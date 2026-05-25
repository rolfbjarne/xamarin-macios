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
	[Register("MLCLSTMDescriptor", true)]
	[SupportedOSPlatform ("ios14.0")]
	[SupportedOSPlatform ("tvos14.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[ObsoletedOSPlatform ("macos14.3", "Use the Metal Performance Shaders Graph or the Accelerate framework (BNNS) instead.")]
	[ObsoletedOSPlatform ("ios17.4", "Use the Metal Performance Shaders Graph or the Accelerate framework (BNNS) instead.")]
	[ObsoletedOSPlatform ("tvos17.4", "Use the Metal Performance Shaders Graph or the Accelerate framework (BNNS) instead.")]
	[ObsoletedOSPlatform ("maccatalyst17.4", "Use the Metal Performance Shaders Graph or the Accelerate framework (BNNS) instead.")]
	[SupportedOSPlatform ("macos")]
	public unsafe partial class MLCLstmDescriptor : NSObject, INSCopying {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selBatchFirstX = "batchFirst";
		static readonly NativeHandle selBatchFirstXHandle = Selector.GetHandle ("batchFirst");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCopyWithZone_X = "copyWithZone:";
		static readonly NativeHandle selCopyWithZone_XHandle = Selector.GetHandle ("copyWithZone:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDescriptorWithInputSize_HiddenSize_LayerCount_X = "descriptorWithInputSize:hiddenSize:layerCount:";
		static readonly NativeHandle selDescriptorWithInputSize_HiddenSize_LayerCount_XHandle = Selector.GetHandle ("descriptorWithInputSize:hiddenSize:layerCount:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDescriptorWithInputSize_HiddenSize_LayerCount_UsesBiases_BatchFirst_IsBidirectional_Dropout_X = "descriptorWithInputSize:hiddenSize:layerCount:usesBiases:batchFirst:isBidirectional:dropout:";
		static readonly NativeHandle selDescriptorWithInputSize_HiddenSize_LayerCount_UsesBiases_BatchFirst_IsBidirectional_Dropout_XHandle = Selector.GetHandle ("descriptorWithInputSize:hiddenSize:layerCount:usesBiases:batchFirst:isBidirectional:dropout:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDescriptorWithInputSize_HiddenSize_LayerCount_UsesBiases_BatchFirst_IsBidirectional_ReturnsSequences_Dropout_X = "descriptorWithInputSize:hiddenSize:layerCount:usesBiases:batchFirst:isBidirectional:returnsSequences:dropout:";
		static readonly NativeHandle selDescriptorWithInputSize_HiddenSize_LayerCount_UsesBiases_BatchFirst_IsBidirectional_ReturnsSequences_Dropout_XHandle = Selector.GetHandle ("descriptorWithInputSize:hiddenSize:layerCount:usesBiases:batchFirst:isBidirectional:returnsSequences:dropout:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDescriptorWithInputSize_HiddenSize_LayerCount_UsesBiases_BatchFirst_IsBidirectional_ReturnsSequences_Dropout_ResultMode_X = "descriptorWithInputSize:hiddenSize:layerCount:usesBiases:batchFirst:isBidirectional:returnsSequences:dropout:resultMode:";
		static readonly NativeHandle selDescriptorWithInputSize_HiddenSize_LayerCount_UsesBiases_BatchFirst_IsBidirectional_ReturnsSequences_Dropout_ResultMode_XHandle = Selector.GetHandle ("descriptorWithInputSize:hiddenSize:layerCount:usesBiases:batchFirst:isBidirectional:returnsSequences:dropout:resultMode:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDescriptorWithInputSize_HiddenSize_LayerCount_UsesBiases_IsBidirectional_Dropout_X = "descriptorWithInputSize:hiddenSize:layerCount:usesBiases:isBidirectional:dropout:";
		static readonly NativeHandle selDescriptorWithInputSize_HiddenSize_LayerCount_UsesBiases_IsBidirectional_Dropout_XHandle = Selector.GetHandle ("descriptorWithInputSize:hiddenSize:layerCount:usesBiases:isBidirectional:dropout:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDropoutX = "dropout";
		static readonly NativeHandle selDropoutXHandle = Selector.GetHandle ("dropout");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selHiddenSizeX = "hiddenSize";
		static readonly NativeHandle selHiddenSizeXHandle = Selector.GetHandle ("hiddenSize");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInputSizeX = "inputSize";
		static readonly NativeHandle selInputSizeXHandle = Selector.GetHandle ("inputSize");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsBidirectionalX = "isBidirectional";
		static readonly NativeHandle selIsBidirectionalXHandle = Selector.GetHandle ("isBidirectional");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLayerCountX = "layerCount";
		static readonly NativeHandle selLayerCountXHandle = Selector.GetHandle ("layerCount");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selResultModeX = "resultMode";
		static readonly NativeHandle selResultModeXHandle = Selector.GetHandle ("resultMode");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selReturnsSequencesX = "returnsSequences";
		static readonly NativeHandle selReturnsSequencesXHandle = Selector.GetHandle ("returnsSequences");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selUsesBiasesX = "usesBiases";
		static readonly NativeHandle selUsesBiasesXHandle = Selector.GetHandle ("usesBiases");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("MLCLSTMDescriptor");
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
		protected MLCLstmDescriptor (NSObjectFlag t) : base (t)
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
		protected internal MLCLstmDescriptor (NativeHandle handle) : base (handle)
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
		[Export ("descriptorWithInputSize:hiddenSize:layerCount:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MLCLstmDescriptor Create (nuint inputSize, nuint hiddenSize, nuint layerCount)
		{
			MLCLstmDescriptor ret;
			ret =  Runtime.GetNSObject<MLCLstmDescriptor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UIntPtr_UIntPtr_UIntPtr (class_ptr, selDescriptorWithInputSize_HiddenSize_LayerCount_XHandle, inputSize, hiddenSize, layerCount), false)!;
			return ret;
		}
		[Export ("descriptorWithInputSize:hiddenSize:layerCount:usesBiases:isBidirectional:dropout:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MLCLstmDescriptor Create (nuint inputSize, nuint hiddenSize, nuint layerCount, bool usesBiases, bool isBidirectional, float dropout)
		{
			MLCLstmDescriptor ret;
			ret =  Runtime.GetNSObject<MLCLstmDescriptor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UIntPtr_UIntPtr_UIntPtr_bool_bool_float (class_ptr, selDescriptorWithInputSize_HiddenSize_LayerCount_UsesBiases_IsBidirectional_Dropout_XHandle, inputSize, hiddenSize, layerCount, usesBiases ? (byte) 1 : (byte) 0, isBidirectional ? (byte) 1 : (byte) 0, dropout), false)!;
			return ret;
		}
		[Export ("descriptorWithInputSize:hiddenSize:layerCount:usesBiases:batchFirst:isBidirectional:dropout:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MLCLstmDescriptor Create (nuint inputSize, nuint hiddenSize, nuint layerCount, bool usesBiases, bool batchFirst, bool isBidirectional, float dropout)
		{
			MLCLstmDescriptor ret;
			ret =  Runtime.GetNSObject<MLCLstmDescriptor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UIntPtr_UIntPtr_UIntPtr_bool_bool_bool_float (class_ptr, selDescriptorWithInputSize_HiddenSize_LayerCount_UsesBiases_BatchFirst_IsBidirectional_Dropout_XHandle, inputSize, hiddenSize, layerCount, usesBiases ? (byte) 1 : (byte) 0, batchFirst ? (byte) 1 : (byte) 0, isBidirectional ? (byte) 1 : (byte) 0, dropout), false)!;
			return ret;
		}
		[Export ("descriptorWithInputSize:hiddenSize:layerCount:usesBiases:batchFirst:isBidirectional:returnsSequences:dropout:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MLCLstmDescriptor Create (nuint inputSize, nuint hiddenSize, nuint layerCount, bool usesBiases, bool batchFirst, bool isBidirectional, bool returnsSequences, float dropout)
		{
			MLCLstmDescriptor ret;
			ret =  Runtime.GetNSObject<MLCLstmDescriptor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UIntPtr_UIntPtr_UIntPtr_bool_bool_bool_bool_float (class_ptr, selDescriptorWithInputSize_HiddenSize_LayerCount_UsesBiases_BatchFirst_IsBidirectional_ReturnsSequences_Dropout_XHandle, inputSize, hiddenSize, layerCount, usesBiases ? (byte) 1 : (byte) 0, batchFirst ? (byte) 1 : (byte) 0, isBidirectional ? (byte) 1 : (byte) 0, returnsSequences ? (byte) 1 : (byte) 0, dropout), false)!;
			return ret;
		}
		[Export ("descriptorWithInputSize:hiddenSize:layerCount:usesBiases:batchFirst:isBidirectional:returnsSequences:dropout:resultMode:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MLCLstmDescriptor Create (nuint inputSize, nuint hiddenSize, nuint layerCount, bool usesBiases, bool batchFirst, bool isBidirectional, bool returnsSequences, float dropout, MLCLstmResultMode resultMode)
		{
			MLCLstmDescriptor ret;
			ret =  Runtime.GetNSObject<MLCLstmDescriptor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UIntPtr_UIntPtr_UIntPtr_bool_bool_bool_bool_float_UInt64 (class_ptr, selDescriptorWithInputSize_HiddenSize_LayerCount_UsesBiases_BatchFirst_IsBidirectional_ReturnsSequences_Dropout_ResultMode_XHandle, inputSize, hiddenSize, layerCount, usesBiases ? (byte) 1 : (byte) 0, batchFirst ? (byte) 1 : (byte) 0, isBidirectional ? (byte) 1 : (byte) 0, returnsSequences ? (byte) 1 : (byte) 0, dropout, (UInt64)resultMode), false)!;
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool BatchFirst {
			[Export ("batchFirst")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selBatchFirstXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selBatchFirstXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual float Dropout {
			[Export ("dropout")]
			get {
				float ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selDropoutXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.float_objc_msgSendSuper (&__objc_super__, selDropoutXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nuint HiddenSize {
			[Export ("hiddenSize")]
			get {
				nuint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selHiddenSizeXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selHiddenSizeXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nuint InputSize {
			[Export ("inputSize")]
			get {
				nuint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selInputSizeXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selInputSizeXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool IsBidirectional {
			[Export ("isBidirectional")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsBidirectionalXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsBidirectionalXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nuint LayerCount {
			[Export ("layerCount")]
			get {
				nuint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selLayerCountXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selLayerCountXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MLCLstmResultMode ResultMode {
			[Export ("resultMode")]
			get {
				MLCLstmResultMode ret;
				if (IsDirectBinding) {
					ret = (MLCLstmResultMode) global::ObjCRuntime.Messaging.UInt64_objc_msgSend (this.Handle, selResultModeXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (MLCLstmResultMode) global::ObjCRuntime.Messaging.UInt64_objc_msgSendSuper (&__objc_super__, selResultModeXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ReturnsSequences {
			[Export ("returnsSequences")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selReturnsSequencesXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selReturnsSequencesXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool UsesBiases {
			[Export ("usesBiases")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selUsesBiasesXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selUsesBiasesXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
	} /* class MLCLstmDescriptor */
}
