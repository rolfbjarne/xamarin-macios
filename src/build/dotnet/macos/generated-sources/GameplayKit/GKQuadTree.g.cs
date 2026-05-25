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
namespace GameplayKit {
	/// <summary>A data structure that efficiently organizes objects in two-dimensional space.</summary><related type="externalDocumentation" href="https://developer.apple.com/reference/GameplayKit/GKQuadTree">Apple documentation for <c>GKQuadTree</c></related>
	[Register("GKQuadtree", true)]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe partial class GKQuadTree : NSObject {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAddElement_WithPoint_X = "addElement:withPoint:";
		static readonly NativeHandle selAddElement_WithPoint_XHandle = Selector.GetHandle ("addElement:withPoint:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAddElement_WithQuad_X = "addElement:withQuad:";
		static readonly NativeHandle selAddElement_WithQuad_XHandle = Selector.GetHandle ("addElement:withQuad:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selElementsAtPoint_X = "elementsAtPoint:";
		static readonly NativeHandle selElementsAtPoint_XHandle = Selector.GetHandle ("elementsAtPoint:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selElementsInQuad_X = "elementsInQuad:";
		static readonly NativeHandle selElementsInQuad_XHandle = Selector.GetHandle ("elementsInQuad:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithBoundingQuad_MinimumCellSize_X = "initWithBoundingQuad:minimumCellSize:";
		static readonly NativeHandle selInitWithBoundingQuad_MinimumCellSize_XHandle = Selector.GetHandle ("initWithBoundingQuad:minimumCellSize:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selQuadtreeWithBoundingQuad_MinimumCellSize_X = "quadtreeWithBoundingQuad:minimumCellSize:";
		static readonly NativeHandle selQuadtreeWithBoundingQuad_MinimumCellSize_XHandle = Selector.GetHandle ("quadtreeWithBoundingQuad:minimumCellSize:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRemoveElement_X = "removeElement:";
		static readonly NativeHandle selRemoveElement_XHandle = Selector.GetHandle ("removeElement:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRemoveElement_WithNode_X = "removeElement:withNode:";
		static readonly NativeHandle selRemoveElement_WithNode_XHandle = Selector.GetHandle ("removeElement:withNode:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("GKQuadtree");
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
		protected GKQuadTree (NSObjectFlag t) : base (t)
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
		protected internal GKQuadTree (NativeHandle handle) : base (handle)
		{
		}

		[Export ("initWithBoundingQuad:minimumCellSize:")]
		[DesignatedInitializer]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public GKQuadTree (GKQuad quad, float minCellSize)
			: base (NSObjectFlag.Empty)
		{
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.xamarin_simd__NativeHandle_objc_msgSend_GKQuad_float (this.Handle, selInitWithBoundingQuad_MinimumCellSize_XHandle, quad, minCellSize), "initWithBoundingQuad:minimumCellSize:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.xamarin_simd__NativeHandle_objc_msgSendSuper_GKQuad_float (&__objc_super__, selInitWithBoundingQuad_MinimumCellSize_XHandle, quad, minCellSize), "initWithBoundingQuad:minimumCellSize:");
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("addElement:withPoint:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual GKQuadTreeNode AddElement (NSObject element, global::System.Numerics.Vector2 point)
		{
			var element__handle__ = element!.GetNonNullHandle (nameof (element));
			IntPtr exception_gchandle = IntPtr.Zero;
			GKQuadTreeNode? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<GKQuadTreeNode> (global::ObjCRuntime.Messaging.xamarin_simd__NativeHandle_objc_msgSend_NativeHandle_Vector2_exception (this.Handle, selAddElement_WithPoint_XHandle, element__handle__, point, &exception_gchandle), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<GKQuadTreeNode> (global::ObjCRuntime.Messaging.xamarin_simd__NativeHandle_objc_msgSendSuper_NativeHandle_Vector2_exception (&__objc_super__, selAddElement_WithPoint_XHandle, element__handle__, point, &exception_gchandle), false)!;
					GC.KeepAlive (this);
				}
			}
			Runtime.ThrowException (exception_gchandle);
			GC.KeepAlive (element);
			return ret!;
		}
		[Export ("addElement:withQuad:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual GKQuadTreeNode AddElement (NSObject element, GKQuad quad)
		{
			var element__handle__ = element!.GetNonNullHandle (nameof (element));
			GKQuadTreeNode? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<GKQuadTreeNode> (global::ObjCRuntime.Messaging.xamarin_simd__NativeHandle_objc_msgSend_NativeHandle_GKQuad (this.Handle, selAddElement_WithQuad_XHandle, element__handle__, quad), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<GKQuadTreeNode> (global::ObjCRuntime.Messaging.xamarin_simd__NativeHandle_objc_msgSendSuper_NativeHandle_GKQuad (&__objc_super__, selAddElement_WithQuad_XHandle, element__handle__, quad), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (element);
			return ret!;
		}
		[Export ("quadtreeWithBoundingQuad:minimumCellSize:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static GKQuadTree FromBoundingQuad (GKQuad quad, float minCellSize)
		{
			GKQuadTree ret;
			ret =  Runtime.GetNSObject<GKQuadTree> (global::ObjCRuntime.Messaging.xamarin_simd__NativeHandle_objc_msgSend_GKQuad_float (class_ptr, selQuadtreeWithBoundingQuad_MinimumCellSize_XHandle, quad, minCellSize), false)!;
			return ret;
		}
		[Export ("elementsAtPoint:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject[] GetElements (global::System.Numerics.Vector2 point)
		{
			NSObject[] ret;
			if (IsDirectBinding) {
				ret = CFArray.ArrayFromHandle<NSObject>(global::ObjCRuntime.Messaging.xamarin_simd__NativeHandle_objc_msgSend_Vector2 (this.Handle, selElementsAtPoint_XHandle, point), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFArray.ArrayFromHandle<NSObject>(global::ObjCRuntime.Messaging.xamarin_simd__NativeHandle_objc_msgSendSuper_Vector2 (&__objc_super__, selElementsAtPoint_XHandle, point), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("elementsInQuad:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject[] GetElements (GKQuad quad)
		{
			NSObject[] ret;
			if (IsDirectBinding) {
				ret = CFArray.ArrayFromHandle<NSObject>(global::ObjCRuntime.Messaging.xamarin_simd__NativeHandle_objc_msgSend_GKQuad (this.Handle, selElementsInQuad_XHandle, quad), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFArray.ArrayFromHandle<NSObject>(global::ObjCRuntime.Messaging.xamarin_simd__NativeHandle_objc_msgSendSuper_GKQuad (&__objc_super__, selElementsInQuad_XHandle, quad), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("removeElement:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool RemoveElement (NSObject element)
		{
			var element__handle__ = element!.GetNonNullHandle (nameof (element));
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (this.Handle, selRemoveElement_XHandle, element__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle (&__objc_super__, selRemoveElement_XHandle, element__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (element);
			return ret != 0;
		}
		[Export ("removeElement:withNode:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool RemoveElement (NSObject data, GKQuadTreeNode node)
		{
			var data__handle__ = data!.GetNonNullHandle (nameof (data));
			var node__handle__ = node!.GetNonNullHandle (nameof (node));
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selRemoveElement_WithNode_XHandle, data__handle__, node__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selRemoveElement_WithNode_XHandle, data__handle__, node__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (data);
			GC.KeepAlive (node);
			return ret != 0;
		}
	} /* class GKQuadTree */
}
