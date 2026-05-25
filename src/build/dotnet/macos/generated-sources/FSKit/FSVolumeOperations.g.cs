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
	/// <summary>This interface represents the Objective-C protocol <c>FSVolumeOperations</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[SupportedOSPlatform ("macos15.4")]
	[Experimental ("APL0002")]
	[Protocol (Name = "FSVolumeOperations", WrapperType = typeof (FSVolumeOperationsWrapper), BackwardsCompatibleCodeGeneration = false)]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "Mount", Selector = "mountWithOptions:replyHandler:", ParameterType = new Type [] { typeof (FSKit.FSTaskOptions), typeof (FSKit.FSVolumeOperationsMountHandler) }, ParameterByRef = new bool [] { false, false }, ParameterBlockProxy = new Type? [] { null, typeof (ObjCRuntime.Trampolines.NIDFSVolumeOperationsMountHandler) })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "Unmount", Selector = "unmountWithReplyHandler:", ParameterType = new Type [] { typeof (Action) }, ParameterByRef = new bool [] { false }, ParameterBlockProxy = new Type? [] { typeof (ObjCRuntime.Trampolines.NIDAction) })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "Synchronize", Selector = "synchronizeWithFlags:replyHandler:", ParameterType = new Type [] { typeof (FSKit.FSSyncFlags), typeof (FSKit.FSVolumeOperationsSynchronizeHandler) }, ParameterByRef = new bool [] { false, false }, ParameterBlockProxy = new Type? [] { null, typeof (ObjCRuntime.Trampolines.NIDFSVolumeOperationsSynchronizeHandler) })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetAttributes", Selector = "getAttributes:ofItem:replyHandler:", ParameterType = new Type [] { typeof (FSKit.FSItemGetAttributesRequest), typeof (FSKit.FSItem), typeof (FSKit.FSVolumeOperationsAttributesHandler) }, ParameterByRef = new bool [] { false, false, false }, ParameterBlockProxy = new Type? [] { null, null, typeof (ObjCRuntime.Trampolines.NIDFSVolumeOperationsAttributesHandler) })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetAttributes", Selector = "setAttributes:onItem:replyHandler:", ParameterType = new Type [] { typeof (FSKit.FSItemSetAttributesRequest), typeof (FSKit.FSItem), typeof (FSKit.FSVolumeOperationsAttributesHandler) }, ParameterByRef = new bool [] { false, false, false }, ParameterBlockProxy = new Type? [] { null, null, typeof (ObjCRuntime.Trampolines.NIDFSVolumeOperationsAttributesHandler) })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "LookupItem", Selector = "lookupItemNamed:inDirectory:replyHandler:", ParameterType = new Type [] { typeof (FSKit.FSFileName), typeof (FSKit.FSItem), typeof (FSKit.FSVolumeOperationsLookupItemHandler) }, ParameterByRef = new bool [] { false, false, false }, ParameterBlockProxy = new Type? [] { null, null, typeof (ObjCRuntime.Trampolines.NIDFSVolumeOperationsLookupItemHandler) })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "Reclaim", Selector = "reclaimItem:replyHandler:", ParameterType = new Type [] { typeof (FSKit.FSItem), typeof (FSKit.FSVolumeOperationsReclaimHandler) }, ParameterByRef = new bool [] { false, false }, ParameterBlockProxy = new Type? [] { null, typeof (ObjCRuntime.Trampolines.NIDFSVolumeOperationsReclaimHandler) })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "ReadSymbolicLink", Selector = "readSymbolicLink:replyHandler:", ParameterType = new Type [] { typeof (FSKit.FSItem), typeof (FSKit.FSVolumeOperationsReadSymbolicLinkHandler) }, ParameterByRef = new bool [] { false, false }, ParameterBlockProxy = new Type? [] { null, typeof (ObjCRuntime.Trampolines.NIDFSVolumeOperationsReadSymbolicLinkHandler) })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "CreateItem", Selector = "createItemNamed:type:inDirectory:attributes:replyHandler:", ParameterType = new Type [] { typeof (FSKit.FSFileName), typeof (FSKit.FSItemType), typeof (FSKit.FSItem), typeof (FSKit.FSItemSetAttributesRequest), typeof (FSKit.FSVolumeOperationsCreateItemHandler) }, ParameterByRef = new bool [] { false, false, false, false, false }, ParameterBlockProxy = new Type? [] { null, null, null, null, typeof (ObjCRuntime.Trampolines.NIDFSVolumeOperationsCreateItemHandler) })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "CreateSymbolicLink", Selector = "createSymbolicLinkNamed:inDirectory:attributes:linkContents:replyHandler:", ParameterType = new Type [] { typeof (FSKit.FSFileName), typeof (FSKit.FSItem), typeof (FSKit.FSItemSetAttributesRequest), typeof (FSKit.FSFileName), typeof (FSKit.FSVolumeOperationsCreateItemHandler) }, ParameterByRef = new bool [] { false, false, false, false, false }, ParameterBlockProxy = new Type? [] { null, null, null, null, typeof (ObjCRuntime.Trampolines.NIDFSVolumeOperationsCreateItemHandler) })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "CreateLink", Selector = "createLinkToItem:named:inDirectory:replyHandler:", ParameterType = new Type [] { typeof (FSKit.FSItem), typeof (FSKit.FSFileName), typeof (FSKit.FSItem), typeof (FSKit.FSVolumeOperationsCreateLinkHandler) }, ParameterByRef = new bool [] { false, false, false, false }, ParameterBlockProxy = new Type? [] { null, null, null, typeof (ObjCRuntime.Trampolines.NIDFSVolumeOperationsCreateLinkHandler) })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "RemoveItem", Selector = "removeItem:named:fromDirectory:replyHandler:", ParameterType = new Type [] { typeof (FSKit.FSItem), typeof (FSKit.FSFileName), typeof (FSKit.FSItem), typeof (FSKit.FSVolumeOperationsRemoveItemHandler) }, ParameterByRef = new bool [] { false, false, false, false }, ParameterBlockProxy = new Type? [] { null, null, null, typeof (ObjCRuntime.Trampolines.NIDFSVolumeOperationsRemoveItemHandler) })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "RenameItem", Selector = "renameItem:inDirectory:named:toNewName:inDirectory:overItem:replyHandler:", ParameterType = new Type [] { typeof (FSKit.FSItem), typeof (FSKit.FSItem), typeof (FSKit.FSFileName), typeof (FSKit.FSFileName), typeof (FSKit.FSItem), typeof (FSKit.FSItem), typeof (FSKit.FSVolumeOperationsRenameItemHandler) }, ParameterByRef = new bool [] { false, false, false, false, false, false, false }, ParameterBlockProxy = new Type? [] { null, null, null, null, null, null, typeof (ObjCRuntime.Trampolines.NIDFSVolumeOperationsRenameItemHandler) })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "EnumerateDirectory", Selector = "enumerateDirectory:startingAtCookie:verifier:providingAttributes:usingPacker:replyHandler:", ParameterType = new Type [] { typeof (FSKit.FSItem), typeof (ulong), typeof (ulong), typeof (FSKit.FSItemGetAttributesRequest), typeof (FSKit.FSDirectoryEntryPacker), typeof (FSKit.FSVolumeOperationsEnumerateDirectoryHandler) }, ParameterByRef = new bool [] { false, false, false, false, false, false }, ParameterBlockProxy = new Type? [] { null, null, null, null, null, typeof (ObjCRuntime.Trampolines.NIDFSVolumeOperationsEnumerateDirectoryHandler) })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "Activate", Selector = "activateWithOptions:replyHandler:", ParameterType = new Type [] { typeof (FSKit.FSTaskOptions), typeof (FSKit.FSVolumeOperationsActivateHandler) }, ParameterByRef = new bool [] { false, false }, ParameterBlockProxy = new Type? [] { null, typeof (ObjCRuntime.Trampolines.NIDFSVolumeOperationsActivateHandler) })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "Deactivate", Selector = "deactivateWithOptions:replyHandler:", ParameterType = new Type [] { typeof (FSKit.FSDeactivateOptions), typeof (FSKit.FSVolumeOperationsDeactivateHandler) }, ParameterByRef = new bool [] { false, false }, ParameterBlockProxy = new Type? [] { null, typeof (ObjCRuntime.Trampolines.NIDFSVolumeOperationsDeactivateHandler) })]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "SupportedVolumeCapabilities", Selector = "supportedVolumeCapabilities", PropertyType = typeof (FSKit.FSVolumeSupportedCapabilities), GetterSelector = "supportedVolumeCapabilities", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "VolumeStatistics", Selector = "volumeStatistics", PropertyType = typeof (FSKit.FSStatFSResult), GetterSelector = "volumeStatistics", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "EnableOpenUnlinkEmulation", Selector = "enableOpenUnlinkEmulation", PropertyType = typeof (bool), GetterSelector = "enableOpenUnlinkEmulation", SetterSelector = "setEnableOpenUnlinkEmulation:", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "RequestedMountOptions", Selector = "requestedMountOptions", PropertyType = typeof (FSKit.FSMountOptions), GetterSelector = "requestedMountOptions", SetterSelector = "setRequestedMountOptions:", ArgumentSemantic = ArgumentSemantic.Assign)]
	public partial interface IFSVolumeOperations : INativeObject, IDisposable, 
		FSKit.IFSVolumePathConfOperations
	{
		[global::Foundation.RequiredMember]
		[Export ("mountWithOptions:replyHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void Mount (FSTaskOptions options, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDFSVolumeOperationsMountHandler))]FSVolumeOperationsMountHandler reply)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _Mount (IFSVolumeOperations This, FSTaskOptions options, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDFSVolumeOperationsMountHandler))]FSVolumeOperationsMountHandler reply)
		{
			var options__handle__ = options!.GetNonNullHandle (nameof (options));
			if (reply is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (reply));
			using var block_reply = Trampolines.SDFSVolumeOperationsMountHandler.CreateBlock (reply);
			BlockLiteral *block_ptr_reply = &block_reply;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("mountWithOptions:replyHandler:"), options__handle__, (IntPtr) block_ptr_reply);
			GC.KeepAlive (This);
			GC.KeepAlive (options);
		}
		[global::Foundation.RequiredMember]
		[Export ("unmountWithReplyHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void Unmount ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action reply)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _Unmount (IFSVolumeOperations This, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action reply)
		{
			if (reply is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (reply));
			using var block_reply = Trampolines.SDAction.CreateBlock (reply);
			BlockLiteral *block_ptr_reply = &block_reply;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("unmountWithReplyHandler:"), (IntPtr) block_ptr_reply);
			GC.KeepAlive (This);
		}
		[global::Foundation.RequiredMember]
		[Export ("synchronizeWithFlags:replyHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void Synchronize (FSSyncFlags flags, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDFSVolumeOperationsSynchronizeHandler))]FSVolumeOperationsSynchronizeHandler reply)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _Synchronize (IFSVolumeOperations This, FSSyncFlags flags, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDFSVolumeOperationsSynchronizeHandler))]FSVolumeOperationsSynchronizeHandler reply)
		{
			if (reply is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (reply));
			using var block_reply = Trampolines.SDFSVolumeOperationsSynchronizeHandler.CreateBlock (reply);
			BlockLiteral *block_ptr_reply = &block_reply;
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_NativeHandle (This.Handle, Selector.GetHandle ("synchronizeWithFlags:replyHandler:"), (IntPtr) (long) flags, (IntPtr) block_ptr_reply);
			GC.KeepAlive (This);
		}
		[global::Foundation.RequiredMember]
		[Export ("getAttributes:ofItem:replyHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void GetAttributes (FSItemGetAttributesRequest desiredAttributes, FSItem item, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDFSVolumeOperationsAttributesHandler))]FSVolumeOperationsAttributesHandler reply)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _GetAttributes (IFSVolumeOperations This, FSItemGetAttributesRequest desiredAttributes, FSItem item, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDFSVolumeOperationsAttributesHandler))]FSVolumeOperationsAttributesHandler reply)
		{
			var desiredAttributes__handle__ = desiredAttributes!.GetNonNullHandle (nameof (desiredAttributes));
			var item__handle__ = item!.GetNonNullHandle (nameof (item));
			if (reply is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (reply));
			using var block_reply = Trampolines.SDFSVolumeOperationsAttributesHandler.CreateBlock (reply);
			BlockLiteral *block_ptr_reply = &block_reply;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("getAttributes:ofItem:replyHandler:"), desiredAttributes__handle__, item__handle__, (IntPtr) block_ptr_reply);
			GC.KeepAlive (This);
			GC.KeepAlive (desiredAttributes);
			GC.KeepAlive (item);
		}
		[global::Foundation.RequiredMember]
		[Export ("setAttributes:onItem:replyHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void SetAttributes (FSItemSetAttributesRequest newAttributes, FSItem item, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDFSVolumeOperationsAttributesHandler))]FSVolumeOperationsAttributesHandler reply)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _SetAttributes (IFSVolumeOperations This, FSItemSetAttributesRequest newAttributes, FSItem item, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDFSVolumeOperationsAttributesHandler))]FSVolumeOperationsAttributesHandler reply)
		{
			var newAttributes__handle__ = newAttributes!.GetNonNullHandle (nameof (newAttributes));
			var item__handle__ = item!.GetNonNullHandle (nameof (item));
			if (reply is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (reply));
			using var block_reply = Trampolines.SDFSVolumeOperationsAttributesHandler.CreateBlock (reply);
			BlockLiteral *block_ptr_reply = &block_reply;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("setAttributes:onItem:replyHandler:"), newAttributes__handle__, item__handle__, (IntPtr) block_ptr_reply);
			GC.KeepAlive (This);
			GC.KeepAlive (newAttributes);
			GC.KeepAlive (item);
		}
		[global::Foundation.RequiredMember]
		[Export ("lookupItemNamed:inDirectory:replyHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void LookupItem (FSFileName name, FSItem directory, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDFSVolumeOperationsLookupItemHandler))]FSVolumeOperationsLookupItemHandler reply)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _LookupItem (IFSVolumeOperations This, FSFileName name, FSItem directory, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDFSVolumeOperationsLookupItemHandler))]FSVolumeOperationsLookupItemHandler reply)
		{
			var name__handle__ = name!.GetNonNullHandle (nameof (name));
			var directory__handle__ = directory!.GetNonNullHandle (nameof (directory));
			if (reply is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (reply));
			using var block_reply = Trampolines.SDFSVolumeOperationsLookupItemHandler.CreateBlock (reply);
			BlockLiteral *block_ptr_reply = &block_reply;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("lookupItemNamed:inDirectory:replyHandler:"), name__handle__, directory__handle__, (IntPtr) block_ptr_reply);
			GC.KeepAlive (This);
			GC.KeepAlive (name);
			GC.KeepAlive (directory);
		}
		[global::Foundation.RequiredMember]
		[Export ("reclaimItem:replyHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void Reclaim (FSItem item, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDFSVolumeOperationsReclaimHandler))]FSVolumeOperationsReclaimHandler reply)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _Reclaim (IFSVolumeOperations This, FSItem item, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDFSVolumeOperationsReclaimHandler))]FSVolumeOperationsReclaimHandler reply)
		{
			var item__handle__ = item!.GetNonNullHandle (nameof (item));
			if (reply is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (reply));
			using var block_reply = Trampolines.SDFSVolumeOperationsReclaimHandler.CreateBlock (reply);
			BlockLiteral *block_ptr_reply = &block_reply;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("reclaimItem:replyHandler:"), item__handle__, (IntPtr) block_ptr_reply);
			GC.KeepAlive (This);
			GC.KeepAlive (item);
		}
		[global::Foundation.RequiredMember]
		[Export ("readSymbolicLink:replyHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void ReadSymbolicLink (FSItem item, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDFSVolumeOperationsReadSymbolicLinkHandler))]FSVolumeOperationsReadSymbolicLinkHandler reply)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _ReadSymbolicLink (IFSVolumeOperations This, FSItem item, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDFSVolumeOperationsReadSymbolicLinkHandler))]FSVolumeOperationsReadSymbolicLinkHandler reply)
		{
			var item__handle__ = item!.GetNonNullHandle (nameof (item));
			if (reply is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (reply));
			using var block_reply = Trampolines.SDFSVolumeOperationsReadSymbolicLinkHandler.CreateBlock (reply);
			BlockLiteral *block_ptr_reply = &block_reply;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("readSymbolicLink:replyHandler:"), item__handle__, (IntPtr) block_ptr_reply);
			GC.KeepAlive (This);
			GC.KeepAlive (item);
		}
		[global::Foundation.RequiredMember]
		[Export ("createItemNamed:type:inDirectory:attributes:replyHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void CreateItem (FSFileName name, FSItemType type, FSItem directory, FSItemSetAttributesRequest newAttributes, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDFSVolumeOperationsCreateItemHandler))]FSVolumeOperationsCreateItemHandler reply)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _CreateItem (IFSVolumeOperations This, FSFileName name, FSItemType type, FSItem directory, FSItemSetAttributesRequest newAttributes, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDFSVolumeOperationsCreateItemHandler))]FSVolumeOperationsCreateItemHandler reply)
		{
			var name__handle__ = name!.GetNonNullHandle (nameof (name));
			var directory__handle__ = directory!.GetNonNullHandle (nameof (directory));
			var newAttributes__handle__ = newAttributes!.GetNonNullHandle (nameof (newAttributes));
			if (reply is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (reply));
			using var block_reply = Trampolines.SDFSVolumeOperationsCreateItemHandler.CreateBlock (reply);
			BlockLiteral *block_ptr_reply = &block_reply;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_IntPtr_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("createItemNamed:type:inDirectory:attributes:replyHandler:"), name__handle__, (IntPtr) (long) type, directory__handle__, newAttributes__handle__, (IntPtr) block_ptr_reply);
			GC.KeepAlive (This);
			GC.KeepAlive (name);
			GC.KeepAlive (directory);
			GC.KeepAlive (newAttributes);
		}
		[global::Foundation.RequiredMember]
		[Export ("createSymbolicLinkNamed:inDirectory:attributes:linkContents:replyHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void CreateSymbolicLink (FSFileName name, FSItem directory, FSItemSetAttributesRequest newAttributes, FSFileName contents, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDFSVolumeOperationsCreateItemHandler))]FSVolumeOperationsCreateItemHandler reply)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _CreateSymbolicLink (IFSVolumeOperations This, FSFileName name, FSItem directory, FSItemSetAttributesRequest newAttributes, FSFileName contents, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDFSVolumeOperationsCreateItemHandler))]FSVolumeOperationsCreateItemHandler reply)
		{
			var name__handle__ = name!.GetNonNullHandle (nameof (name));
			var directory__handle__ = directory!.GetNonNullHandle (nameof (directory));
			var newAttributes__handle__ = newAttributes!.GetNonNullHandle (nameof (newAttributes));
			var contents__handle__ = contents!.GetNonNullHandle (nameof (contents));
			if (reply is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (reply));
			using var block_reply = Trampolines.SDFSVolumeOperationsCreateItemHandler.CreateBlock (reply);
			BlockLiteral *block_ptr_reply = &block_reply;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("createSymbolicLinkNamed:inDirectory:attributes:linkContents:replyHandler:"), name__handle__, directory__handle__, newAttributes__handle__, contents__handle__, (IntPtr) block_ptr_reply);
			GC.KeepAlive (This);
			GC.KeepAlive (name);
			GC.KeepAlive (directory);
			GC.KeepAlive (newAttributes);
			GC.KeepAlive (contents);
		}
		[global::Foundation.RequiredMember]
		[Export ("createLinkToItem:named:inDirectory:replyHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void CreateLink (FSItem item, FSFileName name, FSItem directory, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDFSVolumeOperationsCreateLinkHandler))]FSVolumeOperationsCreateLinkHandler reply)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _CreateLink (IFSVolumeOperations This, FSItem item, FSFileName name, FSItem directory, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDFSVolumeOperationsCreateLinkHandler))]FSVolumeOperationsCreateLinkHandler reply)
		{
			var item__handle__ = item!.GetNonNullHandle (nameof (item));
			var name__handle__ = name!.GetNonNullHandle (nameof (name));
			var directory__handle__ = directory!.GetNonNullHandle (nameof (directory));
			if (reply is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (reply));
			using var block_reply = Trampolines.SDFSVolumeOperationsCreateLinkHandler.CreateBlock (reply);
			BlockLiteral *block_ptr_reply = &block_reply;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("createLinkToItem:named:inDirectory:replyHandler:"), item__handle__, name__handle__, directory__handle__, (IntPtr) block_ptr_reply);
			GC.KeepAlive (This);
			GC.KeepAlive (item);
			GC.KeepAlive (name);
			GC.KeepAlive (directory);
		}
		[global::Foundation.RequiredMember]
		[Export ("removeItem:named:fromDirectory:replyHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void RemoveItem (FSItem item, FSFileName name, FSItem directory, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDFSVolumeOperationsRemoveItemHandler))]FSVolumeOperationsRemoveItemHandler reply)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _RemoveItem (IFSVolumeOperations This, FSItem item, FSFileName name, FSItem directory, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDFSVolumeOperationsRemoveItemHandler))]FSVolumeOperationsRemoveItemHandler reply)
		{
			var item__handle__ = item!.GetNonNullHandle (nameof (item));
			var name__handle__ = name!.GetNonNullHandle (nameof (name));
			var directory__handle__ = directory!.GetNonNullHandle (nameof (directory));
			if (reply is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (reply));
			using var block_reply = Trampolines.SDFSVolumeOperationsRemoveItemHandler.CreateBlock (reply);
			BlockLiteral *block_ptr_reply = &block_reply;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("removeItem:named:fromDirectory:replyHandler:"), item__handle__, name__handle__, directory__handle__, (IntPtr) block_ptr_reply);
			GC.KeepAlive (This);
			GC.KeepAlive (item);
			GC.KeepAlive (name);
			GC.KeepAlive (directory);
		}
		[global::Foundation.RequiredMember]
		[Export ("renameItem:inDirectory:named:toNewName:inDirectory:overItem:replyHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void RenameItem (FSItem item, FSItem sourceDirectory, FSFileName sourceName, FSFileName destinationName, FSItem destinationDirectory, FSItem? overItem, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDFSVolumeOperationsRenameItemHandler))]FSVolumeOperationsRenameItemHandler reply)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _RenameItem (IFSVolumeOperations This, FSItem item, FSItem sourceDirectory, FSFileName sourceName, FSFileName destinationName, FSItem destinationDirectory, FSItem? overItem, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDFSVolumeOperationsRenameItemHandler))]FSVolumeOperationsRenameItemHandler reply)
		{
			var item__handle__ = item!.GetNonNullHandle (nameof (item));
			var sourceDirectory__handle__ = sourceDirectory!.GetNonNullHandle (nameof (sourceDirectory));
			var sourceName__handle__ = sourceName!.GetNonNullHandle (nameof (sourceName));
			var destinationName__handle__ = destinationName!.GetNonNullHandle (nameof (destinationName));
			var destinationDirectory__handle__ = destinationDirectory!.GetNonNullHandle (nameof (destinationDirectory));
			var overItem__handle__ = overItem.GetHandle ();
			if (reply is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (reply));
			using var block_reply = Trampolines.SDFSVolumeOperationsRenameItemHandler.CreateBlock (reply);
			BlockLiteral *block_ptr_reply = &block_reply;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("renameItem:inDirectory:named:toNewName:inDirectory:overItem:replyHandler:"), item__handle__, sourceDirectory__handle__, sourceName__handle__, destinationName__handle__, destinationDirectory__handle__, overItem__handle__, (IntPtr) block_ptr_reply);
			GC.KeepAlive (This);
			GC.KeepAlive (item);
			GC.KeepAlive (sourceDirectory);
			GC.KeepAlive (sourceName);
			GC.KeepAlive (destinationName);
			GC.KeepAlive (destinationDirectory);
			GC.KeepAlive (overItem);
		}
		[global::Foundation.RequiredMember]
		[Export ("enumerateDirectory:startingAtCookie:verifier:providingAttributes:usingPacker:replyHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void EnumerateDirectory (FSItem directory, ulong startingAt, ulong verifier, FSItemGetAttributesRequest? attributes, FSDirectoryEntryPacker packer, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDFSVolumeOperationsEnumerateDirectoryHandler))]FSVolumeOperationsEnumerateDirectoryHandler reply)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _EnumerateDirectory (IFSVolumeOperations This, FSItem directory, ulong startingAt, ulong verifier, FSItemGetAttributesRequest? attributes, FSDirectoryEntryPacker packer, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDFSVolumeOperationsEnumerateDirectoryHandler))]FSVolumeOperationsEnumerateDirectoryHandler reply)
		{
			var directory__handle__ = directory!.GetNonNullHandle (nameof (directory));
			var attributes__handle__ = attributes.GetHandle ();
			var packer__handle__ = packer!.GetNonNullHandle (nameof (packer));
			if (reply is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (reply));
			using var block_reply = Trampolines.SDFSVolumeOperationsEnumerateDirectoryHandler.CreateBlock (reply);
			BlockLiteral *block_ptr_reply = &block_reply;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UInt64_UInt64_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("enumerateDirectory:startingAtCookie:verifier:providingAttributes:usingPacker:replyHandler:"), directory__handle__, startingAt, verifier, attributes__handle__, packer__handle__, (IntPtr) block_ptr_reply);
			GC.KeepAlive (This);
			GC.KeepAlive (directory);
			GC.KeepAlive (attributes);
			GC.KeepAlive (packer);
		}
		[global::Foundation.RequiredMember]
		[Export ("activateWithOptions:replyHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void Activate (FSTaskOptions options, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDFSVolumeOperationsActivateHandler))]FSVolumeOperationsActivateHandler reply)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _Activate (IFSVolumeOperations This, FSTaskOptions options, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDFSVolumeOperationsActivateHandler))]FSVolumeOperationsActivateHandler reply)
		{
			var options__handle__ = options!.GetNonNullHandle (nameof (options));
			if (reply is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (reply));
			using var block_reply = Trampolines.SDFSVolumeOperationsActivateHandler.CreateBlock (reply);
			BlockLiteral *block_ptr_reply = &block_reply;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("activateWithOptions:replyHandler:"), options__handle__, (IntPtr) block_ptr_reply);
			GC.KeepAlive (This);
			GC.KeepAlive (options);
		}
		[global::Foundation.RequiredMember]
		[Export ("deactivateWithOptions:replyHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void Deactivate (FSDeactivateOptions options, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDFSVolumeOperationsDeactivateHandler))]FSVolumeOperationsDeactivateHandler reply)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _Deactivate (IFSVolumeOperations This, FSDeactivateOptions options, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDFSVolumeOperationsDeactivateHandler))]FSVolumeOperationsDeactivateHandler reply)
		{
			if (reply is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (reply));
			using var block_reply = Trampolines.SDFSVolumeOperationsDeactivateHandler.CreateBlock (reply);
			BlockLiteral *block_ptr_reply = &block_reply;
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_NativeHandle (This.Handle, Selector.GetHandle ("deactivateWithOptions:replyHandler:"), (IntPtr) (long) options, (IntPtr) block_ptr_reply);
			GC.KeepAlive (This);
		}
		[DynamicDependencyAttribute ("Activate(FSKit.FSTaskOptions,FSKit.FSVolumeOperationsActivateHandler)")]
		[DynamicDependencyAttribute ("CreateItem(FSKit.FSFileName,FSKit.FSItemType,FSKit.FSItem,FSKit.FSItemSetAttributesRequest,FSKit.FSVolumeOperationsCreateItemHandler)")]
		[DynamicDependencyAttribute ("CreateLink(FSKit.FSItem,FSKit.FSFileName,FSKit.FSItem,FSKit.FSVolumeOperationsCreateLinkHandler)")]
		[DynamicDependencyAttribute ("CreateSymbolicLink(FSKit.FSFileName,FSKit.FSItem,FSKit.FSItemSetAttributesRequest,FSKit.FSFileName,FSKit.FSVolumeOperationsCreateItemHandler)")]
		[DynamicDependencyAttribute ("Deactivate(FSKit.FSDeactivateOptions,FSKit.FSVolumeOperationsDeactivateHandler)")]
		[DynamicDependencyAttribute ("EnableOpenUnlinkEmulation")]
		[DynamicDependencyAttribute ("EnumerateDirectory(FSKit.FSItem,System.UInt64,System.UInt64,FSKit.FSItemGetAttributesRequest,FSKit.FSDirectoryEntryPacker,FSKit.FSVolumeOperationsEnumerateDirectoryHandler)")]
		[DynamicDependencyAttribute ("GetAttributes(FSKit.FSItemGetAttributesRequest,FSKit.FSItem,FSKit.FSVolumeOperationsAttributesHandler)")]
		[DynamicDependencyAttribute ("LookupItem(FSKit.FSFileName,FSKit.FSItem,FSKit.FSVolumeOperationsLookupItemHandler)")]
		[DynamicDependencyAttribute ("Mount(FSKit.FSTaskOptions,FSKit.FSVolumeOperationsMountHandler)")]
		[DynamicDependencyAttribute ("ReadSymbolicLink(FSKit.FSItem,FSKit.FSVolumeOperationsReadSymbolicLinkHandler)")]
		[DynamicDependencyAttribute ("Reclaim(FSKit.FSItem,FSKit.FSVolumeOperationsReclaimHandler)")]
		[DynamicDependencyAttribute ("RemoveItem(FSKit.FSItem,FSKit.FSFileName,FSKit.FSItem,FSKit.FSVolumeOperationsRemoveItemHandler)")]
		[DynamicDependencyAttribute ("RenameItem(FSKit.FSItem,FSKit.FSItem,FSKit.FSFileName,FSKit.FSFileName,FSKit.FSItem,FSKit.FSItem,FSKit.FSVolumeOperationsRenameItemHandler)")]
		[DynamicDependencyAttribute ("RequestedMountOptions")]
		[DynamicDependencyAttribute ("SetAttributes(FSKit.FSItemSetAttributesRequest,FSKit.FSItem,FSKit.FSVolumeOperationsAttributesHandler)")]
		[DynamicDependencyAttribute ("SupportedVolumeCapabilities")]
		[DynamicDependencyAttribute ("Synchronize(FSKit.FSSyncFlags,FSKit.FSVolumeOperationsSynchronizeHandler)")]
		[DynamicDependencyAttribute ("Unmount(System.Action)")]
		[DynamicDependencyAttribute ("VolumeStatistics")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (FSVolumeOperationsWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IFSVolumeOperations ()
		{
			GC.KeepAlive (null);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual FSVolumeSupportedCapabilities SupportedVolumeCapabilities {
			[Export ("supportedVolumeCapabilities")]
			get {
				return _GetSupportedVolumeCapabilities (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static FSVolumeSupportedCapabilities _GetSupportedVolumeCapabilities (IFSVolumeOperations This)
		{
			FSVolumeSupportedCapabilities ret;
			ret =  Runtime.GetNSObject<FSVolumeSupportedCapabilities> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("supportedVolumeCapabilities")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual FSStatFSResult VolumeStatistics {
			[Export ("volumeStatistics")]
			get {
				return _GetVolumeStatistics (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static FSStatFSResult _GetVolumeStatistics (IFSVolumeOperations This)
		{
			FSStatFSResult ret;
			ret =  Runtime.GetNSObject<FSStatFSResult> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("volumeStatistics")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("macos26.0")]
		[global::Foundation.OptionalMember]
		public virtual bool EnableOpenUnlinkEmulation {
			[Export ("enableOpenUnlinkEmulation")]
			get {
				return _GetEnableOpenUnlinkEmulation (this);
			}
			[Export ("setEnableOpenUnlinkEmulation:")]
			set {
				_SetEnableOpenUnlinkEmulation (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _GetEnableOpenUnlinkEmulation (IFSVolumeOperations This)
		{
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("enableOpenUnlinkEmulation"));
			GC.KeepAlive (This);
			return ret != 0;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetEnableOpenUnlinkEmulation (IFSVolumeOperations This, bool value)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_bool (This.Handle, Selector.GetHandle ("setEnableOpenUnlinkEmulation:"), value ? (byte) 1 : (byte) 0);
			GC.KeepAlive (This);
		}
		/// <summary>Gets or sets the mount options that the file system requests from FSKit.</summary><remarks>FSKit reads this value after the volume replies to the <see cref="M:FSKit.IFSVolumeOperations.Mount(FSKit.FSTaskOptions,FSKit.FSVolumeOperationsMountHandler)" /> call. Changing the returned value during the runtime of the volume has no effect.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("macos26.0")]
		[global::Foundation.OptionalMember]
		public virtual FSMountOptions RequestedMountOptions {
			[Export ("requestedMountOptions", ArgumentSemantic.Assign)]
			get {
				return _GetRequestedMountOptions (this);
			}
			[Export ("setRequestedMountOptions:", ArgumentSemantic.Assign)]
			set {
				_SetRequestedMountOptions (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static FSMountOptions _GetRequestedMountOptions (IFSVolumeOperations This)
		{
			FSMountOptions ret;
			ret = (FSKit.FSMountOptions) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("requestedMountOptions"));
			GC.KeepAlive (This);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetRequestedMountOptions (IFSVolumeOperations This, FSMountOptions value)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (This.Handle, Selector.GetHandle ("setRequestedMountOptions:"), (UIntPtr) (ulong) value);
			GC.KeepAlive (This);
		}
	}
	#pragma warning restore CS1573
	[Experimental ("APL0002")]
	internal unsafe sealed class FSVolumeOperationsWrapper : BaseWrapper, IFSVolumeOperations {
		[Experimental ("APL0002")]
		public FSVolumeOperationsWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (FSVolumeOperationsWrapper))]
		static FSVolumeOperationsWrapper ()
		{
			GC.KeepAlive (null);
		}
		[Export ("mountWithOptions:replyHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void Mount (FSTaskOptions options, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDFSVolumeOperationsMountHandler))]FSVolumeOperationsMountHandler reply)
		{
			var options__handle__ = options!.GetNonNullHandle (nameof (options));
			if (reply is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (reply));
			using var block_reply = Trampolines.SDFSVolumeOperationsMountHandler.CreateBlock (reply);
			BlockLiteral *block_ptr_reply = &block_reply;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("mountWithOptions:replyHandler:"), options__handle__, (IntPtr) block_ptr_reply);
			GC.KeepAlive (options);
		}
		[Export ("unmountWithReplyHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void Unmount ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action reply)
		{
			if (reply is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (reply));
			using var block_reply = Trampolines.SDAction.CreateBlock (reply);
			BlockLiteral *block_ptr_reply = &block_reply;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("unmountWithReplyHandler:"), (IntPtr) block_ptr_reply);
		}
		[Export ("synchronizeWithFlags:replyHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void Synchronize (FSSyncFlags flags, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDFSVolumeOperationsSynchronizeHandler))]FSVolumeOperationsSynchronizeHandler reply)
		{
			if (reply is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (reply));
			using var block_reply = Trampolines.SDFSVolumeOperationsSynchronizeHandler.CreateBlock (reply);
			BlockLiteral *block_ptr_reply = &block_reply;
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_NativeHandle (this.Handle, Selector.GetHandle ("synchronizeWithFlags:replyHandler:"), (IntPtr) (long) flags, (IntPtr) block_ptr_reply);
		}
		[Export ("getAttributes:ofItem:replyHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void GetAttributes (FSItemGetAttributesRequest desiredAttributes, FSItem item, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDFSVolumeOperationsAttributesHandler))]FSVolumeOperationsAttributesHandler reply)
		{
			var desiredAttributes__handle__ = desiredAttributes!.GetNonNullHandle (nameof (desiredAttributes));
			var item__handle__ = item!.GetNonNullHandle (nameof (item));
			if (reply is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (reply));
			using var block_reply = Trampolines.SDFSVolumeOperationsAttributesHandler.CreateBlock (reply);
			BlockLiteral *block_ptr_reply = &block_reply;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("getAttributes:ofItem:replyHandler:"), desiredAttributes__handle__, item__handle__, (IntPtr) block_ptr_reply);
			GC.KeepAlive (desiredAttributes);
			GC.KeepAlive (item);
		}
		[Export ("setAttributes:onItem:replyHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void SetAttributes (FSItemSetAttributesRequest newAttributes, FSItem item, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDFSVolumeOperationsAttributesHandler))]FSVolumeOperationsAttributesHandler reply)
		{
			var newAttributes__handle__ = newAttributes!.GetNonNullHandle (nameof (newAttributes));
			var item__handle__ = item!.GetNonNullHandle (nameof (item));
			if (reply is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (reply));
			using var block_reply = Trampolines.SDFSVolumeOperationsAttributesHandler.CreateBlock (reply);
			BlockLiteral *block_ptr_reply = &block_reply;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("setAttributes:onItem:replyHandler:"), newAttributes__handle__, item__handle__, (IntPtr) block_ptr_reply);
			GC.KeepAlive (newAttributes);
			GC.KeepAlive (item);
		}
		[Export ("lookupItemNamed:inDirectory:replyHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void LookupItem (FSFileName name, FSItem directory, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDFSVolumeOperationsLookupItemHandler))]FSVolumeOperationsLookupItemHandler reply)
		{
			var name__handle__ = name!.GetNonNullHandle (nameof (name));
			var directory__handle__ = directory!.GetNonNullHandle (nameof (directory));
			if (reply is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (reply));
			using var block_reply = Trampolines.SDFSVolumeOperationsLookupItemHandler.CreateBlock (reply);
			BlockLiteral *block_ptr_reply = &block_reply;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("lookupItemNamed:inDirectory:replyHandler:"), name__handle__, directory__handle__, (IntPtr) block_ptr_reply);
			GC.KeepAlive (name);
			GC.KeepAlive (directory);
		}
		[Export ("reclaimItem:replyHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void Reclaim (FSItem item, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDFSVolumeOperationsReclaimHandler))]FSVolumeOperationsReclaimHandler reply)
		{
			var item__handle__ = item!.GetNonNullHandle (nameof (item));
			if (reply is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (reply));
			using var block_reply = Trampolines.SDFSVolumeOperationsReclaimHandler.CreateBlock (reply);
			BlockLiteral *block_ptr_reply = &block_reply;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("reclaimItem:replyHandler:"), item__handle__, (IntPtr) block_ptr_reply);
			GC.KeepAlive (item);
		}
		[Export ("readSymbolicLink:replyHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void ReadSymbolicLink (FSItem item, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDFSVolumeOperationsReadSymbolicLinkHandler))]FSVolumeOperationsReadSymbolicLinkHandler reply)
		{
			var item__handle__ = item!.GetNonNullHandle (nameof (item));
			if (reply is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (reply));
			using var block_reply = Trampolines.SDFSVolumeOperationsReadSymbolicLinkHandler.CreateBlock (reply);
			BlockLiteral *block_ptr_reply = &block_reply;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("readSymbolicLink:replyHandler:"), item__handle__, (IntPtr) block_ptr_reply);
			GC.KeepAlive (item);
		}
		[Export ("createItemNamed:type:inDirectory:attributes:replyHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void CreateItem (FSFileName name, FSItemType type, FSItem directory, FSItemSetAttributesRequest newAttributes, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDFSVolumeOperationsCreateItemHandler))]FSVolumeOperationsCreateItemHandler reply)
		{
			var name__handle__ = name!.GetNonNullHandle (nameof (name));
			var directory__handle__ = directory!.GetNonNullHandle (nameof (directory));
			var newAttributes__handle__ = newAttributes!.GetNonNullHandle (nameof (newAttributes));
			if (reply is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (reply));
			using var block_reply = Trampolines.SDFSVolumeOperationsCreateItemHandler.CreateBlock (reply);
			BlockLiteral *block_ptr_reply = &block_reply;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_IntPtr_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("createItemNamed:type:inDirectory:attributes:replyHandler:"), name__handle__, (IntPtr) (long) type, directory__handle__, newAttributes__handle__, (IntPtr) block_ptr_reply);
			GC.KeepAlive (name);
			GC.KeepAlive (directory);
			GC.KeepAlive (newAttributes);
		}
		[Export ("createSymbolicLinkNamed:inDirectory:attributes:linkContents:replyHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void CreateSymbolicLink (FSFileName name, FSItem directory, FSItemSetAttributesRequest newAttributes, FSFileName contents, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDFSVolumeOperationsCreateItemHandler))]FSVolumeOperationsCreateItemHandler reply)
		{
			var name__handle__ = name!.GetNonNullHandle (nameof (name));
			var directory__handle__ = directory!.GetNonNullHandle (nameof (directory));
			var newAttributes__handle__ = newAttributes!.GetNonNullHandle (nameof (newAttributes));
			var contents__handle__ = contents!.GetNonNullHandle (nameof (contents));
			if (reply is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (reply));
			using var block_reply = Trampolines.SDFSVolumeOperationsCreateItemHandler.CreateBlock (reply);
			BlockLiteral *block_ptr_reply = &block_reply;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("createSymbolicLinkNamed:inDirectory:attributes:linkContents:replyHandler:"), name__handle__, directory__handle__, newAttributes__handle__, contents__handle__, (IntPtr) block_ptr_reply);
			GC.KeepAlive (name);
			GC.KeepAlive (directory);
			GC.KeepAlive (newAttributes);
			GC.KeepAlive (contents);
		}
		[Export ("createLinkToItem:named:inDirectory:replyHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void CreateLink (FSItem item, FSFileName name, FSItem directory, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDFSVolumeOperationsCreateLinkHandler))]FSVolumeOperationsCreateLinkHandler reply)
		{
			var item__handle__ = item!.GetNonNullHandle (nameof (item));
			var name__handle__ = name!.GetNonNullHandle (nameof (name));
			var directory__handle__ = directory!.GetNonNullHandle (nameof (directory));
			if (reply is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (reply));
			using var block_reply = Trampolines.SDFSVolumeOperationsCreateLinkHandler.CreateBlock (reply);
			BlockLiteral *block_ptr_reply = &block_reply;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("createLinkToItem:named:inDirectory:replyHandler:"), item__handle__, name__handle__, directory__handle__, (IntPtr) block_ptr_reply);
			GC.KeepAlive (item);
			GC.KeepAlive (name);
			GC.KeepAlive (directory);
		}
		[Export ("removeItem:named:fromDirectory:replyHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void RemoveItem (FSItem item, FSFileName name, FSItem directory, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDFSVolumeOperationsRemoveItemHandler))]FSVolumeOperationsRemoveItemHandler reply)
		{
			var item__handle__ = item!.GetNonNullHandle (nameof (item));
			var name__handle__ = name!.GetNonNullHandle (nameof (name));
			var directory__handle__ = directory!.GetNonNullHandle (nameof (directory));
			if (reply is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (reply));
			using var block_reply = Trampolines.SDFSVolumeOperationsRemoveItemHandler.CreateBlock (reply);
			BlockLiteral *block_ptr_reply = &block_reply;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("removeItem:named:fromDirectory:replyHandler:"), item__handle__, name__handle__, directory__handle__, (IntPtr) block_ptr_reply);
			GC.KeepAlive (item);
			GC.KeepAlive (name);
			GC.KeepAlive (directory);
		}
		[Export ("renameItem:inDirectory:named:toNewName:inDirectory:overItem:replyHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void RenameItem (FSItem item, FSItem sourceDirectory, FSFileName sourceName, FSFileName destinationName, FSItem destinationDirectory, FSItem? overItem, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDFSVolumeOperationsRenameItemHandler))]FSVolumeOperationsRenameItemHandler reply)
		{
			var item__handle__ = item!.GetNonNullHandle (nameof (item));
			var sourceDirectory__handle__ = sourceDirectory!.GetNonNullHandle (nameof (sourceDirectory));
			var sourceName__handle__ = sourceName!.GetNonNullHandle (nameof (sourceName));
			var destinationName__handle__ = destinationName!.GetNonNullHandle (nameof (destinationName));
			var destinationDirectory__handle__ = destinationDirectory!.GetNonNullHandle (nameof (destinationDirectory));
			var overItem__handle__ = overItem.GetHandle ();
			if (reply is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (reply));
			using var block_reply = Trampolines.SDFSVolumeOperationsRenameItemHandler.CreateBlock (reply);
			BlockLiteral *block_ptr_reply = &block_reply;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("renameItem:inDirectory:named:toNewName:inDirectory:overItem:replyHandler:"), item__handle__, sourceDirectory__handle__, sourceName__handle__, destinationName__handle__, destinationDirectory__handle__, overItem__handle__, (IntPtr) block_ptr_reply);
			GC.KeepAlive (item);
			GC.KeepAlive (sourceDirectory);
			GC.KeepAlive (sourceName);
			GC.KeepAlive (destinationName);
			GC.KeepAlive (destinationDirectory);
			GC.KeepAlive (overItem);
		}
		[Export ("enumerateDirectory:startingAtCookie:verifier:providingAttributes:usingPacker:replyHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void EnumerateDirectory (FSItem directory, ulong startingAt, ulong verifier, FSItemGetAttributesRequest? attributes, FSDirectoryEntryPacker packer, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDFSVolumeOperationsEnumerateDirectoryHandler))]FSVolumeOperationsEnumerateDirectoryHandler reply)
		{
			var directory__handle__ = directory!.GetNonNullHandle (nameof (directory));
			var attributes__handle__ = attributes.GetHandle ();
			var packer__handle__ = packer!.GetNonNullHandle (nameof (packer));
			if (reply is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (reply));
			using var block_reply = Trampolines.SDFSVolumeOperationsEnumerateDirectoryHandler.CreateBlock (reply);
			BlockLiteral *block_ptr_reply = &block_reply;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UInt64_UInt64_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("enumerateDirectory:startingAtCookie:verifier:providingAttributes:usingPacker:replyHandler:"), directory__handle__, startingAt, verifier, attributes__handle__, packer__handle__, (IntPtr) block_ptr_reply);
			GC.KeepAlive (directory);
			GC.KeepAlive (attributes);
			GC.KeepAlive (packer);
		}
		[Export ("activateWithOptions:replyHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void Activate (FSTaskOptions options, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDFSVolumeOperationsActivateHandler))]FSVolumeOperationsActivateHandler reply)
		{
			var options__handle__ = options!.GetNonNullHandle (nameof (options));
			if (reply is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (reply));
			using var block_reply = Trampolines.SDFSVolumeOperationsActivateHandler.CreateBlock (reply);
			BlockLiteral *block_ptr_reply = &block_reply;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("activateWithOptions:replyHandler:"), options__handle__, (IntPtr) block_ptr_reply);
			GC.KeepAlive (options);
		}
		[Export ("deactivateWithOptions:replyHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void Deactivate (FSDeactivateOptions options, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDFSVolumeOperationsDeactivateHandler))]FSVolumeOperationsDeactivateHandler reply)
		{
			if (reply is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (reply));
			using var block_reply = Trampolines.SDFSVolumeOperationsDeactivateHandler.CreateBlock (reply);
			BlockLiteral *block_ptr_reply = &block_reply;
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_NativeHandle (this.Handle, Selector.GetHandle ("deactivateWithOptions:replyHandler:"), (IntPtr) (long) options, (IntPtr) block_ptr_reply);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public FSVolumeSupportedCapabilities SupportedVolumeCapabilities {
			[Export ("supportedVolumeCapabilities")]
			get {
				FSVolumeSupportedCapabilities ret;
				ret =  Runtime.GetNSObject<FSVolumeSupportedCapabilities> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("supportedVolumeCapabilities")), false)!;
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public FSStatFSResult VolumeStatistics {
			[Export ("volumeStatistics")]
			get {
				FSStatFSResult ret;
				ret =  Runtime.GetNSObject<FSStatFSResult> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("volumeStatistics")), false)!;
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("macos15.4")]
		public nint MaximumLinkCount {
			[Export ("maximumLinkCount")]
			[SupportedOSPlatform ("macos15.4")]
			get {
				nint ret;
				ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("maximumLinkCount"));
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("macos15.4")]
		public nint MaximumNameLength {
			[Export ("maximumNameLength")]
			[SupportedOSPlatform ("macos15.4")]
			get {
				nint ret;
				ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("maximumNameLength"));
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("macos15.4")]
		public bool RestrictsOwnershipChanges {
			[Export ("restrictsOwnershipChanges")]
			[SupportedOSPlatform ("macos15.4")]
			get {
				byte ret;
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("restrictsOwnershipChanges"));
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("macos15.4")]
		public bool TruncatesLongNames {
			[Export ("truncatesLongNames")]
			[SupportedOSPlatform ("macos15.4")]
			get {
				byte ret;
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("truncatesLongNames"));
				return ret != 0;
			}
		}
	}
}
