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
namespace CoreML {
	/// <summary>Represents an efficient multi-dimensional array.</summary>
	[Register("MLMultiArray", true)]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe partial class MLMultiArray : NSObject, INSCoding, INSSecureCoding {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCountX = "count";
		static readonly NativeHandle selCountXHandle = Selector.GetHandle ("count");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDataPointerX = "dataPointer";
		static readonly NativeHandle selDataPointerXHandle = Selector.GetHandle ("dataPointer");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDataTypeX = "dataType";
		static readonly NativeHandle selDataTypeXHandle = Selector.GetHandle ("dataType");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selEncodeWithCoder_X = "encodeWithCoder:";
		static readonly NativeHandle selEncodeWithCoder_XHandle = Selector.GetHandle ("encodeWithCoder:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selGetBytesWithHandler_X = "getBytesWithHandler:";
		static readonly NativeHandle selGetBytesWithHandler_XHandle = Selector.GetHandle ("getBytesWithHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selGetMutableBytesWithHandler_X = "getMutableBytesWithHandler:";
		static readonly NativeHandle selGetMutableBytesWithHandler_XHandle = Selector.GetHandle ("getMutableBytesWithHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithCoder_X = "initWithCoder:";
		static readonly NativeHandle selInitWithCoder_XHandle = Selector.GetHandle ("initWithCoder:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithDataPointer_Shape_DataType_Strides_Deallocator_Error_X = "initWithDataPointer:shape:dataType:strides:deallocator:error:";
		static readonly NativeHandle selInitWithDataPointer_Shape_DataType_Strides_Deallocator_Error_XHandle = Selector.GetHandle ("initWithDataPointer:shape:dataType:strides:deallocator:error:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithPixelBuffer_Shape_X = "initWithPixelBuffer:shape:";
		static readonly NativeHandle selInitWithPixelBuffer_Shape_XHandle = Selector.GetHandle ("initWithPixelBuffer:shape:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithShape_DataType_Error_X = "initWithShape:dataType:error:";
		static readonly NativeHandle selInitWithShape_DataType_Error_XHandle = Selector.GetHandle ("initWithShape:dataType:error:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithShape_DataType_Strides_X = "initWithShape:dataType:strides:";
		static readonly NativeHandle selInitWithShape_DataType_Strides_XHandle = Selector.GetHandle ("initWithShape:dataType:strides:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMultiArrayByConcatenatingMultiArrays_AlongAxis_DataType_X = "multiArrayByConcatenatingMultiArrays:alongAxis:dataType:";
		static readonly NativeHandle selMultiArrayByConcatenatingMultiArrays_AlongAxis_DataType_XHandle = Selector.GetHandle ("multiArrayByConcatenatingMultiArrays:alongAxis:dataType:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selObjectAtIndexedSubscript_X = "objectAtIndexedSubscript:";
		static readonly NativeHandle selObjectAtIndexedSubscript_XHandle = Selector.GetHandle ("objectAtIndexedSubscript:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selObjectForKeyedSubscript_X = "objectForKeyedSubscript:";
		static readonly NativeHandle selObjectForKeyedSubscript_XHandle = Selector.GetHandle ("objectForKeyedSubscript:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPixelBufferX = "pixelBuffer";
		static readonly NativeHandle selPixelBufferXHandle = Selector.GetHandle ("pixelBuffer");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetObject_AtIndexedSubscript_X = "setObject:atIndexedSubscript:";
		static readonly NativeHandle selSetObject_AtIndexedSubscript_XHandle = Selector.GetHandle ("setObject:atIndexedSubscript:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetObject_ForKeyedSubscript_X = "setObject:forKeyedSubscript:";
		static readonly NativeHandle selSetObject_ForKeyedSubscript_XHandle = Selector.GetHandle ("setObject:forKeyedSubscript:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selShapeX = "shape";
		static readonly NativeHandle selShapeXHandle = Selector.GetHandle ("shape");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selStridesX = "strides";
		static readonly NativeHandle selStridesXHandle = Selector.GetHandle ("strides");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTransferToMultiArray_X = "transferToMultiArray:";
		static readonly NativeHandle selTransferToMultiArray_XHandle = Selector.GetHandle ("transferToMultiArray:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("MLMultiArray");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
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
		public MLMultiArray (NSCoder coder) : base (NSObjectFlag.Empty)
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
		protected MLMultiArray (NSObjectFlag t) : base (t)
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
		protected internal MLMultiArray (NativeHandle handle) : base (handle)
		{
		}

		/// <param name="shape">To be added.</param><param name="dataType">To be added.</param><param name="error">To be added.</param><summary>Creates a new MLMultiArray with the specified shape and data type.</summary><remarks>To be added.</remarks>
		[Export ("initWithShape:dataType:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe MLMultiArray (NSNumber[] shape, MLMultiArrayDataType dataType, out NSError error)
			: base (NSObjectFlag.Empty)
		{
			if (shape is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (shape));
			NativeHandle errorValue = IntPtr.Zero;
			using var nsa_shape = NSArray.FromNSObjects (shape);
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_IntPtr_ref_NativeHandle (this.Handle, selInitWithShape_DataType_Error_XHandle, nsa_shape.Handle, (IntPtr) (long) dataType, &errorValue), "initWithShape:dataType:error:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_IntPtr_ref_NativeHandle (&__objc_super__, selInitWithShape_DataType_Error_XHandle, nsa_shape.Handle, (IntPtr) (long) dataType, &errorValue), "initWithShape:dataType:error:");
					GC.KeepAlive (this);
				}
			}
			error = Runtime.GetNSObject<NSError> (errorValue)!;
		}
		[Export ("initWithShape:dataType:strides:")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[SupportedOSPlatform ("macos15.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public MLMultiArray (NSNumber[] shape, MLMultiArrayDataType dataType, NSNumber[] strides)
			: base (NSObjectFlag.Empty)
		{
			if (shape is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (shape));
			if (strides is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (strides));
			using var nsa_shape = NSArray.FromNSObjects (shape);
			using var nsa_strides = NSArray.FromNSObjects (strides);
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_IntPtr_NativeHandle (this.Handle, selInitWithShape_DataType_Strides_XHandle, nsa_shape.Handle, (IntPtr) (long) dataType, nsa_strides.Handle), "initWithShape:dataType:strides:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_IntPtr_NativeHandle (&__objc_super__, selInitWithShape_DataType_Strides_XHandle, nsa_shape.Handle, (IntPtr) (long) dataType, nsa_strides.Handle), "initWithShape:dataType:strides:");
					GC.KeepAlive (this);
				}
			}
		}
		/// <param name="dataPointer">To be added.</param><param name="shape">To be added.</param><param name="dataType">To be added.</param><param name="strides">To be added.</param><param name="deallocator">To be added.</param><param name="error">To be added.</param><summary>Creates a new MLMultiArray with the specified details.</summary><remarks>To be added.</remarks>
		[Export ("initWithDataPointer:shape:dataType:strides:deallocator:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe MLMultiArray (nint dataPointer, NSNumber[] shape, MLMultiArrayDataType dataType, NSNumber[] strides, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V23))]global::System.Action<nint>? deallocator, out NSError error)
			: base (NSObjectFlag.Empty)
		{
			if (shape is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (shape));
			if (strides is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (strides));
			NativeHandle errorValue = IntPtr.Zero;
			using var nsa_shape = NSArray.FromNSObjects (shape);
			using var nsa_strides = NSArray.FromNSObjects (strides);
			using var block_deallocator = Trampolines.SDActionArity1V23.CreateNullableBlock (deallocator);
			BlockLiteral *block_ptr_deallocator = null;
			if (deallocator is not null)
				block_ptr_deallocator = &block_deallocator;
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_IntPtr_NativeHandle_IntPtr_NativeHandle_NativeHandle_ref_NativeHandle (this.Handle, selInitWithDataPointer_Shape_DataType_Strides_Deallocator_Error_XHandle, dataPointer, nsa_shape.Handle, (IntPtr) (long) dataType, nsa_strides.Handle, (IntPtr) block_ptr_deallocator, &errorValue), "initWithDataPointer:shape:dataType:strides:deallocator:error:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_IntPtr_NativeHandle_IntPtr_NativeHandle_NativeHandle_ref_NativeHandle (&__objc_super__, selInitWithDataPointer_Shape_DataType_Strides_Deallocator_Error_XHandle, dataPointer, nsa_shape.Handle, (IntPtr) (long) dataType, nsa_strides.Handle, (IntPtr) block_ptr_deallocator, &errorValue), "initWithDataPointer:shape:dataType:strides:deallocator:error:");
					GC.KeepAlive (this);
				}
			}
			error = Runtime.GetNSObject<NSError> (errorValue)!;
		}
		[Export ("initWithPixelBuffer:shape:")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public MLMultiArray (global::CoreVideo.CVPixelBuffer pixelBuffer, NSNumber[] shape)
			: base (NSObjectFlag.Empty)
		{
			var pixelBuffer__handle__ = pixelBuffer!.GetNonNullHandle (nameof (pixelBuffer));
			if (shape is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (shape));
			using var nsa_shape = NSArray.FromNSObjects (shape);
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selInitWithPixelBuffer_Shape_XHandle, pixelBuffer__handle__, nsa_shape.Handle), "initWithPixelBuffer:shape:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selInitWithPixelBuffer_Shape_XHandle, pixelBuffer__handle__, nsa_shape.Handle), "initWithPixelBuffer:shape:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (pixelBuffer);
		}
		[Export ("multiArrayByConcatenatingMultiArrays:alongAxis:dataType:")]
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MLMultiArray Concat (MLMultiArray[] multiArrays, nint axis, MLMultiArrayDataType dataType)
		{
			if (multiArrays is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (multiArrays));
			using var nsa_multiArrays = NSArray.FromNSObjects (multiArrays);
			MLMultiArray ret;
			ret =  Runtime.GetNSObject<MLMultiArray> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_IntPtr_IntPtr (class_ptr, selMultiArrayByConcatenatingMultiArrays_AlongAxis_DataType_XHandle, nsa_multiArrays.Handle, axis, (IntPtr) (long) dataType), false)!;
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
		[Export ("getBytesWithHandler:")]
		[SupportedOSPlatform ("tvos15.4")]
		[SupportedOSPlatform ("macos12.3")]
		[SupportedOSPlatform ("ios15.4")]
		[SupportedOSPlatform ("maccatalyst15.4")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void GetBytes ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V67))]global::System.Action<nint, nint> handler)
		{
			if (handler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (handler));
			using var block_handler = Trampolines.SDActionArity2V67.CreateBlock (handler);
			BlockLiteral *block_ptr_handler = &block_handler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selGetBytesWithHandler_XHandle, (IntPtr) block_ptr_handler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selGetBytesWithHandler_XHandle, (IntPtr) block_ptr_handler);
					GC.KeepAlive (this);
				}
			}
		}
		[SupportedOSPlatform ("tvos15.4")]
		[SupportedOSPlatform ("macos12.3")]
		[SupportedOSPlatform ("ios15.4")]
		[SupportedOSPlatform ("maccatalyst15.4")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<MLMultiArrayDataPointer> GetBytesAsync ()
		{
			var tcs = new TaskCompletionSource<MLMultiArrayDataPointer> ();
			GetBytes((arg1_, arg2_) => {
				tcs.SetResult (new MLMultiArrayDataPointer (arg1_!, arg2_!));
			});
			return tcs.Task;
		}
		[Export ("getMutableBytesWithHandler:")]
		[SupportedOSPlatform ("tvos15.4")]
		[SupportedOSPlatform ("macos12.3")]
		[SupportedOSPlatform ("ios15.4")]
		[SupportedOSPlatform ("maccatalyst15.4")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void GetMutableBytes ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity3V2))]global::System.Action<nint, nint, NSArray<NSNumber>> handler)
		{
			if (handler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (handler));
			using var block_handler = Trampolines.SDActionArity3V2.CreateBlock (handler);
			BlockLiteral *block_ptr_handler = &block_handler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selGetMutableBytesWithHandler_XHandle, (IntPtr) block_ptr_handler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selGetMutableBytesWithHandler_XHandle, (IntPtr) block_ptr_handler);
					GC.KeepAlive (this);
				}
			}
		}
		[SupportedOSPlatform ("tvos15.4")]
		[SupportedOSPlatform ("macos12.3")]
		[SupportedOSPlatform ("ios15.4")]
		[SupportedOSPlatform ("maccatalyst15.4")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<MLMultiArrayMutableDataPointer> GetMutableBytesAsync ()
		{
			var tcs = new TaskCompletionSource<MLMultiArrayMutableDataPointer> ();
			GetMutableBytes((arg1_, arg2_, arg3_) => {
				tcs.SetResult (new MLMultiArrayMutableDataPointer (arg1_!, arg2_!, arg3_!));
			});
			return tcs.Task;
		}
		/// <param name="idx">A numeric identifier for the object to get.</param><summary>Retrieves the element at <paramref name="idx" />, as if the array were single-dimensional.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("objectAtIndexedSubscript:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSNumber GetObject (nint idx)
		{
			NSNumber ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSNumber> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_IntPtr (this.Handle, selObjectAtIndexedSubscript_XHandle, idx), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSNumber> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_IntPtr (&__objc_super__, selObjectAtIndexedSubscript_XHandle, idx), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		/// <param name="key">A numeric identifier for the object to get.</param><summary>Retrieves the element at the point specified by <paramref name="key" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("objectForKeyedSubscript:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSNumber GetObject (NSNumber[] key)
		{
			if (key is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (key));
			using var nsa_key = NSArray.FromNSObjects (key);
			NSNumber ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSNumber> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selObjectForKeyedSubscript_XHandle, nsa_key.Handle), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSNumber> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selObjectForKeyedSubscript_XHandle, nsa_key.Handle), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal NSNumber GetObjectInternal (nint key)
		{
			NSNumber ret;
			ret =  Runtime.GetNSObject<NSNumber> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_IntPtr (this.Handle, selObjectForKeyedSubscript_XHandle, key), false)!;
			return ret;
		}
		/// <param name="obj">The new value.</param><param name="idx">A numeric identifier for the object to set.</param><summary>Sets the value at <paramref name="idx" /> to <paramref name="obj" />, as if the array were single-dimensional.</summary><remarks>To be added.</remarks>
		[Export ("setObject:atIndexedSubscript:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetObject (NSNumber obj, nint idx)
		{
			var obj__handle__ = obj!.GetNonNullHandle (nameof (obj));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_IntPtr (this.Handle, selSetObject_AtIndexedSubscript_XHandle, obj__handle__, idx);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_IntPtr (&__objc_super__, selSetObject_AtIndexedSubscript_XHandle, obj__handle__, idx);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (obj);
		}
		/// <param name="obj">The new value.</param><param name="key">A numeric identifier for the object to set.</param><summary>Sets the value at <paramref name="key" /> to <paramref name="obj" />.</summary><remarks>To be added.</remarks>
		[Export ("setObject:forKeyedSubscript:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetObject (NSNumber obj, NSNumber[] key)
		{
			var obj__handle__ = obj!.GetNonNullHandle (nameof (obj));
			if (key is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (key));
			using var nsa_key = NSArray.FromNSObjects (key);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selSetObject_ForKeyedSubscript_XHandle, obj__handle__, nsa_key.Handle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selSetObject_ForKeyedSubscript_XHandle, obj__handle__, nsa_key.Handle);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (obj);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal void SetObjectInternal (NSNumber obj, nint key)
		{
			var obj__handle__ = obj!.GetNonNullHandle (nameof (obj));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_IntPtr (this.Handle, selSetObject_ForKeyedSubscript_XHandle, obj__handle__, key);
			GC.KeepAlive (obj);
		}
		[Export ("transferToMultiArray:")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[SupportedOSPlatform ("macos15.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void TransferToMultiArray (MLMultiArray destinationMultiArray)
		{
			var destinationMultiArray__handle__ = destinationMultiArray!.GetNonNullHandle (nameof (destinationMultiArray));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selTransferToMultiArray_XHandle, destinationMultiArray__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selTransferToMultiArray_XHandle, destinationMultiArray__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (destinationMultiArray);
		}
		/// <summary>The total number of elements in the array.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint Count {
			[Export ("count")]
			get {
				nint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selCountXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selCountXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		/// <summary>Gets a pointer to the raw array data.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[ObsoletedOSPlatform ("macos13.0", "Use 'GetBytes (Action<IntPtr, nint>)' or 'GetMutableBytes' async methods instead.")]
		[ObsoletedOSPlatform ("ios16.0", "Use 'GetBytes (Action<IntPtr, nint>)' or 'GetMutableBytes' async methods instead.")]
		[ObsoletedOSPlatform ("tvos16.0", "Use 'GetBytes (Action<IntPtr, nint>)' or 'GetMutableBytes' async methods instead.")]
		[ObsoletedOSPlatform ("maccatalyst16.0", "Use 'GetBytes (Action<IntPtr, nint>)' or 'GetMutableBytes' async methods instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		public virtual nint DataPointer {
			[Export ("dataPointer")]
			get {
				nint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selDataPointerXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selDataPointerXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		/// <summary>The type of the data elements stored in the array.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MLMultiArrayDataType DataType {
			[Export ("dataType")]
			get {
				MLMultiArrayDataType ret;
				if (IsDirectBinding) {
					ret = (MLMultiArrayDataType) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selDataTypeXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (MLMultiArrayDataType) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selDataTypeXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[SupportedOSPlatform ("macos")]
		public virtual global::CoreVideo.CVPixelBuffer? PixelBuffer {
			[Export ("pixelBuffer")]
			get {
				global::CoreVideo.CVPixelBuffer? ret;
				if (IsDirectBinding) {
					ret = Runtime.GetINativeObject<CVPixelBuffer> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selPixelBufferXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = Runtime.GetINativeObject<CVPixelBuffer> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selPixelBufferXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal virtual nint _Shape {
			[Export ("shape")]
			get {
				nint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selShapeXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selShapeXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal virtual nint _Strides {
			[Export ("strides")]
			get {
				nint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selStridesXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selStridesXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
	} /* class MLMultiArray */
	//
	// Async result classes
	//
	/// <summary>This class holds the return values for an asynchronous operation.</summary>
	public partial class MLMultiArrayDataPointer {
		/// <summary>The result value from the asynchronous operation.</summary>
		public nint Arg1 { get; set; }
		/// <summary>The result value from the asynchronous operation.</summary>
		public nint Arg2 { get; set; }
		partial void Initialize ();
		/// <summary>Creates a new instance of this class.</summary>
		/// <param name="arg1">Result value from an asynchronous operation.</param>
		/// <param name="arg2">Result value from an asynchronous operation.</param>
		public MLMultiArrayDataPointer (nint arg1, nint arg2) {
			this.Arg1 = arg1;
			this.Arg2 = arg2;
			Initialize ();
		}
	}
	/// <summary>This class holds the return values for an asynchronous operation.</summary>
	public partial class MLMultiArrayMutableDataPointer {
		/// <summary>The result value from the asynchronous operation.</summary>
		public nint Arg1 { get; set; }
		/// <summary>The result value from the asynchronous operation.</summary>
		public nint Arg2 { get; set; }
		/// <summary>The result value from the asynchronous operation.</summary>
		public NSArray<NSNumber> Arg3 { get; set; }
		partial void Initialize ();
		/// <summary>Creates a new instance of this class.</summary>
		/// <param name="arg1">Result value from an asynchronous operation.</param>
		/// <param name="arg2">Result value from an asynchronous operation.</param>
		/// <param name="arg3">Result value from an asynchronous operation.</param>
		public MLMultiArrayMutableDataPointer (nint arg1, nint arg2, NSArray<NSNumber> arg3) {
			this.Arg1 = arg1;
			this.Arg2 = arg2;
			this.Arg3 = arg3;
			Initialize ();
		}
	}
}
