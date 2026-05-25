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
	/// <summary>Abstract base class of arithmetic nodes.</summary>
	[Register("MPSNNBinaryArithmeticNode", true)]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe partial class MPSNNBinaryArithmeticNode : MPSNNFilterNode {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selBiasX = "bias";
		static readonly NativeHandle selBiasXHandle = Selector.GetHandle ("bias");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selGradientClassX = "gradientClass";
		static readonly NativeHandle selGradientClassXHandle = Selector.GetHandle ("gradientClass");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selGradientFiltersWithSources_X = "gradientFiltersWithSources:";
		static readonly NativeHandle selGradientFiltersWithSources_XHandle = Selector.GetHandle ("gradientFiltersWithSources:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithLeftSource_RightSource_X = "initWithLeftSource:rightSource:";
		static readonly NativeHandle selInitWithLeftSource_RightSource_XHandle = Selector.GetHandle ("initWithLeftSource:rightSource:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithSources_X = "initWithSources:";
		static readonly NativeHandle selInitWithSources_XHandle = Selector.GetHandle ("initWithSources:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMaximumValueX = "maximumValue";
		static readonly NativeHandle selMaximumValueXHandle = Selector.GetHandle ("maximumValue");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMinimumValueX = "minimumValue";
		static readonly NativeHandle selMinimumValueXHandle = Selector.GetHandle ("minimumValue");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selNodeWithLeftSource_RightSource_X = "nodeWithLeftSource:rightSource:";
		static readonly NativeHandle selNodeWithLeftSource_RightSource_XHandle = Selector.GetHandle ("nodeWithLeftSource:rightSource:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selNodeWithSources_X = "nodeWithSources:";
		static readonly NativeHandle selNodeWithSources_XHandle = Selector.GetHandle ("nodeWithSources:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPrimaryScaleX = "primaryScale";
		static readonly NativeHandle selPrimaryScaleXHandle = Selector.GetHandle ("primaryScale");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPrimaryStrideInFeatureChannelsX = "primaryStrideInFeatureChannels";
		static readonly NativeHandle selPrimaryStrideInFeatureChannelsXHandle = Selector.GetHandle ("primaryStrideInFeatureChannels");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPrimaryStrideInPixelsXX = "primaryStrideInPixelsX";
		static readonly NativeHandle selPrimaryStrideInPixelsXXHandle = Selector.GetHandle ("primaryStrideInPixelsX");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPrimaryStrideInPixelsYX = "primaryStrideInPixelsY";
		static readonly NativeHandle selPrimaryStrideInPixelsYXHandle = Selector.GetHandle ("primaryStrideInPixelsY");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSecondaryScaleX = "secondaryScale";
		static readonly NativeHandle selSecondaryScaleXHandle = Selector.GetHandle ("secondaryScale");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSecondaryStrideInFeatureChannelsX = "secondaryStrideInFeatureChannels";
		static readonly NativeHandle selSecondaryStrideInFeatureChannelsXHandle = Selector.GetHandle ("secondaryStrideInFeatureChannels");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSecondaryStrideInPixelsXX = "secondaryStrideInPixelsX";
		static readonly NativeHandle selSecondaryStrideInPixelsXXHandle = Selector.GetHandle ("secondaryStrideInPixelsX");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSecondaryStrideInPixelsYX = "secondaryStrideInPixelsY";
		static readonly NativeHandle selSecondaryStrideInPixelsYXHandle = Selector.GetHandle ("secondaryStrideInPixelsY");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetBias_X = "setBias:";
		static readonly NativeHandle selSetBias_XHandle = Selector.GetHandle ("setBias:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetMaximumValue_X = "setMaximumValue:";
		static readonly NativeHandle selSetMaximumValue_XHandle = Selector.GetHandle ("setMaximumValue:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetMinimumValue_X = "setMinimumValue:";
		static readonly NativeHandle selSetMinimumValue_XHandle = Selector.GetHandle ("setMinimumValue:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetPrimaryScale_X = "setPrimaryScale:";
		static readonly NativeHandle selSetPrimaryScale_XHandle = Selector.GetHandle ("setPrimaryScale:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetPrimaryStrideInFeatureChannels_X = "setPrimaryStrideInFeatureChannels:";
		static readonly NativeHandle selSetPrimaryStrideInFeatureChannels_XHandle = Selector.GetHandle ("setPrimaryStrideInFeatureChannels:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetPrimaryStrideInPixelsX_X = "setPrimaryStrideInPixelsX:";
		static readonly NativeHandle selSetPrimaryStrideInPixelsX_XHandle = Selector.GetHandle ("setPrimaryStrideInPixelsX:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetPrimaryStrideInPixelsY_X = "setPrimaryStrideInPixelsY:";
		static readonly NativeHandle selSetPrimaryStrideInPixelsY_XHandle = Selector.GetHandle ("setPrimaryStrideInPixelsY:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetSecondaryScale_X = "setSecondaryScale:";
		static readonly NativeHandle selSetSecondaryScale_XHandle = Selector.GetHandle ("setSecondaryScale:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetSecondaryStrideInFeatureChannels_X = "setSecondaryStrideInFeatureChannels:";
		static readonly NativeHandle selSetSecondaryStrideInFeatureChannels_XHandle = Selector.GetHandle ("setSecondaryStrideInFeatureChannels:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetSecondaryStrideInPixelsX_X = "setSecondaryStrideInPixelsX:";
		static readonly NativeHandle selSetSecondaryStrideInPixelsX_XHandle = Selector.GetHandle ("setSecondaryStrideInPixelsX:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetSecondaryStrideInPixelsY_X = "setSecondaryStrideInPixelsY:";
		static readonly NativeHandle selSetSecondaryStrideInPixelsY_XHandle = Selector.GetHandle ("setSecondaryStrideInPixelsY:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("MPSNNBinaryArithmeticNode");
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
		protected MPSNNBinaryArithmeticNode (NSObjectFlag t) : base (t)
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
		protected internal MPSNNBinaryArithmeticNode (NativeHandle handle) : base (handle)
		{
		}

		/// <param name="sourceNodes">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("initWithSources:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public MPSNNBinaryArithmeticNode (MPSNNImageNode[] sourceNodes)
			: base (NSObjectFlag.Empty)
		{
			if (sourceNodes is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (sourceNodes));
			using var nsa_sourceNodes = NSArray.FromNSObjects (sourceNodes);
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selInitWithSources_XHandle, nsa_sourceNodes.Handle), "initWithSources:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selInitWithSources_XHandle, nsa_sourceNodes.Handle), "initWithSources:");
					GC.KeepAlive (this);
				}
			}
		}
		/// <param name="left">To be added.</param><param name="right">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("initWithLeftSource:rightSource:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public MPSNNBinaryArithmeticNode (MPSNNImageNode left, MPSNNImageNode right)
			: base (NSObjectFlag.Empty)
		{
			var left__handle__ = left!.GetNonNullHandle (nameof (left));
			var right__handle__ = right!.GetNonNullHandle (nameof (right));
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selInitWithLeftSource_RightSource_XHandle, left__handle__, right__handle__), "initWithLeftSource:rightSource:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selInitWithLeftSource_RightSource_XHandle, left__handle__, right__handle__), "initWithLeftSource:rightSource:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (left);
			GC.KeepAlive (right);
		}
		/// <param name="sourceNodes">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("nodeWithSources:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSNNBinaryArithmeticNode Create (MPSNNImageNode[] sourceNodes)
		{
			if (sourceNodes is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (sourceNodes));
			using var nsa_sourceNodes = NSArray.FromNSObjects (sourceNodes);
			MPSNNBinaryArithmeticNode ret;
			ret =  Runtime.GetNSObject<MPSNNBinaryArithmeticNode> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, selNodeWithSources_XHandle, nsa_sourceNodes.Handle), false)!;
			return ret;
		}
		/// <param name="left">To be added.</param><param name="right">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("nodeWithLeftSource:rightSource:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSNNBinaryArithmeticNode Create (MPSNNImageNode left, MPSNNImageNode right)
		{
			var left__handle__ = left!.GetNonNullHandle (nameof (left));
			var right__handle__ = right!.GetNonNullHandle (nameof (right));
			MPSNNBinaryArithmeticNode? ret;
			ret =  Runtime.GetNSObject<MPSNNBinaryArithmeticNode> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (class_ptr, selNodeWithLeftSource_RightSource_XHandle, left__handle__, right__handle__), false)!;
			GC.KeepAlive (left);
			GC.KeepAlive (right);
			return ret!;
		}
		/// <param name="gradientImages">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("gradientFiltersWithSources:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MPSNNGradientFilterNode[] GetGradientFilters (MPSNNImageNode[] gradientImages)
		{
			if (gradientImages is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (gradientImages));
			using var nsa_gradientImages = NSArray.FromNSObjects (gradientImages);
			MPSNNGradientFilterNode[] ret;
			if (IsDirectBinding) {
				ret = CFArray.ArrayFromHandle<MPSNNGradientFilterNode>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selGradientFiltersWithSources_XHandle, nsa_gradientImages.Handle), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFArray.ArrayFromHandle<MPSNNGradientFilterNode>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selGradientFiltersWithSources_XHandle, nsa_gradientImages.Handle), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual float Bias {
			[Export ("bias")]
			get {
				float ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selBiasXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.float_objc_msgSendSuper (&__objc_super__, selBiasXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setBias:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, selSetBias_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_float (&__objc_super__, selSetBias_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual Class GradientClass {
			[Export ("gradientClass")]
			get {
				Class ret;
				if (IsDirectBinding) {
					ret = Runtime.GetINativeObject<global::ObjCRuntime.Class> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selGradientClassXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = Runtime.GetINativeObject<global::ObjCRuntime.Class> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selGradientClassXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual float MaximumValue {
			[Export ("maximumValue")]
			get {
				float ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selMaximumValueXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.float_objc_msgSendSuper (&__objc_super__, selMaximumValueXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setMaximumValue:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, selSetMaximumValue_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_float (&__objc_super__, selSetMaximumValue_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual float MinimumValue {
			[Export ("minimumValue")]
			get {
				float ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selMinimumValueXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.float_objc_msgSendSuper (&__objc_super__, selMinimumValueXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setMinimumValue:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, selSetMinimumValue_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_float (&__objc_super__, selSetMinimumValue_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual float PrimaryScale {
			[Export ("primaryScale")]
			get {
				float ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selPrimaryScaleXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.float_objc_msgSendSuper (&__objc_super__, selPrimaryScaleXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setPrimaryScale:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, selSetPrimaryScale_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_float (&__objc_super__, selSetPrimaryScale_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nuint PrimaryStrideInFeatureChannels {
			[Export ("primaryStrideInFeatureChannels")]
			get {
				nuint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selPrimaryStrideInFeatureChannelsXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selPrimaryStrideInFeatureChannelsXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setPrimaryStrideInFeatureChannels:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (this.Handle, selSetPrimaryStrideInFeatureChannels_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UIntPtr (&__objc_super__, selSetPrimaryStrideInFeatureChannels_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nuint PrimaryStrideInPixelsX {
			[Export ("primaryStrideInPixelsX")]
			get {
				nuint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selPrimaryStrideInPixelsXXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selPrimaryStrideInPixelsXXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setPrimaryStrideInPixelsX:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (this.Handle, selSetPrimaryStrideInPixelsX_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UIntPtr (&__objc_super__, selSetPrimaryStrideInPixelsX_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nuint PrimaryStrideInPixelsY {
			[Export ("primaryStrideInPixelsY")]
			get {
				nuint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selPrimaryStrideInPixelsYXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selPrimaryStrideInPixelsYXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setPrimaryStrideInPixelsY:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (this.Handle, selSetPrimaryStrideInPixelsY_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UIntPtr (&__objc_super__, selSetPrimaryStrideInPixelsY_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual float SecondaryScale {
			[Export ("secondaryScale")]
			get {
				float ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selSecondaryScaleXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.float_objc_msgSendSuper (&__objc_super__, selSecondaryScaleXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setSecondaryScale:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, selSetSecondaryScale_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_float (&__objc_super__, selSetSecondaryScale_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nuint SecondaryStrideInFeatureChannels {
			[Export ("secondaryStrideInFeatureChannels")]
			get {
				nuint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selSecondaryStrideInFeatureChannelsXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selSecondaryStrideInFeatureChannelsXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setSecondaryStrideInFeatureChannels:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (this.Handle, selSetSecondaryStrideInFeatureChannels_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UIntPtr (&__objc_super__, selSetSecondaryStrideInFeatureChannels_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nuint SecondaryStrideInPixelsX {
			[Export ("secondaryStrideInPixelsX")]
			get {
				nuint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selSecondaryStrideInPixelsXXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selSecondaryStrideInPixelsXXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setSecondaryStrideInPixelsX:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (this.Handle, selSetSecondaryStrideInPixelsX_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UIntPtr (&__objc_super__, selSetSecondaryStrideInPixelsX_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nuint SecondaryStrideInPixelsY {
			[Export ("secondaryStrideInPixelsY")]
			get {
				nuint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selSecondaryStrideInPixelsYXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selSecondaryStrideInPixelsYXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setSecondaryStrideInPixelsY:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (this.Handle, selSetSecondaryStrideInPixelsY_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UIntPtr (&__objc_super__, selSetSecondaryStrideInPixelsY_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
	} /* class MPSNNBinaryArithmeticNode */
}
