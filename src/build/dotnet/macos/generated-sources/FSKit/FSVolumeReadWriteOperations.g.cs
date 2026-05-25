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
	/// <summary>This interface represents the Objective-C protocol <c>FSVolumeReadWriteOperations</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[SupportedOSPlatform ("macos15.4")]
	[Experimental ("APL0002")]
	[Protocol (Name = "FSVolumeReadWriteOperations", WrapperType = typeof (FSVolumeReadWriteOperationsWrapper), BackwardsCompatibleCodeGeneration = false)]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "Read", Selector = "readFromFile:offset:length:intoBuffer:replyHandler:", ParameterType = new Type [] { typeof (FSKit.FSItem), typeof (long), typeof (UIntPtr), typeof (FSKit.FSMutableFileDataBuffer), typeof (FSKit.FSVolumeReadWriteOperationsReadHandler) }, ParameterByRef = new bool [] { false, false, false, false, false }, ParameterBlockProxy = new Type? [] { null, null, null, null, typeof (ObjCRuntime.Trampolines.NIDFSVolumeReadWriteOperationsReadHandler) })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "Write", Selector = "writeContents:toFile:atOffset:replyHandler:", ParameterType = new Type [] { typeof (NSData), typeof (FSKit.FSItem), typeof (long), typeof (FSKit.FSVolumeReadWriteOperationsWriteHandler) }, ParameterByRef = new bool [] { false, false, false, false }, ParameterBlockProxy = new Type? [] { null, null, null, typeof (ObjCRuntime.Trampolines.NIDFSVolumeReadWriteOperationsWriteHandler) })]
	public partial interface IFSVolumeReadWriteOperations : INativeObject, IDisposable
	{
		[global::Foundation.RequiredMember]
		[Export ("readFromFile:offset:length:intoBuffer:replyHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void Read (FSItem item, long offset, nuint length, FSMutableFileDataBuffer buffer, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDFSVolumeReadWriteOperationsReadHandler))]FSVolumeReadWriteOperationsReadHandler reply)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _Read (IFSVolumeReadWriteOperations This, FSItem item, long offset, nuint length, FSMutableFileDataBuffer buffer, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDFSVolumeReadWriteOperationsReadHandler))]FSVolumeReadWriteOperationsReadHandler reply)
		{
			var item__handle__ = item!.GetNonNullHandle (nameof (item));
			var buffer__handle__ = buffer!.GetNonNullHandle (nameof (buffer));
			if (reply is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (reply));
			using var block_reply = Trampolines.SDFSVolumeReadWriteOperationsReadHandler.CreateBlock (reply);
			BlockLiteral *block_ptr_reply = &block_reply;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_Int64_UIntPtr_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("readFromFile:offset:length:intoBuffer:replyHandler:"), item__handle__, offset, length, buffer__handle__, (IntPtr) block_ptr_reply);
			GC.KeepAlive (This);
			GC.KeepAlive (item);
			GC.KeepAlive (buffer);
		}
		[global::Foundation.RequiredMember]
		[Export ("writeContents:toFile:atOffset:replyHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void Write (NSData contents, FSItem item, long offset, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDFSVolumeReadWriteOperationsWriteHandler))]FSVolumeReadWriteOperationsWriteHandler reply)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _Write (IFSVolumeReadWriteOperations This, NSData contents, FSItem item, long offset, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDFSVolumeReadWriteOperationsWriteHandler))]FSVolumeReadWriteOperationsWriteHandler reply)
		{
			var contents__handle__ = contents!.GetNonNullHandle (nameof (contents));
			var item__handle__ = item!.GetNonNullHandle (nameof (item));
			if (reply is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (reply));
			using var block_reply = Trampolines.SDFSVolumeReadWriteOperationsWriteHandler.CreateBlock (reply);
			BlockLiteral *block_ptr_reply = &block_reply;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_Int64_NativeHandle (This.Handle, Selector.GetHandle ("writeContents:toFile:atOffset:replyHandler:"), contents__handle__, item__handle__, offset, (IntPtr) block_ptr_reply);
			GC.KeepAlive (This);
			GC.KeepAlive (contents);
			GC.KeepAlive (item);
		}
		[DynamicDependencyAttribute ("Read(FSKit.FSItem,System.Int64,System.UIntPtr,FSKit.FSMutableFileDataBuffer,FSKit.FSVolumeReadWriteOperationsReadHandler)")]
		[DynamicDependencyAttribute ("Write(Foundation.NSData,FSKit.FSItem,System.Int64,FSKit.FSVolumeReadWriteOperationsWriteHandler)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (FSVolumeReadWriteOperationsWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IFSVolumeReadWriteOperations ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	[Experimental ("APL0002")]
	internal unsafe sealed class FSVolumeReadWriteOperationsWrapper : BaseWrapper, IFSVolumeReadWriteOperations {
		[Experimental ("APL0002")]
		public FSVolumeReadWriteOperationsWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (FSVolumeReadWriteOperationsWrapper))]
		static FSVolumeReadWriteOperationsWrapper ()
		{
			GC.KeepAlive (null);
		}
		[Export ("readFromFile:offset:length:intoBuffer:replyHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void Read (FSItem item, long offset, nuint length, FSMutableFileDataBuffer buffer, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDFSVolumeReadWriteOperationsReadHandler))]FSVolumeReadWriteOperationsReadHandler reply)
		{
			var item__handle__ = item!.GetNonNullHandle (nameof (item));
			var buffer__handle__ = buffer!.GetNonNullHandle (nameof (buffer));
			if (reply is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (reply));
			using var block_reply = Trampolines.SDFSVolumeReadWriteOperationsReadHandler.CreateBlock (reply);
			BlockLiteral *block_ptr_reply = &block_reply;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_Int64_UIntPtr_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("readFromFile:offset:length:intoBuffer:replyHandler:"), item__handle__, offset, length, buffer__handle__, (IntPtr) block_ptr_reply);
			GC.KeepAlive (item);
			GC.KeepAlive (buffer);
		}
		[Export ("writeContents:toFile:atOffset:replyHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void Write (NSData contents, FSItem item, long offset, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDFSVolumeReadWriteOperationsWriteHandler))]FSVolumeReadWriteOperationsWriteHandler reply)
		{
			var contents__handle__ = contents!.GetNonNullHandle (nameof (contents));
			var item__handle__ = item!.GetNonNullHandle (nameof (item));
			if (reply is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (reply));
			using var block_reply = Trampolines.SDFSVolumeReadWriteOperationsWriteHandler.CreateBlock (reply);
			BlockLiteral *block_ptr_reply = &block_reply;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_Int64_NativeHandle (this.Handle, Selector.GetHandle ("writeContents:toFile:atOffset:replyHandler:"), contents__handle__, item__handle__, offset, (IntPtr) block_ptr_reply);
			GC.KeepAlive (contents);
			GC.KeepAlive (item);
		}
	}
}
