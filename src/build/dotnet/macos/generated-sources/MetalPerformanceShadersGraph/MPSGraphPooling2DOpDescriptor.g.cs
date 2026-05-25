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
namespace MetalPerformanceShadersGraph {
	[Register("MPSGraphPooling2DOpDescriptor", true)]
	[SupportedOSPlatform ("ios14.0")]
	[SupportedOSPlatform ("tvos14.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	public unsafe partial class MPSGraphPooling2DOpDescriptor : MPSGraphObject, INSCopying {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCeilModeX = "ceilMode";
		static readonly NativeHandle selCeilModeXHandle = Selector.GetHandle ("ceilMode");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCopyWithZone_X = "copyWithZone:";
		static readonly NativeHandle selCopyWithZone_XHandle = Selector.GetHandle ("copyWithZone:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDataLayoutX = "dataLayout";
		static readonly NativeHandle selDataLayoutXHandle = Selector.GetHandle ("dataLayout");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDescriptorWithKernelWidth_KernelHeight_StrideInX_StrideInY_DilationRateInX_DilationRateInY_PaddingLeft_PaddingRight_PaddingTop_PaddingBottom_PaddingStyle_DataLayout_X = "descriptorWithKernelWidth:kernelHeight:strideInX:strideInY:dilationRateInX:dilationRateInY:paddingLeft:paddingRight:paddingTop:paddingBottom:paddingStyle:dataLayout:";
		static readonly NativeHandle selDescriptorWithKernelWidth_KernelHeight_StrideInX_StrideInY_DilationRateInX_DilationRateInY_PaddingLeft_PaddingRight_PaddingTop_PaddingBottom_PaddingStyle_DataLayout_XHandle = Selector.GetHandle ("descriptorWithKernelWidth:kernelHeight:strideInX:strideInY:dilationRateInX:dilationRateInY:paddingLeft:paddingRight:paddingTop:paddingBottom:paddingStyle:dataLayout:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDescriptorWithKernelWidth_KernelHeight_StrideInX_StrideInY_PaddingStyle_DataLayout_X = "descriptorWithKernelWidth:kernelHeight:strideInX:strideInY:paddingStyle:dataLayout:";
		static readonly NativeHandle selDescriptorWithKernelWidth_KernelHeight_StrideInX_StrideInY_PaddingStyle_DataLayout_XHandle = Selector.GetHandle ("descriptorWithKernelWidth:kernelHeight:strideInX:strideInY:paddingStyle:dataLayout:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDilationRateInXX = "dilationRateInX";
		static readonly NativeHandle selDilationRateInXXHandle = Selector.GetHandle ("dilationRateInX");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDilationRateInYX = "dilationRateInY";
		static readonly NativeHandle selDilationRateInYXHandle = Selector.GetHandle ("dilationRateInY");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIncludeZeroPadToAverageX = "includeZeroPadToAverage";
		static readonly NativeHandle selIncludeZeroPadToAverageXHandle = Selector.GetHandle ("includeZeroPadToAverage");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selKernelHeightX = "kernelHeight";
		static readonly NativeHandle selKernelHeightXHandle = Selector.GetHandle ("kernelHeight");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selKernelWidthX = "kernelWidth";
		static readonly NativeHandle selKernelWidthXHandle = Selector.GetHandle ("kernelWidth");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPaddingBottomX = "paddingBottom";
		static readonly NativeHandle selPaddingBottomXHandle = Selector.GetHandle ("paddingBottom");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPaddingLeftX = "paddingLeft";
		static readonly NativeHandle selPaddingLeftXHandle = Selector.GetHandle ("paddingLeft");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPaddingRightX = "paddingRight";
		static readonly NativeHandle selPaddingRightXHandle = Selector.GetHandle ("paddingRight");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPaddingStyleX = "paddingStyle";
		static readonly NativeHandle selPaddingStyleXHandle = Selector.GetHandle ("paddingStyle");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPaddingTopX = "paddingTop";
		static readonly NativeHandle selPaddingTopXHandle = Selector.GetHandle ("paddingTop");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selReturnIndicesDataTypeX = "returnIndicesDataType";
		static readonly NativeHandle selReturnIndicesDataTypeXHandle = Selector.GetHandle ("returnIndicesDataType");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selReturnIndicesModeX = "returnIndicesMode";
		static readonly NativeHandle selReturnIndicesModeXHandle = Selector.GetHandle ("returnIndicesMode");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetCeilMode_X = "setCeilMode:";
		static readonly NativeHandle selSetCeilMode_XHandle = Selector.GetHandle ("setCeilMode:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetDataLayout_X = "setDataLayout:";
		static readonly NativeHandle selSetDataLayout_XHandle = Selector.GetHandle ("setDataLayout:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetDilationRateInX_X = "setDilationRateInX:";
		static readonly NativeHandle selSetDilationRateInX_XHandle = Selector.GetHandle ("setDilationRateInX:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetDilationRateInY_X = "setDilationRateInY:";
		static readonly NativeHandle selSetDilationRateInY_XHandle = Selector.GetHandle ("setDilationRateInY:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetExplicitPaddingWithPaddingLeft_PaddingRight_PaddingTop_PaddingBottom_X = "setExplicitPaddingWithPaddingLeft:paddingRight:paddingTop:paddingBottom:";
		static readonly NativeHandle selSetExplicitPaddingWithPaddingLeft_PaddingRight_PaddingTop_PaddingBottom_XHandle = Selector.GetHandle ("setExplicitPaddingWithPaddingLeft:paddingRight:paddingTop:paddingBottom:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetIncludeZeroPadToAverage_X = "setIncludeZeroPadToAverage:";
		static readonly NativeHandle selSetIncludeZeroPadToAverage_XHandle = Selector.GetHandle ("setIncludeZeroPadToAverage:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetKernelHeight_X = "setKernelHeight:";
		static readonly NativeHandle selSetKernelHeight_XHandle = Selector.GetHandle ("setKernelHeight:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetKernelWidth_X = "setKernelWidth:";
		static readonly NativeHandle selSetKernelWidth_XHandle = Selector.GetHandle ("setKernelWidth:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetPaddingBottom_X = "setPaddingBottom:";
		static readonly NativeHandle selSetPaddingBottom_XHandle = Selector.GetHandle ("setPaddingBottom:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetPaddingLeft_X = "setPaddingLeft:";
		static readonly NativeHandle selSetPaddingLeft_XHandle = Selector.GetHandle ("setPaddingLeft:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetPaddingRight_X = "setPaddingRight:";
		static readonly NativeHandle selSetPaddingRight_XHandle = Selector.GetHandle ("setPaddingRight:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetPaddingStyle_X = "setPaddingStyle:";
		static readonly NativeHandle selSetPaddingStyle_XHandle = Selector.GetHandle ("setPaddingStyle:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetPaddingTop_X = "setPaddingTop:";
		static readonly NativeHandle selSetPaddingTop_XHandle = Selector.GetHandle ("setPaddingTop:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetReturnIndicesDataType_X = "setReturnIndicesDataType:";
		static readonly NativeHandle selSetReturnIndicesDataType_XHandle = Selector.GetHandle ("setReturnIndicesDataType:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetReturnIndicesMode_X = "setReturnIndicesMode:";
		static readonly NativeHandle selSetReturnIndicesMode_XHandle = Selector.GetHandle ("setReturnIndicesMode:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetStrideInX_X = "setStrideInX:";
		static readonly NativeHandle selSetStrideInX_XHandle = Selector.GetHandle ("setStrideInX:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetStrideInY_X = "setStrideInY:";
		static readonly NativeHandle selSetStrideInY_XHandle = Selector.GetHandle ("setStrideInY:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selStrideInXX = "strideInX";
		static readonly NativeHandle selStrideInXXHandle = Selector.GetHandle ("strideInX");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selStrideInYX = "strideInY";
		static readonly NativeHandle selStrideInYXHandle = Selector.GetHandle ("strideInY");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("MPSGraphPooling2DOpDescriptor");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		/// <summary>Creates a new <see cref="MPSGraphPooling2DOpDescriptor" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public MPSGraphPooling2DOpDescriptor () : base (NSObjectFlag.Empty)
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
		protected MPSGraphPooling2DOpDescriptor (NSObjectFlag t) : base (t)
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
		protected internal MPSGraphPooling2DOpDescriptor (NativeHandle handle) : base (handle)
		{
		}

		/// <param name="zone">Developers should pass <see langword="null" />.  Memory zones are no longer used.</param><summary>Performs a copy of the underlying Objective-C object.</summary><returns>The newly-allocated object.</returns><remarks><para>This method performs a "shallow copy" of <see langword="this" />. If this object contains references to external objects, the new object will contain references to the same object.</para></remarks>
		[Export ("copyWithZone:")]
		[return: ReleaseAttribute ()]
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
		[Export ("descriptorWithKernelWidth:kernelHeight:strideInX:strideInY:dilationRateInX:dilationRateInY:paddingLeft:paddingRight:paddingTop:paddingBottom:paddingStyle:dataLayout:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphPooling2DOpDescriptor? Create (nuint kernelWidth, nuint kernelHeight, nuint strideInX, nuint strideInY, nuint dilationRateInX, nuint dilationRateInY, nuint paddingLeft, nuint paddingRight, nuint paddingTop, nuint paddingBottom, MPSGraphPaddingStyle paddingStyle, MPSGraphTensorNamedDataLayout dataLayout)
		{
			MPSGraphPooling2DOpDescriptor ret;
			ret =  Runtime.GetNSObject<MPSGraphPooling2DOpDescriptor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UIntPtr_UIntPtr_UIntPtr_UIntPtr_UIntPtr_UIntPtr_UIntPtr_UIntPtr_UIntPtr_UIntPtr_UIntPtr_UIntPtr (class_ptr, selDescriptorWithKernelWidth_KernelHeight_StrideInX_StrideInY_DilationRateInX_DilationRateInY_PaddingLeft_PaddingRight_PaddingTop_PaddingBottom_PaddingStyle_DataLayout_XHandle, kernelWidth, kernelHeight, strideInX, strideInY, dilationRateInX, dilationRateInY, paddingLeft, paddingRight, paddingTop, paddingBottom, (UIntPtr) (ulong) paddingStyle, (UIntPtr) (ulong) dataLayout), false)!;
			return ret;
		}
		[Export ("descriptorWithKernelWidth:kernelHeight:strideInX:strideInY:paddingStyle:dataLayout:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphPooling2DOpDescriptor? Create (nuint kernelWidth, nuint kernelHeight, nuint strideInX, nuint strideInY, MPSGraphPaddingStyle paddingStyle, MPSGraphTensorNamedDataLayout dataLayout)
		{
			MPSGraphPooling2DOpDescriptor ret;
			ret =  Runtime.GetNSObject<MPSGraphPooling2DOpDescriptor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UIntPtr_UIntPtr_UIntPtr_UIntPtr_UIntPtr_UIntPtr (class_ptr, selDescriptorWithKernelWidth_KernelHeight_StrideInX_StrideInY_PaddingStyle_DataLayout_XHandle, kernelWidth, kernelHeight, strideInX, strideInY, (UIntPtr) (ulong) paddingStyle, (UIntPtr) (ulong) dataLayout), false)!;
			return ret;
		}
		[Export ("setExplicitPaddingWithPaddingLeft:paddingRight:paddingTop:paddingBottom:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetExplicitPadding (nuint paddingLeft, nuint paddingRight, nuint paddingTop, nuint paddingBottom)
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr_UIntPtr_UIntPtr_UIntPtr (this.Handle, selSetExplicitPaddingWithPaddingLeft_PaddingRight_PaddingTop_PaddingBottom_XHandle, paddingLeft, paddingRight, paddingTop, paddingBottom);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UIntPtr_UIntPtr_UIntPtr_UIntPtr (&__objc_super__, selSetExplicitPaddingWithPaddingLeft_PaddingRight_PaddingTop_PaddingBottom_XHandle, paddingLeft, paddingRight, paddingTop, paddingBottom);
					GC.KeepAlive (this);
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public virtual bool CeilMode {
			[Export ("ceilMode")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selCeilModeXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selCeilModeXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setCeilMode:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetCeilMode_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetCeilMode_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MPSGraphTensorNamedDataLayout DataLayout {
			[Export ("dataLayout", ArgumentSemantic.Assign)]
			get {
				MPSGraphTensorNamedDataLayout ret;
				if (IsDirectBinding) {
					ret = (MPSGraphTensorNamedDataLayout) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selDataLayoutXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (MPSGraphTensorNamedDataLayout) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selDataLayoutXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setDataLayout:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (this.Handle, selSetDataLayout_XHandle, (UIntPtr) (ulong) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UIntPtr (&__objc_super__, selSetDataLayout_XHandle, (UIntPtr) (ulong) value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nuint DilationRateInX {
			[Export ("dilationRateInX")]
			get {
				nuint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selDilationRateInXXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selDilationRateInXXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setDilationRateInX:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (this.Handle, selSetDilationRateInX_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UIntPtr (&__objc_super__, selSetDilationRateInX_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nuint DilationRateInY {
			[Export ("dilationRateInY")]
			get {
				nuint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selDilationRateInYXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selDilationRateInYXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setDilationRateInY:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (this.Handle, selSetDilationRateInY_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UIntPtr (&__objc_super__, selSetDilationRateInY_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public virtual bool IncludeZeroPadToAverage {
			[Export ("includeZeroPadToAverage")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIncludeZeroPadToAverageXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIncludeZeroPadToAverageXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setIncludeZeroPadToAverage:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetIncludeZeroPadToAverage_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetIncludeZeroPadToAverage_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nuint KernelHeight {
			[Export ("kernelHeight")]
			get {
				nuint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selKernelHeightXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selKernelHeightXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setKernelHeight:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (this.Handle, selSetKernelHeight_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UIntPtr (&__objc_super__, selSetKernelHeight_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nuint KernelWidth {
			[Export ("kernelWidth")]
			get {
				nuint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selKernelWidthXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selKernelWidthXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setKernelWidth:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (this.Handle, selSetKernelWidth_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UIntPtr (&__objc_super__, selSetKernelWidth_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nuint PaddingBottom {
			[Export ("paddingBottom")]
			get {
				nuint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selPaddingBottomXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selPaddingBottomXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setPaddingBottom:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (this.Handle, selSetPaddingBottom_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UIntPtr (&__objc_super__, selSetPaddingBottom_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nuint PaddingLeft {
			[Export ("paddingLeft")]
			get {
				nuint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selPaddingLeftXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selPaddingLeftXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setPaddingLeft:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (this.Handle, selSetPaddingLeft_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UIntPtr (&__objc_super__, selSetPaddingLeft_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nuint PaddingRight {
			[Export ("paddingRight")]
			get {
				nuint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selPaddingRightXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selPaddingRightXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setPaddingRight:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (this.Handle, selSetPaddingRight_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UIntPtr (&__objc_super__, selSetPaddingRight_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MPSGraphPaddingStyle PaddingStyle {
			[Export ("paddingStyle", ArgumentSemantic.Assign)]
			get {
				MPSGraphPaddingStyle ret;
				if (IsDirectBinding) {
					ret = (MPSGraphPaddingStyle) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selPaddingStyleXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (MPSGraphPaddingStyle) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selPaddingStyleXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setPaddingStyle:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (this.Handle, selSetPaddingStyle_XHandle, (UIntPtr) (ulong) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UIntPtr (&__objc_super__, selSetPaddingStyle_XHandle, (UIntPtr) (ulong) value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nuint PaddingTop {
			[Export ("paddingTop")]
			get {
				nuint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selPaddingTopXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selPaddingTopXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setPaddingTop:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (this.Handle, selSetPaddingTop_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UIntPtr (&__objc_super__, selSetPaddingTop_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos15.3")]
		[SupportedOSPlatform ("macos12.2")]
		[SupportedOSPlatform ("ios15.3")]
		[SupportedOSPlatform ("maccatalyst15.3")]
		public virtual global::MetalPerformanceShaders.MPSDataType ReturnIndicesDataType {
			[Export ("returnIndicesDataType", ArgumentSemantic.Assign)]
			get {
				global::MetalPerformanceShaders.MPSDataType ret;
				if (IsDirectBinding) {
					ret = (global::MetalPerformanceShaders.MPSDataType) global::ObjCRuntime.Messaging.UInt32_objc_msgSend (this.Handle, selReturnIndicesDataTypeXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (global::MetalPerformanceShaders.MPSDataType) global::ObjCRuntime.Messaging.UInt32_objc_msgSendSuper (&__objc_super__, selReturnIndicesDataTypeXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setReturnIndicesDataType:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_UInt32 (this.Handle, selSetReturnIndicesDataType_XHandle, (UInt32)value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UInt32 (&__objc_super__, selSetReturnIndicesDataType_XHandle, (UInt32)value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos15.3")]
		[SupportedOSPlatform ("macos12.2")]
		[SupportedOSPlatform ("ios15.3")]
		[SupportedOSPlatform ("maccatalyst15.3")]
		public virtual MPSGraphPoolingReturnIndicesMode ReturnIndicesMode {
			[Export ("returnIndicesMode", ArgumentSemantic.Assign)]
			get {
				MPSGraphPoolingReturnIndicesMode ret;
				if (IsDirectBinding) {
					ret = (MPSGraphPoolingReturnIndicesMode) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selReturnIndicesModeXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (MPSGraphPoolingReturnIndicesMode) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selReturnIndicesModeXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setReturnIndicesMode:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (this.Handle, selSetReturnIndicesMode_XHandle, (UIntPtr) (ulong) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UIntPtr (&__objc_super__, selSetReturnIndicesMode_XHandle, (UIntPtr) (ulong) value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nuint StrideInX {
			[Export ("strideInX")]
			get {
				nuint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selStrideInXXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selStrideInXXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setStrideInX:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (this.Handle, selSetStrideInX_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UIntPtr (&__objc_super__, selSetStrideInX_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nuint StrideInY {
			[Export ("strideInY")]
			get {
				nuint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selStrideInYXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selStrideInYXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setStrideInY:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (this.Handle, selSetStrideInY_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UIntPtr (&__objc_super__, selSetStrideInY_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
	} /* class MPSGraphPooling2DOpDescriptor */
}
