//
// spritekit.cs: binding for iOS (7+) and Mac (10.9+) SpriteKit framework
//
// Authors:
//   Aaron Bockover (abock@xamarin.com)
//
// Copyright 2013-2015 Xamarin Inc

using System.ComponentModel;

using CoreImage;
using GameplayKit;

using AVFoundation;
using CoreFoundation;
using CoreGraphics;
using CoreVideo;
using SceneKit;
using Metal;

using MatrixFloat2x2 = global::CoreGraphics.NMatrix2;
using MatrixFloat3x3 = global::CoreGraphics.NMatrix3;
using MatrixFloat4x4 = global::CoreGraphics.NMatrix4;
using Vector2 = global::System.Numerics.Vector2;
using Vector3 = global::System.Numerics.Vector3;
using Vector4 = global::System.Numerics.Vector4;
using VectorFloat3 = global::CoreGraphics.NVector3;
using Quaternion = global::System.Numerics.Quaternion;

#if MONOMAC
using AppKit;
using UIColor = global::AppKit.NSColor;
using UIImage = global::AppKit.NSImage;
using UIView = global::AppKit.NSView;
using UITouch = Foundation.NSObject;
#else
using UIKit;
using NSLineBreakMode = global::UIKit.UILineBreakMode;
using NSEvent = System.Object;
#endif

namespace SpriteKit {
	/// <summary>The delegate that acts as the enumeration handler for <see cref="SpriteKit.SKNode.EnumerateChildNodes(System.String,SpriteKit.SKNodeChildEnumeratorHandler)" />.</summary>
	delegate void SKNodeChildEnumeratorHandler (SKNode node, out bool stop);
#if !XAMCORE_5_0
	/// <summary>A method that maps <paramref name="time" />, a value between 0 and 1, to a return value between 0 snd 1.</summary>
	///     <remarks>Application developers should assign this delegate to a method that returns 0 for a <paramref name="time" /> value of 0, and 1 for a <paramref name="time" /> value of 1.</remarks>
	delegate float SKActionTimingFunction2 (float /* float, not CGFloat */ time);
#endif
	/// <summary>A method that maps <paramref name="time" />, a value between 0 and 1, to a return value between 0 snd 1.</summary>
	/// <remarks>Application developers should assign this delegate to a method that returns 0 for a <paramref name="time" /> value of 0, and 1 for a <paramref name="time" /> value of 1.</remarks>
	delegate float SKActionTimingFunction (float /* float, not CGFloat */ time);

	/// <summary>Renders a Scene Kit image as a textured 2D image. Used to incorporate Scene Kit content into a Sprite Kit app.</summary>
	///     
	///     <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/SpriteKit/Reference/SK3DNode/index.html">Apple documentation for <c>SK3DNode</c></related>
	[MacCatalyst (13, 1)]
	[BaseType (typeof (SKNode))]
	interface SK3DNode {
		[DesignatedInitializer]
		[Export ("initWithViewportSize:")]
		NativeHandle Constructor (CGSize viewportSize);

		[Export ("viewportSize")]
		CGSize ViewportSize { get; set; }

		[NullAllowed] // by default this property is null
		[Export ("scnScene", ArgumentSemantic.Retain)]
		SCNScene ScnScene { get; set; }

		[Export ("sceneTime")]
		double SceneTime { get; set; }

		/// <summary>Gets or sets a value that controls whether the scene plays.</summary>
		[Export ("playing")]
		bool Playing { [Bind ("isPlaying")] get; set; }

		[Export ("loops")]
		bool Loops { get; set; }

		[NullAllowed] // by default this property is null
		[Export ("pointOfView", ArgumentSemantic.Retain)]
		SCNNode PointOfView { get; set; }

		[Export ("autoenablesDefaultLighting")]
		bool AutoenablesDefaultLighting { get; set; }

		[Static, Export ("nodeWithViewportSize:")]
		SK3DNode FromViewportSize (CGSize viewportSize);

		[Export ("hitTest:options:")]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		SCNHitTestResult [] HitTest (CGPoint thePoint, [NullAllowed] NSDictionary options);

		/// <param name="thePoint">The point to test for nodes.</param>
		/// <param name="options">Options for the hit test.</param>
		/// <summary>Returns nodes at the specified point.</summary>
		/// <returns>An array of nodes at the specified point.</returns>
		[Wrap ("HitTest (thePoint, options.GetDictionary ())")]
		SCNHitTestResult [] HitTest (CGPoint thePoint, SCNHitTestOptions options);

		[Export ("projectPoint:")]
		/* vector_float3 */
		[MarshalDirective (NativePrefix = "xamarin_simd__", Library = "__Internal")]
		Vector3 ProjectPoint (Vector3 point);

		[Export ("unprojectPoint:")]
		/* vector_float3 */
		[MarshalDirective (NativePrefix = "xamarin_simd__", Library = "__Internal")]
		Vector3 UnprojectPoint (Vector3 point);
	}


	/// <include file="../docs/api/SpriteKit/SKNode.xml" path="/Documentation/Docs[@DocId='T:SpriteKit.SKNode']/*" />
	[DisableDefaultCtor] // DesignatedInitializer below
	[MacCatalyst (13, 1)]
#if MONOMAC
	[BaseType (typeof (NSResponder))]
#else
	[BaseType (typeof (UIResponder))]
#endif
	partial interface SKNode : NSSecureCoding, NSCopying
#if IOS || TVOS
	, UIFocusItem, UIFocusItemContainer, UICoordinateSpace
#endif
	{
		[DesignatedInitializer]
		[Export ("init")]
		NativeHandle Constructor ();

		[Static, Export ("node")]
		SKNode Create ();

		[MacCatalyst (13, 1)]
		[Static]
		[Export ("nodeWithFileNamed:")]
		[return: NullAllowed]
		SKNode Create (string filename);

		[MacCatalyst (13, 1)]
		[Internal]
		[Static]
		[Export ("nodeWithFileNamed:securelyWithClasses:andError:")]
		[return: NullAllowed]
		SKNode Create (string filename, IntPtr classesPtr, out NSError error);

		[Export ("frame")]
#if !MONOMAC
		// For iOS+tvOS we also get this property from the UIFocusItem protocol, but we redefine it here to get the right availability attributes.
		new
#endif
		CGRect Frame { get; }

		[Export ("calculateAccumulatedFrame")]
		CGRect CalculateAccumulatedFrame ();

		[Export ("position")]
		CGPoint Position { get; set; }

		[Export ("zPosition")]
		nfloat ZPosition { get; set; }

		[Export ("zRotation")]
		nfloat ZRotation { get; set; }

		[Export ("xScale")]
		nfloat XScale { get; set; }

		[Export ("yScale")]
		nfloat YScale { get; set; }

		[Export ("speed")]
		nfloat Speed { get; set; }

		[Export ("alpha")]
		nfloat Alpha { get; set; }

		/// <summary>Gets or sets a value that causes this node and its descendants to be skipped when actions are processed for the scene. <see langword="true" /> causes them to be skipped.</summary>
		[Export ("paused")]
		bool Paused { [Bind ("isPaused")] get; set; }

		/// <summary>Gets a value that tells whether the node and its descendants are rendered to the screen.</summary>
		///         <remarks>
		///         </remarks>
		[Export ("hidden")]
		bool Hidden { [Bind ("isHidden")] get; set; }

		/// <summary>Gets or sets a value that controls whether the node responds to touch.</summary>
		[Export ("userInteractionEnabled")]
		bool UserInteractionEnabled { [Bind ("isUserInteractionEnabled")] get; set; }

		[NoMac]
		[MacCatalyst (13, 1)]
		[Export ("focusBehavior", ArgumentSemantic.Assign)]
		SKNodeFocusBehavior FocusBehavior { get; set; }

		[Export ("parent")]
		[NullAllowed]
		SKNode Parent { get; }

		[Export ("children")]
		SKNode [] Children { get; }

		[NullAllowed] // by default this property is null
		[Export ("name", ArgumentSemantic.Copy)]
		string Name { get; set; }

		[Export ("scene")]
		[NullAllowed]
		SKScene Scene { get; }

		[Export ("physicsBody", ArgumentSemantic.Retain), NullAllowed]
		SKPhysicsBody PhysicsBody { get; set; }

		[NullAllowed] // by default this property is null
		[Export ("userData", ArgumentSemantic.Retain)]
		NSMutableDictionary UserData { get; set; }

		/// <param name="scale">The scale factor to apply.</param>
		/// <summary>Sets the X- and Y-scales to <paramref name="scale" />.</summary>
		
		[Export ("setScale:")]
		void SetScale (nfloat scale);

		[Export ("addChild:")]
		[PostGet ("Children")]
		void AddChild (SKNode node);

		/// <param name="node">The child node to insert.</param>
		/// <param name="index">The index at which to insert the node.</param>
		/// <summary>Inserts <paramref name="node" /> at the position that is specified by <paramref name="index" /> into the list of this node's children.</summary>
		
		[Export ("insertChild:atIndex:")]
		[PostGet ("Children")]
		void InsertChild (SKNode node, nint index);

		[Export ("removeChildrenInArray:")]
		[PostGet ("Children")]
		void RemoveChildren (SKNode [] nodes);

		[Export ("removeAllChildren")]
		[PostGet ("Children")]
		void RemoveAllChildren ();

		[Export ("removeFromParent")]
		void RemoveFromParent ();

		[Export ("childNodeWithName:")]
		[return: NullAllowed]
		SKNode GetChildNode (string name);

		[Export ("enumerateChildNodesWithName:usingBlock:")]
		void EnumerateChildNodes (string name, SKNodeChildEnumeratorHandler enumerationHandler);

		[Export ("runAction:")]
		void RunAction (SKAction action);

		[Async (XmlDocs = """
			<param name="action">The action to add and run.</param>
			<summary>Asynchronously adds an action to the node that will be processed in the next animation loop.</summary>
			<returns>A task that represents the asynchronous RunAction operation</returns>
			<remarks>
			          <para copied="true">The RunActionAsync method is suitable to be used with C# async by returning control to the caller with a Task representing the operation.</para>
			          <para>This async method returns a Task representing the operation.</para>
			        </remarks>
			""")]
		[Export ("runAction:completion:")]
		void RunAction (SKAction action, Action completionHandler);

		[Export ("runAction:withKey:")]
		void RunAction (SKAction action, string key);

		[Export ("hasActions")]
		bool HasActions { get; }

		[Export ("actionForKey:")]
		[return: NullAllowed]
		SKAction GetActionForKey (string key);

		[Export ("removeActionForKey:")]
		void RemoveActionForKey (string key);

		[Export ("removeAllActions")]
		void RemoveAllActions ();

		[Export ("containsPoint:")]
		bool ContainsPoint (CGPoint point);

		[Export ("nodeAtPoint:")]
		SKNode GetNodeAtPoint (CGPoint point);

		[Export ("nodesAtPoint:")]
		SKNode [] GetNodesAtPoint (CGPoint point);

		[Export ("convertPoint:fromNode:")]
		CGPoint ConvertPointFromNode (CGPoint point, SKNode sourceNode);

		[Export ("convertPoint:toNode:")]
		CGPoint ConvertPointToNode (CGPoint point, SKNode sourceNode);

		[Export ("intersectsNode:")]
		bool IntersectsNode (SKNode node);

		[MacCatalyst (13, 1)]
		[Export ("isEqualToNode:")]
		bool IsEqual (SKNode node);

		[Export ("inParentHierarchy:")]
		bool InParentHierarchy (SKNode node);

		[MacCatalyst (13, 1)]
		[NullAllowed] // by default this property is null
		[Export ("reachConstraints", ArgumentSemantic.Copy)]
		SKReachConstraints ReachConstraints { get; set; }

		[MacCatalyst (13, 1)]
		[NullAllowed] // by default this property is null
		[Export ("constraints", ArgumentSemantic.Copy)]
		SKConstraint [] Constraints { get; set; }

		[MacCatalyst (13, 1)]
		[Export ("objectForKeyedSubscript:")]
		SKNode GetObjectsMatching (string nameExpression);

		[MacCatalyst (13, 1)]
		[Export ("moveToParent:")]
		void MoveToParent (SKNode parent);

		// Moved from SpriteKit to GameplayKit header in iOS 10 beta 1
		/// <param name="nodes">The nodes to use for generating the physics body.</param>
		///         <summary>Creates a new <see cref="GameplayKit.GKPolygonObstacle" /> for each <see cref="SpriteKit.SKNode" /> in <paramref name="nodes" />.</summary>
		/// <returns>A new physics body created from the specified nodes.</returns>
		[MacCatalyst (13, 1)]
		[Static]
		[Export ("obstaclesFromNodeBounds:")]
		GKPolygonObstacle [] ObstaclesFromNodeBounds (SKNode [] nodes);

		// Moved from SpriteKit to GameplayKit header in iOS 10 beta 1
		/// <param name="nodes">The nodes to use for generating the physics body.</param>
		///         <summary>Creates a new <see cref="GameplayKit.GKPolygonObstacle" /> for each <see cref="SpriteKit.SKNode.PhysicsBody" /> in the <see cref="SpriteKit.SKNode" /> object in <paramref name="nodes" /></summary>
		/// <returns>A new physics body created from the specified nodes.</returns>
		[MacCatalyst (13, 1)]
		[Static]
		[Export ("obstaclesFromNodePhysicsBodies:")]
		GKPolygonObstacle [] ObstaclesFromNodePhysicsBodies (SKNode [] nodes);

		// Moved from SpriteKit to GameplayKit header in iOS 10 beta 1
		/// <param name="sprites">The sprite textures to create the body from.</param>
		/// <param name="accuracy">The accuracy of the generated body (0.0 to 1.0).</param>
		///         <summary>Creates a new <see cref="GameplayKit.GKPolygonObstacle" /> by converting the <see cref="SpriteKit.SKSpriteNode.Texture" /> of each <see cref="SpriteKit.SKNode" /> object in <paramref name="sprites" />.</summary>
		/// <returns>A new physics body based on the sprite textures.</returns>
		[MacCatalyst (13, 1)]
		[Static]
		[Export ("obstaclesFromSpriteTextures:accuracy:")]
		GKPolygonObstacle [] ObstaclesFromSpriteTextures (SKNode [] sprites, float accuracy);

		// Extensions from GameplayKit, inlined to avoid ugly static extension syntax
		/// <param name="sprites">The sprite textures to create the body from.</param>
		/// <param name="accuracy">The accuracy of the generated body (0.0 to 1.0).</param>
		/// <summary>Creates a physics body from the alpha channel of the specified textures.</summary>
		/// <returns>A new physics body based on the sprite textures.</returns>
		[MacCatalyst (13, 1)]
		[Static]
		[Export ("obstaclesFromSpriteTextures:accuracy:")]
		GKPolygonObstacle [] GetObstaclesFromSpriteTextures (SKNode [] sprites, float accuracy);

		/// <param name="nodes">The nodes to create the body from.</param>
		/// <summary>Creates a physics body that is the union of the specified nodes.</summary>
		/// <returns>A new physics body that is the union of the bodies.</returns>
		[MacCatalyst (13, 1)]
		[Static]
		[Export ("obstaclesFromNodeBounds:")]
		GKPolygonObstacle [] GetObstaclesFromNodeBounds (SKNode [] nodes);

		/// <param name="nodes">The nodes to create the body from.</param>
		/// <summary>Creates a physics body that is the union of the specified nodes.</summary>
		/// <returns>A new physics body that is the union of the bodies.</returns>
		[MacCatalyst (13, 1)]
		[Static]
		[Export ("obstaclesFromNodePhysicsBodies:")]
		GKPolygonObstacle [] GetObstaclesFromNodePhysicsBodies (SKNode [] nodes);
	}

	[NoiOS]
	[NoTV]
	[NoMacCatalyst]
	[Category, BaseType (typeof (NSEvent))]
	partial interface SKNodeEvent_NSEvent {

		/// <param name="node">The node to join to this body.</param>
		/// <summary>Creates a joint between this body and the specified node.</summary>
		/// <returns>A new physics joint.</returns>
		
		[Export ("locationInNode:")]
		CGPoint LocationInNode (SKNode node);
	}

	/// <summary>Extension methods for <see cref="UIKit.UITouch" /> that aide with conversion to Sprite Kit coordinates.</summary>
	[NoMac]
	[MacCatalyst (13, 1)]
	[Category, BaseType (typeof (UITouch))]
	partial interface SKNodeTouches_UITouch {

		/// <param name="node">The other node to anchor with.</param>
		/// <summary>The current position of <c>this</c> in the coordinate system of <paramref name="node" />.</summary>
		/// <returns>A new physics joint.</returns>
		
		[Export ("locationInNode:")]
		CGPoint LocationInNode (SKNode node);

		/// <param name="node">The other node to connect with a spring.</param>
		/// <summary>The previous location of <c>this</c> in the coordinate system of <paramref name="node" />.</summary>
		/// <returns>A new physics joint.</returns>
		
		[Export ("previousLocationInNode:")]
		CGPoint PreviousLocationInNode (SKNode node);
	}

	/// <summary>An <see cref="SpriteKit.SKNode" /> that applies a Core Graphics <see cref="CoreImage.CIFilter" /> to its output.</summary>
	///     <remarks>
	///       <para>Application developers should ensure that <see cref="SpriteKit.SKEffectNode.ShouldEnableEffects" /> is <see langword="true" />.</para>
	///       <para>Note that <see cref="SpriteKit.SKScene" /> is a subclass of <see cref="SpriteKit.SKEffectNode" />.</para>
	///     </remarks>
	///     <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/SpriteKit/Reference/SKEffectNode_Ref/index.html">Apple documentation for <c>SKEffectNode</c></related>
	[MacCatalyst (13, 1)]
	[BaseType (typeof (SKNode))]
	partial interface SKEffectNode : SKWarpable {

		[MacCatalyst (13, 1)]
		[NullAllowed] // by default this property is null
		[Export ("filter", ArgumentSemantic.Retain)]
		CIFilter Filter { get; set; }

		[Export ("shouldCenterFilter")]
		bool ShouldCenterFilter { get; set; }

		[Export ("shouldEnableEffects")]
		bool ShouldEnableEffects { get; set; }

		[Export ("shouldRasterize")]
		bool ShouldRasterize { get; set; }

		[Export ("blendMode")]
		SKBlendMode BlendMode { get; set; }

		[MacCatalyst (13, 1)]
		[NullAllowed] // by default this property is null
		[Export ("shader", ArgumentSemantic.Retain)]
		SKShader Shader { get; set; }

		[MacCatalyst (13, 1)]
		[Export ("attributeValues", ArgumentSemantic.Copy)]
		NSDictionary<NSString, SKAttributeValue> AttributeValues { get; set; }

		[MacCatalyst (13, 1)]
		[Export ("valueForAttributeNamed:")]
		[return: NullAllowed]
		SKAttributeValue GetValue (string key);

		[MacCatalyst (13, 1)]
		[Export ("setValue:forAttributeNamed:")]
		void SetValue (SKAttributeValue value, string key);
	}

	/// <summary>A method that derives a force by applying the physics of a field to a body that is within the field.</summary>
	delegate Vector3 SKFieldForceEvaluator (/* vector_float3 */ Vector4 position, /* vector_float3 */ Vector4 velocity, float /* float, not CGFloat */ mass, float /* float, not CGFloat */ charge, double time);

	/// <summary>Applies physics effects within APortion of a scene.</summary>
	///     
	///     <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/SpriteKit/Reference/SKFieldNode_Ref/index.html">Apple documentation for <c>SKFieldNode</c></related>
	[MacCatalyst (13, 1)]
	[BaseType (typeof (SKNode))]
	interface SKFieldNode {
		[Export ("region", ArgumentSemantic.Retain)]
		[NullAllowed]
		SKRegion Region { get; set; }

		[Export ("strength")]
		float Strength { get; set; } /* float, not CGFloat */

		[Export ("falloff")]
		float Falloff { get; set; } /* float, not CGFloat */

		[Export ("minimumRadius")]

		float MinimumRadius { get; set; } /* float, not CGFloat */

		/// <summary>Gets or sets a value that controls whether the field is active.</summary>
		[Export ("enabled")]
		bool Enabled { [Bind ("isEnabled")] get; set; }

		/// <summary>Gets or sets a value that controls whether the field should override all other fields whose regions intersect with its own region.</summary>
		[Export ("exclusive")]
		bool Exclusive { [Bind ("isExclusive")] get; set; }

		[Export ("categoryBitMask")]
		uint CategoryBitMask { get; set; } /* uint32_t */

		[Export ("direction")]
		/* This was typed as Vector4 since sizeof the native type (vector_float3) = 16 */
		Vector4 Direction {
			[MarshalDirective (NativePrefix = "xamarin_vector_float3__", Library = "__Internal")]
			get;
			[MarshalDirective (NativePrefix = "xamarin_vector_float3__", Library = "__Internal")]
			set;
		}

		[Export ("smoothness")]
		float Smoothness { get; set; } /* float, not CGFloat */

		[Export ("animationSpeed")]
		float AnimationSpeed { get; set; } /* float, not CGFloat */

		[Export ("texture", ArgumentSemantic.Retain)]
		[NullAllowed]
		SKTexture Texture { get; set; }

		[Static, Export ("dragField")]
		SKFieldNode CreateDragField ();

		[Static, Export ("vortexField")]
		SKFieldNode CreateVortexField ();

		[Static, Export ("radialGravityField")]
		SKFieldNode CreateRadialGravityField ();

		[Static, Export ("linearGravityFieldWithVector:")]
		[MarshalDirective (NativePrefix = "xamarin_simd__", Library = "__Internal")]
		SKFieldNode CreateLinearGravityField (/* vector_float3 */ Vector4 direction);

		[Static, Export ("velocityFieldWithVector:")]
		[MarshalDirective (NativePrefix = "xamarin_simd__", Library = "__Internal")]
		SKFieldNode CreateVelocityField (/* vector_float3 */ Vector4 direction);

		[Static, Export ("velocityFieldWithTexture:")]
		SKFieldNode CreateVelocityField (SKTexture velocityTexture);

		/// <param name="smoothness">The smoothness factor (0.0 to 1.0).</param>
		/// <param name="speed">The animation speed.</param>
		/// <summary>Creates a node that applies randomized accelerations to physics bodies.</summary>
		/// <returns>A new warp geometry grid.</returns>
		
		[Static, Export ("noiseFieldWithSmoothness:animationSpeed:")]
		SKFieldNode CreateNoiseField (nfloat smoothness, nfloat speed);

		/// <param name="smoothness">The smoothness factor (0.0 to 1.0).</param>
		/// <param name="speed">The animation speed.</param>
		/// <summary>Creates a node that applies randomized forces to neighboring physics bodies, with an average force that is proportional to the physics body's speed.</summary>
		/// <returns>A new warp geometry grid.</returns>
		
		[Static, Export ("turbulenceFieldWithSmoothness:animationSpeed:")]
		SKFieldNode CreateTurbulenceField (nfloat smoothness, nfloat speed);

		[Static, Export ("springField")]
		SKFieldNode CreateSpringField ();

		[Static, Export ("electricField")]
		SKFieldNode CreateElectricField ();

		[Static, Export ("magneticField")]
		SKFieldNode CreateMagneticField ();

		[Static, Export ("customFieldWithEvaluationBlock:")]
		SKFieldNode CreateCustomField (SKFieldForceEvaluator evaluator);
	}

	/// <include file="../docs/api/SpriteKit/SKScene.xml" path="/Documentation/Docs[@DocId='T:SpriteKit.SKScene']/*" />
	[MacCatalyst (13, 1)]
	[BaseType (typeof (SKEffectNode))]
	interface SKScene
		: GKSceneRootNodeType {
		[Export ("initWithSize:")]
		NativeHandle Constructor (CGSize size);

		[Static, Export ("sceneWithSize:")]
		SKScene FromSize (CGSize size);

		[MacCatalyst (13, 1)]
		[Export ("sceneDidLoad")]
		void SceneDidLoad ();

		[Export ("size")]
		CGSize Size { get; set; }

		[Export ("scaleMode")]
		SKSceneScaleMode ScaleMode { get; set; }

		[Export ("backgroundColor", ArgumentSemantic.Retain)]
		UIColor BackgroundColor { get; set; }

		[Export ("anchorPoint")]
		CGPoint AnchorPoint { get; set; }

		[Export ("physicsWorld")]
		SKPhysicsWorld PhysicsWorld { get; }

		[MacCatalyst (13, 1)]
		[Export ("convertPointFromView:")]
		CGPoint ConvertPointFromView (CGPoint point);

		[MacCatalyst (13, 1)]
		[Export ("convertPointToView:")]
		CGPoint ConvertPointToView (CGPoint point);

		[MacCatalyst (13, 1)]
		[Export ("view", ArgumentSemantic.Weak)]
		[NullAllowed]
		SKView View { get; }

		[Export ("update:")]
		void Update (double currentTime);

		[Export ("didEvaluateActions")]
		void DidEvaluateActions ();

		[Export ("didSimulatePhysics")]
		void DidSimulatePhysics ();

		[MacCatalyst (13, 1)]
		[Export ("didMoveToView:")]
		void DidMoveToView (SKView view);

		[MacCatalyst (13, 1)]
		[Export ("willMoveFromView:")]
		void WillMoveFromView (SKView view);

		[Export ("didChangeSize:")]
		void DidChangeSize (CGSize oldSize);

		[MacCatalyst (13, 1)]
		[Export ("didApplyConstraints")]
		void DidApplyConstraints ();

		[MacCatalyst (13, 1)]
		[Export ("didFinishUpdate")]
		void DidFinishUpdate ();

		[MacCatalyst (13, 1)]
		[Export ("delegate", ArgumentSemantic.Weak), NullAllowed]
		NSObject WeakDelegate { get; set; }

		/// <summary>An instance of the SpriteKit.ISKSceneDelegate model class which acts as the class delegate.</summary>
		///         <value>The instance of the SpriteKit.ISKSceneDelegate model class</value>
		///         <remarks>
		///           <para>The delegate instance assigned to this object will be used to handle events or provide data on demand to this class.</para>
		///           <para>When setting the Delegate or WeakDelegate values events will be delivered to the specified instance instead of being delivered to the C#-style events</para>
		///           <para>This is the strongly typed version of the object, developers should use the WeakDelegate property instead if they want to merely assign a class derived from NSObject that has been decorated with [Export] attributes.</para>
		///         </remarks>
		[MacCatalyst (13, 1)]
		[Wrap ("WeakDelegate")]
		ISKSceneDelegate Delegate { get; set; }

		[MacCatalyst (13, 1)]
		[Export ("audioEngine", ArgumentSemantic.Retain)]
		AVAudioEngine AudioEngine { get; }

		[MacCatalyst (13, 1)]
		[NullAllowed, Export ("camera", ArgumentSemantic.Weak)]
		SKCameraNode Camera { get; set; }

		[MacCatalyst (13, 1)]
		[NullAllowed, Export ("listener", ArgumentSemantic.Weak)]
		SKNode Listener { get; set; }
	}

	interface ISKSceneDelegate { }

	/// <summary>Delegate object for SKScene objects. Provides methods relating to animation events.</summary>
	///     
	///     <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/SpriteKit/Reference/SKSceneDelegate_Ref/index.html">Apple documentation for <c>SKSceneDelegate</c></related>
	[MacCatalyst (13, 1)]
	[Protocol, Model]
	[BaseType (typeof (NSObject))]
	interface SKSceneDelegate {
		/// <param name="currentTime">The current time in the simulation.</param>
		/// <param name="scene">The scene being updated.</param>
		/// <summary>Method that is called once per frame, if <paramref name="scene" /> is presented and not paused, before any animation takes place.</summary>
		
		[Export ("update:forScene:")]
		void Update (double currentTime, SKScene scene);

		/// <param name="scene">The scene that performed the actions.</param>
		/// <summary>Method that is called after all scene actions are evaluated for <paramref name="scene" />.</summary>
		
		[Export ("didEvaluateActionsForScene:")]
		void DidEvaluateActions (SKScene scene);

		/// <param name="scene">The scene that simulated the physics.</param>
		/// <summary>Method that is called after physics simulation for <paramref name="scene" /> is complete.</summary>
		
		[Export ("didSimulatePhysicsForScene:")]
		void DidSimulatePhysics (SKScene scene);

		/// <param name="scene">The scene that applied the constraints.</param>
		/// <summary>Method that is called after constraints are applied to <paramref name="scene" />.</summary>
		
		[Export ("didApplyConstraintsForScene:")]
		void DidApplyConstraints (SKScene scene);

		/// <param name="scene">The scene that finished rendering.</param>
		/// <summary>Method that is called after the <paramref name="scene" /> is updated.</summary>
		
		[Export ("didFinishUpdateForScene:")]
		void DidFinishUpdate (SKScene scene);
	}

	/// <summary>An OpenGL ES fragment shader.</summary>
	///     
	///     <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/SpriteKit/Reference/SKShader_Ref/index.html">Apple documentation for <c>SKShader</c></related>
	[MacCatalyst (13, 1)]
	[BaseType (typeof (NSObject))]
	interface SKShader : NSCopying, NSSecureCoding {
		[Export ("initWithSource:")]
		NativeHandle Constructor (string shaderSourceCode);

		[Export ("initWithSource:uniforms:")]
		NativeHandle Constructor (string sharedSourceCode, SKUniform [] uniforms);

		[NullAllowed] // by default this property is null
		[Export ("source")]
		string Source { get; set; }

		// @property (copy) NSArray * uniforms;
		[Export ("uniforms", ArgumentSemantic.Copy)]
		SKUniform [] Uniforms { get; set; }

		// @required + (instancetype)shader;
		[Static, Export ("shader")]
		SKShader Create ();

		[Static, Export ("shaderWithSource:")]
		SKShader FromShaderSourceCode (string source);

		[Static, Export ("shaderWithSource:uniforms:")]
		SKShader FromShaderSourceCode (string source, SKUniform [] uniforms);

		[Static, Export ("shaderWithFileNamed:")]
		SKShader FromFile (string name);

		[Export ("addUniform:")]
		void AddUniform (SKUniform uniform);

		[Export ("uniformNamed:")]
		[return: NullAllowed]
		SKUniform GetUniform (string uniformName);

		[Export ("removeUniformNamed:")]
		void RemoveUniform (string uniforName);

		[MacCatalyst (13, 1)]
		[Export ("attributes", ArgumentSemantic.Copy)]
		SKAttribute [] Attributes { get; set; }
	}

	/// <summary>A <see cref="SpriteKit.SKShapeNode" /> that displays a textured, colored sprite.</summary>
	///     
	///     <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/SpriteKit/Reference/SKSpriteNode_Ref/index.html">Apple documentation for <c>SKSpriteNode</c></related>
	[MacCatalyst (13, 1)]
	[BaseType (typeof (SKNode))]
	partial interface SKSpriteNode : SKWarpable {

		[Static, Export ("spriteNodeWithTexture:size:")]
		SKSpriteNode FromTexture ([NullAllowed] SKTexture texture, CGSize size);

		[Static, Export ("spriteNodeWithTexture:")]
		SKSpriteNode FromTexture ([NullAllowed] SKTexture texture);

		[Static, Export ("spriteNodeWithImageNamed:")]
		SKSpriteNode FromImageNamed (string name);

		[Static, Export ("spriteNodeWithColor:size:")]
		SKSpriteNode FromColor (UIColor color, CGSize size);

		[DesignatedInitializer]
		[Export ("initWithTexture:color:size:")]
		NativeHandle Constructor ([NullAllowed] SKTexture texture, UIColor color, CGSize size);

		[Export ("initWithTexture:")]
		NativeHandle Constructor ([NullAllowed] SKTexture texture);

		// can't be null -> crash
		[Export ("initWithImageNamed:")]
		NativeHandle Constructor (string name);

		[Export ("initWithColor:size:")]
		NativeHandle Constructor (UIColor color, CGSize size);

		[Export ("texture", ArgumentSemantic.Retain)]
		[NullAllowed]
		SKTexture Texture { get; set; }

		[Export ("centerRect")]
		CGRect CenterRect { get; set; }

		[Export ("colorBlendFactor")]
		nfloat ColorBlendFactor { get; set; }

		[Export ("color", ArgumentSemantic.Retain)]
		[NullAllowed] // it's actually null-resetable (see unit tests)
		UIColor Color { get; set; }

		[Export ("blendMode")]
		SKBlendMode BlendMode { get; set; }

		[Export ("anchorPoint")]
		CGPoint AnchorPoint { get; set; }

		[Export ("size")]
		CGSize Size { get; set; }

		//
		// iOS 8
		//


		[MacCatalyst (13, 1)]
		[Static, Export ("spriteNodeWithTexture:normalMap:")]
		SKSpriteNode Create ([NullAllowed] SKTexture texture, [NullAllowed] SKTexture normalMap);

		[MacCatalyst (13, 1)]
		[Static, Export ("spriteNodeWithImageNamed:normalMapped:")]
		SKSpriteNode Create (string imageName, bool generateNormalMap);

		[MacCatalyst (13, 1)]
		[NullAllowed] // by default this property is null
		[Export ("normalTexture", ArgumentSemantic.Retain)]
		SKTexture NormalTexture { get; set; }

		[MacCatalyst (13, 1)]
		[Export ("lightingBitMask")]
		uint LightingBitMask { get; set; } /* uint32_t */

		[MacCatalyst (13, 1)]
		[Export ("shadowCastBitMask")]
		uint ShadowCastBitMask { get; set; } /* uint32_t */

		[MacCatalyst (13, 1)]
		[Export ("shadowedBitMask")]
		uint ShadowedBitMask { get; set; } /* uint32_t */

		[MacCatalyst (13, 1)]
		[Export ("shader", ArgumentSemantic.Retain), NullAllowed]
		SKShader Shader { get; set; }

		[MacCatalyst (13, 1)]
		[Export ("scaleToSize:")]
		void ScaleTo (CGSize size);

		[MacCatalyst (13, 1)]
		[Export ("attributeValues", ArgumentSemantic.Copy)]
		NSDictionary<NSString, SKAttributeValue> AttributeValues { get; set; }

		[MacCatalyst (13, 1)]
		[Export ("valueForAttributeNamed:")]
		[return: NullAllowed]
		SKAttributeValue GetValue (string key);

		[MacCatalyst (13, 1)]
		[Export ("setValue:forAttributeNamed:")]
		void SetValue (SKAttributeValue value, string key);
	}

	/// <summary>An object that can control the properties of particles emitted by a <see cref="SpriteKit.SKEmitterNode" />.</summary>
	///     <remarks>
	///       <para>The total time of the sequence is normalized from 0.0 to 1.0.</para>
	///     </remarks>
	///     
	///     
	///     
	///     
	///     <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/SpriteKit/Reference/SKKeyframeSequence_Ref/index.html">Apple documentation for <c>SKKeyframeSequence</c></related>
	[MacCatalyst (13, 1)]
	[BaseType (typeof (NSObject))]
	partial interface SKKeyframeSequence : NSSecureCoding, NSCopying {

		[DesignatedInitializer]
		[Export ("initWithKeyframeValues:times:")]
		[Internal]
		NativeHandle Constructor ([NullAllowed] NSObject [] values, [NullAllowed] NSArray times);

		/// <param name="numItems">The number of keyframe items.</param>
		/// <summary>Creates a new <see cref="SpriteKit.SKKeyframeSequence" /> with the capacity to hold <paramref name="numItems" /> keyframe values.</summary>
		
		[Export ("initWithCapacity:")]
		NativeHandle Constructor (nuint numItems);

		[Export ("count")]
		nuint Count { get; }

		/// <param name="value">The value for the keyframe.</param>
		/// <param name="time">The time for the keyframe (0.0 to 1.0).</param>
		/// <summary>Adds a keyframe to the end of the list of keyframes, with the specified time..</summary>
		
		[Export ("addKeyframeValue:time:")]
		void AddKeyframeValue (NSObject value, nfloat time);

		[Export ("removeLastKeyframe")]
		void RemoveLastKeyframe ();

		/// <param name="index">The index of the keyframe to get.</param>
		/// <summary>Removes the keyframe, and corresponding time, at the specified index.</summary>
		
		[Export ("removeKeyframeAtIndex:")]
		void RemoveKeyframe (nuint index);

		/// <param name="value">The new value for the keyframe.</param>
		/// <param name="index">The index of the keyframe to set.</param>
		/// <summary>Sets the value for the keyframe at <paramref name="index" />.</summary>
		
		[Export ("setKeyframeValue:forIndex:")]
		void SetKeyframeValue (NSObject value, nuint index);

		/// <param name="time">The new time for the keyframe.</param>
		/// <param name="index">The index of the keyframe to set.</param>
		/// <summary>Sets the time for the keyframe at <paramref name="index" />.</summary>
		
		[Export ("setKeyframeTime:forIndex:")]
		void SetKeyframeTime (nfloat time, nuint index);

		/// <param name="value">The value for the keyframe.</param>
		/// <param name="time">The time for the keyframe.</param>
		/// <param name="index">The index at which to insert the keyframe.</param>
		/// <summary>Sets the time and value for the keyframe at the specified index.</summary>
		
		[Export ("setKeyframeValue:time:forIndex:")]
		void SetKeyframeValue (NSObject value, nfloat time, nuint index);

		/// <param name="index">The index of the keyframe to remove.</param>
		/// <summary>Gets the keyframe value for the specified index.</summary>
		/// <returns>The value of the removed keyframe.</returns>
		
		[Export ("getKeyframeValueForIndex:")]
		NSObject GetKeyframeValue (nuint index);

		/// <param name="index">The index of the keyframe.</param>
		/// <summary>Gets the time for the keyframe at the specified index.</summary>
		/// <returns>The time of the keyframe at the specified index.</returns>
		
		[Export ("getKeyframeTimeForIndex:")]
		nfloat GetKeyframeTime (nuint index);

		/// <param name="time">The time to sample (0.0 to 1.0).</param>
		/// <summary>Samples a value at the specified time.</summary>
		/// <returns>The interpolated value at the specified time.</returns>
		
		[Export ("sampleAtTime:")]
		[return: NullAllowed]
		NSObject SampleAtTime (nfloat time);

		[Export ("interpolationMode")]
		SKInterpolationMode InterpolationMode { get; set; }

		[Export ("repeatMode")]
		SKRepeatMode RepeatMode { get; set; }
	}

	/// <summary>A  <see cref="SpriteKit.SKNode" /> that produces colored and textured particles.</summary>
	///     <remarks>
	///       <para>Emitted particles are not directly accessible to the application developer; their behavior can be controlled either via the creation parameters configurable in <see cref="SpriteKit.SKEmitterNode" /> or by a <see cref="SpriteKit.SKKeyframeSequence" />.</para>
	///     </remarks>
	///     <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/SpriteKit/Reference/SKEmitterNode_Ref/index.html">Apple documentation for <c>SKEmitterNode</c></related>
	[MacCatalyst (13, 1)]
	[BaseType (typeof (SKNode))]
	partial interface SKEmitterNode {

		[Export ("advanceSimulationTime:")]
		void AdvanceSimulationTime (double sec);

		[Export ("resetSimulation")]
		void ResetSimulation ();

		[NullAllowed] // by default this property is null
		[Export ("particleTexture", ArgumentSemantic.Retain)]
		SKTexture ParticleTexture { get; set; }

		[Export ("particleZPosition")]
		nfloat ParticleZPosition { get; set; }

		[Deprecated (PlatformName.iOS, 8, 0)]
		[Deprecated (PlatformName.TvOS, 8, 0)]
		[Deprecated (PlatformName.MacOSX, 10, 10)]
		[Deprecated (PlatformName.MacCatalyst, 13, 1)]
		[Export ("particleZPositionRange")]
		nfloat ParticleZPositionRange { get; set; }

		[Export ("particleBlendMode")]
		SKBlendMode ParticleBlendMode { get; set; }

		[Export ("particleColor", ArgumentSemantic.Retain)]
		UIColor ParticleColor { get; set; }

		[Export ("particleColorRedRange")]
		nfloat ParticleColorRedRange { get; set; }

		[Export ("particleColorGreenRange")]
		nfloat ParticleColorGreenRange { get; set; }

		[Export ("particleColorBlueRange")]
		nfloat ParticleColorBlueRange { get; set; }

		[Export ("particleColorAlphaRange")]
		nfloat ParticleColorAlphaRange { get; set; }

		[Export ("particleColorRedSpeed")]
		nfloat ParticleColorRedSpeed { get; set; }

		[Export ("particleColorGreenSpeed")]
		nfloat ParticleColorGreenSpeed { get; set; }

		[Export ("particleColorBlueSpeed")]
		nfloat ParticleColorBlueSpeed { get; set; }

		[Export ("particleColorAlphaSpeed")]
		nfloat ParticleColorAlphaSpeed { get; set; }

		[NullAllowed] // by default this property is null
		[Export ("particleColorSequence", ArgumentSemantic.Retain)]
		SKKeyframeSequence ParticleColorSequence { get; set; }

		[Export ("particleColorBlendFactor")]
		nfloat ParticleColorBlendFactor { get; set; }

		[Export ("particleColorBlendFactorRange")]
		nfloat ParticleColorBlendFactorRange { get; set; }

		[Export ("particleColorBlendFactorSpeed")]
		nfloat ParticleColorBlendFactorSpeed { get; set; }

		[NullAllowed] // by default this property is null
		[Export ("particleColorBlendFactorSequence", ArgumentSemantic.Retain)]
		SKKeyframeSequence ParticleColorBlendFactorSequence { get; set; }

		[Export ("particlePosition")]
		CGPoint ParticlePosition { get; set; }

		[Export ("particlePositionRange")]
		CGVector ParticlePositionRange { get; set; }

		[Export ("particleSpeed")]
		nfloat ParticleSpeed { get; set; }

		[Export ("particleSpeedRange")]
		nfloat ParticleSpeedRange { get; set; }

		[Export ("emissionAngle")]
		nfloat EmissionAngle { get; set; }

		[Export ("emissionAngleRange")]
		nfloat EmissionAngleRange { get; set; }

		[Export ("xAcceleration")]
		nfloat XAcceleration { get; set; }

		[Export ("yAcceleration")]
		nfloat YAcceleration { get; set; }

		[Export ("particleBirthRate")]
		nfloat ParticleBirthRate { get; set; }

		[Export ("numParticlesToEmit")]
		nuint NumParticlesToEmit { get; set; }

		[Export ("particleLifetime")]
		nfloat ParticleLifetime { get; set; }

		[Export ("particleLifetimeRange")]
		nfloat ParticleLifetimeRange { get; set; }

		[Export ("particleRotation")]
		nfloat ParticleRotation { get; set; }

		[Export ("particleRotationRange")]
		nfloat ParticleRotationRange { get; set; }

		[Export ("particleRotationSpeed")]
		nfloat ParticleRotationSpeed { get; set; }

		[Export ("particleSize")]
		CGSize ParticleSize { get; set; }

		[Export ("particleScale")]
		nfloat ParticleScale { get; set; }

		[Export ("particleScaleRange")]
		nfloat ParticleScaleRange { get; set; }

		[Export ("particleScaleSpeed")]
		nfloat ParticleScaleSpeed { get; set; }

		[NullAllowed] // by default this property is null
		[Export ("particleScaleSequence", ArgumentSemantic.Retain)]
		SKKeyframeSequence ParticleScaleSequence { get; set; }

		[Export ("particleAlpha")]
		nfloat ParticleAlpha { get; set; }

		[Export ("particleAlphaRange")]
		nfloat ParticleAlphaRange { get; set; }

		[Export ("particleAlphaSpeed")]
		nfloat ParticleAlphaSpeed { get; set; }

		[NullAllowed] // by default this property is null
		[Export ("particleAlphaSequence", ArgumentSemantic.Retain)]
		SKKeyframeSequence ParticleAlphaSequence { get; set; }

		[NullAllowed] // by default this property is null
		[Export ("particleAction", ArgumentSemantic.Copy)]
		SKAction ParticleAction { get; set; }

		[NullAllowed] // by default this property is null
		[Export ("targetNode", ArgumentSemantic.Weak)]
		SKNode TargetNode { get; set; }

		//
		// iOS 8
		//
		[MacCatalyst (13, 1)]
		[Export ("fieldBitMask")]
		uint FieldBitMask { get; set; } /* uint32_t */

		[Deprecated (PlatformName.iOS, 8, 0)]
		[Deprecated (PlatformName.TvOS, 8, 0)]
		[Deprecated (PlatformName.MacOSX, 10, 10)]
		[Deprecated (PlatformName.MacCatalyst, 13, 1)]
		[Export ("particleZPositionSpeed")]
		nfloat ParticleZPositionSpeed { get; set; }

		[MacCatalyst (13, 1)]
		[NullAllowed] // by default this property is null
		[Export ("shader", ArgumentSemantic.Retain)]
		SKShader Shader { get; set; }

		[MacCatalyst (13, 1)]
		[Export ("particleRenderOrder", ArgumentSemantic.Assign)]
		SKParticleRenderOrder ParticleRenderOrder { get; set; }

		[MacCatalyst (13, 1)]
		[Export ("attributeValues", ArgumentSemantic.Copy)]
		NSDictionary<NSString, SKAttributeValue> AttributeValues { get; set; }

		[MacCatalyst (13, 1)]
		[Export ("valueForAttributeNamed:")]
		[return: NullAllowed]
		SKAttributeValue GetValue (string key);

		[MacCatalyst (13, 1)]
		[Export ("setValue:forAttributeNamed:")]
		void SetValue (SKAttributeValue value, string key);
	}

	/// <summary>A <see cref="SpriteKit.SKShapeNode" /> defined by a Core Graphics <see cref="CoreGraphics.CGPath" />.</summary>
	///     
	///     <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/SpriteKit/Reference/SKShapeNode_Ref/index.html">Apple documentation for <c>SKShapeNode</c></related>
	[MacCatalyst (13, 1)]
	[BaseType (typeof (SKNode))]
	partial interface SKShapeNode {

		[NullAllowed]
		[Export ("path")]
		CGPath Path { get; set; }

		[Export ("strokeColor", ArgumentSemantic.Retain)]
		UIColor StrokeColor { get; set; }

		[Export ("fillColor", ArgumentSemantic.Retain)]
		UIColor FillColor { get; set; }

		[Export ("blendMode")]
		SKBlendMode BlendMode { get; set; }

		/// <summary>Gets or sets a value that controls whether to antialias the shape.</summary>
		[Export ("antialiased")]
		bool Antialiased { [Bind ("isAntialiased")] get; set; }

		[Export ("lineWidth")]
		nfloat LineWidth { get; set; }

		[Export ("glowWidth")]
		nfloat GlowWidth { get; set; }

		//
		// iOS 8
		//
		[MacCatalyst (13, 1)]
		[NullAllowed] // by default this property is null
		[Export ("fillTexture", ArgumentSemantic.Retain)]
		SKTexture FillTexture { get; set; }

		[MacCatalyst (13, 1)]
		[NullAllowed] // by default this property is null
		[Export ("fillShader", ArgumentSemantic.Retain)]
		SKShader FillShader { get; set; }

		[MacCatalyst (13, 1)]
		[NullAllowed] // by default this property is null
		[Export ("strokeTexture", ArgumentSemantic.Retain)]
		SKTexture StrokeTexture { get; set; }

		[MacCatalyst (13, 1)]
		[NullAllowed] // by default this property is null
		[Export ("strokeShader", ArgumentSemantic.Retain)]
		SKShader StrokeShader { get; set; }

		[MacCatalyst (13, 1)]
		[Static, Export ("shapeNodeWithPath:")]
		SKShapeNode FromPath (CGPath path);

		[MacCatalyst (13, 1)]
		[Static, Export ("shapeNodeWithPath:centered:")]
		SKShapeNode FromPath (CGPath path, bool centered);

		[MacCatalyst (13, 1)]
		[Static, Export ("shapeNodeWithRect:")]
		SKShapeNode FromRect (CGRect rect);

		[MacCatalyst (13, 1)]
		[Static, Export ("shapeNodeWithRectOfSize:")]
		SKShapeNode FromRect (CGSize size);

		/// <param name="rect">The rectangle that defines the shape.</param>
		/// <param name="cornerRadius">The radius of the rounded corners.</param>
		/// <summary>Creates a shape node from the specified rectangle and the specified corner radius.</summary>
		/// <returns>A new shape node with the specified rounded rectangle.</returns>
		
		[MacCatalyst (13, 1)]
		[Static, Export ("shapeNodeWithRect:cornerRadius:")]
		SKShapeNode FromRect (CGRect rect, nfloat cornerRadius);

		/// <param name="size">The size of the rectangle.</param>
		/// <param name="cornerRadius">The radius of the rounded corners.</param>
		/// <summary>Creates a shape node with the specified corner radius by treating the specified size as a rectangle.</summary>
		/// <returns>A new shape node centered at the origin.</returns>
		
		[MacCatalyst (13, 1)]
		[Static, Export ("shapeNodeWithRectOfSize:cornerRadius:")]
		SKShapeNode FromRect (CGSize size, nfloat cornerRadius);

		/// <param name="radius">The radius of the circle.</param>
		/// <summary>Creates a new circular shape node from a radius.</summary>
		/// <returns>A new shape node with the specified circle.</returns>
		
		[MacCatalyst (13, 1)]
		[Static, Export ("shapeNodeWithCircleOfRadius:")]
		SKShapeNode FromCircle (nfloat radius);

		[MacCatalyst (13, 1)]
		[Static, Export ("shapeNodeWithEllipseInRect:")]
		SKShapeNode FromEllipse (CGRect rect);

		[MacCatalyst (13, 1)]
		[Static, Export ("shapeNodeWithEllipseOfSize:")]
		SKShapeNode FromEllipse (CGSize size);

		// Hide this ugly api fixes https://bugzilla.xamarin.com/show_bug.cgi?id=39706
		/// <param name="points">The array of points defining the spline.</param>
		/// <param name="numPoints">The number of points in the array.</param>
		/// <summary>Creates a shape node from the specified list of points.</summary>
		/// <returns>A new shape node with a spline path.</returns>
		
		[Internal]
		[MacCatalyst (13, 1)]
		[Static, Export ("shapeNodeWithPoints:count:")]
		SKShapeNode FromPoints (ref CGPoint points, nuint numPoints);

		// Hide this ugly api fixes https://bugzilla.xamarin.com/show_bug.cgi?id=39706
		/// <param name="points">The array of points defining the polygon.</param>
		/// <param name="numPoints">The number of points in the array.</param>
		/// <summary>Creates a shape node that represents a quadratic spline curve through the specified points.</summary>
		/// <returns>A new shape node with the specified polygon.</returns>
		
		[Internal]
		[MacCatalyst (13, 1)]
		[Static, Export ("shapeNodeWithSplinePoints:count:")]
		SKShapeNode FromSplinePoints (ref CGPoint points, nuint numPoints);

		[MacCatalyst (13, 1)]
		[Export ("lineCap")]
		CGLineCap LineCap { get; set; }

		[MacCatalyst (13, 1)]
		[Export ("lineJoin")]
		CGLineJoin LineJoin { get; set; }

		[MacCatalyst (13, 1)]
		[Export ("miterLimit")]
		nfloat MiterLimit { get; set; }

		[MacCatalyst (13, 1)]
		[Export ("lineLength")]
		nfloat LineLength { get; }

		[MacCatalyst (13, 1)]
		[Export ("attributeValues", ArgumentSemantic.Copy)]
		NSDictionary<NSString, SKAttributeValue> AttributeValues { get; set; }

		[MacCatalyst (13, 1)]
		[Export ("valueForAttributeNamed:")]
		[return: NullAllowed]
		SKAttributeValue GetValue (string key);

		[MacCatalyst (13, 1)]
		[Export ("setValue:forAttributeNamed:")]
		void SetValue (SKAttributeValue value, string key);
	}

	/// <summary>A range of motion used with inverse kinematics.</summary>
	///     
	///     <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/SpriteKit/Reference/SKReachConstraints_Ref/index.html">Apple documentation for <c>SKReachConstraints</c></related>
	[MacCatalyst (13, 1)]
	[BaseType (typeof (NSObject))]
	interface SKReachConstraints : NSSecureCoding {
		/// <param name="lowerAngleLimit">The lower angle limit in radians.</param>
		/// <param name="upperAngleLimit">The upper angle limit in radians.</param>
		/// <summary>Creates a new <see cref="SpriteKit.SKReachConstraints" /> object with the specified limits.</summary>
		
		[DesignatedInitializer]
		[Export ("initWithLowerAngleLimit:upperAngleLimit:")]
		NativeHandle Constructor (nfloat lowerAngleLimit, nfloat upperAngleLimit);

		[Export ("lowerAngleLimit", ArgumentSemantic.UnsafeUnretained)]
		nfloat LowerAngleLimit { get; set; }

		[Export ("upperAngleLimit", ArgumentSemantic.UnsafeUnretained)]
		nfloat UpperAngleLimit { get; set; }
	}

	/// <summary>A path-defined area. Typically used for hit-testing and physics-field extents.</summary>
	///     
	///     <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/SpriteKit/Reference/SKRegion_Ref/index.html">Apple documentation for <c>SKRegion</c></related>
	[MacCatalyst (13, 1)]
	[BaseType (typeof (NSObject))]
	interface SKRegion : NSCopying, NSSecureCoding {
		[Export ("initWithRadius:")]
		NativeHandle Constructor (float /* float, not CGFloat */ radius);

		[Export ("initWithSize:")]
		NativeHandle Constructor (CGSize size);

		[Export ("initWithPath:")]
		NativeHandle Constructor (CGPath path);

		[Export ("path")]
		[NullAllowed]
		CGPath Path { get; }

		[Static, Export ("infiniteRegion")]
		SKRegion InfiniteRegion { get; }

		[Export ("inverseRegion")]
		SKRegion InverseRegion ();

		[Export ("regionByUnionWithRegion:")]
		SKRegion CreateUnion (SKRegion region);

		[Export ("regionByDifferenceFromRegion:")]
		SKRegion CreateDifference (SKRegion region);

		[Export ("regionByIntersectionWithRegion:")]
		SKRegion CreateIntersection (SKRegion region);

		[Export ("containsPoint:")]
		bool ContainsPoint (CGPoint point);
	}

	/// <summary>A <see cref="SpriteKit.SKNode" /> that displays a string.</summary>
	///     
	///     <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/SpriteKit/Reference/SKLabelNode_Ref/index.html">Apple documentation for <c>SKLabelNode</c></related>
	[MacCatalyst (13, 1)]
	[BaseType (typeof (SKNode))]
	partial interface SKLabelNode {

		[Static, Export ("labelNodeWithFontNamed:")]
		SKLabelNode FromFont ([NullAllowed] string fontName);

		[Export ("initWithFontNamed:")]
		NativeHandle Constructor ([NullAllowed] string fontName);

		[MacCatalyst (13, 1)]
		[Static, Export ("labelNodeWithText:")]
		SKLabelNode FromText ([NullAllowed] string text);

		[MacCatalyst (13, 1)]
		[Static]
		[Export ("labelNodeWithAttributedText:")]
		SKLabelNode FromText ([NullAllowed] NSAttributedString attributedText);

		[Export ("verticalAlignmentMode")]
		SKLabelVerticalAlignmentMode VerticalAlignmentMode { get; set; }

		[Export ("horizontalAlignmentMode")]
		SKLabelHorizontalAlignmentMode HorizontalAlignmentMode { get; set; }

		[MacCatalyst (13, 1)]
		[Export ("numberOfLines")]
		nint NumberOfLines { get; set; }

		[MacCatalyst (13, 1)]
		[Export ("lineBreakMode", ArgumentSemantic.Assign)]
		NSLineBreakMode LineBreakMode { get; set; }

		[MacCatalyst (13, 1)]
		[Export ("preferredMaxLayoutWidth")]
		nfloat PreferredMaxLayoutWidth { get; set; }

		[Export ("fontName", ArgumentSemantic.Copy)]
		[NullAllowed]
		string FontName { get; set; }

		[Export ("text", ArgumentSemantic.Copy)]
		[NullAllowed] // nullable in Xcode7 headers and caught by introspection tests
		string Text { get; set; }

		[MacCatalyst (13, 1)]
		[NullAllowed, Export ("attributedText", ArgumentSemantic.Copy)]
		NSAttributedString AttributedText { get; set; }

		[Export ("fontSize")]
		nfloat FontSize { get; set; }

		[Export ("fontColor", ArgumentSemantic.Retain)]
		[NullAllowed]
		UIColor FontColor { get; set; }

		[Export ("colorBlendFactor")]
		nfloat ColorBlendFactor { get; set; }

		[NullAllowed] // by default this property is null
		[Export ("color", ArgumentSemantic.Retain)]
		UIColor Color { get; set; }

		[Export ("blendMode")]
		SKBlendMode BlendMode { get; set; }
	}

	/// <summary>A node that creates a lighting effect within a scene.</summary>
	///     
	///     <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/SpriteKit/Reference/SKLightNode_Ref/index.html">Apple documentation for <c>SKLightNode</c></related>
	[MacCatalyst (13, 1)]
	[BaseType (typeof (SKNode))]
	interface SKLightNode {
		/// <summary>Gets or sets of value that determines whether the node is casting light.</summary>
		[Export ("enabled")]
		bool Enabled { [Bind ("isEnabled")] get; set; }

		[Export ("lightColor")]
		UIColor LightColor { get; set; }

		[Export ("ambientColor")]
		UIColor AmbientColor { get; set; }

		[Export ("shadowColor")]
		UIColor ShadowColor { get; set; }

		[Export ("falloff")]
		nfloat Falloff { get; set; }

		[Export ("categoryBitMask")]
		uint CategoryBitMask { get; set; } /* uint32_t */
	}

	/// <summary>A <see cref="SpriteKit.SKNode" /> that displays video.</summary>
	///     
	///     <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/SpriteKit/Reference/SKVideoNode/index.html">Apple documentation for <c>SKVideoNode</c></related>
	[MacCatalyst (13, 1)]
	[BaseType (typeof (SKNode))]
	partial interface SKVideoNode {
		[Static, Export ("videoNodeWithAVPlayer:")]
		SKVideoNode FromPlayer (AVPlayer player);

		/// <summary>Create a video node from the named video file.</summary>
		/// <param name="videoFile">The video file to create the <see cref="SKVideoNode" /> from.</param>
		[Static, Export ("videoNodeWithFileNamed:")]
		SKVideoNode FromFile (string videoFile);

		/// <summary>Creates a video node from the file at the specified URL.</summary>
		/// <param name="videoUrl">The video url to create the <see cref="SKVideoNode" /> from.</param>
		[Static, Export ("videoNodeWithURL:")]
		SKVideoNode FromUrl (NSUrl videoUrl);

		[DesignatedInitializer]
		[Export ("initWithAVPlayer:")]
		NativeHandle Constructor (AVPlayer player);

		/// <summary>Create a video node from the named video file.</summary>
		/// <param name="videoFile">The video file to create the <see cref="SKVideoNode" /> from.</param>
		[Export ("initWithFileNamed:")]
		[DesignatedInitializer]
		NativeHandle Constructor (string videoFile);

		/// <summary>Creates a video node from the file at the specified URL.</summary>
		/// <param name="url">The video url to create the <see cref="SKVideoNode" /> from.</param>
		[Export ("initWithURL:")]
		[DesignatedInitializer]
		NativeHandle Constructor (NSUrl url);

		[Export ("play")]
		void Play ();

		[Export ("pause")]
		void Pause ();

		[Export ("size")]
		CGSize Size { get; set; }

		[Export ("anchorPoint")]
		CGPoint AnchorPoint { get; set; }
	}

	/// <summary>Mathematical constraint on a node's position or orientation.</summary>
	///     
	///     <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/SpriteKit/Reference/SKConstraint_Ref/index.html">Apple documentation for <c>SKConstraint</c></related>
	[MacCatalyst (13, 1)]
	[BaseType (typeof (NSObject))]
	interface SKConstraint : NSSecureCoding, NSCopying {
		[Export ("enabled")]
		bool Enabled { get; set; }

		[NullAllowed] // by default this property is null
		[Export ("referenceNode", ArgumentSemantic.Retain)]
		SKNode ReferenceNode { get; set; }

		[Static, Export ("positionX:")]
		SKConstraint CreateXRestriction (SKRange range);

		[Static, Export ("positionY:")]
		SKConstraint CreateYRestriction (SKRange range);

		[Static, Export ("positionX:Y:")]
		SKConstraint CreateRestriction (SKRange xRange, SKRange yRange);

		[Static, Export ("distance:toNode:")]
		SKConstraint CreateDistance (SKRange range, SKNode node);

		[Static, Export ("distance:toPoint:")]
		SKConstraint CreateDistance (SKRange range, CGPoint point);

		[Static, Export ("distance:toPoint:inNode:")]
		SKConstraint CreateDistance (SKRange range, CGPoint point, SKNode node);

		[Static, Export ("zRotation:")]
		SKConstraint CreateZRotation (SKRange zRange);

		[Static, Export ("orientToNode:offset:")]
		SKConstraint CreateOrientToNode (SKNode node, SKRange radians);

		[Static, Export ("orientToPoint:offset:")]
		SKConstraint CreateOrientToPoint (CGPoint point, SKRange radians);

		[Static, Export ("orientToPoint:inNode:offset:")]
		SKConstraint CreateOrientToPoint (CGPoint point, SKNode node, SKRange radians);
	}

	/// <summary>A node that masks its children's pixels.</summary>
	///     <remarks>
	///       <para>An <see cref="SpriteKit.SKCropNode" /> masks pixels outside of the area defined by its <see cref="SpriteKit.SKCropNode.MaskNode" /> node. Pixels that fall outside of that area are not passed up towards the root of the <see cref="SpriteKit.SKScene" />.</para>
	///     </remarks>
	///     
	///     <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/SpriteKit/Reference/SKCropNode_Ref/index.html">Apple documentation for <c>SKCropNode</c></related>
	[MacCatalyst (13, 1)]
	[BaseType (typeof (SKNode))]
	partial interface SKCropNode {

		[NullAllowed] // by default this property is null
		[Export ("maskNode", ArgumentSemantic.Retain)]
		SKNode MaskNode { get; set; }
	}

	/// <summary>A <see cref="UIView" /> that displays a <see cref="SKScene" />.</summary>
	/// <remarks>
	///   <para>Application developers should note the availability of debugging properties, such as <see cref="SpriteKit.SKView.ShowsFPS" />.</para>
	/// </remarks>
	/// <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/SpriteKit/Reference/SKView/index.html">Apple documentation for <c>SKView</c></related>
	[MacCatalyst (13, 1)]
	[BaseType (typeof (UIView))]
	[DisableDefaultCtor]
	partial interface SKView
#if MONOMAC
	 : NSSecureCoding
#endif
		{
		/// <param name="frame">Frame used by the view, expressed in iOS points.</param>
		/// <summary>Initializes the SKView with the specified frame.</summary>
		/// <remarks>
		///           <para>This constructor is used to programmatically create a new instance of SKView with the specified dimension in the frame.   The object will only be displayed once it has been added to a view hierarchy by calling AddSubview in a containing view.</para>
		///           <para>This constructor is not invoked when deserializing objects from storyboards or XIB files; instead, the constructor that takes an NSCoder parameter is invoked.</para>
		///         </remarks>
		[Export ("initWithFrame:")]
		NativeHandle Constructor (CGRect frame);

		/// <summary>Gets or sets a value that controls whether the view is paused.</summary>
		[Export ("paused")]
		bool Paused { [Bind ("isPaused")] get; set; }

		[Export ("showsFPS")]
		bool ShowsFPS { get; set; }

		[Export ("showsDrawCount")]
		bool ShowsDrawCount { get; set; }

		[Export ("showsNodeCount")]
		bool ShowsNodeCount { get; set; }

		[MacCatalyst (13, 1)]
		[Export ("showsPhysics")]
		bool ShowsPhysics { get; set; }

		/// <summary>Gets or sets whether the view is rendered asynchronously.</summary>
		[Export ("asynchronous")]
		bool Asynchronous { [Bind ("isAsynchronous")] get; set; }

		[Deprecated (PlatformName.iOS, 10, 0)]
		[Deprecated (PlatformName.TvOS, 10, 0)]
		[Deprecated (PlatformName.MacOSX, 10, 12)]
		[Deprecated (PlatformName.MacCatalyst, 13, 1)]
		[Export ("frameInterval")]
		nint FrameInterval { get; set; }

		[Export ("presentScene:")]
		void PresentScene ([NullAllowed] SKScene scene);

		[Export ("presentScene:transition:")]
		void PresentScene (SKScene scene, SKTransition transition);

		[Export ("scene")]
		[NullAllowed]
		SKScene Scene { get; }

		[Export ("textureFromNode:")]
		[return: NullAllowed]
		SKTexture TextureFromNode (SKNode node);

		[Export ("convertPoint:toScene:")]
		CGPoint ConvertPointToScene (CGPoint point, SKScene scene);

		[Export ("convertPoint:fromScene:")]
		CGPoint ConvertPointFromScene (CGPoint point, SKScene scene);

		[Export ("ignoresSiblingOrder")]
		bool IgnoresSiblingOrder { get; set; }

		//
		// iOS 8
		//
		[MacCatalyst (13, 1)]
		[Export ("allowsTransparency")]
		bool AllowsTransparency { get; set; }

		[MacCatalyst (13, 1)]
		[Export ("shouldCullNonVisibleNodes")]
		bool ShouldCullNonVisibleNodes { get; set; }

		[MacCatalyst (13, 1)]
		[Export ("showsFields")]
		bool ShowsFields { get; set; }

		[MacCatalyst (13, 1)]
		[Export ("showsQuadCount")]
		bool ShowsQuadCount { get; set; }

		[MacCatalyst (13, 1)]
		[Export ("textureFromNode:crop:")]
		[return: NullAllowed]
		SKTexture TextureFromNode (SKNode node, CGRect crop);

		[MacCatalyst (13, 1)]
		[Export ("preferredFramesPerSecond")]
		nint PreferredFramesPerSecond { get; set; }

		[MacCatalyst (13, 1)]
		[NullAllowed, Export ("delegate", ArgumentSemantic.Weak)]
		ISKViewDelegate Delegate { get; set; }

		[iOS (14, 0)]
		[TV (14, 0)]
		[MacCatalyst (14, 0)]
		[Export ("disableDepthStencilBuffer")]
		bool DisableDepthStencilBuffer { get; set; }
	}

	interface ISKViewDelegate { }

	/// <summary>Delegate object for <see cref="SpriteKit.SKView" /> objects, allowing the developer to control the frame rate.</summary>
	///     
	///     <related type="externalDocumentation" href="https://developer.apple.com/reference/SpriteKit/SKViewDelegate">Apple documentation for <c>SKViewDelegate</c></related>
	[MacCatalyst (13, 1)]
	[Protocol, Model]
	[BaseType (typeof (NSObject))]
	interface SKViewDelegate {
		/// <param name="view">The view to render into.</param>
		/// <param name="time">The time at which to render.</param>
		/// <summary>Renders the scene at the specified time.</summary>
		/// <returns>The rendered image.</returns>
		
		[Export ("view:shouldRenderAtTime:")]
		bool ShouldRender (SKView view, double time);
	}

	/// <summary>Transitions that can be used between <see cref="SpriteKit.SKScene" />s. Used with the <see cref="SpriteKit.SKView.PresentScene(SpriteKit.SKScene,SpriteKit.SKTransition)" /> method.</summary>
	///     
	///     <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/SpriteKit/Reference/SKTransition_Ref/index.html">Apple documentation for <c>SKTransition</c></related>
	[MacCatalyst (13, 1)]
	[BaseType (typeof (NSObject))]
	[DisableDefaultCtor]
	partial interface SKTransition : NSCopying {

		[Static, Export ("crossFadeWithDuration:")]
		SKTransition CrossFadeWithDuration (double sec);

		[Static, Export ("fadeWithDuration:")]
		SKTransition FadeWithDuration (double sec);

		[Static, Export ("fadeWithColor:duration:")]
		SKTransition FadeWithColor (UIColor color, double sec);

		[Static, Export ("flipHorizontalWithDuration:")]
		SKTransition FlipHorizontalWithDuration (double sec);

		[Static, Export ("flipVerticalWithDuration:")]
		SKTransition FlipVerticalWithDuration (double sec);

		[Static, Export ("revealWithDirection:duration:")]
		SKTransition RevealWithDirection (SKTransitionDirection direction, double sec);

		[Static, Export ("moveInWithDirection:duration:")]
		SKTransition MoveInWithDirection (SKTransitionDirection direction, double sec);

		[Static, Export ("pushWithDirection:duration:")]
		SKTransition PushWithDirection (SKTransitionDirection direction, double sec);

		[Static, Export ("doorsOpenHorizontalWithDuration:")]
		SKTransition DoorsOpenHorizontalWithDuration (double sec);

		[Static, Export ("doorsOpenVerticalWithDuration:")]
		SKTransition DoorsOpenVerticalWithDuration (double sec);

		[Static, Export ("doorsCloseHorizontalWithDuration:")]
		SKTransition DoorsCloseHorizontalWithDuration (double sec);

		[Static, Export ("doorsCloseVerticalWithDuration:")]
		SKTransition DoorsCloseVerticalWithDuration (double sec);

		[Static, Export ("doorwayWithDuration:")]
		SKTransition DoorwayWithDuration (double sec);

		[MacCatalyst (13, 1)]
		[Static, Export ("transitionWithCIFilter:duration:")]
		SKTransition TransitionWithCIFilter (CIFilter filter, double sec);

		[Export ("pausesIncomingScene")]
		bool PausesIncomingScene { get; set; }

		[Export ("pausesOutgoingScene")]
		bool PausesOutgoingScene { get; set; }
	}

	/// <summary>An image that can be used with one or more <see cref="SpriteKit.SKSpriteNode" />s and particles.</summary>
	///     <remarks>
	///       <para>Sprite Kit attempts to be efficient with the memory associated with textures. Textures are lazy-loaded from their source files and in preparation for loading onto the graphics hardware. This lazy-loading can be overridden with the <c>Preload*</c> methods.</para>
	///     </remarks>
	///     
	///     <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/SpriteKit/Reference/SKTexture_Ref/index.html">Apple documentation for <c>SKTexture</c></related>
	[MacCatalyst (13, 1)]
	[BaseType (typeof (NSObject))]
	[DisableDefaultCtor]
	partial interface SKTexture : NSSecureCoding, NSCopying {

		[Static, Export ("textureWithImageNamed:")]
		SKTexture FromImageNamed (string name);

		[Static, Export ("textureWithRect:inTexture:")]
		SKTexture FromRectangle (CGRect rect, SKTexture texture);

		[Static, Export ("textureWithCGImage:")]
		SKTexture FromImage (CGImage image);

		[Static, Export ("textureWithImage:")]
		SKTexture FromImage (UIImage image);

		[Static, Export ("textureWithData:size:")]
		SKTexture FromData (NSData pixelData, CGSize size);

		[Static, Export ("textureWithData:size:rowLength:alignment:")]
		SKTexture FromData (NSData pixelData, CGSize size, uint /* unsigned int*/ rowLength, uint /* unsigned int */ alignment);

		[MacCatalyst (13, 1)]
		[Export ("textureByApplyingCIFilter:")]
		SKTexture TextureByApplyingCIFilter (CIFilter filter);

		[Export ("textureRect")]
		CGRect TextureRect { get; }

		[Export ("size")]
		CGSize Size { get; }

		[Export ("filteringMode")]
		SKTextureFilteringMode FilteringMode { get; set; }

		[Export ("usesMipmaps")]
		bool UsesMipmaps { get; set; }

		[Static]
		[Export ("preloadTextures:withCompletionHandler:")]
		[Async (XmlDocs = """
			<param name="textures">The textures to preload.</param>
			<summary>Asynchronously loads the textures into memory.</summary>
			<returns>A task that represents the asynchronous PreloadTextures operation</returns>
			<remarks>Preloading textures improves rendering performance.</remarks>
			""")]
		// note: unlike SKTextureAtlas completion can't be null (or it crash)
		void PreloadTextures (SKTexture [] textures, Action completion);

		[Export ("preloadWithCompletionHandler:")]
		[Async (XmlDocs = """
			<summary>Asynchronously loads the texture into memory.</summary>
			<returns>A task that represents the asynchronous Preload operation</returns>
			<remarks>
			          <para copied="true">The PreloadAsync method is suitable to be used with C# async by returning control to the caller with a Task representing the operation.</para>
			          <para>This async method returns a Task representing the operation.</para>
			        </remarks>
			""")]
		// note: unlike SKTextureAtlas completion can't be null (or it crash)
		void Preload (Action completion);

		[MacCatalyst (13, 1)]
		[Export ("textureByGeneratingNormalMap")]
		SKTexture CreateTextureByGeneratingNormalMap ();

		/// <param name="smoothness">The smoothness of the noise (0.0 to 1.0).</param>
		/// <param name="contrast">The contrast of the noise.</param>
		/// <summary>Creates a new texture from the texture, smoothing the texture values before processing and magnifying the contrast of the resulting normal map.</summary>
		/// <returns>A new noise texture.</returns>
		
		[MacCatalyst (13, 1)]
		[Export ("textureByGeneratingNormalMapWithSmoothness:contrast:")]
		SKTexture CreateTextureByGeneratingNormalMap (nfloat smoothness, nfloat contrast);

		/// <param name="smoothness">The smoothness of the noise (0.0 to 1.0).</param>
		/// <param name="size">The size of the texture.</param>
		/// <summary>Creates a texture that consists of randomized directional noise data, with the RGB values comprising a direction vector, and the alpha channel representing a magnitude.</summary>
		/// <returns>A new noise texture with the specified size.</returns>
		
		[MacCatalyst (13, 1)]
		[Static, Export ("textureVectorNoiseWithSmoothness:size:")]
		SKTexture FromTextureVectorNoise (nfloat smoothness, CGSize size);

		/// <param name="smoothness">The smoothness of the noise (0.0 to 1.0).</param>
		/// <param name="size">The size of the texture.</param>
		/// <param name="grayscale">Whether to generate a grayscale texture.</param>
		/// <summary>Creates a noise texture with the specified smoothness, size, and color mode.</summary>
		/// <returns>A new noise texture.</returns>
		
		[MacCatalyst (13, 1)]
		[Static, Export ("textureNoiseWithSmoothness:size:grayscale:")]
		SKTexture FromTextureNoise (nfloat smoothness, CGSize size, bool grayscale);

		[MacCatalyst (13, 1)]
		[Static, Export ("textureWithData:size:flipped:")]
		SKTexture FromData (NSData pixelData, CGSize size, bool flipped);

		[MacCatalyst (13, 1)]
		[Export ("CGImage")]
		CGImage CGImage { get; }

		// Static Category from GameplayKit
		/// <param name="noiseMap">The noise map to generate the texture from.</param>
		/// <summary>Creates a texture from a noise map.</summary>
		/// <returns>A new texture generated from the noise map.</returns>
		[MacCatalyst (13, 1)]
		[Static]
		[Export ("textureWithNoiseMap:")]
		SKTexture FromNoiseMap (GKNoiseMap noiseMap);
	}

	/// <summary>A method that modifies a texture in place.</summary>
	delegate void SKTextureModify (IntPtr pixelData, nuint lengthInBytes);

	/// <summary>A texture that can be modified after assignment.</summary>
	///     
	///     <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/SpriteKit/Reference/SKMutableTexture_Ref/index.html">Apple documentation for <c>SKMutableTexture</c></related>
	[MacCatalyst (13, 1)]
	[BaseType (typeof (SKTexture))]
	[DisableDefaultCtor] // cannot be created (like SKTexture) by calling `init`
	interface SKMutableTexture {
		[Export ("initWithSize:")]
		NativeHandle Constructor (CGSize size);

		[Export ("initWithSize:pixelFormat:")]
		NativeHandle Constructor (CGSize size, CVPixelFormatType pixelFormat);

		[Static, Export ("mutableTextureWithSize:")]
		SKMutableTexture Create (CGSize size);

		[Export ("modifyPixelDataWithBlock:")]
		void ModifyPixelData (SKTextureModify modifyMethod);
	}

	delegate void SKTextureAtlasLoadCallback ([NullAllowed] NSError error, SKTextureAtlas foundAtlases);

	/// <summary>A collection of <see cref="SpriteKit.SKTexture" />s that are loaded from a single source.</summary>
	///     
	///     <!-- TODO: These can be created in XCode. Can we load them? Sample code or at least discussion. -->
	///     <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/SpriteKit/Reference/SKTextureAtlas/index.html">Apple documentation for <c>SKTextureAtlas</c></related>
	[MacCatalyst (13, 1)]
	[BaseType (typeof (NSObject))]
	partial interface SKTextureAtlas : NSSecureCoding {

		[Static, Export ("atlasNamed:")]
		SKTextureAtlas FromName (string name);

		[Export ("textureNamed:")]
		SKTexture TextureNamed (string name);

		[Export ("textureNames")]
		string [] TextureNames { get; }

		[Static]
		[Export ("preloadTextureAtlases:withCompletionHandler:")]
		[Async (XmlDocs = """
			<param name="textures">The textures to preload.</param>
			<summary>Asynchronously preloads the specified list of texture atlases.</summary>
			<returns>A task that represents the asynchronous PreloadTextures operation</returns>
			<remarks>Preloading textures improves rendering performance.</remarks>
			""")]
		// Unfortunate name, should have been PreloadTextureAtlases
		void PreloadTextures (SKTextureAtlas [] textures, Action completion);

		[MacCatalyst (13, 1)]
		[Static]
		[Export ("preloadTextureAtlasesNamed:withCompletionHandler:")]
		[Async (ResultTypeName = "SKTextureAtlasLoadResult", XmlDocs = """
			<param name="atlasNames">The names of the atlases to preload.</param>
			<summary>Loads the named atlases and calls a completion handler after they are loaded.</summary>
			<returns>
			          <para>A task that represents the asynchronous PreloadTextureAtlases operation.   The value of the TResult parameter is of type <c>Action&lt;SpriteKit.SKTextureAtlasLoadResult&gt;</c>.</para>
			        </returns>
			<remarks>Preloading texture atlases improves rendering performance.</remarks>
			""")]
		void PreloadTextureAtlases (string [] atlasNames, SKTextureAtlasLoadCallback completionHandler);

		[Export ("preloadWithCompletionHandler:")]
		[Async (XmlDocs = """
			<summary>Asynchronously preloads the texture atlas.</summary>
			<returns>A task that represents the asynchronous Preload operation</returns>
			<remarks>
			          <para copied="true">The PreloadAsync method is suitable to be used with C# async by returning control to the caller with a Task representing the operation.</para>
			          <para>This async method returns a Task representing the operation.</para>
			        </remarks>
			""")]
		void Preload (Action completion);

		[MacCatalyst (13, 1)]
		[Static, Export ("atlasWithDictionary:")]
		SKTextureAtlas FromDictionary (NSDictionary properties);

	}

	/// <summary>Holds shareable uniform data for SKShader objects.</summary>
	///     
	///     <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/SpriteKit/Reference/SKUniform_Ref/index.html">Apple documentation for <c>SKUniform</c></related>
	[MacCatalyst (13, 1)]
	[BaseType (typeof (NSObject))]
	interface SKUniform : NSCopying, NSSecureCoding {
		[Export ("initWithName:")]
		NativeHandle Constructor (string name);

		[Export ("initWithName:texture:")]
		NativeHandle Constructor (string name, [NullAllowed] SKTexture texture);

		[Export ("initWithName:float:")]
		NativeHandle Constructor (string name, float /* float, not CGFloat */ value);

		[Export ("initWithName:vectorFloat2:")]
		[MarshalDirective (NativePrefix = "xamarin_simd__", Library = "__Internal")]
		NativeHandle Constructor (string name, Vector2 value);

		[Export ("initWithName:vectorFloat3:")]
		[MarshalDirective (NativePrefix = "xamarin_simd__", Library = "__Internal")]
		NativeHandle Constructor (string name, Vector3 value);

		[Export ("initWithName:vectorFloat4:")]
		[MarshalDirective (NativePrefix = "xamarin_simd__", Library = "__Internal")]
		NativeHandle Constructor (string name, Vector4 value);

		[MacCatalyst (13, 1)]
		[Export ("initWithName:matrixFloat2x2:")]
		[MarshalDirective (NativePrefix = "xamarin_simd__", Library = "__Internal")]
		NativeHandle Constructor (string name, MatrixFloat2x2 value);

		[MacCatalyst (13, 1)]
		[Export ("initWithName:matrixFloat3x3:")]
		[MarshalDirective (NativePrefix = "xamarin_simd__", Library = "__Internal")]
		NativeHandle Constructor (string name, MatrixFloat3x3 value);

		[MacCatalyst (13, 1)]
		[Export ("initWithName:matrixFloat4x4:")]
		[MarshalDirective (NativePrefix = "xamarin_simd__", Library = "__Internal")]
		NativeHandle Constructor (string name, MatrixFloat4x4 value);

		[Export ("name")]
		string Name { get; }

		[Export ("uniformType")]
		SKUniformType UniformType { get; }

		[Export ("textureValue")]
		[NullAllowed]
		SKTexture TextureValue { get; set; }

		[Export ("floatValue")]
		float FloatValue { get; set; } /* float, not CGFloat */

		[MacCatalyst (13, 1)]
		[Export ("vectorFloat2Value", ArgumentSemantic.Assign)]
		Vector2 FloatVector2Value {
			[MarshalDirective (NativePrefix = "xamarin_simd__", Library = "__Internal")]
			get;
			[MarshalDirective (NativePrefix = "xamarin_simd__", Library = "__Internal")]
			set;
		}

		[MacCatalyst (13, 1)]
		[Export ("vectorFloat3Value", ArgumentSemantic.Assign)]
		Vector3 FloatVector3Value {
			[MarshalDirective (NativePrefix = "xamarin_simd__", Library = "__Internal")]
			get;
			[MarshalDirective (NativePrefix = "xamarin_simd__", Library = "__Internal")]
			set;
		}

		[MacCatalyst (13, 1)]
		[Export ("vectorFloat4Value", ArgumentSemantic.Assign)]
		Vector4 FloatVector4Value {
			[MarshalDirective (NativePrefix = "xamarin_simd__", Library = "__Internal")]
			get;
			[MarshalDirective (NativePrefix = "xamarin_simd__", Library = "__Internal")]
			set;
		}

		[MacCatalyst (13, 1)]
		[Export ("matrixFloat2x2Value", ArgumentSemantic.Assign)]
		MatrixFloat2x2 MatrixFloat2x2Value {
			[MarshalDirective (NativePrefix = "xamarin_simd__", Library = "__Internal")]
			get;
			[MarshalDirective (NativePrefix = "xamarin_simd__", Library = "__Internal")]
			set;
		}

		[MacCatalyst (13, 1)]
		[Export ("matrixFloat3x3Value", ArgumentSemantic.Assign)]
		MatrixFloat3x3 MatrixFloat3x3Value {
			[MarshalDirective (NativePrefix = "xamarin_simd__", Library = "__Internal")]
			get;
			[MarshalDirective (NativePrefix = "xamarin_simd__", Library = "__Internal")]
			set;
		}

		[MacCatalyst (13, 1)]
		[Export ("matrixFloat4x4Value", ArgumentSemantic.Assign)]
		MatrixFloat4x4 MatrixFloat4x4Value {
			[MarshalDirective (NativePrefix = "xamarin_simd__", Library = "__Internal")]
			get;
			[MarshalDirective (NativePrefix = "xamarin_simd__", Library = "__Internal")]
			set;
		}

		[Static, Export ("uniformWithName:")]
		SKUniform Create (string name);

		[Static, Export ("uniformWithName:texture:")]
		SKUniform Create (string name, [NullAllowed] SKTexture texture);

		[Static, Export ("uniformWithName:float:")]
		SKUniform Create (string name, float /* float, not CGFloat */ value);

		[MacCatalyst (13, 1)]
		[Static]
		[Export ("uniformWithName:vectorFloat2:")]
		[MarshalDirective (NativePrefix = "xamarin_simd__", Library = "__Internal")]
		[MarshalNativeExceptions]
		SKUniform Create (string name, Vector2 value);

		[MacCatalyst (13, 1)]
		[Static]
		[Export ("uniformWithName:vectorFloat3:")]
		[MarshalDirective (NativePrefix = "xamarin_simd__", Library = "__Internal")]
		SKUniform Create (string name, Vector3 value);

		[MacCatalyst (13, 1)]
		[Static]
		[Export ("uniformWithName:vectorFloat4:")]
		[MarshalDirective (NativePrefix = "xamarin_simd__", Library = "__Internal")]
		SKUniform Create (string name, Vector4 value);

		[MacCatalyst (13, 1)]
		[Static]
		[Export ("uniformWithName:matrixFloat2x2:")]
		[MarshalDirective (NativePrefix = "xamarin_simd__", Library = "__Internal")]
		SKUniform Create (string name, MatrixFloat2x2 value);

		[MacCatalyst (13, 1)]
		[Static]
		[Export ("uniformWithName:matrixFloat3x3:")]
		[MarshalDirective (NativePrefix = "xamarin_simd__", Library = "__Internal")]
		SKUniform Create (string name, MatrixFloat3x3 value);

		[MacCatalyst (13, 1)]
		[Static]
		[Export ("uniformWithName:matrixFloat4x4:")]
		[MarshalDirective (NativePrefix = "xamarin_simd__", Library = "__Internal")]
		SKUniform Create (string name, MatrixFloat4x4 value);
	}

	/// <summary>The delegate for a custom action, used with <see cref="SpriteKit.SKAction.CustomActionWithDuration(System.Double,SpriteKit.SKActionDurationHandler)" />.</summary>
	delegate void SKActionDurationHandler (SKNode node, nfloat elapsedTime);

	/// <include file="../docs/api/SpriteKit/SKAction.xml" path="/Documentation/Docs[@DocId='T:SpriteKit.SKAction']/*" />
	[MacCatalyst (13, 1)]
	[BaseType (typeof (NSObject))]
	[DisableDefaultCtor] // <quote>To create an action, call the class method for the action you are interested in. </quote>
	partial interface SKAction : NSSecureCoding, NSCopying {

		[Export ("duration")]
		double Duration { get; set; }

		[Export ("timingMode")]
		SKActionTimingMode TimingMode { get; set; }

		[Export ("speed")]
		nfloat Speed { get; set; }

		[Export ("reversedAction")]
		SKAction ReversedAction { get; }

		// These are in a category
		/// <param name="deltaX">The horizontal distance to move.</param>
		/// <param name="deltaY">The vertical distance to move.</param>
		/// <param name="sec">The duration of the action in seconds.</param>
		/// <summary>Creates an action that moves a node by a relative amount.</summary>
		/// <returns>A new move action.</returns>
		
		[Static, Export ("moveByX:y:duration:")]
		SKAction MoveBy (nfloat deltaX, nfloat deltaY, double sec);

		[Static, Export ("moveBy:duration:")]
		SKAction MoveBy (CGVector delta, double duration);

		[Static, Export ("moveTo:duration:")]
		SKAction MoveTo (CGPoint location, double sec);

		/// <param name="x">The new x-coordinate.</param>
		/// <param name="sec">The duration of the action in seconds.</param>
		/// <summary>Creates an action that moves a node horizontally to a new position.</summary>
		/// <returns>A new move action.</returns>
		
		[Static, Export ("moveToX:duration:")]
		SKAction MoveToX (nfloat x, double sec);

		/// <param name="y">The new y-coordinate.</param>
		/// <param name="sec">The duration of the action in seconds.</param>
		/// <summary>Creates an action that moves a node vertically to a new position.</summary>
		/// <returns>A new move action.</returns>
		
		[Static, Export ("moveToY:duration:")]
		SKAction MoveToY (nfloat y, double sec);

		/// <param name="radians">The angle to rotate by in radians.</param>
		/// <param name="sec">The duration of the action in seconds.</param>
		/// <summary>Creates an action that rotates a node by a relative angle.</summary>
		/// <returns>A new rotation action.</returns>
		
		[Static, Export ("rotateByAngle:duration:")]
		SKAction RotateByAngle (nfloat radians, double sec);

		/// <param name="radians">The absolute angle to rotate to in radians.</param>
		/// <param name="sec">The duration of the action in seconds.</param>
		/// <summary>Creates an action that rotates a node to an absolute angle.</summary>
		/// <returns>A new rotation action.</returns>
		
		[Static, Export ("rotateToAngle:duration:")]
		SKAction RotateToAngle (nfloat radians, double sec);

		/// <param name="radians">The absolute angle to rotate to in radians.</param>
		/// <param name="sec">The duration of the action in seconds.</param>
		/// <param name="shortedUnitArc">Whether to rotate using the shortest arc.</param>
		/// <summary>Creates an action that rotates to an angle using the shortest arc.</summary>
		/// <returns>A new rotation action.</returns>
		
		[Static, Export ("rotateToAngle:duration:shortestUnitArc:")]
		SKAction RotateToAngle (nfloat radians, double sec, bool shortedUnitArc);

		/// <param name="width">The new width.</param>
		/// <param name="height">The new height.</param>
		/// <param name="duration">The duration of the action in seconds.</param>
		/// <summary>Creates an action that resizes a node to a new size.</summary>
		/// <returns>A new resize action.</returns>
		
		[Static, Export ("resizeByWidth:height:duration:")]
		SKAction ResizeByWidth (nfloat width, nfloat height, double duration);

		/// <param name="width">The width change.</param>
		/// <param name="height">The height change.</param>
		/// <param name="duration">The duration of the action in seconds.</param>
		/// <summary>Creates an action that resizes a node by a relative amount.</summary>
		/// <returns>A new resize action.</returns>
		
		[Static, Export ("resizeToWidth:height:duration:")]
		SKAction ResizeTo (nfloat width, nfloat height, double duration);

		/// <param name="width">The new width.</param>
		/// <param name="duration">The duration of the action in seconds.</param>
		/// <summary>Creates an action that resizes the width to a specific value.</summary>
		/// <returns>A new resize action.</returns>
		
		[Static, Export ("resizeToWidth:duration:")]
		SKAction ResizeToWidth (nfloat width, double duration);

		/// <param name="height">The new height.</param>
		/// <param name="duration">The duration of the action in seconds.</param>
		/// <summary>Creates an action that resizes the height to a specific value.</summary>
		/// <returns>A new resize action.</returns>
		
		[Static, Export ("resizeToHeight:duration:")]
		SKAction ResizeToHeight (nfloat height, double duration);

		/// <param name="scale">The absolute scale factor.</param>
		/// <param name="sec">The duration of the action in seconds.</param>
		/// <summary>Creates an action that scales a node to a specific value.</summary>
		/// <returns>A new scale action.</returns>
		
		[Static, Export ("scaleBy:duration:")]
		SKAction ScaleBy (nfloat scale, double sec);

		/// <param name="xScale">The absolute x scale factor.</param>
		/// <param name="yScale">The absolute y scale factor.</param>
		/// <param name="sec">The duration of the action in seconds.</param>
		/// <summary>Creates an action that scales a node to specific x and y values.</summary>
		/// <returns>A new scale action.</returns>
		
		[Static, Export ("scaleXBy:y:duration:")]
		SKAction ScaleBy (nfloat xScale, nfloat yScale, double sec);

		/// <param name="scale">The relative scale factor.</param>
		/// <param name="sec">The duration of the action in seconds.</param>
		/// <summary>Creates an action that scales a node by a relative amount.</summary>
		/// <returns>A new scale action.</returns>
		
		[Static, Export ("scaleTo:duration:")]
		SKAction ScaleTo (nfloat scale, double sec);

		/// <param name="xScale">The relative x scale factor.</param>
		/// <param name="yScale">The relative y scale factor.</param>
		/// <param name="sec">The duration of the action in seconds.</param>
		/// <summary>Creates an action that scales x and y by relative amounts.</summary>
		/// <returns>A new scale action.</returns>
		
		[Static, Export ("scaleXTo:y:duration:")]
		SKAction ScaleTo (nfloat xScale, nfloat yScale, double sec);

		/// <param name="scale">The absolute scale factor.</param>
		/// <param name="sec">The duration of the action in seconds.</param>
		/// <summary>Creates an action that scales the x component to a specific value.</summary>
		/// <returns>A new scale action.</returns>
		
		[Static, Export ("scaleXTo:duration:")]
		SKAction ScaleXTo (nfloat scale, double sec);

		/// <param name="scale">The absolute scale factor.</param>
		/// <param name="sec">The duration of the action in seconds.</param>
		/// <summary>Creates an action that scales the y component to a specific value.</summary>
		/// <returns>A new scale action.</returns>
		
		[Static, Export ("scaleYTo:duration:")]
		SKAction ScaleYTo (nfloat scale, double sec);

		[MacCatalyst (13, 1)]
		[Static]
		[Export ("scaleToSize:duration:")]
		SKAction ScaleTo (CGSize size, double sec);

		[Static, Export ("sequence:")]
		SKAction Sequence ([Params] SKAction [] actions);

		[Static, Export ("group:")]
		SKAction Group ([Params] SKAction [] actions);

		/// <param name="action">The action to repeat.</param>
		/// <param name="count">The number of times to repeat the action.</param>
		/// <summary>Creates an action that repeats <paramref name="action" /> a specified number of times on the node on which it is run.</summary>
		/// <returns>A new action that repeats the specified action.</returns>
		
		[Static, Export ("repeatAction:count:")]
		SKAction RepeatAction (SKAction action, nuint count);

		[Static, Export ("repeatActionForever:")]
		SKAction RepeatActionForever (SKAction action);

		[Static, Export ("fadeInWithDuration:")]
		SKAction FadeInWithDuration (double sec);

		[Static, Export ("fadeOutWithDuration:")]
		SKAction FadeOutWithDuration (double sec);

		/// <param name="factor">The amount to change the alpha by.</param>
		/// <param name="sec">The duration of the action in seconds.</param>
		/// <summary>Creates an action that adjusts the alpha by a relative amount.</summary>
		/// <returns>A new fade action.</returns>
		
		[Static, Export ("fadeAlphaBy:duration:")]
		SKAction FadeAlphaBy (nfloat factor, double sec);

		/// <param name="alpha">The target alpha value (0.0 to 1.0).</param>
		/// <param name="sec">The duration of the action in seconds.</param>
		/// <summary>Creates an action that fades the alpha to a specific value.</summary>
		/// <returns>A new fade action.</returns>
		
		[Static, Export ("fadeAlphaTo:duration:")]
		SKAction FadeAlphaTo (nfloat alpha, double sec);

		[MacCatalyst (13, 1)]
		[Static, Export ("setTexture:")]
		SKAction SetTexture (SKTexture texture);

		[MacCatalyst (13, 1)]
		[Static, Export ("setTexture:resize:")]
		SKAction SetTexture (SKTexture texture, bool resize);

		[Static, Export ("animateWithTextures:timePerFrame:")]
		SKAction AnimateWithTextures (SKTexture [] textures, double sec);

		[Static, Export ("animateWithTextures:timePerFrame:resize:restore:")]
		SKAction AnimateWithTextures (SKTexture [] textures, double sec, bool resize, bool restore);

		[Static, Export ("playSoundFileNamed:waitForCompletion:")]
		SKAction PlaySoundFileNamed (string soundFile, bool wait);

		/// <param name="color">The target color.</param>
		/// <param name="colorBlendFactor">The target color blend factor (0.0 to 1.0).</param>
		/// <param name="sec">The duration of the action in seconds.</param>
		/// <summary>Creates an action that animates a color change.</summary>
		/// <returns>A new colorize action.</returns>
		
		[Static, Export ("colorizeWithColor:colorBlendFactor:duration:")]
		SKAction ColorizeWithColor (UIColor color, nfloat colorBlendFactor, double sec);

		/// <param name="colorBlendFactor">The target color blend factor (0.0 to 1.0).</param>
		/// <param name="sec">The duration of the action in seconds.</param>
		/// <summary>Creates an action that animates the color blend factor.</summary>
		/// <returns>A new colorize action.</returns>
		
		[Static, Export ("colorizeWithColorBlendFactor:duration:")]
		SKAction ColorizeWithColorBlendFactor (nfloat colorBlendFactor, double sec);

		[Static, Export ("followPath:duration:")]
		SKAction FollowPath (CGPath path, double sec);

		[Static, Export ("followPath:asOffset:orientToPath:duration:")]
#if XAMCORE_5_0
		SKAction FollowPath (CGPath path, bool offset, bool orientToPath, double sec);
#else
		SKAction FollowPath (CGPath path, bool offset, bool orient, double sec);
#endif

		/// <param name="path">The CGPath to follow.</param>
		/// <param name="speed">The speed at which to follow the path.</param>
		/// <summary>Creates an action that moves the <see cref="SpriteKit.SKNode" /> on which it is run over the <paramref name="path" />, at the specified <paramref name="speed" />.</summary>
		/// <returns>A new path-following action.</returns>
		
		[MacCatalyst (13, 1)]
		[Static, Export ("followPath:speed:")]
		SKAction FollowPath (CGPath path, nfloat speed);

		/// <param name="path">The CGPath to follow.</param>
		/// <param name="offset">Whether to use the path as an offset from the current position.</param>
		/// <param name="orient">Whether to orient the node to the path direction.</param>
		/// <param name="speed">The speed at which to follow the path.</param>
		/// <summary>Creates an action that moves the <see cref="SpriteKit.SKNode" /> on which it is run over the <paramref name="path" />, with the specified offset, orientation, and speed.</summary>
		/// <returns>A new path-following action.</returns>
		
		[MacCatalyst (13, 1)]
		[Static, Export ("followPath:asOffset:orientToPath:speed:")]
#if XAMCORE_5_0
		SKAction FollowPath (CGPath path, bool offset, bool orientToPath, nfloat speed);
#else
		SKAction FollowPath (CGPath path, bool offset, bool orient, nfloat speed);
#endif

		/// <param name="speed">The target playback speed.</param>
		/// <param name="sec">The duration of the action in seconds.</param>
		/// <summary>Creates an action that changes the playback speed of an action.</summary>
		/// <returns>A new speed adjustment action.</returns>
		
		[Static, Export ("speedBy:duration:")]
		SKAction SpeedBy (nfloat speed, double sec);

		/// <param name="speed">The target playback speed.</param>
		/// <param name="sec">The duration of the action in seconds.</param>
		/// <summary>Creates an action that changes the playback speed to a specific value.</summary>
		/// <returns>A new speed adjustment action.</returns>
		
		[Static, Export ("speedTo:duration:")]
		SKAction SpeedTo (nfloat speed, double sec);

		[Static, Export ("waitForDuration:")]
		SKAction WaitForDuration (double sec);

		[Static, Export ("waitForDuration:withRange:")]
		SKAction WaitForDuration (double sec, double durationRange);

		[Static, Export ("removeFromParent")]
		SKAction RemoveFromParent ();

		[Static, Export ("performSelector:onTarget:")]
		SKAction PerformSelector (Selector selector, NSObject target);

		[Static, Export ("runBlock:")]
		SKAction Run (Action block);

		[Static, Export ("runBlock:queue:")]
		SKAction Run (Action block, DispatchQueue queue);

		[Static, Export ("runAction:onChildWithName:")]
		SKAction RunAction (SKAction action, string name);

		[Static, Export ("customActionWithDuration:actionBlock:")]
		SKAction CustomActionWithDuration (double seconds, SKActionDurationHandler actionHandler);

		//
		// iOS 8 cluster (a few more are above, as part of their family
		//
		[MacCatalyst (13, 1)]
		[Static, Export ("hide")]
		SKAction Hide ();

		[MacCatalyst (13, 1)]
		[Static, Export ("unhide")]
		SKAction Unhide ();

		[MacCatalyst (13, 1)]
		[Static, Export ("reachTo:rootNode:duration:")]
		SKAction ReachTo (CGPoint position, SKNode rootNode, double secs);

		/// <param name="position">The target position to reach.</param>
		/// <param name="rootNode">The root node of the scene.</param>
		/// <param name="velocity">The velocity in points per second.</param>
		/// <summary>Creates an action that moves a node toward a position.</summary>
		/// <returns>A new reach action.</returns>
		
		[MacCatalyst (13, 1)]
		[Static, Export ("reachTo:rootNode:velocity:")]
		SKAction ReachTo (CGPoint position, SKNode rootNode, nfloat velocity);

		[MacCatalyst (13, 1)]
		[Static, Export ("reachToNode:rootNode:duration:")]
		SKAction ReachToNode (SKNode node, SKNode rootNode, double sec);

		/// <param name="node">The target node to reach.</param>
		/// <param name="rootNode">The root node of the scene.</param>
		/// <param name="velocity">The velocity in points per second.</param>
		/// <summary>Creates an action that moves the node to which it is applied by rotating it, along with all nodes between it and <paramref name="rootNode" />, so that it is closer to <paramref name="node" />, in a way that moves the node at the speed that is specified by <paramref name="velocity" />.</summary>
		/// <returns>A new reach action.</returns>
		
		[MacCatalyst (13, 1)]
		[Static, Export ("reachToNode:rootNode:velocity:")]
		SKAction ReachToNode (SKNode node, SKNode rootNode, nfloat velocity);

		[MacCatalyst (13, 1)]
		[Static, Export ("strengthTo:duration:")]
		SKAction StrengthTo (float /* float, not CGFloat */ strength, double sec);

		[MacCatalyst (13, 1)]
		[Static, Export ("strengthBy:duration:")]
		SKAction StrengthBy (float /* float, not CGFloat */ strength, double sec);

		/// <summary>Sets the function that transforms the times at which actions occur.</summary>
		[MacCatalyst (13, 1)]
		[NullAllowed, Export ("timingFunction", ArgumentSemantic.Assign)]
#if XAMCORE_5_0
		SKActionTimingFunction TimingFunction { get; set; }
#else
		[Obsolete ("Use 'TimingFunction' instead.")]
		SKActionTimingFunction2 TimingFunction2 { get; set; }
#endif

#if !XAMCORE_5_0
		/// <summary>Sets the function that transforms the times at which actions occur.</summary>
		[MacCatalyst (13, 1)]
		[NullAllowed, Export ("timingFunction", ArgumentSemantic.Assign)]
		[Sealed]
		SKActionTimingFunction TimingFunction { get; set; }
#endif

		[MacCatalyst (13, 1)]
		[Static, Export ("falloffBy:duration:")]
		SKAction FalloffBy (float /* float, not CGFloat */ to, double duration);

		[MacCatalyst (13, 1)]
		[Static]
		[Export ("falloffTo:duration:")]
		SKAction FalloffTo (float falloff, double sec);

		// iOS 9 cluster
		[MacCatalyst (13, 1)]
		[Static]
		[Export ("actionNamed:")]
		[return: NullAllowed]
		SKAction Create (string name);

		[MacCatalyst (13, 1)]
		[Static]
		[Export ("actionNamed:duration:")]
		[return: NullAllowed]
		SKAction Create (string name, double duration);

		[MacCatalyst (13, 1)]
		[Static]
		[Export ("actionNamed:fromURL:")]
		[return: NullAllowed]
		SKAction Create (string name, NSUrl url);

		[MacCatalyst (13, 1)]
		[Static]
		[Export ("actionNamed:fromURL:duration:")]
		[return: NullAllowed]
		SKAction Create (string name, NSUrl url, double duration);

		[MacCatalyst (13, 1)]
		[Static]
		[Export ("setNormalTexture:")]
		SKAction SetNormalTexture (SKTexture texture);

		[MacCatalyst (13, 1)]
		[Static]
		[Export ("setNormalTexture:resize:")]
		SKAction SetNormalTexture (SKTexture texture, bool resize);

		[MacCatalyst (13, 1)]
		[Static]
		[Export ("animateWithNormalTextures:timePerFrame:")]
		SKAction AnimateWithNormalTextures (SKTexture [] textures, double secondsPerFrame);

		[MacCatalyst (13, 1)]
		[Static]
		[Export ("animateWithNormalTextures:timePerFrame:resize:restore:")]
		SKAction AnimateWithNormalTextures (SKTexture [] textures, double secondsPerFrame, bool resize, bool restore);

		[MacCatalyst (13, 1)]
		[Static]
		[Export ("play")]
		SKAction CreatePlay ();

		[MacCatalyst (13, 1)]
		[Static]
		[Export ("pause")]
		SKAction CreatePause ();

		[MacCatalyst (13, 1)]
		[Static]
		[Export ("stop")]
		SKAction CreateStop ();

		[MacCatalyst (13, 1)]
		[Static]
		[Export ("changePlaybackRateTo:duration:")]
		SKAction CreateChangePlaybackRate (float playbackRate, double duration);

		[MacCatalyst (13, 1)]
		[Static]
		[Export ("changePlaybackRateBy:duration:")]
		SKAction CreateChangePlaybackRateBy (float playbackRate, double duration);

		[MacCatalyst (13, 1)]
		[Static]
		[Export ("changeVolumeTo:duration:")]
		SKAction CreateChangeVolume (float newVolume, double duration);

		[MacCatalyst (13, 1)]
		[Static]
		[Export ("changeVolumeBy:duration:")]
		SKAction CreateChangeVolumeBy (float by, double duration);

		[MacCatalyst (13, 1)]
		[Static]
		[Export ("changeChargeTo:duration:")]
		SKAction CreateChangeChargeTo (float newCharge, double duration);

		[MacCatalyst (13, 1)]
		[Static]
		[Export ("changeChargeBy:duration:")]
		SKAction CreateChangeChargeBy (float by, double duration);

		[MacCatalyst (13, 1)]
		[Static]
		[Export ("changeMassTo:duration:")]
		SKAction CreateChangeMassTo (float newMass, double duration);

		[MacCatalyst (13, 1)]
		[Static]
		[Export ("changeMassBy:duration:")]
		SKAction CreateChangeMassBy (float by, double duration);

		[MacCatalyst (13, 1)]
		[Static]
		[Export ("applyForce:duration:")]
		SKAction CreateApplyForce (CGVector force, double duration);

		[MacCatalyst (13, 1)]
		[Static]
		[Export ("applyForce:atPoint:duration:")]
		SKAction CreateApplyForce (CGVector force, CGPoint point, double duration);

		/// <param name="torque">The angular force to apply.</param>
		/// <param name="duration">The duration over which to apply the torque.</param>
		/// <summary>Creates an action that applies an angular force for a duration.</summary>
		/// <returns>A new physics torque action.</returns>
		
		[MacCatalyst (13, 1)]
		[Static]
		[Export ("applyTorque:duration:")]
		SKAction CreateApplyTorque (nfloat torque, double duration);

		[MacCatalyst (13, 1)]
		[Static]
		[Export ("applyImpulse:duration:")]
		SKAction CreateApplyImpulse (CGVector impulse, double duration);

		[MacCatalyst (13, 1)]
		[Static]
		[Export ("applyImpulse:atPoint:duration:")]
		SKAction CreateApplyImpulse (CGVector impulse, CGPoint point, double duration);

		/// <param name="impulse">The angular impulse to apply.</param>
		/// <param name="duration">The duration over which to apply the impulse.</param>
		/// <summary>Creates an action that applies an angular impulse for a duration.</summary>
		/// <returns>A new physics impulse action.</returns>
		
		[MacCatalyst (13, 1)]
		[Static]
		[Export ("applyAngularImpulse:duration:")]
		SKAction CreateApplyAngularImpulse (nfloat impulse, double duration);

		// SKAction_SKAudioNode inlined

		[MacCatalyst (13, 1)]
		[Static]
		[Export ("stereoPanTo:duration:")]
		SKAction CreateStereoPanTo (float target, double duration);

		[MacCatalyst (13, 1)]
		[Static]
		[Export ("stereoPanBy:duration:")]
		SKAction CreateStereoPanBy (float by, double duration);

		[MacCatalyst (13, 1)]
		[Static]
		[Export ("changeReverbTo:duration:")]
		SKAction CreateChangeReverbTo (float target, double duration);

		[MacCatalyst (13, 1)]
		[Static]
		[Export ("changeReverbBy:duration:")]
		SKAction CreateChangeReverbBy (float by, double duration);

		[MacCatalyst (13, 1)]
		[Static]
		[Export ("changeObstructionTo:duration:")]
		SKAction CreateChangeObstructionTo (float target, double duration);

		[MacCatalyst (13, 1)]
		[Static]
		[Export ("changeObstructionBy:duration:")]
		SKAction CreateChangeObstructionBy (float by, double duration);

		[MacCatalyst (13, 1)]
		[Static]
		[Export ("changeOcclusionTo:duration:")]
		SKAction CreateChangeOcclusionTo (float target, double duration);

		[MacCatalyst (13, 1)]
		[Static]
		[Export ("changeOcclusionBy:duration:")]
		SKAction CreateChangeOcclusionBy (float by, double duration);

		// SKAction_SKWarpable

		[MacCatalyst (13, 1)]
		[Static]
		[Export ("warpTo:duration:")]
		[return: NullAllowed]
		SKAction WarpTo (SKWarpGeometry warp, double duration);

		[MacCatalyst (13, 1)]
		[Static]
		[Export ("animateWithWarps:times:")]
		[return: NullAllowed]
		SKAction Animate (SKWarpGeometry [] warps, NSNumber [] times);

		[MacCatalyst (13, 1)]
		[Static]
		[Export ("animateWithWarps:times:restore:")]
		[return: NullAllowed]
		SKAction Animate (SKWarpGeometry [] warps, NSNumber [] times, bool restore);
	}

	/// <include file="../docs/api/SpriteKit/SKPhysicsBody.xml" path="/Documentation/Docs[@DocId='T:SpriteKit.SKPhysicsBody']/*" />
	[MacCatalyst (13, 1)]
	[DisableDefaultCtor] // see https://bugzilla.xamarin.com/show_bug.cgi?id=14502
	[BaseType (typeof (NSObject))]
	partial interface SKPhysicsBody : NSSecureCoding, NSCopying {

		[MacCatalyst (13, 1)]
		[Static, Export ("bodyWithBodies:")]
		SKPhysicsBody FromBodies (SKPhysicsBody [] bodies);

		/// <param name="radius">The radius of the physics body.</param>
		/// <summary>Creates a new circular physics body with the specified radius.</summary>
		/// <returns>A new circular physics body.</returns>
		
		[Static, Export ("bodyWithCircleOfRadius:")]
		SKPhysicsBody CreateCircularBody (nfloat radius);

		/// <param name="radius">The radius of the physics body.</param>
		/// <param name="center">The center point of the circle.</param>
		/// <summary>Creates a new circular physics body with the specified radius and center.</summary>
		/// <returns>A new circular physics body with a custom center.</returns>
		
		[MacCatalyst (13, 1)]
		[Static, Export ("bodyWithCircleOfRadius:center:")]
		SKPhysicsBody CreateCircularBody (nfloat radius, CGPoint center);

		[Static, Export ("bodyWithRectangleOfSize:")]
		SKPhysicsBody CreateRectangularBody (CGSize size);

		[MacCatalyst (13, 1)]
		[Static, Export ("bodyWithRectangleOfSize:center:")]
		SKPhysicsBody CreateRectangularBody (CGSize size, CGPoint center);

		[Static, Export ("bodyWithPolygonFromPath:")]
		SKPhysicsBody CreateBodyFromPath (CGPath path);

		[Static, Export ("bodyWithEdgeFromPoint:toPoint:")]
		SKPhysicsBody CreateEdge (CGPoint fromPoint, CGPoint toPoint);

		[Static, Export ("bodyWithEdgeChainFromPath:")]
		SKPhysicsBody CreateEdgeChain (CGPath path);

		[Static, Export ("bodyWithEdgeLoopFromPath:")]
		SKPhysicsBody CreateEdgeLoop (CGPath path);

		[Static, Export ("bodyWithEdgeLoopFromRect:")]
		SKPhysicsBody CreateEdgeLoop (CGRect rect);

		/// <summary>Gets or sets a value the tells whether the physics body is affected by forces and impulses in the simulation.</summary>
		[Export ("dynamic")]
		bool Dynamic { [Bind ("isDynamic")] get; set; }

		[Export ("usesPreciseCollisionDetection")]
		bool UsesPreciseCollisionDetection { get; set; }

		[Export ("allowsRotation")]
		bool AllowsRotation { get; set; }

		/// <summary>Gets or sets a value that tells whether the body is resting on another body in the simulation, and thus does not participate in the simulation.</summary>
		[Export ("resting")]
		bool Resting { [Bind ("isResting")] get; set; }

		[Export ("friction")]
		nfloat Friction { get; set; }

		[Export ("restitution")]
		nfloat Restitution { get; set; }

		[Export ("linearDamping", ArgumentSemantic.Assign)]
		nfloat LinearDamping { get; set; }

		[Export ("angularDamping", ArgumentSemantic.Assign)]
		nfloat AngularDamping { get; set; }

		[Export ("density")]
		nfloat Density { get; set; }

		[Export ("mass")]
		nfloat Mass { get; set; }

		[Export ("area")]
		nfloat Area { get; }

		[Export ("affectedByGravity", ArgumentSemantic.Assign)]
		bool AffectedByGravity { get; set; }

		[Export ("categoryBitMask", ArgumentSemantic.Assign)]
		uint CategoryBitMask { get; set; } /* uint32_t */

		[Export ("collisionBitMask", ArgumentSemantic.Assign)]
		uint CollisionBitMask { get; set; } /* uint32_t */

		[Export ("contactTestBitMask", ArgumentSemantic.Assign)]
		uint ContactTestBitMask { get; set; } /* uint32_t */

		[Export ("joints")]
		SKPhysicsJoint [] Joints { get; }

		[Export ("node", ArgumentSemantic.Weak)]
		[NullAllowed]
		SKNode Node { get; }

		[Export ("velocity")]
		CGVector Velocity { get; set; }

		[Export ("angularVelocity")]
		nfloat AngularVelocity { get; set; }

		[Export ("applyForce:")]
		void ApplyForce (CGVector force);

		[Export ("applyForce:atPoint:")]
		void ApplyForce (CGVector force, CGPoint point);

		/// <param name="torque">The angular force to apply to the body.</param>
		/// <summary>Applies a torque, in Newton-meters, to the physics body for one time step.</summary>
		
		[Export ("applyTorque:")]
		void ApplyTorque (nfloat torque);

		[Export ("applyImpulse:")]
		void ApplyImpulse (CGVector impulse);

		[Export ("applyImpulse:atPoint:")]
		void ApplyImpulse (CGVector impulse, CGPoint point);

		/// <param name="impulse">The angular impulse to apply to the body.</param>
		/// <summary>Applies the specified angular impulse, in Newton-seconds, to the physics body.</summary>
		
		[Export ("applyAngularImpulse:")]
		void ApplyAngularImpulse (nfloat impulse);

		[Export ("allContactedBodies")]
		SKPhysicsBody [] AllContactedBodies { get; }

		//
		// iOS 8
		//
		[MacCatalyst (13, 1)]
		[Static, Export ("bodyWithTexture:size:")]
		SKPhysicsBody Create (SKTexture texture, CGSize size);

		[MacCatalyst (13, 1)]
		[Static, Export ("bodyWithTexture:alphaThreshold:size:")]
		SKPhysicsBody Create (SKTexture texture, float /* float, not CGFloat */ alphaThreshold, CGSize size);

		[MacCatalyst (13, 1)]
		[Export ("charge")]
		nfloat Charge { get; set; }

		[MacCatalyst (13, 1)]
		[Export ("fieldBitMask")]
		uint FieldBitMask { get; set; } /* uint32_t */

		[MacCatalyst (13, 1)]
		[Export ("pinned")]
		bool Pinned { get; set; }
	}

	/// <summary>Encapsulates the data of a collision between two <see cref="SpriteKit.SKPhysicsBody" />s.</summary>
	///     
	///     
	///     <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/SpriteKit/Reference/SKPhysicsContact/index.html">Apple documentation for <c>SKPhysicsContact</c></related>
	[MacCatalyst (13, 1)]
	[BaseType (typeof (NSObject))]
	[DisableDefaultCtor] // <quote>An SKPhysicsContact object is created automatically by Scene Kit</quote>
	partial interface SKPhysicsContact {

		[Export ("bodyA")]
		SKPhysicsBody BodyA { get; }

		[Export ("bodyB")]
		SKPhysicsBody BodyB { get; }

		[Export ("contactPoint")]
		CGPoint ContactPoint { get; }

		[Export ("collisionImpulse")]
		nfloat CollisionImpulse { get; }

		[MacCatalyst (13, 1)]
		[Export ("contactNormal")]
		CGVector ContactNormal { get; }

	}

	interface ISKPhysicsContactDelegate { }

	/// <include file="../docs/api/SpriteKit/SKPhysicsContactDelegate.xml" path="/Documentation/Docs[@DocId='T:SpriteKit.SKPhysicsContactDelegate']/*" />
	[MacCatalyst (13, 1)]
	[BaseType (typeof (NSObject))]
	[Model]
	[Protocol]
	partial interface SKPhysicsContactDelegate {

		/// <param name="contact">The contact information for the beginning of the collision.</param>
		/// <summary>Method that is called when contact is started.</summary>
		
		[EventArgs ("", XmlDocs = """
			<summary>Event raised by the object.</summary>
			<remarks>If developers do not assign a value to this event, this will reset the value for the WeakContactDelegate property to an internal handler that maps delegates to events.</remarks>
			""")]
		[Export ("didBeginContact:")]
		void DidBeginContact (SKPhysicsContact contact);

		/// <param name="contact">The contact information for the end of the collision.</param>
		/// <summary>Method that is called after contact ends.</summary>
		
		[EventArgs ("", XmlDocs = """
			<summary>Event raised by the object.</summary>
			<remarks>If developers do not assign a value to this event, this will reset the value for the WeakContactDelegate property to an internal handler that maps delegates to events.</remarks>
			""")]
		[Export ("didEndContact:")]
		void DidEndContact (SKPhysicsContact contact);
	}

	/// <include file="../docs/api/SpriteKit/SKPhysicsWorldBodiesEnumeratorHandler.xml" path="/Documentation/Docs[@DocId='T:SpriteKit.SKPhysicsWorldBodiesEnumeratorHandler']/*" />
	delegate void SKPhysicsWorldBodiesEnumeratorHandler (SKPhysicsBody body, out bool stop);
	/// <summary>The delegate used for enumerating bodies that fall along a ray when used with <see cref="SpriteKit.SKPhysicsWorld.EnumerateBodies(CGPoint,CGPoint,SpriteKit.SKPhysicsWorldBodiesAlongRayStartEnumeratorHandler)" />.</summary>
	delegate void SKPhysicsWorldBodiesAlongRayStartEnumeratorHandler (SKPhysicsBody body, CGPoint point, CGVector normal, out bool stop);

	/// <include file="../docs/api/SpriteKit/SKPhysicsWorld.xml" path="/Documentation/Docs[@DocId='T:SpriteKit.SKPhysicsWorld']/*" />
	[MacCatalyst (13, 1)]
	[BaseType (typeof (NSObject),
		   Delegates = new string [] { "WeakContactDelegate" },
		   Events = new Type [] { typeof (SKPhysicsContactDelegate) })]
	[DisableDefaultCtor] // <quote>You do not create SKPhysicsWorld objects directly; instead, read the physicsWorld property of an SKScene object.</quote>
	partial interface SKPhysicsWorld : NSSecureCoding {

		[Export ("gravity")]
		CGVector Gravity { get; set; }

		[Export ("speed")]
		nfloat Speed { get; set; }

		[Export ("contactDelegate", ArgumentSemantic.Assign), NullAllowed]
		NSObject WeakContactDelegate { get; set; }

		/// <summary>A delegate object that can handle events relating to collisions between the physics bodies in the simulation.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[Wrap ("WeakContactDelegate")]
		ISKPhysicsContactDelegate ContactDelegate { get; set; }

		[Export ("addJoint:")]
		void AddJoint (SKPhysicsJoint joint);

		[Export ("removeJoint:")]
		void RemoveJoint (SKPhysicsJoint joint);

		[Export ("removeAllJoints")]
		void RemoveAllJoints ();

		[Export ("bodyAtPoint:")]
		[return: NullAllowed]
		SKPhysicsBody GetBody (CGPoint point);

		[Export ("bodyInRect:")]
		[return: NullAllowed]
		SKPhysicsBody GetBody (CGRect rect);

		[Export ("bodyAlongRayStart:end:")]
		[return: NullAllowed]
		SKPhysicsBody GetBody (CGPoint rayStart, CGPoint rayEnd);

		[Export ("enumerateBodiesAtPoint:usingBlock:")]
		void EnumerateBodies (CGPoint point, SKPhysicsWorldBodiesEnumeratorHandler enumeratorHandler);

		[Export ("enumerateBodiesInRect:usingBlock:")]
		void EnumerateBodies (CGRect rect, SKPhysicsWorldBodiesEnumeratorHandler enumeratorHandler);

		[Export ("enumerateBodiesAlongRayStart:end:usingBlock:")]
		void EnumerateBodies (CGPoint start, CGPoint end, SKPhysicsWorldBodiesAlongRayStartEnumeratorHandler enumeratorHandler);

		//
		// iOS 8
		//
		[MacCatalyst (13, 1)]
		[Export ("sampleFieldsAt:")]
		[MarshalDirective (NativePrefix = "xamarin_simd__", Library = "__Internal")]
		Vector3 SampleFields (/* vector_float3 */ Vector3 position);
	}

	/// <include file="../docs/api/SpriteKit/SKPhysicsJoint.xml" path="/Documentation/Docs[@DocId='T:SpriteKit.SKPhysicsJoint']/*" />
	[MacCatalyst (13, 1)]
	[BaseType (typeof (NSObject))]
	[Abstract] // <quote>You never instantiate objects of this class directly</quote>
	partial interface SKPhysicsJoint : NSSecureCoding {

		[Export ("bodyA", ArgumentSemantic.Retain)]
		SKPhysicsBody BodyA { get; set; }

		[Export ("bodyB", ArgumentSemantic.Retain)]
		SKPhysicsBody BodyB { get; set; }

		[MacCatalyst (13, 1)]
		[Export ("reactionForce")]
		CGVector ReactionForce { get; }

		[MacCatalyst (13, 1)]
		[Export ("reactionTorque")]
		nfloat ReactionTorque { get; }
	}

	/// <summary>A <see cref="SpriteKit.SKPhysicsJoint" /> that pins two bodies to a common point.</summary>
	///     
	///     <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/SpriteKit/Reference/SKPhysicsJointPin_Ref/index.html">Apple documentation for <c>SKPhysicsJointPin</c></related>
	[MacCatalyst (13, 1)]
	[BaseType (typeof (SKPhysicsJoint))]
	[DisableDefaultCtor] // impossible to set the `anchor` using the default ctor (see #14511) 
	partial interface SKPhysicsJointPin {

		[Static, Export ("jointWithBodyA:bodyB:anchor:")]
		SKPhysicsJointPin Create (SKPhysicsBody bodyA, SKPhysicsBody bodyB, CGPoint anchor);

		[Export ("shouldEnableLimits")]
		bool ShouldEnableLimits { get; set; }

		[Export ("lowerAngleLimit")]
		nfloat LowerAngleLimit { get; set; }

		[Export ("upperAngleLimit")]
		nfloat UpperAngleLimit { get; set; }

		[Export ("frictionTorque")]
		nfloat FrictionTorque { get; set; }

		[MacCatalyst (13, 1)]
		[Export ("rotationSpeed")]
		nfloat RotationSpeed { get; set; }
	}

	/// <summary>A <see cref="SpriteKit.SKPhysicsJoint" /> that connects two bodies as if by a spring.</summary>
	///     
	///     <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/SpriteKit/Reference/SKPhysicsJointSpring_Ref/index.html">Apple documentation for <c>SKPhysicsJointSpring</c></related>
	[MacCatalyst (13, 1)]
	[BaseType (typeof (SKPhysicsJoint))]
	[DisableDefaultCtor] // impossible to set the `anchorA` and `anchorB` using the default ctor (see #14511) 
	partial interface SKPhysicsJointSpring {

		[Static, Export ("jointWithBodyA:bodyB:anchorA:anchorB:")]
		SKPhysicsJointSpring Create (SKPhysicsBody bodyA, SKPhysicsBody bodyB, CGPoint anchorA, CGPoint anchorB);

		[Export ("damping")]
		nfloat Damping { get; set; }

		[Export ("frequency")]
		nfloat Frequency { get; set; }
	}

	/// <summary>A <see cref="SpriteKit.SKPhysicsJoint" /> that rigidly connects two bodies.</summary>
	///     <remarks>
	///       <para>At least one of the <see cref="SpriteKit.SKPhysicsBody" />s must have its <see cref="SpriteKit.SKPhysicsBody.AllowsRotation" /> property set to <see langword="true" /> or this <see cref="SpriteKit.SKPhysicsJointFixed" /> will not behave properly.</para>
	///     </remarks>
	///     <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/SpriteKit/Reference/SKPhysicsJointFixed_Ref/index.html">Apple documentation for <c>SKPhysicsJointFixed</c></related>
	[MacCatalyst (13, 1)]
	[BaseType (typeof (SKPhysicsJoint))]
	[DisableDefaultCtor] // https://bugzilla.xamarin.com/show_bug.cgi?id=14511
	partial interface SKPhysicsJointFixed {

		[Static, Export ("jointWithBodyA:bodyB:anchor:")]
		SKPhysicsJointFixed Create (SKPhysicsBody bodyA, SKPhysicsBody bodyB, CGPoint anchor);
	}

	/// <summary>A <see cref="SpriteKit.SKPhysicsJoint" /> that connects two bodies as if by a sliding rod.</summary>
	///     
	///     <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/SpriteKit/Reference/SKPhysicsJointSliding_Ref/index.html">Apple documentation for <c>SKPhysicsJointSliding</c></related>
	[MacCatalyst (13, 1)]
	[BaseType (typeof (SKPhysicsJoint))]
	[DisableDefaultCtor] // impossible to set the `anchor` and `axis` using the default ctor (see #14511) 
	partial interface SKPhysicsJointSliding {

		[Static, Export ("jointWithBodyA:bodyB:anchor:axis:")]
		SKPhysicsJointSliding Create (SKPhysicsBody bodyA, SKPhysicsBody bodyB, CGPoint anchor, CGVector axis);

		[Export ("shouldEnableLimits")]
		bool ShouldEnableLimits { get; set; }

		[Export ("lowerDistanceLimit")]
		nfloat LowerDistanceLimit { get; set; }

		[Export ("upperDistanceLimit")]
		nfloat UpperDistanceLimit { get; set; }
	}

	/// <summary>A <see cref="SpriteKit.SKPhysicsJoint" /> that connects two bodies as if by a rope.</summary>
	///     
	///     <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/SpriteKit/Reference/SKPhysicsJointLimit/index.html">Apple documentation for <c>SKPhysicsJointLimit</c></related>
	[MacCatalyst (13, 1)]
	[BaseType (typeof (SKPhysicsJoint))]
	[DisableDefaultCtor] // impossible to set the `anchorA` and `anchorB` using the default ctor (see #14511) 
	partial interface SKPhysicsJointLimit {

		[Export ("maxLength")]
		nfloat MaxLength { get; set; }

		[Static, Export ("jointWithBodyA:bodyB:anchorA:anchorB:")]
		SKPhysicsJointLimit Create (SKPhysicsBody bodyA, SKPhysicsBody bodyB, CGPoint anchorA, CGPoint anchorB);
	}

	/// <summary>Defines a range for acceptable float values.</summary>
	///     
	///     <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/SpriteKit/Reference/SKRange_Ref/index.html">Apple documentation for <c>SKRange</c></related>
	[MacCatalyst (13, 1)]
	[BaseType (typeof (NSObject))]
	interface SKRange : NSSecureCoding, NSCopying {
		/// <param name="lowerLimit">The lower angular limit in radians.</param>
		/// <param name="upperLimier">The upper angular limit in radians.</param>
		/// <summary>Creates a new <see cref="SpriteKit.SKRange" /> with the specified limits.</summary>
		
		[DesignatedInitializer]
		[Export ("initWithLowerLimit:upperLimit:")]
		NativeHandle Constructor (nfloat lowerLimit, nfloat upperLimier);

		[Export ("lowerLimit")]
		nfloat LowerLimit { get; set; }

		[Export ("upperLimit")]
		nfloat UpperLimit { get; set; }

		/// <param name="lower">The lower distance limit.</param>
		/// <param name="upper">The upper distance limit.</param>
		/// <summary>Creates a range that represents values between the specified lower and upper limits.</summary>
		/// <returns>A new distance range constraint.</returns>
		
		[Static, Export ("rangeWithLowerLimit:upperLimit:")]
		SKRange Create (nfloat lower, nfloat upper);

		/// <param name="lower">The lower distance limit.</param>
		/// <summary>Creates a semi-infinite range with the specified lower bound, inclusive.</summary>
		/// <returns>A new constraint with a lower distance limit.</returns>
		
		[Static, Export ("rangeWithLowerLimit:")]
		SKRange CreateWithLowerLimit (nfloat lower);

		/// <param name="upper">The upper distance limit.</param>
		/// <summary>Creates a semi-infinite range with the specified upper bound, inclusive.</summary>
		/// <returns>A new constraint with an upper distance limit.</returns>
		
		[Static, Export ("rangeWithUpperLimit:")]
		SKRange CreateWithUpperLimit (nfloat upper);

		/// <param name="value">The fixed distance value.</param>
		/// <summary>Creates a zero-width range at the specified value.</summary>
		/// <returns>A new constraint with a fixed distance.</returns>
		
		[Static, Export ("rangeWithConstantValue:")]
		SKRange CreateConstant (nfloat value);

		/// <param name="value">The central distance value.</param>
		/// <param name="variance">The allowed variance from the value.</param>
		/// <summary>Creates an inclusive range from the specified value an variance.</summary>
		/// <returns>A new constraint with the specified distance range.</returns>
		
		[Static, Export ("rangeWithValue:variance:")]
		SKRange CreateWithVariance (nfloat value, nfloat variance);

		[Static, Export ("rangeWithNoLimits")]
		SKRange CreateUnlimited ();
	}

	/// <summary>A <see cref="SpriteKit.SKNode" /> that holds audio information.</summary>
	///     
	///     <related type="externalDocumentation" href="https://developer.apple.com/reference/SpriteKit/SKAudioNode">Apple documentation for <c>SKAudioNode</c></related>
	[MacCatalyst (13, 1)]
	[BaseType (typeof (SKNode))]
	[DisableDefaultCtor]
	interface SKAudioNode : NSSecureCoding {
		[Export ("initWithAVAudioNode:")]
		[DesignatedInitializer]
		NativeHandle Constructor ([NullAllowed] AVAudioNode node);

		[Export ("initWithFileNamed:")]
		NativeHandle Constructor (string fileName);

		[Export ("initWithURL:")]
		NativeHandle Constructor (NSUrl url);

		[NullAllowed, Export ("avAudioNode", ArgumentSemantic.Retain)]
		AVAudioNode AvAudioNode { get; set; }

		[Export ("autoplayLooped")]
		bool AutoplayLooped { get; set; }

		/// <summary>Whether the audio is altered by the node's position in the scene.</summary>
		[Export ("positional")]
		bool Positional { [Bind ("isPositional")] get; set; }
	}

	/// <summary>A node that specifies the position inside a <see cref="SpriteKit.SKScene" /> from which it can be rendered.</summary>
	///     
	///     <related type="externalDocumentation" href="https://developer.apple.com/reference/SpriteKit/SKCameraNode">Apple documentation for <c>SKCameraNode</c></related>
	[MacCatalyst (13, 1)]
	[BaseType (typeof (SKNode))]
	interface SKCameraNode {
		[Export ("containsNode:")]
		bool Contains (SKNode node);

		[Export ("containedNodeSet")]
		NSSet<SKNode> ContainedNodeSet { get; }
	}

	/// <summary>A <see cref="SpriteKit.SKNode" /> that holds an archived collection of child nodes that can be used in multiple places throughout the game.</summary>
	///     
	///     <related type="externalDocumentation" href="https://developer.apple.com/reference/SpriteKit/SKReferenceNode">Apple documentation for <c>SKReferenceNode</c></related>
	[MacCatalyst (13, 1)]
	[BaseType (typeof (SKNode))]
	[DisableDefaultCtor]
	interface SKReferenceNode {
		[Export ("initWithURL:")]
		[DesignatedInitializer]
		NativeHandle Constructor ([NullAllowed] NSUrl url);

		[Export ("initWithFileNamed:")]
		[DesignatedInitializer]
		NativeHandle Constructor ([NullAllowed] string fileName);

		[Static]
		[Export ("referenceNodeWithFileNamed:")]
		SKReferenceNode FromFile (string fileName);

		[Static]
		[Export ("referenceNodeWithURL:")]
		SKReferenceNode FromUrl (NSUrl referenceUrl);

		[Export ("didLoadReferenceNode:")]
		void DidLoadReferenceNode ([NullAllowed] SKNode node);

		[Export ("resolveReferenceNode")]
		void Resolve ();
	}

	/// <summary>Holds per-node data to be used with a custom shader.</summary>
	///     
	///     <related type="externalDocumentation" href="https://developer.apple.com/reference/SpriteKit/SKAttribute">Apple documentation for <c>SKAttribute</c></related>
	[MacCatalyst (13, 1)]
	[BaseType (typeof (NSObject))]
	[DisableDefaultCtor]
	interface SKAttribute : NSSecureCoding {
		[Static]
		[Export ("attributeWithName:type:")]
		SKAttribute Create (string name, SKAttributeType type);

		[Export ("initWithName:type:")]
		[DesignatedInitializer]
		NativeHandle Constructor (string name, SKAttributeType type);

		[Export ("name")]
		string Name { get; }

		[Export ("type")]
		SKAttributeType Type { get; }
	}

	/// <summary>Holds the value, of the appropriate <see cref="SpriteKit.SKAttributeType" />, for an <see cref="SpriteKit.SKAttribute" />.</summary>
	///     
	///     <related type="externalDocumentation" href="https://developer.apple.com/reference/SpriteKit/SKAttributeValue">Apple documentation for <c>SKAttributeValue</c></related>
	[MacCatalyst (13, 1)]
	[BaseType (typeof (NSObject))]
	[DisableDefaultCtor] // DesignatedInitializer below
	interface SKAttributeValue : NSSecureCoding {
		[DesignatedInitializer]
		[Export ("init")]
		NativeHandle Constructor ();

		[Static]
		[Export ("valueWithFloat:")]
		SKAttributeValue Create (float value);

		[Static]
		[Export ("valueWithVectorFloat2:")]
		[MarshalDirective (NativePrefix = "xamarin_simd__", Library = "__Internal")]
		SKAttributeValue Create (Vector2 value);

		[Static]
		[Export ("valueWithVectorFloat3:")]
		[MarshalDirective (NativePrefix = "xamarin_simd__", Library = "__Internal")]
		SKAttributeValue Create (Vector3 value);

		[Static]
		[Export ("valueWithVectorFloat4:")]
		[MarshalDirective (NativePrefix = "xamarin_simd__", Library = "__Internal")]
		SKAttributeValue Create (Vector4 value);

		[Export ("floatValue")]
		float FloatValue { get; set; }

		[Export ("vectorFloat2Value", ArgumentSemantic.Assign)]
		Vector2 VectorFloat2Value {
			[MarshalDirective (NativePrefix = "xamarin_simd__", Library = "__Internal")]
			get;
			[MarshalDirective (NativePrefix = "xamarin_simd__", Library = "__Internal")]
			set;
		}

		[Export ("vectorFloat3Value", ArgumentSemantic.Assign)]
		Vector3 VectorFloat3Value {
			[MarshalDirective (NativePrefix = "xamarin_simd__", Library = "__Internal")]
			get;
			[MarshalDirective (NativePrefix = "xamarin_simd__", Library = "__Internal")]
			set;
		}

		[Export ("vectorFloat4Value", ArgumentSemantic.Assign)]
		Vector4 VectorFloat4Value {
			[MarshalDirective (NativePrefix = "xamarin_simd__", Library = "__Internal")]
			get;
			[MarshalDirective (NativePrefix = "xamarin_simd__", Library = "__Internal")]
			set;
		}
	}

	/// <summary>A single kind of tile in a tile map.</summary>
	///     
	///     <related type="externalDocumentation" href="https://developer.apple.com/reference/SpriteKit/SKTileDefinition">Apple documentation for <c>SKTileDefinition</c></related>
	[MacCatalyst (13, 1)]
	[BaseType (typeof (NSObject))]
	[DisableDefaultCtor]
	interface SKTileDefinition : NSCopying, NSSecureCoding {
		[Static]
		[Export ("tileDefinitionWithTexture:")]
		SKTileDefinition Create (SKTexture texture);

		[Static]
		[Export ("tileDefinitionWithTexture:size:")]
		SKTileDefinition Create (SKTexture texture, CGSize size);

		[Static]
		[Export ("tileDefinitionWithTexture:normalTexture:size:")]
		SKTileDefinition Create (SKTexture texture, SKTexture normalTexture, CGSize size);

		/// <param name="textures">The textures for the animation frames.</param>
		/// <param name="size">The size for each frame.</param>
		/// <param name="timePerFrame">The duration of each frame in seconds.</param>
		/// <summary>Creates an animated tile definition with the specified frames.</summary>
		/// <returns>A new animated tile definition.</returns>
		
		[Static]
		[Export ("tileDefinitionWithTextures:size:timePerFrame:")]
		SKTileDefinition Create (SKTexture [] textures, CGSize size, nfloat timePerFrame);

		/// <param name="textures">The textures for the animation frames.</param>
		/// <param name="normalTextures">The normal map textures for each frame.</param>
		/// <param name="size">The size for each frame.</param>
		/// <param name="timePerFrame">The duration of each frame in seconds.</param>
		/// <summary>Creates an animated tile definition with textures and normal maps.</summary>
		/// <returns>A new animated tile definition.</returns>
		
		[Static]
		[Export ("tileDefinitionWithTextures:normalTextures:size:timePerFrame:")]
		SKTileDefinition Create (SKTexture [] textures, SKTexture [] normalTextures, CGSize size, nfloat timePerFrame);

		[Export ("initWithTexture:")]
		NativeHandle Constructor (SKTexture texture);

		[Export ("initWithTexture:size:")]
		NativeHandle Constructor (SKTexture texture, CGSize size);

		[Export ("initWithTexture:normalTexture:size:")]
		NativeHandle Constructor (SKTexture texture, SKTexture normalTexture, CGSize size);

		/// <param name="textures">The textures for the animation frames.</param>
		/// <param name="size">The size for each frame.</param>
		/// <param name="timePerFrame">The duration of each frame in seconds.</param>
		/// <summary>Creates an animated tile definition with the specified frames.</summary>
		
		[Export ("initWithTextures:size:timePerFrame:")]
		NativeHandle Constructor (SKTexture [] textures, CGSize size, nfloat timePerFrame);

		/// <param name="textures">The textures for the animation frames.</param>
		/// <param name="normalTextures">The normal map textures for each frame.</param>
		/// <param name="size">The size for each frame.</param>
		/// <param name="timePerFrame">The duration of each frame in seconds.</param>
		/// <summary>Creates an animated tile definition with textures and normal maps.</summary>
		
		[Export ("initWithTextures:normalTextures:size:timePerFrame:")]
		NativeHandle Constructor (SKTexture [] textures, SKTexture [] normalTextures, CGSize size, nfloat timePerFrame);

		[Export ("textures", ArgumentSemantic.Copy)]
		SKTexture [] Textures { get; set; }

		[Export ("normalTextures", ArgumentSemantic.Copy)]
		SKTexture [] NormalTextures { get; set; }

		[NullAllowed, Export ("userData", ArgumentSemantic.Retain)]
		NSMutableDictionary UserData { get; set; }

		[NullAllowed, Export ("name")]
		string Name { get; set; }

		[Export ("size", ArgumentSemantic.Assign)]
		CGSize Size { get; set; }

		[Export ("timePerFrame")]
		nfloat TimePerFrame { get; set; }

		[Export ("placementWeight")]
		nuint PlacementWeight { get; set; }

		[Export ("rotation", ArgumentSemantic.Assign)]
		SKTileDefinitionRotation Rotation { get; set; }

		[Export ("flipVertically")]
		bool FlipVertically { get; set; }

		[Export ("flipHorizontally")]
		bool FlipHorizontally { get; set; }
	}

	/// <include file="../docs/api/SpriteKit/SKTileMapNode.xml" path="/Documentation/Docs[@DocId='T:SpriteKit.SKTileMapNode']/*" />
	[MacCatalyst (13, 1)]
	[BaseType (typeof (SKNode))]
	interface SKTileMapNode : NSCopying, NSSecureCoding {
		/// <param name="tileSet">The tile set to use.</param>
		/// <param name="columns">The number of columns in the map.</param>
		/// <param name="rows">The number of rows in the map.</param>
		/// <param name="tileSize">The size of each tile.</param>
		/// <summary>Factory method to create an <see cref="SpriteKit.SKTileMapNode" /> with the specified properties.</summary>
		/// <returns>A new tile map node.</returns>
		
		[Static]
		[Export ("tileMapNodeWithTileSet:columns:rows:tileSize:")]
		SKTileMapNode Create (SKTileSet tileSet, nuint columns, nuint rows, CGSize tileSize);

		/// <param name="tileSet">The tile set to use.</param>
		/// <param name="columns">The number of columns in the map.</param>
		/// <param name="rows">The number of rows in the map.</param>
		/// <param name="tileSize">The size of each tile.</param>
		/// <param name="tileGroup">The tile group to fill the map with.</param>
		/// <summary>Creates a tile map node filled with the specified tile group.</summary>
		/// <returns>A new tile map node filled with tiles.</returns>
		
		[Static]
		[Export ("tileMapNodeWithTileSet:columns:rows:tileSize:fillWithTileGroup:")]
		SKTileMapNode Create (SKTileSet tileSet, nuint columns, nuint rows, CGSize tileSize, SKTileGroup tileGroup);

		/// <param name="tileSet">The tile set to use.</param>
		/// <param name="columns">The number of columns in the map.</param>
		/// <param name="rows">The number of rows in the map.</param>
		/// <param name="tileSize">The size of each tile.</param>
		/// <param name="tileGroupLayout">The tile groups for each position.</param>
		/// <summary>Creates a tile map node with the specified layout.</summary>
		/// <returns>A new tile map node with the specified layout.</returns>
		
		[Static]
		[Export ("tileMapNodeWithTileSet:columns:rows:tileSize:tileGroupLayout:")]
		SKTileMapNode Create (SKTileSet tileSet, nuint columns, nuint rows, CGSize tileSize, SKTileGroup [] tileGroupLayout);

		/// <param name="tileSet">The tile set to use.</param>
		/// <param name="columns">The number of columns in the map.</param>
		/// <param name="rows">The number of rows in the map.</param>
		/// <param name="tileSize">The size of each tile.</param>
		/// <summary>Creates a tile map node with the specified configuration.</summary>
		
		[Export ("initWithTileSet:columns:rows:tileSize:")]
		NativeHandle Constructor (SKTileSet tileSet, nuint columns, nuint rows, CGSize tileSize);

		/// <param name="tileSet">The tile set to use.</param>
		/// <param name="columns">The number of columns in the map.</param>
		/// <param name="rows">The number of rows in the map.</param>
		/// <param name="tileSize">The size of each tile.</param>
		/// <param name="tileGroup">The tile group to fill the map with.</param>
		/// <summary>Creates a tile map node filled with the specified tile group.</summary>
		
		[Export ("initWithTileSet:columns:rows:tileSize:fillWithTileGroup:")]
		NativeHandle Constructor (SKTileSet tileSet, nuint columns, nuint rows, CGSize tileSize, SKTileGroup tileGroup);

		/// <param name="tileSet">The tile set to use.</param>
		/// <param name="columns">The number of columns in the map.</param>
		/// <param name="rows">The number of rows in the map.</param>
		/// <param name="tileSize">The size of each tile.</param>
		/// <param name="tileGroupLayout">The tile groups for each position.</param>
		/// <summary>Creates a tile map node with the specified layout.</summary>
		
		[Export ("initWithTileSet:columns:rows:tileSize:tileGroupLayout:")]
		NativeHandle Constructor (SKTileSet tileSet, nuint columns, nuint rows, CGSize tileSize, SKTileGroup [] tileGroupLayout);

		[Export ("numberOfColumns")]
		nuint NumberOfColumns { get; set; }

		[Export ("numberOfRows")]
		nuint NumberOfRows { get; set; }

		[Export ("tileSize", ArgumentSemantic.Assign)]
		CGSize TileSize { get; set; }

		[Export ("mapSize")]
		CGSize MapSize { get; }

		[Export ("tileSet", ArgumentSemantic.Assign)]
		SKTileSet TileSet { get; set; }

		[Export ("colorBlendFactor")]
		nfloat ColorBlendFactor { get; set; }

		[Export ("color", ArgumentSemantic.Retain)]
		UIColor Color { get; set; }

		[Export ("blendMode", ArgumentSemantic.Assign)]
		SKBlendMode BlendMode { get; set; }

		[Export ("anchorPoint", ArgumentSemantic.Assign)]
		CGPoint AnchorPoint { get; set; }

		[NullAllowed, Export ("shader", ArgumentSemantic.Retain)]
		SKShader Shader { get; set; }

		[Export ("lightingBitMask")]
		uint LightingBitMask { get; set; }

		[Export ("enableAutomapping")]
		bool EnableAutomapping { get; set; }

		[Export ("fillWithTileGroup:")]
		void Fill ([NullAllowed] SKTileGroup tileGroup);

		/// <param name="column">The column index.</param>
		/// <param name="row">The row index.</param>
		/// <summary>Gets the <see cref="SpriteKit.SKTileDefinition" /> for the tile at the specified position.</summary>
		/// <returns>The tile group at the specified position.</returns>
		
		[Export ("tileDefinitionAtColumn:row:")]
		[return: NullAllowed]
		SKTileDefinition GetTileDefinition (nuint column, nuint row);

		/// <param name="column">The column index.</param>
		/// <param name="row">The row index.</param>
		/// <summary>Gets the <see cref="SpriteKit.SKTileGroup" /> for the tile at the specified position.</summary>
		/// <returns>The tile definition at the specified position.</returns>
		
		[Export ("tileGroupAtColumn:row:")]
		[return: NullAllowed]
		SKTileGroup GetTileGroup (nuint column, nuint row);

		/// <param name="tileGroup">
		///           <para>Sets the tile group at the specified position.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		/// <param name="column">The column index.</param>
		/// <param name="row">The row index.</param>
		/// <summary>Sets the <see cref="SpriteKit.SKTileGroup" /> at the specified location.</summary>
		
		[Export ("setTileGroup:forColumn:row:")]
		void SetTileGroup ([NullAllowed] SKTileGroup tileGroup, nuint column, nuint row);

		/// <param name="tileGroup">The tile group to set.</param>
		/// <param name="tileDefinition">The tile definition to set.</param>
		/// <param name="column">The column index.</param>
		/// <param name="row">The row index.</param>
		/// <summary>Sets the <paramref name="tileGroup" /> and <paramref name="tileDefinition" /> at the specified location.</summary>
		
		[Export ("setTileGroup:andTileDefinition:forColumn:row:")]
		void SetTileGroup (SKTileGroup tileGroup, SKTileDefinition tileDefinition, nuint column, nuint row);

		[Export ("tileColumnIndexFromPosition:")]
		nuint GetTileColumnIndex (CGPoint position);

		[Export ("tileRowIndexFromPosition:")]
		nuint GetTileRowIndex (CGPoint position);

		/// <param name="column">The column index.</param>
		/// <param name="row">The row index.</param>
		/// <summary>Retrieves the <see cref="CoreGraphics.CGPoint" /> at the center of the specified position.</summary>
		/// <returns>The center point of the tile at the specified position.</returns>
		
		[Export ("centerOfTileAtColumn:row:")]
		CGPoint GetCenterOfTile (nuint column, nuint row);

		// Static Category from GameplayKit
		/// <param name="tileSet">The tile set to use.</param>
		/// <param name="columns">The number of columns in the map.</param>
		/// <param name="rows">The number of rows in the map.</param>
		/// <param name="tileSize">The size of each tile.</param>
		/// <param name="noiseMap">The noise map to use for tile placement.</param>
		/// <param name="thresholds">The noise thresholds for tile selection.</param>
		/// <summary>Creates a tile map node using a noise map for procedural placement.</summary>
		/// <returns>A new tile map node with procedurally placed tiles.</returns>
		
		[MacCatalyst (13, 1)]
		[Static]
		[Export ("tileMapNodesWithTileSet:columns:rows:tileSize:fromNoiseMap:tileTypeNoiseMapThresholds:")]
		SKTileMapNode [] FromTileSet (SKTileSet tileSet, nuint columns, nuint rows, CGSize tileSize, GKNoiseMap noiseMap, NSNumber [] thresholds);

		[Export ("attributeValues", ArgumentSemantic.Copy)]
		NSDictionary<NSString, SKAttributeValue> AttributeValues { get; set; }

		[Export ("valueForAttributeNamed:")]
		[return: NullAllowed]
		SKAttributeValue GetValue (string key);

		[Export ("setValue:forAttributeNamed:")]
		void SetValue (SKAttributeValue value, string key);
	}

	/// <summary>Represents the possible elements of a <see cref="SpriteKit.SKTileMapNode" /> in the form of <see cref="SpriteKit.SKTileGroup" /> objects.</summary>
	///     <remarks>
	///       <para>An <see cref="SpriteKit.SKTileSet" /> collects a set of related <see cref="SpriteKit.SKTileGroup" /> objects that may be placed on a <see cref="SpriteKit.SKTileMapNode" />. Additionally, it may define a default tile group and tile size.</para>
	///     </remarks>
	///     <related type="externalDocumentation" href="https://developer.apple.com/reference/SpriteKit/SKTileSet">Apple documentation for <c>SKTileSet</c></related>
	[MacCatalyst (13, 1)]
	[BaseType (typeof (NSObject))]
	interface SKTileSet : NSCopying, NSSecureCoding {
		[Static]
		[Export ("tileSetWithTileGroups:")]
		SKTileSet Create (SKTileGroup [] tileGroups);

		[Static]
		[Export ("tileSetWithTileGroups:tileSetType:")]
		SKTileSet Create (SKTileGroup [] tileGroups, SKTileSetType tileSetType);

		[Export ("initWithTileGroups:")]
		NativeHandle Constructor (SKTileGroup [] tileGroups);

		[Export ("initWithTileGroups:tileSetType:")]
		NativeHandle Constructor (SKTileGroup [] tileGroups, SKTileSetType tileSetType);

		[Static]
		[Export ("tileSetNamed:")]
		[return: NullAllowed]
		SKTileSet FromName (string name);

		[Static]
		[Export ("tileSetFromURL:")]
		[return: NullAllowed]
		SKTileSet FromUrl (NSUrl url);

		[Export ("tileGroups", ArgumentSemantic.Copy)]
		SKTileGroup [] TileGroups { get; set; }

		[NullAllowed, Export ("name")]
		string Name { get; set; }

		[Export ("type", ArgumentSemantic.Assign)]
		SKTileSetType Type { get; set; }

		[NullAllowed, Export ("defaultTileGroup", ArgumentSemantic.Assign)]
		SKTileGroup DefaultTileGroup { get; set; }

		[Export ("defaultTileSize", ArgumentSemantic.Assign)]
		CGSize DefaultTileSize { get; set; }
	}

	/// <include file="../docs/api/SpriteKit/SKTileGroup.xml" path="/Documentation/Docs[@DocId='T:SpriteKit.SKTileGroup']/*" />
	[MacCatalyst (13, 1)]
	[BaseType (typeof (NSObject))]
	interface SKTileGroup : NSCopying, NSSecureCoding {
		[Static]
		[Export ("tileGroupWithTileDefinition:")]
		SKTileGroup Create (SKTileDefinition tileDefinition);

		[Static]
		[Export ("tileGroupWithRules:")]
		SKTileGroup Create (SKTileGroupRule [] rules);

		[Static]
		[Export ("emptyTileGroup")]
		SKTileGroup CreateEmpty ();

		[Export ("initWithTileDefinition:")]
		NativeHandle Constructor (SKTileDefinition tileDefinition);

		[Export ("initWithRules:")]
		NativeHandle Constructor (SKTileGroupRule [] rules);

		[Export ("rules", ArgumentSemantic.Copy)]
		SKTileGroupRule [] Rules { get; set; }

		[NullAllowed, Export ("name")]
		string Name { get; set; }
	}

	/// <summary>Defines adjacency rules for tiles in an <see cref="SpriteKit.SKTileGroup" />.</summary>
	///     
	///     <related type="externalDocumentation" href="https://developer.apple.com/reference/SpriteKit/SKTileGroupRule">Apple documentation for <c>SKTileGroupRule</c></related>
	[MacCatalyst (13, 1)]
	[BaseType (typeof (NSObject))]
	interface SKTileGroupRule : NSCopying, NSSecureCoding {
		[Static]
		[Export ("tileGroupRuleWithAdjacency:tileDefinitions:")]
		SKTileGroupRule Create (SKTileAdjacencyMask adjacency, SKTileDefinition [] tileDefinitions);

		[Export ("initWithAdjacency:tileDefinitions:")]
		NativeHandle Constructor (SKTileAdjacencyMask adjacency, SKTileDefinition [] tileDefinitions);

		[Export ("adjacency", ArgumentSemantic.Assign)]
		SKTileAdjacencyMask Adjacency { get; set; }

		[Export ("tileDefinitions", ArgumentSemantic.Copy)]
		SKTileDefinition [] TileDefinitions { get; set; }

		[NullAllowed, Export ("name")]
		string Name { get; set; }
	}

	/// <summary>Defines geometry deformation on <see cref="SpriteKit.SKNode" /> objects.</summary>
	///     
	///     <related type="externalDocumentation" href="https://developer.apple.com/reference/SpriteKit/SKWarpGeometry">Apple documentation for <c>SKWarpGeometry</c></related>
	[MacCatalyst (13, 1)]
	[BaseType (typeof (NSObject))]
	interface SKWarpGeometry : NSCopying, NSSecureCoding { }

	/// <summary>Associates a <see cref="SpriteKit.SKWarpGeometry" /> and subdivision levels with an implementation.</summary>
	[MacCatalyst (13, 1)]
	[Protocol]
	interface SKWarpable {
		/// <summary>Gets or sets the source positions for the warp geometry.</summary>
		/// <value>The source positions array.</value>
		
		[Abstract]
		[NullAllowed, Export ("warpGeometry", ArgumentSemantic.Assign)]
		SKWarpGeometry WarpGeometry { get; set; }

		/// <summary>Gets or sets the destination positions for the warp geometry.</summary>
		/// <value>The destination positions array.</value>
		
		[Abstract]
		[Export ("subdivisionLevels")]
		nint SubdivisionLevels { get; set; }
	}

	/// <summary>A <see cref="SpriteKit.SKWarpGeometry" /> subclass that defines a warpable grid.</summary>
	///     
	///     <related type="externalDocumentation" href="https://developer.apple.com/reference/SpriteKit/SKWarpGeometryGrid">Apple documentation for <c>SKWarpGeometryGrid</c></related>
	[MacCatalyst (13, 1)]
	[BaseType (typeof (SKWarpGeometry))]
	[DisableDefaultCtor]
	interface SKWarpGeometryGrid : NSSecureCoding {
		[Static]
		[Export ("grid")]
		SKWarpGeometryGrid GetGrid ();

		/// <param name="cols">The number of columns in the grid.</param>
		/// <param name="rows">The number of rows in the grid.</param>
		/// <summary>Creates a warp geometry grid with the specified dimensions.</summary>
		/// <returns>A new warp geometry grid.</returns>
		
		[Static]
		[Export ("gridWithColumns:rows:")]
		SKWarpGeometryGrid Create (nint cols, nint rows);

		[Internal]
		[Static]
		[Export ("gridWithColumns:rows:sourcePositions:destPositions:")]
		SKWarpGeometryGrid GridWithColumns (nint cols, nint rows, [NullAllowed] IntPtr sourcePositions, [NullAllowed] IntPtr destPositions);

		[Internal]
		[DesignatedInitializer]
		[Export ("initWithColumns:rows:sourcePositions:destPositions:")]
		IntPtr InitWithColumns (nint cols, nint rows, [NullAllowed] IntPtr sourcePositions, [NullAllowed] IntPtr destPositions);

		[Export ("numberOfColumns")]
		nint NumberOfColumns { get; }

		[Export ("numberOfRows")]
		nint NumberOfRows { get; }

		[Export ("vertexCount")]
		nint VertexCount { get; }

		/// <param name="index">The index of the source position.</param>
		/// <summary>Gets the source position at the specified index.</summary>
		/// <returns>The source position at the specified index.</returns>
		
		[Export ("sourcePositionAtIndex:")]
		[MarshalDirective (NativePrefix = "xamarin_simd__", Library = "__Internal")]
		Vector2 GetSourcePosition (nint index);

		/// <param name="index">The index of the destination position.</param>
		/// <summary>Gets the destination position at the specified index.</summary>
		/// <returns>The destination position at the specified index.</returns>
		
		[Export ("destPositionAtIndex:")]
		[MarshalDirective (NativePrefix = "xamarin_simd__", Library = "__Internal")]
		Vector2 GetDestPosition (nint index);

		[Internal]
		[Export ("gridByReplacingSourcePositions:")]
		SKWarpGeometryGrid _GridByReplacingSourcePositions (IntPtr sourcePositions);

		[Internal]
		[Export ("gridByReplacingDestPositions:")]
		SKWarpGeometryGrid _GridByReplacingDestPositions (IntPtr destPositions);
	}

	// SKRenderer is not available for WatchKit apps and the iOS simulator
	/// <summary>The class used to render SpriteKit.</summary>
	[MacCatalyst (13, 1)]
	[BaseType (typeof (NSObject))]
	[DisableDefaultCtor]
	interface SKRenderer {
		[Static]
		[Export ("rendererWithDevice:")]
		SKRenderer FromDevice (IMTLDevice device);

		[Export ("renderWithViewport:commandBuffer:renderPassDescriptor:")]
		void Render (CGRect viewport, IMTLCommandBuffer commandBuffer, MTLRenderPassDescriptor renderPassDescriptor);

		[Export ("renderWithViewport:renderCommandEncoder:renderPassDescriptor:commandQueue:")]
		void Render (CGRect viewport, IMTLRenderCommandEncoder renderCommandEncoder, MTLRenderPassDescriptor renderPassDescriptor, IMTLCommandQueue commandQueue);

		[Export ("updateAtTime:")]
		void Update (double currentTime);

		[NullAllowed, Export ("scene", ArgumentSemantic.Assign)]
		SKScene Scene { get; set; }

		[Export ("ignoresSiblingOrder")]
		bool IgnoresSiblingOrder { get; set; }

		[Export ("shouldCullNonVisibleNodes")]
		bool ShouldCullNonVisibleNodes { get; set; }

		[Export ("showsDrawCount")]
		bool ShowsDrawCount { get; set; }

		[Export ("showsNodeCount")]
		bool ShowsNodeCount { get; set; }

		[Export ("showsQuadCount")]
		bool ShowsQuadCount { get; set; }

		[Export ("showsPhysics")]
		bool ShowsPhysics { get; set; }

		[Export ("showsFields")]
		bool ShowsFields { get; set; }
	}

	/// <summary>A <see cref="SpriteKit.SKNode" /> that holds a geometric transform.</summary>
	[MacCatalyst (13, 1)]
	[BaseType (typeof (SKNode))]
	interface SKTransformNode {
		[Export ("xRotation")]
		nfloat XRotation { get; set; }

		[Export ("yRotation")]
		nfloat YRotation { get; set; }

		[Export ("eulerAngles")]
		VectorFloat3 EulerAngles {
			[MarshalDirective (NativePrefix = "xamarin_simd__", Library = "__Internal")]
			get;
			[MarshalDirective (NativePrefix = "xamarin_simd__", Library = "__Internal")]
			set;
		}

		[Export ("rotationMatrix")]
		MatrixFloat3x3 RotationMatrix {
			[MarshalDirective (NativePrefix = "xamarin_simd__", Library = "__Internal")]
			get;
			[MarshalDirective (NativePrefix = "xamarin_simd__", Library = "__Internal")]
			set;
		}

		[Export ("quaternion")]
		Quaternion Quaternion {
			[MarshalDirective (NativePrefix = "xamarin_simd__", Library = "__Internal")]
			get;
			[MarshalDirective (NativePrefix = "xamarin_simd__", Library = "__Internal")]
			set;
		}
	}
}
