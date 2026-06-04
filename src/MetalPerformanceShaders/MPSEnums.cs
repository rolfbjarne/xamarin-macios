
using Metal;

namespace MetalPerformanceShaders {

	/// <summary>Enumerates ORable kernel options that improve performance in certain cases.</summary>
	[Introduced (PlatformName.MacCatalyst, 13, 0)]
	[Native] // NSUInteger
	[Flags] // NS_OPTIONS
	public enum MPSKernelOptions : ulong {
		/// <summary>Validate the kernel and use standard-precision types in calculations. Default.</summary>
		None = 0,
		/// <summary>Skip Metal's validation layer.</summary>
		SkipApiValidation = 1 << 0,
		/// <summary>Allow the use of reduced-precision types in calculations.</summary>
		AllowReducedPrecision = 1 << 1,
		/// <summary>Disable internal tiling.</summary>
		[MacCatalyst (13, 1)]
		DisableInternalTiling = 1 << 2,
		/// <summary>Insert debug groups.</summary>
		[MacCatalyst (13, 1)]
		InsertDebugGroups = 1 << 3,
		/// <summary>Enable verbose output.</summary>
		[MacCatalyst (13, 1)]
		Verbose = 1 << 4,
	}

	/// <summary>Enumerates shader behavior at the edges of regions and images.</summary>
	[Introduced (PlatformName.MacCatalyst, 13, 0)]
	[Native] // NSUInteger
	public enum MPSImageEdgeMode : ulong {
		/// <summary>Pixels outside the region of interest are set to zero. (The alpha channel is set to 0.0 for pixels with an alpha channel, and to 1.0 for those without.)</summary>
		Zero,
		/// <summary>Pixels outside the region of interest are clamped to the values at the edge of the region.</summary>
		Clamp = 1,
		/// <summary>Mirror the edge values.</summary>
		[MacCatalyst (13, 1)]
		Mirror,
		/// <summary>Mirror with the edge value repeated.</summary>
		[MacCatalyst (13, 1)]
		MirrorWithEdge,
		/// <summary>Pad with a constant value.</summary>
		[MacCatalyst (13, 1)]
		Constant,
	}

	/// <summary>Enumerates values that indicate if and what kind of color premultiplication will be applied to color values.</summary>
	[MacCatalyst (13, 1)]
	[Native]
	public enum MPSAlphaType : ulong {
		/// <summary>Indicates that the image will not be premultiplied, and the alpha channel will not be guaranteed to be 1.</summary>
		NonPremultiplied = 0,
		/// <summary>Indicates that the alpha channel will be clamped to 1, even if it is not encoded in the source data.</summary>
		AlphaIsOne = 1,
		/// <summary>Indicates that the image will be premultiplied, and the alpha channel will not be guaranteed to be 1.</summary>
		Premultiplied = 2,
	}

	/// <summary>Enumerates values that specify floating point data types.</summary>
	[Introduced (PlatformName.MacCatalyst, 13, 0)]
	public enum MPSDataType : uint { // uint32_t
		/// <summary>An invalid data type.</summary>
		Invalid = 0,

		/// <summary>Indicates floating point format data of any width.</summary>
		FloatBit = 0x10000000,
		/// <summary>16-bit floating point.</summary>
		Float16 = FloatBit | 16,
		/// <summary>Indicates 32-bit floating point format data.</summary>
		Float32 = FloatBit | 32,

		[iOS (16, 2), MacCatalyst (16, 2), TV (16, 2)]
		ComplexBit = 0x01000000,
		[iOS (16, 2), MacCatalyst (16, 2), TV (16, 2)]
		ComplexFloat32 = FloatBit | ComplexBit | 64,
		[iOS (16, 2), MacCatalyst (16, 2), TV (16, 2)]
		ComplexFloat16 = FloatBit | ComplexBit | 32,
		[iOS (26, 4), MacCatalyst (26, 4), TV (26, 4)]
		ComplexBFloat16 = AlternateEncodingBit | FloatBit | ComplexBit | 32,

		/// <summary>The signed bit flag.</summary>
		SignedBit = 0x20000000,
		[TV (18, 4), Mac (15, 4), iOS (18, 4), MacCatalyst (18, 4)]
		Int2 = SignedBit | 2,
		[TV (18, 0), Mac (15, 0), iOS (18, 0), MacCatalyst (18, 0)]
		Int4 = SignedBit | 4,
		/// <summary>8-bit signed integer.</summary>
		Int8 = SignedBit | 8,
		/// <summary>16-bit signed integer.</summary>
		Int16 = SignedBit | 16,
		Int32 = SignedBit | 32,
		[iOS (14, 1)]
		[TV (14, 2)]
		[MacCatalyst (14, 1)]
		Int64 = SignedBit | 64,

		[TV (18, 4), Mac (15, 4), iOS (18, 4), MacCatalyst (18, 4)]
		UInt2 = 2,
		[TV (18, 0), Mac (15, 0), iOS (18, 0), MacCatalyst (18, 0)]
		UInt4 = 4,
		/// <summary>8-bit unsigned integer.</summary>
		UInt8 = 8,
		/// <summary>16-bit unsigned integer.</summary>
		UInt16 = 16,
		/// <summary>32-bit unsigned integer.</summary>
		UInt32 = 32,
		[iOS (14, 1)]
		[TV (14, 2)]
		[MacCatalyst (14, 1)]
		UInt64 = 64,

		[iOS (15, 0), MacCatalyst (15, 0), TV (15, 0)]
		AlternateEncodingBit = 0x80000000,
		[iOS (15, 0), MacCatalyst (15, 0), TV (15, 0)]
		Bool = AlternateEncodingBit | 8,
		[iOS (16, 0), MacCatalyst (16, 0), TV (16, 0), Mac (14, 0)]
		BFloat16 = AlternateEncodingBit | Float16,

		/// <summary>The normalized bit flag.</summary>
		[MacCatalyst (13, 1)]
		NormalizedBit = 0x40000000,
		/// <summary>1-bit unsigned normalized.</summary>
		[MacCatalyst (13, 1)]
		Unorm1 = NormalizedBit | 1,
		/// <summary>8-bit unsigned normalized.</summary>
		[MacCatalyst (13, 1)]
		Unorm8 = NormalizedBit | 8,
	}

	[Flags]
	[Native]
	[iOS (13, 0), TV (13, 0)]
	[Introduced (PlatformName.MacCatalyst, 13, 0)]
	public enum MPSAliasingStrategy : ulong {
		Default = 0x0,
		DontCare = Default,
		ShallAlias = 1uL << 0,
		ShallNotAlias = 1uL << 1,
		AliasingReserved = ShallAlias | ShallNotAlias,
		PreferTemporaryMemory = 1uL << 2,
		PreferNonTemporaryMemory = 1uL << 3,
	}

	/// <summary>Enumerates image channel descriptions.</summary>
	[Introduced (PlatformName.MacCatalyst, 13, 0)]
	[Native]
	public enum MPSImageFeatureChannelFormat : ulong {
		/// <summary>Indicates an invalid format.</summary>
		Invalid = 0,
		/// <summary>Indicates an unsigned 8-bit integer that encodes values in [0,1.0].</summary>
		Unorm8 = 1,
		/// <summary>Indicates an unsigned 16-bit integer that encodes values in [0,1.0].</summary>
		Unorm16 = 2,
		/// <summary>Indicates a half-precision floating point format.</summary>
		Float16 = 3,
		/// <summary>Indicates a single-precision floating point format.</summary>
		Float32 = 4,
		[iOS (13, 0), TV (13, 0)]
		[MacCatalyst (13, 1)]
		Reserved0 = 5,

		//Count, // must always be last, and because of this it will cause breaking changes.
	}

	/// <summary>Enumerates the result forms of a matrix decomposition.</summary>
	[Introduced (PlatformName.MacCatalyst, 13, 0)]
	public enum MPSMatrixDecompositionStatus {
		/// <summary>Success.</summary>
		Success = 0,
		/// <summary>Failure.</summary>
		Failure = -1,
		/// <summary>Singular.</summary>
		Singular = -2,
		/// <summary>Non Positive Definite.</summary>
		NonPositiveDefinite = -3,
	}

	[iOS (13, 0), TV (13, 0)]
	[Introduced (PlatformName.MacCatalyst, 13, 0)]
	[Flags]
	[Native]
	public enum MPSMatrixRandomDistribution : ulong {
		Default = 0x1,
		Uniform = 0x2,
		[iOS (14, 0), TV (14, 0)]
		[Introduced (PlatformName.MacCatalyst, 14, 0)]
		Normal = Default | Uniform,
	}

	/// <summary>Enumerates the propagation direction in a layer in a recurrent neural net.</summary>
	[MacCatalyst (13, 1)]
	[Native]
	public enum MPSRnnSequenceDirection : ulong {
		/// <summary>Forward.</summary>
		Forward = 0,
		/// <summary>Backward.</summary>
		Backward,
	}

	/// <summary>Enumerates how input matrices or images should be combined in a recurrent neural net.</summary>
	[MacCatalyst (13, 1)]
	[Native]
	public enum MPSRnnBidirectionalCombineMode : ulong {
		/// <summary>No value specified.</summary>
		None = 0,
		/// <summary>Add.</summary>
		Add,
		/// <summary>Concatenate.</summary>
		Concatenate,
	}

	/// <summary>Enumerates the available activation functions of a neuron.</summary>
	[MacCatalyst (13, 1)]
	public enum MPSCnnNeuronType {
		/// <summary>No value specified.</summary>
		None = 0,
		/// <summary>Re L U.</summary>
		ReLU,
		/// <summary>Linear.</summary>
		Linear,
		/// <summary>Sigmoid.</summary>
		Sigmoid,
		/// <summary>Hard Sigmoid.</summary>
		HardSigmoid,
		/// <summary>Tan H.</summary>
		TanH,
		/// <summary>Absolute.</summary>
		Absolute,
		/// <summary>Soft Plus.</summary>
		SoftPlus,
		/// <summary>Soft Sign.</summary>
		SoftSign,
		/// <summary>Elu.</summary>
		Elu,
		/// <summary>P Re L U.</summary>
		PReLU,
		/// <summary>Re Lun.</summary>
		ReLun,
		/// <summary>Power.</summary>
		[MacCatalyst (13, 1)]
		Power,
		/// <summary>Exponential.</summary>
		[MacCatalyst (13, 1)]
		Exponential,
		/// <summary>Logarithm.</summary>
		[MacCatalyst (13, 1)]
		Logarithm,
		[TV (13, 0), iOS (13, 0)]
		[MacCatalyst (13, 1)]
		GeLU,
	}

	/// <summary>Flagging enumeration for options available to binary convolution kernels.</summary>
	[MacCatalyst (13, 1)]
	[Native]
	[Flags]
	public enum MPSCnnBinaryConvolutionFlags : ulong {
		/// <summary>No value specified.</summary>
		None = 0,
		/// <summary>Use Beta Scaling.</summary>
		UseBetaScaling = 1 << 0,
	}

	/// <summary>Enumerates the operation used in a binary convolution.</summary>
	[MacCatalyst (13, 1)]
	[Native]
	public enum MPSCnnBinaryConvolutionType : ulong {
		/// <summary>Binary Weights.</summary>
		BinaryWeights = 0,
		/// <summary>Xnor.</summary>
		Xnor,
		/// <summary>And.</summary>
		And,
	}

	/// <summary>Options for how a neural network graph will pad results.</summary>
	[MacCatalyst (13, 1)]
	[Native]
	public enum MPSNNPaddingMethod : ulong {
		/// <summary>Align Centered.</summary>
		AlignCentered = 0,
		/// <summary>Align Top Left.</summary>
		AlignTopLeft = 1,
		/// <summary>Align Bottom Right.</summary>
		AlignBottomRight = 2,
		/// <summary>Align Reserved.</summary>
		AlignReserved = 3,
		/// <summary>Add Remainder To Top Left.</summary>
		AddRemainderToTopLeft = 0 << 2,
		/// <summary>Add Remainder To Top Right.</summary>
		AddRemainderToTopRight = 1 << 2,
		/// <summary>Add Remainder To Bottom Left.</summary>
		AddRemainderToBottomLeft = 2 << 2,
		/// <summary>Add Remainder To Bottom Right.</summary>
		AddRemainderToBottomRight = 3 << 2,
		/// <summary>Size Valid Only.</summary>
		SizeValidOnly = 0,
		/// <summary>Size Same.</summary>
		SizeSame = 1 << 4,
		/// <summary>Size Full.</summary>
		SizeFull = 2 << 4,
		/// <summary>Size Reserved.</summary>
		SizeReserved = 3 << 4,
		/// <summary>Custom Whitelist For Node Fusion.</summary>
		CustomWhitelistForNodeFusion = (1 << 13),
		/// <summary>Custom.</summary>
		Custom = (1 << 14),
		/// <summary>Size Mask.</summary>
		SizeMask = 2032,
		/// <summary>Exclude Edges.</summary>
		ExcludeEdges = (1 << 15),
	}

	/// <summary>Enumerates whether a data buffer is row- or column-major</summary>
	[Introduced (PlatformName.MacCatalyst, 13, 0)]
	[Native]
	public enum MPSDataLayout : ulong {
		/// <summary>Height Per Width Per Feature Channels.</summary>
		HeightPerWidthPerFeatureChannels = 0,
		/// <summary>Feature Channels Per Height Per Width.</summary>
		FeatureChannelsPerHeightPerWidth = 1,
	}

	[Introduced (PlatformName.MacCatalyst, 13, 0)]
	[Native]
	public enum MPSStateResourceType : ulong {
		/// <summary>No value specified.</summary>
		None = 0,
		/// <summary>Buffer.</summary>
		Buffer = 1,
		/// <summary>Texture.</summary>
		Texture = 2,
	}

	[MacCatalyst (13, 1)]
	[Native]
	public enum MPSIntersectionType : ulong {
		/// <summary>Nearest.</summary>
		Nearest = 0,
		/// <summary>Any.</summary>
		Any = 1,
	}

	[MacCatalyst (13, 1)]
	[Native]
	public enum MPSTriangleIntersectionTestType : ulong {
		/// <summary>The default value.</summary>
		Default = 0,
		/// <summary>Watertight.</summary>
		Watertight = 1,
	}

	[MacCatalyst (13, 1)]
	[Native]
	public enum MPSBoundingBoxIntersectionTestType : ulong {
		/// <summary>The default value.</summary>
		Default = 0,
		/// <summary>Axis Aligned.</summary>
		AxisAligned = 1,
		[TV (13, 0), iOS (13, 0)]
		[MacCatalyst (13, 1)]
		Fast = 2,
	}

	[MacCatalyst (13, 1)]
	[Flags]
	[Native]
	public enum MPSRayMaskOptions : ulong {
		/// <summary>No value specified.</summary>
		None = 0,
		/// <summary>Primitive.</summary>
		Primitive = 1,
		/// <summary>Instance.</summary>
		Instance = 2,
	}

	[MacCatalyst (13, 1)]
	[Native]
	public enum MPSRayDataType : ulong {
		/// <summary>Origin Direction.</summary>
		OriginDirection = 0,
		/// <summary>Origin Min Distance Direction Max Distance.</summary>
		OriginMinDistanceDirectionMaxDistance = 1,
		/// <summary>Origin Mask Direction Max Distance.</summary>
		OriginMaskDirectionMaxDistance = 2,
		[TV (13, 0), iOS (13, 0)]
		[MacCatalyst (13, 1)]
		PackedOriginDirection = 3,
	}

	[MacCatalyst (13, 1)]
	[Native]
	public enum MPSIntersectionDataType : ulong {
		/// <summary>Distance.</summary>
		Distance = 0,
		/// <summary>Primitive Index.</summary>
		PrimitiveIndex = 1,
		/// <summary>Primitive Index Coordinates.</summary>
		PrimitiveIndexCoordinates = 2,
		/// <summary>Primitive Index Instance Index.</summary>
		PrimitiveIndexInstanceIndex = 3,
		/// <summary>Primitive Index Instance Index Coordinates.</summary>
		PrimitiveIndexInstanceIndexCoordinates = 4,

		[iOS (15, 0), TV (15, 0), MacCatalyst (15, 0)]
		PrimitiveIndexBufferIndex = 5,

		[iOS (15, 0), TV (15, 0), MacCatalyst (15, 0)]
		PrimitiveIndexBufferIndexCoordinates = 6,

		[iOS (15, 0), TV (15, 0), MacCatalyst (15, 0)]
		PrimitiveIndexBufferIndexInstanceIndex = 7,

		[iOS (15, 0), TV (15, 0), MacCatalyst (15, 0)]
		PrimitiveIndexBufferIndexInstanceIndexCoordinates = 8,
	}

	[MacCatalyst (13, 1)]
	[Native]
	public enum MPSTransformType : ulong {
		/// <summary>Float4x4.</summary>
		Float4x4 = 0,
		/// <summary>Identity.</summary>
		Identity = 1,
	}

	[MacCatalyst (13, 1)]
	[Flags]
	[Native]
	public enum MPSAccelerationStructureUsage : ulong {
		/// <summary>No value specified.</summary>
		None = 0,
		/// <summary>Refit.</summary>
		Refit = 1,
		/// <summary>Frequent Rebuild.</summary>
		FrequentRebuild = 2,
		[TV (13, 0), iOS (13, 0)]
		[MacCatalyst (13, 1)]
		PreferGpuBuild = 4,
		[TV (13, 0), iOS (13, 0)]
		[MacCatalyst (13, 1)]
		PreferCpuBuild = 8,
	}

	[MacCatalyst (13, 1)]
	[Native]
	public enum MPSAccelerationStructureStatus : ulong {
		/// <summary>Unbuilt.</summary>
		Unbuilt = 0,
		/// <summary>Built.</summary>
		Built = 1,
	}

	[MacCatalyst (13, 1)]
	public enum MPSCnnWeightsQuantizationType : uint {
		/// <summary>No value specified.</summary>
		None = 0,
		/// <summary>Linear.</summary>
		Linear = 1,
		/// <summary>Lookup Table.</summary>
		LookupTable = 2,
	}

	[Flags]
	[Native]
	[MacCatalyst (13, 1)]
	public enum MPSCnnConvolutionGradientOption : ulong {
		/// <summary>Gradient With Data.</summary>
		GradientWithData = 0x1,
		/// <summary>Gradient With Weights And Bias.</summary>
		GradientWithWeightsAndBias = 0x2,
		/// <summary>All.</summary>
		All = GradientWithData | GradientWithWeightsAndBias,
	}

	[Flags]
	[Native]
	[MacCatalyst (13, 1)]
	public enum MPSNNComparisonType : ulong {
		/// <summary>Equal.</summary>
		Equal,
		/// <summary>Not Equal.</summary>
		NotEqual,
		/// <summary>Less.</summary>
		Less,
		/// <summary>Less Or Equal.</summary>
		LessOrEqual,
		/// <summary>Greater.</summary>
		Greater,
		/// <summary>Greater Or Equal.</summary>
		GreaterOrEqual,
	}

	[Introduced (PlatformName.MacCatalyst, 13, 0)]
	public enum MPSCnnLossType : uint {
		/// <summary>Mean Absolute Error.</summary>
		MeanAbsoluteError = 0,
		/// <summary>Mean Squared Error.</summary>
		MeanSquaredError,
		/// <summary>Soft Max Cross Entropy.</summary>
		SoftMaxCrossEntropy,
		/// <summary>Sigmoid Cross Entropy.</summary>
		SigmoidCrossEntropy,
		/// <summary>Categorical Cross Entropy.</summary>
		CategoricalCrossEntropy,
		/// <summary>Hinge.</summary>
		Hinge,
		/// <summary>Huber.</summary>
		Huber,
		/// <summary>Cosine Distance.</summary>
		CosineDistance,
		/// <summary>Log.</summary>
		Log,
		/// <summary>Kullback Leibler Divergence.</summary>
		KullbackLeiblerDivergence,
		//Count, // must always be last, and because of this it will cause breaking changes.
	}

	[Introduced (PlatformName.MacCatalyst, 13, 0)]
	public enum MPSCnnReductionType {
		/// <summary>No value specified.</summary>
		None = 0,
		/// <summary>Sum.</summary>
		Sum,
		/// <summary>Mean.</summary>
		Mean,
		/// <summary>Sum By Non Zero Weights.</summary>
		SumByNonZeroWeights,
		//Count, // must always be last, and because of this it will cause breaking changes.
	}

	[Flags]
	[Native]
	[MacCatalyst (13, 1)]
	public enum MPSNNConvolutionAccumulatorPrecisionOption : ulong {
		/// <summary>Half.</summary>
		Half = 0x0,
		/// <summary>Float.</summary>
		Float = 1uL << 0,
	}

	[Flags]
	[Native]
	[MacCatalyst (13, 1)]
	public enum MPSCnnBatchNormalizationFlags : ulong {
		/// <summary>The default value.</summary>
		Default = 0x0,
		/// <summary>Calculate Statistics Automatic.</summary>
		CalculateStatisticsAutomatic = Default,
		/// <summary>Calculate Statistics Always.</summary>
		CalculateStatisticsAlways = 0x1,
		/// <summary>Calculate Statistics Never.</summary>
		CalculateStatisticsNever = 0x2,
		/// <summary>Calculate Statistics Mask.</summary>
		CalculateStatisticsMask = 0x3,
	}

	[MacCatalyst (13, 1)]
	[Native]
	public enum MPSNNRegularizationType : ulong {
		/// <summary>No value specified.</summary>
		None = 0,
		/// <summary>L1.</summary>
		L1 = 1,
		/// <summary>L2.</summary>
		L2 = 2,
	}

	[MacCatalyst (13, 1)]
	[Flags]
	[Native]
	public enum MPSNNTrainingStyle : ulong {
		/// <summary>No value specified.</summary>
		None = 0x0,
		/// <summary>Cpu.</summary>
		Cpu = 0x1,
		/// <summary>Gpu.</summary>
		Gpu = 0x2,
	}

	[Native]
	[MacCatalyst (13, 1)]
	public enum MPSRnnMatrixId : ulong {
		/// <summary>Single Gate Input Weights.</summary>
		SingleGateInputWeights = 0,
		/// <summary>Single Gate Recurrent Weights.</summary>
		SingleGateRecurrentWeights,
		/// <summary>Single Gate Bias Terms.</summary>
		SingleGateBiasTerms,
		/// <summary>Lstm Input Gate Input Weights.</summary>
		LstmInputGateInputWeights,
		/// <summary>Lstm Input Gate Recurrent Weights.</summary>
		LstmInputGateRecurrentWeights,
		/// <summary>Lstm Input Gate Memory Weights.</summary>
		LstmInputGateMemoryWeights,
		/// <summary>Lstm Input Gate Bias Terms.</summary>
		LstmInputGateBiasTerms,
		/// <summary>Lstm Forget Gate Input Weights.</summary>
		LstmForgetGateInputWeights,
		/// <summary>Lstm Forget Gate Recurrent Weights.</summary>
		LstmForgetGateRecurrentWeights,
		/// <summary>Lstm Forget Gate Memory Weights.</summary>
		LstmForgetGateMemoryWeights,
		/// <summary>Lstm Forget Gate Bias Terms.</summary>
		LstmForgetGateBiasTerms,
		/// <summary>Lstm Memory Gate Input Weights.</summary>
		LstmMemoryGateInputWeights,
		/// <summary>Lstm Memory Gate Recurrent Weights.</summary>
		LstmMemoryGateRecurrentWeights,
		/// <summary>Lstm Memory Gate Memory Weights.</summary>
		LstmMemoryGateMemoryWeights,
		/// <summary>Lstm Memory Gate Bias Terms.</summary>
		LstmMemoryGateBiasTerms,
		/// <summary>Lstm Output Gate Input Weights.</summary>
		LstmOutputGateInputWeights,
		/// <summary>Lstm Output Gate Recurrent Weights.</summary>
		LstmOutputGateRecurrentWeights,
		/// <summary>Lstm Output Gate Memory Weights.</summary>
		LstmOutputGateMemoryWeights,
		/// <summary>Lstm Output Gate Bias Terms.</summary>
		LstmOutputGateBiasTerms,
		/// <summary>Gru Input Gate Input Weights.</summary>
		GruInputGateInputWeights,
		/// <summary>Gru Input Gate Recurrent Weights.</summary>
		GruInputGateRecurrentWeights,
		/// <summary>Gru Input Gate Bias Terms.</summary>
		GruInputGateBiasTerms,
		/// <summary>Gru Recurrent Gate Input Weights.</summary>
		GruRecurrentGateInputWeights,
		/// <summary>Gru Recurrent Gate Recurrent Weights.</summary>
		GruRecurrentGateRecurrentWeights,
		/// <summary>Gru Recurrent Gate Bias Terms.</summary>
		GruRecurrentGateBiasTerms,
		/// <summary>Gru Output Gate Input Weights.</summary>
		GruOutputGateInputWeights,
		/// <summary>Gru Output Gate Recurrent Weights.</summary>
		GruOutputGateRecurrentWeights,
		/// <summary>Gru Output Gate Input Gate Weights.</summary>
		GruOutputGateInputGateWeights,
		/// <summary>Gru Output Gate Bias Terms.</summary>
		GruOutputGateBiasTerms,
		//Count, // must always be last, and because of this it will cause breaking changes.
	}

	[Introduced (PlatformName.MacCatalyst, 13, 0)]
	public enum MPSCustomKernelIndex : uint {
		DestIndex = 0,
		Src0Index = 0,
		Src1Index = 1,
		Src2Index = 2,
		Src3Index = 3,
		Src4Index = 4,
		UserDataIndex = 30,
	}

	[Introduced (PlatformName.MacCatalyst, 13, 0)]
	public enum MPSImageType : uint {
		Type2d = 0,
		Type2dArray = 1,
		Array2d = 2,
		Array2dArray = 3,

		ArrayMask = 1,
		BatchMask = 2,
		TypeMask = 3,
		NoAlpha = 4,
		TexelFormatMask = 56,
		TexelFormatShift = 3,
		TexelFormatStandard = 0u << (int) TexelFormatShift,
		TexelFormatUnorm8 = 1u << (int) TexelFormatShift,
		TexelFormatFloat16 = 2u << (int) TexelFormatShift,
		TexelFormatBFloat16 = 3u << (int) TexelFormatShift,
		BitCount = 6,
		Mask = (1u << (int) BitCount) - 1,
		Type2dNoAlpha = Type2d | NoAlpha,
		Type2dArrayNoAlpha = Type2dArray | NoAlpha,
		Array2dNoAlpha = Type2d | BatchMask | NoAlpha,
		Array2dArrayNoAlpha = Type2dArray | BatchMask | NoAlpha,

		DestTextureType = (MPSConstants.FunctionConstantIndex >> (int) (0 * BitCount)) & Mask,
		Src0TextureType = (MPSConstants.FunctionConstantIndex >> (int) (0 * BitCount)) & Mask,
		Src1TextureType = (MPSConstants.FunctionConstantIndex >> (int) (1 * BitCount)) & Mask,
		Src2TextureType = (MPSConstants.FunctionConstantIndex >> (int) (2 * BitCount)) & Mask,
		Src3TextureType = (MPSConstants.FunctionConstantIndex >> (int) (3 * BitCount)) & Mask,
		Src4TextureType = (MPSConstants.FunctionConstantIndex >> (int) (4 * BitCount)) & Mask,
	}

	[Flags]
	[Native]
	[Introduced (PlatformName.MacCatalyst, 13, 0)]
	public enum MPSDeviceOptions : ulong {
		Default = 0x0,
		LowPower = 0x1,
		SkipRemovable = 0x2,
	}
}
