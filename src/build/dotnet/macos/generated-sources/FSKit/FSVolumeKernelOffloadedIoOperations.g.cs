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
namespace FSKit {
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>FSVolumeKernelOffloadedIOOperations</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[SupportedOSPlatform ("macos15.4")]
	[Experimental ("APL0002")]
	[Protocol (Name = "FSVolumeKernelOffloadedIOOperations", WrapperType = typeof (FSVolumeKernelOffloadedIoOperationsWrapper), BackwardsCompatibleCodeGeneration = false)]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "BlockmapFile", Selector = "blockmapFile:offset:length:flags:operationID:packer:replyHandler:", ParameterType = new Type [] { typeof (FSKit.FSItem), typeof (long), typeof (UIntPtr), typeof (FSKit.FSBlockmapFlags), typeof (UIntPtr), typeof (FSKit.FSExtentPacker), typeof (FSKit.FSVolumeKernelOffloadedIoOperationsHandler) }, ParameterByRef = new bool [] { false, false, false, false, false, false, false }, ParameterBlockProxy = new Type? [] { null, null, null, null, null, null, typeof (ObjCRuntime.Trampolines.NIDFSVolumeKernelOffloadedIoOperationsHandler) })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "CompleteIo", Selector = "completeIOForFile:offset:length:status:flags:operationID:replyHandler:", ParameterType = new Type [] { typeof (FSKit.FSItem), typeof (long), typeof (UIntPtr), typeof (NSError), typeof (FSKit.FSCompleteIoFlags), typeof (UIntPtr), typeof (FSKit.FSVolumeKernelOffloadedIoOperationsHandler) }, ParameterByRef = new bool [] { false, false, false, false, false, false, false }, ParameterBlockProxy = new Type? [] { null, null, null, null, null, null, typeof (ObjCRuntime.Trampolines.NIDFSVolumeKernelOffloadedIoOperationsHandler) })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "CreateFile", Selector = "createFileNamed:inDirectory:attributes:packer:replyHandler:", ParameterType = new Type [] { typeof (FSKit.FSFileName), typeof (FSKit.FSItem), typeof (FSKit.FSItemSetAttributesRequest), typeof (FSKit.FSExtentPacker), typeof (FSKit.FSVolumeKernelOffloadedIoOperationsCreateFileHandler) }, ParameterByRef = new bool [] { false, false, false, false, false }, ParameterBlockProxy = new Type? [] { null, null, null, null, typeof (ObjCRuntime.Trampolines.NIDFSVolumeKernelOffloadedIoOperationsCreateFileHandler) })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "LookupItem", Selector = "lookupItemNamed:inDirectory:packer:replyHandler:", ParameterType = new Type [] { typeof (FSKit.FSFileName), typeof (FSKit.FSItem), typeof (FSKit.FSExtentPacker), typeof (FSKit.FSVolumeKernelOffloadedIoOperationsLookupItemHandler) }, ParameterByRef = new bool [] { false, false, false, false }, ParameterBlockProxy = new Type? [] { null, null, null, typeof (ObjCRuntime.Trampolines.NIDFSVolumeKernelOffloadedIoOperationsLookupItemHandler) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "PreallocateSpace", Selector = "preallocateSpaceForFile:atOffset:length:flags:packer:replyHandler:", ParameterType = new Type [] { typeof (FSKit.FSItem), typeof (long), typeof (UIntPtr), typeof (FSKit.FSPreallocateFlags), typeof (FSKit.FSExtentPacker), typeof (FSKit.FSVolumeKernelOffloadedIoOperationsPreallocateSpaceHandler) }, ParameterByRef = new bool [] { false, false, false, false, false, false }, ParameterBlockProxy = new Type? [] { null, null, null, null, null, typeof (ObjCRuntime.Trampolines.NIDFSVolumeKernelOffloadedIoOperationsPreallocateSpaceHandler) })]
	public partial interface IFSVolumeKernelOffloadedIoOperations : INativeObject, IDisposable
	{
		[global::Foundation.RequiredMember]
		[Export ("blockmapFile:offset:length:flags:operationID:packer:replyHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void BlockmapFile (FSItem item, long offset, nuint lengthIo, FSBlockmapFlags flags, nuint operationId, FSExtentPacker packer, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDFSVolumeKernelOffloadedIoOperationsHandler))]FSVolumeKernelOffloadedIoOperationsHandler reply)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _BlockmapFile (IFSVolumeKernelOffloadedIoOperations This, FSItem item, long offset, nuint lengthIo, FSBlockmapFlags flags, nuint operationId, FSExtentPacker packer, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDFSVolumeKernelOffloadedIoOperationsHandler))]FSVolumeKernelOffloadedIoOperationsHandler reply)
		{
			var item__handle__ = item!.GetNonNullHandle (nameof (item));
			var packer__handle__ = packer!.GetNonNullHandle (nameof (packer));
			if (reply is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (reply));
			using var block_reply = Trampolines.SDFSVolumeKernelOffloadedIoOperationsHandler.CreateBlock (reply);
			BlockLiteral *block_ptr_reply = &block_reply;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_Int64_UIntPtr_UIntPtr_UIntPtr_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("blockmapFile:offset:length:flags:operationID:packer:replyHandler:"), item__handle__, offset, lengthIo, (UIntPtr) (ulong) flags, operationId, packer__handle__, (IntPtr) block_ptr_reply);
			GC.KeepAlive (This);
			GC.KeepAlive (item);
			GC.KeepAlive (packer);
		}
		[global::Foundation.RequiredMember]
		[Export ("completeIOForFile:offset:length:status:flags:operationID:replyHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void CompleteIo (FSItem item, long offset, nuint length, NSError status, FSCompleteIoFlags flags, nuint operationId, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDFSVolumeKernelOffloadedIoOperationsHandler))]FSVolumeKernelOffloadedIoOperationsHandler reply)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _CompleteIo (IFSVolumeKernelOffloadedIoOperations This, FSItem item, long offset, nuint length, NSError status, FSCompleteIoFlags flags, nuint operationId, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDFSVolumeKernelOffloadedIoOperationsHandler))]FSVolumeKernelOffloadedIoOperationsHandler reply)
		{
			var item__handle__ = item!.GetNonNullHandle (nameof (item));
			var status__handle__ = status!.GetNonNullHandle (nameof (status));
			if (reply is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (reply));
			using var block_reply = Trampolines.SDFSVolumeKernelOffloadedIoOperationsHandler.CreateBlock (reply);
			BlockLiteral *block_ptr_reply = &block_reply;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_Int64_UIntPtr_NativeHandle_UIntPtr_UIntPtr_NativeHandle (This.Handle, Selector.GetHandle ("completeIOForFile:offset:length:status:flags:operationID:replyHandler:"), item__handle__, offset, length, status__handle__, (UIntPtr) (ulong) flags, operationId, (IntPtr) block_ptr_reply);
			GC.KeepAlive (This);
			GC.KeepAlive (item);
			GC.KeepAlive (status);
		}
		[global::Foundation.RequiredMember]
		[Export ("createFileNamed:inDirectory:attributes:packer:replyHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void CreateFile (FSFileName name, FSItem directory, FSItemSetAttributesRequest newAttributes, FSExtentPacker packer, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDFSVolumeKernelOffloadedIoOperationsCreateFileHandler))]FSVolumeKernelOffloadedIoOperationsCreateFileHandler reply)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _CreateFile (IFSVolumeKernelOffloadedIoOperations This, FSFileName name, FSItem directory, FSItemSetAttributesRequest newAttributes, FSExtentPacker packer, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDFSVolumeKernelOffloadedIoOperationsCreateFileHandler))]FSVolumeKernelOffloadedIoOperationsCreateFileHandler reply)
		{
			var name__handle__ = name!.GetNonNullHandle (nameof (name));
			var directory__handle__ = directory!.GetNonNullHandle (nameof (directory));
			var newAttributes__handle__ = newAttributes!.GetNonNullHandle (nameof (newAttributes));
			var packer__handle__ = packer!.GetNonNullHandle (nameof (packer));
			if (reply is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (reply));
			using var block_reply = Trampolines.SDFSVolumeKernelOffloadedIoOperationsCreateFileHandler.CreateBlock (reply);
			BlockLiteral *block_ptr_reply = &block_reply;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("createFileNamed:inDirectory:attributes:packer:replyHandler:"), name__handle__, directory__handle__, newAttributes__handle__, packer__handle__, (IntPtr) block_ptr_reply);
			GC.KeepAlive (This);
			GC.KeepAlive (name);
			GC.KeepAlive (directory);
			GC.KeepAlive (newAttributes);
			GC.KeepAlive (packer);
		}
		[global::Foundation.RequiredMember]
		[Export ("lookupItemNamed:inDirectory:packer:replyHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void LookupItem (FSFileName name, FSItem directory, FSExtentPacker packer, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDFSVolumeKernelOffloadedIoOperationsLookupItemHandler))]FSVolumeKernelOffloadedIoOperationsLookupItemHandler reply)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _LookupItem (IFSVolumeKernelOffloadedIoOperations This, FSFileName name, FSItem directory, FSExtentPacker packer, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDFSVolumeKernelOffloadedIoOperationsLookupItemHandler))]FSVolumeKernelOffloadedIoOperationsLookupItemHandler reply)
		{
			var name__handle__ = name!.GetNonNullHandle (nameof (name));
			var directory__handle__ = directory!.GetNonNullHandle (nameof (directory));
			var packer__handle__ = packer!.GetNonNullHandle (nameof (packer));
			if (reply is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (reply));
			using var block_reply = Trampolines.SDFSVolumeKernelOffloadedIoOperationsLookupItemHandler.CreateBlock (reply);
			BlockLiteral *block_ptr_reply = &block_reply;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("lookupItemNamed:inDirectory:packer:replyHandler:"), name__handle__, directory__handle__, packer__handle__, (IntPtr) block_ptr_reply);
			GC.KeepAlive (This);
			GC.KeepAlive (name);
			GC.KeepAlive (directory);
			GC.KeepAlive (packer);
		}
		[global::Foundation.OptionalMember]
		[Export ("preallocateSpaceForFile:atOffset:length:flags:packer:replyHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void PreallocateSpace (FSItem file, long offset, nuint length, FSPreallocateFlags flags, FSExtentPacker packer, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDFSVolumeKernelOffloadedIoOperationsPreallocateSpaceHandler))]FSVolumeKernelOffloadedIoOperationsPreallocateSpaceHandler reply)
		{
			_PreallocateSpace (this, file, offset, length, flags, packer, reply);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _PreallocateSpace (IFSVolumeKernelOffloadedIoOperations This, FSItem file, long offset, nuint length, FSPreallocateFlags flags, FSExtentPacker packer, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDFSVolumeKernelOffloadedIoOperationsPreallocateSpaceHandler))]FSVolumeKernelOffloadedIoOperationsPreallocateSpaceHandler reply)
		{
			var file__handle__ = file!.GetNonNullHandle (nameof (file));
			var packer__handle__ = packer!.GetNonNullHandle (nameof (packer));
			if (reply is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (reply));
			using var block_reply = Trampolines.SDFSVolumeKernelOffloadedIoOperationsPreallocateSpaceHandler.CreateBlock (reply);
			BlockLiteral *block_ptr_reply = &block_reply;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_Int64_UIntPtr_UIntPtr_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("preallocateSpaceForFile:atOffset:length:flags:packer:replyHandler:"), file__handle__, offset, length, (UIntPtr) (ulong) flags, packer__handle__, (IntPtr) block_ptr_reply);
			GC.KeepAlive (This);
			GC.KeepAlive (file);
			GC.KeepAlive (packer);
		}
		[DynamicDependencyAttribute ("BlockmapFile(FSKit.FSItem,System.Int64,System.UIntPtr,FSKit.FSBlockmapFlags,System.UIntPtr,FSKit.FSExtentPacker,FSKit.FSVolumeKernelOffloadedIoOperationsHandler)")]
		[DynamicDependencyAttribute ("CompleteIo(FSKit.FSItem,System.Int64,System.UIntPtr,Foundation.NSError,FSKit.FSCompleteIoFlags,System.UIntPtr,FSKit.FSVolumeKernelOffloadedIoOperationsHandler)")]
		[DynamicDependencyAttribute ("CreateFile(FSKit.FSFileName,FSKit.FSItem,FSKit.FSItemSetAttributesRequest,FSKit.FSExtentPacker,FSKit.FSVolumeKernelOffloadedIoOperationsCreateFileHandler)")]
		[DynamicDependencyAttribute ("LookupItem(FSKit.FSFileName,FSKit.FSItem,FSKit.FSExtentPacker,FSKit.FSVolumeKernelOffloadedIoOperationsLookupItemHandler)")]
		[DynamicDependencyAttribute ("PreallocateSpace(FSKit.FSItem,System.Int64,System.UIntPtr,FSKit.FSPreallocateFlags,FSKit.FSExtentPacker,FSKit.FSVolumeKernelOffloadedIoOperationsPreallocateSpaceHandler)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (FSVolumeKernelOffloadedIoOperationsWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IFSVolumeKernelOffloadedIoOperations ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	[Experimental ("APL0002")]
	internal unsafe sealed class FSVolumeKernelOffloadedIoOperationsWrapper : BaseWrapper, IFSVolumeKernelOffloadedIoOperations {
		[Experimental ("APL0002")]
		public FSVolumeKernelOffloadedIoOperationsWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (FSVolumeKernelOffloadedIoOperationsWrapper))]
		static FSVolumeKernelOffloadedIoOperationsWrapper ()
		{
			GC.KeepAlive (null);
		}
		[Export ("blockmapFile:offset:length:flags:operationID:packer:replyHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void BlockmapFile (FSItem item, long offset, nuint lengthIo, FSBlockmapFlags flags, nuint operationId, FSExtentPacker packer, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDFSVolumeKernelOffloadedIoOperationsHandler))]FSVolumeKernelOffloadedIoOperationsHandler reply)
		{
			var item__handle__ = item!.GetNonNullHandle (nameof (item));
			var packer__handle__ = packer!.GetNonNullHandle (nameof (packer));
			if (reply is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (reply));
			using var block_reply = Trampolines.SDFSVolumeKernelOffloadedIoOperationsHandler.CreateBlock (reply);
			BlockLiteral *block_ptr_reply = &block_reply;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_Int64_UIntPtr_UIntPtr_UIntPtr_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("blockmapFile:offset:length:flags:operationID:packer:replyHandler:"), item__handle__, offset, lengthIo, (UIntPtr) (ulong) flags, operationId, packer__handle__, (IntPtr) block_ptr_reply);
			GC.KeepAlive (item);
			GC.KeepAlive (packer);
		}
		[Export ("completeIOForFile:offset:length:status:flags:operationID:replyHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void CompleteIo (FSItem item, long offset, nuint length, NSError status, FSCompleteIoFlags flags, nuint operationId, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDFSVolumeKernelOffloadedIoOperationsHandler))]FSVolumeKernelOffloadedIoOperationsHandler reply)
		{
			var item__handle__ = item!.GetNonNullHandle (nameof (item));
			var status__handle__ = status!.GetNonNullHandle (nameof (status));
			if (reply is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (reply));
			using var block_reply = Trampolines.SDFSVolumeKernelOffloadedIoOperationsHandler.CreateBlock (reply);
			BlockLiteral *block_ptr_reply = &block_reply;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_Int64_UIntPtr_NativeHandle_UIntPtr_UIntPtr_NativeHandle (this.Handle, Selector.GetHandle ("completeIOForFile:offset:length:status:flags:operationID:replyHandler:"), item__handle__, offset, length, status__handle__, (UIntPtr) (ulong) flags, operationId, (IntPtr) block_ptr_reply);
			GC.KeepAlive (item);
			GC.KeepAlive (status);
		}
		[Export ("createFileNamed:inDirectory:attributes:packer:replyHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void CreateFile (FSFileName name, FSItem directory, FSItemSetAttributesRequest newAttributes, FSExtentPacker packer, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDFSVolumeKernelOffloadedIoOperationsCreateFileHandler))]FSVolumeKernelOffloadedIoOperationsCreateFileHandler reply)
		{
			var name__handle__ = name!.GetNonNullHandle (nameof (name));
			var directory__handle__ = directory!.GetNonNullHandle (nameof (directory));
			var newAttributes__handle__ = newAttributes!.GetNonNullHandle (nameof (newAttributes));
			var packer__handle__ = packer!.GetNonNullHandle (nameof (packer));
			if (reply is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (reply));
			using var block_reply = Trampolines.SDFSVolumeKernelOffloadedIoOperationsCreateFileHandler.CreateBlock (reply);
			BlockLiteral *block_ptr_reply = &block_reply;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("createFileNamed:inDirectory:attributes:packer:replyHandler:"), name__handle__, directory__handle__, newAttributes__handle__, packer__handle__, (IntPtr) block_ptr_reply);
			GC.KeepAlive (name);
			GC.KeepAlive (directory);
			GC.KeepAlive (newAttributes);
			GC.KeepAlive (packer);
		}
		[Export ("lookupItemNamed:inDirectory:packer:replyHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void LookupItem (FSFileName name, FSItem directory, FSExtentPacker packer, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDFSVolumeKernelOffloadedIoOperationsLookupItemHandler))]FSVolumeKernelOffloadedIoOperationsLookupItemHandler reply)
		{
			var name__handle__ = name!.GetNonNullHandle (nameof (name));
			var directory__handle__ = directory!.GetNonNullHandle (nameof (directory));
			var packer__handle__ = packer!.GetNonNullHandle (nameof (packer));
			if (reply is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (reply));
			using var block_reply = Trampolines.SDFSVolumeKernelOffloadedIoOperationsLookupItemHandler.CreateBlock (reply);
			BlockLiteral *block_ptr_reply = &block_reply;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("lookupItemNamed:inDirectory:packer:replyHandler:"), name__handle__, directory__handle__, packer__handle__, (IntPtr) block_ptr_reply);
			GC.KeepAlive (name);
			GC.KeepAlive (directory);
			GC.KeepAlive (packer);
		}
	}
}
