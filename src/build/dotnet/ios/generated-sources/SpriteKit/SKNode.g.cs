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
	/// <summary>The building block out of which scene-graphs are made. The root of the tree is an <see cref="T:SpriteKit.SKScene" />.</summary><remarks><para><img href="~/xml/SpriteKit/_images/SKNode.Hierarchy.png" alt="Class diagram of the SKNode hierarchy" /></para><para><list type="table"><listheader><term>Class</term><description>Description</description></listheader><item><term><see cref="T:SpriteKit.SKCropNode" /></term><description>Uses a mask to crop its children.</description></item><item><term><see cref="T:SpriteKit.SKEffectNode" /></term><description>Applies a <see cref="T:CoreImage.CIFilter" /> to its children.</description></item><item><term><see cref="T:SpriteKit.SKEmitterNode" /></term><description>Produces and displays particles.</description></item><item><term><see cref="T:SpriteKit.SKLabelNode" /></term><description>Displays text.</description></item><item><term><see cref="T:SpriteKit.SKShapeNode" /></term><description>Displays a <see cref="T:CoreGraphics.CGPath" />-based shape.</description></item><item><term><see cref="T:SpriteKit.SKSpriteNode" /></term><description>Displays a textured sprite.</description></item></list></para></remarks><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/SpriteKit/Reference/SKNode_Ref/index.html">Apple documentation for <c>SKNode</c></related>
	[Register("SKNode", true)]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe partial class SKNode : global::UIKit.UIResponder, INSCoding, INSCopying, INSSecureCoding, global::UIKit.IUICoordinateSpace, global::UIKit.IUIFocusEnvironment, global::UIKit.IUIFocusItem, global::UIKit.IUIFocusItemContainer {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("SKNode");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
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
		public SKNode (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("initWithCoder:"), coder.Handle), "initWithCoder:");
			} else {
				unsafe {
				var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
				InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (&__objc_super__, Selector.GetHandle ("initWithCoder:"), coder.Handle), "initWithCoder:");
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
		protected SKNode (NSObjectFlag t) : base (t)
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
		protected internal SKNode (NativeHandle handle) : base (handle)
		{
		}

		[Export ("init")]
		[DesignatedInitializer]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public SKNode ()
			: base (NSObjectFlag.Empty)
		{
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("init")), "init");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("init")), "init");
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("addChild:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AddChild (SKNode node)
		{
			var node__handle__ = node!.GetNonNullHandle (nameof (node));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("addChild:"), node__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("addChild:"), node__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (node);
			#pragma warning disable 168
			#pragma warning restore 168
		}
		[Export ("calculateAccumulatedFrame")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGRect CalculateAccumulatedFrame ()
		{
			CGRect ret;
			if (IsDirectBinding) {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend (this.Handle, Selector.GetHandle ("calculateAccumulatedFrame"));
				} else {
					ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret (this.Handle, Selector.GetHandle ("calculateAccumulatedFrame"));
				}
			} else {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("calculateAccumulatedFrame"));
						GC.KeepAlive (this);
					}
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper_stret (&__objc_super__, Selector.GetHandle ("calculateAccumulatedFrame"));
						GC.KeepAlive (this);
					}
				}
			}
			return ret!;
		}
		[Export ("containsPoint:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ContainsPoint (CGPoint point)
		{
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_CGPoint (this.Handle, Selector.GetHandle ("containsPoint:"), point);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_CGPoint (&__objc_super__, Selector.GetHandle ("containsPoint:"), point);
					GC.KeepAlive (this);
				}
			}
			return ret != 0;
		}
		/// <param name="point">To be added.</param><param name="coordinateSpace">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("convertPoint:fromCoordinateSpace:")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGPoint ConvertPointFromCoordinateSpace (CGPoint point, global::UIKit.IUICoordinateSpace coordinateSpace)
		{
			var coordinateSpace__handle__ = coordinateSpace!.GetNonNullHandle (nameof (coordinateSpace));
			CGPoint ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.CGPoint_objc_msgSend_CGPoint_NativeHandle (this.Handle, Selector.GetHandle ("convertPoint:fromCoordinateSpace:"), point, coordinateSpace__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.CGPoint_objc_msgSendSuper_CGPoint_NativeHandle (&__objc_super__, Selector.GetHandle ("convertPoint:fromCoordinateSpace:"), point, coordinateSpace__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (coordinateSpace);
			return ret!;
		}
		[Export ("convertPoint:fromNode:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGPoint ConvertPointFromNode (CGPoint point, SKNode sourceNode)
		{
			var sourceNode__handle__ = sourceNode!.GetNonNullHandle (nameof (sourceNode));
			CGPoint ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.CGPoint_objc_msgSend_CGPoint_NativeHandle (this.Handle, Selector.GetHandle ("convertPoint:fromNode:"), point, sourceNode__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.CGPoint_objc_msgSendSuper_CGPoint_NativeHandle (&__objc_super__, Selector.GetHandle ("convertPoint:fromNode:"), point, sourceNode__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (sourceNode);
			return ret!;
		}
		/// <param name="point">To be added.</param><param name="coordinateSpace">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("convertPoint:toCoordinateSpace:")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGPoint ConvertPointToCoordinateSpace (CGPoint point, global::UIKit.IUICoordinateSpace coordinateSpace)
		{
			var coordinateSpace__handle__ = coordinateSpace!.GetNonNullHandle (nameof (coordinateSpace));
			CGPoint ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.CGPoint_objc_msgSend_CGPoint_NativeHandle (this.Handle, Selector.GetHandle ("convertPoint:toCoordinateSpace:"), point, coordinateSpace__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.CGPoint_objc_msgSendSuper_CGPoint_NativeHandle (&__objc_super__, Selector.GetHandle ("convertPoint:toCoordinateSpace:"), point, coordinateSpace__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (coordinateSpace);
			return ret!;
		}
		[Export ("convertPoint:toNode:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGPoint ConvertPointToNode (CGPoint point, SKNode sourceNode)
		{
			var sourceNode__handle__ = sourceNode!.GetNonNullHandle (nameof (sourceNode));
			CGPoint ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.CGPoint_objc_msgSend_CGPoint_NativeHandle (this.Handle, Selector.GetHandle ("convertPoint:toNode:"), point, sourceNode__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.CGPoint_objc_msgSendSuper_CGPoint_NativeHandle (&__objc_super__, Selector.GetHandle ("convertPoint:toNode:"), point, sourceNode__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (sourceNode);
			return ret!;
		}
		/// <param name="rect">To be added.</param><param name="coordinateSpace">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("convertRect:fromCoordinateSpace:")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGRect ConvertRectFromCoordinateSpace (CGRect rect, global::UIKit.IUICoordinateSpace coordinateSpace)
		{
			var coordinateSpace__handle__ = coordinateSpace!.GetNonNullHandle (nameof (coordinateSpace));
			CGRect ret;
			if (IsDirectBinding) {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_CGRect_NativeHandle (this.Handle, Selector.GetHandle ("convertRect:fromCoordinateSpace:"), rect, coordinateSpace__handle__);
				} else {
					ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret_CGRect_NativeHandle (this.Handle, Selector.GetHandle ("convertRect:fromCoordinateSpace:"), rect, coordinateSpace__handle__);
				}
			} else {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper_CGRect_NativeHandle (&__objc_super__, Selector.GetHandle ("convertRect:fromCoordinateSpace:"), rect, coordinateSpace__handle__);
						GC.KeepAlive (this);
					}
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper_stret_CGRect_NativeHandle (&__objc_super__, Selector.GetHandle ("convertRect:fromCoordinateSpace:"), rect, coordinateSpace__handle__);
						GC.KeepAlive (this);
					}
				}
			}
			GC.KeepAlive (coordinateSpace);
			return ret!;
		}
		/// <param name="rect">To be added.</param><param name="coordinateSpace">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("convertRect:toCoordinateSpace:")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGRect ConvertRectToCoordinateSpace (CGRect rect, global::UIKit.IUICoordinateSpace coordinateSpace)
		{
			var coordinateSpace__handle__ = coordinateSpace!.GetNonNullHandle (nameof (coordinateSpace));
			CGRect ret;
			if (IsDirectBinding) {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_CGRect_NativeHandle (this.Handle, Selector.GetHandle ("convertRect:toCoordinateSpace:"), rect, coordinateSpace__handle__);
				} else {
					ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret_CGRect_NativeHandle (this.Handle, Selector.GetHandle ("convertRect:toCoordinateSpace:"), rect, coordinateSpace__handle__);
				}
			} else {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper_CGRect_NativeHandle (&__objc_super__, Selector.GetHandle ("convertRect:toCoordinateSpace:"), rect, coordinateSpace__handle__);
						GC.KeepAlive (this);
					}
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper_stret_CGRect_NativeHandle (&__objc_super__, Selector.GetHandle ("convertRect:toCoordinateSpace:"), rect, coordinateSpace__handle__);
						GC.KeepAlive (this);
					}
				}
			}
			GC.KeepAlive (coordinateSpace);
			return ret!;
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
				ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("copyWithZone:"), zone__handle__), true)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("copyWithZone:"), zone__handle__), true)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (zone);
			return ret!;
		}
		[Export ("node")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SKNode Create ()
		{
			SKNode ret;
			ret =  Runtime.GetNSObject<SKNode> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, Selector.GetHandle ("node")), false)!;
			return ret;
		}
		[Export ("nodeWithFileNamed:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SKNode? Create (string filename)
		{
			if (filename is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (filename));
			var nsfilename = CFString.CreateNative (filename);
			SKNode? ret;
			ret =  Runtime.GetNSObject<SKNode> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, Selector.GetHandle ("nodeWithFileNamed:"), nsfilename), false)!;
			CFString.ReleaseNative (nsfilename);
			return ret!;
		}
		[Export ("nodeWithFileNamed:securelyWithClasses:andError:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static SKNode? Create (string filename, nint classesPtr, out NSError error)
		{
			if (filename is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (filename));
			NativeHandle errorValue = IntPtr.Zero;
			var nsfilename = CFString.CreateNative (filename);
			SKNode? ret;
			ret =  Runtime.GetNSObject<SKNode> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_IntPtr_ref_NativeHandle (class_ptr, Selector.GetHandle ("nodeWithFileNamed:securelyWithClasses:andError:"), nsfilename, classesPtr, &errorValue), false)!;
			CFString.ReleaseNative (nsfilename);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		/// <param name="hint">The focus movement hint.</param><summary>Called when a focus change may soon happen.</summary><remarks>To be added.</remarks>
		[Export ("didHintFocusMovement:")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidHintFocusMovement (global::UIKit.UIFocusMovementHint hint)
		{
			var hint__handle__ = hint!.GetNonNullHandle (nameof (hint));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("didHintFocusMovement:"), hint__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("didHintFocusMovement:"), hint__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (hint);
		}
		/// <param name="context">Metadata for the focus change.</param><param name="coordinator">The <see cref="T:UIKit.UIFocusAnimationCoordinator" /> coordinating the focus-change animations.</param><summary>Delegate method called shortly after focus has changed to a new <see cref="T:UIKit.UIView" />.</summary><remarks>To be added.</remarks>
		[Export ("didUpdateFocusInContext:withAnimationCoordinator:")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidUpdateFocus (global::UIKit.UIFocusUpdateContext context, global::UIKit.UIFocusAnimationCoordinator coordinator)
		{
			var context__handle__ = context!.GetNonNullHandle (nameof (context));
			var coordinator__handle__ = coordinator!.GetNonNullHandle (nameof (coordinator));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("didUpdateFocusInContext:withAnimationCoordinator:"), context__handle__, coordinator__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("didUpdateFocusInContext:withAnimationCoordinator:"), context__handle__, coordinator__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (context);
			GC.KeepAlive (coordinator);
		}
		/// <summary>Encodes the state of the object using the provided encoder.</summary><param name="encoder">The encoder object where the state of the object will be stored</param><remarks><para>This method is part of the <see cref="T:Foundation.INSCoding" /> protocol and is used by applications to preserve the state of the object into an archive.</para><para>Developers will typically create an <see cref="T:Foundation.NSKeyedArchiver" /> and then invoke the <see cref="M:Foundation.NSKeyedArchiver.ArchiveRootObjectToFile(Foundation.NSObject,System.String)" /> method which will call into this method.</para><para>If developers want to allow their object to be archived, they should override this method and store their state in using the provided <paramref name="encoder" /> parameter. In addition, developers should also implement a constructor that takes an NSCoder argument and is exported with <c>[Export ("initWithCoder:")]</c>.</para><example><code lang="csharp lang-csharp"><![CDATA[public void override EncodeTo (NSCoder coder) {
		/// coder.Encode (1, key: "version");
		/// coder.Encode (userName, key: "userName");
		/// coder.Encode (hostName, key: "hostName");]]></code></example></remarks>
		[Export ("encodeWithCoder:")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void EncodeTo (NSCoder encoder)
		{
			var encoder__handle__ = encoder!.GetNonNullHandle (nameof (encoder));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("encodeWithCoder:"), encoder__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("encodeWithCoder:"), encoder__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (encoder);
		}
		[Export ("enumerateChildNodesWithName:usingBlock:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void EnumerateChildNodes (string name, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDSKNodeChildEnumeratorHandler))]SKNodeChildEnumeratorHandler enumerationHandler)
		{
			if (name is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (name));
			if (enumerationHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (enumerationHandler));
			var nsname = CFString.CreateNative (name);
			using var block_enumerationHandler = Trampolines.SDSKNodeChildEnumeratorHandler.CreateBlock (enumerationHandler);
			BlockLiteral *block_ptr_enumerationHandler = &block_enumerationHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("enumerateChildNodesWithName:usingBlock:"), nsname, (IntPtr) block_ptr_enumerationHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("enumerateChildNodesWithName:usingBlock:"), nsname, (IntPtr) block_ptr_enumerationHandler);
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsname);
		}
		[Export ("actionForKey:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual SKAction? GetActionForKey (string key)
		{
			if (key is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (key));
			var nskey = CFString.CreateNative (key);
			SKAction? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<SKAction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("actionForKey:"), nskey), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<SKAction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("actionForKey:"), nskey), false)!;
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nskey);
			return ret!;
		}
		[Export ("childNodeWithName:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual SKNode? GetChildNode (string name)
		{
			if (name is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (name));
			var nsname = CFString.CreateNative (name);
			SKNode? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<SKNode> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("childNodeWithName:"), nsname), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<SKNode> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("childNodeWithName:"), nsname), false)!;
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		/// <param name="rect">The rectangle whose focus items to get.</param><summary>Returns a list of all the child focus items within the specified rectangle.</summary><returns>The list of all the child focus items within the specified rectangle.</returns><remarks>To be added.</remarks>
		[Export ("focusItemsInRect:")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::UIKit.IUIFocusItem[] GetFocusItems (CGRect rect)
		{
			global::UIKit.IUIFocusItem[] ret;
			if (IsDirectBinding) {
				ret = CFArray.ArrayFromHandle<IUIFocusItem>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_CGRect (this.Handle, Selector.GetHandle ("focusItemsInRect:"), rect), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFArray.ArrayFromHandle<IUIFocusItem>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_CGRect (&__objc_super__, Selector.GetHandle ("focusItemsInRect:"), rect), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("nodeAtPoint:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual SKNode GetNodeAtPoint (CGPoint point)
		{
			SKNode ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<SKNode> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_CGPoint (this.Handle, Selector.GetHandle ("nodeAtPoint:"), point), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<SKNode> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_CGPoint (&__objc_super__, Selector.GetHandle ("nodeAtPoint:"), point), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("nodesAtPoint:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual SKNode[] GetNodesAtPoint (CGPoint point)
		{
			SKNode[] ret;
			if (IsDirectBinding) {
				ret = CFArray.ArrayFromHandle<SKNode>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_CGPoint (this.Handle, Selector.GetHandle ("nodesAtPoint:"), point), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFArray.ArrayFromHandle<SKNode>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_CGPoint (&__objc_super__, Selector.GetHandle ("nodesAtPoint:"), point), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("objectForKeyedSubscript:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual SKNode GetObjectsMatching (string nameExpression)
		{
			if (nameExpression is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (nameExpression));
			var nsnameExpression = CFString.CreateNative (nameExpression);
			SKNode? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<SKNode> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("objectForKeyedSubscript:"), nsnameExpression), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<SKNode> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("objectForKeyedSubscript:"), nsnameExpression), false)!;
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsnameExpression);
			return ret!;
		}
		/// <param name="nodes">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("obstaclesFromNodeBounds:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static global::GameplayKit.GKPolygonObstacle[] GetObstaclesFromNodeBounds (SKNode[] nodes)
		{
			if (nodes is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (nodes));
			using var nsa_nodes = NSArray.FromNSObjects (nodes);
			global::GameplayKit.GKPolygonObstacle[] ret;
			ret = CFArray.ArrayFromHandle<global::GameplayKit.GKPolygonObstacle>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, Selector.GetHandle ("obstaclesFromNodeBounds:"), nsa_nodes.Handle), false)!;
			return ret;
		}
		/// <param name="nodes">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("obstaclesFromNodePhysicsBodies:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static global::GameplayKit.GKPolygonObstacle[] GetObstaclesFromNodePhysicsBodies (SKNode[] nodes)
		{
			if (nodes is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (nodes));
			using var nsa_nodes = NSArray.FromNSObjects (nodes);
			global::GameplayKit.GKPolygonObstacle[] ret;
			ret = CFArray.ArrayFromHandle<global::GameplayKit.GKPolygonObstacle>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, Selector.GetHandle ("obstaclesFromNodePhysicsBodies:"), nsa_nodes.Handle), false)!;
			return ret;
		}
		/// <param name="sprites">To be added.</param><param name="accuracy">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("obstaclesFromSpriteTextures:accuracy:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static global::GameplayKit.GKPolygonObstacle[] GetObstaclesFromSpriteTextures (SKNode[] sprites, float accuracy)
		{
			if (sprites is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (sprites));
			using var nsa_sprites = NSArray.FromNSObjects (sprites);
			global::GameplayKit.GKPolygonObstacle[] ret;
			ret = CFArray.ArrayFromHandle<global::GameplayKit.GKPolygonObstacle>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_float (class_ptr, Selector.GetHandle ("obstaclesFromSpriteTextures:accuracy:"), nsa_sprites.Handle, accuracy), false)!;
			return ret;
		}
		[Export ("inParentHierarchy:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool InParentHierarchy (SKNode node)
		{
			var node__handle__ = node!.GetNonNullHandle (nameof (node));
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("inParentHierarchy:"), node__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("inParentHierarchy:"), node__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (node);
			return ret != 0;
		}
		/// <param name="node">To be added.</param><param name="index">To be added.</param><summary>Inserts <paramref name="node" /> at the position that is specified by <paramref name="index" /> into the list of this node's children.</summary><remarks>To be added.</remarks>
		[Export ("insertChild:atIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void InsertChild (SKNode node, nint index)
		{
			var node__handle__ = node!.GetNonNullHandle (nameof (node));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_IntPtr (this.Handle, Selector.GetHandle ("insertChild:atIndex:"), node__handle__, index);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_IntPtr (&__objc_super__, Selector.GetHandle ("insertChild:atIndex:"), node__handle__, index);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (node);
			#pragma warning disable 168
			#pragma warning restore 168
		}
		[Export ("intersectsNode:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool IntersectsNode (SKNode node)
		{
			var node__handle__ = node!.GetNonNullHandle (nameof (node));
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("intersectsNode:"), node__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("intersectsNode:"), node__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (node);
			return ret != 0;
		}
		[Export ("isEqualToNode:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool IsEqual (SKNode node)
		{
			var node__handle__ = node!.GetNonNullHandle (nameof (node));
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("isEqualToNode:"), node__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("isEqualToNode:"), node__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (node);
			return ret != 0;
		}
		[Export ("moveToParent:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void MoveToParent (SKNode parent)
		{
			var parent__handle__ = parent!.GetNonNullHandle (nameof (parent));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("moveToParent:"), parent__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("moveToParent:"), parent__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (parent);
		}
		/// <param name="nodes">To be added.</param><summary>Creates a new <see cref="T:GameplayKit.GKPolygonObstacle" /> for each <see cref="T:SpriteKit.SKNode" /> in <paramref name="nodes" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("obstaclesFromNodeBounds:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static global::GameplayKit.GKPolygonObstacle[] ObstaclesFromNodeBounds (SKNode[] nodes)
		{
			if (nodes is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (nodes));
			using var nsa_nodes = NSArray.FromNSObjects (nodes);
			global::GameplayKit.GKPolygonObstacle[] ret;
			ret = CFArray.ArrayFromHandle<global::GameplayKit.GKPolygonObstacle>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, Selector.GetHandle ("obstaclesFromNodeBounds:"), nsa_nodes.Handle), false)!;
			return ret;
		}
		/// <param name="nodes">To be added.</param><summary>Creates a new <see cref="T:GameplayKit.GKPolygonObstacle" /> for each <see cref="P:SpriteKit.SKNode.PhysicsBody" /> in the <see cref="T:SpriteKit.SKNode" /> object in <paramref name="nodes" /></summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("obstaclesFromNodePhysicsBodies:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static global::GameplayKit.GKPolygonObstacle[] ObstaclesFromNodePhysicsBodies (SKNode[] nodes)
		{
			if (nodes is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (nodes));
			using var nsa_nodes = NSArray.FromNSObjects (nodes);
			global::GameplayKit.GKPolygonObstacle[] ret;
			ret = CFArray.ArrayFromHandle<global::GameplayKit.GKPolygonObstacle>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, Selector.GetHandle ("obstaclesFromNodePhysicsBodies:"), nsa_nodes.Handle), false)!;
			return ret;
		}
		/// <param name="sprites">To be added.</param><param name="accuracy">To be added.</param><summary>Creates a new <see cref="T:GameplayKit.GKPolygonObstacle" /> by converting the <see cref="P:SpriteKit.SKSpriteNode.Texture" /> of each <see cref="T:SpriteKit.SKNode" /> object in <paramref name="sprites" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("obstaclesFromSpriteTextures:accuracy:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static global::GameplayKit.GKPolygonObstacle[] ObstaclesFromSpriteTextures (SKNode[] sprites, float accuracy)
		{
			if (sprites is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (sprites));
			using var nsa_sprites = NSArray.FromNSObjects (sprites);
			global::GameplayKit.GKPolygonObstacle[] ret;
			ret = CFArray.ArrayFromHandle<global::GameplayKit.GKPolygonObstacle>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_float (class_ptr, Selector.GetHandle ("obstaclesFromSpriteTextures:accuracy:"), nsa_sprites.Handle, accuracy), false)!;
			return ret;
		}
		[Export ("removeActionForKey:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemoveActionForKey (string key)
		{
			if (key is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (key));
			var nskey = CFString.CreateNative (key);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("removeActionForKey:"), nskey);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("removeActionForKey:"), nskey);
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nskey);
		}
		[Export ("removeAllActions")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemoveAllActions ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("removeAllActions"));
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("removeAllActions"));
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("removeAllChildren")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemoveAllChildren ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("removeAllChildren"));
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("removeAllChildren"));
					GC.KeepAlive (this);
				}
			}
			#pragma warning disable 168
			#pragma warning restore 168
		}
		[Export ("removeChildrenInArray:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemoveChildren (SKNode[] nodes)
		{
			if (nodes is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (nodes));
			using var nsa_nodes = NSArray.FromNSObjects (nodes);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("removeChildrenInArray:"), nsa_nodes.Handle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("removeChildrenInArray:"), nsa_nodes.Handle);
					GC.KeepAlive (this);
				}
			}
			#pragma warning disable 168
			#pragma warning restore 168
		}
		[Export ("removeFromParent")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemoveFromParent ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("removeFromParent"));
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("removeFromParent"));
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("runAction:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RunAction (SKAction action)
		{
			var action__handle__ = action!.GetNonNullHandle (nameof (action));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("runAction:"), action__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("runAction:"), action__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (action);
		}
		[Export ("runAction:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void RunAction (SKAction action, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action completionHandler)
		{
			var action__handle__ = action!.GetNonNullHandle (nameof (action));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDAction.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("runAction:completion:"), action__handle__, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("runAction:completion:"), action__handle__, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (action);
		}
		/// <param name="action">The action to add and run.</param>
		/// <summary>Asynchronously adds an action to the node that will be processed in the next animation loop.</summary>
		/// <returns>A task that represents the asynchronous RunAction operation</returns>
		/// <remarks>
		///           <para copied="true">The RunActionAsync method is suitable to be used with C# async by returning control to the caller with a Task representing the operation.</para>
		///           <para copied="true">To be added.</para>
		///         </remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task RunActionAsync (SKAction action)
		{
			var tcs = new TaskCompletionSource<bool> ();
			RunAction(action, () => {
				tcs.SetResult (true);
			});
			return tcs.Task;
		}
		[Export ("runAction:withKey:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RunAction (SKAction action, string key)
		{
			var action__handle__ = action!.GetNonNullHandle (nameof (action));
			if (key is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (key));
			var nskey = CFString.CreateNative (key);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("runAction:withKey:"), action__handle__, nskey);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("runAction:withKey:"), action__handle__, nskey);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (action);
			CFString.ReleaseNative (nskey);
		}
		/// <summary>When <c>this</c> is the active focus environment, requests a focus update, which can potentially change the <see cref="UIKit.UIViewController.PreferredFocusedView" />. (See also <see cref="UIKit.UIViewController.UpdateFocusIfNeeded" />.)</summary><remarks>To be added.</remarks>
		[Export ("setNeedsFocusUpdate")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetNeedsFocusUpdate ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("setNeedsFocusUpdate"));
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("setNeedsFocusUpdate"));
					GC.KeepAlive (this);
				}
			}
		}
		/// <param name="scale">To be added.</param><summary>Sets the X- and Y-scales to <paramref name="scale" />.</summary><remarks>To be added.</remarks>
		[Export ("setScale:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetScale (nfloat scale)
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_nfloat (this.Handle, Selector.GetHandle ("setScale:"), scale);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_nfloat (&__objc_super__, Selector.GetHandle ("setScale:"), scale);
					GC.KeepAlive (this);
				}
			}
		}
		/// <param name="context">To be added.</param><summary>Called prior to the current object either losing or receiving focus. If either focus environment returns <see langword="false" />, the focus update is canceled.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("shouldUpdateFocusInContext:")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldUpdateFocus (global::UIKit.UIFocusUpdateContext context)
		{
			var context__handle__ = context!.GetNonNullHandle (nameof (context));
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("shouldUpdateFocusInContext:"), context__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("shouldUpdateFocusInContext:"), context__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (context);
			return ret != 0;
		}
		/// <summary>If any focus environment has a pending update, this method forces an immediate focus update. Unlike <see cref="UIKit.IUIFocusEnvironment.SetNeedsFocusUpdate" />, this method may be called by any <see cref="T:UIKit.IUIFocusEnvironment" />, whether it currently contains focus or not.</summary><remarks>To be added.</remarks>
		[Export ("updateFocusIfNeeded")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void UpdateFocusIfNeeded ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("updateFocusIfNeeded"));
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("updateFocusIfNeeded"));
					GC.KeepAlive (this);
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nfloat Alpha {
			[Export ("alpha")]
			get {
				nfloat ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend (this.Handle, Selector.GetHandle ("alpha"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("alpha"));
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setAlpha:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_nfloat (this.Handle, Selector.GetHandle ("setAlpha:"), value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_nfloat (&__objc_super__, Selector.GetHandle ("setAlpha:"), value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>Gets the bounding rectangle of the object in its own coordinate space.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		public virtual CGRect Bounds {
			[Export ("bounds")]
			[UnsupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				CGRect ret;
				if (IsDirectBinding) {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend (this.Handle, Selector.GetHandle ("bounds"));
					} else {
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret (this.Handle, Selector.GetHandle ("bounds"));
					}
				} else {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("bounds"));
							GC.KeepAlive (this);
						}
					} else {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper_stret (&__objc_super__, Selector.GetHandle ("bounds"));
							GC.KeepAlive (this);
						}
					}
				}
				return ret!;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		public virtual bool CanBecomeFocused {
			[Export ("canBecomeFocused")]
			[UnsupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("canBecomeFocused"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("canBecomeFocused"));
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual SKNode[] Children {
			[Export ("children")]
			get {
				SKNode[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<SKNode>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("children")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<SKNode>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("children")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual SKConstraint[]? Constraints {
			[Export ("constraints", ArgumentSemantic.Copy)]
			get {
				SKConstraint[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<SKConstraint>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("constraints")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<SKConstraint>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("constraints")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setConstraints:", ArgumentSemantic.Copy)]
			set {
				using var nsa_value = value is null ? null : NSArray.FromNSObjects (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setConstraints:"), nsa_value.GetHandle ());
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("setConstraints:"), nsa_value.GetHandle ());
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>Gets the coordinate space implementation.</summary><value>The coordinate space implementation.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		public virtual global::UIKit.IUICoordinateSpace CoordinateSpace {
			[Export ("coordinateSpace")]
			[UnsupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				global::UIKit.IUICoordinateSpace? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetINativeObject<global::UIKit.IUICoordinateSpace> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("coordinateSpace")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetINativeObject<global::UIKit.IUICoordinateSpace> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("coordinateSpace")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		public virtual SKNodeFocusBehavior FocusBehavior {
			[Export ("focusBehavior", ArgumentSemantic.Assign)]
			get {
				SKNodeFocusBehavior ret;
				if (IsDirectBinding) {
					ret = (SKNodeFocusBehavior) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("focusBehavior"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (SKNodeFocusBehavior) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("focusBehavior"));
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setFocusBehavior:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setFocusBehavior:"), (IntPtr) (long) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, Selector.GetHandle ("setFocusBehavior:"), (IntPtr) (long) value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		public virtual global::UIKit.UIFocusEffect? FocusEffect {
			[Export ("focusEffect", ArgumentSemantic.Copy)]
			[UnsupportedOSPlatform ("tvos")]
			[UnsupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("ios15.0")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				global::UIKit.UIFocusEffect? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIFocusEffect> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("focusEffect")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<global::UIKit.UIFocusEffect> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("focusEffect")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		public virtual string? FocusGroupIdentifier {
			[Export ("focusGroupIdentifier")]
			[UnsupportedOSPlatform ("tvos")]
			[UnsupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("ios14.0")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("focusGroupIdentifier")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("focusGroupIdentifier")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		public virtual global::UIKit.UIFocusGroupPriority FocusGroupPriority {
			[Export ("focusGroupPriority")]
			[UnsupportedOSPlatform ("tvos")]
			[UnsupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("ios15.0")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				global::UIKit.UIFocusGroupPriority ret;
				if (IsDirectBinding) {
					ret = (UIFocusGroupPriority) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("focusGroupPriority"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (UIFocusGroupPriority) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("focusGroupPriority"));
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		/// <summary>Gets the container that manages focus information for child focus items.</summary><value>The container that manages focus information for child focus items.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		public virtual global::UIKit.IUIFocusItemContainer? FocusItemContainer {
			[Export ("focusItemContainer")]
			[UnsupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				global::UIKit.IUIFocusItemContainer? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetINativeObject<global::UIKit.IUIFocusItemContainer> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("focusItemContainer")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetINativeObject<global::UIKit.IUIFocusItemContainer> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("focusItemContainer")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[SupportedOSPlatform ("tvos18.0")]
		[UnsupportedOSPlatform ("macos")]
		public virtual global::UIKit.UIFocusItemDeferralMode FocusItemDeferralMode {
			[Export ("focusItemDeferralMode")]
			[UnsupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("ios18.0")]
			[SupportedOSPlatform ("tvos18.0")]
			[SupportedOSPlatform ("maccatalyst18.0")]
			get {
				global::UIKit.UIFocusItemDeferralMode ret;
				if (IsDirectBinding) {
					ret = (UIFocusItemDeferralMode) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("focusItemDeferralMode"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (UIFocusItemDeferralMode) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("focusItemDeferralMode"));
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGRect Frame {
			[Export ("frame")]
			get {
				CGRect ret;
				if (IsDirectBinding) {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend (this.Handle, Selector.GetHandle ("frame"));
					} else {
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret (this.Handle, Selector.GetHandle ("frame"));
					}
				} else {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("frame"));
							GC.KeepAlive (this);
						}
					} else {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper_stret (&__objc_super__, Selector.GetHandle ("frame"));
							GC.KeepAlive (this);
						}
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool HasActions {
			[Export ("hasActions")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("hasActions"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("hasActions"));
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		/// <summary>Gets a value that tells whether the node and its descendants are rendered to the screen.</summary><value>To be added.</value><remarks></remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool Hidden {
			[Export ("isHidden")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isHidden"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("isHidden"));
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setHidden:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setHidden:"), value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, Selector.GetHandle ("setHidden:"), value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		public virtual bool IsTransparentFocusItem {
			[Export ("isTransparentFocusItem")]
			[UnsupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("ios15.0")]
			[SupportedOSPlatform ("tvos18.0")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isTransparentFocusItem"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("isTransparentFocusItem"));
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string? Name {
			[Export ("name", ArgumentSemantic.Copy)]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("name")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("name")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setName:", ArgumentSemantic.Copy)]
			set {
				var nsvalue = CFString.CreateNative (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setName:"), nsvalue);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("setName:"), nsvalue);
						GC.KeepAlive (this);
					}
				}
				CFString.ReleaseNative (nsvalue);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual SKNode? Parent {
			[Export ("parent")]
			get {
				SKNode? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<SKNode> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("parent")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<SKNode> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("parent")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		object? __mt_ParentFocusEnvironment_var;
		/// <summary>Gets the parent focus environment.</summary><value>The parent focus environment.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		public virtual global::UIKit.IUIFocusEnvironment? ParentFocusEnvironment {
			[Export ("parentFocusEnvironment", ArgumentSemantic.Weak)]
			[UnsupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				global::UIKit.IUIFocusEnvironment? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetINativeObject<global::UIKit.IUIFocusEnvironment> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("parentFocusEnvironment")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetINativeObject<global::UIKit.IUIFocusEnvironment> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("parentFocusEnvironment")), false)!;
						GC.KeepAlive (this);
					}
				}
				MarkDirty ();
				__mt_ParentFocusEnvironment_var = ret;
				return ret!;
			}
		}
		/// <summary>Gets or sets a value that causes this node and its descendants to be skipped when actions are processed for the scene. <see langword="true" /> causes them to be skipped.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool Paused {
			[Export ("isPaused")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isPaused"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("isPaused"));
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setPaused:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setPaused:"), value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, Selector.GetHandle ("setPaused:"), value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual SKPhysicsBody? PhysicsBody {
			[Export ("physicsBody", ArgumentSemantic.Retain)]
			get {
				SKPhysicsBody? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<SKPhysicsBody> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("physicsBody")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<SKPhysicsBody> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("physicsBody")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setPhysicsBody:", ArgumentSemantic.Retain)]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setPhysicsBody:"), value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("setPhysicsBody:"), value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGPoint Position {
			[Export ("position")]
			get {
				CGPoint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.CGPoint_objc_msgSend (this.Handle, Selector.GetHandle ("position"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGPoint_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("position"));
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setPosition:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_CGPoint (this.Handle, Selector.GetHandle ("setPosition:"), value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_CGPoint (&__objc_super__, Selector.GetHandle ("setPosition:"), value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>Gets the list of focus environments, ordered by priority, that the environment prefers when updating the focus.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		public virtual global::UIKit.IUIFocusEnvironment[] PreferredFocusEnvironments {
			[Export ("preferredFocusEnvironments", ArgumentSemantic.Copy)]
			[UnsupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				global::UIKit.IUIFocusEnvironment[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<IUIFocusEnvironment>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("preferredFocusEnvironments")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<IUIFocusEnvironment>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("preferredFocusEnvironments")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		object? __mt_PreferredFocusedView_var;
		/// <summary>If not <see langword="null" />, indicates the child <see cref="T:UIKit.UIView" /> that should receive focus by default.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[ObsoletedOSPlatform ("ios10.0", "Use 'PreferredFocusEnvironments' instead.")]
		[ObsoletedOSPlatform ("tvos10.0", "Use 'PreferredFocusEnvironments' instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'PreferredFocusEnvironments' instead.")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		public virtual global::UIKit.UIView? PreferredFocusedView {
			[Export ("preferredFocusedView", ArgumentSemantic.Weak)]
			[ObsoletedOSPlatform ("ios12.2", "Use 'PreferredFocusEnvironments' instead.")]
			[ObsoletedOSPlatform ("tvos12.2", "Use 'PreferredFocusEnvironments' instead.")]
			[ObsoletedOSPlatform ("maccatalyst15.0", "Use 'PreferredFocusEnvironments' instead.")]
			[UnsupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				global::UIKit.UIView? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIView> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("preferredFocusedView")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<global::UIKit.UIView> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("preferredFocusedView")), false)!;
						GC.KeepAlive (this);
					}
				}
				MarkDirty ();
				__mt_PreferredFocusedView_var = ret;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual SKReachConstraints? ReachConstraints {
			[Export ("reachConstraints", ArgumentSemantic.Copy)]
			get {
				SKReachConstraints? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<SKReachConstraints> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("reachConstraints")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<SKReachConstraints> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("reachConstraints")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setReachConstraints:", ArgumentSemantic.Copy)]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setReachConstraints:"), value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("setReachConstraints:"), value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual SKScene? Scene {
			[Export ("scene")]
			get {
				SKScene? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<SKScene> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("scene")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<SKScene> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("scene")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nfloat Speed {
			[Export ("speed")]
			get {
				nfloat ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend (this.Handle, Selector.GetHandle ("speed"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("speed"));
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setSpeed:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_nfloat (this.Handle, Selector.GetHandle ("setSpeed:"), value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_nfloat (&__objc_super__, Selector.GetHandle ("setSpeed:"), value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSMutableDictionary? UserData {
			[Export ("userData", ArgumentSemantic.Retain)]
			get {
				NSMutableDictionary? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSMutableDictionary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("userData")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSMutableDictionary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("userData")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setUserData:", ArgumentSemantic.Retain)]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setUserData:"), value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("setUserData:"), value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		/// <summary>Gets or sets a value that controls whether the node responds to touch.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool UserInteractionEnabled {
			[Export ("isUserInteractionEnabled")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isUserInteractionEnabled"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("isUserInteractionEnabled"));
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setUserInteractionEnabled:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setUserInteractionEnabled:"), value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, Selector.GetHandle ("setUserInteractionEnabled:"), value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nfloat XScale {
			[Export ("xScale")]
			get {
				nfloat ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend (this.Handle, Selector.GetHandle ("xScale"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("xScale"));
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setXScale:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_nfloat (this.Handle, Selector.GetHandle ("setXScale:"), value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_nfloat (&__objc_super__, Selector.GetHandle ("setXScale:"), value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nfloat YScale {
			[Export ("yScale")]
			get {
				nfloat ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend (this.Handle, Selector.GetHandle ("yScale"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("yScale"));
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setYScale:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_nfloat (this.Handle, Selector.GetHandle ("setYScale:"), value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_nfloat (&__objc_super__, Selector.GetHandle ("setYScale:"), value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nfloat ZPosition {
			[Export ("zPosition")]
			get {
				nfloat ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend (this.Handle, Selector.GetHandle ("zPosition"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("zPosition"));
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setZPosition:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_nfloat (this.Handle, Selector.GetHandle ("setZPosition:"), value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_nfloat (&__objc_super__, Selector.GetHandle ("setZPosition:"), value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nfloat ZRotation {
			[Export ("zRotation")]
			get {
				nfloat ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend (this.Handle, Selector.GetHandle ("zRotation"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("zRotation"));
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setZRotation:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_nfloat (this.Handle, Selector.GetHandle ("setZRotation:"), value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_nfloat (&__objc_super__, Selector.GetHandle ("setZRotation:"), value);
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
				__mt_ParentFocusEnvironment_var = null;
				__mt_PreferredFocusedView_var = null;
			}
		}
	} /* class SKNode */
}
