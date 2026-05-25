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
	/// <summary>Delegate object for drag interaction events.</summary>
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[Protocol (Name = "UIDragInteractionDelegate", WrapperType = typeof (UIDragInteractionDelegateWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetItemsForBeginningSession", Selector = "dragInteraction:itemsForBeginningSession:", ReturnType = typeof (UIDragItem[]), ParameterType = new Type [] { typeof (UIDragInteraction), typeof (IUIDragSession) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetPreviewForLiftingItem", Selector = "dragInteraction:previewForLiftingItem:session:", ReturnType = typeof (UITargetedDragPreview), ParameterType = new Type [] { typeof (UIDragInteraction), typeof (UIDragItem), typeof (IUIDragSession) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillAnimateLift", Selector = "dragInteraction:willAnimateLiftWithAnimator:session:", ParameterType = new Type [] { typeof (UIDragInteraction), typeof (IUIDragAnimating), typeof (IUIDragSession) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "SessionWillBegin", Selector = "dragInteraction:sessionWillBegin:", ParameterType = new Type [] { typeof (UIDragInteraction), typeof (IUIDragSession) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "SessionAllowsMoveOperation", Selector = "dragInteraction:sessionAllowsMoveOperation:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (UIDragInteraction), typeof (IUIDragSession) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "SessionIsRestrictedToDraggingApplication", Selector = "dragInteraction:sessionIsRestrictedToDraggingApplication:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (UIDragInteraction), typeof (IUIDragSession) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "PrefersFullSizePreviews", Selector = "dragInteraction:prefersFullSizePreviewsForSession:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (UIDragInteraction), typeof (IUIDragSession) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "SessionDidMove", Selector = "dragInteraction:sessionDidMove:", ParameterType = new Type [] { typeof (UIDragInteraction), typeof (IUIDragSession) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "SessionWillEnd", Selector = "dragInteraction:session:willEndWithOperation:", ParameterType = new Type [] { typeof (UIDragInteraction), typeof (IUIDragSession), typeof (UIDropOperation) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "SessionDidEnd", Selector = "dragInteraction:session:didEndWithOperation:", ParameterType = new Type [] { typeof (UIDragInteraction), typeof (IUIDragSession), typeof (UIDropOperation) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "SessionDidTransferItems", Selector = "dragInteraction:sessionDidTransferItems:", ParameterType = new Type [] { typeof (UIDragInteraction), typeof (IUIDragSession) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetItemsForAddingToSession", Selector = "dragInteraction:itemsForAddingToSession:withTouchAtPoint:", ReturnType = typeof (UIDragItem[]), ParameterType = new Type [] { typeof (UIDragInteraction), typeof (IUIDragSession), typeof (CGPoint) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetSessionForAddingItems", Selector = "dragInteraction:sessionForAddingItems:withTouchAtPoint:", ReturnType = typeof (IUIDragSession), ParameterType = new Type [] { typeof (UIDragInteraction), typeof (IUIDragSession[]), typeof (CGPoint) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillAddItems", Selector = "dragInteraction:session:willAddItems:forInteraction:", ParameterType = new Type [] { typeof (UIDragInteraction), typeof (IUIDragSession), typeof (UIDragItem[]), typeof (UIDragInteraction) }, ParameterByRef = new bool [] { false, false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetPreviewForCancellingItem", Selector = "dragInteraction:previewForCancellingItem:withDefault:", ReturnType = typeof (UITargetedDragPreview), ParameterType = new Type [] { typeof (UIDragInteraction), typeof (UIDragItem), typeof (UITargetedDragPreview) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillAnimateCancel", Selector = "dragInteraction:item:willAnimateCancelWithAnimator:", ParameterType = new Type [] { typeof (UIDragInteraction), typeof (UIDragItem), typeof (IUIDragAnimating) }, ParameterByRef = new bool [] { false, false, false })]
	public partial interface IUIDragInteractionDelegate : INativeObject, IDisposable
	{
		/// <param name="interaction">The interaction that is making the request.</param><param name="session">The drag session to add initial items to.</param><summary>Method that is called to get the items that will begin a drag interaction.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("dragInteraction:itemsForBeginningSession:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIDragItem[] GetItemsForBeginningSession (UIDragInteraction interaction, IUIDragSession session)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="interaction">The interaction that is making the request.</param><param name="session">The drag session to add initial items to.</param><summary>Method that is called to get the items that will begin a drag interaction.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static UIDragItem[] _GetItemsForBeginningSession (IUIDragInteractionDelegate This, UIDragInteraction interaction, IUIDragSession session)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var interaction__handle__ = interaction!.GetNonNullHandle (nameof (interaction));
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			UIDragItem[]? ret;
			ret = CFArray.ArrayFromHandle<UIDragItem>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("dragInteraction:itemsForBeginningSession:"), interaction__handle__, session__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (interaction);
			GC.KeepAlive (session);
			return ret!;
		}
		/// <param name="interaction">The interaction that is making the request.</param><param name="item">The item for which to get a preview.</param><param name="session">The drag session.</param><summary>Method that is called to get a targeted drag preview for animating the lift.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("dragInteraction:previewForLiftingItem:session:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UITargetedDragPreview? GetPreviewForLiftingItem (UIDragInteraction interaction, UIDragItem item, IUIDragSession session)
		{
			return _GetPreviewForLiftingItem (this, interaction, item, session);
		}
		/// <param name="interaction">The interaction that is making the request.</param><param name="item">The item for which to get a preview.</param><param name="session">The drag session.</param><summary>Method that is called to get a targeted drag preview for animating the lift.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static UITargetedDragPreview? _GetPreviewForLiftingItem (IUIDragInteractionDelegate This, UIDragInteraction interaction, UIDragItem item, IUIDragSession session)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var interaction__handle__ = interaction!.GetNonNullHandle (nameof (interaction));
			var item__handle__ = item!.GetNonNullHandle (nameof (item));
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			UITargetedDragPreview? ret;
			ret =  Runtime.GetNSObject<UITargetedDragPreview> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("dragInteraction:previewForLiftingItem:session:"), interaction__handle__, item__handle__, session__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (interaction);
			GC.KeepAlive (item);
			GC.KeepAlive (session);
			return ret!;
		}
		/// <param name="interaction">The interaction that is making the request.</param><param name="animator">An animator to run custom parallel animations and in which the developer may optionally add a completion handler.</param><param name="session">The session.</param><summary>Method that is called before each item with a lift preview is about to lift.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("dragInteraction:willAnimateLiftWithAnimator:session:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillAnimateLift (UIDragInteraction interaction, IUIDragAnimating animator, IUIDragSession session)
		{
			_WillAnimateLift (this, interaction, animator, session);
		}
		/// <param name="interaction">The interaction that is making the request.</param><param name="animator">An animator to run custom parallel animations and in which the developer may optionally add a completion handler.</param><param name="session">The session.</param><summary>Method that is called before each item with a lift preview is about to lift.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _WillAnimateLift (IUIDragInteractionDelegate This, UIDragInteraction interaction, IUIDragAnimating animator, IUIDragSession session)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var interaction__handle__ = interaction!.GetNonNullHandle (nameof (interaction));
			var animator__handle__ = animator!.GetNonNullHandle (nameof (animator));
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("dragInteraction:willAnimateLiftWithAnimator:session:"), interaction__handle__, animator__handle__, session__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (interaction);
			GC.KeepAlive (animator);
			GC.KeepAlive (session);
		}
		/// <param name="interaction">The interaction that is making the request.</param><param name="session">The session that will begin.</param><summary>Method that is called when a session is about to begin.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("dragInteraction:sessionWillBegin:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SessionWillBegin (UIDragInteraction interaction, IUIDragSession session)
		{
			_SessionWillBegin (this, interaction, session);
		}
		/// <param name="interaction">The interaction that is making the request.</param><param name="session">The session that will begin.</param><summary>Method that is called when a session is about to begin.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SessionWillBegin (IUIDragInteractionDelegate This, UIDragInteraction interaction, IUIDragSession session)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var interaction__handle__ = interaction!.GetNonNullHandle (nameof (interaction));
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("dragInteraction:sessionWillBegin:"), interaction__handle__, session__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (interaction);
			GC.KeepAlive (session);
		}
		/// <param name="interaction">The interaction that is making the request.</param><param name="session">The session to query.</param><summary>Method that is called to find out if the session allows items to be moved, instead of copied.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("dragInteraction:sessionAllowsMoveOperation:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool SessionAllowsMoveOperation (UIDragInteraction interaction, IUIDragSession session)
		{
			return _SessionAllowsMoveOperation (this, interaction, session);
		}
		/// <param name="interaction">The interaction that is making the request.</param><param name="session">The session to query.</param><summary>Method that is called to find out if the session allows items to be moved, instead of copied.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _SessionAllowsMoveOperation (IUIDragInteractionDelegate This, UIDragInteraction interaction, IUIDragSession session)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var interaction__handle__ = interaction!.GetNonNullHandle (nameof (interaction));
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("dragInteraction:sessionAllowsMoveOperation:"), interaction__handle__, session__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (interaction);
			GC.KeepAlive (session);
			return ret != 0;
		}
		/// <param name="interaction">The interaction that is making the request.</param><param name="session">The session to query.</param><summary>Method that is called to find out if the application only supports drag and drop operations to and from itself.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("dragInteraction:sessionIsRestrictedToDraggingApplication:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool SessionIsRestrictedToDraggingApplication (UIDragInteraction interaction, IUIDragSession session)
		{
			return _SessionIsRestrictedToDraggingApplication (this, interaction, session);
		}
		/// <param name="interaction">The interaction that is making the request.</param><param name="session">The session to query.</param><summary>Method that is called to find out if the application only supports drag and drop operations to and from itself.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _SessionIsRestrictedToDraggingApplication (IUIDragInteractionDelegate This, UIDragInteraction interaction, IUIDragSession session)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var interaction__handle__ = interaction!.GetNonNullHandle (nameof (interaction));
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("dragInteraction:sessionIsRestrictedToDraggingApplication:"), interaction__handle__, session__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (interaction);
			GC.KeepAlive (session);
			return ret != 0;
		}
		/// <param name="interaction">The interaction that is making the request.</param><param name="session">The session to query.</param><summary>Method that is called to find out whether the application prefers full size previews in the source view.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("dragInteraction:prefersFullSizePreviewsForSession:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool PrefersFullSizePreviews (UIDragInteraction interaction, IUIDragSession session)
		{
			return _PrefersFullSizePreviews (this, interaction, session);
		}
		/// <param name="interaction">The interaction that is making the request.</param><param name="session">The session to query.</param><summary>Method that is called to find out whether the application prefers full size previews in the source view.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _PrefersFullSizePreviews (IUIDragInteractionDelegate This, UIDragInteraction interaction, IUIDragSession session)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var interaction__handle__ = interaction!.GetNonNullHandle (nameof (interaction));
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("dragInteraction:prefersFullSizePreviewsForSession:"), interaction__handle__, session__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (interaction);
			GC.KeepAlive (session);
			return ret != 0;
		}
		/// <param name="interaction">The interaction that is making the request.</param><param name="session">The drag session.</param><summary>Method that is called when the drag point moves.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("dragInteraction:sessionDidMove:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SessionDidMove (UIDragInteraction interaction, IUIDragSession session)
		{
			_SessionDidMove (this, interaction, session);
		}
		/// <param name="interaction">The interaction that is making the request.</param><param name="session">The drag session.</param><summary>Method that is called when the drag point moves.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SessionDidMove (IUIDragInteractionDelegate This, UIDragInteraction interaction, IUIDragSession session)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var interaction__handle__ = interaction!.GetNonNullHandle (nameof (interaction));
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("dragInteraction:sessionDidMove:"), interaction__handle__, session__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (interaction);
			GC.KeepAlive (session);
		}
		/// <param name="interaction">The interaction that is making the request.</param><param name="session">The session that will end.</param><param name="operation">The operation that will end the session.</param><summary>Method that is called when a session is about to end.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("dragInteraction:session:willEndWithOperation:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SessionWillEnd (UIDragInteraction interaction, IUIDragSession session, UIDropOperation operation)
		{
			_SessionWillEnd (this, interaction, session, operation);
		}
		/// <param name="interaction">The interaction that is making the request.</param><param name="session">The session that will end.</param><param name="operation">The operation that will end the session.</param><summary>Method that is called when a session is about to end.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SessionWillEnd (IUIDragInteractionDelegate This, UIDragInteraction interaction, IUIDragSession session, UIDropOperation operation)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var interaction__handle__ = interaction!.GetNonNullHandle (nameof (interaction));
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_UIntPtr (This.Handle, Selector.GetHandle ("dragInteraction:session:willEndWithOperation:"), interaction__handle__, session__handle__, (UIntPtr) (ulong) operation);
			GC.KeepAlive (This);
			GC.KeepAlive (interaction);
			GC.KeepAlive (session);
		}
		/// <param name="interaction">The interaction that is making the request.</param><param name="session">The session that ended.</param><param name="operation">The resulting drag and drop operation.</param><summary>Method that is called when the drag session ends.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("dragInteraction:session:didEndWithOperation:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SessionDidEnd (UIDragInteraction interaction, IUIDragSession session, UIDropOperation operation)
		{
			_SessionDidEnd (this, interaction, session, operation);
		}
		/// <param name="interaction">The interaction that is making the request.</param><param name="session">The session that ended.</param><param name="operation">The resulting drag and drop operation.</param><summary>Method that is called when the drag session ends.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SessionDidEnd (IUIDragInteractionDelegate This, UIDragInteraction interaction, IUIDragSession session, UIDropOperation operation)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var interaction__handle__ = interaction!.GetNonNullHandle (nameof (interaction));
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_UIntPtr (This.Handle, Selector.GetHandle ("dragInteraction:session:didEndWithOperation:"), interaction__handle__, session__handle__, (UIntPtr) (ulong) operation);
			GC.KeepAlive (This);
			GC.KeepAlive (interaction);
			GC.KeepAlive (session);
		}
		/// <param name="interaction">The interaction that is making the request.</param><param name="session">The session that ended and transferred the items.</param><summary>Method that is called after the dropped items have been received.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("dragInteraction:sessionDidTransferItems:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SessionDidTransferItems (UIDragInteraction interaction, IUIDragSession session)
		{
			_SessionDidTransferItems (this, interaction, session);
		}
		/// <param name="interaction">The interaction that is making the request.</param><param name="session">The session that ended and transferred the items.</param><summary>Method that is called after the dropped items have been received.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SessionDidTransferItems (IUIDragInteractionDelegate This, UIDragInteraction interaction, IUIDragSession session)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var interaction__handle__ = interaction!.GetNonNullHandle (nameof (interaction));
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("dragInteraction:sessionDidTransferItems:"), interaction__handle__, session__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (interaction);
			GC.KeepAlive (session);
		}
		/// <param name="interaction">The interaction that is making the request.</param><param name="session">The session to which to add items.</param><param name="point">The touch location in the view's coordinate system.</param><summary>Method that is called to add drag items to a drag session in response to a gesture by the user.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("dragInteraction:itemsForAddingToSession:withTouchAtPoint:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIDragItem[] GetItemsForAddingToSession (UIDragInteraction interaction, IUIDragSession session, CGPoint point)
		{
			return _GetItemsForAddingToSession (this, interaction, session, point);
		}
		/// <param name="interaction">The interaction that is making the request.</param><param name="session">The session to which to add items.</param><param name="point">The touch location in the view's coordinate system.</param><summary>Method that is called to add drag items to a drag session in response to a gesture by the user.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static UIDragItem[] _GetItemsForAddingToSession (IUIDragInteractionDelegate This, UIDragInteraction interaction, IUIDragSession session, CGPoint point)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var interaction__handle__ = interaction!.GetNonNullHandle (nameof (interaction));
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			UIDragItem[]? ret;
			ret = CFArray.ArrayFromHandle<UIDragItem>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_CGPoint (This.Handle, Selector.GetHandle ("dragInteraction:itemsForAddingToSession:withTouchAtPoint:"), interaction__handle__, session__handle__, point), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (interaction);
			GC.KeepAlive (session);
			return ret!;
		}
		/// <param name="interaction">The interaction that is making the request.</param><param name="sessions">The sessions from which to choose.</param><param name="point">The touch point in the view's coordinate system.</param><summary>Method that is called to disambiguate to which session to add items when multiple sessions are active.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("dragInteraction:sessionForAddingItems:withTouchAtPoint:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual IUIDragSession? GetSessionForAddingItems (UIDragInteraction interaction, IUIDragSession[] sessions, CGPoint point)
		{
			return _GetSessionForAddingItems (this, interaction, sessions, point);
		}
		/// <param name="interaction">The interaction that is making the request.</param><param name="sessions">The sessions from which to choose.</param><param name="point">The touch point in the view's coordinate system.</param><summary>Method that is called to disambiguate to which session to add items when multiple sessions are active.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static IUIDragSession? _GetSessionForAddingItems (IUIDragInteractionDelegate This, UIDragInteraction interaction, IUIDragSession[] sessions, CGPoint point)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var interaction__handle__ = interaction!.GetNonNullHandle (nameof (interaction));
			if (sessions is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (sessions));
			using var nsa_sessions = NSArray.FromNSObjects (sessions);
			IUIDragSession? ret;
			ret =  Runtime.GetINativeObject<IUIDragSession> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_CGPoint (This.Handle, Selector.GetHandle ("dragInteraction:sessionForAddingItems:withTouchAtPoint:"), interaction__handle__, nsa_sessions.Handle, point), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (interaction);
			return ret!;
		}
		/// <param name="interaction">The interaction that is making the request.</param><param name="session">The session to which items will be added.</param><param name="items">The items to add.</param><param name="addingInteraction">The interaction that will add the items.</param><summary>Method that is called when items are about to be added to the session.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("dragInteraction:session:willAddItems:forInteraction:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillAddItems (UIDragInteraction interaction, IUIDragSession session, UIDragItem[] items, UIDragInteraction addingInteraction)
		{
			_WillAddItems (this, interaction, session, items, addingInteraction);
		}
		/// <param name="interaction">The interaction that is making the request.</param><param name="session">The session to which items will be added.</param><param name="items">The items to add.</param><param name="addingInteraction">The interaction that will add the items.</param><summary>Method that is called when items are about to be added to the session.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _WillAddItems (IUIDragInteractionDelegate This, UIDragInteraction interaction, IUIDragSession session, UIDragItem[] items, UIDragInteraction addingInteraction)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var interaction__handle__ = interaction!.GetNonNullHandle (nameof (interaction));
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			if (items is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (items));
			var addingInteraction__handle__ = addingInteraction!.GetNonNullHandle (nameof (addingInteraction));
			using var nsa_items = NSArray.FromNSObjects (items);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("dragInteraction:session:willAddItems:forInteraction:"), interaction__handle__, session__handle__, nsa_items.Handle, addingInteraction__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (interaction);
			GC.KeepAlive (session);
			GC.KeepAlive (addingInteraction);
		}
		/// <param name="interaction">The interaction that is making the request.</param><param name="item">The item for which to get a preview.</param><param name="defaultPreview">The default drag preview for the item.</param><summary>Method that is called for each visible item in a drag session when the user cancels the drag session.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("dragInteraction:previewForCancellingItem:withDefault:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UITargetedDragPreview? GetPreviewForCancellingItem (UIDragInteraction interaction, UIDragItem item, UITargetedDragPreview defaultPreview)
		{
			return _GetPreviewForCancellingItem (this, interaction, item, defaultPreview);
		}
		/// <param name="interaction">The interaction that is making the request.</param><param name="item">The item for which to get a preview.</param><param name="defaultPreview">The default drag preview for the item.</param><summary>Method that is called for each visible item in a drag session when the user cancels the drag session.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static UITargetedDragPreview? _GetPreviewForCancellingItem (IUIDragInteractionDelegate This, UIDragInteraction interaction, UIDragItem item, UITargetedDragPreview defaultPreview)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var interaction__handle__ = interaction!.GetNonNullHandle (nameof (interaction));
			var item__handle__ = item!.GetNonNullHandle (nameof (item));
			var defaultPreview__handle__ = defaultPreview!.GetNonNullHandle (nameof (defaultPreview));
			UITargetedDragPreview? ret;
			ret =  Runtime.GetNSObject<UITargetedDragPreview> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("dragInteraction:previewForCancellingItem:withDefault:"), interaction__handle__, item__handle__, defaultPreview__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (interaction);
			GC.KeepAlive (item);
			GC.KeepAlive (defaultPreview);
			return ret!;
		}
		/// <param name="interaction">The interaction that is making the request.</param><param name="item">The item whose cancellation will be animated.</param><param name="animator">An animator to run custom parallel animations and in which the developer may optionally add a completion handler.</param><summary>Method that is called before the animation of each item in a cancellation begins.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("dragInteraction:item:willAnimateCancelWithAnimator:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillAnimateCancel (UIDragInteraction interaction, UIDragItem item, IUIDragAnimating animator)
		{
			_WillAnimateCancel (this, interaction, item, animator);
		}
		/// <param name="interaction">The interaction that is making the request.</param><param name="item">The item whose cancellation will be animated.</param><param name="animator">An animator to run custom parallel animations and in which the developer may optionally add a completion handler.</param><summary>Method that is called before the animation of each item in a cancellation begins.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _WillAnimateCancel (IUIDragInteractionDelegate This, UIDragInteraction interaction, UIDragItem item, IUIDragAnimating animator)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var interaction__handle__ = interaction!.GetNonNullHandle (nameof (interaction));
			var item__handle__ = item!.GetNonNullHandle (nameof (item));
			var animator__handle__ = animator!.GetNonNullHandle (nameof (animator));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("dragInteraction:item:willAnimateCancelWithAnimator:"), interaction__handle__, item__handle__, animator__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (interaction);
			GC.KeepAlive (item);
			GC.KeepAlive (animator);
		}
		[DynamicDependencyAttribute ("GetItemsForAddingToSession(UIKit.UIDragInteraction,UIKit.IUIDragSession,CoreGraphics.CGPoint)")]
		[DynamicDependencyAttribute ("GetItemsForBeginningSession(UIKit.UIDragInteraction,UIKit.IUIDragSession)")]
		[DynamicDependencyAttribute ("GetPreviewForCancellingItem(UIKit.UIDragInteraction,UIKit.UIDragItem,UIKit.UITargetedDragPreview)")]
		[DynamicDependencyAttribute ("GetPreviewForLiftingItem(UIKit.UIDragInteraction,UIKit.UIDragItem,UIKit.IUIDragSession)")]
		[DynamicDependencyAttribute ("GetSessionForAddingItems(UIKit.UIDragInteraction,UIKit.IUIDragSession[],CoreGraphics.CGPoint)")]
		[DynamicDependencyAttribute ("PrefersFullSizePreviews(UIKit.UIDragInteraction,UIKit.IUIDragSession)")]
		[DynamicDependencyAttribute ("SessionAllowsMoveOperation(UIKit.UIDragInteraction,UIKit.IUIDragSession)")]
		[DynamicDependencyAttribute ("SessionDidEnd(UIKit.UIDragInteraction,UIKit.IUIDragSession,UIKit.UIDropOperation)")]
		[DynamicDependencyAttribute ("SessionDidMove(UIKit.UIDragInteraction,UIKit.IUIDragSession)")]
		[DynamicDependencyAttribute ("SessionDidTransferItems(UIKit.UIDragInteraction,UIKit.IUIDragSession)")]
		[DynamicDependencyAttribute ("SessionIsRestrictedToDraggingApplication(UIKit.UIDragInteraction,UIKit.IUIDragSession)")]
		[DynamicDependencyAttribute ("SessionWillBegin(UIKit.UIDragInteraction,UIKit.IUIDragSession)")]
		[DynamicDependencyAttribute ("SessionWillEnd(UIKit.UIDragInteraction,UIKit.IUIDragSession,UIKit.UIDropOperation)")]
		[DynamicDependencyAttribute ("WillAddItems(UIKit.UIDragInteraction,UIKit.IUIDragSession,UIKit.UIDragItem[],UIKit.UIDragInteraction)")]
		[DynamicDependencyAttribute ("WillAnimateCancel(UIKit.UIDragInteraction,UIKit.UIDragItem,UIKit.IUIDragAnimating)")]
		[DynamicDependencyAttribute ("WillAnimateLift(UIKit.UIDragInteraction,UIKit.IUIDragAnimating,UIKit.IUIDragSession)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UIDragInteractionDelegateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IUIDragInteractionDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="IUIDragInteractionDelegate" /> interface to support all the methods from the UIDragInteractionDelegate protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IUIDragInteractionDelegate" /> interface allow developers to treat instances of the interface as having all the optional methods of the original UIDragInteractionDelegate protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class UIDragInteractionDelegate_Extensions {
		/// <param name="interaction">The interaction that is making the request.</param><param name="item">The item for which to get a preview.</param><param name="session">The drag session.</param><summary>Method that is called to get a targeted drag preview for animating the lift.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static UITargetedDragPreview? GetPreviewForLiftingItem (this IUIDragInteractionDelegate This, UIDragInteraction interaction, UIDragItem item, IUIDragSession session)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var interaction__handle__ = interaction!.GetNonNullHandle (nameof (interaction));
			var item__handle__ = item!.GetNonNullHandle (nameof (item));
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			UITargetedDragPreview? ret;
			ret =  Runtime.GetNSObject<UITargetedDragPreview> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("dragInteraction:previewForLiftingItem:session:"), interaction__handle__, item__handle__, session__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (interaction);
			GC.KeepAlive (item);
			GC.KeepAlive (session);
			return ret!;
		}
		/// <param name="interaction">The interaction that is making the request.</param><param name="animator">An animator to run custom parallel animations and in which the developer may optionally add a completion handler.</param><param name="session">The session.</param><summary>Method that is called before each item with a lift preview is about to lift.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void WillAnimateLift (this IUIDragInteractionDelegate This, UIDragInteraction interaction, IUIDragAnimating animator, IUIDragSession session)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var interaction__handle__ = interaction!.GetNonNullHandle (nameof (interaction));
			var animator__handle__ = animator!.GetNonNullHandle (nameof (animator));
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("dragInteraction:willAnimateLiftWithAnimator:session:"), interaction__handle__, animator__handle__, session__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (interaction);
			GC.KeepAlive (animator);
			GC.KeepAlive (session);
		}
		/// <param name="interaction">The interaction that is making the request.</param><param name="session">The session that will begin.</param><summary>Method that is called when a session is about to begin.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SessionWillBegin (this IUIDragInteractionDelegate This, UIDragInteraction interaction, IUIDragSession session)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var interaction__handle__ = interaction!.GetNonNullHandle (nameof (interaction));
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("dragInteraction:sessionWillBegin:"), interaction__handle__, session__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (interaction);
			GC.KeepAlive (session);
		}
		/// <param name="interaction">The interaction that is making the request.</param><param name="session">The session to query.</param><summary>Method that is called to find out if the session allows items to be moved, instead of copied.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool SessionAllowsMoveOperation (this IUIDragInteractionDelegate This, UIDragInteraction interaction, IUIDragSession session)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var interaction__handle__ = interaction!.GetNonNullHandle (nameof (interaction));
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("dragInteraction:sessionAllowsMoveOperation:"), interaction__handle__, session__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (interaction);
			GC.KeepAlive (session);
			return ret != 0;
		}
		/// <param name="interaction">The interaction that is making the request.</param><param name="session">The session to query.</param><summary>Method that is called to find out if the application only supports drag and drop operations to and from itself.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool SessionIsRestrictedToDraggingApplication (this IUIDragInteractionDelegate This, UIDragInteraction interaction, IUIDragSession session)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var interaction__handle__ = interaction!.GetNonNullHandle (nameof (interaction));
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("dragInteraction:sessionIsRestrictedToDraggingApplication:"), interaction__handle__, session__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (interaction);
			GC.KeepAlive (session);
			return ret != 0;
		}
		/// <param name="interaction">The interaction that is making the request.</param><param name="session">The session to query.</param><summary>Method that is called to find out whether the application prefers full size previews in the source view.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool PrefersFullSizePreviews (this IUIDragInteractionDelegate This, UIDragInteraction interaction, IUIDragSession session)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var interaction__handle__ = interaction!.GetNonNullHandle (nameof (interaction));
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("dragInteraction:prefersFullSizePreviewsForSession:"), interaction__handle__, session__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (interaction);
			GC.KeepAlive (session);
			return ret != 0;
		}
		/// <param name="interaction">The interaction that is making the request.</param><param name="session">The drag session.</param><summary>Method that is called when the drag point moves.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SessionDidMove (this IUIDragInteractionDelegate This, UIDragInteraction interaction, IUIDragSession session)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var interaction__handle__ = interaction!.GetNonNullHandle (nameof (interaction));
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("dragInteraction:sessionDidMove:"), interaction__handle__, session__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (interaction);
			GC.KeepAlive (session);
		}
		/// <param name="interaction">The interaction that is making the request.</param><param name="session">The session that will end.</param><param name="operation">The operation that will end the session.</param><summary>Method that is called when a session is about to end.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SessionWillEnd (this IUIDragInteractionDelegate This, UIDragInteraction interaction, IUIDragSession session, UIDropOperation operation)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var interaction__handle__ = interaction!.GetNonNullHandle (nameof (interaction));
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_UIntPtr (This.Handle, Selector.GetHandle ("dragInteraction:session:willEndWithOperation:"), interaction__handle__, session__handle__, (UIntPtr) (ulong) operation);
			GC.KeepAlive (This);
			GC.KeepAlive (interaction);
			GC.KeepAlive (session);
		}
		/// <param name="interaction">The interaction that is making the request.</param><param name="session">The session that ended.</param><param name="operation">The resulting drag and drop operation.</param><summary>Method that is called when the drag session ends.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SessionDidEnd (this IUIDragInteractionDelegate This, UIDragInteraction interaction, IUIDragSession session, UIDropOperation operation)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var interaction__handle__ = interaction!.GetNonNullHandle (nameof (interaction));
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_UIntPtr (This.Handle, Selector.GetHandle ("dragInteraction:session:didEndWithOperation:"), interaction__handle__, session__handle__, (UIntPtr) (ulong) operation);
			GC.KeepAlive (This);
			GC.KeepAlive (interaction);
			GC.KeepAlive (session);
		}
		/// <param name="interaction">The interaction that is making the request.</param><param name="session">The session that ended and transferred the items.</param><summary>Method that is called after the dropped items have been received.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SessionDidTransferItems (this IUIDragInteractionDelegate This, UIDragInteraction interaction, IUIDragSession session)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var interaction__handle__ = interaction!.GetNonNullHandle (nameof (interaction));
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("dragInteraction:sessionDidTransferItems:"), interaction__handle__, session__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (interaction);
			GC.KeepAlive (session);
		}
		/// <param name="interaction">The interaction that is making the request.</param><param name="session">The session to which to add items.</param><param name="point">The touch location in the view's coordinate system.</param><summary>Method that is called to add drag items to a drag session in response to a gesture by the user.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static UIDragItem[] GetItemsForAddingToSession (this IUIDragInteractionDelegate This, UIDragInteraction interaction, IUIDragSession session, CGPoint point)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var interaction__handle__ = interaction!.GetNonNullHandle (nameof (interaction));
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			UIDragItem[]? ret;
			ret = CFArray.ArrayFromHandle<UIDragItem>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_CGPoint (This.Handle, Selector.GetHandle ("dragInteraction:itemsForAddingToSession:withTouchAtPoint:"), interaction__handle__, session__handle__, point), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (interaction);
			GC.KeepAlive (session);
			return ret!;
		}
		/// <param name="interaction">The interaction that is making the request.</param><param name="sessions">The sessions from which to choose.</param><param name="point">The touch point in the view's coordinate system.</param><summary>Method that is called to disambiguate to which session to add items when multiple sessions are active.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static IUIDragSession? GetSessionForAddingItems (this IUIDragInteractionDelegate This, UIDragInteraction interaction, IUIDragSession[] sessions, CGPoint point)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var interaction__handle__ = interaction!.GetNonNullHandle (nameof (interaction));
			if (sessions is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (sessions));
			using var nsa_sessions = NSArray.FromNSObjects (sessions);
			IUIDragSession? ret;
			ret =  Runtime.GetINativeObject<IUIDragSession> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_CGPoint (This.Handle, Selector.GetHandle ("dragInteraction:sessionForAddingItems:withTouchAtPoint:"), interaction__handle__, nsa_sessions.Handle, point), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (interaction);
			return ret!;
		}
		/// <param name="interaction">The interaction that is making the request.</param><param name="session">The session to which items will be added.</param><param name="items">The items to add.</param><param name="addingInteraction">The interaction that will add the items.</param><summary>Method that is called when items are about to be added to the session.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void WillAddItems (this IUIDragInteractionDelegate This, UIDragInteraction interaction, IUIDragSession session, UIDragItem[] items, UIDragInteraction addingInteraction)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var interaction__handle__ = interaction!.GetNonNullHandle (nameof (interaction));
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			if (items is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (items));
			var addingInteraction__handle__ = addingInteraction!.GetNonNullHandle (nameof (addingInteraction));
			using var nsa_items = NSArray.FromNSObjects (items);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("dragInteraction:session:willAddItems:forInteraction:"), interaction__handle__, session__handle__, nsa_items.Handle, addingInteraction__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (interaction);
			GC.KeepAlive (session);
			GC.KeepAlive (addingInteraction);
		}
		/// <param name="interaction">The interaction that is making the request.</param><param name="item">The item for which to get a preview.</param><param name="defaultPreview">The default drag preview for the item.</param><summary>Method that is called for each visible item in a drag session when the user cancels the drag session.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static UITargetedDragPreview? GetPreviewForCancellingItem (this IUIDragInteractionDelegate This, UIDragInteraction interaction, UIDragItem item, UITargetedDragPreview defaultPreview)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var interaction__handle__ = interaction!.GetNonNullHandle (nameof (interaction));
			var item__handle__ = item!.GetNonNullHandle (nameof (item));
			var defaultPreview__handle__ = defaultPreview!.GetNonNullHandle (nameof (defaultPreview));
			UITargetedDragPreview? ret;
			ret =  Runtime.GetNSObject<UITargetedDragPreview> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("dragInteraction:previewForCancellingItem:withDefault:"), interaction__handle__, item__handle__, defaultPreview__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (interaction);
			GC.KeepAlive (item);
			GC.KeepAlive (defaultPreview);
			return ret!;
		}
		/// <param name="interaction">The interaction that is making the request.</param><param name="item">The item whose cancellation will be animated.</param><param name="animator">An animator to run custom parallel animations and in which the developer may optionally add a completion handler.</param><summary>Method that is called before the animation of each item in a cancellation begins.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void WillAnimateCancel (this IUIDragInteractionDelegate This, UIDragInteraction interaction, UIDragItem item, IUIDragAnimating animator)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var interaction__handle__ = interaction!.GetNonNullHandle (nameof (interaction));
			var item__handle__ = item!.GetNonNullHandle (nameof (item));
			var animator__handle__ = animator!.GetNonNullHandle (nameof (animator));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("dragInteraction:item:willAnimateCancelWithAnimator:"), interaction__handle__, item__handle__, animator__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (interaction);
			GC.KeepAlive (item);
			GC.KeepAlive (animator);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class UIDragInteractionDelegateWrapper : BaseWrapper, IUIDragInteractionDelegate {
		public UIDragInteractionDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UIDragInteractionDelegateWrapper))]
		static UIDragInteractionDelegateWrapper ()
		{
			GC.KeepAlive (null);
		}
		/// <param name="interaction">The interaction that is making the request.</param><param name="session">The drag session to add initial items to.</param><summary>Method that is called to get the items that will begin a drag interaction.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("dragInteraction:itemsForBeginningSession:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public UIDragItem[] GetItemsForBeginningSession (UIDragInteraction interaction, IUIDragSession session)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var interaction__handle__ = interaction!.GetNonNullHandle (nameof (interaction));
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			UIDragItem[]? ret;
			ret = CFArray.ArrayFromHandle<UIDragItem>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("dragInteraction:itemsForBeginningSession:"), interaction__handle__, session__handle__), false)!;
			GC.KeepAlive (interaction);
			GC.KeepAlive (session);
			return ret!;
		}
	}
}
namespace UIKit {
	/// <summary>Delegate object for drag interaction events.</summary>
	[Protocol()]
	[Register("Microsoft_MacCatalyst__UIKit_UIDragInteractionDelegate", false)]
	[Model]
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	public unsafe abstract partial class UIDragInteractionDelegate : NSObject, IUIDragInteractionDelegate {
		/// <summary>Creates a new <see cref="UIDragInteractionDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected UIDragInteractionDelegate () : base (NSObjectFlag.Empty)
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
		protected UIDragInteractionDelegate (NSObjectFlag t) : base (t)
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
		protected internal UIDragInteractionDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		/// <param name="interaction">The interaction that is making the request.</param><param name="session">The session to which to add items.</param><param name="point">The touch location in the view's coordinate system.</param><summary>Method that is called to add drag items to a drag session in response to a gesture by the user.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("dragInteraction:itemsForAddingToSession:withTouchAtPoint:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIDragItem[] GetItemsForAddingToSession (UIDragInteraction interaction, IUIDragSession session, CGPoint point)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="interaction">The interaction that is making the request.</param><param name="session">The drag session to add initial items to.</param><summary>Method that is called to get the items that will begin a drag interaction.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("dragInteraction:itemsForBeginningSession:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIDragItem[] GetItemsForBeginningSession (UIDragInteraction interaction, IUIDragSession session)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="interaction">The interaction that is making the request.</param><param name="item">The item for which to get a preview.</param><param name="defaultPreview">The default drag preview for the item.</param><summary>Method that is called for each visible item in a drag session when the user cancels the drag session.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("dragInteraction:previewForCancellingItem:withDefault:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UITargetedDragPreview? GetPreviewForCancellingItem (UIDragInteraction interaction, UIDragItem item, UITargetedDragPreview defaultPreview)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="interaction">The interaction that is making the request.</param><param name="item">The item for which to get a preview.</param><param name="session">The drag session.</param><summary>Method that is called to get a targeted drag preview for animating the lift.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("dragInteraction:previewForLiftingItem:session:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UITargetedDragPreview? GetPreviewForLiftingItem (UIDragInteraction interaction, UIDragItem item, IUIDragSession session)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="interaction">The interaction that is making the request.</param><param name="sessions">The sessions from which to choose.</param><param name="point">The touch point in the view's coordinate system.</param><summary>Method that is called to disambiguate to which session to add items when multiple sessions are active.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("dragInteraction:sessionForAddingItems:withTouchAtPoint:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual IUIDragSession? GetSessionForAddingItems (UIDragInteraction interaction, IUIDragSession[] sessions, CGPoint point)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="interaction">The interaction that is making the request.</param><param name="session">The session to query.</param><summary>Method that is called to find out whether the application prefers full size previews in the source view.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("dragInteraction:prefersFullSizePreviewsForSession:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool PrefersFullSizePreviews (UIDragInteraction interaction, IUIDragSession session)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="interaction">The interaction that is making the request.</param><param name="session">The session to query.</param><summary>Method that is called to find out if the session allows items to be moved, instead of copied.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("dragInteraction:sessionAllowsMoveOperation:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool SessionAllowsMoveOperation (UIDragInteraction interaction, IUIDragSession session)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="interaction">The interaction that is making the request.</param><param name="session">The session that ended.</param><param name="operation">The resulting drag and drop operation.</param><summary>Method that is called when the drag session ends.</summary><remarks>To be added.</remarks>
		[Export ("dragInteraction:session:didEndWithOperation:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SessionDidEnd (UIDragInteraction interaction, IUIDragSession session, UIDropOperation operation)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="interaction">The interaction that is making the request.</param><param name="session">The drag session.</param><summary>Method that is called when the drag point moves.</summary><remarks>To be added.</remarks>
		[Export ("dragInteraction:sessionDidMove:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SessionDidMove (UIDragInteraction interaction, IUIDragSession session)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="interaction">The interaction that is making the request.</param><param name="session">The session that ended and transferred the items.</param><summary>Method that is called after the dropped items have been received.</summary><remarks>To be added.</remarks>
		[Export ("dragInteraction:sessionDidTransferItems:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SessionDidTransferItems (UIDragInteraction interaction, IUIDragSession session)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="interaction">The interaction that is making the request.</param><param name="session">The session to query.</param><summary>Method that is called to find out if the application only supports drag and drop operations to and from itself.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("dragInteraction:sessionIsRestrictedToDraggingApplication:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool SessionIsRestrictedToDraggingApplication (UIDragInteraction interaction, IUIDragSession session)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="interaction">The interaction that is making the request.</param><param name="session">The session that will begin.</param><summary>Method that is called when a session is about to begin.</summary><remarks>To be added.</remarks>
		[Export ("dragInteraction:sessionWillBegin:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SessionWillBegin (UIDragInteraction interaction, IUIDragSession session)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="interaction">The interaction that is making the request.</param><param name="session">The session that will end.</param><param name="operation">The operation that will end the session.</param><summary>Method that is called when a session is about to end.</summary><remarks>To be added.</remarks>
		[Export ("dragInteraction:session:willEndWithOperation:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SessionWillEnd (UIDragInteraction interaction, IUIDragSession session, UIDropOperation operation)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="interaction">The interaction that is making the request.</param><param name="session">The session to which items will be added.</param><param name="items">The items to add.</param><param name="addingInteraction">The interaction that will add the items.</param><summary>Method that is called when items are about to be added to the session.</summary><remarks>To be added.</remarks>
		[Export ("dragInteraction:session:willAddItems:forInteraction:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillAddItems (UIDragInteraction interaction, IUIDragSession session, UIDragItem[] items, UIDragInteraction addingInteraction)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="interaction">The interaction that is making the request.</param><param name="item">The item whose cancellation will be animated.</param><param name="animator">An animator to run custom parallel animations and in which the developer may optionally add a completion handler.</param><summary>Method that is called before the animation of each item in a cancellation begins.</summary><remarks>To be added.</remarks>
		[Export ("dragInteraction:item:willAnimateCancelWithAnimator:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillAnimateCancel (UIDragInteraction interaction, UIDragItem item, IUIDragAnimating animator)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="interaction">The interaction that is making the request.</param><param name="animator">An animator to run custom parallel animations and in which the developer may optionally add a completion handler.</param><param name="session">The session.</param><summary>Method that is called before each item with a lift preview is about to lift.</summary><remarks>To be added.</remarks>
		[Export ("dragInteraction:willAnimateLiftWithAnimator:session:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillAnimateLift (UIDragInteraction interaction, IUIDragAnimating animator, IUIDragSession session)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class UIDragInteractionDelegate */
}
