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
namespace MetalPerformanceShaders {
	[Register("MPSNNOptimizerDescriptor", true)]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe partial class MPSNNOptimizerDescriptor : NSObject {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selApplyGradientClippingX = "applyGradientClipping";
		static readonly NativeHandle selApplyGradientClippingXHandle = Selector.GetHandle ("applyGradientClipping");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selGradientClipMaxX = "gradientClipMax";
		static readonly NativeHandle selGradientClipMaxXHandle = Selector.GetHandle ("gradientClipMax");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selGradientClipMinX = "gradientClipMin";
		static readonly NativeHandle selGradientClipMinXHandle = Selector.GetHandle ("gradientClipMin");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selGradientRescaleX = "gradientRescale";
		static readonly NativeHandle selGradientRescaleXHandle = Selector.GetHandle ("gradientRescale");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithLearningRate_GradientRescale_ApplyGradientClipping_GradientClipMax_GradientClipMin_RegularizationType_RegularizationScale_X = "initWithLearningRate:gradientRescale:applyGradientClipping:gradientClipMax:gradientClipMin:regularizationType:regularizationScale:";
		static readonly NativeHandle selInitWithLearningRate_GradientRescale_ApplyGradientClipping_GradientClipMax_GradientClipMin_RegularizationType_RegularizationScale_XHandle = Selector.GetHandle ("initWithLearningRate:gradientRescale:applyGradientClipping:gradientClipMax:gradientClipMin:regularizationType:regularizationScale:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithLearningRate_GradientRescale_RegularizationType_RegularizationScale_X = "initWithLearningRate:gradientRescale:regularizationType:regularizationScale:";
		static readonly NativeHandle selInitWithLearningRate_GradientRescale_RegularizationType_RegularizationScale_XHandle = Selector.GetHandle ("initWithLearningRate:gradientRescale:regularizationType:regularizationScale:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLearningRateX = "learningRate";
		static readonly NativeHandle selLearningRateXHandle = Selector.GetHandle ("learningRate");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selOptimizerDescriptorWithLearningRate_GradientRescale_ApplyGradientClipping_GradientClipMax_GradientClipMin_RegularizationType_RegularizationScale_X = "optimizerDescriptorWithLearningRate:gradientRescale:applyGradientClipping:gradientClipMax:gradientClipMin:regularizationType:regularizationScale:";
		static readonly NativeHandle selOptimizerDescriptorWithLearningRate_GradientRescale_ApplyGradientClipping_GradientClipMax_GradientClipMin_RegularizationType_RegularizationScale_XHandle = Selector.GetHandle ("optimizerDescriptorWithLearningRate:gradientRescale:applyGradientClipping:gradientClipMax:gradientClipMin:regularizationType:regularizationScale:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selOptimizerDescriptorWithLearningRate_GradientRescale_RegularizationType_RegularizationScale_X = "optimizerDescriptorWithLearningRate:gradientRescale:regularizationType:regularizationScale:";
		static readonly NativeHandle selOptimizerDescriptorWithLearningRate_GradientRescale_RegularizationType_RegularizationScale_XHandle = Selector.GetHandle ("optimizerDescriptorWithLearningRate:gradientRescale:regularizationType:regularizationScale:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRegularizationScaleX = "regularizationScale";
		static readonly NativeHandle selRegularizationScaleXHandle = Selector.GetHandle ("regularizationScale");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRegularizationTypeX = "regularizationType";
		static readonly NativeHandle selRegularizationTypeXHandle = Selector.GetHandle ("regularizationType");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetApplyGradientClipping_X = "setApplyGradientClipping:";
		static readonly NativeHandle selSetApplyGradientClipping_XHandle = Selector.GetHandle ("setApplyGradientClipping:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetGradientClipMax_X = "setGradientClipMax:";
		static readonly NativeHandle selSetGradientClipMax_XHandle = Selector.GetHandle ("setGradientClipMax:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetGradientClipMin_X = "setGradientClipMin:";
		static readonly NativeHandle selSetGradientClipMin_XHandle = Selector.GetHandle ("setGradientClipMin:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetGradientRescale_X = "setGradientRescale:";
		static readonly NativeHandle selSetGradientRescale_XHandle = Selector.GetHandle ("setGradientRescale:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetLearningRate_X = "setLearningRate:";
		static readonly NativeHandle selSetLearningRate_XHandle = Selector.GetHandle ("setLearningRate:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetRegularizationScale_X = "setRegularizationScale:";
		static readonly NativeHandle selSetRegularizationScale_XHandle = Selector.GetHandle ("setRegularizationScale:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetRegularizationType_X = "setRegularizationType:";
		static readonly NativeHandle selSetRegularizationType_XHandle = Selector.GetHandle ("setRegularizationType:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("MPSNNOptimizerDescriptor");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
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
		protected MPSNNOptimizerDescriptor (NSObjectFlag t) : base (t)
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
		protected internal MPSNNOptimizerDescriptor (NativeHandle handle) : base (handle)
		{
		}

		/// <param name="learningRate">To be added.</param><param name="gradientRescale">To be added.</param><param name="regularizationType">To be added.</param><param name="regularizationScale">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("initWithLearningRate:gradientRescale:regularizationType:regularizationScale:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public MPSNNOptimizerDescriptor (float learningRate, float gradientRescale, MPSNNRegularizationType regularizationType, float regularizationScale)
			: base (NSObjectFlag.Empty)
		{
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_float_float_UIntPtr_float (this.Handle, selInitWithLearningRate_GradientRescale_RegularizationType_RegularizationScale_XHandle, learningRate, gradientRescale, (UIntPtr) (ulong) regularizationType, regularizationScale), "initWithLearningRate:gradientRescale:regularizationType:regularizationScale:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_float_float_UIntPtr_float (&__objc_super__, selInitWithLearningRate_GradientRescale_RegularizationType_RegularizationScale_XHandle, learningRate, gradientRescale, (UIntPtr) (ulong) regularizationType, regularizationScale), "initWithLearningRate:gradientRescale:regularizationType:regularizationScale:");
					GC.KeepAlive (this);
				}
			}
		}
		/// <param name="learningRate">To be added.</param><param name="gradientRescale">To be added.</param><param name="applyGradientClipping">To be added.</param><param name="gradientClipMax">To be added.</param><param name="gradientClipMin">To be added.</param><param name="regularizationType">To be added.</param><param name="regularizationScale">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("initWithLearningRate:gradientRescale:applyGradientClipping:gradientClipMax:gradientClipMin:regularizationType:regularizationScale:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public MPSNNOptimizerDescriptor (float learningRate, float gradientRescale, bool applyGradientClipping, float gradientClipMax, float gradientClipMin, MPSNNRegularizationType regularizationType, float regularizationScale)
			: base (NSObjectFlag.Empty)
		{
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_float_float_bool_float_float_UIntPtr_float (this.Handle, selInitWithLearningRate_GradientRescale_ApplyGradientClipping_GradientClipMax_GradientClipMin_RegularizationType_RegularizationScale_XHandle, learningRate, gradientRescale, applyGradientClipping ? (byte) 1 : (byte) 0, gradientClipMax, gradientClipMin, (UIntPtr) (ulong) regularizationType, regularizationScale), "initWithLearningRate:gradientRescale:applyGradientClipping:gradientClipMax:gradientClipMin:regularizationType:regularizationScale:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_float_float_bool_float_float_UIntPtr_float (&__objc_super__, selInitWithLearningRate_GradientRescale_ApplyGradientClipping_GradientClipMax_GradientClipMin_RegularizationType_RegularizationScale_XHandle, learningRate, gradientRescale, applyGradientClipping ? (byte) 1 : (byte) 0, gradientClipMax, gradientClipMin, (UIntPtr) (ulong) regularizationType, regularizationScale), "initWithLearningRate:gradientRescale:applyGradientClipping:gradientClipMax:gradientClipMin:regularizationType:regularizationScale:");
					GC.KeepAlive (this);
				}
			}
		}
		/// <param name="learningRate">To be added.</param><param name="gradientRescale">To be added.</param><param name="regularizationType">To be added.</param><param name="regularizationScale">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("optimizerDescriptorWithLearningRate:gradientRescale:regularizationType:regularizationScale:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSNNOptimizerDescriptor Create (float learningRate, float gradientRescale, MPSNNRegularizationType regularizationType, float regularizationScale)
		{
			MPSNNOptimizerDescriptor ret;
			ret =  Runtime.GetNSObject<MPSNNOptimizerDescriptor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_float_float_UIntPtr_float (class_ptr, selOptimizerDescriptorWithLearningRate_GradientRescale_RegularizationType_RegularizationScale_XHandle, learningRate, gradientRescale, (UIntPtr) (ulong) regularizationType, regularizationScale), false)!;
			return ret;
		}
		/// <param name="learningRate">To be added.</param><param name="gradientRescale">To be added.</param><param name="applyGradientClipping">To be added.</param><param name="gradientClipMax">To be added.</param><param name="gradientClipMin">To be added.</param><param name="regularizationType">To be added.</param><param name="regularizationScale">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("optimizerDescriptorWithLearningRate:gradientRescale:applyGradientClipping:gradientClipMax:gradientClipMin:regularizationType:regularizationScale:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSNNOptimizerDescriptor Create (float learningRate, float gradientRescale, bool applyGradientClipping, float gradientClipMax, float gradientClipMin, MPSNNRegularizationType regularizationType, float regularizationScale)
		{
			MPSNNOptimizerDescriptor ret;
			ret =  Runtime.GetNSObject<MPSNNOptimizerDescriptor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_float_float_bool_float_float_UIntPtr_float (class_ptr, selOptimizerDescriptorWithLearningRate_GradientRescale_ApplyGradientClipping_GradientClipMax_GradientClipMin_RegularizationType_RegularizationScale_XHandle, learningRate, gradientRescale, applyGradientClipping ? (byte) 1 : (byte) 0, gradientClipMax, gradientClipMin, (UIntPtr) (ulong) regularizationType, regularizationScale), false)!;
			return ret;
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ApplyGradientClipping {
			[Export ("applyGradientClipping")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selApplyGradientClippingXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selApplyGradientClippingXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setApplyGradientClipping:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetApplyGradientClipping_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetApplyGradientClipping_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual float GradientClipMax {
			[Export ("gradientClipMax")]
			get {
				float ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selGradientClipMaxXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.float_objc_msgSendSuper (&__objc_super__, selGradientClipMaxXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setGradientClipMax:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, selSetGradientClipMax_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_float (&__objc_super__, selSetGradientClipMax_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual float GradientClipMin {
			[Export ("gradientClipMin")]
			get {
				float ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selGradientClipMinXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.float_objc_msgSendSuper (&__objc_super__, selGradientClipMinXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setGradientClipMin:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, selSetGradientClipMin_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_float (&__objc_super__, selSetGradientClipMin_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual float GradientRescale {
			[Export ("gradientRescale")]
			get {
				float ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selGradientRescaleXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.float_objc_msgSendSuper (&__objc_super__, selGradientRescaleXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setGradientRescale:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, selSetGradientRescale_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_float (&__objc_super__, selSetGradientRescale_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual float LearningRate {
			[Export ("learningRate")]
			get {
				float ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selLearningRateXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.float_objc_msgSendSuper (&__objc_super__, selLearningRateXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setLearningRate:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, selSetLearningRate_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_float (&__objc_super__, selSetLearningRate_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual float RegularizationScale {
			[Export ("regularizationScale")]
			get {
				float ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selRegularizationScaleXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.float_objc_msgSendSuper (&__objc_super__, selRegularizationScaleXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setRegularizationScale:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, selSetRegularizationScale_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_float (&__objc_super__, selSetRegularizationScale_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MPSNNRegularizationType RegularizationType {
			[Export ("regularizationType", ArgumentSemantic.Assign)]
			get {
				MPSNNRegularizationType ret;
				if (IsDirectBinding) {
					ret = (MetalPerformanceShaders.MPSNNRegularizationType) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selRegularizationTypeXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (MetalPerformanceShaders.MPSNNRegularizationType) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selRegularizationTypeXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setRegularizationType:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (this.Handle, selSetRegularizationType_XHandle, (UIntPtr) (ulong) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UIntPtr (&__objc_super__, selSetRegularizationType_XHandle, (UIntPtr) (ulong) value);
						GC.KeepAlive (this);
					}
				}
			}
		}
	} /* class MPSNNOptimizerDescriptor */
}
