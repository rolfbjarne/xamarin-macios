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
	/// <summary>An object that reacts to the physics simulation of the <see cref="T:SpriteKit.SKScene" />'s <see cref="P:SpriteKit.SKScene.PhysicsWorld" />.</summary><remarks><para>The visual appearance of a <see cref="T:SpriteKit.SKScene" /> is determined by its <see cref="T:SpriteKit.SKNode" />s. The physics simulation of a <see cref="T:SpriteKit.SKScene" /> is determined by the <see cref="T:SpriteKit.SKPhysicsWorld" /> object of the <see cref="T:SpriteKit.SKScene" />'s <see cref="P:SpriteKit.SKScene.PhysicsWorld" /> property. The physics of that word are applied to those <see cref="T:SpriteKit.SKNode" />s that have a non-null <see cref="P:SpriteKit.SKNode.PhysicsBody" />.</para><para>The following example demonstrates a simple dynamic system:</para><example><code lang="csharp lang-csharp"><![CDATA[
	/// var blockSize = new CGSize(20, 20);
	/// var node1 = new SKSpriteNode(UIColor.Red, blockSize) {
	/// 	Position = new CGPoint(100, 100),
	/// 	Name = "Red",
	/// 	PhysicsBody = SKPhysicsBody.BodyWithRectangleOfSize(blockSize),
	/// };
	/// var node2 = new SKSpriteNode(UIColor.Green, blockSize) {
	/// 	Position = new CGPoint(150, 100),
	/// 	Name = "Green",
	/// 	PhysicsBody = SKPhysicsBody.BodyWithRectangleOfSize(blockSize)
	/// };
	/// 
	/// //Pin node1 in position and connect node2 to it with a spring
	/// node1.PhysicsBody.Dynamic = false;
	/// var joint = SKPhysicsJointSpring.Create(node1.PhysicsBody, node2.PhysicsBody, node1.Position, node2.Position);
	/// 
	/// //Add nodes to scene
	/// scene.AddChild(node1);
	/// scene.AddChild(node2);
	/// 
	/// //Add the joint to the physics world
	/// scene.PhysicsWorld.AddJoint(joint);
	/// ]]></code></example><para>Application developers must add the <see cref="T:SpriteKit.SKNode" />s to the scene-graph prior to setting <see cref="T:SpriteKit.SKPhysicsJoint" />s or Sprite Kit may segfault.</para></remarks><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/SpriteKit/Reference/SKPhysicsBody_Ref/index.html">Apple documentation for <c>SKPhysicsBody</c></related>
	[Register("SKPhysicsBody", true)]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe partial class SKPhysicsBody : NSObject, INSCoding, INSCopying, INSSecureCoding {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAffectedByGravityX = "affectedByGravity";
		static readonly NativeHandle selAffectedByGravityXHandle = Selector.GetHandle ("affectedByGravity");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAllContactedBodiesX = "allContactedBodies";
		static readonly NativeHandle selAllContactedBodiesXHandle = Selector.GetHandle ("allContactedBodies");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAllowsRotationX = "allowsRotation";
		static readonly NativeHandle selAllowsRotationXHandle = Selector.GetHandle ("allowsRotation");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAngularDampingX = "angularDamping";
		static readonly NativeHandle selAngularDampingXHandle = Selector.GetHandle ("angularDamping");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAngularVelocityX = "angularVelocity";
		static readonly NativeHandle selAngularVelocityXHandle = Selector.GetHandle ("angularVelocity");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selApplyAngularImpulse_X = "applyAngularImpulse:";
		static readonly NativeHandle selApplyAngularImpulse_XHandle = Selector.GetHandle ("applyAngularImpulse:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selApplyForce_X = "applyForce:";
		static readonly NativeHandle selApplyForce_XHandle = Selector.GetHandle ("applyForce:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selApplyForce_AtPoint_X = "applyForce:atPoint:";
		static readonly NativeHandle selApplyForce_AtPoint_XHandle = Selector.GetHandle ("applyForce:atPoint:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selApplyImpulse_X = "applyImpulse:";
		static readonly NativeHandle selApplyImpulse_XHandle = Selector.GetHandle ("applyImpulse:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selApplyImpulse_AtPoint_X = "applyImpulse:atPoint:";
		static readonly NativeHandle selApplyImpulse_AtPoint_XHandle = Selector.GetHandle ("applyImpulse:atPoint:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selApplyTorque_X = "applyTorque:";
		static readonly NativeHandle selApplyTorque_XHandle = Selector.GetHandle ("applyTorque:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAreaX = "area";
		static readonly NativeHandle selAreaXHandle = Selector.GetHandle ("area");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selBodyWithBodies_X = "bodyWithBodies:";
		static readonly NativeHandle selBodyWithBodies_XHandle = Selector.GetHandle ("bodyWithBodies:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selBodyWithCircleOfRadius_X = "bodyWithCircleOfRadius:";
		static readonly NativeHandle selBodyWithCircleOfRadius_XHandle = Selector.GetHandle ("bodyWithCircleOfRadius:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selBodyWithCircleOfRadius_Center_X = "bodyWithCircleOfRadius:center:";
		static readonly NativeHandle selBodyWithCircleOfRadius_Center_XHandle = Selector.GetHandle ("bodyWithCircleOfRadius:center:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selBodyWithEdgeChainFromPath_X = "bodyWithEdgeChainFromPath:";
		static readonly NativeHandle selBodyWithEdgeChainFromPath_XHandle = Selector.GetHandle ("bodyWithEdgeChainFromPath:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selBodyWithEdgeFromPoint_ToPoint_X = "bodyWithEdgeFromPoint:toPoint:";
		static readonly NativeHandle selBodyWithEdgeFromPoint_ToPoint_XHandle = Selector.GetHandle ("bodyWithEdgeFromPoint:toPoint:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selBodyWithEdgeLoopFromPath_X = "bodyWithEdgeLoopFromPath:";
		static readonly NativeHandle selBodyWithEdgeLoopFromPath_XHandle = Selector.GetHandle ("bodyWithEdgeLoopFromPath:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selBodyWithEdgeLoopFromRect_X = "bodyWithEdgeLoopFromRect:";
		static readonly NativeHandle selBodyWithEdgeLoopFromRect_XHandle = Selector.GetHandle ("bodyWithEdgeLoopFromRect:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selBodyWithPolygonFromPath_X = "bodyWithPolygonFromPath:";
		static readonly NativeHandle selBodyWithPolygonFromPath_XHandle = Selector.GetHandle ("bodyWithPolygonFromPath:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selBodyWithRectangleOfSize_X = "bodyWithRectangleOfSize:";
		static readonly NativeHandle selBodyWithRectangleOfSize_XHandle = Selector.GetHandle ("bodyWithRectangleOfSize:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selBodyWithRectangleOfSize_Center_X = "bodyWithRectangleOfSize:center:";
		static readonly NativeHandle selBodyWithRectangleOfSize_Center_XHandle = Selector.GetHandle ("bodyWithRectangleOfSize:center:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selBodyWithTexture_AlphaThreshold_Size_X = "bodyWithTexture:alphaThreshold:size:";
		static readonly NativeHandle selBodyWithTexture_AlphaThreshold_Size_XHandle = Selector.GetHandle ("bodyWithTexture:alphaThreshold:size:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selBodyWithTexture_Size_X = "bodyWithTexture:size:";
		static readonly NativeHandle selBodyWithTexture_Size_XHandle = Selector.GetHandle ("bodyWithTexture:size:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCategoryBitMaskX = "categoryBitMask";
		static readonly NativeHandle selCategoryBitMaskXHandle = Selector.GetHandle ("categoryBitMask");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selChargeX = "charge";
		static readonly NativeHandle selChargeXHandle = Selector.GetHandle ("charge");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCollisionBitMaskX = "collisionBitMask";
		static readonly NativeHandle selCollisionBitMaskXHandle = Selector.GetHandle ("collisionBitMask");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selContactTestBitMaskX = "contactTestBitMask";
		static readonly NativeHandle selContactTestBitMaskXHandle = Selector.GetHandle ("contactTestBitMask");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCopyWithZone_X = "copyWithZone:";
		static readonly NativeHandle selCopyWithZone_XHandle = Selector.GetHandle ("copyWithZone:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDensityX = "density";
		static readonly NativeHandle selDensityXHandle = Selector.GetHandle ("density");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selEncodeWithCoder_X = "encodeWithCoder:";
		static readonly NativeHandle selEncodeWithCoder_XHandle = Selector.GetHandle ("encodeWithCoder:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFieldBitMaskX = "fieldBitMask";
		static readonly NativeHandle selFieldBitMaskXHandle = Selector.GetHandle ("fieldBitMask");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFrictionX = "friction";
		static readonly NativeHandle selFrictionXHandle = Selector.GetHandle ("friction");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithCoder_X = "initWithCoder:";
		static readonly NativeHandle selInitWithCoder_XHandle = Selector.GetHandle ("initWithCoder:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsDynamicX = "isDynamic";
		static readonly NativeHandle selIsDynamicXHandle = Selector.GetHandle ("isDynamic");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsRestingX = "isResting";
		static readonly NativeHandle selIsRestingXHandle = Selector.GetHandle ("isResting");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selJointsX = "joints";
		static readonly NativeHandle selJointsXHandle = Selector.GetHandle ("joints");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLinearDampingX = "linearDamping";
		static readonly NativeHandle selLinearDampingXHandle = Selector.GetHandle ("linearDamping");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMassX = "mass";
		static readonly NativeHandle selMassXHandle = Selector.GetHandle ("mass");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selNodeX = "node";
		static readonly NativeHandle selNodeXHandle = Selector.GetHandle ("node");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPinnedX = "pinned";
		static readonly NativeHandle selPinnedXHandle = Selector.GetHandle ("pinned");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRestitutionX = "restitution";
		static readonly NativeHandle selRestitutionXHandle = Selector.GetHandle ("restitution");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAffectedByGravity_X = "setAffectedByGravity:";
		static readonly NativeHandle selSetAffectedByGravity_XHandle = Selector.GetHandle ("setAffectedByGravity:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAllowsRotation_X = "setAllowsRotation:";
		static readonly NativeHandle selSetAllowsRotation_XHandle = Selector.GetHandle ("setAllowsRotation:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAngularDamping_X = "setAngularDamping:";
		static readonly NativeHandle selSetAngularDamping_XHandle = Selector.GetHandle ("setAngularDamping:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAngularVelocity_X = "setAngularVelocity:";
		static readonly NativeHandle selSetAngularVelocity_XHandle = Selector.GetHandle ("setAngularVelocity:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetCategoryBitMask_X = "setCategoryBitMask:";
		static readonly NativeHandle selSetCategoryBitMask_XHandle = Selector.GetHandle ("setCategoryBitMask:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetCharge_X = "setCharge:";
		static readonly NativeHandle selSetCharge_XHandle = Selector.GetHandle ("setCharge:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetCollisionBitMask_X = "setCollisionBitMask:";
		static readonly NativeHandle selSetCollisionBitMask_XHandle = Selector.GetHandle ("setCollisionBitMask:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetContactTestBitMask_X = "setContactTestBitMask:";
		static readonly NativeHandle selSetContactTestBitMask_XHandle = Selector.GetHandle ("setContactTestBitMask:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetDensity_X = "setDensity:";
		static readonly NativeHandle selSetDensity_XHandle = Selector.GetHandle ("setDensity:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetDynamic_X = "setDynamic:";
		static readonly NativeHandle selSetDynamic_XHandle = Selector.GetHandle ("setDynamic:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetFieldBitMask_X = "setFieldBitMask:";
		static readonly NativeHandle selSetFieldBitMask_XHandle = Selector.GetHandle ("setFieldBitMask:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetFriction_X = "setFriction:";
		static readonly NativeHandle selSetFriction_XHandle = Selector.GetHandle ("setFriction:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetLinearDamping_X = "setLinearDamping:";
		static readonly NativeHandle selSetLinearDamping_XHandle = Selector.GetHandle ("setLinearDamping:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetMass_X = "setMass:";
		static readonly NativeHandle selSetMass_XHandle = Selector.GetHandle ("setMass:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetPinned_X = "setPinned:";
		static readonly NativeHandle selSetPinned_XHandle = Selector.GetHandle ("setPinned:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetResting_X = "setResting:";
		static readonly NativeHandle selSetResting_XHandle = Selector.GetHandle ("setResting:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetRestitution_X = "setRestitution:";
		static readonly NativeHandle selSetRestitution_XHandle = Selector.GetHandle ("setRestitution:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetUsesPreciseCollisionDetection_X = "setUsesPreciseCollisionDetection:";
		static readonly NativeHandle selSetUsesPreciseCollisionDetection_XHandle = Selector.GetHandle ("setUsesPreciseCollisionDetection:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetVelocity_X = "setVelocity:";
		static readonly NativeHandle selSetVelocity_XHandle = Selector.GetHandle ("setVelocity:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selUsesPreciseCollisionDetectionX = "usesPreciseCollisionDetection";
		static readonly NativeHandle selUsesPreciseCollisionDetectionXHandle = Selector.GetHandle ("usesPreciseCollisionDetection");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selVelocityX = "velocity";
		static readonly NativeHandle selVelocityXHandle = Selector.GetHandle ("velocity");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("SKPhysicsBody");
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
		public SKPhysicsBody (NSCoder coder) : base (NSObjectFlag.Empty)
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
		protected SKPhysicsBody (NSObjectFlag t) : base (t)
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
		protected internal SKPhysicsBody (NativeHandle handle) : base (handle)
		{
		}

		/// <param name="impulse">To be added.</param><summary>Applies the specified angular impulse, in Newton-seconds, to the physics body.</summary><remarks>To be added.</remarks>
		[Export ("applyAngularImpulse:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ApplyAngularImpulse (nfloat impulse)
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_nfloat (this.Handle, selApplyAngularImpulse_XHandle, impulse);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_nfloat (&__objc_super__, selApplyAngularImpulse_XHandle, impulse);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("applyForce:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ApplyForce (CGVector force)
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_CGVector (this.Handle, selApplyForce_XHandle, force);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_CGVector (&__objc_super__, selApplyForce_XHandle, force);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("applyForce:atPoint:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ApplyForce (CGVector force, CGPoint point)
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_CGVector_CGPoint (this.Handle, selApplyForce_AtPoint_XHandle, force, point);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_CGVector_CGPoint (&__objc_super__, selApplyForce_AtPoint_XHandle, force, point);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("applyImpulse:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ApplyImpulse (CGVector impulse)
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_CGVector (this.Handle, selApplyImpulse_XHandle, impulse);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_CGVector (&__objc_super__, selApplyImpulse_XHandle, impulse);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("applyImpulse:atPoint:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ApplyImpulse (CGVector impulse, CGPoint point)
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_CGVector_CGPoint (this.Handle, selApplyImpulse_AtPoint_XHandle, impulse, point);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_CGVector_CGPoint (&__objc_super__, selApplyImpulse_AtPoint_XHandle, impulse, point);
					GC.KeepAlive (this);
				}
			}
		}
		/// <param name="torque">To be added.</param><summary>Applies a torque, in Newton-meters, to the physics body for one time step.</summary><remarks>To be added.</remarks>
		[Export ("applyTorque:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ApplyTorque (nfloat torque)
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_nfloat (this.Handle, selApplyTorque_XHandle, torque);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_nfloat (&__objc_super__, selApplyTorque_XHandle, torque);
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
		[Export ("bodyWithTexture:size:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SKPhysicsBody Create (SKTexture texture, CGSize size)
		{
			var texture__handle__ = texture!.GetNonNullHandle (nameof (texture));
			SKPhysicsBody? ret;
			ret =  Runtime.GetNSObject<SKPhysicsBody> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_CGSize (class_ptr, selBodyWithTexture_Size_XHandle, texture__handle__, size), false)!;
			GC.KeepAlive (texture);
			return ret!;
		}
		[Export ("bodyWithTexture:alphaThreshold:size:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SKPhysicsBody Create (SKTexture texture, float alphaThreshold, CGSize size)
		{
			var texture__handle__ = texture!.GetNonNullHandle (nameof (texture));
			SKPhysicsBody? ret;
			ret =  Runtime.GetNSObject<SKPhysicsBody> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_float_CGSize (class_ptr, selBodyWithTexture_AlphaThreshold_Size_XHandle, texture__handle__, alphaThreshold, size), false)!;
			GC.KeepAlive (texture);
			return ret!;
		}
		[Export ("bodyWithPolygonFromPath:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SKPhysicsBody CreateBodyFromPath (CGPath path)
		{
			var path__handle__ = path!.GetNonNullHandle (nameof (path));
			SKPhysicsBody? ret;
			ret =  Runtime.GetNSObject<SKPhysicsBody> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, selBodyWithPolygonFromPath_XHandle, path.Handle), false)!;
			GC.KeepAlive (path);
			return ret!;
		}
		/// <param name="radius">To be added.</param><summary>Creates a new circular physics body with the specified radius.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("bodyWithCircleOfRadius:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SKPhysicsBody CreateCircularBody (nfloat radius)
		{
			SKPhysicsBody ret;
			ret =  Runtime.GetNSObject<SKPhysicsBody> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_nfloat (class_ptr, selBodyWithCircleOfRadius_XHandle, radius), false)!;
			return ret;
		}
		/// <param name="radius">To be added.</param><param name="center">To be added.</param><summary>Creates a new circular physics body with the specified radius and center.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("bodyWithCircleOfRadius:center:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SKPhysicsBody CreateCircularBody (nfloat radius, CGPoint center)
		{
			SKPhysicsBody ret;
			ret =  Runtime.GetNSObject<SKPhysicsBody> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_nfloat_CGPoint (class_ptr, selBodyWithCircleOfRadius_Center_XHandle, radius, center), false)!;
			return ret;
		}
		[Export ("bodyWithEdgeFromPoint:toPoint:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SKPhysicsBody CreateEdge (CGPoint fromPoint, CGPoint toPoint)
		{
			SKPhysicsBody ret;
			ret =  Runtime.GetNSObject<SKPhysicsBody> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_CGPoint_CGPoint (class_ptr, selBodyWithEdgeFromPoint_ToPoint_XHandle, fromPoint, toPoint), false)!;
			return ret;
		}
		[Export ("bodyWithEdgeChainFromPath:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SKPhysicsBody CreateEdgeChain (CGPath path)
		{
			var path__handle__ = path!.GetNonNullHandle (nameof (path));
			SKPhysicsBody? ret;
			ret =  Runtime.GetNSObject<SKPhysicsBody> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, selBodyWithEdgeChainFromPath_XHandle, path.Handle), false)!;
			GC.KeepAlive (path);
			return ret!;
		}
		[Export ("bodyWithEdgeLoopFromPath:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SKPhysicsBody CreateEdgeLoop (CGPath path)
		{
			var path__handle__ = path!.GetNonNullHandle (nameof (path));
			SKPhysicsBody? ret;
			ret =  Runtime.GetNSObject<SKPhysicsBody> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, selBodyWithEdgeLoopFromPath_XHandle, path.Handle), false)!;
			GC.KeepAlive (path);
			return ret!;
		}
		[Export ("bodyWithEdgeLoopFromRect:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SKPhysicsBody CreateEdgeLoop (CGRect rect)
		{
			SKPhysicsBody ret;
			ret =  Runtime.GetNSObject<SKPhysicsBody> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_CGRect (class_ptr, selBodyWithEdgeLoopFromRect_XHandle, rect), false)!;
			return ret;
		}
		[Export ("bodyWithRectangleOfSize:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SKPhysicsBody CreateRectangularBody (CGSize size)
		{
			SKPhysicsBody ret;
			ret =  Runtime.GetNSObject<SKPhysicsBody> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_CGSize (class_ptr, selBodyWithRectangleOfSize_XHandle, size), false)!;
			return ret;
		}
		[Export ("bodyWithRectangleOfSize:center:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SKPhysicsBody CreateRectangularBody (CGSize size, CGPoint center)
		{
			SKPhysicsBody ret;
			ret =  Runtime.GetNSObject<SKPhysicsBody> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_CGSize_CGPoint (class_ptr, selBodyWithRectangleOfSize_Center_XHandle, size, center), false)!;
			return ret;
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
		[Export ("bodyWithBodies:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SKPhysicsBody FromBodies (SKPhysicsBody[] bodies)
		{
			if (bodies is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (bodies));
			using var nsa_bodies = NSArray.FromNSObjects (bodies);
			SKPhysicsBody ret;
			ret =  Runtime.GetNSObject<SKPhysicsBody> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, selBodyWithBodies_XHandle, nsa_bodies.Handle), false)!;
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool AffectedByGravity {
			[Export ("affectedByGravity")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selAffectedByGravityXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selAffectedByGravityXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setAffectedByGravity:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetAffectedByGravity_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetAffectedByGravity_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual SKPhysicsBody[] AllContactedBodies {
			[Export ("allContactedBodies")]
			get {
				SKPhysicsBody[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<SKPhysicsBody>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selAllContactedBodiesXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<SKPhysicsBody>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selAllContactedBodiesXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool AllowsRotation {
			[Export ("allowsRotation")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selAllowsRotationXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selAllowsRotationXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setAllowsRotation:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetAllowsRotation_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetAllowsRotation_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nfloat AngularDamping {
			[Export ("angularDamping", ArgumentSemantic.Assign)]
			get {
				nfloat ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend (this.Handle, selAngularDampingXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSendSuper (&__objc_super__, selAngularDampingXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setAngularDamping:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_nfloat (this.Handle, selSetAngularDamping_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_nfloat (&__objc_super__, selSetAngularDamping_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nfloat AngularVelocity {
			[Export ("angularVelocity")]
			get {
				nfloat ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend (this.Handle, selAngularVelocityXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSendSuper (&__objc_super__, selAngularVelocityXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setAngularVelocity:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_nfloat (this.Handle, selSetAngularVelocity_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_nfloat (&__objc_super__, selSetAngularVelocity_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nfloat Area {
			[Export ("area")]
			get {
				nfloat ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend (this.Handle, selAreaXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSendSuper (&__objc_super__, selAreaXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual uint CategoryBitMask {
			[Export ("categoryBitMask")]
			get {
				uint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.UInt32_objc_msgSend (this.Handle, selCategoryBitMaskXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.UInt32_objc_msgSendSuper (&__objc_super__, selCategoryBitMaskXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setCategoryBitMask:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_UInt32 (this.Handle, selSetCategoryBitMask_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UInt32 (&__objc_super__, selSetCategoryBitMask_XHandle, value);
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
		public virtual nfloat Charge {
			[Export ("charge")]
			get {
				nfloat ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend (this.Handle, selChargeXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSendSuper (&__objc_super__, selChargeXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setCharge:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_nfloat (this.Handle, selSetCharge_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_nfloat (&__objc_super__, selSetCharge_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual uint CollisionBitMask {
			[Export ("collisionBitMask")]
			get {
				uint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.UInt32_objc_msgSend (this.Handle, selCollisionBitMaskXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.UInt32_objc_msgSendSuper (&__objc_super__, selCollisionBitMaskXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setCollisionBitMask:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_UInt32 (this.Handle, selSetCollisionBitMask_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UInt32 (&__objc_super__, selSetCollisionBitMask_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual uint ContactTestBitMask {
			[Export ("contactTestBitMask")]
			get {
				uint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.UInt32_objc_msgSend (this.Handle, selContactTestBitMaskXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.UInt32_objc_msgSendSuper (&__objc_super__, selContactTestBitMaskXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setContactTestBitMask:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_UInt32 (this.Handle, selSetContactTestBitMask_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UInt32 (&__objc_super__, selSetContactTestBitMask_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nfloat Density {
			[Export ("density")]
			get {
				nfloat ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend (this.Handle, selDensityXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSendSuper (&__objc_super__, selDensityXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setDensity:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_nfloat (this.Handle, selSetDensity_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_nfloat (&__objc_super__, selSetDensity_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>Gets or sets a value the tells whether the physics body is affected by forces and impulses in the simulation.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool Dynamic {
			[Export ("isDynamic")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsDynamicXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsDynamicXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setDynamic:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetDynamic_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetDynamic_XHandle, value ? (byte) 1 : (byte) 0);
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
		public virtual uint FieldBitMask {
			[Export ("fieldBitMask")]
			get {
				uint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.UInt32_objc_msgSend (this.Handle, selFieldBitMaskXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.UInt32_objc_msgSendSuper (&__objc_super__, selFieldBitMaskXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setFieldBitMask:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_UInt32 (this.Handle, selSetFieldBitMask_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UInt32 (&__objc_super__, selSetFieldBitMask_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nfloat Friction {
			[Export ("friction")]
			get {
				nfloat ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend (this.Handle, selFrictionXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSendSuper (&__objc_super__, selFrictionXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setFriction:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_nfloat (this.Handle, selSetFriction_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_nfloat (&__objc_super__, selSetFriction_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual SKPhysicsJoint[] Joints {
			[Export ("joints")]
			get {
				SKPhysicsJoint[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<SKPhysicsJoint>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selJointsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<SKPhysicsJoint>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selJointsXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nfloat LinearDamping {
			[Export ("linearDamping", ArgumentSemantic.Assign)]
			get {
				nfloat ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend (this.Handle, selLinearDampingXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSendSuper (&__objc_super__, selLinearDampingXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setLinearDamping:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_nfloat (this.Handle, selSetLinearDamping_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_nfloat (&__objc_super__, selSetLinearDamping_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nfloat Mass {
			[Export ("mass")]
			get {
				nfloat ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend (this.Handle, selMassXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSendSuper (&__objc_super__, selMassXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setMass:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_nfloat (this.Handle, selSetMass_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_nfloat (&__objc_super__, selSetMass_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		object? __mt_Node_var;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual SKNode? Node {
			[Export ("node", ArgumentSemantic.Weak)]
			get {
				SKNode? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<SKNode> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selNodeXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<SKNode> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selNodeXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				MarkDirty ();
				__mt_Node_var = ret;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual bool Pinned {
			[Export ("pinned")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selPinnedXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selPinnedXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setPinned:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetPinned_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetPinned_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>Gets or sets a value that tells whether the body is resting on another body in the simulation, and thus does not participate in the simulation.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool Resting {
			[Export ("isResting")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsRestingXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsRestingXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setResting:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetResting_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetResting_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nfloat Restitution {
			[Export ("restitution")]
			get {
				nfloat ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend (this.Handle, selRestitutionXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSendSuper (&__objc_super__, selRestitutionXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setRestitution:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_nfloat (this.Handle, selSetRestitution_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_nfloat (&__objc_super__, selSetRestitution_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool UsesPreciseCollisionDetection {
			[Export ("usesPreciseCollisionDetection")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selUsesPreciseCollisionDetectionXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selUsesPreciseCollisionDetectionXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setUsesPreciseCollisionDetection:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetUsesPreciseCollisionDetection_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetUsesPreciseCollisionDetection_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGVector Velocity {
			[Export ("velocity")]
			get {
				CGVector ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.CGVector_objc_msgSend (this.Handle, selVelocityXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGVector_objc_msgSendSuper (&__objc_super__, selVelocityXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setVelocity:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_CGVector (this.Handle, selSetVelocity_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_CGVector (&__objc_super__, selSetVelocity_XHandle, value);
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
				__mt_Node_var = null;
			}
		}
	} /* class SKPhysicsBody */
}
