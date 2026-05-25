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
	/// <summary>Interface for accessing drop session state and loading drag items.</summary>
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[Protocol (Name = "UIDropSession", WrapperType = typeof (UIDropSessionWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "LoadObjects", Selector = "loadObjectsOfClass:completion:", ReturnType = typeof (NSProgress), ParameterType = new Type [] { typeof (Class), typeof (global::System.Action<INSItemProviderReading[]>) }, ParameterByRef = new bool [] { false, false }, ParameterBlockProxy = new Type? [] { null, typeof (ObjCRuntime.Trampolines.NIDActionArity1V246) })]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "LocalDragSession", Selector = "localDragSession", PropertyType = typeof (IUIDragSession), GetterSelector = "localDragSession", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "ProgressIndicatorStyle", Selector = "progressIndicatorStyle", PropertyType = typeof (UIDropSessionProgressIndicatorStyle), GetterSelector = "progressIndicatorStyle", SetterSelector = "setProgressIndicatorStyle:", ArgumentSemantic = ArgumentSemantic.Assign)]
	public partial interface IUIDropSession : INativeObject, IDisposable, 
		Foundation.INSProgressReporting
		, UIKit.IUIDragDropSession
	{
		/// <param name="itemProviderReadingClass">The class of objects to load.</param><param name="completion">Handler to run after the objects are loaded.</param><summary>When implemented by the developer, instantiates every object in the drop session that has the type that is specified by the <paramref ame="itemProviderReadingClass" /> parameter.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("loadObjectsOfClass:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual NSProgress LoadObjects (Class itemProviderReadingClass, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V246))]global::System.Action<INSItemProviderReading[]> completion)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="itemProviderReadingClass">The class of objects to load.</param><param name="completion">Handler to run after the objects are loaded.</param><summary>When implemented by the developer, instantiates every object in the drop session that has the type that is specified by the <paramref ame="itemProviderReadingClass" /> parameter.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static NSProgress _LoadObjects (IUIDropSession This, Class itemProviderReadingClass, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V246))]global::System.Action<INSItemProviderReading[]> completion)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var itemProviderReadingClass__handle__ = itemProviderReadingClass!.GetNonNullHandle (nameof (itemProviderReadingClass));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V246.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			NSProgress? ret;
			ret =  Runtime.GetNSObject<NSProgress> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("loadObjectsOfClass:completion:"), itemProviderReadingClass.Handle, (IntPtr) block_ptr_completion), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (itemProviderReadingClass);
			return ret!;
		}
		[DynamicDependencyAttribute ("LoadObjects(ObjCRuntime.Class,System.Action{Foundation.INSItemProviderReading[]})")]
		[DynamicDependencyAttribute ("LocalDragSession")]
		[DynamicDependencyAttribute ("ProgressIndicatorStyle")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UIDropSessionWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IUIDropSession ()
		{
			GC.KeepAlive (null);
		}
		/// <summary>The local in-app drag session for the drop session.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual IUIDragSession? LocalDragSession {
			[Export ("localDragSession")]
			get {
				return _GetLocalDragSession (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static IUIDragSession _GetLocalDragSession (IUIDropSession This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			IUIDragSession ret;
			ret =  Runtime.GetINativeObject<IUIDragSession> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("localDragSession")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		/// <summary>Gets or sets the style of the drop indicator.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual UIDropSessionProgressIndicatorStyle ProgressIndicatorStyle {
			[Export ("progressIndicatorStyle", ArgumentSemantic.Assign)]
			get {
				return _GetProgressIndicatorStyle (this);
			}
			[Export ("setProgressIndicatorStyle:", ArgumentSemantic.Assign)]
			set {
				_SetProgressIndicatorStyle (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static UIDropSessionProgressIndicatorStyle _GetProgressIndicatorStyle (IUIDropSession This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			UIDropSessionProgressIndicatorStyle ret;
			ret = (UIDropSessionProgressIndicatorStyle) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("progressIndicatorStyle"));
			GC.KeepAlive (This);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetProgressIndicatorStyle (IUIDropSession This, UIDropSessionProgressIndicatorStyle value)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (This.Handle, Selector.GetHandle ("setProgressIndicatorStyle:"), (UIntPtr) (ulong) value);
			GC.KeepAlive (This);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class UIDropSessionWrapper : BaseWrapper, IUIDropSession {
		public UIDropSessionWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UIDropSessionWrapper))]
		static UIDropSessionWrapper ()
		{
			GC.KeepAlive (null);
		}
		/// <param name="itemProviderReadingClass">The class of objects to load.</param><param name="completion">Handler to run after the objects are loaded.</param><summary>When implemented by the developer, instantiates every object in the drop session that has the type that is specified by the <paramref ame="itemProviderReadingClass" /> parameter.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("loadObjectsOfClass:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NSProgress LoadObjects (Class itemProviderReadingClass, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V246))]global::System.Action<INSItemProviderReading[]> completion)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var itemProviderReadingClass__handle__ = itemProviderReadingClass!.GetNonNullHandle (nameof (itemProviderReadingClass));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V246.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			NSProgress? ret;
			ret =  Runtime.GetNSObject<NSProgress> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("loadObjectsOfClass:completion:"), itemProviderReadingClass.Handle, (IntPtr) block_ptr_completion), false)!;
			GC.KeepAlive (itemProviderReadingClass);
			return ret!;
		}
		/// <param name="view">The view to query.</param><summary>Returns the location of the drag-drop activity in the coordinate frame of the specified <paramref name="view" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("locationInView:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public CGPoint LocationInView (UIView? view)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var view__handle__ = view.GetHandle ();
			CGPoint ret;
			ret = global::ObjCRuntime.Messaging.CGPoint_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("locationInView:"), view__handle__);
			GC.KeepAlive (view);
			return ret!;
		}
		/// <param name="typeIdentifiers">The type identifiers to check.</param><summary>TReturns a Boolean value that tells whether the session contains at least one item that is described by any of the specified type identifiers.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("hasItemsConformingToTypeIdentifiers:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public bool HasConformingItems (string[] typeIdentifiers)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (typeIdentifiers is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (typeIdentifiers));
			using var nsa_typeIdentifiers = NSArray.FromStrings (typeIdentifiers);
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("hasItemsConformingToTypeIdentifiers:"), nsa_typeIdentifiers.Handle);
			return ret != 0;
		}
		/// <param name="itemProviderReadingClass">The class of objects to check.</param><summary>Returns a Boolean value that tells whether the session can load objects of the specified class.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("canLoadObjectsOfClass:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public bool CanLoadObjects (Class itemProviderReadingClass)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var itemProviderReadingClass__handle__ = itemProviderReadingClass!.GetNonNullHandle (nameof (itemProviderReadingClass));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("canLoadObjectsOfClass:"), itemProviderReadingClass.Handle);
			GC.KeepAlive (itemProviderReadingClass);
			return ret != 0;
		}
		/// <summary>The local in-app drag session for the drop session.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public IUIDragSession? LocalDragSession {
			[Export ("localDragSession")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				IUIDragSession ret;
				ret =  Runtime.GetINativeObject<IUIDragSession> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("localDragSession")), false)!;
				return ret;
			}
		}
		/// <summary>Gets or sets the style of the drop indicator.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public UIDropSessionProgressIndicatorStyle ProgressIndicatorStyle {
			[Export ("progressIndicatorStyle", ArgumentSemantic.Assign)]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UIDropSessionProgressIndicatorStyle ret;
				ret = (UIDropSessionProgressIndicatorStyle) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("progressIndicatorStyle"));
				return ret!;
			}
			[Export ("setProgressIndicatorStyle:", ArgumentSemantic.Assign)]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (this.Handle, Selector.GetHandle ("setProgressIndicatorStyle:"), (UIntPtr) (ulong) value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		public NSProgress Progress {
			[Export ("progress")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("macos")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				NSProgress ret;
				ret =  Runtime.GetNSObject<NSProgress> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("progress")), false)!;
				return ret;
			}
		}
		/// <summary>Gets the drag items that are in the session.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		public UIDragItem[] Items {
			[Export ("items")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UIDragItem[] ret;
				ret = CFArray.ArrayFromHandle<UIDragItem>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("items")), false)!;
				return ret;
			}
		}
		/// <summary>Gets a Boolean value that tells whether the session can move items within a single app.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		public bool AllowsMoveOperation {
			[Export ("allowsMoveOperation")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				byte ret;
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("allowsMoveOperation"));
				return ret != 0;
			}
		}
		/// <summary>Gets a Boolean value that tells whether the drag activity is confined to the originating app.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		public bool RestrictedToDraggingApplication {
			[Export ("isRestrictedToDraggingApplication")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				byte ret;
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isRestrictedToDraggingApplication"));
				return ret != 0;
			}
		}
	}
}
