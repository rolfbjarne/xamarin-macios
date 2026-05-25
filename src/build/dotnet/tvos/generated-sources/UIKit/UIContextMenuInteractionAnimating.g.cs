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
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Security;
using AudioUnit;
using CoreVideo;
using CoreMedia;
using CoreImage;
using SpriteKit;
using Foundation;
using ObjCRuntime;
using MediaPlayer;
using GameplayKit;
using CoreGraphics;
using CoreLocation;
using AVFoundation;
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;
using MetalPerformanceShadersGraph;
#nullable enable
namespace UIKit {
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>UIContextMenuInteractionAnimating</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[SupportedOSPlatform ("tvos17.0")]
	[SupportedOSPlatform ("ios13.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[Protocol (Name = "UIContextMenuInteractionAnimating", WrapperType = typeof (UIContextMenuInteractionAnimatingWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "AddAnimations", Selector = "addAnimations:", ParameterType = new Type [] { typeof (Action) }, ParameterByRef = new bool [] { false }, ParameterBlockProxy = new Type? [] { typeof (ObjCRuntime.Trampolines.NIDAction) })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "AddCompletion", Selector = "addCompletion:", ParameterType = new Type [] { typeof (Action) }, ParameterByRef = new bool [] { false }, ParameterBlockProxy = new Type? [] { typeof (ObjCRuntime.Trampolines.NIDAction) })]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "PreviewViewController", Selector = "previewViewController", PropertyType = typeof (UIViewController), GetterSelector = "previewViewController", ArgumentSemantic = ArgumentSemantic.None)]
	public partial interface IUIContextMenuInteractionAnimating : INativeObject, IDisposable
	{
		[global::Foundation.RequiredMember]
		[Export ("addAnimations:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void AddAnimations ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action animations)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _AddAnimations (IUIContextMenuInteractionAnimating This, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action animations)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (animations is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (animations));
			using var block_animations = Trampolines.SDAction.CreateBlock (animations);
			BlockLiteral *block_ptr_animations = &block_animations;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("addAnimations:"), (IntPtr) block_ptr_animations);
			GC.KeepAlive (This);
		}
		[global::Foundation.RequiredMember]
		[Export ("addCompletion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void AddCompletion ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action completion)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _AddCompletion (IUIContextMenuInteractionAnimating This, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action completion)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDAction.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("addCompletion:"), (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
		}
		[DynamicDependencyAttribute ("AddAnimations(System.Action)")]
		[DynamicDependencyAttribute ("AddCompletion(System.Action)")]
		[DynamicDependencyAttribute ("PreviewViewController")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UIContextMenuInteractionAnimatingWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IUIContextMenuInteractionAnimating ()
		{
			GC.KeepAlive (null);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual UIViewController? PreviewViewController {
			[Export ("previewViewController")]
			get {
				return _GetPreviewViewController (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static UIViewController _GetPreviewViewController (IUIContextMenuInteractionAnimating This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			UIViewController ret;
			ret =  Runtime.GetNSObject<UIViewController> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("previewViewController")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class UIContextMenuInteractionAnimatingWrapper : BaseWrapper, IUIContextMenuInteractionAnimating {
		public UIContextMenuInteractionAnimatingWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UIContextMenuInteractionAnimatingWrapper))]
		static UIContextMenuInteractionAnimatingWrapper ()
		{
			GC.KeepAlive (null);
		}
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
		[Export ("addCompletion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void AddCompletion ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action completion)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDAction.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("addCompletion:"), (IntPtr) block_ptr_completion);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public UIViewController? PreviewViewController {
			[Export ("previewViewController")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UIViewController ret;
				ret =  Runtime.GetNSObject<UIViewController> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("previewViewController")), false)!;
				return ret;
			}
		}
	}
}
