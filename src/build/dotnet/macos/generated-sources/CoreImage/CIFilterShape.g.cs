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
namespace CoreImage {
	/// <summary>Masks filter operations to areas composed of the intersections, unions, and affine transformations of rectangles and other similarly constructed filter shapes.</summary><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/GraphicsImaging/Reference/QuartzCoreFramework/Classes/CIFilterShape_Class/index.html">Apple documentation for <c>CIFilterShape</c></related>
	[Register("CIFilterShape", true)]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe partial class CIFilterShape : NSObject, INSCopying {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCopyWithZone_X = "copyWithZone:";
		static readonly NativeHandle selCopyWithZone_XHandle = Selector.GetHandle ("copyWithZone:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selExtentX = "extent";
		static readonly NativeHandle selExtentXHandle = Selector.GetHandle ("extent");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithRect_X = "initWithRect:";
		static readonly NativeHandle selInitWithRect_XHandle = Selector.GetHandle ("initWithRect:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInsetByX_Y_X = "insetByX:Y:";
		static readonly NativeHandle selInsetByX_Y_XHandle = Selector.GetHandle ("insetByX:Y:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIntersectWith_X = "intersectWith:";
		static readonly NativeHandle selIntersectWith_XHandle = Selector.GetHandle ("intersectWith:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIntersectWithRect_X = "intersectWithRect:";
		static readonly NativeHandle selIntersectWithRect_XHandle = Selector.GetHandle ("intersectWithRect:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selShapeWithRect_X = "shapeWithRect:";
		static readonly NativeHandle selShapeWithRect_XHandle = Selector.GetHandle ("shapeWithRect:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTransformBy_Interior_X = "transformBy:interior:";
		static readonly NativeHandle selTransformBy_Interior_XHandle = Selector.GetHandle ("transformBy:interior:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selUnionWith_X = "unionWith:";
		static readonly NativeHandle selUnionWith_XHandle = Selector.GetHandle ("unionWith:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selUnionWithRect_X = "unionWithRect:";
		static readonly NativeHandle selUnionWithRect_XHandle = Selector.GetHandle ("unionWithRect:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("CIFilterShape");
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
		protected CIFilterShape (NSObjectFlag t) : base (t)
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
		protected internal CIFilterShape (NativeHandle handle) : base (handle)
		{
		}

		/// <param name="rect">To be added.</param><summary>Creates a new CIFilterShape that limits filter operations to the specified rectangle.</summary><remarks>To be added.</remarks>
		[Export ("initWithRect:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public CIFilterShape (CGRect rect)
			: base (NSObjectFlag.Empty)
		{
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_CGRect (this.Handle, selInitWithRect_XHandle, rect), "initWithRect:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_CGRect (&__objc_super__, selInitWithRect_XHandle, rect), "initWithRect:");
					GC.KeepAlive (this);
				}
			}
		}
		/// <param name="zone">Developers should pass <see langword="null" />.  Memory zones are no longer used.</param><summary>Performs a copy of the underlying Objective-C object.</summary><returns>The newly-allocated object.</returns><remarks><para>This method performs a "shallow copy" of <see langword="this" />. If this object contains references to external objects, the new object will contain references to the same object.</para></remarks>
		[Export ("copyWithZone:")]
		[return: ReleaseAttribute ()]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject Copy (NSZone? zone)
		{
			var zone__handle__ = zone.GetHandle ();
			NSObject? ret;
			if (IsDirectBinding) {
				ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selCopyWithZone_XHandle, zone__handle__), true)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selCopyWithZone_XHandle, zone__handle__), true)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (zone);
			return ret!;
		}
		/// <param name="rect">To be added.</param><summary>Creates a new CIFilterShape that limits filter operations to the specified rectangle.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("shapeWithRect:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CIFilterShape FromRect (CGRect rect)
		{
			CIFilterShape ret;
			ret =  Runtime.GetNSObject<CIFilterShape> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_CGRect (class_ptr, selShapeWithRect_XHandle, rect), false)!;
			return ret;
		}
		/// <param name="dx">To be added.</param><param name="dy">To be added.</param><summary>Moves the filter region by the specified X and Y directions.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("insetByX:Y:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CIFilterShape Inset (int dx, int dy)
		{
			CIFilterShape ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<CIFilterShape> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_int_int (this.Handle, selInsetByX_Y_XHandle, dx, dy), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<CIFilterShape> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_int_int (&__objc_super__, selInsetByX_Y_XHandle, dx, dy), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		/// <param name="other">To be added.</param><summary>Creates a new CIFilterShape from the intersection of the current filter shape with <paramref name="other" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("intersectWith:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CIFilterShape Intersect (CIFilterShape other)
		{
			var other__handle__ = other!.GetNonNullHandle (nameof (other));
			CIFilterShape? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<CIFilterShape> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selIntersectWith_XHandle, other__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<CIFilterShape> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selIntersectWith_XHandle, other__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (other);
			return ret!;
		}
		/// <param name="rectangle">The rectangle with which to calculate the intersection.</param><summary>Returns a new <see cref="T:CoreImage.CIFilterShape" /> whose shape is defined by the overlap of <c>this</c> and the specified <paramref name="rectangle" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("intersectWithRect:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CIFilterShape Intersect (CGRect rectangle)
		{
			CIFilterShape ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<CIFilterShape> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_CGRect (this.Handle, selIntersectWithRect_XHandle, rectangle), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<CIFilterShape> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_CGRect (&__objc_super__, selIntersectWithRect_XHandle, rectangle), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		/// <param name="transformation">To be added.</param><param name="interiorFlag">Developers should pass <see langword="true" /> to indicate that the resulting transformed filter shape should definitely exclude the boundary points. Developers should pass <see langword="false" /> to indicate that the result should definitely include the boundary points.</param><summary>Creates a new CIFilterShape by applying the specified transformation to the current filter shape.</summary><returns>To be added.</returns><remarks><para>App developers should realize that neither setting of <paramref name="interiorFlag" /> results in an exact operation. Points may be excluded or included along the boundary to guarantee inclusivity or exclusivity of the result.</para></remarks>
		[Export ("transformBy:interior:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CIFilterShape Transform (CGAffineTransform transformation, bool interiorFlag)
		{
			CIFilterShape ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<CIFilterShape> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_CGAffineTransform_bool (this.Handle, selTransformBy_Interior_XHandle, transformation, interiorFlag ? (byte) 1 : (byte) 0), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<CIFilterShape> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_CGAffineTransform_bool (&__objc_super__, selTransformBy_Interior_XHandle, transformation, interiorFlag ? (byte) 1 : (byte) 0), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		/// <param name="other">To be added.</param><summary>Creates a new CIFilterShape from the union of the current filter shape with <paramref name="other" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("unionWith:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CIFilterShape Union (CIFilterShape other)
		{
			var other__handle__ = other!.GetNonNullHandle (nameof (other));
			CIFilterShape? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<CIFilterShape> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selUnionWith_XHandle, other__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<CIFilterShape> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selUnionWith_XHandle, other__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (other);
			return ret!;
		}
		/// <param name="rectangle">To be added.</param><summary>Creates a new CIFilterShape from the union of the current filter shape with the specified rectangle.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("unionWithRect:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CIFilterShape Union (CGRect rectangle)
		{
			CIFilterShape ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<CIFilterShape> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_CGRect (this.Handle, selUnionWithRect_XHandle, rectangle), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<CIFilterShape> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_CGRect (&__objc_super__, selUnionWithRect_XHandle, rectangle), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		/// <summary>The rectangle that encloses the filter, in the working coordinate space.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGRect Extent {
			[Export ("extent")]
			get {
				CGRect ret;
				if (IsDirectBinding) {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend (this.Handle, selExtentXHandle);
					} else {
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret (this.Handle, selExtentXHandle);
					}
				} else {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper (&__objc_super__, selExtentXHandle);
							GC.KeepAlive (this);
						}
					} else {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper_stret (&__objc_super__, selExtentXHandle);
							GC.KeepAlive (this);
						}
					}
				}
				return ret!;
			}
		}
	} /* class CIFilterShape */
}
