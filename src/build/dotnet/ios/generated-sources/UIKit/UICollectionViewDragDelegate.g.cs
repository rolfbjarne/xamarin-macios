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
	/// <summary>Interface for a drag operation that started from a collection view.</summary>
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[Protocol (Name = "UICollectionViewDragDelegate", WrapperType = typeof (UICollectionViewDragDelegateWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetItemsForBeginningDragSession", Selector = "collectionView:itemsForBeginningDragSession:atIndexPath:", ReturnType = typeof (UIDragItem[]), ParameterType = new Type [] { typeof (UICollectionView), typeof (IUIDragSession), typeof (NSIndexPath) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetItemsForAddingToDragSession", Selector = "collectionView:itemsForAddingToDragSession:atIndexPath:point:", ReturnType = typeof (UIDragItem[]), ParameterType = new Type [] { typeof (UICollectionView), typeof (IUIDragSession), typeof (NSIndexPath), typeof (CGPoint) }, ParameterByRef = new bool [] { false, false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetDragPreviewParameters", Selector = "collectionView:dragPreviewParametersForItemAtIndexPath:", ReturnType = typeof (UIDragPreviewParameters), ParameterType = new Type [] { typeof (UICollectionView), typeof (NSIndexPath) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DragSessionWillBegin", Selector = "collectionView:dragSessionWillBegin:", ParameterType = new Type [] { typeof (UICollectionView), typeof (IUIDragSession) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DragSessionDidEnd", Selector = "collectionView:dragSessionDidEnd:", ParameterType = new Type [] { typeof (UICollectionView), typeof (IUIDragSession) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DragSessionAllowsMoveOperation", Selector = "collectionView:dragSessionAllowsMoveOperation:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (UICollectionView), typeof (IUIDragSession) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DragSessionIsRestrictedToDraggingApplication", Selector = "collectionView:dragSessionIsRestrictedToDraggingApplication:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (UICollectionView), typeof (IUIDragSession) }, ParameterByRef = new bool [] { false, false })]
	public partial interface IUICollectionViewDragDelegate : INativeObject, IDisposable
	{
		/// <param name="collectionView">The originating collection view.</param><param name="session">The drag session to which to add items.</param><param name="indexPath">The index path to the item.</param><summary>Returns the items that were used to begin the drag operation, if present.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("collectionView:itemsForBeginningDragSession:atIndexPath:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIDragItem[] GetItemsForBeginningDragSession (UICollectionView collectionView, IUIDragSession session, NSIndexPath indexPath)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="collectionView">The originating collection view.</param><param name="session">The drag session to which to add items.</param><param name="indexPath">The index path to the item.</param><summary>Returns the items that were used to begin the drag operation, if present.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static UIDragItem[] _GetItemsForBeginningDragSession (IUICollectionViewDragDelegate This, UICollectionView collectionView, IUIDragSession session, NSIndexPath indexPath)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var collectionView__handle__ = collectionView!.GetNonNullHandle (nameof (collectionView));
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			var indexPath__handle__ = indexPath!.GetNonNullHandle (nameof (indexPath));
			UIDragItem[]? ret;
			ret = CFArray.ArrayFromHandle<UIDragItem>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("collectionView:itemsForBeginningDragSession:atIndexPath:"), collectionView__handle__, session__handle__, indexPath__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (collectionView);
			GC.KeepAlive (session);
			GC.KeepAlive (indexPath);
			return ret!;
		}
		/// <param name="collectionView">The originating collection view.</param><param name="session">The drag session to which to add items.</param><param name="indexPath">The index path to the item to add.</param><param name="point">The point that the user touched, in the collection view coordinate space.</param><summary>Adds the items at the index path to the drag session.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("collectionView:itemsForAddingToDragSession:atIndexPath:point:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIDragItem[] GetItemsForAddingToDragSession (UICollectionView collectionView, IUIDragSession session, NSIndexPath indexPath, CGPoint point)
		{
			return _GetItemsForAddingToDragSession (this, collectionView, session, indexPath, point);
		}
		/// <param name="collectionView">The originating collection view.</param><param name="session">The drag session to which to add items.</param><param name="indexPath">The index path to the item to add.</param><param name="point">The point that the user touched, in the collection view coordinate space.</param><summary>Adds the items at the index path to the drag session.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static UIDragItem[] _GetItemsForAddingToDragSession (IUICollectionViewDragDelegate This, UICollectionView collectionView, IUIDragSession session, NSIndexPath indexPath, CGPoint point)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var collectionView__handle__ = collectionView!.GetNonNullHandle (nameof (collectionView));
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			var indexPath__handle__ = indexPath!.GetNonNullHandle (nameof (indexPath));
			UIDragItem[]? ret;
			ret = CFArray.ArrayFromHandle<UIDragItem>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_CGPoint (This.Handle, Selector.GetHandle ("collectionView:itemsForAddingToDragSession:atIndexPath:point:"), collectionView__handle__, session__handle__, indexPath__handle__, point), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (collectionView);
			GC.KeepAlive (session);
			GC.KeepAlive (indexPath);
			return ret!;
		}
		/// <param name="collectionView">To be added.</param><param name="indexPath">To be added.</param><summary>Gets the preview parameters for the item at the specified index path.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("collectionView:dragPreviewParametersForItemAtIndexPath:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIDragPreviewParameters? GetDragPreviewParameters (UICollectionView collectionView, NSIndexPath indexPath)
		{
			return _GetDragPreviewParameters (this, collectionView, indexPath);
		}
		/// <param name="collectionView">To be added.</param><param name="indexPath">To be added.</param><summary>Gets the preview parameters for the item at the specified index path.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static UIDragPreviewParameters? _GetDragPreviewParameters (IUICollectionViewDragDelegate This, UICollectionView collectionView, NSIndexPath indexPath)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var collectionView__handle__ = collectionView!.GetNonNullHandle (nameof (collectionView));
			var indexPath__handle__ = indexPath!.GetNonNullHandle (nameof (indexPath));
			UIDragPreviewParameters? ret;
			ret =  Runtime.GetNSObject<UIDragPreviewParameters> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("collectionView:dragPreviewParametersForItemAtIndexPath:"), collectionView__handle__, indexPath__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (collectionView);
			GC.KeepAlive (indexPath);
			return ret!;
		}
		/// <param name="collectionView">The originating collection view.</param><param name="session">The session that is about to begin.</param><summary>Method that is called just before a drag session begins.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("collectionView:dragSessionWillBegin:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DragSessionWillBegin (UICollectionView collectionView, IUIDragSession session)
		{
			_DragSessionWillBegin (this, collectionView, session);
		}
		/// <param name="collectionView">The originating collection view.</param><param name="session">The session that is about to begin.</param><summary>Method that is called just before a drag session begins.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DragSessionWillBegin (IUICollectionViewDragDelegate This, UICollectionView collectionView, IUIDragSession session)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var collectionView__handle__ = collectionView!.GetNonNullHandle (nameof (collectionView));
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("collectionView:dragSessionWillBegin:"), collectionView__handle__, session__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (collectionView);
			GC.KeepAlive (session);
		}
		/// <param name="collectionView">The originating collection view.</param><param name="session">The session that is ending.</param><summary>Method that is called when the user cancels or completes the drag session.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("collectionView:dragSessionDidEnd:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DragSessionDidEnd (UICollectionView collectionView, IUIDragSession session)
		{
			_DragSessionDidEnd (this, collectionView, session);
		}
		/// <param name="collectionView">The originating collection view.</param><param name="session">The session that is ending.</param><summary>Method that is called when the user cancels or completes the drag session.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DragSessionDidEnd (IUICollectionViewDragDelegate This, UICollectionView collectionView, IUIDragSession session)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var collectionView__handle__ = collectionView!.GetNonNullHandle (nameof (collectionView));
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("collectionView:dragSessionDidEnd:"), collectionView__handle__, session__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (collectionView);
			GC.KeepAlive (session);
		}
		/// <param name="collectionView">To be added.</param><param name="session">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("collectionView:dragSessionAllowsMoveOperation:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool DragSessionAllowsMoveOperation (UICollectionView collectionView, IUIDragSession session)
		{
			return _DragSessionAllowsMoveOperation (this, collectionView, session);
		}
		/// <param name="collectionView">To be added.</param><param name="session">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _DragSessionAllowsMoveOperation (IUICollectionViewDragDelegate This, UICollectionView collectionView, IUIDragSession session)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var collectionView__handle__ = collectionView!.GetNonNullHandle (nameof (collectionView));
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("collectionView:dragSessionAllowsMoveOperation:"), collectionView__handle__, session__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (collectionView);
			GC.KeepAlive (session);
			return ret != 0;
		}
		/// <param name="collectionView">To be added.</param><param name="session">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("collectionView:dragSessionIsRestrictedToDraggingApplication:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool DragSessionIsRestrictedToDraggingApplication (UICollectionView collectionView, IUIDragSession session)
		{
			return _DragSessionIsRestrictedToDraggingApplication (this, collectionView, session);
		}
		/// <param name="collectionView">To be added.</param><param name="session">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _DragSessionIsRestrictedToDraggingApplication (IUICollectionViewDragDelegate This, UICollectionView collectionView, IUIDragSession session)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var collectionView__handle__ = collectionView!.GetNonNullHandle (nameof (collectionView));
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("collectionView:dragSessionIsRestrictedToDraggingApplication:"), collectionView__handle__, session__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (collectionView);
			GC.KeepAlive (session);
			return ret != 0;
		}
		[DynamicDependencyAttribute ("DragSessionAllowsMoveOperation(UIKit.UICollectionView,UIKit.IUIDragSession)")]
		[DynamicDependencyAttribute ("DragSessionDidEnd(UIKit.UICollectionView,UIKit.IUIDragSession)")]
		[DynamicDependencyAttribute ("DragSessionIsRestrictedToDraggingApplication(UIKit.UICollectionView,UIKit.IUIDragSession)")]
		[DynamicDependencyAttribute ("DragSessionWillBegin(UIKit.UICollectionView,UIKit.IUIDragSession)")]
		[DynamicDependencyAttribute ("GetDragPreviewParameters(UIKit.UICollectionView,Foundation.NSIndexPath)")]
		[DynamicDependencyAttribute ("GetItemsForAddingToDragSession(UIKit.UICollectionView,UIKit.IUIDragSession,Foundation.NSIndexPath,CoreGraphics.CGPoint)")]
		[DynamicDependencyAttribute ("GetItemsForBeginningDragSession(UIKit.UICollectionView,UIKit.IUIDragSession,Foundation.NSIndexPath)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UICollectionViewDragDelegateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IUICollectionViewDragDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="IUICollectionViewDragDelegate" /> interface to support all the methods from the UICollectionViewDragDelegate protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IUICollectionViewDragDelegate" /> interface allow developers to treat instances of the interface as having all the optional methods of the original UICollectionViewDragDelegate protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class UICollectionViewDragDelegate_Extensions {
		/// <param name="collectionView">The originating collection view.</param><param name="session">The drag session to which to add items.</param><param name="indexPath">The index path to the item to add.</param><param name="point">The point that the user touched, in the collection view coordinate space.</param><summary>Adds the items at the index path to the drag session.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static UIDragItem[] GetItemsForAddingToDragSession (this IUICollectionViewDragDelegate This, UICollectionView collectionView, IUIDragSession session, NSIndexPath indexPath, CGPoint point)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var collectionView__handle__ = collectionView!.GetNonNullHandle (nameof (collectionView));
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			var indexPath__handle__ = indexPath!.GetNonNullHandle (nameof (indexPath));
			UIDragItem[]? ret;
			ret = CFArray.ArrayFromHandle<UIDragItem>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_CGPoint (This.Handle, Selector.GetHandle ("collectionView:itemsForAddingToDragSession:atIndexPath:point:"), collectionView__handle__, session__handle__, indexPath__handle__, point), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (collectionView);
			GC.KeepAlive (session);
			GC.KeepAlive (indexPath);
			return ret!;
		}
		/// <param name="collectionView">To be added.</param><param name="indexPath">To be added.</param><summary>Gets the preview parameters for the item at the specified index path.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static UIDragPreviewParameters? GetDragPreviewParameters (this IUICollectionViewDragDelegate This, UICollectionView collectionView, NSIndexPath indexPath)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var collectionView__handle__ = collectionView!.GetNonNullHandle (nameof (collectionView));
			var indexPath__handle__ = indexPath!.GetNonNullHandle (nameof (indexPath));
			UIDragPreviewParameters? ret;
			ret =  Runtime.GetNSObject<UIDragPreviewParameters> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("collectionView:dragPreviewParametersForItemAtIndexPath:"), collectionView__handle__, indexPath__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (collectionView);
			GC.KeepAlive (indexPath);
			return ret!;
		}
		/// <param name="collectionView">The originating collection view.</param><param name="session">The session that is about to begin.</param><summary>Method that is called just before a drag session begins.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DragSessionWillBegin (this IUICollectionViewDragDelegate This, UICollectionView collectionView, IUIDragSession session)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var collectionView__handle__ = collectionView!.GetNonNullHandle (nameof (collectionView));
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("collectionView:dragSessionWillBegin:"), collectionView__handle__, session__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (collectionView);
			GC.KeepAlive (session);
		}
		/// <param name="collectionView">The originating collection view.</param><param name="session">The session that is ending.</param><summary>Method that is called when the user cancels or completes the drag session.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DragSessionDidEnd (this IUICollectionViewDragDelegate This, UICollectionView collectionView, IUIDragSession session)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var collectionView__handle__ = collectionView!.GetNonNullHandle (nameof (collectionView));
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("collectionView:dragSessionDidEnd:"), collectionView__handle__, session__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (collectionView);
			GC.KeepAlive (session);
		}
		/// <param name="collectionView">To be added.</param><param name="session">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool DragSessionAllowsMoveOperation (this IUICollectionViewDragDelegate This, UICollectionView collectionView, IUIDragSession session)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var collectionView__handle__ = collectionView!.GetNonNullHandle (nameof (collectionView));
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("collectionView:dragSessionAllowsMoveOperation:"), collectionView__handle__, session__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (collectionView);
			GC.KeepAlive (session);
			return ret != 0;
		}
		/// <param name="collectionView">To be added.</param><param name="session">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool DragSessionIsRestrictedToDraggingApplication (this IUICollectionViewDragDelegate This, UICollectionView collectionView, IUIDragSession session)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var collectionView__handle__ = collectionView!.GetNonNullHandle (nameof (collectionView));
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("collectionView:dragSessionIsRestrictedToDraggingApplication:"), collectionView__handle__, session__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (collectionView);
			GC.KeepAlive (session);
			return ret != 0;
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class UICollectionViewDragDelegateWrapper : BaseWrapper, IUICollectionViewDragDelegate {
		public UICollectionViewDragDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UICollectionViewDragDelegateWrapper))]
		static UICollectionViewDragDelegateWrapper ()
		{
			GC.KeepAlive (null);
		}
		/// <param name="collectionView">The originating collection view.</param><param name="session">The drag session to which to add items.</param><param name="indexPath">The index path to the item.</param><summary>Returns the items that were used to begin the drag operation, if present.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("collectionView:itemsForBeginningDragSession:atIndexPath:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public UIDragItem[] GetItemsForBeginningDragSession (UICollectionView collectionView, IUIDragSession session, NSIndexPath indexPath)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var collectionView__handle__ = collectionView!.GetNonNullHandle (nameof (collectionView));
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			var indexPath__handle__ = indexPath!.GetNonNullHandle (nameof (indexPath));
			UIDragItem[]? ret;
			ret = CFArray.ArrayFromHandle<UIDragItem>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("collectionView:itemsForBeginningDragSession:atIndexPath:"), collectionView__handle__, session__handle__, indexPath__handle__), false)!;
			GC.KeepAlive (collectionView);
			GC.KeepAlive (session);
			GC.KeepAlive (indexPath);
			return ret!;
		}
	}
}
namespace UIKit {
	/// <summary>Interface for a drag operation that started from a collection view.</summary>
	[Protocol()]
	[Register("Microsoft_iOS__UIKit_UICollectionViewDragDelegate", false)]
	[Model]
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	public unsafe abstract partial class UICollectionViewDragDelegate : NSObject, IUICollectionViewDragDelegate {
		/// <summary>Creates a new <see cref="UICollectionViewDragDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected UICollectionViewDragDelegate () : base (NSObjectFlag.Empty)
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
		protected UICollectionViewDragDelegate (NSObjectFlag t) : base (t)
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
		protected internal UICollectionViewDragDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		/// <param name="collectionView">To be added.</param><param name="session">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("collectionView:dragSessionAllowsMoveOperation:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool DragSessionAllowsMoveOperation (UICollectionView collectionView, IUIDragSession session)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="collectionView">The originating collection view.</param><param name="session">The session that is ending.</param><summary>Method that is called when the user cancels or completes the drag session.</summary><remarks>To be added.</remarks>
		[Export ("collectionView:dragSessionDidEnd:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DragSessionDidEnd (UICollectionView collectionView, IUIDragSession session)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="collectionView">To be added.</param><param name="session">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("collectionView:dragSessionIsRestrictedToDraggingApplication:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool DragSessionIsRestrictedToDraggingApplication (UICollectionView collectionView, IUIDragSession session)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="collectionView">The originating collection view.</param><param name="session">The session that is about to begin.</param><summary>Method that is called just before a drag session begins.</summary><remarks>To be added.</remarks>
		[Export ("collectionView:dragSessionWillBegin:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DragSessionWillBegin (UICollectionView collectionView, IUIDragSession session)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="collectionView">To be added.</param><param name="indexPath">To be added.</param><summary>Gets the preview parameters for the item at the specified index path.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("collectionView:dragPreviewParametersForItemAtIndexPath:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIDragPreviewParameters? GetDragPreviewParameters (UICollectionView collectionView, NSIndexPath indexPath)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="collectionView">The originating collection view.</param><param name="session">The drag session to which to add items.</param><param name="indexPath">The index path to the item to add.</param><param name="point">The point that the user touched, in the collection view coordinate space.</param><summary>Adds the items at the index path to the drag session.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("collectionView:itemsForAddingToDragSession:atIndexPath:point:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIDragItem[] GetItemsForAddingToDragSession (UICollectionView collectionView, IUIDragSession session, NSIndexPath indexPath, CGPoint point)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="collectionView">The originating collection view.</param><param name="session">The drag session to which to add items.</param><param name="indexPath">The index path to the item.</param><summary>Returns the items that were used to begin the drag operation, if present.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("collectionView:itemsForBeginningDragSession:atIndexPath:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIDragItem[] GetItemsForBeginningDragSession (UICollectionView collectionView, IUIDragSession session, NSIndexPath indexPath)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class UICollectionViewDragDelegate */
}
