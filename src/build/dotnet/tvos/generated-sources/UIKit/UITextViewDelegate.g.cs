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
	/// <summary>A class used to receive notifications from a UITextView control.</summary><remarks>
	/// 
	/// A strongly typed implementation of a class that can be used to respond to events raised by the <see cref="T:UIKit.UITextView" />.</remarks><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/UIKit/Reference/UITextViewDelegate_Protocol/index.html">Apple documentation for <c>UITextViewDelegate</c></related>
	[UnsupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("tvos")]
	[Protocol (Name = "UITextViewDelegate", WrapperType = typeof (UITextViewDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldBeginEditing", Selector = "textViewShouldBeginEditing:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (UITextView) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldEndEditing", Selector = "textViewShouldEndEditing:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (UITextView) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "EditingStarted", Selector = "textViewDidBeginEditing:", ParameterType = new Type [] { typeof (UITextView) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "EditingEnded", Selector = "textViewDidEndEditing:", ParameterType = new Type [] { typeof (UITextView) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldChangeText", Selector = "textView:shouldChangeTextInRange:replacementText:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (UITextView), typeof (NSRange), typeof (string) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "Changed", Selector = "textViewDidChange:", ParameterType = new Type [] { typeof (UITextView) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "SelectionChanged", Selector = "textViewDidChangeSelection:", ParameterType = new Type [] { typeof (UITextView) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldInteractWithUrl", Selector = "textView:shouldInteractWithURL:inRange:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (UITextView), typeof (NSUrl), typeof (NSRange) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldInteractWithTextAttachment", Selector = "textView:shouldInteractWithTextAttachment:inRange:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (UITextView), typeof (NSTextAttachment), typeof (NSRange) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldInteractWithUrl", Selector = "textView:shouldInteractWithURL:inRange:interaction:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (UITextView), typeof (NSUrl), typeof (NSRange), typeof (UITextItemInteraction) }, ParameterByRef = new bool [] { false, false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldInteractWithTextAttachment", Selector = "textView:shouldInteractWithTextAttachment:inRange:interaction:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (UITextView), typeof (NSTextAttachment), typeof (NSRange), typeof (UITextItemInteraction) }, ParameterByRef = new bool [] { false, false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetEditMenuForText", Selector = "textView:editMenuForTextInRange:suggestedActions:", ReturnType = typeof (UIMenu), ParameterType = new Type [] { typeof (UITextView), typeof (NSRange), typeof (UIMenuElement[]) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldChangeText", Selector = "textView:shouldChangeTextInRanges:replacementText:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (UITextView), typeof (NSValue[]), typeof (string) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetEditMenuForText", Selector = "textView:editMenuForTextInRanges:suggestedActions:", ReturnType = typeof (UIMenu), ParameterType = new Type [] { typeof (UITextView), typeof (NSValue[]), typeof (UIMenuElement[]) }, ParameterByRef = new bool [] { false, false, false })]
	public partial interface IUITextViewDelegate : INativeObject, IDisposable, 
		UIKit.IUIScrollViewDelegate
	{
		/// <param name="textView">To be added.</param><summary>Whether editing should begin in the specified UITextView.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("textViewShouldBeginEditing:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldBeginEditing (UITextView textView)
		{
			return _ShouldBeginEditing (this, textView);
		}
		/// <param name="textView">To be added.</param><summary>Whether editing should begin in the specified UITextView.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _ShouldBeginEditing (IUITextViewDelegate This, UITextView textView)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var textView__handle__ = textView!.GetNonNullHandle (nameof (textView));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("textViewShouldBeginEditing:"), textView__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (textView);
			return ret != 0;
		}
		/// <param name="textView">To be added.</param><summary>Whether editing should end in the specified UITextView.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("textViewShouldEndEditing:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldEndEditing (UITextView textView)
		{
			return _ShouldEndEditing (this, textView);
		}
		/// <param name="textView">To be added.</param><summary>Whether editing should end in the specified UITextView.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _ShouldEndEditing (IUITextViewDelegate This, UITextView textView)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var textView__handle__ = textView!.GetNonNullHandle (nameof (textView));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("textViewShouldEndEditing:"), textView__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (textView);
			return ret != 0;
		}
		/// <param name="textView">To be added.</param><summary>Indicates editing has begun in the specified UITextView.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("textViewDidBeginEditing:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void EditingStarted (UITextView textView)
		{
			_EditingStarted (this, textView);
		}
		/// <param name="textView">To be added.</param><summary>Indicates editing has begun in the specified UITextView.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _EditingStarted (IUITextViewDelegate This, UITextView textView)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var textView__handle__ = textView!.GetNonNullHandle (nameof (textView));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("textViewDidBeginEditing:"), textView__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (textView);
		}
		/// <param name="textView">To be added.</param><summary>Indicates that editing has ended in the specified UITextView.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("textViewDidEndEditing:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void EditingEnded (UITextView textView)
		{
			_EditingEnded (this, textView);
		}
		/// <param name="textView">To be added.</param><summary>Indicates that editing has ended in the specified UITextView.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _EditingEnded (IUITextViewDelegate This, UITextView textView)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var textView__handle__ = textView!.GetNonNullHandle (nameof (textView));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("textViewDidEndEditing:"), textView__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (textView);
		}
		/// <param name="textView">To be added.</param><param name="range">To be added.</param><param name="text">To be added.</param><summary>Whether the specified text should be replaced in the UITextView.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("textView:shouldChangeTextInRange:replacementText:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldChangeText (UITextView textView, NSRange range, string text)
		{
			return _ShouldChangeText (this, textView, range, text);
		}
		/// <param name="textView">To be added.</param><param name="range">To be added.</param><param name="text">To be added.</param><summary>Whether the specified text should be replaced in the UITextView.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _ShouldChangeText (IUITextViewDelegate This, UITextView textView, NSRange range, string text)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var textView__handle__ = textView!.GetNonNullHandle (nameof (textView));
			if (text is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (text));
			var nstext = CFString.CreateNative (text);
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NSRange_NativeHandle (This.Handle, Selector.GetHandle ("textView:shouldChangeTextInRange:replacementText:"), textView__handle__, range, nstext);
			GC.KeepAlive (This);
			GC.KeepAlive (textView);
			CFString.ReleaseNative (nstext);
			return ret != 0;
		}
		/// <param name="textView">To be added.</param><summary>Indicates the text or text attributes in the specified UITextView were changed by the app user.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("textViewDidChange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Changed (UITextView textView)
		{
			_Changed (this, textView);
		}
		/// <param name="textView">To be added.</param><summary>Indicates the text or text attributes in the specified UITextView were changed by the app user.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _Changed (IUITextViewDelegate This, UITextView textView)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var textView__handle__ = textView!.GetNonNullHandle (nameof (textView));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("textViewDidChange:"), textView__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (textView);
		}
		/// <param name="textView">To be added.</param><summary>Indicates the text selection has changed in the specified UITextView.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("textViewDidChangeSelection:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SelectionChanged (UITextView textView)
		{
			_SelectionChanged (this, textView);
		}
		/// <param name="textView">To be added.</param><summary>Indicates the text selection has changed in the specified UITextView.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SelectionChanged (IUITextViewDelegate This, UITextView textView)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var textView__handle__ = textView!.GetNonNullHandle (nameof (textView));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("textViewDidChangeSelection:"), textView__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (textView);
		}
		/// <param name="textView">To be added.</param><param name="URL">To be added.</param><param name="characterRange">To be added.</param><summary>Whether the specified UITextView should allow user interaction with the specified URL in the given range of text.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("textView:shouldInteractWithURL:inRange:")]
		[ObsoletedOSPlatform ("ios10.0", "Use the 'ShouldInteractWithUrl' overload that takes 'UITextItemInteraction' instead.")]
		[ObsoletedOSPlatform ("tvos10.0", "Use the 'ShouldInteractWithUrl' overload that takes 'UITextItemInteraction' instead.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use the 'ShouldInteractWithUrl' overload that takes 'UITextItemInteraction' instead.")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldInteractWithUrl (UITextView textView, NSUrl URL, NSRange characterRange)
		{
			return _ShouldInteractWithUrl (this, textView, URL, characterRange);
		}
		/// <param name="textView">To be added.</param><param name="URL">To be added.</param><param name="characterRange">To be added.</param><summary>Whether the specified UITextView should allow user interaction with the specified URL in the given range of text.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[ObsoletedOSPlatform ("ios10.0", "Use the 'ShouldInteractWithUrl' overload that takes 'UITextItemInteraction' instead.")]
		[ObsoletedOSPlatform ("tvos10.0", "Use the 'ShouldInteractWithUrl' overload that takes 'UITextItemInteraction' instead.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use the 'ShouldInteractWithUrl' overload that takes 'UITextItemInteraction' instead.")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _ShouldInteractWithUrl (IUITextViewDelegate This, UITextView textView, NSUrl URL, NSRange characterRange)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var textView__handle__ = textView!.GetNonNullHandle (nameof (textView));
			var URL__handle__ = URL!.GetNonNullHandle (nameof (URL));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_NSRange (This.Handle, Selector.GetHandle ("textView:shouldInteractWithURL:inRange:"), textView__handle__, URL__handle__, characterRange);
			GC.KeepAlive (This);
			GC.KeepAlive (textView);
			GC.KeepAlive (URL);
			return ret != 0;
		}
		/// <param name="textView">To be added.</param><param name="textAttachment">To be added.</param><param name="characterRange">To be added.</param><summary>Developers should not use this deprecated method. Developers should use the 'ShouldInteractWithTextAttachment' overload that takes 'UITextItemInteraction' instead.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("textView:shouldInteractWithTextAttachment:inRange:")]
		[ObsoletedOSPlatform ("ios10.0", "Use the 'ShouldInteractWithTextAttachment' overload that takes 'UITextItemInteraction' instead.")]
		[ObsoletedOSPlatform ("tvos10.0", "Use the 'ShouldInteractWithTextAttachment' overload that takes 'UITextItemInteraction' instead.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use the 'ShouldInteractWithTextAttachment' overload that takes 'UITextItemInteraction' instead.")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldInteractWithTextAttachment (UITextView textView, NSTextAttachment textAttachment, NSRange characterRange)
		{
			return _ShouldInteractWithTextAttachment (this, textView, textAttachment, characterRange);
		}
		/// <param name="textView">To be added.</param><param name="textAttachment">To be added.</param><param name="characterRange">To be added.</param><summary>Developers should not use this deprecated method. Developers should use the 'ShouldInteractWithTextAttachment' overload that takes 'UITextItemInteraction' instead.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[ObsoletedOSPlatform ("ios10.0", "Use the 'ShouldInteractWithTextAttachment' overload that takes 'UITextItemInteraction' instead.")]
		[ObsoletedOSPlatform ("tvos10.0", "Use the 'ShouldInteractWithTextAttachment' overload that takes 'UITextItemInteraction' instead.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use the 'ShouldInteractWithTextAttachment' overload that takes 'UITextItemInteraction' instead.")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _ShouldInteractWithTextAttachment (IUITextViewDelegate This, UITextView textView, NSTextAttachment textAttachment, NSRange characterRange)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var textView__handle__ = textView!.GetNonNullHandle (nameof (textView));
			var textAttachment__handle__ = textAttachment!.GetNonNullHandle (nameof (textAttachment));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_NSRange (This.Handle, Selector.GetHandle ("textView:shouldInteractWithTextAttachment:inRange:"), textView__handle__, textAttachment__handle__, characterRange);
			GC.KeepAlive (This);
			GC.KeepAlive (textView);
			GC.KeepAlive (textAttachment);
			return ret != 0;
		}
		/// <param name="textView">The text view that has the attachment.</param><param name="url">To be added.</param><param name="characterRange">The character range of the URL in the text view.</param><param name="interaction">The interaction type to check.</param><summary>Whether the specified UITextView should allow user interaction with the specified URL in the given range of text.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("textView:shouldInteractWithURL:inRange:interaction:")]
		[ObsoletedOSPlatform ("ios10.0", "Use the 'ShouldInteractWithTextAttachment' overload that takes 'UITextItemInteraction' instead.")]
		[ObsoletedOSPlatform ("tvos10.0", "Use the 'ShouldInteractWithTextAttachment' overload that takes 'UITextItemInteraction' instead.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use the 'ShouldInteractWithTextAttachment' overload that takes 'UITextItemInteraction' instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldInteractWithUrl (UITextView textView, NSUrl url, NSRange characterRange, UITextItemInteraction interaction)
		{
			return _ShouldInteractWithUrl (this, textView, url, characterRange, interaction);
		}
		/// <param name="textView">The text view that has the attachment.</param><param name="url">To be added.</param><param name="characterRange">The character range of the URL in the text view.</param><param name="interaction">The interaction type to check.</param><summary>Whether the specified UITextView should allow user interaction with the specified URL in the given range of text.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[ObsoletedOSPlatform ("ios10.0", "Use the 'ShouldInteractWithTextAttachment' overload that takes 'UITextItemInteraction' instead.")]
		[ObsoletedOSPlatform ("tvos10.0", "Use the 'ShouldInteractWithTextAttachment' overload that takes 'UITextItemInteraction' instead.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use the 'ShouldInteractWithTextAttachment' overload that takes 'UITextItemInteraction' instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _ShouldInteractWithUrl (IUITextViewDelegate This, UITextView textView, NSUrl url, NSRange characterRange, UITextItemInteraction interaction)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var textView__handle__ = textView!.GetNonNullHandle (nameof (textView));
			var url__handle__ = url!.GetNonNullHandle (nameof (url));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_NSRange_IntPtr (This.Handle, Selector.GetHandle ("textView:shouldInteractWithURL:inRange:interaction:"), textView__handle__, url__handle__, characterRange, (IntPtr) (long) interaction);
			GC.KeepAlive (This);
			GC.KeepAlive (textView);
			GC.KeepAlive (url);
			return ret != 0;
		}
		/// <param name="textView">The text view that has the attachment.</param><param name="textAttachment">The attachment.</param><param name="characterRange">The character range where the attachment is attached.</param><param name="interaction">The interaction type to check.</param><summary>Whether the specified UITextView should allow user interaction with the specified URL in the given range of text.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("textView:shouldInteractWithTextAttachment:inRange:interaction:")]
		[ObsoletedOSPlatform ("ios17.0", "Replaced by 'GetPrimaryAction' and 'GetMenuConfiguration'.")]
		[ObsoletedOSPlatform ("tvos17.0", "Replaced by 'GetPrimaryAction' and 'GetMenuConfiguration'.")]
		[ObsoletedOSPlatform ("maccatalyst17.0", "Replaced by 'GetPrimaryAction' and 'GetMenuConfiguration'.")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldInteractWithTextAttachment (UITextView textView, NSTextAttachment textAttachment, NSRange characterRange, UITextItemInteraction interaction)
		{
			return _ShouldInteractWithTextAttachment (this, textView, textAttachment, characterRange, interaction);
		}
		/// <param name="textView">The text view that has the attachment.</param><param name="textAttachment">The attachment.</param><param name="characterRange">The character range where the attachment is attached.</param><param name="interaction">The interaction type to check.</param><summary>Whether the specified UITextView should allow user interaction with the specified URL in the given range of text.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[ObsoletedOSPlatform ("ios17.0", "Replaced by 'GetPrimaryAction' and 'GetMenuConfiguration'.")]
		[ObsoletedOSPlatform ("tvos17.0", "Replaced by 'GetPrimaryAction' and 'GetMenuConfiguration'.")]
		[ObsoletedOSPlatform ("maccatalyst17.0", "Replaced by 'GetPrimaryAction' and 'GetMenuConfiguration'.")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _ShouldInteractWithTextAttachment (IUITextViewDelegate This, UITextView textView, NSTextAttachment textAttachment, NSRange characterRange, UITextItemInteraction interaction)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var textView__handle__ = textView!.GetNonNullHandle (nameof (textView));
			var textAttachment__handle__ = textAttachment!.GetNonNullHandle (nameof (textAttachment));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_NSRange_IntPtr (This.Handle, Selector.GetHandle ("textView:shouldInteractWithTextAttachment:inRange:interaction:"), textView__handle__, textAttachment__handle__, characterRange, (IntPtr) (long) interaction);
			GC.KeepAlive (This);
			GC.KeepAlive (textView);
			GC.KeepAlive (textAttachment);
			return ret != 0;
		}
		[global::Foundation.OptionalMember]
		[Export ("textView:editMenuForTextInRange:suggestedActions:")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[UnsupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIMenu? GetEditMenuForText (UITextView textView, NSRange range, UIMenuElement[] suggestedActions)
		{
			return _GetEditMenuForText (this, textView, range, suggestedActions);
		}
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[UnsupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static UIMenu? _GetEditMenuForText (IUITextViewDelegate This, UITextView textView, NSRange range, UIMenuElement[] suggestedActions)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var textView__handle__ = textView!.GetNonNullHandle (nameof (textView));
			if (suggestedActions is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (suggestedActions));
			using var nsa_suggestedActions = NSArray.FromNSObjects (suggestedActions);
			UIMenu? ret;
			ret =  Runtime.GetNSObject<UIMenu> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NSRange_NativeHandle (This.Handle, Selector.GetHandle ("textView:editMenuForTextInRange:suggestedActions:"), textView__handle__, range, nsa_suggestedActions.Handle), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (textView);
			return ret!;
		}
		[global::Foundation.OptionalMember]
		[Export ("textView:shouldChangeTextInRanges:replacementText:")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[UnsupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldChangeText (UITextView textView, NSValue[] ranges, string replacementText)
		{
			return _ShouldChangeText (this, textView, ranges, replacementText);
		}
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[UnsupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _ShouldChangeText (IUITextViewDelegate This, UITextView textView, NSValue[] ranges, string replacementText)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var textView__handle__ = textView!.GetNonNullHandle (nameof (textView));
			if (ranges is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (ranges));
			if (replacementText is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (replacementText));
			using var nsa_ranges = NSArray.FromNSObjects (ranges);
			var nsreplacementText = CFString.CreateNative (replacementText);
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("textView:shouldChangeTextInRanges:replacementText:"), textView__handle__, nsa_ranges.Handle, nsreplacementText);
			GC.KeepAlive (This);
			GC.KeepAlive (textView);
			CFString.ReleaseNative (nsreplacementText);
			return ret != 0;
		}
		[global::Foundation.OptionalMember]
		[Export ("textView:editMenuForTextInRanges:suggestedActions:")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[UnsupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIMenu? GetEditMenuForText (UITextView textView, NSValue[] ranges, UIMenuElement[] suggestedActions)
		{
			return _GetEditMenuForText (this, textView, ranges, suggestedActions);
		}
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[UnsupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static UIMenu? _GetEditMenuForText (IUITextViewDelegate This, UITextView textView, NSValue[] ranges, UIMenuElement[] suggestedActions)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var textView__handle__ = textView!.GetNonNullHandle (nameof (textView));
			if (ranges is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (ranges));
			if (suggestedActions is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (suggestedActions));
			using var nsa_ranges = NSArray.FromNSObjects (ranges);
			using var nsa_suggestedActions = NSArray.FromNSObjects (suggestedActions);
			UIMenu? ret;
			ret =  Runtime.GetNSObject<UIMenu> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("textView:editMenuForTextInRanges:suggestedActions:"), textView__handle__, nsa_ranges.Handle, nsa_suggestedActions.Handle), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (textView);
			return ret!;
		}
		[DynamicDependencyAttribute ("Changed(UIKit.UITextView)")]
		[DynamicDependencyAttribute ("EditingEnded(UIKit.UITextView)")]
		[DynamicDependencyAttribute ("EditingStarted(UIKit.UITextView)")]
		[DynamicDependencyAttribute ("GetEditMenuForText(UIKit.UITextView,Foundation.NSRange,UIKit.UIMenuElement[])")]
		[DynamicDependencyAttribute ("GetEditMenuForText(UIKit.UITextView,Foundation.NSValue[],UIKit.UIMenuElement[])")]
		[DynamicDependencyAttribute ("SelectionChanged(UIKit.UITextView)")]
		[DynamicDependencyAttribute ("ShouldBeginEditing(UIKit.UITextView)")]
		[DynamicDependencyAttribute ("ShouldChangeText(UIKit.UITextView,Foundation.NSRange,System.String)")]
		[DynamicDependencyAttribute ("ShouldChangeText(UIKit.UITextView,Foundation.NSValue[],System.String)")]
		[DynamicDependencyAttribute ("ShouldEndEditing(UIKit.UITextView)")]
		[DynamicDependencyAttribute ("ShouldInteractWithTextAttachment(UIKit.UITextView,UIKit.NSTextAttachment,Foundation.NSRange,UIKit.UITextItemInteraction)")]
		[DynamicDependencyAttribute ("ShouldInteractWithTextAttachment(UIKit.UITextView,UIKit.NSTextAttachment,Foundation.NSRange)")]
		[DynamicDependencyAttribute ("ShouldInteractWithUrl(UIKit.UITextView,Foundation.NSUrl,Foundation.NSRange,UIKit.UITextItemInteraction)")]
		[DynamicDependencyAttribute ("ShouldInteractWithUrl(UIKit.UITextView,Foundation.NSUrl,Foundation.NSRange)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UITextViewDelegateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IUITextViewDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="IUITextViewDelegate" /> interface to support all the methods from the UITextViewDelegate protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IUITextViewDelegate" /> interface allow developers to treat instances of the interface as having all the optional methods of the original UITextViewDelegate protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class UITextViewDelegate_Extensions {
		/// <param name="textView">To be added.</param><summary>Whether editing should begin in the specified UITextView.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool ShouldBeginEditing (this IUITextViewDelegate This, UITextView textView)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var textView__handle__ = textView!.GetNonNullHandle (nameof (textView));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("textViewShouldBeginEditing:"), textView__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (textView);
			return ret != 0;
		}
		/// <param name="textView">To be added.</param><summary>Whether editing should end in the specified UITextView.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool ShouldEndEditing (this IUITextViewDelegate This, UITextView textView)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var textView__handle__ = textView!.GetNonNullHandle (nameof (textView));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("textViewShouldEndEditing:"), textView__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (textView);
			return ret != 0;
		}
		/// <param name="textView">To be added.</param><summary>Indicates editing has begun in the specified UITextView.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void EditingStarted (this IUITextViewDelegate This, UITextView textView)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var textView__handle__ = textView!.GetNonNullHandle (nameof (textView));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("textViewDidBeginEditing:"), textView__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (textView);
		}
		/// <param name="textView">To be added.</param><summary>Indicates that editing has ended in the specified UITextView.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void EditingEnded (this IUITextViewDelegate This, UITextView textView)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var textView__handle__ = textView!.GetNonNullHandle (nameof (textView));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("textViewDidEndEditing:"), textView__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (textView);
		}
		/// <param name="textView">To be added.</param><param name="range">To be added.</param><param name="text">To be added.</param><summary>Whether the specified text should be replaced in the UITextView.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool ShouldChangeText (this IUITextViewDelegate This, UITextView textView, NSRange range, string text)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var textView__handle__ = textView!.GetNonNullHandle (nameof (textView));
			if (text is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (text));
			var nstext = CFString.CreateNative (text);
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NSRange_NativeHandle (This.Handle, Selector.GetHandle ("textView:shouldChangeTextInRange:replacementText:"), textView__handle__, range, nstext);
			GC.KeepAlive (This);
			GC.KeepAlive (textView);
			CFString.ReleaseNative (nstext);
			return ret != 0;
		}
		/// <param name="textView">To be added.</param><summary>Indicates the text or text attributes in the specified UITextView were changed by the app user.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void Changed (this IUITextViewDelegate This, UITextView textView)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var textView__handle__ = textView!.GetNonNullHandle (nameof (textView));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("textViewDidChange:"), textView__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (textView);
		}
		/// <param name="textView">To be added.</param><summary>Indicates the text selection has changed in the specified UITextView.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SelectionChanged (this IUITextViewDelegate This, UITextView textView)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var textView__handle__ = textView!.GetNonNullHandle (nameof (textView));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("textViewDidChangeSelection:"), textView__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (textView);
		}
		/// <param name="textView">To be added.</param><param name="URL">To be added.</param><param name="characterRange">To be added.</param><summary>Whether the specified UITextView should allow user interaction with the specified URL in the given range of text.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[ObsoletedOSPlatform ("ios10.0", "Use the 'ShouldInteractWithUrl' overload that takes 'UITextItemInteraction' instead.")]
		[ObsoletedOSPlatform ("tvos10.0", "Use the 'ShouldInteractWithUrl' overload that takes 'UITextItemInteraction' instead.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use the 'ShouldInteractWithUrl' overload that takes 'UITextItemInteraction' instead.")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool ShouldInteractWithUrl (this IUITextViewDelegate This, UITextView textView, NSUrl URL, NSRange characterRange)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var textView__handle__ = textView!.GetNonNullHandle (nameof (textView));
			var URL__handle__ = URL!.GetNonNullHandle (nameof (URL));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_NSRange (This.Handle, Selector.GetHandle ("textView:shouldInteractWithURL:inRange:"), textView__handle__, URL__handle__, characterRange);
			GC.KeepAlive (This);
			GC.KeepAlive (textView);
			GC.KeepAlive (URL);
			return ret != 0;
		}
		/// <param name="textView">To be added.</param><param name="textAttachment">To be added.</param><param name="characterRange">To be added.</param><summary>Developers should not use this deprecated method. Developers should use the 'ShouldInteractWithTextAttachment' overload that takes 'UITextItemInteraction' instead.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[ObsoletedOSPlatform ("ios10.0", "Use the 'ShouldInteractWithTextAttachment' overload that takes 'UITextItemInteraction' instead.")]
		[ObsoletedOSPlatform ("tvos10.0", "Use the 'ShouldInteractWithTextAttachment' overload that takes 'UITextItemInteraction' instead.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use the 'ShouldInteractWithTextAttachment' overload that takes 'UITextItemInteraction' instead.")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool ShouldInteractWithTextAttachment (this IUITextViewDelegate This, UITextView textView, NSTextAttachment textAttachment, NSRange characterRange)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var textView__handle__ = textView!.GetNonNullHandle (nameof (textView));
			var textAttachment__handle__ = textAttachment!.GetNonNullHandle (nameof (textAttachment));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_NSRange (This.Handle, Selector.GetHandle ("textView:shouldInteractWithTextAttachment:inRange:"), textView__handle__, textAttachment__handle__, characterRange);
			GC.KeepAlive (This);
			GC.KeepAlive (textView);
			GC.KeepAlive (textAttachment);
			return ret != 0;
		}
		/// <param name="textView">The text view that has the attachment.</param><param name="url">To be added.</param><param name="characterRange">The character range of the URL in the text view.</param><param name="interaction">The interaction type to check.</param><summary>Whether the specified UITextView should allow user interaction with the specified URL in the given range of text.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[ObsoletedOSPlatform ("ios10.0", "Use the 'ShouldInteractWithTextAttachment' overload that takes 'UITextItemInteraction' instead.")]
		[ObsoletedOSPlatform ("tvos10.0", "Use the 'ShouldInteractWithTextAttachment' overload that takes 'UITextItemInteraction' instead.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use the 'ShouldInteractWithTextAttachment' overload that takes 'UITextItemInteraction' instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool ShouldInteractWithUrl (this IUITextViewDelegate This, UITextView textView, NSUrl url, NSRange characterRange, UITextItemInteraction interaction)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var textView__handle__ = textView!.GetNonNullHandle (nameof (textView));
			var url__handle__ = url!.GetNonNullHandle (nameof (url));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_NSRange_IntPtr (This.Handle, Selector.GetHandle ("textView:shouldInteractWithURL:inRange:interaction:"), textView__handle__, url__handle__, characterRange, (IntPtr) (long) interaction);
			GC.KeepAlive (This);
			GC.KeepAlive (textView);
			GC.KeepAlive (url);
			return ret != 0;
		}
		/// <param name="textView">The text view that has the attachment.</param><param name="textAttachment">The attachment.</param><param name="characterRange">The character range where the attachment is attached.</param><param name="interaction">The interaction type to check.</param><summary>Whether the specified UITextView should allow user interaction with the specified URL in the given range of text.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[ObsoletedOSPlatform ("ios17.0", "Replaced by 'GetPrimaryAction' and 'GetMenuConfiguration'.")]
		[ObsoletedOSPlatform ("tvos17.0", "Replaced by 'GetPrimaryAction' and 'GetMenuConfiguration'.")]
		[ObsoletedOSPlatform ("maccatalyst17.0", "Replaced by 'GetPrimaryAction' and 'GetMenuConfiguration'.")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool ShouldInteractWithTextAttachment (this IUITextViewDelegate This, UITextView textView, NSTextAttachment textAttachment, NSRange characterRange, UITextItemInteraction interaction)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var textView__handle__ = textView!.GetNonNullHandle (nameof (textView));
			var textAttachment__handle__ = textAttachment!.GetNonNullHandle (nameof (textAttachment));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_NSRange_IntPtr (This.Handle, Selector.GetHandle ("textView:shouldInteractWithTextAttachment:inRange:interaction:"), textView__handle__, textAttachment__handle__, characterRange, (IntPtr) (long) interaction);
			GC.KeepAlive (This);
			GC.KeepAlive (textView);
			GC.KeepAlive (textAttachment);
			return ret != 0;
		}
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[UnsupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static UIMenu? GetEditMenuForText (this IUITextViewDelegate This, UITextView textView, NSRange range, UIMenuElement[] suggestedActions)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var textView__handle__ = textView!.GetNonNullHandle (nameof (textView));
			if (suggestedActions is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (suggestedActions));
			using var nsa_suggestedActions = NSArray.FromNSObjects (suggestedActions);
			UIMenu? ret;
			ret =  Runtime.GetNSObject<UIMenu> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NSRange_NativeHandle (This.Handle, Selector.GetHandle ("textView:editMenuForTextInRange:suggestedActions:"), textView__handle__, range, nsa_suggestedActions.Handle), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (textView);
			return ret!;
		}
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[UnsupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool ShouldChangeText (this IUITextViewDelegate This, UITextView textView, NSValue[] ranges, string replacementText)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var textView__handle__ = textView!.GetNonNullHandle (nameof (textView));
			if (ranges is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (ranges));
			if (replacementText is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (replacementText));
			using var nsa_ranges = NSArray.FromNSObjects (ranges);
			var nsreplacementText = CFString.CreateNative (replacementText);
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("textView:shouldChangeTextInRanges:replacementText:"), textView__handle__, nsa_ranges.Handle, nsreplacementText);
			GC.KeepAlive (This);
			GC.KeepAlive (textView);
			CFString.ReleaseNative (nsreplacementText);
			return ret != 0;
		}
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[UnsupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static UIMenu? GetEditMenuForText (this IUITextViewDelegate This, UITextView textView, NSValue[] ranges, UIMenuElement[] suggestedActions)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var textView__handle__ = textView!.GetNonNullHandle (nameof (textView));
			if (ranges is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (ranges));
			if (suggestedActions is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (suggestedActions));
			using var nsa_ranges = NSArray.FromNSObjects (ranges);
			using var nsa_suggestedActions = NSArray.FromNSObjects (suggestedActions);
			UIMenu? ret;
			ret =  Runtime.GetNSObject<UIMenu> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("textView:editMenuForTextInRanges:suggestedActions:"), textView__handle__, nsa_ranges.Handle, nsa_suggestedActions.Handle), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (textView);
			return ret!;
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class UITextViewDelegateWrapper : BaseWrapper, IUITextViewDelegate {
		public UITextViewDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UITextViewDelegateWrapper))]
		static UITextViewDelegateWrapper ()
		{
			GC.KeepAlive (null);
		}
	}
}
namespace UIKit {
	/// <summary>A class used to receive notifications from a UITextView control.</summary><remarks>
	/// 
	/// A strongly typed implementation of a class that can be used to respond to events raised by the <see cref="T:UIKit.UITextView" />.</remarks><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/UIKit/Reference/UITextViewDelegate_Protocol/index.html">Apple documentation for <c>UITextViewDelegate</c></related>
	[Protocol()]
	[Register("Microsoft_tvOS__UIKit_UITextViewDelegate", false)]
	[Model]
	[UnsupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("tvos")]
	public unsafe partial class UITextViewDelegate : UIScrollViewDelegate, IUITextViewDelegate {
		/// <summary>Creates a new <see cref="UITextViewDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public UITextViewDelegate () : base (NSObjectFlag.Empty)
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
		protected UITextViewDelegate (NSObjectFlag t) : base (t)
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
		protected internal UITextViewDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		/// <param name="textView">To be added.</param><summary>Indicates the text or text attributes in the specified UITextView were changed by the app user.</summary><remarks>To be added.</remarks>
		[Export ("textViewDidChange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Changed (UITextView textView)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="textView">To be added.</param><summary>Indicates that editing has ended in the specified UITextView.</summary><remarks>To be added.</remarks>
		[Export ("textViewDidEndEditing:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void EditingEnded (UITextView textView)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="textView">To be added.</param><summary>Indicates editing has begun in the specified UITextView.</summary><remarks>To be added.</remarks>
		[Export ("textViewDidBeginEditing:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void EditingStarted (UITextView textView)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("textView:editMenuForTextInRange:suggestedActions:")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[UnsupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIMenu? GetEditMenuForText (UITextView textView, NSRange range, UIMenuElement[] suggestedActions)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("textView:editMenuForTextInRanges:suggestedActions:")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[UnsupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIMenu? GetEditMenuForText (UITextView textView, NSValue[] ranges, UIMenuElement[] suggestedActions)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="textView">To be added.</param><summary>Indicates the text selection has changed in the specified UITextView.</summary><remarks>To be added.</remarks>
		[Export ("textViewDidChangeSelection:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SelectionChanged (UITextView textView)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="textView">To be added.</param><summary>Whether editing should begin in the specified UITextView.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("textViewShouldBeginEditing:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldBeginEditing (UITextView textView)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="textView">To be added.</param><param name="range">To be added.</param><param name="text">To be added.</param><summary>Whether the specified text should be replaced in the UITextView.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("textView:shouldChangeTextInRange:replacementText:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldChangeText (UITextView textView, NSRange range, string text)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("textView:shouldChangeTextInRanges:replacementText:")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[UnsupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldChangeText (UITextView textView, NSValue[] ranges, string replacementText)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="textView">To be added.</param><summary>Whether editing should end in the specified UITextView.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("textViewShouldEndEditing:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldEndEditing (UITextView textView)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="textView">To be added.</param><param name="textAttachment">To be added.</param><param name="characterRange">To be added.</param><summary>Developers should not use this deprecated method. Developers should use the 'ShouldInteractWithTextAttachment' overload that takes 'UITextItemInteraction' instead.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("textView:shouldInteractWithTextAttachment:inRange:")]
		[ObsoletedOSPlatform ("ios10.0", "Use the 'ShouldInteractWithTextAttachment' overload that takes 'UITextItemInteraction' instead.")]
		[ObsoletedOSPlatform ("tvos10.0", "Use the 'ShouldInteractWithTextAttachment' overload that takes 'UITextItemInteraction' instead.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use the 'ShouldInteractWithTextAttachment' overload that takes 'UITextItemInteraction' instead.")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldInteractWithTextAttachment (UITextView textView, NSTextAttachment textAttachment, NSRange characterRange)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="textView">The text view that has the attachment.</param><param name="textAttachment">The attachment.</param><param name="characterRange">The character range where the attachment is attached.</param><param name="interaction">The interaction type to check.</param><summary>Whether the specified UITextView should allow user interaction with the specified URL in the given range of text.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("textView:shouldInteractWithTextAttachment:inRange:interaction:")]
		[ObsoletedOSPlatform ("ios17.0", "Replaced by 'GetPrimaryAction' and 'GetMenuConfiguration'.")]
		[ObsoletedOSPlatform ("tvos17.0", "Replaced by 'GetPrimaryAction' and 'GetMenuConfiguration'.")]
		[ObsoletedOSPlatform ("maccatalyst17.0", "Replaced by 'GetPrimaryAction' and 'GetMenuConfiguration'.")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldInteractWithTextAttachment (UITextView textView, NSTextAttachment textAttachment, NSRange characterRange, UITextItemInteraction interaction)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="textView">To be added.</param><param name="URL">To be added.</param><param name="characterRange">To be added.</param><summary>Whether the specified UITextView should allow user interaction with the specified URL in the given range of text.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("textView:shouldInteractWithURL:inRange:")]
		[ObsoletedOSPlatform ("ios10.0", "Use the 'ShouldInteractWithUrl' overload that takes 'UITextItemInteraction' instead.")]
		[ObsoletedOSPlatform ("tvos10.0", "Use the 'ShouldInteractWithUrl' overload that takes 'UITextItemInteraction' instead.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use the 'ShouldInteractWithUrl' overload that takes 'UITextItemInteraction' instead.")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldInteractWithUrl (UITextView textView, NSUrl URL, NSRange characterRange)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="textView">The text view that has the attachment.</param><param name="url">To be added.</param><param name="characterRange">The character range of the URL in the text view.</param><param name="interaction">The interaction type to check.</param><summary>Whether the specified UITextView should allow user interaction with the specified URL in the given range of text.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("textView:shouldInteractWithURL:inRange:interaction:")]
		[ObsoletedOSPlatform ("ios10.0", "Use the 'ShouldInteractWithTextAttachment' overload that takes 'UITextItemInteraction' instead.")]
		[ObsoletedOSPlatform ("tvos10.0", "Use the 'ShouldInteractWithTextAttachment' overload that takes 'UITextItemInteraction' instead.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use the 'ShouldInteractWithTextAttachment' overload that takes 'UITextItemInteraction' instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldInteractWithUrl (UITextView textView, NSUrl url, NSRange characterRange, UITextItemInteraction interaction)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class UITextViewDelegate */
}
