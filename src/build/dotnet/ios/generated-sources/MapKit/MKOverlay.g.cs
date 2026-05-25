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
namespace MapKit {
	#pragma warning disable CS1573
	/// <summary>Describes a map annotation that combines a location and a geometric shape.</summary><remarks><para><see cref="T:MapKit.MKOverlay" />s allow the application developer to layer graphics above an <see cref="T:MapKit.MKMapView" />. The <see cref="T:MapKit.MKOverlay" /> will automatically position, zoom, and redirect itself to the underlying <see cref="T:MapKit.MKMapView" />.</para><para>iOS provides several standard overlays:</para><list type="table"><listheader><term>Class</term><description>Description</description></listheader><item><term><see cref="T:MapKit.MKCircle" /></term><description>A circular region</description></item><item><term><see cref="T:MapKit.MKPolygon" /></term><description>A closed polygonal area.</description></item><item><term><see cref="T:MapKit.MKPolyline" /></term><description>An area defined by points in which the first and final points are not automatically joined.</description></item></list></remarks><related type="article" href="https://docs.xamarin.com/guides/ios/platform_features/ios_maps">iOS Maps</related><related type="recipe" href="https://docs.xamarin.com/recipes/ios/content_controls/map_view/add_an_overlay_to_a_map">Add an Overlay to a Map</related><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/MapKit/Reference/MKOverlay_protocol/index.html">Apple documentation for <c>MKOverlay</c></related>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	[Protocol (Name = "MKOverlay", WrapperType = typeof (MKOverlayWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "Intersects", Selector = "intersectsMapRect:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (MKMapRect) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "BoundingMapRect", Selector = "boundingMapRect", PropertyType = typeof (MKMapRect), GetterSelector = "boundingMapRect", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "CanReplaceMapContent", Selector = "canReplaceMapContent", PropertyType = typeof (bool), GetterSelector = "canReplaceMapContent", ArgumentSemantic = ArgumentSemantic.None)]
	public partial interface IMKOverlay : INativeObject, IDisposable, 
		MapKit.IMKAnnotation
	{
		/// <param name="rect">The area being checked for intersection with this <see cref="T:MapKit.MKOverlay" />.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("intersectsMapRect:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool Intersects (MKMapRect rect)
		{
			return _Intersects (this, rect);
		}
		/// <param name="rect">The area being checked for intersection with this <see cref="T:MapKit.MKOverlay" />.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _Intersects (IMKOverlay This, MKMapRect rect)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_MKMapRect (This.Handle, Selector.GetHandle ("intersectsMapRect:"), rect);
			GC.KeepAlive (This);
			return ret != 0;
		}
		[DynamicDependencyAttribute ("BoundingMapRect")]
		[DynamicDependencyAttribute ("CanReplaceMapContent")]
		[DynamicDependencyAttribute ("Intersects(MapKit.MKMapRect)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (MKOverlayWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IMKOverlay ()
		{
			GC.KeepAlive (null);
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual MKMapRect BoundingMapRect {
			[Export ("boundingMapRect")]
			get {
				return _GetBoundingMapRect (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static MKMapRect _GetBoundingMapRect (IMKOverlay This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			MKMapRect ret;
			if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
				ret = global::ObjCRuntime.Messaging.MKMapRect_objc_msgSend (This.Handle, Selector.GetHandle ("boundingMapRect"));
				GC.KeepAlive (This);
			} else {
				ret = global::ObjCRuntime.Messaging.MKMapRect_objc_msgSend_stret (This.Handle, Selector.GetHandle ("boundingMapRect"));
				GC.KeepAlive (This);
			}
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[DebuggerBrowsable (DebuggerBrowsableState.Never)]
		[global::Foundation.OptionalMember]
		public virtual bool CanReplaceMapContent {
			[Export ("canReplaceMapContent")]
			get {
				return _GetCanReplaceMapContent (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _GetCanReplaceMapContent (IMKOverlay This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("canReplaceMapContent"));
			GC.KeepAlive (This);
			return ret != 0;
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="IMKOverlay" /> interface to support all the methods from the MKOverlay protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IMKOverlay" /> interface allow developers to treat instances of the interface as having all the optional methods of the original MKOverlay protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class MKOverlay_Extensions {
		/// <param name="rect">The area being checked for intersection with this <see cref="T:MapKit.MKOverlay" />.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool Intersects (this IMKOverlay This, MKMapRect rect)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_MKMapRect (This.Handle, Selector.GetHandle ("intersectsMapRect:"), rect);
			GC.KeepAlive (This);
			return ret != 0;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool GetCanReplaceMapContent (this IMKOverlay This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("canReplaceMapContent"));
			GC.KeepAlive (This);
			return ret != 0;
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class MKOverlayWrapper : BaseWrapper, IMKOverlay {
		public MKOverlayWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (MKOverlayWrapper))]
		static MKOverlayWrapper ()
		{
			GC.KeepAlive (null);
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public MKMapRect BoundingMapRect {
			[Export ("boundingMapRect")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				MKMapRect ret;
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					ret = global::ObjCRuntime.Messaging.MKMapRect_objc_msgSend (this.Handle, Selector.GetHandle ("boundingMapRect"));
				} else {
					ret = global::ObjCRuntime.Messaging.MKMapRect_objc_msgSend_stret (this.Handle, Selector.GetHandle ("boundingMapRect"));
				}
				return ret!;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		public global::CoreLocation.CLLocationCoordinate2D Coordinate {
			[Export ("coordinate")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				global::CoreLocation.CLLocationCoordinate2D ret;
				ret = global::ObjCRuntime.Messaging.CLLocationCoordinate2D_objc_msgSend (this.Handle, Selector.GetHandle ("coordinate"));
				return ret;
			}
		}
	}
}
namespace MapKit {
	/// <summary>Describes a map annotation that combines a location and a geometric shape.</summary><remarks><para><see cref="T:MapKit.MKOverlay" />s allow the application developer to layer graphics above an <see cref="T:MapKit.MKMapView" />. The <see cref="T:MapKit.MKOverlay" /> will automatically position, zoom, and redirect itself to the underlying <see cref="T:MapKit.MKMapView" />.</para><para>iOS provides several standard overlays:</para><list type="table"><listheader><term>Class</term><description>Description</description></listheader><item><term><see cref="T:MapKit.MKCircle" /></term><description>A circular region</description></item><item><term><see cref="T:MapKit.MKPolygon" /></term><description>A closed polygonal area.</description></item><item><term><see cref="T:MapKit.MKPolyline" /></term><description>An area defined by points in which the first and final points are not automatically joined.</description></item></list></remarks><related type="article" href="https://docs.xamarin.com/guides/ios/platform_features/ios_maps">iOS Maps</related><related type="recipe" href="https://docs.xamarin.com/recipes/ios/content_controls/map_view/add_an_overlay_to_a_map">Add an Overlay to a Map</related><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/MapKit/Reference/MKOverlay_protocol/index.html">Apple documentation for <c>MKOverlay</c></related>
	[Protocol()]
	[Register("Microsoft_iOS__MapKit_MKOverlay", false)]
	[Model]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe abstract partial class MKOverlay : MKAnnotation, IMKOverlay {
		/// <summary>Creates a new <see cref="MKOverlay" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected MKOverlay () : base (NSObjectFlag.Empty)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
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
		protected MKOverlay (NSObjectFlag t) : base (t)
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
		protected internal MKOverlay (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		/// <param name="rect">The area being checked for intersection with this <see cref="T:MapKit.MKOverlay" />.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("intersectsMapRect:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool Intersects (MKMapRect rect)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MKMapRect BoundingMapRect {
			[Export ("boundingMapRect")]
			get {
				throw new ModelNotImplementedException ();
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[DebuggerBrowsable (DebuggerBrowsableState.Never)]
		public virtual bool CanReplaceMapContent {
			[Export ("canReplaceMapContent")]
			get {
				throw new ModelNotImplementedException ();
			}
		}
	} /* class MKOverlay */
}
