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
	/// <summary>Delegate for handling drops to text views.</summary>
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[Protocol (Name = "UITextDropDelegate", WrapperType = typeof (UITextDropDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillBecomeEditable", Selector = "textDroppableView:willBecomeEditableForDrop:", ReturnType = typeof (UITextDropEditability), ParameterType = new Type [] { typeof (IUITextDroppable), typeof (IUITextDropRequest) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetProposalForDrop", Selector = "textDroppableView:proposalForDrop:", ReturnType = typeof (UITextDropProposal), ParameterType = new Type [] { typeof (IUITextDroppable), typeof (IUITextDropRequest) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillPerformDrop", Selector = "textDroppableView:willPerformDrop:", ParameterType = new Type [] { typeof (IUITextDroppable), typeof (IUITextDropRequest) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetPreviewForDroppingAllItems", Selector = "textDroppableView:previewForDroppingAllItemsWithDefault:", ReturnType = typeof (UITargetedDragPreview), ParameterType = new Type [] { typeof (IUITextDroppable), typeof (UITargetedDragPreview) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DropSessionDidEnter", Selector = "textDroppableView:dropSessionDidEnter:", ParameterType = new Type [] { typeof (IUITextDroppable), typeof (IUIDropSession) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DropSessionDidUpdate", Selector = "textDroppableView:dropSessionDidUpdate:", ParameterType = new Type [] { typeof (IUITextDroppable), typeof (IUIDropSession) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DropSessionDidExit", Selector = "textDroppableView:dropSessionDidExit:", ParameterType = new Type [] { typeof (IUITextDroppable), typeof (IUIDropSession) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DropSessionDidEnd", Selector = "textDroppableView:dropSessionDidEnd:", ParameterType = new Type [] { typeof (IUITextDroppable), typeof (IUIDropSession) }, ParameterByRef = new bool [] { false, false })]
	public partial interface IUITextDropDelegate : INativeObject, IDisposable
	{
		/// <param name="textDroppableView">The currently non-editable receiving view.</param><param name="drop">The drop request.</param><summary>Method that is called to determine whether a non-editable text view can accept drops.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("textDroppableView:willBecomeEditableForDrop:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UITextDropEditability WillBecomeEditable (IUITextDroppable textDroppableView, IUITextDropRequest drop)
		{
			return _WillBecomeEditable (this, textDroppableView, drop);
		}
		/// <param name="textDroppableView">The currently non-editable receiving view.</param><param name="drop">The drop request.</param><summary>Method that is called to determine whether a non-editable text view can accept drops.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static UITextDropEditability _WillBecomeEditable (IUITextDropDelegate This, IUITextDroppable textDroppableView, IUITextDropRequest drop)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var textDroppableView__handle__ = textDroppableView!.GetNonNullHandle (nameof (textDroppableView));
			var drop__handle__ = drop!.GetNonNullHandle (nameof (drop));
			UITextDropEditability ret;
			ret = (UITextDropEditability) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("textDroppableView:willBecomeEditableForDrop:"), textDroppableView__handle__, drop__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (textDroppableView);
			GC.KeepAlive (drop);
			return ret!;
		}
		/// <param name="textDroppableView">The receiving view.</param><param name="drop">The drop request for which to get a proposal.</param><summary>Method that is called to get the drop proposal.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("textDroppableView:proposalForDrop:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UITextDropProposal GetProposalForDrop (IUITextDroppable textDroppableView, IUITextDropRequest drop)
		{
			return _GetProposalForDrop (this, textDroppableView, drop);
		}
		/// <param name="textDroppableView">The receiving view.</param><param name="drop">The drop request for which to get a proposal.</param><summary>Method that is called to get the drop proposal.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static UITextDropProposal _GetProposalForDrop (IUITextDropDelegate This, IUITextDroppable textDroppableView, IUITextDropRequest drop)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var textDroppableView__handle__ = textDroppableView!.GetNonNullHandle (nameof (textDroppableView));
			var drop__handle__ = drop!.GetNonNullHandle (nameof (drop));
			UITextDropProposal? ret;
			ret =  Runtime.GetNSObject<UITextDropProposal> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("textDroppableView:proposalForDrop:"), textDroppableView__handle__, drop__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (textDroppableView);
			GC.KeepAlive (drop);
			return ret!;
		}
		/// <param name="textDroppableView">The receiving view.</param><param name="drop">The drop request.</param><summary>Method that is called just before the drop is performed.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("textDroppableView:willPerformDrop:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillPerformDrop (IUITextDroppable textDroppableView, IUITextDropRequest drop)
		{
			_WillPerformDrop (this, textDroppableView, drop);
		}
		/// <param name="textDroppableView">The receiving view.</param><param name="drop">The drop request.</param><summary>Method that is called just before the drop is performed.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _WillPerformDrop (IUITextDropDelegate This, IUITextDroppable textDroppableView, IUITextDropRequest drop)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var textDroppableView__handle__ = textDroppableView!.GetNonNullHandle (nameof (textDroppableView));
			var drop__handle__ = drop!.GetNonNullHandle (nameof (drop));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("textDroppableView:willPerformDrop:"), textDroppableView__handle__, drop__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (textDroppableView);
			GC.KeepAlive (drop);
		}
		/// <param name="textDroppableView">The receiving view.</param><param name="defaultPreview">The system-provided default preview.</param><summary>Method that is called once to get the drag preview to use for dropping all the items.</summary><returns><para>Developers can return <see langword="null" /> to cause the default preview to be used.</para></returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("textDroppableView:previewForDroppingAllItemsWithDefault:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UITargetedDragPreview? GetPreviewForDroppingAllItems (IUITextDroppable textDroppableView, UITargetedDragPreview defaultPreview)
		{
			return _GetPreviewForDroppingAllItems (this, textDroppableView, defaultPreview);
		}
		/// <param name="textDroppableView">The receiving view.</param><param name="defaultPreview">The system-provided default preview.</param><summary>Method that is called once to get the drag preview to use for dropping all the items.</summary><returns><para>Developers can return <see langword="null" /> to cause the default preview to be used.</para></returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static UITargetedDragPreview? _GetPreviewForDroppingAllItems (IUITextDropDelegate This, IUITextDroppable textDroppableView, UITargetedDragPreview defaultPreview)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var textDroppableView__handle__ = textDroppableView!.GetNonNullHandle (nameof (textDroppableView));
			var defaultPreview__handle__ = defaultPreview!.GetNonNullHandle (nameof (defaultPreview));
			UITargetedDragPreview? ret;
			ret =  Runtime.GetNSObject<UITargetedDragPreview> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("textDroppableView:previewForDroppingAllItemsWithDefault:"), textDroppableView__handle__, defaultPreview__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (textDroppableView);
			GC.KeepAlive (defaultPreview);
			return ret!;
		}
		/// <param name="textDroppableView">The receiving view.</param><param name="session">The session that entered.</param><summary>Method that is called when the drop point enters the text view.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("textDroppableView:dropSessionDidEnter:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DropSessionDidEnter (IUITextDroppable textDroppableView, IUIDropSession session)
		{
			_DropSessionDidEnter (this, textDroppableView, session);
		}
		/// <param name="textDroppableView">The receiving view.</param><param name="session">The session that entered.</param><summary>Method that is called when the drop point enters the text view.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DropSessionDidEnter (IUITextDropDelegate This, IUITextDroppable textDroppableView, IUIDropSession session)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var textDroppableView__handle__ = textDroppableView!.GetNonNullHandle (nameof (textDroppableView));
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("textDroppableView:dropSessionDidEnter:"), textDroppableView__handle__, session__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (textDroppableView);
			GC.KeepAlive (session);
		}
		/// <param name="textDroppableView">The receiving view.</param><param name="session">The session that was updated.</param><summary>Method that is called when the drop point over the text view changes.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("textDroppableView:dropSessionDidUpdate:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DropSessionDidUpdate (IUITextDroppable textDroppableView, IUIDropSession session)
		{
			_DropSessionDidUpdate (this, textDroppableView, session);
		}
		/// <param name="textDroppableView">The receiving view.</param><param name="session">The session that was updated.</param><summary>Method that is called when the drop point over the text view changes.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DropSessionDidUpdate (IUITextDropDelegate This, IUITextDroppable textDroppableView, IUIDropSession session)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var textDroppableView__handle__ = textDroppableView!.GetNonNullHandle (nameof (textDroppableView));
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("textDroppableView:dropSessionDidUpdate:"), textDroppableView__handle__, session__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (textDroppableView);
			GC.KeepAlive (session);
		}
		/// <param name="textDroppableView">The previously receiving view.</param><param name="session">The session that exited.</param><summary>Method that is called when the drop point leaves the text view.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("textDroppableView:dropSessionDidExit:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DropSessionDidExit (IUITextDroppable textDroppableView, IUIDropSession session)
		{
			_DropSessionDidExit (this, textDroppableView, session);
		}
		/// <param name="textDroppableView">The previously receiving view.</param><param name="session">The session that exited.</param><summary>Method that is called when the drop point leaves the text view.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DropSessionDidExit (IUITextDropDelegate This, IUITextDroppable textDroppableView, IUIDropSession session)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var textDroppableView__handle__ = textDroppableView!.GetNonNullHandle (nameof (textDroppableView));
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("textDroppableView:dropSessionDidExit:"), textDroppableView__handle__, session__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (textDroppableView);
			GC.KeepAlive (session);
		}
		/// <param name="textDroppableView">The destination view.</param><param name="session">The drop session that ended.</param><summary>Method that is called when the drop session ends.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("textDroppableView:dropSessionDidEnd:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DropSessionDidEnd (IUITextDroppable textDroppableView, IUIDropSession session)
		{
			_DropSessionDidEnd (this, textDroppableView, session);
		}
		/// <param name="textDroppableView">The destination view.</param><param name="session">The drop session that ended.</param><summary>Method that is called when the drop session ends.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DropSessionDidEnd (IUITextDropDelegate This, IUITextDroppable textDroppableView, IUIDropSession session)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var textDroppableView__handle__ = textDroppableView!.GetNonNullHandle (nameof (textDroppableView));
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("textDroppableView:dropSessionDidEnd:"), textDroppableView__handle__, session__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (textDroppableView);
			GC.KeepAlive (session);
		}
		[DynamicDependencyAttribute ("DropSessionDidEnd(UIKit.IUITextDroppable,UIKit.IUIDropSession)")]
		[DynamicDependencyAttribute ("DropSessionDidEnter(UIKit.IUITextDroppable,UIKit.IUIDropSession)")]
		[DynamicDependencyAttribute ("DropSessionDidExit(UIKit.IUITextDroppable,UIKit.IUIDropSession)")]
		[DynamicDependencyAttribute ("DropSessionDidUpdate(UIKit.IUITextDroppable,UIKit.IUIDropSession)")]
		[DynamicDependencyAttribute ("GetPreviewForDroppingAllItems(UIKit.IUITextDroppable,UIKit.UITargetedDragPreview)")]
		[DynamicDependencyAttribute ("GetProposalForDrop(UIKit.IUITextDroppable,UIKit.IUITextDropRequest)")]
		[DynamicDependencyAttribute ("WillBecomeEditable(UIKit.IUITextDroppable,UIKit.IUITextDropRequest)")]
		[DynamicDependencyAttribute ("WillPerformDrop(UIKit.IUITextDroppable,UIKit.IUITextDropRequest)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UITextDropDelegateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IUITextDropDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="IUITextDropDelegate" /> interface to support all the methods from the UITextDropDelegate protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IUITextDropDelegate" /> interface allow developers to treat instances of the interface as having all the optional methods of the original UITextDropDelegate protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class UITextDropDelegate_Extensions {
		/// <param name="textDroppableView">The currently non-editable receiving view.</param><param name="drop">The drop request.</param><summary>Method that is called to determine whether a non-editable text view can accept drops.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static UITextDropEditability WillBecomeEditable (this IUITextDropDelegate This, IUITextDroppable textDroppableView, IUITextDropRequest drop)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var textDroppableView__handle__ = textDroppableView!.GetNonNullHandle (nameof (textDroppableView));
			var drop__handle__ = drop!.GetNonNullHandle (nameof (drop));
			UITextDropEditability ret;
			ret = (UITextDropEditability) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("textDroppableView:willBecomeEditableForDrop:"), textDroppableView__handle__, drop__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (textDroppableView);
			GC.KeepAlive (drop);
			return ret!;
		}
		/// <param name="textDroppableView">The receiving view.</param><param name="drop">The drop request for which to get a proposal.</param><summary>Method that is called to get the drop proposal.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static UITextDropProposal GetProposalForDrop (this IUITextDropDelegate This, IUITextDroppable textDroppableView, IUITextDropRequest drop)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var textDroppableView__handle__ = textDroppableView!.GetNonNullHandle (nameof (textDroppableView));
			var drop__handle__ = drop!.GetNonNullHandle (nameof (drop));
			UITextDropProposal? ret;
			ret =  Runtime.GetNSObject<UITextDropProposal> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("textDroppableView:proposalForDrop:"), textDroppableView__handle__, drop__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (textDroppableView);
			GC.KeepAlive (drop);
			return ret!;
		}
		/// <param name="textDroppableView">The receiving view.</param><param name="drop">The drop request.</param><summary>Method that is called just before the drop is performed.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void WillPerformDrop (this IUITextDropDelegate This, IUITextDroppable textDroppableView, IUITextDropRequest drop)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var textDroppableView__handle__ = textDroppableView!.GetNonNullHandle (nameof (textDroppableView));
			var drop__handle__ = drop!.GetNonNullHandle (nameof (drop));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("textDroppableView:willPerformDrop:"), textDroppableView__handle__, drop__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (textDroppableView);
			GC.KeepAlive (drop);
		}
		/// <param name="textDroppableView">The receiving view.</param><param name="defaultPreview">The system-provided default preview.</param><summary>Method that is called once to get the drag preview to use for dropping all the items.</summary><returns><para>Developers can return <see langword="null" /> to cause the default preview to be used.</para></returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static UITargetedDragPreview? GetPreviewForDroppingAllItems (this IUITextDropDelegate This, IUITextDroppable textDroppableView, UITargetedDragPreview defaultPreview)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var textDroppableView__handle__ = textDroppableView!.GetNonNullHandle (nameof (textDroppableView));
			var defaultPreview__handle__ = defaultPreview!.GetNonNullHandle (nameof (defaultPreview));
			UITargetedDragPreview? ret;
			ret =  Runtime.GetNSObject<UITargetedDragPreview> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("textDroppableView:previewForDroppingAllItemsWithDefault:"), textDroppableView__handle__, defaultPreview__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (textDroppableView);
			GC.KeepAlive (defaultPreview);
			return ret!;
		}
		/// <param name="textDroppableView">The receiving view.</param><param name="session">The session that entered.</param><summary>Method that is called when the drop point enters the text view.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DropSessionDidEnter (this IUITextDropDelegate This, IUITextDroppable textDroppableView, IUIDropSession session)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var textDroppableView__handle__ = textDroppableView!.GetNonNullHandle (nameof (textDroppableView));
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("textDroppableView:dropSessionDidEnter:"), textDroppableView__handle__, session__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (textDroppableView);
			GC.KeepAlive (session);
		}
		/// <param name="textDroppableView">The receiving view.</param><param name="session">The session that was updated.</param><summary>Method that is called when the drop point over the text view changes.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DropSessionDidUpdate (this IUITextDropDelegate This, IUITextDroppable textDroppableView, IUIDropSession session)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var textDroppableView__handle__ = textDroppableView!.GetNonNullHandle (nameof (textDroppableView));
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("textDroppableView:dropSessionDidUpdate:"), textDroppableView__handle__, session__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (textDroppableView);
			GC.KeepAlive (session);
		}
		/// <param name="textDroppableView">The previously receiving view.</param><param name="session">The session that exited.</param><summary>Method that is called when the drop point leaves the text view.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DropSessionDidExit (this IUITextDropDelegate This, IUITextDroppable textDroppableView, IUIDropSession session)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var textDroppableView__handle__ = textDroppableView!.GetNonNullHandle (nameof (textDroppableView));
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("textDroppableView:dropSessionDidExit:"), textDroppableView__handle__, session__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (textDroppableView);
			GC.KeepAlive (session);
		}
		/// <param name="textDroppableView">The destination view.</param><param name="session">The drop session that ended.</param><summary>Method that is called when the drop session ends.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DropSessionDidEnd (this IUITextDropDelegate This, IUITextDroppable textDroppableView, IUIDropSession session)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var textDroppableView__handle__ = textDroppableView!.GetNonNullHandle (nameof (textDroppableView));
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("textDroppableView:dropSessionDidEnd:"), textDroppableView__handle__, session__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (textDroppableView);
			GC.KeepAlive (session);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class UITextDropDelegateWrapper : BaseWrapper, IUITextDropDelegate {
		public UITextDropDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UITextDropDelegateWrapper))]
		static UITextDropDelegateWrapper ()
		{
			GC.KeepAlive (null);
		}
	}
}
namespace UIKit {
	/// <summary>Delegate for handling drops to text views.</summary>
	[Protocol()]
	[Register("Microsoft_iOS__UIKit_UITextDropDelegate", false)]
	[Model]
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	public unsafe partial class UITextDropDelegate : NSObject, IUITextDropDelegate {
		/// <summary>Creates a new <see cref="UITextDropDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public UITextDropDelegate () : base (NSObjectFlag.Empty)
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
		protected UITextDropDelegate (NSObjectFlag t) : base (t)
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
		protected internal UITextDropDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		/// <param name="textDroppableView">The destination view.</param><param name="session">The drop session that ended.</param><summary>Method that is called when the drop session ends.</summary><remarks>To be added.</remarks>
		[Export ("textDroppableView:dropSessionDidEnd:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DropSessionDidEnd (IUITextDroppable textDroppableView, IUIDropSession session)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="textDroppableView">The receiving view.</param><param name="session">The session that entered.</param><summary>Method that is called when the drop point enters the text view.</summary><remarks>To be added.</remarks>
		[Export ("textDroppableView:dropSessionDidEnter:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DropSessionDidEnter (IUITextDroppable textDroppableView, IUIDropSession session)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="textDroppableView">The previously receiving view.</param><param name="session">The session that exited.</param><summary>Method that is called when the drop point leaves the text view.</summary><remarks>To be added.</remarks>
		[Export ("textDroppableView:dropSessionDidExit:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DropSessionDidExit (IUITextDroppable textDroppableView, IUIDropSession session)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="textDroppableView">The receiving view.</param><param name="session">The session that was updated.</param><summary>Method that is called when the drop point over the text view changes.</summary><remarks>To be added.</remarks>
		[Export ("textDroppableView:dropSessionDidUpdate:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DropSessionDidUpdate (IUITextDroppable textDroppableView, IUIDropSession session)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="textDroppableView">The receiving view.</param><param name="defaultPreview">The system-provided default preview.</param><summary>Method that is called once to get the drag preview to use for dropping all the items.</summary><returns><para>Developers can return <see langword="null" /> to cause the default preview to be used.</para></returns><remarks>To be added.</remarks>
		[Export ("textDroppableView:previewForDroppingAllItemsWithDefault:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UITargetedDragPreview? GetPreviewForDroppingAllItems (IUITextDroppable textDroppableView, UITargetedDragPreview defaultPreview)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="textDroppableView">The receiving view.</param><param name="drop">The drop request for which to get a proposal.</param><summary>Method that is called to get the drop proposal.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("textDroppableView:proposalForDrop:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UITextDropProposal GetProposalForDrop (IUITextDroppable textDroppableView, IUITextDropRequest drop)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="textDroppableView">The currently non-editable receiving view.</param><param name="drop">The drop request.</param><summary>Method that is called to determine whether a non-editable text view can accept drops.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("textDroppableView:willBecomeEditableForDrop:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UITextDropEditability WillBecomeEditable (IUITextDroppable textDroppableView, IUITextDropRequest drop)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="textDroppableView">The receiving view.</param><param name="drop">The drop request.</param><summary>Method that is called just before the drop is performed.</summary><remarks>To be added.</remarks>
		[Export ("textDroppableView:willPerformDrop:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillPerformDrop (IUITextDroppable textDroppableView, IUITextDropRequest drop)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class UITextDropDelegate */
}
