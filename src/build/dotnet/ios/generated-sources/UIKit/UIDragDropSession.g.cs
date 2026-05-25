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
namespace UIKit {
	#pragma warning disable CS1573
	/// <summary>Interface for querying drag-and-drop capabilities and state.</summary>
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[Protocol (Name = "UIDragDropSession", WrapperType = typeof (UIDragDropSessionWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "LocationInView", Selector = "locationInView:", ReturnType = typeof (CGPoint), ParameterType = new Type [] { typeof (UIView) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "HasConformingItems", Selector = "hasItemsConformingToTypeIdentifiers:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (String[]) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "CanLoadObjects", Selector = "canLoadObjectsOfClass:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (Class) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "Items", Selector = "items", PropertyType = typeof (UIDragItem[]), GetterSelector = "items", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "AllowsMoveOperation", Selector = "allowsMoveOperation", PropertyType = typeof (bool), GetterSelector = "allowsMoveOperation", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "RestrictedToDraggingApplication", Selector = "restrictedToDraggingApplication", PropertyType = typeof (bool), GetterSelector = "isRestrictedToDraggingApplication", ArgumentSemantic = ArgumentSemantic.None)]
	public partial interface IUIDragDropSession : INativeObject, IDisposable
	{
		/// <param name="view">The view to query.</param><summary>Returns the location of the drag-drop activity in the coordinate frame of the specified <paramref name="view" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("locationInView:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGPoint LocationInView (UIView? view)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="view">The view to query.</param><summary>Returns the location of the drag-drop activity in the coordinate frame of the specified <paramref name="view" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static CGPoint _LocationInView (IUIDragDropSession This, UIView? view)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var view__handle__ = view.GetHandle ();
			CGPoint ret;
			ret = global::ObjCRuntime.Messaging.CGPoint_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("locationInView:"), view__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (view);
			return ret!;
		}
		/// <param name="typeIdentifiers">The type identifiers to check.</param><summary>TReturns a Boolean value that tells whether the session contains at least one item that is described by any of the specified type identifiers.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("hasItemsConformingToTypeIdentifiers:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool HasConformingItems (string[] typeIdentifiers)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="typeIdentifiers">The type identifiers to check.</param><summary>TReturns a Boolean value that tells whether the session contains at least one item that is described by any of the specified type identifiers.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _HasConformingItems (IUIDragDropSession This, string[] typeIdentifiers)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (typeIdentifiers is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (typeIdentifiers));
			using var nsa_typeIdentifiers = NSArray.FromStrings (typeIdentifiers);
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("hasItemsConformingToTypeIdentifiers:"), nsa_typeIdentifiers.Handle);
			GC.KeepAlive (This);
			return ret != 0;
		}
		/// <param name="itemProviderReadingClass">The class of objects to check.</param><summary>Returns a Boolean value that tells whether the session can load objects of the specified class.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("canLoadObjectsOfClass:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool CanLoadObjects (Class itemProviderReadingClass)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="itemProviderReadingClass">The class of objects to check.</param><summary>Returns a Boolean value that tells whether the session can load objects of the specified class.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _CanLoadObjects (IUIDragDropSession This, Class itemProviderReadingClass)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var itemProviderReadingClass__handle__ = itemProviderReadingClass!.GetNonNullHandle (nameof (itemProviderReadingClass));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("canLoadObjectsOfClass:"), itemProviderReadingClass.Handle);
			GC.KeepAlive (This);
			GC.KeepAlive (itemProviderReadingClass);
			return ret != 0;
		}
		[DynamicDependencyAttribute ("AllowsMoveOperation")]
		[DynamicDependencyAttribute ("CanLoadObjects(ObjCRuntime.Class)")]
		[DynamicDependencyAttribute ("HasConformingItems(System.String[])")]
		[DynamicDependencyAttribute ("Items")]
		[DynamicDependencyAttribute ("LocationInView(UIKit.UIView)")]
		[DynamicDependencyAttribute ("RestrictedToDraggingApplication")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UIDragDropSessionWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IUIDragDropSession ()
		{
			GC.KeepAlive (null);
		}
		/// <summary>Gets the drag items that are in the session.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual UIDragItem[] Items {
			[Export ("items")]
			get {
				return _GetItems (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static UIDragItem[] _GetItems (IUIDragDropSession This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			UIDragItem[] ret;
			ret = CFArray.ArrayFromHandle<UIDragItem>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("items")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		/// <summary>Gets a Boolean value that tells whether the session can move items within a single app.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual bool AllowsMoveOperation {
			[Export ("allowsMoveOperation")]
			get {
				return _GetAllowsMoveOperation (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _GetAllowsMoveOperation (IUIDragDropSession This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("allowsMoveOperation"));
			GC.KeepAlive (This);
			return ret != 0;
		}
		/// <summary>Gets a Boolean value that tells whether the drag activity is confined to the originating app.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual bool RestrictedToDraggingApplication {
			[Export ("isRestrictedToDraggingApplication")]
			get {
				return _GetRestrictedToDraggingApplication (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _GetRestrictedToDraggingApplication (IUIDragDropSession This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("isRestrictedToDraggingApplication"));
			GC.KeepAlive (This);
			return ret != 0;
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class UIDragDropSessionWrapper : BaseWrapper, IUIDragDropSession {
		public UIDragDropSessionWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UIDragDropSessionWrapper))]
		static UIDragDropSessionWrapper ()
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
		/// <summary>Gets the drag items that are in the session.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public UIDragItem[] Items {
			[Export ("items")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UIDragItem[] ret;
				ret = CFArray.ArrayFromHandle<UIDragItem>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("items")), false)!;
				return ret;
			}
		}
		/// <summary>Gets a Boolean value that tells whether the session can move items within a single app.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public bool AllowsMoveOperation {
			[Export ("allowsMoveOperation")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				byte ret;
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("allowsMoveOperation"));
				return ret != 0;
			}
		}
		/// <summary>Gets a Boolean value that tells whether the drag activity is confined to the originating app.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public bool RestrictedToDraggingApplication {
			[Export ("isRestrictedToDraggingApplication")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				byte ret;
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isRestrictedToDraggingApplication"));
				return ret != 0;
			}
		}
	}
}
