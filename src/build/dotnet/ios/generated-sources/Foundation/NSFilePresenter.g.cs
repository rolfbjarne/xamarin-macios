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
using UIKit;
using GLKit;
using Metal;
using CoreML;
using MapKit;
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Contacts;
using Security;
using Messages;
using AudioUnit;
using CoreVideo;
using CoreMedia;
using QuickLook;
using CoreImage;
using SpriteKit;
using Foundation;
using CoreMotion;
using ObjCRuntime;
using AddressBook;
using MediaPlayer;
using GameplayKit;
using CoreGraphics;
using CoreLocation;
using AVFoundation;
using NewsstandKit;
using FileProvider;
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;
using MetalPerformanceShadersGraph;
#nullable enable
namespace Foundation {
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>NSFilePresenter</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[Protocol (Name = "NSFilePresenter", WrapperType = typeof (NSFilePresenterWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "RelinquishPresentedItemToReader", Selector = "relinquishPresentedItemToReader:", ParameterType = new Type [] { typeof (NSFilePresenterReacquirer) }, ParameterByRef = new bool [] { false }, ParameterBlockProxy = new Type? [] { typeof (ObjCRuntime.Trampolines.NIDNSFilePresenterReacquirer) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "RelinquishPresentedItemToWriter", Selector = "relinquishPresentedItemToWriter:", ParameterType = new Type [] { typeof (NSFilePresenterReacquirer) }, ParameterByRef = new bool [] { false }, ParameterBlockProxy = new Type? [] { typeof (ObjCRuntime.Trampolines.NIDNSFilePresenterReacquirer) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "SavePresentedItemChanges", Selector = "savePresentedItemChangesWithCompletionHandler:", ParameterType = new Type [] { typeof (global::System.Action<NSError>) }, ParameterByRef = new bool [] { false }, ParameterBlockProxy = new Type? [] { typeof (ObjCRuntime.Trampolines.NIDActionArity1V0) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "AccommodatePresentedItemDeletion", Selector = "accommodatePresentedItemDeletionWithCompletionHandler:", ParameterType = new Type [] { typeof (global::System.Action<NSError>) }, ParameterByRef = new bool [] { false }, ParameterBlockProxy = new Type? [] { typeof (ObjCRuntime.Trampolines.NIDActionArity1V0) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "AccommodatePresentedItemEviction", Selector = "accommodatePresentedItemEvictionWithCompletionHandler:", ParameterType = new Type [] { typeof (global::System.Action<NSError>) }, ParameterByRef = new bool [] { false }, ParameterBlockProxy = new Type? [] { typeof (ObjCRuntime.Trampolines.NIDActionArity1V0) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "PresentedItemMoved", Selector = "presentedItemDidMoveToURL:", ParameterType = new Type [] { typeof (NSUrl) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "PresentedItemChanged", Selector = "presentedItemDidChange")]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "PresentedItemGainedVersion", Selector = "presentedItemDidGainVersion:", ParameterType = new Type [] { typeof (NSFileVersion) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "PresentedItemLostVersion", Selector = "presentedItemDidLoseVersion:", ParameterType = new Type [] { typeof (NSFileVersion) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "PresentedItemResolveConflictVersion", Selector = "presentedItemDidResolveConflictVersion:", ParameterType = new Type [] { typeof (NSFileVersion) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "AccommodatePresentedSubitemDeletion", Selector = "accommodatePresentedSubitemDeletionAtURL:completionHandler:", ParameterType = new Type [] { typeof (NSUrl), typeof (global::System.Action<NSError>) }, ParameterByRef = new bool [] { false, false }, ParameterBlockProxy = new Type? [] { null, typeof (ObjCRuntime.Trampolines.NIDActionArity1V0) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "PresentedSubitemAppeared", Selector = "presentedSubitemDidAppearAtURL:", ParameterType = new Type [] { typeof (NSUrl) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "PresentedSubitemMoved", Selector = "presentedSubitemAtURL:didMoveToURL:", ParameterType = new Type [] { typeof (NSUrl), typeof (NSUrl) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "PresentedSubitemChanged", Selector = "presentedSubitemDidChangeAtURL:", ParameterType = new Type [] { typeof (NSUrl) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "PresentedSubitemGainedVersion", Selector = "presentedSubitemAtURL:didGainVersion:", ParameterType = new Type [] { typeof (NSUrl), typeof (NSFileVersion) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "PresentedSubitemLostVersion", Selector = "presentedSubitemAtURL:didLoseVersion:", ParameterType = new Type [] { typeof (NSUrl), typeof (NSFileVersion) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "PresentedSubitemResolvedConflictVersion", Selector = "presentedSubitemAtURL:didResolveConflictVersion:", ParameterType = new Type [] { typeof (NSUrl), typeof (NSFileVersion) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "PresentedItemChangedUbiquityAttributes", Selector = "presentedItemDidChangeUbiquityAttributes:", ParameterType = new Type [] { typeof (global::Foundation.NSSet<NSString>) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "PresentedItemUrl", Selector = "presentedItemURL", PropertyType = typeof (NSUrl), GetterSelector = "presentedItemURL", ArgumentSemantic = ArgumentSemantic.Retain)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "PresentedItemOperationQueue", Selector = "presentedItemOperationQueue", PropertyType = typeof (NSOperationQueue), GetterSelector = "presentedItemOperationQueue", ArgumentSemantic = ArgumentSemantic.Retain)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "PresentedItemObservedUbiquityAttributes", Selector = "observedPresentedItemUbiquityAttributes", PropertyType = typeof (global::Foundation.NSSet<NSString>), GetterSelector = "observedPresentedItemUbiquityAttributes", ArgumentSemantic = ArgumentSemantic.Retain)]
	public partial interface INSFilePresenter : INativeObject, IDisposable
	{
		/// <param name="readerAction">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("relinquishPresentedItemToReader:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void RelinquishPresentedItemToReader ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDNSFilePresenterReacquirer))]NSFilePresenterReacquirer readerAction)
		{
			_RelinquishPresentedItemToReader (this, readerAction);
		}
		/// <param name="readerAction">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _RelinquishPresentedItemToReader (INSFilePresenter This, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDNSFilePresenterReacquirer))]NSFilePresenterReacquirer readerAction)
		{
			if (readerAction is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (readerAction));
			using var block_readerAction = Trampolines.SDNSFilePresenterReacquirer.CreateBlock (readerAction);
			BlockLiteral *block_ptr_readerAction = &block_readerAction;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("relinquishPresentedItemToReader:"), (IntPtr) block_ptr_readerAction);
			GC.KeepAlive (This);
		}
		/// <param name="writerAction">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("relinquishPresentedItemToWriter:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void RelinquishPresentedItemToWriter ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDNSFilePresenterReacquirer))]NSFilePresenterReacquirer writerAction)
		{
			_RelinquishPresentedItemToWriter (this, writerAction);
		}
		/// <param name="writerAction">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _RelinquishPresentedItemToWriter (INSFilePresenter This, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDNSFilePresenterReacquirer))]NSFilePresenterReacquirer writerAction)
		{
			if (writerAction is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (writerAction));
			using var block_writerAction = Trampolines.SDNSFilePresenterReacquirer.CreateBlock (writerAction);
			BlockLiteral *block_ptr_writerAction = &block_writerAction;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("relinquishPresentedItemToWriter:"), (IntPtr) block_ptr_writerAction);
			GC.KeepAlive (This);
		}
		/// <param name="completionHandler">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("savePresentedItemChangesWithCompletionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void SavePresentedItemChanges ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V0))]global::System.Action<NSError> completionHandler)
		{
			_SavePresentedItemChanges (this, completionHandler);
		}
		/// <param name="completionHandler">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _SavePresentedItemChanges (INSFilePresenter This, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V0))]global::System.Action<NSError> completionHandler)
		{
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity1V0.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("savePresentedItemChangesWithCompletionHandler:"), (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
		}
		/// <param name="completionHandler">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("accommodatePresentedItemDeletionWithCompletionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void AccommodatePresentedItemDeletion ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V0))]global::System.Action<NSError> completionHandler)
		{
			_AccommodatePresentedItemDeletion (this, completionHandler);
		}
		/// <param name="completionHandler">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _AccommodatePresentedItemDeletion (INSFilePresenter This, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V0))]global::System.Action<NSError> completionHandler)
		{
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity1V0.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("accommodatePresentedItemDeletionWithCompletionHandler:"), (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
		}
		[global::Foundation.OptionalMember]
		[Export ("accommodatePresentedItemEvictionWithCompletionHandler:")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos14.4")]
		[SupportedOSPlatform ("ios17.4")]
		[SupportedOSPlatform ("maccatalyst17.4")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void AccommodatePresentedItemEviction ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V0))]global::System.Action<NSError> completionHandler)
		{
			_AccommodatePresentedItemEviction (this, completionHandler);
		}
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos14.4")]
		[SupportedOSPlatform ("ios17.4")]
		[SupportedOSPlatform ("maccatalyst17.4")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _AccommodatePresentedItemEviction (INSFilePresenter This, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V0))]global::System.Action<NSError> completionHandler)
		{
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity1V0.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("accommodatePresentedItemEvictionWithCompletionHandler:"), (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
		}
		/// <param name="newURL">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("presentedItemDidMoveToURL:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PresentedItemMoved (NSUrl newURL)
		{
			_PresentedItemMoved (this, newURL);
		}
		/// <param name="newURL">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _PresentedItemMoved (INSFilePresenter This, NSUrl newURL)
		{
			var newURL__handle__ = newURL!.GetNonNullHandle (nameof (newURL));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("presentedItemDidMoveToURL:"), newURL__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (newURL);
		}
		/// <summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("presentedItemDidChange")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PresentedItemChanged ()
		{
			_PresentedItemChanged (this);
		}
		/// <summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _PresentedItemChanged (INSFilePresenter This)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("presentedItemDidChange"));
			GC.KeepAlive (This);
		}
		/// <param name="version">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("presentedItemDidGainVersion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PresentedItemGainedVersion (NSFileVersion version)
		{
			_PresentedItemGainedVersion (this, version);
		}
		/// <param name="version">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _PresentedItemGainedVersion (INSFilePresenter This, NSFileVersion version)
		{
			var version__handle__ = version!.GetNonNullHandle (nameof (version));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("presentedItemDidGainVersion:"), version__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (version);
		}
		/// <param name="version">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("presentedItemDidLoseVersion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PresentedItemLostVersion (NSFileVersion version)
		{
			_PresentedItemLostVersion (this, version);
		}
		/// <param name="version">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _PresentedItemLostVersion (INSFilePresenter This, NSFileVersion version)
		{
			var version__handle__ = version!.GetNonNullHandle (nameof (version));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("presentedItemDidLoseVersion:"), version__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (version);
		}
		/// <param name="version">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("presentedItemDidResolveConflictVersion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PresentedItemResolveConflictVersion (NSFileVersion version)
		{
			_PresentedItemResolveConflictVersion (this, version);
		}
		/// <param name="version">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _PresentedItemResolveConflictVersion (INSFilePresenter This, NSFileVersion version)
		{
			var version__handle__ = version!.GetNonNullHandle (nameof (version));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("presentedItemDidResolveConflictVersion:"), version__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (version);
		}
		/// <param name="url">To be added.</param><param name="completionHandler">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("accommodatePresentedSubitemDeletionAtURL:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void AccommodatePresentedSubitemDeletion (NSUrl url, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V0))]global::System.Action<NSError> completionHandler)
		{
			_AccommodatePresentedSubitemDeletion (this, url, completionHandler);
		}
		/// <param name="url">To be added.</param><param name="completionHandler">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _AccommodatePresentedSubitemDeletion (INSFilePresenter This, NSUrl url, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V0))]global::System.Action<NSError> completionHandler)
		{
			var url__handle__ = url!.GetNonNullHandle (nameof (url));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity1V0.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("accommodatePresentedSubitemDeletionAtURL:completionHandler:"), url__handle__, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
			GC.KeepAlive (url);
		}
		/// <param name="atUrl">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("presentedSubitemDidAppearAtURL:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PresentedSubitemAppeared (NSUrl atUrl)
		{
			_PresentedSubitemAppeared (this, atUrl);
		}
		/// <param name="atUrl">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _PresentedSubitemAppeared (INSFilePresenter This, NSUrl atUrl)
		{
			var atUrl__handle__ = atUrl!.GetNonNullHandle (nameof (atUrl));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("presentedSubitemDidAppearAtURL:"), atUrl__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (atUrl);
		}
		/// <param name="oldURL">To be added.</param><param name="newURL">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("presentedSubitemAtURL:didMoveToURL:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PresentedSubitemMoved (NSUrl oldURL, NSUrl newURL)
		{
			_PresentedSubitemMoved (this, oldURL, newURL);
		}
		/// <param name="oldURL">To be added.</param><param name="newURL">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _PresentedSubitemMoved (INSFilePresenter This, NSUrl oldURL, NSUrl newURL)
		{
			var oldURL__handle__ = oldURL!.GetNonNullHandle (nameof (oldURL));
			var newURL__handle__ = newURL!.GetNonNullHandle (nameof (newURL));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("presentedSubitemAtURL:didMoveToURL:"), oldURL__handle__, newURL__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (oldURL);
			GC.KeepAlive (newURL);
		}
		/// <param name="url">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("presentedSubitemDidChangeAtURL:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PresentedSubitemChanged (NSUrl url)
		{
			_PresentedSubitemChanged (this, url);
		}
		/// <param name="url">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _PresentedSubitemChanged (INSFilePresenter This, NSUrl url)
		{
			var url__handle__ = url!.GetNonNullHandle (nameof (url));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("presentedSubitemDidChangeAtURL:"), url__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (url);
		}
		/// <param name="url">To be added.</param><param name="version">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("presentedSubitemAtURL:didGainVersion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PresentedSubitemGainedVersion (NSUrl url, NSFileVersion version)
		{
			_PresentedSubitemGainedVersion (this, url, version);
		}
		/// <param name="url">To be added.</param><param name="version">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _PresentedSubitemGainedVersion (INSFilePresenter This, NSUrl url, NSFileVersion version)
		{
			var url__handle__ = url!.GetNonNullHandle (nameof (url));
			var version__handle__ = version!.GetNonNullHandle (nameof (version));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("presentedSubitemAtURL:didGainVersion:"), url__handle__, version__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (url);
			GC.KeepAlive (version);
		}
		/// <param name="url">To be added.</param><param name="version">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("presentedSubitemAtURL:didLoseVersion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PresentedSubitemLostVersion (NSUrl url, NSFileVersion version)
		{
			_PresentedSubitemLostVersion (this, url, version);
		}
		/// <param name="url">To be added.</param><param name="version">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _PresentedSubitemLostVersion (INSFilePresenter This, NSUrl url, NSFileVersion version)
		{
			var url__handle__ = url!.GetNonNullHandle (nameof (url));
			var version__handle__ = version!.GetNonNullHandle (nameof (version));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("presentedSubitemAtURL:didLoseVersion:"), url__handle__, version__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (url);
			GC.KeepAlive (version);
		}
		/// <param name="url">To be added.</param><param name="version">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("presentedSubitemAtURL:didResolveConflictVersion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PresentedSubitemResolvedConflictVersion (NSUrl url, NSFileVersion version)
		{
			_PresentedSubitemResolvedConflictVersion (this, url, version);
		}
		/// <param name="url">To be added.</param><param name="version">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _PresentedSubitemResolvedConflictVersion (INSFilePresenter This, NSUrl url, NSFileVersion version)
		{
			var url__handle__ = url!.GetNonNullHandle (nameof (url));
			var version__handle__ = version!.GetNonNullHandle (nameof (version));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("presentedSubitemAtURL:didResolveConflictVersion:"), url__handle__, version__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (url);
			GC.KeepAlive (version);
		}
		/// <param name="attributes">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("presentedItemDidChangeUbiquityAttributes:")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PresentedItemChangedUbiquityAttributes (NSSet<NSString> attributes)
		{
			_PresentedItemChangedUbiquityAttributes (this, attributes);
		}
		/// <param name="attributes">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _PresentedItemChangedUbiquityAttributes (INSFilePresenter This, NSSet<NSString> attributes)
		{
			var attributes__handle__ = attributes!.GetNonNullHandle (nameof (attributes));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("presentedItemDidChangeUbiquityAttributes:"), attributes__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (attributes);
		}
		[DynamicDependencyAttribute ("AccommodatePresentedItemDeletion(System.Action{Foundation.NSError})")]
		[DynamicDependencyAttribute ("AccommodatePresentedItemEviction(System.Action{Foundation.NSError})")]
		[DynamicDependencyAttribute ("AccommodatePresentedSubitemDeletion(Foundation.NSUrl,System.Action{Foundation.NSError})")]
		[DynamicDependencyAttribute ("PresentedItemChanged()")]
		[DynamicDependencyAttribute ("PresentedItemChangedUbiquityAttributes(Foundation.NSSet{Foundation.NSString})")]
		[DynamicDependencyAttribute ("PresentedItemGainedVersion(Foundation.NSFileVersion)")]
		[DynamicDependencyAttribute ("PresentedItemLostVersion(Foundation.NSFileVersion)")]
		[DynamicDependencyAttribute ("PresentedItemMoved(Foundation.NSUrl)")]
		[DynamicDependencyAttribute ("PresentedItemObservedUbiquityAttributes")]
		[DynamicDependencyAttribute ("PresentedItemOperationQueue")]
		[DynamicDependencyAttribute ("PresentedItemResolveConflictVersion(Foundation.NSFileVersion)")]
		[DynamicDependencyAttribute ("PresentedItemUrl")]
		[DynamicDependencyAttribute ("PresentedSubitemAppeared(Foundation.NSUrl)")]
		[DynamicDependencyAttribute ("PresentedSubitemChanged(Foundation.NSUrl)")]
		[DynamicDependencyAttribute ("PresentedSubitemGainedVersion(Foundation.NSUrl,Foundation.NSFileVersion)")]
		[DynamicDependencyAttribute ("PresentedSubitemLostVersion(Foundation.NSUrl,Foundation.NSFileVersion)")]
		[DynamicDependencyAttribute ("PresentedSubitemMoved(Foundation.NSUrl,Foundation.NSUrl)")]
		[DynamicDependencyAttribute ("PresentedSubitemResolvedConflictVersion(Foundation.NSUrl,Foundation.NSFileVersion)")]
		[DynamicDependencyAttribute ("RelinquishPresentedItemToReader(Foundation.NSFilePresenterReacquirer)")]
		[DynamicDependencyAttribute ("RelinquishPresentedItemToWriter(Foundation.NSFilePresenterReacquirer)")]
		[DynamicDependencyAttribute ("SavePresentedItemChanges(System.Action{Foundation.NSError})")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSFilePresenterWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static INSFilePresenter ()
		{
			GC.KeepAlive (null);
		}
		/// <summary>Gets URL of presented item.</summary><value></value><remarks><para></para><para tool="threads">This can be used from a background thread.</para></remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual NSUrl? PresentedItemUrl {
			[Export ("presentedItemURL", ArgumentSemantic.Retain)]
			get {
				return _GetPresentedItemUrl (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSUrl _GetPresentedItemUrl (INSFilePresenter This)
		{
			NSUrl ret;
			ret =  Runtime.GetNSObject<NSUrl> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("presentedItemURL")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		/// <summary>Gets the <see cref="T:Foundation.NSOperationQueue" /> on which presenter-related methods are executed.</summary><value>The <see cref="T:Foundation.NSOperationQueue" /> on which methods are executed.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual NSOperationQueue PresentedItemOperationQueue {
			[Export ("presentedItemOperationQueue", ArgumentSemantic.Retain)]
			get {
				return _GetPresentedItemOperationQueue (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSOperationQueue _GetPresentedItemOperationQueue (INSFilePresenter This)
		{
			NSOperationQueue ret;
			ret =  Runtime.GetNSObject<NSOperationQueue> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("presentedItemOperationQueue")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		/// <summary>Gets the set of ubiquity attributes that will generate notifications if they are modified.</summary><value>To be added.</value><remarks><para>(More documentation for this node is coming)</para><para tool="threads">This can be used from a background thread.</para></remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[global::Foundation.OptionalMember]
		public virtual NSSet<NSString> PresentedItemObservedUbiquityAttributes {
			[Export ("observedPresentedItemUbiquityAttributes", ArgumentSemantic.Retain)]
			get {
				return _GetPresentedItemObservedUbiquityAttributes (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSSet<NSString> _GetPresentedItemObservedUbiquityAttributes (INSFilePresenter This)
		{
			NSSet<NSString> ret;
			ret =  Runtime.GetNSObject<NSSet<NSString>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("observedPresentedItemUbiquityAttributes")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="INSFilePresenter" /> interface to support all the methods from the NSFilePresenter protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="INSFilePresenter" /> interface allow developers to treat instances of the interface as having all the optional methods of the original NSFilePresenter protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class NSFilePresenter_Extensions {
		/// <param name="readerAction">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void RelinquishPresentedItemToReader (this INSFilePresenter This, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDNSFilePresenterReacquirer))]NSFilePresenterReacquirer readerAction)
		{
			if (readerAction is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (readerAction));
			using var block_readerAction = Trampolines.SDNSFilePresenterReacquirer.CreateBlock (readerAction);
			BlockLiteral *block_ptr_readerAction = &block_readerAction;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("relinquishPresentedItemToReader:"), (IntPtr) block_ptr_readerAction);
			GC.KeepAlive (This);
		}
		/// <param name="writerAction">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void RelinquishPresentedItemToWriter (this INSFilePresenter This, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDNSFilePresenterReacquirer))]NSFilePresenterReacquirer writerAction)
		{
			if (writerAction is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (writerAction));
			using var block_writerAction = Trampolines.SDNSFilePresenterReacquirer.CreateBlock (writerAction);
			BlockLiteral *block_ptr_writerAction = &block_writerAction;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("relinquishPresentedItemToWriter:"), (IntPtr) block_ptr_writerAction);
			GC.KeepAlive (This);
		}
		/// <param name="completionHandler">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void SavePresentedItemChanges (this INSFilePresenter This, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V0))]global::System.Action<NSError> completionHandler)
		{
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity1V0.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("savePresentedItemChangesWithCompletionHandler:"), (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
		}
		/// <param name="completionHandler">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void AccommodatePresentedItemDeletion (this INSFilePresenter This, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V0))]global::System.Action<NSError> completionHandler)
		{
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity1V0.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("accommodatePresentedItemDeletionWithCompletionHandler:"), (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
		}
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos14.4")]
		[SupportedOSPlatform ("ios17.4")]
		[SupportedOSPlatform ("maccatalyst17.4")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void AccommodatePresentedItemEviction (this INSFilePresenter This, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V0))]global::System.Action<NSError> completionHandler)
		{
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity1V0.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("accommodatePresentedItemEvictionWithCompletionHandler:"), (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
		}
		/// <param name="newURL">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void PresentedItemMoved (this INSFilePresenter This, NSUrl newURL)
		{
			var newURL__handle__ = newURL!.GetNonNullHandle (nameof (newURL));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("presentedItemDidMoveToURL:"), newURL__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (newURL);
		}
		/// <summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void PresentedItemChanged (this INSFilePresenter This)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("presentedItemDidChange"));
			GC.KeepAlive (This);
		}
		/// <param name="version">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void PresentedItemGainedVersion (this INSFilePresenter This, NSFileVersion version)
		{
			var version__handle__ = version!.GetNonNullHandle (nameof (version));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("presentedItemDidGainVersion:"), version__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (version);
		}
		/// <param name="version">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void PresentedItemLostVersion (this INSFilePresenter This, NSFileVersion version)
		{
			var version__handle__ = version!.GetNonNullHandle (nameof (version));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("presentedItemDidLoseVersion:"), version__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (version);
		}
		/// <param name="version">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void PresentedItemResolveConflictVersion (this INSFilePresenter This, NSFileVersion version)
		{
			var version__handle__ = version!.GetNonNullHandle (nameof (version));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("presentedItemDidResolveConflictVersion:"), version__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (version);
		}
		/// <param name="url">To be added.</param><param name="completionHandler">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void AccommodatePresentedSubitemDeletion (this INSFilePresenter This, NSUrl url, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V0))]global::System.Action<NSError> completionHandler)
		{
			var url__handle__ = url!.GetNonNullHandle (nameof (url));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity1V0.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("accommodatePresentedSubitemDeletionAtURL:completionHandler:"), url__handle__, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
			GC.KeepAlive (url);
		}
		/// <param name="atUrl">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void PresentedSubitemAppeared (this INSFilePresenter This, NSUrl atUrl)
		{
			var atUrl__handle__ = atUrl!.GetNonNullHandle (nameof (atUrl));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("presentedSubitemDidAppearAtURL:"), atUrl__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (atUrl);
		}
		/// <param name="oldURL">To be added.</param><param name="newURL">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void PresentedSubitemMoved (this INSFilePresenter This, NSUrl oldURL, NSUrl newURL)
		{
			var oldURL__handle__ = oldURL!.GetNonNullHandle (nameof (oldURL));
			var newURL__handle__ = newURL!.GetNonNullHandle (nameof (newURL));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("presentedSubitemAtURL:didMoveToURL:"), oldURL__handle__, newURL__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (oldURL);
			GC.KeepAlive (newURL);
		}
		/// <param name="url">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void PresentedSubitemChanged (this INSFilePresenter This, NSUrl url)
		{
			var url__handle__ = url!.GetNonNullHandle (nameof (url));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("presentedSubitemDidChangeAtURL:"), url__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (url);
		}
		/// <param name="url">To be added.</param><param name="version">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void PresentedSubitemGainedVersion (this INSFilePresenter This, NSUrl url, NSFileVersion version)
		{
			var url__handle__ = url!.GetNonNullHandle (nameof (url));
			var version__handle__ = version!.GetNonNullHandle (nameof (version));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("presentedSubitemAtURL:didGainVersion:"), url__handle__, version__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (url);
			GC.KeepAlive (version);
		}
		/// <param name="url">To be added.</param><param name="version">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void PresentedSubitemLostVersion (this INSFilePresenter This, NSUrl url, NSFileVersion version)
		{
			var url__handle__ = url!.GetNonNullHandle (nameof (url));
			var version__handle__ = version!.GetNonNullHandle (nameof (version));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("presentedSubitemAtURL:didLoseVersion:"), url__handle__, version__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (url);
			GC.KeepAlive (version);
		}
		/// <param name="url">To be added.</param><param name="version">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void PresentedSubitemResolvedConflictVersion (this INSFilePresenter This, NSUrl url, NSFileVersion version)
		{
			var url__handle__ = url!.GetNonNullHandle (nameof (url));
			var version__handle__ = version!.GetNonNullHandle (nameof (version));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("presentedSubitemAtURL:didResolveConflictVersion:"), url__handle__, version__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (url);
			GC.KeepAlive (version);
		}
		/// <param name="attributes">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void PresentedItemChangedUbiquityAttributes (this INSFilePresenter This, NSSet<NSString> attributes)
		{
			var attributes__handle__ = attributes!.GetNonNullHandle (nameof (attributes));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("presentedItemDidChangeUbiquityAttributes:"), attributes__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (attributes);
		}
		/// <summary>Gets the set of ubiquity attributes that will generate notifications if they are modified.</summary><value>To be added.</value><remarks><para>(More documentation for this node is coming)</para><para tool="threads">This can be used from a background thread.</para></remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSSet<NSString> GetPresentedItemObservedUbiquityAttributes (this INSFilePresenter This)
		{
			NSSet<NSString> ret;
			ret =  Runtime.GetNSObject<NSSet<NSString>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("observedPresentedItemUbiquityAttributes")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class NSFilePresenterWrapper : BaseWrapper, INSFilePresenter {
		public NSFilePresenterWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSFilePresenterWrapper))]
		static NSFilePresenterWrapper ()
		{
			GC.KeepAlive (null);
		}
		/// <summary>Gets URL of presented item.</summary><value></value><remarks><para></para><para tool="threads">This can be used from a background thread.</para></remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSUrl? PresentedItemUrl {
			[Export ("presentedItemURL", ArgumentSemantic.Retain)]
			get {
				NSUrl ret;
				ret =  Runtime.GetNSObject<NSUrl> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("presentedItemURL")), false)!;
				return ret;
			}
		}
		/// <summary>Gets the <see cref="T:Foundation.NSOperationQueue" /> on which presenter-related methods are executed.</summary><value>The <see cref="T:Foundation.NSOperationQueue" /> on which methods are executed.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSOperationQueue PresentedItemOperationQueue {
			[Export ("presentedItemOperationQueue", ArgumentSemantic.Retain)]
			get {
				NSOperationQueue ret;
				ret =  Runtime.GetNSObject<NSOperationQueue> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("presentedItemOperationQueue")), false)!;
				return ret;
			}
		}
	}
}
namespace Foundation {
	/// <summary>
	///   <para>This is a class that implements the interface <see cref="INSFilePresenter" /> (for the protocol <c>NSFilePresenter</c>).</para>
	///   <para>Subclass this class to easily create a type that implements the protocol.</para>
	///   <para>An alternative is to create a subclass of <see cref="NSObject" /> and then implemented the interface <see cref="INSFilePresenter" />.</para>
	/// </summary>
	[Protocol()]
	[Register("Microsoft_iOS__Foundation_NSFilePresenter", false)]
	[Model]
	public unsafe abstract partial class NSFilePresenter : NSObject, INSFilePresenter {
		/// <summary>Creates a new <see cref="NSFilePresenter" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected NSFilePresenter () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = false;
			unsafe {
			var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
			InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			GC.KeepAlive (this);
			}
		}

		/// <summary>Constructor to call on derived classes to skip initialization and merely allocate the object.</summary>
		/// <param name="t">Unused sentinel value, pass NSObjectFlag.Empty.</param>
		/// <remarks>
		///     <para>
		///         This constructor should be called by derived classes when they completely construct the object in managed code and merely want the runtime to allocate and initialize the <see cref="Foundation.NSObject" />.
		///         This is required to implement the two-step initialization process that Objective-C uses, the first step is to perform the object allocation, the second step is to initialize the object.
		///         When developers invoke this constructor, they take advantage of a direct path that goes all the way up to <see cref="Foundation.NSObject" /> to merely allocate the object's memory and bind the Objective-C and C# objects together.
		///         The actual initialization of the object is up to the developer.
		///     </para>
		///     <para>
		///         This constructor is typically used by the binding generator to allocate the object, but prevent the actual initialization to take place.
		///         Once the allocation has taken place, the constructor has to initialize the object.
		///         With constructors generated by the binding generator this means that it manually invokes one of the "init" methods to initialize the object.
		///     </para>
		///     <para>It is the developer's responsibility to completely initialize the object if they chain up using this constructor chain.</para>
		///     <para>
		///         In general, if the developer's constructor invokes the corresponding base implementation, then it should also call an Objective-C init method.
		///         If this is not the case, developers should instead chain to the proper constructor in their class.
		///     </para>
		///     <para>
		///         The argument value is ignored and merely ensures that the only code that is executed is the construction phase is the basic <see cref="Foundation.NSObject" /> allocation and runtime type registration.
		///         Typically the chaining would look like this:
		///     </para>
		///     <example>
		///             <code lang="csharp lang-csharp"><![CDATA[
		/// //
		/// // The NSObjectFlag constructor merely allocates the object and registers the C# class with the Objective-C runtime if necessary.
		/// // No actual initXxx method is invoked, that is done later in the constructor
		/// //
		/// // This is taken from the iOS SDK's source code for the UIView class:
		/// //
		/// [Export ("initWithFrame:")]
		/// public UIView (CGRect frame) : base (NSObjectFlag.Empty)
		/// {
		///     // Invoke the init method now.
		///     var initWithFrame = new Selector ("initWithFrame:").Handle;
		///     if (IsDirectBinding) {
		///         Handle = ObjCRuntime.Messaging.IntPtr_objc_msgSend_CGRect (this.Handle, initWithFrame, frame);
		///     } else {
		///         unsafe {
		///             var __objc_super__ = new ObjCRuntime.ObjCSuper (this);
		///             Handle = ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_CGRect (&__objc_super__, initWithFrame, frame);
		///         }
		///         GC.KeepAlive (this);
		///     }
		/// }
		/// ]]></code>
		///     </example>
		/// </remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected NSFilePresenter (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = false;
		}

		/// <summary>A constructor used when creating managed representations of unmanaged objects. Called by the runtime.</summary>
		/// <param name="handle">Pointer (handle) to the unmanaged object.</param>
		/// <remarks>
		///     <para>
		///         This constructor is invoked by the runtime infrastructure (<see cref="ObjCRuntime.Runtime.GetNSObject(System.IntPtr)" />) to create a new managed representation for a pointer to an unmanaged Objective-C object.
		///         Developers should not invoke this method directly, instead they should call <see cref="ObjCRuntime.Runtime.GetNSObject(System.IntPtr)" /> as it will prevent two instances of a managed object pointing to the same native object.
		///     </para>
		/// </remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal NSFilePresenter (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		/// <param name="completionHandler">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("accommodatePresentedItemDeletionWithCompletionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void AccommodatePresentedItemDeletion ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V0))]global::System.Action<NSError> completionHandler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("accommodatePresentedItemEvictionWithCompletionHandler:")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos14.4")]
		[SupportedOSPlatform ("ios17.4")]
		[SupportedOSPlatform ("maccatalyst17.4")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void AccommodatePresentedItemEviction ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V0))]global::System.Action<NSError> completionHandler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="url">To be added.</param><param name="completionHandler">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("accommodatePresentedSubitemDeletionAtURL:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void AccommodatePresentedSubitemDeletion (NSUrl url, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V0))]global::System.Action<NSError> completionHandler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("presentedItemDidChange")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PresentedItemChanged ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="attributes">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("presentedItemDidChangeUbiquityAttributes:")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PresentedItemChangedUbiquityAttributes (NSSet<NSString> attributes)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="version">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("presentedItemDidGainVersion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PresentedItemGainedVersion (NSFileVersion version)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="version">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("presentedItemDidLoseVersion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PresentedItemLostVersion (NSFileVersion version)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="newURL">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("presentedItemDidMoveToURL:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PresentedItemMoved (NSUrl newURL)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="version">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("presentedItemDidResolveConflictVersion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PresentedItemResolveConflictVersion (NSFileVersion version)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="atUrl">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("presentedSubitemDidAppearAtURL:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PresentedSubitemAppeared (NSUrl atUrl)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="url">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("presentedSubitemDidChangeAtURL:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PresentedSubitemChanged (NSUrl url)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="url">To be added.</param><param name="version">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("presentedSubitemAtURL:didGainVersion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PresentedSubitemGainedVersion (NSUrl url, NSFileVersion version)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="url">To be added.</param><param name="version">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("presentedSubitemAtURL:didLoseVersion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PresentedSubitemLostVersion (NSUrl url, NSFileVersion version)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="oldURL">To be added.</param><param name="newURL">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("presentedSubitemAtURL:didMoveToURL:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PresentedSubitemMoved (NSUrl oldURL, NSUrl newURL)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="url">To be added.</param><param name="version">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("presentedSubitemAtURL:didResolveConflictVersion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PresentedSubitemResolvedConflictVersion (NSUrl url, NSFileVersion version)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="readerAction">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("relinquishPresentedItemToReader:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void RelinquishPresentedItemToReader ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDNSFilePresenterReacquirer))]NSFilePresenterReacquirer readerAction)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="writerAction">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("relinquishPresentedItemToWriter:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void RelinquishPresentedItemToWriter ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDNSFilePresenterReacquirer))]NSFilePresenterReacquirer writerAction)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="completionHandler">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("savePresentedItemChangesWithCompletionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void SavePresentedItemChanges ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V0))]global::System.Action<NSError> completionHandler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <summary>Gets the set of ubiquity attributes that will generate notifications if they are modified.</summary><value>To be added.</value><remarks><para>(More documentation for this node is coming)</para><para tool="threads">This can be used from a background thread.</para></remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		public virtual NSSet<NSString> PresentedItemObservedUbiquityAttributes {
			[Export ("observedPresentedItemUbiquityAttributes", ArgumentSemantic.Retain)]
			get {
				throw new ModelNotImplementedException ();
			}
		}
		/// <summary>Gets the <see cref="T:Foundation.NSOperationQueue" /> on which presenter-related methods are executed.</summary><value>The <see cref="T:Foundation.NSOperationQueue" /> on which methods are executed.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSOperationQueue PresentedItemOperationQueue {
			[Export ("presentedItemOperationQueue", ArgumentSemantic.Retain)]
			get {
				throw new ModelNotImplementedException ();
			}
		}
		/// <summary>Gets URL of presented item.</summary><value></value><remarks><para></para><para tool="threads">This can be used from a background thread.</para></remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSUrl? PresentedItemUrl {
			[Export ("presentedItemURL", ArgumentSemantic.Retain)]
			get {
				throw new ModelNotImplementedException ();
			}
		}
	} /* class NSFilePresenter */
}
