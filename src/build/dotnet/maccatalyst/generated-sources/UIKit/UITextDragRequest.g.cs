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
	/// <summary>System-provided interface for getting information about a drag request that originated in a text view.</summary>
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[Protocol (Name = "UITextDragRequest", WrapperType = typeof (UITextDragRequestWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "DragRange", Selector = "dragRange", PropertyType = typeof (UITextRange), GetterSelector = "dragRange", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "SuggestedItems", Selector = "suggestedItems", PropertyType = typeof (UIDragItem[]), GetterSelector = "suggestedItems", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "ExistingItems", Selector = "existingItems", PropertyType = typeof (UIDragItem[]), GetterSelector = "existingItems", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "Selected", Selector = "selected", PropertyType = typeof (bool), GetterSelector = "isSelected", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "DragSession", Selector = "dragSession", PropertyType = typeof (IUIDragSession), GetterSelector = "dragSession", ArgumentSemantic = ArgumentSemantic.None)]
	public partial interface IUITextDragRequest : INativeObject, IDisposable
	{
		[DynamicDependencyAttribute ("DragRange")]
		[DynamicDependencyAttribute ("DragSession")]
		[DynamicDependencyAttribute ("ExistingItems")]
		[DynamicDependencyAttribute ("Selected")]
		[DynamicDependencyAttribute ("SuggestedItems")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UITextDragRequestWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IUITextDragRequest ()
		{
			GC.KeepAlive (null);
		}
		/// <summary>Gets the range of the text that is being dragged.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual UITextRange DragRange {
			[Export ("dragRange")]
			get {
				return _GetDragRange (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static UITextRange _GetDragRange (IUITextDragRequest This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			UITextRange ret;
			ret =  Runtime.GetNSObject<UITextRange> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("dragRange")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		/// <summary>Gets the items that the system would supply if the developer does not provide a custom implementation.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual UIDragItem[] SuggestedItems {
			[Export ("suggestedItems")]
			get {
				return _GetSuggestedItems (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static UIDragItem[] _GetSuggestedItems (IUITextDragRequest This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			UIDragItem[] ret;
			ret = CFArray.ArrayFromHandle<UIDragItem>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("suggestedItems")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		/// <summary>Gets the items that are currently in the drag session.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual UIDragItem[] ExistingItems {
			[Export ("existingItems")]
			get {
				return _GetExistingItems (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static UIDragItem[] _GetExistingItems (IUITextDragRequest This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			UIDragItem[] ret;
			ret = CFArray.ArrayFromHandle<UIDragItem>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("existingItems")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		/// <summary>Gets a Boolean value that tells whether there is a selection that can be dragged.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual bool Selected {
			[Export ("isSelected")]
			get {
				return _GetSelected (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _GetSelected (IUITextDragRequest This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("isSelected"));
			GC.KeepAlive (This);
			return ret != 0;
		}
		/// <summary>Gets the drag session.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual IUIDragSession DragSession {
			[Export ("dragSession")]
			get {
				return _GetDragSession (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static IUIDragSession _GetDragSession (IUITextDragRequest This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			IUIDragSession ret;
			ret =  Runtime.GetINativeObject<IUIDragSession> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("dragSession")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class UITextDragRequestWrapper : BaseWrapper, IUITextDragRequest {
		public UITextDragRequestWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UITextDragRequestWrapper))]
		static UITextDragRequestWrapper ()
		{
			GC.KeepAlive (null);
		}
		/// <summary>Gets the range of the text that is being dragged.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public UITextRange DragRange {
			[Export ("dragRange")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UITextRange ret;
				ret =  Runtime.GetNSObject<UITextRange> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("dragRange")), false)!;
				return ret;
			}
		}
		/// <summary>Gets the items that the system would supply if the developer does not provide a custom implementation.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public UIDragItem[] SuggestedItems {
			[Export ("suggestedItems")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UIDragItem[] ret;
				ret = CFArray.ArrayFromHandle<UIDragItem>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("suggestedItems")), false)!;
				return ret;
			}
		}
		/// <summary>Gets the items that are currently in the drag session.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public UIDragItem[] ExistingItems {
			[Export ("existingItems")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UIDragItem[] ret;
				ret = CFArray.ArrayFromHandle<UIDragItem>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("existingItems")), false)!;
				return ret;
			}
		}
		/// <summary>Gets a Boolean value that tells whether there is a selection that can be dragged.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public bool Selected {
			[Export ("isSelected")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				byte ret;
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isSelected"));
				return ret != 0;
			}
		}
		/// <summary>Gets the drag session.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public IUIDragSession DragSession {
			[Export ("dragSession")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				IUIDragSession ret;
				ret =  Runtime.GetINativeObject<IUIDragSession> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("dragSession")), false)!;
				return ret;
			}
		}
	}
}
