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
	/// <summary>Describes a Long-Short Term Memory layer in neural net.</summary>
	[Register("MPSLSTMDescriptor", true)]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe partial class MPSLSTMDescriptor : MPSRnnDescriptor {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCellGateInputWeightsX = "cellGateInputWeights";
		static readonly NativeHandle selCellGateInputWeightsXHandle = Selector.GetHandle ("cellGateInputWeights");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCellGateMemoryWeightsX = "cellGateMemoryWeights";
		static readonly NativeHandle selCellGateMemoryWeightsXHandle = Selector.GetHandle ("cellGateMemoryWeights");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCellGateRecurrentWeightsX = "cellGateRecurrentWeights";
		static readonly NativeHandle selCellGateRecurrentWeightsXHandle = Selector.GetHandle ("cellGateRecurrentWeights");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCellToOutputNeuronParamAX = "cellToOutputNeuronParamA";
		static readonly NativeHandle selCellToOutputNeuronParamAXHandle = Selector.GetHandle ("cellToOutputNeuronParamA");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCellToOutputNeuronParamBX = "cellToOutputNeuronParamB";
		static readonly NativeHandle selCellToOutputNeuronParamBXHandle = Selector.GetHandle ("cellToOutputNeuronParamB");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCellToOutputNeuronParamCX = "cellToOutputNeuronParamC";
		static readonly NativeHandle selCellToOutputNeuronParamCXHandle = Selector.GetHandle ("cellToOutputNeuronParamC");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCellToOutputNeuronTypeX = "cellToOutputNeuronType";
		static readonly NativeHandle selCellToOutputNeuronTypeXHandle = Selector.GetHandle ("cellToOutputNeuronType");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCreateLSTMDescriptorWithInputFeatureChannels_OutputFeatureChannels_X = "createLSTMDescriptorWithInputFeatureChannels:outputFeatureChannels:";
		static readonly NativeHandle selCreateLSTMDescriptorWithInputFeatureChannels_OutputFeatureChannels_XHandle = Selector.GetHandle ("createLSTMDescriptorWithInputFeatureChannels:outputFeatureChannels:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selForgetGateInputWeightsX = "forgetGateInputWeights";
		static readonly NativeHandle selForgetGateInputWeightsXHandle = Selector.GetHandle ("forgetGateInputWeights");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selForgetGateMemoryWeightsX = "forgetGateMemoryWeights";
		static readonly NativeHandle selForgetGateMemoryWeightsXHandle = Selector.GetHandle ("forgetGateMemoryWeights");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selForgetGateRecurrentWeightsX = "forgetGateRecurrentWeights";
		static readonly NativeHandle selForgetGateRecurrentWeightsXHandle = Selector.GetHandle ("forgetGateRecurrentWeights");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInputGateInputWeightsX = "inputGateInputWeights";
		static readonly NativeHandle selInputGateInputWeightsXHandle = Selector.GetHandle ("inputGateInputWeights");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInputGateMemoryWeightsX = "inputGateMemoryWeights";
		static readonly NativeHandle selInputGateMemoryWeightsXHandle = Selector.GetHandle ("inputGateMemoryWeights");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInputGateRecurrentWeightsX = "inputGateRecurrentWeights";
		static readonly NativeHandle selInputGateRecurrentWeightsXHandle = Selector.GetHandle ("inputGateRecurrentWeights");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMemoryWeightsAreDiagonalX = "memoryWeightsAreDiagonal";
		static readonly NativeHandle selMemoryWeightsAreDiagonalXHandle = Selector.GetHandle ("memoryWeightsAreDiagonal");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selOutputGateInputWeightsX = "outputGateInputWeights";
		static readonly NativeHandle selOutputGateInputWeightsXHandle = Selector.GetHandle ("outputGateInputWeights");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selOutputGateMemoryWeightsX = "outputGateMemoryWeights";
		static readonly NativeHandle selOutputGateMemoryWeightsXHandle = Selector.GetHandle ("outputGateMemoryWeights");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selOutputGateRecurrentWeightsX = "outputGateRecurrentWeights";
		static readonly NativeHandle selOutputGateRecurrentWeightsXHandle = Selector.GetHandle ("outputGateRecurrentWeights");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetCellGateInputWeights_X = "setCellGateInputWeights:";
		static readonly NativeHandle selSetCellGateInputWeights_XHandle = Selector.GetHandle ("setCellGateInputWeights:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetCellGateMemoryWeights_X = "setCellGateMemoryWeights:";
		static readonly NativeHandle selSetCellGateMemoryWeights_XHandle = Selector.GetHandle ("setCellGateMemoryWeights:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetCellGateRecurrentWeights_X = "setCellGateRecurrentWeights:";
		static readonly NativeHandle selSetCellGateRecurrentWeights_XHandle = Selector.GetHandle ("setCellGateRecurrentWeights:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetCellToOutputNeuronParamA_X = "setCellToOutputNeuronParamA:";
		static readonly NativeHandle selSetCellToOutputNeuronParamA_XHandle = Selector.GetHandle ("setCellToOutputNeuronParamA:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetCellToOutputNeuronParamB_X = "setCellToOutputNeuronParamB:";
		static readonly NativeHandle selSetCellToOutputNeuronParamB_XHandle = Selector.GetHandle ("setCellToOutputNeuronParamB:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetCellToOutputNeuronParamC_X = "setCellToOutputNeuronParamC:";
		static readonly NativeHandle selSetCellToOutputNeuronParamC_XHandle = Selector.GetHandle ("setCellToOutputNeuronParamC:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetCellToOutputNeuronType_X = "setCellToOutputNeuronType:";
		static readonly NativeHandle selSetCellToOutputNeuronType_XHandle = Selector.GetHandle ("setCellToOutputNeuronType:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetForgetGateInputWeights_X = "setForgetGateInputWeights:";
		static readonly NativeHandle selSetForgetGateInputWeights_XHandle = Selector.GetHandle ("setForgetGateInputWeights:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetForgetGateMemoryWeights_X = "setForgetGateMemoryWeights:";
		static readonly NativeHandle selSetForgetGateMemoryWeights_XHandle = Selector.GetHandle ("setForgetGateMemoryWeights:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetForgetGateRecurrentWeights_X = "setForgetGateRecurrentWeights:";
		static readonly NativeHandle selSetForgetGateRecurrentWeights_XHandle = Selector.GetHandle ("setForgetGateRecurrentWeights:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetInputGateInputWeights_X = "setInputGateInputWeights:";
		static readonly NativeHandle selSetInputGateInputWeights_XHandle = Selector.GetHandle ("setInputGateInputWeights:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetInputGateMemoryWeights_X = "setInputGateMemoryWeights:";
		static readonly NativeHandle selSetInputGateMemoryWeights_XHandle = Selector.GetHandle ("setInputGateMemoryWeights:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetInputGateRecurrentWeights_X = "setInputGateRecurrentWeights:";
		static readonly NativeHandle selSetInputGateRecurrentWeights_XHandle = Selector.GetHandle ("setInputGateRecurrentWeights:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetMemoryWeightsAreDiagonal_X = "setMemoryWeightsAreDiagonal:";
		static readonly NativeHandle selSetMemoryWeightsAreDiagonal_XHandle = Selector.GetHandle ("setMemoryWeightsAreDiagonal:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetOutputGateInputWeights_X = "setOutputGateInputWeights:";
		static readonly NativeHandle selSetOutputGateInputWeights_XHandle = Selector.GetHandle ("setOutputGateInputWeights:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetOutputGateMemoryWeights_X = "setOutputGateMemoryWeights:";
		static readonly NativeHandle selSetOutputGateMemoryWeights_XHandle = Selector.GetHandle ("setOutputGateMemoryWeights:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetOutputGateRecurrentWeights_X = "setOutputGateRecurrentWeights:";
		static readonly NativeHandle selSetOutputGateRecurrentWeights_XHandle = Selector.GetHandle ("setOutputGateRecurrentWeights:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("MPSLSTMDescriptor");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		/// <summary>Creates a new <see cref="MPSLSTMDescriptor" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public MPSLSTMDescriptor () : base (NSObjectFlag.Empty)
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
		protected MPSLSTMDescriptor (NSObjectFlag t) : base (t)
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
		protected internal MPSLSTMDescriptor (NativeHandle handle) : base (handle)
		{
		}

		/// <param name="inputFeatureChannels">To be added.</param><param name="outputFeatureChannels">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("createLSTMDescriptorWithInputFeatureChannels:outputFeatureChannels:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSLSTMDescriptor Create (nuint inputFeatureChannels, nuint outputFeatureChannels)
		{
			MPSLSTMDescriptor ret;
			ret =  Runtime.GetNSObject<MPSLSTMDescriptor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UIntPtr_UIntPtr (class_ptr, selCreateLSTMDescriptorWithInputFeatureChannels_OutputFeatureChannels_XHandle, inputFeatureChannels, outputFeatureChannels), false)!;
			return ret;
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool AreMemoryWeightsDiagonal {
			[Export ("memoryWeightsAreDiagonal")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selMemoryWeightsAreDiagonalXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selMemoryWeightsAreDiagonalXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setMemoryWeightsAreDiagonal:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetMemoryWeightsAreDiagonal_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetMemoryWeightsAreDiagonal_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>To be added.</summary><value><para>(More documentation for this node is coming)</para><para tool="nullallowed">This value can be <see langword="null" />.</para></value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual IMPSCnnConvolutionDataSource? CellGateInputWeights {
			[Export ("cellGateInputWeights", ArgumentSemantic.Retain)]
			get {
				IMPSCnnConvolutionDataSource? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetINativeObject<IMPSCnnConvolutionDataSource> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selCellGateInputWeightsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetINativeObject<IMPSCnnConvolutionDataSource> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selCellGateInputWeightsXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setCellGateInputWeights:", ArgumentSemantic.Retain)]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetCellGateInputWeights_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetCellGateInputWeights_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		/// <summary>To be added.</summary><value><para>(More documentation for this node is coming)</para><para tool="nullallowed">This value can be <see langword="null" />.</para></value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual IMPSCnnConvolutionDataSource? CellGateMemoryWeights {
			[Export ("cellGateMemoryWeights", ArgumentSemantic.Retain)]
			get {
				IMPSCnnConvolutionDataSource? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetINativeObject<IMPSCnnConvolutionDataSource> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selCellGateMemoryWeightsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetINativeObject<IMPSCnnConvolutionDataSource> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selCellGateMemoryWeightsXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setCellGateMemoryWeights:", ArgumentSemantic.Retain)]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetCellGateMemoryWeights_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetCellGateMemoryWeights_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		/// <summary>To be added.</summary><value><para>(More documentation for this node is coming)</para><para tool="nullallowed">This value can be <see langword="null" />.</para></value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual IMPSCnnConvolutionDataSource? CellGateRecurrentWeights {
			[Export ("cellGateRecurrentWeights", ArgumentSemantic.Retain)]
			get {
				IMPSCnnConvolutionDataSource? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetINativeObject<IMPSCnnConvolutionDataSource> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selCellGateRecurrentWeightsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetINativeObject<IMPSCnnConvolutionDataSource> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selCellGateRecurrentWeightsXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setCellGateRecurrentWeights:", ArgumentSemantic.Retain)]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetCellGateRecurrentWeights_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetCellGateRecurrentWeights_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual float CellToOutputNeuronParamA {
			[Export ("cellToOutputNeuronParamA")]
			get {
				float ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selCellToOutputNeuronParamAXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.float_objc_msgSendSuper (&__objc_super__, selCellToOutputNeuronParamAXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setCellToOutputNeuronParamA:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, selSetCellToOutputNeuronParamA_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_float (&__objc_super__, selSetCellToOutputNeuronParamA_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual float CellToOutputNeuronParamB {
			[Export ("cellToOutputNeuronParamB")]
			get {
				float ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selCellToOutputNeuronParamBXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.float_objc_msgSendSuper (&__objc_super__, selCellToOutputNeuronParamBXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setCellToOutputNeuronParamB:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, selSetCellToOutputNeuronParamB_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_float (&__objc_super__, selSetCellToOutputNeuronParamB_XHandle, value);
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
		public virtual float CellToOutputNeuronParamC {
			[Export ("cellToOutputNeuronParamC")]
			get {
				float ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selCellToOutputNeuronParamCXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.float_objc_msgSendSuper (&__objc_super__, selCellToOutputNeuronParamCXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setCellToOutputNeuronParamC:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, selSetCellToOutputNeuronParamC_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_float (&__objc_super__, selSetCellToOutputNeuronParamC_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MPSCnnNeuronType CellToOutputNeuronType {
			[Export ("cellToOutputNeuronType", ArgumentSemantic.Assign)]
			get {
				MPSCnnNeuronType ret;
				if (IsDirectBinding) {
					ret = (MPSCnnNeuronType) global::ObjCRuntime.Messaging.int_objc_msgSend (this.Handle, selCellToOutputNeuronTypeXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (MPSCnnNeuronType) global::ObjCRuntime.Messaging.int_objc_msgSendSuper (&__objc_super__, selCellToOutputNeuronTypeXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setCellToOutputNeuronType:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_int (this.Handle, selSetCellToOutputNeuronType_XHandle, (int)value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_int (&__objc_super__, selSetCellToOutputNeuronType_XHandle, (int)value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>To be added.</summary><value><para>(More documentation for this node is coming)</para><para tool="nullallowed">This value can be <see langword="null" />.</para></value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual IMPSCnnConvolutionDataSource? ForgetGateInputWeights {
			[Export ("forgetGateInputWeights", ArgumentSemantic.Retain)]
			get {
				IMPSCnnConvolutionDataSource? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetINativeObject<IMPSCnnConvolutionDataSource> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selForgetGateInputWeightsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetINativeObject<IMPSCnnConvolutionDataSource> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selForgetGateInputWeightsXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setForgetGateInputWeights:", ArgumentSemantic.Retain)]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetForgetGateInputWeights_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetForgetGateInputWeights_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		/// <summary>To be added.</summary><value><para>(More documentation for this node is coming)</para><para tool="nullallowed">This value can be <see langword="null" />.</para></value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual IMPSCnnConvolutionDataSource? ForgetGateMemoryWeights {
			[Export ("forgetGateMemoryWeights", ArgumentSemantic.Retain)]
			get {
				IMPSCnnConvolutionDataSource? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetINativeObject<IMPSCnnConvolutionDataSource> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selForgetGateMemoryWeightsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetINativeObject<IMPSCnnConvolutionDataSource> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selForgetGateMemoryWeightsXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setForgetGateMemoryWeights:", ArgumentSemantic.Retain)]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetForgetGateMemoryWeights_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetForgetGateMemoryWeights_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		/// <summary>To be added.</summary><value><para>(More documentation for this node is coming)</para><para tool="nullallowed">This value can be <see langword="null" />.</para></value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual IMPSCnnConvolutionDataSource? ForgetGateRecurrentWeights {
			[Export ("forgetGateRecurrentWeights", ArgumentSemantic.Retain)]
			get {
				IMPSCnnConvolutionDataSource? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetINativeObject<IMPSCnnConvolutionDataSource> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selForgetGateRecurrentWeightsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetINativeObject<IMPSCnnConvolutionDataSource> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selForgetGateRecurrentWeightsXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setForgetGateRecurrentWeights:", ArgumentSemantic.Retain)]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetForgetGateRecurrentWeights_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetForgetGateRecurrentWeights_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		/// <summary>To be added.</summary><value><para>(More documentation for this node is coming)</para><para tool="nullallowed">This value can be <see langword="null" />.</para></value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual IMPSCnnConvolutionDataSource? InputGateInputWeights {
			[Export ("inputGateInputWeights", ArgumentSemantic.Retain)]
			get {
				IMPSCnnConvolutionDataSource? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetINativeObject<IMPSCnnConvolutionDataSource> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selInputGateInputWeightsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetINativeObject<IMPSCnnConvolutionDataSource> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selInputGateInputWeightsXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setInputGateInputWeights:", ArgumentSemantic.Retain)]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetInputGateInputWeights_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetInputGateInputWeights_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		/// <summary>To be added.</summary><value><para>(More documentation for this node is coming)</para><para tool="nullallowed">This value can be <see langword="null" />.</para></value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual IMPSCnnConvolutionDataSource? InputGateMemoryWeights {
			[Export ("inputGateMemoryWeights", ArgumentSemantic.Retain)]
			get {
				IMPSCnnConvolutionDataSource? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetINativeObject<IMPSCnnConvolutionDataSource> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selInputGateMemoryWeightsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetINativeObject<IMPSCnnConvolutionDataSource> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selInputGateMemoryWeightsXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setInputGateMemoryWeights:", ArgumentSemantic.Retain)]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetInputGateMemoryWeights_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetInputGateMemoryWeights_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		/// <summary>To be added.</summary><value><para>(More documentation for this node is coming)</para><para tool="nullallowed">This value can be <see langword="null" />.</para></value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual IMPSCnnConvolutionDataSource? InputGateRecurrentWeights {
			[Export ("inputGateRecurrentWeights", ArgumentSemantic.Retain)]
			get {
				IMPSCnnConvolutionDataSource? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetINativeObject<IMPSCnnConvolutionDataSource> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selInputGateRecurrentWeightsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetINativeObject<IMPSCnnConvolutionDataSource> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selInputGateRecurrentWeightsXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setInputGateRecurrentWeights:", ArgumentSemantic.Retain)]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetInputGateRecurrentWeights_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetInputGateRecurrentWeights_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		/// <summary>To be added.</summary><value><para>(More documentation for this node is coming)</para><para tool="nullallowed">This value can be <see langword="null" />.</para></value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual IMPSCnnConvolutionDataSource? OutputGateInputWeights {
			[Export ("outputGateInputWeights", ArgumentSemantic.Retain)]
			get {
				IMPSCnnConvolutionDataSource? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetINativeObject<IMPSCnnConvolutionDataSource> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selOutputGateInputWeightsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetINativeObject<IMPSCnnConvolutionDataSource> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selOutputGateInputWeightsXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setOutputGateInputWeights:", ArgumentSemantic.Retain)]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetOutputGateInputWeights_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetOutputGateInputWeights_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		/// <summary>To be added.</summary><value><para>(More documentation for this node is coming)</para><para tool="nullallowed">This value can be <see langword="null" />.</para></value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual IMPSCnnConvolutionDataSource? OutputGateMemoryWeights {
			[Export ("outputGateMemoryWeights", ArgumentSemantic.Retain)]
			get {
				IMPSCnnConvolutionDataSource? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetINativeObject<IMPSCnnConvolutionDataSource> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selOutputGateMemoryWeightsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetINativeObject<IMPSCnnConvolutionDataSource> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selOutputGateMemoryWeightsXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setOutputGateMemoryWeights:", ArgumentSemantic.Retain)]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetOutputGateMemoryWeights_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetOutputGateMemoryWeights_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		/// <summary>To be added.</summary><value><para>(More documentation for this node is coming)</para><para tool="nullallowed">This value can be <see langword="null" />.</para></value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual IMPSCnnConvolutionDataSource? OutputGateRecurrentWeights {
			[Export ("outputGateRecurrentWeights", ArgumentSemantic.Retain)]
			get {
				IMPSCnnConvolutionDataSource? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetINativeObject<IMPSCnnConvolutionDataSource> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selOutputGateRecurrentWeightsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetINativeObject<IMPSCnnConvolutionDataSource> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selOutputGateRecurrentWeightsXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setOutputGateRecurrentWeights:", ArgumentSemantic.Retain)]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetOutputGateRecurrentWeights_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetOutputGateRecurrentWeights_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
	} /* class MPSLSTMDescriptor */
}
