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
namespace SpriteKit {
	/// <summary>The class used to render SpriteKit.</summary>
	[Register("SKRenderer", true)]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe partial class SKRenderer : NSObject {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIgnoresSiblingOrderX = "ignoresSiblingOrder";
		static readonly NativeHandle selIgnoresSiblingOrderXHandle = Selector.GetHandle ("ignoresSiblingOrder");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRenderWithViewport_CommandBuffer_RenderPassDescriptor_X = "renderWithViewport:commandBuffer:renderPassDescriptor:";
		static readonly NativeHandle selRenderWithViewport_CommandBuffer_RenderPassDescriptor_XHandle = Selector.GetHandle ("renderWithViewport:commandBuffer:renderPassDescriptor:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRenderWithViewport_RenderCommandEncoder_RenderPassDescriptor_CommandQueue_X = "renderWithViewport:renderCommandEncoder:renderPassDescriptor:commandQueue:";
		static readonly NativeHandle selRenderWithViewport_RenderCommandEncoder_RenderPassDescriptor_CommandQueue_XHandle = Selector.GetHandle ("renderWithViewport:renderCommandEncoder:renderPassDescriptor:commandQueue:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRendererWithDevice_X = "rendererWithDevice:";
		static readonly NativeHandle selRendererWithDevice_XHandle = Selector.GetHandle ("rendererWithDevice:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSceneX = "scene";
		static readonly NativeHandle selSceneXHandle = Selector.GetHandle ("scene");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetIgnoresSiblingOrder_X = "setIgnoresSiblingOrder:";
		static readonly NativeHandle selSetIgnoresSiblingOrder_XHandle = Selector.GetHandle ("setIgnoresSiblingOrder:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetScene_X = "setScene:";
		static readonly NativeHandle selSetScene_XHandle = Selector.GetHandle ("setScene:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetShouldCullNonVisibleNodes_X = "setShouldCullNonVisibleNodes:";
		static readonly NativeHandle selSetShouldCullNonVisibleNodes_XHandle = Selector.GetHandle ("setShouldCullNonVisibleNodes:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetShowsDrawCount_X = "setShowsDrawCount:";
		static readonly NativeHandle selSetShowsDrawCount_XHandle = Selector.GetHandle ("setShowsDrawCount:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetShowsFields_X = "setShowsFields:";
		static readonly NativeHandle selSetShowsFields_XHandle = Selector.GetHandle ("setShowsFields:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetShowsNodeCount_X = "setShowsNodeCount:";
		static readonly NativeHandle selSetShowsNodeCount_XHandle = Selector.GetHandle ("setShowsNodeCount:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetShowsPhysics_X = "setShowsPhysics:";
		static readonly NativeHandle selSetShowsPhysics_XHandle = Selector.GetHandle ("setShowsPhysics:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetShowsQuadCount_X = "setShowsQuadCount:";
		static readonly NativeHandle selSetShowsQuadCount_XHandle = Selector.GetHandle ("setShowsQuadCount:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selShouldCullNonVisibleNodesX = "shouldCullNonVisibleNodes";
		static readonly NativeHandle selShouldCullNonVisibleNodesXHandle = Selector.GetHandle ("shouldCullNonVisibleNodes");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selShowsDrawCountX = "showsDrawCount";
		static readonly NativeHandle selShowsDrawCountXHandle = Selector.GetHandle ("showsDrawCount");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selShowsFieldsX = "showsFields";
		static readonly NativeHandle selShowsFieldsXHandle = Selector.GetHandle ("showsFields");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selShowsNodeCountX = "showsNodeCount";
		static readonly NativeHandle selShowsNodeCountXHandle = Selector.GetHandle ("showsNodeCount");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selShowsPhysicsX = "showsPhysics";
		static readonly NativeHandle selShowsPhysicsXHandle = Selector.GetHandle ("showsPhysics");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selShowsQuadCountX = "showsQuadCount";
		static readonly NativeHandle selShowsQuadCountXHandle = Selector.GetHandle ("showsQuadCount");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selUpdateAtTime_X = "updateAtTime:";
		static readonly NativeHandle selUpdateAtTime_XHandle = Selector.GetHandle ("updateAtTime:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("SKRenderer");
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
		protected SKRenderer (NSObjectFlag t) : base (t)
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
		protected internal SKRenderer (NativeHandle handle) : base (handle)
		{
		}

		[Export ("rendererWithDevice:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SKRenderer FromDevice (global::Metal.IMTLDevice device)
		{
			var device__handle__ = device!.GetNonNullHandle (nameof (device));
			SKRenderer? ret;
			ret =  Runtime.GetNSObject<SKRenderer> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, selRendererWithDevice_XHandle, device__handle__), false)!;
			GC.KeepAlive (device);
			return ret!;
		}
		[Export ("renderWithViewport:commandBuffer:renderPassDescriptor:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Render (CGRect viewport, global::Metal.IMTLCommandBuffer commandBuffer, global::Metal.MTLRenderPassDescriptor renderPassDescriptor)
		{
			var commandBuffer__handle__ = commandBuffer!.GetNonNullHandle (nameof (commandBuffer));
			var renderPassDescriptor__handle__ = renderPassDescriptor!.GetNonNullHandle (nameof (renderPassDescriptor));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_CGRect_NativeHandle_NativeHandle (this.Handle, selRenderWithViewport_CommandBuffer_RenderPassDescriptor_XHandle, viewport, commandBuffer__handle__, renderPassDescriptor__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_CGRect_NativeHandle_NativeHandle (&__objc_super__, selRenderWithViewport_CommandBuffer_RenderPassDescriptor_XHandle, viewport, commandBuffer__handle__, renderPassDescriptor__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (commandBuffer);
			GC.KeepAlive (renderPassDescriptor);
		}
		[Export ("renderWithViewport:renderCommandEncoder:renderPassDescriptor:commandQueue:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Render (CGRect viewport, global::Metal.IMTLRenderCommandEncoder renderCommandEncoder, global::Metal.MTLRenderPassDescriptor renderPassDescriptor, global::Metal.IMTLCommandQueue commandQueue)
		{
			var renderCommandEncoder__handle__ = renderCommandEncoder!.GetNonNullHandle (nameof (renderCommandEncoder));
			var renderPassDescriptor__handle__ = renderPassDescriptor!.GetNonNullHandle (nameof (renderPassDescriptor));
			var commandQueue__handle__ = commandQueue!.GetNonNullHandle (nameof (commandQueue));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_CGRect_NativeHandle_NativeHandle_NativeHandle (this.Handle, selRenderWithViewport_RenderCommandEncoder_RenderPassDescriptor_CommandQueue_XHandle, viewport, renderCommandEncoder__handle__, renderPassDescriptor__handle__, commandQueue__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_CGRect_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, selRenderWithViewport_RenderCommandEncoder_RenderPassDescriptor_CommandQueue_XHandle, viewport, renderCommandEncoder__handle__, renderPassDescriptor__handle__, commandQueue__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (renderCommandEncoder);
			GC.KeepAlive (renderPassDescriptor);
			GC.KeepAlive (commandQueue);
		}
		[Export ("updateAtTime:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Update (double currentTime)
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_Double (this.Handle, selUpdateAtTime_XHandle, currentTime);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_Double (&__objc_super__, selUpdateAtTime_XHandle, currentTime);
					GC.KeepAlive (this);
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool IgnoresSiblingOrder {
			[Export ("ignoresSiblingOrder")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIgnoresSiblingOrderXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIgnoresSiblingOrderXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setIgnoresSiblingOrder:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetIgnoresSiblingOrder_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetIgnoresSiblingOrder_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		object? __mt_Scene_var;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual SKScene? Scene {
			[Export ("scene", ArgumentSemantic.Assign)]
			get {
				SKScene? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<SKScene> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selSceneXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<SKScene> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selSceneXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				MarkDirty ();
				__mt_Scene_var = ret;
				return ret!;
			}
			[Export ("setScene:", ArgumentSemantic.Assign)]
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
				MarkDirty ();
				__mt_Scene_var = value;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldCullNonVisibleNodes {
			[Export ("shouldCullNonVisibleNodes")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selShouldCullNonVisibleNodesXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selShouldCullNonVisibleNodesXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setShouldCullNonVisibleNodes:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetShouldCullNonVisibleNodes_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetShouldCullNonVisibleNodes_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShowsDrawCount {
			[Export ("showsDrawCount")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selShowsDrawCountXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selShowsDrawCountXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setShowsDrawCount:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetShowsDrawCount_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetShowsDrawCount_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShowsFields {
			[Export ("showsFields")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selShowsFieldsXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selShowsFieldsXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setShowsFields:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetShowsFields_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetShowsFields_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShowsNodeCount {
			[Export ("showsNodeCount")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selShowsNodeCountXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selShowsNodeCountXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setShowsNodeCount:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetShowsNodeCount_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetShowsNodeCount_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShowsPhysics {
			[Export ("showsPhysics")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selShowsPhysicsXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selShowsPhysicsXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setShowsPhysics:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetShowsPhysics_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetShowsPhysics_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShowsQuadCount {
			[Export ("showsQuadCount")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selShowsQuadCountXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selShowsQuadCountXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setShowsQuadCount:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetShowsQuadCount_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetShowsQuadCount_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_Scene_var = null;
			}
		}
	} /* class SKRenderer */
}
