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
	/// <summary>Observes changes and deletions of the enumerated files from a <see cref="T:FileProvider.INSFileProviderEnumerator" />.</summary>
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[Protocol (Name = "NSFileProviderChangeObserver", WrapperType = typeof (NSFileProviderChangeObserverWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "DidUpdateItems", Selector = "didUpdateItems:", ParameterType = new Type [] { typeof (INSFileProviderItem[]) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "DidDeleteItems", Selector = "didDeleteItemsWithIdentifiers:", ParameterType = new Type [] { typeof (String[]) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "FinishEnumeratingChanges", Selector = "finishEnumeratingChangesUpToSyncAnchor:moreComing:", ParameterType = new Type [] { typeof (NSData), typeof (bool) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "FinishEnumerating", Selector = "finishEnumeratingWithError:", ParameterType = new Type [] { typeof (NSError) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetSuggestedBatchSize", Selector = "suggestedBatchSize", ReturnType = typeof (IntPtr))]
	public partial interface INSFileProviderChangeObserver : INativeObject, IDisposable
	{
		/// <param name="updatedItems">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("didUpdateItems:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidUpdateItems (INSFileProviderItem[] updatedItems)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="updatedItems">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidUpdateItems (INSFileProviderChangeObserver This, INSFileProviderItem[] updatedItems)
		{
			if (updatedItems is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (updatedItems));
			using var nsa_updatedItems = NSArray.FromNSObjects (updatedItems);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("didUpdateItems:"), nsa_updatedItems.Handle);
			GC.KeepAlive (This);
		}
		/// <param name="deletedItemIdentifiers">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("didDeleteItemsWithIdentifiers:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidDeleteItems (string[] deletedItemIdentifiers)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="deletedItemIdentifiers">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidDeleteItems (INSFileProviderChangeObserver This, string[] deletedItemIdentifiers)
		{
			if (deletedItemIdentifiers is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (deletedItemIdentifiers));
			using var nsa_deletedItemIdentifiers = NSArray.FromStrings (deletedItemIdentifiers);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("didDeleteItemsWithIdentifiers:"), nsa_deletedItemIdentifiers.Handle);
			GC.KeepAlive (This);
		}
		/// <param name="anchor">To be added.</param><param name="moreComing">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("finishEnumeratingChangesUpToSyncAnchor:moreComing:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void FinishEnumeratingChanges (NSData anchor, bool moreComing)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="anchor">To be added.</param><param name="moreComing">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _FinishEnumeratingChanges (INSFileProviderChangeObserver This, NSData anchor, bool moreComing)
		{
			var anchor__handle__ = anchor!.GetNonNullHandle (nameof (anchor));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_bool (This.Handle, Selector.GetHandle ("finishEnumeratingChangesUpToSyncAnchor:moreComing:"), anchor__handle__, moreComing ? (byte) 1 : (byte) 0);
			GC.KeepAlive (This);
			GC.KeepAlive (anchor);
		}
		/// <param name="error">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("finishEnumeratingWithError:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void FinishEnumerating (NSError error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="error">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _FinishEnumerating (INSFileProviderChangeObserver This, NSError error)
		{
			var error__handle__ = error!.GetNonNullHandle (nameof (error));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("finishEnumeratingWithError:"), error__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (error);
		}
		[global::Foundation.OptionalMember]
		[Export ("suggestedBatchSize")]
		[SupportedOSPlatform ("ios16.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint GetSuggestedBatchSize ()
		{
			return _GetSuggestedBatchSize (this);
		}
		[SupportedOSPlatform ("ios16.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static nint _GetSuggestedBatchSize (INSFileProviderChangeObserver This)
		{
			nint ret;
			ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("suggestedBatchSize"));
			GC.KeepAlive (This);
			return ret;
		}
		[DynamicDependencyAttribute ("DidDeleteItems(System.String[])")]
		[DynamicDependencyAttribute ("DidUpdateItems(FileProvider.INSFileProviderItem[])")]
		[DynamicDependencyAttribute ("FinishEnumerating(Foundation.NSError)")]
		[DynamicDependencyAttribute ("FinishEnumeratingChanges(Foundation.NSData,System.Boolean)")]
		[DynamicDependencyAttribute ("GetSuggestedBatchSize()")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSFileProviderChangeObserverWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static INSFileProviderChangeObserver ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="INSFileProviderChangeObserver" /> interface to support all the methods from the NSFileProviderChangeObserver protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="INSFileProviderChangeObserver" /> interface allow developers to treat instances of the interface as having all the optional methods of the original NSFileProviderChangeObserver protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class NSFileProviderChangeObserver_Extensions {
		[SupportedOSPlatform ("ios16.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static nint GetSuggestedBatchSize (this INSFileProviderChangeObserver This)
		{
			nint ret;
			ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("suggestedBatchSize"));
			GC.KeepAlive (This);
			return ret;
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class NSFileProviderChangeObserverWrapper : BaseWrapper, INSFileProviderChangeObserver {
		public NSFileProviderChangeObserverWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSFileProviderChangeObserverWrapper))]
		static NSFileProviderChangeObserverWrapper ()
		{
			GC.KeepAlive (null);
		}
		/// <param name="updatedItems">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("didUpdateItems:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void DidUpdateItems (INSFileProviderItem[] updatedItems)
		{
			if (updatedItems is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (updatedItems));
			using var nsa_updatedItems = NSArray.FromNSObjects (updatedItems);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("didUpdateItems:"), nsa_updatedItems.Handle);
		}
		/// <param name="deletedItemIdentifiers">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("didDeleteItemsWithIdentifiers:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void DidDeleteItems (string[] deletedItemIdentifiers)
		{
			if (deletedItemIdentifiers is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (deletedItemIdentifiers));
			using var nsa_deletedItemIdentifiers = NSArray.FromStrings (deletedItemIdentifiers);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("didDeleteItemsWithIdentifiers:"), nsa_deletedItemIdentifiers.Handle);
		}
		/// <param name="anchor">To be added.</param><param name="moreComing">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("finishEnumeratingChangesUpToSyncAnchor:moreComing:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void FinishEnumeratingChanges (NSData anchor, bool moreComing)
		{
			var anchor__handle__ = anchor!.GetNonNullHandle (nameof (anchor));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_bool (this.Handle, Selector.GetHandle ("finishEnumeratingChangesUpToSyncAnchor:moreComing:"), anchor__handle__, moreComing ? (byte) 1 : (byte) 0);
			GC.KeepAlive (anchor);
		}
		/// <param name="error">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("finishEnumeratingWithError:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void FinishEnumerating (NSError error)
		{
			var error__handle__ = error!.GetNonNullHandle (nameof (error));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("finishEnumeratingWithError:"), error__handle__);
			GC.KeepAlive (error);
		}
	}
}
