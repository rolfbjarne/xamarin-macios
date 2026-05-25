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
	/// <summary>The building block out of which scene-graphs are made. The root of the tree is an <see cref="T:SpriteKit.SKScene" />.</summary><remarks><para><img href="~/xml/SpriteKit/_images/SKNode.Hierarchy.png" alt="Class diagram of the SKNode hierarchy" /></para><para><list type="table"><listheader><term>Class</term><description>Description</description></listheader><item><term><see cref="T:SpriteKit.SKCropNode" /></term><description>Uses a mask to crop its children.</description></item><item><term><see cref="T:SpriteKit.SKEffectNode" /></term><description>Applies a <see cref="T:CoreImage.CIFilter" /> to its children.</description></item><item><term><see cref="T:SpriteKit.SKEmitterNode" /></term><description>Produces and displays particles.</description></item><item><term><see cref="T:SpriteKit.SKLabelNode" /></term><description>Displays text.</description></item><item><term><see cref="T:SpriteKit.SKShapeNode" /></term><description>Displays a <see cref="T:CoreGraphics.CGPath" />-based shape.</description></item><item><term><see cref="T:SpriteKit.SKSpriteNode" /></term><description>Displays a textured sprite.</description></item></list></para></remarks><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/SpriteKit/Reference/SKNode_Ref/index.html">Apple documentation for <c>SKNode</c></related>
	[Register("SKNode", true)]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe partial class SKNode : global::AppKit.NSResponder, INSCoding, INSCopying, INSSecureCoding {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selActionForKey_X = "actionForKey:";
		static readonly NativeHandle selActionForKey_XHandle = Selector.GetHandle ("actionForKey:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAddChild_X = "addChild:";
		static readonly NativeHandle selAddChild_XHandle = Selector.GetHandle ("addChild:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAlphaX = "alpha";
		static readonly NativeHandle selAlphaXHandle = Selector.GetHandle ("alpha");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCalculateAccumulatedFrameX = "calculateAccumulatedFrame";
		static readonly NativeHandle selCalculateAccumulatedFrameXHandle = Selector.GetHandle ("calculateAccumulatedFrame");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selChildNodeWithName_X = "childNodeWithName:";
		static readonly NativeHandle selChildNodeWithName_XHandle = Selector.GetHandle ("childNodeWithName:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selChildrenX = "children";
		static readonly NativeHandle selChildrenXHandle = Selector.GetHandle ("children");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selConstraintsX = "constraints";
		static readonly NativeHandle selConstraintsXHandle = Selector.GetHandle ("constraints");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selContainsPoint_X = "containsPoint:";
		static readonly NativeHandle selContainsPoint_XHandle = Selector.GetHandle ("containsPoint:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selConvertPoint_FromNode_X = "convertPoint:fromNode:";
		static readonly NativeHandle selConvertPoint_FromNode_XHandle = Selector.GetHandle ("convertPoint:fromNode:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selConvertPoint_ToNode_X = "convertPoint:toNode:";
		static readonly NativeHandle selConvertPoint_ToNode_XHandle = Selector.GetHandle ("convertPoint:toNode:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCopyWithZone_X = "copyWithZone:";
		static readonly NativeHandle selCopyWithZone_XHandle = Selector.GetHandle ("copyWithZone:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selEncodeWithCoder_X = "encodeWithCoder:";
		static readonly NativeHandle selEncodeWithCoder_XHandle = Selector.GetHandle ("encodeWithCoder:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selEnumerateChildNodesWithName_UsingBlock_X = "enumerateChildNodesWithName:usingBlock:";
		static readonly NativeHandle selEnumerateChildNodesWithName_UsingBlock_XHandle = Selector.GetHandle ("enumerateChildNodesWithName:usingBlock:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFrameX = "frame";
		static readonly NativeHandle selFrameXHandle = Selector.GetHandle ("frame");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selHasActionsX = "hasActions";
		static readonly NativeHandle selHasActionsXHandle = Selector.GetHandle ("hasActions");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInParentHierarchy_X = "inParentHierarchy:";
		static readonly NativeHandle selInParentHierarchy_XHandle = Selector.GetHandle ("inParentHierarchy:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitX = "init";
		static readonly NativeHandle selInitXHandle = Selector.GetHandle ("init");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithCoder_X = "initWithCoder:";
		static readonly NativeHandle selInitWithCoder_XHandle = Selector.GetHandle ("initWithCoder:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInsertChild_AtIndex_X = "insertChild:atIndex:";
		static readonly NativeHandle selInsertChild_AtIndex_XHandle = Selector.GetHandle ("insertChild:atIndex:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIntersectsNode_X = "intersectsNode:";
		static readonly NativeHandle selIntersectsNode_XHandle = Selector.GetHandle ("intersectsNode:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsEqualToNode_X = "isEqualToNode:";
		static readonly NativeHandle selIsEqualToNode_XHandle = Selector.GetHandle ("isEqualToNode:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsHiddenX = "isHidden";
		static readonly NativeHandle selIsHiddenXHandle = Selector.GetHandle ("isHidden");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsPausedX = "isPaused";
		static readonly NativeHandle selIsPausedXHandle = Selector.GetHandle ("isPaused");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsUserInteractionEnabledX = "isUserInteractionEnabled";
		static readonly NativeHandle selIsUserInteractionEnabledXHandle = Selector.GetHandle ("isUserInteractionEnabled");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMoveToParent_X = "moveToParent:";
		static readonly NativeHandle selMoveToParent_XHandle = Selector.GetHandle ("moveToParent:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selNameX = "name";
		static readonly NativeHandle selNameXHandle = Selector.GetHandle ("name");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selNodeX = "node";
		static readonly NativeHandle selNodeXHandle = Selector.GetHandle ("node");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selNodeAtPoint_X = "nodeAtPoint:";
		static readonly NativeHandle selNodeAtPoint_XHandle = Selector.GetHandle ("nodeAtPoint:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selNodeWithFileNamed_X = "nodeWithFileNamed:";
		static readonly NativeHandle selNodeWithFileNamed_XHandle = Selector.GetHandle ("nodeWithFileNamed:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selNodeWithFileNamed_SecurelyWithClasses_AndError_X = "nodeWithFileNamed:securelyWithClasses:andError:";
		static readonly NativeHandle selNodeWithFileNamed_SecurelyWithClasses_AndError_XHandle = Selector.GetHandle ("nodeWithFileNamed:securelyWithClasses:andError:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selNodesAtPoint_X = "nodesAtPoint:";
		static readonly NativeHandle selNodesAtPoint_XHandle = Selector.GetHandle ("nodesAtPoint:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selObjectForKeyedSubscript_X = "objectForKeyedSubscript:";
		static readonly NativeHandle selObjectForKeyedSubscript_XHandle = Selector.GetHandle ("objectForKeyedSubscript:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selObstaclesFromNodeBounds_X = "obstaclesFromNodeBounds:";
		static readonly NativeHandle selObstaclesFromNodeBounds_XHandle = Selector.GetHandle ("obstaclesFromNodeBounds:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selObstaclesFromNodePhysicsBodies_X = "obstaclesFromNodePhysicsBodies:";
		static readonly NativeHandle selObstaclesFromNodePhysicsBodies_XHandle = Selector.GetHandle ("obstaclesFromNodePhysicsBodies:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selObstaclesFromSpriteTextures_Accuracy_X = "obstaclesFromSpriteTextures:accuracy:";
		static readonly NativeHandle selObstaclesFromSpriteTextures_Accuracy_XHandle = Selector.GetHandle ("obstaclesFromSpriteTextures:accuracy:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selParentX = "parent";
		static readonly NativeHandle selParentXHandle = Selector.GetHandle ("parent");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPhysicsBodyX = "physicsBody";
		static readonly NativeHandle selPhysicsBodyXHandle = Selector.GetHandle ("physicsBody");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPositionX = "position";
		static readonly NativeHandle selPositionXHandle = Selector.GetHandle ("position");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selReachConstraintsX = "reachConstraints";
		static readonly NativeHandle selReachConstraintsXHandle = Selector.GetHandle ("reachConstraints");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRemoveActionForKey_X = "removeActionForKey:";
		static readonly NativeHandle selRemoveActionForKey_XHandle = Selector.GetHandle ("removeActionForKey:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRemoveAllActionsX = "removeAllActions";
		static readonly NativeHandle selRemoveAllActionsXHandle = Selector.GetHandle ("removeAllActions");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRemoveAllChildrenX = "removeAllChildren";
		static readonly NativeHandle selRemoveAllChildrenXHandle = Selector.GetHandle ("removeAllChildren");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRemoveChildrenInArray_X = "removeChildrenInArray:";
		static readonly NativeHandle selRemoveChildrenInArray_XHandle = Selector.GetHandle ("removeChildrenInArray:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRemoveFromParentX = "removeFromParent";
		static readonly NativeHandle selRemoveFromParentXHandle = Selector.GetHandle ("removeFromParent");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRunAction_X = "runAction:";
		static readonly NativeHandle selRunAction_XHandle = Selector.GetHandle ("runAction:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRunAction_Completion_X = "runAction:completion:";
		static readonly NativeHandle selRunAction_Completion_XHandle = Selector.GetHandle ("runAction:completion:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRunAction_WithKey_X = "runAction:withKey:";
		static readonly NativeHandle selRunAction_WithKey_XHandle = Selector.GetHandle ("runAction:withKey:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSceneX = "scene";
		static readonly NativeHandle selSceneXHandle = Selector.GetHandle ("scene");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAlpha_X = "setAlpha:";
		static readonly NativeHandle selSetAlpha_XHandle = Selector.GetHandle ("setAlpha:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetConstraints_X = "setConstraints:";
		static readonly NativeHandle selSetConstraints_XHandle = Selector.GetHandle ("setConstraints:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetHidden_X = "setHidden:";
		static readonly NativeHandle selSetHidden_XHandle = Selector.GetHandle ("setHidden:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetName_X = "setName:";
		static readonly NativeHandle selSetName_XHandle = Selector.GetHandle ("setName:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetPaused_X = "setPaused:";
		static readonly NativeHandle selSetPaused_XHandle = Selector.GetHandle ("setPaused:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetPhysicsBody_X = "setPhysicsBody:";
		static readonly NativeHandle selSetPhysicsBody_XHandle = Selector.GetHandle ("setPhysicsBody:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetPosition_X = "setPosition:";
		static readonly NativeHandle selSetPosition_XHandle = Selector.GetHandle ("setPosition:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetReachConstraints_X = "setReachConstraints:";
		static readonly NativeHandle selSetReachConstraints_XHandle = Selector.GetHandle ("setReachConstraints:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetScale_X = "setScale:";
		static readonly NativeHandle selSetScale_XHandle = Selector.GetHandle ("setScale:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetSpeed_X = "setSpeed:";
		static readonly NativeHandle selSetSpeed_XHandle = Selector.GetHandle ("setSpeed:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetUserData_X = "setUserData:";
		static readonly NativeHandle selSetUserData_XHandle = Selector.GetHandle ("setUserData:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetUserInteractionEnabled_X = "setUserInteractionEnabled:";
		static readonly NativeHandle selSetUserInteractionEnabled_XHandle = Selector.GetHandle ("setUserInteractionEnabled:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetXScale_X = "setXScale:";
		static readonly NativeHandle selSetXScale_XHandle = Selector.GetHandle ("setXScale:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetYScale_X = "setYScale:";
		static readonly NativeHandle selSetYScale_XHandle = Selector.GetHandle ("setYScale:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetZPosition_X = "setZPosition:";
		static readonly NativeHandle selSetZPosition_XHandle = Selector.GetHandle ("setZPosition:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetZRotation_X = "setZRotation:";
		static readonly NativeHandle selSetZRotation_XHandle = Selector.GetHandle ("setZRotation:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSpeedX = "speed";
		static readonly NativeHandle selSpeedXHandle = Selector.GetHandle ("speed");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selUserDataX = "userData";
		static readonly NativeHandle selUserDataXHandle = Selector.GetHandle ("userData");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selXScaleX = "xScale";
		static readonly NativeHandle selXScaleXHandle = Selector.GetHandle ("xScale");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selYScaleX = "yScale";
		static readonly NativeHandle selYScaleXHandle = Selector.GetHandle ("yScale");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selZPositionX = "zPosition";
		static readonly NativeHandle selZPositionXHandle = Selector.GetHandle ("zPosition");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selZRotationX = "zRotation";
		static readonly NativeHandle selZRotationXHandle = Selector.GetHandle ("zRotation");
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
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selInitXHandle), "init");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selInitXHandle), "init");
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
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selAddChild_XHandle, node__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selAddChild_XHandle, node__handle__);
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
					ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend (this.Handle, selCalculateAccumulatedFrameXHandle);
				} else {
					ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret (this.Handle, selCalculateAccumulatedFrameXHandle);
				}
			} else {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper (&__objc_super__, selCalculateAccumulatedFrameXHandle);
						GC.KeepAlive (this);
					}
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper_stret (&__objc_super__, selCalculateAccumulatedFrameXHandle);
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
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_CGPoint (this.Handle, selContainsPoint_XHandle, point);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_CGPoint (&__objc_super__, selContainsPoint_XHandle, point);
					GC.KeepAlive (this);
				}
			}
			return ret != 0;
		}
		[Export ("convertPoint:fromNode:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGPoint ConvertPointFromNode (CGPoint point, SKNode sourceNode)
		{
			var sourceNode__handle__ = sourceNode!.GetNonNullHandle (nameof (sourceNode));
			CGPoint ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.CGPoint_objc_msgSend_CGPoint_NativeHandle (this.Handle, selConvertPoint_FromNode_XHandle, point, sourceNode__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.CGPoint_objc_msgSendSuper_CGPoint_NativeHandle (&__objc_super__, selConvertPoint_FromNode_XHandle, point, sourceNode__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (sourceNode);
			return ret!;
		}
		[Export ("convertPoint:toNode:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGPoint ConvertPointToNode (CGPoint point, SKNode sourceNode)
		{
			var sourceNode__handle__ = sourceNode!.GetNonNullHandle (nameof (sourceNode));
			CGPoint ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.CGPoint_objc_msgSend_CGPoint_NativeHandle (this.Handle, selConvertPoint_ToNode_XHandle, point, sourceNode__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.CGPoint_objc_msgSendSuper_CGPoint_NativeHandle (&__objc_super__, selConvertPoint_ToNode_XHandle, point, sourceNode__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (sourceNode);
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
		[Export ("node")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SKNode Create ()
		{
			SKNode ret;
			ret =  Runtime.GetNSObject<SKNode> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selNodeXHandle), false)!;
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
			ret =  Runtime.GetNSObject<SKNode> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, selNodeWithFileNamed_XHandle, nsfilename), false)!;
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
			ret =  Runtime.GetNSObject<SKNode> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_IntPtr_ref_NativeHandle (class_ptr, selNodeWithFileNamed_SecurelyWithClasses_AndError_XHandle, nsfilename, classesPtr, &errorValue), false)!;
			CFString.ReleaseNative (nsfilename);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
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
		public new virtual void EncodeTo (NSCoder encoder)
		{
			var encoder__handle__ = encoder!.GetNonNullHandle (nameof (encoder));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selEncodeWithCoder_XHandle, encoder__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selEncodeWithCoder_XHandle, encoder__handle__);
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
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selEnumerateChildNodesWithName_UsingBlock_XHandle, nsname, (IntPtr) block_ptr_enumerationHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selEnumerateChildNodesWithName_UsingBlock_XHandle, nsname, (IntPtr) block_ptr_enumerationHandler);
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
				ret =  Runtime.GetNSObject<SKAction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selActionForKey_XHandle, nskey), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<SKAction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selActionForKey_XHandle, nskey), false)!;
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
				ret =  Runtime.GetNSObject<SKNode> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selChildNodeWithName_XHandle, nsname), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<SKNode> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selChildNodeWithName_XHandle, nsname), false)!;
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("nodeAtPoint:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual SKNode GetNodeAtPoint (CGPoint point)
		{
			SKNode ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<SKNode> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_CGPoint (this.Handle, selNodeAtPoint_XHandle, point), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<SKNode> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_CGPoint (&__objc_super__, selNodeAtPoint_XHandle, point), false)!;
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
				ret = CFArray.ArrayFromHandle<SKNode>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_CGPoint (this.Handle, selNodesAtPoint_XHandle, point), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFArray.ArrayFromHandle<SKNode>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_CGPoint (&__objc_super__, selNodesAtPoint_XHandle, point), false)!;
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
				ret =  Runtime.GetNSObject<SKNode> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selObjectForKeyedSubscript_XHandle, nsnameExpression), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<SKNode> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selObjectForKeyedSubscript_XHandle, nsnameExpression), false)!;
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
			ret = CFArray.ArrayFromHandle<global::GameplayKit.GKPolygonObstacle>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, selObstaclesFromNodeBounds_XHandle, nsa_nodes.Handle), false)!;
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
			ret = CFArray.ArrayFromHandle<global::GameplayKit.GKPolygonObstacle>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, selObstaclesFromNodePhysicsBodies_XHandle, nsa_nodes.Handle), false)!;
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
			ret = CFArray.ArrayFromHandle<global::GameplayKit.GKPolygonObstacle>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_float (class_ptr, selObstaclesFromSpriteTextures_Accuracy_XHandle, nsa_sprites.Handle, accuracy), false)!;
			return ret;
		}
		[Export ("inParentHierarchy:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool InParentHierarchy (SKNode node)
		{
			var node__handle__ = node!.GetNonNullHandle (nameof (node));
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (this.Handle, selInParentHierarchy_XHandle, node__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle (&__objc_super__, selInParentHierarchy_XHandle, node__handle__);
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
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_IntPtr (this.Handle, selInsertChild_AtIndex_XHandle, node__handle__, index);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_IntPtr (&__objc_super__, selInsertChild_AtIndex_XHandle, node__handle__, index);
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
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (this.Handle, selIntersectsNode_XHandle, node__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle (&__objc_super__, selIntersectsNode_XHandle, node__handle__);
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
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (this.Handle, selIsEqualToNode_XHandle, node__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle (&__objc_super__, selIsEqualToNode_XHandle, node__handle__);
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
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selMoveToParent_XHandle, parent__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selMoveToParent_XHandle, parent__handle__);
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
			ret = CFArray.ArrayFromHandle<global::GameplayKit.GKPolygonObstacle>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, selObstaclesFromNodeBounds_XHandle, nsa_nodes.Handle), false)!;
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
			ret = CFArray.ArrayFromHandle<global::GameplayKit.GKPolygonObstacle>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, selObstaclesFromNodePhysicsBodies_XHandle, nsa_nodes.Handle), false)!;
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
			ret = CFArray.ArrayFromHandle<global::GameplayKit.GKPolygonObstacle>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_float (class_ptr, selObstaclesFromSpriteTextures_Accuracy_XHandle, nsa_sprites.Handle, accuracy), false)!;
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
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selRemoveActionForKey_XHandle, nskey);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selRemoveActionForKey_XHandle, nskey);
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
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selRemoveAllActionsXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selRemoveAllActionsXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("removeAllChildren")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemoveAllChildren ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selRemoveAllChildrenXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selRemoveAllChildrenXHandle);
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
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selRemoveChildrenInArray_XHandle, nsa_nodes.Handle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selRemoveChildrenInArray_XHandle, nsa_nodes.Handle);
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
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selRemoveFromParentXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selRemoveFromParentXHandle);
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
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selRunAction_XHandle, action__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selRunAction_XHandle, action__handle__);
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
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selRunAction_Completion_XHandle, action__handle__, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selRunAction_Completion_XHandle, action__handle__, (IntPtr) block_ptr_completionHandler);
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
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selRunAction_WithKey_XHandle, action__handle__, nskey);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selRunAction_WithKey_XHandle, action__handle__, nskey);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (action);
			CFString.ReleaseNative (nskey);
		}
		/// <param name="scale">To be added.</param><summary>Sets the X- and Y-scales to <paramref name="scale" />.</summary><remarks>To be added.</remarks>
		[Export ("setScale:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetScale (nfloat scale)
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_nfloat (this.Handle, selSetScale_XHandle, scale);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_nfloat (&__objc_super__, selSetScale_XHandle, scale);
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
					ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend (this.Handle, selAlphaXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSendSuper (&__objc_super__, selAlphaXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setAlpha:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_nfloat (this.Handle, selSetAlpha_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_nfloat (&__objc_super__, selSetAlpha_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual SKNode[] Children {
			[Export ("children")]
			get {
				SKNode[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<SKNode>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selChildrenXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<SKNode>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selChildrenXHandle), false)!;
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
					ret = CFArray.ArrayFromHandle<SKConstraint>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selConstraintsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<SKConstraint>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selConstraintsXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setConstraints:", ArgumentSemantic.Copy)]
			set {
				using var nsa_value = value is null ? null : NSArray.FromNSObjects (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetConstraints_XHandle, nsa_value.GetHandle ());
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetConstraints_XHandle, nsa_value.GetHandle ());
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGRect Frame {
			[Export ("frame")]
			get {
				CGRect ret;
				if (IsDirectBinding) {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend (this.Handle, selFrameXHandle);
					} else {
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret (this.Handle, selFrameXHandle);
					}
				} else {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper (&__objc_super__, selFrameXHandle);
							GC.KeepAlive (this);
						}
					} else {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper_stret (&__objc_super__, selFrameXHandle);
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
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selHasActionsXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selHasActionsXHandle);
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
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsHiddenXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsHiddenXHandle);
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
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string? Name {
			[Export ("name", ArgumentSemantic.Copy)]
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
			[Export ("setName:", ArgumentSemantic.Copy)]
			set {
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
		public virtual SKNode? Parent {
			[Export ("parent")]
			get {
				SKNode? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<SKNode> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selParentXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<SKNode> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selParentXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
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
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsPausedXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsPausedXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setPaused:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetPaused_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetPaused_XHandle, value ? (byte) 1 : (byte) 0);
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
					ret =  Runtime.GetNSObject<SKPhysicsBody> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selPhysicsBodyXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<SKPhysicsBody> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selPhysicsBodyXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setPhysicsBody:", ArgumentSemantic.Retain)]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetPhysicsBody_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetPhysicsBody_XHandle, value__handle__);
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
					ret = global::ObjCRuntime.Messaging.CGPoint_objc_msgSend (this.Handle, selPositionXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGPoint_objc_msgSendSuper (&__objc_super__, selPositionXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setPosition:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_CGPoint (this.Handle, selSetPosition_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_CGPoint (&__objc_super__, selSetPosition_XHandle, value);
						GC.KeepAlive (this);
					}
				}
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
					ret =  Runtime.GetNSObject<SKReachConstraints> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selReachConstraintsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<SKReachConstraints> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selReachConstraintsXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setReachConstraints:", ArgumentSemantic.Copy)]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetReachConstraints_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetReachConstraints_XHandle, value__handle__);
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
					ret =  Runtime.GetNSObject<SKScene> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selSceneXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<SKScene> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selSceneXHandle), false)!;
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
					ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend (this.Handle, selSpeedXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSendSuper (&__objc_super__, selSpeedXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setSpeed:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_nfloat (this.Handle, selSetSpeed_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_nfloat (&__objc_super__, selSetSpeed_XHandle, value);
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
					ret =  Runtime.GetNSObject<NSMutableDictionary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selUserDataXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSMutableDictionary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selUserDataXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setUserData:", ArgumentSemantic.Retain)]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetUserData_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetUserData_XHandle, value__handle__);
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
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsUserInteractionEnabledXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsUserInteractionEnabledXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setUserInteractionEnabled:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetUserInteractionEnabled_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetUserInteractionEnabled_XHandle, value ? (byte) 1 : (byte) 0);
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
					ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend (this.Handle, selXScaleXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSendSuper (&__objc_super__, selXScaleXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setXScale:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_nfloat (this.Handle, selSetXScale_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_nfloat (&__objc_super__, selSetXScale_XHandle, value);
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
					ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend (this.Handle, selYScaleXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSendSuper (&__objc_super__, selYScaleXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setYScale:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_nfloat (this.Handle, selSetYScale_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_nfloat (&__objc_super__, selSetYScale_XHandle, value);
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
					ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend (this.Handle, selZPositionXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSendSuper (&__objc_super__, selZPositionXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setZPosition:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_nfloat (this.Handle, selSetZPosition_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_nfloat (&__objc_super__, selSetZPosition_XHandle, value);
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
					ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend (this.Handle, selZRotationXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSendSuper (&__objc_super__, selZRotationXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setZRotation:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_nfloat (this.Handle, selSetZRotation_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_nfloat (&__objc_super__, selSetZRotation_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
	} /* class SKNode */
}
