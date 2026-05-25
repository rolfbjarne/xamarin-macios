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
namespace GameplayKit {
	/// <summary>Uses a <see cref="T:GameplayKit.GKNoiseSource" /> to procedurally generate an infinite three-dimensional noise field.</summary>
	[Register("GKNoise", true)]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe partial class GKNoise : NSObject {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAddWithNoise_X = "addWithNoise:";
		static readonly NativeHandle selAddWithNoise_XHandle = Selector.GetHandle ("addWithNoise:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selApplyAbsoluteValueX = "applyAbsoluteValue";
		static readonly NativeHandle selApplyAbsoluteValueXHandle = Selector.GetHandle ("applyAbsoluteValue");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selApplyTurbulenceWithFrequency_Power_Roughness_Seed_X = "applyTurbulenceWithFrequency:power:roughness:seed:";
		static readonly NativeHandle selApplyTurbulenceWithFrequency_Power_Roughness_Seed_XHandle = Selector.GetHandle ("applyTurbulenceWithFrequency:power:roughness:seed:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selClampWithLowerBound_UpperBound_X = "clampWithLowerBound:upperBound:";
		static readonly NativeHandle selClampWithLowerBound_UpperBound_XHandle = Selector.GetHandle ("clampWithLowerBound:upperBound:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDisplaceXWithNoise_YWithNoise_ZWithNoise_X = "displaceXWithNoise:yWithNoise:zWithNoise:";
		static readonly NativeHandle selDisplaceXWithNoise_YWithNoise_ZWithNoise_XHandle = Selector.GetHandle ("displaceXWithNoise:yWithNoise:zWithNoise:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selGradientColorsX = "gradientColors";
		static readonly NativeHandle selGradientColorsXHandle = Selector.GetHandle ("gradientColors");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithNoiseSource_X = "initWithNoiseSource:";
		static readonly NativeHandle selInitWithNoiseSource_XHandle = Selector.GetHandle ("initWithNoiseSource:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithNoiseSource_GradientColors_X = "initWithNoiseSource:gradientColors:";
		static readonly NativeHandle selInitWithNoiseSource_GradientColors_XHandle = Selector.GetHandle ("initWithNoiseSource:gradientColors:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInvertX = "invert";
		static readonly NativeHandle selInvertXHandle = Selector.GetHandle ("invert");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMaximumWithNoise_X = "maximumWithNoise:";
		static readonly NativeHandle selMaximumWithNoise_XHandle = Selector.GetHandle ("maximumWithNoise:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMinimumWithNoise_X = "minimumWithNoise:";
		static readonly NativeHandle selMinimumWithNoise_XHandle = Selector.GetHandle ("minimumWithNoise:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMoveBy_X = "moveBy:";
		static readonly NativeHandle selMoveBy_XHandle = Selector.GetHandle ("moveBy:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMultiplyWithNoise_X = "multiplyWithNoise:";
		static readonly NativeHandle selMultiplyWithNoise_XHandle = Selector.GetHandle ("multiplyWithNoise:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selNoiseWithComponentNoises_SelectionNoise_X = "noiseWithComponentNoises:selectionNoise:";
		static readonly NativeHandle selNoiseWithComponentNoises_SelectionNoise_XHandle = Selector.GetHandle ("noiseWithComponentNoises:selectionNoise:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selNoiseWithComponentNoises_SelectionNoise_ComponentBoundaries_BoundaryBlendDistances_X = "noiseWithComponentNoises:selectionNoise:componentBoundaries:boundaryBlendDistances:";
		static readonly NativeHandle selNoiseWithComponentNoises_SelectionNoise_ComponentBoundaries_BoundaryBlendDistances_XHandle = Selector.GetHandle ("noiseWithComponentNoises:selectionNoise:componentBoundaries:boundaryBlendDistances:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selNoiseWithNoiseSource_X = "noiseWithNoiseSource:";
		static readonly NativeHandle selNoiseWithNoiseSource_XHandle = Selector.GetHandle ("noiseWithNoiseSource:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selNoiseWithNoiseSource_GradientColors_X = "noiseWithNoiseSource:gradientColors:";
		static readonly NativeHandle selNoiseWithNoiseSource_GradientColors_XHandle = Selector.GetHandle ("noiseWithNoiseSource:gradientColors:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRaiseToPower_X = "raiseToPower:";
		static readonly NativeHandle selRaiseToPower_XHandle = Selector.GetHandle ("raiseToPower:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRaiseToPowerWithNoise_X = "raiseToPowerWithNoise:";
		static readonly NativeHandle selRaiseToPowerWithNoise_XHandle = Selector.GetHandle ("raiseToPowerWithNoise:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRemapValuesToCurveWithControlPoints_X = "remapValuesToCurveWithControlPoints:";
		static readonly NativeHandle selRemapValuesToCurveWithControlPoints_XHandle = Selector.GetHandle ("remapValuesToCurveWithControlPoints:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRemapValuesToTerracesWithPeaks_TerracesInverted_X = "remapValuesToTerracesWithPeaks:terracesInverted:";
		static readonly NativeHandle selRemapValuesToTerracesWithPeaks_TerracesInverted_XHandle = Selector.GetHandle ("remapValuesToTerracesWithPeaks:terracesInverted:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRotateBy_X = "rotateBy:";
		static readonly NativeHandle selRotateBy_XHandle = Selector.GetHandle ("rotateBy:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selScaleBy_X = "scaleBy:";
		static readonly NativeHandle selScaleBy_XHandle = Selector.GetHandle ("scaleBy:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetGradientColors_X = "setGradientColors:";
		static readonly NativeHandle selSetGradientColors_XHandle = Selector.GetHandle ("setGradientColors:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selValueAtPosition_X = "valueAtPosition:";
		static readonly NativeHandle selValueAtPosition_XHandle = Selector.GetHandle ("valueAtPosition:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("GKNoise");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		/// <summary>Creates a new <see cref="GKNoise" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public GKNoise () : base (NSObjectFlag.Empty)
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
		protected GKNoise (NSObjectFlag t) : base (t)
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
		protected internal GKNoise (NativeHandle handle) : base (handle)
		{
		}

		[Export ("initWithNoiseSource:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public GKNoise (GKNoiseSource noiseSource)
			: base (NSObjectFlag.Empty)
		{
			var noiseSource__handle__ = noiseSource!.GetNonNullHandle (nameof (noiseSource));
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selInitWithNoiseSource_XHandle, noiseSource__handle__), "initWithNoiseSource:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selInitWithNoiseSource_XHandle, noiseSource__handle__), "initWithNoiseSource:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (noiseSource);
		}
		[Export ("initWithNoiseSource:gradientColors:")]
		[DesignatedInitializer]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public GKNoise (GKNoiseSource noiseSource, NSDictionary<NSNumber, global::AppKit.NSColor> gradientColors)
			: base (NSObjectFlag.Empty)
		{
			var noiseSource__handle__ = noiseSource!.GetNonNullHandle (nameof (noiseSource));
			var gradientColors__handle__ = gradientColors!.GetNonNullHandle (nameof (gradientColors));
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selInitWithNoiseSource_GradientColors_XHandle, noiseSource__handle__, gradientColors__handle__), "initWithNoiseSource:gradientColors:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selInitWithNoiseSource_GradientColors_XHandle, noiseSource__handle__, gradientColors__handle__), "initWithNoiseSource:gradientColors:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (noiseSource);
			GC.KeepAlive (gradientColors);
		}
		[Export ("addWithNoise:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Add (GKNoise noise)
		{
			var noise__handle__ = noise!.GetNonNullHandle (nameof (noise));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selAddWithNoise_XHandle, noise__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selAddWithNoise_XHandle, noise__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (noise);
		}
		[Export ("applyAbsoluteValue")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ApplyAbsoluteValue ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selApplyAbsoluteValueXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selApplyAbsoluteValueXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("applyTurbulenceWithFrequency:power:roughness:seed:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ApplyTurbulence (double frequency, double power, int roughness, int seed)
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_Double_Double_int_int (this.Handle, selApplyTurbulenceWithFrequency_Power_Roughness_Seed_XHandle, frequency, power, roughness, seed);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_Double_Double_int_int (&__objc_super__, selApplyTurbulenceWithFrequency_Power_Roughness_Seed_XHandle, frequency, power, roughness, seed);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("clampWithLowerBound:upperBound:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Clamp (double lowerBound, double upperBound)
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_Double_Double (this.Handle, selClampWithLowerBound_UpperBound_XHandle, lowerBound, upperBound);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_Double_Double (&__objc_super__, selClampWithLowerBound_UpperBound_XHandle, lowerBound, upperBound);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("displaceXWithNoise:yWithNoise:zWithNoise:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Displace (GKNoise xDisplacementNoise, GKNoise yDisplacementNoise, GKNoise zDisplacementNoise)
		{
			var xDisplacementNoise__handle__ = xDisplacementNoise!.GetNonNullHandle (nameof (xDisplacementNoise));
			var yDisplacementNoise__handle__ = yDisplacementNoise!.GetNonNullHandle (nameof (yDisplacementNoise));
			var zDisplacementNoise__handle__ = zDisplacementNoise!.GetNonNullHandle (nameof (zDisplacementNoise));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, selDisplaceXWithNoise_YWithNoise_ZWithNoise_XHandle, xDisplacementNoise__handle__, yDisplacementNoise__handle__, zDisplacementNoise__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, selDisplaceXWithNoise_YWithNoise_ZWithNoise_XHandle, xDisplacementNoise__handle__, yDisplacementNoise__handle__, zDisplacementNoise__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (xDisplacementNoise);
			GC.KeepAlive (yDisplacementNoise);
			GC.KeepAlive (zDisplacementNoise);
		}
		[Export ("noiseWithComponentNoises:selectionNoise:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static GKNoise FromComponentNoises (GKNoise[] noises, GKNoise selectionNoise)
		{
			if (noises is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (noises));
			var selectionNoise__handle__ = selectionNoise!.GetNonNullHandle (nameof (selectionNoise));
			using var nsa_noises = NSArray.FromNSObjects (noises);
			GKNoise? ret;
			ret =  Runtime.GetNSObject<GKNoise> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (class_ptr, selNoiseWithComponentNoises_SelectionNoise_XHandle, nsa_noises.Handle, selectionNoise__handle__), false)!;
			GC.KeepAlive (selectionNoise);
			return ret!;
		}
		[Export ("noiseWithComponentNoises:selectionNoise:componentBoundaries:boundaryBlendDistances:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static GKNoise FromComponentNoises (GKNoise[] noises, GKNoise selectionNoise, NSNumber[] componentBoundaries, NSNumber[] blendDistances)
		{
			if (noises is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (noises));
			var selectionNoise__handle__ = selectionNoise!.GetNonNullHandle (nameof (selectionNoise));
			if (componentBoundaries is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (componentBoundaries));
			if (blendDistances is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (blendDistances));
			using var nsa_noises = NSArray.FromNSObjects (noises);
			using var nsa_componentBoundaries = NSArray.FromNSObjects (componentBoundaries);
			using var nsa_blendDistances = NSArray.FromNSObjects (blendDistances);
			GKNoise? ret;
			ret =  Runtime.GetNSObject<GKNoise> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (class_ptr, selNoiseWithComponentNoises_SelectionNoise_ComponentBoundaries_BoundaryBlendDistances_XHandle, nsa_noises.Handle, selectionNoise__handle__, nsa_componentBoundaries.Handle, nsa_blendDistances.Handle), false)!;
			GC.KeepAlive (selectionNoise);
			return ret!;
		}
		[Export ("noiseWithNoiseSource:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static GKNoise FromNoiseSource (GKNoiseSource noiseSource)
		{
			var noiseSource__handle__ = noiseSource!.GetNonNullHandle (nameof (noiseSource));
			GKNoise? ret;
			ret =  Runtime.GetNSObject<GKNoise> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, selNoiseWithNoiseSource_XHandle, noiseSource__handle__), false)!;
			GC.KeepAlive (noiseSource);
			return ret!;
		}
		[Export ("noiseWithNoiseSource:gradientColors:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static GKNoise FromNoiseSource (GKNoiseSource noiseSource, NSDictionary<NSNumber, global::AppKit.NSColor> gradientColors)
		{
			var noiseSource__handle__ = noiseSource!.GetNonNullHandle (nameof (noiseSource));
			var gradientColors__handle__ = gradientColors!.GetNonNullHandle (nameof (gradientColors));
			GKNoise? ret;
			ret =  Runtime.GetNSObject<GKNoise> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (class_ptr, selNoiseWithNoiseSource_GradientColors_XHandle, noiseSource__handle__, gradientColors__handle__), false)!;
			GC.KeepAlive (noiseSource);
			GC.KeepAlive (gradientColors);
			return ret!;
		}
		[Export ("maximumWithNoise:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void GetMaximum (GKNoise noise)
		{
			var noise__handle__ = noise!.GetNonNullHandle (nameof (noise));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selMaximumWithNoise_XHandle, noise__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selMaximumWithNoise_XHandle, noise__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (noise);
		}
		[Export ("minimumWithNoise:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void GetMinimum (GKNoise noise)
		{
			var noise__handle__ = noise!.GetNonNullHandle (nameof (noise));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selMinimumWithNoise_XHandle, noise__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selMinimumWithNoise_XHandle, noise__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (noise);
		}
		[Export ("valueAtPosition:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual float GetValue (global::System.Numerics.Vector2 position)
		{
			float ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.xamarin_simd__float_objc_msgSend_Vector2 (this.Handle, selValueAtPosition_XHandle, position);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.xamarin_simd__float_objc_msgSendSuper_Vector2 (&__objc_super__, selValueAtPosition_XHandle, position);
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("invert")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Invert ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selInvertXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selInvertXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("moveBy:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Move (NVector3d delta)
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.xamarin_simd__void_objc_msgSend_NVector3d (this.Handle, selMoveBy_XHandle, delta);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.xamarin_simd__void_objc_msgSendSuper_NVector3d (&__objc_super__, selMoveBy_XHandle, delta);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("multiplyWithNoise:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Multiply (GKNoise noise)
		{
			var noise__handle__ = noise!.GetNonNullHandle (nameof (noise));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selMultiplyWithNoise_XHandle, noise__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selMultiplyWithNoise_XHandle, noise__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (noise);
		}
		[Export ("raiseToPower:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RaiseToPower (double power)
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_Double (this.Handle, selRaiseToPower_XHandle, power);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_Double (&__objc_super__, selRaiseToPower_XHandle, power);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("raiseToPowerWithNoise:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RaiseToPower (GKNoise noise)
		{
			var noise__handle__ = noise!.GetNonNullHandle (nameof (noise));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selRaiseToPowerWithNoise_XHandle, noise__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selRaiseToPowerWithNoise_XHandle, noise__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (noise);
		}
		[Export ("remapValuesToCurveWithControlPoints:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemapValuesToCurve (NSDictionary<NSNumber, NSNumber> controlPoints)
		{
			var controlPoints__handle__ = controlPoints!.GetNonNullHandle (nameof (controlPoints));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selRemapValuesToCurveWithControlPoints_XHandle, controlPoints__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selRemapValuesToCurveWithControlPoints_XHandle, controlPoints__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (controlPoints);
		}
		[Export ("remapValuesToTerracesWithPeaks:terracesInverted:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemapValuesToTerraces (NSNumber[] peakInputValues, bool inverted)
		{
			if (peakInputValues is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (peakInputValues));
			using var nsa_peakInputValues = NSArray.FromNSObjects (peakInputValues);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_bool (this.Handle, selRemapValuesToTerracesWithPeaks_TerracesInverted_XHandle, nsa_peakInputValues.Handle, inverted ? (byte) 1 : (byte) 0);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_bool (&__objc_super__, selRemapValuesToTerracesWithPeaks_TerracesInverted_XHandle, nsa_peakInputValues.Handle, inverted ? (byte) 1 : (byte) 0);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("rotateBy:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Rotate (NVector3d radians)
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.xamarin_simd__void_objc_msgSend_NVector3d (this.Handle, selRotateBy_XHandle, radians);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.xamarin_simd__void_objc_msgSendSuper_NVector3d (&__objc_super__, selRotateBy_XHandle, radians);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("scaleBy:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Scale (NVector3d factor)
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.xamarin_simd__void_objc_msgSend_NVector3d (this.Handle, selScaleBy_XHandle, factor);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.xamarin_simd__void_objc_msgSendSuper_NVector3d (&__objc_super__, selScaleBy_XHandle, factor);
					GC.KeepAlive (this);
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDictionary<NSNumber, global::AppKit.NSColor> GradientColors {
			[Export ("gradientColors", ArgumentSemantic.Copy)]
			get {
				NSDictionary<NSNumber, global::AppKit.NSColor>? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDictionary<NSNumber, global::AppKit.NSColor>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selGradientColorsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSDictionary<NSNumber, global::AppKit.NSColor>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selGradientColorsXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setGradientColors:", ArgumentSemantic.Copy)]
			set {
				var value__handle__ = value!.GetNonNullHandle (nameof (value));
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetGradientColors_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetGradientColors_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
	} /* class GKNoise */
}
