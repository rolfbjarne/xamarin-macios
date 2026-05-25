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
	/// <summary>This interface represents the Objective-C protocol <c>UITextFieldDelegate</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("tvos")]
	[Protocol (Name = "UITextFieldDelegate", WrapperType = typeof (UITextFieldDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldBeginEditing", Selector = "textFieldShouldBeginEditing:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (UITextField) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "EditingStarted", Selector = "textFieldDidBeginEditing:", ParameterType = new Type [] { typeof (UITextField) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldEndEditing", Selector = "textFieldShouldEndEditing:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (UITextField) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "EditingEnded", Selector = "textFieldDidEndEditing:", ParameterType = new Type [] { typeof (UITextField) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "EditingEnded", Selector = "textFieldDidEndEditing:reason:", ParameterType = new Type [] { typeof (UITextField), typeof (UITextFieldDidEndEditingReason) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldClear", Selector = "textFieldShouldClear:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (UITextField) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldReturn", Selector = "textFieldShouldReturn:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (UITextField) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldChangeCharacters", Selector = "textField:shouldChangeCharactersInRange:replacementString:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (UITextField), typeof (NSRange), typeof (string) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidChangeSelection", Selector = "textFieldDidChangeSelection:", ParameterType = new Type [] { typeof (UITextField) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetEditMenu", Selector = "textField:editMenuForCharactersInRange:suggestedActions:", ReturnType = typeof (UIMenu), ParameterType = new Type [] { typeof (UITextField), typeof (NSRange), typeof (UIMenuElement[]) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldChangeCharacters", Selector = "textField:shouldChangeCharactersInRanges:replacementString:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (UITextField), typeof (NSValue[]), typeof (string) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetEditMenu", Selector = "textField:editMenuForCharactersInRanges:suggestedActions:", ReturnType = typeof (UIMenu), ParameterType = new Type [] { typeof (UITextField), typeof (NSValue[]), typeof (UIMenuElement[]) }, ParameterByRef = new bool [] { false, false, false })]
	public partial interface IUITextFieldDelegate : INativeObject, IDisposable
	{
		/// <param name="textField">To be added.</param><summary>Whether editing should begin in the specified text field.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("textFieldShouldBeginEditing:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldBeginEditing (UITextField textField)
		{
			return _ShouldBeginEditing (this, textField);
		}
		/// <param name="textField">To be added.</param><summary>Whether editing should begin in the specified text field.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _ShouldBeginEditing (IUITextFieldDelegate This, UITextField textField)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var textField__handle__ = textField!.GetNonNullHandle (nameof (textField));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("textFieldShouldBeginEditing:"), textField__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (textField);
			return ret != 0;
		}
		/// <param name="textField">To be added.</param><summary>Indicates that editing has begun on the specified text field.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("textFieldDidBeginEditing:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void EditingStarted (UITextField textField)
		{
			_EditingStarted (this, textField);
		}
		/// <param name="textField">To be added.</param><summary>Indicates that editing has begun on the specified text field.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _EditingStarted (IUITextFieldDelegate This, UITextField textField)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var textField__handle__ = textField!.GetNonNullHandle (nameof (textField));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("textFieldDidBeginEditing:"), textField__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (textField);
		}
		/// <param name="textField">To be added.</param><summary>Whether editing should stop in the specified text field.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("textFieldShouldEndEditing:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldEndEditing (UITextField textField)
		{
			return _ShouldEndEditing (this, textField);
		}
		/// <param name="textField">To be added.</param><summary>Whether editing should stop in the specified text field.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _ShouldEndEditing (IUITextFieldDelegate This, UITextField textField)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var textField__handle__ = textField!.GetNonNullHandle (nameof (textField));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("textFieldShouldEndEditing:"), textField__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (textField);
			return ret != 0;
		}
		/// <param name="textField">The text field for which editing ended.</param><summary>Indicates that editing has ended in the specified text field.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("textFieldDidEndEditing:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void EditingEnded (UITextField textField)
		{
			_EditingEnded (this, textField);
		}
		/// <param name="textField">The text field for which editing ended.</param><summary>Indicates that editing has ended in the specified text field.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _EditingEnded (IUITextFieldDelegate This, UITextField textField)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var textField__handle__ = textField!.GetNonNullHandle (nameof (textField));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("textFieldDidEndEditing:"), textField__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (textField);
		}
		/// <param name="textField">The text field for which editing ended.</param><param name="reason">The reason that editing ended.</param><summary>Indicates that editing has ended in the specified text field for the specified reason.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("textFieldDidEndEditing:reason:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void EditingEnded (UITextField textField, UITextFieldDidEndEditingReason reason)
		{
			_EditingEnded (this, textField, reason);
		}
		/// <param name="textField">The text field for which editing ended.</param><param name="reason">The reason that editing ended.</param><summary>Indicates that editing has ended in the specified text field for the specified reason.</summary><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _EditingEnded (IUITextFieldDelegate This, UITextField textField, UITextFieldDidEndEditingReason reason)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var textField__handle__ = textField!.GetNonNullHandle (nameof (textField));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("textFieldDidEndEditing:reason:"), textField__handle__, (IntPtr) (long) reason);
			GC.KeepAlive (This);
			GC.KeepAlive (textField);
		}
		/// <param name="textField">To be added.</param><summary>Whether the specified text field's current contents should be removed.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("textFieldShouldClear:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldClear (UITextField textField)
		{
			return _ShouldClear (this, textField);
		}
		/// <param name="textField">To be added.</param><summary>Whether the specified text field's current contents should be removed.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _ShouldClear (IUITextFieldDelegate This, UITextField textField)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var textField__handle__ = textField!.GetNonNullHandle (nameof (textField));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("textFieldShouldClear:"), textField__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (textField);
			return ret != 0;
		}
		/// <param name="textField">To be added.</param><summary>Whether the text field should process the pressing of the return button.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("textFieldShouldReturn:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldReturn (UITextField textField)
		{
			return _ShouldReturn (this, textField);
		}
		/// <param name="textField">To be added.</param><summary>Whether the text field should process the pressing of the return button.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _ShouldReturn (IUITextFieldDelegate This, UITextField textField)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var textField__handle__ = textField!.GetNonNullHandle (nameof (textField));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("textFieldShouldReturn:"), textField__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (textField);
			return ret != 0;
		}
		/// <param name="textField">To be added.</param><param name="range">To be added.</param><param name="replacementString">To be added.</param><summary>Whether the specified text should be changed.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("textField:shouldChangeCharactersInRange:replacementString:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldChangeCharacters (UITextField textField, NSRange range, string replacementString)
		{
			return _ShouldChangeCharacters (this, textField, range, replacementString);
		}
		/// <param name="textField">To be added.</param><param name="range">To be added.</param><param name="replacementString">To be added.</param><summary>Whether the specified text should be changed.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _ShouldChangeCharacters (IUITextFieldDelegate This, UITextField textField, NSRange range, string replacementString)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var textField__handle__ = textField!.GetNonNullHandle (nameof (textField));
			if (replacementString is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (replacementString));
			var nsreplacementString = CFString.CreateNative (replacementString);
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NSRange_NativeHandle (This.Handle, Selector.GetHandle ("textField:shouldChangeCharactersInRange:replacementString:"), textField__handle__, range, nsreplacementString);
			GC.KeepAlive (This);
			GC.KeepAlive (textField);
			CFString.ReleaseNative (nsreplacementString);
			return ret != 0;
		}
		[global::Foundation.OptionalMember]
		[Export ("textFieldDidChangeSelection:")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidChangeSelection (UITextField textField)
		{
			_DidChangeSelection (this, textField);
		}
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidChangeSelection (IUITextFieldDelegate This, UITextField textField)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var textField__handle__ = textField!.GetNonNullHandle (nameof (textField));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("textFieldDidChangeSelection:"), textField__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (textField);
		}
		[global::Foundation.OptionalMember]
		[Export ("textField:editMenuForCharactersInRange:suggestedActions:")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIMenu? GetEditMenu (UITextField textField, NSRange range, UIMenuElement[] suggestedActions)
		{
			return _GetEditMenu (this, textField, range, suggestedActions);
		}
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static UIMenu? _GetEditMenu (IUITextFieldDelegate This, UITextField textField, NSRange range, UIMenuElement[] suggestedActions)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var textField__handle__ = textField!.GetNonNullHandle (nameof (textField));
			if (suggestedActions is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (suggestedActions));
			using var nsa_suggestedActions = NSArray.FromNSObjects (suggestedActions);
			UIMenu? ret;
			ret =  Runtime.GetNSObject<UIMenu> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NSRange_NativeHandle (This.Handle, Selector.GetHandle ("textField:editMenuForCharactersInRange:suggestedActions:"), textField__handle__, range, nsa_suggestedActions.Handle), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (textField);
			return ret!;
		}
		[global::Foundation.OptionalMember]
		[Export ("textField:shouldChangeCharactersInRanges:replacementString:")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldChangeCharacters (UITextField textField, NSValue[] ranges, string replacementString)
		{
			return _ShouldChangeCharacters (this, textField, ranges, replacementString);
		}
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _ShouldChangeCharacters (IUITextFieldDelegate This, UITextField textField, NSValue[] ranges, string replacementString)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var textField__handle__ = textField!.GetNonNullHandle (nameof (textField));
			if (ranges is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (ranges));
			if (replacementString is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (replacementString));
			using var nsa_ranges = NSArray.FromNSObjects (ranges);
			var nsreplacementString = CFString.CreateNative (replacementString);
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("textField:shouldChangeCharactersInRanges:replacementString:"), textField__handle__, nsa_ranges.Handle, nsreplacementString);
			GC.KeepAlive (This);
			GC.KeepAlive (textField);
			CFString.ReleaseNative (nsreplacementString);
			return ret != 0;
		}
		[global::Foundation.OptionalMember]
		[Export ("textField:editMenuForCharactersInRanges:suggestedActions:")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIMenu? GetEditMenu (UITextField textField, NSValue[] ranges, UIMenuElement[] suggestedActions)
		{
			return _GetEditMenu (this, textField, ranges, suggestedActions);
		}
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static UIMenu? _GetEditMenu (IUITextFieldDelegate This, UITextField textField, NSValue[] ranges, UIMenuElement[] suggestedActions)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var textField__handle__ = textField!.GetNonNullHandle (nameof (textField));
			if (ranges is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (ranges));
			if (suggestedActions is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (suggestedActions));
			using var nsa_ranges = NSArray.FromNSObjects (ranges);
			using var nsa_suggestedActions = NSArray.FromNSObjects (suggestedActions);
			UIMenu? ret;
			ret =  Runtime.GetNSObject<UIMenu> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("textField:editMenuForCharactersInRanges:suggestedActions:"), textField__handle__, nsa_ranges.Handle, nsa_suggestedActions.Handle), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (textField);
			return ret!;
		}
		[DynamicDependencyAttribute ("DidChangeSelection(UIKit.UITextField)")]
		[DynamicDependencyAttribute ("EditingEnded(UIKit.UITextField,UIKit.UITextFieldDidEndEditingReason)")]
		[DynamicDependencyAttribute ("EditingEnded(UIKit.UITextField)")]
		[DynamicDependencyAttribute ("EditingStarted(UIKit.UITextField)")]
		[DynamicDependencyAttribute ("GetEditMenu(UIKit.UITextField,Foundation.NSRange,UIKit.UIMenuElement[])")]
		[DynamicDependencyAttribute ("GetEditMenu(UIKit.UITextField,Foundation.NSValue[],UIKit.UIMenuElement[])")]
		[DynamicDependencyAttribute ("ShouldBeginEditing(UIKit.UITextField)")]
		[DynamicDependencyAttribute ("ShouldChangeCharacters(UIKit.UITextField,Foundation.NSRange,System.String)")]
		[DynamicDependencyAttribute ("ShouldChangeCharacters(UIKit.UITextField,Foundation.NSValue[],System.String)")]
		[DynamicDependencyAttribute ("ShouldClear(UIKit.UITextField)")]
		[DynamicDependencyAttribute ("ShouldEndEditing(UIKit.UITextField)")]
		[DynamicDependencyAttribute ("ShouldReturn(UIKit.UITextField)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UITextFieldDelegateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IUITextFieldDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="IUITextFieldDelegate" /> interface to support all the methods from the UITextFieldDelegate protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IUITextFieldDelegate" /> interface allow developers to treat instances of the interface as having all the optional methods of the original UITextFieldDelegate protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class UITextFieldDelegate_Extensions {
		/// <param name="textField">To be added.</param><summary>Whether editing should begin in the specified text field.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool ShouldBeginEditing (this IUITextFieldDelegate This, UITextField textField)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var textField__handle__ = textField!.GetNonNullHandle (nameof (textField));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("textFieldShouldBeginEditing:"), textField__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (textField);
			return ret != 0;
		}
		/// <param name="textField">To be added.</param><summary>Indicates that editing has begun on the specified text field.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void EditingStarted (this IUITextFieldDelegate This, UITextField textField)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var textField__handle__ = textField!.GetNonNullHandle (nameof (textField));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("textFieldDidBeginEditing:"), textField__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (textField);
		}
		/// <param name="textField">To be added.</param><summary>Whether editing should stop in the specified text field.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool ShouldEndEditing (this IUITextFieldDelegate This, UITextField textField)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var textField__handle__ = textField!.GetNonNullHandle (nameof (textField));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("textFieldShouldEndEditing:"), textField__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (textField);
			return ret != 0;
		}
		/// <param name="textField">The text field for which editing ended.</param><summary>Indicates that editing has ended in the specified text field.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void EditingEnded (this IUITextFieldDelegate This, UITextField textField)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var textField__handle__ = textField!.GetNonNullHandle (nameof (textField));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("textFieldDidEndEditing:"), textField__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (textField);
		}
		/// <param name="textField">The text field for which editing ended.</param><param name="reason">The reason that editing ended.</param><summary>Indicates that editing has ended in the specified text field for the specified reason.</summary><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void EditingEnded (this IUITextFieldDelegate This, UITextField textField, UITextFieldDidEndEditingReason reason)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var textField__handle__ = textField!.GetNonNullHandle (nameof (textField));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("textFieldDidEndEditing:reason:"), textField__handle__, (IntPtr) (long) reason);
			GC.KeepAlive (This);
			GC.KeepAlive (textField);
		}
		/// <param name="textField">To be added.</param><summary>Whether the specified text field's current contents should be removed.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool ShouldClear (this IUITextFieldDelegate This, UITextField textField)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var textField__handle__ = textField!.GetNonNullHandle (nameof (textField));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("textFieldShouldClear:"), textField__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (textField);
			return ret != 0;
		}
		/// <param name="textField">To be added.</param><summary>Whether the text field should process the pressing of the return button.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool ShouldReturn (this IUITextFieldDelegate This, UITextField textField)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var textField__handle__ = textField!.GetNonNullHandle (nameof (textField));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("textFieldShouldReturn:"), textField__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (textField);
			return ret != 0;
		}
		/// <param name="textField">To be added.</param><param name="range">To be added.</param><param name="replacementString">To be added.</param><summary>Whether the specified text should be changed.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool ShouldChangeCharacters (this IUITextFieldDelegate This, UITextField textField, NSRange range, string replacementString)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var textField__handle__ = textField!.GetNonNullHandle (nameof (textField));
			if (replacementString is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (replacementString));
			var nsreplacementString = CFString.CreateNative (replacementString);
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NSRange_NativeHandle (This.Handle, Selector.GetHandle ("textField:shouldChangeCharactersInRange:replacementString:"), textField__handle__, range, nsreplacementString);
			GC.KeepAlive (This);
			GC.KeepAlive (textField);
			CFString.ReleaseNative (nsreplacementString);
			return ret != 0;
		}
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidChangeSelection (this IUITextFieldDelegate This, UITextField textField)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var textField__handle__ = textField!.GetNonNullHandle (nameof (textField));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("textFieldDidChangeSelection:"), textField__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (textField);
		}
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static UIMenu? GetEditMenu (this IUITextFieldDelegate This, UITextField textField, NSRange range, UIMenuElement[] suggestedActions)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var textField__handle__ = textField!.GetNonNullHandle (nameof (textField));
			if (suggestedActions is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (suggestedActions));
			using var nsa_suggestedActions = NSArray.FromNSObjects (suggestedActions);
			UIMenu? ret;
			ret =  Runtime.GetNSObject<UIMenu> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NSRange_NativeHandle (This.Handle, Selector.GetHandle ("textField:editMenuForCharactersInRange:suggestedActions:"), textField__handle__, range, nsa_suggestedActions.Handle), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (textField);
			return ret!;
		}
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool ShouldChangeCharacters (this IUITextFieldDelegate This, UITextField textField, NSValue[] ranges, string replacementString)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var textField__handle__ = textField!.GetNonNullHandle (nameof (textField));
			if (ranges is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (ranges));
			if (replacementString is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (replacementString));
			using var nsa_ranges = NSArray.FromNSObjects (ranges);
			var nsreplacementString = CFString.CreateNative (replacementString);
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("textField:shouldChangeCharactersInRanges:replacementString:"), textField__handle__, nsa_ranges.Handle, nsreplacementString);
			GC.KeepAlive (This);
			GC.KeepAlive (textField);
			CFString.ReleaseNative (nsreplacementString);
			return ret != 0;
		}
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static UIMenu? GetEditMenu (this IUITextFieldDelegate This, UITextField textField, NSValue[] ranges, UIMenuElement[] suggestedActions)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var textField__handle__ = textField!.GetNonNullHandle (nameof (textField));
			if (ranges is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (ranges));
			if (suggestedActions is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (suggestedActions));
			using var nsa_ranges = NSArray.FromNSObjects (ranges);
			using var nsa_suggestedActions = NSArray.FromNSObjects (suggestedActions);
			UIMenu? ret;
			ret =  Runtime.GetNSObject<UIMenu> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("textField:editMenuForCharactersInRanges:suggestedActions:"), textField__handle__, nsa_ranges.Handle, nsa_suggestedActions.Handle), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (textField);
			return ret!;
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class UITextFieldDelegateWrapper : BaseWrapper, IUITextFieldDelegate {
		public UITextFieldDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UITextFieldDelegateWrapper))]
		static UITextFieldDelegateWrapper ()
		{
			GC.KeepAlive (null);
		}
	}
}
namespace UIKit {
	/// <summary>
	///   <para>This is a class that implements the interface <see cref="IUITextFieldDelegate" /> (for the protocol <c>UITextFieldDelegate</c>).</para>
	///   <para>Subclass this class to easily create a type that implements the protocol.</para>
	///   <para>An alternative is to create a subclass of <see cref="NSObject" /> and then implemented the interface <see cref="IUITextFieldDelegate" />.</para>
	/// </summary>
	[Protocol()]
	[Register("Microsoft_tvOS__UIKit_UITextFieldDelegate", false)]
	[Model]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("tvos")]
	public unsafe partial class UITextFieldDelegate : NSObject, IUITextFieldDelegate {
		/// <summary>Creates a new <see cref="UITextFieldDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public UITextFieldDelegate () : base (NSObjectFlag.Empty)
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
		protected UITextFieldDelegate (NSObjectFlag t) : base (t)
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
		protected internal UITextFieldDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		[Export ("textFieldDidChangeSelection:")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidChangeSelection (UITextField textField)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="textField">The text field for which editing ended.</param><summary>Indicates that editing has ended in the specified text field.</summary><remarks>To be added.</remarks>
		[Export ("textFieldDidEndEditing:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void EditingEnded (UITextField textField)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="textField">The text field for which editing ended.</param><param name="reason">The reason that editing ended.</param><summary>Indicates that editing has ended in the specified text field for the specified reason.</summary><remarks>To be added.</remarks>
		[Export ("textFieldDidEndEditing:reason:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void EditingEnded (UITextField textField, UITextFieldDidEndEditingReason reason)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="textField">To be added.</param><summary>Indicates that editing has begun on the specified text field.</summary><remarks>To be added.</remarks>
		[Export ("textFieldDidBeginEditing:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void EditingStarted (UITextField textField)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("textField:editMenuForCharactersInRange:suggestedActions:")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIMenu? GetEditMenu (UITextField textField, NSRange range, UIMenuElement[] suggestedActions)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("textField:editMenuForCharactersInRanges:suggestedActions:")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIMenu? GetEditMenu (UITextField textField, NSValue[] ranges, UIMenuElement[] suggestedActions)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="textField">To be added.</param><summary>Whether editing should begin in the specified text field.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("textFieldShouldBeginEditing:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldBeginEditing (UITextField textField)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="textField">To be added.</param><param name="range">To be added.</param><param name="replacementString">To be added.</param><summary>Whether the specified text should be changed.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("textField:shouldChangeCharactersInRange:replacementString:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldChangeCharacters (UITextField textField, NSRange range, string replacementString)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("textField:shouldChangeCharactersInRanges:replacementString:")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldChangeCharacters (UITextField textField, NSValue[] ranges, string replacementString)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="textField">To be added.</param><summary>Whether the specified text field's current contents should be removed.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("textFieldShouldClear:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldClear (UITextField textField)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="textField">To be added.</param><summary>Whether editing should stop in the specified text field.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("textFieldShouldEndEditing:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldEndEditing (UITextField textField)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="textField">To be added.</param><summary>Whether the text field should process the pressing of the return button.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("textFieldShouldReturn:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldReturn (UITextField textField)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class UITextFieldDelegate */
}
