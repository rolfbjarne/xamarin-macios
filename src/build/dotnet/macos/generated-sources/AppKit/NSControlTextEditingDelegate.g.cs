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
	/// <summary>This interface represents the Objective-C protocol <c>NSControlTextEditingDelegate</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[Protocol (Name = "NSControlTextEditingDelegate", WrapperType = typeof (NSControlTextEditingDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "TextShouldBeginEditing", Selector = "control:textShouldBeginEditing:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (NSControl), typeof (NSText) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "TextShouldEndEditing", Selector = "control:textShouldEndEditing:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (NSControl), typeof (NSText) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidFailToFormatString", Selector = "control:didFailToFormatString:errorDescription:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (NSControl), typeof (string), typeof (string) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidFailToValidatePartialString", Selector = "control:didFailToValidatePartialString:errorDescription:", ParameterType = new Type [] { typeof (NSControl), typeof (string), typeof (string) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "IsValidObject", Selector = "control:isValidObject:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (NSControl), typeof (NSObject) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DoCommandBySelector", Selector = "control:textView:doCommandBySelector:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (NSControl), typeof (NSTextView), typeof (Selector) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetCompletions", Selector = "control:textView:completions:forPartialWordRange:indexOfSelectedItem:", ReturnType = typeof (String[]), ParameterType = new Type [] { typeof (NSControl), typeof (NSTextView), typeof (String[]), typeof (NSRange), typeof (IntPtr) }, ParameterByRef = new bool [] { false, false, false, false, true })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ControlTextDidBeginEditing", Selector = "controlTextDidBeginEditing:", ParameterType = new Type [] { typeof (NSNotification) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ControlTextDidEndEditing", Selector = "controlTextDidEndEditing:", ParameterType = new Type [] { typeof (NSNotification) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ControlTextDidChange", Selector = "controlTextDidChange:", ParameterType = new Type [] { typeof (NSNotification) }, ParameterByRef = new bool [] { false })]
	public partial interface INSControlTextEditingDelegate : INativeObject, IDisposable
	{
		/// <param name="control">To be added.</param><param name="fieldEditor">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("control:textShouldBeginEditing:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool TextShouldBeginEditing (NSControl control, NSText fieldEditor)
		{
			return _TextShouldBeginEditing (this, control, fieldEditor);
		}
		/// <param name="control">To be added.</param><param name="fieldEditor">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _TextShouldBeginEditing (INSControlTextEditingDelegate This, NSControl control, NSText fieldEditor)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var control__handle__ = control!.GetNonNullHandle (nameof (control));
			var fieldEditor__handle__ = fieldEditor!.GetNonNullHandle (nameof (fieldEditor));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("control:textShouldBeginEditing:"), control__handle__, fieldEditor__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (control);
			GC.KeepAlive (fieldEditor);
			return ret != 0;
		}
		/// <param name="control">To be added.</param><param name="fieldEditor">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("control:textShouldEndEditing:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool TextShouldEndEditing (NSControl control, NSText fieldEditor)
		{
			return _TextShouldEndEditing (this, control, fieldEditor);
		}
		/// <param name="control">To be added.</param><param name="fieldEditor">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _TextShouldEndEditing (INSControlTextEditingDelegate This, NSControl control, NSText fieldEditor)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var control__handle__ = control!.GetNonNullHandle (nameof (control));
			var fieldEditor__handle__ = fieldEditor!.GetNonNullHandle (nameof (fieldEditor));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("control:textShouldEndEditing:"), control__handle__, fieldEditor__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (control);
			GC.KeepAlive (fieldEditor);
			return ret != 0;
		}
		/// <param name="control">To be added.</param><param name="str">To be added.</param><param name="error">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("control:didFailToFormatString:errorDescription:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool DidFailToFormatString (NSControl control, string str, string error)
		{
			return _DidFailToFormatString (this, control, str, error);
		}
		/// <param name="control">To be added.</param><param name="str">To be added.</param><param name="error">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _DidFailToFormatString (INSControlTextEditingDelegate This, NSControl control, string str, string error)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var control__handle__ = control!.GetNonNullHandle (nameof (control));
			if (str is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (str));
			if (error is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (error));
			var nsstr = CFString.CreateNative (str);
			var nserror = CFString.CreateNative (error);
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("control:didFailToFormatString:errorDescription:"), control__handle__, nsstr, nserror);
			GC.KeepAlive (This);
			GC.KeepAlive (control);
			CFString.ReleaseNative (nsstr);
			CFString.ReleaseNative (nserror);
			return ret != 0;
		}
		/// <param name="control">To be added.</param><param name="str">To be added.</param><param name="error">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("control:didFailToValidatePartialString:errorDescription:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidFailToValidatePartialString (NSControl control, string str, string error)
		{
			_DidFailToValidatePartialString (this, control, str, error);
		}
		/// <param name="control">To be added.</param><param name="str">To be added.</param><param name="error">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidFailToValidatePartialString (INSControlTextEditingDelegate This, NSControl control, string str, string error)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var control__handle__ = control!.GetNonNullHandle (nameof (control));
			if (str is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (str));
			if (error is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (error));
			var nsstr = CFString.CreateNative (str);
			var nserror = CFString.CreateNative (error);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("control:didFailToValidatePartialString:errorDescription:"), control__handle__, nsstr, nserror);
			GC.KeepAlive (This);
			GC.KeepAlive (control);
			CFString.ReleaseNative (nsstr);
			CFString.ReleaseNative (nserror);
		}
		/// <param name="control">To be added.</param><param name="objectToValidate">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("control:isValidObject:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool IsValidObject (NSControl control, NSObject objectToValidate)
		{
			return _IsValidObject (this, control, objectToValidate);
		}
		/// <param name="control">To be added.</param><param name="objectToValidate">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _IsValidObject (INSControlTextEditingDelegate This, NSControl control, NSObject objectToValidate)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var control__handle__ = control!.GetNonNullHandle (nameof (control));
			var objectToValidate__handle__ = objectToValidate!.GetNonNullHandle (nameof (objectToValidate));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("control:isValidObject:"), control__handle__, objectToValidate__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (control);
			GC.KeepAlive (objectToValidate);
			return ret != 0;
		}
		/// <param name="control">To be added.</param><param name="textView">To be added.</param><param name="commandSelector">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("control:textView:doCommandBySelector:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool DoCommandBySelector (NSControl control, NSTextView textView, Selector commandSelector)
		{
			return _DoCommandBySelector (this, control, textView, commandSelector);
		}
		/// <param name="control">To be added.</param><param name="textView">To be added.</param><param name="commandSelector">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _DoCommandBySelector (INSControlTextEditingDelegate This, NSControl control, NSTextView textView, Selector commandSelector)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var control__handle__ = control!.GetNonNullHandle (nameof (control));
			var textView__handle__ = textView!.GetNonNullHandle (nameof (textView));
			var commandSelector__handle__ = commandSelector!.GetNonNullHandle (nameof (commandSelector));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("control:textView:doCommandBySelector:"), control__handle__, textView__handle__, commandSelector.Handle);
			GC.KeepAlive (This);
			GC.KeepAlive (control);
			GC.KeepAlive (textView);
			GC.KeepAlive (commandSelector);
			return ret != 0;
		}
		/// <param name="control">To be added.</param><param name="textView">To be added.</param><param name="words">To be added.</param><param name="charRange">To be added.</param><param name="index">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("control:textView:completions:forPartialWordRange:indexOfSelectedItem:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual string[] GetCompletions (NSControl control, NSTextView textView, string[] words, NSRange charRange, ref nint index)
		{
			return _GetCompletions (this, control, textView, words, charRange, ref index);
		}
		/// <param name="control">To be added.</param><param name="textView">To be added.</param><param name="words">To be added.</param><param name="charRange">To be added.</param><param name="index">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static string[] _GetCompletions (INSControlTextEditingDelegate This, NSControl control, NSTextView textView, string[] words, NSRange charRange, ref nint index)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var control__handle__ = control!.GetNonNullHandle (nameof (control));
			var textView__handle__ = textView!.GetNonNullHandle (nameof (textView));
			if (words is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (words));
			fixed (nint* index__pointer = &index) {
			using var nsa_words = NSArray.FromStrings (words);
			string[]? ret;
			ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NSRange_ref_IntPtr (This.Handle, Selector.GetHandle ("control:textView:completions:forPartialWordRange:indexOfSelectedItem:"), control__handle__, textView__handle__, nsa_words.Handle, charRange, index__pointer), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (control);
			GC.KeepAlive (textView);
			return ret!;
			}
		}
		/// <param name="obj">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("controlTextDidBeginEditing:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ControlTextDidBeginEditing (NSNotification obj)
		{
			_ControlTextDidBeginEditing (this, obj);
		}
		/// <param name="obj">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _ControlTextDidBeginEditing (INSControlTextEditingDelegate This, NSNotification obj)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var obj__handle__ = obj!.GetNonNullHandle (nameof (obj));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("controlTextDidBeginEditing:"), obj__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (obj);
		}
		/// <param name="obj">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("controlTextDidEndEditing:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ControlTextDidEndEditing (NSNotification obj)
		{
			_ControlTextDidEndEditing (this, obj);
		}
		/// <param name="obj">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _ControlTextDidEndEditing (INSControlTextEditingDelegate This, NSNotification obj)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var obj__handle__ = obj!.GetNonNullHandle (nameof (obj));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("controlTextDidEndEditing:"), obj__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (obj);
		}
		/// <param name="obj">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("controlTextDidChange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ControlTextDidChange (NSNotification obj)
		{
			_ControlTextDidChange (this, obj);
		}
		/// <param name="obj">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _ControlTextDidChange (INSControlTextEditingDelegate This, NSNotification obj)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var obj__handle__ = obj!.GetNonNullHandle (nameof (obj));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("controlTextDidChange:"), obj__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (obj);
		}
		[DynamicDependencyAttribute ("ControlTextDidBeginEditing(Foundation.NSNotification)")]
		[DynamicDependencyAttribute ("ControlTextDidChange(Foundation.NSNotification)")]
		[DynamicDependencyAttribute ("ControlTextDidEndEditing(Foundation.NSNotification)")]
		[DynamicDependencyAttribute ("DidFailToFormatString(AppKit.NSControl,System.String,System.String)")]
		[DynamicDependencyAttribute ("DidFailToValidatePartialString(AppKit.NSControl,System.String,System.String)")]
		[DynamicDependencyAttribute ("DoCommandBySelector(AppKit.NSControl,AppKit.NSTextView,ObjCRuntime.Selector)")]
		[DynamicDependencyAttribute ("GetCompletions(AppKit.NSControl,AppKit.NSTextView,System.String[],Foundation.NSRange,System.IntPtr@)")]
		[DynamicDependencyAttribute ("IsValidObject(AppKit.NSControl,Foundation.NSObject)")]
		[DynamicDependencyAttribute ("TextShouldBeginEditing(AppKit.NSControl,AppKit.NSText)")]
		[DynamicDependencyAttribute ("TextShouldEndEditing(AppKit.NSControl,AppKit.NSText)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSControlTextEditingDelegateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static INSControlTextEditingDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="INSControlTextEditingDelegate" /> interface to support all the methods from the NSControlTextEditingDelegate protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="INSControlTextEditingDelegate" /> interface allow developers to treat instances of the interface as having all the optional methods of the original NSControlTextEditingDelegate protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class NSControlTextEditingDelegate_Extensions {
		/// <param name="control">To be added.</param><param name="fieldEditor">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool TextShouldBeginEditing (this INSControlTextEditingDelegate This, NSControl control, NSText fieldEditor)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var control__handle__ = control!.GetNonNullHandle (nameof (control));
			var fieldEditor__handle__ = fieldEditor!.GetNonNullHandle (nameof (fieldEditor));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("control:textShouldBeginEditing:"), control__handle__, fieldEditor__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (control);
			GC.KeepAlive (fieldEditor);
			return ret != 0;
		}
		/// <param name="control">To be added.</param><param name="fieldEditor">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool TextShouldEndEditing (this INSControlTextEditingDelegate This, NSControl control, NSText fieldEditor)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var control__handle__ = control!.GetNonNullHandle (nameof (control));
			var fieldEditor__handle__ = fieldEditor!.GetNonNullHandle (nameof (fieldEditor));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("control:textShouldEndEditing:"), control__handle__, fieldEditor__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (control);
			GC.KeepAlive (fieldEditor);
			return ret != 0;
		}
		/// <param name="control">To be added.</param><param name="str">To be added.</param><param name="error">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool DidFailToFormatString (this INSControlTextEditingDelegate This, NSControl control, string str, string error)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var control__handle__ = control!.GetNonNullHandle (nameof (control));
			if (str is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (str));
			if (error is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (error));
			var nsstr = CFString.CreateNative (str);
			var nserror = CFString.CreateNative (error);
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("control:didFailToFormatString:errorDescription:"), control__handle__, nsstr, nserror);
			GC.KeepAlive (This);
			GC.KeepAlive (control);
			CFString.ReleaseNative (nsstr);
			CFString.ReleaseNative (nserror);
			return ret != 0;
		}
		/// <param name="control">To be added.</param><param name="str">To be added.</param><param name="error">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidFailToValidatePartialString (this INSControlTextEditingDelegate This, NSControl control, string str, string error)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var control__handle__ = control!.GetNonNullHandle (nameof (control));
			if (str is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (str));
			if (error is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (error));
			var nsstr = CFString.CreateNative (str);
			var nserror = CFString.CreateNative (error);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("control:didFailToValidatePartialString:errorDescription:"), control__handle__, nsstr, nserror);
			GC.KeepAlive (This);
			GC.KeepAlive (control);
			CFString.ReleaseNative (nsstr);
			CFString.ReleaseNative (nserror);
		}
		/// <param name="control">To be added.</param><param name="objectToValidate">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool IsValidObject (this INSControlTextEditingDelegate This, NSControl control, NSObject objectToValidate)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var control__handle__ = control!.GetNonNullHandle (nameof (control));
			var objectToValidate__handle__ = objectToValidate!.GetNonNullHandle (nameof (objectToValidate));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("control:isValidObject:"), control__handle__, objectToValidate__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (control);
			GC.KeepAlive (objectToValidate);
			return ret != 0;
		}
		/// <param name="control">To be added.</param><param name="textView">To be added.</param><param name="commandSelector">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool DoCommandBySelector (this INSControlTextEditingDelegate This, NSControl control, NSTextView textView, Selector commandSelector)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var control__handle__ = control!.GetNonNullHandle (nameof (control));
			var textView__handle__ = textView!.GetNonNullHandle (nameof (textView));
			var commandSelector__handle__ = commandSelector!.GetNonNullHandle (nameof (commandSelector));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("control:textView:doCommandBySelector:"), control__handle__, textView__handle__, commandSelector.Handle);
			GC.KeepAlive (This);
			GC.KeepAlive (control);
			GC.KeepAlive (textView);
			GC.KeepAlive (commandSelector);
			return ret != 0;
		}
		/// <param name="control">To be added.</param><param name="textView">To be added.</param><param name="words">To be added.</param><param name="charRange">To be added.</param><param name="index">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static string[] GetCompletions (this INSControlTextEditingDelegate This, NSControl control, NSTextView textView, string[] words, NSRange charRange, ref nint index)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var control__handle__ = control!.GetNonNullHandle (nameof (control));
			var textView__handle__ = textView!.GetNonNullHandle (nameof (textView));
			if (words is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (words));
			fixed (nint* index__pointer = &index) {
			using var nsa_words = NSArray.FromStrings (words);
			string[]? ret;
			ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NSRange_ref_IntPtr (This.Handle, Selector.GetHandle ("control:textView:completions:forPartialWordRange:indexOfSelectedItem:"), control__handle__, textView__handle__, nsa_words.Handle, charRange, index__pointer), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (control);
			GC.KeepAlive (textView);
			return ret!;
			}
		}
		/// <param name="obj">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void ControlTextDidBeginEditing (this INSControlTextEditingDelegate This, NSNotification obj)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var obj__handle__ = obj!.GetNonNullHandle (nameof (obj));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("controlTextDidBeginEditing:"), obj__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (obj);
		}
		/// <param name="obj">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void ControlTextDidEndEditing (this INSControlTextEditingDelegate This, NSNotification obj)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var obj__handle__ = obj!.GetNonNullHandle (nameof (obj));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("controlTextDidEndEditing:"), obj__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (obj);
		}
		/// <param name="obj">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void ControlTextDidChange (this INSControlTextEditingDelegate This, NSNotification obj)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var obj__handle__ = obj!.GetNonNullHandle (nameof (obj));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("controlTextDidChange:"), obj__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (obj);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class NSControlTextEditingDelegateWrapper : BaseWrapper, INSControlTextEditingDelegate {
		public NSControlTextEditingDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSControlTextEditingDelegateWrapper))]
		static NSControlTextEditingDelegateWrapper ()
		{
			GC.KeepAlive (null);
		}
	}
}
namespace AppKit {
	/// <summary>
	///   <para>This is a class that implements the interface <see cref="INSControlTextEditingDelegate" /> (for the protocol <c>NSControlTextEditingDelegate</c>).</para>
	///   <para>Subclass this class to easily create a type that implements the protocol.</para>
	///   <para>An alternative is to create a subclass of <see cref="NSObject" /> and then implemented the interface <see cref="INSControlTextEditingDelegate" />.</para>
	/// </summary>
	[Protocol()]
	[Register("Microsoft_macOS__AppKit_NSControlTextEditingDelegate", false)]
	[Model]
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	public unsafe partial class NSControlTextEditingDelegate : NSObject, INSControlTextEditingDelegate {
		/// <summary>Creates a new <see cref="NSControlTextEditingDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public NSControlTextEditingDelegate () : base (NSObjectFlag.Empty)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			IsDirectBinding = false;
			unsafe {
			var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
			InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, global::ObjCRuntime.Selector.Init), "init");
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
		protected NSControlTextEditingDelegate (NSObjectFlag t) : base (t)
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
		protected internal NSControlTextEditingDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		/// <param name="obj">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("controlTextDidBeginEditing:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ControlTextDidBeginEditing (NSNotification obj)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="obj">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("controlTextDidChange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ControlTextDidChange (NSNotification obj)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="obj">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("controlTextDidEndEditing:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ControlTextDidEndEditing (NSNotification obj)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="control">To be added.</param><param name="str">To be added.</param><param name="error">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("control:didFailToFormatString:errorDescription:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool DidFailToFormatString (NSControl control, string str, string error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="control">To be added.</param><param name="str">To be added.</param><param name="error">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("control:didFailToValidatePartialString:errorDescription:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidFailToValidatePartialString (NSControl control, string str, string error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="control">To be added.</param><param name="textView">To be added.</param><param name="commandSelector">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("control:textView:doCommandBySelector:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool DoCommandBySelector (NSControl control, NSTextView textView, Selector commandSelector)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="control">To be added.</param><param name="textView">To be added.</param><param name="words">To be added.</param><param name="charRange">To be added.</param><param name="index">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("control:textView:completions:forPartialWordRange:indexOfSelectedItem:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual string[] GetCompletions (NSControl control, NSTextView textView, string[] words, NSRange charRange, ref nint index)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="control">To be added.</param><param name="objectToValidate">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("control:isValidObject:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool IsValidObject (NSControl control, NSObject objectToValidate)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="control">To be added.</param><param name="fieldEditor">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("control:textShouldBeginEditing:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool TextShouldBeginEditing (NSControl control, NSText fieldEditor)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="control">To be added.</param><param name="fieldEditor">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("control:textShouldEndEditing:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool TextShouldEndEditing (NSControl control, NSText fieldEditor)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class NSControlTextEditingDelegate */
}
