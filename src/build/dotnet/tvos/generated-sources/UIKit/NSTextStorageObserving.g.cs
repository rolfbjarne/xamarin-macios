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
	/// <summary>This interface represents the Objective-C protocol <c>NSTextStorageObserving</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[SupportedOSPlatform ("tvos15.0")]
	[SupportedOSPlatform ("ios15.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[Protocol (Name = "NSTextStorageObserving", WrapperType = typeof (NSTextStorageObservingWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "ProcessEditing", Selector = "processEditingForTextStorage:edited:range:changeInLength:invalidatedRange:", ParameterType = new Type [] { typeof (NSTextStorage), typeof (NSTextStorageEditActions), typeof (NSRange), typeof (IntPtr), typeof (NSRange) }, ParameterByRef = new bool [] { false, false, false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "PerformEditingTransaction", Selector = "performEditingTransactionForTextStorage:usingBlock:", ParameterType = new Type [] { typeof (NSTextStorage), typeof (Action) }, ParameterByRef = new bool [] { false, false }, ParameterBlockProxy = new Type? [] { null, typeof (ObjCRuntime.Trampolines.NIDAction) })]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "TextStorage", Selector = "textStorage", PropertyType = typeof (NSTextStorage), GetterSelector = "textStorage", SetterSelector = "setTextStorage:", ArgumentSemantic = ArgumentSemantic.Retain)]
	public partial interface INSTextStorageObserving : INativeObject, IDisposable
	{
		[global::Foundation.RequiredMember]
		[Export ("processEditingForTextStorage:edited:range:changeInLength:invalidatedRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ProcessEditing (NSTextStorage textStorage, NSTextStorageEditActions editMask, NSRange newCharRange, nint delta, NSRange invalidatedCharRange)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _ProcessEditing (INSTextStorageObserving This, NSTextStorage textStorage, NSTextStorageEditActions editMask, NSRange newCharRange, nint delta, NSRange invalidatedCharRange)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var textStorage__handle__ = textStorage!.GetNonNullHandle (nameof (textStorage));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr_NSRange_IntPtr_NSRange (This.Handle, Selector.GetHandle ("processEditingForTextStorage:edited:range:changeInLength:invalidatedRange:"), textStorage__handle__, (UIntPtr) (ulong) editMask, newCharRange, delta, invalidatedCharRange);
			GC.KeepAlive (This);
			GC.KeepAlive (textStorage);
		}
		[global::Foundation.RequiredMember]
		[Export ("performEditingTransactionForTextStorage:usingBlock:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void PerformEditingTransaction (NSTextStorage textStorage, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action transaction)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _PerformEditingTransaction (INSTextStorageObserving This, NSTextStorage textStorage, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action transaction)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var textStorage__handle__ = textStorage!.GetNonNullHandle (nameof (textStorage));
			if (transaction is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (transaction));
			using var block_transaction = Trampolines.SDAction.CreateBlock (transaction);
			BlockLiteral *block_ptr_transaction = &block_transaction;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("performEditingTransactionForTextStorage:usingBlock:"), textStorage__handle__, (IntPtr) block_ptr_transaction);
			GC.KeepAlive (This);
			GC.KeepAlive (textStorage);
		}
		[DynamicDependencyAttribute ("PerformEditingTransaction(UIKit.NSTextStorage,System.Action)")]
		[DynamicDependencyAttribute ("ProcessEditing(UIKit.NSTextStorage,UIKit.NSTextStorageEditActions,Foundation.NSRange,System.IntPtr,Foundation.NSRange)")]
		[DynamicDependencyAttribute ("TextStorage")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSTextStorageObservingWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static INSTextStorageObserving ()
		{
			GC.KeepAlive (null);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual NSTextStorage? TextStorage {
			[Export ("textStorage", ArgumentSemantic.Retain)]
			get {
				return _GetTextStorage (this);
			}
			[Export ("setTextStorage:", ArgumentSemantic.Retain)]
			set {
				_SetTextStorage (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSTextStorage _GetTextStorage (INSTextStorageObserving This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			NSTextStorage ret;
			ret =  Runtime.GetNSObject<NSTextStorage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("textStorage")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetTextStorage (INSTextStorageObserving This, NSTextStorage? value)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var value__handle__ = value.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setTextStorage:"), value__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (value);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class NSTextStorageObservingWrapper : BaseWrapper, INSTextStorageObserving {
		public NSTextStorageObservingWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSTextStorageObservingWrapper))]
		static NSTextStorageObservingWrapper ()
		{
			GC.KeepAlive (null);
		}
		[Export ("processEditingForTextStorage:edited:range:changeInLength:invalidatedRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void ProcessEditing (NSTextStorage textStorage, NSTextStorageEditActions editMask, NSRange newCharRange, nint delta, NSRange invalidatedCharRange)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var textStorage__handle__ = textStorage!.GetNonNullHandle (nameof (textStorage));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr_NSRange_IntPtr_NSRange (this.Handle, Selector.GetHandle ("processEditingForTextStorage:edited:range:changeInLength:invalidatedRange:"), textStorage__handle__, (UIntPtr) (ulong) editMask, newCharRange, delta, invalidatedCharRange);
			GC.KeepAlive (textStorage);
		}
		[Export ("performEditingTransactionForTextStorage:usingBlock:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void PerformEditingTransaction (NSTextStorage textStorage, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action transaction)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var textStorage__handle__ = textStorage!.GetNonNullHandle (nameof (textStorage));
			if (transaction is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (transaction));
			using var block_transaction = Trampolines.SDAction.CreateBlock (transaction);
			BlockLiteral *block_ptr_transaction = &block_transaction;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("performEditingTransactionForTextStorage:usingBlock:"), textStorage__handle__, (IntPtr) block_ptr_transaction);
			GC.KeepAlive (textStorage);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSTextStorage? TextStorage {
			[Export ("textStorage", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				NSTextStorage ret;
				ret =  Runtime.GetNSObject<NSTextStorage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("textStorage")), false)!;
				return ret;
			}
			[Export ("setTextStorage:", ArgumentSemantic.Retain)]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				var value__handle__ = value.GetHandle ();
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setTextStorage:"), value__handle__);
				GC.KeepAlive (value);
			}
		}
	}
}
