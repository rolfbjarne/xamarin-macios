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
	/// <summary>A point of view that looks into a 3D scence, and that can simulate certain aspects of a physical camera.</summary><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/ModelIO/Reference/MDLCamera_Class/index.html">Apple documentation for <c>MDLCamera</c></related>
	[Register("MDLCamera", true)]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe partial class MDLCamera : MDLObject {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selApertureBladeCountX = "apertureBladeCount";
		static readonly NativeHandle selApertureBladeCountXHandle = Selector.GetHandle ("apertureBladeCount");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selBarrelDistortionX = "barrelDistortion";
		static readonly NativeHandle selBarrelDistortionXHandle = Selector.GetHandle ("barrelDistortion");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selBokehKernelWithSize_X = "bokehKernelWithSize:";
		static readonly NativeHandle selBokehKernelWithSize_XHandle = Selector.GetHandle ("bokehKernelWithSize:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCameraWithSCNCamera_X = "cameraWithSCNCamera:";
		static readonly NativeHandle selCameraWithSCNCamera_XHandle = Selector.GetHandle ("cameraWithSCNCamera:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selChromaticAberrationX = "chromaticAberration";
		static readonly NativeHandle selChromaticAberrationXHandle = Selector.GetHandle ("chromaticAberration");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selExposureX = "exposure";
		static readonly NativeHandle selExposureXHandle = Selector.GetHandle ("exposure");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selExposureCompressionX = "exposureCompression";
		static readonly NativeHandle selExposureCompressionXHandle = Selector.GetHandle ("exposureCompression");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFStopX = "fStop";
		static readonly NativeHandle selFStopXHandle = Selector.GetHandle ("fStop");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFarVisibilityDistanceX = "farVisibilityDistance";
		static readonly NativeHandle selFarVisibilityDistanceXHandle = Selector.GetHandle ("farVisibilityDistance");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFieldOfViewX = "fieldOfView";
		static readonly NativeHandle selFieldOfViewXHandle = Selector.GetHandle ("fieldOfView");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFisheyeDistortionX = "fisheyeDistortion";
		static readonly NativeHandle selFisheyeDistortionXHandle = Selector.GetHandle ("fisheyeDistortion");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFlashX = "flash";
		static readonly NativeHandle selFlashXHandle = Selector.GetHandle ("flash");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFocalLengthX = "focalLength";
		static readonly NativeHandle selFocalLengthXHandle = Selector.GetHandle ("focalLength");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFocusDistanceX = "focusDistance";
		static readonly NativeHandle selFocusDistanceXHandle = Selector.GetHandle ("focusDistance");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFrameBoundingBox_SetNearAndFar_X = "frameBoundingBox:setNearAndFar:";
		static readonly NativeHandle selFrameBoundingBox_SetNearAndFar_XHandle = Selector.GetHandle ("frameBoundingBox:setNearAndFar:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLookAt_X = "lookAt:";
		static readonly NativeHandle selLookAt_XHandle = Selector.GetHandle ("lookAt:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLookAt_From_X = "lookAt:from:";
		static readonly NativeHandle selLookAt_From_XHandle = Selector.GetHandle ("lookAt:from:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMaximumCircleOfConfusionX = "maximumCircleOfConfusion";
		static readonly NativeHandle selMaximumCircleOfConfusionXHandle = Selector.GetHandle ("maximumCircleOfConfusion");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selNearVisibilityDistanceX = "nearVisibilityDistance";
		static readonly NativeHandle selNearVisibilityDistanceXHandle = Selector.GetHandle ("nearVisibilityDistance");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selOpticalVignettingX = "opticalVignetting";
		static readonly NativeHandle selOpticalVignettingXHandle = Selector.GetHandle ("opticalVignetting");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selProjectionX = "projection";
		static readonly NativeHandle selProjectionXHandle = Selector.GetHandle ("projection");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selProjectionMatrixX = "projectionMatrix";
		static readonly NativeHandle selProjectionMatrixXHandle = Selector.GetHandle ("projectionMatrix");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRayTo_ForViewPort_X = "rayTo:forViewPort:";
		static readonly NativeHandle selRayTo_ForViewPort_XHandle = Selector.GetHandle ("rayTo:forViewPort:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSensorAspectX = "sensorAspect";
		static readonly NativeHandle selSensorAspectXHandle = Selector.GetHandle ("sensorAspect");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSensorEnlargementX = "sensorEnlargement";
		static readonly NativeHandle selSensorEnlargementXHandle = Selector.GetHandle ("sensorEnlargement");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSensorShiftX = "sensorShift";
		static readonly NativeHandle selSensorShiftXHandle = Selector.GetHandle ("sensorShift");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSensorVerticalApertureX = "sensorVerticalAperture";
		static readonly NativeHandle selSensorVerticalApertureXHandle = Selector.GetHandle ("sensorVerticalAperture");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetApertureBladeCount_X = "setApertureBladeCount:";
		static readonly NativeHandle selSetApertureBladeCount_XHandle = Selector.GetHandle ("setApertureBladeCount:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetBarrelDistortion_X = "setBarrelDistortion:";
		static readonly NativeHandle selSetBarrelDistortion_XHandle = Selector.GetHandle ("setBarrelDistortion:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetChromaticAberration_X = "setChromaticAberration:";
		static readonly NativeHandle selSetChromaticAberration_XHandle = Selector.GetHandle ("setChromaticAberration:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetExposure_X = "setExposure:";
		static readonly NativeHandle selSetExposure_XHandle = Selector.GetHandle ("setExposure:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetExposureCompression_X = "setExposureCompression:";
		static readonly NativeHandle selSetExposureCompression_XHandle = Selector.GetHandle ("setExposureCompression:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetFStop_X = "setFStop:";
		static readonly NativeHandle selSetFStop_XHandle = Selector.GetHandle ("setFStop:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetFarVisibilityDistance_X = "setFarVisibilityDistance:";
		static readonly NativeHandle selSetFarVisibilityDistance_XHandle = Selector.GetHandle ("setFarVisibilityDistance:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetFieldOfView_X = "setFieldOfView:";
		static readonly NativeHandle selSetFieldOfView_XHandle = Selector.GetHandle ("setFieldOfView:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetFisheyeDistortion_X = "setFisheyeDistortion:";
		static readonly NativeHandle selSetFisheyeDistortion_XHandle = Selector.GetHandle ("setFisheyeDistortion:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetFlash_X = "setFlash:";
		static readonly NativeHandle selSetFlash_XHandle = Selector.GetHandle ("setFlash:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetFocalLength_X = "setFocalLength:";
		static readonly NativeHandle selSetFocalLength_XHandle = Selector.GetHandle ("setFocalLength:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetFocusDistance_X = "setFocusDistance:";
		static readonly NativeHandle selSetFocusDistance_XHandle = Selector.GetHandle ("setFocusDistance:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetMaximumCircleOfConfusion_X = "setMaximumCircleOfConfusion:";
		static readonly NativeHandle selSetMaximumCircleOfConfusion_XHandle = Selector.GetHandle ("setMaximumCircleOfConfusion:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetNearVisibilityDistance_X = "setNearVisibilityDistance:";
		static readonly NativeHandle selSetNearVisibilityDistance_XHandle = Selector.GetHandle ("setNearVisibilityDistance:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetOpticalVignetting_X = "setOpticalVignetting:";
		static readonly NativeHandle selSetOpticalVignetting_XHandle = Selector.GetHandle ("setOpticalVignetting:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetProjection_X = "setProjection:";
		static readonly NativeHandle selSetProjection_XHandle = Selector.GetHandle ("setProjection:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetSensorAspect_X = "setSensorAspect:";
		static readonly NativeHandle selSetSensorAspect_XHandle = Selector.GetHandle ("setSensorAspect:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetSensorEnlargement_X = "setSensorEnlargement:";
		static readonly NativeHandle selSetSensorEnlargement_XHandle = Selector.GetHandle ("setSensorEnlargement:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetSensorShift_X = "setSensorShift:";
		static readonly NativeHandle selSetSensorShift_XHandle = Selector.GetHandle ("setSensorShift:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetSensorVerticalAperture_X = "setSensorVerticalAperture:";
		static readonly NativeHandle selSetSensorVerticalAperture_XHandle = Selector.GetHandle ("setSensorVerticalAperture:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetShutterOpenInterval_X = "setShutterOpenInterval:";
		static readonly NativeHandle selSetShutterOpenInterval_XHandle = Selector.GetHandle ("setShutterOpenInterval:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetWorldToMetersConversionScale_X = "setWorldToMetersConversionScale:";
		static readonly NativeHandle selSetWorldToMetersConversionScale_XHandle = Selector.GetHandle ("setWorldToMetersConversionScale:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selShutterOpenIntervalX = "shutterOpenInterval";
		static readonly NativeHandle selShutterOpenIntervalXHandle = Selector.GetHandle ("shutterOpenInterval");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selWorldToMetersConversionScaleX = "worldToMetersConversionScale";
		static readonly NativeHandle selWorldToMetersConversionScaleXHandle = Selector.GetHandle ("worldToMetersConversionScale");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("MDLCamera");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		/// <summary>Creates a new <see cref="MDLCamera" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public MDLCamera () : base (NSObjectFlag.Empty)
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
		protected MDLCamera (NSObjectFlag t) : base (t)
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
		protected internal MDLCamera (NativeHandle handle) : base (handle)
		{
		}

		/// <param name="size">To be added.</param><summary>Creates and returns a texture, of the specified size, that is used to simulate bokeh effects by using the value of the <see cref="P:ModelIO.MDLCamera.ApertureBladeCount" /> property.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("bokehKernelWithSize:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MDLTexture BokehKernelWithSize (NVector2i size)
		{
			MDLTexture ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<MDLTexture> (global::ObjCRuntime.Messaging.xamarin_simd__NativeHandle_objc_msgSend_NVector2i (this.Handle, selBokehKernelWithSize_XHandle, size), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<MDLTexture> (global::ObjCRuntime.Messaging.xamarin_simd__NativeHandle_objc_msgSendSuper_NVector2i (&__objc_super__, selBokehKernelWithSize_XHandle, size), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		/// <param name="boundingBox">To be added.</param><param name="setNearAndFar">To be added.</param><summary>Moves the camera to view <paramref name="boundingBox" /> looking parallel to the Z axis in a negative direction, and sets the near and far clipping planes to the bounding box if <paramref name="setNearAndFar" /> is <see langword="true" />.</summary><remarks>To be added.</remarks>
		[Export ("frameBoundingBox:setNearAndFar:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void FrameBoundingBox (MDLAxisAlignedBoundingBox boundingBox, bool setNearAndFar)
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.xamarin_simd__void_objc_msgSend_MDLAxisAlignedBoundingBox_bool (this.Handle, selFrameBoundingBox_SetNearAndFar_XHandle, boundingBox, setNearAndFar ? (byte) 1 : (byte) 0);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.xamarin_simd__void_objc_msgSendSuper_MDLAxisAlignedBoundingBox_bool (&__objc_super__, selFrameBoundingBox_SetNearAndFar_XHandle, boundingBox, setNearAndFar ? (byte) 1 : (byte) 0);
					GC.KeepAlive (this);
				}
			}
		}
		/// <param name="sceneCamera">To be added.</param><summary>Creates a new MDLCamera from the specified Scene Kit camera.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("cameraWithSCNCamera:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MDLCamera FromSceneCamera (global::SceneKit.SCNCamera sceneCamera)
		{
			var sceneCamera__handle__ = sceneCamera!.GetNonNullHandle (nameof (sceneCamera));
			MDLCamera? ret;
			ret =  Runtime.GetNSObject<MDLCamera> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, selCameraWithSCNCamera_XHandle, sceneCamera__handle__), false)!;
			GC.KeepAlive (sceneCamera);
			return ret!;
		}
		/// <param name="focusPosition">To be added.</param><summary>Points the camera at <paramref name="focusPosition" />.</summary><remarks>To be added.</remarks>
		[Export ("lookAt:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void LookAt (global::System.Numerics.Vector3 focusPosition)
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.xamarin_simd__void_objc_msgSend_Vector3 (this.Handle, selLookAt_XHandle, focusPosition);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.xamarin_simd__void_objc_msgSendSuper_Vector3 (&__objc_super__, selLookAt_XHandle, focusPosition);
					GC.KeepAlive (this);
				}
			}
		}
		/// <param name="focusPosition">To be added.</param><param name="cameraPosition">To be added.</param><summary>Moves the camera to <paramref name="focusPosition" />, and points it at <paramref name="focusPosition" />.</summary><remarks>To be added.</remarks>
		[Export ("lookAt:from:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void LookAt (global::System.Numerics.Vector3 focusPosition, global::System.Numerics.Vector3 cameraPosition)
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.xamarin_simd__void_objc_msgSend_Vector3_Vector3 (this.Handle, selLookAt_From_XHandle, focusPosition, cameraPosition);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.xamarin_simd__void_objc_msgSendSuper_Vector3_Vector3 (&__objc_super__, selLookAt_From_XHandle, focusPosition, cameraPosition);
					GC.KeepAlive (this);
				}
			}
		}
		/// <param name="pixel">To be added.</param><param name="size">To be added.</param><summary>Returns a truncated 3D ray that points from the camera toward the 2D point that is specified by taking <paramref name="pixel" /> as coordinates in a viewport with the dimensions in <paramref name="size" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("rayTo:forViewPort:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::System.Numerics.Vector3 RayTo (NVector2i pixel, NVector2i size)
		{
			global::System.Numerics.Vector3 ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.xamarin_simd__Vector3_objc_msgSend_NVector2i_NVector2i (this.Handle, selRayTo_ForViewPort_XHandle, pixel, size);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.xamarin_simd__Vector3_objc_msgSendSuper_NVector2i_NVector2i (&__objc_super__, selRayTo_ForViewPort_XHandle, pixel, size);
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		/// <summary>Gets or sets the number of blades to use when simulating bokeh in out-of-focus elements in the scene.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nuint ApertureBladeCount {
			[Export ("apertureBladeCount")]
			get {
				nuint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selApertureBladeCountXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selApertureBladeCountXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setApertureBladeCount:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (this.Handle, selSetApertureBladeCount_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UIntPtr (&__objc_super__, selSetApertureBladeCount_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>Gets or sets the coefficient of the quadratic term in the formula that is used to calculate radial distortion.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual float BarrelDistortion {
			[Export ("barrelDistortion")]
			get {
				float ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selBarrelDistortionXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.float_objc_msgSendSuper (&__objc_super__, selBarrelDistortionXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setBarrelDistortion:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, selSetBarrelDistortion_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_float (&__objc_super__, selSetBarrelDistortion_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>Gets or sets the degree to which different colors are focussed differently by the camera. 0.0 is no chromatic aberration. 1.0 is the maximum amount.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual float ChromaticAberration {
			[Export ("chromaticAberration")]
			get {
				float ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selChromaticAberrationXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.float_objc_msgSendSuper (&__objc_super__, selChromaticAberrationXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setChromaticAberration:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, selSetChromaticAberration_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_float (&__objc_super__, selSetChromaticAberration_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>Gets or sets a vector whose components are multiplied by the color components of the rendered image prior to simulation of the physical lens.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::System.Numerics.Vector3 Exposure {
			[Export ("exposure", ArgumentSemantic.Assign)]
			get {
				global::System.Numerics.Vector3 ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.xamarin_simd__Vector3_objc_msgSend (this.Handle, selExposureXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.xamarin_simd__Vector3_objc_msgSendSuper (&__objc_super__, selExposureXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setExposure:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.xamarin_simd__void_objc_msgSend_Vector3 (this.Handle, selSetExposure_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.xamarin_simd__void_objc_msgSendSuper_Vector3 (&__objc_super__, selSetExposure_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>Gets or sets a vector whose X and Y components clamp the low and high values of color components when calculating exposure levels for a simulated physical camera.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::System.Numerics.Vector2 ExposureCompression {
			[Export ("exposureCompression", ArgumentSemantic.Assign)]
			get {
				global::System.Numerics.Vector2 ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.xamarin_simd__Vector2_objc_msgSend (this.Handle, selExposureCompressionXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.xamarin_simd__Vector2_objc_msgSendSuper (&__objc_super__, selExposureCompressionXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setExposureCompression:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.xamarin_simd__void_objc_msgSend_Vector2 (this.Handle, selSetExposureCompression_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.xamarin_simd__void_objc_msgSendSuper_Vector2 (&__objc_super__, selSetExposureCompression_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>Gets or sets the focal ratio of the camera.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual float FStop {
			[Export ("fStop")]
			get {
				float ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selFStopXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.float_objc_msgSendSuper (&__objc_super__, selFStopXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setFStop:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, selSetFStop_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_float (&__objc_super__, selSetFStop_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>Gets or sets the back clipping plane.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual float FarVisibilityDistance {
			[Export ("farVisibilityDistance")]
			get {
				float ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selFarVisibilityDistanceXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.float_objc_msgSendSuper (&__objc_super__, selFarVisibilityDistanceXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setFarVisibilityDistance:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, selSetFarVisibilityDistance_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_float (&__objc_super__, selSetFarVisibilityDistance_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>Gets or sets the field of view, and updates the focal length of the camera accordingly.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual float FieldOfView {
			[Export ("fieldOfView")]
			get {
				float ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selFieldOfViewXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.float_objc_msgSendSuper (&__objc_super__, selFieldOfViewXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setFieldOfView:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, selSetFieldOfView_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_float (&__objc_super__, selSetFieldOfView_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>Gets or sets the coefficient of the fourth-power term in the formula that is used to calculate radial distortion.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual float FisheyeDistortion {
			[Export ("fisheyeDistortion")]
			get {
				float ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selFisheyeDistortionXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.float_objc_msgSendSuper (&__objc_super__, selFisheyeDistortionXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setFisheyeDistortion:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, selSetFisheyeDistortion_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_float (&__objc_super__, selSetFisheyeDistortion_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>Gets or sets a vector whose signed components are added to the rendered image in order to simulate the effect of a flash.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::System.Numerics.Vector3 Flash {
			[Export ("flash", ArgumentSemantic.Assign)]
			get {
				global::System.Numerics.Vector3 ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.xamarin_simd__Vector3_objc_msgSend (this.Handle, selFlashXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.xamarin_simd__Vector3_objc_msgSendSuper (&__objc_super__, selFlashXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setFlash:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.xamarin_simd__void_objc_msgSend_Vector3 (this.Handle, selSetFlash_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.xamarin_simd__void_objc_msgSendSuper_Vector3 (&__objc_super__, selSetFlash_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>Gets or sets the focal length and updates the field of view accordingly.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual float FocalLength {
			[Export ("focalLength")]
			get {
				float ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selFocalLengthXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.float_objc_msgSendSuper (&__objc_super__, selFocalLengthXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setFocalLength:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, selSetFocalLength_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_float (&__objc_super__, selSetFocalLength_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>Gets or sets the focal distance, in meters.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual float FocusDistance {
			[Export ("focusDistance")]
			get {
				float ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selFocusDistanceXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.float_objc_msgSendSuper (&__objc_super__, selFocusDistanceXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setFocusDistance:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, selSetFocusDistance_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_float (&__objc_super__, selSetFocusDistance_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>Gets or sets the largest size of bokeh from point sources of light.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual float MaximumCircleOfConfusion {
			[Export ("maximumCircleOfConfusion")]
			get {
				float ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selMaximumCircleOfConfusionXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.float_objc_msgSendSuper (&__objc_super__, selMaximumCircleOfConfusionXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setMaximumCircleOfConfusion:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, selSetMaximumCircleOfConfusion_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_float (&__objc_super__, selSetMaximumCircleOfConfusion_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>Gets or sets the near clipping plane.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual float NearVisibilityDistance {
			[Export ("nearVisibilityDistance")]
			get {
				float ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selNearVisibilityDistanceXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.float_objc_msgSendSuper (&__objc_super__, selNearVisibilityDistanceXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setNearVisibilityDistance:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, selSetNearVisibilityDistance_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_float (&__objc_super__, selSetNearVisibilityDistance_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>Gets or sets a value that controls the degree to which image brightness is reduced as the edge of the simulated physical aperture is approached.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual float OpticalVignetting {
			[Export ("opticalVignetting")]
			get {
				float ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selOpticalVignettingXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.float_objc_msgSendSuper (&__objc_super__, selOpticalVignettingXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setOpticalVignetting:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, selSetOpticalVignetting_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_float (&__objc_super__, selSetOpticalVignetting_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>Gets or sets a value that controls whether the projection is perspective or orthographic.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual MDLCameraProjection Projection {
			[Export ("projection", ArgumentSemantic.Assign)]
			get {
				MDLCameraProjection ret;
				if (IsDirectBinding) {
					ret = (MDLCameraProjection) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selProjectionXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (MDLCameraProjection) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selProjectionXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setProjection:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (this.Handle, selSetProjection_XHandle, (UIntPtr) (ulong) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UIntPtr (&__objc_super__, selSetProjection_XHandle, (UIntPtr) (ulong) value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>Gets or sets the transformation that determines what portion of a scene that the camera can view.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NMatrix4 ProjectionMatrix {
			[Export ("projectionMatrix")]
			get {
				NMatrix4 ret;
				if (IsDirectBinding) {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						ret = global::ObjCRuntime.Messaging.xamarin_simd__NMatrix4_objc_msgSend (this.Handle, selProjectionMatrixXHandle);
					} else {
						ret = global::ObjCRuntime.Messaging.xamarin_simd__NMatrix4_objc_msgSend_stret (this.Handle, selProjectionMatrixXHandle);
					}
				} else {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.xamarin_simd__NMatrix4_objc_msgSendSuper (&__objc_super__, selProjectionMatrixXHandle);
							GC.KeepAlive (this);
						}
					} else {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.xamarin_simd__NMatrix4_objc_msgSendSuper_stret (&__objc_super__, selProjectionMatrixXHandle);
							GC.KeepAlive (this);
						}
					}
				}
				return ret!;
			}
		}
		/// <summary>Gets or sets the aspect ratio of a simulated camera sensor.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual float SensorAspect {
			[Export ("sensorAspect")]
			get {
				float ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selSensorAspectXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.float_objc_msgSendSuper (&__objc_super__, selSensorAspectXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setSensorAspect:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, selSetSensorAspect_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_float (&__objc_super__, selSetSensorAspect_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>Gets or sets the scale factor by which to expand the central region of the region. The image is cropped to the original extent of the sensor.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::System.Numerics.Vector2 SensorEnlargement {
			[Export ("sensorEnlargement", ArgumentSemantic.Assign)]
			get {
				global::System.Numerics.Vector2 ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.xamarin_simd__Vector2_objc_msgSend (this.Handle, selSensorEnlargementXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.xamarin_simd__Vector2_objc_msgSendSuper (&__objc_super__, selSensorEnlargementXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setSensorEnlargement:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.xamarin_simd__void_objc_msgSend_Vector2 (this.Handle, selSetSensorEnlargement_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.xamarin_simd__void_objc_msgSendSuper_Vector2 (&__objc_super__, selSetSensorEnlargement_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>Gets or sets the directed distance, in mm, by which to offset the sensor from the center line of the simulated optical system.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::System.Numerics.Vector2 SensorShift {
			[Export ("sensorShift", ArgumentSemantic.Assign)]
			get {
				global::System.Numerics.Vector2 ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.xamarin_simd__Vector2_objc_msgSend (this.Handle, selSensorShiftXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.xamarin_simd__Vector2_objc_msgSendSuper (&__objc_super__, selSensorShiftXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setSensorShift:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.xamarin_simd__void_objc_msgSend_Vector2 (this.Handle, selSetSensorShift_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.xamarin_simd__void_objc_msgSendSuper_Vector2 (&__objc_super__, selSetSensorShift_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>Gets or sets the height, in mm, of the sensor.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual float SensorVerticalAperture {
			[Export ("sensorVerticalAperture")]
			get {
				float ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selSensorVerticalApertureXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.float_objc_msgSendSuper (&__objc_super__, selSensorVerticalApertureXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setSensorVerticalAperture:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, selSetSensorVerticalAperture_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_float (&__objc_super__, selSetSensorVerticalAperture_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>Gets or sets the time, in seconds, for which the simulated shutter is open per frame.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual double ShutterOpenInterval {
			[Export ("shutterOpenInterval")]
			get {
				double ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.Double_objc_msgSend (this.Handle, selShutterOpenIntervalXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.Double_objc_msgSendSuper (&__objc_super__, selShutterOpenIntervalXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setShutterOpenInterval:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_Double (this.Handle, selSetShutterOpenInterval_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_Double (&__objc_super__, selSetShutterOpenInterval_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>Gets or sets the scale factor that transforms world coordinates into meters.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual float WorldToMetersConversionScale {
			[Export ("worldToMetersConversionScale")]
			get {
				float ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selWorldToMetersConversionScaleXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.float_objc_msgSendSuper (&__objc_super__, selWorldToMetersConversionScaleXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setWorldToMetersConversionScale:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, selSetWorldToMetersConversionScale_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_float (&__objc_super__, selSetWorldToMetersConversionScale_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
	} /* class MDLCamera */
}
