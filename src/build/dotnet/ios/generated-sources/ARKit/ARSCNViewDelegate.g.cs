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
namespace ARKit {
	#pragma warning disable CS1573
	/// <summary>Delegate object for <see cref="T:ARKit.ARSCNView" /> objects.</summary>
	[UnsupportedOSPlatform ("tvos")]
	[UnsupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("ios")]
	[Protocol (Name = "ARSCNViewDelegate", WrapperType = typeof (ARSCNViewDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetNode", Selector = "renderer:nodeForAnchor:", ReturnType = typeof (SCNNode), ParameterType = new Type [] { typeof (ISCNSceneRenderer), typeof (ARKit.ARAnchor) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidAddNode", Selector = "renderer:didAddNode:forAnchor:", ParameterType = new Type [] { typeof (ISCNSceneRenderer), typeof (SCNNode), typeof (ARKit.ARAnchor) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillUpdateNode", Selector = "renderer:willUpdateNode:forAnchor:", ParameterType = new Type [] { typeof (ISCNSceneRenderer), typeof (SCNNode), typeof (ARKit.ARAnchor) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidUpdateNode", Selector = "renderer:didUpdateNode:forAnchor:", ParameterType = new Type [] { typeof (ISCNSceneRenderer), typeof (SCNNode), typeof (ARKit.ARAnchor) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidRemoveNode", Selector = "renderer:didRemoveNode:forAnchor:", ParameterType = new Type [] { typeof (ISCNSceneRenderer), typeof (SCNNode), typeof (ARKit.ARAnchor) }, ParameterByRef = new bool [] { false, false, false })]
	public partial interface IARSCNViewDelegate : INativeObject, IDisposable, 
		ARKit.IARSessionObserver
		, SceneKit.ISCNSceneRendererDelegate
	{
		/// <param name="renderer">The renderer for the scene.</param><param name="anchor">The anchor for the node to get.</param><summary>Retrieves the <see cref="T:SceneKit.SCNNode" /> corresponding to the specified <paramref name="anchor" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("renderer:nodeForAnchor:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::SceneKit.SCNNode? GetNode (global::SceneKit.ISCNSceneRenderer renderer, ARAnchor anchor)
		{
			return _GetNode (this, renderer, anchor);
		}
		/// <param name="renderer">The renderer for the scene.</param><param name="anchor">The anchor for the node to get.</param><summary>Retrieves the <see cref="T:SceneKit.SCNNode" /> corresponding to the specified <paramref name="anchor" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static global::SceneKit.SCNNode? _GetNode (IARSCNViewDelegate This, global::SceneKit.ISCNSceneRenderer renderer, ARAnchor anchor)
		{
			var renderer__handle__ = renderer!.GetNonNullHandle (nameof (renderer));
			var anchor__handle__ = anchor!.GetNonNullHandle (nameof (anchor));
			global::SceneKit.SCNNode? ret;
			ret =  Runtime.GetNSObject<global::SceneKit.SCNNode> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("renderer:nodeForAnchor:"), renderer__handle__, anchor__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (renderer);
			GC.KeepAlive (anchor);
			return ret!;
		}
		/// <param name="renderer">The renderer for the event.</param><param name="node">The node that was added.</param><param name="anchor">The anchor for the node that was added.</param><summary>Developers may override this method to react to the adding of a <see cref="T:SceneKit.SCNNode" /> that corresponds to a new <see cref="T:ARKit.ARAnchor" />.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("renderer:didAddNode:forAnchor:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidAddNode (global::SceneKit.ISCNSceneRenderer renderer, global::SceneKit.SCNNode node, ARAnchor anchor)
		{
			_DidAddNode (this, renderer, node, anchor);
		}
		/// <param name="renderer">The renderer for the event.</param><param name="node">The node that was added.</param><param name="anchor">The anchor for the node that was added.</param><summary>Developers may override this method to react to the adding of a <see cref="T:SceneKit.SCNNode" /> that corresponds to a new <see cref="T:ARKit.ARAnchor" />.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidAddNode (IARSCNViewDelegate This, global::SceneKit.ISCNSceneRenderer renderer, global::SceneKit.SCNNode node, ARAnchor anchor)
		{
			var renderer__handle__ = renderer!.GetNonNullHandle (nameof (renderer));
			var node__handle__ = node!.GetNonNullHandle (nameof (node));
			var anchor__handle__ = anchor!.GetNonNullHandle (nameof (anchor));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("renderer:didAddNode:forAnchor:"), renderer__handle__, node__handle__, anchor__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (renderer);
			GC.KeepAlive (node);
			GC.KeepAlive (anchor);
		}
		/// <param name="renderer">The renderer for the scene.</param><param name="node">The node that will be updated.</param><param name="anchor">The anchor for the node that will be updated.</param><summary>This method is called shortly before the properties of <paramref name="node" /> are updated to reflect the state of <paramref name="anchor" />.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("renderer:willUpdateNode:forAnchor:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillUpdateNode (global::SceneKit.ISCNSceneRenderer renderer, global::SceneKit.SCNNode node, ARAnchor anchor)
		{
			_WillUpdateNode (this, renderer, node, anchor);
		}
		/// <param name="renderer">The renderer for the scene.</param><param name="node">The node that will be updated.</param><param name="anchor">The anchor for the node that will be updated.</param><summary>This method is called shortly before the properties of <paramref name="node" /> are updated to reflect the state of <paramref name="anchor" />.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _WillUpdateNode (IARSCNViewDelegate This, global::SceneKit.ISCNSceneRenderer renderer, global::SceneKit.SCNNode node, ARAnchor anchor)
		{
			var renderer__handle__ = renderer!.GetNonNullHandle (nameof (renderer));
			var node__handle__ = node!.GetNonNullHandle (nameof (node));
			var anchor__handle__ = anchor!.GetNonNullHandle (nameof (anchor));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("renderer:willUpdateNode:forAnchor:"), renderer__handle__, node__handle__, anchor__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (renderer);
			GC.KeepAlive (node);
			GC.KeepAlive (anchor);
		}
		/// <param name="renderer">The renderer for the scene.</param><param name="node">The node that was updated.</param><param name="anchor">The anchor for the node that was updated.</param><summary>This method is called shortly after <paramref name="node" /> has been updated to reflect the current state of <paramref name="anchor" />.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("renderer:didUpdateNode:forAnchor:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidUpdateNode (global::SceneKit.ISCNSceneRenderer renderer, global::SceneKit.SCNNode node, ARAnchor anchor)
		{
			_DidUpdateNode (this, renderer, node, anchor);
		}
		/// <param name="renderer">The renderer for the scene.</param><param name="node">The node that was updated.</param><param name="anchor">The anchor for the node that was updated.</param><summary>This method is called shortly after <paramref name="node" /> has been updated to reflect the current state of <paramref name="anchor" />.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidUpdateNode (IARSCNViewDelegate This, global::SceneKit.ISCNSceneRenderer renderer, global::SceneKit.SCNNode node, ARAnchor anchor)
		{
			var renderer__handle__ = renderer!.GetNonNullHandle (nameof (renderer));
			var node__handle__ = node!.GetNonNullHandle (nameof (node));
			var anchor__handle__ = anchor!.GetNonNullHandle (nameof (anchor));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("renderer:didUpdateNode:forAnchor:"), renderer__handle__, node__handle__, anchor__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (renderer);
			GC.KeepAlive (node);
			GC.KeepAlive (anchor);
		}
		/// <param name="renderer">The renderer for the scene.</param><param name="node">The node that was removed.</param><param name="anchor">The anchor for the node that was removed.</param><summary>Developers may override this method to react to the removal of <paramref name="node" />, which was removed after <paramref name="anchor" /> was removed.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("renderer:didRemoveNode:forAnchor:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidRemoveNode (global::SceneKit.ISCNSceneRenderer renderer, global::SceneKit.SCNNode node, ARAnchor anchor)
		{
			_DidRemoveNode (this, renderer, node, anchor);
		}
		/// <param name="renderer">The renderer for the scene.</param><param name="node">The node that was removed.</param><param name="anchor">The anchor for the node that was removed.</param><summary>Developers may override this method to react to the removal of <paramref name="node" />, which was removed after <paramref name="anchor" /> was removed.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidRemoveNode (IARSCNViewDelegate This, global::SceneKit.ISCNSceneRenderer renderer, global::SceneKit.SCNNode node, ARAnchor anchor)
		{
			var renderer__handle__ = renderer!.GetNonNullHandle (nameof (renderer));
			var node__handle__ = node!.GetNonNullHandle (nameof (node));
			var anchor__handle__ = anchor!.GetNonNullHandle (nameof (anchor));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("renderer:didRemoveNode:forAnchor:"), renderer__handle__, node__handle__, anchor__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (renderer);
			GC.KeepAlive (node);
			GC.KeepAlive (anchor);
		}
		[DynamicDependencyAttribute ("DidAddNode(SceneKit.ISCNSceneRenderer,SceneKit.SCNNode,ARKit.ARAnchor)")]
		[DynamicDependencyAttribute ("DidRemoveNode(SceneKit.ISCNSceneRenderer,SceneKit.SCNNode,ARKit.ARAnchor)")]
		[DynamicDependencyAttribute ("DidUpdateNode(SceneKit.ISCNSceneRenderer,SceneKit.SCNNode,ARKit.ARAnchor)")]
		[DynamicDependencyAttribute ("GetNode(SceneKit.ISCNSceneRenderer,ARKit.ARAnchor)")]
		[DynamicDependencyAttribute ("WillUpdateNode(SceneKit.ISCNSceneRenderer,SceneKit.SCNNode,ARKit.ARAnchor)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (ARSCNViewDelegateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IARSCNViewDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="IARSCNViewDelegate" /> interface to support all the methods from the ARSCNViewDelegate protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IARSCNViewDelegate" /> interface allow developers to treat instances of the interface as having all the optional methods of the original ARSCNViewDelegate protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class ARSCNViewDelegate_Extensions {
		/// <param name="renderer">The renderer for the scene.</param><param name="anchor">The anchor for the node to get.</param><summary>Retrieves the <see cref="T:SceneKit.SCNNode" /> corresponding to the specified <paramref name="anchor" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static global::SceneKit.SCNNode? GetNode (this IARSCNViewDelegate This, global::SceneKit.ISCNSceneRenderer renderer, ARAnchor anchor)
		{
			var renderer__handle__ = renderer!.GetNonNullHandle (nameof (renderer));
			var anchor__handle__ = anchor!.GetNonNullHandle (nameof (anchor));
			global::SceneKit.SCNNode? ret;
			ret =  Runtime.GetNSObject<global::SceneKit.SCNNode> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("renderer:nodeForAnchor:"), renderer__handle__, anchor__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (renderer);
			GC.KeepAlive (anchor);
			return ret!;
		}
		/// <param name="renderer">The renderer for the event.</param><param name="node">The node that was added.</param><param name="anchor">The anchor for the node that was added.</param><summary>Developers may override this method to react to the adding of a <see cref="T:SceneKit.SCNNode" /> that corresponds to a new <see cref="T:ARKit.ARAnchor" />.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidAddNode (this IARSCNViewDelegate This, global::SceneKit.ISCNSceneRenderer renderer, global::SceneKit.SCNNode node, ARAnchor anchor)
		{
			var renderer__handle__ = renderer!.GetNonNullHandle (nameof (renderer));
			var node__handle__ = node!.GetNonNullHandle (nameof (node));
			var anchor__handle__ = anchor!.GetNonNullHandle (nameof (anchor));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("renderer:didAddNode:forAnchor:"), renderer__handle__, node__handle__, anchor__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (renderer);
			GC.KeepAlive (node);
			GC.KeepAlive (anchor);
		}
		/// <param name="renderer">The renderer for the scene.</param><param name="node">The node that will be updated.</param><param name="anchor">The anchor for the node that will be updated.</param><summary>This method is called shortly before the properties of <paramref name="node" /> are updated to reflect the state of <paramref name="anchor" />.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void WillUpdateNode (this IARSCNViewDelegate This, global::SceneKit.ISCNSceneRenderer renderer, global::SceneKit.SCNNode node, ARAnchor anchor)
		{
			var renderer__handle__ = renderer!.GetNonNullHandle (nameof (renderer));
			var node__handle__ = node!.GetNonNullHandle (nameof (node));
			var anchor__handle__ = anchor!.GetNonNullHandle (nameof (anchor));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("renderer:willUpdateNode:forAnchor:"), renderer__handle__, node__handle__, anchor__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (renderer);
			GC.KeepAlive (node);
			GC.KeepAlive (anchor);
		}
		/// <param name="renderer">The renderer for the scene.</param><param name="node">The node that was updated.</param><param name="anchor">The anchor for the node that was updated.</param><summary>This method is called shortly after <paramref name="node" /> has been updated to reflect the current state of <paramref name="anchor" />.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidUpdateNode (this IARSCNViewDelegate This, global::SceneKit.ISCNSceneRenderer renderer, global::SceneKit.SCNNode node, ARAnchor anchor)
		{
			var renderer__handle__ = renderer!.GetNonNullHandle (nameof (renderer));
			var node__handle__ = node!.GetNonNullHandle (nameof (node));
			var anchor__handle__ = anchor!.GetNonNullHandle (nameof (anchor));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("renderer:didUpdateNode:forAnchor:"), renderer__handle__, node__handle__, anchor__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (renderer);
			GC.KeepAlive (node);
			GC.KeepAlive (anchor);
		}
		/// <param name="renderer">The renderer for the scene.</param><param name="node">The node that was removed.</param><param name="anchor">The anchor for the node that was removed.</param><summary>Developers may override this method to react to the removal of <paramref name="node" />, which was removed after <paramref name="anchor" /> was removed.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidRemoveNode (this IARSCNViewDelegate This, global::SceneKit.ISCNSceneRenderer renderer, global::SceneKit.SCNNode node, ARAnchor anchor)
		{
			var renderer__handle__ = renderer!.GetNonNullHandle (nameof (renderer));
			var node__handle__ = node!.GetNonNullHandle (nameof (node));
			var anchor__handle__ = anchor!.GetNonNullHandle (nameof (anchor));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("renderer:didRemoveNode:forAnchor:"), renderer__handle__, node__handle__, anchor__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (renderer);
			GC.KeepAlive (node);
			GC.KeepAlive (anchor);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class ARSCNViewDelegateWrapper : BaseWrapper, IARSCNViewDelegate {
		public ARSCNViewDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (ARSCNViewDelegateWrapper))]
		static ARSCNViewDelegateWrapper ()
		{
			GC.KeepAlive (null);
		}
	}
}
namespace ARKit {
	/// <summary>Delegate object for <see cref="T:ARKit.ARSCNView" /> objects.</summary>
	[Protocol()]
	[Register("Microsoft_iOS__ARKit_ARSCNViewDelegate", false)]
	[Model]
	[UnsupportedOSPlatform ("tvos")]
	[UnsupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("ios")]
	public unsafe partial class ARSCNViewDelegate : NSObject, IARSCNViewDelegate, IARSessionObserver, global::SceneKit.ISCNSceneRendererDelegate {
		/// <summary>Creates a new <see cref="ARSCNViewDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public ARSCNViewDelegate () : base (NSObjectFlag.Empty)
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
		protected ARSCNViewDelegate (NSObjectFlag t) : base (t)
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
		protected internal ARSCNViewDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		/// <param name="session">The session that is supplying the information for the event.</param><param name="camera">The camera whose tracking state changed.</param><summary>Called when the <see cref="P:ARKit.ARCamera.TrackingState" /> changes, indicating a change in tracking quality.</summary><remarks>To be added.</remarks>
		[Export ("session:cameraDidChangeTrackingState:")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void CameraDidChangeTrackingState (ARSession session, ARCamera camera)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="renderer">The renderer for the event.</param><param name="node">The node that was added.</param><param name="anchor">The anchor for the node that was added.</param><summary>Developers may override this method to react to the adding of a <see cref="T:SceneKit.SCNNode" /> that corresponds to a new <see cref="T:ARKit.ARAnchor" />.</summary><remarks>To be added.</remarks>
		[Export ("renderer:didAddNode:forAnchor:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidAddNode (global::SceneKit.ISCNSceneRenderer renderer, global::SceneKit.SCNNode node, ARAnchor anchor)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="renderer">To be added.</param><param name="timeInSeconds">To be added.</param><summary>Developers may override this method to react to the completion of animations.</summary><remarks>To be added.</remarks>
		[Export ("renderer:didApplyAnimationsAtTime:")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidApplyAnimations (global::SceneKit.ISCNSceneRenderer renderer, double timeInSeconds)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="renderer">To be added.</param><param name="atTime">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("renderer:didApplyConstraintsAtTime:")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidApplyConstraints (global::SceneKit.ISCNSceneRenderer renderer, double atTime)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("session:didChangeGeoTrackingStatus:")]
		[SupportedOSPlatform ("ios14.0")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidChangeGeoTrackingStatus (ARSession session, ARGeoTrackingStatus geoTrackingStatus)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="session">The session that is supplying the information for the event.</param><param name="error">The error that occurred.</param><summary>Called when the <paramref name="session" /> stops running due to an error.</summary><remarks>To be added.</remarks>
		[Export ("session:didFailWithError:")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidFail (ARSession session, NSError error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="session">The session that is supplying the information for the event.</param><param name="audioSampleBuffer">The audio buffer that was played.</param><summary>Developers may implement this method that is called shortly after an audio buffer has been played.</summary><remarks>To be added.</remarks>
		[Export ("session:didOutputAudioSampleBuffer:")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidOutputAudioSampleBuffer (ARSession session, global::CoreMedia.CMSampleBuffer audioSampleBuffer)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("session:didOutputCollaborationData:")]
		[SupportedOSPlatform ("ios13.0")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidOutputCollaborationData (ARSession session, ARCollaborationData data)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="renderer">The renderer for the scene.</param><param name="node">The node that was removed.</param><param name="anchor">The anchor for the node that was removed.</param><summary>Developers may override this method to react to the removal of <paramref name="node" />, which was removed after <paramref name="anchor" /> was removed.</summary><remarks>To be added.</remarks>
		[Export ("renderer:didRemoveNode:forAnchor:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidRemoveNode (global::SceneKit.ISCNSceneRenderer renderer, global::SceneKit.SCNNode node, ARAnchor anchor)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="renderer">To be added.</param><param name="scene">To be added.</param><param name="timeInSeconds">To be added.</param><summary>This method is called shortly after the scene has been rendered.</summary><remarks>To be added.</remarks>
		[Export ("renderer:didRenderScene:atTime:")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidRenderScene (global::SceneKit.ISCNSceneRenderer renderer, global::SceneKit.SCNScene scene, double timeInSeconds)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="renderer">To be added.</param><param name="timeInSeconds">To be added.</param><summary>This method is called shortly after physics have been simulated.</summary><remarks>To be added.</remarks>
		[Export ("renderer:didSimulatePhysicsAtTime:")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidSimulatePhysics (global::SceneKit.ISCNSceneRenderer renderer, double timeInSeconds)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="renderer">The renderer for the scene.</param><param name="node">The node that was updated.</param><param name="anchor">The anchor for the node that was updated.</param><summary>This method is called shortly after <paramref name="node" /> has been updated to reflect the current state of <paramref name="anchor" />.</summary><remarks>To be added.</remarks>
		[Export ("renderer:didUpdateNode:forAnchor:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidUpdateNode (global::SceneKit.ISCNSceneRenderer renderer, global::SceneKit.SCNNode node, ARAnchor anchor)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="renderer">The renderer for the scene.</param><param name="anchor">The anchor for the node to get.</param><summary>Retrieves the <see cref="T:SceneKit.SCNNode" /> corresponding to the specified <paramref name="anchor" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("renderer:nodeForAnchor:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::SceneKit.SCNNode? GetNode (global::SceneKit.ISCNSceneRenderer renderer, ARAnchor anchor)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="session">The session that is supplying the information for the event.</param><summary>Developers may override this method to begin frame processing and device tracking after an interruption.</summary><remarks>To be added.</remarks>
		[Export ("sessionInterruptionEnded:")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void InterruptionEnded (ARSession session)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="session">The session in question.</param><summary>Returns a Boolean value that tells whether the session should attempt to reorient after an interruption.</summary><returns>A Boolean value that tells whether the session should attempt to reorient after an interruption.</returns><remarks>To be added.</remarks>
		[Export ("sessionShouldAttemptRelocalization:")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldAttemptRelocalization (ARSession session)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="renderer">To be added.</param><param name="timeInSeconds">To be added.</param><summary>Developers may override this method to perform processing prior to any actions, animations, or physics simulations.</summary><remarks>To be added.</remarks>
		[Export ("renderer:updateAtTime:")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Update (global::SceneKit.ISCNSceneRenderer renderer, double timeInSeconds)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="session">The session that is supplying the information for the event.</param><summary>Developers may override this method to stop frame processing and device tracking when an interruption occurs.</summary><remarks>To be added.</remarks>
		[Export ("sessionWasInterrupted:")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WasInterrupted (ARSession session)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="renderer">To be added.</param><param name="scene">To be added.</param><param name="timeInSeconds">To be added.</param><summary>Developers may override this method to do processing immediately prior to the rendering of the scene.</summary><remarks>To be added.</remarks>
		[Export ("renderer:willRenderScene:atTime:")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillRenderScene (global::SceneKit.ISCNSceneRenderer renderer, global::SceneKit.SCNScene scene, double timeInSeconds)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="renderer">The renderer for the scene.</param><param name="node">The node that will be updated.</param><param name="anchor">The anchor for the node that will be updated.</param><summary>This method is called shortly before the properties of <paramref name="node" /> are updated to reflect the state of <paramref name="anchor" />.</summary><remarks>To be added.</remarks>
		[Export ("renderer:willUpdateNode:forAnchor:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillUpdateNode (global::SceneKit.ISCNSceneRenderer renderer, global::SceneKit.SCNNode node, ARAnchor anchor)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class ARSCNViewDelegate */
}
