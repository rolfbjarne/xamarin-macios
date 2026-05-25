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
	/// <summary>This interface represents the Objective-C protocol <c>FSUnaryFileSystemOperations</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[SupportedOSPlatform ("macos15.4")]
	[Experimental ("APL0002")]
	[Protocol (Name = "FSUnaryFileSystemOperations", WrapperType = typeof (FSUnaryFileSystemOperationsWrapper), BackwardsCompatibleCodeGeneration = false)]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "ProbeResource", Selector = "probeResource:replyHandler:", ParameterType = new Type [] { typeof (FSKit.FSResource), typeof (FSKit.FSUnaryFileSystemOperationsProbeResourceResult) }, ParameterByRef = new bool [] { false, false }, ParameterBlockProxy = new Type? [] { null, typeof (ObjCRuntime.Trampolines.NIDFSUnaryFileSystemOperationsProbeResourceResult) })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "LoadResource", Selector = "loadResource:options:replyHandler:", ParameterType = new Type [] { typeof (FSKit.FSResource), typeof (FSKit.FSTaskOptions), typeof (FSKit.FSUnaryFileSystemOperationsLoadResourceResult) }, ParameterByRef = new bool [] { false, false, false }, ParameterBlockProxy = new Type? [] { null, null, typeof (ObjCRuntime.Trampolines.NIDFSUnaryFileSystemOperationsLoadResourceResult) })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "UnloadResource", Selector = "unloadResource:options:replyHandler:", ParameterType = new Type [] { typeof (FSKit.FSResource), typeof (FSKit.FSTaskOptions), typeof (FSKit.FSUnaryFileSystemOperationsUnloadResourceResult) }, ParameterByRef = new bool [] { false, false, false }, ParameterBlockProxy = new Type? [] { null, null, typeof (ObjCRuntime.Trampolines.NIDFSUnaryFileSystemOperationsUnloadResourceResult) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidFinishLoading", Selector = "didFinishLoading")]
	public partial interface IFSUnaryFileSystemOperations : INativeObject, IDisposable
	{
		[global::Foundation.RequiredMember]
		[Export ("probeResource:replyHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void ProbeResource (FSResource resource, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDFSUnaryFileSystemOperationsProbeResourceResult))]FSUnaryFileSystemOperationsProbeResourceResult replyHandler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _ProbeResource (IFSUnaryFileSystemOperations This, FSResource resource, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDFSUnaryFileSystemOperationsProbeResourceResult))]FSUnaryFileSystemOperationsProbeResourceResult replyHandler)
		{
			var resource__handle__ = resource!.GetNonNullHandle (nameof (resource));
			if (replyHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (replyHandler));
			using var block_replyHandler = Trampolines.SDFSUnaryFileSystemOperationsProbeResourceResult.CreateBlock (replyHandler);
			BlockLiteral *block_ptr_replyHandler = &block_replyHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("probeResource:replyHandler:"), resource__handle__, (IntPtr) block_ptr_replyHandler);
			GC.KeepAlive (This);
			GC.KeepAlive (resource);
		}
		[global::Foundation.RequiredMember]
		[Export ("loadResource:options:replyHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void LoadResource (FSResource resource, FSTaskOptions options, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDFSUnaryFileSystemOperationsLoadResourceResult))]FSUnaryFileSystemOperationsLoadResourceResult replyHandler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _LoadResource (IFSUnaryFileSystemOperations This, FSResource resource, FSTaskOptions options, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDFSUnaryFileSystemOperationsLoadResourceResult))]FSUnaryFileSystemOperationsLoadResourceResult replyHandler)
		{
			var resource__handle__ = resource!.GetNonNullHandle (nameof (resource));
			var options__handle__ = options!.GetNonNullHandle (nameof (options));
			if (replyHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (replyHandler));
			using var block_replyHandler = Trampolines.SDFSUnaryFileSystemOperationsLoadResourceResult.CreateBlock (replyHandler);
			BlockLiteral *block_ptr_replyHandler = &block_replyHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("loadResource:options:replyHandler:"), resource__handle__, options__handle__, (IntPtr) block_ptr_replyHandler);
			GC.KeepAlive (This);
			GC.KeepAlive (resource);
			GC.KeepAlive (options);
		}
		[global::Foundation.RequiredMember]
		[Export ("unloadResource:options:replyHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void UnloadResource (FSResource resource, FSTaskOptions options, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDFSUnaryFileSystemOperationsUnloadResourceResult))]FSUnaryFileSystemOperationsUnloadResourceResult reply)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _UnloadResource (IFSUnaryFileSystemOperations This, FSResource resource, FSTaskOptions options, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDFSUnaryFileSystemOperationsUnloadResourceResult))]FSUnaryFileSystemOperationsUnloadResourceResult reply)
		{
			var resource__handle__ = resource!.GetNonNullHandle (nameof (resource));
			var options__handle__ = options!.GetNonNullHandle (nameof (options));
			if (reply is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (reply));
			using var block_reply = Trampolines.SDFSUnaryFileSystemOperationsUnloadResourceResult.CreateBlock (reply);
			BlockLiteral *block_ptr_reply = &block_reply;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("unloadResource:options:replyHandler:"), resource__handle__, options__handle__, (IntPtr) block_ptr_reply);
			GC.KeepAlive (This);
			GC.KeepAlive (resource);
			GC.KeepAlive (options);
		}
		[global::Foundation.OptionalMember]
		[Export ("didFinishLoading")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidFinishLoading ()
		{
			_DidFinishLoading (this);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidFinishLoading (IFSUnaryFileSystemOperations This)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("didFinishLoading"));
			GC.KeepAlive (This);
		}
		[DynamicDependencyAttribute ("DidFinishLoading()")]
		[DynamicDependencyAttribute ("LoadResource(FSKit.FSResource,FSKit.FSTaskOptions,FSKit.FSUnaryFileSystemOperationsLoadResourceResult)")]
		[DynamicDependencyAttribute ("ProbeResource(FSKit.FSResource,FSKit.FSUnaryFileSystemOperationsProbeResourceResult)")]
		[DynamicDependencyAttribute ("UnloadResource(FSKit.FSResource,FSKit.FSTaskOptions,FSKit.FSUnaryFileSystemOperationsUnloadResourceResult)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (FSUnaryFileSystemOperationsWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IFSUnaryFileSystemOperations ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	[Experimental ("APL0002")]
	internal unsafe sealed class FSUnaryFileSystemOperationsWrapper : BaseWrapper, IFSUnaryFileSystemOperations {
		[Experimental ("APL0002")]
		public FSUnaryFileSystemOperationsWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (FSUnaryFileSystemOperationsWrapper))]
		static FSUnaryFileSystemOperationsWrapper ()
		{
			GC.KeepAlive (null);
		}
		[Export ("probeResource:replyHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void ProbeResource (FSResource resource, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDFSUnaryFileSystemOperationsProbeResourceResult))]FSUnaryFileSystemOperationsProbeResourceResult replyHandler)
		{
			var resource__handle__ = resource!.GetNonNullHandle (nameof (resource));
			if (replyHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (replyHandler));
			using var block_replyHandler = Trampolines.SDFSUnaryFileSystemOperationsProbeResourceResult.CreateBlock (replyHandler);
			BlockLiteral *block_ptr_replyHandler = &block_replyHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("probeResource:replyHandler:"), resource__handle__, (IntPtr) block_ptr_replyHandler);
			GC.KeepAlive (resource);
		}
		[Export ("loadResource:options:replyHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void LoadResource (FSResource resource, FSTaskOptions options, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDFSUnaryFileSystemOperationsLoadResourceResult))]FSUnaryFileSystemOperationsLoadResourceResult replyHandler)
		{
			var resource__handle__ = resource!.GetNonNullHandle (nameof (resource));
			var options__handle__ = options!.GetNonNullHandle (nameof (options));
			if (replyHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (replyHandler));
			using var block_replyHandler = Trampolines.SDFSUnaryFileSystemOperationsLoadResourceResult.CreateBlock (replyHandler);
			BlockLiteral *block_ptr_replyHandler = &block_replyHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("loadResource:options:replyHandler:"), resource__handle__, options__handle__, (IntPtr) block_ptr_replyHandler);
			GC.KeepAlive (resource);
			GC.KeepAlive (options);
		}
		[Export ("unloadResource:options:replyHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void UnloadResource (FSResource resource, FSTaskOptions options, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDFSUnaryFileSystemOperationsUnloadResourceResult))]FSUnaryFileSystemOperationsUnloadResourceResult reply)
		{
			var resource__handle__ = resource!.GetNonNullHandle (nameof (resource));
			var options__handle__ = options!.GetNonNullHandle (nameof (options));
			if (reply is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (reply));
			using var block_reply = Trampolines.SDFSUnaryFileSystemOperationsUnloadResourceResult.CreateBlock (reply);
			BlockLiteral *block_ptr_reply = &block_reply;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("unloadResource:options:replyHandler:"), resource__handle__, options__handle__, (IntPtr) block_ptr_reply);
			GC.KeepAlive (resource);
			GC.KeepAlive (options);
		}
	}
}
