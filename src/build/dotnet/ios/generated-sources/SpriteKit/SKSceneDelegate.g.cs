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
namespace SpriteKit {
	#pragma warning disable CS1573
	/// <summary>Delegate object for SKScene objects. Provides methods relating to animation events.</summary><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/SpriteKit/Reference/SKSceneDelegate_Ref/index.html">Apple documentation for <c>SKSceneDelegate</c></related>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	[Protocol (Name = "SKSceneDelegate", WrapperType = typeof (SKSceneDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "Update", Selector = "update:forScene:", ParameterType = new Type [] { typeof (double), typeof (SKScene) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidEvaluateActions", Selector = "didEvaluateActionsForScene:", ParameterType = new Type [] { typeof (SKScene) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidSimulatePhysics", Selector = "didSimulatePhysicsForScene:", ParameterType = new Type [] { typeof (SKScene) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidApplyConstraints", Selector = "didApplyConstraintsForScene:", ParameterType = new Type [] { typeof (SKScene) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidFinishUpdate", Selector = "didFinishUpdateForScene:", ParameterType = new Type [] { typeof (SKScene) }, ParameterByRef = new bool [] { false })]
	public partial interface ISKSceneDelegate : INativeObject, IDisposable
	{
		/// <param name="currentTime">To be added.</param><param name="scene">To be added.</param><summary>Method that is called once per frame, if <paramref name="scene" /> is presented and not paused, before any animation takes place.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("update:forScene:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Update (double currentTime, SKScene scene)
		{
			_Update (this, currentTime, scene);
		}
		/// <param name="currentTime">To be added.</param><param name="scene">To be added.</param><summary>Method that is called once per frame, if <paramref name="scene" /> is presented and not paused, before any animation takes place.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _Update (ISKSceneDelegate This, double currentTime, SKScene scene)
		{
			var scene__handle__ = scene!.GetNonNullHandle (nameof (scene));
			global::ObjCRuntime.Messaging.void_objc_msgSend_Double_NativeHandle (This.Handle, Selector.GetHandle ("update:forScene:"), currentTime, scene__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (scene);
		}
		/// <param name="scene">To be added.</param><summary>Method that is called after all scene actions are evaluated for <paramref name="scene" />.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("didEvaluateActionsForScene:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidEvaluateActions (SKScene scene)
		{
			_DidEvaluateActions (this, scene);
		}
		/// <param name="scene">To be added.</param><summary>Method that is called after all scene actions are evaluated for <paramref name="scene" />.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidEvaluateActions (ISKSceneDelegate This, SKScene scene)
		{
			var scene__handle__ = scene!.GetNonNullHandle (nameof (scene));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("didEvaluateActionsForScene:"), scene__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (scene);
		}
		/// <param name="scene">To be added.</param><summary>Method that is called after physics simulation for <paramref name="scene" /> is complete.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("didSimulatePhysicsForScene:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidSimulatePhysics (SKScene scene)
		{
			_DidSimulatePhysics (this, scene);
		}
		/// <param name="scene">To be added.</param><summary>Method that is called after physics simulation for <paramref name="scene" /> is complete.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidSimulatePhysics (ISKSceneDelegate This, SKScene scene)
		{
			var scene__handle__ = scene!.GetNonNullHandle (nameof (scene));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("didSimulatePhysicsForScene:"), scene__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (scene);
		}
		/// <param name="scene">To be added.</param><summary>Method that is called after constraints are applied to <paramref name="scene" />.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("didApplyConstraintsForScene:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidApplyConstraints (SKScene scene)
		{
			_DidApplyConstraints (this, scene);
		}
		/// <param name="scene">To be added.</param><summary>Method that is called after constraints are applied to <paramref name="scene" />.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidApplyConstraints (ISKSceneDelegate This, SKScene scene)
		{
			var scene__handle__ = scene!.GetNonNullHandle (nameof (scene));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("didApplyConstraintsForScene:"), scene__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (scene);
		}
		/// <param name="scene">To be added.</param><summary>Method that is called after the <paramref name="scene" /> is updated.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("didFinishUpdateForScene:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidFinishUpdate (SKScene scene)
		{
			_DidFinishUpdate (this, scene);
		}
		/// <param name="scene">To be added.</param><summary>Method that is called after the <paramref name="scene" /> is updated.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidFinishUpdate (ISKSceneDelegate This, SKScene scene)
		{
			var scene__handle__ = scene!.GetNonNullHandle (nameof (scene));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("didFinishUpdateForScene:"), scene__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (scene);
		}
		[DynamicDependencyAttribute ("DidApplyConstraints(SpriteKit.SKScene)")]
		[DynamicDependencyAttribute ("DidEvaluateActions(SpriteKit.SKScene)")]
		[DynamicDependencyAttribute ("DidFinishUpdate(SpriteKit.SKScene)")]
		[DynamicDependencyAttribute ("DidSimulatePhysics(SpriteKit.SKScene)")]
		[DynamicDependencyAttribute ("Update(System.Double,SpriteKit.SKScene)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (SKSceneDelegateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static ISKSceneDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="ISKSceneDelegate" /> interface to support all the methods from the SKSceneDelegate protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="ISKSceneDelegate" /> interface allow developers to treat instances of the interface as having all the optional methods of the original SKSceneDelegate protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class SKSceneDelegate_Extensions {
		/// <param name="currentTime">To be added.</param><param name="scene">To be added.</param><summary>Method that is called once per frame, if <paramref name="scene" /> is presented and not paused, before any animation takes place.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void Update (this ISKSceneDelegate This, double currentTime, SKScene scene)
		{
			var scene__handle__ = scene!.GetNonNullHandle (nameof (scene));
			global::ObjCRuntime.Messaging.void_objc_msgSend_Double_NativeHandle (This.Handle, Selector.GetHandle ("update:forScene:"), currentTime, scene__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (scene);
		}
		/// <param name="scene">To be added.</param><summary>Method that is called after all scene actions are evaluated for <paramref name="scene" />.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidEvaluateActions (this ISKSceneDelegate This, SKScene scene)
		{
			var scene__handle__ = scene!.GetNonNullHandle (nameof (scene));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("didEvaluateActionsForScene:"), scene__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (scene);
		}
		/// <param name="scene">To be added.</param><summary>Method that is called after physics simulation for <paramref name="scene" /> is complete.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidSimulatePhysics (this ISKSceneDelegate This, SKScene scene)
		{
			var scene__handle__ = scene!.GetNonNullHandle (nameof (scene));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("didSimulatePhysicsForScene:"), scene__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (scene);
		}
		/// <param name="scene">To be added.</param><summary>Method that is called after constraints are applied to <paramref name="scene" />.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidApplyConstraints (this ISKSceneDelegate This, SKScene scene)
		{
			var scene__handle__ = scene!.GetNonNullHandle (nameof (scene));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("didApplyConstraintsForScene:"), scene__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (scene);
		}
		/// <param name="scene">To be added.</param><summary>Method that is called after the <paramref name="scene" /> is updated.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidFinishUpdate (this ISKSceneDelegate This, SKScene scene)
		{
			var scene__handle__ = scene!.GetNonNullHandle (nameof (scene));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("didFinishUpdateForScene:"), scene__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (scene);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class SKSceneDelegateWrapper : BaseWrapper, ISKSceneDelegate {
		public SKSceneDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (SKSceneDelegateWrapper))]
		static SKSceneDelegateWrapper ()
		{
			GC.KeepAlive (null);
		}
	}
}
namespace SpriteKit {
	/// <summary>Delegate object for SKScene objects. Provides methods relating to animation events.</summary><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/SpriteKit/Reference/SKSceneDelegate_Ref/index.html">Apple documentation for <c>SKSceneDelegate</c></related>
	[Protocol()]
	[Register("Microsoft_iOS__SpriteKit_SKSceneDelegate", false)]
	[Model]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe partial class SKSceneDelegate : NSObject, ISKSceneDelegate {
		/// <summary>Creates a new <see cref="SKSceneDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public SKSceneDelegate () : base (NSObjectFlag.Empty)
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
		protected SKSceneDelegate (NSObjectFlag t) : base (t)
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
		protected internal SKSceneDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		/// <param name="scene">To be added.</param><summary>Method that is called after constraints are applied to <paramref name="scene" />.</summary><remarks>To be added.</remarks>
		[Export ("didApplyConstraintsForScene:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidApplyConstraints (SKScene scene)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="scene">To be added.</param><summary>Method that is called after all scene actions are evaluated for <paramref name="scene" />.</summary><remarks>To be added.</remarks>
		[Export ("didEvaluateActionsForScene:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidEvaluateActions (SKScene scene)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="scene">To be added.</param><summary>Method that is called after the <paramref name="scene" /> is updated.</summary><remarks>To be added.</remarks>
		[Export ("didFinishUpdateForScene:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidFinishUpdate (SKScene scene)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="scene">To be added.</param><summary>Method that is called after physics simulation for <paramref name="scene" /> is complete.</summary><remarks>To be added.</remarks>
		[Export ("didSimulatePhysicsForScene:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidSimulatePhysics (SKScene scene)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="currentTime">To be added.</param><param name="scene">To be added.</param><summary>Method that is called once per frame, if <paramref name="scene" /> is presented and not paused, before any animation takes place.</summary><remarks>To be added.</remarks>
		[Export ("update:forScene:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Update (double currentTime, SKScene scene)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class SKSceneDelegate */
}
