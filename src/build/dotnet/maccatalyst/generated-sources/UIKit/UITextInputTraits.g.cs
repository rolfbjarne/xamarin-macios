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
	/// <summary>An interface implemented by <see cref="T:UIKit.UITextField" /> and <see cref="T:UIKit.UITextView" /> with common input traits.</summary><remarks>To be added.</remarks>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("tvos")]
	[Protocol (Name = "UITextInputTraits", WrapperType = typeof (UITextInputTraitsWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "AutocapitalizationType", Selector = "autocapitalizationType", PropertyType = typeof (UITextAutocapitalizationType), GetterSelector = "autocapitalizationType", SetterSelector = "setAutocapitalizationType:", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "AutocorrectionType", Selector = "autocorrectionType", PropertyType = typeof (UITextAutocorrectionType), GetterSelector = "autocorrectionType", SetterSelector = "setAutocorrectionType:", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "KeyboardType", Selector = "keyboardType", PropertyType = typeof (UIKeyboardType), GetterSelector = "keyboardType", SetterSelector = "setKeyboardType:", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "KeyboardAppearance", Selector = "keyboardAppearance", PropertyType = typeof (UIKeyboardAppearance), GetterSelector = "keyboardAppearance", SetterSelector = "setKeyboardAppearance:", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "ReturnKeyType", Selector = "returnKeyType", PropertyType = typeof (UIReturnKeyType), GetterSelector = "returnKeyType", SetterSelector = "setReturnKeyType:", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "EnablesReturnKeyAutomatically", Selector = "enablesReturnKeyAutomatically", PropertyType = typeof (bool), GetterSelector = "enablesReturnKeyAutomatically", SetterSelector = "setEnablesReturnKeyAutomatically:", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "SecureTextEntry", Selector = "secureTextEntry", PropertyType = typeof (bool), GetterSelector = "isSecureTextEntry", SetterSelector = "setSecureTextEntry:", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "SpellCheckingType", Selector = "spellCheckingType", PropertyType = typeof (UITextSpellCheckingType), GetterSelector = "spellCheckingType", SetterSelector = "setSpellCheckingType:", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "TextContentType", Selector = "textContentType", PropertyType = typeof (NSString), GetterSelector = "textContentType", SetterSelector = "setTextContentType:", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "SmartQuotesType", Selector = "smartQuotesType", PropertyType = typeof (UITextSmartQuotesType), GetterSelector = "smartQuotesType", SetterSelector = "setSmartQuotesType:", ArgumentSemantic = ArgumentSemantic.Assign)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "SmartDashesType", Selector = "smartDashesType", PropertyType = typeof (UITextSmartDashesType), GetterSelector = "smartDashesType", SetterSelector = "setSmartDashesType:", ArgumentSemantic = ArgumentSemantic.Assign)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "SmartInsertDeleteType", Selector = "smartInsertDeleteType", PropertyType = typeof (UITextSmartInsertDeleteType), GetterSelector = "smartInsertDeleteType", SetterSelector = "setSmartInsertDeleteType:", ArgumentSemantic = ArgumentSemantic.Assign)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "PasswordRules", Selector = "passwordRules", PropertyType = typeof (UITextInputPasswordRules), GetterSelector = "passwordRules", SetterSelector = "setPasswordRules:", ArgumentSemantic = ArgumentSemantic.Copy)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "InlinePredictionType", Selector = "inlinePredictionType", PropertyType = typeof (UITextInlinePredictionType), GetterSelector = "inlinePredictionType", SetterSelector = "setInlinePredictionType:", ArgumentSemantic = ArgumentSemantic.Assign)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "WritingToolsBehavior", Selector = "writingToolsBehavior", PropertyType = typeof (UIWritingToolsBehavior), GetterSelector = "writingToolsBehavior", SetterSelector = "setWritingToolsBehavior:", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "AllowedWritingToolsResultOptions", Selector = "allowedWritingToolsResultOptions", PropertyType = typeof (UIWritingToolsResultOptions), GetterSelector = "allowedWritingToolsResultOptions", SetterSelector = "setAllowedWritingToolsResultOptions:", ArgumentSemantic = ArgumentSemantic.Assign)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "MathExpressionCompletionType", Selector = "mathExpressionCompletionType", PropertyType = typeof (UITextMathExpressionCompletionType), GetterSelector = "mathExpressionCompletionType", SetterSelector = "setMathExpressionCompletionType:", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "AllowsNumberPadPopover", Selector = "allowsNumberPadPopover", PropertyType = typeof (bool), GetterSelector = "allowsNumberPadPopover", SetterSelector = "setAllowsNumberPadPopover:", ArgumentSemantic = ArgumentSemantic.None)]
	public partial interface IUITextInputTraits : INativeObject, IDisposable
	{
		[DynamicDependencyAttribute ("AllowedWritingToolsResultOptions")]
		[DynamicDependencyAttribute ("AllowsNumberPadPopover")]
		[DynamicDependencyAttribute ("AutocapitalizationType")]
		[DynamicDependencyAttribute ("AutocorrectionType")]
		[DynamicDependencyAttribute ("EnablesReturnKeyAutomatically")]
		[DynamicDependencyAttribute ("InlinePredictionType")]
		[DynamicDependencyAttribute ("KeyboardAppearance")]
		[DynamicDependencyAttribute ("KeyboardType")]
		[DynamicDependencyAttribute ("MathExpressionCompletionType")]
		[DynamicDependencyAttribute ("PasswordRules")]
		[DynamicDependencyAttribute ("ReturnKeyType")]
		[DynamicDependencyAttribute ("SecureTextEntry")]
		[DynamicDependencyAttribute ("SmartDashesType")]
		[DynamicDependencyAttribute ("SmartInsertDeleteType")]
		[DynamicDependencyAttribute ("SmartQuotesType")]
		[DynamicDependencyAttribute ("SpellCheckingType")]
		[DynamicDependencyAttribute ("TextContentType")]
		[DynamicDependencyAttribute ("WritingToolsBehavior")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UITextInputTraitsWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IUITextInputTraits ()
		{
			GC.KeepAlive (null);
		}
		/// <summary>The <see cref="T:UIKit.UITextAutocapitalizationType" /> used by the <see cref="T:UIKit.IUITextInput" />.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.OptionalMember]
		public virtual UITextAutocapitalizationType AutocapitalizationType {
			[Export ("autocapitalizationType")]
			get {
				return _GetAutocapitalizationType (this);
			}
			[Export ("setAutocapitalizationType:")]
			set {
				_SetAutocapitalizationType (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static UITextAutocapitalizationType _GetAutocapitalizationType (IUITextInputTraits This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			UITextAutocapitalizationType ret;
			ret = (UITextAutocapitalizationType) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("autocapitalizationType"));
			GC.KeepAlive (This);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetAutocapitalizationType (IUITextInputTraits This, UITextAutocapitalizationType value)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setAutocapitalizationType:"), (IntPtr) (long) value);
			GC.KeepAlive (This);
		}
		/// <summary>The <see cref="T:UIKit.UITextAutocorrectionType" /> used by the <see cref="T:UIKit.IUITextInput" />.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.OptionalMember]
		public virtual UITextAutocorrectionType AutocorrectionType {
			[Export ("autocorrectionType")]
			get {
				return _GetAutocorrectionType (this);
			}
			[Export ("setAutocorrectionType:")]
			set {
				_SetAutocorrectionType (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static UITextAutocorrectionType _GetAutocorrectionType (IUITextInputTraits This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			UITextAutocorrectionType ret;
			ret = (UITextAutocorrectionType) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("autocorrectionType"));
			GC.KeepAlive (This);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetAutocorrectionType (IUITextInputTraits This, UITextAutocorrectionType value)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setAutocorrectionType:"), (IntPtr) (long) value);
			GC.KeepAlive (This);
		}
		/// <summary>The <see cref="T:UIKit.UIKeyboardType" /> used by the <see cref="T:UIKit.IUITextInput" />.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.OptionalMember]
		public virtual UIKeyboardType KeyboardType {
			[Export ("keyboardType")]
			get {
				return _GetKeyboardType (this);
			}
			[Export ("setKeyboardType:")]
			set {
				_SetKeyboardType (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static UIKeyboardType _GetKeyboardType (IUITextInputTraits This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			UIKeyboardType ret;
			ret = (UIKeyboardType) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("keyboardType"));
			GC.KeepAlive (This);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetKeyboardType (IUITextInputTraits This, UIKeyboardType value)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setKeyboardType:"), (IntPtr) (long) value);
			GC.KeepAlive (This);
		}
		/// <summary>The <see cref="T:UIKit.UIKeyboardAppearance" /> used by the <see cref="T:UIKit.IUITextInput" /></summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.OptionalMember]
		public virtual global::UIKit.UIKeyboardAppearance KeyboardAppearance {
			[Export ("keyboardAppearance")]
			get {
				return _GetKeyboardAppearance (this);
			}
			[Export ("setKeyboardAppearance:")]
			set {
				_SetKeyboardAppearance (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static global::UIKit.UIKeyboardAppearance _GetKeyboardAppearance (IUITextInputTraits This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			global::UIKit.UIKeyboardAppearance ret;
			ret = (UIKeyboardAppearance) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("keyboardAppearance"));
			GC.KeepAlive (This);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetKeyboardAppearance (IUITextInputTraits This, global::UIKit.UIKeyboardAppearance value)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setKeyboardAppearance:"), (IntPtr) (long) value);
			GC.KeepAlive (This);
		}
		/// <summary>The form of the return key for the <see cref="T:UIKit.IUITextInput" />.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.OptionalMember]
		public virtual UIReturnKeyType ReturnKeyType {
			[Export ("returnKeyType")]
			get {
				return _GetReturnKeyType (this);
			}
			[Export ("setReturnKeyType:")]
			set {
				_SetReturnKeyType (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static UIReturnKeyType _GetReturnKeyType (IUITextInputTraits This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			UIReturnKeyType ret;
			ret = (UIReturnKeyType) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("returnKeyType"));
			GC.KeepAlive (This);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetReturnKeyType (IUITextInputTraits This, UIReturnKeyType value)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setReturnKeyType:"), (IntPtr) (long) value);
			GC.KeepAlive (This);
		}
		/// <summary>Whether the return key is automatically enabled.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.OptionalMember]
		public virtual bool EnablesReturnKeyAutomatically {
			[Export ("enablesReturnKeyAutomatically")]
			get {
				return _GetEnablesReturnKeyAutomatically (this);
			}
			[Export ("setEnablesReturnKeyAutomatically:")]
			set {
				_SetEnablesReturnKeyAutomatically (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _GetEnablesReturnKeyAutomatically (IUITextInputTraits This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("enablesReturnKeyAutomatically"));
			GC.KeepAlive (This);
			return ret != 0;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetEnablesReturnKeyAutomatically (IUITextInputTraits This, bool value)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_bool (This.Handle, Selector.GetHandle ("setEnablesReturnKeyAutomatically:"), value ? (byte) 1 : (byte) 0);
			GC.KeepAlive (This);
		}
		/// <summary>Whether the entered text should be hidden.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.OptionalMember]
		public virtual bool SecureTextEntry {
			[Export ("isSecureTextEntry")]
			get {
				return _GetSecureTextEntry (this);
			}
			[Export ("setSecureTextEntry:")]
			set {
				_SetSecureTextEntry (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _GetSecureTextEntry (IUITextInputTraits This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("isSecureTextEntry"));
			GC.KeepAlive (This);
			return ret != 0;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetSecureTextEntry (IUITextInputTraits This, bool value)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_bool (This.Handle, Selector.GetHandle ("setSecureTextEntry:"), value ? (byte) 1 : (byte) 0);
			GC.KeepAlive (This);
		}
		/// <summary>Gets or sets a value that tells whether spell-checking is on, off, or if spell-checking will be enabled only when auto-complete is enabled (default).</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.OptionalMember]
		public virtual UITextSpellCheckingType SpellCheckingType {
			[Export ("spellCheckingType")]
			get {
				return _GetSpellCheckingType (this);
			}
			[Export ("setSpellCheckingType:")]
			set {
				_SetSpellCheckingType (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static UITextSpellCheckingType _GetSpellCheckingType (IUITextInputTraits This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			UITextSpellCheckingType ret;
			ret = (UITextSpellCheckingType) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("spellCheckingType"));
			GC.KeepAlive (This);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetSpellCheckingType (IUITextInputTraits This, UITextSpellCheckingType value)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setSpellCheckingType:"), (IntPtr) (long) value);
			GC.KeepAlive (This);
		}
		/// <summary>The semantic of the expected input, which allows the system to, for example, provide custom keyboards.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[global::Foundation.OptionalMember]
		public virtual NSString TextContentType {
			[Export ("textContentType")]
			get {
				return _GetTextContentType (this);
			}
			[Export ("setTextContentType:")]
			set {
				_SetTextContentType (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSString _GetTextContentType (IUITextInputTraits This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			NSString ret;
			ret =  Runtime.GetNSObject<NSString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("textContentType")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetTextContentType (IUITextInputTraits This, NSString value)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var value__handle__ = value!.GetNonNullHandle (nameof (value));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setTextContentType:"), value__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (value);
		}
		/// <summary>The smart quotes style.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[global::Foundation.OptionalMember]
		public virtual UITextSmartQuotesType SmartQuotesType {
			[Export ("smartQuotesType", ArgumentSemantic.Assign)]
			get {
				return _GetSmartQuotesType (this);
			}
			[Export ("setSmartQuotesType:", ArgumentSemantic.Assign)]
			set {
				_SetSmartQuotesType (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static UITextSmartQuotesType _GetSmartQuotesType (IUITextInputTraits This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			UITextSmartQuotesType ret;
			ret = (UITextSmartQuotesType) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("smartQuotesType"));
			GC.KeepAlive (This);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetSmartQuotesType (IUITextInputTraits This, UITextSmartQuotesType value)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setSmartQuotesType:"), (IntPtr) (long) value);
			GC.KeepAlive (This);
		}
		/// <summary>The smart dashes style.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[global::Foundation.OptionalMember]
		public virtual UITextSmartDashesType SmartDashesType {
			[Export ("smartDashesType", ArgumentSemantic.Assign)]
			get {
				return _GetSmartDashesType (this);
			}
			[Export ("setSmartDashesType:", ArgumentSemantic.Assign)]
			set {
				_SetSmartDashesType (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static UITextSmartDashesType _GetSmartDashesType (IUITextInputTraits This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			UITextSmartDashesType ret;
			ret = (UITextSmartDashesType) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("smartDashesType"));
			GC.KeepAlive (This);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetSmartDashesType (IUITextInputTraits This, UITextSmartDashesType value)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setSmartDashesType:"), (IntPtr) (long) value);
			GC.KeepAlive (This);
		}
		/// <summary>The smart insert style.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[global::Foundation.OptionalMember]
		public virtual UITextSmartInsertDeleteType SmartInsertDeleteType {
			[Export ("smartInsertDeleteType", ArgumentSemantic.Assign)]
			get {
				return _GetSmartInsertDeleteType (this);
			}
			[Export ("setSmartInsertDeleteType:", ArgumentSemantic.Assign)]
			set {
				_SetSmartInsertDeleteType (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static UITextSmartInsertDeleteType _GetSmartInsertDeleteType (IUITextInputTraits This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			UITextSmartInsertDeleteType ret;
			ret = (UITextSmartInsertDeleteType) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("smartInsertDeleteType"));
			GC.KeepAlive (This);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetSmartInsertDeleteType (IUITextInputTraits This, UITextSmartInsertDeleteType value)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setSmartInsertDeleteType:"), (IntPtr) (long) value);
			GC.KeepAlive (This);
		}
		/// <summary>The password entry rules.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[global::Foundation.OptionalMember]
		public virtual UITextInputPasswordRules? PasswordRules {
			[Export ("passwordRules", ArgumentSemantic.Copy)]
			get {
				return _GetPasswordRules (this);
			}
			[Export ("setPasswordRules:", ArgumentSemantic.Copy)]
			set {
				_SetPasswordRules (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static UITextInputPasswordRules _GetPasswordRules (IUITextInputTraits This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			UITextInputPasswordRules ret;
			ret =  Runtime.GetNSObject<UITextInputPasswordRules> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("passwordRules")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetPasswordRules (IUITextInputTraits This, UITextInputPasswordRules? value)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var value__handle__ = value.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setPasswordRules:"), value__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (value);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[SupportedOSPlatform ("tvos")]
		[global::Foundation.OptionalMember]
		public virtual UITextInlinePredictionType InlinePredictionType {
			[Export ("inlinePredictionType", ArgumentSemantic.Assign)]
			get {
				return _GetInlinePredictionType (this);
			}
			[Export ("setInlinePredictionType:", ArgumentSemantic.Assign)]
			set {
				_SetInlinePredictionType (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static UITextInlinePredictionType _GetInlinePredictionType (IUITextInputTraits This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			UITextInlinePredictionType ret;
			ret = (UITextInlinePredictionType) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("inlinePredictionType"));
			GC.KeepAlive (This);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetInlinePredictionType (IUITextInputTraits This, UITextInlinePredictionType value)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setInlinePredictionType:"), (IntPtr) (long) value);
			GC.KeepAlive (This);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[UnsupportedOSPlatform ("tvos")]
		[global::Foundation.OptionalMember]
		public virtual UIWritingToolsBehavior WritingToolsBehavior {
			[Export ("writingToolsBehavior")]
			get {
				return _GetWritingToolsBehavior (this);
			}
			[Export ("setWritingToolsBehavior:")]
			set {
				_SetWritingToolsBehavior (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static UIWritingToolsBehavior _GetWritingToolsBehavior (IUITextInputTraits This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			UIWritingToolsBehavior ret;
			ret = (UIWritingToolsBehavior) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("writingToolsBehavior"));
			GC.KeepAlive (This);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetWritingToolsBehavior (IUITextInputTraits This, UIWritingToolsBehavior value)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setWritingToolsBehavior:"), (IntPtr) (long) value);
			GC.KeepAlive (This);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[UnsupportedOSPlatform ("tvos")]
		[global::Foundation.OptionalMember]
		public virtual UIWritingToolsResultOptions AllowedWritingToolsResultOptions {
			[Export ("allowedWritingToolsResultOptions", ArgumentSemantic.Assign)]
			get {
				return _GetAllowedWritingToolsResultOptions (this);
			}
			[Export ("setAllowedWritingToolsResultOptions:", ArgumentSemantic.Assign)]
			set {
				_SetAllowedWritingToolsResultOptions (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static UIWritingToolsResultOptions _GetAllowedWritingToolsResultOptions (IUITextInputTraits This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			UIWritingToolsResultOptions ret;
			ret = (UIWritingToolsResultOptions) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("allowedWritingToolsResultOptions"));
			GC.KeepAlive (This);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetAllowedWritingToolsResultOptions (IUITextInputTraits This, UIWritingToolsResultOptions value)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (This.Handle, Selector.GetHandle ("setAllowedWritingToolsResultOptions:"), (UIntPtr) (ulong) value);
			GC.KeepAlive (This);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[SupportedOSPlatform ("tvos18.0")]
		[global::Foundation.OptionalMember]
		public virtual UITextMathExpressionCompletionType MathExpressionCompletionType {
			[Export ("mathExpressionCompletionType")]
			get {
				return _GetMathExpressionCompletionType (this);
			}
			[Export ("setMathExpressionCompletionType:")]
			set {
				_SetMathExpressionCompletionType (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static UITextMathExpressionCompletionType _GetMathExpressionCompletionType (IUITextInputTraits This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			UITextMathExpressionCompletionType ret;
			ret = (UITextMathExpressionCompletionType) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("mathExpressionCompletionType"));
			GC.KeepAlive (This);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetMathExpressionCompletionType (IUITextInputTraits This, UITextMathExpressionCompletionType value)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setMathExpressionCompletionType:"), (IntPtr) (long) value);
			GC.KeepAlive (This);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[global::Foundation.OptionalMember]
		public virtual bool AllowsNumberPadPopover {
			[Export ("allowsNumberPadPopover")]
			get {
				return _GetAllowsNumberPadPopover (this);
			}
			[Export ("setAllowsNumberPadPopover:")]
			set {
				_SetAllowsNumberPadPopover (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _GetAllowsNumberPadPopover (IUITextInputTraits This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("allowsNumberPadPopover"));
			GC.KeepAlive (This);
			return ret != 0;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetAllowsNumberPadPopover (IUITextInputTraits This, bool value)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_bool (This.Handle, Selector.GetHandle ("setAllowsNumberPadPopover:"), value ? (byte) 1 : (byte) 0);
			GC.KeepAlive (This);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="IUITextInputTraits" /> interface to support all the methods from the UITextInputTraits protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IUITextInputTraits" /> interface allow developers to treat instances of the interface as having all the optional methods of the original UITextInputTraits protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class UITextInputTraits_Extensions {
		/// <summary>The <see cref="T:UIKit.UITextAutocapitalizationType" /> used by the <see cref="T:UIKit.IUITextInput" />.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static UITextAutocapitalizationType GetAutocapitalizationType (this IUITextInputTraits This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			UITextAutocapitalizationType ret;
			ret = (UITextAutocapitalizationType) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("autocapitalizationType"));
			GC.KeepAlive (This);
			return ret!;
		}
		/// <summary>The <see cref="T:UIKit.UITextAutocapitalizationType" /> used by the <see cref="T:UIKit.IUITextInput" />.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetAutocapitalizationType (this IUITextInputTraits This, UITextAutocapitalizationType value)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setAutocapitalizationType:"), (IntPtr) (long) value);
			GC.KeepAlive (This);
		}
		/// <summary>The <see cref="T:UIKit.UITextAutocorrectionType" /> used by the <see cref="T:UIKit.IUITextInput" />.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static UITextAutocorrectionType GetAutocorrectionType (this IUITextInputTraits This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			UITextAutocorrectionType ret;
			ret = (UITextAutocorrectionType) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("autocorrectionType"));
			GC.KeepAlive (This);
			return ret!;
		}
		/// <summary>The <see cref="T:UIKit.UITextAutocorrectionType" /> used by the <see cref="T:UIKit.IUITextInput" />.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetAutocorrectionType (this IUITextInputTraits This, UITextAutocorrectionType value)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setAutocorrectionType:"), (IntPtr) (long) value);
			GC.KeepAlive (This);
		}
		/// <summary>The <see cref="T:UIKit.UIKeyboardType" /> used by the <see cref="T:UIKit.IUITextInput" />.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static UIKeyboardType GetKeyboardType (this IUITextInputTraits This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			UIKeyboardType ret;
			ret = (UIKeyboardType) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("keyboardType"));
			GC.KeepAlive (This);
			return ret!;
		}
		/// <summary>The <see cref="T:UIKit.UIKeyboardType" /> used by the <see cref="T:UIKit.IUITextInput" />.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetKeyboardType (this IUITextInputTraits This, UIKeyboardType value)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setKeyboardType:"), (IntPtr) (long) value);
			GC.KeepAlive (This);
		}
		/// <summary>The <see cref="T:UIKit.UIKeyboardAppearance" /> used by the <see cref="T:UIKit.IUITextInput" /></summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static global::UIKit.UIKeyboardAppearance GetKeyboardAppearance (this IUITextInputTraits This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			global::UIKit.UIKeyboardAppearance ret;
			ret = (UIKeyboardAppearance) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("keyboardAppearance"));
			GC.KeepAlive (This);
			return ret!;
		}
		/// <summary>The <see cref="T:UIKit.UIKeyboardAppearance" /> used by the <see cref="T:UIKit.IUITextInput" /></summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetKeyboardAppearance (this IUITextInputTraits This, global::UIKit.UIKeyboardAppearance value)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setKeyboardAppearance:"), (IntPtr) (long) value);
			GC.KeepAlive (This);
		}
		/// <summary>The form of the return key for the <see cref="T:UIKit.IUITextInput" />.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static UIReturnKeyType GetReturnKeyType (this IUITextInputTraits This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			UIReturnKeyType ret;
			ret = (UIReturnKeyType) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("returnKeyType"));
			GC.KeepAlive (This);
			return ret!;
		}
		/// <summary>The form of the return key for the <see cref="T:UIKit.IUITextInput" />.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetReturnKeyType (this IUITextInputTraits This, UIReturnKeyType value)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setReturnKeyType:"), (IntPtr) (long) value);
			GC.KeepAlive (This);
		}
		/// <summary>Whether the return key is automatically enabled.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool GetEnablesReturnKeyAutomatically (this IUITextInputTraits This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("enablesReturnKeyAutomatically"));
			GC.KeepAlive (This);
			return ret != 0;
		}
		/// <summary>Whether the return key is automatically enabled.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetEnablesReturnKeyAutomatically (this IUITextInputTraits This, bool value)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_bool (This.Handle, Selector.GetHandle ("setEnablesReturnKeyAutomatically:"), value ? (byte) 1 : (byte) 0);
			GC.KeepAlive (This);
		}
		/// <summary>Whether the entered text should be hidden.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool GetSecureTextEntry (this IUITextInputTraits This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("isSecureTextEntry"));
			GC.KeepAlive (This);
			return ret != 0;
		}
		/// <summary>Whether the entered text should be hidden.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetSecureTextEntry (this IUITextInputTraits This, bool value)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_bool (This.Handle, Selector.GetHandle ("setSecureTextEntry:"), value ? (byte) 1 : (byte) 0);
			GC.KeepAlive (This);
		}
		/// <summary>Gets or sets a value that tells whether spell-checking is on, off, or if spell-checking will be enabled only when auto-complete is enabled (default).</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static UITextSpellCheckingType GetSpellCheckingType (this IUITextInputTraits This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			UITextSpellCheckingType ret;
			ret = (UITextSpellCheckingType) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("spellCheckingType"));
			GC.KeepAlive (This);
			return ret!;
		}
		/// <summary>Gets or sets a value that tells whether spell-checking is on, off, or if spell-checking will be enabled only when auto-complete is enabled (default).</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetSpellCheckingType (this IUITextInputTraits This, UITextSpellCheckingType value)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setSpellCheckingType:"), (IntPtr) (long) value);
			GC.KeepAlive (This);
		}
		/// <summary>The semantic of the expected input, which allows the system to, for example, provide custom keyboards.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSString GetTextContentType (this IUITextInputTraits This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			NSString ret;
			ret =  Runtime.GetNSObject<NSString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("textContentType")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		/// <summary>The semantic of the expected input, which allows the system to, for example, provide custom keyboards.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetTextContentType (this IUITextInputTraits This, NSString value)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var value__handle__ = value!.GetNonNullHandle (nameof (value));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setTextContentType:"), value__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (value);
		}
		/// <summary>The smart quotes style.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static UITextSmartQuotesType GetSmartQuotesType (this IUITextInputTraits This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			UITextSmartQuotesType ret;
			ret = (UITextSmartQuotesType) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("smartQuotesType"));
			GC.KeepAlive (This);
			return ret!;
		}
		/// <summary>The smart quotes style.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetSmartQuotesType (this IUITextInputTraits This, UITextSmartQuotesType value)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setSmartQuotesType:"), (IntPtr) (long) value);
			GC.KeepAlive (This);
		}
		/// <summary>The smart dashes style.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static UITextSmartDashesType GetSmartDashesType (this IUITextInputTraits This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			UITextSmartDashesType ret;
			ret = (UITextSmartDashesType) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("smartDashesType"));
			GC.KeepAlive (This);
			return ret!;
		}
		/// <summary>The smart dashes style.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetSmartDashesType (this IUITextInputTraits This, UITextSmartDashesType value)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setSmartDashesType:"), (IntPtr) (long) value);
			GC.KeepAlive (This);
		}
		/// <summary>The smart insert style.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static UITextSmartInsertDeleteType GetSmartInsertDeleteType (this IUITextInputTraits This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			UITextSmartInsertDeleteType ret;
			ret = (UITextSmartInsertDeleteType) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("smartInsertDeleteType"));
			GC.KeepAlive (This);
			return ret!;
		}
		/// <summary>The smart insert style.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetSmartInsertDeleteType (this IUITextInputTraits This, UITextSmartInsertDeleteType value)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setSmartInsertDeleteType:"), (IntPtr) (long) value);
			GC.KeepAlive (This);
		}
		/// <summary>The password entry rules.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static UITextInputPasswordRules GetPasswordRules (this IUITextInputTraits This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			UITextInputPasswordRules ret;
			ret =  Runtime.GetNSObject<UITextInputPasswordRules> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("passwordRules")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		/// <summary>The password entry rules.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetPasswordRules (this IUITextInputTraits This, UITextInputPasswordRules? value)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var value__handle__ = value.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setPasswordRules:"), value__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (value);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static UITextInlinePredictionType GetInlinePredictionType (this IUITextInputTraits This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			UITextInlinePredictionType ret;
			ret = (UITextInlinePredictionType) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("inlinePredictionType"));
			GC.KeepAlive (This);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetInlinePredictionType (this IUITextInputTraits This, UITextInlinePredictionType value)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setInlinePredictionType:"), (IntPtr) (long) value);
			GC.KeepAlive (This);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static UIWritingToolsBehavior GetWritingToolsBehavior (this IUITextInputTraits This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			UIWritingToolsBehavior ret;
			ret = (UIWritingToolsBehavior) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("writingToolsBehavior"));
			GC.KeepAlive (This);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetWritingToolsBehavior (this IUITextInputTraits This, UIWritingToolsBehavior value)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setWritingToolsBehavior:"), (IntPtr) (long) value);
			GC.KeepAlive (This);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static UIWritingToolsResultOptions GetAllowedWritingToolsResultOptions (this IUITextInputTraits This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			UIWritingToolsResultOptions ret;
			ret = (UIWritingToolsResultOptions) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("allowedWritingToolsResultOptions"));
			GC.KeepAlive (This);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetAllowedWritingToolsResultOptions (this IUITextInputTraits This, UIWritingToolsResultOptions value)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (This.Handle, Selector.GetHandle ("setAllowedWritingToolsResultOptions:"), (UIntPtr) (ulong) value);
			GC.KeepAlive (This);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static UITextMathExpressionCompletionType GetMathExpressionCompletionType (this IUITextInputTraits This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			UITextMathExpressionCompletionType ret;
			ret = (UITextMathExpressionCompletionType) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("mathExpressionCompletionType"));
			GC.KeepAlive (This);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetMathExpressionCompletionType (this IUITextInputTraits This, UITextMathExpressionCompletionType value)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setMathExpressionCompletionType:"), (IntPtr) (long) value);
			GC.KeepAlive (This);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool GetAllowsNumberPadPopover (this IUITextInputTraits This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("allowsNumberPadPopover"));
			GC.KeepAlive (This);
			return ret != 0;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetAllowsNumberPadPopover (this IUITextInputTraits This, bool value)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_bool (This.Handle, Selector.GetHandle ("setAllowsNumberPadPopover:"), value ? (byte) 1 : (byte) 0);
			GC.KeepAlive (This);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class UITextInputTraitsWrapper : BaseWrapper, IUITextInputTraits {
		public UITextInputTraitsWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UITextInputTraitsWrapper))]
		static UITextInputTraitsWrapper ()
		{
			GC.KeepAlive (null);
		}
	}
}
