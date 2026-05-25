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
	/// <summary>This interface represents the Objective-C protocol <c>FSVolumeRenameOperations</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[SupportedOSPlatform ("macos15.4")]
	[Experimental ("APL0002")]
	[Protocol (Name = "FSVolumeRenameOperations", WrapperType = typeof (FSVolumeRenameOperationsWrapper), BackwardsCompatibleCodeGeneration = false)]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetVolumeName", Selector = "setVolumeName:replyHandler:", ParameterType = new Type [] { typeof (FSKit.FSFileName), typeof (FSKit.FSVolumeRenameOperationsSetVolumeNameHandler) }, ParameterByRef = new bool [] { false, false }, ParameterBlockProxy = new Type? [] { null, typeof (ObjCRuntime.Trampolines.NIDFSVolumeRenameOperationsSetVolumeNameHandler) })]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "IsVolumeRenameInhibited", Selector = "volumeRenameInhibited", PropertyType = typeof (bool), GetterSelector = "isVolumeRenameInhibited", SetterSelector = "setVolumeRenameInhibited:", ArgumentSemantic = ArgumentSemantic.None)]
	public partial interface IFSVolumeRenameOperations : INativeObject, IDisposable
	{
		[global::Foundation.RequiredMember]
		[Export ("setVolumeName:replyHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void SetVolumeName (FSFileName name, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDFSVolumeRenameOperationsSetVolumeNameHandler))]FSVolumeRenameOperationsSetVolumeNameHandler reply)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _SetVolumeName (IFSVolumeRenameOperations This, FSFileName name, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDFSVolumeRenameOperationsSetVolumeNameHandler))]FSVolumeRenameOperationsSetVolumeNameHandler reply)
		{
			var name__handle__ = name!.GetNonNullHandle (nameof (name));
			if (reply is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (reply));
			using var block_reply = Trampolines.SDFSVolumeRenameOperationsSetVolumeNameHandler.CreateBlock (reply);
			BlockLiteral *block_ptr_reply = &block_reply;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("setVolumeName:replyHandler:"), name__handle__, (IntPtr) block_ptr_reply);
			GC.KeepAlive (This);
			GC.KeepAlive (name);
		}
		[DynamicDependencyAttribute ("IsVolumeRenameInhibited")]
		[DynamicDependencyAttribute ("SetVolumeName(FSKit.FSFileName,FSKit.FSVolumeRenameOperationsSetVolumeNameHandler)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (FSVolumeRenameOperationsWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IFSVolumeRenameOperations ()
		{
			GC.KeepAlive (null);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.OptionalMember]
		public virtual bool IsVolumeRenameInhibited {
			[Export ("isVolumeRenameInhibited")]
			get {
				return _GetIsVolumeRenameInhibited (this);
			}
			[Export ("setVolumeRenameInhibited:")]
			set {
				_SetIsVolumeRenameInhibited (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _GetIsVolumeRenameInhibited (IFSVolumeRenameOperations This)
		{
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("isVolumeRenameInhibited"));
			GC.KeepAlive (This);
			return ret != 0;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetIsVolumeRenameInhibited (IFSVolumeRenameOperations This, bool value)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_bool (This.Handle, Selector.GetHandle ("setVolumeRenameInhibited:"), value ? (byte) 1 : (byte) 0);
			GC.KeepAlive (This);
		}
	}
	#pragma warning restore CS1573
	[Experimental ("APL0002")]
	internal unsafe sealed class FSVolumeRenameOperationsWrapper : BaseWrapper, IFSVolumeRenameOperations {
		[Experimental ("APL0002")]
		public FSVolumeRenameOperationsWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (FSVolumeRenameOperationsWrapper))]
		static FSVolumeRenameOperationsWrapper ()
		{
			GC.KeepAlive (null);
		}
		[Export ("setVolumeName:replyHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void SetVolumeName (FSFileName name, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDFSVolumeRenameOperationsSetVolumeNameHandler))]FSVolumeRenameOperationsSetVolumeNameHandler reply)
		{
			var name__handle__ = name!.GetNonNullHandle (nameof (name));
			if (reply is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (reply));
			using var block_reply = Trampolines.SDFSVolumeRenameOperationsSetVolumeNameHandler.CreateBlock (reply);
			BlockLiteral *block_ptr_reply = &block_reply;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("setVolumeName:replyHandler:"), name__handle__, (IntPtr) block_ptr_reply);
			GC.KeepAlive (name);
		}
	}
}
