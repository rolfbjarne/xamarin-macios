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
	/// <summary>A delegate object that exposes events for <see cref="T:UIKit.NSLayoutManager" />s.</summary><related type="externalDocumentation" href="https://developer.apple.com/documentation/uikit/nslayoutmanagerdelegate">Apple documentation for <c>NSLayoutManagerDelegate</c></related>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("tvos")]
	[Protocol (Name = "NSLayoutManagerDelegate", WrapperType = typeof (NSLayoutManagerDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidInvalidatedLayout", Selector = "layoutManagerDidInvalidateLayout:", ParameterType = new Type [] { typeof (NSLayoutManager) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidCompleteLayout", Selector = "layoutManager:didCompleteLayoutForTextContainer:atEnd:", ParameterType = new Type [] { typeof (NSLayoutManager), typeof (NSTextContainer), typeof (bool) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldGenerateGlyphs", Selector = "layoutManager:shouldGenerateGlyphs:properties:characterIndexes:font:forGlyphRange:", ReturnType = typeof (UIntPtr), ParameterType = new Type [] { typeof (NSLayoutManager), typeof (IntPtr), typeof (IntPtr), typeof (IntPtr), typeof (UIFont), typeof (NSRange) }, ParameterByRef = new bool [] { false, false, false, false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetLineSpacingAfterGlyph", Selector = "layoutManager:lineSpacingAfterGlyphAtIndex:withProposedLineFragmentRect:", ReturnType = typeof (NFloat), ParameterType = new Type [] { typeof (NSLayoutManager), typeof (UIntPtr), typeof (CGRect) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetParagraphSpacingBeforeGlyph", Selector = "layoutManager:paragraphSpacingBeforeGlyphAtIndex:withProposedLineFragmentRect:", ReturnType = typeof (NFloat), ParameterType = new Type [] { typeof (NSLayoutManager), typeof (UIntPtr), typeof (CGRect) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetParagraphSpacingAfterGlyph", Selector = "layoutManager:paragraphSpacingAfterGlyphAtIndex:withProposedLineFragmentRect:", ReturnType = typeof (NFloat), ParameterType = new Type [] { typeof (NSLayoutManager), typeof (UIntPtr), typeof (CGRect) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldUseAction", Selector = "layoutManager:shouldUseAction:forControlCharacterAtIndex:", ReturnType = typeof (NSControlCharacterAction), ParameterType = new Type [] { typeof (NSLayoutManager), typeof (NSControlCharacterAction), typeof (UIntPtr) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldBreakLineByWordBeforeCharacter", Selector = "layoutManager:shouldBreakLineByWordBeforeCharacterAtIndex:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (NSLayoutManager), typeof (UIntPtr) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldBreakLineByHyphenatingBeforeCharacter", Selector = "layoutManager:shouldBreakLineByHyphenatingBeforeCharacterAtIndex:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (NSLayoutManager), typeof (UIntPtr) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetBoundingBox", Selector = "layoutManager:boundingBoxForControlGlyphAtIndex:forTextContainer:proposedLineFragment:glyphPosition:characterIndex:", ReturnType = typeof (CGRect), ParameterType = new Type [] { typeof (NSLayoutManager), typeof (UIntPtr), typeof (NSTextContainer), typeof (CGRect), typeof (CGPoint), typeof (UIntPtr) }, ParameterByRef = new bool [] { false, false, false, false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidChangeGeometry", Selector = "layoutManager:textContainer:didChangeGeometryFromSize:", ParameterType = new Type [] { typeof (NSLayoutManager), typeof (NSTextContainer), typeof (CGSize) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldSetLineFragmentRect", Selector = "layoutManager:shouldSetLineFragmentRect:lineFragmentUsedRect:baselineOffset:inTextContainer:forGlyphRange:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (NSLayoutManager), typeof (CGRect), typeof (CGRect), typeof (NFloat), typeof (NSTextContainer), typeof (NSRange) }, ParameterByRef = new bool [] { false, true, true, true, false, false })]
	public partial interface INSLayoutManagerDelegate : INativeObject, IDisposable
	{
		/// <param name="sender">To be added.</param><summary>Indicates that the NSLayoutManager has invalidated layout information (not glyph information).</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("layoutManagerDidInvalidateLayout:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidInvalidatedLayout (NSLayoutManager sender)
		{
			_DidInvalidatedLayout (this, sender);
		}
		/// <param name="sender">To be added.</param><summary>Indicates that the NSLayoutManager has invalidated layout information (not glyph information).</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidInvalidatedLayout (INSLayoutManagerDelegate This, NSLayoutManager sender)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("layoutManagerDidInvalidateLayout:"), sender__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
		}
		/// <param name="layoutManager">To be added.</param><param name="textContainer">To be added.</param><param name="layoutFinishedFlag">To be added.</param><summary>Indicates that the specified NSLayoutManager has finished laying out text in the specified text container.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("layoutManager:didCompleteLayoutForTextContainer:atEnd:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidCompleteLayout (NSLayoutManager layoutManager, NSTextContainer? textContainer, bool layoutFinishedFlag)
		{
			_DidCompleteLayout (this, layoutManager, textContainer, layoutFinishedFlag);
		}
		/// <param name="layoutManager">To be added.</param><param name="textContainer">To be added.</param><param name="layoutFinishedFlag">To be added.</param><summary>Indicates that the specified NSLayoutManager has finished laying out text in the specified text container.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidCompleteLayout (INSLayoutManagerDelegate This, NSLayoutManager layoutManager, NSTextContainer? textContainer, bool layoutFinishedFlag)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var layoutManager__handle__ = layoutManager!.GetNonNullHandle (nameof (layoutManager));
			var textContainer__handle__ = textContainer.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_bool (This.Handle, Selector.GetHandle ("layoutManager:didCompleteLayoutForTextContainer:atEnd:"), layoutManager__handle__, textContainer__handle__, layoutFinishedFlag ? (byte) 1 : (byte) 0);
			GC.KeepAlive (This);
			GC.KeepAlive (layoutManager);
			GC.KeepAlive (textContainer);
		}
		/// <param name="layoutManager">To be added.</param><param name="glyphBuffer">To be added.</param><param name="properties">To be added.</param><param name="characterIndexes">To be added.</param><param name="font">To be added.</param><param name="glyphRange">To be added.</param><summary>When overridden, allows the app developer to customize the initial glyph generation process.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("layoutManager:shouldGenerateGlyphs:properties:characterIndexes:font:forGlyphRange:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nuint ShouldGenerateGlyphs (NSLayoutManager layoutManager, nint glyphBuffer, nint properties, nint characterIndexes, UIFont font, NSRange glyphRange)
		{
			return _ShouldGenerateGlyphs (this, layoutManager, glyphBuffer, properties, characterIndexes, font, glyphRange);
		}
		/// <param name="layoutManager">To be added.</param><param name="glyphBuffer">To be added.</param><param name="properties">To be added.</param><param name="characterIndexes">To be added.</param><param name="font">To be added.</param><param name="glyphRange">To be added.</param><summary>When overridden, allows the app developer to customize the initial glyph generation process.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static nuint _ShouldGenerateGlyphs (INSLayoutManagerDelegate This, NSLayoutManager layoutManager, nint glyphBuffer, nint properties, nint characterIndexes, UIFont font, NSRange glyphRange)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var layoutManager__handle__ = layoutManager!.GetNonNullHandle (nameof (layoutManager));
			var font__handle__ = font!.GetNonNullHandle (nameof (font));
			nuint ret;
			ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend_NativeHandle_IntPtr_IntPtr_IntPtr_NativeHandle_NSRange (This.Handle, Selector.GetHandle ("layoutManager:shouldGenerateGlyphs:properties:characterIndexes:font:forGlyphRange:"), layoutManager__handle__, glyphBuffer, properties, characterIndexes, font__handle__, glyphRange);
			GC.KeepAlive (This);
			GC.KeepAlive (layoutManager);
			GC.KeepAlive (font);
			return ret!;
		}
		/// <param name="layoutManager">To be added.</param><param name="glyphIndex">To be added.</param><param name="rect">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("layoutManager:lineSpacingAfterGlyphAtIndex:withProposedLineFragmentRect:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nfloat GetLineSpacingAfterGlyph (NSLayoutManager layoutManager, nuint glyphIndex, CGRect rect)
		{
			return _GetLineSpacingAfterGlyph (this, layoutManager, glyphIndex, rect);
		}
		/// <param name="layoutManager">To be added.</param><param name="glyphIndex">To be added.</param><param name="rect">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static nfloat _GetLineSpacingAfterGlyph (INSLayoutManagerDelegate This, NSLayoutManager layoutManager, nuint glyphIndex, CGRect rect)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var layoutManager__handle__ = layoutManager!.GetNonNullHandle (nameof (layoutManager));
			nfloat ret;
			ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend_NativeHandle_UIntPtr_CGRect (This.Handle, Selector.GetHandle ("layoutManager:lineSpacingAfterGlyphAtIndex:withProposedLineFragmentRect:"), layoutManager__handle__, glyphIndex, rect);
			GC.KeepAlive (This);
			GC.KeepAlive (layoutManager);
			return ret!;
		}
		/// <param name="layoutManager">To be added.</param><param name="glyphIndex">To be added.</param><param name="rect">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("layoutManager:paragraphSpacingBeforeGlyphAtIndex:withProposedLineFragmentRect:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nfloat GetParagraphSpacingBeforeGlyph (NSLayoutManager layoutManager, nuint glyphIndex, CGRect rect)
		{
			return _GetParagraphSpacingBeforeGlyph (this, layoutManager, glyphIndex, rect);
		}
		/// <param name="layoutManager">To be added.</param><param name="glyphIndex">To be added.</param><param name="rect">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static nfloat _GetParagraphSpacingBeforeGlyph (INSLayoutManagerDelegate This, NSLayoutManager layoutManager, nuint glyphIndex, CGRect rect)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var layoutManager__handle__ = layoutManager!.GetNonNullHandle (nameof (layoutManager));
			nfloat ret;
			ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend_NativeHandle_UIntPtr_CGRect (This.Handle, Selector.GetHandle ("layoutManager:paragraphSpacingBeforeGlyphAtIndex:withProposedLineFragmentRect:"), layoutManager__handle__, glyphIndex, rect);
			GC.KeepAlive (This);
			GC.KeepAlive (layoutManager);
			return ret!;
		}
		/// <param name="layoutManager">To be added.</param><param name="glyphIndex">To be added.</param><param name="rect">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("layoutManager:paragraphSpacingAfterGlyphAtIndex:withProposedLineFragmentRect:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nfloat GetParagraphSpacingAfterGlyph (NSLayoutManager layoutManager, nuint glyphIndex, CGRect rect)
		{
			return _GetParagraphSpacingAfterGlyph (this, layoutManager, glyphIndex, rect);
		}
		/// <param name="layoutManager">To be added.</param><param name="glyphIndex">To be added.</param><param name="rect">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static nfloat _GetParagraphSpacingAfterGlyph (INSLayoutManagerDelegate This, NSLayoutManager layoutManager, nuint glyphIndex, CGRect rect)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var layoutManager__handle__ = layoutManager!.GetNonNullHandle (nameof (layoutManager));
			nfloat ret;
			ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend_NativeHandle_UIntPtr_CGRect (This.Handle, Selector.GetHandle ("layoutManager:paragraphSpacingAfterGlyphAtIndex:withProposedLineFragmentRect:"), layoutManager__handle__, glyphIndex, rect);
			GC.KeepAlive (This);
			GC.KeepAlive (layoutManager);
			return ret!;
		}
		/// <param name="layoutManager">To be added.</param><param name="action">To be added.</param><param name="characterIndex">To be added.</param><summary>The control character action for the control character at the specified index.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("layoutManager:shouldUseAction:forControlCharacterAtIndex:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSControlCharacterAction ShouldUseAction (NSLayoutManager layoutManager, NSControlCharacterAction action, nuint characterIndex)
		{
			return _ShouldUseAction (this, layoutManager, action, characterIndex);
		}
		/// <param name="layoutManager">To be added.</param><param name="action">To be added.</param><param name="characterIndex">To be added.</param><summary>The control character action for the control character at the specified index.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSControlCharacterAction _ShouldUseAction (INSLayoutManagerDelegate This, NSLayoutManager layoutManager, NSControlCharacterAction action, nuint characterIndex)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var layoutManager__handle__ = layoutManager!.GetNonNullHandle (nameof (layoutManager));
			NSControlCharacterAction ret;
			ret = (NSControlCharacterAction) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_NativeHandle_IntPtr_UIntPtr (This.Handle, Selector.GetHandle ("layoutManager:shouldUseAction:forControlCharacterAtIndex:"), layoutManager__handle__, (IntPtr) (long) action, characterIndex);
			GC.KeepAlive (This);
			GC.KeepAlive (layoutManager);
			return ret!;
		}
		/// <param name="layoutManager">To be added.</param><param name="characterIndex">To be added.</param><summary>Whether a line should have a soft line break. Called frequently.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("layoutManager:shouldBreakLineByWordBeforeCharacterAtIndex:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldBreakLineByWordBeforeCharacter (NSLayoutManager layoutManager, nuint characterIndex)
		{
			return _ShouldBreakLineByWordBeforeCharacter (this, layoutManager, characterIndex);
		}
		/// <param name="layoutManager">To be added.</param><param name="characterIndex">To be added.</param><summary>Whether a line should have a soft line break. Called frequently.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _ShouldBreakLineByWordBeforeCharacter (INSLayoutManagerDelegate This, NSLayoutManager layoutManager, nuint characterIndex)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var layoutManager__handle__ = layoutManager!.GetNonNullHandle (nameof (layoutManager));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_UIntPtr (This.Handle, Selector.GetHandle ("layoutManager:shouldBreakLineByWordBeforeCharacterAtIndex:"), layoutManager__handle__, characterIndex);
			GC.KeepAlive (This);
			GC.KeepAlive (layoutManager);
			return ret != 0;
		}
		/// <param name="layoutManager">To be added.</param><param name="characterIndex">To be added.</param><summary>Whether a line should break with a hyphen at the specified point. Called frequently.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("layoutManager:shouldBreakLineByHyphenatingBeforeCharacterAtIndex:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldBreakLineByHyphenatingBeforeCharacter (NSLayoutManager layoutManager, nuint characterIndex)
		{
			return _ShouldBreakLineByHyphenatingBeforeCharacter (this, layoutManager, characterIndex);
		}
		/// <param name="layoutManager">To be added.</param><param name="characterIndex">To be added.</param><summary>Whether a line should break with a hyphen at the specified point. Called frequently.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _ShouldBreakLineByHyphenatingBeforeCharacter (INSLayoutManagerDelegate This, NSLayoutManager layoutManager, nuint characterIndex)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var layoutManager__handle__ = layoutManager!.GetNonNullHandle (nameof (layoutManager));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_UIntPtr (This.Handle, Selector.GetHandle ("layoutManager:shouldBreakLineByHyphenatingBeforeCharacterAtIndex:"), layoutManager__handle__, characterIndex);
			GC.KeepAlive (This);
			GC.KeepAlive (layoutManager);
			return ret != 0;
		}
		/// <param name="layoutManager">To be added.</param><param name="glyphIndex">To be added.</param><param name="textContainer">To be added.</param><param name="proposedRect">To be added.</param><param name="glyphPosition">To be added.</param><param name="characterIndex">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("layoutManager:boundingBoxForControlGlyphAtIndex:forTextContainer:proposedLineFragment:glyphPosition:characterIndex:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGRect GetBoundingBox (NSLayoutManager layoutManager, nuint glyphIndex, NSTextContainer textContainer, CGRect proposedRect, CGPoint glyphPosition, nuint characterIndex)
		{
			return _GetBoundingBox (this, layoutManager, glyphIndex, textContainer, proposedRect, glyphPosition, characterIndex);
		}
		/// <param name="layoutManager">To be added.</param><param name="glyphIndex">To be added.</param><param name="textContainer">To be added.</param><param name="proposedRect">To be added.</param><param name="glyphPosition">To be added.</param><param name="characterIndex">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static CGRect _GetBoundingBox (INSLayoutManagerDelegate This, NSLayoutManager layoutManager, nuint glyphIndex, NSTextContainer textContainer, CGRect proposedRect, CGPoint glyphPosition, nuint characterIndex)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var layoutManager__handle__ = layoutManager!.GetNonNullHandle (nameof (layoutManager));
			var textContainer__handle__ = textContainer!.GetNonNullHandle (nameof (textContainer));
			CGRect ret;
			if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
				ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_NativeHandle_UIntPtr_NativeHandle_CGRect_CGPoint_UIntPtr (This.Handle, Selector.GetHandle ("layoutManager:boundingBoxForControlGlyphAtIndex:forTextContainer:proposedLineFragment:glyphPosition:characterIndex:"), layoutManager__handle__, glyphIndex, textContainer__handle__, proposedRect, glyphPosition, characterIndex);
				GC.KeepAlive (This);
			} else {
				ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret_NativeHandle_UIntPtr_NativeHandle_CGRect_CGPoint_UIntPtr (This.Handle, Selector.GetHandle ("layoutManager:boundingBoxForControlGlyphAtIndex:forTextContainer:proposedLineFragment:glyphPosition:characterIndex:"), layoutManager__handle__, glyphIndex, textContainer__handle__, proposedRect, glyphPosition, characterIndex);
				GC.KeepAlive (This);
			}
			GC.KeepAlive (layoutManager);
			GC.KeepAlive (textContainer);
			return ret!;
		}
		/// <param name="layoutManager">To be added.</param><param name="textContainer">To be added.</param><param name="oldSize">To be added.</param><summary>The geometry of <paramref name="textContainer" /> changed from <paramref name="oldSize" />, and <paramref name="layoutManager" /> will invalidate the layout.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("layoutManager:textContainer:didChangeGeometryFromSize:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidChangeGeometry (NSLayoutManager layoutManager, NSTextContainer textContainer, CGSize oldSize)
		{
			_DidChangeGeometry (this, layoutManager, textContainer, oldSize);
		}
		/// <param name="layoutManager">To be added.</param><param name="textContainer">To be added.</param><param name="oldSize">To be added.</param><summary>The geometry of <paramref name="textContainer" /> changed from <paramref name="oldSize" />, and <paramref name="layoutManager" /> will invalidate the layout.</summary><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidChangeGeometry (INSLayoutManagerDelegate This, NSLayoutManager layoutManager, NSTextContainer textContainer, CGSize oldSize)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var layoutManager__handle__ = layoutManager!.GetNonNullHandle (nameof (layoutManager));
			var textContainer__handle__ = textContainer!.GetNonNullHandle (nameof (textContainer));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_CGSize (This.Handle, Selector.GetHandle ("layoutManager:textContainer:didChangeGeometryFromSize:"), layoutManager__handle__, textContainer__handle__, oldSize);
			GC.KeepAlive (This);
			GC.KeepAlive (layoutManager);
			GC.KeepAlive (textContainer);
		}
		/// <param name="layoutManager">To be added.</param><param name="lineFragmentRect">To be added.</param><param name="lineFragmentUsedRect">To be added.</param><param name="baselineOffset">To be added.</param><param name="textContainer">To be added.</param><param name="glyphRange">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("layoutManager:shouldSetLineFragmentRect:lineFragmentUsedRect:baselineOffset:inTextContainer:forGlyphRange:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual bool ShouldSetLineFragmentRect (NSLayoutManager layoutManager, ref CGRect lineFragmentRect, ref CGRect lineFragmentUsedRect, ref nfloat baselineOffset, NSTextContainer textContainer, NSRange glyphRange)
		{
			return _ShouldSetLineFragmentRect (this, layoutManager, ref lineFragmentRect, ref lineFragmentUsedRect, ref baselineOffset, textContainer, glyphRange);
		}
		/// <param name="layoutManager">To be added.</param><param name="lineFragmentRect">To be added.</param><param name="lineFragmentUsedRect">To be added.</param><param name="baselineOffset">To be added.</param><param name="textContainer">To be added.</param><param name="glyphRange">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static bool _ShouldSetLineFragmentRect (INSLayoutManagerDelegate This, NSLayoutManager layoutManager, ref CGRect lineFragmentRect, ref CGRect lineFragmentUsedRect, ref nfloat baselineOffset, NSTextContainer textContainer, NSRange glyphRange)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var layoutManager__handle__ = layoutManager!.GetNonNullHandle (nameof (layoutManager));
			var textContainer__handle__ = textContainer!.GetNonNullHandle (nameof (textContainer));
			fixed (CGRect* lineFragmentRect__pointer = &lineFragmentRect) {
			fixed (CGRect* lineFragmentUsedRect__pointer = &lineFragmentUsedRect) {
			fixed (nfloat* baselineOffset__pointer = &baselineOffset) {
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_ref_CGRect_ref_CGRect_ref_NFloat_NativeHandle_NSRange (This.Handle, Selector.GetHandle ("layoutManager:shouldSetLineFragmentRect:lineFragmentUsedRect:baselineOffset:inTextContainer:forGlyphRange:"), layoutManager__handle__, lineFragmentRect__pointer, lineFragmentUsedRect__pointer, baselineOffset__pointer, textContainer__handle__, glyphRange);
			GC.KeepAlive (This);
			GC.KeepAlive (layoutManager);
			GC.KeepAlive (textContainer);
			return ret != 0;
			}
			}
			}
		}
		[DynamicDependencyAttribute ("DidChangeGeometry(UIKit.NSLayoutManager,UIKit.NSTextContainer,CoreGraphics.CGSize)")]
		[DynamicDependencyAttribute ("DidCompleteLayout(UIKit.NSLayoutManager,UIKit.NSTextContainer,System.Boolean)")]
		[DynamicDependencyAttribute ("DidInvalidatedLayout(UIKit.NSLayoutManager)")]
		[DynamicDependencyAttribute ("GetBoundingBox(UIKit.NSLayoutManager,System.UIntPtr,UIKit.NSTextContainer,CoreGraphics.CGRect,CoreGraphics.CGPoint,System.UIntPtr)")]
		[DynamicDependencyAttribute ("GetLineSpacingAfterGlyph(UIKit.NSLayoutManager,System.UIntPtr,CoreGraphics.CGRect)")]
		[DynamicDependencyAttribute ("GetParagraphSpacingAfterGlyph(UIKit.NSLayoutManager,System.UIntPtr,CoreGraphics.CGRect)")]
		[DynamicDependencyAttribute ("GetParagraphSpacingBeforeGlyph(UIKit.NSLayoutManager,System.UIntPtr,CoreGraphics.CGRect)")]
		[DynamicDependencyAttribute ("ShouldBreakLineByHyphenatingBeforeCharacter(UIKit.NSLayoutManager,System.UIntPtr)")]
		[DynamicDependencyAttribute ("ShouldBreakLineByWordBeforeCharacter(UIKit.NSLayoutManager,System.UIntPtr)")]
		[DynamicDependencyAttribute ("ShouldGenerateGlyphs(UIKit.NSLayoutManager,System.IntPtr,System.IntPtr,System.IntPtr,UIKit.UIFont,Foundation.NSRange)")]
		[DynamicDependencyAttribute ("ShouldSetLineFragmentRect(UIKit.NSLayoutManager,CoreGraphics.CGRect@,CoreGraphics.CGRect@,System.Runtime.InteropServices.NFloat@,UIKit.NSTextContainer,Foundation.NSRange)")]
		[DynamicDependencyAttribute ("ShouldUseAction(UIKit.NSLayoutManager,UIKit.NSControlCharacterAction,System.UIntPtr)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSLayoutManagerDelegateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static INSLayoutManagerDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="INSLayoutManagerDelegate" /> interface to support all the methods from the NSLayoutManagerDelegate protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="INSLayoutManagerDelegate" /> interface allow developers to treat instances of the interface as having all the optional methods of the original NSLayoutManagerDelegate protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class NSLayoutManagerDelegate_Extensions {
		/// <param name="sender">To be added.</param><summary>Indicates that the NSLayoutManager has invalidated layout information (not glyph information).</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidInvalidatedLayout (this INSLayoutManagerDelegate This, NSLayoutManager sender)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("layoutManagerDidInvalidateLayout:"), sender__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
		}
		/// <param name="layoutManager">To be added.</param><param name="textContainer">To be added.</param><param name="layoutFinishedFlag">To be added.</param><summary>Indicates that the specified NSLayoutManager has finished laying out text in the specified text container.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidCompleteLayout (this INSLayoutManagerDelegate This, NSLayoutManager layoutManager, NSTextContainer? textContainer, bool layoutFinishedFlag)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var layoutManager__handle__ = layoutManager!.GetNonNullHandle (nameof (layoutManager));
			var textContainer__handle__ = textContainer.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_bool (This.Handle, Selector.GetHandle ("layoutManager:didCompleteLayoutForTextContainer:atEnd:"), layoutManager__handle__, textContainer__handle__, layoutFinishedFlag ? (byte) 1 : (byte) 0);
			GC.KeepAlive (This);
			GC.KeepAlive (layoutManager);
			GC.KeepAlive (textContainer);
		}
		/// <param name="layoutManager">To be added.</param><param name="glyphBuffer">To be added.</param><param name="properties">To be added.</param><param name="characterIndexes">To be added.</param><param name="font">To be added.</param><param name="glyphRange">To be added.</param><summary>When overridden, allows the app developer to customize the initial glyph generation process.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static nuint ShouldGenerateGlyphs (this INSLayoutManagerDelegate This, NSLayoutManager layoutManager, nint glyphBuffer, nint properties, nint characterIndexes, UIFont font, NSRange glyphRange)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var layoutManager__handle__ = layoutManager!.GetNonNullHandle (nameof (layoutManager));
			var font__handle__ = font!.GetNonNullHandle (nameof (font));
			nuint ret;
			ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend_NativeHandle_IntPtr_IntPtr_IntPtr_NativeHandle_NSRange (This.Handle, Selector.GetHandle ("layoutManager:shouldGenerateGlyphs:properties:characterIndexes:font:forGlyphRange:"), layoutManager__handle__, glyphBuffer, properties, characterIndexes, font__handle__, glyphRange);
			GC.KeepAlive (This);
			GC.KeepAlive (layoutManager);
			GC.KeepAlive (font);
			return ret!;
		}
		/// <param name="layoutManager">To be added.</param><param name="glyphIndex">To be added.</param><param name="rect">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static nfloat GetLineSpacingAfterGlyph (this INSLayoutManagerDelegate This, NSLayoutManager layoutManager, nuint glyphIndex, CGRect rect)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var layoutManager__handle__ = layoutManager!.GetNonNullHandle (nameof (layoutManager));
			nfloat ret;
			ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend_NativeHandle_UIntPtr_CGRect (This.Handle, Selector.GetHandle ("layoutManager:lineSpacingAfterGlyphAtIndex:withProposedLineFragmentRect:"), layoutManager__handle__, glyphIndex, rect);
			GC.KeepAlive (This);
			GC.KeepAlive (layoutManager);
			return ret!;
		}
		/// <param name="layoutManager">To be added.</param><param name="glyphIndex">To be added.</param><param name="rect">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static nfloat GetParagraphSpacingBeforeGlyph (this INSLayoutManagerDelegate This, NSLayoutManager layoutManager, nuint glyphIndex, CGRect rect)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var layoutManager__handle__ = layoutManager!.GetNonNullHandle (nameof (layoutManager));
			nfloat ret;
			ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend_NativeHandle_UIntPtr_CGRect (This.Handle, Selector.GetHandle ("layoutManager:paragraphSpacingBeforeGlyphAtIndex:withProposedLineFragmentRect:"), layoutManager__handle__, glyphIndex, rect);
			GC.KeepAlive (This);
			GC.KeepAlive (layoutManager);
			return ret!;
		}
		/// <param name="layoutManager">To be added.</param><param name="glyphIndex">To be added.</param><param name="rect">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static nfloat GetParagraphSpacingAfterGlyph (this INSLayoutManagerDelegate This, NSLayoutManager layoutManager, nuint glyphIndex, CGRect rect)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var layoutManager__handle__ = layoutManager!.GetNonNullHandle (nameof (layoutManager));
			nfloat ret;
			ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend_NativeHandle_UIntPtr_CGRect (This.Handle, Selector.GetHandle ("layoutManager:paragraphSpacingAfterGlyphAtIndex:withProposedLineFragmentRect:"), layoutManager__handle__, glyphIndex, rect);
			GC.KeepAlive (This);
			GC.KeepAlive (layoutManager);
			return ret!;
		}
		/// <param name="layoutManager">To be added.</param><param name="action">To be added.</param><param name="characterIndex">To be added.</param><summary>The control character action for the control character at the specified index.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSControlCharacterAction ShouldUseAction (this INSLayoutManagerDelegate This, NSLayoutManager layoutManager, NSControlCharacterAction action, nuint characterIndex)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var layoutManager__handle__ = layoutManager!.GetNonNullHandle (nameof (layoutManager));
			NSControlCharacterAction ret;
			ret = (NSControlCharacterAction) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_NativeHandle_IntPtr_UIntPtr (This.Handle, Selector.GetHandle ("layoutManager:shouldUseAction:forControlCharacterAtIndex:"), layoutManager__handle__, (IntPtr) (long) action, characterIndex);
			GC.KeepAlive (This);
			GC.KeepAlive (layoutManager);
			return ret!;
		}
		/// <param name="layoutManager">To be added.</param><param name="characterIndex">To be added.</param><summary>Whether a line should have a soft line break. Called frequently.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool ShouldBreakLineByWordBeforeCharacter (this INSLayoutManagerDelegate This, NSLayoutManager layoutManager, nuint characterIndex)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var layoutManager__handle__ = layoutManager!.GetNonNullHandle (nameof (layoutManager));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_UIntPtr (This.Handle, Selector.GetHandle ("layoutManager:shouldBreakLineByWordBeforeCharacterAtIndex:"), layoutManager__handle__, characterIndex);
			GC.KeepAlive (This);
			GC.KeepAlive (layoutManager);
			return ret != 0;
		}
		/// <param name="layoutManager">To be added.</param><param name="characterIndex">To be added.</param><summary>Whether a line should break with a hyphen at the specified point. Called frequently.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool ShouldBreakLineByHyphenatingBeforeCharacter (this INSLayoutManagerDelegate This, NSLayoutManager layoutManager, nuint characterIndex)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var layoutManager__handle__ = layoutManager!.GetNonNullHandle (nameof (layoutManager));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_UIntPtr (This.Handle, Selector.GetHandle ("layoutManager:shouldBreakLineByHyphenatingBeforeCharacterAtIndex:"), layoutManager__handle__, characterIndex);
			GC.KeepAlive (This);
			GC.KeepAlive (layoutManager);
			return ret != 0;
		}
		/// <param name="layoutManager">To be added.</param><param name="glyphIndex">To be added.</param><param name="textContainer">To be added.</param><param name="proposedRect">To be added.</param><param name="glyphPosition">To be added.</param><param name="characterIndex">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CGRect GetBoundingBox (this INSLayoutManagerDelegate This, NSLayoutManager layoutManager, nuint glyphIndex, NSTextContainer textContainer, CGRect proposedRect, CGPoint glyphPosition, nuint characterIndex)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var layoutManager__handle__ = layoutManager!.GetNonNullHandle (nameof (layoutManager));
			var textContainer__handle__ = textContainer!.GetNonNullHandle (nameof (textContainer));
			CGRect ret;
			if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
				ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_NativeHandle_UIntPtr_NativeHandle_CGRect_CGPoint_UIntPtr (This.Handle, Selector.GetHandle ("layoutManager:boundingBoxForControlGlyphAtIndex:forTextContainer:proposedLineFragment:glyphPosition:characterIndex:"), layoutManager__handle__, glyphIndex, textContainer__handle__, proposedRect, glyphPosition, characterIndex);
				GC.KeepAlive (This);
			} else {
				ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret_NativeHandle_UIntPtr_NativeHandle_CGRect_CGPoint_UIntPtr (This.Handle, Selector.GetHandle ("layoutManager:boundingBoxForControlGlyphAtIndex:forTextContainer:proposedLineFragment:glyphPosition:characterIndex:"), layoutManager__handle__, glyphIndex, textContainer__handle__, proposedRect, glyphPosition, characterIndex);
				GC.KeepAlive (This);
			}
			GC.KeepAlive (layoutManager);
			GC.KeepAlive (textContainer);
			return ret!;
		}
		/// <param name="layoutManager">To be added.</param><param name="textContainer">To be added.</param><param name="oldSize">To be added.</param><summary>The geometry of <paramref name="textContainer" /> changed from <paramref name="oldSize" />, and <paramref name="layoutManager" /> will invalidate the layout.</summary><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidChangeGeometry (this INSLayoutManagerDelegate This, NSLayoutManager layoutManager, NSTextContainer textContainer, CGSize oldSize)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var layoutManager__handle__ = layoutManager!.GetNonNullHandle (nameof (layoutManager));
			var textContainer__handle__ = textContainer!.GetNonNullHandle (nameof (textContainer));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_CGSize (This.Handle, Selector.GetHandle ("layoutManager:textContainer:didChangeGeometryFromSize:"), layoutManager__handle__, textContainer__handle__, oldSize);
			GC.KeepAlive (This);
			GC.KeepAlive (layoutManager);
			GC.KeepAlive (textContainer);
		}
		/// <param name="layoutManager">To be added.</param><param name="lineFragmentRect">To be added.</param><param name="lineFragmentUsedRect">To be added.</param><param name="baselineOffset">To be added.</param><param name="textContainer">To be added.</param><param name="glyphRange">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static bool ShouldSetLineFragmentRect (this INSLayoutManagerDelegate This, NSLayoutManager layoutManager, ref CGRect lineFragmentRect, ref CGRect lineFragmentUsedRect, ref nfloat baselineOffset, NSTextContainer textContainer, NSRange glyphRange)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var layoutManager__handle__ = layoutManager!.GetNonNullHandle (nameof (layoutManager));
			var textContainer__handle__ = textContainer!.GetNonNullHandle (nameof (textContainer));
			fixed (CGRect* lineFragmentRect__pointer = &lineFragmentRect) {
			fixed (CGRect* lineFragmentUsedRect__pointer = &lineFragmentUsedRect) {
			fixed (nfloat* baselineOffset__pointer = &baselineOffset) {
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_ref_CGRect_ref_CGRect_ref_NFloat_NativeHandle_NSRange (This.Handle, Selector.GetHandle ("layoutManager:shouldSetLineFragmentRect:lineFragmentUsedRect:baselineOffset:inTextContainer:forGlyphRange:"), layoutManager__handle__, lineFragmentRect__pointer, lineFragmentUsedRect__pointer, baselineOffset__pointer, textContainer__handle__, glyphRange);
			GC.KeepAlive (This);
			GC.KeepAlive (layoutManager);
			GC.KeepAlive (textContainer);
			return ret != 0;
			}
			}
			}
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class NSLayoutManagerDelegateWrapper : BaseWrapper, INSLayoutManagerDelegate {
		public NSLayoutManagerDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSLayoutManagerDelegateWrapper))]
		static NSLayoutManagerDelegateWrapper ()
		{
			GC.KeepAlive (null);
		}
	}
}
namespace UIKit {
	/// <summary>A delegate object that exposes events for <see cref="T:UIKit.NSLayoutManager" />s.</summary><related type="externalDocumentation" href="https://developer.apple.com/documentation/uikit/nslayoutmanagerdelegate">Apple documentation for <c>NSLayoutManagerDelegate</c></related>
	[Protocol()]
	[Register("Microsoft_iOS__UIKit_NSLayoutManagerDelegate", false)]
	[Model]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("tvos")]
	public unsafe partial class NSLayoutManagerDelegate : NSObject, INSLayoutManagerDelegate {
		/// <summary>Creates a new <see cref="NSLayoutManagerDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public NSLayoutManagerDelegate () : base (NSObjectFlag.Empty)
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
		protected NSLayoutManagerDelegate (NSObjectFlag t) : base (t)
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
		protected internal NSLayoutManagerDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		/// <param name="layoutManager">To be added.</param><param name="textContainer">To be added.</param><param name="oldSize">To be added.</param><summary>The geometry of <paramref name="textContainer" /> changed from <paramref name="oldSize" />, and <paramref name="layoutManager" /> will invalidate the layout.</summary><remarks>To be added.</remarks>
		[Export ("layoutManager:textContainer:didChangeGeometryFromSize:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidChangeGeometry (NSLayoutManager layoutManager, NSTextContainer textContainer, CGSize oldSize)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="layoutManager">To be added.</param><param name="textContainer">To be added.</param><param name="layoutFinishedFlag">To be added.</param><summary>Indicates that the specified NSLayoutManager has finished laying out text in the specified text container.</summary><remarks>To be added.</remarks>
		[Export ("layoutManager:didCompleteLayoutForTextContainer:atEnd:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidCompleteLayout (NSLayoutManager layoutManager, NSTextContainer? textContainer, bool layoutFinishedFlag)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="sender">To be added.</param><summary>Indicates that the NSLayoutManager has invalidated layout information (not glyph information).</summary><remarks>To be added.</remarks>
		[Export ("layoutManagerDidInvalidateLayout:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidInvalidatedLayout (NSLayoutManager sender)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="layoutManager">To be added.</param><param name="glyphIndex">To be added.</param><param name="textContainer">To be added.</param><param name="proposedRect">To be added.</param><param name="glyphPosition">To be added.</param><param name="characterIndex">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("layoutManager:boundingBoxForControlGlyphAtIndex:forTextContainer:proposedLineFragment:glyphPosition:characterIndex:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGRect GetBoundingBox (NSLayoutManager layoutManager, nuint glyphIndex, NSTextContainer textContainer, CGRect proposedRect, CGPoint glyphPosition, nuint characterIndex)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="layoutManager">To be added.</param><param name="glyphIndex">To be added.</param><param name="rect">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("layoutManager:lineSpacingAfterGlyphAtIndex:withProposedLineFragmentRect:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nfloat GetLineSpacingAfterGlyph (NSLayoutManager layoutManager, nuint glyphIndex, CGRect rect)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="layoutManager">To be added.</param><param name="glyphIndex">To be added.</param><param name="rect">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("layoutManager:paragraphSpacingAfterGlyphAtIndex:withProposedLineFragmentRect:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nfloat GetParagraphSpacingAfterGlyph (NSLayoutManager layoutManager, nuint glyphIndex, CGRect rect)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="layoutManager">To be added.</param><param name="glyphIndex">To be added.</param><param name="rect">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("layoutManager:paragraphSpacingBeforeGlyphAtIndex:withProposedLineFragmentRect:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nfloat GetParagraphSpacingBeforeGlyph (NSLayoutManager layoutManager, nuint glyphIndex, CGRect rect)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="layoutManager">To be added.</param><param name="characterIndex">To be added.</param><summary>Whether a line should break with a hyphen at the specified point. Called frequently.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("layoutManager:shouldBreakLineByHyphenatingBeforeCharacterAtIndex:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldBreakLineByHyphenatingBeforeCharacter (NSLayoutManager layoutManager, nuint characterIndex)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="layoutManager">To be added.</param><param name="characterIndex">To be added.</param><summary>Whether a line should have a soft line break. Called frequently.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("layoutManager:shouldBreakLineByWordBeforeCharacterAtIndex:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldBreakLineByWordBeforeCharacter (NSLayoutManager layoutManager, nuint characterIndex)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="layoutManager">To be added.</param><param name="glyphBuffer">To be added.</param><param name="properties">To be added.</param><param name="characterIndexes">To be added.</param><param name="font">To be added.</param><param name="glyphRange">To be added.</param><summary>When overridden, allows the app developer to customize the initial glyph generation process.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("layoutManager:shouldGenerateGlyphs:properties:characterIndexes:font:forGlyphRange:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nuint ShouldGenerateGlyphs (NSLayoutManager layoutManager, nint glyphBuffer, nint properties, nint characterIndexes, UIFont font, NSRange glyphRange)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="layoutManager">To be added.</param><param name="lineFragmentRect">To be added.</param><param name="lineFragmentUsedRect">To be added.</param><param name="baselineOffset">To be added.</param><param name="textContainer">To be added.</param><param name="glyphRange">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("layoutManager:shouldSetLineFragmentRect:lineFragmentUsedRect:baselineOffset:inTextContainer:forGlyphRange:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual bool ShouldSetLineFragmentRect (NSLayoutManager layoutManager, ref CGRect lineFragmentRect, ref CGRect lineFragmentUsedRect, ref nfloat baselineOffset, NSTextContainer textContainer, NSRange glyphRange)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="layoutManager">To be added.</param><param name="action">To be added.</param><param name="characterIndex">To be added.</param><summary>The control character action for the control character at the specified index.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("layoutManager:shouldUseAction:forControlCharacterAtIndex:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSControlCharacterAction ShouldUseAction (NSLayoutManager layoutManager, NSControlCharacterAction action, nuint characterIndex)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class NSLayoutManagerDelegate */
}
