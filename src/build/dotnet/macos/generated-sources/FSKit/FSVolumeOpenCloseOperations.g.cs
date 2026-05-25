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
	/// <summary>This interface represents the Objective-C protocol <c>FSVolumeOpenCloseOperations</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[SupportedOSPlatform ("macos15.4")]
	[Experimental ("APL0002")]
	[Protocol (Name = "FSVolumeOpenCloseOperations", WrapperType = typeof (FSVolumeOpenCloseOperationsWrapper), BackwardsCompatibleCodeGeneration = false)]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "OpenItem", Selector = "openItem:withModes:replyHandler:", ParameterType = new Type [] { typeof (FSKit.FSItem), typeof (FSKit.FSVolumeOpenModes), typeof (FSKit.FSVolumeOpenCloseOperationsHandler) }, ParameterByRef = new bool [] { false, false, false }, ParameterBlockProxy = new Type? [] { null, null, typeof (ObjCRuntime.Trampolines.NIDFSVolumeOpenCloseOperationsHandler) })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "CloseItem", Selector = "closeItem:keepingModes:replyHandler:", ParameterType = new Type [] { typeof (FSKit.FSItem), typeof (FSKit.FSVolumeOpenModes), typeof (FSKit.FSVolumeOpenCloseOperationsHandler) }, ParameterByRef = new bool [] { false, false, false }, ParameterBlockProxy = new Type? [] { null, null, typeof (ObjCRuntime.Trampolines.NIDFSVolumeOpenCloseOperationsHandler) })]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "IsOpenCloseInhibited", Selector = "openCloseInhibited", PropertyType = typeof (bool), GetterSelector = "isOpenCloseInhibited", SetterSelector = "setOpenCloseInhibited:", ArgumentSemantic = ArgumentSemantic.None)]
	public partial interface IFSVolumeOpenCloseOperations : INativeObject, IDisposable
	{
		[global::Foundation.RequiredMember]
		[Export ("openItem:withModes:replyHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void OpenItem (FSItem item, FSVolumeOpenModes mode, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDFSVolumeOpenCloseOperationsHandler))]FSVolumeOpenCloseOperationsHandler reply)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _OpenItem (IFSVolumeOpenCloseOperations This, FSItem item, FSVolumeOpenModes mode, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDFSVolumeOpenCloseOperationsHandler))]FSVolumeOpenCloseOperationsHandler reply)
		{
			var item__handle__ = item!.GetNonNullHandle (nameof (item));
			if (reply is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (reply));
			using var block_reply = Trampolines.SDFSVolumeOpenCloseOperationsHandler.CreateBlock (reply);
			BlockLiteral *block_ptr_reply = &block_reply;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr_NativeHandle (This.Handle, Selector.GetHandle ("openItem:withModes:replyHandler:"), item__handle__, (UIntPtr) (ulong) mode, (IntPtr) block_ptr_reply);
			GC.KeepAlive (This);
			GC.KeepAlive (item);
		}
		[global::Foundation.RequiredMember]
		[Export ("closeItem:keepingModes:replyHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void CloseItem (FSItem item, FSVolumeOpenModes mode, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDFSVolumeOpenCloseOperationsHandler))]FSVolumeOpenCloseOperationsHandler reply)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _CloseItem (IFSVolumeOpenCloseOperations This, FSItem item, FSVolumeOpenModes mode, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDFSVolumeOpenCloseOperationsHandler))]FSVolumeOpenCloseOperationsHandler reply)
		{
			var item__handle__ = item!.GetNonNullHandle (nameof (item));
			if (reply is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (reply));
			using var block_reply = Trampolines.SDFSVolumeOpenCloseOperationsHandler.CreateBlock (reply);
			BlockLiteral *block_ptr_reply = &block_reply;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr_NativeHandle (This.Handle, Selector.GetHandle ("closeItem:keepingModes:replyHandler:"), item__handle__, (UIntPtr) (ulong) mode, (IntPtr) block_ptr_reply);
			GC.KeepAlive (This);
			GC.KeepAlive (item);
		}
		[DynamicDependencyAttribute ("CloseItem(FSKit.FSItem,FSKit.FSVolumeOpenModes,FSKit.FSVolumeOpenCloseOperationsHandler)")]
		[DynamicDependencyAttribute ("IsOpenCloseInhibited")]
		[DynamicDependencyAttribute ("OpenItem(FSKit.FSItem,FSKit.FSVolumeOpenModes,FSKit.FSVolumeOpenCloseOperationsHandler)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (FSVolumeOpenCloseOperationsWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IFSVolumeOpenCloseOperations ()
		{
			GC.KeepAlive (null);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.OptionalMember]
		public virtual bool IsOpenCloseInhibited {
			[Export ("isOpenCloseInhibited")]
			get {
				return _GetIsOpenCloseInhibited (this);
			}
			[Export ("setOpenCloseInhibited:")]
			set {
				_SetIsOpenCloseInhibited (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _GetIsOpenCloseInhibited (IFSVolumeOpenCloseOperations This)
		{
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("isOpenCloseInhibited"));
			GC.KeepAlive (This);
			return ret != 0;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetIsOpenCloseInhibited (IFSVolumeOpenCloseOperations This, bool value)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_bool (This.Handle, Selector.GetHandle ("setOpenCloseInhibited:"), value ? (byte) 1 : (byte) 0);
			GC.KeepAlive (This);
		}
	}
	#pragma warning restore CS1573
	[Experimental ("APL0002")]
	internal unsafe sealed class FSVolumeOpenCloseOperationsWrapper : BaseWrapper, IFSVolumeOpenCloseOperations {
		[Experimental ("APL0002")]
		public FSVolumeOpenCloseOperationsWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (FSVolumeOpenCloseOperationsWrapper))]
		static FSVolumeOpenCloseOperationsWrapper ()
		{
			GC.KeepAlive (null);
		}
		[Export ("openItem:withModes:replyHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void OpenItem (FSItem item, FSVolumeOpenModes mode, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDFSVolumeOpenCloseOperationsHandler))]FSVolumeOpenCloseOperationsHandler reply)
		{
			var item__handle__ = item!.GetNonNullHandle (nameof (item));
			if (reply is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (reply));
			using var block_reply = Trampolines.SDFSVolumeOpenCloseOperationsHandler.CreateBlock (reply);
			BlockLiteral *block_ptr_reply = &block_reply;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr_NativeHandle (this.Handle, Selector.GetHandle ("openItem:withModes:replyHandler:"), item__handle__, (UIntPtr) (ulong) mode, (IntPtr) block_ptr_reply);
			GC.KeepAlive (item);
		}
		[Export ("closeItem:keepingModes:replyHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void CloseItem (FSItem item, FSVolumeOpenModes mode, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDFSVolumeOpenCloseOperationsHandler))]FSVolumeOpenCloseOperationsHandler reply)
		{
			var item__handle__ = item!.GetNonNullHandle (nameof (item));
			if (reply is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (reply));
			using var block_reply = Trampolines.SDFSVolumeOpenCloseOperationsHandler.CreateBlock (reply);
			BlockLiteral *block_ptr_reply = &block_reply;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr_NativeHandle (this.Handle, Selector.GetHandle ("closeItem:keepingModes:replyHandler:"), item__handle__, (UIntPtr) (ulong) mode, (IntPtr) block_ptr_reply);
			GC.KeepAlive (item);
		}
	}
}
