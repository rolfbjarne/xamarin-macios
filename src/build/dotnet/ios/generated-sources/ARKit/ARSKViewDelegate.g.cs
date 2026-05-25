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
	/// <summary>Delegate object allowing the developer to respond to events relating to a <see cref="T:ARKit.ARSKView" />.</summary>
	[UnsupportedOSPlatform ("tvos")]
	[UnsupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("ios")]
	[Protocol (Name = "ARSKViewDelegate", WrapperType = typeof (ARSKViewDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetNode", Selector = "view:nodeForAnchor:", ReturnType = typeof (SKNode), ParameterType = new Type [] { typeof (ARKit.ARSKView), typeof (ARKit.ARAnchor) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidAddNode", Selector = "view:didAddNode:forAnchor:", ParameterType = new Type [] { typeof (ARKit.ARSKView), typeof (SKNode), typeof (ARKit.ARAnchor) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillUpdateNode", Selector = "view:willUpdateNode:forAnchor:", ParameterType = new Type [] { typeof (ARKit.ARSKView), typeof (SKNode), typeof (ARKit.ARAnchor) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidUpdateNode", Selector = "view:didUpdateNode:forAnchor:", ParameterType = new Type [] { typeof (ARKit.ARSKView), typeof (SKNode), typeof (ARKit.ARAnchor) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidRemoveNode", Selector = "view:didRemoveNode:forAnchor:", ParameterType = new Type [] { typeof (ARKit.ARSKView), typeof (SKNode), typeof (ARKit.ARAnchor) }, ParameterByRef = new bool [] { false, false, false })]
	public partial interface IARSKViewDelegate : INativeObject, IDisposable, 
		ARKit.IARSessionObserver
		, SpriteKit.ISKViewDelegate
	{
		/// <param name="view">The view that is rendering the scene.</param><param name="anchor">The anchor for the node to get.</param><summary>Retrieves the <see cref="T:SpriteKit.SKNode" /> corresponding to the specified <paramref name="anchor" />. If no corresponding node exists, returns <see langword="null" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("view:nodeForAnchor:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::SpriteKit.SKNode? GetNode (ARSKView view, ARAnchor anchor)
		{
			return _GetNode (this, view, anchor);
		}
		/// <param name="view">The view that is rendering the scene.</param><param name="anchor">The anchor for the node to get.</param><summary>Retrieves the <see cref="T:SpriteKit.SKNode" /> corresponding to the specified <paramref name="anchor" />. If no corresponding node exists, returns <see langword="null" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static global::SpriteKit.SKNode? _GetNode (IARSKViewDelegate This, ARSKView view, ARAnchor anchor)
		{
			var view__handle__ = view!.GetNonNullHandle (nameof (view));
			var anchor__handle__ = anchor!.GetNonNullHandle (nameof (anchor));
			global::SpriteKit.SKNode? ret;
			ret =  Runtime.GetNSObject<global::SpriteKit.SKNode> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("view:nodeForAnchor:"), view__handle__, anchor__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (view);
			GC.KeepAlive (anchor);
			return ret!;
		}
		/// <param name="view">The view that is rendering the scene.</param><param name="node">The node that was added.</param><param name="anchor">The anchor for the node that was added.</param><summary>Developers may override this method to react to the adding of a <see cref="T:SpriteKit.SKNode" /> that corresponds to a new <see cref="T:ARKit.ARAnchor" />.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("view:didAddNode:forAnchor:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidAddNode (ARSKView view, global::SpriteKit.SKNode node, ARAnchor anchor)
		{
			_DidAddNode (this, view, node, anchor);
		}
		/// <param name="view">The view that is rendering the scene.</param><param name="node">The node that was added.</param><param name="anchor">The anchor for the node that was added.</param><summary>Developers may override this method to react to the adding of a <see cref="T:SpriteKit.SKNode" /> that corresponds to a new <see cref="T:ARKit.ARAnchor" />.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidAddNode (IARSKViewDelegate This, ARSKView view, global::SpriteKit.SKNode node, ARAnchor anchor)
		{
			var view__handle__ = view!.GetNonNullHandle (nameof (view));
			var node__handle__ = node!.GetNonNullHandle (nameof (node));
			var anchor__handle__ = anchor!.GetNonNullHandle (nameof (anchor));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("view:didAddNode:forAnchor:"), view__handle__, node__handle__, anchor__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (view);
			GC.KeepAlive (node);
			GC.KeepAlive (anchor);
		}
		/// <param name="view">The view that is rendering the scene.</param><param name="node">The node that will be updated.</param><param name="anchor">The anchor for the node that will be updated.</param><summary>This method is called shortly before the properties of <paramref name="node" /> are updated to reflect the state of <paramref name="anchor" />.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("view:willUpdateNode:forAnchor:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillUpdateNode (ARSKView view, global::SpriteKit.SKNode node, ARAnchor anchor)
		{
			_WillUpdateNode (this, view, node, anchor);
		}
		/// <param name="view">The view that is rendering the scene.</param><param name="node">The node that will be updated.</param><param name="anchor">The anchor for the node that will be updated.</param><summary>This method is called shortly before the properties of <paramref name="node" /> are updated to reflect the state of <paramref name="anchor" />.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _WillUpdateNode (IARSKViewDelegate This, ARSKView view, global::SpriteKit.SKNode node, ARAnchor anchor)
		{
			var view__handle__ = view!.GetNonNullHandle (nameof (view));
			var node__handle__ = node!.GetNonNullHandle (nameof (node));
			var anchor__handle__ = anchor!.GetNonNullHandle (nameof (anchor));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("view:willUpdateNode:forAnchor:"), view__handle__, node__handle__, anchor__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (view);
			GC.KeepAlive (node);
			GC.KeepAlive (anchor);
		}
		/// <param name="view">The view that is rendering the scene.</param><param name="node">The node that was updated.</param><param name="anchor">The anchor for the node that was updated.</param><summary>This method is called shortly after <paramref name="node" /> has been updated to reflect the current state of <paramref name="anchor" />.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("view:didUpdateNode:forAnchor:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidUpdateNode (ARSKView view, global::SpriteKit.SKNode node, ARAnchor anchor)
		{
			_DidUpdateNode (this, view, node, anchor);
		}
		/// <param name="view">The view that is rendering the scene.</param><param name="node">The node that was updated.</param><param name="anchor">The anchor for the node that was updated.</param><summary>This method is called shortly after <paramref name="node" /> has been updated to reflect the current state of <paramref name="anchor" />.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidUpdateNode (IARSKViewDelegate This, ARSKView view, global::SpriteKit.SKNode node, ARAnchor anchor)
		{
			var view__handle__ = view!.GetNonNullHandle (nameof (view));
			var node__handle__ = node!.GetNonNullHandle (nameof (node));
			var anchor__handle__ = anchor!.GetNonNullHandle (nameof (anchor));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("view:didUpdateNode:forAnchor:"), view__handle__, node__handle__, anchor__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (view);
			GC.KeepAlive (node);
			GC.KeepAlive (anchor);
		}
		/// <param name="view">The view that is rendering the scene.</param><param name="node">The node that was removed.</param><param name="anchor">The anchor for the node that was removed.</param><summary>Developers may override this method to react to the removal of <paramref name="node" />, which was removed after <paramref name="anchor" /> was removed.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("view:didRemoveNode:forAnchor:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidRemoveNode (ARSKView view, global::SpriteKit.SKNode node, ARAnchor anchor)
		{
			_DidRemoveNode (this, view, node, anchor);
		}
		/// <param name="view">The view that is rendering the scene.</param><param name="node">The node that was removed.</param><param name="anchor">The anchor for the node that was removed.</param><summary>Developers may override this method to react to the removal of <paramref name="node" />, which was removed after <paramref name="anchor" /> was removed.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidRemoveNode (IARSKViewDelegate This, ARSKView view, global::SpriteKit.SKNode node, ARAnchor anchor)
		{
			var view__handle__ = view!.GetNonNullHandle (nameof (view));
			var node__handle__ = node!.GetNonNullHandle (nameof (node));
			var anchor__handle__ = anchor!.GetNonNullHandle (nameof (anchor));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("view:didRemoveNode:forAnchor:"), view__handle__, node__handle__, anchor__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (view);
			GC.KeepAlive (node);
			GC.KeepAlive (anchor);
		}
		[DynamicDependencyAttribute ("DidAddNode(ARKit.ARSKView,SpriteKit.SKNode,ARKit.ARAnchor)")]
		[DynamicDependencyAttribute ("DidRemoveNode(ARKit.ARSKView,SpriteKit.SKNode,ARKit.ARAnchor)")]
		[DynamicDependencyAttribute ("DidUpdateNode(ARKit.ARSKView,SpriteKit.SKNode,ARKit.ARAnchor)")]
		[DynamicDependencyAttribute ("GetNode(ARKit.ARSKView,ARKit.ARAnchor)")]
		[DynamicDependencyAttribute ("WillUpdateNode(ARKit.ARSKView,SpriteKit.SKNode,ARKit.ARAnchor)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (ARSKViewDelegateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IARSKViewDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="IARSKViewDelegate" /> interface to support all the methods from the ARSKViewDelegate protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IARSKViewDelegate" /> interface allow developers to treat instances of the interface as having all the optional methods of the original ARSKViewDelegate protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class ARSKViewDelegate_Extensions {
		/// <param name="view">The view that is rendering the scene.</param><param name="anchor">The anchor for the node to get.</param><summary>Retrieves the <see cref="T:SpriteKit.SKNode" /> corresponding to the specified <paramref name="anchor" />. If no corresponding node exists, returns <see langword="null" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static global::SpriteKit.SKNode? GetNode (this IARSKViewDelegate This, ARSKView view, ARAnchor anchor)
		{
			var view__handle__ = view!.GetNonNullHandle (nameof (view));
			var anchor__handle__ = anchor!.GetNonNullHandle (nameof (anchor));
			global::SpriteKit.SKNode? ret;
			ret =  Runtime.GetNSObject<global::SpriteKit.SKNode> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("view:nodeForAnchor:"), view__handle__, anchor__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (view);
			GC.KeepAlive (anchor);
			return ret!;
		}
		/// <param name="view">The view that is rendering the scene.</param><param name="node">The node that was added.</param><param name="anchor">The anchor for the node that was added.</param><summary>Developers may override this method to react to the adding of a <see cref="T:SpriteKit.SKNode" /> that corresponds to a new <see cref="T:ARKit.ARAnchor" />.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidAddNode (this IARSKViewDelegate This, ARSKView view, global::SpriteKit.SKNode node, ARAnchor anchor)
		{
			var view__handle__ = view!.GetNonNullHandle (nameof (view));
			var node__handle__ = node!.GetNonNullHandle (nameof (node));
			var anchor__handle__ = anchor!.GetNonNullHandle (nameof (anchor));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("view:didAddNode:forAnchor:"), view__handle__, node__handle__, anchor__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (view);
			GC.KeepAlive (node);
			GC.KeepAlive (anchor);
		}
		/// <param name="view">The view that is rendering the scene.</param><param name="node">The node that will be updated.</param><param name="anchor">The anchor for the node that will be updated.</param><summary>This method is called shortly before the properties of <paramref name="node" /> are updated to reflect the state of <paramref name="anchor" />.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void WillUpdateNode (this IARSKViewDelegate This, ARSKView view, global::SpriteKit.SKNode node, ARAnchor anchor)
		{
			var view__handle__ = view!.GetNonNullHandle (nameof (view));
			var node__handle__ = node!.GetNonNullHandle (nameof (node));
			var anchor__handle__ = anchor!.GetNonNullHandle (nameof (anchor));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("view:willUpdateNode:forAnchor:"), view__handle__, node__handle__, anchor__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (view);
			GC.KeepAlive (node);
			GC.KeepAlive (anchor);
		}
		/// <param name="view">The view that is rendering the scene.</param><param name="node">The node that was updated.</param><param name="anchor">The anchor for the node that was updated.</param><summary>This method is called shortly after <paramref name="node" /> has been updated to reflect the current state of <paramref name="anchor" />.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidUpdateNode (this IARSKViewDelegate This, ARSKView view, global::SpriteKit.SKNode node, ARAnchor anchor)
		{
			var view__handle__ = view!.GetNonNullHandle (nameof (view));
			var node__handle__ = node!.GetNonNullHandle (nameof (node));
			var anchor__handle__ = anchor!.GetNonNullHandle (nameof (anchor));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("view:didUpdateNode:forAnchor:"), view__handle__, node__handle__, anchor__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (view);
			GC.KeepAlive (node);
			GC.KeepAlive (anchor);
		}
		/// <param name="view">The view that is rendering the scene.</param><param name="node">The node that was removed.</param><param name="anchor">The anchor for the node that was removed.</param><summary>Developers may override this method to react to the removal of <paramref name="node" />, which was removed after <paramref name="anchor" /> was removed.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidRemoveNode (this IARSKViewDelegate This, ARSKView view, global::SpriteKit.SKNode node, ARAnchor anchor)
		{
			var view__handle__ = view!.GetNonNullHandle (nameof (view));
			var node__handle__ = node!.GetNonNullHandle (nameof (node));
			var anchor__handle__ = anchor!.GetNonNullHandle (nameof (anchor));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("view:didRemoveNode:forAnchor:"), view__handle__, node__handle__, anchor__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (view);
			GC.KeepAlive (node);
			GC.KeepAlive (anchor);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class ARSKViewDelegateWrapper : BaseWrapper, IARSKViewDelegate {
		public ARSKViewDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (ARSKViewDelegateWrapper))]
		static ARSKViewDelegateWrapper ()
		{
			GC.KeepAlive (null);
		}
	}
}
namespace ARKit {
	/// <summary>Delegate object allowing the developer to respond to events relating to a <see cref="T:ARKit.ARSKView" />.</summary>
	[Protocol()]
	[Register("Microsoft_iOS__ARKit_ARSKViewDelegate", false)]
	[Model]
	[UnsupportedOSPlatform ("tvos")]
	[UnsupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("ios")]
	public unsafe partial class ARSKViewDelegate : NSObject, IARSKViewDelegate, IARSessionObserver, global::SpriteKit.ISKViewDelegate {
		/// <summary>Creates a new <see cref="ARSKViewDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public ARSKViewDelegate () : base (NSObjectFlag.Empty)
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
		protected ARSKViewDelegate (NSObjectFlag t) : base (t)
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
		protected internal ARSKViewDelegate (NativeHandle handle) : base (handle)
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
		/// <param name="view">The view that is rendering the scene.</param><param name="node">The node that was added.</param><param name="anchor">The anchor for the node that was added.</param><summary>Developers may override this method to react to the adding of a <see cref="T:SpriteKit.SKNode" /> that corresponds to a new <see cref="T:ARKit.ARAnchor" />.</summary><remarks>To be added.</remarks>
		[Export ("view:didAddNode:forAnchor:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidAddNode (ARSKView view, global::SpriteKit.SKNode node, ARAnchor anchor)
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
		/// <param name="view">The view that is rendering the scene.</param><param name="node">The node that was removed.</param><param name="anchor">The anchor for the node that was removed.</param><summary>Developers may override this method to react to the removal of <paramref name="node" />, which was removed after <paramref name="anchor" /> was removed.</summary><remarks>To be added.</remarks>
		[Export ("view:didRemoveNode:forAnchor:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidRemoveNode (ARSKView view, global::SpriteKit.SKNode node, ARAnchor anchor)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="view">The view that is rendering the scene.</param><param name="node">The node that was updated.</param><param name="anchor">The anchor for the node that was updated.</param><summary>This method is called shortly after <paramref name="node" /> has been updated to reflect the current state of <paramref name="anchor" />.</summary><remarks>To be added.</remarks>
		[Export ("view:didUpdateNode:forAnchor:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidUpdateNode (ARSKView view, global::SpriteKit.SKNode node, ARAnchor anchor)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="view">The view that is rendering the scene.</param><param name="anchor">The anchor for the node to get.</param><summary>Retrieves the <see cref="T:SpriteKit.SKNode" /> corresponding to the specified <paramref name="anchor" />. If no corresponding node exists, returns <see langword="null" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("view:nodeForAnchor:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::SpriteKit.SKNode? GetNode (ARSKView view, ARAnchor anchor)
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
		/// <param name="view">To be added.</param><param name="time">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("view:shouldRenderAtTime:")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldRender (global::SpriteKit.SKView view, double time)
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
		/// <param name="view">The view that is rendering the scene.</param><param name="node">The node that will be updated.</param><param name="anchor">The anchor for the node that will be updated.</param><summary>This method is called shortly before the properties of <paramref name="node" /> are updated to reflect the state of <paramref name="anchor" />.</summary><remarks>To be added.</remarks>
		[Export ("view:willUpdateNode:forAnchor:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillUpdateNode (ARSKView view, global::SpriteKit.SKNode node, ARAnchor anchor)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class ARSKViewDelegate */
}
