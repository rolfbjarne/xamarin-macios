//
// Authors:
//  Miguel de Icaza (miguel@xamarin.com)
//
// Copyright 2015 Xamarin, Inc.
//
//

using System.ComponentModel;
using System.Numerics;

using AudioUnit;
using CoreFoundation;
using CoreAnimation;
using CoreGraphics;
using SceneKit;

using Vector2d = global::CoreGraphics.NVector2d;
using Vector2i = global::CoreGraphics.NVector2i;
using NVector3d = global::CoreGraphics.NVector3d;
using NVector3 = global::CoreGraphics.NVector3;
using Vector3i = global::CoreGraphics.NVector3i;
using Vector4d = global::CoreGraphics.NVector4d;
using Vector4i = global::CoreGraphics.NVector4i;
using Matrix2 = global::CoreGraphics.NMatrix2;
using Matrix3 = global::CoreGraphics.NMatrix3;
using Matrix4 = global::CoreGraphics.NMatrix4;
using MatrixFloat2x2 = global::CoreGraphics.NMatrix2;
using MatrixFloat3x3 = global::CoreGraphics.NMatrix3;
using MatrixFloat4x4 = global::CoreGraphics.NMatrix4;
using NMatrix4 = global::CoreGraphics.NMatrix4;
using NMatrix4d = global::CoreGraphics.NMatrix4d;
using Quaterniond = global::CoreGraphics.NQuaterniond;

#if MONOMAC
using AppKit;
using AUViewControllerBase = AppKit.NSViewController;
#else
using UIKit;
using AUViewControllerBase = UIKit.UIViewController;
#endif

namespace ModelIO {

	[MacCatalyst (13, 1)]
	[Native]
	enum MDLAnimatedValueInterpolation : ulong {
		/// <summary>Constant interpolation.</summary>
		Constant,
		/// <summary>Linear interpolation.</summary>
		Linear,
	}

	[MacCatalyst (13, 1)]
	[Native]
	enum MDLTransformOpRotationOrder : ulong {
		/// <summary>XYZ rotation order.</summary>
		Xyz = 1,
		/// <summary>XZY rotation order.</summary>
		Xzy,
		/// <summary>YXZ rotation order.</summary>
		Yxz,
		/// <summary>YZX rotation order.</summary>
		Yzx,
		/// <summary>ZXY rotation order.</summary>
		Zxy,
		/// <summary>ZYX rotation order.</summary>
		Zyx,
	}

	[MacCatalyst (13, 1)]
	[Native]
	enum MDLDataPrecision : ulong {
		/// <summary>Undefined precision.</summary>
		Undefined,
		/// <summary>Single-precision floating point.</summary>
		Float,
		/// <summary>Double-precision floating point.</summary>
		Double,
	}

	delegate void MDLObjectHandler (MDLObject mdlObject, ref bool stop);

	/// <summary>A basic high-performance light for illuminating scenes from a lit shape.</summary>
	///     
	///     <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/ModelIO/Reference/MDLAreaLight_Class/index.html">Apple documentation for <c>MDLAreaLight</c></related>
	[MacCatalyst (13, 1)]
	[BaseType (typeof (MDLPhysicallyPlausibleLight))]
	[DisableDefaultCtor]
	interface MDLAreaLight {
		/// <summary>Gets or sets the base linear dimension from which light shapes are calculated.</summary>
		[Export ("areaRadius")]
		float AreaRadius { get; set; }

		/// <summary>Gets or sets the power of a super-elliptically-shaped light.</summary>
		[Export ("superEllipticPower", ArgumentSemantic.Assign)]
		Vector2 SuperEllipticPower {
			[MarshalDirective (NativePrefix = "xamarin_simd__", Library = "__Internal")]
			get;
			[MarshalDirective (NativePrefix = "xamarin_simd__", Library = "__Internal")]
			set;
		}

		/// <summary>Gets or sets the aspect ratio of the light.</summary>
		[Export ("aspect")]
		float Aspect { get; set; }
	}

	/// <summary>A container that stores 3D assets as an indexed collection of <see cref="ModelIO.MDLObject" /> trees.</summary>
	///     
	///     <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/ModelIO/Reference/MDLAsset_Class/index.html">Apple documentation for <c>MDLAsset</c></related>
	[MacCatalyst (13, 1)]
	[BaseType (typeof (NSObject))]
	interface MDLAsset : NSCopying {
		/// <param name="url">The URL.</param>
		/// <summary>Creates a new MDLAsset by loading the file at the specified URL.</summary>
		[Export ("initWithURL:")]
		NativeHandle Constructor (NSUrl url);

		/// <param name="url">The URL.</param>
		/// <param name="vertexDescriptor">
		///           <para>A task representing the asynchronous operation.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		/// <param name="bufferAllocator">
		///           <para>A task representing the asynchronous operation.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		/// <summary>Creates a new MDLAsset by loading the file at the specified URL into the buffers provided by the buffer allocator, and formatting the data in memory as described by the vertex descriptor.</summary>
		[Export ("initWithURL:vertexDescriptor:bufferAllocator:")]
		NativeHandle Constructor ([NullAllowed] NSUrl url, [NullAllowed] MDLVertexDescriptor vertexDescriptor, [NullAllowed] IMDLMeshBufferAllocator bufferAllocator);

		/// <param name="bufferAllocator">
		///           <para>A task representing the asynchronous operation.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		/// <summary>Creates a new Model IO asset by using the provided <paramref name="bufferAllocator" />.</summary>
		[MacCatalyst (13, 1)]
		[Export ("initWithBufferAllocator:")]
		NativeHandle Constructor ([NullAllowed] IMDLMeshBufferAllocator bufferAllocator);

		/// <param name="url">
		///           <para>A task representing the asynchronous operation.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		/// <param name="vertexDescriptor">
		///           <para>A task representing the asynchronous operation.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		/// <param name="bufferAllocator">
		///           <para>A task representing the asynchronous operation.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		/// <param name="preserveTopology">Whether to preserve topology.</param>
		/// <param name="error">The error, or null if none.</param>
		/// <summary>Creates a new MDLAsset by loading the file at the specified URL into the buffers provided by the buffer allocator, and formatting the data in memory as described by the vertex descriptor.</summary>
		[Export ("initWithURL:vertexDescriptor:bufferAllocator:preserveTopology:error:")]
		NativeHandle Constructor (NSUrl url, [NullAllowed] MDLVertexDescriptor vertexDescriptor, [NullAllowed] IMDLMeshBufferAllocator bufferAllocator, bool preserveTopology, out NSError error);

		// note: by choice we do not export "exportAssetToURL:"
		/// <param name="url">The URL.</param>
		///         <param name="error">The error, or null if none.</param>
		///         <summary>Exports the data that is contained in the asset to the file at the specified URL.</summary>
		///         <returns>The result of the operation.</returns>
		[Export ("exportAssetToURL:error:")]
		bool ExportAssetToUrl (NSUrl url, out NSError error);

		/// <param name="atPath">The path.</param>
		///         <summary>Performs the get object operation.</summary>
		///         <returns>The result of the operation.</returns>
		[MacCatalyst (13, 1)]
		[Export ("objectAtPath:")]
		MDLObject GetObject (string atPath);

		/// <param name="extension">The file extension.</param>
		///         <summary>Returns <see langword="true" /> if the asset can import information from files with a format that corresponds to the specified extension. Otherwise, returns <see langword="false" />.</summary>
		///         <returns>The result of the operation.</returns>
		[Static]
		[Export ("canImportFileExtension:")]
		bool CanImportFileExtension (string extension);

		/// <param name="extension">The file extension.</param>
		///         <summary>Returns <see langword="true" /> if the asset can export information to files with a format that corresponds to the specified extension. Otherwise, returns <see langword="false" />.</summary>
		///         <returns>The result of the operation.</returns>
		[Static]
		[Export ("canExportFileExtension:")]
		bool CanExportFileExtension (string extension);

		/// <summary>Gets the Components value.</summary>
		[MacCatalyst (13, 1)]
		[Export ("components", ArgumentSemantic.Copy)]
		IMDLComponent [] Components { get; }

		/// <param name="component">The component.</param>
		///         <param name="protocol">The protocol.</param>
		///         <summary>Performs the set component operation.</summary>
		[MacCatalyst (13, 1)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("setComponent:forProtocol:")]
		void SetComponent (IMDLComponent component, Protocol protocol);

		/// <param name="component">The component.</param>
		///         <param name="type">The type.</param>
		///         <summary>Performs the set component operation.</summary>
		[MacCatalyst (13, 1)]
		[Wrap ("SetComponent (component, new Protocol (type))")]
		void SetComponent (IMDLComponent component, Type type);

		/// <param name="protocol">The protocol.</param>
		///         <summary>Performs the get component operation.</summary>
		///         <returns>The result of the operation.</returns>
		[MacCatalyst (13, 1)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("componentConformingToProtocol:")]
		[return: NullAllowed]
		IMDLComponent GetComponent (Protocol protocol);

		/// <param name="type">The type.</param>
		///         <summary>Performs the get component operation.</summary>
		///         <returns>The result of the operation.</returns>
		[MacCatalyst (13, 1)]
		[Wrap ("GetComponent (new Protocol (type!))")]
		[return: NullAllowed]
		IMDLComponent GetComponent (Type type);

		/// <param name="objectClass">The object class.</param>
		///         <summary>Gets the asset's child assets.</summary>
		///         <returns>The result of the operation.</returns>
		[MacCatalyst (13, 1)]
		[Export ("childObjectsOfClass:")]
		MDLObject [] GetChildObjects (Class objectClass);

		/// <summary>Performs the load textures operation.</summary>
		[MacCatalyst (13, 1)]
		[Export ("loadTextures")]
		void LoadTextures ();

		/// <param name="atTime">The time.</param>
		///         <summary>Gets the bounding box of the asset at the specified time.</summary>
		///         <returns>The result of the operation.</returns>
		[Export ("boundingBoxAtTime:")]
		[MarshalDirective (NativePrefix = "xamarin_simd__", Library = "__Internal")]
		MDLAxisAlignedBoundingBox GetBoundingBox (double atTime);

		/// <summary>Gets the smallest box that contains all of the objects in the asset.</summary>
		/// <remarks>If any of the asset's contents contain timed information, application developers should use <see cref="GetBoundingBox(double)" />, instead.</remarks>
		[Export ("boundingBox")]
		MDLAxisAlignedBoundingBox BoundingBox {
			[MarshalDirective (NativePrefix = "xamarin_simd__", Library = "__Internal")]
			get;
		}

		/// <summary>Gets or sets the frame interval for timed data in the asset.</summary>
		[Export ("frameInterval")]
		double FrameInterval { get; set; }

		/// <summary>Gets the timestamp of the first timed data item in the asset, which is the lowest value to which all requested timed sample data are clamped.</summary>
		[Export ("startTime")]
		double StartTime { get; set; }

		/// <summary>Gets the timestamp of the last timed data item in the asset, which is the highest value to which all requested timed sample data are clamped.</summary>
		[Export ("endTime")]
		double EndTime { get; set; }

		/// <summary>Performs the up axis operation.</summary>
		[MacCatalyst (13, 1)]
		[Export ("upAxis", ArgumentSemantic.Assign)]
		NVector3 UpAxis {
			[MarshalDirective (NativePrefix = "xamarin_simd__", Library = "__Internal")]
			get;
			[MarshalDirective (NativePrefix = "xamarin_simd__", Library = "__Internal")]
			set;
		}

		/// <summary>Gets the URL from which the asset was loaded, or <see langword="null" /> if the asset was not loaded from a URL.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[NullAllowed, Export ("URL", ArgumentSemantic.Retain)]
		NSUrl Url { get; }

		/// <summary>Gets or sets the Resolver value.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[MacCatalyst (13, 1)]
		[NullAllowed, Export ("resolver", ArgumentSemantic.Retain)]
		IMDLAssetResolver Resolver { get; set; }

		/// <summary>Gets the allocator that the application developer specified when constructing the asset, or an internal allocator if none was specified.</summary>
		[Export ("bufferAllocator", ArgumentSemantic.Retain)]
		IMDLMeshBufferAllocator BufferAllocator { get; }

		/// <summary>Gets or sets the description of in-memory vertex data.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[NullAllowed, Export ("vertexDescriptor", ArgumentSemantic.Retain)]
		MDLVertexDescriptor VertexDescriptor { get; }

		/// <param name="object">The object.</param>
		///         <summary>Adds the specified <see cref="ModelIO.MDLObject" />, which may be a <see cref="ModelIO.MDLCamera" />, <see cref="ModelIO.MDLMesh" />, or <see cref="ModelIO.MDLLight" />, to the end of the indexed list of objects for this <see cref="ModelIO.MDLAsset" />.</summary>
		[Export ("addObject:")]
		void AddObject (MDLObject @object);

		/// <param name="object">The object.</param>
		///         <summary>Removes the specified <see cref="ModelIO.MDLObject" />.</summary>
		[Export ("removeObject:")]
		void RemoveObject (MDLObject @object);

		/// <summary>Gets the number of top-level <see cref="ModelIO.MDLObject" /> nodes that are indexed by the asset, each of which contains zero or more child <see cref="ModelIO.MDLObject" /> nodes.</summary>
		[Export ("count")]
		nuint Count { get; }

		/// <param name="index">The index.</param>
		/// <summary>Returns the top-level <see cref="ModelIO.MDLObject" /> node in this asset's indexed list of <see cref="ModelIO.MDLObject" /> nodes, at the specified index.</summary>
		/// <returns>The result of the operation.</returns>
		[Export ("objectAtIndexedSubscript:")]
		[return: NullAllowed]
		MDLObject GetObjectAtIndexedSubscript (nuint index);

		/// <param name="index">The index.</param>
		/// <summary>Returns the object at the specified index.</summary>
		/// <returns>The result of the operation.</returns>
		[Export ("objectAtIndex:")]
		MDLObject GetObject (nuint index);

		/// <summary>Gets or sets the underlying object that contains the asset's object hierarchy.</summary>
		[Deprecated (PlatformName.iOS, 15, 0, message: "Use the 'Originals' property instead.")]
		[Deprecated (PlatformName.TvOS, 15, 0, message: "Use the 'Originals' property instead.")]
		[Deprecated (PlatformName.MacOSX, 12, 0, message: "Use the 'Originals' property instead.")]
		[Deprecated (PlatformName.MacCatalyst, 15, 0, message: "Use the 'Originals' property instead.")]
		[MacCatalyst (13, 1)]
		[Export ("masters", ArgumentSemantic.Retain)]
		IMDLObjectContainerComponent Masters { get; set; }

		[iOS (15, 0), TV (15, 0), MacCatalyst (15, 0)]
		[Export ("originals", ArgumentSemantic.Retain)]
		IMDLObjectContainerComponent Originals { get; set; }

		/// <summary>Gets or sets the Animations value.</summary>
		[MacCatalyst (13, 1)]
		[Export ("animations", ArgumentSemantic.Retain)]
		IMDLObjectContainerComponent Animations { get; set; }

		/// <param name="scene">The scene.</param>
		///         <summary>Creates and returns a new Model IO asset from the provided Scene Kit scene.</summary>
		///         <returns>The result of the operation.</returns>
		[Static]
		[Export ("assetWithSCNScene:")]
		MDLAsset FromScene (SCNScene scene);

		/// <param name="scene">The scene.</param>
		///         <param name="bufferAllocator">
		///           <para>A task representing the asynchronous operation.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		///         <summary>Creates and returns a new Model IO asset from the provided Scene Kit scene, using the specified buffer allocator.</summary>
		///         <returns>The result of the operation.</returns>
		[MacCatalyst (13, 1)]
		[Static]
		[Export ("assetWithSCNScene:bufferAllocator:")]
		MDLAsset FromScene (SCNScene scene, [NullAllowed] IMDLMeshBufferAllocator bufferAllocator);

		// MDLAsset_MDLLightBaking (category)

		/// <param name="density">The density.</param>
		///         <param name="type">The type.</param>
		///         <param name="dataSource">The data source.</param>
		///         <summary>Places light probes with the specified density and data source.</summary>
		///         <returns>The result of the operation.</returns>
		[Static]
		[Export ("placeLightProbesWithDensity:heuristic:usingIrradianceDataSource:")]
		[MacCatalyst (13, 1)]
		MDLLightProbe [] PlaceLightProbes (float density, MDLProbePlacement type, IMDLLightProbeIrradianceDataSource dataSource);
	}

	interface IMDLLightProbeIrradianceDataSource { }

	// Added in iOS 10 SDK but it is supposed to be present in iOS 9.
	/// <related type="externalDocumentation" href="https://developer.apple.com/reference/ModelIO/MDLLightProbeIrradianceDataSource">Apple documentation for <c>MDLLightProbeIrradianceDataSource</c></related>
	[MacCatalyst (13, 1)]
	[Protocol, Model]
	[BaseType (typeof (NSObject))]
	interface MDLLightProbeIrradianceDataSource {
		/// <summary>Gets or sets the BoundingBox value.</summary>
		[Abstract]
		[Export ("boundingBox", ArgumentSemantic.Assign)]
		MDLAxisAlignedBoundingBox BoundingBox { get; set; }

		/// <summary>Gets or sets the SphericalHarmonicsLevel value.</summary>
		[Export ("sphericalHarmonicsLevel")]
		nuint SphericalHarmonicsLevel { get; set; }

		[Export ("sphericalHarmonicsCoefficientsAtPosition:")]
		[MarshalDirective (NativePrefix = "xamarin_simd__", Library = "__Internal")]
		NSData GetSphericalHarmonicsCoefficients (Vector3 position);
	}

	/// <summary>A point of view that looks into a 3D scence, and that can simulate certain aspects of APhysical camera.</summary>
	///     
	///     <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/ModelIO/Reference/MDLCamera_Class/index.html">Apple documentation for <c>MDLCamera</c></related>
	[MacCatalyst (13, 1)]
	[BaseType (typeof (MDLObject))]
	interface MDLCamera {
		/// <summary>Gets or sets the transformation that determines what portion of a scene that the camera can view.</summary>
		[Export ("projectionMatrix")]
		Matrix4 ProjectionMatrix {
			[MarshalDirective (NativePrefix = "xamarin_simd__", Library = "__Internal")]
			get;
		}

		/// <summary>Gets or sets a value that controls whether the projection is perspective or orthographic.</summary>
		[MacCatalyst (13, 1)]
		[Export ("projection", ArgumentSemantic.Assign)]
		MDLCameraProjection Projection { get; set; }

		/// <param name="boundingBox">The bounding box.</param>
		///         <param name="setNearAndFar">The set near and far.</param>
		///         <summary>Moves the camera to view <paramref name="boundingBox" /> looking parallel to the Z axis in a negative direction, and sets the near and far clipping planes to the bounding box if <paramref name="setNearAndFar" /> is <see langword="true" />.</summary>
		[Export ("frameBoundingBox:setNearAndFar:")]
		[MarshalDirective (NativePrefix = "xamarin_simd__", Library = "__Internal")]
		void FrameBoundingBox (MDLAxisAlignedBoundingBox boundingBox, bool setNearAndFar);

		/// <param name="focusPosition">The focus position.</param>
		/// <summary>Points the camera at <paramref name="focusPosition" />.</summary>
		[Export ("lookAt:")]
		[MarshalDirective (NativePrefix = "xamarin_simd__", Library = "__Internal")]
		void LookAt (Vector3 focusPosition);

		/// <param name="focusPosition">The focus position.</param>
		/// <param name="cameraPosition">The camera position.</param>
		/// <summary>Moves the camera to <paramref name="focusPosition" />, and points it at <paramref name="focusPosition" />.</summary>
		[Export ("lookAt:from:")]
		[MarshalDirective (NativePrefix = "xamarin_simd__", Library = "__Internal")]
		void LookAt (Vector3 focusPosition, Vector3 cameraPosition);

		/// <param name="pixel">The pixel.</param>
		/// <param name="size">The size.</param>
		/// <summary>Returns a truncated 3D ray that points from the camera toward the 2D point that is specified by taking <paramref name="pixel" /> as coordinates in a viewport with the dimensions in <paramref name="size" />.</summary>
		/// <returns>The result of the operation.</returns>
		[Export ("rayTo:forViewPort:")]
		[MarshalDirective (NativePrefix = "xamarin_simd__", Library = "__Internal")]
		Vector3 RayTo (Vector2i pixel, Vector2i size);

		/// <summary>Gets or sets the near clipping plane.</summary>
		[Export ("nearVisibilityDistance")]
		float NearVisibilityDistance { get; set; }

		/// <summary>Gets or sets the back clipping plane.</summary>
		[Export ("farVisibilityDistance")]
		float FarVisibilityDistance { get; set; }

		/// <summary>Gets or sets the coefficient of the quadratic term in the formula that is used to calculate radial distortion.</summary>
		[Export ("barrelDistortion")]
		float BarrelDistortion { get; set; }

		/// <summary>Gets or sets the scale factor that transforms world coordinates into meters.</summary>
		[Export ("worldToMetersConversionScale")]
		float WorldToMetersConversionScale { get; set; }

		/// <summary>Gets or sets the coefficient of the fourth-power term in the formula that is used to calculate radial distortion.</summary>
		[Export ("fisheyeDistortion")]
		float FisheyeDistortion { get; set; }

		/// <summary>Gets or sets a value that controls the degree to which image brightness is reduced as the edge of the simulated physical aperture is approached.</summary>
		[Export ("opticalVignetting")]
		float OpticalVignetting { get; set; }

		/// <summary>Gets or sets the degree to which different colors are focussed differently by the camera. 0.0 is no chromatic aberration. 1.0 is the maximum amount.</summary>
		[Export ("chromaticAberration")]
		float ChromaticAberration { get; set; }

		/// <summary>Gets or sets the focal length and updates the field of view accordingly.</summary>
		[Export ("focalLength")]
		float FocalLength { get; set; }

		/// <summary>Gets or sets the focal distance, in meters.</summary>
		[Export ("focusDistance")]
		float FocusDistance { get; set; }

		/// <summary>Gets or sets the field of view, and updates the focal length of the camera accordingly.</summary>
		[Export ("fieldOfView")]
		float FieldOfView { get; set; }

		/// <summary>Gets or sets the focal ratio of the camera.</summary>
		[Export ("fStop")]
		float FStop { get; set; }

		/// <summary>Gets or sets the number of blades to use when simulating bokeh in out-of-focus elements in the scene.</summary>
		[Export ("apertureBladeCount", ArgumentSemantic.Assign)]
		nuint ApertureBladeCount { get; set; }

		/// <summary>Gets or sets the largest size of bokeh from point sources of light.</summary>
		[Export ("maximumCircleOfConfusion")]
		float MaximumCircleOfConfusion { get; set; }

		/// <param name="size">The size.</param>
		/// <summary>Creates and returns a texture, of the specified size, that is used to simulate bokeh effects by using the value of the <see cref="ModelIO.MDLCamera.ApertureBladeCount" /> property.</summary>
		/// <returns>The result of the operation.</returns>
		[Export ("bokehKernelWithSize:")]
		[MarshalDirective (NativePrefix = "xamarin_simd__", Library = "__Internal")]
#if XAMCORE_5_0
		MDLTexture GetBokehKernel (Vector2i size);
#else
		MDLTexture BokehKernelWithSize (Vector2i size);
#endif

		/// <summary>Gets or sets the time, in seconds, for which the simulated shutter is open per frame.</summary>
		[Export ("shutterOpenInterval")]
		double ShutterOpenInterval { get; set; }

		/// <summary>Gets or sets the height, in mm, of the sensor.</summary>
		[Export ("sensorVerticalAperture")]
		float SensorVerticalAperture { get; set; }

		/// <summary>Gets or sets the aspect ratio of a simulated camera sensor.</summary>
		[Export ("sensorAspect")]
		float SensorAspect { get; set; }

		/// <summary>Gets or sets the scale factor by which to expand the central region of the region. The image is cropped to the original extent of the sensor.</summary>
		[Export ("sensorEnlargement", ArgumentSemantic.Assign)]
		Vector2 SensorEnlargement {
			[MarshalDirective (NativePrefix = "xamarin_simd__", Library = "__Internal")]
			get;
			[MarshalDirective (NativePrefix = "xamarin_simd__", Library = "__Internal")]
			set;
		}

		/// <summary>Gets or sets the directed distance, in mm, by which to offset the sensor from the center line of the simulated optical system.</summary>
		[Export ("sensorShift", ArgumentSemantic.Assign)]
		Vector2 SensorShift {
			[MarshalDirective (NativePrefix = "xamarin_simd__", Library = "__Internal")]
			get;
			[MarshalDirective (NativePrefix = "xamarin_simd__", Library = "__Internal")]
			set;
		}

		/// <summary>Gets or sets a vector whose signed components are added to the rendered image in order to simulate the effect of a flash.</summary>
		[Export ("flash", ArgumentSemantic.Assign)]
		Vector3 Flash {
			[MarshalDirective (NativePrefix = "xamarin_simd__", Library = "__Internal")]
			get;
			[MarshalDirective (NativePrefix = "xamarin_simd__", Library = "__Internal")]
			set;
		}

		/// <summary>Gets or sets a vector whose X and Y components clamp the low and high values of color components when calculating exposure levels for a simulated physical camera.</summary>
		[Export ("exposureCompression", ArgumentSemantic.Assign)]
		Vector2 ExposureCompression {
			[MarshalDirective (NativePrefix = "xamarin_simd__", Library = "__Internal")]
			get;
			[MarshalDirective (NativePrefix = "xamarin_simd__", Library = "__Internal")]
			set;
		}

		/// <summary>Gets or sets a vector whose components are multiplied by the color components of the rendered image prior to simulation of the physical lens.</summary>
		[Export ("exposure", ArgumentSemantic.Assign)]
		Vector3 Exposure {
			[MarshalDirective (NativePrefix = "xamarin_simd__", Library = "__Internal")]
			get;
			[MarshalDirective (NativePrefix = "xamarin_simd__", Library = "__Internal")]
			set;
		}

		/// <param name="sceneCamera">The scene camera.</param>
		///         <summary>Creates a new MDLCamera from the specified Scene Kit camera.</summary>
		///         <returns>The result of the operation.</returns>
		[Static]
		[Export ("cameraWithSCNCamera:")]
		MDLCamera FromSceneCamera (SCNCamera sceneCamera);
	}

	/// <summary>Procedurally generates a checkerboard texture on demand, and caches the result.</summary>
	///     
	///     <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/ModelIO/Reference/MDLCheckerboardTexture_Class/index.html">Apple documentation for <c>MDLCheckerboardTexture</c></related>
	[MacCatalyst (13, 1)]
	[BaseType (typeof (MDLTexture))]
	[DisableDefaultCtor]
	interface MDLCheckerboardTexture {
		/// <param name="pixelData">
		///           <para>A task representing the asynchronous operation.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		/// <param name="topLeftOrigin">The top left origin.</param>
		/// <param name="name">
		///           <para>A task representing the asynchronous operation.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		/// <param name="dimensions">The dimensions.</param>
		/// <param name="rowStride">The row stride.</param>
		/// <param name="channelCount">The channel count.</param>
		/// <param name="channelEncoding">The channel encoding.</param>
		/// <param name="isCube">The is cube.</param>
		/// <summary>Creates a new instance with the specified parameters.</summary>
		[Export ("initWithData:topLeftOrigin:name:dimensions:rowStride:channelCount:channelEncoding:isCube:")]
		[MarshalDirective (NativePrefix = "xamarin_simd__", Library = "__Internal")]
		NativeHandle Constructor ([NullAllowed] NSData pixelData, bool topLeftOrigin, [NullAllowed] string name, Vector2i dimensions, nint rowStride, nuint channelCount, MDLTextureChannelEncoding channelEncoding, bool isCube);

		// -(instancetype __nonnull)initWithDivisions:(float)divisions name:(NSString * __nullable)name dimensions:(vector_int2)dimensions channelCount:(int)channelCount channelEncoding:(MDLTextureChannelEncoding)channelEncoding color1:(CGColorRef __nonnull)color1 color2:(CGColorRef __nonnull)color2;
		/// <param name="divisions">The number of divisions.</param>
		/// <param name="name">
		///           <para>A task representing the asynchronous operation.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		/// <param name="dimensions">The dimensions.</param>
		/// <param name="channelCount">The channel count.</param>
		/// <param name="channelEncoding">The channel encoding.</param>
		/// <param name="color1">The color1.</param>
		/// <param name="color2">The color2.</param>
		/// <summary>Creates a new instance with the specified parameters.</summary>
		[Export ("initWithDivisions:name:dimensions:channelCount:channelEncoding:color1:color2:")]
		[MarshalDirective (NativePrefix = "xamarin_simd__", Library = "__Internal")]
		NativeHandle Constructor (float divisions, [NullAllowed] string name, Vector2i dimensions, int channelCount, MDLTextureChannelEncoding channelEncoding, CGColor color1, CGColor color2);

		/// <summary>Gets or sets the number of squares in each direction.</summary>
		[Export ("divisions")]
		float Divisions { get; set; }

		/// <summary>Gets or sets the first color. This is the color of the top left corner of the checkerboard pattern</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[NullAllowed]
		[Export ("color1", ArgumentSemantic.Assign)]
		CGColor Color1 { get; set; }

		/// <summary>Gets or sets the second color.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[NullAllowed]
		[Export ("color2", ArgumentSemantic.Assign)]
		CGColor Color2 { get; set; }
	}

	/// <summary>Texture that contains a gradient between two colors.</summary>
	///     
	///     <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/ModelIO/Reference/MDLColorSwatchTexture_Class/index.html">Apple documentation for <c>MDLColorSwatchTexture</c></related>
	[MacCatalyst (13, 1)]
	[BaseType (typeof (MDLTexture))]
	[DisableDefaultCtor]
	interface MDLColorSwatchTexture {
		/// <param name="pixelData">
		///           <para>A task representing the asynchronous operation.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		/// <param name="topLeftOrigin">The top left origin.</param>
		/// <param name="name">
		///           <para>A task representing the asynchronous operation.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		/// <param name="dimensions">The dimensions.</param>
		/// <param name="rowStride">The row stride.</param>
		/// <param name="channelCount">The channel count.</param>
		/// <param name="channelEncoding">The channel encoding.</param>
		/// <param name="isCube">The is cube.</param>
		/// <summary>Creates a new instance with the specified parameters.</summary>
		[Export ("initWithData:topLeftOrigin:name:dimensions:rowStride:channelCount:channelEncoding:isCube:")]
		[MarshalDirective (NativePrefix = "xamarin_simd__", Library = "__Internal")]
		NativeHandle Constructor ([NullAllowed] NSData pixelData, bool topLeftOrigin, [NullAllowed] string name, Vector2i dimensions, nint rowStride, nuint channelCount, MDLTextureChannelEncoding channelEncoding, bool isCube);

		/// <param name="colorTemperature1">The color temperature1.</param>
		/// <param name="colorTemperature2">The color temperature2.</param>
		/// <param name="name">
		///           <para>A name for the texture.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		/// <param name="textureDimensions">The dimensions of the <see cref="ModelIO.MDLColorSwatchTexture" /> to create, in texels.</param>
		/// <summary>Creates a new <see cref="ModelIO.MDLColorSwatchTexture" /> vertical gradient from <paramref name="colorTemperature1" /> to <paramref name="colorTemperature2" />.</summary>
		[Export ("initWithColorTemperatureGradientFrom:toColorTemperature:name:textureDimensions:")]
		[MarshalDirective (NativePrefix = "xamarin_simd__", Library = "__Internal")]
		NativeHandle Constructor (float colorTemperature1, float colorTemperature2, [NullAllowed] string name, Vector2i textureDimensions);

		/// <param name="color1">The top color of the gradient.</param>
		/// <param name="color2">The bottom color of the gradient.</param>
		/// <param name="name">
		///           <para>A task representing the asynchronous operation.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		/// <param name="textureDimensions">The texture dimensions.</param>
		/// <summary>Creates a new <see cref="ModelIO.MDLColorSwatchTexture" /> vertical gradient from <paramref name="color1" /> to <paramref name="color2" />.</summary>
		/// <remarks>The dimensions of the <see cref="ModelIO.MDLColorSwatchTexture" /> to create, in texels.</remarks>
		[Export ("initWithColorGradientFrom:toColor:name:textureDimensions:")]
		[MarshalDirective (NativePrefix = "xamarin_simd__", Library = "__Internal")]
		NativeHandle Constructor (CGColor color1, CGColor color2, [NullAllowed] string name, Vector2i textureDimensions);
	}


	/// <summary>Base class for light sources.</summary>
	///     
	///     <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/ModelIO/Reference/MDLLight_Class/index.html">Apple documentation for <c>MDLLight</c></related>
	[MacCatalyst (13, 1)]
	[BaseType (typeof (MDLObject))]
	interface MDLLight {
		/// <param name="point">The point.</param>
		/// <summary>Calculates and returns the effect of the light on the specified point.</summary>
		/// <returns>The result of the operation.</returns>
		[Export ("irradianceAtPoint:")]
		[MarshalDirective (NativePrefix = "xamarin_simd__", Library = "__Internal")]
		CGColor GetIrradiance (Vector3 point);

		[Export ("irradianceAtPoint:colorSpace:")]
		[MarshalDirective (NativePrefix = "xamarin_simd__", Library = "__Internal")]
		CGColor GetIrradiance (Vector3 point, CGColorSpace colorSpace);

		/// <summary>Gets or sets the light type.</summary>
		[Export ("lightType")]
		MDLLightType LightType { get; set; }

		/// <summary>Gets or sets the light's color space.</summary>
		[MacCatalyst (13, 1)]
		[Export ("colorSpace")]
		// No documentation to confirm but this should be a constant (hence NSString).
		NSString ColorSpace { get; set; }

		/// <param name="sceneLight">The scene light.</param>
		///         <summary>Creates a new MDLLight instance from the specified <see cref="SceneKit.SCNLight" />.</summary>
		///         <returns>The result of the operation.</returns>
		[Static]
		[Export ("lightWithSCNLight:")]
		MDLLight FromSceneLight (SCNLight sceneLight);
	}

	/// <summary>A light source that defines the color and intensity of its light in all directions.</summary>
	///     
	///     <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/ModelIO/Reference/MDLLightProbe_Class/index.html">Apple documentation for <c>MDLLightProbe</c></related>
	[MacCatalyst (13, 1)]
	[BaseType (typeof (MDLLight))]
	interface MDLLightProbe {
		/// <param name="reflectiveTexture">
		///           <para>A task representing the asynchronous operation.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		/// <param name="irradianceTexture">
		///           <para>A task representing the asynchronous operation.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		/// <summary>Creates a new MDLLightProbe instance with the specified reflectance and radiance textures.</summary>
		[Export ("initWithReflectiveTexture:irradianceTexture:")]
		NativeHandle Constructor ([NullAllowed] MDLTexture reflectiveTexture, [NullAllowed] MDLTexture irradianceTexture);

		/// <param name="sphericalHarmonicsLevel">The spherical harmonics level.</param>
		/// <summary>Generates a spherical harmonics map from the irradiance map of the light probe, to the specified harmonics depth.</summary>
		[Export ("generateSphericalHarmonicsFromIrradiance:")]
		void GenerateSphericalHarmonicsFromIrradiance (nuint sphericalHarmonicsLevel);

		/// <summary>Gets the cube map that represents the scene as seen from the viewpoint of the light probe.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[NullAllowed, Export ("reflectiveTexture", ArgumentSemantic.Retain)]
		MDLTexture ReflectiveTexture { get; }

		/// <summary>Gets the irradiance map.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[NullAllowed, Export ("irradianceTexture", ArgumentSemantic.Retain)]
		MDLTexture IrradianceTexture { get; }

		/// <summary>Gets a value from <c>0</c> to <c>3</c> that represents the number of harmonics that are represented by  <see cref="ModelIO.MDLLightProbe.SphericalHarmonicsCoefficients" />.</summary>
		///         <remarks>There are 3 values in each coefficient. <see cref="ModelIO.MDLLightProbe.SphericalHarmonicsLevel" /> represent the highest index level in <see cref="ModelIO.MDLLightProbe.SphericalHarmonicsCoefficients" />. There are 2^(<see cref="ModelIO.MDLLightProbe.SphericalHarmonicsLevel" /> + 1) sets of 3-valued coefficients in the array.</remarks>
		[Export ("sphericalHarmonicsLevel")]
		nuint SphericalHarmonicsLevel { get; }

		/// <summary>Gets an array of 32-bit floating-point coefficients that are used to calculate the light probes illumination in space.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		///         <remarks>There are 3 values in each coefficient. <see cref="ModelIO.MDLLightProbe.SphericalHarmonicsLevel" /> represent the highest index level in <see cref="ModelIO.MDLLightProbe.SphericalHarmonicsCoefficients" />. There are 2^(<see cref="ModelIO.MDLLightProbe.SphericalHarmonicsLevel" /> + 1) sets of 3-valued coefficients in the array.</remarks>
		[NullAllowed, Export ("sphericalHarmonicsCoefficients", ArgumentSemantic.Copy)]
		NSData SphericalHarmonicsCoefficients { get; }

		// inlined from MDLLightBaking (MDLLightProbe)
		// reason: static protocol members made very bad extensions methods

		/// <param name="textureSize">The texture size.</param>
		/// <param name="transform">The transform.</param>
		/// <param name="lightsToConsider">The lights to consider.</param>
		/// <param name="objectsToConsider">The objects to consider.</param>
		/// <param name="reflectiveCubemap">
		///           <para>A task representing the asynchronous operation.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		/// <param name="irradianceCubemap">
		///           <para>A task representing the asynchronous operation.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		/// <summary>Performs the create operation.</summary>
		/// <returns>The result of the operation.</returns>
		[Static]
		[Export ("lightProbeWithTextureSize:forLocation:lightsToConsider:objectsToConsider:reflectiveCubemap:irradianceCubemap:")]
		[return: NullAllowed]
		MDLLightProbe Create (nint textureSize, MDLTransform transform, MDLLight [] lightsToConsider, MDLObject [] objectsToConsider, [NullAllowed] MDLTexture reflectiveCubemap, [NullAllowed] MDLTexture irradianceCubemap);
	}

	/// <summary>Defines how a surface should appear when rendered.</summary>
	///     
	///     <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/ModelIO/Reference/MDLMaterial_Class/index.html">Apple documentation for <c>MDLMaterial</c></related>
	[MacCatalyst (13, 1)]
	[BaseType (typeof (NSObject))]
	interface MDLMaterial : MDLNamed, INSFastEnumeration {
		/// <param name="name">The name.</param>
		/// <param name="scatteringFunction">The scattering function.</param>
		/// <summary>Creates a new named material with the specified scattering function.</summary>
		[Export ("initWithName:scatteringFunction:")]
		NativeHandle Constructor (string name, MDLScatteringFunction scatteringFunction);

		/// <param name="property">The material property.</param>
		///         <summary>Updates or adds the specified property.</summary>
		[Export ("setProperty:")]
		void SetProperty (MDLMaterialProperty property);

		/// <param name="property">The material property.</param>
		///         <summary>Removes <paramref name="property" /> from the material.</summary>
		[Export ("removeProperty:")]
		void RemoveProperty (MDLMaterialProperty property);

		/// <param name="name">The name.</param>
		///         <summary>Returns the property with the specifed name, if it exists. Otherwise, returns <see langword="null" />.</summary>
		///         <returns>The result of the operation.</returns>
		[Export ("propertyNamed:")]
		[return: NullAllowed]
		MDLMaterialProperty GetProperty (string name);

		/// <param name="semantic">The semantic.</param>
		///         <summary>Returns the property value for the specifed semantic, if it exists. Otherwise, returns <see langword="null" />.</summary>
		///         <returns>The result of the operation.</returns>
		[Export ("propertyWithSemantic:")]
		[return: NullAllowed]
		MDLMaterialProperty GetProperty (MDLMaterialSemantic semantic);

		/// <param name="semantic">The semantic.</param>
		///         <summary>Gets the material properties matching the specified semantic.</summary>
		///         <returns>The result of the operation.</returns>
		[MacCatalyst (13, 1)]
		[Export ("propertiesWithSemantic:")]
		MDLMaterialProperty [] GetProperties (MDLMaterialSemantic semantic);

		/// <summary>Removes all properties from the material.</summary>
		[Export ("removeAllProperties")]
		void RemoveAllProperties ();

		/// <param name="resolver">
		///           <para>A task representing the asynchronous operation.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		///         <summary>Performs the resolve textures operation.</summary>
		[MacCatalyst (13, 1)]
		[Export ("resolveTexturesWithResolver:")]
		void ResolveTextures (IMDLAssetResolver resolver);

		/// <param name="resolver">
		///           <para>A task representing the asynchronous operation.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		///         <summary>Performs the load textures operation.</summary>
		[MacCatalyst (13, 1)]
		[Export ("loadTexturesUsingResolver:")]
		void LoadTextures (IMDLAssetResolver resolver);

		/// <summary>Gets the scattering function for the material.</summary>
		[Export ("scatteringFunction", ArgumentSemantic.Retain)]
		MDLScatteringFunction ScatteringFunction { get; }

		/// <summary>Gets or sets a material from which to derive the properties of this amterial.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		///         <remarks>Uninitialized properties on this object are filled in with their correspoding values from the base material.</remarks>
		[NullAllowed, Export ("baseMaterial", ArgumentSemantic.Retain)]
		MDLMaterial BaseMaterial { get; set; }

		[Export ("objectAtIndexedSubscript:")]
		[Internal]
		[return: NullAllowed]
		MDLMaterialProperty ObjectAtIndexedSubscript (nuint idx);

		[Export ("objectForKeyedSubscript:")]
		[Internal]
		[return: NullAllowed]
		MDLMaterialProperty ObjectForKeyedSubscript (string name);

		/// <summary>Gets the number of properties that belong to this material.</summary>
		[Export ("count")]
		nuint Count { get; }

		/// <summary>Gets or sets a value that determines whether the material is a back, front, or double-sided face.</summary>
		[MacCatalyst (13, 1)]
		[Export ("materialFace", ArgumentSemantic.Assign)]
		MDLMaterialFace MaterialFace { get; set; }

		/// <param name="material">The material.</param>
		///         <summary>Creates a new MDLMaterial from the specified SCNMaterial.</summary>
		///         <returns>The result of the operation.</returns>
		[Static]
		[Export ("materialWithSCNMaterial:")]
		MDLMaterial FromSceneMaterial (SCNMaterial material);
	}

	/// <summary>Defines a specific parameter that controls the rendering of a material surface.</summary>
	///     
	///     <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/ModelIO/Reference/MDLMaterialProperty_Class/index.html">Apple documentation for <c>MDLMaterialProperty</c></related>
	[MacCatalyst (13, 1)]
	[BaseType (typeof (NSObject))]
	[DisableDefaultCtor]
	interface MDLMaterialProperty : MDLNamed, NSCopying {
		/// <param name="name">The name.</param>
		/// <param name="semantic">The semantic.</param>
		/// <summary>Creates a new MDLMaterialProperty with the specified name and semantic.</summary>
		[DesignatedInitializer]
		[Export ("initWithName:semantic:")]
		NativeHandle Constructor (string name, MDLMaterialSemantic semantic);

		/// <param name="name">The name.</param>
		/// <param name="semantic">The semantic.</param>
		/// <param name="value">The value.</param>
		/// <summary>Creates a new MDLMaterialProperty with the specified name, semantic, and value.</summary>
		[Export ("initWithName:semantic:float:")]
		NativeHandle Constructor (string name, MDLMaterialSemantic semantic, float value);

		/// <param name="name">The name.</param>
		/// <param name="semantic">The semantic.</param>
		/// <param name="value">The value.</param>
		/// <summary>Creates a new MDLMaterialProperty with the specified name, semantic, and value.</summary>
		[Export ("initWithName:semantic:float2:")]
		[MarshalDirective (NativePrefix = "xamarin_simd__", Library = "__Internal")]
		NativeHandle Constructor (string name, MDLMaterialSemantic semantic, Vector2 value);

		/// <param name="name">The name.</param>
		/// <param name="semantic">The semantic.</param>
		/// <param name="value">The value.</param>
		/// <summary>Creates a new MDLMaterialProperty with the specified name, semantic, and value.</summary>
		[Export ("initWithName:semantic:float3:")]
		[MarshalDirective (NativePrefix = "xamarin_simd__", Library = "__Internal")]
		NativeHandle Constructor (string name, MDLMaterialSemantic semantic, Vector3 value);

		/// <param name="name">The name.</param>
		/// <param name="semantic">The semantic.</param>
		/// <param name="value">The value.</param>
		/// <summary>Creates a new MDLMaterialProperty with the specified name, semantic, and value.</summary>
		[Export ("initWithName:semantic:float4:")]
		[MarshalDirective (NativePrefix = "xamarin_simd__", Library = "__Internal")]
		NativeHandle Constructor (string name, MDLMaterialSemantic semantic, Vector4 value);

		/// <param name="name">The name.</param>
		/// <param name="semantic">The semantic.</param>
		/// <param name="value">The value.</param>
		/// <summary>Creates a new MDLMaterialProperty with the specified name, semantic, and value.</summary>
		[Export ("initWithName:semantic:matrix4x4:")]
		[MarshalDirective (NativePrefix = "xamarin_simd__", Library = "__Internal")]
		NativeHandle Constructor (string name, MDLMaterialSemantic semantic, Matrix4 value);

		/// <param name="name">The name.</param>
		/// <param name="semantic">The semantic.</param>
		/// <param name="url">
		///           <para>A task representing the asynchronous operation.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		/// <summary>Creates a new MDLMaterialProperty with the specified name and semantic, by loading the resource at the specified URL.</summary>
		[Export ("initWithName:semantic:URL:")]
		NativeHandle Constructor (string name, MDLMaterialSemantic semantic, [NullAllowed] NSUrl url);

		/// <param name="name">The name.</param>
		/// <param name="semantic">The semantic.</param>
		/// <param name="stringValue">
		///           <para>A task representing the asynchronous operation.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		/// <summary>Creates a new MDLMaterialProperty with the specified name, semantic, and value.</summary>
		[Export ("initWithName:semantic:string:")]
		NativeHandle Constructor (string name, MDLMaterialSemantic semantic, [NullAllowed] string stringValue);

		/// <param name="name">The name.</param>
		/// <param name="semantic">The semantic.</param>
		/// <param name="textureSampler">
		///           <para>A task representing the asynchronous operation.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		/// <summary>Creates a new MDLMaterialProperty with the specified name, semantic, and texture sampler.</summary>
		[Export ("initWithName:semantic:textureSampler:")]
		NativeHandle Constructor (string name, MDLMaterialSemantic semantic, [NullAllowed] MDLTextureSampler textureSampler);

		/// <param name="name">The name.</param>
		/// <param name="semantic">The semantic.</param>
		/// <param name="color">The color.</param>
		/// <summary>Creates a new color MDLMaterialProperty with the specified name, semantic, and color.</summary>
		[Export ("initWithName:semantic:color:")]
		NativeHandle Constructor (string name, MDLMaterialSemantic semantic, CGColor color);

		/// <param name="property">The material property.</param>
		///         <summary>Sets the values of this MDLMaterialProperty to match those of <paramref name="property" />.</summary>
		[Export ("setProperties:")]
		void SetProperties (MDLMaterialProperty property);

		/// <summary>Gets or sets the semantic for the property.</summary>
		[Export ("semantic", ArgumentSemantic.Assign)]
		MDLMaterialSemantic Semantic { get; set; }

		/// <summary>Gets the property type.</summary>
		[Export ("type", ArgumentSemantic.Assign)]
		MDLMaterialPropertyType Type { get; }

		/// <param name="type">The type.</param>
		///         <summary>Performs the set type operation.</summary>
		[MacCatalyst (13, 1)]
		[Export ("setType:")]
		void SetType (MDLMaterialPropertyType type);

		/// <summary>Gets or sets the string value.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[NullAllowed, Export ("stringValue")]
		string StringValue { get; set; }

		/// <summary>Gets or sets the URL value.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[NullAllowed, Export ("URLValue", ArgumentSemantic.Copy)]
		NSUrl UrlValue { get; set; }

		/// <summary>Gets or sets the texture sampler value.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[NullAllowed, Export ("textureSamplerValue", ArgumentSemantic.Retain)]
		MDLTextureSampler TextureSamplerValue { get; set; }

		/// <summary>Gets or sets the color of the material property.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[NullAllowed]
		[Export ("color", ArgumentSemantic.Assign)]
		CGColor Color { get; set; }

		/// <summary>Gets or sets the floating-point value.</summary>
		[Export ("floatValue")]
		float FloatValue { get; set; }

		/// <summary>Gets or sets the 2-part floating-point value.</summary>
		[Export ("float2Value", ArgumentSemantic.Assign)]
		Vector2 Float2Value {
			[MarshalDirective (NativePrefix = "xamarin_simd__", Library = "__Internal")]
			get;
			[MarshalDirective (NativePrefix = "xamarin_simd__", Library = "__Internal")]
			set;
		}

		/// <summary>Gets or sets the 3-part floating-point value.</summary>
		[Export ("float3Value", ArgumentSemantic.Assign)]
		Vector3 Float3Value {
			[MarshalDirective (NativePrefix = "xamarin_simd__", Library = "__Internal")]
			get;
			[MarshalDirective (NativePrefix = "xamarin_simd__", Library = "__Internal")]
			set;
		}

		/// <summary>Gets or sets the 4-part floating-point value.</summary>
		[Export ("float4Value", ArgumentSemantic.Assign)]
		Vector4 Float4Value {
			[MarshalDirective (NativePrefix = "xamarin_simd__", Library = "__Internal")]
			get;
			[MarshalDirective (NativePrefix = "xamarin_simd__", Library = "__Internal")]
			set;
		}

		/// <summary>Gets or sets the 4x4 matrix of floating-point values.</summary>
		[Export ("matrix4x4", ArgumentSemantic.Assign)]
		Matrix4 Matrix4x4 {
			[MarshalDirective (NativePrefix = "xamarin_simd__", Library = "__Internal")]
			get;
			[MarshalDirective (NativePrefix = "xamarin_simd__", Library = "__Internal")]
			set;
		}

		/// <summary>Gets or sets the luminance of the material.</summary>
		[MacCatalyst (13, 1)]
		[Export ("luminance")]
		float Luminance { get; set; }
	}

	/// <related type="externalDocumentation" href="https://developer.apple.com/reference/ModelIO/MDLMaterialPropertyConnection">Apple documentation for <c>MDLMaterialPropertyConnection</c></related>
	[MacCatalyst (13, 1)]
	[BaseType (typeof (NSObject))]
	[DisableDefaultCtor]
	interface MDLMaterialPropertyConnection : MDLNamed {
		/// <param name="output">The output.</param>
		/// <param name="input">The input.</param>
		/// <summary>Creates a new instance with the specified parameters.</summary>
		[Export ("initWithOutput:input:")]
		NativeHandle Constructor (MDLMaterialProperty output, MDLMaterialProperty input);

		/// <summary>Gets the Output value.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[NullAllowed, Export ("output", ArgumentSemantic.Weak)]
		MDLMaterialProperty Output { get; }

		/// <summary>Gets the Input value.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[NullAllowed, Export ("input", ArgumentSemantic.Weak)]
		MDLMaterialProperty Input { get; }
	}

	/// <related type="externalDocumentation" href="https://developer.apple.com/reference/ModelIO/MDLMaterialPropertyNode">Apple documentation for <c>MDLMaterialPropertyNode</c></related>
	[MacCatalyst (13, 1)]
	[BaseType (typeof (NSObject))]
	[DisableDefaultCtor]
	interface MDLMaterialPropertyNode : MDLNamed {
		/// <param name="inputs">The inputs.</param>
		/// <param name="outputs">The outputs.</param>
		/// <param name="function">The function.</param>
		/// <summary>Creates a new instance with the specified parameters.</summary>
		[Export ("initWithInputs:outputs:evaluationFunction:")]
		NativeHandle Constructor (MDLMaterialProperty [] inputs, MDLMaterialProperty [] outputs, Action<MDLMaterialPropertyNode> function);

		/// <summary>Gets or sets the EvaluationFunction value.</summary>
		[Export ("evaluationFunction", ArgumentSemantic.Copy)]
		Action<MDLMaterialPropertyNode> EvaluationFunction { get; set; }

		/// <summary>Gets the Inputs value.</summary>
		[Export ("inputs")]
		MDLMaterialProperty [] Inputs { get; }

		/// <summary>Gets the Outputs value.</summary>
		[Export ("outputs")]
		MDLMaterialProperty [] Outputs { get; }
	}

	/// <related type="externalDocumentation" href="https://developer.apple.com/reference/ModelIO/MDLMaterialPropertyGraph">Apple documentation for <c>MDLMaterialPropertyGraph</c></related>
	[MacCatalyst (13, 1)]
	[BaseType (typeof (MDLMaterialPropertyNode))]
	[DisableDefaultCtor]
	interface MDLMaterialPropertyGraph {
		/// <param name="nodes">The nodes.</param>
		/// <param name="connections">The connections.</param>
		/// <summary>Creates a new instance with the specified parameters.</summary>
		[Export ("initWithNodes:connections:")]
		NativeHandle Constructor (MDLMaterialPropertyNode [] nodes, MDLMaterialPropertyConnection [] connections);

		/// <summary>Performs the evaluate operation.</summary>
		[Export ("evaluate")]
		void Evaluate ();

		/// <summary>Gets the Nodes value.</summary>
		[Export ("nodes")]
		MDLMaterialPropertyNode [] Nodes { get; }

		/// <summary>Gets the Connections value.</summary>
		[Export ("connections")]
		MDLMaterialPropertyConnection [] Connections { get; }
	}

	/// <summary>A collection of <see cref="ModelIO.MDLSubmesh" /> objects that, together, define the geometric and material properties for rendering a 3D object.</summary>
	///     
	///     <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/ModelIO/Reference/MDLMesh_Class/index.html">Apple documentation for <c>MDLMesh</c></related>
	[MacCatalyst (13, 1)]
	[BaseType (typeof (MDLObject))]
	interface MDLMesh {
		/// <param name="bufferAllocator">
		///           <para>A task representing the asynchronous operation.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		/// <summary>Creates a new Model IO mesh with the specified buffer allocator.</summary>
		[MacCatalyst (13, 1)]
		[Export ("initWithBufferAllocator:")]
		NativeHandle Constructor ([NullAllowed] IMDLMeshBufferAllocator bufferAllocator);

		/// <param name="vertexBuffer">The vertex buffer.</param>
		/// <param name="vertexCount">The vertex count.</param>
		/// <param name="descriptor">The vertex descriptor.</param>
		/// <param name="submeshes">The submeshes.</param>
		/// <summary>Creates a new instance with the specified parameters.</summary>
		[Export ("initWithVertexBuffer:vertexCount:descriptor:submeshes:")]
		NativeHandle Constructor (IMDLMeshBuffer vertexBuffer, nuint vertexCount, MDLVertexDescriptor descriptor, MDLSubmesh [] submeshes);

		/// <param name="vertexBuffers">The vertex buffers.</param>
		/// <param name="vertexCount">The vertex count.</param>
		/// <param name="descriptor">The vertex descriptor.</param>
		/// <param name="submeshes">The submeshes.</param>
		/// <summary>Creates a new instance with the specified parameters.</summary>
		[Export ("initWithVertexBuffers:vertexCount:descriptor:submeshes:")]
		NativeHandle Constructor (IMDLMeshBuffer [] vertexBuffers, nuint vertexCount, MDLVertexDescriptor descriptor, MDLSubmesh [] submeshes);

		[Internal]
		[Export ("vertexAttributeDataForAttributeNamed:")]
		[return: NullAllowed]
		MDLVertexAttributeData GetVertexAttributeDataForAttribute (string attributeName);

		/// <param name="attributeName">The attribute name.</param>
		///         <param name="format">The format.</param>
		///         <summary>Performs the get vertex attribute data operation.</summary>
		///         <returns>The result of the operation.</returns>
		[MacCatalyst (13, 1)]
		[Export ("vertexAttributeDataForAttributeNamed:asFormat:")]
		[return: NullAllowed]
		MDLVertexAttributeData GetVertexAttributeData (string attributeName, MDLVertexFormat format);

		/// <summary>Gets the smallest box that contains all of the vertices in the mesh.</summary>
		[Export ("boundingBox")]
		MDLAxisAlignedBoundingBox BoundingBox {
			[MarshalDirective (NativePrefix = "xamarin_simd__", Library = "__Internal")]
			get;
		}

		/// <summary>Gets or sets the description of the in-memory layout of vertices in a mesh.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[Export ("vertexDescriptor", ArgumentSemantic.Copy)]
		MDLVertexDescriptor VertexDescriptor { get; set; }

		/// <summary>Gets the number of vertices in the entire mesh.</summary>
		[Export ("vertexCount")]
		nuint VertexCount {
			get;
			[MacCatalyst (13, 1)]
			set;
		}

		/// <summary>Gets the buffers that contain the vertex data for the mesh.</summary>
		[Export ("vertexBuffers", ArgumentSemantic.Retain)]
		IMDLMeshBuffer [] VertexBuffers {
			get;
			[MacCatalyst (13, 1)]
			set;
		}

		/// <summary>Gets the array of submeshes for this mesh.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[NullAllowed]
		[Export ("submeshes", ArgumentSemantic.Copy)]
		NSMutableArray<MDLSubmesh> Submeshes {
			get;
			[MacCatalyst (13, 1)]
			set;
		}

		/// <summary>Gets the Allocator value.</summary>
		[MacCatalyst (13, 1)]
		[Export ("allocator", ArgumentSemantic.Retain)]
		IMDLMeshBufferAllocator Allocator { get; }

		// MDLMesh_Modifiers (category)

		/// <param name="name">The name.</param>
		///         <param name="format">The format.</param>
		///         <summary>Adds the <paramref name="format" /> attribute, indexed by the keyword <paramref name="name" />.</summary>
		[Export ("addAttributeWithName:format:")]
		void AddAttribute (string name, MDLVertexFormat format);

		/// <param name="name">The name.</param>
		/// <param name="format">The format.</param>
		/// <param name="type">The mesh vector type.</param>
		/// <param name="data">The data.</param>
		/// <param name="stride">The stride.</param>
		/// <summary>Adds a vertex attribute and a corresponding empty vertex buffer.</summary>
		[MacCatalyst (13, 1)]
		[Export ("addAttributeWithName:format:type:data:stride:")]
		void AddAttribute (string name, MDLVertexFormat format, string type, NSData data, nint stride);

		/// <param name="name">The name.</param>
		/// <param name="format">The format.</param>
		/// <param name="type">The type.</param>
		/// <param name="data">The data.</param>
		/// <param name="stride">The stride.</param>
		/// <param name="time">The time.</param>
		/// <summary>Performs the add attribute operation.</summary>
		[MacCatalyst (13, 1)]
		[Export ("addAttributeWithName:format:type:data:stride:time:")]
		void AddAttribute (string name, MDLVertexFormat format, string type, NSData data, nint stride, double time);

		/// <param name="name">
		///           <para>A task representing the asynchronous operation.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		///         <param name="creaseThreshold">The crease threshold.</param>
		///         <summary>Generates surface normals for a mesh, interpolating between adjacent faces when the dot product of their unit normals is greater than <paramref name="creaseThreshold" />.</summary>
		[Export ("addNormalsWithAttributeNamed:creaseThreshold:")]
		void AddNormals ([NullAllowed] string name, float creaseThreshold);

		/// <param name="textureCoordinateAttributeName">The texture coordinate attribute name.</param>
		///         <param name="tangentAttributeName">The tangent attribute name.</param>
		///         <param name="bitangentAttributeName">
		///           <para>A task representing the asynchronous operation.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		///         <summary>Reads texture coordinates from the buffer that is specified by <paramref name="textureCoordinateAttributeName" />, calculates tangents and bitangents, and stores them in the specified buffers.</summary>
		[Export ("addTangentBasisForTextureCoordinateAttributeNamed:tangentAttributeNamed:bitangentAttributeNamed:")]
		void AddTangentBasis (string textureCoordinateAttributeName, string tangentAttributeName, [NullAllowed] string bitangentAttributeName);

		/// <param name="textureCoordinateAttributeName">The texture coordinate attribute name.</param>
		///         <param name="normalAttributeName">The normal attribute name.</param>
		///         <param name="tangentAttributeName">The tangent attribute name.</param>
		///         <summary>Reads surface normals from the buffer that is specified by <paramref name="textureCoordinateAttributeName" />, calculates tangents and bitangents, and stores them in the specified buffers.</summary>
		[Export ("addTangentBasisForTextureCoordinateAttributeNamed:normalAttributeNamed:tangentAttributeNamed:")]
		void AddTangentBasisWithNormals (string textureCoordinateAttributeName, string normalAttributeName, string tangentAttributeName);

		/// <param name="textureCoordinateAttributeName">The texture coordinate attribute name.</param>
		///         <param name="normalAttributeName">The normal attribute name.</param>
		///         <param name="tangentAttributeName">The tangent attribute name.</param>
		///         <summary>Performs the add orth tan basis operation.</summary>
		[MacCatalyst (13, 1)]
		[Export ("addOrthTanBasisForTextureCoordinateAttributeNamed:normalAttributeNamed:tangentAttributeNamed:")]
		void AddOrthTanBasis (string textureCoordinateAttributeName, string normalAttributeName, string tangentAttributeName);

		/// <param name="textureCoordinateAttributeName">The texture coordinate attribute name.</param>
		///         <summary>Performs the add unwrapped texture coordinates operation.</summary>
		[MacCatalyst (13, 1)]
		[Export ("addUnwrappedTextureCoordinatesForAttributeNamed:")]
		void AddUnwrappedTextureCoordinates (string textureCoordinateAttributeName);

		/// <param name="inTextureCoordinateAttributeNamed">The in texture coordinate attribute named.</param>
		///         <summary>Performs the flip texture coordinates operation.</summary>
		[MacCatalyst (13, 1)]
		[Export ("flipTextureCoordinatesInAttributeNamed:")]
		void FlipTextureCoordinates (string inTextureCoordinateAttributeNamed);

		/// <summary>Developers should not use this deprecated method. Developers should use the 'NSError' overload.</summary>
		[Deprecated (PlatformName.iOS, 11, 0, message: "Use the 'NSError' overload.")]
		[Deprecated (PlatformName.MacOSX, 10, 13, message: "Use the 'NSError' overload.")]
		[Deprecated (PlatformName.TvOS, 11, 0, message: "Use the 'NSError' overload.")]
		[Deprecated (PlatformName.MacCatalyst, 13, 1, message: "Use the 'NSError' overload.")]
		[Export ("makeVerticesUnique")]
		void MakeVerticesUnique ();

		/// <param name="error">The error, or null if none.</param>
		///         <summary>Performs the make vertices unique operation.</summary>
		///         <returns>The result of the operation.</returns>
		[MacCatalyst (13, 1)]
		[Export ("makeVerticesUniqueAndReturnError:")]
		bool MakeVerticesUnique (out NSError error);

		/// <param name="name">The name.</param>
		///         <param name="newData">The new data.</param>
		///         <summary>Performs the replace attribute operation.</summary>
		[MacCatalyst (13, 1)]
		[Export ("replaceAttributeNamed:withData:")]
		void ReplaceAttribute (string name, MDLVertexAttributeData newData);

		/// <param name="name">The name.</param>
		///         <param name="newData">The new data.</param>
		///         <summary>Performs the update attribute operation.</summary>
		[MacCatalyst (13, 1)]
		[Export ("updateAttributeNamed:withData:")]
		void UpdateAttribute (string name, MDLVertexAttributeData newData);

		/// <param name="name">The name.</param>
		///         <summary>Performs the remove attribute operation.</summary>
		[MacCatalyst (13, 1)]
		[Export ("removeAttributeNamed:")]
		void RemoveAttribute (string name);

		// MDLMesh_Generators (category)

		// Note: we turn these constructors into static constructors because we don't want to lose the shape name. Also, the signatures of these constructors differ so it would not be possible to use an enum to differentiate the shapes.

		[Internal]
		[Export ("initBoxWithExtent:segments:inwardNormals:geometryType:allocator:")]
		[MarshalDirective (NativePrefix = "xamarin_simd__", Library = "__Internal")]
		IntPtr InitBox (Vector3 extent, Vector3i segments, bool inwardNormals, MDLGeometryType geometryType, [NullAllowed] IMDLMeshBufferAllocator allocator);

		[Internal]
		[Export ("initSphereWithExtent:segments:inwardNormals:geometryType:allocator:")]
		[MarshalDirective (NativePrefix = "xamarin_simd__", Library = "__Internal")]
		IntPtr InitSphere (Vector3 extent, Vector2i segments, bool inwardNormals, MDLGeometryType geometryType, [NullAllowed] IMDLMeshBufferAllocator allocator);

		[Internal]
		[Export ("initHemisphereWithExtent:segments:inwardNormals:cap:geometryType:allocator:")]
		[MarshalDirective (NativePrefix = "xamarin_simd__", Library = "__Internal")]
		IntPtr InitHemisphere (Vector3 extent, Vector2i segments, bool inwardNormals, bool cap, MDLGeometryType geometryType, [NullAllowed] IMDLMeshBufferAllocator allocator);

		[Internal]
		[Export ("initCylinderWithExtent:segments:inwardNormals:topCap:bottomCap:geometryType:allocator:")]
		[MarshalDirective (NativePrefix = "xamarin_simd__", Library = "__Internal")]
		IntPtr InitCylinder (Vector3 extent, Vector2i segments, bool inwardNormals, bool topCap, bool bottomCap, MDLGeometryType geometryType, [NullAllowed] IMDLMeshBufferAllocator allocator);

		[Internal]
		[Export ("initCapsuleWithExtent:cylinderSegments:hemisphereSegments:inwardNormals:geometryType:allocator:")]
		[MarshalDirective (NativePrefix = "xamarin_simd__", Library = "__Internal")]
		IntPtr InitCapsule (Vector3 extent, Vector2i segments, int hemisphereSegments, bool inwardNormals, MDLGeometryType geometryType, [NullAllowed] IMDLMeshBufferAllocator allocator);

		[Internal]
		[Export ("initConeWithExtent:segments:inwardNormals:cap:geometryType:allocator:")]
		[MarshalDirective (NativePrefix = "xamarin_simd__", Library = "__Internal")]
		IntPtr InitCone (Vector3 extent, Vector2i segments, bool inwardNormals, bool cap, MDLGeometryType geometryType, [NullAllowed] IMDLMeshBufferAllocator allocator);

		[Internal]
		[Export ("initPlaneWithExtent:segments:geometryType:allocator:")]
		[MarshalDirective (NativePrefix = "xamarin_simd__", Library = "__Internal")]
		IntPtr InitPlane (Vector3 extent, Vector2i segments, MDLGeometryType geometryType, [NullAllowed] IMDLMeshBufferAllocator allocator);

		[Internal]
		[Export ("initIcosahedronWithExtent:inwardNormals:geometryType:allocator:")]
		[MarshalDirective (NativePrefix = "xamarin_simd__", Library = "__Internal")]
		IntPtr InitIcosahedron (Vector3 extent, bool inwardNormals, MDLGeometryType geometryType, [NullAllowed] IMDLMeshBufferAllocator allocator);

		[Internal]
		[Export ("initMeshBySubdividingMesh:submeshIndex:subdivisionLevels:allocator:")]
		[MarshalDirective (NativePrefix = "xamarin_simd__", Library = "__Internal")]
		IntPtr InitMesh (MDLMesh mesh, int submeshIndex, uint subdivisionLevels, [NullAllowed] IMDLMeshBufferAllocator allocator);

		[Internal]
		[Static]
		[Export ("newBoxWithDimensions:segments:geometryType:inwardNormals:allocator:")]
		[MarshalDirective (NativePrefix = "xamarin_simd__", Library = "__Internal")]
		MDLMesh NewBoxWithDimensions (Vector3 dimensions, Vector3i segments, MDLGeometryType geometryType, bool inwardNormals, [NullAllowed] IMDLMeshBufferAllocator allocator);

		[Static]
		[Export ("newPlaneWithDimensions:segments:geometryType:allocator:")]
		[MarshalDirective (NativePrefix = "xamarin_simd__", Library = "__Internal")]
		MDLMesh CreatePlane (Vector2 dimensions, Vector2i segments, MDLGeometryType geometryType, [NullAllowed] IMDLMeshBufferAllocator allocator);

		[Static]
		[Export ("newEllipsoidWithRadii:radialSegments:verticalSegments:geometryType:inwardNormals:hemisphere:allocator:")]
		[MarshalDirective (NativePrefix = "xamarin_simd__", Library = "__Internal")]
		MDLMesh CreateEllipsoid (Vector3 radii, nuint radialSegments, nuint verticalSegments, MDLGeometryType geometryType, bool inwardNormals, bool hemisphere, [NullAllowed] IMDLMeshBufferAllocator allocator);

		[Static]
		[Export ("newCylinderWithHeight:radii:radialSegments:verticalSegments:geometryType:inwardNormals:allocator:")]
		[MarshalDirective (NativePrefix = "xamarin_simd__", Library = "__Internal")]
		MDLMesh CreateCylindroid (float height, Vector2 radii, nuint radialSegments, nuint verticalSegments, MDLGeometryType geometryType, bool inwardNormals, [NullAllowed] IMDLMeshBufferAllocator allocator);

		/// <include file="../docs/api/ModelIO/MDLMesh.xml" path="/Documentation/Docs[@DocId='M:ModelIO.MDLMesh.CreateCapsule(System.Single,OpenTK.Vector2,System.nuint,System.nuint,System.nuint,ModelIO.MDLGeometryType,System.Boolean,ModelIO.IMDLMeshBufferAllocator)']/*" />
		[Static]
		[MacCatalyst (13, 1)]
		[Export ("newCapsuleWithHeight:radii:radialSegments:verticalSegments:hemisphereSegments:geometryType:inwardNormals:allocator:")]
		[MarshalDirective (NativePrefix = "xamarin_simd__", Library = "__Internal")]
		MDLMesh CreateCapsule (float height, Vector2 radii, nuint radialSegments, nuint verticalSegments, nuint hemisphereSegments, MDLGeometryType geometryType, bool inwardNormals, [NullAllowed] IMDLMeshBufferAllocator allocator);

		[Static]
		[Export ("newEllipticalConeWithHeight:radii:radialSegments:verticalSegments:geometryType:inwardNormals:allocator:")]
		[MarshalDirective (NativePrefix = "xamarin_simd__", Library = "__Internal")]
		MDLMesh CreateEllipticalCone (float height, Vector2 radii, nuint radialSegments, nuint verticalSegments, MDLGeometryType geometryType, bool inwardNormals, [NullAllowed] IMDLMeshBufferAllocator allocator);

		/// <param name="radius">The radius of the icosahedron.</param>
		///         <param name="inwardNormals">Whether to generate inward-pointing normals.</param>
		///         <param name="allocator">
		///           <para>The allocator to use instead of the default, internal allocator.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		///         <summary>Creates a regular icosohedron with the specified radius.</summary>
		///         <returns>The result of the operation.</returns>
		[Static]
		[Export ("newIcosahedronWithRadius:inwardNormals:allocator:")]
		MDLMesh CreateIcosahedron (float radius, bool inwardNormals, [NullAllowed] IMDLMeshBufferAllocator allocator);

		/// <param name="radius">The radius of the icosahedron.</param>
		///         <param name="inwardNormals">Whether to generate inward-pointing normals.</param>
		///         <param name="geometryType">Whether to create triangles, quadrilaterals, or lines.</param>
		///         <param name="allocator">
		///           <para>The allocator to use instead of the default, internal allocator.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		///         <summary>Creates a regular icosahedron from the specified parameters.</summary>
		///         <returns>The result of the operation.</returns>
		[Static]
		[MacCatalyst (13, 1)]
		[Export ("newIcosahedronWithRadius:inwardNormals:geometryType:allocator:")]
		MDLMesh CreateIcosahedron (float radius, bool inwardNormals, MDLGeometryType geometryType, [NullAllowed] IMDLMeshBufferAllocator allocator);

		/// <param name="mesh">The mesh.</param>
		/// <param name="submeshIndex">The submesh index.</param>
		/// <param name="subdivisionLevels">The subdivision levels.</param>
		/// <summary>Subdivides the indexed submesh within the specified mesh, the specified number of times.</summary>
		/// <returns>The result of the operation.</returns>
		[Static]
		[Export ("newSubdividedMesh:submeshIndex:subdivisionLevels:")]
		[return: NullAllowed]
		MDLMesh CreateSubdividedMesh (MDLMesh mesh, nuint submeshIndex, nuint subdivisionLevels);

		[Export ("generateAmbientOcclusionTextureWithSize:raysPerSample:attenuationFactor:objectsToConsider:vertexAttributeNamed:materialPropertyNamed:")]
		[MarshalDirective (NativePrefix = "xamarin_simd__", Library = "__Internal")]
		bool GenerateAmbientOcclusionTexture (Vector2i textureSize, nint raysPerSample, float attenuationFactor, MDLObject [] objectsToConsider, string vertexAttributeName, string materialPropertyName);

		/// <param name="bakeQuality">The bake quality.</param>
		///         <param name="attenuationFactor">The attenuation factor.</param>
		///         <param name="objectsToConsider">The objects to consider.</param>
		///         <param name="vertexAttributeName">The vertex attribute name.</param>
		///         <param name="materialPropertyName">The material property name.</param>
		///         <summary>Generates a texture that is used to simulate the occlusion of ambient light from recesses in the mesh.</summary>
		///         <returns>The result of the operation.</returns>
		[Export ("generateAmbientOcclusionTextureWithQuality:attenuationFactor:objectsToConsider:vertexAttributeNamed:materialPropertyNamed:")]
		bool GenerateAmbientOcclusionTexture (float bakeQuality, float attenuationFactor, MDLObject [] objectsToConsider, string vertexAttributeName, string materialPropertyName);

		/// <param name="raysPerSample">The rays per sample.</param>
		/// <param name="attenuationFactor">The attenuation factor.</param>
		/// <param name="objectsToConsider">The objects to consider.</param>
		/// <param name="vertexAttributeName">The vertex attribute name.</param>
		/// <summary>Performs the generate ambient occlusion vertex colors operation.</summary>
		/// <returns>The result of the operation.</returns>
		[Export ("generateAmbientOcclusionVertexColorsWithRaysPerSample:attenuationFactor:objectsToConsider:vertexAttributeNamed:")]
		bool GenerateAmbientOcclusionVertexColors (nint raysPerSample, float attenuationFactor, MDLObject [] objectsToConsider, string vertexAttributeName);

		/// <param name="bakeQuality">The bake quality.</param>
		///         <param name="attenuationFactor">The attenuation factor.</param>
		///         <param name="objectsToConsider">The objects to consider.</param>
		///         <param name="vertexAttributeName">The vertex attribute name.</param>
		///         <summary>Generates vertex color data that is used to simulate the occlusion of ambient light from recesses in the mesh.</summary>
		///         <returns>The result of the operation.</returns>
		[Export ("generateAmbientOcclusionVertexColorsWithQuality:attenuationFactor:objectsToConsider:vertexAttributeNamed:")]
		bool GenerateAmbientOcclusionVertexColors (float bakeQuality, float attenuationFactor, MDLObject [] objectsToConsider, string vertexAttributeName);


		[Export ("generateLightMapTextureWithTextureSize:lightsToConsider:objectsToConsider:vertexAttributeNamed:materialPropertyNamed:")]
		[MarshalDirective (NativePrefix = "xamarin_simd__", Library = "__Internal")]
		bool GenerateLightMapTexture (Vector2i textureSize, MDLLight [] lightsToConsider, MDLObject [] objectsToConsider, string vertexAttributeName, string materialPropertyName);

		/// <param name="bakeQuality">The bake quality.</param>
		///         <param name="lightsToConsider">The lights to consider.</param>
		///         <param name="objectsToConsider">The objects to consider.</param>
		///         <param name="vertexAttributeName">The vertex attribute name.</param>
		///         <param name="materialPropertyName">The material property name.</param>
		///         <summary>Generates a map that represents the computed result of shading from the specified lights, obstructed by the specified objects.</summary>
		///         <returns>The result of the operation.</returns>
		[Export ("generateLightMapTextureWithQuality:lightsToConsider:objectsToConsider:vertexAttributeNamed:materialPropertyNamed:")]
		bool GenerateLightMapTexture (float bakeQuality, MDLLight [] lightsToConsider, MDLObject [] objectsToConsider, string vertexAttributeName, string materialPropertyName);

		/// <param name="lightsToConsider">The lights to consider.</param>
		///         <param name="objectsToConsider">The objects to consider.</param>
		///         <param name="vertexAttributeName">The vertex attribute name.</param>
		///         <summary>Generates vertex color data that represent the computed result of shading from the specified lights, obstructed by the specified objects.</summary>
		///         <returns>The result of the operation.</returns>
		[Export ("generateLightMapVertexColorsWithLightsToConsider:objectsToConsider:vertexAttributeNamed:")]
		bool GenerateLightMapVertexColors (MDLLight [] lightsToConsider, MDLObject [] objectsToConsider, string vertexAttributeName);

		/// <param name="geometry">The geometry.</param>
		///         <summary>Performs the from geometry operation.</summary>
		///         <returns>The result of the operation.</returns>
		[Static]
		[Export ("meshWithSCNGeometry:")]
		MDLMesh FromGeometry (SCNGeometry geometry);

		/// <param name="geometry">The geometry.</param>
		///         <param name="bufferAllocator">
		///           <para>A task representing the asynchronous operation.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		///         <summary>Performs the from geometry operation.</summary>
		///         <returns>The result of the operation.</returns>
		[MacCatalyst (13, 1)]
		[Static]
		[Export ("meshWithSCNGeometry:bufferAllocator:")]
		MDLMesh FromGeometry (SCNGeometry geometry, [NullAllowed] IMDLMeshBufferAllocator bufferAllocator);
	}

	interface IMDLMeshBuffer { }

	[MacCatalyst (13, 1)]
	[Protocol]
	interface MDLMeshBuffer : NSCopying {
		/// <param name="data">The data.</param>
		/// <param name="offset">The offset.</param>
		/// <summary>Writes <paramref name="data" /> into the buffer at the specified <paramref name="offset" /> number of bytes.</summary>
		[Abstract]
		[Export ("fillData:offset:")]
		void FillData (NSData data, nuint offset);

		/// <summary>Gets a mesh buffer map that provides read-only access to the data in the buffer.</summary>
		[Abstract]
		[Export ("map")]
		MDLMeshBufferMap Map { get; }

		/// <summary>Gets the length of the buffer, in bytes.</summary>
		[Abstract]
		[Export ("length")]
		nuint Length { get; }

		/// <summary>Gets the allocator that is used to allocate memory for the mesh buffer.</summary>
		[Abstract]
		[Export ("allocator", ArgumentSemantic.Retain)]
		IMDLMeshBufferAllocator Allocator { get; }

		/// <summary>Gets the memory pool that the buffer occupies.</summary>
		[Abstract]
		[Export ("zone", ArgumentSemantic.Retain)]
		[NullAllowed]
		IMDLMeshBufferZone Zone { get; }

		/// <summary>Gets a value that indicates whether the buffer contains indices or vertices.</summary>
		[Abstract]
		[Export ("type")]
		MDLMeshBufferType Type { get; }
	}

	interface IMDLMeshBufferAllocator { }

	[MacCatalyst (13, 1)]
	[Protocol]
	interface MDLMeshBufferAllocator {
		/// <param name="capacity">The capacity.</param>
		/// <summary>Creates and returns a new mesh buffer zone with the specified  <paramref name="capacity" />.</summary>
		/// <returns>The result of the operation.</returns>
		[Abstract]
		[Export ("newZone:")]
		IMDLMeshBufferZone CreateZone (nuint capacity);

		/// <param name="sizes">The sizes.</param>
		/// <param name="types">The types.</param>
		/// <summary>Creates a new zone that is large enough to contain buffers from the list of sizes and corresponding types.</summary>
		/// <returns>The result of the operation.</returns>
		[Abstract]
		[Export ("newZoneForBuffersWithSize:andType:")]
		IMDLMeshBufferZone CreateZone (NSNumber [] sizes, NSNumber [] types);

		/// <param name="length">The length.</param>
		/// <param name="type">The type.</param>
		/// <summary>Performs the create buffer operation.</summary>
		/// <returns>The result of the operation.</returns>
		[Abstract]
		[Export ("newBuffer:type:")]
		IMDLMeshBuffer CreateBuffer (nuint length, MDLMeshBufferType type);

		/// <param name="data">The data.</param>
		/// <param name="type">The type.</param>
		/// <summary>Creates a new buffer from the specified data, of the specified type, in the default zone of the implementor.</summary>
		/// <returns>The result of the operation.</returns>
		[Abstract]
		[Export ("newBufferWithData:type:")]
		IMDLMeshBuffer CreateBuffer (NSData data, MDLMeshBufferType type);

		/// <param name="zone">The zone.</param>
		/// <param name="length">The length.</param>
		/// <param name="type">The type.</param>
		/// <summary>Performs the create buffer operation.</summary>
		/// <returns>The result of the operation.</returns>
		[Abstract]
		[Export ("newBufferFromZone:length:type:")]
		[return: NullAllowed]
		IMDLMeshBuffer CreateBuffer ([NullAllowed] IMDLMeshBufferZone zone, nuint length, MDLMeshBufferType type);

		/// <param name="zone">The zone.</param>
		/// <param name="data">The data.</param>
		/// <param name="type">The type.</param>
		/// <summary>Creates a new buffer from the specified data, of the specified type, in the specified zone.</summary>
		/// <returns>The result of the operation.</returns>
		[Abstract]
		[Export ("newBufferFromZone:data:type:")]
		[return: NullAllowed]
		IMDLMeshBuffer CreateBuffer ([NullAllowed] IMDLMeshBufferZone zone, NSData data, MDLMeshBufferType type);
	}

	/// <summary>An implementation of <see cref="ModelIO.IMDLMeshBufferAllocator" /> that allocates mesh buffer data space within main memory, not GPU memory.</summary>
	///     
	///     <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/ModelIO/Reference/MDLMeshBufferDataAllocator_Class/index.html">Apple documentation for <c>MDLMeshBufferDataAllocator</c></related>
	[MacCatalyst (13, 1)]
	[BaseType (typeof (NSObject))]
	interface MDLMeshBufferDataAllocator : MDLMeshBufferAllocator {

	}

	/// <summary>A default implementation of a <see cref="ModelIO.IMDLMeshBufferZone" />.</summary>
	///     
	///     <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/ModelIO/Reference/MDLMeshBufferZoneDefault_Class/index.html">Apple documentation for <c>MDLMeshBufferZoneDefault</c></related>
	[MacCatalyst (13, 1)]
	[BaseType (typeof (NSObject))]
	interface MDLMeshBufferZoneDefault : MDLMeshBufferZone {
		// We get Capacity and Allocator from MDLMeshBufferZone
		// [Export ("capacity")]
		// nuint Capacity { get; }

		// [Export ("allocator", ArgumentSemantic.Retain)]
		// IMDLMeshBufferAllocator Allocator { get; }
	}

	/// <summary>Provides storage for vertex and index data for a <see cref="ModelIO.MDLMesh" /> object.</summary>
	///     
	///     <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/ModelIO/Reference/MDLMeshBufferData_Class/index.html">Apple documentation for <c>MDLMeshBufferData</c></related>
	[MacCatalyst (13, 1)]
	[BaseType (typeof (NSObject))]
	interface MDLMeshBufferData : MDLMeshBuffer, NSCopying {
		/// <param name="type">The type.</param>
		/// <param name="length">The length.</param>
		/// <summary>Creates a new mesh buffer of the specified size in bytes and the specified type.</summary>
		[Export ("initWithType:length:")]
		NativeHandle Constructor (MDLMeshBufferType type, nuint length);

		/// <param name="type">The type.</param>
		/// <param name="data">
		///           <para>A task representing the asynchronous operation.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		/// <summary>Creates a new mesh buffer that contains the specified data.</summary>
		[Export ("initWithType:data:")]
		NativeHandle Constructor (MDLMeshBufferType type, [NullAllowed] NSData data);

		/// <summary>Gets an NSData object that contains the data.</summary>
		[Export ("data", ArgumentSemantic.Retain)]
		NSData Data { get; }
	}

	interface IMDLMeshBufferZone { }

	[MacCatalyst (13, 1)]
	[Protocol]
	interface MDLMeshBufferZone {
		/// <summary>Gets the capacity of the zone, in bytes.</summary>
		[Abstract]
		[Export ("capacity")]
		nuint Capacity { get; }

		/// <summary>Gets the allocator that created the zone.</summary>
		[Abstract]
		[Export ("allocator")]
		IMDLMeshBufferAllocator Allocator { get; }
	}

	/// <summary>Interface whose implementers define a <see cref="ModelIO.IMDLNamed.Name" /> property.</summary>
	[MacCatalyst (13, 1)]
	[Protocol]
	interface MDLNamed {
		/// <summary>Gets or sets the descriptive name of the named object.</summary>
		[Abstract]
		[Export ("name")]
		string Name { get; set; }
	}

	/// <summary>Class that generates a texture that consists of random color or direction noise.</summary>
	///     
	///     <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/ModelIO/Reference/MDLNoiseTexture_Class/index.html">Apple documentation for <c>MDLNoiseTexture</c></related>
	[MacCatalyst (13, 1)]
	[BaseType (typeof (MDLTexture))]
	[DisableDefaultCtor]
	interface MDLNoiseTexture {
		/// <param name="pixelData">
		///           <para>A task representing the asynchronous operation.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		/// <param name="topLeftOrigin">The top left origin.</param>
		/// <param name="name">
		///           <para>A task representing the asynchronous operation.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		/// <param name="dimensions">The dimensions.</param>
		/// <param name="rowStride">The row stride.</param>
		/// <param name="channelCount">The channel count.</param>
		/// <param name="channelEncoding">The channel encoding.</param>
		/// <param name="isCube">The is cube.</param>
		/// <summary>Creates a new instance with the specified parameters.</summary>
		[Export ("initWithData:topLeftOrigin:name:dimensions:rowStride:channelCount:channelEncoding:isCube:")]
		[MarshalDirective (NativePrefix = "xamarin_simd__", Library = "__Internal")]
		NativeHandle Constructor ([NullAllowed] NSData pixelData, bool topLeftOrigin, [NullAllowed] string name, Vector2i dimensions, nint rowStride, nuint channelCount, MDLTextureChannelEncoding channelEncoding, bool isCube);

		[Internal]
		[Export ("initVectorNoiseWithSmoothness:name:textureDimensions:channelEncoding:")]
		[MarshalDirective (NativePrefix = "xamarin_simd__", Library = "__Internal")]
		IntPtr _InitVectorNoiseWithSmoothness (float smoothness, [NullAllowed] string name, Vector2i textureDimensions, MDLTextureChannelEncoding channelEncoding);

		/// <param name="smoothness">The smoothness.</param>
		/// <param name="name">
		///           <para>A task representing the asynchronous operation.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		/// <param name="textureDimensions">The texture dimensions.</param>
		/// <param name="channelCount">The channel count.</param>
		/// <param name="channelEncoding">The channel encoding.</param>
		/// <param name="grayscale">The grayscale.</param>
		/// <summary>Creates a new instance with the specified parameters.</summary>
		[Export ("initScalarNoiseWithSmoothness:name:textureDimensions:channelCount:channelEncoding:grayscale:")]
		[MarshalDirective (NativePrefix = "xamarin_simd__", Library = "__Internal")]
		NativeHandle Constructor (float smoothness, [NullAllowed] string name, Vector2i textureDimensions, int channelCount, MDLTextureChannelEncoding channelEncoding, bool grayscale);

		[Internal]
		[MacCatalyst (13, 1)]
		[Export ("initCellularNoiseWithFrequency:name:textureDimensions:channelEncoding:")]
		[MarshalDirective (NativePrefix = "xamarin_simd__", Library = "__Internal")]
		IntPtr _InitCellularNoiseWithFrequency (float frequency, [NullAllowed] string name, Vector2i textureDimensions, MDLTextureChannelEncoding channelEncoding);
	}

	/// <summary>Class that generates a texture that contains surface normal data.</summary>
	///     
	///     <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/ModelIO/Reference/MDLNormalMapTexture_Class/index.html">Apple documentation for <c>MDLNormalMapTexture</c></related>
	[MacCatalyst (13, 1)]
	[BaseType (typeof (MDLTexture))]
	[DisableDefaultCtor]
	interface MDLNormalMapTexture {
		/// <param name="pixelData">
		///           <para>A task representing the asynchronous operation.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		/// <param name="topLeftOrigin">The top left origin.</param>
		/// <param name="name">
		///           <para>A task representing the asynchronous operation.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		/// <param name="dimensions">The dimensions.</param>
		/// <param name="rowStride">The row stride.</param>
		/// <param name="channelCount">The channel count.</param>
		/// <param name="channelEncoding">The channel encoding.</param>
		/// <param name="isCube">The is cube.</param>
		/// <summary>Creates a new instance with the specified parameters.</summary>
		[Export ("initWithData:topLeftOrigin:name:dimensions:rowStride:channelCount:channelEncoding:isCube:")]
		[MarshalDirective (NativePrefix = "xamarin_simd__", Library = "__Internal")]
		NativeHandle Constructor ([NullAllowed] NSData pixelData, bool topLeftOrigin, [NullAllowed] string name, Vector2i dimensions, nint rowStride, nuint channelCount, MDLTextureChannelEncoding channelEncoding, bool isCube);

		/// <param name="sourceTexture">The source texture.</param>
		/// <param name="name">
		///           <para>A task representing the asynchronous operation.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		/// <param name="smoothness">The smoothness.</param>
		/// <param name="contrast">The contrast.</param>
		/// <summary>Creates a new normal map from the provided source texture and specified smoothness and contrast.</summary>
		[Export ("initByGeneratingNormalMapWithTexture:name:smoothness:contrast:")]
		NativeHandle Constructor (MDLTexture sourceTexture, [NullAllowed] string name, float smoothness, float contrast);
	}

	/// <summary>Base class for objects in a <see cref="ModelIO.MDLAsset" />.</summary>
	///     
	///     <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/ModelIO/Reference/MDLObject_Class/index.html">Apple documentation for <c>MDLObject</c></related>
	[MacCatalyst (13, 1)]
	[BaseType (typeof (NSObject))]
	interface MDLObject : MDLNamed {
		/// <summary>Gets the array of components that belong to this Model I/O object.</summary>
		[MacCatalyst (13, 1)]
		[Export ("components", ArgumentSemantic.Copy)]
		IMDLComponent [] Components { get; }

		/// <param name="component">The component to associate with AProtocol.</param>
		///         <param name="protocol">The protocol to associate with the component.</param>
		///         <summary>Associates <paramref name="component" /> with this MDLOBject for the specified protocol.</summary>
		[Export ("setComponent:forProtocol:")]
		void SetComponent (IMDLComponent component, Protocol protocol);

		/// <param name="component">The component to associate with a type.</param>
		///         <param name="type">The type to associate with the component.</param>
		///         <summary>Makes <paramref name="component" /> the object to provide for the specified <paramref name="type" />.</summary>
		[Wrap ("SetComponent (component, new Protocol (type!))")]
		void SetComponent (IMDLComponent component, Type type);

		/// <param name="protocol">The protocol for which to get the component.</param>
		///         <summary>Gets this object's component that conforms to <paramref name="protocol" />.</summary>
		///         <returns>The result of the operation.</returns>
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("componentConformingToProtocol:")]
		[return: NullAllowed]
		IMDLComponent GetComponent (Protocol protocol);

		/// <param name="type">The type to filter by.</param>
		///         <summary>Gets this object's component that matches the supplied <paramref name="type" />.</summary>
		///         <returns>The result of the operation.</returns>
		[Wrap ("GetComponent (new Protocol (type!))")]
		[return: NullAllowed]
		IMDLComponent GetComponent (Type type);

		/// <summary>Gets or sets this <see cref="ModelIO.MDLObject" /> object's parent, or <see langword="null" /> if this is a top-level object.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[NullAllowed, Export ("parent", ArgumentSemantic.Weak)]
		MDLObject Parent { get; set; }

		/// <summary>Gets or sets the Instance value.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[MacCatalyst (13, 1)]
		[NullAllowed, Export ("instance", ArgumentSemantic.Retain)]
		MDLObject Instance { get; set; }

		/// <summary>Gets the Path value.</summary>
		[MacCatalyst (13, 1)]
		[Export ("path")]
		string Path { get; }

		/// <param name="path">The path.</param>
		///         <summary>Returns the Model IO object at the specified path.</summary>
		///         <returns>The result of the operation.</returns>
		[MacCatalyst (13, 1)]
		[Export ("objectAtPath:")]
		MDLObject GetObject (string path);

		/// <param name="objectClass">The class of child objects to enumerate.</param>
		///         <param name="root">The root object whose children will be enumerated.</param>
		///         <param name="handler">A handler to run on each child object.</param>
		///         <param name="stop">Developers set this value to <see langword="true" /> to stop enumeration.</param>
		///         <summary>Runs the provided <paramref name="handler" /> on each component in <paramref name="root" />'s object hierarchy that matches the specified <paramref name="objectClass" />.</summary>
		[MacCatalyst (13, 1)]
		[Export ("enumerateChildObjectsOfClass:root:usingBlock:stopPointer:")]
		void EnumerateChildObjects (Class objectClass, MDLObject root, MDLObjectHandler handler, ref bool stop);

		/// <summary>Gets or sets the possibly time-dependent transform that establishes this <see cref="ModelIO.MDLObject" /> object's coordinate system in relation to its parent's coordinate system.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[NullAllowed, Export ("transform", ArgumentSemantic.Retain)]
		IMDLTransformComponent Transform { get; set; }

		/// <summary>Gets or sets the list of the objects of type <see cref="ModelIO.MDLObject" /> that belong to this <see cref="ModelIO.MDLObject" />.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[Export ("children", ArgumentSemantic.Retain)]
		IMDLObjectContainerComponent Children { get; set; }

		/// <summary>Gets or sets a Boolean value that controls whether the Model IO object is hidden.</summary>
		[MacCatalyst (13, 1)]
		[Export ("hidden")]
		bool Hidden { get; set; }

		/// <param name="child">The child.</param>
		///         <summary>Adds <paramref name="child" /> to this <see cref="ModelIO.MDLObject" /> object's <see cref="ModelIO.MDLObject.Children" /> property, creating <see cref="ModelIO.MDLObject.Children" />, if necessary.</summary>
		[Export ("addChild:")]
		void AddChild (MDLObject child);

		/// <param name="atTime">The time.</param>
		///         <summary>Returns the bounding box of the Model IO object at the specified time.</summary>
		///         <returns>The result of the operation.</returns>
		[Export ("boundingBoxAtTime:")]
		[MarshalDirective (NativePrefix = "xamarin_simd__", Library = "__Internal")]
		MDLAxisAlignedBoundingBox GetBoundingBox (double atTime);

		/// <param name="node">The node.</param>
		///         <summary>Creates a new MDLObject from the specified Scene Kit node.</summary>
		///         <returns>The result of the operation.</returns>
		[Static]
		[Export ("objectWithSCNNode:")]
		MDLObject FromNode (SCNNode node);

		/// <param name="node">The node.</param>
		///         <param name="bufferAllocator">
		///           <para>A task representing the asynchronous operation.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		///         <summary>Creates and returns a new Model IO object from the provided node.</summary>
		///         <returns>The result of the operation.</returns>
		[MacCatalyst (13, 1)]
		[Static]
		[Export ("objectWithSCNNode:bufferAllocator:")]
		MDLObject FromNode (SCNNode node, [NullAllowed] IMDLMeshBufferAllocator bufferAllocator);
	}

	/// <summary>A default implementation of the abstract <see cref="ModelIO.IMDLObjectContainerComponent" /> class.</summary>
	///     
	///     <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/ModelIO/Reference/MDLObjectContainer_Class/index.html">Apple documentation for <c>MDLObjectContainer</c></related>
	[MacCatalyst (13, 1)]
	[BaseType (typeof (NSObject))]
	interface MDLObjectContainer : MDLObjectContainerComponent {
	}

	interface IMDLObjectContainerComponent { }

	[MacCatalyst (13, 1)]
	[Protocol]
	interface MDLObjectContainerComponent : MDLComponent, INSFastEnumeration {
		/// <param name="object">The object.</param>
		/// <summary>Adds <paramref name="object" /> to the list of objects that are contained by this IMDLObjectContainerComponent.</summary>
		[Abstract]
		[Export ("addObject:")]
		void AddObject (MDLObject @object);

		/// <param name="object">The object.</param>
		/// <summary>Removes <paramref name="object" /> from the list of objects that are contained by this IMDLObjectContainerComponent.</summary>
		[Abstract]
		[Export ("removeObject:")]
		void RemoveObject (MDLObject @object);

		/// <param name="index">The index of the object to get.</param>
		/// <summary>Returns the object at the specified <paramref name="index" />.</summary>
		/// <returns>The result of the operation.</returns>
		[Abstract]
		[MacCatalyst (13, 1)]
		[Export ("objectAtIndexedSubscript:")]
		MDLObject GetObject (nuint index);

		/// <summary>Gets the number of objects in this container.</summary>
		[Abstract]
		[MacCatalyst (13, 1)]
		[Export ("count")]
		nuint Count { get; }

		/// <summary>Gets the list of objects that belong to this IMDLObjectContainerComponent.</summary>
		[Abstract]
		[Export ("objects", ArgumentSemantic.Retain)]
		MDLObject [] Objects { get; }
	}

	interface IMDLComponent { }

	[MacCatalyst (13, 1)]
	[Protocol]
	interface MDLComponent {
	}

	/// <summary>Represents a light that is derived from photometric data.</summary>
	///     
	///     <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/ModelIO/Reference/MDLPhotometricLight_Class/index.html">Apple documentation for <c>MDLPhotometricLight</c></related>
	[MacCatalyst (13, 1)]
	[BaseType (typeof (MDLPhysicallyPlausibleLight))]
	interface MDLPhotometricLight {
		/// <param name="url">The URL.</param>
		/// <summary>Creates a new MDLPhotometricLight from IES data that is contained at the specified URL.</summary>
		[Export ("initWithIESProfile:")]
		NativeHandle Constructor (NSUrl url);

		/// <param name="sphericalHarmonicsLevel">The spherical harmonics level.</param>
		/// <summary>Fills the <see cref="ModelIO.MDLPhotometricLight.SphericalHarmonicsCoefficients" /> property to the depth that is specified by <paramref name="sphericalHarmonicsLevel" />.</summary>
		[Export ("generateSphericalHarmonicsFromLight:")]
		void GenerateSphericalHarmonics (nuint sphericalHarmonicsLevel);

		/// <param name="textureSize">The texture size.</param>
		/// <summary>Fills the <see cref="ModelIO.MDLPhotometricLight.LightCubeMap" /> property with cube map data that has sides of length <paramref name="textureSize" />.</summary>
		[Export ("generateCubemapFromLight:")]
		void GenerateCubemap (nuint textureSize);

		/// <param name="textureSize">The texture size.</param>
		/// <summary>Performs the generate texture operation.</summary>
		/// <returns>The result of the operation.</returns>
		[MacCatalyst (13, 1)]
		[Export ("generateTexture:")]
		MDLTexture GenerateTexture (nuint textureSize);

		/// <summary>Gets the light cube map that describes the directional intensity of the light.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		///         <remarks>Gets a cube map that represents the light's intensity in all directions, if present.</remarks>
		[NullAllowed, Export ("lightCubeMap", ArgumentSemantic.Retain)]
		MDLTexture LightCubeMap { get; }

		/// <summary>Gets a value from <c>0</c> to <c>3</c> that represents the number of harmonics that are represented by  <see cref="ModelIO.MDLPhotometricLight.SphericalHarmonicsCoefficients" />.</summary>
		///         <remarks>There are 3 values in each coefficient. <see cref="ModelIO.MDLPhotometricLight.SphericalHarmonicsLevel" /> represent the highest index level in <see cref="ModelIO.MDLPhotometricLight.SphericalHarmonicsCoefficients" />. There are 2^(<see cref="ModelIO.MDLPhotometricLight.SphericalHarmonicsLevel" /> + 1) sets of 3-valued coefficients in the array.</remarks>
		[Export ("sphericalHarmonicsLevel")]
		nuint SphericalHarmonicsLevel { get; }

		/// <summary>Gets the spherical harmonics that control the light's directional intensity, if present.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[NullAllowed, Export ("sphericalHarmonicsCoefficients", ArgumentSemantic.Copy)]
		NSData SphericalHarmonicsCoefficients { get; }
	}

	/// <summary>Represents a light that plausibly attenutates and can represent black-body incandescence.</summary>
	///     
	///     <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/ModelIO/Reference/MDLPhysicallyPlausibleLight_Class/index.html">Apple documentation for <c>MDLPhysicallyPlausibleLight</c></related>
	[MacCatalyst (13, 1)]
	[BaseType (typeof (MDLLight))]
	interface MDLPhysicallyPlausibleLight {
		/// <param name="temperature">The temperature.</param>
		///         <summary>Sets the color of light by modeling black-body radiation at the specified temperature in °K.</summary>
		[Export ("setColorByTemperature:")]
		void SetColor (float temperature);

		/// <summary>Gets or sets the color of the light.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[NullAllowed, Export ("color", ArgumentSemantic.Assign)]
		CGColor Color { get; set; }

		/// <summary>Gets or sets the light's intensity. The default is <c>1000.0</c> lumens.</summary>
		[Export ("lumens")]
		float Lumens { get; set; }

		/// <summary>Gets or sets the angle, in radians, of the cone of full illumination.</summary>
		[Export ("innerConeAngle")]
		float InnerConeAngle { get; set; }

		/// <summary>Gets or sets the angle, in radians, of the cone of partial illumination, outside of which the illumination is zero.</summary>
		[Export ("outerConeAngle")]
		float OuterConeAngle { get; set; }

		/// <summary>Gets or sets the distance before which the light provides full illumination.</summary>
		[Export ("attenuationStartDistance")]
		float AttenuationStartDistance { get; set; }

		/// <summary>Gets or sets the distance after which the light provides no illumination.</summary>
		[Export ("attenuationEndDistance")]
		float AttenuationEndDistance { get; set; }
	}

	/// <summary>Represents a bidirectional reflectance distribution function to use when rendering a <see cref="ModelIO.MDLMaterialTextureWrapMode" />.</summary>
	///     <remarks>The properties on this object, except for <see cref="ModelIO.MDLPhysicallyPlausibleScatteringFunction.Version" /> have valid values only in the range [0.0, 1.0].</remarks>
	///     <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/ModelIO/Reference/MDLPhysicallyPlausibleScatteringFunction_Class/index.html">Apple documentation for <c>MDLPhysicallyPlausibleScatteringFunction</c></related>
	[MacCatalyst (13, 1)]
	[BaseType (typeof (MDLScatteringFunction))]
	interface MDLPhysicallyPlausibleScatteringFunction {
		/// <summary>Gets the scattering function version.</summary>
		[Export ("version")]
		nint Version { get; }

		/// <summary>Gets the degree to which light is scattered immediately beneath the surface. The default is <c>0.0</c>, which indicates very strong scattering.</summary>
		[Export ("subsurface", ArgumentSemantic.Retain)]
		MDLMaterialProperty Subsurface { get; }

		/// <summary>Gets the degree to which the surface appears metallic. The default is <c>0.0</c>, which indicates a nonmetallic surface.</summary>
		[Export ("metallic", ArgumentSemantic.Retain)]
		MDLMaterialProperty Metallic { get; }

		/// <summary>Gets the relative strength of specular highlights. The default is <c>0.0</c>, which indicates no specular highlights are visible.</summary>
		[Export ("specularAmount", ArgumentSemantic.Retain)]
		MDLMaterialProperty SpecularAmount { get; }

		/// <summary>Gets the degree to which specular reflections are tinted by the surface color. The default is <c>0.0</c>, which indicates that specular reflections are identical to the incident light color.</summary>
		[Export ("specularTint", ArgumentSemantic.Retain)]
		MDLMaterialProperty SpecularTint { get; }

		/// <summary>Gets the surface roughness. The default is <c>0.9</c>, which indicates a matte surface.</summary>
		[Export ("roughness", ArgumentSemantic.Retain)]
		MDLMaterialProperty Roughness { get; }

		/// <summary>Gets the degree to which reflection varies as a function of the angle from the tangential vector. The default is <c>0.0</c>, which indicates isotropic reflection.</summary>
		[Export ("anisotropic", ArgumentSemantic.Retain)]
		MDLMaterialProperty Anisotropic { get; }

		/// <summary>Gets the angular deviation from which anisotropic effects are calculated, relative to the tangential basis. The default is <c>0.0</c>, which indicates no deviation.</summary>
		[Export ("anisotropicRotation", ArgumentSemantic.Retain)]
		MDLMaterialProperty AnisotropicRotation { get; }

		/// <summary>Gets or sets the degree of added low-angle reflection. The default is <c>0.05</c>, which indicates a highlight that is just detectable.</summary>
		[Export ("sheen", ArgumentSemantic.Retain)]
		MDLMaterialProperty Sheen { get; }

		/// <summary>Gets the degree to which low-angle reflections are tinted by the surface color. The default is <c>0.0</c>, which indicates that low-angle reflections are identical to the incident light color.</summary>
		[Export ("sheenTint", ArgumentSemantic.Retain)]
		MDLMaterialProperty SheenTint { get; }

		/// <summary>Gets the intensity of secondary highlights. The default is <c>0.0</c>, which indicates no specular highlights.</summary>
		[Export ("clearcoat", ArgumentSemantic.Retain)]
		MDLMaterialProperty Clearcoat { get; }

		/// <summary>Gets the sharpness of secondary highlights. The default is <c>0.0</c>, which indicates blurry specular highlights.</summary>
		[Export ("clearcoatGloss", ArgumentSemantic.Retain)]
		MDLMaterialProperty ClearcoatGloss { get; }
	}

	/// <summary>Represents a Bidirectional Reflectance Distribution Funcion (BRDF) that defines a material's response to lighting conditions.</summary>
	///     
	///     <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/ModelIO/Reference/MDLScatteringFunction_Class/index.html">Apple documentation for <c>MDLScatteringFunction</c></related>
	[MacCatalyst (13, 1)]
	[BaseType (typeof (NSObject))]
	interface MDLScatteringFunction : MDLNamed {
		/// <summary>Gets the base color of the material.</summary>
		[Export ("baseColor", ArgumentSemantic.Retain)]
		MDLMaterialProperty BaseColor { get; }

		/// <summary>Gets the radiance color of the material, which provides a minimum illumination when the object is darkened by the rest of the lighting and shading model.</summary>
		[Export ("emission", ArgumentSemantic.Retain)]
		MDLMaterialProperty Emission { get; }

		/// <summary>Gets the intensity of specular highlighting.</summary>
		[Export ("specular", ArgumentSemantic.Retain)]
		MDLMaterialProperty Specular { get; }

		/// <summary>Gets the n2 term in Schlick's approximation of the Fresnel factor in specular relection..</summary>
		[Export ("materialIndexOfRefraction", ArgumentSemantic.Retain)]
		MDLMaterialProperty MaterialIndexOfRefraction { get; }

		/// <summary>Gets the n1 term in Schlick's approximation of the Fresnel factor in specular relection.</summary>
		[Export ("interfaceIndexOfRefraction", ArgumentSemantic.Retain)]
		MDLMaterialProperty InterfaceIndexOfRefraction { get; }

		/// <summary>Gets the deviation of surface normals in model coordinate space.</summary>
		[Export ("normal", ArgumentSemantic.Retain)]
		MDLMaterialProperty Normal { get; }

		/// <summary>Gets the degree to which ambient light is blocked by neighboring geometry.</summary>
		[Export ("ambientOcclusion", ArgumentSemantic.Retain)]
		MDLMaterialProperty AmbientOcclusion { get; }

		/// <summary>Gets a multiplier for the degree to which ambient light is blocked by neighboring geometry. The default value is <c>1.0</c>.</summary>
		[Export ("ambientOcclusionScale", ArgumentSemantic.Retain)]
		MDLMaterialProperty AmbientOcclusionScale { get; }
	}

	/// <summary>A texture that represents a realistic sunlit sky.</summary>
	///     
	///     <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/ModelIO/Reference/MDLSkyCubeTexture_Class/index.html">Apple documentation for <c>MDLSkyCubeTexture</c></related>
	[MacCatalyst (13, 1)]
	[BaseType (typeof (MDLTexture))]
	[DisableDefaultCtor]
	interface MDLSkyCubeTexture {
		/// <param name="pixelData">
		///           <para>A task representing the asynchronous operation.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		/// <param name="topLeftOrigin">The top left origin.</param>
		/// <param name="name">
		///           <para>A task representing the asynchronous operation.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		/// <param name="dimensions">The dimensions.</param>
		/// <param name="rowStride">The row stride.</param>
		/// <param name="channelCount">The channel count.</param>
		/// <param name="channelEncoding">The channel encoding.</param>
		/// <param name="isCube">The is cube.</param>
		/// <summary>Creates a new instance with the specified parameters.</summary>
		[Export ("initWithData:topLeftOrigin:name:dimensions:rowStride:channelCount:channelEncoding:isCube:")]
		[MarshalDirective (NativePrefix = "xamarin_simd__", Library = "__Internal")]
		NativeHandle Constructor ([NullAllowed] NSData pixelData, bool topLeftOrigin, [NullAllowed] string name, Vector2i dimensions, nint rowStride, nuint channelCount, MDLTextureChannelEncoding channelEncoding, bool isCube);

		/// <param name="name">
		///           <para>A task representing the asynchronous operation.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		/// <param name="channelEncoding">The channel encoding.</param>
		/// <param name="textureDimensions">The texture dimensions.</param>
		/// <param name="turbidity">The turbidity.</param>
		/// <param name="sunElevation">The sun elevation.</param>
		/// <param name="upperAtmosphereScattering">The upper atmosphere scattering.</param>
		/// <param name="groundAlbedo">The ground albedo.</param>
		/// <summary>Creates a new instance with the specified parameters.</summary>
		[Export ("initWithName:channelEncoding:textureDimensions:turbidity:sunElevation:upperAtmosphereScattering:groundAlbedo:")]
		[MarshalDirective (NativePrefix = "xamarin_simd__", Library = "__Internal")]
		NativeHandle Constructor ([NullAllowed] string name, MDLTextureChannelEncoding channelEncoding, Vector2i textureDimensions, float turbidity, float sunElevation, float upperAtmosphereScattering, float groundAlbedo);

		/// <param name="name">
		///           <para>A task representing the asynchronous operation.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		/// <param name="channelEncoding">The channel encoding.</param>
		/// <param name="textureDimensions">The texture dimensions.</param>
		/// <param name="turbidity">The turbidity.</param>
		/// <param name="sunElevation">The sun elevation.</param>
		/// <param name="sunAzimuth">The sun azimuth.</param>
		/// <param name="upperAtmosphereScattering">The upper atmosphere scattering.</param>
		/// <param name="groundAlbedo">The ground albedo.</param>
		/// <summary>Creates a new instance with the specified parameters.</summary>
		[MacCatalyst (13, 1)]
		[Export ("initWithName:channelEncoding:textureDimensions:turbidity:sunElevation:sunAzimuth:upperAtmosphereScattering:groundAlbedo:")]
		[MarshalDirective (NativePrefix = "xamarin_simd__", Library = "__Internal")]
		NativeHandle Constructor ([NullAllowed] string name, MDLTextureChannelEncoding channelEncoding, Vector2i textureDimensions, float turbidity, float sunElevation, float sunAzimuth, float upperAtmosphereScattering, float groundAlbedo);

		/// <summary>Regenerates the sky to match the current property values of this MDLSkyCubeTexture object.</summary>
		[Export ("updateTexture")]
		void UpdateTexture ();

		/// <summary>Gets or sets the haziness of the simulated sky, on a scale from <c>0.0</c> to <c>1.0</c>.</summary>
		[Export ("turbidity")]
		float Turbidity { get; set; }

		/// <summary>Gets or sets the angular position, from the zenith, of the Sun's position.</summary>
		///         <remarks>To control the horizontal position of the sun, app developers should rotate the scene within the sky cube.</remarks>
		[Export ("sunElevation")]
		float SunElevation { get; set; }

		/// <summary>Gets or sets the SunAzimuth value.</summary>
		[MacCatalyst (13, 1)]
		[Export ("sunAzimuth")]
		float SunAzimuth { get; set; }

		/// <summary>Gets or sets the scattering present in the upper regions of the simulated sky, on a scale from <c>0.0</c> (similar to illumination at dawn or dusk) to <c>1.0</c> (similar to midday illumination).</summary>
		[Export ("upperAtmosphereScattering")]
		float UpperAtmosphereScattering { get; set; }

		/// <summary>Gets or sets the relative amount of light, from <c>0.0</c> to <c>10.0</c>, that reflects off the ground. Lower values produce an effect similar to a clear sky.</summary>
		[Export ("groundAlbedo")]
		float GroundAlbedo { get; set; }

		/// <summary>Gets or sets the angular height, in radians, below which the ground color affects the rendering outcome.</summary>
		[Export ("horizonElevation")]
		float HorizonElevation { get; set; }

		/// <summary>Gets or sets the ground color.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[NullAllowed]
		[Export ("groundColor", ArgumentSemantic.Assign)]
		CGColor GroundColor { get; set; }

		/// <summary>Gets or sets a gamma correction factor to use when tone mapping.</summary>
		[Export ("gamma")]
		float Gamma { get; set; }

		/// <summary>Gets or sets a the exposure to use when tone mapping.</summary>
		[Export ("exposure")]
		float Exposure { get; set; }

		/// <summary>Gets or sets a brightness multiplier to use when tone mapping.</summary>
		[Export ("brightness")]
		float Brightness { get; set; }

		/// <summary>Gets or sets a contrast multiplier to use when tone mapping.</summary>
		[Export ("contrast")]
		float Contrast { get; set; }

		/// <summary>Gets or sets the saturation to use when tone mapping.</summary>
		[Export ("saturation")]
		float Saturation { get; set; }

		/// <summary>Gets or sets a vector, that filters and clamps color values for HDR compression.</summary>
		///         <remarks>Color values that are below the X value of this property's vector value are ignored. Thos above the Y value are clamped to the maximum display brightness.</remarks>
		[Export ("highDynamicRangeCompression", ArgumentSemantic.Assign)]
		Vector2 HighDynamicRangeCompression {
			[MarshalDirective (NativePrefix = "xamarin_simd__", Library = "__Internal")]
			get;
			[MarshalDirective (NativePrefix = "xamarin_simd__", Library = "__Internal")]
			set;
		}
	}

	/// <summary>A camera that can be used to render stereoscopic views of a scene.</summary>
	///     
	///     <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/ModelIO/Reference/MDLStereoscopicCamera_Class/index.html">Apple documentation for <c>MDLStereoscopicCamera</c></related>
	[MacCatalyst (13, 1)]
	[BaseType (typeof (MDLCamera))]
	interface MDLStereoscopicCamera {
		/// <summary>Gets or sets the distance, in millimeters, between the centers of the camera viewpoints.</summary>
		[Export ("interPupillaryDistance")]
		float InterPupillaryDistance { get; set; }

		/// <summary>Gets or sets the angle in degrees at which the left viewpoint looks toward the centerline.</summary>
		[Export ("leftVergence")]
		float LeftVergence { get; set; }

		/// <summary>Gets or sets the angle in degrees at which the right viewpoint looks toward the centerline.</summary>
		[Export ("rightVergence")]
		float RightVergence { get; set; }

		/// <summary>The fraction of the image width by which the left and right images overlap.</summary>
		[Export ("overlap")]
		float Overlap { get; set; }

		/// <summary>Gets the view matrix for the left viewpoint.</summary>
		[Export ("leftViewMatrix")]
		Matrix4 LeftViewMatrix {
			[MarshalDirective (NativePrefix = "xamarin_simd__", Library = "__Internal")]
			get;
		}

		/// <summary>Gets the view matrix for the right viewpoint.</summary>
		[Export ("rightViewMatrix")]
		Matrix4 RightViewMatrix {
			[MarshalDirective (NativePrefix = "xamarin_simd__", Library = "__Internal")]
			get;
		}

		/// <summary>Gets the projection matrix for the left viewpoint.</summary>
		[Export ("leftProjectionMatrix")]
		Matrix4 LeftProjectionMatrix {
			[MarshalDirective (NativePrefix = "xamarin_simd__", Library = "__Internal")]
			get;
		}

		/// <summary>Gets the projection matrix for the right viewpoint.</summary>
		[Export ("rightProjectionMatrix")]
		Matrix4 RightProjectionMatrix {
			[MarshalDirective (NativePrefix = "xamarin_simd__", Library = "__Internal")]
			get;
		}
	}

	/// <summary>Indexes and identifies APortion of an MDLMesh, and contains material information about the indexed portion.</summary>
	///     
	///     <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/ModelIO/Reference/MDLSubmesh_Class/index.html">Apple documentation for <c>MDLSubmesh</c></related>
	[MacCatalyst (13, 1)]
	[BaseType (typeof (NSObject))]
	interface MDLSubmesh : MDLNamed {
		/// <param name="name">The name.</param>
		/// <param name="indexBuffer">The index buffer.</param>
		/// <param name="indexCount">The index count.</param>
		/// <param name="indexType">The index type.</param>
		/// <param name="geometryType">The geometry type.</param>
		/// <param name="material">
		///           <para>A task representing the asynchronous operation.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		/// <summary>Creates a new instance with the specified parameters.</summary>
		[Export ("initWithName:indexBuffer:indexCount:indexType:geometryType:material:")]
		NativeHandle Constructor (string name, IMDLMeshBuffer indexBuffer, nuint indexCount, MDLIndexBitDepth indexType, MDLGeometryType geometryType, [NullAllowed] MDLMaterial material);

		/// <param name="indexBuffer">The index buffer.</param>
		/// <param name="indexCount">The index count.</param>
		/// <param name="indexType">The index type.</param>
		/// <param name="geometryType">The geometry type.</param>
		/// <param name="material">
		///           <para>A task representing the asynchronous operation.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		/// <summary>Creates a new instance with the specified parameters.</summary>
		[Export ("initWithIndexBuffer:indexCount:indexType:geometryType:material:")]
		NativeHandle Constructor (IMDLMeshBuffer indexBuffer, nuint indexCount, MDLIndexBitDepth indexType, MDLGeometryType geometryType, [NullAllowed] MDLMaterial material);

		/// <param name="name">The name.</param>
		/// <param name="indexBuffer">The index buffer.</param>
		/// <param name="indexCount">The index count.</param>
		/// <param name="indexType">The index type.</param>
		/// <param name="geometryType">The geometry type.</param>
		/// <param name="material">
		///           <para>A task representing the asynchronous operation.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		/// <param name="topology">
		///           <para>A task representing the asynchronous operation.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		/// <summary>Creates a new instance with the specified parameters.</summary>
		[Export ("initWithName:indexBuffer:indexCount:indexType:geometryType:material:topology:")]
		NativeHandle Constructor (string name, IMDLMeshBuffer indexBuffer, nuint indexCount, MDLIndexBitDepth indexType, MDLGeometryType geometryType, [NullAllowed] MDLMaterial material, [NullAllowed] MDLSubmeshTopology topology);

		/// <param name="indexBuffer">The index buffer.</param>
		/// <param name="indexType">The index type.</param>
		/// <param name="geometryType">The geometry type.</param>
		/// <summary>Creates a new MDLSubmesh with the specified parameters.</summary>
		/// <remarks>If either <paramref name="indexType" /> or <paramref name="geometryType" /> do not match the type of data in <paramref name="indexBuffer" />, then a new buffer is created and filled with converted data.</remarks>
		[Export ("initWithMDLSubmesh:indexType:geometryType:")]
		NativeHandle Constructor (MDLSubmesh indexBuffer, MDLIndexBitDepth indexType, MDLGeometryType geometryType);

		/// <summary>Gets the buffer whose indices sequence the vertex data into interpretable geometry.</summary>
		[Export ("indexBuffer", ArgumentSemantic.Retain)]
		IMDLMeshBuffer IndexBuffer { get; }

		/// <param name="indexType">The index type.</param>
		///         <summary>Returns the index buffer for the submesh with the specified bit depth.</summary>
		///         <returns>The result of the operation.</returns>
		[MacCatalyst (13, 1)]
		[Export ("indexBufferAsIndexType:")]
		IMDLMeshBuffer GetIndexBuffer (MDLIndexBitDepth indexType);

		/// <summary>Gets the number of indices in the index buffer.</summary>
		[Export ("indexCount")]
		nuint IndexCount { get; }

		/// <summary>Gets the numeric data type of the values in the index buffer.</summary>
		[Export ("indexType")]
		MDLIndexBitDepth IndexType { get; }

		/// <summary>Gets or sets the geometry type of the submesh.</summary>
		[Export ("geometryType")]
		MDLGeometryType GeometryType { get; }

		/// <summary>Gets or sets the material to use when rendering the submesh.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[NullAllowed, Export ("material", ArgumentSemantic.Retain)]
		MDLMaterial Material { get; set; }

		/// <summary>Gets a value that controls how the vertices in the submesh define the geometry of the mesh.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		///         <remarks>Gets or sets an object that describes the submesh's topology.</remarks>
		[NullAllowed, Export ("topology", ArgumentSemantic.Retain)]
		MDLSubmeshTopology Topology {
			get;
			[MacCatalyst (13, 1)]
			set;
		}

		/// <param name="element">The element.</param>
		///         <summary>Creates a new MDLSubmesh object from the specified Scene Kit geometry element.</summary>
		///         <returns>The result of the operation.</returns>
		[Static]
		[Export ("submeshWithSCNGeometryElement:")]
		MDLSubmesh FromGeometryElement (SCNGeometryElement element);

		/// <param name="element">The element.</param>
		///         <param name="bufferAllocator">
		///           <para>A task representing the asynchronous operation.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		///         <summary>Creates a new submesh from the provided Scene Kit element.</summary>
		///         <returns>The result of the operation.</returns>
		[MacCatalyst (13, 1)]
		[Static]
		[Export ("submeshWithSCNGeometryElement:bufferAllocator:")]
		MDLSubmesh FromGeometryElement (SCNGeometryElement element, [NullAllowed] IMDLMeshBufferAllocator bufferAllocator);
	}

	/// <summary>Represents texel data for surface rendering.</summary>
	///     
	///     <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/ModelIO/Reference/MDLTexture_Class/index.html">Apple documentation for <c>MDLTexture</c></related>
	[MacCatalyst (13, 1)]
	[BaseType (typeof (NSObject))]
	[DisableDefaultCtor] // designated
	interface MDLTexture : MDLNamed {
		/// <summary>Default constructor, initializes a new instance of this class.</summary>
		/// <remarks>
		///         </remarks>
		[DesignatedInitializer]
		[Export ("init")]
		NativeHandle Constructor ();

		/// <summary>Creates a new texture from the specified texture in the default application bundle.</summary>
		[Static]
		[Export ("textureNamed:")]
		[return: NullAllowed]
		MDLTexture CreateTexture (string name);

		/// <summary>Creates a new texture from the specified texture in the specified application bundle.</summary>
		[Static]
		[Export ("textureNamed:bundle:")]
		[return: NullAllowed]
		MDLTexture CreateTexture (string name, [NullAllowed] NSBundle bundleOrNil);

		/// <param name="name">The name.</param>
		///         <param name="resolver">The resolver.</param>
		///         <summary>Performs the create texture operation.</summary>
		///         <returns>The result of the operation.</returns>
		[MacCatalyst (13, 1)]
		[Static]
		[Export ("textureNamed:assetResolver:")]
		[return: NullAllowed]
		MDLTexture CreateTexture (string name, IMDLAssetResolver resolver);

		/// <param name="imageNames">The image names.</param>
		///         <summary>Creates a texture cube from the named images in the default application bundle.</summary>
		///         <returns>The result of the operation.</returns>
		[Static]
		[Export ("textureCubeWithImagesNamed:")]
		[return: NullAllowed]
		MDLTexture CreateTextureCube (string [] imageNames);

		/// <param name="imageNames">The image names.</param>
		///         <param name="bundleOrNil">
		///           <para>A task representing the asynchronous operation.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		///         <summary>Creates a texture cube from the named images in the specified application bundle.</summary>
		///         <returns>The result of the operation.</returns>
		[Static]
		[Export ("textureCubeWithImagesNamed:bundle:")]
		[return: NullAllowed]
		MDLTexture CreateTextureCube (string [] imageNames, [NullAllowed] NSBundle bundleOrNil);

		/// <param name="texture">The texture.</param>
		/// <param name="name">
		///           <para>A task representing the asynchronous operation.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		/// <param name="dimensions">The dimensions.</param>
		/// <summary>Creates an cubical irradiance map from an environment map.</summary>
		/// <returns>The result of the operation.</returns>
		[Static]
		[Export ("irradianceTextureCubeWithTexture:name:dimensions:")]
		[MarshalDirective (NativePrefix = "xamarin_simd__", Library = "__Internal")]
		MDLTexture CreateIrradianceTextureCube (MDLTexture texture, [NullAllowed] string name, Vector2i dimensions);

		[Static]
		[Export ("irradianceTextureCubeWithTexture:name:dimensions:roughness:")]
		[MarshalDirective (NativePrefix = "xamarin_simd__", Library = "__Internal")]
		MDLTexture CreateIrradianceTextureCube (MDLTexture reflectiveTexture, [NullAllowed] string name, Vector2i dimensions, float roughness);

		/// <param name="pixelData">
		///           <para>A task representing the asynchronous operation.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		/// <param name="topLeftOrigin">The top left origin.</param>
		/// <param name="name">
		///           <para>A task representing the asynchronous operation.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		/// <param name="dimensions">The dimensions.</param>
		/// <param name="rowStride">The row stride.</param>
		/// <param name="channelCount">The channel count.</param>
		/// <param name="channelEncoding">The channel encoding.</param>
		/// <param name="isCube">The is cube.</param>
		/// <summary>Creates a new instance with the specified parameters.</summary>
		[Export ("initWithData:topLeftOrigin:name:dimensions:rowStride:channelCount:channelEncoding:isCube:")]
		[DesignatedInitializer]
		[MarshalDirective (NativePrefix = "xamarin_simd__", Library = "__Internal")]
		NativeHandle Constructor ([NullAllowed] NSData pixelData, bool topLeftOrigin, [NullAllowed] string name, Vector2i dimensions, nint rowStride, nuint channelCount, MDLTextureChannelEncoding channelEncoding, bool isCube);

		/// <param name="url">The URL.</param>
		///         <summary>Writes the texture data to the specified URL.</summary>
		///         <returns>The result of the operation.</returns>
		[Export ("writeToURL:")]
		bool WriteToUrl (NSUrl url);

		/// <param name="url">The URL.</param>
		/// <param name="level">The level.</param>
		/// <summary>Performs the write to url operation.</summary>
		/// <returns>The result of the operation.</returns>
		[MacCatalyst (13, 1)]
		[Export ("writeToURL:level:")]
		bool WriteToUrl (NSUrl url, nuint level);

		/// <param name="url">The URL.</param>
		///         <param name="type">The type.</param>
		///         <summary>Writes the texture data to the specified URL.</summary>
		///         <returns>The result of the operation.</returns>
		[Export ("writeToURL:type:")]
		bool WriteToUrl (NSUrl url, string type);

		/// <param name="nsurl">The nsurl.</param>
		/// <param name="type">The type.</param>
		/// <param name="level">The level.</param>
		/// <summary>Performs the write to url operation.</summary>
		/// <returns>The result of the operation.</returns>
		[MacCatalyst (13, 1)]
		[Export ("writeToURL:type:level:")]
		bool WriteToUrl (NSUrl nsurl, string type, nuint level);

		/// <summary>Returns an image created from the texture data.</summary>
		///         <returns>The result of the operation.</returns>
		[Export ("imageFromTexture")]
		[return: NullAllowed]
		CGImage GetImageFromTexture ();

		/// <param name="level">The level.</param>
		/// <summary>Performs the get image from texture operation.</summary>
		/// <returns>The result of the operation.</returns>
		[MacCatalyst (13, 1)]
		[Export ("imageFromTextureAtLevel:")]
		[return: NullAllowed]
		CGImage GetImageFromTexture (nuint level);

		/// <summary>Gets the texel data such that the first texel represents the top left corner of the texture.</summary>
		///         <returns>The result of the operation.</returns>
		[Export ("texelDataWithTopLeftOrigin")]
		[return: NullAllowed]
		NSData GetTexelDataWithTopLeftOrigin ();

		/// <summary>Gets the texel data such that the first texel represents the bottom left corner of the texture.</summary>
		///         <returns>The result of the operation.</returns>
		[Export ("texelDataWithBottomLeftOrigin")]
		[return: NullAllowed]
		NSData GetTexelDataWithBottomLeftOrigin ();

		/// <param name="mipLevel">The mip level.</param>
		/// <param name="create">The create.</param>
		/// <summary>Performs the get texel data with top left origin operation.</summary>
		/// <returns>The result of the operation.</returns>
		[Export ("texelDataWithTopLeftOriginAtMipLevel:create:")]
		[return: NullAllowed]
		NSData GetTexelDataWithTopLeftOrigin (nint mipLevel, bool create);

		/// <param name="mipLevel">The mip level.</param>
		/// <param name="create">The create.</param>
		/// <summary>Performs the get texel data with bottom left origin operation.</summary>
		/// <returns>The result of the operation.</returns>
		[Export ("texelDataWithBottomLeftOriginAtMipLevel:create:")]
		[return: NullAllowed]
		NSData GetTexelDataWithBottomLeftOrigin (nint mipLevel, bool create);

		/// <summary>Gets the width and height of the texture, in texels.</summary>
		[Export ("dimensions")]
		Vector2i Dimensions {
			[MarshalDirective (NativePrefix = "xamarin_simd__", Library = "__Internal")]
			get;
		}

		/// <summary>Gets the row stride length in bytes.</summary>
		[Export ("rowStride")]
		nint RowStride { get; }

		/// <summary>Gets the number of channels per texel.</summary>
		[Export ("channelCount")]
		nuint ChannelCount { get; }

		/// <summary>Gets the maximum number of mipmap levels for the texture.</summary>
		[Export ("mipLevelCount")]
		nuint MipLevelCount { get; }

		/// <summary>Gets a value that represents the encoding for texels in the texture.</summary>
		[Export ("channelEncoding")]
		MDLTextureChannelEncoding ChannelEncoding { get; }

		/// <summary>Gets or sets a value that determines whether the texture should be interpreted as a cube.</summary>
		[Export ("isCube")]
		bool IsCube { get; set; }

		/// <summary>Gets or sets the HasAlphaValues value.</summary>
		[MacCatalyst (13, 1)]
		[Export ("hasAlphaValues")]
		bool HasAlphaValues { get; set; }
	}

	/// <summary>Describes filtering modes for rendering by sampling a texture.</summary>
	///     
	///     <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/ModelIO/Reference/MDLTextureFilter_Class/index.html">Apple documentation for <c>MDLTextureFilter</c></related>
	[MacCatalyst (13, 1)]
	[BaseType (typeof (NSObject))]
	interface MDLTextureFilter {
		/// <summary>Gets or sets the wrapping mode for S-coordinates.</summary>
		[Export ("sWrapMode", ArgumentSemantic.Assign)]
		MDLMaterialTextureWrapMode SWrapMode { get; set; }

		/// <summary>Gets or sets the wrapping mode for T-coordinates.</summary>
		[Export ("tWrapMode", ArgumentSemantic.Assign)]
		MDLMaterialTextureWrapMode TWrapMode { get; set; }

		/// <summary>Gets or sets the wrapping mode for R-coordinates.</summary>
		[Export ("rWrapMode", ArgumentSemantic.Assign)]
		MDLMaterialTextureWrapMode RWrapMode { get; set; }

		/// <summary>Gets or sets the filtering mode for rendering shrunken versions of the texture.</summary>
		[Export ("minFilter", ArgumentSemantic.Assign)]
		MDLMaterialTextureFilterMode MinFilter { get; set; }

		/// <summary>Gets or sets the filtering mode for rendering magnified versions of the texture.</summary>
		[Export ("magFilter", ArgumentSemantic.Assign)]
		MDLMaterialTextureFilterMode MagFilter { get; set; }

		/// <summary>Gets or sets the filtering mode for rendering with mipmaps.</summary>
		[Export ("mipFilter", ArgumentSemantic.Assign)]
		MDLMaterialMipMapFilterMode MipFilter { get; set; }
	}

	/// <summary>Represents a texture and sampling parameters to use when rendering the texture.</summary>
	///     
	///     <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/ModelIO/Reference/MDLTextureSampler_Class/index.html">Apple documentation for <c>MDLTextureSampler</c></related>
	[MacCatalyst (13, 1)]
	[BaseType (typeof (NSObject))]
	interface MDLTextureSampler {
		/// <summary>Gets or sets the texture to sample.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[NullAllowed, Export ("texture", ArgumentSemantic.Retain)]
		MDLTexture Texture { get; set; }

		/// <summary>Gets or sets the filter to use to perform hardware filtering.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[NullAllowed, Export ("hardwareFilter", ArgumentSemantic.Retain)]
		MDLTextureFilter HardwareFilter { get; set; }

		/// <summary>Gets or sets the pre-sample transform.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		///         <remarks>Gets or sets a transfomation to apply to coordinates before sampling the texture.</remarks>
		[NullAllowed, Export ("transform", ArgumentSemantic.Retain)]
		MDLTransform Transform { get; set; }
	}

	/// <summary>Represents static and animated coordinate transformations.</summary>
	///     
	///     <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/ModelIO/Reference/MDLTransform_Class/index.html">Apple documentation for <c>MDLTransform</c></related>
	[MacCatalyst (13, 1)]
	[BaseType (typeof (NSObject))]
	[DesignatedDefaultCtor]
	interface MDLTransform : MDLTransformComponent, NSCopying {

		/// <param name="component">The component.</param>
		/// <summary>Creates a new MDLTransform from the specified transform component.</summary>
		[Export ("initWithTransformComponent:")]
		NativeHandle Constructor (IMDLTransformComponent component);

		/// <param name="component">The component.</param>
		/// <param name="resetsTransform">The resets transform.</param>
		/// <summary>Creates a new transform that represents the specified transform <paramref name="component" />.</summary>
		[MacCatalyst (13, 1)]
		[Export ("initWithTransformComponent:resetsTransform:")]
		NativeHandle Constructor (IMDLTransformComponent component, bool resetsTransform);

		/// <param name="matrix">The matrix.</param>
		/// <summary>Creates a new MDLTransform from the specified matrix.</summary>
		[Export ("initWithMatrix:")]
		[MarshalDirective (NativePrefix = "xamarin_simd__", Library = "__Internal")]
		NativeHandle Constructor (Matrix4 matrix);

		/// <param name="matrix">The matrix.</param>
		/// <param name="resetsTransform">The resets transform.</param>
		/// <summary>Creates a new MDLTransform from the specified matrix.</summary>
		[MacCatalyst (13, 1)]
		[Export ("initWithMatrix:resetsTransform:")]
		[MarshalDirective (NativePrefix = "xamarin_simd__", Library = "__Internal")]
		NativeHandle Constructor (Matrix4 matrix, bool resetsTransform);

		/// <summary>Makes the transform identical to the identity transform.</summary>
		[Export ("setIdentity")]
		void SetIdentity ();

		/// <param name="atTime">The time.</param>
		///         <summary>Returns the shear of the transform at the specified time.</summary>
		///         <returns>The result of the operation.</returns>
		[Export ("shearAtTime:")]
		[MarshalDirective (NativePrefix = "xamarin_simd__", Library = "__Internal")]
		Vector3 GetShear (double atTime);

		/// <param name="atTime">The time.</param>
		///         <summary>Returns the scale of the transform at the specified time.</summary>
		///         <returns>The result of the operation.</returns>
		[Export ("scaleAtTime:")]
		[MarshalDirective (NativePrefix = "xamarin_simd__", Library = "__Internal")]
		Vector3 GetScale (double atTime);

		/// <param name="atTime">The time.</param>
		///         <summary>Returns the translation of the transform at the specified time.</summary>
		///         <returns>The result of the operation.</returns>
		[Export ("translationAtTime:")]
		[MarshalDirective (NativePrefix = "xamarin_simd__", Library = "__Internal")]
		Vector3 GetTranslation (double atTime);

		/// <param name="atTime">The time.</param>
		///         <summary>Returns the rotation of the transform at the specified time.</summary>
		///         <returns>The result of the operation.</returns>
		[Export ("rotationAtTime:")]
		[MarshalDirective (NativePrefix = "xamarin_simd__", Library = "__Internal")]
		Vector3 GetRotation (double atTime);

		/// <param name="atTime">The time.</param>
		///         <summary>Returns the rotation of the transform at the specified time.</summary>
		///         <returns>The result of the operation.</returns>
		[Export ("rotationMatrixAtTime:")]
		[MarshalDirective (NativePrefix = "xamarin_simd__", Library = "__Internal")]
		Matrix4 GetRotationMatrix (double atTime);

		[Export ("setShear:forTime:")]
		[MarshalDirective (NativePrefix = "xamarin_simd__", Library = "__Internal")]
		void SetShear (Vector3 scale, double time);

		[Export ("setScale:forTime:")]
		[MarshalDirective (NativePrefix = "xamarin_simd__", Library = "__Internal")]
		void SetScale (Vector3 scale, double time);

		[Export ("setTranslation:forTime:")]
		[MarshalDirective (NativePrefix = "xamarin_simd__", Library = "__Internal")]
		void SetTranslation (Vector3 translation, double time);

		[Export ("setRotation:forTime:")]
		[MarshalDirective (NativePrefix = "xamarin_simd__", Library = "__Internal")]
		void SetRotation (Vector3 rotation, double time);

		[MacCatalyst (13, 1)]
		[Export ("setMatrix:forTime:")]
		[MarshalDirective (NativePrefix = "xamarin_simd__", Library = "__Internal")]
		void SetMatrix (Matrix4 matrix, double time);

		/// <summary>Gets or sets the shear of the transform.</summary>
		[Export ("shear", ArgumentSemantic.Assign)]
		Vector3 Shear {
			[MarshalDirective (NativePrefix = "xamarin_simd__", Library = "__Internal")]
			get;
			[MarshalDirective (NativePrefix = "xamarin_simd__", Library = "__Internal")]
			set;
		}

		/// <summary>Gets or sets the componentwise scale factors of the transform.</summary>
		[Export ("scale", ArgumentSemantic.Assign)]
		Vector3 Scale {
			[MarshalDirective (NativePrefix = "xamarin_simd__", Library = "__Internal")]
			get;
			[MarshalDirective (NativePrefix = "xamarin_simd__", Library = "__Internal")]
			set;
		}

		/// <summary>Gets or sets the translation of the transform.</summary>
		[Export ("translation", ArgumentSemantic.Assign)]
		Vector3 Translation {
			[MarshalDirective (NativePrefix = "xamarin_simd__", Library = "__Internal")]
			get;
			[MarshalDirective (NativePrefix = "xamarin_simd__", Library = "__Internal")]
			set;
		}

		/// <summary>Gets or sets the rotation aspect of the transformation.</summary>
		[Export ("rotation", ArgumentSemantic.Assign)]
		Vector3 Rotation {
			[MarshalDirective (NativePrefix = "xamarin_simd__", Library = "__Internal")]
			get;
			[MarshalDirective (NativePrefix = "xamarin_simd__", Library = "__Internal")]
			set;
		}
	}

	interface IMDLTransformComponent { }

	[MacCatalyst (13, 1)]
	[Protocol]
	interface MDLTransformComponent : MDLComponent {
		/// <summary>Gets or sets the matrix of the transform at the earliest specified time.</summary>
		[Abstract]
		[Export ("matrix", ArgumentSemantic.Assign)]
		Matrix4 Matrix {
			[MarshalDirective (NativePrefix = "xamarin_simd__", Library = "__Internal")]
			get;
			[MarshalDirective (NativePrefix = "xamarin_simd__", Library = "__Internal")]
			set;
		}

		/// <summary>Inserts the specified transform at the specified time.</summary>
		[MacCatalyst (13, 1)]
		[Abstract]
		[Export ("resetsTransform")]
		bool ResetsTransform { get; set; }

		/// <summary>Gets the first specified time in the transformation.</summary>
		[Abstract]
		[Export ("minimumTime")]
		double MinimumTime { get; }

		/// <summary>Gets the last specified time in the transformation.</summary>
		[Abstract]
		[Export ("maximumTime")]
		double MaximumTime { get; }

		// Added in iOS 10 SDK but it is supposed to be present in iOS 9.
		/// <summary>Gets the KeyTimes value.</summary>
		[MacCatalyst (13, 1)]
		[Abstract]
		[Export ("keyTimes", ArgumentSemantic.Copy)]
		NSNumber [] KeyTimes { get; }

		/// <summary>Causes this transform to represent the specified static transform.</summary>
		[Export ("setLocalTransform:forTime:")]
		[MarshalDirective (NativePrefix = "xamarin_simd__", Library = "__Internal")]
		void SetLocalTransform (Matrix4 transform, double time);

		/// <summary>Causes this transform to represent the specified static transform.</summary>
		[Export ("setLocalTransform:")]
		[MarshalDirective (NativePrefix = "xamarin_simd__", Library = "__Internal")]
		void SetLocalTransform (Matrix4 transform);

		/// <param name="atTime">The time for which to retrieve the local transform.</param>
		/// <summary>Gets the local transform at the specified time.</summary>
		/// <returns>The result of the operation.</returns>
		[Export ("localTransformAtTime:")]
		[MarshalDirective (NativePrefix = "xamarin_simd__", Library = "__Internal")]
		Matrix4 GetLocalTransform (double atTime);

		/// <summary>Creates and returns a global transform for the specified object at the specified time.</summary>
		/// <param name="obj">The object that represents the spatial transform.</param>
		/// <param name="atTime">The time at which to apply the transform.</param>
		[Static]
		[Export ("globalTransformWithObject:atTime:")]
		[MarshalDirective (NativePrefix = "xamarin_simd__", Library = "__Internal")]
		Matrix4 CreateGlobalTransform (MDLObject obj, double atTime);
	}

	/// <summary>Encapsulates on-demand loading of a texture at a URL.</summary>
	///     
	///     <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/ModelIO/Reference/MDLURLTexture_Class/index.html">Apple documentation for <c>MDLURLTexture</c></related>
	[MacCatalyst (13, 1)]
	[BaseType (typeof (MDLTexture), Name = "MDLURLTexture")]
	[DisableDefaultCtor]
	interface MDLUrlTexture {
		/// <param name="pixelData">
		///           <para>A task representing the asynchronous operation.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		/// <param name="topLeftOrigin">The top left origin.</param>
		/// <param name="name">
		///           <para>A task representing the asynchronous operation.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		/// <param name="dimensions">The dimensions.</param>
		/// <param name="rowStride">The row stride.</param>
		/// <param name="channelCount">The channel count.</param>
		/// <param name="channelEncoding">The channel encoding.</param>
		/// <param name="isCube">The is cube.</param>
		/// <summary>Creates a new instance with the specified parameters.</summary>
		[Export ("initWithData:topLeftOrigin:name:dimensions:rowStride:channelCount:channelEncoding:isCube:")]
		[MarshalDirective (NativePrefix = "xamarin_simd__", Library = "__Internal")]
		NativeHandle Constructor ([NullAllowed] NSData pixelData, bool topLeftOrigin, [NullAllowed] string name, Vector2i dimensions, nint rowStride, nuint channelCount, MDLTextureChannelEncoding channelEncoding, bool isCube);

		/// <param name="url">The URL.</param>
		/// <param name="name">
		///           <para>A task representing the asynchronous operation.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		/// <summary>Creates a new MDLUrlTexture with the specified URL and name.</summary>
		[Export ("initWithURL:name:")]
		NativeHandle Constructor (NSUrl url, [NullAllowed] string name);

		/// <summary>Gets or sets the URL for the MDLURLTexture.</summary>
		[Export ("URL", ArgumentSemantic.Copy)]
		NSUrl Url { get; set; }
	}

	/// <summary>Describes the physical layout and semantic content of vertex data in an index buffer.</summary>
	///     
	///     <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/ModelIO/Reference/MDLVertexAttribute_Class/index.html">Apple documentation for <c>MDLVertexAttribute</c></related>
	[MacCatalyst (13, 1)]
	[BaseType (typeof (NSObject))]
	interface MDLVertexAttribute : NSCopying {
		/// <param name="name">The name.</param>
		/// <param name="format">The format.</param>
		/// <param name="offset">The offset.</param>
		/// <param name="bufferIndex">The buffer index.</param>
		/// <summary>Creates a new MDLVertexAttribute with the specified values.</summary>
		[Export ("initWithName:format:offset:bufferIndex:")]
		NativeHandle Constructor (string name, MDLVertexFormat format, nuint offset, nuint bufferIndex);

		/// <summary>Gets or sets the name of the attribute. Application developers should use values from <see cref="ModelIO.MDLVertexAttributes" />.</summary>
		[Export ("name")]
		string Name { get; set; }

		/// <summary>Gets or sets a descriptor for the physical data format of the attribute.</summary>
		[Export ("format", ArgumentSemantic.Assign)]
		MDLVertexFormat Format { get; set; }

		/// <summary>Gets the byte offset that locates this attribute relative to the start of a vertex datum in the vertex buffer.</summary>
		[Export ("offset", ArgumentSemantic.Assign)]
		nuint Offset { get; set; }

		/// <summary>Gets or sets the index into the array of vertex buffers that specifies the buffer that is described by this vertex attribute.</summary>
		[Export ("bufferIndex", ArgumentSemantic.Assign)]
		nuint BufferIndex { get; set; }

		/// <summary>Gets or sets the Time value.</summary>
		[MacCatalyst (13, 1)]
		[Export ("time")]
		double Time { get; set; }

		/// <summary>Gets or sets a default value for the vertex data for the attribute.</summary>
		[Export ("initializationValue", ArgumentSemantic.Assign)]
		Vector4 InitializationValue {
			[MarshalDirective (NativePrefix = "xamarin_simd__", Library = "__Internal")]
			get;
			[MarshalDirective (NativePrefix = "xamarin_simd__", Library = "__Internal")]
			set;
		}
	}

	/// <summary>Provides convenient access to vertex data for a specific <see cref="ModelIO.MDLMesh" /> object.</summary>
	///     
	///     <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/ModelIO/Reference/MDLVertexAttributeData_Class/index.html">Apple documentation for <c>MDLVertexAttributeData</c></related>
	[MacCatalyst (13, 1)]
	[BaseType (typeof (NSObject))]
	[DisableDefaultCtor] // apple headers: created by MDLMesh's vertexAttributeData selector
	interface MDLVertexAttributeData {
		/// <summary>Gets or sets the Map value.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[Export ("map", ArgumentSemantic.Retain)]
		MDLMeshBufferMap Map { get; set; }

		/// <summary>Gets or sets the intra-vertex byte offset for the start of attribute data.</summary>
		[Export ("dataStart", ArgumentSemantic.Assign)]
		IntPtr DataStart { get; set; }

		/// <summary>Gets or sets the stride, in bytes, between vertex attributes.</summary>
		[Export ("stride", ArgumentSemantic.Assign)]
		nuint Stride { get; set; }

		/// <summary>Gets or sets the vertex attribute format.</summary>
		[Export ("format", ArgumentSemantic.Assign)]
		MDLVertexFormat Format { get; set; }

		/// <summary>Gets or sets the BufferSize value.</summary>
		[MacCatalyst (13, 1)]
		[Export ("bufferSize", ArgumentSemantic.Assign)]
		nuint BufferSize { get; set; }
	}

	/// <summary>Class that provides temporary access to mesh data in shared memory.</summary>
	///     
	///     <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/ModelIO/Reference/MDLMeshBufferMap_Class/index.html">Apple documentation for <c>MDLMeshBufferMap</c></related>
	[MacCatalyst (13, 1)]
	[BaseType (typeof (NSObject))]
	interface MDLMeshBufferMap {
		// FIXME: provide better API.
		/// <param name="bytes">The bytes.</param>
		/// <param name="deallocator">
		///           <para>A task representing the asynchronous operation.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		/// <summary>Creates a new mesh buffer map.</summary>
		[Export ("initWithBytes:deallocator:")]
		NativeHandle Constructor (IntPtr bytes, [NullAllowed] Action deallocator);

		/// <summary>Returns APointer to the mesh buffer data.</summary>
		[Export ("bytes")]
		IntPtr Bytes { get; }
	}

	/// <summary>Describes the format of vertices in a mesh buffer.</summary>
	///     
	///     <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/ModelIO/Reference/MDLVertexDescriptor_Class/index.html">Apple documentation for <c>MDLVertexDescriptor</c></related>
	[MacCatalyst (13, 1)]
	[BaseType (typeof (NSObject))]
	interface MDLVertexDescriptor : NSCopying {
		/// <param name="vertexDescriptor">The vertex descriptor.</param>
		/// <summary>Performs a deep copy of <paramref name="vertexDescriptor" />.</summary>
		[Export ("initWithVertexDescriptor:")]
		NativeHandle Constructor (MDLVertexDescriptor vertexDescriptor);

		/// <param name="name">The name.</param>
		///         <summary>Returns the attribute that is identified by <paramref name="name" />.</summary>
		///         <returns>The result of the operation.</returns>
		[Export ("attributeNamed:")]
		[return: NullAllowed]
		MDLVertexAttribute AttributeNamed (string name);

		/// <param name="attribute">The vertex attribute.</param>
		///         <summary>Adds <paramref name="attribute" /> to the descriptor, or updates it if it is already present.</summary>
		[Export ("addOrReplaceAttribute:")]
		void AddOrReplaceAttribute (MDLVertexAttribute attribute);

		/// <param name="name">The name.</param>
		///         <summary>Removes the attribute that has the specified name.</summary>
		[MacCatalyst (13, 1)]
		[Export ("removeAttributeNamed:")]
		void RemoveAttribute (string name);

		/// <summary>Gets or sets the list of attributes that are described by this descriptor.</summary>
		[Export ("attributes", ArgumentSemantic.Retain)]
		NSMutableArray<MDLVertexAttribute> Attributes { get; set; }

		/// <summary>Gets or sets the vertex buffer layouts that describe the corresponding attributes that are contained in the <see cref="ModelIO.MDLVertexDescriptor.Attributes" /> property.</summary>
		[Export ("layouts", ArgumentSemantic.Retain)]
		NSMutableArray<MDLVertexBufferLayout> Layouts { get; set; }

		/// <summary>Clears all data from this vertex descriptor do that it contains a single default attribute and single default vertex buffer layout.</summary>
		[Export ("reset")]
		void Reset ();

		/// <summary>Sets the per-vertex stride to produce the most compact vertex buffer for the current vertex offsets.</summary>
		[Export ("setPackedStrides")]
		void SetPackedStrides ();

		/// <summary>Sets vertex attribute offsets to produce the most compact vertices.</summary>
		[Export ("setPackedOffsets")]
		void SetPackedOffsets ();
	}

	/// <summary>Models a 3D object as a collection of volumetric elements, called voxels.</summary>
	///     
	///     <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/ModelIO/Reference/MDLVoxelArray_Class/index.html">Apple documentation for <c>MDLVoxelArray</c></related>
	[MacCatalyst (13, 1)]
	[BaseType (typeof (MDLObject))]
	[DisableDefaultCtor]
	interface MDLVoxelArray {

		/// <param name="asset">The asset.</param>
		/// <param name="divisions">The number of divisions.</param>
		/// <param name="interiorShells">The interior shells.</param>
		/// <param name="exteriorShells">The exterior shells.</param>
		/// <param name="patchRadius">The patch radius.</param>
		/// <summary>Developers should not use this deprecated constructor. Developers should use 'new MDLVoxelArray (MDLAsset, int, float)'.</summary>
		[Deprecated (PlatformName.MacOSX, 10, 12, message: "Use 'new MDLVoxelArray (MDLAsset, int, float)'.")]
		[NoiOS]
#if XAMCORE_5_0
		[NoTV]
#else
		[Obsoleted (PlatformName.TvOS, 10, 0, message: "Use 'new MDLVoxelArray (MDLAsset, int, float)'.")]
		[NoMacCatalyst]
#endif
		[Export ("initWithAsset:divisions:interiorShells:exteriorShells:patchRadius:")]
		NativeHandle Constructor (MDLAsset asset, int divisions, int interiorShells, int exteriorShells, float patchRadius);

		/// <param name="asset">The asset.</param>
		/// <param name="divisions">The number of divisions.</param>
		/// <param name="interiorNBWidth">The interior n b width.</param>
		/// <param name="exteriorNBWidth">The exterior n b width.</param>
		/// <param name="patchRadius">The patch radius.</param>
		/// <summary>Creates a new MDLVoxelArray from the provided asset, with the specified number of divisions and the specified numbers of concentric interior and exterior shells of voxels.</summary>
		[Deprecated (PlatformName.MacOSX, 10, 12, message: "Use 'new MDLVoxelArray (MDLAsset, int, float)'.")]
		[NoiOS]
#if XAMCORE_5_0
		[NoTV]
#else
		[Obsoleted (PlatformName.TvOS, 10, 0, message: "Use 'new MDLVoxelArray (MDLAsset, int, float)'.")]
		[NoMacCatalyst]
#endif
		[Export ("initWithAsset:divisions:interiorNBWidth:exteriorNBWidth:patchRadius:")]
		NativeHandle Constructor (MDLAsset asset, int divisions, float interiorNBWidth, float exteriorNBWidth, float patchRadius);

		/// <param name="asset">The asset.</param>
		/// <param name="divisions">The number of divisions.</param>
		/// <param name="patchRadius">The patch radius.</param>
		/// <summary>Creates a new instance with the specified parameters.</summary>
		[MacCatalyst (13, 1)]
		[Export ("initWithAsset:divisions:patchRadius:")]
		NativeHandle Constructor (MDLAsset asset, int divisions, float patchRadius);

		/// <param name="voxelData">The voxel data.</param>
		/// <param name="boundingBox">The bounding box.</param>
		/// <param name="voxelExtent">The voxel extent.</param>
		/// <summary>Creates a new MDLVoxelArray from the provided voxel data, bounding box, and voxel extent.</summary>
		[Export ("initWithData:boundingBox:voxelExtent:")]
		[MarshalDirective (NativePrefix = "xamarin_simd__", Library = "__Internal")]
		NativeHandle Constructor (NSData voxelData, MDLAxisAlignedBoundingBox boundingBox, float voxelExtent);

		/// <param name="allocator">
		///           <para>A task representing the asynchronous operation.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		///         <summary>Returns a mesh that encloses the voxels in the array.</summary>
		///         <returns>The result of the operation.</returns>
		[Export ("meshUsingAllocator:")]
		[return: NullAllowed]
		MDLMesh CreateMesh ([NullAllowed] IMDLMeshBufferAllocator allocator);

		[Export ("voxelExistsAtIndex:allowAnyX:allowAnyY:allowAnyZ:allowAnyShell:")]
		[MarshalDirective (NativePrefix = "xamarin_simd__", Library = "__Internal")]
		bool VoxelExists (Vector4i atIndex, bool allowAnyX, bool allowAnyY, bool allowAnyZ, bool allowAnyShell);

		[Export ("setVoxelAtIndex:")]
		[MarshalDirective (NativePrefix = "xamarin_simd__", Library = "__Internal")]
		void SetVoxel (Vector4i index);

		/// <param name="mesh">The mesh.</param>
		///         <param name="divisions">The number of divisions.</param>
		///         <param name="patchRadius">The patch radius.</param>
		///         <summary>Performs the set voxels operation.</summary>
		[MacCatalyst (13, 1)]
		[Export ("setVoxelsForMesh:divisions:patchRadius:")]
		void SetVoxels (MDLMesh mesh, int divisions, float patchRadius);

		/// <param name="mesh">The mesh.</param>
		///         <param name="divisions">The number of divisions.</param>
		///         <param name="interiorShells">The interior shells.</param>
		///         <param name="exteriorShells">The exterior shells.</param>
		///         <param name="patchRadius">The patch radius.</param>
		///         <summary>Sets the voxels for the mesh with the specified parameters.</summary>
		[Deprecated (PlatformName.MacOSX, 10, 12, message: "Use 'SetVoxels (MDLMesh, int, float)' instead.")]
		[NoiOS]
#if XAMCORE_5_0
		[NoTV]
#else
		[Obsoleted (PlatformName.TvOS, 10, 0, message: "Use 'SetVoxels (MDLMesh, int, float)' instead.")]
		[NoMacCatalyst]
#endif
		[Export ("setVoxelsForMesh:divisions:interiorShells:exteriorShells:patchRadius:")]
		void SetVoxels (MDLMesh mesh, int divisions, int interiorShells, int exteriorShells, float patchRadius);

		/// <param name="mesh">The mesh.</param>
		///         <param name="divisions">The number of divisions.</param>
		///         <param name="interiorNBWidth">The interior n b width.</param>
		///         <param name="exteriorNBWidth">The exterior n b width.</param>
		///         <param name="patchRadius">The patch radius.</param>
		///         <summary>Sets the voxels for the mesh with the specified parameters.</summary>
		[Deprecated (PlatformName.MacOSX, 10, 12, message: "Use 'SetVoxels (MDLMesh, int, float)' instead.")]
		[NoiOS]
#if XAMCORE_5_0
		[NoTV]
#else
		[Obsoleted (PlatformName.TvOS, 10, 0, message: "Use 'SetVoxels (MDLMesh, int, float)' instead.")]
		[NoMacCatalyst]
#endif
		[Export ("setVoxelsForMesh:divisions:interiorNBWidth:exteriorNBWidth:patchRadius:")]
		void SetVoxels (MDLMesh mesh, int divisions, float interiorNBWidth, float exteriorNBWidth, float patchRadius);

		/// <param name="withinExtent">The within extent.</param>
		///         <summary>Performs the get voxels operation.</summary>
		///         <returns>The result of the operation.</returns>
		[MarshalDirective (NativePrefix = "xamarin_simd__", Library = "__Internal")]
		[Export ("voxelsWithinExtent:")]
		[return: NullAllowed]
		NSData GetVoxels (MDLVoxelIndexExtent withinExtent);

		/// <summary>Returns a list of all the voxel indices as an array of 4-component integer arrays.</summary>
		///         <returns>The result of the operation.</returns>
		[Export ("voxelIndices")]
		[return: NullAllowed]
		NSData GetVoxelIndices ();

		/// <param name="voxels">The voxels.</param>
		///         <summary>Performs the union with operation.</summary>
		[Export ("unionWithVoxels:")]
		void UnionWith (MDLVoxelArray voxels);

		/// <param name="voxels">The voxels.</param>
		///         <summary>Performs the difference with operation.</summary>
		[Export ("differenceWithVoxels:")]
		void DifferenceWith (MDLVoxelArray voxels);

		/// <param name="voxels">The voxels.</param>
		///         <summary>Performs the intersect with operation.</summary>
		[Export ("intersectWithVoxels:")]
		void IntersectWith (MDLVoxelArray voxels);

		[Export ("indexOfSpatialLocation:")]
		[MarshalDirective (NativePrefix = "xamarin_simd__", Library = "__Internal")]
		Vector4i GetIndex (Vector3 spatiallocation);

		[Export ("spatialLocationOfIndex:")]
		[MarshalDirective (NativePrefix = "xamarin_simd__", Library = "__Internal")]
		Vector3 GetSpatialLocation (Vector4i index);

		[Export ("voxelBoundingBoxAtIndex:")]
		[MarshalDirective (NativePrefix = "xamarin_simd__", Library = "__Internal")]
		MDLAxisAlignedBoundingBox GetVoxelBoundingBox (Vector4i index);

		/// <summary>Gets the number of voxels in the array.</summary>
		[Export ("count")]
		nuint Count { get; }

		/// <summary>Gets the allowable ranges for the four components of a voxel index.</summary>
		[Export ("voxelIndexExtent")]
		MDLVoxelIndexExtent VoxelIndexExtent {
			[MarshalDirective (NativePrefix = "xamarin_simd__", Library = "__Internal")]
			get;
		}

		/// <summary>Gets the smallest box that contains all the voxels.</summary>
		[Export ("boundingBox")]
		MDLAxisAlignedBoundingBox BoundingBox {
			[MarshalDirective (NativePrefix = "xamarin_simd__", Library = "__Internal")]
			get;
		}

		/// <summary>Performs the convert to signed shell field operation.</summary>
		[MacCatalyst (13, 1)]
		[Export ("convertToSignedShellField")]
		void ConvertToSignedShellField ();

		/// <summary>Gets the IsValidSignedShellField value.</summary>
		[MacCatalyst (13, 1)]
		[Export ("isValidSignedShellField")]
		bool IsValidSignedShellField { get; }

		/// <summary>Gets or sets the ShellFieldInteriorThickness value.</summary>
		[MacCatalyst (13, 1)]
		[Export ("shellFieldInteriorThickness")]
		float ShellFieldInteriorThickness { get; set; }

		/// <summary>Gets or sets the ShellFieldExteriorThickness value.</summary>
		[MacCatalyst (13, 1)]
		[Export ("shellFieldExteriorThickness")]
		float ShellFieldExteriorThickness { get; set; }

		/// <summary>Performs the get coarse mesh operation.</summary>
		///         <returns>The result of the operation.</returns>
		[MacCatalyst (13, 1)]
		[Export ("coarseMesh")]
		[return: NullAllowed]
		MDLMesh GetCoarseMesh ();

		/// <param name="allocator">
		///           <para>A task representing the asynchronous operation.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		///         <summary>Performs the get coarse mesh using allocator operation.</summary>
		///         <returns>The result of the operation.</returns>
		[MacCatalyst (13, 1)]
		[Export ("coarseMeshUsingAllocator:")]
		[return: NullAllowed]
		MDLMesh GetCoarseMeshUsingAllocator ([NullAllowed] IMDLMeshBufferAllocator allocator);
	}

	/// <summary>Contains valid vertex attribute names.</summary>
	[Static]
	[MacCatalyst (13, 1)]
	interface MDLVertexAttributes {
		/// <summary>The vertex attribute data describe the degree to which the surface changes appearance with rotation.</summary>
		[Field ("MDLVertexAttributeAnisotropy")]
		NSString Anisotropy { get; }

		/// <summary>The vertex attribute data describe binormal vector data.</summary>
		[Field ("MDLVertexAttributeBinormal")]
		NSString Binormal { get; }

		/// <summary>The vertex attribute data describe bitangent vector data.</summary>
		[Field ("MDLVertexAttributeBitangent")]
		NSString Bitangent { get; }

		/// <summary>The vertex attribute data describe color data.</summary>
		[Field ("MDLVertexAttributeColor")]
		NSString Color { get; }

		/// <summary>The vertex attribute data describe edges that should not be modified during subdivision.</summary>
		[Field ("MDLVertexAttributeEdgeCrease")]
		NSString EdgeCrease { get; }

		/// <summary>The vertex attribute data describe joint index data.</summary>
		[Field ("MDLVertexAttributeJointIndices")]
		NSString JointIndices { get; }

		/// <summary>The vertex attribute data describe joint weight data.</summary>
		[Field ("MDLVertexAttributeJointWeights")]
		NSString JointWeights { get; }

		/// <summary>The vertex attribute data describe a normal vector.</summary>
		[Field ("MDLVertexAttributeNormal")]
		NSString Normal { get; }

		/// <summary>The vertex attribute data describe ambient occlusion data.</summary>
		[Field ("MDLVertexAttributeOcclusionValue")]
		NSString OcclusionValue { get; }

		/// <summary>The vertex attribute data describe position data.</summary>
		[Field ("MDLVertexAttributePosition")]
		NSString Position { get; }

		/// <summary>The vertex attribute data describe the U component of a shading basis.</summary>
		[Field ("MDLVertexAttributeShadingBasisU")]
		NSString ShadingBasisU { get; }

		/// <summary>The vertex attribute data describe the V component of a shading basis.</summary>
		[Field ("MDLVertexAttributeShadingBasisV")]
		NSString ShadingBasisV { get; }

		/// <summary>The vertex attribute data describe data that control which neighboring vertices control subdivision.</summary>
		[Field ("MDLVertexAttributeSubdivisionStencil")]
		NSString SubdivisionStencil { get; }

		/// <summary>The vertex attribute data describe tangent vectors.</summary>
		[Field ("MDLVertexAttributeTangent")]
		NSString Tangent { get; }

		/// <summary>The vertex attribute data describe texture coordinates.</summary>
		[Field ("MDLVertexAttributeTextureCoordinate")]
		NSString TextureCoordinate { get; }
	}

	/// <summary>Describes the layout of vertices in a mesh buffer object.</summary>
	///     
	///     <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/ModelIO/Reference/MDLVertexBufferLayout_Class/index.html">Apple documentation for <c>MDLVertexBufferLayout</c></related>
	[MacCatalyst (13, 1)]
	[BaseType (typeof (NSObject))]
	interface MDLVertexBufferLayout : NSCopying {
		/// <param name="stride">The stride.</param>
		/// <summary>Creates a new vertex buffer layout with the specified <paramref name="stride" />.</summary>
		[MacCatalyst (13, 1)]
		[Export ("initWithStride:")]
		NativeHandle Constructor (nuint stride);

		/// <summary>Gets or sets the stride of the data.</summary>
		[Export ("stride", ArgumentSemantic.Assign)]
		nuint Stride { get; set; }
	}

	/// <summary>Describes the topology of the vertices that are indexed by a submesh's index buffers.</summary>
	///     
	///     <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/ModelIO/Reference/MDLSubmeshTopology_Class/index.html">Apple documentation for <c>MDLSubmeshTopology</c></related>
	[MacCatalyst (13, 1)]
	[BaseType (typeof (NSObject))]
	interface MDLSubmeshTopology {
		/// <param name="submesh">The submesh.</param>
		/// <summary>Creates a new instance with the specified parameters.</summary>
		[MacCatalyst (13, 1)]
		[Export ("initWithSubmesh:")]
		NativeHandle Constructor (MDLSubmesh submesh);

		/// <summary>Gets or sets a mesh buffer that contains the number of faces for each corresponding face in the mesh's index buffer.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[NullAllowed, Export ("faceTopology", ArgumentSemantic.Retain)]
		IMDLMeshBuffer FaceTopology { get; set; }

		/// <summary>Gets or sets the number of faces in the submesh.</summary>
		[Export ("faceCount", ArgumentSemantic.Assign)]
		nuint FaceCount { get; set; }

		/// <summary>Gets or sets the indices of vertices that are to be treated as creases.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[NullAllowed, Export ("vertexCreaseIndices", ArgumentSemantic.Retain)]
		IMDLMeshBuffer VertexCreaseIndices { get; set; }

		/// <summary>Gets or sets the sparse mesh buffer that contains vertex smoothness data that are indexed by <see cref="ModelIO.MDLSubmeshTopology.VertexCreaseIndices" /> property</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[NullAllowed, Export ("vertexCreases", ArgumentSemantic.Retain)]
		IMDLMeshBuffer VertexCreases { get; set; }

		/// <summary>Gets or sets the number of values in the <see cref="ModelIO.MDLSubmeshTopology.VertexCreaseIndices" /> property.</summary>
		[Export ("vertexCreaseCount", ArgumentSemantic.Assign)]
		nuint VertexCreaseCount { get; set; }

		/// <summary>Gets or sets the mesh buffer that contains the indices to the vertices that define the edges that crease during subdivision.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[NullAllowed, Export ("edgeCreaseIndices", ArgumentSemantic.Retain)]
		IMDLMeshBuffer EdgeCreaseIndices { get; set; }

		/// <summary>Gets or sets the mesh buffer that contains edge smoothness data that correlates with the vertex pairs that are contained in <see cref="ModelIO.MDLSubmeshTopology.EdgeCreaseIndices" /> property.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[NullAllowed, Export ("edgeCreases", ArgumentSemantic.Retain)]
		IMDLMeshBuffer EdgeCreases { get; set; }

		/// <summary>Gets the number of creases that are contained in the edge crease buffers.</summary>
		[Export ("edgeCreaseCount", ArgumentSemantic.Assign)]
		nuint EdgeCreaseCount { get; set; }

		/// <summary>Gets or sets a mesh buffer that contains indices into the submesh's mesh buffer, thus indicating which faces are to be treated as holes when rendering.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[NullAllowed, Export ("holes", ArgumentSemantic.Retain)]
		IMDLMeshBuffer Holes { get; set; }

		/// <summary>Gets or sets the number of holes in the hole buffer.</summary>
		[Export ("holeCount", ArgumentSemantic.Assign)]
		nuint HoleCount { get; set; }
	}

	[MacCatalyst (13, 1)]
	[BaseType (typeof (NSObject))]
	interface MDLAnimatedValue : NSCopying {

		/// <summary>Gets the IsAnimated value.</summary>
		[Export ("isAnimated")]
		bool IsAnimated { get; }

		/// <summary>Gets the Precision value.</summary>
		[Export ("precision")]
		MDLDataPrecision Precision { get; }

		/// <summary>Gets the TimeSampleCount value.</summary>
		[Export ("timeSampleCount")]
		nuint TimeSampleCount { get; }

		/// <summary>Gets the MinimumTime value.</summary>
		[Export ("minimumTime")]
		double MinimumTime { get; }

		/// <summary>Gets the MaximumTime value.</summary>
		[Export ("maximumTime")]
		double MaximumTime { get; }

		/// <summary>Gets or sets the Interpolation value.</summary>
		[Export ("interpolation", ArgumentSemantic.Assign)]
		MDLAnimatedValueInterpolation Interpolation { get; set; }

		/// <summary>Gets the WeakKeyTimes value.</summary>
		[Protected]
		[Export ("keyTimes")]
		NSNumber [] WeakKeyTimes { get; }

		/// <summary>Performs the clear operation.</summary>
		[Export ("clear")]
		void Clear ();

		[Internal]
		[Export ("getTimes:maxCount:")]
		nuint _GetTimes (IntPtr timesArray, nuint maxCount);
	}

	[MacCatalyst (13, 1)]
	[BaseType (typeof (MDLAnimatedValue))]
	interface MDLAnimatedScalarArray {

		/// <summary>Gets the ElementCount value.</summary>
		[Export ("elementCount")]
		nuint ElementCount { get; }

		[Export ("initWithElementCount:")]
		NativeHandle Constructor (nuint arrayElementCount);

		[Internal]
		[Export ("setFloatArray:count:atTime:")]
		void _SetFloatArray (IntPtr array, nuint count, double time);

		[Internal]
		[Export ("setDoubleArray:count:atTime:")]
		void _SetDoubleArray (IntPtr array, nuint count, double time);

		[Internal]
		[Export ("getFloatArray:maxCount:atTime:")]
		nuint _GetFloatArray (IntPtr array, nuint maxCount, double time);

		[Internal]
		[Export ("getDoubleArray:maxCount:atTime:")]
		nuint _GetDoubleArray (IntPtr array, nuint maxCount, double time);

		[Internal]
		[Export ("resetWithFloatArray:count:atTimes:count:")]
		void _ResetWithFloatArray (IntPtr valuesArray, nuint valuesCount, IntPtr timesArray, nuint timesCount);

		[Internal]
		[Export ("resetWithDoubleArray:count:atTimes:count:")]
		void _ResetWithDoubleArray (IntPtr valuesArray, nuint valuesCount, IntPtr timesArray, nuint timesCount);

		[Internal]
		[Export ("getFloatArray:maxCount:")]
		nuint _GetFloatArray (IntPtr valuesArray, nuint maxCount);

		[Internal]
		[Export ("getDoubleArray:maxCount:")]
		nuint _GetDoubleArray (IntPtr valuesArray, nuint maxCount);
	}

	[MacCatalyst (13, 1)]
	[BaseType (typeof (MDLAnimatedValue))]
	interface MDLAnimatedVector3Array {

		/// <summary>Gets the ElementCount value.</summary>
		[Export ("elementCount")]
		nuint ElementCount { get; }

		[Export ("initWithElementCount:")]
		NativeHandle Constructor (nuint arrayElementCount);

		[Internal]
		[Export ("setFloat3Array:count:atTime:")]
		void _SetFloat3Array (IntPtr array, nuint count, double time);

		[Internal]
		[Export ("setDouble3Array:count:atTime:")]
		void _SetDouble3Array (IntPtr array, nuint count, double time);

		[Internal]
		[Export ("getFloat3Array:maxCount:atTime:")]
		nuint _GetFloat3Array (IntPtr array, nuint maxCount, double time);

		[Internal]
		[Export ("getDouble3Array:maxCount:atTime:")]
		nuint _GetDouble3Array (IntPtr array, nuint maxCount, double time);

		[Internal]
		[Export ("resetWithFloat3Array:count:atTimes:count:")]
		void _ResetWithFloat3Array (IntPtr valuesArray, nuint valuesCount, IntPtr timesArray, nuint timesCount);

		[Internal]
		[Export ("resetWithDouble3Array:count:atTimes:count:")]
		void _ResetWithDouble3Array (IntPtr valuesArray, nuint valuesCount, IntPtr timesArray, nuint timesCount);

		[Internal]
		[Export ("getFloat3Array:maxCount:")]
		nuint _GetFloat3Array (IntPtr valuesArray, nuint maxCount);

		[Internal]
		[Export ("getDouble3Array:maxCount:")]
		nuint _GetDouble3Array (IntPtr valuesArray, nuint maxCount);
	}

	[MacCatalyst (13, 1)]
	[BaseType (typeof (MDLAnimatedValue))]
	interface MDLAnimatedQuaternionArray {

		/// <summary>Gets the ElementCount value.</summary>
		[Export ("elementCount")]
		nuint ElementCount { get; }

		[Export ("initWithElementCount:")]
		NativeHandle Constructor (nuint arrayElementCount);

		[Internal]
		[Export ("setFloatQuaternionArray:count:atTime:")]
		void _SetFloatQuaternionArray (IntPtr array, nuint count, double time);

		[Internal]
		[Export ("setDoubleQuaternionArray:count:atTime:")]
		void _SetDoubleQuaternionArray (IntPtr array, nuint count, double time);

		[Internal]
		[Export ("getFloatQuaternionArray:maxCount:atTime:")]
		nuint _GetFloatQuaternionArray (IntPtr array, nuint maxCount, double time);

		[Internal]
		[Export ("getDoubleQuaternionArray:maxCount:atTime:")]
		nuint _GetDoubleQuaternionArray (IntPtr array, nuint maxCount, double time);

		[Internal]
		[Export ("resetWithFloatQuaternionArray:count:atTimes:count:")]
		void _ResetWithFloatQuaternionArray (IntPtr valuesArray, nuint valuesCount, IntPtr timesArray, nuint timesCount);

		[Internal]
		[Export ("resetWithDoubleQuaternionArray:count:atTimes:count:")]
		void _ResetWithDoubleQuaternionArray (IntPtr valuesArray, nuint valuesCount, IntPtr timesArray, nuint timesCount);

		[Internal]
		[Export ("getFloatQuaternionArray:maxCount:")]
		nuint _GetFloatQuaternionArray (IntPtr valuesArray, nuint maxCount);

		[Internal]
		[Export ("getDoubleQuaternionArray:maxCount:")]
		nuint _GetDoubleQuaternionArray (IntPtr valuesArray, nuint maxCount);
	}

	[MacCatalyst (13, 1)]
	[BaseType (typeof (MDLAnimatedValue))]
	interface MDLAnimatedScalar {

		/// <param name="value">The value.</param>
		///         <param name="time">The time.</param>
		///         <summary>Performs the set value operation.</summary>
		[Export ("setFloat:atTime:")]
		void SetValue (float value, double time);

		/// <param name="value">The value.</param>
		///         <param name="time">The time.</param>
		///         <summary>Performs the set value operation.</summary>
		[Export ("setDouble:atTime:")]
		void SetValue (double value, double time);

		/// <param name="time">The time.</param>
		///         <summary>Performs the get float operation.</summary>
		///         <returns>The result of the operation.</returns>
		[Export ("floatAtTime:")]
		float GetFloat (double time);

		/// <param name="time">The time.</param>
		///         <summary>Performs the get double operation.</summary>
		///         <returns>The result of the operation.</returns>
		[Export ("doubleAtTime:")]
		double GetDouble (double time);

		[Internal]
		[Export ("resetWithFloatArray:atTimes:count:")]
		void _ResetWithFloatArray (IntPtr valuesArray, IntPtr timesArray, nuint count);

		[Internal]
		[Export ("resetWithDoubleArray:atTimes:count:")]
		void _ResetWithDoubleArray (IntPtr valuesArray, IntPtr timesArray, nuint count);

		[Internal]
		[Export ("getFloatArray:maxCount:")]
		nuint _GetFloatArray (IntPtr valuesArray, nuint maxCount);

		[Internal]
		[Export ("getDoubleArray:maxCount:")]
		nuint _GetDoubleArray (IntPtr valuesArray, nuint maxCount);
	}

	[MacCatalyst (13, 1)]
	[BaseType (typeof (MDLAnimatedValue))]
	interface MDLAnimatedVector2 {

		[Export ("setFloat2:atTime:")]
		[MarshalDirective (NativePrefix = "xamarin_simd__", Library = "__Internal")]
		void SetValue (Vector2 value, double time);

		[Export ("setDouble2:atTime:")]
		[MarshalDirective (NativePrefix = "xamarin_simd__", Library = "__Internal")]
		void SetValue (Vector2d value, double time);

		/// <param name="time">The time.</param>
		///         <summary>Performs the get vector2 value operation.</summary>
		///         <returns>The result of the operation.</returns>
		[Export ("float2AtTime:")]
		[MarshalDirective (NativePrefix = "xamarin_simd__", Library = "__Internal")]
		Vector2 GetVector2Value (double time);

		/// <param name="time">The time.</param>
		///         <summary>Performs the get vector2d value operation.</summary>
		///         <returns>The result of the operation.</returns>
		[Export ("double2AtTime:")]
		[MarshalDirective (NativePrefix = "xamarin_simd__", Library = "__Internal")]
		Vector2d GetVector2dValue (double time);

		[Internal]
		[Export ("resetWithFloat2Array:atTimes:count:")]
		void _ResetWithFloat2Array (IntPtr valuesArray, IntPtr timesArray, nuint count);

		[Internal]
		[Export ("resetWithDouble2Array:atTimes:count:")]
		void _ResetWithDouble2Array (IntPtr valuesArray, IntPtr timesArray, nuint count);

		[Internal]
		[Export ("getFloat2Array:maxCount:")]
		nuint _GetFloat2Array (IntPtr valuesArray, nuint maxCount);

		[Internal]
		[Export ("getDouble2Array:maxCount:")]
		nuint _GetDouble2Array (IntPtr valuesArray, nuint maxCount);
	}

	[MacCatalyst (13, 1)]
	[BaseType (typeof (MDLAnimatedValue))]
	interface MDLAnimatedVector3 {

		[Export ("setFloat3:atTime:")]
		[MarshalDirective (NativePrefix = "xamarin_simd__", Library = "__Internal")]
		void SetValue (NVector3 value, double time);

		[Export ("setDouble3:atTime:")]
		[MarshalDirective (NativePrefix = "xamarin_simd__", Library = "__Internal")]
		void SetValue (NVector3d value, double time);

		/// <param name="time">The time.</param>
		///         <summary>Performs the get n vector3 value operation.</summary>
		///         <returns>The result of the operation.</returns>
		[Export ("float3AtTime:")]
		[MarshalDirective (NativePrefix = "xamarin_simd__", Library = "__Internal")]
		NVector3 GetNVector3Value (double time);

		/// <param name="time">The time.</param>
		///         <summary>Performs the get n vector3d value operation.</summary>
		///         <returns>The result of the operation.</returns>
		[Export ("double3AtTime:")]
		[MarshalDirective (NativePrefix = "xamarin_simd__", Library = "__Internal")]
		NVector3d GetNVector3dValue (double time);

		[Internal]
		[Export ("resetWithFloat3Array:atTimes:count:")]
		void _ResetWithFloat3Array (IntPtr valuesArray, IntPtr timesArray, nuint count);

		[Internal]
		[Export ("resetWithDouble3Array:atTimes:count:")]
		void _ResetWithDouble3Array (IntPtr valuesArray, IntPtr timesArray, nuint count);

		[Internal]
		[Export ("getFloat3Array:maxCount:")]
		nuint _GetFloat3Array (IntPtr valuesArray, nuint maxCount);

		[Internal]
		[Export ("getDouble3Array:maxCount:")]
		nuint _GetDouble3Array (IntPtr valuesArray, nuint maxCount);
	}

	[MacCatalyst (13, 1)]
	[BaseType (typeof (MDLAnimatedValue))]
	interface MDLAnimatedVector4 {

		[Export ("setFloat4:atTime:")]
		[MarshalDirective (NativePrefix = "xamarin_simd__", Library = "__Internal")]
		void SetValue (Vector4 value, double time);

		[Export ("setDouble4:atTime:")]
		[MarshalDirective (NativePrefix = "xamarin_simd__", Library = "__Internal")]
		void SetValue (Vector4d value, double time);

		/// <param name="time">The time.</param>
		///         <summary>Performs the get vector4 value operation.</summary>
		///         <returns>The result of the operation.</returns>
		[Export ("float4AtTime:")]
		[MarshalDirective (NativePrefix = "xamarin_simd__", Library = "__Internal")]
		Vector4 GetVector4Value (double time);

		/// <param name="time">The time.</param>
		///         <summary>Performs the get vector4d value operation.</summary>
		///         <returns>The result of the operation.</returns>
		[Export ("double4AtTime:")]
		[MarshalDirective (NativePrefix = "xamarin_simd__", Library = "__Internal")]
		Vector4d GetVector4dValue (double time);

		[Internal]
		[Export ("resetWithFloat4Array:atTimes:count:")]
		void _ResetWithFloat4Array (IntPtr valuesArray, IntPtr timesArray, nuint count);

		[Internal]
		[Export ("resetWithDouble4Array:atTimes:count:")]
		void _ResetWithDouble4Array (IntPtr valuesArray, IntPtr timesArray, nuint count);

		[Internal]
		[Export ("getFloat4Array:maxCount:")]
		nuint _GetFloat4Array (IntPtr valuesArray, nuint maxCount);

		[Internal]
		[Export ("getDouble4Array:maxCount:")]
		nuint _GetDouble4Array (IntPtr valuesArray, nuint maxCount);
	}

	[MacCatalyst (13, 1)]
	[BaseType (typeof (MDLAnimatedValue))]
	interface MDLAnimatedMatrix4x4 {

		[Export ("setFloat4x4:atTime:")]
		[MarshalDirective (NativePrefix = "xamarin_simd__", Library = "__Internal")]
		void SetValue (NMatrix4 value, double time);

		[Export ("setDouble4x4:atTime:")]
		[MarshalDirective (NativePrefix = "xamarin_simd__", Library = "__Internal")]
		void SetValue (NMatrix4d value, double time);

		/// <param name="time">The time.</param>
		///         <summary>Performs the get n matrix4 value operation.</summary>
		///         <returns>The result of the operation.</returns>
		[Export ("float4x4AtTime:")]
		[MarshalDirective (NativePrefix = "xamarin_simd__", Library = "__Internal")]
		NMatrix4 GetNMatrix4Value (double time);

		/// <param name="time">The time.</param>
		///         <summary>Performs the get n matrix4d value operation.</summary>
		///         <returns>The result of the operation.</returns>
		[Export ("double4x4AtTime:")]
		[MarshalDirective (NativePrefix = "xamarin_simd__", Library = "__Internal")]
		NMatrix4d GetNMatrix4dValue (double time);

		[Internal]
		[Export ("resetWithFloat4x4Array:atTimes:count:")]
		void _ResetWithFloat4x4Array (IntPtr valuesArray, IntPtr timesArray, nuint count);

		[Internal]
		[Export ("resetWithDouble4x4Array:atTimes:count:")]
		void _ResetWithDouble4x4Array (IntPtr valuesArray, IntPtr timesArray, nuint count);

		[Internal]
		[Export ("getFloat4x4Array:maxCount:")]
		nuint _GetFloat4x4Array (IntPtr valuesArray, nuint maxCount);

		[Internal]
		[Export ("getDouble4x4Array:maxCount:")]
		nuint _GetDouble4x4Array (IntPtr valuesArray, nuint maxCount);
	}

	[MacCatalyst (13, 1)]
	[BaseType (typeof (MDLObject))]
	[DisableDefaultCtor]
	interface MDLSkeleton : NSCopying {

		/// <summary>Gets the JointPaths value.</summary>
		[Export ("jointPaths")]
		string [] JointPaths { get; }

		/// <summary>Gets the JointBindTransforms value.</summary>
		[Export ("jointBindTransforms")]
		MDLMatrix4x4Array JointBindTransforms { get; }

		/// <summary>Gets the JointRestTransforms value.</summary>
		[MacCatalyst (13, 1)]
		[Export ("jointRestTransforms")]
		MDLMatrix4x4Array JointRestTransforms { get; }

		/// <param name="name">The name.</param>
		/// <param name="jointPaths">The joint paths.</param>
		/// <summary>Creates a new instance with the specified parameters.</summary>
		[Export ("initWithName:jointPaths:")]
		NativeHandle Constructor (string name, string [] jointPaths);
	}

	interface IMDLJointAnimation { }

	[MacCatalyst (13, 1)]
	[Protocol]
	interface MDLJointAnimation {
	}

	[MacCatalyst (13, 1)]
	[BaseType (typeof (MDLObject))]
	[DisableDefaultCtor]
	interface MDLPackedJointAnimation : NSCopying, MDLJointAnimation {

		/// <summary>Gets the JointPaths value.</summary>
		[Export ("jointPaths")]
		string [] JointPaths { get; }

		/// <summary>Gets the Translations value.</summary>
		[Export ("translations")]
		MDLAnimatedVector3Array Translations { get; }

		/// <summary>Gets the Rotations value.</summary>
		[Export ("rotations")]
		MDLAnimatedQuaternionArray Rotations { get; }

		/// <summary>Gets the Scales value.</summary>
		[Export ("scales")]
		MDLAnimatedVector3Array Scales { get; }

		/// <param name="name">The name.</param>
		/// <param name="jointPaths">The joint paths.</param>
		/// <summary>Creates a new instance with the specified parameters.</summary>
		[Export ("initWithName:jointPaths:")]
		NativeHandle Constructor (string name, string [] jointPaths);
	}

	[MacCatalyst (13, 1)]
	[BaseType (typeof (NSObject))]
	interface MDLAnimationBindComponent : NSCopying, MDLComponent {

		/// <summary>Gets or sets the Skeleton value.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[NullAllowed, Export ("skeleton", ArgumentSemantic.Retain)]
		MDLSkeleton Skeleton { get; set; }

		/// <summary>Gets or sets the JointAnimation value.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[NullAllowed, Export ("jointAnimation", ArgumentSemantic.Retain)]
		IMDLJointAnimation JointAnimation { get; set; }

		/// <summary>Gets or sets the JointPaths value.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[NullAllowed, Export ("jointPaths", ArgumentSemantic.Retain)]
		string [] JointPaths { get; set; }

		/// <summary>Performs the geometry bind transform operation.</summary>
		[Export ("geometryBindTransform", ArgumentSemantic.Assign)]
		NMatrix4d GeometryBindTransform {
			[MarshalDirective (NativePrefix = "xamarin_simd__", Library = "__Internal")]
			get;
			[MarshalDirective (NativePrefix = "xamarin_simd__", Library = "__Internal")]
			set;
		}
	}

	interface IMDLAssetResolver { }

	[MacCatalyst (13, 1)]
	[Protocol]
	interface MDLAssetResolver {

		/// <param name="name">The name.</param>
		/// <summary>Performs the can resolve asset operation.</summary>
		/// <returns>The result of the operation.</returns>
		[Abstract]
		[Export ("canResolveAssetNamed:")]
		bool CanResolveAsset (string name);

		/// <param name="name">The name.</param>
		/// <summary>Performs the resolve asset operation.</summary>
		/// <returns>The result of the operation.</returns>
		[Abstract]
		[Export ("resolveAssetNamed:")]
		NSUrl ResolveAsset (string name);
	}

	[MacCatalyst (13, 1)]
	[BaseType (typeof (NSObject))]
	[DisableDefaultCtor]
	interface MDLRelativeAssetResolver : MDLAssetResolver {

		/// <param name="asset">The asset.</param>
		/// <summary>Creates a new instance with the specified parameters.</summary>
		[Export ("initWithAsset:")]
		NativeHandle Constructor (MDLAsset asset);

		/// <summary>Gets or sets the Asset value.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[NullAllowed, Export ("asset", ArgumentSemantic.Weak)]
		MDLAsset Asset { get; set; }
	}

	[MacCatalyst (13, 1)]
	[BaseType (typeof (NSObject))]
	[DisableDefaultCtor]
	interface MDLPathAssetResolver : MDLAssetResolver {

		/// <param name="path">The path.</param>
		/// <summary>Creates a new instance with the specified parameters.</summary>
		[Export ("initWithPath:")]
		NativeHandle Constructor (string path);

		/// <summary>Gets or sets the Path value.</summary>
		[Export ("path")]
		string Path { get; set; }
	}

	[MacCatalyst (13, 1)]
	[BaseType (typeof (NSObject))]
	[DisableDefaultCtor]
	interface MDLBundleAssetResolver : MDLAssetResolver {

		/// <param name="path">The path.</param>
		/// <summary>Creates a new instance with the specified parameters.</summary>
		[Export ("initWithBundle:")]
		NativeHandle Constructor (string path);

		/// <summary>Gets or sets the Path value.</summary>
		[Export ("path")]
		string Path { get; set; }
	}

	interface IMDLTransformOp { }

	[MacCatalyst (13, 1)]
	[Protocol]
	interface MDLTransformOp {

		/// <summary>Gets the Name value.</summary>
		[Abstract]
		[Export ("name")]
		string Name { get; }

		/// <param name="atTime">The time.</param>
		/// <summary>Performs the get n matrix4 operation.</summary>
		/// <returns>The result of the operation.</returns>
		[Abstract]
		[Export ("float4x4AtTime:")]
		[MarshalDirective (NativePrefix = "xamarin_simd__", Library = "__Internal")]
		NMatrix4 GetNMatrix4 (double atTime);

		/// <param name="atTime">The time.</param>
		/// <summary>Performs the get n matrix4d operation.</summary>
		/// <returns>The result of the operation.</returns>
		[Abstract]
		[Export ("double4x4AtTime:")]
		[MarshalDirective (NativePrefix = "xamarin_simd__", Library = "__Internal")]
		NMatrix4d GetNMatrix4d (double atTime);

		/// <summary>Gets the IsInverseOp value.</summary>
		[Abstract]
		[Export ("IsInverseOp")]
		bool IsInverseOp { get; }
	}

	[MacCatalyst (13, 1)]
	[BaseType (typeof (NSObject))]
	interface MDLTransformRotateXOp : MDLTransformOp {

		// From MDLTransformOp Protocol
		//[Export ("name")]
		//string Name { get; }

		/// <summary>Gets the AnimatedValue value.</summary>
		[Export ("animatedValue")]
		MDLAnimatedScalar AnimatedValue { get; }
	}

	[MacCatalyst (13, 1)]
	[BaseType (typeof (NSObject))]
	interface MDLTransformRotateYOp : MDLTransformOp {

		// From MDLTransformOp Protocol
		//[Export ("name")]
		//string Name { get; }

		/// <summary>Gets the AnimatedValue value.</summary>
		[Export ("animatedValue")]
		MDLAnimatedScalar AnimatedValue { get; }
	}

	[MacCatalyst (13, 1)]
	[BaseType (typeof (NSObject))]
	interface MDLTransformRotateZOp : MDLTransformOp {

		// From MDLTransformOp Protocol
		//[Export ("name")]
		//string Name { get; }

		/// <summary>Gets the AnimatedValue value.</summary>
		[Export ("animatedValue")]
		MDLAnimatedScalar AnimatedValue { get; }
	}

	[MacCatalyst (13, 1)]
	[BaseType (typeof (NSObject))]
	interface MDLTransformRotateOp : MDLTransformOp {

		// From MDLTransformOp Protocol
		//[Export ("name")]
		//string Name { get; }

		/// <summary>Gets the AnimatedValue value.</summary>
		[Export ("animatedValue")]
		MDLAnimatedVector3 AnimatedValue { get; }
	}

	[MacCatalyst (13, 1)]
	[BaseType (typeof (NSObject))]
	interface MDLTransformTranslateOp : MDLTransformOp {

		// From MDLTransformOp Protocol
		//[Export ("name")]
		//string Name { get; }

		/// <summary>Gets the AnimatedValue value.</summary>
		[Export ("animatedValue")]
		MDLAnimatedVector3 AnimatedValue { get; }
	}

	[MacCatalyst (13, 1)]
	[BaseType (typeof (NSObject))]
	interface MDLTransformScaleOp : MDLTransformOp {

		// From MDLTransformOp Protocol
		//[Export ("name")]
		//string Name { get; }

		/// <summary>Gets the AnimatedValue value.</summary>
		[Export ("animatedValue")]
		MDLAnimatedVector3 AnimatedValue { get; }
	}

	[MacCatalyst (13, 1)]
	[BaseType (typeof (NSObject))]
	interface MDLTransformMatrixOp : MDLTransformOp {

		// From MDLTransformOp Protocol
		//[Export ("name")]
		//string Name { get; }

		/// <summary>Gets the AnimatedValue value.</summary>
		[Export ("animatedValue")]
		MDLAnimatedMatrix4x4 AnimatedValue { get; }
	}

	[iOS (13, 0), TV (13, 0)]
	[MacCatalyst (13, 1)]
	[BaseType (typeof (NSObject))]
	interface MDLTransformOrientOp : MDLTransformOp {

		// From MDLTransformOp Protocol
		// [Export ("name")]
		// string Name { get; }

		[Export ("animatedValue")]
		MDLAnimatedQuaternion AnimatedValue { get; }
	}

	[MacCatalyst (13, 1)]
	[BaseType (typeof (NSObject))]
	interface MDLTransformStack : NSCopying, MDLTransformComponent {

		/// <param name="animatedValueName">The animated value name.</param>
		///         <param name="inverse">The inverse.</param>
		///         <summary>Performs the add translate op operation.</summary>
		///         <returns>The result of the operation.</returns>
		[Export ("addTranslateOp:inverse:")]
		MDLTransformTranslateOp AddTranslateOp (string animatedValueName, bool inverse);

		/// <param name="animatedValueName">The animated value name.</param>
		///         <param name="inverse">The inverse.</param>
		///         <summary>Performs the add rotate x op operation.</summary>
		///         <returns>The result of the operation.</returns>
		[Export ("addRotateXOp:inverse:")]
		MDLTransformRotateXOp AddRotateXOp (string animatedValueName, bool inverse);

		/// <param name="animatedValueName">The animated value name.</param>
		///         <param name="inverse">The inverse.</param>
		///         <summary>Performs the add rotate y op operation.</summary>
		///         <returns>The result of the operation.</returns>
		[Export ("addRotateYOp:inverse:")]
		MDLTransformRotateYOp AddRotateYOp (string animatedValueName, bool inverse);

		/// <param name="animatedValueName">The animated value name.</param>
		///         <param name="inverse">The inverse.</param>
		///         <summary>Performs the add rotate z op operation.</summary>
		///         <returns>The result of the operation.</returns>
		[Export ("addRotateZOp:inverse:")]
		MDLTransformRotateZOp AddRotateZOp (string animatedValueName, bool inverse);

		/// <param name="animatedValueName">The animated value name.</param>
		///         <param name="order">The order.</param>
		///         <param name="inverse">The inverse.</param>
		///         <summary>Performs the add rotate op operation.</summary>
		///         <returns>The result of the operation.</returns>
		[Export ("addRotateOp:order:inverse:")]
		MDLTransformRotateOp AddRotateOp (string animatedValueName, MDLTransformOpRotationOrder order, bool inverse);

		/// <param name="animatedValueName">The animated value name.</param>
		///         <param name="inverse">The inverse.</param>
		///         <summary>Performs the add scale op operation.</summary>
		///         <returns>The result of the operation.</returns>
		[Export ("addScaleOp:inverse:")]
		MDLTransformScaleOp AddScaleOp (string animatedValueName, bool inverse);

		/// <param name="animatedValueName">The animated value name.</param>
		///         <param name="inverse">The inverse.</param>
		///         <summary>Performs the add matrix op operation.</summary>
		///         <returns>The result of the operation.</returns>
		[Export ("addMatrixOp:inverse:")]
		MDLTransformMatrixOp AddMatrixOp (string animatedValueName, bool inverse);

		[iOS (13, 0), TV (13, 0)]
		[MacCatalyst (13, 1)]
		[Export ("addOrientOp:inverse:")]
		MDLTransformOrientOp AddOrientOp (string animatedValueName, bool inverse);

		/// <param name="name">The name.</param>
		///         <summary>Performs the get animated value operation.</summary>
		///         <returns>The result of the operation.</returns>
		[Export ("animatedValueWithName:")]
		MDLAnimatedValue GetAnimatedValue (string name);

		/// <param name="atTime">The time.</param>
		///         <summary>Performs the get n matrix4 operation.</summary>
		///         <returns>The result of the operation.</returns>
		[Export ("float4x4AtTime:")]
		[MarshalDirective (NativePrefix = "xamarin_simd__", Library = "__Internal")]
		NMatrix4 GetNMatrix4 (double atTime);

		/// <param name="atTime">The time.</param>
		///         <summary>Performs the get n matrix4d operation.</summary>
		///         <returns>The result of the operation.</returns>
		[Export ("double4x4AtTime:")]
		[MarshalDirective (NativePrefix = "xamarin_simd__", Library = "__Internal")]
		NMatrix4d GetNMatrix4d (double atTime);

		/// <summary>Gets the Count value.</summary>
		[Export ("count")]
		nuint Count { get; }

		// Comes from MDLTransformComponent protocol
		//[Export ("keyTimes", ArgumentSemantic.Copy)]
		//NSNumber [] KeyTimes { get; }

		/// <summary>Gets the TransformOps value.</summary>
		[Export ("transformOps", ArgumentSemantic.Copy)]
		IMDLTransformOp [] TransformOps { get; }
	}

	[MacCatalyst (13, 1)]
	[BaseType (typeof (NSObject))]
	[DisableDefaultCtor]
	interface MDLMatrix4x4Array : NSCopying {

		/// <summary>Gets the ElementCount value.</summary>
		[Export ("elementCount")]
		nuint ElementCount { get; }

		/// <summary>Gets the Precision value.</summary>
		[Export ("precision")]
		MDLDataPrecision Precision { get; }

		/// <summary>Performs the clear operation.</summary>
		[Export ("clear")]
		void Clear ();

		[Export ("initWithElementCount:")]
		NativeHandle Constructor (nuint arrayElementCount);

		[Internal]
		[Export ("setFloat4x4Array:count:")]
		void _SetFloat4x4Array (IntPtr valuesArray, nuint count);

		[Internal]
		[Export ("setDouble4x4Array:count:")]
		void _SetDouble4x4Array (IntPtr valuesArray, nuint count);

		[Internal]
		[Export ("getFloat4x4Array:maxCount:")]
		nuint _GetFloat4x4Array (IntPtr valuesArray, nuint maxCount);

		[Internal]
		[Export ("getDouble4x4Array:maxCount:")]
		nuint _GetDouble4x4Array (IntPtr valuesArray, nuint maxCount);
	}

	[iOS (13, 0), TV (13, 0)]
	[MacCatalyst (13, 1)]
	[BaseType (typeof (MDLAnimatedValue))]
	interface MDLAnimatedQuaternion {
		[MarshalDirective (NativePrefix = "xamarin_simd__", Library = "__Internal")]
		[Export ("setFloatQuaternion:atTime:")]
		void SetQuaternion (Quaternion value, double atTime);

		[MarshalDirective (NativePrefix = "xamarin_simd__", Library = "__Internal")]
		[Export ("setDoubleQuaternion:atTime:")]
		void SetQuaternion (Quaterniond value, double atTime);

		[MarshalDirective (NativePrefix = "xamarin_simd__", Library = "__Internal")]
		[Export ("floatQuaternionAtTime:")]
		Quaternion GetFloatQuaternion (double atTime);

		[MarshalDirective (NativePrefix = "xamarin_simd__", Library = "__Internal")]
		[Export ("doubleQuaternionAtTime:")]
		Quaterniond GetDoubleQuaternion (double atTime);

		[Internal]
		[Export ("resetWithFloatQuaternionArray:atTimes:count:")]
		void _ResetWithFloatQuaternionArray (IntPtr valuesArray, IntPtr timesArray, nuint times);

		[Internal]
		[Export ("resetWithDoubleQuaternionArray:atTimes:count:")]
		void _ResetWithDoubleQuaternionArray (IntPtr valuesArray, IntPtr timesArray, nuint times);

		[Internal]
		[Export ("getFloatQuaternionArray:maxCount:")]
		nuint _GetFloatQuaternionArray (IntPtr valuesArray, nuint maxCount);

		[Internal]
		[Export ("getDoubleQuaternionArray:maxCount:")]
		nuint _GetDoubleQuaternionArray (IntPtr valuesArray, nuint maxCount);
	}

	[TV (18, 0), Mac (15, 0), iOS (18, 0), MacCatalyst (18, 0)]
	[DisableDefaultCtor]
	[BaseType (typeof (NSObject))]
	interface MDLUtility {
		[Static]
		[Export ("convertToUSDZ:writeToURL:")]
		void ConvertToUsdz (NSUrl inputUrl, NSUrl outputUrl);
	}
}
