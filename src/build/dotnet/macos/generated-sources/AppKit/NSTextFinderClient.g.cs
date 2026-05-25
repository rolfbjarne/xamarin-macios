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
	/// <summary>This interface represents the Objective-C protocol <c>NSTextFinderClient</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[Protocol (Name = "NSTextFinderClient", WrapperType = typeof (NSTextFinderClientWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetString", Selector = "stringAtIndex:effectiveRange:endsWithSearchBoundary:", ReturnType = typeof (string), ParameterType = new Type [] { typeof (UIntPtr), typeof (NSRange), typeof (bool) }, ParameterByRef = new bool [] { false, true, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ScrollRangeToVisible", Selector = "scrollRangeToVisible:", ParameterType = new Type [] { typeof (NSRange) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldReplaceCharacters", Selector = "shouldReplaceCharactersInRanges:withStrings:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (NSArray), typeof (NSArray) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ReplaceCharacters", Selector = "replaceCharactersInRange:withString:", ParameterType = new Type [] { typeof (NSRange), typeof (string) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidReplaceCharacters", Selector = "didReplaceCharacters")]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetContentView", Selector = "contentViewAtIndex:effectiveCharacterRange:", ReturnType = typeof (NSView), ParameterType = new Type [] { typeof (UIntPtr), typeof (NSRange) }, ParameterByRef = new bool [] { false, true })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetRects", Selector = "rectsForCharacterRange:", ReturnType = typeof (NSArray), ParameterType = new Type [] { typeof (NSRange) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DrawCharacters", Selector = "drawCharactersInRange:forContentView:", ParameterType = new Type [] { typeof (NSRange), typeof (NSView) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "AllowsMultipleSelection", Selector = "allowsMultipleSelection", PropertyType = typeof (bool), GetterSelector = "allowsMultipleSelection", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "Editable", Selector = "editable", PropertyType = typeof (bool), GetterSelector = "isEditable", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "String", Selector = "string", PropertyType = typeof (string), GetterSelector = "string", ArgumentSemantic = ArgumentSemantic.Copy)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "FirstSelectedRange", Selector = "firstSelectedRange", PropertyType = typeof (NSRange), GetterSelector = "firstSelectedRange", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "SelectedRanges", Selector = "selectedRanges", PropertyType = typeof (NSArray), GetterSelector = "selectedRanges", SetterSelector = "setSelectedRanges:", ArgumentSemantic = ArgumentSemantic.Copy)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "VisibleCharacterRanges", Selector = "visibleCharacterRanges", PropertyType = typeof (NSArray), GetterSelector = "visibleCharacterRanges", ArgumentSemantic = ArgumentSemantic.Copy)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "Selectable", Selector = "selectable", PropertyType = typeof (bool), GetterSelector = "isSelectable", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "StringLength", Selector = "stringLength", PropertyType = typeof (UIntPtr), GetterSelector = "stringLength", ArgumentSemantic = ArgumentSemantic.None)]
	public partial interface INSTextFinderClient : INativeObject, IDisposable
	{
		/// <param name="index">To be added.</param><param name="effectiveRange">To be added.</param><param name="endsWithSearchBoundary">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("stringAtIndex:effectiveRange:endsWithSearchBoundary:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual string GetString (nuint index, out NSRange effectiveRange, bool endsWithSearchBoundary)
		{
			return _GetString (this, index, out effectiveRange, endsWithSearchBoundary);
		}
		/// <param name="index">To be added.</param><param name="effectiveRange">To be added.</param><param name="endsWithSearchBoundary">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static string _GetString (INSTextFinderClient This, nuint index, out NSRange effectiveRange, bool endsWithSearchBoundary)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			fixed (NSRange* effectiveRange__pointer = &effectiveRange) {
			effectiveRange = default;
			string ret;
			ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UIntPtr_out_NSRange_bool (This.Handle, Selector.GetHandle ("stringAtIndex:effectiveRange:endsWithSearchBoundary:"), index, effectiveRange__pointer, endsWithSearchBoundary ? (byte) 1 : (byte) 0), false)!;
			GC.KeepAlive (This);
			return ret;
			}
		}
		/// <param name="range">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("scrollRangeToVisible:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ScrollRangeToVisible (NSRange range)
		{
			_ScrollRangeToVisible (this, range);
		}
		/// <param name="range">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _ScrollRangeToVisible (INSTextFinderClient This, NSRange range)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NSRange (This.Handle, Selector.GetHandle ("scrollRangeToVisible:"), range);
			GC.KeepAlive (This);
		}
		/// <param name="ranges">To be added.</param><param name="strings">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("shouldReplaceCharactersInRanges:withStrings:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldReplaceCharacters (NSArray ranges, NSArray strings)
		{
			return _ShouldReplaceCharacters (this, ranges, strings);
		}
		/// <param name="ranges">To be added.</param><param name="strings">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _ShouldReplaceCharacters (INSTextFinderClient This, NSArray ranges, NSArray strings)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var ranges__handle__ = ranges!.GetNonNullHandle (nameof (ranges));
			var strings__handle__ = strings!.GetNonNullHandle (nameof (strings));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("shouldReplaceCharactersInRanges:withStrings:"), ranges__handle__, strings__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (ranges);
			GC.KeepAlive (strings);
			return ret != 0;
		}
		/// <param name="range">To be added.</param><param name="str">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("replaceCharactersInRange:withString:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ReplaceCharacters (NSRange range, string str)
		{
			_ReplaceCharacters (this, range, str);
		}
		/// <param name="range">To be added.</param><param name="str">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _ReplaceCharacters (INSTextFinderClient This, NSRange range, string str)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (str is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (str));
			var nsstr = CFString.CreateNative (str);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NSRange_NativeHandle (This.Handle, Selector.GetHandle ("replaceCharactersInRange:withString:"), range, nsstr);
			GC.KeepAlive (This);
			CFString.ReleaseNative (nsstr);
		}
		/// <summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("didReplaceCharacters")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidReplaceCharacters ()
		{
			_DidReplaceCharacters (this);
		}
		/// <summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidReplaceCharacters (INSTextFinderClient This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			global::ObjCRuntime.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("didReplaceCharacters"));
			GC.KeepAlive (This);
		}
		/// <param name="index">To be added.</param><param name="outRange">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("contentViewAtIndex:effectiveCharacterRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual NSView GetContentView (nuint index, out NSRange outRange)
		{
			return _GetContentView (this, index, out outRange);
		}
		/// <param name="index">To be added.</param><param name="outRange">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static NSView _GetContentView (INSTextFinderClient This, nuint index, out NSRange outRange)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			fixed (NSRange* outRange__pointer = &outRange) {
			outRange = default;
			NSView ret;
			ret =  Runtime.GetNSObject<NSView> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UIntPtr_out_NSRange (This.Handle, Selector.GetHandle ("contentViewAtIndex:effectiveCharacterRange:"), index, outRange__pointer), false)!;
			GC.KeepAlive (This);
			return ret;
			}
		}
		/// <param name="characterRange">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("rectsForCharacterRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSArray GetRects (NSRange characterRange)
		{
			return _GetRects (this, characterRange);
		}
		/// <param name="characterRange">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSArray _GetRects (INSTextFinderClient This, NSRange characterRange)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSArray ret;
			ret =  Runtime.GetNSObject<NSArray> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NSRange (This.Handle, Selector.GetHandle ("rectsForCharacterRange:"), characterRange), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[global::Foundation.OptionalMember]
		[Export ("drawCharactersInRange:forContentView:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DrawCharacters (NSRange range, NSView view)
		{
			_DrawCharacters (this, range, view);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DrawCharacters (INSTextFinderClient This, NSRange range, NSView view)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var view__handle__ = view!.GetNonNullHandle (nameof (view));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NSRange_NativeHandle (This.Handle, Selector.GetHandle ("drawCharactersInRange:forContentView:"), range, view__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (view);
		}
		[DynamicDependencyAttribute ("AllowsMultipleSelection")]
		[DynamicDependencyAttribute ("DidReplaceCharacters()")]
		[DynamicDependencyAttribute ("DrawCharacters(Foundation.NSRange,AppKit.NSView)")]
		[DynamicDependencyAttribute ("Editable")]
		[DynamicDependencyAttribute ("FirstSelectedRange")]
		[DynamicDependencyAttribute ("GetContentView(System.UIntPtr,Foundation.NSRange@)")]
		[DynamicDependencyAttribute ("GetRects(Foundation.NSRange)")]
		[DynamicDependencyAttribute ("GetString(System.UIntPtr,Foundation.NSRange@,System.Boolean)")]
		[DynamicDependencyAttribute ("ReplaceCharacters(Foundation.NSRange,System.String)")]
		[DynamicDependencyAttribute ("ScrollRangeToVisible(Foundation.NSRange)")]
		[DynamicDependencyAttribute ("Selectable")]
		[DynamicDependencyAttribute ("SelectedRanges")]
		[DynamicDependencyAttribute ("ShouldReplaceCharacters(Foundation.NSArray,Foundation.NSArray)")]
		[DynamicDependencyAttribute ("String")]
		[DynamicDependencyAttribute ("StringLength")]
		[DynamicDependencyAttribute ("VisibleCharacterRanges")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSTextFinderClientWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static INSTextFinderClient ()
		{
			GC.KeepAlive (null);
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.OptionalMember]
		public virtual bool AllowsMultipleSelection {
			[Export ("allowsMultipleSelection")]
			get {
				return _GetAllowsMultipleSelection (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _GetAllowsMultipleSelection (INSTextFinderClient This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("allowsMultipleSelection"));
			GC.KeepAlive (This);
			return ret != 0;
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.OptionalMember]
		public virtual bool Editable {
			[Export ("isEditable")]
			get {
				return _GetEditable (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _GetEditable (INSTextFinderClient This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("isEditable"));
			GC.KeepAlive (This);
			return ret != 0;
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.OptionalMember]
		public virtual string String {
			[Export ("string", ArgumentSemantic.Copy)]
			get {
				return _GetString (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static string _GetString (INSTextFinderClient This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			string ret;
			ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("string")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.OptionalMember]
		public virtual NSRange FirstSelectedRange {
			[Export ("firstSelectedRange")]
			get {
				return _GetFirstSelectedRange (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSRange _GetFirstSelectedRange (INSTextFinderClient This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSRange ret;
			ret = global::ObjCRuntime.Messaging.NSRange_objc_msgSend (This.Handle, Selector.GetHandle ("firstSelectedRange"));
			GC.KeepAlive (This);
			return ret;
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.OptionalMember]
		public virtual NSArray SelectedRanges {
			[Export ("selectedRanges", ArgumentSemantic.Copy)]
			get {
				return _GetSelectedRanges (this);
			}
			[Export ("setSelectedRanges:", ArgumentSemantic.Copy)]
			set {
				_SetSelectedRanges (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSArray _GetSelectedRanges (INSTextFinderClient This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSArray ret;
			ret =  Runtime.GetNSObject<NSArray> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("selectedRanges")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetSelectedRanges (INSTextFinderClient This, NSArray value)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var value__handle__ = value!.GetNonNullHandle (nameof (value));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setSelectedRanges:"), value__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (value);
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.OptionalMember]
		public virtual NSArray VisibleCharacterRanges {
			[Export ("visibleCharacterRanges", ArgumentSemantic.Copy)]
			get {
				return _GetVisibleCharacterRanges (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSArray _GetVisibleCharacterRanges (INSTextFinderClient This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSArray ret;
			ret =  Runtime.GetNSObject<NSArray> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("visibleCharacterRanges")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.OptionalMember]
		public virtual bool Selectable {
			[Export ("isSelectable")]
			get {
				return _GetSelectable (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _GetSelectable (INSTextFinderClient This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("isSelectable"));
			GC.KeepAlive (This);
			return ret != 0;
		}
		/// <summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.OptionalMember]
		public virtual nuint StringLength {
			[Export ("stringLength")]
			get {
				return _GetStringLength (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static nuint _GetStringLength (INSTextFinderClient This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			nuint ret;
			ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("stringLength"));
			GC.KeepAlive (This);
			return ret;
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="INSTextFinderClient" /> interface to support all the methods from the NSTextFinderClient protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="INSTextFinderClient" /> interface allow developers to treat instances of the interface as having all the optional methods of the original NSTextFinderClient protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class NSTextFinderClient_Extensions {
		/// <param name="index">To be added.</param><param name="effectiveRange">To be added.</param><param name="endsWithSearchBoundary">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static string GetString (this INSTextFinderClient This, nuint index, out NSRange effectiveRange, bool endsWithSearchBoundary)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			fixed (NSRange* effectiveRange__pointer = &effectiveRange) {
			effectiveRange = default;
			string ret;
			ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UIntPtr_out_NSRange_bool (This.Handle, Selector.GetHandle ("stringAtIndex:effectiveRange:endsWithSearchBoundary:"), index, effectiveRange__pointer, endsWithSearchBoundary ? (byte) 1 : (byte) 0), false)!;
			GC.KeepAlive (This);
			return ret;
			}
		}
		/// <param name="range">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void ScrollRangeToVisible (this INSTextFinderClient This, NSRange range)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NSRange (This.Handle, Selector.GetHandle ("scrollRangeToVisible:"), range);
			GC.KeepAlive (This);
		}
		/// <param name="ranges">To be added.</param><param name="strings">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool ShouldReplaceCharacters (this INSTextFinderClient This, NSArray ranges, NSArray strings)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var ranges__handle__ = ranges!.GetNonNullHandle (nameof (ranges));
			var strings__handle__ = strings!.GetNonNullHandle (nameof (strings));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("shouldReplaceCharactersInRanges:withStrings:"), ranges__handle__, strings__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (ranges);
			GC.KeepAlive (strings);
			return ret != 0;
		}
		/// <param name="range">To be added.</param><param name="str">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void ReplaceCharacters (this INSTextFinderClient This, NSRange range, string str)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (str is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (str));
			var nsstr = CFString.CreateNative (str);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NSRange_NativeHandle (This.Handle, Selector.GetHandle ("replaceCharactersInRange:withString:"), range, nsstr);
			GC.KeepAlive (This);
			CFString.ReleaseNative (nsstr);
		}
		/// <summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidReplaceCharacters (this INSTextFinderClient This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			global::ObjCRuntime.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("didReplaceCharacters"));
			GC.KeepAlive (This);
		}
		/// <param name="index">To be added.</param><param name="outRange">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static NSView GetContentView (this INSTextFinderClient This, nuint index, out NSRange outRange)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			fixed (NSRange* outRange__pointer = &outRange) {
			outRange = default;
			NSView ret;
			ret =  Runtime.GetNSObject<NSView> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UIntPtr_out_NSRange (This.Handle, Selector.GetHandle ("contentViewAtIndex:effectiveCharacterRange:"), index, outRange__pointer), false)!;
			GC.KeepAlive (This);
			return ret;
			}
		}
		/// <param name="characterRange">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSArray GetRects (this INSTextFinderClient This, NSRange characterRange)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSArray ret;
			ret =  Runtime.GetNSObject<NSArray> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NSRange (This.Handle, Selector.GetHandle ("rectsForCharacterRange:"), characterRange), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DrawCharacters (this INSTextFinderClient This, NSRange range, NSView view)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var view__handle__ = view!.GetNonNullHandle (nameof (view));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NSRange_NativeHandle (This.Handle, Selector.GetHandle ("drawCharactersInRange:forContentView:"), range, view__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (view);
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool GetAllowsMultipleSelection (this INSTextFinderClient This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("allowsMultipleSelection"));
			GC.KeepAlive (This);
			return ret != 0;
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool GetEditable (this INSTextFinderClient This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("isEditable"));
			GC.KeepAlive (This);
			return ret != 0;
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string GetString (this INSTextFinderClient This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			string ret;
			ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("string")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSRange GetFirstSelectedRange (this INSTextFinderClient This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSRange ret;
			ret = global::ObjCRuntime.Messaging.NSRange_objc_msgSend (This.Handle, Selector.GetHandle ("firstSelectedRange"));
			GC.KeepAlive (This);
			return ret;
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSArray GetSelectedRanges (this INSTextFinderClient This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSArray ret;
			ret =  Runtime.GetNSObject<NSArray> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("selectedRanges")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetSelectedRanges (this INSTextFinderClient This, NSArray value)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var value__handle__ = value!.GetNonNullHandle (nameof (value));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setSelectedRanges:"), value__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (value);
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSArray GetVisibleCharacterRanges (this INSTextFinderClient This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSArray ret;
			ret =  Runtime.GetNSObject<NSArray> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("visibleCharacterRanges")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool GetSelectable (this INSTextFinderClient This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("isSelectable"));
			GC.KeepAlive (This);
			return ret != 0;
		}
		/// <summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static nuint GetStringLength (this INSTextFinderClient This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			nuint ret;
			ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("stringLength"));
			GC.KeepAlive (This);
			return ret;
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class NSTextFinderClientWrapper : BaseWrapper, INSTextFinderClient {
		public NSTextFinderClientWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSTextFinderClientWrapper))]
		static NSTextFinderClientWrapper ()
		{
			GC.KeepAlive (null);
		}
	}
}
