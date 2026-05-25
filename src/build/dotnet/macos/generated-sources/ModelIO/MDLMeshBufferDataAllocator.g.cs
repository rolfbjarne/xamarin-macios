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
namespace ModelIO {
	/// <summary>An implementation of <see cref="T:ModelIO.IMDLMeshBufferAllocator" /> that allocates mesh buffer data space within main memory, not GPU memory.</summary><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/ModelIO/Reference/MDLMeshBufferDataAllocator_Class/index.html">Apple documentation for <c>MDLMeshBufferDataAllocator</c></related>
	[Register("MDLMeshBufferDataAllocator", true)]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe partial class MDLMeshBufferDataAllocator : NSObject, IMDLMeshBufferAllocator {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selNewBuffer_Type_X = "newBuffer:type:";
		static readonly NativeHandle selNewBuffer_Type_XHandle = Selector.GetHandle ("newBuffer:type:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selNewBufferFromZone_Data_Type_X = "newBufferFromZone:data:type:";
		static readonly NativeHandle selNewBufferFromZone_Data_Type_XHandle = Selector.GetHandle ("newBufferFromZone:data:type:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selNewBufferFromZone_Length_Type_X = "newBufferFromZone:length:type:";
		static readonly NativeHandle selNewBufferFromZone_Length_Type_XHandle = Selector.GetHandle ("newBufferFromZone:length:type:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selNewBufferWithData_Type_X = "newBufferWithData:type:";
		static readonly NativeHandle selNewBufferWithData_Type_XHandle = Selector.GetHandle ("newBufferWithData:type:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selNewZone_X = "newZone:";
		static readonly NativeHandle selNewZone_XHandle = Selector.GetHandle ("newZone:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selNewZoneForBuffersWithSize_AndType_X = "newZoneForBuffersWithSize:andType:";
		static readonly NativeHandle selNewZoneForBuffersWithSize_AndType_XHandle = Selector.GetHandle ("newZoneForBuffersWithSize:andType:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("MDLMeshBufferDataAllocator");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		/// <summary>Creates a new <see cref="MDLMeshBufferDataAllocator" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public MDLMeshBufferDataAllocator () : base (NSObjectFlag.Empty)
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
		protected MDLMeshBufferDataAllocator (NSObjectFlag t) : base (t)
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
		protected internal MDLMeshBufferDataAllocator (NativeHandle handle) : base (handle)
		{
		}

		/// <param name="length">To be added.</param><param name="type">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("newBuffer:type:")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual IMDLMeshBuffer CreateBuffer (nuint length, MDLMeshBufferType type)
		{
			IMDLMeshBuffer ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetINativeObject<IMDLMeshBuffer> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UIntPtr_UIntPtr (this.Handle, selNewBuffer_Type_XHandle, length, (UIntPtr) (ulong) type), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetINativeObject<IMDLMeshBuffer> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_UIntPtr_UIntPtr (&__objc_super__, selNewBuffer_Type_XHandle, length, (UIntPtr) (ulong) type), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		/// <param name="data">To be added.</param><param name="type">To be added.</param><summary>Creates a new buffer from the specified data, of the specified type, in the default zone of the implementor.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("newBufferWithData:type:")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual IMDLMeshBuffer CreateBuffer (NSData data, MDLMeshBufferType type)
		{
			var data__handle__ = data!.GetNonNullHandle (nameof (data));
			IMDLMeshBuffer? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetINativeObject<IMDLMeshBuffer> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_UIntPtr (this.Handle, selNewBufferWithData_Type_XHandle, data__handle__, (UIntPtr) (ulong) type), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetINativeObject<IMDLMeshBuffer> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_UIntPtr (&__objc_super__, selNewBufferWithData_Type_XHandle, data__handle__, (UIntPtr) (ulong) type), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (data);
			return ret!;
		}
		/// <param name="zone">To be added.</param><param name="length">To be added.</param><param name="type">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("newBufferFromZone:length:type:")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual IMDLMeshBuffer? CreateBuffer (IMDLMeshBufferZone? zone, nuint length, MDLMeshBufferType type)
		{
			var zone__handle__ = zone.GetHandle ();
			IMDLMeshBuffer? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetINativeObject<IMDLMeshBuffer> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_UIntPtr_UIntPtr (this.Handle, selNewBufferFromZone_Length_Type_XHandle, zone__handle__, length, (UIntPtr) (ulong) type), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetINativeObject<IMDLMeshBuffer> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_UIntPtr_UIntPtr (&__objc_super__, selNewBufferFromZone_Length_Type_XHandle, zone__handle__, length, (UIntPtr) (ulong) type), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (zone);
			return ret!;
		}
		/// <param name="zone">To be added.</param><param name="data">To be added.</param><param name="type">To be added.</param><summary>Creates a new buffer from the specified data, of the specified type, in the specified zone.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("newBufferFromZone:data:type:")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual IMDLMeshBuffer? CreateBuffer (IMDLMeshBufferZone? zone, NSData data, MDLMeshBufferType type)
		{
			var zone__handle__ = zone.GetHandle ();
			var data__handle__ = data!.GetNonNullHandle (nameof (data));
			IMDLMeshBuffer? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetINativeObject<IMDLMeshBuffer> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_UIntPtr (this.Handle, selNewBufferFromZone_Data_Type_XHandle, zone__handle__, data__handle__, (UIntPtr) (ulong) type), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetINativeObject<IMDLMeshBuffer> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_UIntPtr (&__objc_super__, selNewBufferFromZone_Data_Type_XHandle, zone__handle__, data__handle__, (UIntPtr) (ulong) type), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (zone);
			GC.KeepAlive (data);
			return ret!;
		}
		/// <param name="capacity">To be added.</param><summary>Creates and returns a new mesh buffer zone with the specified  <paramref name="capacity" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("newZone:")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual IMDLMeshBufferZone CreateZone (nuint capacity)
		{
			IMDLMeshBufferZone ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetINativeObject<IMDLMeshBufferZone> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UIntPtr (this.Handle, selNewZone_XHandle, capacity), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetINativeObject<IMDLMeshBufferZone> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_UIntPtr (&__objc_super__, selNewZone_XHandle, capacity), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		/// <param name="sizes">To be added.</param><param name="types">To be added.</param><summary>Creates a new zone that is large enough to contain buffers from the list of sizes and corresponding types.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("newZoneForBuffersWithSize:andType:")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual IMDLMeshBufferZone CreateZone (NSNumber[] sizes, NSNumber[] types)
		{
			if (sizes is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (sizes));
			if (types is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (types));
			using var nsa_sizes = NSArray.FromNSObjects (sizes);
			using var nsa_types = NSArray.FromNSObjects (types);
			IMDLMeshBufferZone ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetINativeObject<IMDLMeshBufferZone> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selNewZoneForBuffersWithSize_AndType_XHandle, nsa_sizes.Handle, nsa_types.Handle), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetINativeObject<IMDLMeshBufferZone> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selNewZoneForBuffersWithSize_AndType_XHandle, nsa_sizes.Handle, nsa_types.Handle), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
	} /* class MDLMeshBufferDataAllocator */
}
