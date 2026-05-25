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
namespace SceneKit {
	/// <summary>Specifies the lighting and shading characteristics of the surface of an SCNGeometry.</summary><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/SceneKit/Reference/SCNMaterial_Class/index.html">Apple documentation for <c>SCNMaterial</c></related>
	[Register("SCNMaterial", true)]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe partial class SCNMaterial : NSObject, INSCoding, INSCopying, INSSecureCoding, ISCNAnimatable, ISCNShadable {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAddAnimation_ForKey_X = "addAnimation:forKey:";
		static readonly NativeHandle selAddAnimation_ForKey_XHandle = Selector.GetHandle ("addAnimation:forKey:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAddAnimationPlayer_ForKey_X = "addAnimationPlayer:forKey:";
		static readonly NativeHandle selAddAnimationPlayer_ForKey_XHandle = Selector.GetHandle ("addAnimationPlayer:forKey:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAmbientX = "ambient";
		static readonly NativeHandle selAmbientXHandle = Selector.GetHandle ("ambient");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAmbientOcclusionX = "ambientOcclusion";
		static readonly NativeHandle selAmbientOcclusionXHandle = Selector.GetHandle ("ambientOcclusion");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAnimationForKey_X = "animationForKey:";
		static readonly NativeHandle selAnimationForKey_XHandle = Selector.GetHandle ("animationForKey:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAnimationKeysX = "animationKeys";
		static readonly NativeHandle selAnimationKeysXHandle = Selector.GetHandle ("animationKeys");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAnimationPlayerForKey_X = "animationPlayerForKey:";
		static readonly NativeHandle selAnimationPlayerForKey_XHandle = Selector.GetHandle ("animationPlayerForKey:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selBlendModeX = "blendMode";
		static readonly NativeHandle selBlendModeXHandle = Selector.GetHandle ("blendMode");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selClearCoatX = "clearCoat";
		static readonly NativeHandle selClearCoatXHandle = Selector.GetHandle ("clearCoat");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selClearCoatNormalX = "clearCoatNormal";
		static readonly NativeHandle selClearCoatNormalXHandle = Selector.GetHandle ("clearCoatNormal");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selClearCoatRoughnessX = "clearCoatRoughness";
		static readonly NativeHandle selClearCoatRoughnessXHandle = Selector.GetHandle ("clearCoatRoughness");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selColorBufferWriteMaskX = "colorBufferWriteMask";
		static readonly NativeHandle selColorBufferWriteMaskXHandle = Selector.GetHandle ("colorBufferWriteMask");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCopyWithZone_X = "copyWithZone:";
		static readonly NativeHandle selCopyWithZone_XHandle = Selector.GetHandle ("copyWithZone:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCullModeX = "cullMode";
		static readonly NativeHandle selCullModeXHandle = Selector.GetHandle ("cullMode");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDiffuseX = "diffuse";
		static readonly NativeHandle selDiffuseXHandle = Selector.GetHandle ("diffuse");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDisplacementX = "displacement";
		static readonly NativeHandle selDisplacementXHandle = Selector.GetHandle ("displacement");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selEmissionX = "emission";
		static readonly NativeHandle selEmissionXHandle = Selector.GetHandle ("emission");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selEncodeWithCoder_X = "encodeWithCoder:";
		static readonly NativeHandle selEncodeWithCoder_XHandle = Selector.GetHandle ("encodeWithCoder:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFillModeX = "fillMode";
		static readonly NativeHandle selFillModeXHandle = Selector.GetHandle ("fillMode");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFresnelExponentX = "fresnelExponent";
		static readonly NativeHandle selFresnelExponentXHandle = Selector.GetHandle ("fresnelExponent");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selHandleBindingOfSymbol_UsingBlock_X = "handleBindingOfSymbol:usingBlock:";
		static readonly NativeHandle selHandleBindingOfSymbol_UsingBlock_XHandle = Selector.GetHandle ("handleBindingOfSymbol:usingBlock:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selHandleUnbindingOfSymbol_UsingBlock_X = "handleUnbindingOfSymbol:usingBlock:";
		static readonly NativeHandle selHandleUnbindingOfSymbol_UsingBlock_XHandle = Selector.GetHandle ("handleUnbindingOfSymbol:usingBlock:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithCoder_X = "initWithCoder:";
		static readonly NativeHandle selInitWithCoder_XHandle = Selector.GetHandle ("initWithCoder:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsAnimationForKeyPaused_X = "isAnimationForKeyPaused:";
		static readonly NativeHandle selIsAnimationForKeyPaused_XHandle = Selector.GetHandle ("isAnimationForKeyPaused:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsDoubleSidedX = "isDoubleSided";
		static readonly NativeHandle selIsDoubleSidedXHandle = Selector.GetHandle ("isDoubleSided");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsLitPerPixelX = "isLitPerPixel";
		static readonly NativeHandle selIsLitPerPixelXHandle = Selector.GetHandle ("isLitPerPixel");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLightingModelNameX = "lightingModelName";
		static readonly NativeHandle selLightingModelNameXHandle = Selector.GetHandle ("lightingModelName");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLocksAmbientWithDiffuseX = "locksAmbientWithDiffuse";
		static readonly NativeHandle selLocksAmbientWithDiffuseXHandle = Selector.GetHandle ("locksAmbientWithDiffuse");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMaterialX = "material";
		static readonly NativeHandle selMaterialXHandle = Selector.GetHandle ("material");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMaterialWithMDLMaterial_X = "materialWithMDLMaterial:";
		static readonly NativeHandle selMaterialWithMDLMaterial_XHandle = Selector.GetHandle ("materialWithMDLMaterial:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMetalnessX = "metalness";
		static readonly NativeHandle selMetalnessXHandle = Selector.GetHandle ("metalness");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMinimumLanguageVersionX = "minimumLanguageVersion";
		static readonly NativeHandle selMinimumLanguageVersionXHandle = Selector.GetHandle ("minimumLanguageVersion");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMultiplyX = "multiply";
		static readonly NativeHandle selMultiplyXHandle = Selector.GetHandle ("multiply");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selNameX = "name";
		static readonly NativeHandle selNameXHandle = Selector.GetHandle ("name");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selNormalX = "normal";
		static readonly NativeHandle selNormalXHandle = Selector.GetHandle ("normal");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPauseAnimationForKey_X = "pauseAnimationForKey:";
		static readonly NativeHandle selPauseAnimationForKey_XHandle = Selector.GetHandle ("pauseAnimationForKey:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selProgramX = "program";
		static readonly NativeHandle selProgramXHandle = Selector.GetHandle ("program");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selReadsFromDepthBufferX = "readsFromDepthBuffer";
		static readonly NativeHandle selReadsFromDepthBufferXHandle = Selector.GetHandle ("readsFromDepthBuffer");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selReflectiveX = "reflective";
		static readonly NativeHandle selReflectiveXHandle = Selector.GetHandle ("reflective");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRemoveAllAnimationsX = "removeAllAnimations";
		static readonly NativeHandle selRemoveAllAnimationsXHandle = Selector.GetHandle ("removeAllAnimations");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRemoveAllAnimationsWithBlendOutDuration_X = "removeAllAnimationsWithBlendOutDuration:";
		static readonly NativeHandle selRemoveAllAnimationsWithBlendOutDuration_XHandle = Selector.GetHandle ("removeAllAnimationsWithBlendOutDuration:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRemoveAnimationForKey_X = "removeAnimationForKey:";
		static readonly NativeHandle selRemoveAnimationForKey_XHandle = Selector.GetHandle ("removeAnimationForKey:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRemoveAnimationForKey_BlendOutDuration_X = "removeAnimationForKey:blendOutDuration:";
		static readonly NativeHandle selRemoveAnimationForKey_BlendOutDuration_XHandle = Selector.GetHandle ("removeAnimationForKey:blendOutDuration:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRemoveAnimationForKey_FadeOutDuration_X = "removeAnimationForKey:fadeOutDuration:";
		static readonly NativeHandle selRemoveAnimationForKey_FadeOutDuration_XHandle = Selector.GetHandle ("removeAnimationForKey:fadeOutDuration:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selResumeAnimationForKey_X = "resumeAnimationForKey:";
		static readonly NativeHandle selResumeAnimationForKey_XHandle = Selector.GetHandle ("resumeAnimationForKey:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRoughnessX = "roughness";
		static readonly NativeHandle selRoughnessXHandle = Selector.GetHandle ("roughness");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSelfIlluminationX = "selfIllumination";
		static readonly NativeHandle selSelfIlluminationXHandle = Selector.GetHandle ("selfIllumination");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetBlendMode_X = "setBlendMode:";
		static readonly NativeHandle selSetBlendMode_XHandle = Selector.GetHandle ("setBlendMode:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetColorBufferWriteMask_X = "setColorBufferWriteMask:";
		static readonly NativeHandle selSetColorBufferWriteMask_XHandle = Selector.GetHandle ("setColorBufferWriteMask:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetCullMode_X = "setCullMode:";
		static readonly NativeHandle selSetCullMode_XHandle = Selector.GetHandle ("setCullMode:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetDoubleSided_X = "setDoubleSided:";
		static readonly NativeHandle selSetDoubleSided_XHandle = Selector.GetHandle ("setDoubleSided:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetFillMode_X = "setFillMode:";
		static readonly NativeHandle selSetFillMode_XHandle = Selector.GetHandle ("setFillMode:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetFresnelExponent_X = "setFresnelExponent:";
		static readonly NativeHandle selSetFresnelExponent_XHandle = Selector.GetHandle ("setFresnelExponent:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetLightingModelName_X = "setLightingModelName:";
		static readonly NativeHandle selSetLightingModelName_XHandle = Selector.GetHandle ("setLightingModelName:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetLitPerPixel_X = "setLitPerPixel:";
		static readonly NativeHandle selSetLitPerPixel_XHandle = Selector.GetHandle ("setLitPerPixel:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetLocksAmbientWithDiffuse_X = "setLocksAmbientWithDiffuse:";
		static readonly NativeHandle selSetLocksAmbientWithDiffuse_XHandle = Selector.GetHandle ("setLocksAmbientWithDiffuse:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetMinimumLanguageVersion_X = "setMinimumLanguageVersion:";
		static readonly NativeHandle selSetMinimumLanguageVersion_XHandle = Selector.GetHandle ("setMinimumLanguageVersion:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetName_X = "setName:";
		static readonly NativeHandle selSetName_XHandle = Selector.GetHandle ("setName:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetProgram_X = "setProgram:";
		static readonly NativeHandle selSetProgram_XHandle = Selector.GetHandle ("setProgram:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetReadsFromDepthBuffer_X = "setReadsFromDepthBuffer:";
		static readonly NativeHandle selSetReadsFromDepthBuffer_XHandle = Selector.GetHandle ("setReadsFromDepthBuffer:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetShaderModifiers_X = "setShaderModifiers:";
		static readonly NativeHandle selSetShaderModifiers_XHandle = Selector.GetHandle ("setShaderModifiers:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetShininess_X = "setShininess:";
		static readonly NativeHandle selSetShininess_XHandle = Selector.GetHandle ("setShininess:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetSpeed_ForAnimationKey_X = "setSpeed:forAnimationKey:";
		static readonly NativeHandle selSetSpeed_ForAnimationKey_XHandle = Selector.GetHandle ("setSpeed:forAnimationKey:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetTransparency_X = "setTransparency:";
		static readonly NativeHandle selSetTransparency_XHandle = Selector.GetHandle ("setTransparency:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetTransparencyMode_X = "setTransparencyMode:";
		static readonly NativeHandle selSetTransparencyMode_XHandle = Selector.GetHandle ("setTransparencyMode:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetWritesToDepthBuffer_X = "setWritesToDepthBuffer:";
		static readonly NativeHandle selSetWritesToDepthBuffer_XHandle = Selector.GetHandle ("setWritesToDepthBuffer:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selShaderModifiersX = "shaderModifiers";
		static readonly NativeHandle selShaderModifiersXHandle = Selector.GetHandle ("shaderModifiers");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selShininessX = "shininess";
		static readonly NativeHandle selShininessXHandle = Selector.GetHandle ("shininess");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSpecularX = "specular";
		static readonly NativeHandle selSpecularXHandle = Selector.GetHandle ("specular");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTransparencyX = "transparency";
		static readonly NativeHandle selTransparencyXHandle = Selector.GetHandle ("transparency");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTransparencyModeX = "transparencyMode";
		static readonly NativeHandle selTransparencyModeXHandle = Selector.GetHandle ("transparencyMode");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTransparentX = "transparent";
		static readonly NativeHandle selTransparentXHandle = Selector.GetHandle ("transparent");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selWritesToDepthBufferX = "writesToDepthBuffer";
		static readonly NativeHandle selWritesToDepthBufferXHandle = Selector.GetHandle ("writesToDepthBuffer");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("SCNMaterial");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		/// <summary>Creates a new <see cref="SCNMaterial" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public SCNMaterial () : base (NSObjectFlag.Empty)
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
		public SCNMaterial (NSCoder coder) : base (NSObjectFlag.Empty)
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
		protected SCNMaterial (NSObjectFlag t) : base (t)
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
		protected internal SCNMaterial (NativeHandle handle) : base (handle)
		{
		}

		/// <summary>Adds <paramref name="scnAnimation" />, identified with the specified <paramref name="key" />.</summary><param name="scnAnimation">The animation to add.</param><param name="key">The animation key.</param><remarks><para>The following example shows how a rotation animation can be added to a <see cref="T:SceneKit.SCNGeometry" /> object:</para><example><code lang="csharp lang-csharp"><![CDATA[
		/// var animation = new CABasicAnimation ();
		/// animation.KeyPath = "rotation";
		/// var v = new SCNVector4 (1.0f, 1.0f, 0.0f, (float) (Math.PI * 2.0));
		/// animation.To = NSValue.FromVector (v);
		/// animation.Duration = 5.0f;
		/// animation.RepeatCount = float.MaxValue; //repeat forever
		/// animatableObject.AddAnimation (animation, (NSString) "rotation");
		/// ]]></code></example></remarks>
		[Export ("addAnimation:forKey:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AddAnimation (ISCNAnimationProtocol scnAnimation, string? key)
		{
			var scnAnimation__handle__ = scnAnimation!.GetNonNullHandle (nameof (scnAnimation));
			var nskey = CFString.CreateNative (key);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selAddAnimation_ForKey_XHandle, scnAnimation__handle__, nskey);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selAddAnimation_ForKey_XHandle, scnAnimation__handle__, nskey);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (scnAnimation);
			CFString.ReleaseNative (nskey);
		}
		[Export ("addAnimationPlayer:forKey:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AddAnimation (SCNAnimationPlayer player, NSString? key)
		{
			var player__handle__ = player!.GetNonNullHandle (nameof (player));
			var key__handle__ = key.GetHandle ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selAddAnimationPlayer_ForKey_XHandle, player__handle__, key__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selAddAnimationPlayer_ForKey_XHandle, player__handle__, key__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (player);
			GC.KeepAlive (key);
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
		[Export ("material")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SCNMaterial Create ()
		{
			SCNMaterial ret;
			ret =  Runtime.GetNSObject<SCNMaterial> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selMaterialXHandle), false)!;
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
		[Export ("materialWithMDLMaterial:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SCNMaterial FromMaterial (global::ModelIO.MDLMaterial material)
		{
			var material__handle__ = material!.GetNonNullHandle (nameof (material));
			SCNMaterial? ret;
			ret =  Runtime.GetNSObject<SCNMaterial> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, selMaterialWithMDLMaterial_XHandle, material__handle__), false)!;
			GC.KeepAlive (material);
			return ret!;
		}
		/// <param name="key">To be added.</param><summary>Developers should not use this deprecated method. Developers should use 'GetAnimationPlayer' instead.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("animationForKey:")]
		[ObsoletedOSPlatform ("tvos11.0", "Use 'GetAnimationPlayer' instead.")]
		[ObsoletedOSPlatform ("ios11.0", "Use 'GetAnimationPlayer' instead.")]
		[ObsoletedOSPlatform ("macos10.13", "Use 'GetAnimationPlayer' instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'GetAnimationPlayer' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::CoreAnimation.CAAnimation? GetAnimation (NSString key)
		{
			var key__handle__ = key!.GetNonNullHandle (nameof (key));
			global::CoreAnimation.CAAnimation? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<global::CoreAnimation.CAAnimation> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selAnimationForKey_XHandle, key__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<global::CoreAnimation.CAAnimation> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selAnimationForKey_XHandle, key__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (key);
			return ret!;
		}
		/// <summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("animationKeys")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSString[] GetAnimationKeys ()
		{
			NSString[] ret;
			if (IsDirectBinding) {
				ret = CFArray.ArrayFromHandle<NSString>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selAnimationKeysXHandle), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFArray.ArrayFromHandle<NSString>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selAnimationKeysXHandle), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("animationPlayerForKey:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual SCNAnimationPlayer? GetAnimationPlayer (NSString key)
		{
			var key__handle__ = key!.GetNonNullHandle (nameof (key));
			SCNAnimationPlayer? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<SCNAnimationPlayer> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selAnimationPlayerForKey_XHandle, key__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<SCNAnimationPlayer> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selAnimationPlayerForKey_XHandle, key__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (key);
			return ret!;
		}
		/// <param name="symbol">To be added.</param><param name="handler">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("handleBindingOfSymbol:usingBlock:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void HandleBinding (string symbol, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDSCNBindingHandler))]SCNBindingHandler? handler)
		{
			if (symbol is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (symbol));
			var nssymbol = CFString.CreateNative (symbol);
			using var block_handler = Trampolines.SDSCNBindingHandler.CreateNullableBlock (handler);
			BlockLiteral *block_ptr_handler = null;
			if (handler is not null)
				block_ptr_handler = &block_handler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selHandleBindingOfSymbol_UsingBlock_XHandle, nssymbol, (IntPtr) block_ptr_handler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selHandleBindingOfSymbol_UsingBlock_XHandle, nssymbol, (IntPtr) block_ptr_handler);
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nssymbol);
		}
		/// <param name="symbol">To be added.</param><param name="handler">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("handleUnbindingOfSymbol:usingBlock:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void HandleUnbinding (string symbol, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDSCNBindingHandler))]SCNBindingHandler? handler)
		{
			if (symbol is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (symbol));
			var nssymbol = CFString.CreateNative (symbol);
			using var block_handler = Trampolines.SDSCNBindingHandler.CreateNullableBlock (handler);
			BlockLiteral *block_ptr_handler = null;
			if (handler is not null)
				block_ptr_handler = &block_handler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selHandleUnbindingOfSymbol_UsingBlock_XHandle, nssymbol, (IntPtr) block_ptr_handler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selHandleUnbindingOfSymbol_UsingBlock_XHandle, nssymbol, (IntPtr) block_ptr_handler);
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nssymbol);
		}
		/// <param name="key">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("isAnimationForKeyPaused:")]
		[ObsoletedOSPlatform ("tvos11.0", "Use 'SCNAnimationPlayer.Paused' instead.")]
		[ObsoletedOSPlatform ("ios11.0", "Use 'SCNAnimationPlayer.Paused' instead.")]
		[ObsoletedOSPlatform ("macos10.13", "Use 'SCNAnimationPlayer.Paused' instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'SCNAnimationPlayer.Paused' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool IsAnimationPaused (NSString key)
		{
			var key__handle__ = key!.GetNonNullHandle (nameof (key));
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (this.Handle, selIsAnimationForKeyPaused_XHandle, key__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle (&__objc_super__, selIsAnimationForKeyPaused_XHandle, key__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (key);
			return ret != 0;
		}
		/// <param name="key">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("pauseAnimationForKey:")]
		[ObsoletedOSPlatform ("tvos11.0", "Use 'SCNAnimationPlayer.Paused' instead.")]
		[ObsoletedOSPlatform ("ios11.0", "Use 'SCNAnimationPlayer.Paused' instead.")]
		[ObsoletedOSPlatform ("macos10.13", "Use 'SCNAnimationPlayer.Paused' instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'SCNAnimationPlayer.Paused' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PauseAnimation (NSString key)
		{
			var key__handle__ = key!.GetNonNullHandle (nameof (key));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selPauseAnimationForKey_XHandle, key__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selPauseAnimationForKey_XHandle, key__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (key);
		}
		/// <summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("removeAllAnimations")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemoveAllAnimations ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selRemoveAllAnimationsXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selRemoveAllAnimationsXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("removeAllAnimationsWithBlendOutDuration:")]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemoveAllAnimationsWithBlendOutDuration (nfloat duration)
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_nfloat (this.Handle, selRemoveAllAnimationsWithBlendOutDuration_XHandle, duration);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_nfloat (&__objc_super__, selRemoveAllAnimationsWithBlendOutDuration_XHandle, duration);
					GC.KeepAlive (this);
				}
			}
		}
		/// <param name="key">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("removeAnimationForKey:")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemoveAnimation (NSString key)
		{
			var key__handle__ = key!.GetNonNullHandle (nameof (key));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selRemoveAnimationForKey_XHandle, key__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selRemoveAnimationForKey_XHandle, key__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (key);
		}
		/// <param name="key">To be added.</param><param name="duration">To be added.</param><summary>Deprecated. Developers should use <see cref="M:SceneKit.SCNAnimatable.RemoveAnimationUsingBlendOutDuration(Foundation.NSString,System.Runtime.InteropServices.NFloat)" />.</summary><remarks>To be added.</remarks>
		[Export ("removeAnimationForKey:fadeOutDuration:")]
		[ObsoletedOSPlatform ("tvos11.0", "Use 'RemoveAnimationUsingBlendOutDuration' instead.")]
		[ObsoletedOSPlatform ("ios11.0", "Use 'RemoveAnimationUsingBlendOutDuration' instead.")]
		[ObsoletedOSPlatform ("macos10.13", "Use 'RemoveAnimationUsingBlendOutDuration' instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'RemoveAnimationUsingBlendOutDuration' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemoveAnimation (NSString key, nfloat duration)
		{
			var key__handle__ = key!.GetNonNullHandle (nameof (key));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_nfloat (this.Handle, selRemoveAnimationForKey_FadeOutDuration_XHandle, key__handle__, duration);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_nfloat (&__objc_super__, selRemoveAnimationForKey_FadeOutDuration_XHandle, key__handle__, duration);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (key);
		}
		/// <param name="key">The key for the animation to remove.</param><param name="blendOutDuration">The duration, in seconds, over which to blend the animation out.</param><summary>Removes the specified animation, blending it out over the specified duration.</summary><remarks>To be added.</remarks>
		[Export ("removeAnimationForKey:blendOutDuration:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemoveAnimationUsingBlendOutDuration (NSString key, nfloat blendOutDuration)
		{
			var key__handle__ = key!.GetNonNullHandle (nameof (key));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_nfloat (this.Handle, selRemoveAnimationForKey_BlendOutDuration_XHandle, key__handle__, blendOutDuration);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_nfloat (&__objc_super__, selRemoveAnimationForKey_BlendOutDuration_XHandle, key__handle__, blendOutDuration);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (key);
		}
		/// <param name="key">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("resumeAnimationForKey:")]
		[ObsoletedOSPlatform ("tvos11.0", "Use 'SCNAnimationPlayer.Paused' instead.")]
		[ObsoletedOSPlatform ("ios11.0", "Use 'SCNAnimationPlayer.Paused' instead.")]
		[ObsoletedOSPlatform ("macos10.13", "Use 'SCNAnimationPlayer.Paused' instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'SCNAnimationPlayer.Paused' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ResumeAnimation (NSString key)
		{
			var key__handle__ = key!.GetNonNullHandle (nameof (key));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selResumeAnimationForKey_XHandle, key__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selResumeAnimationForKey_XHandle, key__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (key);
		}
		/// <param name="speed">To be added.</param><param name="key">To be added.</param><summary>Deprecated. Developers should use <see cref="P:SceneKit.SCNAnimationPlayer.Speed" />, instead.</summary><remarks>To be added.</remarks>
		[Export ("setSpeed:forAnimationKey:")]
		[ObsoletedOSPlatform ("tvos11.0", "Use 'SCNAnimationPlayer.Speed' instead.")]
		[ObsoletedOSPlatform ("ios11.0", "Use 'SCNAnimationPlayer.Speed' instead.")]
		[ObsoletedOSPlatform ("macos10.13", "Use 'SCNAnimationPlayer.Speed' instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'SCNAnimationPlayer.Speed' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetSpeed (nfloat speed, NSString key)
		{
			var key__handle__ = key!.GetNonNullHandle (nameof (key));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_nfloat_NativeHandle (this.Handle, selSetSpeed_ForAnimationKey_XHandle, speed, key__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_nfloat_NativeHandle (&__objc_super__, selSetSpeed_ForAnimationKey_XHandle, speed, key__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (key);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual SCNMaterialProperty Ambient {
			[Export ("ambient")]
			get {
				SCNMaterialProperty? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<SCNMaterialProperty> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selAmbientXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<SCNMaterialProperty> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selAmbientXHandle), false)!;
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
		public virtual SCNMaterialProperty AmbientOcclusion {
			[Export ("ambientOcclusion")]
			get {
				SCNMaterialProperty? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<SCNMaterialProperty> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selAmbientOcclusionXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<SCNMaterialProperty> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selAmbientOcclusionXHandle), false)!;
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
		public virtual SCNBlendMode BlendMode {
			[Export ("blendMode", ArgumentSemantic.Assign)]
			get {
				SCNBlendMode ret;
				if (IsDirectBinding) {
					ret = (SCNBlendMode) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selBlendModeXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (SCNBlendMode) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selBlendModeXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setBlendMode:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetBlendMode_XHandle, (IntPtr) (long) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, selSetBlendMode_XHandle, (IntPtr) (long) value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public virtual SCNMaterialProperty ClearCoat {
			[Export ("clearCoat")]
			get {
				SCNMaterialProperty? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<SCNMaterialProperty> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selClearCoatXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<SCNMaterialProperty> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selClearCoatXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public virtual SCNMaterialProperty ClearCoatNormal {
			[Export ("clearCoatNormal")]
			get {
				SCNMaterialProperty? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<SCNMaterialProperty> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selClearCoatNormalXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<SCNMaterialProperty> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selClearCoatNormalXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public virtual SCNMaterialProperty ClearCoatRoughness {
			[Export ("clearCoatRoughness")]
			get {
				SCNMaterialProperty? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<SCNMaterialProperty> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selClearCoatRoughnessXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<SCNMaterialProperty> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selClearCoatRoughnessXHandle), false)!;
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
		public virtual SCNColorMask ColorBufferWriteMask {
			[Export ("colorBufferWriteMask", ArgumentSemantic.Assign)]
			get {
				SCNColorMask ret;
				if (IsDirectBinding) {
					ret = (SCNColorMask) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selColorBufferWriteMaskXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (SCNColorMask) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selColorBufferWriteMaskXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setColorBufferWriteMask:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetColorBufferWriteMask_XHandle, (IntPtr) (long) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, selSetColorBufferWriteMask_XHandle, (IntPtr) (long) value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual SCNCullMode CullMode {
			[Export ("cullMode")]
			get {
				SCNCullMode ret;
				if (IsDirectBinding) {
					ret = (SCNCullMode) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selCullModeXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (SCNCullMode) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selCullModeXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setCullMode:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetCullMode_XHandle, (IntPtr) (long) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, selSetCullMode_XHandle, (IntPtr) (long) value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual SCNMaterialProperty Diffuse {
			[Export ("diffuse")]
			get {
				SCNMaterialProperty? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<SCNMaterialProperty> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selDiffuseXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<SCNMaterialProperty> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selDiffuseXHandle), false)!;
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
		public virtual SCNMaterialProperty Displacement {
			[Export ("displacement")]
			get {
				SCNMaterialProperty? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<SCNMaterialProperty> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selDisplacementXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<SCNMaterialProperty> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selDisplacementXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		/// <summary>Gets or sets a value that controls whether both faces of a surface should be rendered. Default is <see langword="false" />.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool DoubleSided {
			[Export ("isDoubleSided")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsDoubleSidedXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsDoubleSidedXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setDoubleSided:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetDoubleSided_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetDoubleSided_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual SCNMaterialProperty Emission {
			[Export ("emission")]
			get {
				SCNMaterialProperty? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<SCNMaterialProperty> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selEmissionXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<SCNMaterialProperty> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selEmissionXHandle), false)!;
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
		public virtual SCNFillMode FillMode {
			[Export ("fillMode", ArgumentSemantic.Assign)]
			get {
				SCNFillMode ret;
				if (IsDirectBinding) {
					ret = (SCNFillMode) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selFillModeXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (SCNFillMode) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selFillModeXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setFillMode:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (this.Handle, selSetFillMode_XHandle, (UIntPtr) (ulong) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UIntPtr (&__objc_super__, selSetFillMode_XHandle, (UIntPtr) (ulong) value);
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
		public virtual nfloat FresnelExponent {
			[Export ("fresnelExponent")]
			get {
				nfloat ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend (this.Handle, selFresnelExponentXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSendSuper (&__objc_super__, selFresnelExponentXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setFresnelExponent:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_nfloat (this.Handle, selSetFresnelExponent_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_nfloat (&__objc_super__, selSetFresnelExponent_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSString LightingModelName {
			[Export ("lightingModelName", ArgumentSemantic.Copy)]
			get {
				NSString? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selLightingModelNameXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selLightingModelNameXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setLightingModelName:", ArgumentSemantic.Copy)]
			set {
				var value__handle__ = value!.GetNonNullHandle (nameof (value));
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetLightingModelName_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetLightingModelName_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		/// <summary>Gets or sets a value that controls whether lighting is performed on a per-pixel or per-vertex basis.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool LitPerPixel {
			[Export ("isLitPerPixel")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsLitPerPixelXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsLitPerPixelXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setLitPerPixel:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetLitPerPixel_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetLitPerPixel_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool LocksAmbientWithDiffuse {
			[Export ("locksAmbientWithDiffuse")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selLocksAmbientWithDiffuseXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selLocksAmbientWithDiffuseXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setLocksAmbientWithDiffuse:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetLocksAmbientWithDiffuse_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetLocksAmbientWithDiffuse_XHandle, value ? (byte) 1 : (byte) 0);
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
		public virtual SCNMaterialProperty Metalness {
			[Export ("metalness")]
			get {
				SCNMaterialProperty? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<SCNMaterialProperty> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selMetalnessXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<SCNMaterialProperty> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selMetalnessXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public virtual NSNumber? MinimumLanguageVersion {
			[Export ("minimumLanguageVersion", ArgumentSemantic.Retain)]
			[SupportedOSPlatform ("ios15.0")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos15.0")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				NSNumber? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSNumber> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selMinimumLanguageVersionXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSNumber> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selMinimumLanguageVersionXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setMinimumLanguageVersion:", ArgumentSemantic.Retain)]
			[SupportedOSPlatform ("ios15.0")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos15.0")]
			[SupportedOSPlatform ("maccatalyst")]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetMinimumLanguageVersion_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetMinimumLanguageVersion_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual SCNMaterialProperty Multiply {
			[Export ("multiply")]
			get {
				SCNMaterialProperty? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<SCNMaterialProperty> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selMultiplyXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<SCNMaterialProperty> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selMultiplyXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
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
		public virtual SCNMaterialProperty Normal {
			[Export ("normal")]
			get {
				SCNMaterialProperty? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<SCNMaterialProperty> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selNormalXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<SCNMaterialProperty> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selNormalXHandle), false)!;
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
		public virtual SCNProgram? Program {
			[Export ("program", ArgumentSemantic.Retain)]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				SCNProgram? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<SCNProgram> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selProgramXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<SCNProgram> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selProgramXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setProgram:", ArgumentSemantic.Retain)]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetProgram_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetProgram_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual bool ReadsFromDepthBuffer {
			[Export ("readsFromDepthBuffer")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selReadsFromDepthBufferXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selReadsFromDepthBufferXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setReadsFromDepthBuffer:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetReadsFromDepthBuffer_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetReadsFromDepthBuffer_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual SCNMaterialProperty Reflective {
			[Export ("reflective")]
			get {
				SCNMaterialProperty? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<SCNMaterialProperty> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selReflectiveXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<SCNMaterialProperty> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selReflectiveXHandle), false)!;
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
		public virtual SCNMaterialProperty Roughness {
			[Export ("roughness")]
			get {
				SCNMaterialProperty? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<SCNMaterialProperty> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selRoughnessXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<SCNMaterialProperty> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selRoughnessXHandle), false)!;
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
		public virtual SCNMaterialProperty SelfIllumination {
			[Export ("selfIllumination")]
			get {
				SCNMaterialProperty? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<SCNMaterialProperty> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selSelfIlluminationXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<SCNMaterialProperty> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selSelfIlluminationXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		/// <summary>To be added.</summary><value><para>(More documentation for this node is coming)</para><para tool="nullallowed">This value can be <see langword="null" />.</para></value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public SCNShaderModifiers? ShaderModifiers {
			get {
				var src = WeakShaderModifiers is not null ? new NSMutableDictionary (WeakShaderModifiers) : null;
				return src is null ? null! : new SCNShaderModifiers(src);
			}
			set {
				WeakShaderModifiers = value.GetDictionary ()!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nfloat Shininess {
			[Export ("shininess")]
			get {
				nfloat ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend (this.Handle, selShininessXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSendSuper (&__objc_super__, selShininessXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setShininess:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_nfloat (this.Handle, selSetShininess_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_nfloat (&__objc_super__, selSetShininess_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual SCNMaterialProperty Specular {
			[Export ("specular")]
			get {
				SCNMaterialProperty? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<SCNMaterialProperty> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selSpecularXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<SCNMaterialProperty> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selSpecularXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nfloat Transparency {
			[Export ("transparency")]
			get {
				nfloat ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend (this.Handle, selTransparencyXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSendSuper (&__objc_super__, selTransparencyXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setTransparency:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_nfloat (this.Handle, selSetTransparency_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_nfloat (&__objc_super__, selSetTransparency_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual SCNTransparencyMode TransparencyMode {
			[Export ("transparencyMode")]
			get {
				SCNTransparencyMode ret;
				if (IsDirectBinding) {
					ret = (SCNTransparencyMode) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selTransparencyModeXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (SCNTransparencyMode) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selTransparencyModeXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setTransparencyMode:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetTransparencyMode_XHandle, (IntPtr) (long) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, selSetTransparencyMode_XHandle, (IntPtr) (long) value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual SCNMaterialProperty Transparent {
			[Export ("transparent")]
			get {
				SCNMaterialProperty? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<SCNMaterialProperty> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selTransparentXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<SCNMaterialProperty> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selTransparentXHandle), false)!;
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
		public virtual NSDictionary? WeakShaderModifiers {
			[Export ("shaderModifiers", ArgumentSemantic.Copy)]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				NSDictionary? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDictionary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selShaderModifiersXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSDictionary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selShaderModifiersXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setShaderModifiers:", ArgumentSemantic.Copy)]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetShaderModifiers_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetShaderModifiers_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool WritesToDepthBuffer {
			[Export ("writesToDepthBuffer")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selWritesToDepthBufferXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selWritesToDepthBufferXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setWritesToDepthBuffer:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetWritesToDepthBuffer_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetWritesToDepthBuffer_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
	} /* class SCNMaterial */
}
