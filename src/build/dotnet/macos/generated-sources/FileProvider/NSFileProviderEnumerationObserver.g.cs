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
	/// <summary>This interface represents the Objective-C protocol <c>NSFileProviderEnumerationObserver</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[Protocol (Name = "NSFileProviderEnumerationObserver", WrapperType = typeof (NSFileProviderEnumerationObserverWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "DidEnumerateItems", Selector = "didEnumerateItems:", ParameterType = new Type [] { typeof (INSFileProviderItem[]) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "FinishEnumerating", Selector = "finishEnumeratingUpToPage:", ParameterType = new Type [] { typeof (NSData) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "FinishEnumerating", Selector = "finishEnumeratingWithError:", ParameterType = new Type [] { typeof (NSError) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetSuggestedPageSize", Selector = "suggestedPageSize", ReturnType = typeof (IntPtr))]
	public partial interface INSFileProviderEnumerationObserver : INativeObject, IDisposable
	{
		/// <param name="updatedItems">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("didEnumerateItems:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidEnumerateItems (INSFileProviderItem[] updatedItems)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="updatedItems">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidEnumerateItems (INSFileProviderEnumerationObserver This, INSFileProviderItem[] updatedItems)
		{
			if (updatedItems is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (updatedItems));
			using var nsa_updatedItems = NSArray.FromNSObjects (updatedItems);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("didEnumerateItems:"), nsa_updatedItems.Handle);
			GC.KeepAlive (This);
		}
		/// <param name="upToPage">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("finishEnumeratingUpToPage:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void FinishEnumerating (NSData? upToPage)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="upToPage">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _FinishEnumerating (INSFileProviderEnumerationObserver This, NSData? upToPage)
		{
			var upToPage__handle__ = upToPage.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("finishEnumeratingUpToPage:"), upToPage__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (upToPage);
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
		internal static void _FinishEnumerating (INSFileProviderEnumerationObserver This, NSError error)
		{
			var error__handle__ = error!.GetNonNullHandle (nameof (error));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("finishEnumeratingWithError:"), error__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (error);
		}
		[global::Foundation.OptionalMember]
		[Export ("suggestedPageSize")]
		[SupportedOSPlatform ("ios16.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint GetSuggestedPageSize ()
		{
			return _GetSuggestedPageSize (this);
		}
		[SupportedOSPlatform ("ios16.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static nint _GetSuggestedPageSize (INSFileProviderEnumerationObserver This)
		{
			nint ret;
			ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("suggestedPageSize"));
			GC.KeepAlive (This);
			return ret;
		}
		[DynamicDependencyAttribute ("DidEnumerateItems(FileProvider.INSFileProviderItem[])")]
		[DynamicDependencyAttribute ("FinishEnumerating(Foundation.NSData)")]
		[DynamicDependencyAttribute ("FinishEnumerating(Foundation.NSError)")]
		[DynamicDependencyAttribute ("GetSuggestedPageSize()")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSFileProviderEnumerationObserverWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static INSFileProviderEnumerationObserver ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="INSFileProviderEnumerationObserver" /> interface to support all the methods from the NSFileProviderEnumerationObserver protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="INSFileProviderEnumerationObserver" /> interface allow developers to treat instances of the interface as having all the optional methods of the original NSFileProviderEnumerationObserver protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class NSFileProviderEnumerationObserver_Extensions {
		[SupportedOSPlatform ("ios16.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static nint GetSuggestedPageSize (this INSFileProviderEnumerationObserver This)
		{
			nint ret;
			ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("suggestedPageSize"));
			GC.KeepAlive (This);
			return ret;
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class NSFileProviderEnumerationObserverWrapper : BaseWrapper, INSFileProviderEnumerationObserver {
		public NSFileProviderEnumerationObserverWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSFileProviderEnumerationObserverWrapper))]
		static NSFileProviderEnumerationObserverWrapper ()
		{
			GC.KeepAlive (null);
		}
		/// <param name="updatedItems">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("didEnumerateItems:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void DidEnumerateItems (INSFileProviderItem[] updatedItems)
		{
			if (updatedItems is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (updatedItems));
			using var nsa_updatedItems = NSArray.FromNSObjects (updatedItems);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("didEnumerateItems:"), nsa_updatedItems.Handle);
		}
		/// <param name="upToPage">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("finishEnumeratingUpToPage:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void FinishEnumerating (NSData? upToPage)
		{
			var upToPage__handle__ = upToPage.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("finishEnumeratingUpToPage:"), upToPage__handle__);
			GC.KeepAlive (upToPage);
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
