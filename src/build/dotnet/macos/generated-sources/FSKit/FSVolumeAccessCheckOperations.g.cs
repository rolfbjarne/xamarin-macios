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
	/// <summary>This interface represents the Objective-C protocol <c>FSVolumeAccessCheckOperations</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[SupportedOSPlatform ("macos15.4")]
	[Experimental ("APL0002")]
	[Protocol (Name = "FSVolumeAccessCheckOperations", WrapperType = typeof (FSVolumeAccessCheckOperationsWrapper), BackwardsCompatibleCodeGeneration = false)]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "RequestedAccess", Selector = "checkAccessToItem:requestedAccess:replyHandler:", ParameterType = new Type [] { typeof (FSKit.FSItem), typeof (FSKit.FSAccessMask), typeof (FSKit.FSVolumeAccessCheckOperationsCheckAccessHandler) }, ParameterByRef = new bool [] { false, false, false }, ParameterBlockProxy = new Type? [] { null, null, typeof (ObjCRuntime.Trampolines.NIDFSVolumeAccessCheckOperationsCheckAccessHandler) })]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "IsAccessCheckInhibited", Selector = "accessCheckInhibited", PropertyType = typeof (bool), GetterSelector = "isAccessCheckInhibited", SetterSelector = "setAccessCheckInhibited:", ArgumentSemantic = ArgumentSemantic.None)]
	public partial interface IFSVolumeAccessCheckOperations : INativeObject, IDisposable
	{
		[global::Foundation.RequiredMember]
		[Export ("checkAccessToItem:requestedAccess:replyHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void RequestedAccess (FSItem theItem, FSAccessMask access, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDFSVolumeAccessCheckOperationsCheckAccessHandler))]FSVolumeAccessCheckOperationsCheckAccessHandler reply)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _RequestedAccess (IFSVolumeAccessCheckOperations This, FSItem theItem, FSAccessMask access, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDFSVolumeAccessCheckOperationsCheckAccessHandler))]FSVolumeAccessCheckOperationsCheckAccessHandler reply)
		{
			var theItem__handle__ = theItem!.GetNonNullHandle (nameof (theItem));
			if (reply is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (reply));
			using var block_reply = Trampolines.SDFSVolumeAccessCheckOperationsCheckAccessHandler.CreateBlock (reply);
			BlockLiteral *block_ptr_reply = &block_reply;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr_NativeHandle (This.Handle, Selector.GetHandle ("checkAccessToItem:requestedAccess:replyHandler:"), theItem__handle__, (UIntPtr) (ulong) access, (IntPtr) block_ptr_reply);
			GC.KeepAlive (This);
			GC.KeepAlive (theItem);
		}
		[DynamicDependencyAttribute ("IsAccessCheckInhibited")]
		[DynamicDependencyAttribute ("RequestedAccess(FSKit.FSItem,FSKit.FSAccessMask,FSKit.FSVolumeAccessCheckOperationsCheckAccessHandler)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (FSVolumeAccessCheckOperationsWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IFSVolumeAccessCheckOperations ()
		{
			GC.KeepAlive (null);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.OptionalMember]
		public virtual bool IsAccessCheckInhibited {
			[Export ("isAccessCheckInhibited")]
			get {
				return _GetIsAccessCheckInhibited (this);
			}
			[Export ("setAccessCheckInhibited:")]
			set {
				_SetIsAccessCheckInhibited (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _GetIsAccessCheckInhibited (IFSVolumeAccessCheckOperations This)
		{
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("isAccessCheckInhibited"));
			GC.KeepAlive (This);
			return ret != 0;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetIsAccessCheckInhibited (IFSVolumeAccessCheckOperations This, bool value)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_bool (This.Handle, Selector.GetHandle ("setAccessCheckInhibited:"), value ? (byte) 1 : (byte) 0);
			GC.KeepAlive (This);
		}
	}
	#pragma warning restore CS1573
	[Experimental ("APL0002")]
	internal unsafe sealed class FSVolumeAccessCheckOperationsWrapper : BaseWrapper, IFSVolumeAccessCheckOperations {
		[Experimental ("APL0002")]
		public FSVolumeAccessCheckOperationsWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (FSVolumeAccessCheckOperationsWrapper))]
		static FSVolumeAccessCheckOperationsWrapper ()
		{
			GC.KeepAlive (null);
		}
		[Export ("checkAccessToItem:requestedAccess:replyHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void RequestedAccess (FSItem theItem, FSAccessMask access, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDFSVolumeAccessCheckOperationsCheckAccessHandler))]FSVolumeAccessCheckOperationsCheckAccessHandler reply)
		{
			var theItem__handle__ = theItem!.GetNonNullHandle (nameof (theItem));
			if (reply is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (reply));
			using var block_reply = Trampolines.SDFSVolumeAccessCheckOperationsCheckAccessHandler.CreateBlock (reply);
			BlockLiteral *block_ptr_reply = &block_reply;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr_NativeHandle (this.Handle, Selector.GetHandle ("checkAccessToItem:requestedAccess:replyHandler:"), theItem__handle__, (UIntPtr) (ulong) access, (IntPtr) block_ptr_reply);
			GC.KeepAlive (theItem);
		}
	}
}
