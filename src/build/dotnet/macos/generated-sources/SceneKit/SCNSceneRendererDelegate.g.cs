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
	#pragma warning disable CS1573
	/// <summary>Delegate object for the SCNRenderer class, defines methods reflects rendering events.</summary><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/SceneKit/Reference/SCNSceneRendererDelegate_Protocol/index.html">Apple documentation for <c>SCNSceneRendererDelegate</c></related>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	[Protocol (Name = "SCNSceneRendererDelegate", WrapperType = typeof (SCNSceneRendererDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillRenderScene", Selector = "renderer:willRenderScene:atTime:", ParameterType = new Type [] { typeof (ISCNSceneRenderer), typeof (SCNScene), typeof (double) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidRenderScene", Selector = "renderer:didRenderScene:atTime:", ParameterType = new Type [] { typeof (ISCNSceneRenderer), typeof (SCNScene), typeof (double) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "Update", Selector = "renderer:updateAtTime:", ParameterType = new Type [] { typeof (ISCNSceneRenderer), typeof (double) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidApplyAnimations", Selector = "renderer:didApplyAnimationsAtTime:", ParameterType = new Type [] { typeof (ISCNSceneRenderer), typeof (double) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidSimulatePhysics", Selector = "renderer:didSimulatePhysicsAtTime:", ParameterType = new Type [] { typeof (ISCNSceneRenderer), typeof (double) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidApplyConstraints", Selector = "renderer:didApplyConstraintsAtTime:", ParameterType = new Type [] { typeof (ISCNSceneRenderer), typeof (double) }, ParameterByRef = new bool [] { false, false })]
	public partial interface ISCNSceneRendererDelegate : INativeObject, IDisposable
	{
		/// <param name="renderer">To be added.</param><param name="scene">To be added.</param><param name="timeInSeconds">To be added.</param><summary>Developers may override this method to do processing immediately prior to the rendering of the scene.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("renderer:willRenderScene:atTime:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillRenderScene (ISCNSceneRenderer renderer, SCNScene scene, double timeInSeconds)
		{
			_WillRenderScene (this, renderer, scene, timeInSeconds);
		}
		/// <param name="renderer">To be added.</param><param name="scene">To be added.</param><param name="timeInSeconds">To be added.</param><summary>Developers may override this method to do processing immediately prior to the rendering of the scene.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _WillRenderScene (ISCNSceneRendererDelegate This, ISCNSceneRenderer renderer, SCNScene scene, double timeInSeconds)
		{
			var renderer__handle__ = renderer!.GetNonNullHandle (nameof (renderer));
			var scene__handle__ = scene!.GetNonNullHandle (nameof (scene));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_Double (This.Handle, Selector.GetHandle ("renderer:willRenderScene:atTime:"), renderer__handle__, scene__handle__, timeInSeconds);
			GC.KeepAlive (This);
			GC.KeepAlive (renderer);
			GC.KeepAlive (scene);
		}
		/// <param name="renderer">To be added.</param><param name="scene">To be added.</param><param name="timeInSeconds">To be added.</param><summary>This method is called shortly after the scene has been rendered.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("renderer:didRenderScene:atTime:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidRenderScene (ISCNSceneRenderer renderer, SCNScene scene, double timeInSeconds)
		{
			_DidRenderScene (this, renderer, scene, timeInSeconds);
		}
		/// <param name="renderer">To be added.</param><param name="scene">To be added.</param><param name="timeInSeconds">To be added.</param><summary>This method is called shortly after the scene has been rendered.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidRenderScene (ISCNSceneRendererDelegate This, ISCNSceneRenderer renderer, SCNScene scene, double timeInSeconds)
		{
			var renderer__handle__ = renderer!.GetNonNullHandle (nameof (renderer));
			var scene__handle__ = scene!.GetNonNullHandle (nameof (scene));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_Double (This.Handle, Selector.GetHandle ("renderer:didRenderScene:atTime:"), renderer__handle__, scene__handle__, timeInSeconds);
			GC.KeepAlive (This);
			GC.KeepAlive (renderer);
			GC.KeepAlive (scene);
		}
		/// <param name="renderer">To be added.</param><param name="timeInSeconds">To be added.</param><summary>Developers may override this method to perform processing prior to any actions, animations, or physics simulations.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("renderer:updateAtTime:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Update (ISCNSceneRenderer renderer, double timeInSeconds)
		{
			_Update (this, renderer, timeInSeconds);
		}
		/// <param name="renderer">To be added.</param><param name="timeInSeconds">To be added.</param><summary>Developers may override this method to perform processing prior to any actions, animations, or physics simulations.</summary><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _Update (ISCNSceneRendererDelegate This, ISCNSceneRenderer renderer, double timeInSeconds)
		{
			var renderer__handle__ = renderer!.GetNonNullHandle (nameof (renderer));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_Double (This.Handle, Selector.GetHandle ("renderer:updateAtTime:"), renderer__handle__, timeInSeconds);
			GC.KeepAlive (This);
			GC.KeepAlive (renderer);
		}
		/// <param name="renderer">To be added.</param><param name="timeInSeconds">To be added.</param><summary>Developers may override this method to react to the completion of animations.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("renderer:didApplyAnimationsAtTime:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidApplyAnimations (ISCNSceneRenderer renderer, double timeInSeconds)
		{
			_DidApplyAnimations (this, renderer, timeInSeconds);
		}
		/// <param name="renderer">To be added.</param><param name="timeInSeconds">To be added.</param><summary>Developers may override this method to react to the completion of animations.</summary><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidApplyAnimations (ISCNSceneRendererDelegate This, ISCNSceneRenderer renderer, double timeInSeconds)
		{
			var renderer__handle__ = renderer!.GetNonNullHandle (nameof (renderer));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_Double (This.Handle, Selector.GetHandle ("renderer:didApplyAnimationsAtTime:"), renderer__handle__, timeInSeconds);
			GC.KeepAlive (This);
			GC.KeepAlive (renderer);
		}
		/// <param name="renderer">To be added.</param><param name="timeInSeconds">To be added.</param><summary>This method is called shortly after physics have been simulated.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("renderer:didSimulatePhysicsAtTime:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidSimulatePhysics (ISCNSceneRenderer renderer, double timeInSeconds)
		{
			_DidSimulatePhysics (this, renderer, timeInSeconds);
		}
		/// <param name="renderer">To be added.</param><param name="timeInSeconds">To be added.</param><summary>This method is called shortly after physics have been simulated.</summary><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidSimulatePhysics (ISCNSceneRendererDelegate This, ISCNSceneRenderer renderer, double timeInSeconds)
		{
			var renderer__handle__ = renderer!.GetNonNullHandle (nameof (renderer));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_Double (This.Handle, Selector.GetHandle ("renderer:didSimulatePhysicsAtTime:"), renderer__handle__, timeInSeconds);
			GC.KeepAlive (This);
			GC.KeepAlive (renderer);
		}
		/// <param name="renderer">To be added.</param><param name="atTime">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("renderer:didApplyConstraintsAtTime:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidApplyConstraints (ISCNSceneRenderer renderer, double atTime)
		{
			_DidApplyConstraints (this, renderer, atTime);
		}
		/// <param name="renderer">To be added.</param><param name="atTime">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidApplyConstraints (ISCNSceneRendererDelegate This, ISCNSceneRenderer renderer, double atTime)
		{
			var renderer__handle__ = renderer!.GetNonNullHandle (nameof (renderer));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_Double (This.Handle, Selector.GetHandle ("renderer:didApplyConstraintsAtTime:"), renderer__handle__, atTime);
			GC.KeepAlive (This);
			GC.KeepAlive (renderer);
		}
		[DynamicDependencyAttribute ("DidApplyAnimations(SceneKit.ISCNSceneRenderer,System.Double)")]
		[DynamicDependencyAttribute ("DidApplyConstraints(SceneKit.ISCNSceneRenderer,System.Double)")]
		[DynamicDependencyAttribute ("DidRenderScene(SceneKit.ISCNSceneRenderer,SceneKit.SCNScene,System.Double)")]
		[DynamicDependencyAttribute ("DidSimulatePhysics(SceneKit.ISCNSceneRenderer,System.Double)")]
		[DynamicDependencyAttribute ("Update(SceneKit.ISCNSceneRenderer,System.Double)")]
		[DynamicDependencyAttribute ("WillRenderScene(SceneKit.ISCNSceneRenderer,SceneKit.SCNScene,System.Double)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (SCNSceneRendererDelegateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static ISCNSceneRendererDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="ISCNSceneRendererDelegate" /> interface to support all the methods from the SCNSceneRendererDelegate protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="ISCNSceneRendererDelegate" /> interface allow developers to treat instances of the interface as having all the optional methods of the original SCNSceneRendererDelegate protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class SCNSceneRendererDelegate_Extensions {
		/// <param name="renderer">To be added.</param><param name="scene">To be added.</param><param name="timeInSeconds">To be added.</param><summary>Developers may override this method to do processing immediately prior to the rendering of the scene.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void WillRenderScene (this ISCNSceneRendererDelegate This, ISCNSceneRenderer renderer, SCNScene scene, double timeInSeconds)
		{
			var renderer__handle__ = renderer!.GetNonNullHandle (nameof (renderer));
			var scene__handle__ = scene!.GetNonNullHandle (nameof (scene));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_Double (This.Handle, Selector.GetHandle ("renderer:willRenderScene:atTime:"), renderer__handle__, scene__handle__, timeInSeconds);
			GC.KeepAlive (This);
			GC.KeepAlive (renderer);
			GC.KeepAlive (scene);
		}
		/// <param name="renderer">To be added.</param><param name="scene">To be added.</param><param name="timeInSeconds">To be added.</param><summary>This method is called shortly after the scene has been rendered.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidRenderScene (this ISCNSceneRendererDelegate This, ISCNSceneRenderer renderer, SCNScene scene, double timeInSeconds)
		{
			var renderer__handle__ = renderer!.GetNonNullHandle (nameof (renderer));
			var scene__handle__ = scene!.GetNonNullHandle (nameof (scene));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_Double (This.Handle, Selector.GetHandle ("renderer:didRenderScene:atTime:"), renderer__handle__, scene__handle__, timeInSeconds);
			GC.KeepAlive (This);
			GC.KeepAlive (renderer);
			GC.KeepAlive (scene);
		}
		/// <param name="renderer">To be added.</param><param name="timeInSeconds">To be added.</param><summary>Developers may override this method to perform processing prior to any actions, animations, or physics simulations.</summary><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void Update (this ISCNSceneRendererDelegate This, ISCNSceneRenderer renderer, double timeInSeconds)
		{
			var renderer__handle__ = renderer!.GetNonNullHandle (nameof (renderer));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_Double (This.Handle, Selector.GetHandle ("renderer:updateAtTime:"), renderer__handle__, timeInSeconds);
			GC.KeepAlive (This);
			GC.KeepAlive (renderer);
		}
		/// <param name="renderer">To be added.</param><param name="timeInSeconds">To be added.</param><summary>Developers may override this method to react to the completion of animations.</summary><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidApplyAnimations (this ISCNSceneRendererDelegate This, ISCNSceneRenderer renderer, double timeInSeconds)
		{
			var renderer__handle__ = renderer!.GetNonNullHandle (nameof (renderer));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_Double (This.Handle, Selector.GetHandle ("renderer:didApplyAnimationsAtTime:"), renderer__handle__, timeInSeconds);
			GC.KeepAlive (This);
			GC.KeepAlive (renderer);
		}
		/// <param name="renderer">To be added.</param><param name="timeInSeconds">To be added.</param><summary>This method is called shortly after physics have been simulated.</summary><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidSimulatePhysics (this ISCNSceneRendererDelegate This, ISCNSceneRenderer renderer, double timeInSeconds)
		{
			var renderer__handle__ = renderer!.GetNonNullHandle (nameof (renderer));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_Double (This.Handle, Selector.GetHandle ("renderer:didSimulatePhysicsAtTime:"), renderer__handle__, timeInSeconds);
			GC.KeepAlive (This);
			GC.KeepAlive (renderer);
		}
		/// <param name="renderer">To be added.</param><param name="atTime">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidApplyConstraints (this ISCNSceneRendererDelegate This, ISCNSceneRenderer renderer, double atTime)
		{
			var renderer__handle__ = renderer!.GetNonNullHandle (nameof (renderer));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_Double (This.Handle, Selector.GetHandle ("renderer:didApplyConstraintsAtTime:"), renderer__handle__, atTime);
			GC.KeepAlive (This);
			GC.KeepAlive (renderer);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class SCNSceneRendererDelegateWrapper : BaseWrapper, ISCNSceneRendererDelegate {
		public SCNSceneRendererDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (SCNSceneRendererDelegateWrapper))]
		static SCNSceneRendererDelegateWrapper ()
		{
			GC.KeepAlive (null);
		}
	}
}
namespace SceneKit {
	/// <summary>Delegate object for the SCNRenderer class, defines methods reflects rendering events.</summary><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/SceneKit/Reference/SCNSceneRendererDelegate_Protocol/index.html">Apple documentation for <c>SCNSceneRendererDelegate</c></related>
	[Protocol()]
	[Register("Microsoft_macOS__SceneKit_SCNSceneRendererDelegate", false)]
	[Model]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe partial class SCNSceneRendererDelegate : NSObject, ISCNSceneRendererDelegate {
		/// <summary>Creates a new <see cref="SCNSceneRendererDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public SCNSceneRendererDelegate () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = false;
			unsafe {
			var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
			InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, global::ObjCRuntime.Selector.Init), "init");
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
		protected SCNSceneRendererDelegate (NSObjectFlag t) : base (t)
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
		protected internal SCNSceneRendererDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		/// <param name="renderer">To be added.</param><param name="timeInSeconds">To be added.</param><summary>Developers may override this method to react to the completion of animations.</summary><remarks>To be added.</remarks>
		[Export ("renderer:didApplyAnimationsAtTime:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidApplyAnimations (ISCNSceneRenderer renderer, double timeInSeconds)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="renderer">To be added.</param><param name="atTime">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("renderer:didApplyConstraintsAtTime:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidApplyConstraints (ISCNSceneRenderer renderer, double atTime)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="renderer">To be added.</param><param name="scene">To be added.</param><param name="timeInSeconds">To be added.</param><summary>This method is called shortly after the scene has been rendered.</summary><remarks>To be added.</remarks>
		[Export ("renderer:didRenderScene:atTime:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidRenderScene (ISCNSceneRenderer renderer, SCNScene scene, double timeInSeconds)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="renderer">To be added.</param><param name="timeInSeconds">To be added.</param><summary>This method is called shortly after physics have been simulated.</summary><remarks>To be added.</remarks>
		[Export ("renderer:didSimulatePhysicsAtTime:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidSimulatePhysics (ISCNSceneRenderer renderer, double timeInSeconds)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="renderer">To be added.</param><param name="timeInSeconds">To be added.</param><summary>Developers may override this method to perform processing prior to any actions, animations, or physics simulations.</summary><remarks>To be added.</remarks>
		[Export ("renderer:updateAtTime:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Update (ISCNSceneRenderer renderer, double timeInSeconds)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="renderer">To be added.</param><param name="scene">To be added.</param><param name="timeInSeconds">To be added.</param><summary>Developers may override this method to do processing immediately prior to the rendering of the scene.</summary><remarks>To be added.</remarks>
		[Export ("renderer:willRenderScene:atTime:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillRenderScene (ISCNSceneRenderer renderer, SCNScene scene, double timeInSeconds)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class SCNSceneRendererDelegate */
}
