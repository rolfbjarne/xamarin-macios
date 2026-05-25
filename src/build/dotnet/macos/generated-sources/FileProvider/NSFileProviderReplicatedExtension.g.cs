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
namespace FileProvider {
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>NSFileProviderReplicatedExtension</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios16.0")]
	[SupportedOSPlatform ("macos")]
	[Advice (@"Implementation must expose selector 'initWithDomain:' with '.ctor (NSFileProviderDomain)'.")]
	[Protocol (Name = "NSFileProviderReplicatedExtension", WrapperType = typeof (NSFileProviderReplicatedExtensionWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "Invalidate", Selector = "invalidate")]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetItem", Selector = "itemForIdentifier:request:completionHandler:", ReturnType = typeof (NSProgress), ParameterType = new Type [] { typeof (string), typeof (NSFileProviderRequest), typeof (global::System.Action<global::FileProvider.INSFileProviderItem, NSError>) }, ParameterByRef = new bool [] { false, false, false }, ParameterBlockProxy = new Type? [] { null, null, typeof (ObjCRuntime.Trampolines.NIDActionArity2V73) })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "CreateItem", Selector = "createItemBasedOnTemplate:fields:contents:options:request:completionHandler:", ReturnType = typeof (NSProgress), ParameterType = new Type [] { typeof (INSFileProviderItem), typeof (NSFileProviderItemFields), typeof (NSUrl), typeof (NSFileProviderCreateItemOptions), typeof (NSFileProviderRequest), typeof (NSFileProviderCreateOrModifyItemCompletionHandler) }, ParameterByRef = new bool [] { false, false, false, false, false, false }, ParameterBlockProxy = new Type? [] { null, null, null, null, null, typeof (ObjCRuntime.Trampolines.NIDNSFileProviderCreateOrModifyItemCompletionHandler) })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "FetchContents", Selector = "fetchContentsForItemWithIdentifier:version:request:completionHandler:", ReturnType = typeof (NSProgress), ParameterType = new Type [] { typeof (string), typeof (NSFileProviderItemVersion), typeof (NSFileProviderRequest), typeof (NSFileProviderFetchContentsCompletionHandler) }, ParameterByRef = new bool [] { false, false, false, false }, ParameterBlockProxy = new Type? [] { null, null, null, typeof (ObjCRuntime.Trampolines.NIDNSFileProviderFetchContentsCompletionHandler) })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "ModifyItem", Selector = "modifyItem:baseVersion:changedFields:contents:options:request:completionHandler:", ReturnType = typeof (NSProgress), ParameterType = new Type [] { typeof (INSFileProviderItem), typeof (NSFileProviderItemVersion), typeof (NSFileProviderItemFields), typeof (NSUrl), typeof (NSFileProviderModifyItemOptions), typeof (NSFileProviderRequest), typeof (NSFileProviderCreateOrModifyItemCompletionHandler) }, ParameterByRef = new bool [] { false, false, false, false, false, false, false }, ParameterBlockProxy = new Type? [] { null, null, null, null, null, null, typeof (ObjCRuntime.Trampolines.NIDNSFileProviderCreateOrModifyItemCompletionHandler) })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "DeleteItem", Selector = "deleteItemWithIdentifier:baseVersion:options:request:completionHandler:", ReturnType = typeof (NSProgress), ParameterType = new Type [] { typeof (string), typeof (NSFileProviderItemVersion), typeof (NSFileProviderDeleteItemOptions), typeof (NSFileProviderRequest), typeof (global::System.Action<NSError>) }, ParameterByRef = new bool [] { false, false, false, false, false }, ParameterBlockProxy = new Type? [] { null, null, null, null, typeof (ObjCRuntime.Trampolines.NIDActionArity1V16) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ImportDidFinish", Selector = "importDidFinishWithCompletionHandler:", ParameterType = new Type [] { typeof (Action) }, ParameterByRef = new bool [] { false }, ParameterBlockProxy = new Type? [] { typeof (ObjCRuntime.Trampolines.NIDAction) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "MaterializedItemsDidChange", Selector = "materializedItemsDidChangeWithCompletionHandler:", ParameterType = new Type [] { typeof (Action) }, ParameterByRef = new bool [] { false }, ParameterBlockProxy = new Type? [] { typeof (ObjCRuntime.Trampolines.NIDAction) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "PendingItemsDidChange", Selector = "pendingItemsDidChangeWithCompletionHandler:", ParameterType = new Type [] { typeof (Action) }, ParameterByRef = new bool [] { false }, ParameterBlockProxy = new Type? [] { typeof (ObjCRuntime.Trampolines.NIDAction) })]
	public partial interface INSFileProviderReplicatedExtension : INativeObject, IDisposable, 
		FileProvider.INSFileProviderEnumerating
	{
		[global::Foundation.RequiredMember]
		[Export ("invalidate")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Invalidate ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _Invalidate (INSFileProviderReplicatedExtension This)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("invalidate"));
			GC.KeepAlive (This);
		}
		[global::Foundation.RequiredMember]
		[Export ("itemForIdentifier:request:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual NSProgress GetItem (string identifier, NSFileProviderRequest request, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V73))]global::System.Action<INSFileProviderItem, NSError> completionHandler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static NSProgress _GetItem (INSFileProviderReplicatedExtension This, string identifier, NSFileProviderRequest request, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V73))]global::System.Action<INSFileProviderItem, NSError> completionHandler)
		{
			if (identifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (identifier));
			var request__handle__ = request!.GetNonNullHandle (nameof (request));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			var nsidentifier = CFString.CreateNative (identifier);
			using var block_completionHandler = Trampolines.SDActionArity2V73.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			NSProgress? ret;
			ret =  Runtime.GetNSObject<NSProgress> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("itemForIdentifier:request:completionHandler:"), nsidentifier, request__handle__, (IntPtr) block_ptr_completionHandler), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (request);
			CFString.ReleaseNative (nsidentifier);
			return ret!;
		}
		[global::Foundation.RequiredMember]
		[Export ("createItemBasedOnTemplate:fields:contents:options:request:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual NSProgress CreateItem (INSFileProviderItem itemTemplate, NSFileProviderItemFields fields, NSUrl? url, NSFileProviderCreateItemOptions options, NSFileProviderRequest request, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDNSFileProviderCreateOrModifyItemCompletionHandler))]NSFileProviderCreateOrModifyItemCompletionHandler completionHandler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static NSProgress _CreateItem (INSFileProviderReplicatedExtension This, INSFileProviderItem itemTemplate, NSFileProviderItemFields fields, NSUrl? url, NSFileProviderCreateItemOptions options, NSFileProviderRequest request, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDNSFileProviderCreateOrModifyItemCompletionHandler))]NSFileProviderCreateOrModifyItemCompletionHandler completionHandler)
		{
			var itemTemplate__handle__ = itemTemplate!.GetNonNullHandle (nameof (itemTemplate));
			var url__handle__ = url.GetHandle ();
			var request__handle__ = request!.GetNonNullHandle (nameof (request));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDNSFileProviderCreateOrModifyItemCompletionHandler.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			NSProgress? ret;
			ret =  Runtime.GetNSObject<NSProgress> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_UIntPtr_NativeHandle_UIntPtr_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("createItemBasedOnTemplate:fields:contents:options:request:completionHandler:"), itemTemplate__handle__, (UIntPtr) (ulong) fields, url__handle__, (UIntPtr) (ulong) options, request__handle__, (IntPtr) block_ptr_completionHandler), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (itemTemplate);
			GC.KeepAlive (url);
			GC.KeepAlive (request);
			return ret!;
		}
		[global::Foundation.RequiredMember]
		[Export ("fetchContentsForItemWithIdentifier:version:request:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual NSProgress FetchContents (string itemIdentifier, NSFileProviderItemVersion? requestedVersion, NSFileProviderRequest request, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDNSFileProviderFetchContentsCompletionHandler))]NSFileProviderFetchContentsCompletionHandler completionHandler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static NSProgress _FetchContents (INSFileProviderReplicatedExtension This, string itemIdentifier, NSFileProviderItemVersion? requestedVersion, NSFileProviderRequest request, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDNSFileProviderFetchContentsCompletionHandler))]NSFileProviderFetchContentsCompletionHandler completionHandler)
		{
			if (itemIdentifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (itemIdentifier));
			var requestedVersion__handle__ = requestedVersion.GetHandle ();
			var request__handle__ = request!.GetNonNullHandle (nameof (request));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			var nsitemIdentifier = CFString.CreateNative (itemIdentifier);
			using var block_completionHandler = Trampolines.SDNSFileProviderFetchContentsCompletionHandler.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			NSProgress? ret;
			ret =  Runtime.GetNSObject<NSProgress> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("fetchContentsForItemWithIdentifier:version:request:completionHandler:"), nsitemIdentifier, requestedVersion__handle__, request__handle__, (IntPtr) block_ptr_completionHandler), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (requestedVersion);
			GC.KeepAlive (request);
			CFString.ReleaseNative (nsitemIdentifier);
			return ret!;
		}
		[global::Foundation.RequiredMember]
		[Export ("modifyItem:baseVersion:changedFields:contents:options:request:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual NSProgress ModifyItem (INSFileProviderItem item, NSFileProviderItemVersion version, NSFileProviderItemFields changedFields, NSUrl? newContents, NSFileProviderModifyItemOptions options, NSFileProviderRequest request, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDNSFileProviderCreateOrModifyItemCompletionHandler))]NSFileProviderCreateOrModifyItemCompletionHandler completionHandler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static NSProgress _ModifyItem (INSFileProviderReplicatedExtension This, INSFileProviderItem item, NSFileProviderItemVersion version, NSFileProviderItemFields changedFields, NSUrl? newContents, NSFileProviderModifyItemOptions options, NSFileProviderRequest request, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDNSFileProviderCreateOrModifyItemCompletionHandler))]NSFileProviderCreateOrModifyItemCompletionHandler completionHandler)
		{
			var item__handle__ = item!.GetNonNullHandle (nameof (item));
			var version__handle__ = version!.GetNonNullHandle (nameof (version));
			var newContents__handle__ = newContents.GetHandle ();
			var request__handle__ = request!.GetNonNullHandle (nameof (request));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDNSFileProviderCreateOrModifyItemCompletionHandler.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			NSProgress? ret;
			ret =  Runtime.GetNSObject<NSProgress> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_UIntPtr_NativeHandle_UIntPtr_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("modifyItem:baseVersion:changedFields:contents:options:request:completionHandler:"), item__handle__, version__handle__, (UIntPtr) (ulong) changedFields, newContents__handle__, (UIntPtr) (ulong) options, request__handle__, (IntPtr) block_ptr_completionHandler), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (item);
			GC.KeepAlive (version);
			GC.KeepAlive (newContents);
			GC.KeepAlive (request);
			return ret!;
		}
		[global::Foundation.RequiredMember]
		[Export ("deleteItemWithIdentifier:baseVersion:options:request:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual NSProgress DeleteItem (string identifier, NSFileProviderItemVersion version, NSFileProviderDeleteItemOptions options, NSFileProviderRequest request, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V16))]global::System.Action<NSError> completionHandler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static NSProgress _DeleteItem (INSFileProviderReplicatedExtension This, string identifier, NSFileProviderItemVersion version, NSFileProviderDeleteItemOptions options, NSFileProviderRequest request, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V16))]global::System.Action<NSError> completionHandler)
		{
			if (identifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (identifier));
			var version__handle__ = version!.GetNonNullHandle (nameof (version));
			var request__handle__ = request!.GetNonNullHandle (nameof (request));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			var nsidentifier = CFString.CreateNative (identifier);
			using var block_completionHandler = Trampolines.SDActionArity1V16.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			NSProgress? ret;
			ret =  Runtime.GetNSObject<NSProgress> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_UIntPtr_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("deleteItemWithIdentifier:baseVersion:options:request:completionHandler:"), nsidentifier, version__handle__, (UIntPtr) (ulong) options, request__handle__, (IntPtr) block_ptr_completionHandler), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (version);
			GC.KeepAlive (request);
			CFString.ReleaseNative (nsidentifier);
			return ret!;
		}
		[global::Foundation.OptionalMember]
		[Export ("importDidFinishWithCompletionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void ImportDidFinish ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action completionHandler)
		{
			_ImportDidFinish (this, completionHandler);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _ImportDidFinish (INSFileProviderReplicatedExtension This, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action completionHandler)
		{
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDAction.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("importDidFinishWithCompletionHandler:"), (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
		}
		[global::Foundation.OptionalMember]
		[Export ("materializedItemsDidChangeWithCompletionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void MaterializedItemsDidChange ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action completionHandler)
		{
			_MaterializedItemsDidChange (this, completionHandler);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _MaterializedItemsDidChange (INSFileProviderReplicatedExtension This, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action completionHandler)
		{
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDAction.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("materializedItemsDidChangeWithCompletionHandler:"), (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
		}
		[global::Foundation.OptionalMember]
		[Export ("pendingItemsDidChangeWithCompletionHandler:")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void PendingItemsDidChange ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action completionHandler)
		{
			_PendingItemsDidChange (this, completionHandler);
		}
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _PendingItemsDidChange (INSFileProviderReplicatedExtension This, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action completionHandler)
		{
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDAction.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("pendingItemsDidChangeWithCompletionHandler:"), (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
		}
		[DynamicDependencyAttribute ("CreateItem(FileProvider.INSFileProviderItem,FileProvider.NSFileProviderItemFields,Foundation.NSUrl,FileProvider.NSFileProviderCreateItemOptions,FileProvider.NSFileProviderRequest,FileProvider.NSFileProviderCreateOrModifyItemCompletionHandler)")]
		[DynamicDependencyAttribute ("DeleteItem(System.String,FileProvider.NSFileProviderItemVersion,FileProvider.NSFileProviderDeleteItemOptions,FileProvider.NSFileProviderRequest,System.Action{Foundation.NSError})")]
		[DynamicDependencyAttribute ("FetchContents(System.String,FileProvider.NSFileProviderItemVersion,FileProvider.NSFileProviderRequest,FileProvider.NSFileProviderFetchContentsCompletionHandler)")]
		[DynamicDependencyAttribute ("GetItem(System.String,FileProvider.NSFileProviderRequest,System.Action{FileProvider.INSFileProviderItem,Foundation.NSError})")]
		[DynamicDependencyAttribute ("ImportDidFinish(System.Action)")]
		[DynamicDependencyAttribute ("Invalidate()")]
		[DynamicDependencyAttribute ("MaterializedItemsDidChange(System.Action)")]
		[DynamicDependencyAttribute ("ModifyItem(FileProvider.INSFileProviderItem,FileProvider.NSFileProviderItemVersion,FileProvider.NSFileProviderItemFields,Foundation.NSUrl,FileProvider.NSFileProviderModifyItemOptions,FileProvider.NSFileProviderRequest,FileProvider.NSFileProviderCreateOrModifyItemCompletionHandler)")]
		[DynamicDependencyAttribute ("PendingItemsDidChange(System.Action)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSFileProviderReplicatedExtensionWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static INSFileProviderReplicatedExtension ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="INSFileProviderReplicatedExtension" /> interface to support all the methods from the NSFileProviderReplicatedExtension protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="INSFileProviderReplicatedExtension" /> interface allow developers to treat instances of the interface as having all the optional methods of the original NSFileProviderReplicatedExtension protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	[Advice (@"Implementation must expose selector 'initWithDomain:' with '.ctor (NSFileProviderDomain)'.")]
	public unsafe static partial class NSFileProviderReplicatedExtension_Extensions {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void ImportDidFinish (this INSFileProviderReplicatedExtension This, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action completionHandler)
		{
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDAction.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("importDidFinishWithCompletionHandler:"), (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void MaterializedItemsDidChange (this INSFileProviderReplicatedExtension This, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action completionHandler)
		{
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDAction.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("materializedItemsDidChangeWithCompletionHandler:"), (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
		}
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void PendingItemsDidChange (this INSFileProviderReplicatedExtension This, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action completionHandler)
		{
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDAction.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("pendingItemsDidChangeWithCompletionHandler:"), (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class NSFileProviderReplicatedExtensionWrapper : BaseWrapper, INSFileProviderReplicatedExtension {
		public NSFileProviderReplicatedExtensionWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSFileProviderReplicatedExtensionWrapper))]
		static NSFileProviderReplicatedExtensionWrapper ()
		{
			GC.KeepAlive (null);
		}
		[Export ("invalidate")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void Invalidate ()
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("invalidate"));
		}
		[Export ("itemForIdentifier:request:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NSProgress GetItem (string identifier, NSFileProviderRequest request, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V73))]global::System.Action<INSFileProviderItem, NSError> completionHandler)
		{
			if (identifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (identifier));
			var request__handle__ = request!.GetNonNullHandle (nameof (request));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			var nsidentifier = CFString.CreateNative (identifier);
			using var block_completionHandler = Trampolines.SDActionArity2V73.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			NSProgress? ret;
			ret =  Runtime.GetNSObject<NSProgress> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("itemForIdentifier:request:completionHandler:"), nsidentifier, request__handle__, (IntPtr) block_ptr_completionHandler), false)!;
			GC.KeepAlive (request);
			CFString.ReleaseNative (nsidentifier);
			return ret!;
		}
		[Export ("createItemBasedOnTemplate:fields:contents:options:request:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NSProgress CreateItem (INSFileProviderItem itemTemplate, NSFileProviderItemFields fields, NSUrl? url, NSFileProviderCreateItemOptions options, NSFileProviderRequest request, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDNSFileProviderCreateOrModifyItemCompletionHandler))]NSFileProviderCreateOrModifyItemCompletionHandler completionHandler)
		{
			var itemTemplate__handle__ = itemTemplate!.GetNonNullHandle (nameof (itemTemplate));
			var url__handle__ = url.GetHandle ();
			var request__handle__ = request!.GetNonNullHandle (nameof (request));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDNSFileProviderCreateOrModifyItemCompletionHandler.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			NSProgress? ret;
			ret =  Runtime.GetNSObject<NSProgress> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_UIntPtr_NativeHandle_UIntPtr_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("createItemBasedOnTemplate:fields:contents:options:request:completionHandler:"), itemTemplate__handle__, (UIntPtr) (ulong) fields, url__handle__, (UIntPtr) (ulong) options, request__handle__, (IntPtr) block_ptr_completionHandler), false)!;
			GC.KeepAlive (itemTemplate);
			GC.KeepAlive (url);
			GC.KeepAlive (request);
			return ret!;
		}
		[Export ("fetchContentsForItemWithIdentifier:version:request:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NSProgress FetchContents (string itemIdentifier, NSFileProviderItemVersion? requestedVersion, NSFileProviderRequest request, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDNSFileProviderFetchContentsCompletionHandler))]NSFileProviderFetchContentsCompletionHandler completionHandler)
		{
			if (itemIdentifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (itemIdentifier));
			var requestedVersion__handle__ = requestedVersion.GetHandle ();
			var request__handle__ = request!.GetNonNullHandle (nameof (request));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			var nsitemIdentifier = CFString.CreateNative (itemIdentifier);
			using var block_completionHandler = Trampolines.SDNSFileProviderFetchContentsCompletionHandler.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			NSProgress? ret;
			ret =  Runtime.GetNSObject<NSProgress> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("fetchContentsForItemWithIdentifier:version:request:completionHandler:"), nsitemIdentifier, requestedVersion__handle__, request__handle__, (IntPtr) block_ptr_completionHandler), false)!;
			GC.KeepAlive (requestedVersion);
			GC.KeepAlive (request);
			CFString.ReleaseNative (nsitemIdentifier);
			return ret!;
		}
		[Export ("modifyItem:baseVersion:changedFields:contents:options:request:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NSProgress ModifyItem (INSFileProviderItem item, NSFileProviderItemVersion version, NSFileProviderItemFields changedFields, NSUrl? newContents, NSFileProviderModifyItemOptions options, NSFileProviderRequest request, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDNSFileProviderCreateOrModifyItemCompletionHandler))]NSFileProviderCreateOrModifyItemCompletionHandler completionHandler)
		{
			var item__handle__ = item!.GetNonNullHandle (nameof (item));
			var version__handle__ = version!.GetNonNullHandle (nameof (version));
			var newContents__handle__ = newContents.GetHandle ();
			var request__handle__ = request!.GetNonNullHandle (nameof (request));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDNSFileProviderCreateOrModifyItemCompletionHandler.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			NSProgress? ret;
			ret =  Runtime.GetNSObject<NSProgress> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_UIntPtr_NativeHandle_UIntPtr_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("modifyItem:baseVersion:changedFields:contents:options:request:completionHandler:"), item__handle__, version__handle__, (UIntPtr) (ulong) changedFields, newContents__handle__, (UIntPtr) (ulong) options, request__handle__, (IntPtr) block_ptr_completionHandler), false)!;
			GC.KeepAlive (item);
			GC.KeepAlive (version);
			GC.KeepAlive (newContents);
			GC.KeepAlive (request);
			return ret!;
		}
		[Export ("deleteItemWithIdentifier:baseVersion:options:request:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NSProgress DeleteItem (string identifier, NSFileProviderItemVersion version, NSFileProviderDeleteItemOptions options, NSFileProviderRequest request, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V16))]global::System.Action<NSError> completionHandler)
		{
			if (identifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (identifier));
			var version__handle__ = version!.GetNonNullHandle (nameof (version));
			var request__handle__ = request!.GetNonNullHandle (nameof (request));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			var nsidentifier = CFString.CreateNative (identifier);
			using var block_completionHandler = Trampolines.SDActionArity1V16.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			NSProgress? ret;
			ret =  Runtime.GetNSObject<NSProgress> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_UIntPtr_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("deleteItemWithIdentifier:baseVersion:options:request:completionHandler:"), nsidentifier, version__handle__, (UIntPtr) (ulong) options, request__handle__, (IntPtr) block_ptr_completionHandler), false)!;
			GC.KeepAlive (version);
			GC.KeepAlive (request);
			CFString.ReleaseNative (nsidentifier);
			return ret!;
		}
		[Export ("enumeratorForContainerItemIdentifier:request:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe INSFileProviderEnumerator? GetEnumerator (string containerItemIdentifier, NSFileProviderRequest request, out NSError? error)
		{
			if (containerItemIdentifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (containerItemIdentifier));
			var request__handle__ = request!.GetNonNullHandle (nameof (request));
			NativeHandle errorValue = IntPtr.Zero;
			var nscontainerItemIdentifier = CFString.CreateNative (containerItemIdentifier);
			INSFileProviderEnumerator? ret;
			ret =  Runtime.GetINativeObject<INSFileProviderEnumerator> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_ref_NativeHandle (this.Handle, Selector.GetHandle ("enumeratorForContainerItemIdentifier:request:error:"), nscontainerItemIdentifier, request__handle__, &errorValue), false)!;
			GC.KeepAlive (request);
			CFString.ReleaseNative (nscontainerItemIdentifier);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
	}
}
