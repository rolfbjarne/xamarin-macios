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
namespace SceneKit {
	/// <summary>Renders an SCNScene into an OpenGL context.</summary><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/SceneKit/Reference/SCNRenderer_Class/index.html">Apple documentation for <c>SCNRenderer</c></related>
	[Register("SCNRenderer", true)]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe partial class SCNRenderer : NSObject, ISCNSceneRenderer, ISCNTechniqueSupport {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAudioEngineX = "audioEngine";
		static readonly NativeHandle selAudioEngineXHandle = Selector.GetHandle ("audioEngine");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAudioEnvironmentNodeX = "audioEnvironmentNode";
		static readonly NativeHandle selAudioEnvironmentNodeXHandle = Selector.GetHandle ("audioEnvironmentNode");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAudioListenerX = "audioListener";
		static readonly NativeHandle selAudioListenerXHandle = Selector.GetHandle ("audioListener");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAutoenablesDefaultLightingX = "autoenablesDefaultLighting";
		static readonly NativeHandle selAutoenablesDefaultLightingXHandle = Selector.GetHandle ("autoenablesDefaultLighting");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selColorPixelFormatX = "colorPixelFormat";
		static readonly NativeHandle selColorPixelFormatXHandle = Selector.GetHandle ("colorPixelFormat");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCommandQueueX = "commandQueue";
		static readonly NativeHandle selCommandQueueXHandle = Selector.GetHandle ("commandQueue");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selContextX = "context";
		static readonly NativeHandle selContextXHandle = Selector.GetHandle ("context");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCurrentRenderCommandEncoderX = "currentRenderCommandEncoder";
		static readonly NativeHandle selCurrentRenderCommandEncoderXHandle = Selector.GetHandle ("currentRenderCommandEncoder");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCurrentRenderPassDescriptorX = "currentRenderPassDescriptor";
		static readonly NativeHandle selCurrentRenderPassDescriptorXHandle = Selector.GetHandle ("currentRenderPassDescriptor");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCurrentTimeX = "currentTime";
		static readonly NativeHandle selCurrentTimeXHandle = Selector.GetHandle ("currentTime");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCurrentViewportX = "currentViewport";
		static readonly NativeHandle selCurrentViewportXHandle = Selector.GetHandle ("currentViewport");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDebugOptionsX = "debugOptions";
		static readonly NativeHandle selDebugOptionsXHandle = Selector.GetHandle ("debugOptions");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDelegateX = "delegate";
		static readonly NativeHandle selDelegateXHandle = Selector.GetHandle ("delegate");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDepthPixelFormatX = "depthPixelFormat";
		static readonly NativeHandle selDepthPixelFormatXHandle = Selector.GetHandle ("depthPixelFormat");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDeviceX = "device";
		static readonly NativeHandle selDeviceXHandle = Selector.GetHandle ("device");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selHitTest_Options_X = "hitTest:options:";
		static readonly NativeHandle selHitTest_Options_XHandle = Selector.GetHandle ("hitTest:options:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsJitteringEnabledX = "isJitteringEnabled";
		static readonly NativeHandle selIsJitteringEnabledXHandle = Selector.GetHandle ("isJitteringEnabled");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsNodeInsideFrustum_WithPointOfView_X = "isNodeInsideFrustum:withPointOfView:";
		static readonly NativeHandle selIsNodeInsideFrustum_WithPointOfView_XHandle = Selector.GetHandle ("isNodeInsideFrustum:withPointOfView:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsPlayingX = "isPlaying";
		static readonly NativeHandle selIsPlayingXHandle = Selector.GetHandle ("isPlaying");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsTemporalAntialiasingEnabledX = "isTemporalAntialiasingEnabled";
		static readonly NativeHandle selIsTemporalAntialiasingEnabledXHandle = Selector.GetHandle ("isTemporalAntialiasingEnabled");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLoopsX = "loops";
		static readonly NativeHandle selLoopsXHandle = Selector.GetHandle ("loops");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selNextFrameTimeX = "nextFrameTime";
		static readonly NativeHandle selNextFrameTimeXHandle = Selector.GetHandle ("nextFrameTime");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selNodesInsideFrustumWithPointOfView_X = "nodesInsideFrustumWithPointOfView:";
		static readonly NativeHandle selNodesInsideFrustumWithPointOfView_XHandle = Selector.GetHandle ("nodesInsideFrustumWithPointOfView:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selOverlaySKSceneX = "overlaySKScene";
		static readonly NativeHandle selOverlaySKSceneXHandle = Selector.GetHandle ("overlaySKScene");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPointOfViewX = "pointOfView";
		static readonly NativeHandle selPointOfViewXHandle = Selector.GetHandle ("pointOfView");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPrepareObject_ShouldAbortBlock_X = "prepareObject:shouldAbortBlock:";
		static readonly NativeHandle selPrepareObject_ShouldAbortBlock_XHandle = Selector.GetHandle ("prepareObject:shouldAbortBlock:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPrepareObjects_WithCompletionHandler_X = "prepareObjects:withCompletionHandler:";
		static readonly NativeHandle selPrepareObjects_WithCompletionHandler_XHandle = Selector.GetHandle ("prepareObjects:withCompletionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPresentScene_WithTransition_IncomingPointOfView_CompletionHandler_X = "presentScene:withTransition:incomingPointOfView:completionHandler:";
		static readonly NativeHandle selPresentScene_WithTransition_IncomingPointOfView_CompletionHandler_XHandle = Selector.GetHandle ("presentScene:withTransition:incomingPointOfView:completionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selProjectPoint_X = "projectPoint:";
		static readonly NativeHandle selProjectPoint_XHandle = Selector.GetHandle ("projectPoint:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRenderX = "render";
		static readonly NativeHandle selRenderXHandle = Selector.GetHandle ("render");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRenderAtTime_X = "renderAtTime:";
		static readonly NativeHandle selRenderAtTime_XHandle = Selector.GetHandle ("renderAtTime:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRenderAtTime_Viewport_CommandBuffer_PassDescriptor_X = "renderAtTime:viewport:commandBuffer:passDescriptor:";
		static readonly NativeHandle selRenderAtTime_Viewport_CommandBuffer_PassDescriptor_XHandle = Selector.GetHandle ("renderAtTime:viewport:commandBuffer:passDescriptor:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRenderWithViewport_CommandBuffer_PassDescriptor_X = "renderWithViewport:commandBuffer:passDescriptor:";
		static readonly NativeHandle selRenderWithViewport_CommandBuffer_PassDescriptor_XHandle = Selector.GetHandle ("renderWithViewport:commandBuffer:passDescriptor:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRendererWithContext_Options_X = "rendererWithContext:options:";
		static readonly NativeHandle selRendererWithContext_Options_XHandle = Selector.GetHandle ("rendererWithContext:options:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRendererWithDevice_Options_X = "rendererWithDevice:options:";
		static readonly NativeHandle selRendererWithDevice_Options_XHandle = Selector.GetHandle ("rendererWithDevice:options:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRenderingAPIX = "renderingAPI";
		static readonly NativeHandle selRenderingAPIXHandle = Selector.GetHandle ("renderingAPI");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSceneX = "scene";
		static readonly NativeHandle selSceneXHandle = Selector.GetHandle ("scene");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSceneTimeX = "sceneTime";
		static readonly NativeHandle selSceneTimeXHandle = Selector.GetHandle ("sceneTime");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAudioListener_X = "setAudioListener:";
		static readonly NativeHandle selSetAudioListener_XHandle = Selector.GetHandle ("setAudioListener:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAutoenablesDefaultLighting_X = "setAutoenablesDefaultLighting:";
		static readonly NativeHandle selSetAutoenablesDefaultLighting_XHandle = Selector.GetHandle ("setAutoenablesDefaultLighting:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetCurrentTime_X = "setCurrentTime:";
		static readonly NativeHandle selSetCurrentTime_XHandle = Selector.GetHandle ("setCurrentTime:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetDebugOptions_X = "setDebugOptions:";
		static readonly NativeHandle selSetDebugOptions_XHandle = Selector.GetHandle ("setDebugOptions:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetDelegate_X = "setDelegate:";
		static readonly NativeHandle selSetDelegate_XHandle = Selector.GetHandle ("setDelegate:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetJitteringEnabled_X = "setJitteringEnabled:";
		static readonly NativeHandle selSetJitteringEnabled_XHandle = Selector.GetHandle ("setJitteringEnabled:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetLoops_X = "setLoops:";
		static readonly NativeHandle selSetLoops_XHandle = Selector.GetHandle ("setLoops:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetOverlaySKScene_X = "setOverlaySKScene:";
		static readonly NativeHandle selSetOverlaySKScene_XHandle = Selector.GetHandle ("setOverlaySKScene:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetPlaying_X = "setPlaying:";
		static readonly NativeHandle selSetPlaying_XHandle = Selector.GetHandle ("setPlaying:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetPointOfView_X = "setPointOfView:";
		static readonly NativeHandle selSetPointOfView_XHandle = Selector.GetHandle ("setPointOfView:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetScene_X = "setScene:";
		static readonly NativeHandle selSetScene_XHandle = Selector.GetHandle ("setScene:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetSceneTime_X = "setSceneTime:";
		static readonly NativeHandle selSetSceneTime_XHandle = Selector.GetHandle ("setSceneTime:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetShowsStatistics_X = "setShowsStatistics:";
		static readonly NativeHandle selSetShowsStatistics_XHandle = Selector.GetHandle ("setShowsStatistics:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetTechnique_X = "setTechnique:";
		static readonly NativeHandle selSetTechnique_XHandle = Selector.GetHandle ("setTechnique:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetTemporalAntialiasingEnabled_X = "setTemporalAntialiasingEnabled:";
		static readonly NativeHandle selSetTemporalAntialiasingEnabled_XHandle = Selector.GetHandle ("setTemporalAntialiasingEnabled:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetUsesReverseZ_X = "setUsesReverseZ:";
		static readonly NativeHandle selSetUsesReverseZ_XHandle = Selector.GetHandle ("setUsesReverseZ:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selShowsStatisticsX = "showsStatistics";
		static readonly NativeHandle selShowsStatisticsXHandle = Selector.GetHandle ("showsStatistics");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSnapshotAtTime_WithSize_AntialiasingMode_X = "snapshotAtTime:withSize:antialiasingMode:";
		static readonly NativeHandle selSnapshotAtTime_WithSize_AntialiasingMode_XHandle = Selector.GetHandle ("snapshotAtTime:withSize:antialiasingMode:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selStencilPixelFormatX = "stencilPixelFormat";
		static readonly NativeHandle selStencilPixelFormatXHandle = Selector.GetHandle ("stencilPixelFormat");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTechniqueX = "technique";
		static readonly NativeHandle selTechniqueXHandle = Selector.GetHandle ("technique");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selUnprojectPoint_X = "unprojectPoint:";
		static readonly NativeHandle selUnprojectPoint_XHandle = Selector.GetHandle ("unprojectPoint:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selUpdateAtTime_X = "updateAtTime:";
		static readonly NativeHandle selUpdateAtTime_XHandle = Selector.GetHandle ("updateAtTime:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selUpdateProbes_AtTime_X = "updateProbes:atTime:";
		static readonly NativeHandle selUpdateProbes_AtTime_XHandle = Selector.GetHandle ("updateProbes:atTime:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selUsesReverseZX = "usesReverseZ";
		static readonly NativeHandle selUsesReverseZXHandle = Selector.GetHandle ("usesReverseZ");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selWorkingColorSpaceX = "workingColorSpace";
		static readonly NativeHandle selWorkingColorSpaceXHandle = Selector.GetHandle ("workingColorSpace");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("SCNRenderer");
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
		protected SCNRenderer (NSObjectFlag t) : base (t)
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
		protected internal SCNRenderer (NativeHandle handle) : base (handle)
		{
		}

		[Export ("rendererWithContext:options:")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SCNRenderer FromContext (nint context, NSDictionary? options)
		{
			var options__handle__ = options.GetHandle ();
			SCNRenderer? ret;
			ret =  Runtime.GetNSObject<SCNRenderer> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_IntPtr_NativeHandle (class_ptr, selRendererWithContext_Options_XHandle, context, options__handle__), false)!;
			GC.KeepAlive (options);
			return ret!;
		}
		[Export ("rendererWithDevice:options:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SCNRenderer FromDevice (global::Metal.IMTLDevice? device, NSDictionary? options)
		{
			var device__handle__ = device.GetHandle ();
			var options__handle__ = options.GetHandle ();
			SCNRenderer? ret;
			ret =  Runtime.GetNSObject<SCNRenderer> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (class_ptr, selRendererWithDevice_Options_XHandle, device__handle__, options__handle__), false)!;
			GC.KeepAlive (device);
			GC.KeepAlive (options);
			return ret!;
		}
		/// <summary>Returns the nodes that are contained in the frustrum that is defined by the provided node.</summary>
		[Export ("nodesInsideFrustumWithPointOfView:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual SCNNode[] GetNodesInsideFrustum (SCNNode pointOfView)
		{
			var pointOfView__handle__ = pointOfView!.GetNonNullHandle (nameof (pointOfView));
			SCNNode[]? ret;
			if (IsDirectBinding) {
				ret = CFArray.ArrayFromHandle<SCNNode>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selNodesInsideFrustumWithPointOfView_XHandle, pointOfView__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFArray.ArrayFromHandle<SCNNode>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selNodesInsideFrustumWithPointOfView_XHandle, pointOfView__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (pointOfView);
			return ret!;
		}
		[Export ("snapshotAtTime:withSize:antialiasingMode:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::AppKit.NSImage GetSnapshot (double time, CGSize size, SCNAntialiasingMode antialiasingMode)
		{
			global::AppKit.NSImage ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<global::AppKit.NSImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_Double_CGSize_UIntPtr (this.Handle, selSnapshotAtTime_WithSize_AntialiasingMode_XHandle, time, size, (UIntPtr) (ulong) antialiasingMode), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<global::AppKit.NSImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_Double_CGSize_UIntPtr (&__objc_super__, selSnapshotAtTime_WithSize_AntialiasingMode_XHandle, time, size, (UIntPtr) (ulong) antialiasingMode), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		/// <param name="thePoint">To be added.</param><param name="options">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("hitTest:options:")]
		[EditorBrowsable (EditorBrowsableState.Never)]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual SCNHitTestResult[] HitTest (CGPoint thePoint, NSDictionary? options)
		{
			var options__handle__ = options.GetHandle ();
			SCNHitTestResult[]? ret;
			if (IsDirectBinding) {
				ret = CFArray.ArrayFromHandle<SCNHitTestResult>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_CGPoint_NativeHandle (this.Handle, selHitTest_Options_XHandle, thePoint, options__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFArray.ArrayFromHandle<SCNHitTestResult>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_CGPoint_NativeHandle (&__objc_super__, selHitTest_Options_XHandle, thePoint, options__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (options);
			return ret!;
		}
		/// <param name="thePoint">To be added.</param><param name="options">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public SCNHitTestResult[] HitTest (CGPoint thePoint, SCNHitTestOptions options)
		{
			return HitTest (thePoint, options.GetDictionary ());
		}
		/// <param name="node">To be added.</param><param name="pointOfView">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("isNodeInsideFrustum:withPointOfView:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool IsNodeInsideFrustum (SCNNode node, SCNNode pointOfView)
		{
			var node__handle__ = node!.GetNonNullHandle (nameof (node));
			var pointOfView__handle__ = pointOfView!.GetNonNullHandle (nameof (pointOfView));
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selIsNodeInsideFrustum_WithPointOfView_XHandle, node__handle__, pointOfView__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selIsNodeInsideFrustum_WithPointOfView_XHandle, node__handle__, pointOfView__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (node);
			GC.KeepAlive (pointOfView);
			return ret != 0;
		}
		/// <param name="obj">To be added.</param><param name="abortHandler"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("prepareObject:shouldAbortBlock:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual bool Prepare (NSObject obj, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDFuncArity1V1))]global::System.Func<bool>? abortHandler)
		{
			var obj__handle__ = obj!.GetNonNullHandle (nameof (obj));
			using var block_abortHandler = Trampolines.SDFuncArity1V1.CreateNullableBlock (abortHandler);
			BlockLiteral *block_ptr_abortHandler = null;
			if (abortHandler is not null)
				block_ptr_abortHandler = &block_abortHandler;
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selPrepareObject_ShouldAbortBlock_XHandle, obj__handle__, (IntPtr) block_ptr_abortHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selPrepareObject_ShouldAbortBlock_XHandle, obj__handle__, (IntPtr) block_ptr_abortHandler);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (obj);
			return ret != 0;
		}
		/// <param name="objects">The objects to prepare.</param><param name="completionHandler">A handler that receives <see langword="true" /> if preparation of all scene resources succeeded, or <see langword="false" /> if not.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("prepareObjects:withCompletionHandler:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void Prepare (NSObject[] objects, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V2))]global::System.Action<bool>? completionHandler)
		{
			if (objects is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (objects));
			using var nsa_objects = NSArray.FromNSObjects (objects);
			using var block_completionHandler = Trampolines.SDActionArity1V2.CreateNullableBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = null;
			if (completionHandler is not null)
				block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selPrepareObjects_WithCompletionHandler_XHandle, nsa_objects.Handle, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selPrepareObjects_WithCompletionHandler_XHandle, nsa_objects.Handle, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
		}
		/// <param name="objects">The objects to prepare.</param>
		/// <summary>Prepares the provided objects for rendering on a background thread.</summary>
		/// <returns>
		///           <para class="improve-task-t-return-type-description">A task that represents the asynchronous Prepare operation.  The value of the TResult parameter is of type System.Action&lt;System.Boolean&gt;.</para>
		///         </returns>
		/// <remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<bool> PrepareAsync (NSObject[] objects)
		{
			var tcs = new TaskCompletionSource<bool> ();
			Prepare(objects, (obj_) => {
				tcs.SetResult (obj_!);
			});
			return tcs.Task;
		}
		/// <summary>Displays the provided scene.</summary><param name="scene">The scene to present.</param><param name="transition">The transistion to use to present the scene.</param><param name="pointOfView">The point of view to which to present the scene.</param><param name="completionHandler">A handler to run after the scene is presented.</param>
		[Export ("presentScene:withTransition:incomingPointOfView:completionHandler:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void PresentScene (SCNScene scene, global::SpriteKit.SKTransition transition, SCNNode? pointOfView, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action? completionHandler)
		{
			var scene__handle__ = scene!.GetNonNullHandle (nameof (scene));
			var transition__handle__ = transition!.GetNonNullHandle (nameof (transition));
			var pointOfView__handle__ = pointOfView.GetHandle ();
			using var block_completionHandler = Trampolines.SDAction.CreateNullableBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = null;
			if (completionHandler is not null)
				block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (this.Handle, selPresentScene_WithTransition_IncomingPointOfView_CompletionHandler_XHandle, scene__handle__, transition__handle__, pointOfView__handle__, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, selPresentScene_WithTransition_IncomingPointOfView_CompletionHandler_XHandle, scene__handle__, transition__handle__, pointOfView__handle__, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (scene);
			GC.KeepAlive (transition);
			GC.KeepAlive (pointOfView);
		}
		/// <param name="scene">The scene to present.</param>
		/// <param name="transition">The transistion to use to present the scene.</param>
		/// <param name="pointOfView">The point of view to which to present the scene.</param>
		/// <summary>Displays the provided scene.</summary>
		/// <returns>A task that represents the asynchronous PresentScene operation</returns>
		/// <remarks>
		///           <para copied="true">The PresentSceneAsync method is suitable to be used with C# async by returning control to the caller with a Task representing the operation.</para>
		///           <para copied="true">To be added.</para>
		///         </remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task PresentSceneAsync (SCNScene scene, global::SpriteKit.SKTransition transition, SCNNode? pointOfView)
		{
			var tcs = new TaskCompletionSource<bool> ();
			PresentScene(scene, transition, pointOfView, () => {
				tcs.SetResult (true);
			});
			return tcs.Task;
		}
		/// <param name="point">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("projectPoint:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual SCNVector3 ProjectPoint (SCNVector3 point)
		{
			SCNVector3 ret;
			if (IsDirectBinding) {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					ret = global::ObjCRuntime.Messaging.SCNVector3_objc_msgSend_SCNVector3 (this.Handle, selProjectPoint_XHandle, point);
				} else {
					ret = global::ObjCRuntime.Messaging.SCNVector3_objc_msgSend_stret_SCNVector3 (this.Handle, selProjectPoint_XHandle, point);
				}
			} else {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.SCNVector3_objc_msgSendSuper_SCNVector3 (&__objc_super__, selProjectPoint_XHandle, point);
						GC.KeepAlive (this);
					}
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.SCNVector3_objc_msgSendSuper_stret_SCNVector3 (&__objc_super__, selProjectPoint_XHandle, point);
						GC.KeepAlive (this);
					}
				}
			}
			return ret!;
		}
		[Export ("render")]
		[UnsupportedOSPlatform ("tvos")]
		[ObsoletedOSPlatform ("macos10.11")]
		[ObsoletedOSPlatform ("ios9.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Render ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selRenderXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selRenderXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("renderAtTime:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Render (double timeInSeconds)
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_Double (this.Handle, selRenderAtTime_XHandle, timeInSeconds);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_Double (&__objc_super__, selRenderAtTime_XHandle, timeInSeconds);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("renderAtTime:viewport:commandBuffer:passDescriptor:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Render (double timeInSeconds, CGRect viewport, global::Metal.IMTLCommandBuffer commandBuffer, global::Metal.MTLRenderPassDescriptor renderPassDescriptor)
		{
			var commandBuffer__handle__ = commandBuffer!.GetNonNullHandle (nameof (commandBuffer));
			var renderPassDescriptor__handle__ = renderPassDescriptor!.GetNonNullHandle (nameof (renderPassDescriptor));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_Double_CGRect_NativeHandle_NativeHandle (this.Handle, selRenderAtTime_Viewport_CommandBuffer_PassDescriptor_XHandle, timeInSeconds, viewport, commandBuffer__handle__, renderPassDescriptor__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_Double_CGRect_NativeHandle_NativeHandle (&__objc_super__, selRenderAtTime_Viewport_CommandBuffer_PassDescriptor_XHandle, timeInSeconds, viewport, commandBuffer__handle__, renderPassDescriptor__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (commandBuffer);
			GC.KeepAlive (renderPassDescriptor);
		}
		[Export ("renderWithViewport:commandBuffer:passDescriptor:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Render (CGRect viewport, global::Metal.IMTLCommandBuffer commandBuffer, global::Metal.MTLRenderPassDescriptor renderPassDescriptor)
		{
			var commandBuffer__handle__ = commandBuffer!.GetNonNullHandle (nameof (commandBuffer));
			var renderPassDescriptor__handle__ = renderPassDescriptor!.GetNonNullHandle (nameof (renderPassDescriptor));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_CGRect_NativeHandle_NativeHandle (this.Handle, selRenderWithViewport_CommandBuffer_PassDescriptor_XHandle, viewport, commandBuffer__handle__, renderPassDescriptor__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_CGRect_NativeHandle_NativeHandle (&__objc_super__, selRenderWithViewport_CommandBuffer_PassDescriptor_XHandle, viewport, commandBuffer__handle__, renderPassDescriptor__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (commandBuffer);
			GC.KeepAlive (renderPassDescriptor);
		}
		/// <param name="point">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("unprojectPoint:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual SCNVector3 UnprojectPoint (SCNVector3 point)
		{
			SCNVector3 ret;
			if (IsDirectBinding) {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					ret = global::ObjCRuntime.Messaging.SCNVector3_objc_msgSend_SCNVector3 (this.Handle, selUnprojectPoint_XHandle, point);
				} else {
					ret = global::ObjCRuntime.Messaging.SCNVector3_objc_msgSend_stret_SCNVector3 (this.Handle, selUnprojectPoint_XHandle, point);
				}
			} else {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.SCNVector3_objc_msgSendSuper_SCNVector3 (&__objc_super__, selUnprojectPoint_XHandle, point);
						GC.KeepAlive (this);
					}
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.SCNVector3_objc_msgSendSuper_stret_SCNVector3 (&__objc_super__, selUnprojectPoint_XHandle, point);
						GC.KeepAlive (this);
					}
				}
			}
			return ret!;
		}
		[Export ("updateProbes:atTime:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Update (SCNNode[] lightProbes, double time)
		{
			if (lightProbes is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (lightProbes));
			using var nsa_lightProbes = NSArray.FromNSObjects (lightProbes);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_Double (this.Handle, selUpdateProbes_AtTime_XHandle, nsa_lightProbes.Handle, time);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_Double (&__objc_super__, selUpdateProbes_AtTime_XHandle, nsa_lightProbes.Handle, time);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("updateAtTime:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Update (double time)
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_Double (this.Handle, selUpdateAtTime_XHandle, time);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_Double (&__objc_super__, selUpdateAtTime_XHandle, time);
					GC.KeepAlive (this);
				}
			}
		}
		/// <summary>Returns the audio engine that is used to render sounds in the scene</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual global::AVFoundation.AVAudioEngine AudioEngine {
			[Export ("audioEngine")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				global::AVFoundation.AVAudioEngine? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::AVFoundation.AVAudioEngine> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selAudioEngineXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<global::AVFoundation.AVAudioEngine> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selAudioEngineXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		/// <summary>Returns the audio environment node for the scene.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[DebuggerBrowsable (DebuggerBrowsableState.Never)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual global::AVFoundation.AVAudioEnvironmentNode AudioEnvironmentNode {
			[Export ("audioEnvironmentNode")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				global::AVFoundation.AVAudioEnvironmentNode? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::AVFoundation.AVAudioEnvironmentNode> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selAudioEnvironmentNodeXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<global::AVFoundation.AVAudioEnvironmentNode> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selAudioEnvironmentNodeXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		/// <summary>The node that represents the position of the listener in the scene.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[DebuggerBrowsable (DebuggerBrowsableState.Never)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual SCNNode? AudioListener {
			[Export ("audioListener", ArgumentSemantic.Retain)]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				SCNNode? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<SCNNode> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selAudioListenerXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<SCNNode> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selAudioListenerXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setAudioListener:", ArgumentSemantic.Retain)]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetAudioListener_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetAudioListener_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		public virtual bool AutoenablesDefaultLighting {
			[Export ("autoenablesDefaultLighting")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selAutoenablesDefaultLightingXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selAutoenablesDefaultLightingXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setAutoenablesDefaultLighting:")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetAutoenablesDefaultLighting_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetAutoenablesDefaultLighting_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>Returns the format for color pixels.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual global::Metal.MTLPixelFormat ColorPixelFormat {
			[Export ("colorPixelFormat")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
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
		}
		/// <summary>Returns the command queue.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual global::Metal.IMTLCommandQueue? CommandQueue {
			[Export ("commandQueue")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				global::Metal.IMTLCommandQueue? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetINativeObject<global::Metal.IMTLCommandQueue> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selCommandQueueXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetINativeObject<global::Metal.IMTLCommandQueue> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selCommandQueueXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual nint Context {
			[Export ("context")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				nint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selContextXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selContextXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		/// <summary>Returns the current command encoder that is used for rendering.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual global::Metal.IMTLRenderCommandEncoder? CurrentRenderCommandEncoder {
			[Export ("currentRenderCommandEncoder")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				global::Metal.IMTLRenderCommandEncoder? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetINativeObject<global::Metal.IMTLRenderCommandEncoder> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selCurrentRenderCommandEncoderXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetINativeObject<global::Metal.IMTLRenderCommandEncoder> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selCurrentRenderCommandEncoderXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public virtual global::Metal.MTLRenderPassDescriptor CurrentRenderPassDescriptor {
			[Export ("currentRenderPassDescriptor")]
			[SupportedOSPlatform ("ios14.0")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos14.0")]
			[SupportedOSPlatform ("maccatalyst")]
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
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("macos10.10")]
		[UnsupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		public virtual double CurrentTime {
			[Export ("currentTime")]
			[UnsupportedOSPlatform ("tvos")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[ObsoletedOSPlatform ("macos12.0")]
			[UnsupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			get {
				double ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.Double_objc_msgSend (this.Handle, selCurrentTimeXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.Double_objc_msgSendSuper (&__objc_super__, selCurrentTimeXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setCurrentTime:")]
			[UnsupportedOSPlatform ("tvos")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[ObsoletedOSPlatform ("macos12.0")]
			[UnsupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_Double (this.Handle, selSetCurrentTime_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_Double (&__objc_super__, selSetCurrentTime_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public virtual CGRect CurrentViewport {
			[Export ("currentViewport")]
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				CGRect ret;
				if (IsDirectBinding) {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend (this.Handle, selCurrentViewportXHandle);
					} else {
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret (this.Handle, selCurrentViewportXHandle);
					}
				} else {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper (&__objc_super__, selCurrentViewportXHandle);
							GC.KeepAlive (this);
						}
					} else {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper_stret (&__objc_super__, selCurrentViewportXHandle);
							GC.KeepAlive (this);
						}
					}
				}
				return ret!;
			}
		}
		/// <summary>A value that controls which, if any, debug overlays to show in the rendered output.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual SCNDebugOptions DebugOptions {
			[Export ("debugOptions", ArgumentSemantic.Assign)]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				SCNDebugOptions ret;
				if (IsDirectBinding) {
					ret = (SCNDebugOptions) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selDebugOptionsXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (SCNDebugOptions) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selDebugOptionsXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setDebugOptions:", ArgumentSemantic.Assign)]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (this.Handle, selSetDebugOptions_XHandle, (UIntPtr) (ulong) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UIntPtr (&__objc_super__, selSetDebugOptions_XHandle, (UIntPtr) (ulong) value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>Returns the format for depth pixels.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual global::Metal.MTLPixelFormat DepthPixelFormat {
			[Export ("depthPixelFormat")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				global::Metal.MTLPixelFormat ret;
				if (IsDirectBinding) {
					ret = (MTLPixelFormat) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selDepthPixelFormatXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (MTLPixelFormat) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selDepthPixelFormatXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		/// <summary>Returns the metal device that is used for rendering.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual global::Metal.IMTLDevice? Device {
			[Export ("device")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
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
		/// <summary>Gets or sets a Boolean value that controls whether SceneKit reduces aliasing by jittering the point of view.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		public virtual bool JitteringEnabled {
			[Export ("isJitteringEnabled")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsJitteringEnabledXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsJitteringEnabledXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setJitteringEnabled:")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetJitteringEnabled_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetJitteringEnabled_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		public virtual bool Loops {
			[Export ("loops")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selLoopsXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selLoopsXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setLoops:")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetLoops_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetLoops_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual double NextFrameTimeInSeconds {
			[Export ("nextFrameTime")]
			get {
				double ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.Double_objc_msgSend (this.Handle, selNextFrameTimeXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.Double_objc_msgSendSuper (&__objc_super__, selNextFrameTimeXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual global::SpriteKit.SKScene? OverlayScene {
			[Export ("overlaySKScene", ArgumentSemantic.Retain)]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				global::SpriteKit.SKScene? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::SpriteKit.SKScene> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selOverlaySKSceneXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<global::SpriteKit.SKScene> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selOverlaySKSceneXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setOverlaySKScene:", ArgumentSemantic.Retain)]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetOverlaySKScene_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetOverlaySKScene_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		/// <summary>Gets or sets a Boolean value that starts and stops the scene.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		public virtual bool Playing {
			[Export ("isPlaying")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsPlayingXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsPlayingXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setPlaying:")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetPlaying_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetPlaying_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		public virtual SCNNode? PointOfView {
			[Export ("pointOfView", ArgumentSemantic.Retain)]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				SCNNode? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<SCNNode> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selPointOfViewXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<SCNNode> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selPointOfViewXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setPointOfView:", ArgumentSemantic.Retain)]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetPointOfView_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetPointOfView_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		/// <summary>Returns the rendering API that is used to render the scene.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual SCNRenderingApi RenderingApi {
			[Export ("renderingAPI")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				SCNRenderingApi ret;
				if (IsDirectBinding) {
					ret = (SCNRenderingApi) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selRenderingAPIXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (SCNRenderingApi) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selRenderingAPIXHandle);
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
		public virtual SCNScene? Scene {
			[Export ("scene", ArgumentSemantic.Retain)]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				SCNScene? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<SCNScene> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selSceneXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<SCNScene> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selSceneXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setScene:", ArgumentSemantic.Retain)]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetScene_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetScene_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		/// <summary>Gets or sets the delegate for the renderer.</summary><value><para>(More documentation for this node is coming)</para><para tool="nullallowed">This value can be <see langword="null" />.</para></value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		public ISCNSceneRendererDelegate SceneRendererDelegate {
			get {
				return (WeakSceneRendererDelegate as ISCNSceneRendererDelegate)!;
			}
			set {
				var rvalue = value as NSObject;
				if (!(value is null) && rvalue is null)
					throw new ArgumentException ("The object passed of type " + value.GetType () + " does not derive from NSObject");
				WeakSceneRendererDelegate = rvalue;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual double SceneTimeInSeconds {
			[Export ("sceneTime")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				double ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.Double_objc_msgSend (this.Handle, selSceneTimeXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.Double_objc_msgSendSuper (&__objc_super__, selSceneTimeXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setSceneTime:")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_Double (this.Handle, selSetSceneTime_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_Double (&__objc_super__, selSetSceneTime_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual bool ShowsStatistics {
			[Export ("showsStatistics")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selShowsStatisticsXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selShowsStatisticsXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setShowsStatistics:")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetShowsStatistics_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetShowsStatistics_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>Returns the format for stencil pixels.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual global::Metal.MTLPixelFormat StencilPixelFormat {
			[Export ("stencilPixelFormat")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				global::Metal.MTLPixelFormat ret;
				if (IsDirectBinding) {
					ret = (MTLPixelFormat) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selStencilPixelFormatXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (MTLPixelFormat) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selStencilPixelFormatXHandle);
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
		public virtual SCNTechnique? Technique {
			[Export ("technique", ArgumentSemantic.Copy)]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				SCNTechnique? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<SCNTechnique> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selTechniqueXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<SCNTechnique> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selTechniqueXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setTechnique:", ArgumentSemantic.Copy)]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetTechnique_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetTechnique_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public virtual bool TemporalAntialiasingEnabled {
			[Export ("isTemporalAntialiasingEnabled")]
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsTemporalAntialiasingEnabledXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsTemporalAntialiasingEnabledXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setTemporalAntialiasingEnabled:")]
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetTemporalAntialiasingEnabled_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetTemporalAntialiasingEnabled_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public virtual bool UsesReverseZ {
			[Export ("usesReverseZ")]
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selUsesReverseZXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selUsesReverseZXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setUsesReverseZ:")]
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetUsesReverseZ_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetUsesReverseZ_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		object? __mt_WeakSceneRendererDelegate_var;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		public virtual NSObject? WeakSceneRendererDelegate {
			[Export ("delegate", ArgumentSemantic.Weak)]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
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
				__mt_WeakSceneRendererDelegate_var = ret;
				return ret!;
			}
			[Export ("setDelegate:", ArgumentSemantic.Weak)]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
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
				__mt_WeakSceneRendererDelegate_var = value;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		public virtual CGColorSpace WorkingColorSpace {
			[Export ("workingColorSpace")]
			[SupportedOSPlatform ("ios17.0")]
			[SupportedOSPlatform ("macos14.0")]
			[SupportedOSPlatform ("tvos17.0")]
			[SupportedOSPlatform ("maccatalyst17.0")]
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
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_WeakSceneRendererDelegate_var = null;
			}
		}
	} /* class SCNRenderer */
}
