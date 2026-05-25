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
	/// <summary>Interface for customizing text view drag source behavior.</summary>
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[Protocol (Name = "UITextDragDelegate", WrapperType = typeof (UITextDragDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetItemsForDrag", Selector = "textDraggableView:itemsForDrag:", ReturnType = typeof (UIDragItem[]), ParameterType = new Type [] { typeof (IUITextDraggable), typeof (IUITextDragRequest) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetPreviewForLiftingItem", Selector = "textDraggableView:dragPreviewForLiftingItem:session:", ReturnType = typeof (UITargetedDragPreview), ParameterType = new Type [] { typeof (IUITextDraggable), typeof (UIDragItem), typeof (IUIDragSession) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillAnimateLift", Selector = "textDraggableView:willAnimateLiftWithAnimator:session:", ParameterType = new Type [] { typeof (IUITextDraggable), typeof (IUIDragAnimating), typeof (IUIDragSession) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DragSessionWillBegin", Selector = "textDraggableView:dragSessionWillBegin:", ParameterType = new Type [] { typeof (IUITextDraggable), typeof (IUIDragSession) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DragSessionDidEnd", Selector = "textDraggableView:dragSessionDidEnd:withOperation:", ParameterType = new Type [] { typeof (IUITextDraggable), typeof (IUIDragSession), typeof (UIDropOperation) }, ParameterByRef = new bool [] { false, false, false })]
	public partial interface IUITextDragDelegate : INativeObject, IDisposable
	{
		/// <param name="textDraggableView">The originating view.</param><param name="dragRequest">The drag request.</param><summary>Method that is called to get custom drag items.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("textDraggableView:itemsForDrag:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIDragItem[] GetItemsForDrag (IUITextDraggable textDraggableView, IUITextDragRequest dragRequest)
		{
			return _GetItemsForDrag (this, textDraggableView, dragRequest);
		}
		/// <param name="textDraggableView">The originating view.</param><param name="dragRequest">The drag request.</param><summary>Method that is called to get custom drag items.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static UIDragItem[] _GetItemsForDrag (IUITextDragDelegate This, IUITextDraggable textDraggableView, IUITextDragRequest dragRequest)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var textDraggableView__handle__ = textDraggableView!.GetNonNullHandle (nameof (textDraggableView));
			var dragRequest__handle__ = dragRequest!.GetNonNullHandle (nameof (dragRequest));
			UIDragItem[]? ret;
			ret = CFArray.ArrayFromHandle<UIDragItem>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("textDraggableView:itemsForDrag:"), textDraggableView__handle__, dragRequest__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (textDraggableView);
			GC.KeepAlive (dragRequest);
			return ret!;
		}
		/// <param name="textDraggableView">The originating view.</param><param name="item">The item for which to get a lift preview.</param><param name="session">The drag session.</param><summary>Method that is called to get a preview for the item that is lifting.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("textDraggableView:dragPreviewForLiftingItem:session:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UITargetedDragPreview? GetPreviewForLiftingItem (IUITextDraggable textDraggableView, UIDragItem item, IUIDragSession session)
		{
			return _GetPreviewForLiftingItem (this, textDraggableView, item, session);
		}
		/// <param name="textDraggableView">The originating view.</param><param name="item">The item for which to get a lift preview.</param><param name="session">The drag session.</param><summary>Method that is called to get a preview for the item that is lifting.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static UITargetedDragPreview? _GetPreviewForLiftingItem (IUITextDragDelegate This, IUITextDraggable textDraggableView, UIDragItem item, IUIDragSession session)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var textDraggableView__handle__ = textDraggableView!.GetNonNullHandle (nameof (textDraggableView));
			var item__handle__ = item!.GetNonNullHandle (nameof (item));
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			UITargetedDragPreview? ret;
			ret =  Runtime.GetNSObject<UITargetedDragPreview> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("textDraggableView:dragPreviewForLiftingItem:session:"), textDraggableView__handle__, item__handle__, session__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (textDraggableView);
			GC.KeepAlive (item);
			GC.KeepAlive (session);
			return ret!;
		}
		/// <param name="textDraggableView">The originating view.</param><param name="animator">The animator to use for adding animations.</param><param name="session">The drag session.</param><summary>Method that is called just before an item lift is animated.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("textDraggableView:willAnimateLiftWithAnimator:session:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillAnimateLift (IUITextDraggable textDraggableView, IUIDragAnimating animator, IUIDragSession session)
		{
			_WillAnimateLift (this, textDraggableView, animator, session);
		}
		/// <param name="textDraggableView">The originating view.</param><param name="animator">The animator to use for adding animations.</param><param name="session">The drag session.</param><summary>Method that is called just before an item lift is animated.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _WillAnimateLift (IUITextDragDelegate This, IUITextDraggable textDraggableView, IUIDragAnimating animator, IUIDragSession session)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var textDraggableView__handle__ = textDraggableView!.GetNonNullHandle (nameof (textDraggableView));
			var animator__handle__ = animator!.GetNonNullHandle (nameof (animator));
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("textDraggableView:willAnimateLiftWithAnimator:session:"), textDraggableView__handle__, animator__handle__, session__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (textDraggableView);
			GC.KeepAlive (animator);
			GC.KeepAlive (session);
		}
		/// <param name="textDraggableView">The originating view.</param><param name="session">The drag session that will begin.</param><summary>Method that is called just before a drag session begins.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("textDraggableView:dragSessionWillBegin:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DragSessionWillBegin (IUITextDraggable textDraggableView, IUIDragSession session)
		{
			_DragSessionWillBegin (this, textDraggableView, session);
		}
		/// <param name="textDraggableView">The originating view.</param><param name="session">The drag session that will begin.</param><summary>Method that is called just before a drag session begins.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DragSessionWillBegin (IUITextDragDelegate This, IUITextDraggable textDraggableView, IUIDragSession session)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var textDraggableView__handle__ = textDraggableView!.GetNonNullHandle (nameof (textDraggableView));
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("textDraggableView:dragSessionWillBegin:"), textDraggableView__handle__, session__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (textDraggableView);
			GC.KeepAlive (session);
		}
		/// <param name="textDraggableView">The originating view.</param><param name="session">The drag session that ended.</param><param name="operation">The operation that ended the session.</param><summary>Method that is called when the user cancels or completes the drag session.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("textDraggableView:dragSessionDidEnd:withOperation:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DragSessionDidEnd (IUITextDraggable textDraggableView, IUIDragSession session, UIDropOperation operation)
		{
			_DragSessionDidEnd (this, textDraggableView, session, operation);
		}
		/// <param name="textDraggableView">The originating view.</param><param name="session">The drag session that ended.</param><param name="operation">The operation that ended the session.</param><summary>Method that is called when the user cancels or completes the drag session.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DragSessionDidEnd (IUITextDragDelegate This, IUITextDraggable textDraggableView, IUIDragSession session, UIDropOperation operation)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var textDraggableView__handle__ = textDraggableView!.GetNonNullHandle (nameof (textDraggableView));
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_UIntPtr (This.Handle, Selector.GetHandle ("textDraggableView:dragSessionDidEnd:withOperation:"), textDraggableView__handle__, session__handle__, (UIntPtr) (ulong) operation);
			GC.KeepAlive (This);
			GC.KeepAlive (textDraggableView);
			GC.KeepAlive (session);
		}
		[DynamicDependencyAttribute ("DragSessionDidEnd(UIKit.IUITextDraggable,UIKit.IUIDragSession,UIKit.UIDropOperation)")]
		[DynamicDependencyAttribute ("DragSessionWillBegin(UIKit.IUITextDraggable,UIKit.IUIDragSession)")]
		[DynamicDependencyAttribute ("GetItemsForDrag(UIKit.IUITextDraggable,UIKit.IUITextDragRequest)")]
		[DynamicDependencyAttribute ("GetPreviewForLiftingItem(UIKit.IUITextDraggable,UIKit.UIDragItem,UIKit.IUIDragSession)")]
		[DynamicDependencyAttribute ("WillAnimateLift(UIKit.IUITextDraggable,UIKit.IUIDragAnimating,UIKit.IUIDragSession)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UITextDragDelegateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IUITextDragDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="IUITextDragDelegate" /> interface to support all the methods from the UITextDragDelegate protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IUITextDragDelegate" /> interface allow developers to treat instances of the interface as having all the optional methods of the original UITextDragDelegate protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class UITextDragDelegate_Extensions {
		/// <param name="textDraggableView">The originating view.</param><param name="dragRequest">The drag request.</param><summary>Method that is called to get custom drag items.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static UIDragItem[] GetItemsForDrag (this IUITextDragDelegate This, IUITextDraggable textDraggableView, IUITextDragRequest dragRequest)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var textDraggableView__handle__ = textDraggableView!.GetNonNullHandle (nameof (textDraggableView));
			var dragRequest__handle__ = dragRequest!.GetNonNullHandle (nameof (dragRequest));
			UIDragItem[]? ret;
			ret = CFArray.ArrayFromHandle<UIDragItem>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("textDraggableView:itemsForDrag:"), textDraggableView__handle__, dragRequest__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (textDraggableView);
			GC.KeepAlive (dragRequest);
			return ret!;
		}
		/// <param name="textDraggableView">The originating view.</param><param name="item">The item for which to get a lift preview.</param><param name="session">The drag session.</param><summary>Method that is called to get a preview for the item that is lifting.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static UITargetedDragPreview? GetPreviewForLiftingItem (this IUITextDragDelegate This, IUITextDraggable textDraggableView, UIDragItem item, IUIDragSession session)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var textDraggableView__handle__ = textDraggableView!.GetNonNullHandle (nameof (textDraggableView));
			var item__handle__ = item!.GetNonNullHandle (nameof (item));
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			UITargetedDragPreview? ret;
			ret =  Runtime.GetNSObject<UITargetedDragPreview> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("textDraggableView:dragPreviewForLiftingItem:session:"), textDraggableView__handle__, item__handle__, session__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (textDraggableView);
			GC.KeepAlive (item);
			GC.KeepAlive (session);
			return ret!;
		}
		/// <param name="textDraggableView">The originating view.</param><param name="animator">The animator to use for adding animations.</param><param name="session">The drag session.</param><summary>Method that is called just before an item lift is animated.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void WillAnimateLift (this IUITextDragDelegate This, IUITextDraggable textDraggableView, IUIDragAnimating animator, IUIDragSession session)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var textDraggableView__handle__ = textDraggableView!.GetNonNullHandle (nameof (textDraggableView));
			var animator__handle__ = animator!.GetNonNullHandle (nameof (animator));
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("textDraggableView:willAnimateLiftWithAnimator:session:"), textDraggableView__handle__, animator__handle__, session__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (textDraggableView);
			GC.KeepAlive (animator);
			GC.KeepAlive (session);
		}
		/// <param name="textDraggableView">The originating view.</param><param name="session">The drag session that will begin.</param><summary>Method that is called just before a drag session begins.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DragSessionWillBegin (this IUITextDragDelegate This, IUITextDraggable textDraggableView, IUIDragSession session)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var textDraggableView__handle__ = textDraggableView!.GetNonNullHandle (nameof (textDraggableView));
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("textDraggableView:dragSessionWillBegin:"), textDraggableView__handle__, session__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (textDraggableView);
			GC.KeepAlive (session);
		}
		/// <param name="textDraggableView">The originating view.</param><param name="session">The drag session that ended.</param><param name="operation">The operation that ended the session.</param><summary>Method that is called when the user cancels or completes the drag session.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DragSessionDidEnd (this IUITextDragDelegate This, IUITextDraggable textDraggableView, IUIDragSession session, UIDropOperation operation)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var textDraggableView__handle__ = textDraggableView!.GetNonNullHandle (nameof (textDraggableView));
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_UIntPtr (This.Handle, Selector.GetHandle ("textDraggableView:dragSessionDidEnd:withOperation:"), textDraggableView__handle__, session__handle__, (UIntPtr) (ulong) operation);
			GC.KeepAlive (This);
			GC.KeepAlive (textDraggableView);
			GC.KeepAlive (session);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class UITextDragDelegateWrapper : BaseWrapper, IUITextDragDelegate {
		public UITextDragDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UITextDragDelegateWrapper))]
		static UITextDragDelegateWrapper ()
		{
			GC.KeepAlive (null);
		}
	}
}
namespace UIKit {
	/// <summary>Interface for customizing text view drag source behavior.</summary>
	[Protocol()]
	[Register("Microsoft_MacCatalyst__UIKit_UITextDragDelegate", false)]
	[Model]
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	public unsafe partial class UITextDragDelegate : NSObject, IUITextDragDelegate {
		/// <summary>Creates a new <see cref="UITextDragDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public UITextDragDelegate () : base (NSObjectFlag.Empty)
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
		protected UITextDragDelegate (NSObjectFlag t) : base (t)
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
		protected internal UITextDragDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		/// <param name="textDraggableView">The originating view.</param><param name="session">The drag session that ended.</param><param name="operation">The operation that ended the session.</param><summary>Method that is called when the user cancels or completes the drag session.</summary><remarks>To be added.</remarks>
		[Export ("textDraggableView:dragSessionDidEnd:withOperation:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DragSessionDidEnd (IUITextDraggable textDraggableView, IUIDragSession session, UIDropOperation operation)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="textDraggableView">The originating view.</param><param name="session">The drag session that will begin.</param><summary>Method that is called just before a drag session begins.</summary><remarks>To be added.</remarks>
		[Export ("textDraggableView:dragSessionWillBegin:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DragSessionWillBegin (IUITextDraggable textDraggableView, IUIDragSession session)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="textDraggableView">The originating view.</param><param name="dragRequest">The drag request.</param><summary>Method that is called to get custom drag items.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("textDraggableView:itemsForDrag:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIDragItem[] GetItemsForDrag (IUITextDraggable textDraggableView, IUITextDragRequest dragRequest)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="textDraggableView">The originating view.</param><param name="item">The item for which to get a lift preview.</param><param name="session">The drag session.</param><summary>Method that is called to get a preview for the item that is lifting.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("textDraggableView:dragPreviewForLiftingItem:session:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UITargetedDragPreview? GetPreviewForLiftingItem (IUITextDraggable textDraggableView, UIDragItem item, IUIDragSession session)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="textDraggableView">The originating view.</param><param name="animator">The animator to use for adding animations.</param><param name="session">The drag session.</param><summary>Method that is called just before an item lift is animated.</summary><remarks>To be added.</remarks>
		[Export ("textDraggableView:willAnimateLiftWithAnimator:session:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillAnimateLift (IUITextDraggable textDraggableView, IUIDragAnimating animator, IUIDragSession session)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class UITextDragDelegate */
}
