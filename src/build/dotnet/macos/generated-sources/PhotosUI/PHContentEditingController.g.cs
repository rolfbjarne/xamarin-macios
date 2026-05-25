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
using Metal;
using CoreML;
using OpenGL;
using AppKit;
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Contacts;
using Security;
using CloudKit;
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
using FileProvider;
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;
using MetalPerformanceShadersGraph;
#nullable enable
namespace PhotosUI {
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>PHContentEditingController</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[Protocol (Name = "PHContentEditingController", WrapperType = typeof (PHContentEditingControllerWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "CanHandleAdjustmentData", Selector = "canHandleAdjustmentData:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (PHAdjustmentData) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "StartContentEditing", Selector = "startContentEditingWithInput:placeholderImage:", ParameterType = new Type [] { typeof (PHContentEditingInput), typeof (NSImage) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "FinishContentEditing", Selector = "finishContentEditingWithCompletionHandler:", ParameterType = new Type [] { typeof (global::System.Action<global::Photos.PHContentEditingOutput>) }, ParameterByRef = new bool [] { false }, ParameterBlockProxy = new Type? [] { typeof (ObjCRuntime.Trampolines.NIDActionArity1V104) })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "CancelContentEditing", Selector = "cancelContentEditing")]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "ShouldShowCancelConfirmation", Selector = "shouldShowCancelConfirmation", PropertyType = typeof (bool), GetterSelector = "shouldShowCancelConfirmation", ArgumentSemantic = ArgumentSemantic.None)]
	public partial interface IPHContentEditingController : INativeObject, IDisposable
	{
		/// <param name="adjustmentData">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("canHandleAdjustmentData:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool CanHandleAdjustmentData (global::Photos.PHAdjustmentData adjustmentData)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="adjustmentData">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _CanHandleAdjustmentData (IPHContentEditingController This, global::Photos.PHAdjustmentData adjustmentData)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var adjustmentData__handle__ = adjustmentData!.GetNonNullHandle (nameof (adjustmentData));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("canHandleAdjustmentData:"), adjustmentData__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (adjustmentData);
			return ret != 0;
		}
		/// <param name="contentEditingInput">To be added.</param><param name="placeholderImage">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("startContentEditingWithInput:placeholderImage:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void StartContentEditing (global::Photos.PHContentEditingInput contentEditingInput, global::AppKit.NSImage placeholderImage)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="contentEditingInput">To be added.</param><param name="placeholderImage">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _StartContentEditing (IPHContentEditingController This, global::Photos.PHContentEditingInput contentEditingInput, global::AppKit.NSImage placeholderImage)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var contentEditingInput__handle__ = contentEditingInput!.GetNonNullHandle (nameof (contentEditingInput));
			var placeholderImage__handle__ = placeholderImage!.GetNonNullHandle (nameof (placeholderImage));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("startContentEditingWithInput:placeholderImage:"), contentEditingInput__handle__, placeholderImage__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (contentEditingInput);
			GC.KeepAlive (placeholderImage);
		}
		/// <param name="completionHandler">To be added. This parameter can be <see langword="null" />.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("finishContentEditingWithCompletionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void FinishContentEditing ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V104))]global::System.Action<global::Photos.PHContentEditingOutput> completionHandler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="completionHandler">To be added. This parameter can be <see langword="null" />.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _FinishContentEditing (IPHContentEditingController This, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V104))]global::System.Action<global::Photos.PHContentEditingOutput> completionHandler)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity1V104.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("finishContentEditingWithCompletionHandler:"), (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
		}
		/// <summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("cancelContentEditing")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void CancelContentEditing ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _CancelContentEditing (IPHContentEditingController This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			global::ObjCRuntime.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("cancelContentEditing"));
			GC.KeepAlive (This);
		}
		[DynamicDependencyAttribute ("CancelContentEditing()")]
		[DynamicDependencyAttribute ("CanHandleAdjustmentData(Photos.PHAdjustmentData)")]
		[DynamicDependencyAttribute ("FinishContentEditing(System.Action{Photos.PHContentEditingOutput})")]
		[DynamicDependencyAttribute ("ShouldShowCancelConfirmation")]
		[DynamicDependencyAttribute ("StartContentEditing(Photos.PHContentEditingInput,AppKit.NSImage)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (PHContentEditingControllerWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IPHContentEditingController ()
		{
			GC.KeepAlive (null);
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual bool ShouldShowCancelConfirmation {
			[Export ("shouldShowCancelConfirmation")]
			get {
				return _GetShouldShowCancelConfirmation (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _GetShouldShowCancelConfirmation (IPHContentEditingController This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("shouldShowCancelConfirmation"));
			GC.KeepAlive (This);
			return ret != 0;
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class PHContentEditingControllerWrapper : BaseWrapper, IPHContentEditingController {
		public PHContentEditingControllerWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (PHContentEditingControllerWrapper))]
		static PHContentEditingControllerWrapper ()
		{
			GC.KeepAlive (null);
		}
		/// <param name="adjustmentData">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("canHandleAdjustmentData:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public bool CanHandleAdjustmentData (global::Photos.PHAdjustmentData adjustmentData)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var adjustmentData__handle__ = adjustmentData!.GetNonNullHandle (nameof (adjustmentData));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("canHandleAdjustmentData:"), adjustmentData__handle__);
			GC.KeepAlive (adjustmentData);
			return ret != 0;
		}
		/// <param name="contentEditingInput">To be added.</param><param name="placeholderImage">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("startContentEditingWithInput:placeholderImage:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void StartContentEditing (global::Photos.PHContentEditingInput contentEditingInput, global::AppKit.NSImage placeholderImage)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var contentEditingInput__handle__ = contentEditingInput!.GetNonNullHandle (nameof (contentEditingInput));
			var placeholderImage__handle__ = placeholderImage!.GetNonNullHandle (nameof (placeholderImage));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("startContentEditingWithInput:placeholderImage:"), contentEditingInput__handle__, placeholderImage__handle__);
			GC.KeepAlive (contentEditingInput);
			GC.KeepAlive (placeholderImage);
		}
		/// <param name="completionHandler">To be added. This parameter can be <see langword="null" />.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("finishContentEditingWithCompletionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void FinishContentEditing ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V104))]global::System.Action<global::Photos.PHContentEditingOutput> completionHandler)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity1V104.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("finishContentEditingWithCompletionHandler:"), (IntPtr) block_ptr_completionHandler);
		}
		/// <summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("cancelContentEditing")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void CancelContentEditing ()
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("cancelContentEditing"));
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public bool ShouldShowCancelConfirmation {
			[Export ("shouldShowCancelConfirmation")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				byte ret;
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("shouldShowCancelConfirmation"));
				return ret != 0;
			}
		}
	}
}
