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
	/// <summary>Contains manages collection view placeholder information.</summary>
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[Protocol (Name = "UICollectionViewDropPlaceholderContext", WrapperType = typeof (UICollectionViewDropPlaceholderContextWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "CommitInsertion", Selector = "commitInsertionWithDataSourceUpdates:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (global::System.Action<NSIndexPath>) }, ParameterByRef = new bool [] { false }, ParameterBlockProxy = new Type? [] { typeof (ObjCRuntime.Trampolines.NIDActionArity1V259) })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "DeletePlaceholder", Selector = "deletePlaceholder", ReturnType = typeof (bool))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetNeedsCellUpdate", Selector = "setNeedsCellUpdate")]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "DragItem", Selector = "dragItem", PropertyType = typeof (UIDragItem), GetterSelector = "dragItem", ArgumentSemantic = ArgumentSemantic.None)]
	public partial interface IUICollectionViewDropPlaceholderContext : INativeObject, IDisposable, 
		UIKit.IUIDragAnimating
	{
		/// <param name="dataSourceUpdates">Handler to run as the placeholder is replaced. Takes the index path where the content should drop.</param><summary>Replaces the placeholder cell with dropped content.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("commitInsertionWithDataSourceUpdates:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual bool CommitInsertion ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V259))]global::System.Action<NSIndexPath> dataSourceUpdates)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="dataSourceUpdates">Handler to run as the placeholder is replaced. Takes the index path where the content should drop.</param><summary>Replaces the placeholder cell with dropped content.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static bool _CommitInsertion (IUICollectionViewDropPlaceholderContext This, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V259))]global::System.Action<NSIndexPath> dataSourceUpdates)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (dataSourceUpdates is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (dataSourceUpdates));
			using var block_dataSourceUpdates = Trampolines.SDActionArity1V259.CreateBlock (dataSourceUpdates);
			BlockLiteral *block_ptr_dataSourceUpdates = &block_dataSourceUpdates;
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("commitInsertionWithDataSourceUpdates:"), (IntPtr) block_ptr_dataSourceUpdates);
			GC.KeepAlive (This);
			return ret != 0;
		}
		/// <summary>Removes the placeholder from the view.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("deletePlaceholder")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool DeletePlaceholder ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <summary>Removes the placeholder from the view.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _DeletePlaceholder (IUICollectionViewDropPlaceholderContext This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("deletePlaceholder"));
			GC.KeepAlive (This);
			return ret != 0;
		}
		/// <summary>Marks the placeholder cell as requiring updated content.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("setNeedsCellUpdate")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetNeedsCellUpdate ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <summary>Marks the placeholder cell as requiring updated content.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetNeedsCellUpdate (IUICollectionViewDropPlaceholderContext This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			global::ObjCRuntime.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("setNeedsCellUpdate"));
			GC.KeepAlive (This);
		}
		[DynamicDependencyAttribute ("CommitInsertion(System.Action{Foundation.NSIndexPath})")]
		[DynamicDependencyAttribute ("DeletePlaceholder()")]
		[DynamicDependencyAttribute ("DragItem")]
		[DynamicDependencyAttribute ("SetNeedsCellUpdate()")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UICollectionViewDropPlaceholderContextWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IUICollectionViewDropPlaceholderContext ()
		{
			GC.KeepAlive (null);
		}
		/// <summary>Gets the drag item that is represented by the placeholder.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual UIDragItem DragItem {
			[Export ("dragItem")]
			get {
				return _GetDragItem (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static UIDragItem _GetDragItem (IUICollectionViewDropPlaceholderContext This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			UIDragItem ret;
			ret =  Runtime.GetNSObject<UIDragItem> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("dragItem")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class UICollectionViewDropPlaceholderContextWrapper : BaseWrapper, IUICollectionViewDropPlaceholderContext {
		public UICollectionViewDropPlaceholderContextWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UICollectionViewDropPlaceholderContextWrapper))]
		static UICollectionViewDropPlaceholderContextWrapper ()
		{
			GC.KeepAlive (null);
		}
		/// <param name="dataSourceUpdates">Handler to run as the placeholder is replaced. Takes the index path where the content should drop.</param><summary>Replaces the placeholder cell with dropped content.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("commitInsertionWithDataSourceUpdates:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe bool CommitInsertion ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V259))]global::System.Action<NSIndexPath> dataSourceUpdates)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (dataSourceUpdates is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (dataSourceUpdates));
			using var block_dataSourceUpdates = Trampolines.SDActionArity1V259.CreateBlock (dataSourceUpdates);
			BlockLiteral *block_ptr_dataSourceUpdates = &block_dataSourceUpdates;
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("commitInsertionWithDataSourceUpdates:"), (IntPtr) block_ptr_dataSourceUpdates);
			return ret != 0;
		}
		/// <summary>Removes the placeholder from the view.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("deletePlaceholder")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public bool DeletePlaceholder ()
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("deletePlaceholder"));
			return ret != 0;
		}
		/// <summary>Marks the placeholder cell as requiring updated content.</summary><remarks>To be added.</remarks>
		[Export ("setNeedsCellUpdate")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetNeedsCellUpdate ()
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("setNeedsCellUpdate"));
		}
		/// <param name="animations">An action that animates UI elements.</param><summary>Adds the specified animation action.</summary><remarks>To be added.</remarks>
		[Export ("addAnimations:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void AddAnimations ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action animations)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (animations is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (animations));
			using var block_animations = Trampolines.SDAction.CreateBlock (animations);
			BlockLiteral *block_ptr_animations = &block_animations;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("addAnimations:"), (IntPtr) block_ptr_animations);
		}
		/// <param name="completion">The completion handler to add.</param><summary>Adds the specified <paramref name="completion" /> block to run when the animation ends.</summary><remarks>To be added.</remarks>
		[Export ("addCompletion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void AddCompletion ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V260))]global::System.Action<UIViewAnimatingPosition> completion)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V260.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("addCompletion:"), (IntPtr) block_ptr_completion);
		}
		/// <summary>Gets the drag item that is represented by the placeholder.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public UIDragItem DragItem {
			[Export ("dragItem")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UIDragItem ret;
				ret =  Runtime.GetNSObject<UIDragItem> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("dragItem")), false)!;
				return ret;
			}
		}
	}
}
