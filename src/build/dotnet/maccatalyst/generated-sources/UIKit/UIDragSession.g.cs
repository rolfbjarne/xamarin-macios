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
using Metal;
using CoreML;
using AppKit;
using MapKit;
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Contacts;
using Security;
using CloudKit;
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
using FileProvider;
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;
using MetalPerformanceShadersGraph;
#nullable enable
namespace UIKit {
	#pragma warning disable CS1573
	/// <summary>Interface for providing custom data, visible to the originating activity only, to a drag interaction.</summary>
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[Protocol (Name = "UIDragSession", WrapperType = typeof (UIDragSessionWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "LocalContext", Selector = "localContext", PropertyType = typeof (NSObject), GetterSelector = "localContext", SetterSelector = "setLocalContext:", ArgumentSemantic = ArgumentSemantic.Retain)]
	public partial interface IUIDragSession : INativeObject, IDisposable, 
		UIKit.IUIDragDropSession
	{
		[DynamicDependencyAttribute ("LocalContext")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UIDragSessionWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IUIDragSession ()
		{
			GC.KeepAlive (null);
		}
		/// <summary>Gets or sets the optional object that contains context information visible to the originating activity.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual NSObject? LocalContext {
			[Export ("localContext", ArgumentSemantic.Retain)]
			get {
				return _GetLocalContext (this);
			}
			[Export ("setLocalContext:", ArgumentSemantic.Retain)]
			set {
				_SetLocalContext (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSObject _GetLocalContext (IUIDragSession This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			NSObject ret;
			ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("localContext")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetLocalContext (IUIDragSession This, NSObject? value)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var value__handle__ = value.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setLocalContext:"), value__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (value);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class UIDragSessionWrapper : BaseWrapper, IUIDragSession {
		public UIDragSessionWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UIDragSessionWrapper))]
		static UIDragSessionWrapper ()
		{
			GC.KeepAlive (null);
		}
		/// <param name="view">The view to query.</param><summary>Returns the location of the drag-drop activity in the coordinate frame of the specified <paramref name="view" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("locationInView:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public CGPoint LocationInView (UIView? view)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var view__handle__ = view.GetHandle ();
			CGPoint ret;
			ret = global::ObjCRuntime.Messaging.CGPoint_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("locationInView:"), view__handle__);
			GC.KeepAlive (view);
			return ret!;
		}
		/// <param name="typeIdentifiers">The type identifiers to check.</param><summary>TReturns a Boolean value that tells whether the session contains at least one item that is described by any of the specified type identifiers.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("hasItemsConformingToTypeIdentifiers:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public bool HasConformingItems (string[] typeIdentifiers)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (typeIdentifiers is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (typeIdentifiers));
			using var nsa_typeIdentifiers = NSArray.FromStrings (typeIdentifiers);
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("hasItemsConformingToTypeIdentifiers:"), nsa_typeIdentifiers.Handle);
			return ret != 0;
		}
		/// <param name="itemProviderReadingClass">The class of objects to check.</param><summary>Returns a Boolean value that tells whether the session can load objects of the specified class.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("canLoadObjectsOfClass:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public bool CanLoadObjects (Class itemProviderReadingClass)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var itemProviderReadingClass__handle__ = itemProviderReadingClass!.GetNonNullHandle (nameof (itemProviderReadingClass));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("canLoadObjectsOfClass:"), itemProviderReadingClass.Handle);
			GC.KeepAlive (itemProviderReadingClass);
			return ret != 0;
		}
		/// <summary>Gets or sets the optional object that contains context information visible to the originating activity.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSObject? LocalContext {
			[Export ("localContext", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				NSObject ret;
				ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("localContext")), false)!;
				return ret;
			}
			[Export ("setLocalContext:", ArgumentSemantic.Retain)]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				var value__handle__ = value.GetHandle ();
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setLocalContext:"), value__handle__);
				GC.KeepAlive (value);
			}
		}
		/// <summary>Gets the drag items that are in the session.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		public UIDragItem[] Items {
			[Export ("items")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UIDragItem[] ret;
				ret = CFArray.ArrayFromHandle<UIDragItem>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("items")), false)!;
				return ret;
			}
		}
		/// <summary>Gets a Boolean value that tells whether the session can move items within a single app.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		public bool AllowsMoveOperation {
			[Export ("allowsMoveOperation")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				byte ret;
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("allowsMoveOperation"));
				return ret != 0;
			}
		}
		/// <summary>Gets a Boolean value that tells whether the drag activity is confined to the originating app.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		public bool RestrictedToDraggingApplication {
			[Export ("isRestrictedToDraggingApplication")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				byte ret;
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isRestrictedToDraggingApplication"));
				return ret != 0;
			}
		}
	}
}
