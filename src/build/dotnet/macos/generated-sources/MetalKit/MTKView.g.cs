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
	/// <summary>A <see cref="T:AppKit.NSView" /> that is Metal-aware.</summary><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/MetalKit/Reference/MTKView_ClassReference/index.html">Apple documentation for <c>MTKView</c></related>
	[Register("MTKView", true)]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe partial class MTKView : global::AppKit.NSView, INSCoding, global::CoreAnimation.ICALayerDelegate {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selActionForLayer_ForKey_X = "actionForLayer:forKey:";
		static readonly NativeHandle selActionForLayer_ForKey_XHandle = Selector.GetHandle ("actionForLayer:forKey:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAutoResizeDrawableX = "autoResizeDrawable";
		static readonly NativeHandle selAutoResizeDrawableXHandle = Selector.GetHandle ("autoResizeDrawable");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selClearColorX = "clearColor";
		static readonly NativeHandle selClearColorXHandle = Selector.GetHandle ("clearColor");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selClearDepthX = "clearDepth";
		static readonly NativeHandle selClearDepthXHandle = Selector.GetHandle ("clearDepth");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selClearStencilX = "clearStencil";
		static readonly NativeHandle selClearStencilXHandle = Selector.GetHandle ("clearStencil");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selColorPixelFormatX = "colorPixelFormat";
		static readonly NativeHandle selColorPixelFormatXHandle = Selector.GetHandle ("colorPixelFormat");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selColorspaceX = "colorspace";
		static readonly NativeHandle selColorspaceXHandle = Selector.GetHandle ("colorspace");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCurrentDrawableX = "currentDrawable";
		static readonly NativeHandle selCurrentDrawableXHandle = Selector.GetHandle ("currentDrawable");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCurrentMTL4RenderPassDescriptorX = "currentMTL4RenderPassDescriptor";
		static readonly NativeHandle selCurrentMTL4RenderPassDescriptorXHandle = Selector.GetHandle ("currentMTL4RenderPassDescriptor");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCurrentRenderPassDescriptorX = "currentRenderPassDescriptor";
		static readonly NativeHandle selCurrentRenderPassDescriptorXHandle = Selector.GetHandle ("currentRenderPassDescriptor");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDelegateX = "delegate";
		static readonly NativeHandle selDelegateXHandle = Selector.GetHandle ("delegate");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDepthStencilAttachmentTextureUsageX = "depthStencilAttachmentTextureUsage";
		static readonly NativeHandle selDepthStencilAttachmentTextureUsageXHandle = Selector.GetHandle ("depthStencilAttachmentTextureUsage");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDepthStencilPixelFormatX = "depthStencilPixelFormat";
		static readonly NativeHandle selDepthStencilPixelFormatXHandle = Selector.GetHandle ("depthStencilPixelFormat");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDepthStencilStorageModeX = "depthStencilStorageMode";
		static readonly NativeHandle selDepthStencilStorageModeXHandle = Selector.GetHandle ("depthStencilStorageMode");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDepthStencilTextureX = "depthStencilTexture";
		static readonly NativeHandle selDepthStencilTextureXHandle = Selector.GetHandle ("depthStencilTexture");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDeviceX = "device";
		static readonly NativeHandle selDeviceXHandle = Selector.GetHandle ("device");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDisplayLayer_X = "displayLayer:";
		static readonly NativeHandle selDisplayLayer_XHandle = Selector.GetHandle ("displayLayer:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDrawX = "draw";
		static readonly NativeHandle selDrawXHandle = Selector.GetHandle ("draw");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDrawLayer_InContext_X = "drawLayer:inContext:";
		static readonly NativeHandle selDrawLayer_InContext_XHandle = Selector.GetHandle ("drawLayer:inContext:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDrawableSizeX = "drawableSize";
		static readonly NativeHandle selDrawableSizeXHandle = Selector.GetHandle ("drawableSize");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selEnableSetNeedsDisplayX = "enableSetNeedsDisplay";
		static readonly NativeHandle selEnableSetNeedsDisplayXHandle = Selector.GetHandle ("enableSetNeedsDisplay");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selEncodeWithCoder_X = "encodeWithCoder:";
		static readonly NativeHandle selEncodeWithCoder_XHandle = Selector.GetHandle ("encodeWithCoder:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFramebufferOnlyX = "framebufferOnly";
		static readonly NativeHandle selFramebufferOnlyXHandle = Selector.GetHandle ("framebufferOnly");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithCoder_X = "initWithCoder:";
		static readonly NativeHandle selInitWithCoder_XHandle = Selector.GetHandle ("initWithCoder:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithFrame_Device_X = "initWithFrame:device:";
		static readonly NativeHandle selInitWithFrame_Device_XHandle = Selector.GetHandle ("initWithFrame:device:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsPausedX = "isPaused";
		static readonly NativeHandle selIsPausedXHandle = Selector.GetHandle ("isPaused");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLayerWillDraw_X = "layerWillDraw:";
		static readonly NativeHandle selLayerWillDraw_XHandle = Selector.GetHandle ("layerWillDraw:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLayoutSublayersOfLayer_X = "layoutSublayersOfLayer:";
		static readonly NativeHandle selLayoutSublayersOfLayer_XHandle = Selector.GetHandle ("layoutSublayersOfLayer:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMultisampleColorAttachmentTextureUsageX = "multisampleColorAttachmentTextureUsage";
		static readonly NativeHandle selMultisampleColorAttachmentTextureUsageXHandle = Selector.GetHandle ("multisampleColorAttachmentTextureUsage");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMultisampleColorTextureX = "multisampleColorTexture";
		static readonly NativeHandle selMultisampleColorTextureXHandle = Selector.GetHandle ("multisampleColorTexture");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPreferredDeviceX = "preferredDevice";
		static readonly NativeHandle selPreferredDeviceXHandle = Selector.GetHandle ("preferredDevice");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPreferredDrawableSizeX = "preferredDrawableSize";
		static readonly NativeHandle selPreferredDrawableSizeXHandle = Selector.GetHandle ("preferredDrawableSize");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPreferredFramesPerSecondX = "preferredFramesPerSecond";
		static readonly NativeHandle selPreferredFramesPerSecondXHandle = Selector.GetHandle ("preferredFramesPerSecond");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPresentsWithTransactionX = "presentsWithTransaction";
		static readonly NativeHandle selPresentsWithTransactionXHandle = Selector.GetHandle ("presentsWithTransaction");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selReleaseDrawablesX = "releaseDrawables";
		static readonly NativeHandle selReleaseDrawablesXHandle = Selector.GetHandle ("releaseDrawables");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selResidencySetX = "residencySet";
		static readonly NativeHandle selResidencySetXHandle = Selector.GetHandle ("residencySet");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSampleCountX = "sampleCount";
		static readonly NativeHandle selSampleCountXHandle = Selector.GetHandle ("sampleCount");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAutoResizeDrawable_X = "setAutoResizeDrawable:";
		static readonly NativeHandle selSetAutoResizeDrawable_XHandle = Selector.GetHandle ("setAutoResizeDrawable:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetClearColor_X = "setClearColor:";
		static readonly NativeHandle selSetClearColor_XHandle = Selector.GetHandle ("setClearColor:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetClearDepth_X = "setClearDepth:";
		static readonly NativeHandle selSetClearDepth_XHandle = Selector.GetHandle ("setClearDepth:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetClearStencil_X = "setClearStencil:";
		static readonly NativeHandle selSetClearStencil_XHandle = Selector.GetHandle ("setClearStencil:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetColorPixelFormat_X = "setColorPixelFormat:";
		static readonly NativeHandle selSetColorPixelFormat_XHandle = Selector.GetHandle ("setColorPixelFormat:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetColorspace_X = "setColorspace:";
		static readonly NativeHandle selSetColorspace_XHandle = Selector.GetHandle ("setColorspace:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetDelegate_X = "setDelegate:";
		static readonly NativeHandle selSetDelegate_XHandle = Selector.GetHandle ("setDelegate:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetDepthStencilAttachmentTextureUsage_X = "setDepthStencilAttachmentTextureUsage:";
		static readonly NativeHandle selSetDepthStencilAttachmentTextureUsage_XHandle = Selector.GetHandle ("setDepthStencilAttachmentTextureUsage:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetDepthStencilPixelFormat_X = "setDepthStencilPixelFormat:";
		static readonly NativeHandle selSetDepthStencilPixelFormat_XHandle = Selector.GetHandle ("setDepthStencilPixelFormat:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetDepthStencilStorageMode_X = "setDepthStencilStorageMode:";
		static readonly NativeHandle selSetDepthStencilStorageMode_XHandle = Selector.GetHandle ("setDepthStencilStorageMode:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetDevice_X = "setDevice:";
		static readonly NativeHandle selSetDevice_XHandle = Selector.GetHandle ("setDevice:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetDrawableSize_X = "setDrawableSize:";
		static readonly NativeHandle selSetDrawableSize_XHandle = Selector.GetHandle ("setDrawableSize:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetEnableSetNeedsDisplay_X = "setEnableSetNeedsDisplay:";
		static readonly NativeHandle selSetEnableSetNeedsDisplay_XHandle = Selector.GetHandle ("setEnableSetNeedsDisplay:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetFramebufferOnly_X = "setFramebufferOnly:";
		static readonly NativeHandle selSetFramebufferOnly_XHandle = Selector.GetHandle ("setFramebufferOnly:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetMultisampleColorAttachmentTextureUsage_X = "setMultisampleColorAttachmentTextureUsage:";
		static readonly NativeHandle selSetMultisampleColorAttachmentTextureUsage_XHandle = Selector.GetHandle ("setMultisampleColorAttachmentTextureUsage:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetPaused_X = "setPaused:";
		static readonly NativeHandle selSetPaused_XHandle = Selector.GetHandle ("setPaused:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetPreferredFramesPerSecond_X = "setPreferredFramesPerSecond:";
		static readonly NativeHandle selSetPreferredFramesPerSecond_XHandle = Selector.GetHandle ("setPreferredFramesPerSecond:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetPresentsWithTransaction_X = "setPresentsWithTransaction:";
		static readonly NativeHandle selSetPresentsWithTransaction_XHandle = Selector.GetHandle ("setPresentsWithTransaction:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetSampleCount_X = "setSampleCount:";
		static readonly NativeHandle selSetSampleCount_XHandle = Selector.GetHandle ("setSampleCount:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("MTKView");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		/// <summary>Creates a new <see cref="MTKView" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public MTKView () : base (NSObjectFlag.Empty)
		{
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, global::ObjCRuntime.Selector.Init), "init");
			} else {
				unsafe {
				var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
				InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, global::ObjCRuntime.Selector.Init), "init");
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
		public MTKView (NSCoder coder) : base (NSObjectFlag.Empty)
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
		protected MTKView (NSObjectFlag t) : base (t)
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
		protected internal MTKView (NativeHandle handle) : base (handle)
		{
		}

		[Export ("initWithFrame:device:")]
		[DesignatedInitializer]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public MTKView (CGRect frameRect, global::Metal.IMTLDevice? device)
			: base (NSObjectFlag.Empty)
		{
			var device__handle__ = device.GetHandle ();
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_CGRect_NativeHandle (this.Handle, selInitWithFrame_Device_XHandle, frameRect, device__handle__), "initWithFrame:device:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_CGRect_NativeHandle (&__objc_super__, selInitWithFrame_Device_XHandle, frameRect, device__handle__), "initWithFrame:device:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (device);
		}
		/// <param name="layer">To be added.</param><param name="eventKey">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("actionForLayer:forKey:")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject? ActionForLayer (global::CoreAnimation.CALayer layer, string eventKey)
		{
			var layer__handle__ = layer!.GetNonNullHandle (nameof (layer));
			if (eventKey is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (eventKey));
			var nseventKey = CFString.CreateNative (eventKey);
			NSObject? ret;
			if (IsDirectBinding) {
				ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selActionForLayer_ForKey_XHandle, layer__handle__, nseventKey), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selActionForLayer_ForKey_XHandle, layer__handle__, nseventKey), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (layer);
			CFString.ReleaseNative (nseventKey);
			return ret!;
		}
		/// <param name="layer">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("displayLayer:")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DisplayLayer (global::CoreAnimation.CALayer layer)
		{
			var layer__handle__ = layer!.GetNonNullHandle (nameof (layer));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selDisplayLayer_XHandle, layer__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selDisplayLayer_XHandle, layer__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (layer);
		}
		[Export ("draw")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Draw ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selDrawXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selDrawXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		/// <param name="layer">To be added.</param><param name="context">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("drawLayer:inContext:")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DrawLayer (global::CoreAnimation.CALayer layer, CGContext context)
		{
			var layer__handle__ = layer!.GetNonNullHandle (nameof (layer));
			var context__handle__ = context!.GetNonNullHandle (nameof (context));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selDrawLayer_InContext_XHandle, layer__handle__, context.Handle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selDrawLayer_InContext_XHandle, layer__handle__, context.Handle);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (layer);
			GC.KeepAlive (context);
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
		public new virtual void EncodeTo (NSCoder encoder)
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
		/// <param name="layer">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("layoutSublayersOfLayer:")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void LayoutSublayersOfLayer (global::CoreAnimation.CALayer layer)
		{
			var layer__handle__ = layer!.GetNonNullHandle (nameof (layer));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selLayoutSublayersOfLayer_XHandle, layer__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selLayoutSublayersOfLayer_XHandle, layer__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (layer);
		}
		[Export ("releaseDrawables")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ReleaseDrawables ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selReleaseDrawablesXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selReleaseDrawablesXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		/// <param name="layer">The layer that will be redrawn.</param><summary>Method that is called when <paramref name="layer" /> is about to be drawn.</summary><remarks>To be added.</remarks>
		[Export ("layerWillDraw:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillDrawLayer (global::CoreAnimation.CALayer layer)
		{
			var layer__handle__ = layer!.GetNonNullHandle (nameof (layer));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selLayerWillDraw_XHandle, layer__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selLayerWillDraw_XHandle, layer__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (layer);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool AutoResizeDrawable {
			[Export ("autoResizeDrawable")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selAutoResizeDrawableXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selAutoResizeDrawableXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setAutoResizeDrawable:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetAutoResizeDrawable_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetAutoResizeDrawable_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::Metal.MTLClearColor ClearColor {
			[Export ("clearColor", ArgumentSemantic.Assign)]
			get {
				global::Metal.MTLClearColor ret;
				if (IsDirectBinding) {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						ret = global::ObjCRuntime.Messaging.MTLClearColor_objc_msgSend (this.Handle, selClearColorXHandle);
					} else {
						ret = global::ObjCRuntime.Messaging.MTLClearColor_objc_msgSend_stret (this.Handle, selClearColorXHandle);
					}
				} else {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.MTLClearColor_objc_msgSendSuper (&__objc_super__, selClearColorXHandle);
							GC.KeepAlive (this);
						}
					} else {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.MTLClearColor_objc_msgSendSuper_stret (&__objc_super__, selClearColorXHandle);
							GC.KeepAlive (this);
						}
					}
				}
				return ret!;
			}
			[Export ("setClearColor:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_MTLClearColor (this.Handle, selSetClearColor_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_MTLClearColor (&__objc_super__, selSetClearColor_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual double ClearDepth {
			[Export ("clearDepth")]
			get {
				double ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.Double_objc_msgSend (this.Handle, selClearDepthXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.Double_objc_msgSendSuper (&__objc_super__, selClearDepthXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setClearDepth:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_Double (this.Handle, selSetClearDepth_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_Double (&__objc_super__, selSetClearDepth_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual uint ClearStencil {
			[Export ("clearStencil")]
			get {
				uint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.UInt32_objc_msgSend (this.Handle, selClearStencilXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.UInt32_objc_msgSendSuper (&__objc_super__, selClearStencilXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setClearStencil:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_UInt32 (this.Handle, selSetClearStencil_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UInt32 (&__objc_super__, selSetClearStencil_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::Metal.MTLPixelFormat ColorPixelFormat {
			[Export ("colorPixelFormat", ArgumentSemantic.Assign)]
			get {
				global::Metal.MTLPixelFormat ret;
				if (IsDirectBinding) {
					ret = (MTLPixelFormat) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selColorPixelFormatXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (MTLPixelFormat) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selColorPixelFormatXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setColorPixelFormat:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (this.Handle, selSetColorPixelFormat_XHandle, (UIntPtr) (ulong) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UIntPtr (&__objc_super__, selSetColorPixelFormat_XHandle, (UIntPtr) (ulong) value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public virtual CGColorSpace? ColorSpace {
			[Export ("colorspace", ArgumentSemantic.Assign)]
			get {
				CGColorSpace ret;
				if (IsDirectBinding) {
					ret = Runtime.GetINativeObject<global::CoreGraphics.CGColorSpace> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selColorspaceXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = Runtime.GetINativeObject<global::CoreGraphics.CGColorSpace> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selColorspaceXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setColorspace:", ArgumentSemantic.Assign)]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetColorspace_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetColorspace_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::CoreAnimation.ICAMetalDrawable? CurrentDrawable {
			[Export ("currentDrawable")]
			get {
				global::CoreAnimation.ICAMetalDrawable? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetINativeObject<global::CoreAnimation.ICAMetalDrawable> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selCurrentDrawableXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetINativeObject<global::CoreAnimation.ICAMetalDrawable> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selCurrentDrawableXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		public virtual global::Metal.MTL4RenderPassDescriptor? CurrentMtl4RenderPassDescriptor {
			[Export ("currentMTL4RenderPassDescriptor")]
			get {
				global::Metal.MTL4RenderPassDescriptor? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::Metal.MTL4RenderPassDescriptor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selCurrentMTL4RenderPassDescriptorXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<global::Metal.MTL4RenderPassDescriptor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selCurrentMTL4RenderPassDescriptorXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::Metal.MTLRenderPassDescriptor? CurrentRenderPassDescriptor {
			[Export ("currentRenderPassDescriptor")]
			get {
				global::Metal.MTLRenderPassDescriptor? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::Metal.MTLRenderPassDescriptor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selCurrentRenderPassDescriptorXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<global::Metal.MTLRenderPassDescriptor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selCurrentRenderPassDescriptorXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		/// <summary>An instance of the MetalKit.IMTKViewDelegate model class which acts as the class delegate.</summary><value>The instance of the MetalKit.IMTKViewDelegate model class</value><remarks><para>The delegate instance assigned to this object will be used to handle events or provide data on demand to this class.</para><para>When setting the Delegate or WeakDelegate values events will be delivered to the specified instance instead of being delivered to the C#-style events</para><para>This is the strongly typed version of the object, developers should use the WeakDelegate property instead if they want to merely assign a class derived from NSObject that has been decorated with [Export] attributes.</para></remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public IMTKViewDelegate? Delegate {
			get {
				return (WeakDelegate as IMTKViewDelegate)!;
			}
			set {
				var rvalue = value as NSObject;
				if (!(value is null) && rvalue is null)
					throw new ArgumentException ("The object passed of type " + value.GetType () + " does not derive from NSObject");
				WeakDelegate = rvalue;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public virtual global::Metal.MTLTextureUsage DepthStencilAttachmentTextureUsage {
			[Export ("depthStencilAttachmentTextureUsage", ArgumentSemantic.Assign)]
			get {
				global::Metal.MTLTextureUsage ret;
				if (IsDirectBinding) {
					ret = (MTLTextureUsage) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selDepthStencilAttachmentTextureUsageXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (MTLTextureUsage) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selDepthStencilAttachmentTextureUsageXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setDepthStencilAttachmentTextureUsage:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (this.Handle, selSetDepthStencilAttachmentTextureUsage_XHandle, (UIntPtr) (ulong) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UIntPtr (&__objc_super__, selSetDepthStencilAttachmentTextureUsage_XHandle, (UIntPtr) (ulong) value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::Metal.MTLPixelFormat DepthStencilPixelFormat {
			[Export ("depthStencilPixelFormat", ArgumentSemantic.Assign)]
			get {
				global::Metal.MTLPixelFormat ret;
				if (IsDirectBinding) {
					ret = (MTLPixelFormat) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selDepthStencilPixelFormatXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (MTLPixelFormat) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selDepthStencilPixelFormatXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setDepthStencilPixelFormat:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (this.Handle, selSetDepthStencilPixelFormat_XHandle, (UIntPtr) (ulong) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UIntPtr (&__objc_super__, selSetDepthStencilPixelFormat_XHandle, (UIntPtr) (ulong) value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		public virtual global::Metal.MTLStorageMode DepthStencilStorageMode {
			[Export ("depthStencilStorageMode", ArgumentSemantic.Assign)]
			get {
				global::Metal.MTLStorageMode ret;
				if (IsDirectBinding) {
					ret = (MTLStorageMode) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selDepthStencilStorageModeXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (MTLStorageMode) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selDepthStencilStorageModeXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setDepthStencilStorageMode:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (this.Handle, selSetDepthStencilStorageMode_XHandle, (UIntPtr) (ulong) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UIntPtr (&__objc_super__, selSetDepthStencilStorageMode_XHandle, (UIntPtr) (ulong) value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::Metal.IMTLTexture? DepthStencilTexture {
			[Export ("depthStencilTexture")]
			get {
				global::Metal.IMTLTexture? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetINativeObject<global::Metal.IMTLTexture> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selDepthStencilTextureXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetINativeObject<global::Metal.IMTLTexture> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selDepthStencilTextureXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::Metal.IMTLDevice? Device {
			[Export ("device", ArgumentSemantic.Retain)]
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
			[Export ("setDevice:", ArgumentSemantic.Retain)]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetDevice_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetDevice_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGSize DrawableSize {
			[Export ("drawableSize", ArgumentSemantic.Assign)]
			get {
				CGSize ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.CGSize_objc_msgSend (this.Handle, selDrawableSizeXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGSize_objc_msgSendSuper (&__objc_super__, selDrawableSizeXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setDrawableSize:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_CGSize (this.Handle, selSetDrawableSize_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_CGSize (&__objc_super__, selSetDrawableSize_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool EnableSetNeedsDisplay {
			[Export ("enableSetNeedsDisplay")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selEnableSetNeedsDisplayXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selEnableSetNeedsDisplayXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setEnableSetNeedsDisplay:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetEnableSetNeedsDisplay_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetEnableSetNeedsDisplay_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool FramebufferOnly {
			[Export ("framebufferOnly")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selFramebufferOnlyXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selFramebufferOnlyXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setFramebufferOnly:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetFramebufferOnly_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetFramebufferOnly_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public virtual global::Metal.MTLTextureUsage MultisampleColorAttachmentTextureUsage {
			[Export ("multisampleColorAttachmentTextureUsage", ArgumentSemantic.Assign)]
			get {
				global::Metal.MTLTextureUsage ret;
				if (IsDirectBinding) {
					ret = (MTLTextureUsage) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selMultisampleColorAttachmentTextureUsageXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (MTLTextureUsage) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selMultisampleColorAttachmentTextureUsageXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setMultisampleColorAttachmentTextureUsage:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (this.Handle, selSetMultisampleColorAttachmentTextureUsage_XHandle, (UIntPtr) (ulong) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UIntPtr (&__objc_super__, selSetMultisampleColorAttachmentTextureUsage_XHandle, (UIntPtr) (ulong) value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::Metal.IMTLTexture? MultisampleColorTexture {
			[Export ("multisampleColorTexture")]
			get {
				global::Metal.IMTLTexture? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetINativeObject<global::Metal.IMTLTexture> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selMultisampleColorTextureXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetINativeObject<global::Metal.IMTLTexture> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selMultisampleColorTextureXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		/// <summary>Gets or sets a Boolean value that controls whether the draw loop is paused.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool Paused {
			[Export ("isPaused")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsPausedXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsPausedXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setPaused:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetPaused_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetPaused_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public virtual global::Metal.IMTLDevice? PreferredDevice {
			[Export ("preferredDevice")]
			get {
				global::Metal.IMTLDevice? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetINativeObject<global::Metal.IMTLDevice> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selPreferredDeviceXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetINativeObject<global::Metal.IMTLDevice> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selPreferredDeviceXHandle), false)!;
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
		public virtual CGSize PreferredDrawableSize {
			[Export ("preferredDrawableSize")]
			get {
				CGSize ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.CGSize_objc_msgSend (this.Handle, selPreferredDrawableSizeXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGSize_objc_msgSendSuper (&__objc_super__, selPreferredDrawableSizeXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint PreferredFramesPerSecond {
			[Export ("preferredFramesPerSecond", ArgumentSemantic.Assign)]
			get {
				nint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selPreferredFramesPerSecondXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selPreferredFramesPerSecondXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setPreferredFramesPerSecond:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetPreferredFramesPerSecond_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, selSetPreferredFramesPerSecond_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool PresentsWithTransaction {
			[Export ("presentsWithTransaction")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selPresentsWithTransactionXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selPresentsWithTransactionXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setPresentsWithTransaction:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetPresentsWithTransaction_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetPresentsWithTransaction_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("macos26.4")]
		[SupportedOSPlatform ("ios26.4")]
		[SupportedOSPlatform ("tvos26.4")]
		[SupportedOSPlatform ("maccatalyst26.4")]
		public virtual global::Metal.IMTLResidencySet ResidencySet {
			[Export ("residencySet")]
			get {
				global::Metal.IMTLResidencySet? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetINativeObject<global::Metal.IMTLResidencySet> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selResidencySetXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetINativeObject<global::Metal.IMTLResidencySet> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selResidencySetXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nuint SampleCount {
			[Export ("sampleCount")]
			get {
				nuint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selSampleCountXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selSampleCountXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setSampleCount:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (this.Handle, selSetSampleCount_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UIntPtr (&__objc_super__, selSetSampleCount_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		object? __mt_WeakDelegate_var;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject? WeakDelegate {
			[Export ("delegate", ArgumentSemantic.Weak)]
			get {
				NSObject? ret;
				if (IsDirectBinding) {
					ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selDelegateXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selDelegateXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				MarkDirty ();
				__mt_WeakDelegate_var = ret;
				return ret!;
			}
			[Export ("setDelegate:", ArgumentSemantic.Weak)]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetDelegate_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetDelegate_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
				MarkDirty ();
				__mt_WeakDelegate_var = value;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_WeakDelegate_var = null;
			}
		}
	} /* class MTKView */
}
