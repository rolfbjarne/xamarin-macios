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
namespace CoreAnimation {
	#pragma warning disable CS1573
	/// <summary>Delegate class for the CALayer.</summary><related type="externalDocumentation" href="https://developer.apple.com/documentation/quartzcore/calayerdelegate">Apple documentation for <c>CALayerDelegate</c></related>
	[Protocol (Name = "CALayerDelegate", WrapperType = typeof (CALayerDelegateWrapper), FormalSince = "10.0")]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DisplayLayer", Selector = "displayLayer:", ParameterType = new Type [] { typeof (CALayer) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DrawLayer", Selector = "drawLayer:inContext:", ParameterType = new Type [] { typeof (CALayer), typeof (CGContext) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillDrawLayer", Selector = "layerWillDraw:", ParameterType = new Type [] { typeof (CALayer) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "LayoutSublayersOfLayer", Selector = "layoutSublayersOfLayer:", ParameterType = new Type [] { typeof (CALayer) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ActionForLayer", Selector = "actionForLayer:forKey:", ReturnType = typeof (NSObject), ParameterType = new Type [] { typeof (CALayer), typeof (string) }, ParameterByRef = new bool [] { false, false })]
	public partial interface ICALayerDelegate : INativeObject, IDisposable
	{
		/// <param name="layer">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("displayLayer:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DisplayLayer (CALayer layer)
		{
			_DisplayLayer (this, layer);
		}
		/// <param name="layer">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DisplayLayer (ICALayerDelegate This, CALayer layer)
		{
			var layer__handle__ = layer!.GetNonNullHandle (nameof (layer));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("displayLayer:"), layer__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (layer);
		}
		/// <param name="layer">To be added.</param><param name="context">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("drawLayer:inContext:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DrawLayer (CALayer layer, CGContext context)
		{
			_DrawLayer (this, layer, context);
		}
		/// <param name="layer">To be added.</param><param name="context">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DrawLayer (ICALayerDelegate This, CALayer layer, CGContext context)
		{
			var layer__handle__ = layer!.GetNonNullHandle (nameof (layer));
			var context__handle__ = context!.GetNonNullHandle (nameof (context));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("drawLayer:inContext:"), layer__handle__, context.Handle);
			GC.KeepAlive (This);
			GC.KeepAlive (layer);
			GC.KeepAlive (context);
		}
		/// <param name="layer">The layer that will be redrawn.</param><summary>Method that is called when <paramref name="layer" /> is about to be drawn.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("layerWillDraw:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillDrawLayer (CALayer layer)
		{
			_WillDrawLayer (this, layer);
		}
		/// <param name="layer">The layer that will be redrawn.</param><summary>Method that is called when <paramref name="layer" /> is about to be drawn.</summary><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _WillDrawLayer (ICALayerDelegate This, CALayer layer)
		{
			var layer__handle__ = layer!.GetNonNullHandle (nameof (layer));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("layerWillDraw:"), layer__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (layer);
		}
		/// <param name="layer">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("layoutSublayersOfLayer:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void LayoutSublayersOfLayer (CALayer layer)
		{
			_LayoutSublayersOfLayer (this, layer);
		}
		/// <param name="layer">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _LayoutSublayersOfLayer (ICALayerDelegate This, CALayer layer)
		{
			var layer__handle__ = layer!.GetNonNullHandle (nameof (layer));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("layoutSublayersOfLayer:"), layer__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (layer);
		}
		/// <param name="layer">To be added.</param><param name="eventKey">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("actionForLayer:forKey:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject? ActionForLayer (CALayer layer, string eventKey)
		{
			return _ActionForLayer (this, layer, eventKey);
		}
		/// <param name="layer">To be added.</param><param name="eventKey">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSObject? _ActionForLayer (ICALayerDelegate This, CALayer layer, string eventKey)
		{
			var layer__handle__ = layer!.GetNonNullHandle (nameof (layer));
			if (eventKey is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (eventKey));
			var nseventKey = CFString.CreateNative (eventKey);
			NSObject? ret;
			ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("actionForLayer:forKey:"), layer__handle__, nseventKey), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (layer);
			CFString.ReleaseNative (nseventKey);
			return ret!;
		}
		[DynamicDependencyAttribute ("ActionForLayer(CoreAnimation.CALayer,System.String)")]
		[DynamicDependencyAttribute ("DisplayLayer(CoreAnimation.CALayer)")]
		[DynamicDependencyAttribute ("DrawLayer(CoreAnimation.CALayer,CoreGraphics.CGContext)")]
		[DynamicDependencyAttribute ("LayoutSublayersOfLayer(CoreAnimation.CALayer)")]
		[DynamicDependencyAttribute ("WillDrawLayer(CoreAnimation.CALayer)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (CALayerDelegateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static ICALayerDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="ICALayerDelegate" /> interface to support all the methods from the CALayerDelegate protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="ICALayerDelegate" /> interface allow developers to treat instances of the interface as having all the optional methods of the original CALayerDelegate protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class CALayerDelegate_Extensions {
		/// <param name="layer">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DisplayLayer (this ICALayerDelegate This, CALayer layer)
		{
			var layer__handle__ = layer!.GetNonNullHandle (nameof (layer));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("displayLayer:"), layer__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (layer);
		}
		/// <param name="layer">To be added.</param><param name="context">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DrawLayer (this ICALayerDelegate This, CALayer layer, CGContext context)
		{
			var layer__handle__ = layer!.GetNonNullHandle (nameof (layer));
			var context__handle__ = context!.GetNonNullHandle (nameof (context));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("drawLayer:inContext:"), layer__handle__, context.Handle);
			GC.KeepAlive (This);
			GC.KeepAlive (layer);
			GC.KeepAlive (context);
		}
		/// <param name="layer">The layer that will be redrawn.</param><summary>Method that is called when <paramref name="layer" /> is about to be drawn.</summary><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void WillDrawLayer (this ICALayerDelegate This, CALayer layer)
		{
			var layer__handle__ = layer!.GetNonNullHandle (nameof (layer));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("layerWillDraw:"), layer__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (layer);
		}
		/// <param name="layer">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void LayoutSublayersOfLayer (this ICALayerDelegate This, CALayer layer)
		{
			var layer__handle__ = layer!.GetNonNullHandle (nameof (layer));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("layoutSublayersOfLayer:"), layer__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (layer);
		}
		/// <param name="layer">To be added.</param><param name="eventKey">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSObject? ActionForLayer (this ICALayerDelegate This, CALayer layer, string eventKey)
		{
			var layer__handle__ = layer!.GetNonNullHandle (nameof (layer));
			if (eventKey is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (eventKey));
			var nseventKey = CFString.CreateNative (eventKey);
			NSObject? ret;
			ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("actionForLayer:forKey:"), layer__handle__, nseventKey), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (layer);
			CFString.ReleaseNative (nseventKey);
			return ret!;
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class CALayerDelegateWrapper : BaseWrapper, ICALayerDelegate {
		public CALayerDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (CALayerDelegateWrapper))]
		static CALayerDelegateWrapper ()
		{
			GC.KeepAlive (null);
		}
	}
}
namespace CoreAnimation {
	/// <summary>Delegate class for the CALayer.</summary><related type="externalDocumentation" href="https://developer.apple.com/documentation/quartzcore/calayerdelegate">Apple documentation for <c>CALayerDelegate</c></related>
	[Protocol()]
	[Register("Microsoft_iOS__CoreAnimation_CALayerDelegate", false)]
	[Model]
	public unsafe partial class CALayerDelegate : NSObject, ICALayerDelegate {
		/// <summary>Creates a new <see cref="CALayerDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public CALayerDelegate () : base (NSObjectFlag.Empty)
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
		protected CALayerDelegate (NSObjectFlag t) : base (t)
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
		protected internal CALayerDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		/// <param name="layer">To be added.</param><param name="eventKey">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("actionForLayer:forKey:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject? ActionForLayer (CALayer layer, string eventKey)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="layer">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("displayLayer:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DisplayLayer (CALayer layer)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="layer">To be added.</param><param name="context">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("drawLayer:inContext:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DrawLayer (CALayer layer, CGContext context)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="layer">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("layoutSublayersOfLayer:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void LayoutSublayersOfLayer (CALayer layer)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="layer">The layer that will be redrawn.</param><summary>Method that is called when <paramref name="layer" /> is about to be drawn.</summary><remarks>To be added.</remarks>
		[Export ("layerWillDraw:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillDrawLayer (CALayer layer)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class CALayerDelegate */
}
