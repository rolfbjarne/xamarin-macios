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
	/// <summary>Delegate object for a drop interaction.</summary>
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[Protocol (Name = "UIDropInteractionDelegate", WrapperType = typeof (UIDropInteractionDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "CanHandleSession", Selector = "dropInteraction:canHandleSession:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (UIDropInteraction), typeof (IUIDropSession) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "SessionDidEnter", Selector = "dropInteraction:sessionDidEnter:", ParameterType = new Type [] { typeof (UIDropInteraction), typeof (IUIDropSession) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "SessionDidUpdate", Selector = "dropInteraction:sessionDidUpdate:", ReturnType = typeof (UIDropProposal), ParameterType = new Type [] { typeof (UIDropInteraction), typeof (IUIDropSession) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "SessionDidExit", Selector = "dropInteraction:sessionDidExit:", ParameterType = new Type [] { typeof (UIDropInteraction), typeof (IUIDropSession) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "PerformDrop", Selector = "dropInteraction:performDrop:", ParameterType = new Type [] { typeof (UIDropInteraction), typeof (IUIDropSession) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ConcludeDrop", Selector = "dropInteraction:concludeDrop:", ParameterType = new Type [] { typeof (UIDropInteraction), typeof (IUIDropSession) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "SessionDidEnd", Selector = "dropInteraction:sessionDidEnd:", ParameterType = new Type [] { typeof (UIDropInteraction), typeof (IUIDropSession) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetPreviewForDroppingItem", Selector = "dropInteraction:previewForDroppingItem:withDefault:", ReturnType = typeof (UITargetedDragPreview), ParameterType = new Type [] { typeof (UIDropInteraction), typeof (UIDragItem), typeof (UITargetedDragPreview) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillAnimateDrop", Selector = "dropInteraction:item:willAnimateDropWithAnimator:", ParameterType = new Type [] { typeof (UIDropInteraction), typeof (UIDragItem), typeof (IUIDragAnimating) }, ParameterByRef = new bool [] { false, false, false })]
	public partial interface IUIDropInteractionDelegate : INativeObject, IDisposable
	{
		/// <param name="interaction">The interaction to check.</param><param name="session">The session to query.</param><summary>Returns <see langword="true" /> if the specified <paramref name="interaction" /> can handle the specified <paramref name="session" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("dropInteraction:canHandleSession:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool CanHandleSession (UIDropInteraction interaction, IUIDropSession session)
		{
			return _CanHandleSession (this, interaction, session);
		}
		/// <param name="interaction">The interaction to check.</param><param name="session">The session to query.</param><summary>Returns <see langword="true" /> if the specified <paramref name="interaction" /> can handle the specified <paramref name="session" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _CanHandleSession (IUIDropInteractionDelegate This, UIDropInteraction interaction, IUIDropSession session)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var interaction__handle__ = interaction!.GetNonNullHandle (nameof (interaction));
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("dropInteraction:canHandleSession:"), interaction__handle__, session__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (interaction);
			GC.KeepAlive (session);
			return ret != 0;
		}
		/// <param name="interaction">The interaction that is making the request.</param><param name="session">The session that entered the view for the interaction.</param><summary>Method that is called when the user drags the drop session into the view for the drop interaction.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("dropInteraction:sessionDidEnter:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SessionDidEnter (UIDropInteraction interaction, IUIDropSession session)
		{
			_SessionDidEnter (this, interaction, session);
		}
		/// <param name="interaction">The interaction that is making the request.</param><param name="session">The session that entered the view for the interaction.</param><summary>Method that is called when the user drags the drop session into the view for the drop interaction.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SessionDidEnter (IUIDropInteractionDelegate This, UIDropInteraction interaction, IUIDropSession session)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var interaction__handle__ = interaction!.GetNonNullHandle (nameof (interaction));
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("dropInteraction:sessionDidEnter:"), interaction__handle__, session__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (interaction);
			GC.KeepAlive (session);
		}
		/// <param name="interaction">The interaction that is making the request.</param><param name="session">The session that was changed.</param><summary>Method that is called when the touch point moves into or within the view, or when drag items are added while the touch point is within the view.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("dropInteraction:sessionDidUpdate:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIDropProposal SessionDidUpdate (UIDropInteraction interaction, IUIDropSession session)
		{
			return _SessionDidUpdate (this, interaction, session);
		}
		/// <param name="interaction">The interaction that is making the request.</param><param name="session">The session that was changed.</param><summary>Method that is called when the touch point moves into or within the view, or when drag items are added while the touch point is within the view.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static UIDropProposal _SessionDidUpdate (IUIDropInteractionDelegate This, UIDropInteraction interaction, IUIDropSession session)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var interaction__handle__ = interaction!.GetNonNullHandle (nameof (interaction));
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			UIDropProposal? ret;
			ret =  Runtime.GetNSObject<UIDropProposal> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("dropInteraction:sessionDidUpdate:"), interaction__handle__, session__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (interaction);
			GC.KeepAlive (session);
			return ret!;
		}
		/// <param name="interaction">The interaction that is making the request.</param><param name="session">The session that left the view for the interaction.</param><summary>Method that is called when the user drags the drop session out of the view for the drop interaction.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("dropInteraction:sessionDidExit:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SessionDidExit (UIDropInteraction interaction, IUIDropSession session)
		{
			_SessionDidExit (this, interaction, session);
		}
		/// <param name="interaction">The interaction that is making the request.</param><param name="session">The session that left the view for the interaction.</param><summary>Method that is called when the user drags the drop session out of the view for the drop interaction.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SessionDidExit (IUIDropInteractionDelegate This, UIDropInteraction interaction, IUIDropSession session)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var interaction__handle__ = interaction!.GetNonNullHandle (nameof (interaction));
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("dropInteraction:sessionDidExit:"), interaction__handle__, session__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (interaction);
			GC.KeepAlive (session);
		}
		/// <param name="interaction">The interaction that is making the request.</param><param name="session">The session that contains the items to drop.</param><summary>Method that is called to consume data from the item providers in the drop session.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("dropInteraction:performDrop:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PerformDrop (UIDropInteraction interaction, IUIDropSession session)
		{
			_PerformDrop (this, interaction, session);
		}
		/// <param name="interaction">The interaction that is making the request.</param><param name="session">The session that contains the items to drop.</param><summary>Method that is called to consume data from the item providers in the drop session.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _PerformDrop (IUIDropInteractionDelegate This, UIDropInteraction interaction, IUIDropSession session)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var interaction__handle__ = interaction!.GetNonNullHandle (nameof (interaction));
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("dropInteraction:performDrop:"), interaction__handle__, session__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (interaction);
			GC.KeepAlive (session);
		}
		/// <param name="interaction">The interaction that is making the request.</param><param name="session">The session that has concluded.</param><summary>Method that is called after the drop is performed and all animations have completed.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("dropInteraction:concludeDrop:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ConcludeDrop (UIDropInteraction interaction, IUIDropSession session)
		{
			_ConcludeDrop (this, interaction, session);
		}
		/// <param name="interaction">The interaction that is making the request.</param><param name="session">The session that has concluded.</param><summary>Method that is called after the drop is performed and all animations have completed.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _ConcludeDrop (IUIDropInteractionDelegate This, UIDropInteraction interaction, IUIDropSession session)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var interaction__handle__ = interaction!.GetNonNullHandle (nameof (interaction));
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("dropInteraction:concludeDrop:"), interaction__handle__, session__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (interaction);
			GC.KeepAlive (session);
		}
		/// <param name="interaction">The interaction that is making the request.</param><param name="session">The session that ended.</param><summary>Method that is called to allow the developer to release all resources for the completed drop session.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("dropInteraction:sessionDidEnd:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SessionDidEnd (UIDropInteraction interaction, IUIDropSession session)
		{
			_SessionDidEnd (this, interaction, session);
		}
		/// <param name="interaction">The interaction that is making the request.</param><param name="session">The session that ended.</param><summary>Method that is called to allow the developer to release all resources for the completed drop session.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SessionDidEnd (IUIDropInteractionDelegate This, UIDropInteraction interaction, IUIDropSession session)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var interaction__handle__ = interaction!.GetNonNullHandle (nameof (interaction));
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("dropInteraction:sessionDidEnd:"), interaction__handle__, session__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (interaction);
			GC.KeepAlive (session);
		}
		/// <param name="interaction">The interaction that is making the request.</param><param name="item">The item for which to get a preview.</param><param name="defaultPreview">The default preview for the item.</param><summary>Method that is called for each drag item to allow the developer to provide a custom preview.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("dropInteraction:previewForDroppingItem:withDefault:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UITargetedDragPreview? GetPreviewForDroppingItem (UIDropInteraction interaction, UIDragItem item, UITargetedDragPreview defaultPreview)
		{
			return _GetPreviewForDroppingItem (this, interaction, item, defaultPreview);
		}
		/// <param name="interaction">The interaction that is making the request.</param><param name="item">The item for which to get a preview.</param><param name="defaultPreview">The default preview for the item.</param><summary>Method that is called for each drag item to allow the developer to provide a custom preview.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static UITargetedDragPreview? _GetPreviewForDroppingItem (IUIDropInteractionDelegate This, UIDropInteraction interaction, UIDragItem item, UITargetedDragPreview defaultPreview)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var interaction__handle__ = interaction!.GetNonNullHandle (nameof (interaction));
			var item__handle__ = item!.GetNonNullHandle (nameof (item));
			var defaultPreview__handle__ = defaultPreview!.GetNonNullHandle (nameof (defaultPreview));
			UITargetedDragPreview? ret;
			ret =  Runtime.GetNSObject<UITargetedDragPreview> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("dropInteraction:previewForDroppingItem:withDefault:"), interaction__handle__, item__handle__, defaultPreview__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (interaction);
			GC.KeepAlive (item);
			GC.KeepAlive (defaultPreview);
			return ret!;
		}
		/// <param name="interaction">The interaction that is making the request.</param><param name="item">The item whose drop to animate.</param><param name="animator">An animator to run custom parallel animations and in which the developer may optionally add a completion handler.</param><summary>Method that is called for each visible drag item just before the drop is animated.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("dropInteraction:item:willAnimateDropWithAnimator:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillAnimateDrop (UIDropInteraction interaction, UIDragItem item, IUIDragAnimating animator)
		{
			_WillAnimateDrop (this, interaction, item, animator);
		}
		/// <param name="interaction">The interaction that is making the request.</param><param name="item">The item whose drop to animate.</param><param name="animator">An animator to run custom parallel animations and in which the developer may optionally add a completion handler.</param><summary>Method that is called for each visible drag item just before the drop is animated.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _WillAnimateDrop (IUIDropInteractionDelegate This, UIDropInteraction interaction, UIDragItem item, IUIDragAnimating animator)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var interaction__handle__ = interaction!.GetNonNullHandle (nameof (interaction));
			var item__handle__ = item!.GetNonNullHandle (nameof (item));
			var animator__handle__ = animator!.GetNonNullHandle (nameof (animator));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("dropInteraction:item:willAnimateDropWithAnimator:"), interaction__handle__, item__handle__, animator__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (interaction);
			GC.KeepAlive (item);
			GC.KeepAlive (animator);
		}
		[DynamicDependencyAttribute ("CanHandleSession(UIKit.UIDropInteraction,UIKit.IUIDropSession)")]
		[DynamicDependencyAttribute ("ConcludeDrop(UIKit.UIDropInteraction,UIKit.IUIDropSession)")]
		[DynamicDependencyAttribute ("GetPreviewForDroppingItem(UIKit.UIDropInteraction,UIKit.UIDragItem,UIKit.UITargetedDragPreview)")]
		[DynamicDependencyAttribute ("PerformDrop(UIKit.UIDropInteraction,UIKit.IUIDropSession)")]
		[DynamicDependencyAttribute ("SessionDidEnd(UIKit.UIDropInteraction,UIKit.IUIDropSession)")]
		[DynamicDependencyAttribute ("SessionDidEnter(UIKit.UIDropInteraction,UIKit.IUIDropSession)")]
		[DynamicDependencyAttribute ("SessionDidExit(UIKit.UIDropInteraction,UIKit.IUIDropSession)")]
		[DynamicDependencyAttribute ("SessionDidUpdate(UIKit.UIDropInteraction,UIKit.IUIDropSession)")]
		[DynamicDependencyAttribute ("WillAnimateDrop(UIKit.UIDropInteraction,UIKit.UIDragItem,UIKit.IUIDragAnimating)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UIDropInteractionDelegateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IUIDropInteractionDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="IUIDropInteractionDelegate" /> interface to support all the methods from the UIDropInteractionDelegate protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IUIDropInteractionDelegate" /> interface allow developers to treat instances of the interface as having all the optional methods of the original UIDropInteractionDelegate protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class UIDropInteractionDelegate_Extensions {
		/// <param name="interaction">The interaction to check.</param><param name="session">The session to query.</param><summary>Returns <see langword="true" /> if the specified <paramref name="interaction" /> can handle the specified <paramref name="session" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool CanHandleSession (this IUIDropInteractionDelegate This, UIDropInteraction interaction, IUIDropSession session)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var interaction__handle__ = interaction!.GetNonNullHandle (nameof (interaction));
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("dropInteraction:canHandleSession:"), interaction__handle__, session__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (interaction);
			GC.KeepAlive (session);
			return ret != 0;
		}
		/// <param name="interaction">The interaction that is making the request.</param><param name="session">The session that entered the view for the interaction.</param><summary>Method that is called when the user drags the drop session into the view for the drop interaction.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SessionDidEnter (this IUIDropInteractionDelegate This, UIDropInteraction interaction, IUIDropSession session)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var interaction__handle__ = interaction!.GetNonNullHandle (nameof (interaction));
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("dropInteraction:sessionDidEnter:"), interaction__handle__, session__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (interaction);
			GC.KeepAlive (session);
		}
		/// <param name="interaction">The interaction that is making the request.</param><param name="session">The session that was changed.</param><summary>Method that is called when the touch point moves into or within the view, or when drag items are added while the touch point is within the view.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static UIDropProposal SessionDidUpdate (this IUIDropInteractionDelegate This, UIDropInteraction interaction, IUIDropSession session)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var interaction__handle__ = interaction!.GetNonNullHandle (nameof (interaction));
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			UIDropProposal? ret;
			ret =  Runtime.GetNSObject<UIDropProposal> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("dropInteraction:sessionDidUpdate:"), interaction__handle__, session__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (interaction);
			GC.KeepAlive (session);
			return ret!;
		}
		/// <param name="interaction">The interaction that is making the request.</param><param name="session">The session that left the view for the interaction.</param><summary>Method that is called when the user drags the drop session out of the view for the drop interaction.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SessionDidExit (this IUIDropInteractionDelegate This, UIDropInteraction interaction, IUIDropSession session)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var interaction__handle__ = interaction!.GetNonNullHandle (nameof (interaction));
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("dropInteraction:sessionDidExit:"), interaction__handle__, session__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (interaction);
			GC.KeepAlive (session);
		}
		/// <param name="interaction">The interaction that is making the request.</param><param name="session">The session that contains the items to drop.</param><summary>Method that is called to consume data from the item providers in the drop session.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void PerformDrop (this IUIDropInteractionDelegate This, UIDropInteraction interaction, IUIDropSession session)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var interaction__handle__ = interaction!.GetNonNullHandle (nameof (interaction));
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("dropInteraction:performDrop:"), interaction__handle__, session__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (interaction);
			GC.KeepAlive (session);
		}
		/// <param name="interaction">The interaction that is making the request.</param><param name="session">The session that has concluded.</param><summary>Method that is called after the drop is performed and all animations have completed.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void ConcludeDrop (this IUIDropInteractionDelegate This, UIDropInteraction interaction, IUIDropSession session)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var interaction__handle__ = interaction!.GetNonNullHandle (nameof (interaction));
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("dropInteraction:concludeDrop:"), interaction__handle__, session__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (interaction);
			GC.KeepAlive (session);
		}
		/// <param name="interaction">The interaction that is making the request.</param><param name="session">The session that ended.</param><summary>Method that is called to allow the developer to release all resources for the completed drop session.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SessionDidEnd (this IUIDropInteractionDelegate This, UIDropInteraction interaction, IUIDropSession session)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var interaction__handle__ = interaction!.GetNonNullHandle (nameof (interaction));
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("dropInteraction:sessionDidEnd:"), interaction__handle__, session__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (interaction);
			GC.KeepAlive (session);
		}
		/// <param name="interaction">The interaction that is making the request.</param><param name="item">The item for which to get a preview.</param><param name="defaultPreview">The default preview for the item.</param><summary>Method that is called for each drag item to allow the developer to provide a custom preview.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static UITargetedDragPreview? GetPreviewForDroppingItem (this IUIDropInteractionDelegate This, UIDropInteraction interaction, UIDragItem item, UITargetedDragPreview defaultPreview)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var interaction__handle__ = interaction!.GetNonNullHandle (nameof (interaction));
			var item__handle__ = item!.GetNonNullHandle (nameof (item));
			var defaultPreview__handle__ = defaultPreview!.GetNonNullHandle (nameof (defaultPreview));
			UITargetedDragPreview? ret;
			ret =  Runtime.GetNSObject<UITargetedDragPreview> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("dropInteraction:previewForDroppingItem:withDefault:"), interaction__handle__, item__handle__, defaultPreview__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (interaction);
			GC.KeepAlive (item);
			GC.KeepAlive (defaultPreview);
			return ret!;
		}
		/// <param name="interaction">The interaction that is making the request.</param><param name="item">The item whose drop to animate.</param><param name="animator">An animator to run custom parallel animations and in which the developer may optionally add a completion handler.</param><summary>Method that is called for each visible drag item just before the drop is animated.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void WillAnimateDrop (this IUIDropInteractionDelegate This, UIDropInteraction interaction, UIDragItem item, IUIDragAnimating animator)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var interaction__handle__ = interaction!.GetNonNullHandle (nameof (interaction));
			var item__handle__ = item!.GetNonNullHandle (nameof (item));
			var animator__handle__ = animator!.GetNonNullHandle (nameof (animator));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("dropInteraction:item:willAnimateDropWithAnimator:"), interaction__handle__, item__handle__, animator__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (interaction);
			GC.KeepAlive (item);
			GC.KeepAlive (animator);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class UIDropInteractionDelegateWrapper : BaseWrapper, IUIDropInteractionDelegate {
		public UIDropInteractionDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UIDropInteractionDelegateWrapper))]
		static UIDropInteractionDelegateWrapper ()
		{
			GC.KeepAlive (null);
		}
	}
}
namespace UIKit {
	/// <summary>Delegate object for a drop interaction.</summary>
	[Protocol()]
	[Register("Microsoft_iOS__UIKit_UIDropInteractionDelegate", false)]
	[Model]
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	public unsafe partial class UIDropInteractionDelegate : NSObject, IUIDropInteractionDelegate {
		/// <summary>Creates a new <see cref="UIDropInteractionDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public UIDropInteractionDelegate () : base (NSObjectFlag.Empty)
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
		protected UIDropInteractionDelegate (NSObjectFlag t) : base (t)
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
		protected internal UIDropInteractionDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		/// <param name="interaction">The interaction to check.</param><param name="session">The session to query.</param><summary>Returns <see langword="true" /> if the specified <paramref name="interaction" /> can handle the specified <paramref name="session" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("dropInteraction:canHandleSession:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool CanHandleSession (UIDropInteraction interaction, IUIDropSession session)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="interaction">The interaction that is making the request.</param><param name="session">The session that has concluded.</param><summary>Method that is called after the drop is performed and all animations have completed.</summary><remarks>To be added.</remarks>
		[Export ("dropInteraction:concludeDrop:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ConcludeDrop (UIDropInteraction interaction, IUIDropSession session)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="interaction">The interaction that is making the request.</param><param name="item">The item for which to get a preview.</param><param name="defaultPreview">The default preview for the item.</param><summary>Method that is called for each drag item to allow the developer to provide a custom preview.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("dropInteraction:previewForDroppingItem:withDefault:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UITargetedDragPreview? GetPreviewForDroppingItem (UIDropInteraction interaction, UIDragItem item, UITargetedDragPreview defaultPreview)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="interaction">The interaction that is making the request.</param><param name="session">The session that contains the items to drop.</param><summary>Method that is called to consume data from the item providers in the drop session.</summary><remarks>To be added.</remarks>
		[Export ("dropInteraction:performDrop:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PerformDrop (UIDropInteraction interaction, IUIDropSession session)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="interaction">The interaction that is making the request.</param><param name="session">The session that ended.</param><summary>Method that is called to allow the developer to release all resources for the completed drop session.</summary><remarks>To be added.</remarks>
		[Export ("dropInteraction:sessionDidEnd:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SessionDidEnd (UIDropInteraction interaction, IUIDropSession session)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="interaction">The interaction that is making the request.</param><param name="session">The session that entered the view for the interaction.</param><summary>Method that is called when the user drags the drop session into the view for the drop interaction.</summary><remarks>To be added.</remarks>
		[Export ("dropInteraction:sessionDidEnter:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SessionDidEnter (UIDropInteraction interaction, IUIDropSession session)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="interaction">The interaction that is making the request.</param><param name="session">The session that left the view for the interaction.</param><summary>Method that is called when the user drags the drop session out of the view for the drop interaction.</summary><remarks>To be added.</remarks>
		[Export ("dropInteraction:sessionDidExit:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SessionDidExit (UIDropInteraction interaction, IUIDropSession session)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="interaction">The interaction that is making the request.</param><param name="session">The session that was changed.</param><summary>Method that is called when the touch point moves into or within the view, or when drag items are added while the touch point is within the view.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("dropInteraction:sessionDidUpdate:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIDropProposal SessionDidUpdate (UIDropInteraction interaction, IUIDropSession session)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="interaction">The interaction that is making the request.</param><param name="item">The item whose drop to animate.</param><param name="animator">An animator to run custom parallel animations and in which the developer may optionally add a completion handler.</param><summary>Method that is called for each visible drag item just before the drop is animated.</summary><remarks>To be added.</remarks>
		[Export ("dropInteraction:item:willAnimateDropWithAnimator:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillAnimateDrop (UIDropInteraction interaction, UIDragItem item, IUIDragAnimating animator)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class UIDropInteractionDelegate */
}
