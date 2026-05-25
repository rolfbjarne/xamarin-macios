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
namespace ModelIO {
	/// <summary>Base class for objects in a <see cref="T:ModelIO.MDLAsset" />.</summary><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/ModelIO/Reference/MDLObject_Class/index.html">Apple documentation for <c>MDLObject</c></related>
	[Register("MDLObject", true)]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe partial class MDLObject : NSObject, IMDLNamed {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAddChild_X = "addChild:";
		static readonly NativeHandle selAddChild_XHandle = Selector.GetHandle ("addChild:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selBoundingBoxAtTime_X = "boundingBoxAtTime:";
		static readonly NativeHandle selBoundingBoxAtTime_XHandle = Selector.GetHandle ("boundingBoxAtTime:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selChildrenX = "children";
		static readonly NativeHandle selChildrenXHandle = Selector.GetHandle ("children");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selComponentConformingToProtocol_X = "componentConformingToProtocol:";
		static readonly NativeHandle selComponentConformingToProtocol_XHandle = Selector.GetHandle ("componentConformingToProtocol:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selComponentsX = "components";
		static readonly NativeHandle selComponentsXHandle = Selector.GetHandle ("components");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selEnumerateChildObjectsOfClass_Root_UsingBlock_StopPointer_X = "enumerateChildObjectsOfClass:root:usingBlock:stopPointer:";
		static readonly NativeHandle selEnumerateChildObjectsOfClass_Root_UsingBlock_StopPointer_XHandle = Selector.GetHandle ("enumerateChildObjectsOfClass:root:usingBlock:stopPointer:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selHiddenX = "hidden";
		static readonly NativeHandle selHiddenXHandle = Selector.GetHandle ("hidden");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInstanceX = "instance";
		static readonly NativeHandle selInstanceXHandle = Selector.GetHandle ("instance");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selNameX = "name";
		static readonly NativeHandle selNameXHandle = Selector.GetHandle ("name");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selObjectAtPath_X = "objectAtPath:";
		static readonly NativeHandle selObjectAtPath_XHandle = Selector.GetHandle ("objectAtPath:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selObjectWithSCNNode_X = "objectWithSCNNode:";
		static readonly NativeHandle selObjectWithSCNNode_XHandle = Selector.GetHandle ("objectWithSCNNode:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selObjectWithSCNNode_BufferAllocator_X = "objectWithSCNNode:bufferAllocator:";
		static readonly NativeHandle selObjectWithSCNNode_BufferAllocator_XHandle = Selector.GetHandle ("objectWithSCNNode:bufferAllocator:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selParentX = "parent";
		static readonly NativeHandle selParentXHandle = Selector.GetHandle ("parent");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPathX = "path";
		static readonly NativeHandle selPathXHandle = Selector.GetHandle ("path");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetChildren_X = "setChildren:";
		static readonly NativeHandle selSetChildren_XHandle = Selector.GetHandle ("setChildren:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetComponent_ForProtocol_X = "setComponent:forProtocol:";
		static readonly NativeHandle selSetComponent_ForProtocol_XHandle = Selector.GetHandle ("setComponent:forProtocol:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetHidden_X = "setHidden:";
		static readonly NativeHandle selSetHidden_XHandle = Selector.GetHandle ("setHidden:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetInstance_X = "setInstance:";
		static readonly NativeHandle selSetInstance_XHandle = Selector.GetHandle ("setInstance:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetName_X = "setName:";
		static readonly NativeHandle selSetName_XHandle = Selector.GetHandle ("setName:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetParent_X = "setParent:";
		static readonly NativeHandle selSetParent_XHandle = Selector.GetHandle ("setParent:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetTransform_X = "setTransform:";
		static readonly NativeHandle selSetTransform_XHandle = Selector.GetHandle ("setTransform:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTransformX = "transform";
		static readonly NativeHandle selTransformXHandle = Selector.GetHandle ("transform");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("MDLObject");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		/// <summary>Creates a new <see cref="MDLObject" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public MDLObject () : base (NSObjectFlag.Empty)
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
		protected MDLObject (NSObjectFlag t) : base (t)
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
		protected internal MDLObject (NativeHandle handle) : base (handle)
		{
		}

		/// <param name="child">To be added.</param><summary>Adds <paramref name="child" /> to this <see cref="T:ModelIO.MDLObject" /> object's <see cref="P:ModelIO.MDLObject.Children" /> property, creating <see cref="P:ModelIO.MDLObject.Children" />, if necessary.</summary><remarks>To be added.</remarks>
		[Export ("addChild:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AddChild (MDLObject child)
		{
			var child__handle__ = child!.GetNonNullHandle (nameof (child));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selAddChild_XHandle, child__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selAddChild_XHandle, child__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (child);
		}
		/// <param name="objectClass">The class of child objects to enumerate.</param><param name="root">The root object whose children will be enumerated.</param><param name="handler">A handler to run on each child object.</param><param name="stop">Developers set this value to <see langword="true" /> to stop enumeration.</param><summary>Runs the provided <paramref name="handler" /> on each component in <paramref name="root" />'s object hierarchy that matches the specified <paramref name="objectClass" />.</summary><remarks>To be added.</remarks>
		[Export ("enumerateChildObjectsOfClass:root:usingBlock:stopPointer:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void EnumerateChildObjects (Class objectClass, MDLObject root, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMDLObjectHandler))]MDLObjectHandler handler, ref bool stop)
		{
			var objectClass__handle__ = objectClass!.GetNonNullHandle (nameof (objectClass));
			var root__handle__ = root!.GetNonNullHandle (nameof (root));
			if (handler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (handler));
			fixed (bool* stop__pointer = &stop) {
			using var block_handler = Trampolines.SDMDLObjectHandler.CreateBlock (handler);
			BlockLiteral *block_ptr_handler = &block_handler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_ref_Boolean (this.Handle, selEnumerateChildObjectsOfClass_Root_UsingBlock_StopPointer_XHandle, objectClass.Handle, root__handle__, (IntPtr) block_ptr_handler, (byte*) stop__pointer);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle_ref_Boolean (&__objc_super__, selEnumerateChildObjectsOfClass_Root_UsingBlock_StopPointer_XHandle, objectClass.Handle, root__handle__, (IntPtr) block_ptr_handler, (byte*) stop__pointer);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (objectClass);
			GC.KeepAlive (root);
			}
		}
		/// <param name="node">To be added.</param><summary>Creates a new MDLObject from the specified Scene Kit node.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("objectWithSCNNode:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MDLObject FromNode (global::SceneKit.SCNNode node)
		{
			var node__handle__ = node!.GetNonNullHandle (nameof (node));
			MDLObject? ret;
			ret =  Runtime.GetNSObject<MDLObject> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, selObjectWithSCNNode_XHandle, node__handle__), false)!;
			GC.KeepAlive (node);
			return ret!;
		}
		/// <param name="node">To be added.</param><param name="bufferAllocator"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>Creates and returns a new Model IO object from the provided node.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("objectWithSCNNode:bufferAllocator:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MDLObject FromNode (global::SceneKit.SCNNode node, IMDLMeshBufferAllocator? bufferAllocator)
		{
			var node__handle__ = node!.GetNonNullHandle (nameof (node));
			var bufferAllocator__handle__ = bufferAllocator.GetHandle ();
			MDLObject? ret;
			ret =  Runtime.GetNSObject<MDLObject> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (class_ptr, selObjectWithSCNNode_BufferAllocator_XHandle, node__handle__, bufferAllocator__handle__), false)!;
			GC.KeepAlive (node);
			GC.KeepAlive (bufferAllocator);
			return ret!;
		}
		/// <param name="atTime">To be added.</param><summary>Returns the bounding box of the Model IO object at the specified time.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("boundingBoxAtTime:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MDLAxisAlignedBoundingBox GetBoundingBox (double atTime)
		{
			MDLAxisAlignedBoundingBox ret;
			if (IsDirectBinding) {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					ret = global::ObjCRuntime.Messaging.xamarin_simd__MDLAxisAlignedBoundingBox_objc_msgSend_Double (this.Handle, selBoundingBoxAtTime_XHandle, atTime);
				} else {
					ret = global::ObjCRuntime.Messaging.xamarin_simd__MDLAxisAlignedBoundingBox_objc_msgSend_stret_Double (this.Handle, selBoundingBoxAtTime_XHandle, atTime);
				}
			} else {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.xamarin_simd__MDLAxisAlignedBoundingBox_objc_msgSendSuper_Double (&__objc_super__, selBoundingBoxAtTime_XHandle, atTime);
						GC.KeepAlive (this);
					}
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.xamarin_simd__MDLAxisAlignedBoundingBox_objc_msgSendSuper_stret_Double (&__objc_super__, selBoundingBoxAtTime_XHandle, atTime);
						GC.KeepAlive (this);
					}
				}
			}
			return ret!;
		}
		/// <param name="protocol">The protocol for which to get the component.</param><summary>Gets this object's component that conforms to <paramref name="protocol" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("componentConformingToProtocol:")]
		[EditorBrowsable (EditorBrowsableState.Never)]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual IMDLComponent? GetComponent (Protocol protocol)
		{
			var protocol__handle__ = protocol!.GetNonNullHandle (nameof (protocol));
			IMDLComponent? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetINativeObject<IMDLComponent> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selComponentConformingToProtocol_XHandle, protocol.Handle), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetINativeObject<IMDLComponent> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selComponentConformingToProtocol_XHandle, protocol.Handle), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (protocol);
			return ret!;
		}
		/// <param name="type">The type to filter by.</param><summary>Gets this object's component that matches the supplied <paramref name="type" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public IMDLComponent? GetComponent (global::System.Type type)
		{
			return GetComponent (new Protocol (type!));
		}
		/// <param name="path">To be added.</param><summary>Returns the Model IO object at the specified path.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("objectAtPath:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MDLObject GetObject (string path)
		{
			if (path is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (path));
			var nspath = CFString.CreateNative (path);
			MDLObject? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<MDLObject> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selObjectAtPath_XHandle, nspath), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<MDLObject> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selObjectAtPath_XHandle, nspath), false)!;
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nspath);
			return ret!;
		}
		/// <param name="component">The component to associate with a protocol.</param><param name="protocol">The protocol to associate with the component.</param><summary>Associates <paramref name="component" /> with this MDLOBject for the specified protocol.</summary><remarks>To be added.</remarks>
		[Export ("setComponent:forProtocol:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetComponent (IMDLComponent component, Protocol protocol)
		{
			var component__handle__ = component!.GetNonNullHandle (nameof (component));
			var protocol__handle__ = protocol!.GetNonNullHandle (nameof (protocol));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selSetComponent_ForProtocol_XHandle, component__handle__, protocol.Handle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selSetComponent_ForProtocol_XHandle, component__handle__, protocol.Handle);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (component);
			GC.KeepAlive (protocol);
		}
		/// <param name="component">The component to associate with a type.</param><param name="type">The type to associate with the component.</param><summary>Makes <paramref name="component" /> the object to provide for the specified <paramref name="type" />.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetComponent (IMDLComponent component, global::System.Type type)
		{
			SetComponent (component, new Protocol (type!));
		}
		/// <summary>Gets or sets the list of the objects of type <see cref="T:ModelIO.MDLObject" /> that belong to this <see cref="T:ModelIO.MDLObject" />.</summary><value><para>(More documentation for this node is coming)</para><para tool="nullallowed">This value can be <see langword="null" />.</para></value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual IMDLObjectContainerComponent Children {
			[Export ("children", ArgumentSemantic.Retain)]
			get {
				IMDLObjectContainerComponent? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetINativeObject<IMDLObjectContainerComponent> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selChildrenXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetINativeObject<IMDLObjectContainerComponent> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selChildrenXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setChildren:", ArgumentSemantic.Retain)]
			set {
				var value__handle__ = value!.GetNonNullHandle (nameof (value));
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetChildren_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetChildren_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		/// <summary>Gets the array of components that belong to this Model I/O object.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual IMDLComponent[] Components {
			[Export ("components", ArgumentSemantic.Copy)]
			get {
				IMDLComponent[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<IMDLComponent>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selComponentsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<IMDLComponent>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selComponentsXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		/// <summary>Gets or sets a Boolean value that controls whether the Model IO object is hidden.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual bool Hidden {
			[Export ("hidden")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selHiddenXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selHiddenXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setHidden:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetHidden_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetHidden_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>To be added.</summary><value><para>(More documentation for this node is coming)</para><para tool="nullallowed">This value can be <see langword="null" />.</para></value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual MDLObject? Instance {
			[Export ("instance", ArgumentSemantic.Retain)]
			get {
				MDLObject? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<MDLObject> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selInstanceXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<MDLObject> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selInstanceXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setInstance:", ArgumentSemantic.Retain)]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetInstance_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetInstance_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		/// <summary>Gets or sets the descriptive name of the named object.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		public virtual string Name {
			[Export ("name")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selNameXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selNameXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setName:")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			set {
				if (value is null)
					ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (value));
				var nsvalue = CFString.CreateNative (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetName_XHandle, nsvalue);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetName_XHandle, nsvalue);
						GC.KeepAlive (this);
					}
				}
				CFString.ReleaseNative (nsvalue);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		object? __mt_Parent_var;
		/// <summary>Gets or sets this <see cref="T:ModelIO.MDLObject" /> object's parent, or <see langword="null" /> if this is a top-level object.</summary><value><para>(More documentation for this node is coming)</para><para tool="nullallowed">This value can be <see langword="null" />.</para></value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MDLObject? Parent {
			[Export ("parent", ArgumentSemantic.Weak)]
			get {
				MDLObject? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<MDLObject> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selParentXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<MDLObject> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selParentXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				MarkDirty ();
				__mt_Parent_var = ret;
				return ret!;
			}
			[Export ("setParent:", ArgumentSemantic.Weak)]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetParent_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetParent_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
				MarkDirty ();
				__mt_Parent_var = value;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual string Path {
			[Export ("path")]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selPathXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selPathXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		/// <summary>Gets or sets the possibly time-dependent transform that establishes this <see cref="T:ModelIO.MDLObject" /> object's coordinate system in relation to its parent's coordinate system.</summary><value><para>(More documentation for this node is coming)</para><para tool="nullallowed">This value can be <see langword="null" />.</para></value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual IMDLTransformComponent? Transform {
			[Export ("transform", ArgumentSemantic.Retain)]
			get {
				IMDLTransformComponent? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetINativeObject<IMDLTransformComponent> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selTransformXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetINativeObject<IMDLTransformComponent> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selTransformXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setTransform:", ArgumentSemantic.Retain)]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetTransform_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetTransform_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_Parent_var = null;
			}
		}
	} /* class MDLObject */
}
