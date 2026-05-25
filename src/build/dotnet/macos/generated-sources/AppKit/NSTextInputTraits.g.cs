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
namespace AppKit {
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>NSTextInputTraits</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[Protocol (Name = "NSTextInputTraits", WrapperType = typeof (NSTextInputTraitsWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "AutocorrectionType", Selector = "autocorrectionType", PropertyType = typeof (NSTextInputTraitType), GetterSelector = "autocorrectionType", SetterSelector = "setAutocorrectionType:", ArgumentSemantic = ArgumentSemantic.Assign)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "SpellCheckingType", Selector = "spellCheckingType", PropertyType = typeof (NSTextInputTraitType), GetterSelector = "spellCheckingType", SetterSelector = "setSpellCheckingType:", ArgumentSemantic = ArgumentSemantic.Assign)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "GrammarCheckingType", Selector = "grammarCheckingType", PropertyType = typeof (NSTextInputTraitType), GetterSelector = "grammarCheckingType", SetterSelector = "setGrammarCheckingType:", ArgumentSemantic = ArgumentSemantic.Assign)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "SmartQuotesType", Selector = "smartQuotesType", PropertyType = typeof (NSTextInputTraitType), GetterSelector = "smartQuotesType", SetterSelector = "setSmartQuotesType:", ArgumentSemantic = ArgumentSemantic.Assign)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "SmartDashesType", Selector = "smartDashesType", PropertyType = typeof (NSTextInputTraitType), GetterSelector = "smartDashesType", SetterSelector = "setSmartDashesType:", ArgumentSemantic = ArgumentSemantic.Assign)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "SmartInsertDeleteType", Selector = "smartInsertDeleteType", PropertyType = typeof (NSTextInputTraitType), GetterSelector = "smartInsertDeleteType", SetterSelector = "setSmartInsertDeleteType:", ArgumentSemantic = ArgumentSemantic.Assign)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "TextReplacementType", Selector = "textReplacementType", PropertyType = typeof (NSTextInputTraitType), GetterSelector = "textReplacementType", SetterSelector = "setTextReplacementType:", ArgumentSemantic = ArgumentSemantic.Assign)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "DataDetectionType", Selector = "dataDetectionType", PropertyType = typeof (NSTextInputTraitType), GetterSelector = "dataDetectionType", SetterSelector = "setDataDetectionType:", ArgumentSemantic = ArgumentSemantic.Assign)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "LinkDetectionType", Selector = "linkDetectionType", PropertyType = typeof (NSTextInputTraitType), GetterSelector = "linkDetectionType", SetterSelector = "setLinkDetectionType:", ArgumentSemantic = ArgumentSemantic.Assign)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "TextCompletionType", Selector = "textCompletionType", PropertyType = typeof (NSTextInputTraitType), GetterSelector = "textCompletionType", SetterSelector = "setTextCompletionType:", ArgumentSemantic = ArgumentSemantic.Assign)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "InlinePredictionType", Selector = "inlinePredictionType", PropertyType = typeof (NSTextInputTraitType), GetterSelector = "inlinePredictionType", SetterSelector = "setInlinePredictionType:", ArgumentSemantic = ArgumentSemantic.Assign)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "MathExpressionCompletionType", Selector = "mathExpressionCompletionType", PropertyType = typeof (NSTextInputTraitType), GetterSelector = "mathExpressionCompletionType", SetterSelector = "setMathExpressionCompletionType:", ArgumentSemantic = ArgumentSemantic.Assign)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "WritingToolsBehavior", Selector = "writingToolsBehavior", PropertyType = typeof (NSWritingToolsBehavior), GetterSelector = "writingToolsBehavior", SetterSelector = "setWritingToolsBehavior:", ArgumentSemantic = ArgumentSemantic.Assign)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "AllowedWritingToolsResultOptions", Selector = "allowedWritingToolsResultOptions", PropertyType = typeof (NSWritingToolsResultOptions), GetterSelector = "allowedWritingToolsResultOptions", SetterSelector = "setAllowedWritingToolsResultOptions:", ArgumentSemantic = ArgumentSemantic.None)]
	public partial interface INSTextInputTraits : INativeObject, IDisposable
	{
		[DynamicDependencyAttribute ("AllowedWritingToolsResultOptions")]
		[DynamicDependencyAttribute ("AutocorrectionType")]
		[DynamicDependencyAttribute ("DataDetectionType")]
		[DynamicDependencyAttribute ("GrammarCheckingType")]
		[DynamicDependencyAttribute ("InlinePredictionType")]
		[DynamicDependencyAttribute ("LinkDetectionType")]
		[DynamicDependencyAttribute ("MathExpressionCompletionType")]
		[DynamicDependencyAttribute ("SmartDashesType")]
		[DynamicDependencyAttribute ("SmartInsertDeleteType")]
		[DynamicDependencyAttribute ("SmartQuotesType")]
		[DynamicDependencyAttribute ("SpellCheckingType")]
		[DynamicDependencyAttribute ("TextCompletionType")]
		[DynamicDependencyAttribute ("TextReplacementType")]
		[DynamicDependencyAttribute ("WritingToolsBehavior")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSTextInputTraitsWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static INSTextInputTraits ()
		{
			GC.KeepAlive (null);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.OptionalMember]
		public virtual NSTextInputTraitType AutocorrectionType {
			[Export ("autocorrectionType", ArgumentSemantic.Assign)]
			get {
				return _GetAutocorrectionType (this);
			}
			[Export ("setAutocorrectionType:", ArgumentSemantic.Assign)]
			set {
				_SetAutocorrectionType (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSTextInputTraitType _GetAutocorrectionType (INSTextInputTraits This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSTextInputTraitType ret;
			ret = (NSTextInputTraitType) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("autocorrectionType"));
			GC.KeepAlive (This);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetAutocorrectionType (INSTextInputTraits This, NSTextInputTraitType value)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setAutocorrectionType:"), (IntPtr) (long) value);
			GC.KeepAlive (This);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.OptionalMember]
		public virtual NSTextInputTraitType SpellCheckingType {
			[Export ("spellCheckingType", ArgumentSemantic.Assign)]
			get {
				return _GetSpellCheckingType (this);
			}
			[Export ("setSpellCheckingType:", ArgumentSemantic.Assign)]
			set {
				_SetSpellCheckingType (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSTextInputTraitType _GetSpellCheckingType (INSTextInputTraits This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSTextInputTraitType ret;
			ret = (NSTextInputTraitType) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("spellCheckingType"));
			GC.KeepAlive (This);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetSpellCheckingType (INSTextInputTraits This, NSTextInputTraitType value)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setSpellCheckingType:"), (IntPtr) (long) value);
			GC.KeepAlive (This);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.OptionalMember]
		public virtual NSTextInputTraitType GrammarCheckingType {
			[Export ("grammarCheckingType", ArgumentSemantic.Assign)]
			get {
				return _GetGrammarCheckingType (this);
			}
			[Export ("setGrammarCheckingType:", ArgumentSemantic.Assign)]
			set {
				_SetGrammarCheckingType (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSTextInputTraitType _GetGrammarCheckingType (INSTextInputTraits This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSTextInputTraitType ret;
			ret = (NSTextInputTraitType) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("grammarCheckingType"));
			GC.KeepAlive (This);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetGrammarCheckingType (INSTextInputTraits This, NSTextInputTraitType value)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setGrammarCheckingType:"), (IntPtr) (long) value);
			GC.KeepAlive (This);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.OptionalMember]
		public virtual NSTextInputTraitType SmartQuotesType {
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
		internal static NSTextInputTraitType _GetSmartQuotesType (INSTextInputTraits This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSTextInputTraitType ret;
			ret = (NSTextInputTraitType) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("smartQuotesType"));
			GC.KeepAlive (This);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetSmartQuotesType (INSTextInputTraits This, NSTextInputTraitType value)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setSmartQuotesType:"), (IntPtr) (long) value);
			GC.KeepAlive (This);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.OptionalMember]
		public virtual NSTextInputTraitType SmartDashesType {
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
		internal static NSTextInputTraitType _GetSmartDashesType (INSTextInputTraits This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSTextInputTraitType ret;
			ret = (NSTextInputTraitType) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("smartDashesType"));
			GC.KeepAlive (This);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetSmartDashesType (INSTextInputTraits This, NSTextInputTraitType value)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setSmartDashesType:"), (IntPtr) (long) value);
			GC.KeepAlive (This);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.OptionalMember]
		public virtual NSTextInputTraitType SmartInsertDeleteType {
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
		internal static NSTextInputTraitType _GetSmartInsertDeleteType (INSTextInputTraits This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSTextInputTraitType ret;
			ret = (NSTextInputTraitType) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("smartInsertDeleteType"));
			GC.KeepAlive (This);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetSmartInsertDeleteType (INSTextInputTraits This, NSTextInputTraitType value)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setSmartInsertDeleteType:"), (IntPtr) (long) value);
			GC.KeepAlive (This);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.OptionalMember]
		public virtual NSTextInputTraitType TextReplacementType {
			[Export ("textReplacementType", ArgumentSemantic.Assign)]
			get {
				return _GetTextReplacementType (this);
			}
			[Export ("setTextReplacementType:", ArgumentSemantic.Assign)]
			set {
				_SetTextReplacementType (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSTextInputTraitType _GetTextReplacementType (INSTextInputTraits This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSTextInputTraitType ret;
			ret = (NSTextInputTraitType) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("textReplacementType"));
			GC.KeepAlive (This);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetTextReplacementType (INSTextInputTraits This, NSTextInputTraitType value)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setTextReplacementType:"), (IntPtr) (long) value);
			GC.KeepAlive (This);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.OptionalMember]
		public virtual NSTextInputTraitType DataDetectionType {
			[Export ("dataDetectionType", ArgumentSemantic.Assign)]
			get {
				return _GetDataDetectionType (this);
			}
			[Export ("setDataDetectionType:", ArgumentSemantic.Assign)]
			set {
				_SetDataDetectionType (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSTextInputTraitType _GetDataDetectionType (INSTextInputTraits This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSTextInputTraitType ret;
			ret = (NSTextInputTraitType) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("dataDetectionType"));
			GC.KeepAlive (This);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetDataDetectionType (INSTextInputTraits This, NSTextInputTraitType value)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setDataDetectionType:"), (IntPtr) (long) value);
			GC.KeepAlive (This);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.OptionalMember]
		public virtual NSTextInputTraitType LinkDetectionType {
			[Export ("linkDetectionType", ArgumentSemantic.Assign)]
			get {
				return _GetLinkDetectionType (this);
			}
			[Export ("setLinkDetectionType:", ArgumentSemantic.Assign)]
			set {
				_SetLinkDetectionType (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSTextInputTraitType _GetLinkDetectionType (INSTextInputTraits This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSTextInputTraitType ret;
			ret = (NSTextInputTraitType) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("linkDetectionType"));
			GC.KeepAlive (This);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetLinkDetectionType (INSTextInputTraits This, NSTextInputTraitType value)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setLinkDetectionType:"), (IntPtr) (long) value);
			GC.KeepAlive (This);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.OptionalMember]
		public virtual NSTextInputTraitType TextCompletionType {
			[Export ("textCompletionType", ArgumentSemantic.Assign)]
			get {
				return _GetTextCompletionType (this);
			}
			[Export ("setTextCompletionType:", ArgumentSemantic.Assign)]
			set {
				_SetTextCompletionType (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSTextInputTraitType _GetTextCompletionType (INSTextInputTraits This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSTextInputTraitType ret;
			ret = (NSTextInputTraitType) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("textCompletionType"));
			GC.KeepAlive (This);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetTextCompletionType (INSTextInputTraits This, NSTextInputTraitType value)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setTextCompletionType:"), (IntPtr) (long) value);
			GC.KeepAlive (This);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("macos14.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[global::Foundation.OptionalMember]
		public virtual NSTextInputTraitType InlinePredictionType {
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
		internal static NSTextInputTraitType _GetInlinePredictionType (INSTextInputTraits This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSTextInputTraitType ret;
			ret = (NSTextInputTraitType) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("inlinePredictionType"));
			GC.KeepAlive (This);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetInlinePredictionType (INSTextInputTraits This, NSTextInputTraitType value)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setInlinePredictionType:"), (IntPtr) (long) value);
			GC.KeepAlive (This);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("macos15.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[global::Foundation.OptionalMember]
		public virtual NSTextInputTraitType MathExpressionCompletionType {
			[Export ("mathExpressionCompletionType", ArgumentSemantic.Assign)]
			get {
				return _GetMathExpressionCompletionType (this);
			}
			[Export ("setMathExpressionCompletionType:", ArgumentSemantic.Assign)]
			set {
				_SetMathExpressionCompletionType (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSTextInputTraitType _GetMathExpressionCompletionType (INSTextInputTraits This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSTextInputTraitType ret;
			ret = (NSTextInputTraitType) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("mathExpressionCompletionType"));
			GC.KeepAlive (This);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetMathExpressionCompletionType (INSTextInputTraits This, NSTextInputTraitType value)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setMathExpressionCompletionType:"), (IntPtr) (long) value);
			GC.KeepAlive (This);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("macos15.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[global::Foundation.OptionalMember]
		public virtual NSWritingToolsBehavior WritingToolsBehavior {
			[Export ("writingToolsBehavior", ArgumentSemantic.Assign)]
			get {
				return _GetWritingToolsBehavior (this);
			}
			[Export ("setWritingToolsBehavior:", ArgumentSemantic.Assign)]
			set {
				_SetWritingToolsBehavior (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSWritingToolsBehavior _GetWritingToolsBehavior (INSTextInputTraits This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSWritingToolsBehavior ret;
			ret = (NSWritingToolsBehavior) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("writingToolsBehavior"));
			GC.KeepAlive (This);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetWritingToolsBehavior (INSTextInputTraits This, NSWritingToolsBehavior value)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setWritingToolsBehavior:"), (IntPtr) (long) value);
			GC.KeepAlive (This);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("macos15.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[global::Foundation.OptionalMember]
		public virtual NSWritingToolsResultOptions AllowedWritingToolsResultOptions {
			[Export ("allowedWritingToolsResultOptions")]
			get {
				return _GetAllowedWritingToolsResultOptions (this);
			}
			[Export ("setAllowedWritingToolsResultOptions:")]
			set {
				_SetAllowedWritingToolsResultOptions (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSWritingToolsResultOptions _GetAllowedWritingToolsResultOptions (INSTextInputTraits This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSWritingToolsResultOptions ret;
			ret = (NSWritingToolsResultOptions) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("allowedWritingToolsResultOptions"));
			GC.KeepAlive (This);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetAllowedWritingToolsResultOptions (INSTextInputTraits This, NSWritingToolsResultOptions value)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (This.Handle, Selector.GetHandle ("setAllowedWritingToolsResultOptions:"), (UIntPtr) (ulong) value);
			GC.KeepAlive (This);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="INSTextInputTraits" /> interface to support all the methods from the NSTextInputTraits protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="INSTextInputTraits" /> interface allow developers to treat instances of the interface as having all the optional methods of the original NSTextInputTraits protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class NSTextInputTraits_Extensions {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSTextInputTraitType GetAutocorrectionType (this INSTextInputTraits This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSTextInputTraitType ret;
			ret = (NSTextInputTraitType) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("autocorrectionType"));
			GC.KeepAlive (This);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetAutocorrectionType (this INSTextInputTraits This, NSTextInputTraitType value)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setAutocorrectionType:"), (IntPtr) (long) value);
			GC.KeepAlive (This);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSTextInputTraitType GetSpellCheckingType (this INSTextInputTraits This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSTextInputTraitType ret;
			ret = (NSTextInputTraitType) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("spellCheckingType"));
			GC.KeepAlive (This);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetSpellCheckingType (this INSTextInputTraits This, NSTextInputTraitType value)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setSpellCheckingType:"), (IntPtr) (long) value);
			GC.KeepAlive (This);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSTextInputTraitType GetGrammarCheckingType (this INSTextInputTraits This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSTextInputTraitType ret;
			ret = (NSTextInputTraitType) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("grammarCheckingType"));
			GC.KeepAlive (This);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetGrammarCheckingType (this INSTextInputTraits This, NSTextInputTraitType value)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setGrammarCheckingType:"), (IntPtr) (long) value);
			GC.KeepAlive (This);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSTextInputTraitType GetSmartQuotesType (this INSTextInputTraits This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSTextInputTraitType ret;
			ret = (NSTextInputTraitType) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("smartQuotesType"));
			GC.KeepAlive (This);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetSmartQuotesType (this INSTextInputTraits This, NSTextInputTraitType value)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setSmartQuotesType:"), (IntPtr) (long) value);
			GC.KeepAlive (This);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSTextInputTraitType GetSmartDashesType (this INSTextInputTraits This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSTextInputTraitType ret;
			ret = (NSTextInputTraitType) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("smartDashesType"));
			GC.KeepAlive (This);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetSmartDashesType (this INSTextInputTraits This, NSTextInputTraitType value)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setSmartDashesType:"), (IntPtr) (long) value);
			GC.KeepAlive (This);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSTextInputTraitType GetSmartInsertDeleteType (this INSTextInputTraits This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSTextInputTraitType ret;
			ret = (NSTextInputTraitType) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("smartInsertDeleteType"));
			GC.KeepAlive (This);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetSmartInsertDeleteType (this INSTextInputTraits This, NSTextInputTraitType value)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setSmartInsertDeleteType:"), (IntPtr) (long) value);
			GC.KeepAlive (This);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSTextInputTraitType GetTextReplacementType (this INSTextInputTraits This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSTextInputTraitType ret;
			ret = (NSTextInputTraitType) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("textReplacementType"));
			GC.KeepAlive (This);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetTextReplacementType (this INSTextInputTraits This, NSTextInputTraitType value)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setTextReplacementType:"), (IntPtr) (long) value);
			GC.KeepAlive (This);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSTextInputTraitType GetDataDetectionType (this INSTextInputTraits This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSTextInputTraitType ret;
			ret = (NSTextInputTraitType) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("dataDetectionType"));
			GC.KeepAlive (This);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetDataDetectionType (this INSTextInputTraits This, NSTextInputTraitType value)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setDataDetectionType:"), (IntPtr) (long) value);
			GC.KeepAlive (This);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSTextInputTraitType GetLinkDetectionType (this INSTextInputTraits This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSTextInputTraitType ret;
			ret = (NSTextInputTraitType) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("linkDetectionType"));
			GC.KeepAlive (This);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetLinkDetectionType (this INSTextInputTraits This, NSTextInputTraitType value)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setLinkDetectionType:"), (IntPtr) (long) value);
			GC.KeepAlive (This);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSTextInputTraitType GetTextCompletionType (this INSTextInputTraits This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSTextInputTraitType ret;
			ret = (NSTextInputTraitType) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("textCompletionType"));
			GC.KeepAlive (This);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetTextCompletionType (this INSTextInputTraits This, NSTextInputTraitType value)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setTextCompletionType:"), (IntPtr) (long) value);
			GC.KeepAlive (This);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSTextInputTraitType GetInlinePredictionType (this INSTextInputTraits This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSTextInputTraitType ret;
			ret = (NSTextInputTraitType) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("inlinePredictionType"));
			GC.KeepAlive (This);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetInlinePredictionType (this INSTextInputTraits This, NSTextInputTraitType value)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setInlinePredictionType:"), (IntPtr) (long) value);
			GC.KeepAlive (This);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSTextInputTraitType GetMathExpressionCompletionType (this INSTextInputTraits This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSTextInputTraitType ret;
			ret = (NSTextInputTraitType) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("mathExpressionCompletionType"));
			GC.KeepAlive (This);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetMathExpressionCompletionType (this INSTextInputTraits This, NSTextInputTraitType value)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setMathExpressionCompletionType:"), (IntPtr) (long) value);
			GC.KeepAlive (This);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSWritingToolsBehavior GetWritingToolsBehavior (this INSTextInputTraits This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSWritingToolsBehavior ret;
			ret = (NSWritingToolsBehavior) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("writingToolsBehavior"));
			GC.KeepAlive (This);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetWritingToolsBehavior (this INSTextInputTraits This, NSWritingToolsBehavior value)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setWritingToolsBehavior:"), (IntPtr) (long) value);
			GC.KeepAlive (This);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSWritingToolsResultOptions GetAllowedWritingToolsResultOptions (this INSTextInputTraits This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSWritingToolsResultOptions ret;
			ret = (NSWritingToolsResultOptions) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("allowedWritingToolsResultOptions"));
			GC.KeepAlive (This);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetAllowedWritingToolsResultOptions (this INSTextInputTraits This, NSWritingToolsResultOptions value)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (This.Handle, Selector.GetHandle ("setAllowedWritingToolsResultOptions:"), (UIntPtr) (ulong) value);
			GC.KeepAlive (This);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class NSTextInputTraitsWrapper : BaseWrapper, INSTextInputTraits {
		public NSTextInputTraitsWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSTextInputTraitsWrapper))]
		static NSTextInputTraitsWrapper ()
		{
			GC.KeepAlive (null);
		}
	}
}
