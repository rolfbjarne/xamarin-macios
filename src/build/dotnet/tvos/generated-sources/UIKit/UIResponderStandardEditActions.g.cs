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
	/// <summary>This interface represents the Objective-C protocol <c>UIResponderStandardEditActions</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("tvos")]
	[Protocol (Name = "UIResponderStandardEditActions", WrapperType = typeof (UIResponderStandardEditActionsWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "Cut", Selector = "cut:", ParameterType = new Type [] { typeof (NSObject) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "Copy", Selector = "copy:", ParameterType = new Type [] { typeof (NSObject) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "Paste", Selector = "paste:", ParameterType = new Type [] { typeof (NSObject) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "PasteAndMatchStyle", Selector = "pasteAndMatchStyle:", ParameterType = new Type [] { typeof (NSObject) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "PasteAndGo", Selector = "pasteAndGo:", ParameterType = new Type [] { typeof (NSObject) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "PasteAndSearch", Selector = "pasteAndSearch:", ParameterType = new Type [] { typeof (NSObject) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "Select", Selector = "select:", ParameterType = new Type [] { typeof (NSObject) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "SelectAll", Selector = "selectAll:", ParameterType = new Type [] { typeof (NSObject) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "Delete", Selector = "delete:", ParameterType = new Type [] { typeof (NSObject) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "MakeTextWritingDirectionLeftToRight", Selector = "makeTextWritingDirectionLeftToRight:", ParameterType = new Type [] { typeof (NSObject) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "MakeTextWritingDirectionRightToLeft", Selector = "makeTextWritingDirectionRightToLeft:", ParameterType = new Type [] { typeof (NSObject) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ToggleBoldface", Selector = "toggleBoldface:", ParameterType = new Type [] { typeof (NSObject) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ToggleItalics", Selector = "toggleItalics:", ParameterType = new Type [] { typeof (NSObject) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ToggleUnderline", Selector = "toggleUnderline:", ParameterType = new Type [] { typeof (NSObject) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DecreaseSize", Selector = "decreaseSize:", ParameterType = new Type [] { typeof (NSObject) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "IncreaseSize", Selector = "increaseSize:", ParameterType = new Type [] { typeof (NSObject) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "UpdateTextAttributes", Selector = "updateTextAttributesWithConversionHandler:", ParameterType = new Type [] { typeof (UITextAttributesConversionHandler) }, ParameterByRef = new bool [] { false }, ParameterBlockProxy = new Type? [] { typeof (ObjCRuntime.Trampolines.NIDUITextAttributesConversionHandler) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "Print", Selector = "print:", ParameterType = new Type [] { typeof (NSObject) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "Rename", Selector = "rename:", ParameterType = new Type [] { typeof (NSObject) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "Duplicate", Selector = "duplicate:", ParameterType = new Type [] { typeof (NSObject) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "Move", Selector = "move:", ParameterType = new Type [] { typeof (NSObject) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "Export", Selector = "export:", ParameterType = new Type [] { typeof (NSObject) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "Find", Selector = "find:", ParameterType = new Type [] { typeof (NSObject) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "FindAndReplace", Selector = "findAndReplace:", ParameterType = new Type [] { typeof (NSObject) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "FindNext", Selector = "findNext:", ParameterType = new Type [] { typeof (NSObject) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "FindPrevious", Selector = "findPrevious:", ParameterType = new Type [] { typeof (NSObject) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "UseSelectionForFind", Selector = "useSelectionForFind:", ParameterType = new Type [] { typeof (NSObject) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "AlignLeft", Selector = "alignLeft:", ParameterType = new Type [] { typeof (NSObject) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "AlignRight", Selector = "alignRight:", ParameterType = new Type [] { typeof (NSObject) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "AlignCenter", Selector = "alignCenter:", ParameterType = new Type [] { typeof (NSObject) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "AlignJustified", Selector = "alignJustified:", ParameterType = new Type [] { typeof (NSObject) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "NewFromPasteboard", Selector = "newFromPasteboard:", ParameterType = new Type [] { typeof (NSObject) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "PerformClose", Selector = "performClose:", ParameterType = new Type [] { typeof (NSObject) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ToggleInspector", Selector = "toggleInspector:", ParameterType = new Type [] { typeof (NSObject) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ToggleSidebar", Selector = "toggleSidebar:", ParameterType = new Type [] { typeof (NSObject) }, ParameterByRef = new bool [] { false })]
	public partial interface IUIResponderStandardEditActions : INativeObject, IDisposable
	{
		[global::Foundation.OptionalMember]
		[Export ("cut:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Cut (NSObject? sender)
		{
			_Cut (this, sender);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _Cut (IUIResponderStandardEditActions This, NSObject? sender)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var sender__handle__ = sender.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("cut:"), sender__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
		}
		[global::Foundation.OptionalMember]
		[Export ("copy:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Copy (NSObject? sender)
		{
			_Copy (this, sender);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _Copy (IUIResponderStandardEditActions This, NSObject? sender)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var sender__handle__ = sender.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("copy:"), sender__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
		}
		[global::Foundation.OptionalMember]
		[Export ("paste:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Paste (NSObject? sender)
		{
			_Paste (this, sender);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _Paste (IUIResponderStandardEditActions This, NSObject? sender)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var sender__handle__ = sender.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("paste:"), sender__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
		}
		[global::Foundation.OptionalMember]
		[Export ("pasteAndMatchStyle:")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PasteAndMatchStyle (NSObject? sender)
		{
			_PasteAndMatchStyle (this, sender);
		}
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _PasteAndMatchStyle (IUIResponderStandardEditActions This, NSObject? sender)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var sender__handle__ = sender.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("pasteAndMatchStyle:"), sender__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
		}
		[global::Foundation.OptionalMember]
		[Export ("pasteAndGo:")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PasteAndGo (NSObject? sender)
		{
			_PasteAndGo (this, sender);
		}
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _PasteAndGo (IUIResponderStandardEditActions This, NSObject? sender)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var sender__handle__ = sender.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("pasteAndGo:"), sender__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
		}
		[global::Foundation.OptionalMember]
		[Export ("pasteAndSearch:")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PasteAndSearch (NSObject? sender)
		{
			_PasteAndSearch (this, sender);
		}
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _PasteAndSearch (IUIResponderStandardEditActions This, NSObject? sender)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var sender__handle__ = sender.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("pasteAndSearch:"), sender__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
		}
		[global::Foundation.OptionalMember]
		[Export ("select:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Select (NSObject? sender)
		{
			_Select (this, sender);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _Select (IUIResponderStandardEditActions This, NSObject? sender)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var sender__handle__ = sender.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("select:"), sender__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
		}
		[global::Foundation.OptionalMember]
		[Export ("selectAll:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SelectAll (NSObject? sender)
		{
			_SelectAll (this, sender);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SelectAll (IUIResponderStandardEditActions This, NSObject? sender)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var sender__handle__ = sender.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("selectAll:"), sender__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
		}
		[global::Foundation.OptionalMember]
		[Export ("delete:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Delete (NSObject? sender)
		{
			_Delete (this, sender);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _Delete (IUIResponderStandardEditActions This, NSObject? sender)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var sender__handle__ = sender.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("delete:"), sender__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
		}
		[global::Foundation.OptionalMember]
		[Export ("makeTextWritingDirectionLeftToRight:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void MakeTextWritingDirectionLeftToRight (NSObject? sender)
		{
			_MakeTextWritingDirectionLeftToRight (this, sender);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _MakeTextWritingDirectionLeftToRight (IUIResponderStandardEditActions This, NSObject? sender)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var sender__handle__ = sender.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("makeTextWritingDirectionLeftToRight:"), sender__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
		}
		[global::Foundation.OptionalMember]
		[Export ("makeTextWritingDirectionRightToLeft:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void MakeTextWritingDirectionRightToLeft (NSObject? sender)
		{
			_MakeTextWritingDirectionRightToLeft (this, sender);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _MakeTextWritingDirectionRightToLeft (IUIResponderStandardEditActions This, NSObject? sender)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var sender__handle__ = sender.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("makeTextWritingDirectionRightToLeft:"), sender__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
		}
		[global::Foundation.OptionalMember]
		[Export ("toggleBoldface:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ToggleBoldface (NSObject? sender)
		{
			_ToggleBoldface (this, sender);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _ToggleBoldface (IUIResponderStandardEditActions This, NSObject? sender)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var sender__handle__ = sender.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("toggleBoldface:"), sender__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
		}
		[global::Foundation.OptionalMember]
		[Export ("toggleItalics:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ToggleItalics (NSObject? sender)
		{
			_ToggleItalics (this, sender);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _ToggleItalics (IUIResponderStandardEditActions This, NSObject? sender)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var sender__handle__ = sender.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("toggleItalics:"), sender__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
		}
		[global::Foundation.OptionalMember]
		[Export ("toggleUnderline:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ToggleUnderline (NSObject? sender)
		{
			_ToggleUnderline (this, sender);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _ToggleUnderline (IUIResponderStandardEditActions This, NSObject? sender)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var sender__handle__ = sender.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("toggleUnderline:"), sender__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
		}
		[global::Foundation.OptionalMember]
		[Export ("decreaseSize:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DecreaseSize (NSObject? sender)
		{
			_DecreaseSize (this, sender);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DecreaseSize (IUIResponderStandardEditActions This, NSObject? sender)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var sender__handle__ = sender.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("decreaseSize:"), sender__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
		}
		[global::Foundation.OptionalMember]
		[Export ("increaseSize:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void IncreaseSize (NSObject? sender)
		{
			_IncreaseSize (this, sender);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _IncreaseSize (IUIResponderStandardEditActions This, NSObject? sender)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var sender__handle__ = sender.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("increaseSize:"), sender__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
		}
		[global::Foundation.OptionalMember]
		[Export ("updateTextAttributesWithConversionHandler:")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void UpdateTextAttributes ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDUITextAttributesConversionHandler))]UITextAttributesConversionHandler conversionHandler)
		{
			_UpdateTextAttributes (this, conversionHandler);
		}
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _UpdateTextAttributes (IUIResponderStandardEditActions This, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDUITextAttributesConversionHandler))]UITextAttributesConversionHandler conversionHandler)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (conversionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (conversionHandler));
			using var block_conversionHandler = Trampolines.SDUITextAttributesConversionHandler.CreateBlock (conversionHandler);
			BlockLiteral *block_ptr_conversionHandler = &block_conversionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("updateTextAttributesWithConversionHandler:"), (IntPtr) block_ptr_conversionHandler);
			GC.KeepAlive (This);
		}
		[global::Foundation.OptionalMember]
		[Export ("print:")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Print (NSObject? sender)
		{
			_Print (this, sender);
		}
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _Print (IUIResponderStandardEditActions This, NSObject? sender)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var sender__handle__ = sender.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("print:"), sender__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
		}
		[global::Foundation.OptionalMember]
		[Export ("rename:")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Rename (NSObject? sender)
		{
			_Rename (this, sender);
		}
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _Rename (IUIResponderStandardEditActions This, NSObject? sender)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var sender__handle__ = sender.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("rename:"), sender__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
		}
		[global::Foundation.OptionalMember]
		[Export ("duplicate:")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Duplicate (NSObject? sender)
		{
			_Duplicate (this, sender);
		}
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _Duplicate (IUIResponderStandardEditActions This, NSObject? sender)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var sender__handle__ = sender.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("duplicate:"), sender__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
		}
		[global::Foundation.OptionalMember]
		[Export ("move:")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Move (NSObject? sender)
		{
			_Move (this, sender);
		}
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _Move (IUIResponderStandardEditActions This, NSObject? sender)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var sender__handle__ = sender.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("move:"), sender__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
		}
		[global::Foundation.OptionalMember]
		[Export ("export:")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Export (NSObject? sender)
		{
			_Export (this, sender);
		}
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _Export (IUIResponderStandardEditActions This, NSObject? sender)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var sender__handle__ = sender.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("export:"), sender__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
		}
		[global::Foundation.OptionalMember]
		[Export ("find:")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Find (NSObject? sender)
		{
			_Find (this, sender);
		}
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _Find (IUIResponderStandardEditActions This, NSObject? sender)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var sender__handle__ = sender.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("find:"), sender__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
		}
		[global::Foundation.OptionalMember]
		[Export ("findAndReplace:")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void FindAndReplace (NSObject? sender)
		{
			_FindAndReplace (this, sender);
		}
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _FindAndReplace (IUIResponderStandardEditActions This, NSObject? sender)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var sender__handle__ = sender.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("findAndReplace:"), sender__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
		}
		[global::Foundation.OptionalMember]
		[Export ("findNext:")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void FindNext (NSObject? sender)
		{
			_FindNext (this, sender);
		}
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _FindNext (IUIResponderStandardEditActions This, NSObject? sender)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var sender__handle__ = sender.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("findNext:"), sender__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
		}
		[global::Foundation.OptionalMember]
		[Export ("findPrevious:")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void FindPrevious (NSObject? sender)
		{
			_FindPrevious (this, sender);
		}
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _FindPrevious (IUIResponderStandardEditActions This, NSObject? sender)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var sender__handle__ = sender.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("findPrevious:"), sender__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
		}
		[global::Foundation.OptionalMember]
		[Export ("useSelectionForFind:")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void UseSelectionForFind (NSObject? sender)
		{
			_UseSelectionForFind (this, sender);
		}
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _UseSelectionForFind (IUIResponderStandardEditActions This, NSObject? sender)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var sender__handle__ = sender.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("useSelectionForFind:"), sender__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
		}
		[global::Foundation.OptionalMember]
		[Export ("alignLeft:")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AlignLeft (NSObject? sender)
		{
			_AlignLeft (this, sender);
		}
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _AlignLeft (IUIResponderStandardEditActions This, NSObject? sender)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var sender__handle__ = sender.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("alignLeft:"), sender__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
		}
		[global::Foundation.OptionalMember]
		[Export ("alignRight:")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AlignRight (NSObject? sender)
		{
			_AlignRight (this, sender);
		}
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _AlignRight (IUIResponderStandardEditActions This, NSObject? sender)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var sender__handle__ = sender.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("alignRight:"), sender__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
		}
		[global::Foundation.OptionalMember]
		[Export ("alignCenter:")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AlignCenter (NSObject? sender)
		{
			_AlignCenter (this, sender);
		}
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _AlignCenter (IUIResponderStandardEditActions This, NSObject? sender)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var sender__handle__ = sender.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("alignCenter:"), sender__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
		}
		[global::Foundation.OptionalMember]
		[Export ("alignJustified:")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AlignJustified (NSObject? sender)
		{
			_AlignJustified (this, sender);
		}
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _AlignJustified (IUIResponderStandardEditActions This, NSObject? sender)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var sender__handle__ = sender.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("alignJustified:"), sender__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
		}
		[global::Foundation.OptionalMember]
		[Export ("newFromPasteboard:")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void NewFromPasteboard (NSObject? sender)
		{
			_NewFromPasteboard (this, sender);
		}
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _NewFromPasteboard (IUIResponderStandardEditActions This, NSObject? sender)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var sender__handle__ = sender.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("newFromPasteboard:"), sender__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
		}
		[global::Foundation.OptionalMember]
		[Export ("performClose:")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PerformClose (NSObject? sender)
		{
			_PerformClose (this, sender);
		}
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _PerformClose (IUIResponderStandardEditActions This, NSObject? sender)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var sender__handle__ = sender.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("performClose:"), sender__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
		}
		[global::Foundation.OptionalMember]
		[Export ("toggleInspector:")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ToggleInspector (NSObject? sender)
		{
			_ToggleInspector (this, sender);
		}
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _ToggleInspector (IUIResponderStandardEditActions This, NSObject? sender)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var sender__handle__ = sender.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("toggleInspector:"), sender__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
		}
		[global::Foundation.OptionalMember]
		[Export ("toggleSidebar:")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ToggleSidebar (NSObject? sender)
		{
			_ToggleSidebar (this, sender);
		}
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _ToggleSidebar (IUIResponderStandardEditActions This, NSObject? sender)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var sender__handle__ = sender.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("toggleSidebar:"), sender__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
		}
		[DynamicDependencyAttribute ("AlignCenter(Foundation.NSObject)")]
		[DynamicDependencyAttribute ("AlignJustified(Foundation.NSObject)")]
		[DynamicDependencyAttribute ("AlignLeft(Foundation.NSObject)")]
		[DynamicDependencyAttribute ("AlignRight(Foundation.NSObject)")]
		[DynamicDependencyAttribute ("Copy(Foundation.NSObject)")]
		[DynamicDependencyAttribute ("Cut(Foundation.NSObject)")]
		[DynamicDependencyAttribute ("DecreaseSize(Foundation.NSObject)")]
		[DynamicDependencyAttribute ("Delete(Foundation.NSObject)")]
		[DynamicDependencyAttribute ("Duplicate(Foundation.NSObject)")]
		[DynamicDependencyAttribute ("Export(Foundation.NSObject)")]
		[DynamicDependencyAttribute ("Find(Foundation.NSObject)")]
		[DynamicDependencyAttribute ("FindAndReplace(Foundation.NSObject)")]
		[DynamicDependencyAttribute ("FindNext(Foundation.NSObject)")]
		[DynamicDependencyAttribute ("FindPrevious(Foundation.NSObject)")]
		[DynamicDependencyAttribute ("IncreaseSize(Foundation.NSObject)")]
		[DynamicDependencyAttribute ("MakeTextWritingDirectionLeftToRight(Foundation.NSObject)")]
		[DynamicDependencyAttribute ("MakeTextWritingDirectionRightToLeft(Foundation.NSObject)")]
		[DynamicDependencyAttribute ("Move(Foundation.NSObject)")]
		[DynamicDependencyAttribute ("NewFromPasteboard(Foundation.NSObject)")]
		[DynamicDependencyAttribute ("Paste(Foundation.NSObject)")]
		[DynamicDependencyAttribute ("PasteAndGo(Foundation.NSObject)")]
		[DynamicDependencyAttribute ("PasteAndMatchStyle(Foundation.NSObject)")]
		[DynamicDependencyAttribute ("PasteAndSearch(Foundation.NSObject)")]
		[DynamicDependencyAttribute ("PerformClose(Foundation.NSObject)")]
		[DynamicDependencyAttribute ("Print(Foundation.NSObject)")]
		[DynamicDependencyAttribute ("Rename(Foundation.NSObject)")]
		[DynamicDependencyAttribute ("Select(Foundation.NSObject)")]
		[DynamicDependencyAttribute ("SelectAll(Foundation.NSObject)")]
		[DynamicDependencyAttribute ("ToggleBoldface(Foundation.NSObject)")]
		[DynamicDependencyAttribute ("ToggleInspector(Foundation.NSObject)")]
		[DynamicDependencyAttribute ("ToggleItalics(Foundation.NSObject)")]
		[DynamicDependencyAttribute ("ToggleSidebar(Foundation.NSObject)")]
		[DynamicDependencyAttribute ("ToggleUnderline(Foundation.NSObject)")]
		[DynamicDependencyAttribute ("UpdateTextAttributes(UIKit.UITextAttributesConversionHandler)")]
		[DynamicDependencyAttribute ("UseSelectionForFind(Foundation.NSObject)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UIResponderStandardEditActionsWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IUIResponderStandardEditActions ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="IUIResponderStandardEditActions" /> interface to support all the methods from the UIResponderStandardEditActions protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IUIResponderStandardEditActions" /> interface allow developers to treat instances of the interface as having all the optional methods of the original UIResponderStandardEditActions protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class UIResponderStandardEditActions_Extensions {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void Cut (this IUIResponderStandardEditActions This, NSObject? sender)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var sender__handle__ = sender.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("cut:"), sender__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void Copy (this IUIResponderStandardEditActions This, NSObject? sender)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var sender__handle__ = sender.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("copy:"), sender__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void Paste (this IUIResponderStandardEditActions This, NSObject? sender)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var sender__handle__ = sender.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("paste:"), sender__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
		}
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void PasteAndMatchStyle (this IUIResponderStandardEditActions This, NSObject? sender)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var sender__handle__ = sender.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("pasteAndMatchStyle:"), sender__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
		}
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void PasteAndGo (this IUIResponderStandardEditActions This, NSObject? sender)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var sender__handle__ = sender.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("pasteAndGo:"), sender__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
		}
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void PasteAndSearch (this IUIResponderStandardEditActions This, NSObject? sender)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var sender__handle__ = sender.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("pasteAndSearch:"), sender__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void Select (this IUIResponderStandardEditActions This, NSObject? sender)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var sender__handle__ = sender.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("select:"), sender__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SelectAll (this IUIResponderStandardEditActions This, NSObject? sender)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var sender__handle__ = sender.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("selectAll:"), sender__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void Delete (this IUIResponderStandardEditActions This, NSObject? sender)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var sender__handle__ = sender.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("delete:"), sender__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void MakeTextWritingDirectionLeftToRight (this IUIResponderStandardEditActions This, NSObject? sender)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var sender__handle__ = sender.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("makeTextWritingDirectionLeftToRight:"), sender__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void MakeTextWritingDirectionRightToLeft (this IUIResponderStandardEditActions This, NSObject? sender)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var sender__handle__ = sender.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("makeTextWritingDirectionRightToLeft:"), sender__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void ToggleBoldface (this IUIResponderStandardEditActions This, NSObject? sender)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var sender__handle__ = sender.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("toggleBoldface:"), sender__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void ToggleItalics (this IUIResponderStandardEditActions This, NSObject? sender)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var sender__handle__ = sender.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("toggleItalics:"), sender__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void ToggleUnderline (this IUIResponderStandardEditActions This, NSObject? sender)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var sender__handle__ = sender.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("toggleUnderline:"), sender__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DecreaseSize (this IUIResponderStandardEditActions This, NSObject? sender)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var sender__handle__ = sender.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("decreaseSize:"), sender__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void IncreaseSize (this IUIResponderStandardEditActions This, NSObject? sender)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var sender__handle__ = sender.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("increaseSize:"), sender__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
		}
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void UpdateTextAttributes (this IUIResponderStandardEditActions This, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDUITextAttributesConversionHandler))]UITextAttributesConversionHandler conversionHandler)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (conversionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (conversionHandler));
			using var block_conversionHandler = Trampolines.SDUITextAttributesConversionHandler.CreateBlock (conversionHandler);
			BlockLiteral *block_ptr_conversionHandler = &block_conversionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("updateTextAttributesWithConversionHandler:"), (IntPtr) block_ptr_conversionHandler);
			GC.KeepAlive (This);
		}
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void Print (this IUIResponderStandardEditActions This, NSObject? sender)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var sender__handle__ = sender.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("print:"), sender__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
		}
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void Rename (this IUIResponderStandardEditActions This, NSObject? sender)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var sender__handle__ = sender.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("rename:"), sender__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
		}
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void Duplicate (this IUIResponderStandardEditActions This, NSObject? sender)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var sender__handle__ = sender.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("duplicate:"), sender__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
		}
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void Move (this IUIResponderStandardEditActions This, NSObject? sender)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var sender__handle__ = sender.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("move:"), sender__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
		}
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void Export (this IUIResponderStandardEditActions This, NSObject? sender)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var sender__handle__ = sender.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("export:"), sender__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
		}
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void Find (this IUIResponderStandardEditActions This, NSObject? sender)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var sender__handle__ = sender.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("find:"), sender__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
		}
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void FindAndReplace (this IUIResponderStandardEditActions This, NSObject? sender)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var sender__handle__ = sender.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("findAndReplace:"), sender__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
		}
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void FindNext (this IUIResponderStandardEditActions This, NSObject? sender)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var sender__handle__ = sender.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("findNext:"), sender__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
		}
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void FindPrevious (this IUIResponderStandardEditActions This, NSObject? sender)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var sender__handle__ = sender.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("findPrevious:"), sender__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
		}
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void UseSelectionForFind (this IUIResponderStandardEditActions This, NSObject? sender)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var sender__handle__ = sender.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("useSelectionForFind:"), sender__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
		}
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void AlignLeft (this IUIResponderStandardEditActions This, NSObject? sender)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var sender__handle__ = sender.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("alignLeft:"), sender__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
		}
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void AlignRight (this IUIResponderStandardEditActions This, NSObject? sender)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var sender__handle__ = sender.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("alignRight:"), sender__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
		}
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void AlignCenter (this IUIResponderStandardEditActions This, NSObject? sender)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var sender__handle__ = sender.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("alignCenter:"), sender__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
		}
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void AlignJustified (this IUIResponderStandardEditActions This, NSObject? sender)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var sender__handle__ = sender.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("alignJustified:"), sender__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
		}
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void NewFromPasteboard (this IUIResponderStandardEditActions This, NSObject? sender)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var sender__handle__ = sender.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("newFromPasteboard:"), sender__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
		}
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void PerformClose (this IUIResponderStandardEditActions This, NSObject? sender)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var sender__handle__ = sender.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("performClose:"), sender__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
		}
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void ToggleInspector (this IUIResponderStandardEditActions This, NSObject? sender)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var sender__handle__ = sender.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("toggleInspector:"), sender__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
		}
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void ToggleSidebar (this IUIResponderStandardEditActions This, NSObject? sender)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var sender__handle__ = sender.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("toggleSidebar:"), sender__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class UIResponderStandardEditActionsWrapper : BaseWrapper, IUIResponderStandardEditActions {
		public UIResponderStandardEditActionsWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UIResponderStandardEditActionsWrapper))]
		static UIResponderStandardEditActionsWrapper ()
		{
			GC.KeepAlive (null);
		}
	}
}
