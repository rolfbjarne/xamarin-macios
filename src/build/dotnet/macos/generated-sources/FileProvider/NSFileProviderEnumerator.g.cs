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
	/// <summary>Enumerates items for an file provider.</summary>
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[Protocol (Name = "NSFileProviderEnumerator", WrapperType = typeof (NSFileProviderEnumeratorWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "Invalidate", Selector = "invalidate")]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "EnumerateItems", Selector = "enumerateItemsForObserver:startingAtPage:", ParameterType = new Type [] { typeof (INSFileProviderEnumerationObserver), typeof (NSData) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "EnumerateChanges", Selector = "enumerateChangesForObserver:fromSyncAnchor:", ParameterType = new Type [] { typeof (INSFileProviderChangeObserver), typeof (NSData) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "CurrentSyncAnchor", Selector = "currentSyncAnchorWithCompletionHandler:", ParameterType = new Type [] { typeof (global::System.Action<NSData>) }, ParameterByRef = new bool [] { false }, ParameterBlockProxy = new Type? [] { typeof (ObjCRuntime.Trampolines.NIDActionArity1V48) })]
	public partial interface INSFileProviderEnumerator : INativeObject, IDisposable
	{
		/// <summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("invalidate")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Invalidate ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _Invalidate (INSFileProviderEnumerator This)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("invalidate"));
			GC.KeepAlive (This);
		}
		/// <param name="observer">To be added.</param><param name="startPage">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("enumerateItemsForObserver:startingAtPage:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void EnumerateItems (INSFileProviderEnumerationObserver observer, NSData startPage)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="observer">To be added.</param><param name="startPage">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _EnumerateItems (INSFileProviderEnumerator This, INSFileProviderEnumerationObserver observer, NSData startPage)
		{
			var observer__handle__ = observer!.GetNonNullHandle (nameof (observer));
			var startPage__handle__ = startPage!.GetNonNullHandle (nameof (startPage));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("enumerateItemsForObserver:startingAtPage:"), observer__handle__, startPage__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (observer);
			GC.KeepAlive (startPage);
		}
		/// <param name="observer">To be added.</param><param name="syncAnchor">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("enumerateChangesForObserver:fromSyncAnchor:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void EnumerateChanges (INSFileProviderChangeObserver observer, NSData syncAnchor)
		{
			_EnumerateChanges (this, observer, syncAnchor);
		}
		/// <param name="observer">To be added.</param><param name="syncAnchor">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _EnumerateChanges (INSFileProviderEnumerator This, INSFileProviderChangeObserver observer, NSData syncAnchor)
		{
			var observer__handle__ = observer!.GetNonNullHandle (nameof (observer));
			var syncAnchor__handle__ = syncAnchor!.GetNonNullHandle (nameof (syncAnchor));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("enumerateChangesForObserver:fromSyncAnchor:"), observer__handle__, syncAnchor__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (observer);
			GC.KeepAlive (syncAnchor);
		}
		/// <param name="completionHandler">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("currentSyncAnchorWithCompletionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void CurrentSyncAnchor ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V48))]global::System.Action<NSData> completionHandler)
		{
			_CurrentSyncAnchor (this, completionHandler);
		}
		/// <param name="completionHandler">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _CurrentSyncAnchor (INSFileProviderEnumerator This, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V48))]global::System.Action<NSData> completionHandler)
		{
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity1V48.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("currentSyncAnchorWithCompletionHandler:"), (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
		}
		[DynamicDependencyAttribute ("CurrentSyncAnchor(System.Action{Foundation.NSData})")]
		[DynamicDependencyAttribute ("EnumerateChanges(FileProvider.INSFileProviderChangeObserver,Foundation.NSData)")]
		[DynamicDependencyAttribute ("EnumerateItems(FileProvider.INSFileProviderEnumerationObserver,Foundation.NSData)")]
		[DynamicDependencyAttribute ("Invalidate()")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSFileProviderEnumeratorWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static INSFileProviderEnumerator ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="INSFileProviderEnumerator" /> interface to support all the methods from the NSFileProviderEnumerator protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="INSFileProviderEnumerator" /> interface allow developers to treat instances of the interface as having all the optional methods of the original NSFileProviderEnumerator protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class NSFileProviderEnumerator_Extensions {
		/// <param name="observer">To be added.</param><param name="syncAnchor">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void EnumerateChanges (this INSFileProviderEnumerator This, INSFileProviderChangeObserver observer, NSData syncAnchor)
		{
			var observer__handle__ = observer!.GetNonNullHandle (nameof (observer));
			var syncAnchor__handle__ = syncAnchor!.GetNonNullHandle (nameof (syncAnchor));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("enumerateChangesForObserver:fromSyncAnchor:"), observer__handle__, syncAnchor__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (observer);
			GC.KeepAlive (syncAnchor);
		}
		/// <param name="completionHandler">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void CurrentSyncAnchor (this INSFileProviderEnumerator This, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V48))]global::System.Action<NSData> completionHandler)
		{
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity1V48.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("currentSyncAnchorWithCompletionHandler:"), (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class NSFileProviderEnumeratorWrapper : BaseWrapper, INSFileProviderEnumerator {
		public NSFileProviderEnumeratorWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSFileProviderEnumeratorWrapper))]
		static NSFileProviderEnumeratorWrapper ()
		{
			GC.KeepAlive (null);
		}
		/// <summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("invalidate")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void Invalidate ()
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("invalidate"));
		}
		/// <param name="observer">To be added.</param><param name="startPage">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("enumerateItemsForObserver:startingAtPage:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void EnumerateItems (INSFileProviderEnumerationObserver observer, NSData startPage)
		{
			var observer__handle__ = observer!.GetNonNullHandle (nameof (observer));
			var startPage__handle__ = startPage!.GetNonNullHandle (nameof (startPage));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("enumerateItemsForObserver:startingAtPage:"), observer__handle__, startPage__handle__);
			GC.KeepAlive (observer);
			GC.KeepAlive (startPage);
		}
	}
}
