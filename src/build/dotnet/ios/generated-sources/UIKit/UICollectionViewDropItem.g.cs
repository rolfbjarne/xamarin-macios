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
	/// <summary>Data for an item to be dropped into a collection view.</summary>
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[Protocol (Name = "UICollectionViewDropItem", WrapperType = typeof (UICollectionViewDropItemWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "DragItem", Selector = "dragItem", PropertyType = typeof (UIDragItem), GetterSelector = "dragItem", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "SourceIndexPath", Selector = "sourceIndexPath", PropertyType = typeof (NSIndexPath), GetterSelector = "sourceIndexPath", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "PreviewSize", Selector = "previewSize", PropertyType = typeof (CGSize), GetterSelector = "previewSize", ArgumentSemantic = ArgumentSemantic.None)]
	public partial interface IUICollectionViewDropItem : INativeObject, IDisposable
	{
		[DynamicDependencyAttribute ("DragItem")]
		[DynamicDependencyAttribute ("PreviewSize")]
		[DynamicDependencyAttribute ("SourceIndexPath")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UICollectionViewDropItemWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IUICollectionViewDropItem ()
		{
			GC.KeepAlive (null);
		}
		/// <summary>Gets the drag item.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual UIDragItem DragItem {
			[Export ("dragItem")]
			get {
				return _GetDragItem (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static UIDragItem _GetDragItem (IUICollectionViewDropItem This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			UIDragItem ret;
			ret =  Runtime.GetNSObject<UIDragItem> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("dragItem")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		/// <summary>Gets the source index path for the item if it is being dragged from another location in the collection view.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual NSIndexPath? SourceIndexPath {
			[Export ("sourceIndexPath")]
			get {
				return _GetSourceIndexPath (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSIndexPath _GetSourceIndexPath (IUICollectionViewDropItem This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			NSIndexPath ret;
			ret =  Runtime.GetNSObject<NSIndexPath> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("sourceIndexPath")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		/// <summary>Gets the preview size for the drag item.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual CGSize PreviewSize {
			[Export ("previewSize")]
			get {
				return _GetPreviewSize (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static CGSize _GetPreviewSize (IUICollectionViewDropItem This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			CGSize ret;
			ret = global::ObjCRuntime.Messaging.CGSize_objc_msgSend (This.Handle, Selector.GetHandle ("previewSize"));
			GC.KeepAlive (This);
			return ret;
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class UICollectionViewDropItemWrapper : BaseWrapper, IUICollectionViewDropItem {
		public UICollectionViewDropItemWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UICollectionViewDropItemWrapper))]
		static UICollectionViewDropItemWrapper ()
		{
			GC.KeepAlive (null);
		}
		/// <summary>Gets the drag item.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public UIDragItem DragItem {
			[Export ("dragItem")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UIDragItem ret;
				ret =  Runtime.GetNSObject<UIDragItem> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("dragItem")), false)!;
				return ret;
			}
		}
		/// <summary>Gets the source index path for the item if it is being dragged from another location in the collection view.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSIndexPath? SourceIndexPath {
			[Export ("sourceIndexPath")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				NSIndexPath ret;
				ret =  Runtime.GetNSObject<NSIndexPath> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("sourceIndexPath")), false)!;
				return ret;
			}
		}
		/// <summary>Gets the preview size for the drag item.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public CGSize PreviewSize {
			[Export ("previewSize")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				CGSize ret;
				ret = global::ObjCRuntime.Messaging.CGSize_objc_msgSend (this.Handle, Selector.GetHandle ("previewSize"));
				return ret;
			}
		}
	}
}
