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
	[Register("MPSNNForwardLossNode", true)]
	[SupportedOSPlatform ("tvos13.0")]
	[SupportedOSPlatform ("ios13.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	public unsafe partial class MPSNNForwardLossNode : MPSNNFilterNode {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDeltaX = "delta";
		static readonly NativeHandle selDeltaXHandle = Selector.GetHandle ("delta");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selEpsilonX = "epsilon";
		static readonly NativeHandle selEpsilonXHandle = Selector.GetHandle ("epsilon");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selGradientFilterWithSource_X = "gradientFilterWithSource:";
		static readonly NativeHandle selGradientFilterWithSource_XHandle = Selector.GetHandle ("gradientFilterWithSource:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selGradientFilterWithSources_X = "gradientFilterWithSources:";
		static readonly NativeHandle selGradientFilterWithSources_XHandle = Selector.GetHandle ("gradientFilterWithSources:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selGradientFiltersWithSource_X = "gradientFiltersWithSource:";
		static readonly NativeHandle selGradientFiltersWithSource_XHandle = Selector.GetHandle ("gradientFiltersWithSource:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selGradientFiltersWithSources_X = "gradientFiltersWithSources:";
		static readonly NativeHandle selGradientFiltersWithSources_XHandle = Selector.GetHandle ("gradientFiltersWithSources:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithSource_Labels_LossDescriptor_X = "initWithSource:labels:lossDescriptor:";
		static readonly NativeHandle selInitWithSource_Labels_LossDescriptor_XHandle = Selector.GetHandle ("initWithSource:labels:lossDescriptor:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithSource_Labels_Weights_LossDescriptor_X = "initWithSource:labels:weights:lossDescriptor:";
		static readonly NativeHandle selInitWithSource_Labels_Weights_LossDescriptor_XHandle = Selector.GetHandle ("initWithSource:labels:weights:lossDescriptor:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithSources_LossDescriptor_X = "initWithSources:lossDescriptor:";
		static readonly NativeHandle selInitWithSources_LossDescriptor_XHandle = Selector.GetHandle ("initWithSources:lossDescriptor:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLabelSmoothingX = "labelSmoothing";
		static readonly NativeHandle selLabelSmoothingXHandle = Selector.GetHandle ("labelSmoothing");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLossTypeX = "lossType";
		static readonly NativeHandle selLossTypeXHandle = Selector.GetHandle ("lossType");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selNodeWithSource_Labels_LossDescriptor_X = "nodeWithSource:labels:lossDescriptor:";
		static readonly NativeHandle selNodeWithSource_Labels_LossDescriptor_XHandle = Selector.GetHandle ("nodeWithSource:labels:lossDescriptor:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selNodeWithSource_Labels_Weights_LossDescriptor_X = "nodeWithSource:labels:weights:lossDescriptor:";
		static readonly NativeHandle selNodeWithSource_Labels_Weights_LossDescriptor_XHandle = Selector.GetHandle ("nodeWithSource:labels:weights:lossDescriptor:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selNodeWithSources_LossDescriptor_X = "nodeWithSources:lossDescriptor:";
		static readonly NativeHandle selNodeWithSources_LossDescriptor_XHandle = Selector.GetHandle ("nodeWithSources:lossDescriptor:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selNumberOfClassesX = "numberOfClasses";
		static readonly NativeHandle selNumberOfClassesXHandle = Selector.GetHandle ("numberOfClasses");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPropertyCallBackX = "propertyCallBack";
		static readonly NativeHandle selPropertyCallBackXHandle = Selector.GetHandle ("propertyCallBack");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selReduceAcrossBatchX = "reduceAcrossBatch";
		static readonly NativeHandle selReduceAcrossBatchXHandle = Selector.GetHandle ("reduceAcrossBatch");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selReductionTypeX = "reductionType";
		static readonly NativeHandle selReductionTypeXHandle = Selector.GetHandle ("reductionType");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetPropertyCallBack_X = "setPropertyCallBack:";
		static readonly NativeHandle selSetPropertyCallBack_XHandle = Selector.GetHandle ("setPropertyCallBack:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selWeightX = "weight";
		static readonly NativeHandle selWeightXHandle = Selector.GetHandle ("weight");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("MPSNNForwardLossNode");
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
		protected MPSNNForwardLossNode (NSObjectFlag t) : base (t)
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
		protected internal MPSNNForwardLossNode (NativeHandle handle) : base (handle)
		{
		}

		[Export ("initWithSource:labels:weights:lossDescriptor:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public MPSNNForwardLossNode (MPSNNImageNode source, MPSNNImageNode labels, MPSNNImageNode? weights, MPSCnnLossDescriptor descriptor)
			: base (NSObjectFlag.Empty)
		{
			var source__handle__ = source!.GetNonNullHandle (nameof (source));
			var labels__handle__ = labels!.GetNonNullHandle (nameof (labels));
			var weights__handle__ = weights.GetHandle ();
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (this.Handle, selInitWithSource_Labels_Weights_LossDescriptor_XHandle, source__handle__, labels__handle__, weights__handle__, descriptor__handle__), "initWithSource:labels:weights:lossDescriptor:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, selInitWithSource_Labels_Weights_LossDescriptor_XHandle, source__handle__, labels__handle__, weights__handle__, descriptor__handle__), "initWithSource:labels:weights:lossDescriptor:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (source);
			GC.KeepAlive (labels);
			GC.KeepAlive (weights);
			GC.KeepAlive (descriptor);
		}
		[Export ("initWithSource:labels:lossDescriptor:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public MPSNNForwardLossNode (MPSNNImageNode source, MPSNNImageNode labels, MPSCnnLossDescriptor descriptor)
			: base (NSObjectFlag.Empty)
		{
			var source__handle__ = source!.GetNonNullHandle (nameof (source));
			var labels__handle__ = labels!.GetNonNullHandle (nameof (labels));
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, selInitWithSource_Labels_LossDescriptor_XHandle, source__handle__, labels__handle__, descriptor__handle__), "initWithSource:labels:lossDescriptor:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, selInitWithSource_Labels_LossDescriptor_XHandle, source__handle__, labels__handle__, descriptor__handle__), "initWithSource:labels:lossDescriptor:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (source);
			GC.KeepAlive (labels);
			GC.KeepAlive (descriptor);
		}
		[Export ("initWithSources:lossDescriptor:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public MPSNNForwardLossNode (MPSNNImageNode[] sourceNodes, MPSCnnLossDescriptor descriptor)
			: base (NSObjectFlag.Empty)
		{
			if (sourceNodes is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (sourceNodes));
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			using var nsa_sourceNodes = NSArray.FromNSObjects (sourceNodes);
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selInitWithSources_LossDescriptor_XHandle, nsa_sourceNodes.Handle, descriptor__handle__), "initWithSources:lossDescriptor:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selInitWithSources_LossDescriptor_XHandle, nsa_sourceNodes.Handle, descriptor__handle__), "initWithSources:lossDescriptor:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (descriptor);
		}
		[Export ("nodeWithSource:labels:weights:lossDescriptor:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSNNForwardLossNode Create (MPSNNImageNode source, MPSNNImageNode labels, MPSNNImageNode weights, MPSCnnLossDescriptor descriptor)
		{
			var source__handle__ = source!.GetNonNullHandle (nameof (source));
			var labels__handle__ = labels!.GetNonNullHandle (nameof (labels));
			var weights__handle__ = weights!.GetNonNullHandle (nameof (weights));
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			MPSNNForwardLossNode? ret;
			ret =  Runtime.GetNSObject<MPSNNForwardLossNode> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (class_ptr, selNodeWithSource_Labels_Weights_LossDescriptor_XHandle, source__handle__, labels__handle__, weights__handle__, descriptor__handle__), false)!;
			GC.KeepAlive (source);
			GC.KeepAlive (labels);
			GC.KeepAlive (weights);
			GC.KeepAlive (descriptor);
			return ret!;
		}
		[Export ("nodeWithSource:labels:lossDescriptor:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSNNForwardLossNode Create (MPSNNImageNode source, MPSNNImageNode labels, MPSCnnLossDescriptor descriptor)
		{
			var source__handle__ = source!.GetNonNullHandle (nameof (source));
			var labels__handle__ = labels!.GetNonNullHandle (nameof (labels));
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			MPSNNForwardLossNode? ret;
			ret =  Runtime.GetNSObject<MPSNNForwardLossNode> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (class_ptr, selNodeWithSource_Labels_LossDescriptor_XHandle, source__handle__, labels__handle__, descriptor__handle__), false)!;
			GC.KeepAlive (source);
			GC.KeepAlive (labels);
			GC.KeepAlive (descriptor);
			return ret!;
		}
		[Export ("nodeWithSources:lossDescriptor:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSNNForwardLossNode Create (MPSNNImageNode[] sourceNodes, MPSCnnLossDescriptor descriptor)
		{
			if (sourceNodes is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (sourceNodes));
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			using var nsa_sourceNodes = NSArray.FromNSObjects (sourceNodes);
			MPSNNForwardLossNode? ret;
			ret =  Runtime.GetNSObject<MPSNNForwardLossNode> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (class_ptr, selNodeWithSources_LossDescriptor_XHandle, nsa_sourceNodes.Handle, descriptor__handle__), false)!;
			GC.KeepAlive (descriptor);
			return ret!;
		}
		[Export ("gradientFilterWithSources:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MPSNNLossGradientNode GetFilter (MPSNNImageNode[] sourceGradient)
		{
			if (sourceGradient is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (sourceGradient));
			using var nsa_sourceGradient = NSArray.FromNSObjects (sourceGradient);
			MPSNNLossGradientNode ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<MPSNNLossGradientNode> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selGradientFilterWithSources_XHandle, nsa_sourceGradient.Handle), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<MPSNNLossGradientNode> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selGradientFilterWithSources_XHandle, nsa_sourceGradient.Handle), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("gradientFilterWithSource:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MPSNNLossGradientNode GetFilter (MPSNNImageNode sourceGradient)
		{
			var sourceGradient__handle__ = sourceGradient!.GetNonNullHandle (nameof (sourceGradient));
			MPSNNLossGradientNode? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<MPSNNLossGradientNode> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selGradientFilterWithSource_XHandle, sourceGradient__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<MPSNNLossGradientNode> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selGradientFilterWithSource_XHandle, sourceGradient__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (sourceGradient);
			return ret!;
		}
		[Export ("gradientFiltersWithSources:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MPSNNLossGradientNode[] GetFilters (MPSNNImageNode[] sourceGradient)
		{
			if (sourceGradient is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (sourceGradient));
			using var nsa_sourceGradient = NSArray.FromNSObjects (sourceGradient);
			MPSNNLossGradientNode[] ret;
			if (IsDirectBinding) {
				ret = CFArray.ArrayFromHandle<MPSNNLossGradientNode>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selGradientFiltersWithSources_XHandle, nsa_sourceGradient.Handle), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFArray.ArrayFromHandle<MPSNNLossGradientNode>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selGradientFiltersWithSources_XHandle, nsa_sourceGradient.Handle), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("gradientFiltersWithSource:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MPSNNLossGradientNode[] GetFilters (MPSNNImageNode sourceGradient)
		{
			var sourceGradient__handle__ = sourceGradient!.GetNonNullHandle (nameof (sourceGradient));
			MPSNNLossGradientNode[]? ret;
			if (IsDirectBinding) {
				ret = CFArray.ArrayFromHandle<MPSNNLossGradientNode>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selGradientFiltersWithSource_XHandle, sourceGradient__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFArray.ArrayFromHandle<MPSNNLossGradientNode>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selGradientFiltersWithSource_XHandle, sourceGradient__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (sourceGradient);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual float Delta {
			[Export ("delta")]
			get {
				float ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selDeltaXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.float_objc_msgSendSuper (&__objc_super__, selDeltaXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual float Epsilon {
			[Export ("epsilon")]
			get {
				float ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selEpsilonXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.float_objc_msgSendSuper (&__objc_super__, selEpsilonXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual float LabelSmoothing {
			[Export ("labelSmoothing")]
			get {
				float ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selLabelSmoothingXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.float_objc_msgSendSuper (&__objc_super__, selLabelSmoothingXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MPSCnnLossType LossType {
			[Export ("lossType")]
			get {
				MPSCnnLossType ret;
				if (IsDirectBinding) {
					ret = (MPSCnnLossType) global::ObjCRuntime.Messaging.UInt32_objc_msgSend (this.Handle, selLossTypeXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (MPSCnnLossType) global::ObjCRuntime.Messaging.UInt32_objc_msgSendSuper (&__objc_super__, selLossTypeXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nuint NumberOfClasses {
			[Export ("numberOfClasses")]
			get {
				nuint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selNumberOfClassesXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selNumberOfClassesXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual IMPSNNLossCallback? PropertyCallBack {
			[Export ("propertyCallBack", ArgumentSemantic.Retain)]
			get {
				IMPSNNLossCallback? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetINativeObject<IMPSNNLossCallback> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selPropertyCallBackXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetINativeObject<IMPSNNLossCallback> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selPropertyCallBackXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setPropertyCallBack:", ArgumentSemantic.Retain)]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetPropertyCallBack_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetPropertyCallBack_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("macos")]
		public virtual bool ReduceAcrossBatch {
			[Export ("reduceAcrossBatch")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selReduceAcrossBatchXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selReduceAcrossBatchXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MPSCnnReductionType ReductionType {
			[Export ("reductionType")]
			get {
				MPSCnnReductionType ret;
				if (IsDirectBinding) {
					ret = (MPSCnnReductionType) global::ObjCRuntime.Messaging.int_objc_msgSend (this.Handle, selReductionTypeXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (MPSCnnReductionType) global::ObjCRuntime.Messaging.int_objc_msgSendSuper (&__objc_super__, selReductionTypeXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual float Weight {
			[Export ("weight")]
			get {
				float ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selWeightXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.float_objc_msgSendSuper (&__objc_super__, selWeightXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
	} /* class MPSNNForwardLossNode */
}
