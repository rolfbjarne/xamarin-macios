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
	/// <summary>Interface for adding custom preview animations for lift, drop, and cancellation, along with the standard drag and drop animations.</summary><remarks><para>For example, developers can use this class to dim out or highlight other UI elements during a drag and drop operation.</para></remarks>
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[Protocol (Name = "UIDragAnimating", WrapperType = typeof (UIDragAnimatingWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "AddAnimations", Selector = "addAnimations:", ParameterType = new Type [] { typeof (Action) }, ParameterByRef = new bool [] { false }, ParameterBlockProxy = new Type? [] { typeof (ObjCRuntime.Trampolines.NIDAction) })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "AddCompletion", Selector = "addCompletion:", ParameterType = new Type [] { typeof (global::System.Action<global::UIKit.UIViewAnimatingPosition>) }, ParameterByRef = new bool [] { false }, ParameterBlockProxy = new Type? [] { typeof (ObjCRuntime.Trampolines.NIDActionArity1V260) })]
	public partial interface IUIDragAnimating : INativeObject, IDisposable
	{
		/// <param name="animations">An action that animates UI elements.</param><summary>Adds the specified animation action.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("addAnimations:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void AddAnimations ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action animations)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="animations">An action that animates UI elements.</param><summary>Adds the specified animation action.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _AddAnimations (IUIDragAnimating This, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action animations)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (animations is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (animations));
			using var block_animations = Trampolines.SDAction.CreateBlock (animations);
			BlockLiteral *block_ptr_animations = &block_animations;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("addAnimations:"), (IntPtr) block_ptr_animations);
			GC.KeepAlive (This);
		}
		/// <param name="completion">The completion handler to add.</param><summary>Adds the specified <paramref name="completion" /> block to run when the animation ends.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("addCompletion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void AddCompletion ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V260))]global::System.Action<UIViewAnimatingPosition> completion)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="completion">The completion handler to add.</param><summary>Adds the specified <paramref name="completion" /> block to run when the animation ends.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _AddCompletion (IUIDragAnimating This, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V260))]global::System.Action<UIViewAnimatingPosition> completion)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V260.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("addCompletion:"), (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
		}
		[DynamicDependencyAttribute ("AddAnimations(System.Action)")]
		[DynamicDependencyAttribute ("AddCompletion(System.Action{UIKit.UIViewAnimatingPosition})")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UIDragAnimatingWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IUIDragAnimating ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class UIDragAnimatingWrapper : BaseWrapper, IUIDragAnimating {
		public UIDragAnimatingWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UIDragAnimatingWrapper))]
		static UIDragAnimatingWrapper ()
		{
			GC.KeepAlive (null);
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
	}
}
