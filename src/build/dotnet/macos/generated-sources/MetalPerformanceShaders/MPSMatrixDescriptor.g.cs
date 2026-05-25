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
	/// <summary>Describes the size, data type, and stride of a row-major matrix.</summary><related type="externalDocumentation" href="https://developer.apple.com/reference/MetalPerformanceShaders/MPSMatrixDescriptor">Apple documentation for <c>MPSMatrixDescriptor</c></related>
	[Register("MPSMatrixDescriptor", true)]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe partial class MPSMatrixDescriptor : NSObject {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selColumnsX = "columns";
		static readonly NativeHandle selColumnsXHandle = Selector.GetHandle ("columns");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDataTypeX = "dataType";
		static readonly NativeHandle selDataTypeXHandle = Selector.GetHandle ("dataType");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMatricesX = "matrices";
		static readonly NativeHandle selMatricesXHandle = Selector.GetHandle ("matrices");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMatrixBytesX = "matrixBytes";
		static readonly NativeHandle selMatrixBytesXHandle = Selector.GetHandle ("matrixBytes");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMatrixDescriptorWithDimensions_Columns_RowBytes_DataType_X = "matrixDescriptorWithDimensions:columns:rowBytes:dataType:";
		static readonly NativeHandle selMatrixDescriptorWithDimensions_Columns_RowBytes_DataType_XHandle = Selector.GetHandle ("matrixDescriptorWithDimensions:columns:rowBytes:dataType:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMatrixDescriptorWithRows_Columns_Matrices_RowBytes_MatrixBytes_DataType_X = "matrixDescriptorWithRows:columns:matrices:rowBytes:matrixBytes:dataType:";
		static readonly NativeHandle selMatrixDescriptorWithRows_Columns_Matrices_RowBytes_MatrixBytes_DataType_XHandle = Selector.GetHandle ("matrixDescriptorWithRows:columns:matrices:rowBytes:matrixBytes:dataType:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMatrixDescriptorWithRows_Columns_RowBytes_DataType_X = "matrixDescriptorWithRows:columns:rowBytes:dataType:";
		static readonly NativeHandle selMatrixDescriptorWithRows_Columns_RowBytes_DataType_XHandle = Selector.GetHandle ("matrixDescriptorWithRows:columns:rowBytes:dataType:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRowBytesX = "rowBytes";
		static readonly NativeHandle selRowBytesXHandle = Selector.GetHandle ("rowBytes");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRowBytesForColumns_DataType_X = "rowBytesForColumns:dataType:";
		static readonly NativeHandle selRowBytesForColumns_DataType_XHandle = Selector.GetHandle ("rowBytesForColumns:dataType:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRowBytesFromColumns_DataType_X = "rowBytesFromColumns:dataType:";
		static readonly NativeHandle selRowBytesFromColumns_DataType_XHandle = Selector.GetHandle ("rowBytesFromColumns:dataType:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRowsX = "rows";
		static readonly NativeHandle selRowsXHandle = Selector.GetHandle ("rows");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetColumns_X = "setColumns:";
		static readonly NativeHandle selSetColumns_XHandle = Selector.GetHandle ("setColumns:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetDataType_X = "setDataType:";
		static readonly NativeHandle selSetDataType_XHandle = Selector.GetHandle ("setDataType:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetRowBytes_X = "setRowBytes:";
		static readonly NativeHandle selSetRowBytes_XHandle = Selector.GetHandle ("setRowBytes:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetRows_X = "setRows:";
		static readonly NativeHandle selSetRows_XHandle = Selector.GetHandle ("setRows:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("MPSMatrixDescriptor");
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
		protected MPSMatrixDescriptor (NSObjectFlag t) : base (t)
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
		protected internal MPSMatrixDescriptor (NativeHandle handle) : base (handle)
		{
		}

		[Export ("matrixDescriptorWithDimensions:columns:rowBytes:dataType:")]
		[ObsoletedOSPlatform ("tvos11.0")]
		[ObsoletedOSPlatform ("ios11.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSMatrixDescriptor Create (nuint rows, nuint columns, nuint rowBytes, MPSDataType dataType)
		{
			MPSMatrixDescriptor ret;
			ret =  Runtime.GetNSObject<MPSMatrixDescriptor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UIntPtr_UIntPtr_UIntPtr_UInt32 (class_ptr, selMatrixDescriptorWithDimensions_Columns_RowBytes_DataType_XHandle, rows, columns, rowBytes, (UInt32)dataType), false)!;
			return ret;
		}
		/// <param name="rows">To be added.</param><param name="columns">To be added.</param><param name="rowBytes">To be added.</param><param name="dataType">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("matrixDescriptorWithRows:columns:rowBytes:dataType:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSMatrixDescriptor GetMatrixDescriptor (nuint rows, nuint columns, nuint rowBytes, MPSDataType dataType)
		{
			MPSMatrixDescriptor ret;
			ret =  Runtime.GetNSObject<MPSMatrixDescriptor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UIntPtr_UIntPtr_UIntPtr_UInt32 (class_ptr, selMatrixDescriptorWithRows_Columns_RowBytes_DataType_XHandle, rows, columns, rowBytes, (UInt32)dataType), false)!;
			return ret;
		}
		/// <param name="rows">To be added.</param><param name="columns">To be added.</param><param name="matrices">To be added.</param><param name="rowBytes">To be added.</param><param name="matrixBytes">To be added.</param><param name="dataType">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("matrixDescriptorWithRows:columns:matrices:rowBytes:matrixBytes:dataType:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSMatrixDescriptor GetMatrixDescriptor (nuint rows, nuint columns, nuint matrices, nuint rowBytes, nuint matrixBytes, MPSDataType dataType)
		{
			MPSMatrixDescriptor ret;
			ret =  Runtime.GetNSObject<MPSMatrixDescriptor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UIntPtr_UIntPtr_UIntPtr_UIntPtr_UIntPtr_UInt32 (class_ptr, selMatrixDescriptorWithRows_Columns_Matrices_RowBytes_MatrixBytes_DataType_XHandle, rows, columns, matrices, rowBytes, matrixBytes, (UInt32)dataType), false)!;
			return ret;
		}
		/// <param name="columns">To be added.</param><param name="dataType">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("rowBytesForColumns:dataType:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static nuint GetRowBytesForColumns (nuint columns, MPSDataType dataType)
		{
			nuint ret;
			ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend_UIntPtr_UInt32 (class_ptr, selRowBytesForColumns_DataType_XHandle, columns, (UInt32)dataType);
			return ret;
		}
		[Export ("rowBytesFromColumns:dataType:")]
		[ObsoletedOSPlatform ("ios11.0")]
		[ObsoletedOSPlatform ("tvos11.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static nuint GetRowBytesFromColumns (nuint columns, MPSDataType dataType)
		{
			nuint ret;
			ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend_UIntPtr_UInt32 (class_ptr, selRowBytesFromColumns_DataType_XHandle, columns, (UInt32)dataType);
			return ret;
		}
		/// <summary>Gets the number of columns that are in the matrix.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nuint Columns {
			[Export ("columns")]
			get {
				nuint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selColumnsXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selColumnsXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setColumns:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (this.Handle, selSetColumns_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UIntPtr (&__objc_super__, selSetColumns_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>Gets the type of data that are stored in the matrix.</summary><value>To be added.</value><remarks>To be added.</remarks>
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
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual nuint Matrices {
			[Export ("matrices")]
			get {
				nuint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selMatricesXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selMatricesXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual nuint MatrixBytes {
			[Export ("matrixBytes")]
			get {
				nuint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selMatrixBytesXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selMatrixBytesXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		/// <summary>Gets the row stride for the matrix, in bytes.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nuint RowBytes {
			[Export ("rowBytes")]
			get {
				nuint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selRowBytesXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selRowBytesXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setRowBytes:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (this.Handle, selSetRowBytes_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UIntPtr (&__objc_super__, selSetRowBytes_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>Gets the number of columns in the matrix.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nuint Rows {
			[Export ("rows")]
			get {
				nuint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selRowsXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selRowsXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setRows:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (this.Handle, selSetRows_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UIntPtr (&__objc_super__, selSetRows_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
	} /* class MPSMatrixDescriptor */
}
