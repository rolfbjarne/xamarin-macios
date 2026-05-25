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
	/// <summary>This interface represents the Objective-C protocol <c>FSVolumePreallocateOperations</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[SupportedOSPlatform ("macos15.4")]
	[Experimental ("APL0002")]
	[Protocol (Name = "FSVolumePreallocateOperations", WrapperType = typeof (FSVolumePreallocateOperationsWrapper), BackwardsCompatibleCodeGeneration = false)]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "PreallocateSpace", Selector = "preallocateSpaceForItem:atOffset:length:flags:replyHandler:", ParameterType = new Type [] { typeof (FSKit.FSItem), typeof (long), typeof (UIntPtr), typeof (FSKit.FSPreallocateFlags), typeof (FSKit.FSVolumePreallocateOperationsHandler) }, ParameterByRef = new bool [] { false, false, false, false, false }, ParameterBlockProxy = new Type? [] { null, null, null, null, typeof (ObjCRuntime.Trampolines.NIDFSVolumePreallocateOperationsHandler) })]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "IsPreallocateInhibited", Selector = "preallocateInhibited", PropertyType = typeof (bool), GetterSelector = "isPreallocateInhibited", SetterSelector = "setPreallocateInhibited:", ArgumentSemantic = ArgumentSemantic.None)]
	public partial interface IFSVolumePreallocateOperations : INativeObject, IDisposable
	{
		[global::Foundation.RequiredMember]
		[Export ("preallocateSpaceForItem:atOffset:length:flags:replyHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void PreallocateSpace (FSItem item, long offset, nuint length, FSPreallocateFlags flags, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDFSVolumePreallocateOperationsHandler))]FSVolumePreallocateOperationsHandler reply)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _PreallocateSpace (IFSVolumePreallocateOperations This, FSItem item, long offset, nuint length, FSPreallocateFlags flags, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDFSVolumePreallocateOperationsHandler))]FSVolumePreallocateOperationsHandler reply)
		{
			var item__handle__ = item!.GetNonNullHandle (nameof (item));
			if (reply is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (reply));
			using var block_reply = Trampolines.SDFSVolumePreallocateOperationsHandler.CreateBlock (reply);
			BlockLiteral *block_ptr_reply = &block_reply;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_Int64_UIntPtr_UIntPtr_NativeHandle (This.Handle, Selector.GetHandle ("preallocateSpaceForItem:atOffset:length:flags:replyHandler:"), item__handle__, offset, length, (UIntPtr) (ulong) flags, (IntPtr) block_ptr_reply);
			GC.KeepAlive (This);
			GC.KeepAlive (item);
		}
		[DynamicDependencyAttribute ("IsPreallocateInhibited")]
		[DynamicDependencyAttribute ("PreallocateSpace(FSKit.FSItem,System.Int64,System.UIntPtr,FSKit.FSPreallocateFlags,FSKit.FSVolumePreallocateOperationsHandler)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (FSVolumePreallocateOperationsWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IFSVolumePreallocateOperations ()
		{
			GC.KeepAlive (null);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.OptionalMember]
		public virtual bool IsPreallocateInhibited {
			[Export ("isPreallocateInhibited")]
			get {
				return _GetIsPreallocateInhibited (this);
			}
			[Export ("setPreallocateInhibited:")]
			set {
				_SetIsPreallocateInhibited (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _GetIsPreallocateInhibited (IFSVolumePreallocateOperations This)
		{
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("isPreallocateInhibited"));
			GC.KeepAlive (This);
			return ret != 0;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetIsPreallocateInhibited (IFSVolumePreallocateOperations This, bool value)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_bool (This.Handle, Selector.GetHandle ("setPreallocateInhibited:"), value ? (byte) 1 : (byte) 0);
			GC.KeepAlive (This);
		}
	}
	#pragma warning restore CS1573
	[Experimental ("APL0002")]
	internal unsafe sealed class FSVolumePreallocateOperationsWrapper : BaseWrapper, IFSVolumePreallocateOperations {
		[Experimental ("APL0002")]
		public FSVolumePreallocateOperationsWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (FSVolumePreallocateOperationsWrapper))]
		static FSVolumePreallocateOperationsWrapper ()
		{
			GC.KeepAlive (null);
		}
		[Export ("preallocateSpaceForItem:atOffset:length:flags:replyHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void PreallocateSpace (FSItem item, long offset, nuint length, FSPreallocateFlags flags, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDFSVolumePreallocateOperationsHandler))]FSVolumePreallocateOperationsHandler reply)
		{
			var item__handle__ = item!.GetNonNullHandle (nameof (item));
			if (reply is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (reply));
			using var block_reply = Trampolines.SDFSVolumePreallocateOperationsHandler.CreateBlock (reply);
			BlockLiteral *block_ptr_reply = &block_reply;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_Int64_UIntPtr_UIntPtr_NativeHandle (this.Handle, Selector.GetHandle ("preallocateSpaceForItem:atOffset:length:flags:replyHandler:"), item__handle__, offset, length, (UIntPtr) (ulong) flags, (IntPtr) block_ptr_reply);
			GC.KeepAlive (item);
		}
	}
}
