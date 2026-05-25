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
	/// <summary>Delegate for handling drops to collection views.</summary>
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[Protocol (Name = "UICollectionViewDropDelegate", WrapperType = typeof (UICollectionViewDropDelegateWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "PerformDrop", Selector = "collectionView:performDropWithCoordinator:", ParameterType = new Type [] { typeof (UICollectionView), typeof (IUICollectionViewDropCoordinator) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "CanHandleDropSession", Selector = "collectionView:canHandleDropSession:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (UICollectionView), typeof (IUIDropSession) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DropSessionDidEnter", Selector = "collectionView:dropSessionDidEnter:", ParameterType = new Type [] { typeof (UICollectionView), typeof (IUIDropSession) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DropSessionDidUpdate", Selector = "collectionView:dropSessionDidUpdate:withDestinationIndexPath:", ReturnType = typeof (UICollectionViewDropProposal), ParameterType = new Type [] { typeof (UICollectionView), typeof (IUIDropSession), typeof (NSIndexPath) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DropSessionDidExit", Selector = "collectionView:dropSessionDidExit:", ParameterType = new Type [] { typeof (UICollectionView), typeof (IUIDropSession) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DropSessionDidEnd", Selector = "collectionView:dropSessionDidEnd:", ParameterType = new Type [] { typeof (UICollectionView), typeof (IUIDropSession) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetDropPreviewParameters", Selector = "collectionView:dropPreviewParametersForItemAtIndexPath:", ReturnType = typeof (UIDragPreviewParameters), ParameterType = new Type [] { typeof (UICollectionView), typeof (NSIndexPath) }, ParameterByRef = new bool [] { false, false })]
	public partial interface IUICollectionViewDropDelegate : INativeObject, IDisposable
	{
		/// <param name="collectionView">The receiving collection view.</param><param name="coordinator">The drop coordinator to use.</param><summary>Method that is called to drop data into a collection view.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("collectionView:performDropWithCoordinator:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PerformDrop (UICollectionView collectionView, IUICollectionViewDropCoordinator coordinator)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="collectionView">The receiving collection view.</param><param name="coordinator">The drop coordinator to use.</param><summary>Method that is called to drop data into a collection view.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _PerformDrop (IUICollectionViewDropDelegate This, UICollectionView collectionView, IUICollectionViewDropCoordinator coordinator)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var collectionView__handle__ = collectionView!.GetNonNullHandle (nameof (collectionView));
			var coordinator__handle__ = coordinator!.GetNonNullHandle (nameof (coordinator));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("collectionView:performDropWithCoordinator:"), collectionView__handle__, coordinator__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (collectionView);
			GC.KeepAlive (coordinator);
		}
		/// <param name="collectionView">The collection view to query.</param><param name="session">The drop session with the drag type data.</param><summary>Returns a Boolean value that tells whether the collection view can handle drops from the data in the session.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("collectionView:canHandleDropSession:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool CanHandleDropSession (UICollectionView collectionView, IUIDropSession session)
		{
			return _CanHandleDropSession (this, collectionView, session);
		}
		/// <param name="collectionView">The collection view to query.</param><param name="session">The drop session with the drag type data.</param><summary>Returns a Boolean value that tells whether the collection view can handle drops from the data in the session.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _CanHandleDropSession (IUICollectionViewDropDelegate This, UICollectionView collectionView, IUIDropSession session)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var collectionView__handle__ = collectionView!.GetNonNullHandle (nameof (collectionView));
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("collectionView:canHandleDropSession:"), collectionView__handle__, session__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (collectionView);
			GC.KeepAlive (session);
			return ret != 0;
		}
		/// <param name="collectionView">The originating collection view.</param><param name="session">The drop session.</param><summary>Method that is called when the drop point enters the collection view.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("collectionView:dropSessionDidEnter:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DropSessionDidEnter (UICollectionView collectionView, IUIDropSession session)
		{
			_DropSessionDidEnter (this, collectionView, session);
		}
		/// <param name="collectionView">The originating collection view.</param><param name="session">The drop session.</param><summary>Method that is called when the drop point enters the collection view.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DropSessionDidEnter (IUICollectionViewDropDelegate This, UICollectionView collectionView, IUIDropSession session)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var collectionView__handle__ = collectionView!.GetNonNullHandle (nameof (collectionView));
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("collectionView:dropSessionDidEnter:"), collectionView__handle__, session__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (collectionView);
			GC.KeepAlive (session);
		}
		/// <param name="collectionView">The originating collection view.</param><param name="session">The drop session.</param><param name="destinationIndexPath"><para>The index path where the content would be dropped if it were dropped at the time of the method call.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>Method that is called when the drop point over the collection view changes.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("collectionView:dropSessionDidUpdate:withDestinationIndexPath:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UICollectionViewDropProposal DropSessionDidUpdate (UICollectionView collectionView, IUIDropSession session, NSIndexPath? destinationIndexPath)
		{
			return _DropSessionDidUpdate (this, collectionView, session, destinationIndexPath);
		}
		/// <param name="collectionView">The originating collection view.</param><param name="session">The drop session.</param><param name="destinationIndexPath"><para>The index path where the content would be dropped if it were dropped at the time of the method call.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>Method that is called when the drop point over the collection view changes.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static UICollectionViewDropProposal _DropSessionDidUpdate (IUICollectionViewDropDelegate This, UICollectionView collectionView, IUIDropSession session, NSIndexPath? destinationIndexPath)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var collectionView__handle__ = collectionView!.GetNonNullHandle (nameof (collectionView));
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			var destinationIndexPath__handle__ = destinationIndexPath.GetHandle ();
			UICollectionViewDropProposal? ret;
			ret =  Runtime.GetNSObject<UICollectionViewDropProposal> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("collectionView:dropSessionDidUpdate:withDestinationIndexPath:"), collectionView__handle__, session__handle__, destinationIndexPath__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (collectionView);
			GC.KeepAlive (session);
			GC.KeepAlive (destinationIndexPath);
			return ret!;
		}
		/// <param name="collectionView">The originating collection view.</param><param name="session">The drop session.</param><summary>Method that is called when the drop point leaves the collection view.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("collectionView:dropSessionDidExit:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DropSessionDidExit (UICollectionView collectionView, IUIDropSession session)
		{
			_DropSessionDidExit (this, collectionView, session);
		}
		/// <param name="collectionView">The originating collection view.</param><param name="session">The drop session.</param><summary>Method that is called when the drop point leaves the collection view.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DropSessionDidExit (IUICollectionViewDropDelegate This, UICollectionView collectionView, IUIDropSession session)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var collectionView__handle__ = collectionView!.GetNonNullHandle (nameof (collectionView));
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("collectionView:dropSessionDidExit:"), collectionView__handle__, session__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (collectionView);
			GC.KeepAlive (session);
		}
		/// <param name="collectionView">The originating collection view.</param><param name="session">The drop session.</param><summary>Method that is called when the drop session ends.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("collectionView:dropSessionDidEnd:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DropSessionDidEnd (UICollectionView collectionView, IUIDropSession session)
		{
			_DropSessionDidEnd (this, collectionView, session);
		}
		/// <param name="collectionView">The originating collection view.</param><param name="session">The drop session.</param><summary>Method that is called when the drop session ends.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DropSessionDidEnd (IUICollectionViewDropDelegate This, UICollectionView collectionView, IUIDropSession session)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var collectionView__handle__ = collectionView!.GetNonNullHandle (nameof (collectionView));
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("collectionView:dropSessionDidEnd:"), collectionView__handle__, session__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (collectionView);
			GC.KeepAlive (session);
		}
		/// <param name="collectionView">The originating collection view.</param><param name="indexPath">To be added.</param><summary>Returns the drag preview parameters for the item at the specified index path.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("collectionView:dropPreviewParametersForItemAtIndexPath:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIDragPreviewParameters? GetDropPreviewParameters (UICollectionView collectionView, NSIndexPath indexPath)
		{
			return _GetDropPreviewParameters (this, collectionView, indexPath);
		}
		/// <param name="collectionView">The originating collection view.</param><param name="indexPath">To be added.</param><summary>Returns the drag preview parameters for the item at the specified index path.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static UIDragPreviewParameters? _GetDropPreviewParameters (IUICollectionViewDropDelegate This, UICollectionView collectionView, NSIndexPath indexPath)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var collectionView__handle__ = collectionView!.GetNonNullHandle (nameof (collectionView));
			var indexPath__handle__ = indexPath!.GetNonNullHandle (nameof (indexPath));
			UIDragPreviewParameters? ret;
			ret =  Runtime.GetNSObject<UIDragPreviewParameters> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("collectionView:dropPreviewParametersForItemAtIndexPath:"), collectionView__handle__, indexPath__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (collectionView);
			GC.KeepAlive (indexPath);
			return ret!;
		}
		[DynamicDependencyAttribute ("CanHandleDropSession(UIKit.UICollectionView,UIKit.IUIDropSession)")]
		[DynamicDependencyAttribute ("DropSessionDidEnd(UIKit.UICollectionView,UIKit.IUIDropSession)")]
		[DynamicDependencyAttribute ("DropSessionDidEnter(UIKit.UICollectionView,UIKit.IUIDropSession)")]
		[DynamicDependencyAttribute ("DropSessionDidExit(UIKit.UICollectionView,UIKit.IUIDropSession)")]
		[DynamicDependencyAttribute ("DropSessionDidUpdate(UIKit.UICollectionView,UIKit.IUIDropSession,Foundation.NSIndexPath)")]
		[DynamicDependencyAttribute ("GetDropPreviewParameters(UIKit.UICollectionView,Foundation.NSIndexPath)")]
		[DynamicDependencyAttribute ("PerformDrop(UIKit.UICollectionView,UIKit.IUICollectionViewDropCoordinator)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UICollectionViewDropDelegateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IUICollectionViewDropDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="IUICollectionViewDropDelegate" /> interface to support all the methods from the UICollectionViewDropDelegate protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IUICollectionViewDropDelegate" /> interface allow developers to treat instances of the interface as having all the optional methods of the original UICollectionViewDropDelegate protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class UICollectionViewDropDelegate_Extensions {
		/// <param name="collectionView">The collection view to query.</param><param name="session">The drop session with the drag type data.</param><summary>Returns a Boolean value that tells whether the collection view can handle drops from the data in the session.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool CanHandleDropSession (this IUICollectionViewDropDelegate This, UICollectionView collectionView, IUIDropSession session)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var collectionView__handle__ = collectionView!.GetNonNullHandle (nameof (collectionView));
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("collectionView:canHandleDropSession:"), collectionView__handle__, session__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (collectionView);
			GC.KeepAlive (session);
			return ret != 0;
		}
		/// <param name="collectionView">The originating collection view.</param><param name="session">The drop session.</param><summary>Method that is called when the drop point enters the collection view.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DropSessionDidEnter (this IUICollectionViewDropDelegate This, UICollectionView collectionView, IUIDropSession session)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var collectionView__handle__ = collectionView!.GetNonNullHandle (nameof (collectionView));
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("collectionView:dropSessionDidEnter:"), collectionView__handle__, session__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (collectionView);
			GC.KeepAlive (session);
		}
		/// <param name="collectionView">The originating collection view.</param><param name="session">The drop session.</param><param name="destinationIndexPath"><para>The index path where the content would be dropped if it were dropped at the time of the method call.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>Method that is called when the drop point over the collection view changes.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static UICollectionViewDropProposal DropSessionDidUpdate (this IUICollectionViewDropDelegate This, UICollectionView collectionView, IUIDropSession session, NSIndexPath? destinationIndexPath)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var collectionView__handle__ = collectionView!.GetNonNullHandle (nameof (collectionView));
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			var destinationIndexPath__handle__ = destinationIndexPath.GetHandle ();
			UICollectionViewDropProposal? ret;
			ret =  Runtime.GetNSObject<UICollectionViewDropProposal> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("collectionView:dropSessionDidUpdate:withDestinationIndexPath:"), collectionView__handle__, session__handle__, destinationIndexPath__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (collectionView);
			GC.KeepAlive (session);
			GC.KeepAlive (destinationIndexPath);
			return ret!;
		}
		/// <param name="collectionView">The originating collection view.</param><param name="session">The drop session.</param><summary>Method that is called when the drop point leaves the collection view.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DropSessionDidExit (this IUICollectionViewDropDelegate This, UICollectionView collectionView, IUIDropSession session)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var collectionView__handle__ = collectionView!.GetNonNullHandle (nameof (collectionView));
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("collectionView:dropSessionDidExit:"), collectionView__handle__, session__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (collectionView);
			GC.KeepAlive (session);
		}
		/// <param name="collectionView">The originating collection view.</param><param name="session">The drop session.</param><summary>Method that is called when the drop session ends.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DropSessionDidEnd (this IUICollectionViewDropDelegate This, UICollectionView collectionView, IUIDropSession session)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var collectionView__handle__ = collectionView!.GetNonNullHandle (nameof (collectionView));
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("collectionView:dropSessionDidEnd:"), collectionView__handle__, session__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (collectionView);
			GC.KeepAlive (session);
		}
		/// <param name="collectionView">The originating collection view.</param><param name="indexPath">To be added.</param><summary>Returns the drag preview parameters for the item at the specified index path.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static UIDragPreviewParameters? GetDropPreviewParameters (this IUICollectionViewDropDelegate This, UICollectionView collectionView, NSIndexPath indexPath)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var collectionView__handle__ = collectionView!.GetNonNullHandle (nameof (collectionView));
			var indexPath__handle__ = indexPath!.GetNonNullHandle (nameof (indexPath));
			UIDragPreviewParameters? ret;
			ret =  Runtime.GetNSObject<UIDragPreviewParameters> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("collectionView:dropPreviewParametersForItemAtIndexPath:"), collectionView__handle__, indexPath__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (collectionView);
			GC.KeepAlive (indexPath);
			return ret!;
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class UICollectionViewDropDelegateWrapper : BaseWrapper, IUICollectionViewDropDelegate {
		public UICollectionViewDropDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UICollectionViewDropDelegateWrapper))]
		static UICollectionViewDropDelegateWrapper ()
		{
			GC.KeepAlive (null);
		}
		/// <param name="collectionView">The receiving collection view.</param><param name="coordinator">The drop coordinator to use.</param><summary>Method that is called to drop data into a collection view.</summary><remarks>To be added.</remarks>
		[Export ("collectionView:performDropWithCoordinator:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void PerformDrop (UICollectionView collectionView, IUICollectionViewDropCoordinator coordinator)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var collectionView__handle__ = collectionView!.GetNonNullHandle (nameof (collectionView));
			var coordinator__handle__ = coordinator!.GetNonNullHandle (nameof (coordinator));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("collectionView:performDropWithCoordinator:"), collectionView__handle__, coordinator__handle__);
			GC.KeepAlive (collectionView);
			GC.KeepAlive (coordinator);
		}
	}
}
namespace UIKit {
	/// <summary>Delegate for handling drops to collection views.</summary>
	[Protocol()]
	[Register("Microsoft_iOS__UIKit_UICollectionViewDropDelegate", false)]
	[Model]
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	public unsafe abstract partial class UICollectionViewDropDelegate : NSObject, IUICollectionViewDropDelegate {
		/// <summary>Creates a new <see cref="UICollectionViewDropDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected UICollectionViewDropDelegate () : base (NSObjectFlag.Empty)
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
		protected UICollectionViewDropDelegate (NSObjectFlag t) : base (t)
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
		protected internal UICollectionViewDropDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		/// <param name="collectionView">The collection view to query.</param><param name="session">The drop session with the drag type data.</param><summary>Returns a Boolean value that tells whether the collection view can handle drops from the data in the session.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("collectionView:canHandleDropSession:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool CanHandleDropSession (UICollectionView collectionView, IUIDropSession session)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="collectionView">The originating collection view.</param><param name="session">The drop session.</param><summary>Method that is called when the drop session ends.</summary><remarks>To be added.</remarks>
		[Export ("collectionView:dropSessionDidEnd:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DropSessionDidEnd (UICollectionView collectionView, IUIDropSession session)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="collectionView">The originating collection view.</param><param name="session">The drop session.</param><summary>Method that is called when the drop point enters the collection view.</summary><remarks>To be added.</remarks>
		[Export ("collectionView:dropSessionDidEnter:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DropSessionDidEnter (UICollectionView collectionView, IUIDropSession session)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="collectionView">The originating collection view.</param><param name="session">The drop session.</param><summary>Method that is called when the drop point leaves the collection view.</summary><remarks>To be added.</remarks>
		[Export ("collectionView:dropSessionDidExit:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DropSessionDidExit (UICollectionView collectionView, IUIDropSession session)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="collectionView">The originating collection view.</param><param name="session">The drop session.</param><param name="destinationIndexPath"><para>The index path where the content would be dropped if it were dropped at the time of the method call.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>Method that is called when the drop point over the collection view changes.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("collectionView:dropSessionDidUpdate:withDestinationIndexPath:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UICollectionViewDropProposal DropSessionDidUpdate (UICollectionView collectionView, IUIDropSession session, NSIndexPath? destinationIndexPath)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="collectionView">The originating collection view.</param><param name="indexPath">To be added.</param><summary>Returns the drag preview parameters for the item at the specified index path.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("collectionView:dropPreviewParametersForItemAtIndexPath:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIDragPreviewParameters? GetDropPreviewParameters (UICollectionView collectionView, NSIndexPath indexPath)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="collectionView">The receiving collection view.</param><param name="coordinator">The drop coordinator to use.</param><summary>Method that is called to drop data into a collection view.</summary><remarks>To be added.</remarks>
		[Export ("collectionView:performDropWithCoordinator:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PerformDrop (UICollectionView collectionView, IUICollectionViewDropCoordinator coordinator)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class UICollectionViewDropDelegate */
}
