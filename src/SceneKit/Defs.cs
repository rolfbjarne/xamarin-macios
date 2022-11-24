//
// Defs.cs: Enumerations and core types
//
// Authors:
//   Miguel de Icaza (miguel@xamarin.com)
//   Aaron Bockover (abock@xamarin.com)
//
// Copyright 2012-2014, 2016 Xamarin, Inc.
//

using System;

using Foundation;
using ObjCRuntime;

#nullable enable

namespace SceneKit {

	[Native] // untyped enum (SceneKitTypes.h) but described as the value of `code` for `NSError` which is an NSInteger
	[ErrorDomain ("SCNErrorDomain")]
	public enum SCNErrorCode : long {
		ProgramCompilationError = 1,
	}

	[Native]
	public enum SCNGeometryPrimitiveType : long {
		Triangles,
		TriangleStrip,
		Line,
		Point,
		Polygon
	}

	[Native]
	public enum SCNTransparencyMode : long {
		AOne,
		RgbZero,
		[Watch (4, 0), TV (11, 0), iOS (11, 0)]
		SingleLayer = 2,
		[Watch (4, 0), TV (11, 0), iOS (11, 0)]
		DualLayer = 3,
		[Watch (4, 0), TV (11, 0), iOS (11, 0)]
		Default = AOne,
	}

	[Native]
	public enum SCNCullMode : long {
		Back, Front
	}

	[Native]
	public enum SCNFilterMode : long {
		None,
		Nearest,
		Linear
	}

	[Native]
	public enum SCNWrapMode : long {
		Clamp = 1,
		Repeat,
		// added in iOS 8, removed in 8.3 (mistake?) but added back in 9.0 betas
		ClampToBorder,
		Mirror
	}

	[Native]
	public enum SCNSceneSourceStatus : long {
		Error = -1,
		Parsing = 4,
		Validating = 8,
		Processing = 12,
		Complete = 16
	}

	[Native]
	public enum SCNChamferMode : long {
		Both,
		Front,
		Back
	}

	[Native]
	public enum SCNMorpherCalculationMode : long {
		Normalized,
		Additive
	}

	[Native]
	public enum SCNActionTimingMode : long {
		Linear,
		EaseIn,
		EaseOut,
		EaseInEaseOut
	}

	[Native]
	public enum SCNShadowMode : long {
		Forward,
		Deferred,
		Modulated
	}

	[Native]
	public enum SCNPhysicsBodyType : long {
		Static,
		Dynamic,
		Kinematic
	}

	[Native]
	public enum SCNPhysicsFieldScope : long {
		InsideExtent,
		OutsideExtent
	}

	[Native]
	public enum SCNParticleSortingMode : long {
		None,
		ProjectedDepth,
		Distance,
		OldestFirst,
		YoungestFirst
	}

	[Native]
	public enum SCNParticleBlendMode : long {
		Additive,
		Subtract,
		Multiply,
		Screen,
		Alpha,
		Replace
	}

	[Native]
	public enum SCNParticleOrientationMode : long {
		BillboardScreenAligned,
		BillboardViewAligned,
		Free,
		BillboardYAligned
	}

	[Native]
	public enum SCNParticleBirthLocation : long {
		Surface,
		Volume,
		Vertex
	}

	[Native]
	public enum SCNParticleBirthDirection : long {
		Constant,
		SurfaceNormal,
		Random
	}

	[Native]
	public enum SCNParticleImageSequenceAnimationMode : long {
		Repeat,
		Clamp,
		AutoReverse
	}

	[Native]
	public enum SCNParticleInputMode : long {
		OverLife,
		OverDistance,
		OverOtherProperty
	}

	[Native]
	public enum SCNParticleModifierStage : long {
		PreDynamics,
		PostDynamics,
		PreCollision,
		PostCollision
	}

	[Native]
	public enum SCNParticleEvent : long {
		Birth,
		Death,
		Collision
	}

	// Utility enum
	public enum SCNGeometrySourceSemantics {
		Vertex,
		Normal,
		Color,
		Texcoord,
		VertexCrease,
		EdgeCrease,
		BoneWeights,
		BoneIndices
	}

	// Utility enum
	public enum SCNAnimationImportPolicy {
		Unknown,
		Play,
		PlayRepeatedly,
		DoNotPlay,
		PlayUsingSceneTimeBase
	}

	// Utility enum
	public enum SCNPhysicsSearchMode {
		Unknown = -1,
		Any, Closest, All,
	}

	[Native]
	public enum SCNAntialiasingMode : ulong {
		None,
		Multisampling2X,
		Multisampling4X,
#if MONOMAC || __MACCATALYST__
		[NoiOS][NoTV]
		Multisampling8X,
		[NoiOS][NoTV]
		Multisampling16X,
#endif
	}

	[Native]
	public enum SCNPhysicsCollisionCategory : ulong {
		None = 0,
		Default = 1 << 0,
		Static = 1 << 1,
		All = UInt64.MaxValue
	}

	[Native]
	public enum SCNBillboardAxis : ulong {
		X = 1 << 0,
		Y = 1 << 1,
		Z = 1 << 2,
		All = (X | Y | Z)
	}

	[Native]
	public enum SCNReferenceLoadingPolicy : long {
		Immediate = 0,
		OnDemand = 1
	}

	[Native]
	public enum SCNBlendMode : long {
		Alpha = 0,
		Add = 1,
		Subtract = 2,
		Multiply = 3,
		Screen = 4,
		Replace = 5,
		[Watch (4, 0), TV (11, 0), iOS (11, 0)]
		Max = 6,
	}

	[Native]
	[Flags]
	public enum SCNDebugOptions : ulong {
		None = 0,
		ShowPhysicsShapes = 1 << 0,
		ShowBoundingBoxes = 1 << 1,
		ShowLightInfluences = 1 << 2,
		ShowLightExtents = 1 << 3,
		ShowPhysicsFields = 1 << 4,
		ShowWireframe = 1 << 5,
		[Watch (4, 0), TV (11, 0), iOS (11, 0)]
		RenderAsWireframe = 1 << 6,
		[Watch (4, 0), TV (11, 0), iOS (11, 0)]
		ShowSkeletons = 1 << 7,
		[Watch (4, 0), TV (11, 0), iOS (11, 0)]
		ShowCreases = 1 << 8,
		[Watch (4, 0), TV (11, 0), iOS (11, 0)]
		ShowConstraints = 1 << 9,
		[Watch (4, 0), TV (11, 0), iOS (11, 0)]
		ShowCameras = 1 << 10,
	}

	[Native]
	public enum SCNRenderingApi : ulong {
		Metal,
#if !MONOMAC
		[Unavailable (PlatformName.MacCatalyst)]
		[NoMac]
		OpenGLES2,
#else
		[NoiOS][NoTV][NoMacCatalyst]
		OpenGLLegacy,
		[NoiOS][NoTV][NoMacCatalyst]
		OpenGLCore32,
		[NoiOS][NoTV][NoMacCatalyst]
		OpenGLCore41
#endif
	}

	[Native]
	public enum SCNBufferFrequency : long {
		Frame = 0,
		Node = 1,
		Shadable = 2,
	}

	[Native]
	public enum SCNMovabilityHint : long {
		Fixed,
		Movable
	}

	[Watch (4, 0), TV (11, 0), iOS (11, 0)]
	[Native]
	[Flags]
	public enum SCNColorMask : long {
		None = 0,
		Red = 1 << 3,
		Green = 1 << 2,
		Blue = 1 << 1,
		Alpha = 1 << 0,
		All = 15,
	}

	[Watch (4, 0), TV (11, 0), iOS (11, 0)]
	[Native]
	public enum SCNInteractionMode : long {
		Fly,
		OrbitTurntable,
		OrbitAngleMapping,
		OrbitCenteredArcball,
		OrbitArcball,
		Pan,
		Truck,
	}

	[Watch (4, 0), TV (11, 0), iOS (11, 0)]
	[Native]
	public enum SCNFillMode : ulong {
		Fill = 0,
		Lines = 1,
	}

	[NoWatch, iOS (11, 0)]
	[TV (12, 0)]
	[Native]
	public enum SCNTessellationSmoothingMode : long {
		None = 0,
		PNTriangles,
		Phong,
	}
	[Watch (4, 0), TV (11, 0), iOS (11, 0)]
	[Native]
	public enum SCNHitTestSearchMode : long {
		Closest = 0,
		All = 1,
		Any = 2,
	}

	[Watch (4, 0), TV (11, 0), iOS (11, 0)]
	[Native]
	public enum SCNCameraProjectionDirection : long {
		Vertical = 0,
		Horizontal = 1,
	}

	[Watch (4, 0), TV (11, 0), iOS (11, 0)]
	[Native]
	public enum SCNNodeFocusBehavior : long {
		None = 0,
		Occluding,
		Focusable,
	}

	[Watch (6, 0), TV (13, 0), Mac (10, 15), iOS (13, 0)]
	[Native]
	public enum SCNLightProbeType : long {
		Irradiance = 0,
		Radiance = 1,
	}

	[Watch (6, 0), TV (13, 0), Mac (10, 15), iOS (13, 0)]
	[Native]
	public enum SCNLightProbeUpdateType : long {
		Never = 0,
		Realtime = 1,
	}

	[Watch (6, 0), TV (13, 0), Mac (10, 15), iOS (13, 0)]
	[Native]
	public enum SCNLightAreaType : long {
		Rectangle = 1,
		Polygon = 4,
	}

	public enum SCNPhysicsShapeType {
		ConvexHull,
		BoundingBox,
		ConcavePolyhedron,
	}
}
