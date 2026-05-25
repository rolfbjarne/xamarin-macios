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
namespace SceneKit {
	#pragma warning disable CS1573
	/// <summary>Implementation class of the <see cref="T:SceneKit.ISCNSceneRenderer" /> interface.</summary><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/SceneKit/Reference/SCNSceneRenderer_Protocol/index.html">Apple documentation for <c>SCNSceneRenderer</c></related>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	[Protocol (Name = "SCNSceneRenderer", WrapperType = typeof (SCNSceneRendererWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "HitTest", Selector = "hitTest:options:", ReturnType = typeof (SCNHitTestResult[]), ParameterType = new Type [] { typeof (CGPoint), typeof (NSDictionary) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "IsNodeInsideFrustum", Selector = "isNodeInsideFrustum:withPointOfView:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (SCNNode), typeof (SCNNode) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "ProjectPoint", Selector = "projectPoint:", ReturnType = typeof (SCNVector3), ParameterType = new Type [] { typeof (SCNVector3) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "UnprojectPoint", Selector = "unprojectPoint:", ReturnType = typeof (SCNVector3), ParameterType = new Type [] { typeof (SCNVector3) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "Prepare", Selector = "prepareObject:shouldAbortBlock:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (NSObject), typeof (global::System.Func<bool>) }, ParameterByRef = new bool [] { false, false }, ParameterBlockProxy = new Type? [] { null, typeof (ObjCRuntime.Trampolines.NIDFuncArity1V1) })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "Prepare", Selector = "prepareObjects:withCompletionHandler:", ParameterType = new Type [] { typeof (NSObject[]), typeof (global::System.Action<bool>) }, ParameterByRef = new bool [] { false, false }, ParameterBlockProxy = new Type? [] { null, typeof (ObjCRuntime.Trampolines.NIDActionArity1V4) })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "PresentScene", Selector = "presentScene:withTransition:incomingPointOfView:completionHandler:", ParameterType = new Type [] { typeof (SCNScene), typeof (SKTransition), typeof (SCNNode), typeof (Action) }, ParameterByRef = new bool [] { false, false, false, false }, ParameterBlockProxy = new Type? [] { null, null, null, typeof (ObjCRuntime.Trampolines.NIDAction) })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetNodesInsideFrustum", Selector = "nodesInsideFrustumWithPointOfView:", ReturnType = typeof (SCNNode[]), ParameterType = new Type [] { typeof (SCNNode) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "WeakSceneRendererDelegate", Selector = "delegate", PropertyType = typeof (NSObject), GetterSelector = "delegate", SetterSelector = "setDelegate:", ArgumentSemantic = ArgumentSemantic.Weak)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "Playing", Selector = "playing", PropertyType = typeof (bool), GetterSelector = "isPlaying", SetterSelector = "setPlaying:", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "Loops", Selector = "loops", PropertyType = typeof (bool), GetterSelector = "loops", SetterSelector = "setLoops:", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "PointOfView", Selector = "pointOfView", PropertyType = typeof (SCNNode), GetterSelector = "pointOfView", SetterSelector = "setPointOfView:", ArgumentSemantic = ArgumentSemantic.Retain)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "AutoenablesDefaultLighting", Selector = "autoenablesDefaultLighting", PropertyType = typeof (bool), GetterSelector = "autoenablesDefaultLighting", SetterSelector = "setAutoenablesDefaultLighting:", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "JitteringEnabled", Selector = "jitteringEnabled", PropertyType = typeof (bool), GetterSelector = "isJitteringEnabled", SetterSelector = "setJitteringEnabled:", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "Context", Selector = "context", PropertyType = typeof (IntPtr), GetterSelector = "context", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "ShowsStatistics", Selector = "showsStatistics", PropertyType = typeof (bool), GetterSelector = "showsStatistics", SetterSelector = "setShowsStatistics:", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "SceneTimeInSeconds", Selector = "sceneTime", PropertyType = typeof (double), GetterSelector = "sceneTime", SetterSelector = "setSceneTime:", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "Scene", Selector = "scene", PropertyType = typeof (SCNScene), GetterSelector = "scene", SetterSelector = "setScene:", ArgumentSemantic = ArgumentSemantic.Retain)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "OverlayScene", Selector = "overlaySKScene", PropertyType = typeof (SKScene), GetterSelector = "overlaySKScene", SetterSelector = "setOverlaySKScene:", ArgumentSemantic = ArgumentSemantic.Retain)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "DebugOptions", Selector = "debugOptions", PropertyType = typeof (SCNDebugOptions), GetterSelector = "debugOptions", SetterSelector = "setDebugOptions:", ArgumentSemantic = ArgumentSemantic.Assign)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "RenderingApi", Selector = "renderingAPI", PropertyType = typeof (SCNRenderingApi), GetterSelector = "renderingAPI", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "CurrentRenderCommandEncoder", Selector = "currentRenderCommandEncoder", PropertyType = typeof (IMTLRenderCommandEncoder), GetterSelector = "currentRenderCommandEncoder", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "Device", Selector = "device", PropertyType = typeof (IMTLDevice), GetterSelector = "device", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "ColorPixelFormat", Selector = "colorPixelFormat", PropertyType = typeof (MTLPixelFormat), GetterSelector = "colorPixelFormat", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "DepthPixelFormat", Selector = "depthPixelFormat", PropertyType = typeof (MTLPixelFormat), GetterSelector = "depthPixelFormat", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "StencilPixelFormat", Selector = "stencilPixelFormat", PropertyType = typeof (MTLPixelFormat), GetterSelector = "stencilPixelFormat", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "CommandQueue", Selector = "commandQueue", PropertyType = typeof (IMTLCommandQueue), GetterSelector = "commandQueue", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "AudioEngine", Selector = "audioEngine", PropertyType = typeof (AVAudioEngine), GetterSelector = "audioEngine", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "AudioEnvironmentNode", Selector = "audioEnvironmentNode", PropertyType = typeof (AVAudioEnvironmentNode), GetterSelector = "audioEnvironmentNode", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "AudioListener", Selector = "audioListener", PropertyType = typeof (SCNNode), GetterSelector = "audioListener", SetterSelector = "setAudioListener:", ArgumentSemantic = ArgumentSemantic.Retain)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "TemporalAntialiasingEnabled", Selector = "temporalAntialiasingEnabled", PropertyType = typeof (bool), GetterSelector = "isTemporalAntialiasingEnabled", SetterSelector = "setTemporalAntialiasingEnabled:", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "CurrentViewport", Selector = "currentViewport", PropertyType = typeof (CGRect), GetterSelector = "currentViewport", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "UsesReverseZ", Selector = "usesReverseZ", PropertyType = typeof (bool), GetterSelector = "usesReverseZ", SetterSelector = "setUsesReverseZ:", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "CurrentRenderPassDescriptor", Selector = "currentRenderPassDescriptor", PropertyType = typeof (MTLRenderPassDescriptor), GetterSelector = "currentRenderPassDescriptor", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "WorkingColorSpace", Selector = "workingColorSpace", PropertyType = typeof (CGColorSpace), GetterSelector = "workingColorSpace", ArgumentSemantic = ArgumentSemantic.None)]
	public partial interface ISCNSceneRenderer : INativeObject, IDisposable
	{
		/// <param name="thePoint">To be added.</param><param name="options">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("hitTest:options:")]
		[EditorBrowsable (EditorBrowsableState.Never)]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual SCNHitTestResult[] HitTest (CGPoint thePoint, NSDictionary? options)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="thePoint">To be added.</param><param name="options">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[EditorBrowsable (EditorBrowsableState.Never)]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static SCNHitTestResult[] _HitTest (ISCNSceneRenderer This, CGPoint thePoint, NSDictionary? options)
		{
			var options__handle__ = options.GetHandle ();
			SCNHitTestResult[]? ret;
			ret = CFArray.ArrayFromHandle<SCNHitTestResult>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_CGPoint_NativeHandle (This.Handle, Selector.GetHandle ("hitTest:options:"), thePoint, options__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (options);
			return ret!;
		}
		/// <param name="node">To be added.</param><param name="pointOfView">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("isNodeInsideFrustum:withPointOfView:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool IsNodeInsideFrustum (SCNNode node, SCNNode pointOfView)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="node">To be added.</param><param name="pointOfView">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _IsNodeInsideFrustum (ISCNSceneRenderer This, SCNNode node, SCNNode pointOfView)
		{
			var node__handle__ = node!.GetNonNullHandle (nameof (node));
			var pointOfView__handle__ = pointOfView!.GetNonNullHandle (nameof (pointOfView));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("isNodeInsideFrustum:withPointOfView:"), node__handle__, pointOfView__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (node);
			GC.KeepAlive (pointOfView);
			return ret != 0;
		}
		/// <param name="point">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("projectPoint:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual SCNVector3 ProjectPoint (SCNVector3 point)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="point">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static SCNVector3 _ProjectPoint (ISCNSceneRenderer This, SCNVector3 point)
		{
			SCNVector3 ret;
			ret = global::ObjCRuntime.Messaging.SCNVector3_objc_msgSend_SCNVector3 (This.Handle, Selector.GetHandle ("projectPoint:"), point);
			GC.KeepAlive (This);
			return ret;
		}
		/// <param name="point">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("unprojectPoint:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual SCNVector3 UnprojectPoint (SCNVector3 point)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="point">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static SCNVector3 _UnprojectPoint (ISCNSceneRenderer This, SCNVector3 point)
		{
			SCNVector3 ret;
			ret = global::ObjCRuntime.Messaging.SCNVector3_objc_msgSend_SCNVector3 (This.Handle, Selector.GetHandle ("unprojectPoint:"), point);
			GC.KeepAlive (This);
			return ret;
		}
		/// <param name="obj">To be added.</param><param name="abortHandler"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("prepareObject:shouldAbortBlock:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual bool Prepare (NSObject obj, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDFuncArity1V1))]global::System.Func<bool>? abortHandler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="obj">To be added.</param><param name="abortHandler"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static bool _Prepare (ISCNSceneRenderer This, NSObject obj, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDFuncArity1V1))]global::System.Func<bool>? abortHandler)
		{
			var obj__handle__ = obj!.GetNonNullHandle (nameof (obj));
			using var block_abortHandler = Trampolines.SDFuncArity1V1.CreateNullableBlock (abortHandler);
			BlockLiteral *block_ptr_abortHandler = null;
			if (abortHandler is not null)
				block_ptr_abortHandler = &block_abortHandler;
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("prepareObject:shouldAbortBlock:"), obj__handle__, (IntPtr) block_ptr_abortHandler);
			GC.KeepAlive (This);
			GC.KeepAlive (obj);
			return ret != 0;
		}
		/// <param name="objects">The objects to prepare.</param><param name="completionHandler">A handler that receives <see langword="true" /> if preparation of all scene resources succeeded, or <see langword="false" /> if not.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("prepareObjects:withCompletionHandler:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void Prepare (NSObject[] objects, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V4))]global::System.Action<bool>? completionHandler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
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
		/// <param name="objects">The objects to prepare.</param><param name="completionHandler">A handler that receives <see langword="true" /> if preparation of all scene resources succeeded, or <see langword="false" /> if not.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _Prepare (ISCNSceneRenderer This, NSObject[] objects, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V4))]global::System.Action<bool>? completionHandler)
		{
			if (objects is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (objects));
			using var nsa_objects = NSArray.FromNSObjects (objects);
			using var block_completionHandler = Trampolines.SDActionArity1V4.CreateNullableBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = null;
			if (completionHandler is not null)
				block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("prepareObjects:withCompletionHandler:"), nsa_objects.Handle, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
		}
		/// <summary>Displays the provided scene.</summary><param name="scene">The scene to present.</param><param name="transition">The transistion to use to present the scene.</param><param name="pointOfView">The point of view to which to present the scene.</param><param name="completionHandler">A handler to run after the scene is presented.</param>
		[global::Foundation.RequiredMember]
		[Export ("presentScene:withTransition:incomingPointOfView:completionHandler:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void PresentScene (SCNScene scene, global::SpriteKit.SKTransition transition, SCNNode? pointOfView, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action? completionHandler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
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
		/// <summary>Displays the provided scene.</summary><param name="scene">The scene to present.</param><param name="transition">The transistion to use to present the scene.</param><param name="pointOfView">The point of view to which to present the scene.</param><param name="completionHandler">A handler to run after the scene is presented.</param>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _PresentScene (ISCNSceneRenderer This, SCNScene scene, global::SpriteKit.SKTransition transition, SCNNode? pointOfView, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action? completionHandler)
		{
			var scene__handle__ = scene!.GetNonNullHandle (nameof (scene));
			var transition__handle__ = transition!.GetNonNullHandle (nameof (transition));
			var pointOfView__handle__ = pointOfView.GetHandle ();
			using var block_completionHandler = Trampolines.SDAction.CreateNullableBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = null;
			if (completionHandler is not null)
				block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("presentScene:withTransition:incomingPointOfView:completionHandler:"), scene__handle__, transition__handle__, pointOfView__handle__, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
			GC.KeepAlive (scene);
			GC.KeepAlive (transition);
			GC.KeepAlive (pointOfView);
		}
		/// <summary>Returns the nodes that are contained in the frustrum that is defined by the provided node.</summary>
		[global::Foundation.RequiredMember]
		[Export ("nodesInsideFrustumWithPointOfView:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual SCNNode[] GetNodesInsideFrustum (SCNNode pointOfView)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <summary>Returns the nodes that are contained in the frustrum that is defined by the provided node.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static SCNNode[] _GetNodesInsideFrustum (ISCNSceneRenderer This, SCNNode pointOfView)
		{
			var pointOfView__handle__ = pointOfView!.GetNonNullHandle (nameof (pointOfView));
			SCNNode[]? ret;
			ret = CFArray.ArrayFromHandle<SCNNode>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("nodesInsideFrustumWithPointOfView:"), pointOfView__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (pointOfView);
			return ret!;
		}
		[DynamicDependencyAttribute ("AudioEngine")]
		[DynamicDependencyAttribute ("AudioEnvironmentNode")]
		[DynamicDependencyAttribute ("AudioListener")]
		[DynamicDependencyAttribute ("AutoenablesDefaultLighting")]
		[DynamicDependencyAttribute ("ColorPixelFormat")]
		[DynamicDependencyAttribute ("CommandQueue")]
		[DynamicDependencyAttribute ("Context")]
		[DynamicDependencyAttribute ("CurrentRenderCommandEncoder")]
		[DynamicDependencyAttribute ("CurrentRenderPassDescriptor")]
		[DynamicDependencyAttribute ("CurrentViewport")]
		[DynamicDependencyAttribute ("DebugOptions")]
		[DynamicDependencyAttribute ("DepthPixelFormat")]
		[DynamicDependencyAttribute ("Device")]
		[DynamicDependencyAttribute ("GetNodesInsideFrustum(SceneKit.SCNNode)")]
		[DynamicDependencyAttribute ("HitTest(CoreGraphics.CGPoint,Foundation.NSDictionary)")]
		[DynamicDependencyAttribute ("IsNodeInsideFrustum(SceneKit.SCNNode,SceneKit.SCNNode)")]
		[DynamicDependencyAttribute ("JitteringEnabled")]
		[DynamicDependencyAttribute ("Loops")]
		[DynamicDependencyAttribute ("OverlayScene")]
		[DynamicDependencyAttribute ("Playing")]
		[DynamicDependencyAttribute ("PointOfView")]
		[DynamicDependencyAttribute ("Prepare(Foundation.NSObject,System.Func{System.Boolean})")]
		[DynamicDependencyAttribute ("Prepare(Foundation.NSObject[],System.Action{System.Boolean})")]
		[DynamicDependencyAttribute ("PresentScene(SceneKit.SCNScene,SpriteKit.SKTransition,SceneKit.SCNNode,System.Action)")]
		[DynamicDependencyAttribute ("ProjectPoint(SceneKit.SCNVector3)")]
		[DynamicDependencyAttribute ("RenderingApi")]
		[DynamicDependencyAttribute ("Scene")]
		[DynamicDependencyAttribute ("SceneTimeInSeconds")]
		[DynamicDependencyAttribute ("ShowsStatistics")]
		[DynamicDependencyAttribute ("StencilPixelFormat")]
		[DynamicDependencyAttribute ("TemporalAntialiasingEnabled")]
		[DynamicDependencyAttribute ("UnprojectPoint(SceneKit.SCNVector3)")]
		[DynamicDependencyAttribute ("UsesReverseZ")]
		[DynamicDependencyAttribute ("WeakSceneRendererDelegate")]
		[DynamicDependencyAttribute ("WorkingColorSpace")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (SCNSceneRendererWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static ISCNSceneRenderer ()
		{
			GC.KeepAlive (null);
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual NSObject? WeakSceneRendererDelegate {
			[Export ("delegate", ArgumentSemantic.Weak)]
			get {
				return _GetWeakSceneRendererDelegate (this);
			}
			[Export ("setDelegate:", ArgumentSemantic.Weak)]
			set {
				_SetWeakSceneRendererDelegate (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSObject _GetWeakSceneRendererDelegate (ISCNSceneRenderer This)
		{
			NSObject ret;
			ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("delegate")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetWeakSceneRendererDelegate (ISCNSceneRenderer This, NSObject? value)
		{
			var value__handle__ = value.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setDelegate:"), value__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (value);
		}
		/// <summary>Gets or sets a Boolean value that starts and stops the scene.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual bool Playing {
			[Export ("isPlaying")]
			get {
				return _GetPlaying (this);
			}
			[Export ("setPlaying:")]
			set {
				_SetPlaying (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _GetPlaying (ISCNSceneRenderer This)
		{
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("isPlaying"));
			GC.KeepAlive (This);
			return ret != 0;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetPlaying (ISCNSceneRenderer This, bool value)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_bool (This.Handle, Selector.GetHandle ("setPlaying:"), value ? (byte) 1 : (byte) 0);
			GC.KeepAlive (This);
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual bool Loops {
			[Export ("loops")]
			get {
				return _GetLoops (this);
			}
			[Export ("setLoops:")]
			set {
				_SetLoops (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _GetLoops (ISCNSceneRenderer This)
		{
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("loops"));
			GC.KeepAlive (This);
			return ret != 0;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetLoops (ISCNSceneRenderer This, bool value)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_bool (This.Handle, Selector.GetHandle ("setLoops:"), value ? (byte) 1 : (byte) 0);
			GC.KeepAlive (This);
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual SCNNode? PointOfView {
			[Export ("pointOfView", ArgumentSemantic.Retain)]
			get {
				return _GetPointOfView (this);
			}
			[Export ("setPointOfView:", ArgumentSemantic.Retain)]
			set {
				_SetPointOfView (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static SCNNode _GetPointOfView (ISCNSceneRenderer This)
		{
			SCNNode ret;
			ret =  Runtime.GetNSObject<SCNNode> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("pointOfView")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetPointOfView (ISCNSceneRenderer This, SCNNode? value)
		{
			var value__handle__ = value.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setPointOfView:"), value__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (value);
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual bool AutoenablesDefaultLighting {
			[Export ("autoenablesDefaultLighting")]
			get {
				return _GetAutoenablesDefaultLighting (this);
			}
			[Export ("setAutoenablesDefaultLighting:")]
			set {
				_SetAutoenablesDefaultLighting (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _GetAutoenablesDefaultLighting (ISCNSceneRenderer This)
		{
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("autoenablesDefaultLighting"));
			GC.KeepAlive (This);
			return ret != 0;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetAutoenablesDefaultLighting (ISCNSceneRenderer This, bool value)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_bool (This.Handle, Selector.GetHandle ("setAutoenablesDefaultLighting:"), value ? (byte) 1 : (byte) 0);
			GC.KeepAlive (This);
		}
		/// <summary>Gets or sets a Boolean value that controls whether SceneKit reduces aliasing by jittering the point of view.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual bool JitteringEnabled {
			[Export ("isJitteringEnabled")]
			get {
				return _GetJitteringEnabled (this);
			}
			[Export ("setJitteringEnabled:")]
			set {
				_SetJitteringEnabled (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _GetJitteringEnabled (ISCNSceneRenderer This)
		{
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("isJitteringEnabled"));
			GC.KeepAlive (This);
			return ret != 0;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetJitteringEnabled (ISCNSceneRenderer This, bool value)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_bool (This.Handle, Selector.GetHandle ("setJitteringEnabled:"), value ? (byte) 1 : (byte) 0);
			GC.KeepAlive (This);
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[global::Foundation.RequiredMember]
		public virtual nint Context {
			[Export ("context")]
			get {
				return _GetContext (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static nint _GetContext (ISCNSceneRenderer This)
		{
			nint ret;
			ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("context"));
			GC.KeepAlive (This);
			return ret;
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[global::Foundation.RequiredMember]
		public virtual bool ShowsStatistics {
			[Export ("showsStatistics")]
			get {
				return _GetShowsStatistics (this);
			}
			[Export ("setShowsStatistics:")]
			set {
				_SetShowsStatistics (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _GetShowsStatistics (ISCNSceneRenderer This)
		{
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("showsStatistics"));
			GC.KeepAlive (This);
			return ret != 0;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetShowsStatistics (ISCNSceneRenderer This, bool value)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_bool (This.Handle, Selector.GetHandle ("setShowsStatistics:"), value ? (byte) 1 : (byte) 0);
			GC.KeepAlive (This);
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[global::Foundation.RequiredMember]
		public virtual double SceneTimeInSeconds {
			[Export ("sceneTime")]
			get {
				return _GetSceneTimeInSeconds (this);
			}
			[Export ("setSceneTime:")]
			set {
				_SetSceneTimeInSeconds (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static double _GetSceneTimeInSeconds (ISCNSceneRenderer This)
		{
			double ret;
			ret = global::ObjCRuntime.Messaging.Double_objc_msgSend (This.Handle, Selector.GetHandle ("sceneTime"));
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetSceneTimeInSeconds (ISCNSceneRenderer This, double value)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_Double (This.Handle, Selector.GetHandle ("setSceneTime:"), value);
			GC.KeepAlive (This);
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[global::Foundation.RequiredMember]
		public virtual SCNScene? Scene {
			[Export ("scene", ArgumentSemantic.Retain)]
			get {
				return _GetScene (this);
			}
			[Export ("setScene:", ArgumentSemantic.Retain)]
			set {
				_SetScene (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static SCNScene _GetScene (ISCNSceneRenderer This)
		{
			SCNScene ret;
			ret =  Runtime.GetNSObject<SCNScene> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("scene")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetScene (ISCNSceneRenderer This, SCNScene? value)
		{
			var value__handle__ = value.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setScene:"), value__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (value);
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[global::Foundation.RequiredMember]
		public virtual global::SpriteKit.SKScene? OverlayScene {
			[Export ("overlaySKScene", ArgumentSemantic.Retain)]
			get {
				return _GetOverlayScene (this);
			}
			[Export ("setOverlaySKScene:", ArgumentSemantic.Retain)]
			set {
				_SetOverlayScene (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static global::SpriteKit.SKScene _GetOverlayScene (ISCNSceneRenderer This)
		{
			global::SpriteKit.SKScene ret;
			ret =  Runtime.GetNSObject<global::SpriteKit.SKScene> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("overlaySKScene")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetOverlayScene (ISCNSceneRenderer This, global::SpriteKit.SKScene? value)
		{
			var value__handle__ = value.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setOverlaySKScene:"), value__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (value);
		}
		/// <summary>A value that controls which, if any, debug overlays to show in the rendered output.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[global::Foundation.RequiredMember]
		public virtual SCNDebugOptions DebugOptions {
			[Export ("debugOptions", ArgumentSemantic.Assign)]
			get {
				return _GetDebugOptions (this);
			}
			[Export ("setDebugOptions:", ArgumentSemantic.Assign)]
			set {
				_SetDebugOptions (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static SCNDebugOptions _GetDebugOptions (ISCNSceneRenderer This)
		{
			SCNDebugOptions ret;
			ret = (SCNDebugOptions) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("debugOptions"));
			GC.KeepAlive (This);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetDebugOptions (ISCNSceneRenderer This, SCNDebugOptions value)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (This.Handle, Selector.GetHandle ("setDebugOptions:"), (UIntPtr) (ulong) value);
			GC.KeepAlive (This);
		}
		/// <summary>Returns the rendering API that is used to render the scene.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[global::Foundation.RequiredMember]
		public virtual SCNRenderingApi RenderingApi {
			[Export ("renderingAPI")]
			get {
				return _GetRenderingApi (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static SCNRenderingApi _GetRenderingApi (ISCNSceneRenderer This)
		{
			SCNRenderingApi ret;
			ret = (SCNRenderingApi) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("renderingAPI"));
			GC.KeepAlive (This);
			return ret!;
		}
		/// <summary>Returns the current command encoder that is used for rendering.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[global::Foundation.RequiredMember]
		public virtual global::Metal.IMTLRenderCommandEncoder? CurrentRenderCommandEncoder {
			[Export ("currentRenderCommandEncoder")]
			get {
				return _GetCurrentRenderCommandEncoder (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static global::Metal.IMTLRenderCommandEncoder _GetCurrentRenderCommandEncoder (ISCNSceneRenderer This)
		{
			global::Metal.IMTLRenderCommandEncoder ret;
			ret =  Runtime.GetINativeObject<global::Metal.IMTLRenderCommandEncoder> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("currentRenderCommandEncoder")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		/// <summary>Returns the metal device that is used for rendering.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[global::Foundation.RequiredMember]
		public virtual global::Metal.IMTLDevice? Device {
			[Export ("device")]
			get {
				return _GetDevice (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static global::Metal.IMTLDevice _GetDevice (ISCNSceneRenderer This)
		{
			global::Metal.IMTLDevice ret;
			ret =  Runtime.GetINativeObject<global::Metal.IMTLDevice> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("device")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		/// <summary>Returns the format for color pixels.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[global::Foundation.RequiredMember]
		public virtual global::Metal.MTLPixelFormat ColorPixelFormat {
			[Export ("colorPixelFormat")]
			get {
				return _GetColorPixelFormat (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static global::Metal.MTLPixelFormat _GetColorPixelFormat (ISCNSceneRenderer This)
		{
			global::Metal.MTLPixelFormat ret;
			ret = (MTLPixelFormat) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("colorPixelFormat"));
			GC.KeepAlive (This);
			return ret!;
		}
		/// <summary>Returns the format for depth pixels.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[global::Foundation.RequiredMember]
		public virtual global::Metal.MTLPixelFormat DepthPixelFormat {
			[Export ("depthPixelFormat")]
			get {
				return _GetDepthPixelFormat (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static global::Metal.MTLPixelFormat _GetDepthPixelFormat (ISCNSceneRenderer This)
		{
			global::Metal.MTLPixelFormat ret;
			ret = (MTLPixelFormat) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("depthPixelFormat"));
			GC.KeepAlive (This);
			return ret!;
		}
		/// <summary>Returns the format for stencil pixels.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[global::Foundation.RequiredMember]
		public virtual global::Metal.MTLPixelFormat StencilPixelFormat {
			[Export ("stencilPixelFormat")]
			get {
				return _GetStencilPixelFormat (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static global::Metal.MTLPixelFormat _GetStencilPixelFormat (ISCNSceneRenderer This)
		{
			global::Metal.MTLPixelFormat ret;
			ret = (MTLPixelFormat) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("stencilPixelFormat"));
			GC.KeepAlive (This);
			return ret!;
		}
		/// <summary>Returns the command queue.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[global::Foundation.RequiredMember]
		public virtual global::Metal.IMTLCommandQueue? CommandQueue {
			[Export ("commandQueue")]
			get {
				return _GetCommandQueue (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static global::Metal.IMTLCommandQueue _GetCommandQueue (ISCNSceneRenderer This)
		{
			global::Metal.IMTLCommandQueue ret;
			ret =  Runtime.GetINativeObject<global::Metal.IMTLCommandQueue> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("commandQueue")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		/// <summary>Returns the audio engine that is used to render sounds in the scene</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[global::Foundation.RequiredMember]
		public virtual global::AVFoundation.AVAudioEngine AudioEngine {
			[Export ("audioEngine")]
			get {
				return _GetAudioEngine (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static global::AVFoundation.AVAudioEngine _GetAudioEngine (ISCNSceneRenderer This)
		{
			global::AVFoundation.AVAudioEngine ret;
			ret =  Runtime.GetNSObject<global::AVFoundation.AVAudioEngine> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("audioEngine")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		/// <summary>Returns the audio environment node for the scene.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[DebuggerBrowsable (DebuggerBrowsableState.Never)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[global::Foundation.RequiredMember]
		public virtual global::AVFoundation.AVAudioEnvironmentNode AudioEnvironmentNode {
			[Export ("audioEnvironmentNode")]
			get {
				return _GetAudioEnvironmentNode (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static global::AVFoundation.AVAudioEnvironmentNode _GetAudioEnvironmentNode (ISCNSceneRenderer This)
		{
			global::AVFoundation.AVAudioEnvironmentNode ret;
			ret =  Runtime.GetNSObject<global::AVFoundation.AVAudioEnvironmentNode> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("audioEnvironmentNode")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		/// <summary>The node that represents the position of the listener in the scene.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[DebuggerBrowsable (DebuggerBrowsableState.Never)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[global::Foundation.RequiredMember]
		public virtual SCNNode? AudioListener {
			[Export ("audioListener", ArgumentSemantic.Retain)]
			get {
				return _GetAudioListener (this);
			}
			[Export ("setAudioListener:", ArgumentSemantic.Retain)]
			set {
				_SetAudioListener (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static SCNNode _GetAudioListener (ISCNSceneRenderer This)
		{
			SCNNode ret;
			ret =  Runtime.GetNSObject<SCNNode> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("audioListener")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetAudioListener (ISCNSceneRenderer This, SCNNode? value)
		{
			var value__handle__ = value.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setAudioListener:"), value__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (value);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[global::Foundation.RequiredMember]
		public virtual bool TemporalAntialiasingEnabled {
			[Export ("isTemporalAntialiasingEnabled")]
			get {
				return _GetTemporalAntialiasingEnabled (this);
			}
			[Export ("setTemporalAntialiasingEnabled:")]
			set {
				_SetTemporalAntialiasingEnabled (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _GetTemporalAntialiasingEnabled (ISCNSceneRenderer This)
		{
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("isTemporalAntialiasingEnabled"));
			GC.KeepAlive (This);
			return ret != 0;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetTemporalAntialiasingEnabled (ISCNSceneRenderer This, bool value)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_bool (This.Handle, Selector.GetHandle ("setTemporalAntialiasingEnabled:"), value ? (byte) 1 : (byte) 0);
			GC.KeepAlive (This);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[global::Foundation.RequiredMember]
		public virtual CGRect CurrentViewport {
			[Export ("currentViewport")]
			get {
				return _GetCurrentViewport (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static CGRect _GetCurrentViewport (ISCNSceneRenderer This)
		{
			CGRect ret;
			if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
				ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend (This.Handle, Selector.GetHandle ("currentViewport"));
				GC.KeepAlive (This);
			} else {
				ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret (This.Handle, Selector.GetHandle ("currentViewport"));
				GC.KeepAlive (This);
			}
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[global::Foundation.RequiredMember]
		public virtual bool UsesReverseZ {
			[Export ("usesReverseZ")]
			get {
				return _GetUsesReverseZ (this);
			}
			[Export ("setUsesReverseZ:")]
			set {
				_SetUsesReverseZ (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _GetUsesReverseZ (ISCNSceneRenderer This)
		{
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("usesReverseZ"));
			GC.KeepAlive (This);
			return ret != 0;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetUsesReverseZ (ISCNSceneRenderer This, bool value)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_bool (This.Handle, Selector.GetHandle ("setUsesReverseZ:"), value ? (byte) 1 : (byte) 0);
			GC.KeepAlive (This);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[global::Foundation.RequiredMember]
		public virtual global::Metal.MTLRenderPassDescriptor CurrentRenderPassDescriptor {
			[Export ("currentRenderPassDescriptor")]
			get {
				return _GetCurrentRenderPassDescriptor (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static global::Metal.MTLRenderPassDescriptor _GetCurrentRenderPassDescriptor (ISCNSceneRenderer This)
		{
			global::Metal.MTLRenderPassDescriptor ret;
			ret =  Runtime.GetNSObject<global::Metal.MTLRenderPassDescriptor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("currentRenderPassDescriptor")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[global::Foundation.OptionalMember]
		public virtual CGColorSpace WorkingColorSpace {
			[Export ("workingColorSpace")]
			get {
				return _GetWorkingColorSpace (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static CGColorSpace _GetWorkingColorSpace (ISCNSceneRenderer This)
		{
			CGColorSpace ret;
			ret = Runtime.GetINativeObject<global::CoreGraphics.CGColorSpace> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("workingColorSpace")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="ISCNSceneRenderer" /> interface to support all the methods from the SCNSceneRenderer protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="ISCNSceneRenderer" /> interface allow developers to treat instances of the interface as having all the optional methods of the original SCNSceneRenderer protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class SCNSceneRenderer_Extensions {
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
		public unsafe static Task<bool> PrepareAsync (this ISCNSceneRenderer This, NSObject[] objects)
		{
			var tcs = new TaskCompletionSource<bool> ();
			This.Prepare(objects, (obj_) => {
				tcs.SetResult (obj_!);
			});
			return tcs.Task;
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
		public unsafe static Task PresentSceneAsync (this ISCNSceneRenderer This, SCNScene scene, global::SpriteKit.SKTransition transition, SCNNode? pointOfView)
		{
			var tcs = new TaskCompletionSource<bool> ();
			This.PresentScene(scene, transition, pointOfView, () => {
				tcs.SetResult (true);
			});
			return tcs.Task;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CGColorSpace GetWorkingColorSpace (this ISCNSceneRenderer This)
		{
			CGColorSpace ret;
			ret = Runtime.GetINativeObject<global::CoreGraphics.CGColorSpace> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("workingColorSpace")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class SCNSceneRendererWrapper : BaseWrapper, ISCNSceneRenderer {
		public SCNSceneRendererWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (SCNSceneRendererWrapper))]
		static SCNSceneRendererWrapper ()
		{
			GC.KeepAlive (null);
		}
		/// <param name="thePoint">To be added.</param><param name="options">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("hitTest:options:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public SCNHitTestResult[] HitTest (CGPoint thePoint, NSDictionary? options)
		{
			var options__handle__ = options.GetHandle ();
			SCNHitTestResult[]? ret;
			ret = CFArray.ArrayFromHandle<SCNHitTestResult>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_CGPoint_NativeHandle (this.Handle, Selector.GetHandle ("hitTest:options:"), thePoint, options__handle__), false)!;
			GC.KeepAlive (options);
			return ret!;
		}
		/// <param name="node">To be added.</param><param name="pointOfView">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("isNodeInsideFrustum:withPointOfView:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public bool IsNodeInsideFrustum (SCNNode node, SCNNode pointOfView)
		{
			var node__handle__ = node!.GetNonNullHandle (nameof (node));
			var pointOfView__handle__ = pointOfView!.GetNonNullHandle (nameof (pointOfView));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("isNodeInsideFrustum:withPointOfView:"), node__handle__, pointOfView__handle__);
			GC.KeepAlive (node);
			GC.KeepAlive (pointOfView);
			return ret != 0;
		}
		/// <param name="point">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("projectPoint:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public SCNVector3 ProjectPoint (SCNVector3 point)
		{
			SCNVector3 ret;
			ret = global::ObjCRuntime.Messaging.SCNVector3_objc_msgSend_SCNVector3 (this.Handle, Selector.GetHandle ("projectPoint:"), point);
			return ret;
		}
		/// <param name="point">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("unprojectPoint:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public SCNVector3 UnprojectPoint (SCNVector3 point)
		{
			SCNVector3 ret;
			ret = global::ObjCRuntime.Messaging.SCNVector3_objc_msgSend_SCNVector3 (this.Handle, Selector.GetHandle ("unprojectPoint:"), point);
			return ret;
		}
		/// <param name="obj">To be added.</param><param name="abortHandler"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("prepareObject:shouldAbortBlock:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe bool Prepare (NSObject obj, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDFuncArity1V1))]global::System.Func<bool>? abortHandler)
		{
			var obj__handle__ = obj!.GetNonNullHandle (nameof (obj));
			using var block_abortHandler = Trampolines.SDFuncArity1V1.CreateNullableBlock (abortHandler);
			BlockLiteral *block_ptr_abortHandler = null;
			if (abortHandler is not null)
				block_ptr_abortHandler = &block_abortHandler;
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("prepareObject:shouldAbortBlock:"), obj__handle__, (IntPtr) block_ptr_abortHandler);
			GC.KeepAlive (obj);
			return ret != 0;
		}
		/// <param name="objects">The objects to prepare.</param><param name="completionHandler">A handler that receives <see langword="true" /> if preparation of all scene resources succeeded, or <see langword="false" /> if not.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("prepareObjects:withCompletionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void Prepare (NSObject[] objects, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V4))]global::System.Action<bool>? completionHandler)
		{
			if (objects is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (objects));
			using var nsa_objects = NSArray.FromNSObjects (objects);
			using var block_completionHandler = Trampolines.SDActionArity1V4.CreateNullableBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = null;
			if (completionHandler is not null)
				block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("prepareObjects:withCompletionHandler:"), nsa_objects.Handle, (IntPtr) block_ptr_completionHandler);
		}
		/// <summary>Displays the provided scene.</summary><param name="scene">The scene to present.</param><param name="transition">The transistion to use to present the scene.</param><param name="pointOfView">The point of view to which to present the scene.</param><param name="completionHandler">A handler to run after the scene is presented.</param>
		[Export ("presentScene:withTransition:incomingPointOfView:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void PresentScene (SCNScene scene, global::SpriteKit.SKTransition transition, SCNNode? pointOfView, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action? completionHandler)
		{
			var scene__handle__ = scene!.GetNonNullHandle (nameof (scene));
			var transition__handle__ = transition!.GetNonNullHandle (nameof (transition));
			var pointOfView__handle__ = pointOfView.GetHandle ();
			using var block_completionHandler = Trampolines.SDAction.CreateNullableBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = null;
			if (completionHandler is not null)
				block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("presentScene:withTransition:incomingPointOfView:completionHandler:"), scene__handle__, transition__handle__, pointOfView__handle__, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (scene);
			GC.KeepAlive (transition);
			GC.KeepAlive (pointOfView);
		}
		/// <summary>Returns the nodes that are contained in the frustrum that is defined by the provided node.</summary>
		[Export ("nodesInsideFrustumWithPointOfView:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public SCNNode[] GetNodesInsideFrustum (SCNNode pointOfView)
		{
			var pointOfView__handle__ = pointOfView!.GetNonNullHandle (nameof (pointOfView));
			SCNNode[]? ret;
			ret = CFArray.ArrayFromHandle<SCNNode>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("nodesInsideFrustumWithPointOfView:"), pointOfView__handle__), false)!;
			GC.KeepAlive (pointOfView);
			return ret!;
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSObject? WeakSceneRendererDelegate {
			[Export ("delegate", ArgumentSemantic.Weak)]
			get {
				NSObject ret;
				ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("delegate")), false)!;
				return ret;
			}
			[Export ("setDelegate:", ArgumentSemantic.Weak)]
			set {
				var value__handle__ = value.GetHandle ();
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setDelegate:"), value__handle__);
				GC.KeepAlive (value);
			}
		}
		/// <summary>Gets or sets a Boolean value that starts and stops the scene.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public bool Playing {
			[Export ("isPlaying")]
			get {
				byte ret;
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isPlaying"));
				return ret != 0;
			}
			[Export ("setPlaying:")]
			set {
				global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setPlaying:"), value ? (byte) 1 : (byte) 0);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public bool Loops {
			[Export ("loops")]
			get {
				byte ret;
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("loops"));
				return ret != 0;
			}
			[Export ("setLoops:")]
			set {
				global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setLoops:"), value ? (byte) 1 : (byte) 0);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public SCNNode? PointOfView {
			[Export ("pointOfView", ArgumentSemantic.Retain)]
			get {
				SCNNode ret;
				ret =  Runtime.GetNSObject<SCNNode> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("pointOfView")), false)!;
				return ret;
			}
			[Export ("setPointOfView:", ArgumentSemantic.Retain)]
			set {
				var value__handle__ = value.GetHandle ();
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setPointOfView:"), value__handle__);
				GC.KeepAlive (value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public bool AutoenablesDefaultLighting {
			[Export ("autoenablesDefaultLighting")]
			get {
				byte ret;
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("autoenablesDefaultLighting"));
				return ret != 0;
			}
			[Export ("setAutoenablesDefaultLighting:")]
			set {
				global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setAutoenablesDefaultLighting:"), value ? (byte) 1 : (byte) 0);
			}
		}
		/// <summary>Gets or sets a Boolean value that controls whether SceneKit reduces aliasing by jittering the point of view.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public bool JitteringEnabled {
			[Export ("isJitteringEnabled")]
			get {
				byte ret;
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isJitteringEnabled"));
				return ret != 0;
			}
			[Export ("setJitteringEnabled:")]
			set {
				global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setJitteringEnabled:"), value ? (byte) 1 : (byte) 0);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public nint Context {
			[Export ("context")]
			get {
				nint ret;
				ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("context"));
				return ret;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public bool ShowsStatistics {
			[Export ("showsStatistics")]
			get {
				byte ret;
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("showsStatistics"));
				return ret != 0;
			}
			[Export ("setShowsStatistics:")]
			set {
				global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setShowsStatistics:"), value ? (byte) 1 : (byte) 0);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public double SceneTimeInSeconds {
			[Export ("sceneTime")]
			get {
				double ret;
				ret = global::ObjCRuntime.Messaging.Double_objc_msgSend (this.Handle, Selector.GetHandle ("sceneTime"));
				return ret;
			}
			[Export ("setSceneTime:")]
			set {
				global::ObjCRuntime.Messaging.void_objc_msgSend_Double (this.Handle, Selector.GetHandle ("setSceneTime:"), value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public SCNScene? Scene {
			[Export ("scene", ArgumentSemantic.Retain)]
			get {
				SCNScene ret;
				ret =  Runtime.GetNSObject<SCNScene> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("scene")), false)!;
				return ret;
			}
			[Export ("setScene:", ArgumentSemantic.Retain)]
			set {
				var value__handle__ = value.GetHandle ();
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setScene:"), value__handle__);
				GC.KeepAlive (value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public global::SpriteKit.SKScene? OverlayScene {
			[Export ("overlaySKScene", ArgumentSemantic.Retain)]
			get {
				global::SpriteKit.SKScene ret;
				ret =  Runtime.GetNSObject<global::SpriteKit.SKScene> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("overlaySKScene")), false)!;
				return ret;
			}
			[Export ("setOverlaySKScene:", ArgumentSemantic.Retain)]
			set {
				var value__handle__ = value.GetHandle ();
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setOverlaySKScene:"), value__handle__);
				GC.KeepAlive (value);
			}
		}
		/// <summary>A value that controls which, if any, debug overlays to show in the rendered output.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public SCNDebugOptions DebugOptions {
			[Export ("debugOptions", ArgumentSemantic.Assign)]
			get {
				SCNDebugOptions ret;
				ret = (SCNDebugOptions) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("debugOptions"));
				return ret!;
			}
			[Export ("setDebugOptions:", ArgumentSemantic.Assign)]
			set {
				global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (this.Handle, Selector.GetHandle ("setDebugOptions:"), (UIntPtr) (ulong) value);
			}
		}
		/// <summary>Returns the rendering API that is used to render the scene.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public SCNRenderingApi RenderingApi {
			[Export ("renderingAPI")]
			get {
				SCNRenderingApi ret;
				ret = (SCNRenderingApi) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("renderingAPI"));
				return ret!;
			}
		}
		/// <summary>Returns the current command encoder that is used for rendering.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public global::Metal.IMTLRenderCommandEncoder? CurrentRenderCommandEncoder {
			[Export ("currentRenderCommandEncoder")]
			get {
				global::Metal.IMTLRenderCommandEncoder ret;
				ret =  Runtime.GetINativeObject<global::Metal.IMTLRenderCommandEncoder> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("currentRenderCommandEncoder")), false)!;
				return ret;
			}
		}
		/// <summary>Returns the metal device that is used for rendering.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public global::Metal.IMTLDevice? Device {
			[Export ("device")]
			get {
				global::Metal.IMTLDevice ret;
				ret =  Runtime.GetINativeObject<global::Metal.IMTLDevice> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("device")), false)!;
				return ret;
			}
		}
		/// <summary>Returns the format for color pixels.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public global::Metal.MTLPixelFormat ColorPixelFormat {
			[Export ("colorPixelFormat")]
			get {
				global::Metal.MTLPixelFormat ret;
				ret = (MTLPixelFormat) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("colorPixelFormat"));
				return ret!;
			}
		}
		/// <summary>Returns the format for depth pixels.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public global::Metal.MTLPixelFormat DepthPixelFormat {
			[Export ("depthPixelFormat")]
			get {
				global::Metal.MTLPixelFormat ret;
				ret = (MTLPixelFormat) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("depthPixelFormat"));
				return ret!;
			}
		}
		/// <summary>Returns the format for stencil pixels.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public global::Metal.MTLPixelFormat StencilPixelFormat {
			[Export ("stencilPixelFormat")]
			get {
				global::Metal.MTLPixelFormat ret;
				ret = (MTLPixelFormat) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("stencilPixelFormat"));
				return ret!;
			}
		}
		/// <summary>Returns the command queue.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public global::Metal.IMTLCommandQueue? CommandQueue {
			[Export ("commandQueue")]
			get {
				global::Metal.IMTLCommandQueue ret;
				ret =  Runtime.GetINativeObject<global::Metal.IMTLCommandQueue> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("commandQueue")), false)!;
				return ret;
			}
		}
		/// <summary>Returns the audio engine that is used to render sounds in the scene</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public global::AVFoundation.AVAudioEngine AudioEngine {
			[Export ("audioEngine")]
			get {
				global::AVFoundation.AVAudioEngine ret;
				ret =  Runtime.GetNSObject<global::AVFoundation.AVAudioEngine> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("audioEngine")), false)!;
				return ret;
			}
		}
		/// <summary>Returns the audio environment node for the scene.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[DebuggerBrowsable (DebuggerBrowsableState.Never)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public global::AVFoundation.AVAudioEnvironmentNode AudioEnvironmentNode {
			[Export ("audioEnvironmentNode")]
			get {
				global::AVFoundation.AVAudioEnvironmentNode ret;
				ret =  Runtime.GetNSObject<global::AVFoundation.AVAudioEnvironmentNode> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("audioEnvironmentNode")), false)!;
				return ret;
			}
		}
		/// <summary>The node that represents the position of the listener in the scene.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[DebuggerBrowsable (DebuggerBrowsableState.Never)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public SCNNode? AudioListener {
			[Export ("audioListener", ArgumentSemantic.Retain)]
			get {
				SCNNode ret;
				ret =  Runtime.GetNSObject<SCNNode> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("audioListener")), false)!;
				return ret;
			}
			[Export ("setAudioListener:", ArgumentSemantic.Retain)]
			set {
				var value__handle__ = value.GetHandle ();
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setAudioListener:"), value__handle__);
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public bool TemporalAntialiasingEnabled {
			[Export ("isTemporalAntialiasingEnabled")]
			get {
				byte ret;
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isTemporalAntialiasingEnabled"));
				return ret != 0;
			}
			[Export ("setTemporalAntialiasingEnabled:")]
			set {
				global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setTemporalAntialiasingEnabled:"), value ? (byte) 1 : (byte) 0);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public CGRect CurrentViewport {
			[Export ("currentViewport")]
			get {
				CGRect ret;
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend (this.Handle, Selector.GetHandle ("currentViewport"));
				} else {
					ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret (this.Handle, Selector.GetHandle ("currentViewport"));
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public bool UsesReverseZ {
			[Export ("usesReverseZ")]
			get {
				byte ret;
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("usesReverseZ"));
				return ret != 0;
			}
			[Export ("setUsesReverseZ:")]
			set {
				global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setUsesReverseZ:"), value ? (byte) 1 : (byte) 0);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public global::Metal.MTLRenderPassDescriptor CurrentRenderPassDescriptor {
			[Export ("currentRenderPassDescriptor")]
			get {
				global::Metal.MTLRenderPassDescriptor ret;
				ret =  Runtime.GetNSObject<global::Metal.MTLRenderPassDescriptor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("currentRenderPassDescriptor")), false)!;
				return ret;
			}
		}
	}
}
namespace SceneKit {
	/// <summary>Implementation class of the <see cref="T:SceneKit.ISCNSceneRenderer" /> interface.</summary><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/SceneKit/Reference/SCNSceneRenderer_Protocol/index.html">Apple documentation for <c>SCNSceneRenderer</c></related>
	[Protocol()]
	[Register("Microsoft_iOS__SceneKit_SCNSceneRenderer", false)]
	[Model]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe abstract partial class SCNSceneRenderer : NSObject, ISCNSceneRenderer {
		/// <summary>Creates a new <see cref="SCNSceneRenderer" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected SCNSceneRenderer () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = false;
			unsafe {
			var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
			InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			GC.KeepAlive (this);
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
		protected SCNSceneRenderer (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = false;
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
		protected internal SCNSceneRenderer (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
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
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="thePoint">To be added.</param><param name="options">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("hitTest:options:")]
		[EditorBrowsable (EditorBrowsableState.Never)]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual SCNHitTestResult[] HitTest (CGPoint thePoint, NSDictionary? options)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="thePoint">To be added.</param><param name="options">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public SCNHitTestResult[] HitTest (CGPoint thePoint, SCNHitTestOptions options)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
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
			throw new You_Should_Not_Call_base_In_This_Method ();
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
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="objects">The objects to prepare.</param><param name="completionHandler">A handler that receives <see langword="true" /> if preparation of all scene resources succeeded, or <see langword="false" /> if not.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("prepareObjects:withCompletionHandler:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void Prepare (NSObject[] objects, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V4))]global::System.Action<bool>? completionHandler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
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
			throw new You_Should_Not_Call_base_In_This_Method ();
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
			throw new You_Should_Not_Call_base_In_This_Method ();
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
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <summary>Returns the audio engine that is used to render sounds in the scene</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual global::AVFoundation.AVAudioEngine AudioEngine {
			[Export ("audioEngine")]
			get {
				throw new ModelNotImplementedException ();
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
			get {
				throw new ModelNotImplementedException ();
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
			get {
				throw new ModelNotImplementedException ();
			}
			[Export ("setAudioListener:", ArgumentSemantic.Retain)]
			set {
				throw new ModelNotImplementedException ();
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool AutoenablesDefaultLighting {
			[Export ("autoenablesDefaultLighting")]
			get {
				throw new ModelNotImplementedException ();
			}
			[Export ("setAutoenablesDefaultLighting:")]
			set {
				throw new ModelNotImplementedException ();
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
			get {
				throw new ModelNotImplementedException ();
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
			get {
				throw new ModelNotImplementedException ();
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
			get {
				throw new ModelNotImplementedException ();
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
			get {
				throw new ModelNotImplementedException ();
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public virtual global::Metal.MTLRenderPassDescriptor CurrentRenderPassDescriptor {
			[Export ("currentRenderPassDescriptor")]
			get {
				throw new ModelNotImplementedException ();
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public virtual CGRect CurrentViewport {
			[Export ("currentViewport")]
			get {
				throw new ModelNotImplementedException ();
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
			get {
				throw new ModelNotImplementedException ();
			}
			[Export ("setDebugOptions:", ArgumentSemantic.Assign)]
			set {
				throw new ModelNotImplementedException ();
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
			get {
				throw new ModelNotImplementedException ();
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
			get {
				throw new ModelNotImplementedException ();
			}
		}
		/// <summary>Gets or sets a Boolean value that controls whether SceneKit reduces aliasing by jittering the point of view.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool JitteringEnabled {
			[Export ("isJitteringEnabled")]
			get {
				throw new ModelNotImplementedException ();
			}
			[Export ("setJitteringEnabled:")]
			set {
				throw new ModelNotImplementedException ();
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool Loops {
			[Export ("loops")]
			get {
				throw new ModelNotImplementedException ();
			}
			[Export ("setLoops:")]
			set {
				throw new ModelNotImplementedException ();
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
			get {
				throw new ModelNotImplementedException ();
			}
			[Export ("setOverlaySKScene:", ArgumentSemantic.Retain)]
			set {
				throw new ModelNotImplementedException ();
			}
		}
		/// <summary>Gets or sets a Boolean value that starts and stops the scene.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool Playing {
			[Export ("isPlaying")]
			get {
				throw new ModelNotImplementedException ();
			}
			[Export ("setPlaying:")]
			set {
				throw new ModelNotImplementedException ();
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual SCNNode? PointOfView {
			[Export ("pointOfView", ArgumentSemantic.Retain)]
			get {
				throw new ModelNotImplementedException ();
			}
			[Export ("setPointOfView:", ArgumentSemantic.Retain)]
			set {
				throw new ModelNotImplementedException ();
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
			get {
				throw new ModelNotImplementedException ();
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
			get {
				throw new ModelNotImplementedException ();
			}
			[Export ("setScene:", ArgumentSemantic.Retain)]
			set {
				throw new ModelNotImplementedException ();
			}
		}
		/// <summary>Gets or sets the delegate for the renderer.</summary><value><para>(More documentation for this node is coming)</para><para tool="nullallowed">This value can be <see langword="null" />.</para></value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
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
			get {
				throw new ModelNotImplementedException ();
			}
			[Export ("setSceneTime:")]
			set {
				throw new ModelNotImplementedException ();
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
			get {
				throw new ModelNotImplementedException ();
			}
			[Export ("setShowsStatistics:")]
			set {
				throw new ModelNotImplementedException ();
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
			get {
				throw new ModelNotImplementedException ();
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public virtual bool TemporalAntialiasingEnabled {
			[Export ("isTemporalAntialiasingEnabled")]
			get {
				throw new ModelNotImplementedException ();
			}
			[Export ("setTemporalAntialiasingEnabled:")]
			set {
				throw new ModelNotImplementedException ();
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public virtual bool UsesReverseZ {
			[Export ("usesReverseZ")]
			get {
				throw new ModelNotImplementedException ();
			}
			[Export ("setUsesReverseZ:")]
			set {
				throw new ModelNotImplementedException ();
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject? WeakSceneRendererDelegate {
			[Export ("delegate", ArgumentSemantic.Weak)]
			get {
				throw new ModelNotImplementedException ();
			}
			[Export ("setDelegate:", ArgumentSemantic.Weak)]
			set {
				throw new ModelNotImplementedException ();
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		public virtual CGColorSpace WorkingColorSpace {
			[Export ("workingColorSpace")]
			get {
				throw new ModelNotImplementedException ();
			}
		}
	} /* class SCNSceneRenderer */
}
