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
	/// <summary>This interface represents the Objective-C protocol <c>UITabBarControllerSidebarDelegate</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("ios18.0")]
	[SupportedOSPlatform ("maccatalyst18.0")]
	[Protocol (Name = "UITabBarControllerSidebarDelegate", WrapperType = typeof (UITabBarControllerSidebarDelegateWrapper), BackwardsCompatibleCodeGeneration = false)]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "SidebarVisibilityWillChange", Selector = "tabBarController:sidebarVisibilityWillChange:animator:", ParameterType = new Type [] { typeof (UITabBarController), typeof (UITabBarControllerSidebar), typeof (IUITabBarControllerSidebarAnimating) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetItemForRequest", Selector = "tabBarController:sidebar:itemForRequest:", ReturnType = typeof (UITabSidebarItem), ParameterType = new Type [] { typeof (UITabBarController), typeof (UITabBarControllerSidebar), typeof (UITabSidebarItemRequest) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "UpdateItem", Selector = "tabBarController:sidebar:updateItem:", ParameterType = new Type [] { typeof (UITabBarController), typeof (UITabBarControllerSidebar), typeof (UITabSidebarItem) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillBeginDisplayingTab", Selector = "tabBarController:sidebar:willBeginDisplayingTab:", ParameterType = new Type [] { typeof (UITabBarController), typeof (UITabBarControllerSidebar), typeof (UITab) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidEndDisplayingTab", Selector = "tabBarController:sidebar:didEndDisplayingTab:", ParameterType = new Type [] { typeof (UITabBarController), typeof (UITabBarControllerSidebar), typeof (UITab) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetLeadingSwipeActionsConfigurationForTab", Selector = "tabBarController:sidebar:leadingSwipeActionsConfigurationForTab:", ReturnType = typeof (UISwipeActionsConfiguration), ParameterType = new Type [] { typeof (UITabBarController), typeof (UITabBarControllerSidebar), typeof (UITab) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetTrailingSwipeActionsConfigurationForTab", Selector = "tabBarController:sidebar:trailingSwipeActionsConfigurationForTab:", ReturnType = typeof (UISwipeActionsConfiguration), ParameterType = new Type [] { typeof (UITabBarController), typeof (UITabBarControllerSidebar), typeof (UITab) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetContextMenuConfigurationForTab", Selector = "tabBarController:sidebar:contextMenuConfigurationForTab:", ReturnType = typeof (UIContextMenuConfiguration), ParameterType = new Type [] { typeof (UITabBarController), typeof (UITabBarControllerSidebar), typeof (UITab) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetItemsForBeginningDragSession", Selector = "tabBarController:sidebar:itemsForBeginningDragSession:tab:", ReturnType = typeof (UIDragItem[]), ParameterType = new Type [] { typeof (UITabBarController), typeof (UITabBarControllerSidebar), typeof (IUIDragSession), typeof (UITab) }, ParameterByRef = new bool [] { false, false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetItemsForAddingToDragSession", Selector = "tabBarController:sidebar:itemsForAddingToDragSession:tab:", ReturnType = typeof (UIDragItem[]), ParameterType = new Type [] { typeof (UITabBarController), typeof (UITabBarControllerSidebar), typeof (IUIDragSession), typeof (UITab) }, ParameterByRef = new bool [] { false, false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetOperationForAcceptingItemsFromDropSession", Selector = "tabBarController:sidebar:sidebarAction:group:operationForAcceptingItemsFromDropSession:", ReturnType = typeof (UIDropOperation), ParameterType = new Type [] { typeof (UITabBarController), typeof (UITabBarControllerSidebar), typeof (UIAction), typeof (UITabGroup), typeof (IUIDropSession) }, ParameterByRef = new bool [] { false, false, false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "AcceptItemsFromDropSession", Selector = "tabBarController:sidebar:sidebarAction:group:acceptItemsFromDropSession:", ParameterType = new Type [] { typeof (UITabBarController), typeof (UITabBarControllerSidebar), typeof (UIAction), typeof (UITabGroup), typeof (IUIDropSession) }, ParameterByRef = new bool [] { false, false, false, false, false })]
	public partial interface IUITabBarControllerSidebarDelegate : INativeObject, IDisposable
	{
		[global::Foundation.OptionalMember]
		[Export ("tabBarController:sidebarVisibilityWillChange:animator:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SidebarVisibilityWillChange (UITabBarController tabBarController, UITabBarControllerSidebar sidebar, IUITabBarControllerSidebarAnimating animator)
		{
			_SidebarVisibilityWillChange (this, tabBarController, sidebar, animator);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SidebarVisibilityWillChange (IUITabBarControllerSidebarDelegate This, UITabBarController tabBarController, UITabBarControllerSidebar sidebar, IUITabBarControllerSidebarAnimating animator)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var tabBarController__handle__ = tabBarController!.GetNonNullHandle (nameof (tabBarController));
			var sidebar__handle__ = sidebar!.GetNonNullHandle (nameof (sidebar));
			var animator__handle__ = animator!.GetNonNullHandle (nameof (animator));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("tabBarController:sidebarVisibilityWillChange:animator:"), tabBarController__handle__, sidebar__handle__, animator__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (tabBarController);
			GC.KeepAlive (sidebar);
			GC.KeepAlive (animator);
		}
		[global::Foundation.OptionalMember]
		[Export ("tabBarController:sidebar:itemForRequest:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UITabSidebarItem GetItemForRequest (UITabBarController tabBarController, UITabBarControllerSidebar sidebar, UITabSidebarItemRequest request)
		{
			return _GetItemForRequest (this, tabBarController, sidebar, request);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static UITabSidebarItem _GetItemForRequest (IUITabBarControllerSidebarDelegate This, UITabBarController tabBarController, UITabBarControllerSidebar sidebar, UITabSidebarItemRequest request)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var tabBarController__handle__ = tabBarController!.GetNonNullHandle (nameof (tabBarController));
			var sidebar__handle__ = sidebar!.GetNonNullHandle (nameof (sidebar));
			var request__handle__ = request!.GetNonNullHandle (nameof (request));
			UITabSidebarItem? ret;
			ret =  Runtime.GetNSObject<UITabSidebarItem> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("tabBarController:sidebar:itemForRequest:"), tabBarController__handle__, sidebar__handle__, request__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tabBarController);
			GC.KeepAlive (sidebar);
			GC.KeepAlive (request);
			return ret!;
		}
		[global::Foundation.OptionalMember]
		[Export ("tabBarController:sidebar:updateItem:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void UpdateItem (UITabBarController tabBarController, UITabBarControllerSidebar sidebar, UITabSidebarItem item)
		{
			_UpdateItem (this, tabBarController, sidebar, item);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _UpdateItem (IUITabBarControllerSidebarDelegate This, UITabBarController tabBarController, UITabBarControllerSidebar sidebar, UITabSidebarItem item)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var tabBarController__handle__ = tabBarController!.GetNonNullHandle (nameof (tabBarController));
			var sidebar__handle__ = sidebar!.GetNonNullHandle (nameof (sidebar));
			var item__handle__ = item!.GetNonNullHandle (nameof (item));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("tabBarController:sidebar:updateItem:"), tabBarController__handle__, sidebar__handle__, item__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (tabBarController);
			GC.KeepAlive (sidebar);
			GC.KeepAlive (item);
		}
		[global::Foundation.OptionalMember]
		[Export ("tabBarController:sidebar:willBeginDisplayingTab:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillBeginDisplayingTab (UITabBarController tabBarController, UITabBarControllerSidebar sidebar, UITab tab)
		{
			_WillBeginDisplayingTab (this, tabBarController, sidebar, tab);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _WillBeginDisplayingTab (IUITabBarControllerSidebarDelegate This, UITabBarController tabBarController, UITabBarControllerSidebar sidebar, UITab tab)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var tabBarController__handle__ = tabBarController!.GetNonNullHandle (nameof (tabBarController));
			var sidebar__handle__ = sidebar!.GetNonNullHandle (nameof (sidebar));
			var tab__handle__ = tab!.GetNonNullHandle (nameof (tab));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("tabBarController:sidebar:willBeginDisplayingTab:"), tabBarController__handle__, sidebar__handle__, tab__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (tabBarController);
			GC.KeepAlive (sidebar);
			GC.KeepAlive (tab);
		}
		[global::Foundation.OptionalMember]
		[Export ("tabBarController:sidebar:didEndDisplayingTab:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidEndDisplayingTab (UITabBarController tabBarController, UITabBarControllerSidebar sidebar, UITab tab)
		{
			_DidEndDisplayingTab (this, tabBarController, sidebar, tab);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidEndDisplayingTab (IUITabBarControllerSidebarDelegate This, UITabBarController tabBarController, UITabBarControllerSidebar sidebar, UITab tab)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var tabBarController__handle__ = tabBarController!.GetNonNullHandle (nameof (tabBarController));
			var sidebar__handle__ = sidebar!.GetNonNullHandle (nameof (sidebar));
			var tab__handle__ = tab!.GetNonNullHandle (nameof (tab));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("tabBarController:sidebar:didEndDisplayingTab:"), tabBarController__handle__, sidebar__handle__, tab__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (tabBarController);
			GC.KeepAlive (sidebar);
			GC.KeepAlive (tab);
		}
		[global::Foundation.OptionalMember]
		[Export ("tabBarController:sidebar:leadingSwipeActionsConfigurationForTab:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UISwipeActionsConfiguration? GetLeadingSwipeActionsConfigurationForTab (UITabBarController tabBarController, UITabBarControllerSidebar sidebar, UITab tab)
		{
			return _GetLeadingSwipeActionsConfigurationForTab (this, tabBarController, sidebar, tab);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static UISwipeActionsConfiguration? _GetLeadingSwipeActionsConfigurationForTab (IUITabBarControllerSidebarDelegate This, UITabBarController tabBarController, UITabBarControllerSidebar sidebar, UITab tab)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var tabBarController__handle__ = tabBarController!.GetNonNullHandle (nameof (tabBarController));
			var sidebar__handle__ = sidebar!.GetNonNullHandle (nameof (sidebar));
			var tab__handle__ = tab!.GetNonNullHandle (nameof (tab));
			UISwipeActionsConfiguration? ret;
			ret =  Runtime.GetNSObject<UISwipeActionsConfiguration> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("tabBarController:sidebar:leadingSwipeActionsConfigurationForTab:"), tabBarController__handle__, sidebar__handle__, tab__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tabBarController);
			GC.KeepAlive (sidebar);
			GC.KeepAlive (tab);
			return ret!;
		}
		[global::Foundation.OptionalMember]
		[Export ("tabBarController:sidebar:trailingSwipeActionsConfigurationForTab:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UISwipeActionsConfiguration? GetTrailingSwipeActionsConfigurationForTab (UITabBarController tabBarController, UITabBarControllerSidebar sidebar, UITab tab)
		{
			return _GetTrailingSwipeActionsConfigurationForTab (this, tabBarController, sidebar, tab);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static UISwipeActionsConfiguration? _GetTrailingSwipeActionsConfigurationForTab (IUITabBarControllerSidebarDelegate This, UITabBarController tabBarController, UITabBarControllerSidebar sidebar, UITab tab)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var tabBarController__handle__ = tabBarController!.GetNonNullHandle (nameof (tabBarController));
			var sidebar__handle__ = sidebar!.GetNonNullHandle (nameof (sidebar));
			var tab__handle__ = tab!.GetNonNullHandle (nameof (tab));
			UISwipeActionsConfiguration? ret;
			ret =  Runtime.GetNSObject<UISwipeActionsConfiguration> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("tabBarController:sidebar:trailingSwipeActionsConfigurationForTab:"), tabBarController__handle__, sidebar__handle__, tab__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tabBarController);
			GC.KeepAlive (sidebar);
			GC.KeepAlive (tab);
			return ret!;
		}
		[global::Foundation.OptionalMember]
		[Export ("tabBarController:sidebar:contextMenuConfigurationForTab:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIContextMenuConfiguration? GetContextMenuConfigurationForTab (UITabBarController tabBarController, UITabBarControllerSidebar sidebar, UITab tab)
		{
			return _GetContextMenuConfigurationForTab (this, tabBarController, sidebar, tab);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static UIContextMenuConfiguration? _GetContextMenuConfigurationForTab (IUITabBarControllerSidebarDelegate This, UITabBarController tabBarController, UITabBarControllerSidebar sidebar, UITab tab)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var tabBarController__handle__ = tabBarController!.GetNonNullHandle (nameof (tabBarController));
			var sidebar__handle__ = sidebar!.GetNonNullHandle (nameof (sidebar));
			var tab__handle__ = tab!.GetNonNullHandle (nameof (tab));
			UIContextMenuConfiguration? ret;
			ret =  Runtime.GetNSObject<UIContextMenuConfiguration> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("tabBarController:sidebar:contextMenuConfigurationForTab:"), tabBarController__handle__, sidebar__handle__, tab__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tabBarController);
			GC.KeepAlive (sidebar);
			GC.KeepAlive (tab);
			return ret!;
		}
		[global::Foundation.OptionalMember]
		[Export ("tabBarController:sidebar:itemsForBeginningDragSession:tab:")]
		[SupportedOSPlatform ("ios18.4")]
		[SupportedOSPlatform ("maccatalyst18.4")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIDragItem[] GetItemsForBeginningDragSession (UITabBarController tabBarController, UITabBarControllerSidebar sidebar, IUIDragSession dragSession, UITab tab)
		{
			return _GetItemsForBeginningDragSession (this, tabBarController, sidebar, dragSession, tab);
		}
		[SupportedOSPlatform ("ios18.4")]
		[SupportedOSPlatform ("maccatalyst18.4")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static UIDragItem[] _GetItemsForBeginningDragSession (IUITabBarControllerSidebarDelegate This, UITabBarController tabBarController, UITabBarControllerSidebar sidebar, IUIDragSession dragSession, UITab tab)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var tabBarController__handle__ = tabBarController!.GetNonNullHandle (nameof (tabBarController));
			var sidebar__handle__ = sidebar!.GetNonNullHandle (nameof (sidebar));
			var dragSession__handle__ = dragSession!.GetNonNullHandle (nameof (dragSession));
			var tab__handle__ = tab!.GetNonNullHandle (nameof (tab));
			UIDragItem[]? ret;
			ret = CFArray.ArrayFromHandle<UIDragItem>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("tabBarController:sidebar:itemsForBeginningDragSession:tab:"), tabBarController__handle__, sidebar__handle__, dragSession__handle__, tab__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tabBarController);
			GC.KeepAlive (sidebar);
			GC.KeepAlive (dragSession);
			GC.KeepAlive (tab);
			return ret!;
		}
		[global::Foundation.OptionalMember]
		[Export ("tabBarController:sidebar:itemsForAddingToDragSession:tab:")]
		[SupportedOSPlatform ("ios18.4")]
		[SupportedOSPlatform ("maccatalyst18.4")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIDragItem[] GetItemsForAddingToDragSession (UITabBarController tabBarController, UITabBarControllerSidebar sidebar, IUIDragSession dragSession, UITab tab)
		{
			return _GetItemsForAddingToDragSession (this, tabBarController, sidebar, dragSession, tab);
		}
		[SupportedOSPlatform ("ios18.4")]
		[SupportedOSPlatform ("maccatalyst18.4")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static UIDragItem[] _GetItemsForAddingToDragSession (IUITabBarControllerSidebarDelegate This, UITabBarController tabBarController, UITabBarControllerSidebar sidebar, IUIDragSession dragSession, UITab tab)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var tabBarController__handle__ = tabBarController!.GetNonNullHandle (nameof (tabBarController));
			var sidebar__handle__ = sidebar!.GetNonNullHandle (nameof (sidebar));
			var dragSession__handle__ = dragSession!.GetNonNullHandle (nameof (dragSession));
			var tab__handle__ = tab!.GetNonNullHandle (nameof (tab));
			UIDragItem[]? ret;
			ret = CFArray.ArrayFromHandle<UIDragItem>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("tabBarController:sidebar:itemsForAddingToDragSession:tab:"), tabBarController__handle__, sidebar__handle__, dragSession__handle__, tab__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tabBarController);
			GC.KeepAlive (sidebar);
			GC.KeepAlive (dragSession);
			GC.KeepAlive (tab);
			return ret!;
		}
		[global::Foundation.OptionalMember]
		[Export ("tabBarController:sidebar:sidebarAction:group:operationForAcceptingItemsFromDropSession:")]
		[SupportedOSPlatform ("ios18.4")]
		[SupportedOSPlatform ("maccatalyst18.4")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIDropOperation GetOperationForAcceptingItemsFromDropSession (UITabBarController tabBarController, UITabBarControllerSidebar sidebar, UIAction sidebarAction, UITabGroup group, IUIDropSession session)
		{
			return _GetOperationForAcceptingItemsFromDropSession (this, tabBarController, sidebar, sidebarAction, group, session);
		}
		[SupportedOSPlatform ("ios18.4")]
		[SupportedOSPlatform ("maccatalyst18.4")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static UIDropOperation _GetOperationForAcceptingItemsFromDropSession (IUITabBarControllerSidebarDelegate This, UITabBarController tabBarController, UITabBarControllerSidebar sidebar, UIAction sidebarAction, UITabGroup group, IUIDropSession session)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var tabBarController__handle__ = tabBarController!.GetNonNullHandle (nameof (tabBarController));
			var sidebar__handle__ = sidebar!.GetNonNullHandle (nameof (sidebar));
			var sidebarAction__handle__ = sidebarAction!.GetNonNullHandle (nameof (sidebarAction));
			var group__handle__ = group!.GetNonNullHandle (nameof (group));
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			UIDropOperation ret;
			ret = (UIDropOperation) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("tabBarController:sidebar:sidebarAction:group:operationForAcceptingItemsFromDropSession:"), tabBarController__handle__, sidebar__handle__, sidebarAction__handle__, group__handle__, session__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (tabBarController);
			GC.KeepAlive (sidebar);
			GC.KeepAlive (sidebarAction);
			GC.KeepAlive (group);
			GC.KeepAlive (session);
			return ret!;
		}
		[global::Foundation.OptionalMember]
		[Export ("tabBarController:sidebar:sidebarAction:group:acceptItemsFromDropSession:")]
		[SupportedOSPlatform ("ios18.4")]
		[SupportedOSPlatform ("maccatalyst18.4")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AcceptItemsFromDropSession (UITabBarController tabBarController, UITabBarControllerSidebar sidebar, UIAction sidebarAction, UITabGroup group, IUIDropSession session)
		{
			_AcceptItemsFromDropSession (this, tabBarController, sidebar, sidebarAction, group, session);
		}
		[SupportedOSPlatform ("ios18.4")]
		[SupportedOSPlatform ("maccatalyst18.4")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _AcceptItemsFromDropSession (IUITabBarControllerSidebarDelegate This, UITabBarController tabBarController, UITabBarControllerSidebar sidebar, UIAction sidebarAction, UITabGroup group, IUIDropSession session)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var tabBarController__handle__ = tabBarController!.GetNonNullHandle (nameof (tabBarController));
			var sidebar__handle__ = sidebar!.GetNonNullHandle (nameof (sidebar));
			var sidebarAction__handle__ = sidebarAction!.GetNonNullHandle (nameof (sidebarAction));
			var group__handle__ = group!.GetNonNullHandle (nameof (group));
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("tabBarController:sidebar:sidebarAction:group:acceptItemsFromDropSession:"), tabBarController__handle__, sidebar__handle__, sidebarAction__handle__, group__handle__, session__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (tabBarController);
			GC.KeepAlive (sidebar);
			GC.KeepAlive (sidebarAction);
			GC.KeepAlive (group);
			GC.KeepAlive (session);
		}
		[DynamicDependencyAttribute ("AcceptItemsFromDropSession(UIKit.UITabBarController,UIKit.UITabBarControllerSidebar,UIKit.UIAction,UIKit.UITabGroup,UIKit.IUIDropSession)")]
		[DynamicDependencyAttribute ("DidEndDisplayingTab(UIKit.UITabBarController,UIKit.UITabBarControllerSidebar,UIKit.UITab)")]
		[DynamicDependencyAttribute ("GetContextMenuConfigurationForTab(UIKit.UITabBarController,UIKit.UITabBarControllerSidebar,UIKit.UITab)")]
		[DynamicDependencyAttribute ("GetItemForRequest(UIKit.UITabBarController,UIKit.UITabBarControllerSidebar,UIKit.UITabSidebarItemRequest)")]
		[DynamicDependencyAttribute ("GetItemsForAddingToDragSession(UIKit.UITabBarController,UIKit.UITabBarControllerSidebar,UIKit.IUIDragSession,UIKit.UITab)")]
		[DynamicDependencyAttribute ("GetItemsForBeginningDragSession(UIKit.UITabBarController,UIKit.UITabBarControllerSidebar,UIKit.IUIDragSession,UIKit.UITab)")]
		[DynamicDependencyAttribute ("GetLeadingSwipeActionsConfigurationForTab(UIKit.UITabBarController,UIKit.UITabBarControllerSidebar,UIKit.UITab)")]
		[DynamicDependencyAttribute ("GetOperationForAcceptingItemsFromDropSession(UIKit.UITabBarController,UIKit.UITabBarControllerSidebar,UIKit.UIAction,UIKit.UITabGroup,UIKit.IUIDropSession)")]
		[DynamicDependencyAttribute ("GetTrailingSwipeActionsConfigurationForTab(UIKit.UITabBarController,UIKit.UITabBarControllerSidebar,UIKit.UITab)")]
		[DynamicDependencyAttribute ("SidebarVisibilityWillChange(UIKit.UITabBarController,UIKit.UITabBarControllerSidebar,UIKit.IUITabBarControllerSidebarAnimating)")]
		[DynamicDependencyAttribute ("UpdateItem(UIKit.UITabBarController,UIKit.UITabBarControllerSidebar,UIKit.UITabSidebarItem)")]
		[DynamicDependencyAttribute ("WillBeginDisplayingTab(UIKit.UITabBarController,UIKit.UITabBarControllerSidebar,UIKit.UITab)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UITabBarControllerSidebarDelegateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IUITabBarControllerSidebarDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class UITabBarControllerSidebarDelegateWrapper : BaseWrapper, IUITabBarControllerSidebarDelegate {
		public UITabBarControllerSidebarDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UITabBarControllerSidebarDelegateWrapper))]
		static UITabBarControllerSidebarDelegateWrapper ()
		{
			GC.KeepAlive (null);
		}
	}
}
namespace UIKit {
	/// <summary>
	///   <para>This is a class that implements the interface <see cref="IUITabBarControllerSidebarDelegate" /> (for the protocol <c>UITabBarControllerSidebarDelegate</c>).</para>
	///   <para>Subclass this class to easily create a type that implements the protocol.</para>
	///   <para>An alternative is to create a subclass of <see cref="NSObject" /> and then implemented the interface <see cref="IUITabBarControllerSidebarDelegate" />.</para>
	/// </summary>
	[Protocol()]
	[Register("Microsoft_MacCatalyst__UIKit_UITabBarControllerSidebarDelegate", false)]
	[Model]
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("ios18.0")]
	[SupportedOSPlatform ("maccatalyst18.0")]
	public unsafe partial class UITabBarControllerSidebarDelegate : NSObject, IUITabBarControllerSidebarDelegate {
		/// <summary>Creates a new <see cref="UITabBarControllerSidebarDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public UITabBarControllerSidebarDelegate () : base (NSObjectFlag.Empty)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
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
		protected UITabBarControllerSidebarDelegate (NSObjectFlag t) : base (t)
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
		protected internal UITabBarControllerSidebarDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		[Export ("tabBarController:sidebar:sidebarAction:group:acceptItemsFromDropSession:")]
		[SupportedOSPlatform ("ios18.4")]
		[SupportedOSPlatform ("maccatalyst18.4")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AcceptItemsFromDropSession (UITabBarController tabBarController, UITabBarControllerSidebar sidebar, UIAction sidebarAction, UITabGroup group, IUIDropSession session)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("tabBarController:sidebar:didEndDisplayingTab:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidEndDisplayingTab (UITabBarController tabBarController, UITabBarControllerSidebar sidebar, UITab tab)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("tabBarController:sidebar:contextMenuConfigurationForTab:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIContextMenuConfiguration? GetContextMenuConfigurationForTab (UITabBarController tabBarController, UITabBarControllerSidebar sidebar, UITab tab)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("tabBarController:sidebar:itemForRequest:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UITabSidebarItem GetItemForRequest (UITabBarController tabBarController, UITabBarControllerSidebar sidebar, UITabSidebarItemRequest request)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("tabBarController:sidebar:itemsForAddingToDragSession:tab:")]
		[SupportedOSPlatform ("ios18.4")]
		[SupportedOSPlatform ("maccatalyst18.4")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIDragItem[] GetItemsForAddingToDragSession (UITabBarController tabBarController, UITabBarControllerSidebar sidebar, IUIDragSession dragSession, UITab tab)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("tabBarController:sidebar:itemsForBeginningDragSession:tab:")]
		[SupportedOSPlatform ("ios18.4")]
		[SupportedOSPlatform ("maccatalyst18.4")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIDragItem[] GetItemsForBeginningDragSession (UITabBarController tabBarController, UITabBarControllerSidebar sidebar, IUIDragSession dragSession, UITab tab)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("tabBarController:sidebar:leadingSwipeActionsConfigurationForTab:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UISwipeActionsConfiguration? GetLeadingSwipeActionsConfigurationForTab (UITabBarController tabBarController, UITabBarControllerSidebar sidebar, UITab tab)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("tabBarController:sidebar:sidebarAction:group:operationForAcceptingItemsFromDropSession:")]
		[SupportedOSPlatform ("ios18.4")]
		[SupportedOSPlatform ("maccatalyst18.4")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIDropOperation GetOperationForAcceptingItemsFromDropSession (UITabBarController tabBarController, UITabBarControllerSidebar sidebar, UIAction sidebarAction, UITabGroup group, IUIDropSession session)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("tabBarController:sidebar:trailingSwipeActionsConfigurationForTab:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UISwipeActionsConfiguration? GetTrailingSwipeActionsConfigurationForTab (UITabBarController tabBarController, UITabBarControllerSidebar sidebar, UITab tab)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("tabBarController:sidebarVisibilityWillChange:animator:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SidebarVisibilityWillChange (UITabBarController tabBarController, UITabBarControllerSidebar sidebar, IUITabBarControllerSidebarAnimating animator)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("tabBarController:sidebar:updateItem:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void UpdateItem (UITabBarController tabBarController, UITabBarControllerSidebar sidebar, UITabSidebarItem item)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("tabBarController:sidebar:willBeginDisplayingTab:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillBeginDisplayingTab (UITabBarController tabBarController, UITabBarControllerSidebar sidebar, UITab tab)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class UITabBarControllerSidebarDelegate */
}
