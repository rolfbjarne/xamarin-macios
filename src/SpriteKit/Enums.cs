//
// Enums.cs: enums for SpriteKit
//
// Authors:
//   Aaron Bockover (abock@xamarin.com)
//
// Copyright 2013-2014 Xamarin Inc

#nullable enable

namespace SpriteKit {

	// NSInteger -> SKKeyframeSequence.h
	/// <summary>An enumeration whose values specify the interpolation mode of a <see cref="SpriteKit.SKKeyframeSequence" />.</summary>
	[Native]
	public enum SKInterpolationMode : long {
		/// <summary>Interpolate values linearly.</summary>
		Linear = 1,
		/// <summary>Interpolate values with a B-spline.</summary>
		Spline = 2,
		/// <summary>Do not interpolate values. (Use the value at the latest time that is before the current time.)</summary>
		Step = 3,
	}

	// NSInteger -> SKKeyframeSequence.h
	/// <summary>An enumeration whose values specify whether the time value of a <see cref="SpriteKit.SKKeyframeSequence" /> should cycle.</summary>
	[Native]
	public enum SKRepeatMode : long {
		/// <summary>After the last keyframe's time sequence is past, the last keyframe's value is returned.</summary>
		Clamp = 1,
		/// <summary>After the last keyframe's time sequence is past, the sequence loops back to the first keyframe.</summary>
		Loop = 2,
	}

	// NSInteger -> SKAction.h
	/// <summary>An enumeration whose values specify the time-varying behavior of a <see cref="SpriteKit.SKAction" />. Used with <see cref="SpriteKit.SKAction.TimingMode" />.</summary>
	[Native]
	public enum SKActionTimingMode : long {
		/// <summary>Render the animation with no easing.</summary>
		Linear = 0,
		/// <summary>Ease the animation in.</summary>
		EaseIn = 1,
		/// <summary>Ease the animation out.</summary>
		EaseOut = 2,
		/// <summary>Ease the animation in and out.</summary>
		EaseInEaseOut = 3,
	}

	// NSInteger -> SKLabelNode.h
	/// <summary>
	///  An enumeration whose values specify vertical alignment of a <see cref="SpriteKit.SKLabelNode" />. Used with <see cref="SpriteKit.SKLabelNode.VerticalAlignmentMode" /></summary>
	[Native]
	public enum SKLabelVerticalAlignmentMode : long {
		/// <summary>Place the baseline at the node's origin.</summary>
		Baseline = 0,
		/// <summary>Place the text at the vertical center of the node.</summary>
		Center = 1,
		/// <summary>Place the top of the text at the node's origin.</summary>
		Top = 2,
		/// <summary>Place the bottom of the text at the node's origin.</summary>
		Bottom = 3,
	}

	// NSInteger -> SKLabelNode.h
	/// <summary>An enumeration whose values specify horizontal alignment of a <see cref="SpriteKit.SKLabelNode" />. Used with <see cref="SpriteKit.SKLabelNode.HorizontalAlignmentMode" /></summary>
	[Native]
	public enum SKLabelHorizontalAlignmentMode : long {
		/// <summary>Place the text in the horizontal center of the node.</summary>
		Center = 0,
		/// <summary>Place the left edge of the text at the node's origin.</summary>
		Left = 1,
		/// <summary>Place the right edge of the text at the node's origin.</summary>
		Right = 2,
	}

	// NSInteger -> SKNode.h
	/// <summary>An enumeration whose values specify options for blending of visual <see cref="SpriteKit.SKNode" />s or particles.</summary>
	[Native]
	public enum SKBlendMode : long {
		/// <summary>The alpha value of the source color is used to blend the colors.</summary>
		Alpha = 0,
		/// <summary>The colors are added.</summary>
		Add = 1,
		/// <summary>The source color is subtracted from the destination.</summary>
		Subtract = 2,
		/// <summary>The colors are multiplied.</summary>
		Multiply = 3,
		/// <summary>The colors are multiplied and then doubled.</summary>
		MultiplyX2 = 4,
		/// <summary>The inverted source color is multiplied by the destination color, and the source color is added to the result..</summary>
		Screen = 5,
		/// <summary>The source color is used.</summary>
		Replace = 6,
		/// <summary>Indicates multiply alpha.</summary>
		MultiplyAlpha = 7,
	}

	// NSInteger -> SKScene.h
	/// <summary>An enumeration whose values specify the way in which a <see cref="SpriteKit.SKScene" /> scales to the view in which it is being displayed.</summary>
	[Native]
	public enum SKSceneScaleMode : long {
		/// <summary>Stretch the scene to fill the view.</summary>
		Fill = 0,
		/// <summary>Scale the scene to fill the view, even if the scene must be cropped.</summary>
		AspectFill = 1,
		/// <summary>Scale the scene to fit the view, possibly letterboxing the scene.</summary>
		AspectFit = 2,
		/// <summary>Resize the scene so that it is the same size and shape as the view.</summary>
		ResizeFill = 3,
	}

	// NSInteger -> SKTexture.h
	/// <summary>An enumeration whose values specify how a <see cref="SpriteKit.SKTexture" /> is rendered on a <see cref="SpriteKit.SKSpriteNode" /> of a different size.</summary>
	[Native]
	public enum SKTextureFilteringMode : long {
		/// <summary>The pixel is calculated using the nearest point in the texture. Faster, lower quality.</summary>
		Nearest = 0,
		/// <summary>The pixel is calculated using a linear filter of the nearby texture pixels. Slower, higher quality.</summary>
		Linear = 1,
	}

	// NSInteger -> SKTransition.h
	/// <summary>An enumeration of directions for use with <see cref="SpriteKit.SKTransition" />s.</summary>
	[Native]
	public enum SKTransitionDirection : long {
		/// <summary>The transition moves from bottom to top.</summary>
		Up = 0,
		/// <summary>The transition moves from top to bottom.</summary>
		Down = 1,
		/// <summary>The transition moves from left to right.</summary>
		Right = 2,
		/// <summary>The transition moves from right to left.</summary>
		Left = 3,
	}

	/// <summary>Contains values that describe the data with which an <see cref="SpriteKit.SKUniform" /> was initialized.</summary>
	[Native]
	public enum SKUniformType : long {
		/// <summary>The <see cref="SpriteKit.SKUniform" /> has not been initialized.</summary>
		None,
		/// <summary>The <see cref="SpriteKit.SKUniform" /> was initialized with a float.</summary>
		Float,
		/// <summary>The <see cref="SpriteKit.SKUniform" /> was initialized with a vector that contains 2 floats.</summary>
		FloatVector2,
		/// <summary>The <see cref="SpriteKit.SKUniform" /> was initialized with a vector that contains 3 floats.</summary>
		FloatVector3,
		/// <summary>The <see cref="SpriteKit.SKUniform" /> was initialized with a vector that contains 4 floats.</summary>
		FloatVector4,
		/// <summary>The <see cref="SpriteKit.SKUniform" /> was initialized with a 2x2 array of floats.</summary>
		FloatMatrix2,
		/// <summary>The <see cref="SpriteKit.SKUniform" /> was initialized with a 3x3 array of floats.</summary>
		FloatMatrix3,
		/// <summary>The <see cref="SpriteKit.SKUniform" /> was initialized with a 4x4 array of floats.</summary>
		FloatMatrix4,
		/// <summary>The <see cref="SpriteKit.SKUniform" /> contains texture data.</summary>
		Texture,
	}

	/// <summary>Enumerates values used with <see cref="SpriteKit.SKEmitterNode.ParticleRenderOrder" />.</summary>
	[Native]
	public enum SKParticleRenderOrder : ulong {
		/// <summary>The oldest particles are rendered last.</summary>
		OldestLast,
		/// <summary>The oldest particles are rendered first.</summary>
		OldestFirst,
		/// <summary>Sprite Kit may render the particles in whichever order is best for performance.</summary>
		DontCare,
	}

	/// <summary>Enumeration of valid types for <see cref="SpriteKit.SKAttribute" /> values.</summary>
	[MacCatalyst (13, 1)]
	[Native]
	public enum SKAttributeType : long {
		/// <summary>Indicates none.</summary>
		None = 0,
		/// <summary>Indicates float.</summary>
		Float = 1,
		/// <summary>Indicates vector float2.</summary>
		VectorFloat2 = 2,
		/// <summary>Indicates vector float3.</summary>
		VectorFloat3 = 3,
		/// <summary>Indicates vector float4.</summary>
		VectorFloat4 = 4,
		/// <summary>Indicates half float.</summary>
		HalfFloat = 5,
		/// <summary>Indicates vector half float2.</summary>
		VectorHalfFloat2 = 6,
		/// <summary>Indicates vector half float3.</summary>
		VectorHalfFloat3 = 7,
		/// <summary>Indicates vector half float4.</summary>
		VectorHalfFloat4 = 8,
	}

	/// <summary>Enumerates how a <see cref="SpriteKit.SKTileDefinition" /> kind may be rotated.</summary>
	[MacCatalyst (13, 1)]
	[Native]
	public enum SKTileDefinitionRotation : ulong {
		/// <summary>Indicates angle0.</summary>
		Angle0 = 0,
		/// <summary>Indicates angle90.</summary>
		Angle90,
		/// <summary>Indicates angle180.</summary>
		Angle180,
		/// <summary>Indicates angle270.</summary>
		Angle270,
	}

	/// <summary>Enumerates supported tiling schemes.</summary>
	[MacCatalyst (13, 1)]
	[Native]
	public enum SKTileSetType : ulong {
		/// <summary>Indicates grid.</summary>
		Grid,
		/// <summary>Indicates isometric.</summary>
		Isometric,
		/// <summary>Indicates hexagonal flat.</summary>
		HexagonalFlat,
		/// <summary>Indicates hexagonal pointy.</summary>
		HexagonalPointy,
	}

	/// <summary>Enumerates how neighboring tiles may be automatically placed.</summary>
	[MacCatalyst (13, 1)]
	[Native]
	public enum SKTileAdjacencyMask : ulong {
		/// <summary>Indicates up.</summary>
		Up = 1 << 0,
		/// <summary>Indicates upper right.</summary>
		UpperRight = 1 << 1,
		/// <summary>Indicates right.</summary>
		Right = 1 << 2,
		/// <summary>Indicates lower right.</summary>
		LowerRight = 1 << 3,
		/// <summary>Indicates down.</summary>
		Down = 1 << 4,
		/// <summary>Indicates lower left.</summary>
		LowerLeft = 1 << 5,
		/// <summary>Indicates left.</summary>
		Left = 1 << 6,
		/// <summary>Indicates upper left.</summary>
		UpperLeft = 1 << 7,
		/// <summary>Indicates all.</summary>
		All = Up | UpperRight | Right | LowerRight | Down | LowerLeft | Left | UpperLeft,
		/// <summary>Indicates hex flat up.</summary>
		HexFlatUp = 1 << 0,
		/// <summary>Indicates hex flat upper right.</summary>
		HexFlatUpperRight = 1 << 1,
		/// <summary>Indicates hex flat lower right.</summary>
		HexFlatLowerRight = 1 << 2,
		/// <summary>Indicates hex flat down.</summary>
		HexFlatDown = 1 << 3,
		/// <summary>Indicates hex flat lower left.</summary>
		HexFlatLowerLeft = 1 << 4,
		/// <summary>Indicates hex flat upper left.</summary>
		HexFlatUpperLeft = 1 << 5,
		/// <summary>Indicates hex flat all.</summary>
		HexFlatAll = HexFlatUp | HexFlatUpperRight | HexFlatLowerRight | HexFlatDown | HexFlatLowerLeft | HexFlatUpperLeft,
		/// <summary>Indicates hex pointy upper left.</summary>
		HexPointyUpperLeft = 1 << 0,
		/// <summary>Indicates hex pointy upper right.</summary>
		HexPointyUpperRight = 1 << 1,
		/// <summary>Indicates hex pointy right.</summary>
		HexPointyRight = 1 << 2,
		/// <summary>Indicates hex pointy lower right.</summary>
		HexPointyLowerRight = 1 << 3,
		/// <summary>Indicates hex pointy lower left.</summary>
		HexPointyLowerLeft = 1 << 4,
		/// <summary>Indicates hex pointy left.</summary>
		HexPointyLeft = 1 << 5,
		/// <summary>Indicates hex pointy all.</summary>
		HexPointyAll = HexPointyUpperLeft | HexPointyUpperRight | HexPointyRight | HexPointyLowerRight | HexPointyLowerLeft | HexPointyLeft,
		/// <summary>Indicates up edge.</summary>
		UpEdge = Right | LowerRight | Down | LowerLeft | Left,
		/// <summary>Indicates upper right edge.</summary>
		UpperRightEdge = Down | LowerLeft | Left,
		/// <summary>Indicates right edge.</summary>
		RightEdge = Down | LowerLeft | Left | UpperLeft | Up,
		/// <summary>Indicates lower right edge.</summary>
		LowerRightEdge = Left | UpperLeft | Up,
		/// <summary>Indicates down edge.</summary>
		DownEdge = Up | UpperRight | Right | Left | UpperLeft,
		/// <summary>Indicates lower left edge.</summary>
		LowerLeftEdge = Up | UpperRight | Right,
		/// <summary>Indicates left edge.</summary>
		LeftEdge = Up | UpperRight | Right | LowerRight | Down,
		/// <summary>Indicates upper left edge.</summary>
		UpperLeftEdge = Right | LowerRight | Down,
		/// <summary>Indicates upper right corner.</summary>
		UpperRightCorner = Up | UpperRight | Right | LowerRight | Down | Left | UpperLeft,
		/// <summary>Indicates lower right corner.</summary>
		LowerRightCorner = Up | UpperRight | Right | LowerRight | Down | LowerLeft | Left,
		/// <summary>Indicates lower left corner.</summary>
		LowerLeftCorner = Up | Right | LowerRight | Down | LowerLeft | Left | UpperLeft,
		/// <summary>Indicates upper left corner.</summary>
		UpperLeftCorner = Up | UpperRight | Right | Down | LowerLeft | Left | UpperLeft,
	}

	/// <summary>Enumerates the various ways a <see cref="SpriteKit.SKNode" /> may be focusable.</summary>
	[NoMac]
	[MacCatalyst (13, 1)]
	[Native]
	public enum SKNodeFocusBehavior : long {
		/// <summary>The <see cref="SpriteKit.SKNode" /> is not focusable.</summary>
		None = 0,
		/// <summary>The <see cref="SpriteKit.SKNode" /> is not focusable. It prevents nodes it obscures from being focused.</summary>
		Occluding,
		/// <summary>The <see cref="SpriteKit.SKNode" /> is focusable. It prevents nodes it obscures from being focused.</summary>
		Focusable,
	}
}
