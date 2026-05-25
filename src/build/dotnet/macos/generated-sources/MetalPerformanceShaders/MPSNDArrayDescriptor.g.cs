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
	[Register("MPSNDArrayDescriptor", true)]
	[SupportedOSPlatform ("tvos13.0")]
	[SupportedOSPlatform ("ios13.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	public unsafe partial class MPSNDArrayDescriptor : NSObject {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDataTypeX = "dataType";
		static readonly NativeHandle selDataTypeXHandle = Selector.GetHandle ("dataType");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDescriptorWithDataType_DimensionCount_DimensionSizes_X = "descriptorWithDataType:dimensionCount:dimensionSizes:";
		static readonly NativeHandle selDescriptorWithDataType_DimensionCount_DimensionSizes_XHandle = Selector.GetHandle ("descriptorWithDataType:dimensionCount:dimensionSizes:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDescriptorWithDataType_Shape_X = "descriptorWithDataType:shape:";
		static readonly NativeHandle selDescriptorWithDataType_Shape_XHandle = Selector.GetHandle ("descriptorWithDataType:shape:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDimensionOrderX = "dimensionOrder";
		static readonly NativeHandle selDimensionOrderXHandle = Selector.GetHandle ("dimensionOrder");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selGetShapeX = "getShape";
		static readonly NativeHandle selGetShapeXHandle = Selector.GetHandle ("getShape");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLengthOfDimension_X = "lengthOfDimension:";
		static readonly NativeHandle selLengthOfDimension_XHandle = Selector.GetHandle ("lengthOfDimension:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selNumberOfDimensionsX = "numberOfDimensions";
		static readonly NativeHandle selNumberOfDimensionsXHandle = Selector.GetHandle ("numberOfDimensions");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPermuteWithDimensionOrder_X = "permuteWithDimensionOrder:";
		static readonly NativeHandle selPermuteWithDimensionOrder_XHandle = Selector.GetHandle ("permuteWithDimensionOrder:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPreferPackedRowsX = "preferPackedRows";
		static readonly NativeHandle selPreferPackedRowsXHandle = Selector.GetHandle ("preferPackedRows");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selReshapeWithDimensionCount_DimensionSizes_X = "reshapeWithDimensionCount:dimensionSizes:";
		static readonly NativeHandle selReshapeWithDimensionCount_DimensionSizes_XHandle = Selector.GetHandle ("reshapeWithDimensionCount:dimensionSizes:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selReshapeWithShape_X = "reshapeWithShape:";
		static readonly NativeHandle selReshapeWithShape_XHandle = Selector.GetHandle ("reshapeWithShape:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetDataType_X = "setDataType:";
		static readonly NativeHandle selSetDataType_XHandle = Selector.GetHandle ("setDataType:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetNumberOfDimensions_X = "setNumberOfDimensions:";
		static readonly NativeHandle selSetNumberOfDimensions_XHandle = Selector.GetHandle ("setNumberOfDimensions:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetPreferPackedRows_X = "setPreferPackedRows:";
		static readonly NativeHandle selSetPreferPackedRows_XHandle = Selector.GetHandle ("setPreferPackedRows:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSliceDimension_WithSubrange_X = "sliceDimension:withSubrange:";
		static readonly NativeHandle selSliceDimension_WithSubrange_XHandle = Selector.GetHandle ("sliceDimension:withSubrange:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSliceRangeForDimension_X = "sliceRangeForDimension:";
		static readonly NativeHandle selSliceRangeForDimension_XHandle = Selector.GetHandle ("sliceRangeForDimension:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTransposeDimension_WithDimension_X = "transposeDimension:withDimension:";
		static readonly NativeHandle selTransposeDimension_WithDimension_XHandle = Selector.GetHandle ("transposeDimension:withDimension:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("MPSNDArrayDescriptor");
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
		protected MPSNDArrayDescriptor (NSObjectFlag t) : base (t)
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
		protected internal MPSNDArrayDescriptor (NativeHandle handle) : base (handle)
		{
		}

		[Export ("descriptorWithDataType:dimensionCount:dimensionSizes:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSNDArrayDescriptor Create (MPSDataType dataType, nuint numberOfDimensions, nint dimensionSizes)
		{
			MPSNDArrayDescriptor ret;
			ret =  Runtime.GetNSObject<MPSNDArrayDescriptor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UInt32_UIntPtr_IntPtr (class_ptr, selDescriptorWithDataType_DimensionCount_DimensionSizes_XHandle, (UInt32)dataType, numberOfDimensions, dimensionSizes), false)!;
			return ret;
		}
		[Export ("descriptorWithDataType:shape:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSNDArrayDescriptor Create (MPSDataType dataType, [BindAs (typeof (nuint[]), OriginalType = typeof (NSNumber[]))] nuint[] shape)
		{
			if (shape is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (shape));
			using var nsb_shape = NSArray.FromNSObjects (o => new NSNumber (o), shape);
			MPSNDArrayDescriptor ret;
			ret =  Runtime.GetNSObject<MPSNDArrayDescriptor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UInt32_NativeHandle (class_ptr, selDescriptorWithDataType_Shape_XHandle, (UInt32)dataType, nsb_shape.GetHandle ()), false)!;
			return ret;
		}
		[Export ("lengthOfDimension:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nuint GetLength (nuint dimensionIndex)
		{
			nuint ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend_UIntPtr (this.Handle, selLengthOfDimension_XHandle, dimensionIndex);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper_UIntPtr (&__objc_super__, selLengthOfDimension_XHandle, dimensionIndex);
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("getShape")]
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[return: BindAs (typeof (nuint[]), OriginalType = typeof (NSNumber[]))]
		public virtual nuint[] GetShape ()
		{
			nuint[] ret;
			if (IsDirectBinding) {
				ret = NSArray.ArrayFromHandleFunc <nuint> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selGetShapeXHandle), NSNumber.ToNUInt, false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = NSArray.ArrayFromHandleFunc <nuint> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selGetShapeXHandle), NSNumber.ToNUInt, false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("sliceRangeForDimension:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MPSDimensionSlice GetSliceRange (nuint dimensionIndex)
		{
			MPSDimensionSlice ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.MPSDimensionSlice_objc_msgSend_UIntPtr (this.Handle, selSliceRangeForDimension_XHandle, dimensionIndex);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.MPSDimensionSlice_objc_msgSendSuper_UIntPtr (&__objc_super__, selSliceRangeForDimension_XHandle, dimensionIndex);
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("reshapeWithDimensionCount:dimensionSizes:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Reshape (nuint numberOfDimensions, nint dimensionSizes)
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr_IntPtr (this.Handle, selReshapeWithDimensionCount_DimensionSizes_XHandle, numberOfDimensions, dimensionSizes);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UIntPtr_IntPtr (&__objc_super__, selReshapeWithDimensionCount_DimensionSizes_XHandle, numberOfDimensions, dimensionSizes);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("reshapeWithShape:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Reshape ([BindAs (typeof (nuint[]), OriginalType = typeof (NSNumber[]))] nuint[] shape)
		{
			if (shape is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (shape));
			using var nsb_shape = NSArray.FromNSObjects (o => new NSNumber (o), shape);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selReshapeWithShape_XHandle, nsb_shape.GetHandle ());
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selReshapeWithShape_XHandle, nsb_shape.GetHandle ());
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("sliceDimension:withSubrange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Slice (nuint dimensionIndex, MPSDimensionSlice subRange)
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr_MPSDimensionSlice (this.Handle, selSliceDimension_WithSubrange_XHandle, dimensionIndex, subRange);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UIntPtr_MPSDimensionSlice (&__objc_super__, selSliceDimension_WithSubrange_XHandle, dimensionIndex, subRange);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("transposeDimension:withDimension:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Transpose (nuint dimensionIndex, nuint dimensionIndex2)
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr_UIntPtr (this.Handle, selTransposeDimension_WithDimension_XHandle, dimensionIndex, dimensionIndex2);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UIntPtr_UIntPtr (&__objc_super__, selTransposeDimension_WithDimension_XHandle, dimensionIndex, dimensionIndex2);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("permuteWithDimensionOrder:")]
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal virtual void _PermuteWithDimensionOrder (nint dimensionOrder)
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selPermuteWithDimensionOrder_XHandle, dimensionOrder);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, selPermuteWithDimensionOrder_XHandle, dimensionOrder);
					GC.KeepAlive (this);
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MPSDataType DataType {
			[Export ("dataType", ArgumentSemantic.Assign)]
			get {
				MPSDataType ret;
				if (IsDirectBinding) {
					ret = (MPSDataType) global::ObjCRuntime.Messaging.UInt32_objc_msgSend (this.Handle, selDataTypeXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (MPSDataType) global::ObjCRuntime.Messaging.UInt32_objc_msgSendSuper (&__objc_super__, selDataTypeXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setDataType:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_UInt32 (this.Handle, selSetDataType_XHandle, (UInt32)value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UInt32 (&__objc_super__, selSetDataType_XHandle, (UInt32)value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NVector16b DimensionOrder {
			[Export ("dimensionOrder")]
			get {
				NVector16b ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.xamarin_simd__NVector16b_objc_msgSend (this.Handle, selDimensionOrderXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.xamarin_simd__NVector16b_objc_msgSendSuper (&__objc_super__, selDimensionOrderXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nuint NumberOfDimensions {
			[Export ("numberOfDimensions")]
			get {
				nuint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selNumberOfDimensionsXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selNumberOfDimensionsXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setNumberOfDimensions:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (this.Handle, selSetNumberOfDimensions_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UIntPtr (&__objc_super__, selSetNumberOfDimensions_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		public virtual bool PreferPackedRows {
			[Export ("preferPackedRows")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selPreferPackedRowsXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selPreferPackedRowsXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setPreferPackedRows:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetPreferPackedRows_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetPreferPackedRows_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
	} /* class MPSNDArrayDescriptor */
}
