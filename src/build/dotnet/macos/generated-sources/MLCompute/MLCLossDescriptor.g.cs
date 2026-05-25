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
namespace MLCompute {
	[Register("MLCLossDescriptor", true)]
	[SupportedOSPlatform ("ios14.0")]
	[SupportedOSPlatform ("tvos14.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[ObsoletedOSPlatform ("macos14.3", "Use the Metal Performance Shaders Graph or the Accelerate framework (BNNS) instead.")]
	[ObsoletedOSPlatform ("ios17.4", "Use the Metal Performance Shaders Graph or the Accelerate framework (BNNS) instead.")]
	[ObsoletedOSPlatform ("tvos17.4", "Use the Metal Performance Shaders Graph or the Accelerate framework (BNNS) instead.")]
	[ObsoletedOSPlatform ("maccatalyst17.4", "Use the Metal Performance Shaders Graph or the Accelerate framework (BNNS) instead.")]
	[SupportedOSPlatform ("macos")]
	public unsafe partial class MLCLossDescriptor : NSObject, INSCopying {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selClassCountX = "classCount";
		static readonly NativeHandle selClassCountXHandle = Selector.GetHandle ("classCount");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCopyWithZone_X = "copyWithZone:";
		static readonly NativeHandle selCopyWithZone_XHandle = Selector.GetHandle ("copyWithZone:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDeltaX = "delta";
		static readonly NativeHandle selDeltaXHandle = Selector.GetHandle ("delta");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDescriptorWithType_ReductionType_X = "descriptorWithType:reductionType:";
		static readonly NativeHandle selDescriptorWithType_ReductionType_XHandle = Selector.GetHandle ("descriptorWithType:reductionType:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDescriptorWithType_ReductionType_Weight_X = "descriptorWithType:reductionType:weight:";
		static readonly NativeHandle selDescriptorWithType_ReductionType_Weight_XHandle = Selector.GetHandle ("descriptorWithType:reductionType:weight:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDescriptorWithType_ReductionType_Weight_LabelSmoothing_ClassCount_X = "descriptorWithType:reductionType:weight:labelSmoothing:classCount:";
		static readonly NativeHandle selDescriptorWithType_ReductionType_Weight_LabelSmoothing_ClassCount_XHandle = Selector.GetHandle ("descriptorWithType:reductionType:weight:labelSmoothing:classCount:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDescriptorWithType_ReductionType_Weight_LabelSmoothing_ClassCount_Epsilon_Delta_X = "descriptorWithType:reductionType:weight:labelSmoothing:classCount:epsilon:delta:";
		static readonly NativeHandle selDescriptorWithType_ReductionType_Weight_LabelSmoothing_ClassCount_Epsilon_Delta_XHandle = Selector.GetHandle ("descriptorWithType:reductionType:weight:labelSmoothing:classCount:epsilon:delta:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selEpsilonX = "epsilon";
		static readonly NativeHandle selEpsilonXHandle = Selector.GetHandle ("epsilon");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLabelSmoothingX = "labelSmoothing";
		static readonly NativeHandle selLabelSmoothingXHandle = Selector.GetHandle ("labelSmoothing");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLossTypeX = "lossType";
		static readonly NativeHandle selLossTypeXHandle = Selector.GetHandle ("lossType");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selReductionTypeX = "reductionType";
		static readonly NativeHandle selReductionTypeXHandle = Selector.GetHandle ("reductionType");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selWeightX = "weight";
		static readonly NativeHandle selWeightXHandle = Selector.GetHandle ("weight");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("MLCLossDescriptor");
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
		protected MLCLossDescriptor (NSObjectFlag t) : base (t)
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
		protected internal MLCLossDescriptor (NativeHandle handle) : base (handle)
		{
		}

		/// <param name="zone">Developers should pass <see langword="null" />.  Memory zones are no longer used.</param><summary>Performs a copy of the underlying Objective-C object.</summary><returns>The newly-allocated object.</returns><remarks><para>This method performs a "shallow copy" of <see langword="this" />. If this object contains references to external objects, the new object will contain references to the same object.</para></remarks>
		[Export ("copyWithZone:")]
		[return: ReleaseAttribute ()]
		[ObsoletedOSPlatform ("macos14.3", "Use the Metal Performance Shaders Graph or the Accelerate framework (BNNS) instead.")]
		[ObsoletedOSPlatform ("ios17.4", "Use the Metal Performance Shaders Graph or the Accelerate framework (BNNS) instead.")]
		[ObsoletedOSPlatform ("tvos17.4", "Use the Metal Performance Shaders Graph or the Accelerate framework (BNNS) instead.")]
		[ObsoletedOSPlatform ("maccatalyst17.4", "Use the Metal Performance Shaders Graph or the Accelerate framework (BNNS) instead.")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos14.0")]
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
		[Export ("descriptorWithType:reductionType:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MLCLossDescriptor Create (MLCLossType lossType, MLCReductionType reductionType)
		{
			MLCLossDescriptor ret;
			ret =  Runtime.GetNSObject<MLCLossDescriptor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_int_int (class_ptr, selDescriptorWithType_ReductionType_XHandle, (int)lossType, (int)reductionType), false)!;
			return ret;
		}
		[Export ("descriptorWithType:reductionType:weight:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MLCLossDescriptor Create (MLCLossType lossType, MLCReductionType reductionType, float weight)
		{
			MLCLossDescriptor ret;
			ret =  Runtime.GetNSObject<MLCLossDescriptor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_int_int_float (class_ptr, selDescriptorWithType_ReductionType_Weight_XHandle, (int)lossType, (int)reductionType, weight), false)!;
			return ret;
		}
		[Export ("descriptorWithType:reductionType:weight:labelSmoothing:classCount:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MLCLossDescriptor Create (MLCLossType lossType, MLCReductionType reductionType, float weight, float labelSmoothing, nuint classCount)
		{
			MLCLossDescriptor ret;
			ret =  Runtime.GetNSObject<MLCLossDescriptor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_int_int_float_float_UIntPtr (class_ptr, selDescriptorWithType_ReductionType_Weight_LabelSmoothing_ClassCount_XHandle, (int)lossType, (int)reductionType, weight, labelSmoothing, classCount), false)!;
			return ret;
		}
		[Export ("descriptorWithType:reductionType:weight:labelSmoothing:classCount:epsilon:delta:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MLCLossDescriptor Create (MLCLossType lossType, MLCReductionType reductionType, float weight, float labelSmoothing, nuint classCount, float epsilon, float delta)
		{
			MLCLossDescriptor ret;
			ret =  Runtime.GetNSObject<MLCLossDescriptor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_int_int_float_float_UIntPtr_float_float (class_ptr, selDescriptorWithType_ReductionType_Weight_LabelSmoothing_ClassCount_Epsilon_Delta_XHandle, (int)lossType, (int)reductionType, weight, labelSmoothing, classCount, epsilon, delta), false)!;
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nuint ClassCount {
			[Export ("classCount")]
			get {
				nuint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selClassCountXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selClassCountXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
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
		public virtual MLCLossType LossType {
			[Export ("lossType")]
			get {
				MLCLossType ret;
				if (IsDirectBinding) {
					ret = (MLCLossType) global::ObjCRuntime.Messaging.int_objc_msgSend (this.Handle, selLossTypeXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (MLCLossType) global::ObjCRuntime.Messaging.int_objc_msgSendSuper (&__objc_super__, selLossTypeXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MLCReductionType ReductionType {
			[Export ("reductionType")]
			get {
				MLCReductionType ret;
				if (IsDirectBinding) {
					ret = (MLCReductionType) global::ObjCRuntime.Messaging.int_objc_msgSend (this.Handle, selReductionTypeXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (MLCReductionType) global::ObjCRuntime.Messaging.int_objc_msgSendSuper (&__objc_super__, selReductionTypeXHandle);
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
	} /* class MLCLossDescriptor */
}
