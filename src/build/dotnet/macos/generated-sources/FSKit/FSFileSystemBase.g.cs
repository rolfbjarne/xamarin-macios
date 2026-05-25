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
	/// <summary>This interface represents the Objective-C protocol <c>FSFileSystemBase</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[SupportedOSPlatform ("macos15.4")]
	[Experimental ("APL0002")]
	[Protocol (Name = "FSFileSystemBase", WrapperType = typeof (FSFileSystemBaseWrapper), BackwardsCompatibleCodeGeneration = false)]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "WipeResource", Selector = "wipeResource:completionHandler:", ParameterType = new Type [] { typeof (FSKit.FSBlockDeviceResource), typeof (FSKit.FSFileSystemBaseWipeResourceCompletionHandler) }, ParameterByRef = new bool [] { false, false }, ParameterBlockProxy = new Type? [] { null, typeof (ObjCRuntime.Trampolines.NIDFSFileSystemBaseWipeResourceCompletionHandler) })]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "ContainerStatus", Selector = "containerStatus", PropertyType = typeof (FSKit.FSContainerStatus), GetterSelector = "containerStatus", SetterSelector = "setContainerStatus:", ArgumentSemantic = ArgumentSemantic.Copy)]
	public partial interface IFSFileSystemBase : INativeObject, IDisposable
	{
		[global::Foundation.RequiredMember]
		[Export ("wipeResource:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void WipeResource (FSBlockDeviceResource resource, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDFSFileSystemBaseWipeResourceCompletionHandler))]FSFileSystemBaseWipeResourceCompletionHandler completionHandler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _WipeResource (IFSFileSystemBase This, FSBlockDeviceResource resource, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDFSFileSystemBaseWipeResourceCompletionHandler))]FSFileSystemBaseWipeResourceCompletionHandler completionHandler)
		{
			var resource__handle__ = resource!.GetNonNullHandle (nameof (resource));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDFSFileSystemBaseWipeResourceCompletionHandler.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("wipeResource:completionHandler:"), resource__handle__, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
			GC.KeepAlive (resource);
		}
		[DynamicDependencyAttribute ("ContainerStatus")]
		[DynamicDependencyAttribute ("WipeResource(FSKit.FSBlockDeviceResource,FSKit.FSFileSystemBaseWipeResourceCompletionHandler)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (FSFileSystemBaseWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IFSFileSystemBase ()
		{
			GC.KeepAlive (null);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual FSContainerStatus ContainerStatus {
			[Export ("containerStatus", ArgumentSemantic.Copy)]
			get {
				return _GetContainerStatus (this);
			}
			[Export ("setContainerStatus:", ArgumentSemantic.Copy)]
			set {
				_SetContainerStatus (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static FSContainerStatus _GetContainerStatus (IFSFileSystemBase This)
		{
			FSContainerStatus ret;
			ret =  Runtime.GetNSObject<FSContainerStatus> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("containerStatus")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetContainerStatus (IFSFileSystemBase This, FSContainerStatus value)
		{
			var value__handle__ = value!.GetNonNullHandle (nameof (value));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setContainerStatus:"), value__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (value);
		}
	}
	#pragma warning restore CS1573
	[Experimental ("APL0002")]
	internal unsafe sealed class FSFileSystemBaseWrapper : BaseWrapper, IFSFileSystemBase {
		[Experimental ("APL0002")]
		public FSFileSystemBaseWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (FSFileSystemBaseWrapper))]
		static FSFileSystemBaseWrapper ()
		{
			GC.KeepAlive (null);
		}
		[Export ("wipeResource:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void WipeResource (FSBlockDeviceResource resource, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDFSFileSystemBaseWipeResourceCompletionHandler))]FSFileSystemBaseWipeResourceCompletionHandler completionHandler)
		{
			var resource__handle__ = resource!.GetNonNullHandle (nameof (resource));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDFSFileSystemBaseWipeResourceCompletionHandler.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("wipeResource:completionHandler:"), resource__handle__, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (resource);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public FSContainerStatus ContainerStatus {
			[Export ("containerStatus", ArgumentSemantic.Copy)]
			get {
				FSContainerStatus ret;
				ret =  Runtime.GetNSObject<FSContainerStatus> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("containerStatus")), false)!;
				return ret;
			}
			[Export ("setContainerStatus:", ArgumentSemantic.Copy)]
			set {
				var value__handle__ = value!.GetNonNullHandle (nameof (value));
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setContainerStatus:"), value__handle__);
				GC.KeepAlive (value);
			}
		}
	}
}
