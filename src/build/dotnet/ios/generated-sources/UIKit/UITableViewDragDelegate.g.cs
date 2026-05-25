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
	/// <summary>Interface for a drag operation that started from a table view.</summary>
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[Protocol (Name = "UITableViewDragDelegate", WrapperType = typeof (UITableViewDragDelegateWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetItemsForBeginningDragSession", Selector = "tableView:itemsForBeginningDragSession:atIndexPath:", ReturnType = typeof (UIDragItem[]), ParameterType = new Type [] { typeof (UITableView), typeof (IUIDragSession), typeof (NSIndexPath) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetItemsForAddingToDragSession", Selector = "tableView:itemsForAddingToDragSession:atIndexPath:point:", ReturnType = typeof (UIDragItem[]), ParameterType = new Type [] { typeof (UITableView), typeof (IUIDragSession), typeof (NSIndexPath), typeof (CGPoint) }, ParameterByRef = new bool [] { false, false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetDragPreviewParameters", Selector = "tableView:dragPreviewParametersForRowAtIndexPath:", ReturnType = typeof (UIDragPreviewParameters), ParameterType = new Type [] { typeof (UITableView), typeof (NSIndexPath) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DragSessionWillBegin", Selector = "tableView:dragSessionWillBegin:", ParameterType = new Type [] { typeof (UITableView), typeof (IUIDragSession) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DragSessionDidEnd", Selector = "tableView:dragSessionDidEnd:", ParameterType = new Type [] { typeof (UITableView), typeof (IUIDragSession) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DragSessionAllowsMoveOperation", Selector = "tableView:dragSessionAllowsMoveOperation:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (UITableView), typeof (IUIDragSession) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DragSessionIsRestrictedToDraggingApplication", Selector = "tableView:dragSessionIsRestrictedToDraggingApplication:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (UITableView), typeof (IUIDragSession) }, ParameterByRef = new bool [] { false, false })]
	public partial interface IUITableViewDragDelegate : INativeObject, IDisposable
	{
		/// <param name="tableView">The originating table view.</param><param name="session">The session to which to add the items.</param><param name="indexPath">The index path to the dragged row.</param><summary>Returns a list of any items that are present at the beginning of a drag session.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("tableView:itemsForBeginningDragSession:atIndexPath:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIDragItem[] GetItemsForBeginningDragSession (UITableView tableView, IUIDragSession session, NSIndexPath indexPath)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="tableView">The originating table view.</param><param name="session">The session to which to add the items.</param><param name="indexPath">The index path to the dragged row.</param><summary>Returns a list of any items that are present at the beginning of a drag session.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static UIDragItem[] _GetItemsForBeginningDragSession (IUITableViewDragDelegate This, UITableView tableView, IUIDragSession session, NSIndexPath indexPath)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			var indexPath__handle__ = indexPath!.GetNonNullHandle (nameof (indexPath));
			UIDragItem[]? ret;
			ret = CFArray.ArrayFromHandle<UIDragItem>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("tableView:itemsForBeginningDragSession:atIndexPath:"), tableView__handle__, session__handle__, indexPath__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tableView);
			GC.KeepAlive (session);
			GC.KeepAlive (indexPath);
			return ret!;
		}
		/// <param name="tableView">The originating table view.</param><param name="session">The session to which to add the items.</param><param name="indexPath">The index path to the added row.</param><param name="point">The point, in the table view's coordinate system, of the user's touch.</param><summary>Adds the items at the index path to the drag session.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("tableView:itemsForAddingToDragSession:atIndexPath:point:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIDragItem[] GetItemsForAddingToDragSession (UITableView tableView, IUIDragSession session, NSIndexPath indexPath, CGPoint point)
		{
			return _GetItemsForAddingToDragSession (this, tableView, session, indexPath, point);
		}
		/// <param name="tableView">The originating table view.</param><param name="session">The session to which to add the items.</param><param name="indexPath">The index path to the added row.</param><param name="point">The point, in the table view's coordinate system, of the user's touch.</param><summary>Adds the items at the index path to the drag session.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static UIDragItem[] _GetItemsForAddingToDragSession (IUITableViewDragDelegate This, UITableView tableView, IUIDragSession session, NSIndexPath indexPath, CGPoint point)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			var indexPath__handle__ = indexPath!.GetNonNullHandle (nameof (indexPath));
			UIDragItem[]? ret;
			ret = CFArray.ArrayFromHandle<UIDragItem>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_CGPoint (This.Handle, Selector.GetHandle ("tableView:itemsForAddingToDragSession:atIndexPath:point:"), tableView__handle__, session__handle__, indexPath__handle__, point), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tableView);
			GC.KeepAlive (session);
			GC.KeepAlive (indexPath);
			return ret!;
		}
		/// <param name="tableView">The table view for which to get drag preview parameters.</param><param name="indexPath">The index path to the row for which to get drag preview parameters.</param><summary>Gets the preview parameters for the item at the specified index path.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("tableView:dragPreviewParametersForRowAtIndexPath:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIDragPreviewParameters? GetDragPreviewParameters (UITableView tableView, NSIndexPath indexPath)
		{
			return _GetDragPreviewParameters (this, tableView, indexPath);
		}
		/// <param name="tableView">The table view for which to get drag preview parameters.</param><param name="indexPath">The index path to the row for which to get drag preview parameters.</param><summary>Gets the preview parameters for the item at the specified index path.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static UIDragPreviewParameters? _GetDragPreviewParameters (IUITableViewDragDelegate This, UITableView tableView, NSIndexPath indexPath)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			var indexPath__handle__ = indexPath!.GetNonNullHandle (nameof (indexPath));
			UIDragPreviewParameters? ret;
			ret =  Runtime.GetNSObject<UIDragPreviewParameters> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("tableView:dragPreviewParametersForRowAtIndexPath:"), tableView__handle__, indexPath__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tableView);
			GC.KeepAlive (indexPath);
			return ret!;
		}
		/// <param name="tableView">The originating table view.</param><param name="session">The session that will begin.</param><summary>Method that is called just before a drag session begins.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("tableView:dragSessionWillBegin:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DragSessionWillBegin (UITableView tableView, IUIDragSession session)
		{
			_DragSessionWillBegin (this, tableView, session);
		}
		/// <param name="tableView">The originating table view.</param><param name="session">The session that will begin.</param><summary>Method that is called just before a drag session begins.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DragSessionWillBegin (IUITableViewDragDelegate This, UITableView tableView, IUIDragSession session)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("tableView:dragSessionWillBegin:"), tableView__handle__, session__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (tableView);
			GC.KeepAlive (session);
		}
		/// <param name="tableView">The originating table view.</param><param name="session">The session that ended.</param><summary>Method that is called when the user cancels or completes the drag session.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("tableView:dragSessionDidEnd:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DragSessionDidEnd (UITableView tableView, IUIDragSession session)
		{
			_DragSessionDidEnd (this, tableView, session);
		}
		/// <param name="tableView">The originating table view.</param><param name="session">The session that ended.</param><summary>Method that is called when the user cancels or completes the drag session.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DragSessionDidEnd (IUITableViewDragDelegate This, UITableView tableView, IUIDragSession session)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("tableView:dragSessionDidEnd:"), tableView__handle__, session__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (tableView);
			GC.KeepAlive (session);
		}
		/// <param name="tableView">To be added.</param><param name="session">To be added.</param><summary>Whether the drag session can move items within the developer's app.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("tableView:dragSessionAllowsMoveOperation:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool DragSessionAllowsMoveOperation (UITableView tableView, IUIDragSession session)
		{
			return _DragSessionAllowsMoveOperation (this, tableView, session);
		}
		/// <param name="tableView">To be added.</param><param name="session">To be added.</param><summary>Whether the drag session can move items within the developer's app.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _DragSessionAllowsMoveOperation (IUITableViewDragDelegate This, UITableView tableView, IUIDragSession session)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("tableView:dragSessionAllowsMoveOperation:"), tableView__handle__, session__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (tableView);
			GC.KeepAlive (session);
			return ret != 0;
		}
		/// <param name="tableView">To be added.</param><param name="session">To be added.</param><summary>Gets whether the drag session may only act within the developer's app.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("tableView:dragSessionIsRestrictedToDraggingApplication:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool DragSessionIsRestrictedToDraggingApplication (UITableView tableView, IUIDragSession session)
		{
			return _DragSessionIsRestrictedToDraggingApplication (this, tableView, session);
		}
		/// <param name="tableView">To be added.</param><param name="session">To be added.</param><summary>Gets whether the drag session may only act within the developer's app.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _DragSessionIsRestrictedToDraggingApplication (IUITableViewDragDelegate This, UITableView tableView, IUIDragSession session)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("tableView:dragSessionIsRestrictedToDraggingApplication:"), tableView__handle__, session__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (tableView);
			GC.KeepAlive (session);
			return ret != 0;
		}
		[DynamicDependencyAttribute ("DragSessionAllowsMoveOperation(UIKit.UITableView,UIKit.IUIDragSession)")]
		[DynamicDependencyAttribute ("DragSessionDidEnd(UIKit.UITableView,UIKit.IUIDragSession)")]
		[DynamicDependencyAttribute ("DragSessionIsRestrictedToDraggingApplication(UIKit.UITableView,UIKit.IUIDragSession)")]
		[DynamicDependencyAttribute ("DragSessionWillBegin(UIKit.UITableView,UIKit.IUIDragSession)")]
		[DynamicDependencyAttribute ("GetDragPreviewParameters(UIKit.UITableView,Foundation.NSIndexPath)")]
		[DynamicDependencyAttribute ("GetItemsForAddingToDragSession(UIKit.UITableView,UIKit.IUIDragSession,Foundation.NSIndexPath,CoreGraphics.CGPoint)")]
		[DynamicDependencyAttribute ("GetItemsForBeginningDragSession(UIKit.UITableView,UIKit.IUIDragSession,Foundation.NSIndexPath)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UITableViewDragDelegateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IUITableViewDragDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="IUITableViewDragDelegate" /> interface to support all the methods from the UITableViewDragDelegate protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IUITableViewDragDelegate" /> interface allow developers to treat instances of the interface as having all the optional methods of the original UITableViewDragDelegate protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class UITableViewDragDelegate_Extensions {
		/// <param name="tableView">The originating table view.</param><param name="session">The session to which to add the items.</param><param name="indexPath">The index path to the added row.</param><param name="point">The point, in the table view's coordinate system, of the user's touch.</param><summary>Adds the items at the index path to the drag session.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static UIDragItem[] GetItemsForAddingToDragSession (this IUITableViewDragDelegate This, UITableView tableView, IUIDragSession session, NSIndexPath indexPath, CGPoint point)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			var indexPath__handle__ = indexPath!.GetNonNullHandle (nameof (indexPath));
			UIDragItem[]? ret;
			ret = CFArray.ArrayFromHandle<UIDragItem>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_CGPoint (This.Handle, Selector.GetHandle ("tableView:itemsForAddingToDragSession:atIndexPath:point:"), tableView__handle__, session__handle__, indexPath__handle__, point), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tableView);
			GC.KeepAlive (session);
			GC.KeepAlive (indexPath);
			return ret!;
		}
		/// <param name="tableView">The table view for which to get drag preview parameters.</param><param name="indexPath">The index path to the row for which to get drag preview parameters.</param><summary>Gets the preview parameters for the item at the specified index path.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static UIDragPreviewParameters? GetDragPreviewParameters (this IUITableViewDragDelegate This, UITableView tableView, NSIndexPath indexPath)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			var indexPath__handle__ = indexPath!.GetNonNullHandle (nameof (indexPath));
			UIDragPreviewParameters? ret;
			ret =  Runtime.GetNSObject<UIDragPreviewParameters> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("tableView:dragPreviewParametersForRowAtIndexPath:"), tableView__handle__, indexPath__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tableView);
			GC.KeepAlive (indexPath);
			return ret!;
		}
		/// <param name="tableView">The originating table view.</param><param name="session">The session that will begin.</param><summary>Method that is called just before a drag session begins.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DragSessionWillBegin (this IUITableViewDragDelegate This, UITableView tableView, IUIDragSession session)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("tableView:dragSessionWillBegin:"), tableView__handle__, session__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (tableView);
			GC.KeepAlive (session);
		}
		/// <param name="tableView">The originating table view.</param><param name="session">The session that ended.</param><summary>Method that is called when the user cancels or completes the drag session.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DragSessionDidEnd (this IUITableViewDragDelegate This, UITableView tableView, IUIDragSession session)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("tableView:dragSessionDidEnd:"), tableView__handle__, session__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (tableView);
			GC.KeepAlive (session);
		}
		/// <param name="tableView">To be added.</param><param name="session">To be added.</param><summary>Whether the drag session can move items within the developer's app.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool DragSessionAllowsMoveOperation (this IUITableViewDragDelegate This, UITableView tableView, IUIDragSession session)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("tableView:dragSessionAllowsMoveOperation:"), tableView__handle__, session__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (tableView);
			GC.KeepAlive (session);
			return ret != 0;
		}
		/// <param name="tableView">To be added.</param><param name="session">To be added.</param><summary>Gets whether the drag session may only act within the developer's app.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool DragSessionIsRestrictedToDraggingApplication (this IUITableViewDragDelegate This, UITableView tableView, IUIDragSession session)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("tableView:dragSessionIsRestrictedToDraggingApplication:"), tableView__handle__, session__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (tableView);
			GC.KeepAlive (session);
			return ret != 0;
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class UITableViewDragDelegateWrapper : BaseWrapper, IUITableViewDragDelegate {
		public UITableViewDragDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UITableViewDragDelegateWrapper))]
		static UITableViewDragDelegateWrapper ()
		{
			GC.KeepAlive (null);
		}
		/// <param name="tableView">The originating table view.</param><param name="session">The session to which to add the items.</param><param name="indexPath">The index path to the dragged row.</param><summary>Returns a list of any items that are present at the beginning of a drag session.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("tableView:itemsForBeginningDragSession:atIndexPath:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public UIDragItem[] GetItemsForBeginningDragSession (UITableView tableView, IUIDragSession session, NSIndexPath indexPath)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			var indexPath__handle__ = indexPath!.GetNonNullHandle (nameof (indexPath));
			UIDragItem[]? ret;
			ret = CFArray.ArrayFromHandle<UIDragItem>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("tableView:itemsForBeginningDragSession:atIndexPath:"), tableView__handle__, session__handle__, indexPath__handle__), false)!;
			GC.KeepAlive (tableView);
			GC.KeepAlive (session);
			GC.KeepAlive (indexPath);
			return ret!;
		}
	}
}
namespace UIKit {
	/// <summary>Interface for a drag operation that started from a table view.</summary>
	[Protocol()]
	[Register("Microsoft_iOS__UIKit_UITableViewDragDelegate", false)]
	[Model]
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	public unsafe abstract partial class UITableViewDragDelegate : NSObject, IUITableViewDragDelegate {
		/// <summary>Creates a new <see cref="UITableViewDragDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected UITableViewDragDelegate () : base (NSObjectFlag.Empty)
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
		protected UITableViewDragDelegate (NSObjectFlag t) : base (t)
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
		protected internal UITableViewDragDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		/// <param name="tableView">To be added.</param><param name="session">To be added.</param><summary>Whether the drag session can move items within the developer's app.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("tableView:dragSessionAllowsMoveOperation:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool DragSessionAllowsMoveOperation (UITableView tableView, IUIDragSession session)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="tableView">The originating table view.</param><param name="session">The session that ended.</param><summary>Method that is called when the user cancels or completes the drag session.</summary><remarks>To be added.</remarks>
		[Export ("tableView:dragSessionDidEnd:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DragSessionDidEnd (UITableView tableView, IUIDragSession session)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="tableView">To be added.</param><param name="session">To be added.</param><summary>Gets whether the drag session may only act within the developer's app.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("tableView:dragSessionIsRestrictedToDraggingApplication:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool DragSessionIsRestrictedToDraggingApplication (UITableView tableView, IUIDragSession session)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="tableView">The originating table view.</param><param name="session">The session that will begin.</param><summary>Method that is called just before a drag session begins.</summary><remarks>To be added.</remarks>
		[Export ("tableView:dragSessionWillBegin:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DragSessionWillBegin (UITableView tableView, IUIDragSession session)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="tableView">The table view for which to get drag preview parameters.</param><param name="indexPath">The index path to the row for which to get drag preview parameters.</param><summary>Gets the preview parameters for the item at the specified index path.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("tableView:dragPreviewParametersForRowAtIndexPath:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIDragPreviewParameters? GetDragPreviewParameters (UITableView tableView, NSIndexPath indexPath)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="tableView">The originating table view.</param><param name="session">The session to which to add the items.</param><param name="indexPath">The index path to the added row.</param><param name="point">The point, in the table view's coordinate system, of the user's touch.</param><summary>Adds the items at the index path to the drag session.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("tableView:itemsForAddingToDragSession:atIndexPath:point:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIDragItem[] GetItemsForAddingToDragSession (UITableView tableView, IUIDragSession session, NSIndexPath indexPath, CGPoint point)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="tableView">The originating table view.</param><param name="session">The session to which to add the items.</param><param name="indexPath">The index path to the dragged row.</param><summary>Returns a list of any items that are present at the beginning of a drag session.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("tableView:itemsForBeginningDragSession:atIndexPath:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIDragItem[] GetItemsForBeginningDragSession (UITableView tableView, IUIDragSession session, NSIndexPath indexPath)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class UITableViewDragDelegate */
}
