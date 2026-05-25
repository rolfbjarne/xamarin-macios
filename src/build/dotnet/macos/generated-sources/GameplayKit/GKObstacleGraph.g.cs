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
	/// <summary>A <see cref="T:GameplayKit.GKGraph" /> that generates a space-filling network for representation, allowing smooth, but inefficient, paths.</summary><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/GameplayKit/Reference/GKObstacleGraph_Class/index.html">Apple documentation for <c>GKObstacleGraph</c></related>
	[Register("GKObstacleGraph", true)]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe partial class GKObstacleGraph : GKGraph {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAddObstacles_X = "addObstacles:";
		static readonly NativeHandle selAddObstacles_XHandle = Selector.GetHandle ("addObstacles:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selBufferRadiusX = "bufferRadius";
		static readonly NativeHandle selBufferRadiusXHandle = Selector.GetHandle ("bufferRadius");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selClassForGenericArgumentAtIndex_X = "classForGenericArgumentAtIndex:";
		static readonly NativeHandle selClassForGenericArgumentAtIndex_XHandle = Selector.GetHandle ("classForGenericArgumentAtIndex:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selConnectNodeUsingObstacles_X = "connectNodeUsingObstacles:";
		static readonly NativeHandle selConnectNodeUsingObstacles_XHandle = Selector.GetHandle ("connectNodeUsingObstacles:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selConnectNodeUsingObstacles_IgnoringBufferRadiusOfObstacles_X = "connectNodeUsingObstacles:ignoringBufferRadiusOfObstacles:";
		static readonly NativeHandle selConnectNodeUsingObstacles_IgnoringBufferRadiusOfObstacles_XHandle = Selector.GetHandle ("connectNodeUsingObstacles:ignoringBufferRadiusOfObstacles:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selConnectNodeUsingObstacles_IgnoringObstacles_X = "connectNodeUsingObstacles:ignoringObstacles:";
		static readonly NativeHandle selConnectNodeUsingObstacles_IgnoringObstacles_XHandle = Selector.GetHandle ("connectNodeUsingObstacles:ignoringObstacles:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selGraphWithObstacles_BufferRadius_X = "graphWithObstacles:bufferRadius:";
		static readonly NativeHandle selGraphWithObstacles_BufferRadius_XHandle = Selector.GetHandle ("graphWithObstacles:bufferRadius:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selGraphWithObstacles_BufferRadius_NodeClass_X = "graphWithObstacles:bufferRadius:nodeClass:";
		static readonly NativeHandle selGraphWithObstacles_BufferRadius_NodeClass_XHandle = Selector.GetHandle ("graphWithObstacles:bufferRadius:nodeClass:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithObstacles_BufferRadius_X = "initWithObstacles:bufferRadius:";
		static readonly NativeHandle selInitWithObstacles_BufferRadius_XHandle = Selector.GetHandle ("initWithObstacles:bufferRadius:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithObstacles_BufferRadius_NodeClass_X = "initWithObstacles:bufferRadius:nodeClass:";
		static readonly NativeHandle selInitWithObstacles_BufferRadius_NodeClass_XHandle = Selector.GetHandle ("initWithObstacles:bufferRadius:nodeClass:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsConnectionLockedFromNode_ToNode_X = "isConnectionLockedFromNode:toNode:";
		static readonly NativeHandle selIsConnectionLockedFromNode_ToNode_XHandle = Selector.GetHandle ("isConnectionLockedFromNode:toNode:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLockConnectionFromNode_ToNode_X = "lockConnectionFromNode:toNode:";
		static readonly NativeHandle selLockConnectionFromNode_ToNode_XHandle = Selector.GetHandle ("lockConnectionFromNode:toNode:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selNodesForObstacle_X = "nodesForObstacle:";
		static readonly NativeHandle selNodesForObstacle_XHandle = Selector.GetHandle ("nodesForObstacle:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selObstaclesX = "obstacles";
		static readonly NativeHandle selObstaclesXHandle = Selector.GetHandle ("obstacles");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRemoveAllObstaclesX = "removeAllObstacles";
		static readonly NativeHandle selRemoveAllObstaclesXHandle = Selector.GetHandle ("removeAllObstacles");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRemoveObstacles_X = "removeObstacles:";
		static readonly NativeHandle selRemoveObstacles_XHandle = Selector.GetHandle ("removeObstacles:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selUnlockConnectionFromNode_ToNode_X = "unlockConnectionFromNode:toNode:";
		static readonly NativeHandle selUnlockConnectionFromNode_ToNode_XHandle = Selector.GetHandle ("unlockConnectionFromNode:toNode:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("GKObstacleGraph");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		/// <summary>Creates a new <see cref="GKObstacleGraph" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public GKObstacleGraph () : base (NSObjectFlag.Empty)
		{
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, global::ObjCRuntime.Selector.Init), "init");
			} else {
				unsafe {
				var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
				InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, global::ObjCRuntime.Selector.Init), "init");
				GC.KeepAlive (this);
				}
			}
		}

		/// <summary>A constructor that initializes the object from the data stored in the unarchiver object.</summary>
		/// <param name="coder">The unarchiver object.</param>
		/// <remarks>
		///   <para>This constructor is provided to allow the class to be initialized from an unarchiver (for example, during NIB deserialization). This is part of the <see cref="Foundation.NSCoding" /> protocol.</para>
		///   <para>If developers want to create a subclass of this object and continue to support deserialization from an archive, they should implement a constructor with an identical signature: taking a single parameter of type <see cref="Foundation.NSCoder" /> and decorate it with the <c>[Export("initWithCoder:"]</c> attribute.</para>
		///   <para>The state of this object can also be serialized by using the <see cref="Foundation.INSCoding.EncodeTo" /> companion method.</para>
		/// </remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[DesignatedInitializer]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("initWithCoder:")]
		public GKObstacleGraph (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.InitWithCoder, coder.Handle), "initWithCoder:");
			} else {
				unsafe {
				var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
				InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (&__objc_super__, Selector.InitWithCoder, coder.Handle), "initWithCoder:");
				GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (coder);
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
		protected GKObstacleGraph (NSObjectFlag t) : base (t)
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
		protected internal GKObstacleGraph (NativeHandle handle) : base (handle)
		{
		}

		[Export ("initWithObstacles:bufferRadius:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public GKObstacleGraph (GKPolygonObstacle[] obstacles, float bufferRadius)
			: base (NSObjectFlag.Empty)
		{
			if (obstacles is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (obstacles));
			using var nsa_obstacles = NSArray.FromNSObjects (obstacles);
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_float (this.Handle, selInitWithObstacles_BufferRadius_XHandle, nsa_obstacles.Handle, bufferRadius), "initWithObstacles:bufferRadius:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_float (&__objc_super__, selInitWithObstacles_BufferRadius_XHandle, nsa_obstacles.Handle, bufferRadius), "initWithObstacles:bufferRadius:");
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("initWithObstacles:bufferRadius:nodeClass:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal GKObstacleGraph (GKPolygonObstacle[] obstacles, float bufferRadius, Class nodeClass)
			: base (NSObjectFlag.Empty)
		{
			if (obstacles is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (obstacles));
			var nodeClass__handle__ = nodeClass!.GetNonNullHandle (nameof (nodeClass));
			using var nsa_obstacles = NSArray.FromNSObjects (obstacles);
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_float_NativeHandle (this.Handle, selInitWithObstacles_BufferRadius_NodeClass_XHandle, nsa_obstacles.Handle, bufferRadius, nodeClass.Handle), "initWithObstacles:bufferRadius:nodeClass:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_float_NativeHandle (&__objc_super__, selInitWithObstacles_BufferRadius_NodeClass_XHandle, nsa_obstacles.Handle, bufferRadius, nodeClass.Handle), "initWithObstacles:bufferRadius:nodeClass:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (nodeClass);
		}
		[Export ("addObstacles:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AddObstacles (GKPolygonObstacle[] obstacles)
		{
			if (obstacles is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (obstacles));
			using var nsa_obstacles = NSArray.FromNSObjects (obstacles);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selAddObstacles_XHandle, nsa_obstacles.Handle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selAddObstacles_XHandle, nsa_obstacles.Handle);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("connectNodeUsingObstacles:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ConnectNodeUsingObstacles (GKGraphNode2D node)
		{
			var node__handle__ = node!.GetNonNullHandle (nameof (node));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selConnectNodeUsingObstacles_XHandle, node__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selConnectNodeUsingObstacles_XHandle, node__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (node);
		}
		[Export ("connectNodeUsingObstacles:ignoringObstacles:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ConnectNodeUsingObstacles (GKGraphNode2D node, GKPolygonObstacle[] obstaclesToIgnore)
		{
			var node__handle__ = node!.GetNonNullHandle (nameof (node));
			if (obstaclesToIgnore is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (obstaclesToIgnore));
			using var nsa_obstaclesToIgnore = NSArray.FromNSObjects (obstaclesToIgnore);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selConnectNodeUsingObstacles_IgnoringObstacles_XHandle, node__handle__, nsa_obstaclesToIgnore.Handle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selConnectNodeUsingObstacles_IgnoringObstacles_XHandle, node__handle__, nsa_obstaclesToIgnore.Handle);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (node);
		}
		[Export ("connectNodeUsingObstacles:ignoringBufferRadiusOfObstacles:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ConnectNodeUsingObstaclesIgnoringBufferRadius (GKGraphNode2D node, GKPolygonObstacle[] obstaclesBufferRadiusToIgnore)
		{
			var node__handle__ = node!.GetNonNullHandle (nameof (node));
			if (obstaclesBufferRadiusToIgnore is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (obstaclesBufferRadiusToIgnore));
			using var nsa_obstaclesBufferRadiusToIgnore = NSArray.FromNSObjects (obstaclesBufferRadiusToIgnore);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selConnectNodeUsingObstacles_IgnoringBufferRadiusOfObstacles_XHandle, node__handle__, nsa_obstaclesBufferRadiusToIgnore.Handle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selConnectNodeUsingObstacles_IgnoringBufferRadiusOfObstacles_XHandle, node__handle__, nsa_obstaclesBufferRadiusToIgnore.Handle);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (node);
		}
		[Export ("graphWithObstacles:bufferRadius:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static GKObstacleGraph FromObstacles (GKPolygonObstacle[] obstacles, float bufferRadius)
		{
			if (obstacles is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (obstacles));
			using var nsa_obstacles = NSArray.FromNSObjects (obstacles);
			GKObstacleGraph ret;
			ret =  Runtime.GetNSObject<GKObstacleGraph> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_float (class_ptr, selGraphWithObstacles_BufferRadius_XHandle, nsa_obstacles.Handle, bufferRadius), false)!;
			return ret;
		}
		/// <param name="index">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("classForGenericArgumentAtIndex:")]
		[EditorBrowsable (EditorBrowsableState.Never)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual Class GetClassForGenericArgument (nuint index)
		{
			Class ret;
			if (IsDirectBinding) {
				ret = Runtime.GetINativeObject<global::ObjCRuntime.Class> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UIntPtr (this.Handle, selClassForGenericArgumentAtIndex_XHandle, index), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = Runtime.GetINativeObject<global::ObjCRuntime.Class> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_UIntPtr (&__objc_super__, selClassForGenericArgumentAtIndex_XHandle, index), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		/// <param name="index">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public global::System.Type GetTypeForGenericArgument (nuint index)
		{
			return Class.Lookup (GetClassForGenericArgument (index))!;
		}
		[Export ("graphWithObstacles:bufferRadius:nodeClass:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static nint GraphWithObstacles (GKPolygonObstacle[] obstacles, float bufferRadius, Class nodeClass)
		{
			if (obstacles is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (obstacles));
			var nodeClass__handle__ = nodeClass!.GetNonNullHandle (nameof (nodeClass));
			using var nsa_obstacles = NSArray.FromNSObjects (obstacles);
			nint ret;
			ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_NativeHandle_float_NativeHandle (class_ptr, selGraphWithObstacles_BufferRadius_NodeClass_XHandle, nsa_obstacles.Handle, bufferRadius, nodeClass.Handle);
			GC.KeepAlive (nodeClass);
			return ret!;
		}
		[Export ("isConnectionLockedFromNode:toNode:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool IsConnectionLocked (GKGraphNode2D startNode, GKGraphNode2D endNode)
		{
			var startNode__handle__ = startNode!.GetNonNullHandle (nameof (startNode));
			var endNode__handle__ = endNode!.GetNonNullHandle (nameof (endNode));
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selIsConnectionLockedFromNode_ToNode_XHandle, startNode__handle__, endNode__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selIsConnectionLockedFromNode_ToNode_XHandle, startNode__handle__, endNode__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (startNode);
			GC.KeepAlive (endNode);
			return ret != 0;
		}
		[Export ("lockConnectionFromNode:toNode:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void LockConnection (GKGraphNode2D startNode, GKGraphNode2D endNode)
		{
			var startNode__handle__ = startNode!.GetNonNullHandle (nameof (startNode));
			var endNode__handle__ = endNode!.GetNonNullHandle (nameof (endNode));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selLockConnectionFromNode_ToNode_XHandle, startNode__handle__, endNode__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selLockConnectionFromNode_ToNode_XHandle, startNode__handle__, endNode__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (startNode);
			GC.KeepAlive (endNode);
		}
		[Export ("removeAllObstacles")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemoveAllObstacles ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selRemoveAllObstaclesXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selRemoveAllObstaclesXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("removeObstacles:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemoveObstacles (GKPolygonObstacle[] obstacles)
		{
			if (obstacles is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (obstacles));
			using var nsa_obstacles = NSArray.FromNSObjects (obstacles);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selRemoveObstacles_XHandle, nsa_obstacles.Handle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selRemoveObstacles_XHandle, nsa_obstacles.Handle);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("unlockConnectionFromNode:toNode:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void UnlockConnection (GKGraphNode2D startNode, GKGraphNode2D endNode)
		{
			var startNode__handle__ = startNode!.GetNonNullHandle (nameof (startNode));
			var endNode__handle__ = endNode!.GetNonNullHandle (nameof (endNode));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selUnlockConnectionFromNode_ToNode_XHandle, startNode__handle__, endNode__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selUnlockConnectionFromNode_ToNode_XHandle, startNode__handle__, endNode__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (startNode);
			GC.KeepAlive (endNode);
		}
		[Export ("nodesForObstacle:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal virtual nint _GetNodes (GKPolygonObstacle obstacle)
		{
			var obstacle__handle__ = obstacle!.GetNonNullHandle (nameof (obstacle));
			nint ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_NativeHandle (this.Handle, selNodesForObstacle_XHandle, obstacle__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_NativeHandle (&__objc_super__, selNodesForObstacle_XHandle, obstacle__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (obstacle);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual float BufferRadius {
			[Export ("bufferRadius")]
			get {
				float ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selBufferRadiusXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.float_objc_msgSendSuper (&__objc_super__, selBufferRadiusXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual GKPolygonObstacle[] Obstacles {
			[Export ("obstacles")]
			get {
				GKPolygonObstacle[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<GKPolygonObstacle>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selObstaclesXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<GKPolygonObstacle>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selObstaclesXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
	} /* class GKObstacleGraph */
}
