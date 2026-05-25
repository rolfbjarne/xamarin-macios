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
	/// <summary>System-created object used to coordinate drop actions with a collection view.</summary>
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[Protocol (Name = "UICollectionViewDropCoordinator", WrapperType = typeof (UICollectionViewDropCoordinatorWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "DropItemToPlaceholder", Selector = "dropItem:toPlaceholder:", ReturnType = typeof (IUICollectionViewDropPlaceholderContext), ParameterType = new Type [] { typeof (UIDragItem), typeof (UICollectionViewDropPlaceholder) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "DropItemToItem", Selector = "dropItem:toItemAtIndexPath:", ReturnType = typeof (IUIDragAnimating), ParameterType = new Type [] { typeof (UIDragItem), typeof (NSIndexPath) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "DropItemIntoItem", Selector = "dropItem:intoItemAtIndexPath:rect:", ReturnType = typeof (IUIDragAnimating), ParameterType = new Type [] { typeof (UIDragItem), typeof (NSIndexPath), typeof (CGRect) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "DropItemToTarget", Selector = "dropItem:toTarget:", ReturnType = typeof (IUIDragAnimating), ParameterType = new Type [] { typeof (UIDragItem), typeof (UIDragPreviewTarget) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "Items", Selector = "items", PropertyType = typeof (IUICollectionViewDropItem[]), GetterSelector = "items", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "DestinationIndexPath", Selector = "destinationIndexPath", PropertyType = typeof (NSIndexPath), GetterSelector = "destinationIndexPath", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "Proposal", Selector = "proposal", PropertyType = typeof (UICollectionViewDropProposal), GetterSelector = "proposal", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "Session", Selector = "session", PropertyType = typeof (IUIDropSession), GetterSelector = "session", ArgumentSemantic = ArgumentSemantic.None)]
	public partial interface IUICollectionViewDropCoordinator : INativeObject, IDisposable
	{
		/// <param name="dragItem">The item to drop.</param><param name="placeholder">The placeholder into which to drop the item.</param><summary>Drops the drag item to the specified placeholder.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("dropItem:toPlaceholder:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual IUICollectionViewDropPlaceholderContext DropItemToPlaceholder (UIDragItem dragItem, UICollectionViewDropPlaceholder placeholder)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="dragItem">The item to drop.</param><param name="placeholder">The placeholder into which to drop the item.</param><summary>Drops the drag item to the specified placeholder.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static IUICollectionViewDropPlaceholderContext _DropItemToPlaceholder (IUICollectionViewDropCoordinator This, UIDragItem dragItem, UICollectionViewDropPlaceholder placeholder)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var dragItem__handle__ = dragItem!.GetNonNullHandle (nameof (dragItem));
			var placeholder__handle__ = placeholder!.GetNonNullHandle (nameof (placeholder));
			IUICollectionViewDropPlaceholderContext? ret;
			ret =  Runtime.GetINativeObject<IUICollectionViewDropPlaceholderContext> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("dropItem:toPlaceholder:"), dragItem__handle__, placeholder__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (dragItem);
			GC.KeepAlive (placeholder);
			return ret!;
		}
		/// <param name="dragItem">The item to drop.</param><param name="itemIndexPath">The index path to which to drop the item.</param><summary>Drops the drag item into the item at the specified item index path.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("dropItem:toItemAtIndexPath:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual IUIDragAnimating DropItemToItem (UIDragItem dragItem, NSIndexPath itemIndexPath)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="dragItem">The item to drop.</param><param name="itemIndexPath">The index path to which to drop the item.</param><summary>Drops the drag item into the item at the specified item index path.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static IUIDragAnimating _DropItemToItem (IUICollectionViewDropCoordinator This, UIDragItem dragItem, NSIndexPath itemIndexPath)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var dragItem__handle__ = dragItem!.GetNonNullHandle (nameof (dragItem));
			var itemIndexPath__handle__ = itemIndexPath!.GetNonNullHandle (nameof (itemIndexPath));
			IUIDragAnimating? ret;
			ret =  Runtime.GetINativeObject<IUIDragAnimating> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("dropItem:toItemAtIndexPath:"), dragItem__handle__, itemIndexPath__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (dragItem);
			GC.KeepAlive (itemIndexPath);
			return ret!;
		}
		/// <param name="dragItem">The item to drop.</param><param name="itemIndexPath">The index path to the item into which to drop.</param><param name="rect">The destination drop rectangle.</param><summary>Drops the drag item into the specified rectangle, in the coordinate system of the item at the specified item index path.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("dropItem:intoItemAtIndexPath:rect:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual IUIDragAnimating DropItemIntoItem (UIDragItem dragItem, NSIndexPath itemIndexPath, CGRect rect)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="dragItem">The item to drop.</param><param name="itemIndexPath">The index path to the item into which to drop.</param><param name="rect">The destination drop rectangle.</param><summary>Drops the drag item into the specified rectangle, in the coordinate system of the item at the specified item index path.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static IUIDragAnimating _DropItemIntoItem (IUICollectionViewDropCoordinator This, UIDragItem dragItem, NSIndexPath itemIndexPath, CGRect rect)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var dragItem__handle__ = dragItem!.GetNonNullHandle (nameof (dragItem));
			var itemIndexPath__handle__ = itemIndexPath!.GetNonNullHandle (nameof (itemIndexPath));
			IUIDragAnimating? ret;
			ret =  Runtime.GetINativeObject<IUIDragAnimating> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_CGRect (This.Handle, Selector.GetHandle ("dropItem:intoItemAtIndexPath:rect:"), dragItem__handle__, itemIndexPath__handle__, rect), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (dragItem);
			GC.KeepAlive (itemIndexPath);
			return ret!;
		}
		/// <param name="dragItem">The item to drop.</param><param name="target">The target to which to drop the item.</param><summary>Drops the drag item to the specified target.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("dropItem:toTarget:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual IUIDragAnimating DropItemToTarget (UIDragItem dragItem, UIDragPreviewTarget target)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="dragItem">The item to drop.</param><param name="target">The target to which to drop the item.</param><summary>Drops the drag item to the specified target.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static IUIDragAnimating _DropItemToTarget (IUICollectionViewDropCoordinator This, UIDragItem dragItem, UIDragPreviewTarget target)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var dragItem__handle__ = dragItem!.GetNonNullHandle (nameof (dragItem));
			var target__handle__ = target!.GetNonNullHandle (nameof (target));
			IUIDragAnimating? ret;
			ret =  Runtime.GetINativeObject<IUIDragAnimating> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("dropItem:toTarget:"), dragItem__handle__, target__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (dragItem);
			GC.KeepAlive (target);
			return ret!;
		}
		[DynamicDependencyAttribute ("DestinationIndexPath")]
		[DynamicDependencyAttribute ("DropItemIntoItem(UIKit.UIDragItem,Foundation.NSIndexPath,CoreGraphics.CGRect)")]
		[DynamicDependencyAttribute ("DropItemToItem(UIKit.UIDragItem,Foundation.NSIndexPath)")]
		[DynamicDependencyAttribute ("DropItemToPlaceholder(UIKit.UIDragItem,UIKit.UICollectionViewDropPlaceholder)")]
		[DynamicDependencyAttribute ("DropItemToTarget(UIKit.UIDragItem,UIKit.UIDragPreviewTarget)")]
		[DynamicDependencyAttribute ("Items")]
		[DynamicDependencyAttribute ("Proposal")]
		[DynamicDependencyAttribute ("Session")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UICollectionViewDropCoordinatorWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IUICollectionViewDropCoordinator ()
		{
			GC.KeepAlive (null);
		}
		/// <summary>Gets the drag items.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual IUICollectionViewDropItem[] Items {
			[Export ("items")]
			get {
				return _GetItems (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static IUICollectionViewDropItem[] _GetItems (IUICollectionViewDropCoordinator This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			IUICollectionViewDropItem[] ret;
			ret = CFArray.ArrayFromHandle<IUICollectionViewDropItem>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("items")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		/// <summary>Gets the index path for the insertion.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual NSIndexPath? DestinationIndexPath {
			[Export ("destinationIndexPath")]
			get {
				return _GetDestinationIndexPath (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSIndexPath _GetDestinationIndexPath (IUICollectionViewDropCoordinator This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			NSIndexPath ret;
			ret =  Runtime.GetNSObject<NSIndexPath> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("destinationIndexPath")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		/// <summary>Gets the drop proposal.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual UICollectionViewDropProposal Proposal {
			[Export ("proposal")]
			get {
				return _GetProposal (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static UICollectionViewDropProposal _GetProposal (IUICollectionViewDropCoordinator This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			UICollectionViewDropProposal ret;
			ret =  Runtime.GetNSObject<UICollectionViewDropProposal> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("proposal")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		/// <summary>Gets the drop session.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual IUIDropSession Session {
			[Export ("session")]
			get {
				return _GetSession (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static IUIDropSession _GetSession (IUICollectionViewDropCoordinator This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			IUIDropSession ret;
			ret =  Runtime.GetINativeObject<IUIDropSession> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("session")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class UICollectionViewDropCoordinatorWrapper : BaseWrapper, IUICollectionViewDropCoordinator {
		public UICollectionViewDropCoordinatorWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UICollectionViewDropCoordinatorWrapper))]
		static UICollectionViewDropCoordinatorWrapper ()
		{
			GC.KeepAlive (null);
		}
		/// <param name="dragItem">The item to drop.</param><param name="placeholder">The placeholder into which to drop the item.</param><summary>Drops the drag item to the specified placeholder.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("dropItem:toPlaceholder:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public IUICollectionViewDropPlaceholderContext DropItemToPlaceholder (UIDragItem dragItem, UICollectionViewDropPlaceholder placeholder)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var dragItem__handle__ = dragItem!.GetNonNullHandle (nameof (dragItem));
			var placeholder__handle__ = placeholder!.GetNonNullHandle (nameof (placeholder));
			IUICollectionViewDropPlaceholderContext? ret;
			ret =  Runtime.GetINativeObject<IUICollectionViewDropPlaceholderContext> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("dropItem:toPlaceholder:"), dragItem__handle__, placeholder__handle__), false)!;
			GC.KeepAlive (dragItem);
			GC.KeepAlive (placeholder);
			return ret!;
		}
		/// <param name="dragItem">The item to drop.</param><param name="itemIndexPath">The index path to which to drop the item.</param><summary>Drops the drag item into the item at the specified item index path.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("dropItem:toItemAtIndexPath:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public IUIDragAnimating DropItemToItem (UIDragItem dragItem, NSIndexPath itemIndexPath)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var dragItem__handle__ = dragItem!.GetNonNullHandle (nameof (dragItem));
			var itemIndexPath__handle__ = itemIndexPath!.GetNonNullHandle (nameof (itemIndexPath));
			IUIDragAnimating? ret;
			ret =  Runtime.GetINativeObject<IUIDragAnimating> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("dropItem:toItemAtIndexPath:"), dragItem__handle__, itemIndexPath__handle__), false)!;
			GC.KeepAlive (dragItem);
			GC.KeepAlive (itemIndexPath);
			return ret!;
		}
		/// <param name="dragItem">The item to drop.</param><param name="itemIndexPath">The index path to the item into which to drop.</param><param name="rect">The destination drop rectangle.</param><summary>Drops the drag item into the specified rectangle, in the coordinate system of the item at the specified item index path.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("dropItem:intoItemAtIndexPath:rect:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public IUIDragAnimating DropItemIntoItem (UIDragItem dragItem, NSIndexPath itemIndexPath, CGRect rect)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var dragItem__handle__ = dragItem!.GetNonNullHandle (nameof (dragItem));
			var itemIndexPath__handle__ = itemIndexPath!.GetNonNullHandle (nameof (itemIndexPath));
			IUIDragAnimating? ret;
			ret =  Runtime.GetINativeObject<IUIDragAnimating> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_CGRect (this.Handle, Selector.GetHandle ("dropItem:intoItemAtIndexPath:rect:"), dragItem__handle__, itemIndexPath__handle__, rect), false)!;
			GC.KeepAlive (dragItem);
			GC.KeepAlive (itemIndexPath);
			return ret!;
		}
		/// <param name="dragItem">The item to drop.</param><param name="target">The target to which to drop the item.</param><summary>Drops the drag item to the specified target.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("dropItem:toTarget:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public IUIDragAnimating DropItemToTarget (UIDragItem dragItem, UIDragPreviewTarget target)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var dragItem__handle__ = dragItem!.GetNonNullHandle (nameof (dragItem));
			var target__handle__ = target!.GetNonNullHandle (nameof (target));
			IUIDragAnimating? ret;
			ret =  Runtime.GetINativeObject<IUIDragAnimating> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("dropItem:toTarget:"), dragItem__handle__, target__handle__), false)!;
			GC.KeepAlive (dragItem);
			GC.KeepAlive (target);
			return ret!;
		}
		/// <summary>Gets the drag items.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public IUICollectionViewDropItem[] Items {
			[Export ("items")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				IUICollectionViewDropItem[] ret;
				ret = CFArray.ArrayFromHandle<IUICollectionViewDropItem>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("items")), false)!;
				return ret;
			}
		}
		/// <summary>Gets the index path for the insertion.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSIndexPath? DestinationIndexPath {
			[Export ("destinationIndexPath")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				NSIndexPath ret;
				ret =  Runtime.GetNSObject<NSIndexPath> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("destinationIndexPath")), false)!;
				return ret;
			}
		}
		/// <summary>Gets the drop proposal.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public UICollectionViewDropProposal Proposal {
			[Export ("proposal")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UICollectionViewDropProposal ret;
				ret =  Runtime.GetNSObject<UICollectionViewDropProposal> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("proposal")), false)!;
				return ret;
			}
		}
		/// <summary>Gets the drop session.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public IUIDropSession Session {
			[Export ("session")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				IUIDropSession ret;
				ret =  Runtime.GetINativeObject<IUIDropSession> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("session")), false)!;
				return ret;
			}
		}
	}
}
