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
	/// <summary>Delegate for handling drops to table views.</summary>
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[Protocol (Name = "UITableViewDropDelegate", WrapperType = typeof (UITableViewDropDelegateWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "PerformDrop", Selector = "tableView:performDropWithCoordinator:", ParameterType = new Type [] { typeof (UITableView), typeof (IUITableViewDropCoordinator) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "CanHandleDropSession", Selector = "tableView:canHandleDropSession:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (UITableView), typeof (IUIDropSession) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DropSessionDidEnter", Selector = "tableView:dropSessionDidEnter:", ParameterType = new Type [] { typeof (UITableView), typeof (IUIDropSession) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DropSessionDidUpdate", Selector = "tableView:dropSessionDidUpdate:withDestinationIndexPath:", ReturnType = typeof (UITableViewDropProposal), ParameterType = new Type [] { typeof (UITableView), typeof (IUIDropSession), typeof (NSIndexPath) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DropSessionDidExit", Selector = "tableView:dropSessionDidExit:", ParameterType = new Type [] { typeof (UITableView), typeof (IUIDropSession) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DropSessionDidEnd", Selector = "tableView:dropSessionDidEnd:", ParameterType = new Type [] { typeof (UITableView), typeof (IUIDropSession) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetDropPreviewParameters", Selector = "tableView:dropPreviewParametersForRowAtIndexPath:", ReturnType = typeof (UIDragPreviewParameters), ParameterType = new Type [] { typeof (UITableView), typeof (NSIndexPath) }, ParameterByRef = new bool [] { false, false })]
	public partial interface IUITableViewDropDelegate : INativeObject, IDisposable
	{
		/// <param name="tableView">The receiving table view.</param><param name="coordinator">The drop coordinator.</param><summary>Method that is called to drop data into a table view.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("tableView:performDropWithCoordinator:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PerformDrop (UITableView tableView, IUITableViewDropCoordinator coordinator)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="tableView">The receiving table view.</param><param name="coordinator">The drop coordinator.</param><summary>Method that is called to drop data into a table view.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _PerformDrop (IUITableViewDropDelegate This, UITableView tableView, IUITableViewDropCoordinator coordinator)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			var coordinator__handle__ = coordinator!.GetNonNullHandle (nameof (coordinator));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("tableView:performDropWithCoordinator:"), tableView__handle__, coordinator__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (tableView);
			GC.KeepAlive (coordinator);
		}
		/// <param name="tableView">The target table view.</param><param name="session">The drop session.</param><summary>Returns a Boolean value that tells whether the table view can handle drops from the data in the session.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("tableView:canHandleDropSession:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool CanHandleDropSession (UITableView tableView, IUIDropSession session)
		{
			return _CanHandleDropSession (this, tableView, session);
		}
		/// <param name="tableView">The target table view.</param><param name="session">The drop session.</param><summary>Returns a Boolean value that tells whether the table view can handle drops from the data in the session.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _CanHandleDropSession (IUITableViewDropDelegate This, UITableView tableView, IUIDropSession session)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("tableView:canHandleDropSession:"), tableView__handle__, session__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (tableView);
			GC.KeepAlive (session);
			return ret != 0;
		}
		/// <param name="tableView">The current target of the drop.</param><param name="session">The drop session that entered.</param><summary>Method that is called when the drop point enters the table view.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("tableView:dropSessionDidEnter:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DropSessionDidEnter (UITableView tableView, IUIDropSession session)
		{
			_DropSessionDidEnter (this, tableView, session);
		}
		/// <param name="tableView">The current target of the drop.</param><param name="session">The drop session that entered.</param><summary>Method that is called when the drop point enters the table view.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DropSessionDidEnter (IUITableViewDropDelegate This, UITableView tableView, IUIDropSession session)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("tableView:dropSessionDidEnter:"), tableView__handle__, session__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (tableView);
			GC.KeepAlive (session);
		}
		/// <param name="tableView">The current drop target.</param><param name="session">The drop session.</param><param name="destinationIndexPath">The index path to the currently targeted row. This parameter can be <see langword="null" />.</param><summary>Method that is called when the drop point over the table view changes.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("tableView:dropSessionDidUpdate:withDestinationIndexPath:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UITableViewDropProposal DropSessionDidUpdate (UITableView tableView, IUIDropSession session, NSIndexPath? destinationIndexPath)
		{
			return _DropSessionDidUpdate (this, tableView, session, destinationIndexPath);
		}
		/// <param name="tableView">The current drop target.</param><param name="session">The drop session.</param><param name="destinationIndexPath">The index path to the currently targeted row. This parameter can be <see langword="null" />.</param><summary>Method that is called when the drop point over the table view changes.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static UITableViewDropProposal _DropSessionDidUpdate (IUITableViewDropDelegate This, UITableView tableView, IUIDropSession session, NSIndexPath? destinationIndexPath)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			var destinationIndexPath__handle__ = destinationIndexPath.GetHandle ();
			UITableViewDropProposal? ret;
			ret =  Runtime.GetNSObject<UITableViewDropProposal> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("tableView:dropSessionDidUpdate:withDestinationIndexPath:"), tableView__handle__, session__handle__, destinationIndexPath__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tableView);
			GC.KeepAlive (session);
			GC.KeepAlive (destinationIndexPath);
			return ret!;
		}
		/// <param name="tableView">The view that was tracking the operation.</param><param name="session">The drop session that exited.</param><summary>Method that is called when the drop point leaves the table view.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("tableView:dropSessionDidExit:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DropSessionDidExit (UITableView tableView, IUIDropSession session)
		{
			_DropSessionDidExit (this, tableView, session);
		}
		/// <param name="tableView">The view that was tracking the operation.</param><param name="session">The drop session that exited.</param><summary>Method that is called when the drop point leaves the table view.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DropSessionDidExit (IUITableViewDropDelegate This, UITableView tableView, IUIDropSession session)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("tableView:dropSessionDidExit:"), tableView__handle__, session__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (tableView);
			GC.KeepAlive (session);
		}
		/// <param name="tableView">The original intended target table view.</param><param name="session">The session that ended.</param><summary>Method that is called when the drop session ends.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("tableView:dropSessionDidEnd:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DropSessionDidEnd (UITableView tableView, IUIDropSession session)
		{
			_DropSessionDidEnd (this, tableView, session);
		}
		/// <param name="tableView">The original intended target table view.</param><param name="session">The session that ended.</param><summary>Method that is called when the drop session ends.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DropSessionDidEnd (IUITableViewDropDelegate This, UITableView tableView, IUIDropSession session)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("tableView:dropSessionDidEnd:"), tableView__handle__, session__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (tableView);
			GC.KeepAlive (session);
		}
		/// <param name="tableView">The table view for which to get the preview parameters.</param><param name="indexPath">The index path to the row for which to get the preview parameters.</param><summary>Returns the drag preview parameters for the item at the specified index path.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("tableView:dropPreviewParametersForRowAtIndexPath:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIDragPreviewParameters? GetDropPreviewParameters (UITableView tableView, NSIndexPath indexPath)
		{
			return _GetDropPreviewParameters (this, tableView, indexPath);
		}
		/// <param name="tableView">The table view for which to get the preview parameters.</param><param name="indexPath">The index path to the row for which to get the preview parameters.</param><summary>Returns the drag preview parameters for the item at the specified index path.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static UIDragPreviewParameters? _GetDropPreviewParameters (IUITableViewDropDelegate This, UITableView tableView, NSIndexPath indexPath)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			var indexPath__handle__ = indexPath!.GetNonNullHandle (nameof (indexPath));
			UIDragPreviewParameters? ret;
			ret =  Runtime.GetNSObject<UIDragPreviewParameters> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("tableView:dropPreviewParametersForRowAtIndexPath:"), tableView__handle__, indexPath__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tableView);
			GC.KeepAlive (indexPath);
			return ret!;
		}
		[DynamicDependencyAttribute ("CanHandleDropSession(UIKit.UITableView,UIKit.IUIDropSession)")]
		[DynamicDependencyAttribute ("DropSessionDidEnd(UIKit.UITableView,UIKit.IUIDropSession)")]
		[DynamicDependencyAttribute ("DropSessionDidEnter(UIKit.UITableView,UIKit.IUIDropSession)")]
		[DynamicDependencyAttribute ("DropSessionDidExit(UIKit.UITableView,UIKit.IUIDropSession)")]
		[DynamicDependencyAttribute ("DropSessionDidUpdate(UIKit.UITableView,UIKit.IUIDropSession,Foundation.NSIndexPath)")]
		[DynamicDependencyAttribute ("GetDropPreviewParameters(UIKit.UITableView,Foundation.NSIndexPath)")]
		[DynamicDependencyAttribute ("PerformDrop(UIKit.UITableView,UIKit.IUITableViewDropCoordinator)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UITableViewDropDelegateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IUITableViewDropDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="IUITableViewDropDelegate" /> interface to support all the methods from the UITableViewDropDelegate protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IUITableViewDropDelegate" /> interface allow developers to treat instances of the interface as having all the optional methods of the original UITableViewDropDelegate protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class UITableViewDropDelegate_Extensions {
		/// <param name="tableView">The target table view.</param><param name="session">The drop session.</param><summary>Returns a Boolean value that tells whether the table view can handle drops from the data in the session.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool CanHandleDropSession (this IUITableViewDropDelegate This, UITableView tableView, IUIDropSession session)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("tableView:canHandleDropSession:"), tableView__handle__, session__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (tableView);
			GC.KeepAlive (session);
			return ret != 0;
		}
		/// <param name="tableView">The current target of the drop.</param><param name="session">The drop session that entered.</param><summary>Method that is called when the drop point enters the table view.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DropSessionDidEnter (this IUITableViewDropDelegate This, UITableView tableView, IUIDropSession session)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("tableView:dropSessionDidEnter:"), tableView__handle__, session__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (tableView);
			GC.KeepAlive (session);
		}
		/// <param name="tableView">The current drop target.</param><param name="session">The drop session.</param><param name="destinationIndexPath">The index path to the currently targeted row. This parameter can be <see langword="null" />.</param><summary>Method that is called when the drop point over the table view changes.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static UITableViewDropProposal DropSessionDidUpdate (this IUITableViewDropDelegate This, UITableView tableView, IUIDropSession session, NSIndexPath? destinationIndexPath)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			var destinationIndexPath__handle__ = destinationIndexPath.GetHandle ();
			UITableViewDropProposal? ret;
			ret =  Runtime.GetNSObject<UITableViewDropProposal> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("tableView:dropSessionDidUpdate:withDestinationIndexPath:"), tableView__handle__, session__handle__, destinationIndexPath__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tableView);
			GC.KeepAlive (session);
			GC.KeepAlive (destinationIndexPath);
			return ret!;
		}
		/// <param name="tableView">The view that was tracking the operation.</param><param name="session">The drop session that exited.</param><summary>Method that is called when the drop point leaves the table view.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DropSessionDidExit (this IUITableViewDropDelegate This, UITableView tableView, IUIDropSession session)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("tableView:dropSessionDidExit:"), tableView__handle__, session__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (tableView);
			GC.KeepAlive (session);
		}
		/// <param name="tableView">The original intended target table view.</param><param name="session">The session that ended.</param><summary>Method that is called when the drop session ends.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DropSessionDidEnd (this IUITableViewDropDelegate This, UITableView tableView, IUIDropSession session)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("tableView:dropSessionDidEnd:"), tableView__handle__, session__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (tableView);
			GC.KeepAlive (session);
		}
		/// <param name="tableView">The table view for which to get the preview parameters.</param><param name="indexPath">The index path to the row for which to get the preview parameters.</param><summary>Returns the drag preview parameters for the item at the specified index path.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static UIDragPreviewParameters? GetDropPreviewParameters (this IUITableViewDropDelegate This, UITableView tableView, NSIndexPath indexPath)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			var indexPath__handle__ = indexPath!.GetNonNullHandle (nameof (indexPath));
			UIDragPreviewParameters? ret;
			ret =  Runtime.GetNSObject<UIDragPreviewParameters> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("tableView:dropPreviewParametersForRowAtIndexPath:"), tableView__handle__, indexPath__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tableView);
			GC.KeepAlive (indexPath);
			return ret!;
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class UITableViewDropDelegateWrapper : BaseWrapper, IUITableViewDropDelegate {
		public UITableViewDropDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UITableViewDropDelegateWrapper))]
		static UITableViewDropDelegateWrapper ()
		{
			GC.KeepAlive (null);
		}
		/// <param name="tableView">The receiving table view.</param><param name="coordinator">The drop coordinator.</param><summary>Method that is called to drop data into a table view.</summary><remarks>To be added.</remarks>
		[Export ("tableView:performDropWithCoordinator:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void PerformDrop (UITableView tableView, IUITableViewDropCoordinator coordinator)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			var coordinator__handle__ = coordinator!.GetNonNullHandle (nameof (coordinator));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("tableView:performDropWithCoordinator:"), tableView__handle__, coordinator__handle__);
			GC.KeepAlive (tableView);
			GC.KeepAlive (coordinator);
		}
	}
}
namespace UIKit {
	/// <summary>Delegate for handling drops to table views.</summary>
	[Protocol()]
	[Register("Microsoft_MacCatalyst__UIKit_UITableViewDropDelegate", false)]
	[Model]
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	public unsafe abstract partial class UITableViewDropDelegate : NSObject, IUITableViewDropDelegate {
		/// <summary>Creates a new <see cref="UITableViewDropDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected UITableViewDropDelegate () : base (NSObjectFlag.Empty)
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
		protected UITableViewDropDelegate (NSObjectFlag t) : base (t)
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
		protected internal UITableViewDropDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		/// <param name="tableView">The target table view.</param><param name="session">The drop session.</param><summary>Returns a Boolean value that tells whether the table view can handle drops from the data in the session.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("tableView:canHandleDropSession:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool CanHandleDropSession (UITableView tableView, IUIDropSession session)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="tableView">The original intended target table view.</param><param name="session">The session that ended.</param><summary>Method that is called when the drop session ends.</summary><remarks>To be added.</remarks>
		[Export ("tableView:dropSessionDidEnd:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DropSessionDidEnd (UITableView tableView, IUIDropSession session)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="tableView">The current target of the drop.</param><param name="session">The drop session that entered.</param><summary>Method that is called when the drop point enters the table view.</summary><remarks>To be added.</remarks>
		[Export ("tableView:dropSessionDidEnter:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DropSessionDidEnter (UITableView tableView, IUIDropSession session)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="tableView">The view that was tracking the operation.</param><param name="session">The drop session that exited.</param><summary>Method that is called when the drop point leaves the table view.</summary><remarks>To be added.</remarks>
		[Export ("tableView:dropSessionDidExit:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DropSessionDidExit (UITableView tableView, IUIDropSession session)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="tableView">The current drop target.</param><param name="session">The drop session.</param><param name="destinationIndexPath">The index path to the currently targeted row. This parameter can be <see langword="null" />.</param><summary>Method that is called when the drop point over the table view changes.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("tableView:dropSessionDidUpdate:withDestinationIndexPath:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UITableViewDropProposal DropSessionDidUpdate (UITableView tableView, IUIDropSession session, NSIndexPath? destinationIndexPath)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="tableView">The table view for which to get the preview parameters.</param><param name="indexPath">The index path to the row for which to get the preview parameters.</param><summary>Returns the drag preview parameters for the item at the specified index path.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("tableView:dropPreviewParametersForRowAtIndexPath:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIDragPreviewParameters? GetDropPreviewParameters (UITableView tableView, NSIndexPath indexPath)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="tableView">The receiving table view.</param><param name="coordinator">The drop coordinator.</param><summary>Method that is called to drop data into a table view.</summary><remarks>To be added.</remarks>
		[Export ("tableView:performDropWithCoordinator:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PerformDrop (UITableView tableView, IUITableViewDropCoordinator coordinator)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class UITableViewDropDelegate */
}
