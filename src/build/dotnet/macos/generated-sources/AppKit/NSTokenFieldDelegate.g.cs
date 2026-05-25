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
	/// <summary>This interface represents the Objective-C protocol <c>NSTokenFieldDelegate</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[Protocol (Name = "NSTokenFieldDelegate", WrapperType = typeof (NSTokenFieldDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetCompletionStrings", Selector = "tokenField:completionsForSubstring:indexOfToken:indexOfSelectedItem:", ReturnType = typeof (String[]), ParameterType = new Type [] { typeof (NSTokenField), typeof (string), typeof (IntPtr), typeof (IntPtr) }, ParameterByRef = new bool [] { false, false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldAddObjects", Selector = "tokenField:shouldAddObjects:atIndex:", ReturnType = typeof (NSArray), ParameterType = new Type [] { typeof (NSTokenField), typeof (NSArray), typeof (UIntPtr) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetDisplayString", Selector = "tokenField:displayStringForRepresentedObject:", ReturnType = typeof (string), ParameterType = new Type [] { typeof (NSTokenField), typeof (NSObject) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetEditingString", Selector = "tokenField:editingStringForRepresentedObject:", ReturnType = typeof (string), ParameterType = new Type [] { typeof (NSTokenField), typeof (NSObject) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetRepresentedObject", Selector = "tokenField:representedObjectForEditingString:", ReturnType = typeof (NSObject), ParameterType = new Type [] { typeof (NSTokenField), typeof (string) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WriteRepresented", Selector = "tokenField:writeRepresentedObjects:toPasteboard:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (NSTokenField), typeof (NSArray), typeof (NSPasteboard) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "Read", Selector = "tokenField:readFromPasteboard:", ReturnType = typeof (NSObject[]), ParameterType = new Type [] { typeof (NSTokenField), typeof (NSPasteboard) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetMenu", Selector = "tokenField:menuForRepresentedObject:", ReturnType = typeof (NSMenu), ParameterType = new Type [] { typeof (NSTokenField), typeof (NSObject) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "HasMenu", Selector = "tokenField:hasMenuForRepresentedObject:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (NSTokenField), typeof (NSObject) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetStyle", Selector = "tokenField:styleForRepresentedObject:", ReturnType = typeof (NSTokenStyle), ParameterType = new Type [] { typeof (NSTokenField), typeof (NSObject) }, ParameterByRef = new bool [] { false, false })]
	public partial interface INSTokenFieldDelegate : INativeObject, IDisposable
	{
		/// <param name="tokenField">To be added.</param><param name="substring">To be added.</param><param name="tokenIndex">To be added.</param><param name="selectedIndex">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("tokenField:completionsForSubstring:indexOfToken:indexOfSelectedItem:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string[] GetCompletionStrings (NSTokenField tokenField, string substring, nint tokenIndex, nint selectedIndex)
		{
			return _GetCompletionStrings (this, tokenField, substring, tokenIndex, selectedIndex);
		}
		/// <param name="tokenField">To be added.</param><param name="substring">To be added.</param><param name="tokenIndex">To be added.</param><param name="selectedIndex">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static string[] _GetCompletionStrings (INSTokenFieldDelegate This, NSTokenField tokenField, string substring, nint tokenIndex, nint selectedIndex)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var tokenField__handle__ = tokenField!.GetNonNullHandle (nameof (tokenField));
			if (substring is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (substring));
			var nssubstring = CFString.CreateNative (substring);
			string[]? ret;
			ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("tokenField:completionsForSubstring:indexOfToken:indexOfSelectedItem:"), tokenField__handle__, nssubstring, tokenIndex, selectedIndex), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tokenField);
			CFString.ReleaseNative (nssubstring);
			return ret!;
		}
		/// <param name="tokenField">To be added.</param><param name="tokens">To be added.</param><param name="index">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("tokenField:shouldAddObjects:atIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSArray ShouldAddObjects (NSTokenField tokenField, NSArray tokens, nuint index)
		{
			return _ShouldAddObjects (this, tokenField, tokens, index);
		}
		/// <param name="tokenField">To be added.</param><param name="tokens">To be added.</param><param name="index">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSArray _ShouldAddObjects (INSTokenFieldDelegate This, NSTokenField tokenField, NSArray tokens, nuint index)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var tokenField__handle__ = tokenField!.GetNonNullHandle (nameof (tokenField));
			var tokens__handle__ = tokens!.GetNonNullHandle (nameof (tokens));
			NSArray? ret;
			ret =  Runtime.GetNSObject<NSArray> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_UIntPtr (This.Handle, Selector.GetHandle ("tokenField:shouldAddObjects:atIndex:"), tokenField__handle__, tokens__handle__, index), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tokenField);
			GC.KeepAlive (tokens);
			return ret!;
		}
		/// <param name="tokenField">To be added.</param><param name="representedObject">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("tokenField:displayStringForRepresentedObject:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string GetDisplayString (NSTokenField tokenField, NSObject representedObject)
		{
			return _GetDisplayString (this, tokenField, representedObject);
		}
		/// <param name="tokenField">To be added.</param><param name="representedObject">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static string _GetDisplayString (INSTokenFieldDelegate This, NSTokenField tokenField, NSObject representedObject)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var tokenField__handle__ = tokenField!.GetNonNullHandle (nameof (tokenField));
			var representedObject__handle__ = representedObject!.GetNonNullHandle (nameof (representedObject));
			string? ret;
			ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("tokenField:displayStringForRepresentedObject:"), tokenField__handle__, representedObject__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tokenField);
			GC.KeepAlive (representedObject);
			return ret!;
		}
		/// <param name="tokenField">To be added.</param><param name="representedObject">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("tokenField:editingStringForRepresentedObject:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string GetEditingString (NSTokenField tokenField, NSObject representedObject)
		{
			return _GetEditingString (this, tokenField, representedObject);
		}
		/// <param name="tokenField">To be added.</param><param name="representedObject">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static string _GetEditingString (INSTokenFieldDelegate This, NSTokenField tokenField, NSObject representedObject)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var tokenField__handle__ = tokenField!.GetNonNullHandle (nameof (tokenField));
			var representedObject__handle__ = representedObject!.GetNonNullHandle (nameof (representedObject));
			string? ret;
			ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("tokenField:editingStringForRepresentedObject:"), tokenField__handle__, representedObject__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tokenField);
			GC.KeepAlive (representedObject);
			return ret!;
		}
		/// <param name="tokenField">To be added.</param><param name="editingString">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("tokenField:representedObjectForEditingString:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject? GetRepresentedObject (NSTokenField tokenField, string editingString)
		{
			return _GetRepresentedObject (this, tokenField, editingString);
		}
		/// <param name="tokenField">To be added.</param><param name="editingString">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSObject? _GetRepresentedObject (INSTokenFieldDelegate This, NSTokenField tokenField, string editingString)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var tokenField__handle__ = tokenField!.GetNonNullHandle (nameof (tokenField));
			if (editingString is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (editingString));
			var nseditingString = CFString.CreateNative (editingString);
			NSObject? ret;
			ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("tokenField:representedObjectForEditingString:"), tokenField__handle__, nseditingString), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tokenField);
			CFString.ReleaseNative (nseditingString);
			return ret!;
		}
		/// <param name="tokenField">To be added.</param><param name="objects">To be added.</param><param name="pboard">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("tokenField:writeRepresentedObjects:toPasteboard:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool WriteRepresented (NSTokenField tokenField, NSArray objects, NSPasteboard pboard)
		{
			return _WriteRepresented (this, tokenField, objects, pboard);
		}
		/// <param name="tokenField">To be added.</param><param name="objects">To be added.</param><param name="pboard">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _WriteRepresented (INSTokenFieldDelegate This, NSTokenField tokenField, NSArray objects, NSPasteboard pboard)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var tokenField__handle__ = tokenField!.GetNonNullHandle (nameof (tokenField));
			var objects__handle__ = objects!.GetNonNullHandle (nameof (objects));
			var pboard__handle__ = pboard!.GetNonNullHandle (nameof (pboard));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("tokenField:writeRepresentedObjects:toPasteboard:"), tokenField__handle__, objects__handle__, pboard__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (tokenField);
			GC.KeepAlive (objects);
			GC.KeepAlive (pboard);
			return ret != 0;
		}
		/// <param name="tokenField">To be added.</param><param name="pboard">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("tokenField:readFromPasteboard:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject[] Read (NSTokenField tokenField, NSPasteboard pboard)
		{
			return _Read (this, tokenField, pboard);
		}
		/// <param name="tokenField">To be added.</param><param name="pboard">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSObject[] _Read (INSTokenFieldDelegate This, NSTokenField tokenField, NSPasteboard pboard)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var tokenField__handle__ = tokenField!.GetNonNullHandle (nameof (tokenField));
			var pboard__handle__ = pboard!.GetNonNullHandle (nameof (pboard));
			NSObject[]? ret;
			ret = CFArray.ArrayFromHandle<NSObject>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("tokenField:readFromPasteboard:"), tokenField__handle__, pboard__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tokenField);
			GC.KeepAlive (pboard);
			return ret!;
		}
		/// <param name="tokenField">To be added.</param><param name="representedObject">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("tokenField:menuForRepresentedObject:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSMenu GetMenu (NSTokenField tokenField, NSObject representedObject)
		{
			return _GetMenu (this, tokenField, representedObject);
		}
		/// <param name="tokenField">To be added.</param><param name="representedObject">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSMenu _GetMenu (INSTokenFieldDelegate This, NSTokenField tokenField, NSObject representedObject)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var tokenField__handle__ = tokenField!.GetNonNullHandle (nameof (tokenField));
			var representedObject__handle__ = representedObject!.GetNonNullHandle (nameof (representedObject));
			NSMenu? ret;
			ret =  Runtime.GetNSObject<NSMenu> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("tokenField:menuForRepresentedObject:"), tokenField__handle__, representedObject__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tokenField);
			GC.KeepAlive (representedObject);
			return ret!;
		}
		/// <param name="tokenField">To be added.</param><param name="representedObject">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("tokenField:hasMenuForRepresentedObject:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool HasMenu (NSTokenField tokenField, NSObject representedObject)
		{
			return _HasMenu (this, tokenField, representedObject);
		}
		/// <param name="tokenField">To be added.</param><param name="representedObject">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _HasMenu (INSTokenFieldDelegate This, NSTokenField tokenField, NSObject representedObject)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var tokenField__handle__ = tokenField!.GetNonNullHandle (nameof (tokenField));
			var representedObject__handle__ = representedObject!.GetNonNullHandle (nameof (representedObject));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("tokenField:hasMenuForRepresentedObject:"), tokenField__handle__, representedObject__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (tokenField);
			GC.KeepAlive (representedObject);
			return ret != 0;
		}
		/// <param name="tokenField">To be added.</param><param name="representedObject">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("tokenField:styleForRepresentedObject:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSTokenStyle GetStyle (NSTokenField tokenField, NSObject representedObject)
		{
			return _GetStyle (this, tokenField, representedObject);
		}
		/// <param name="tokenField">To be added.</param><param name="representedObject">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSTokenStyle _GetStyle (INSTokenFieldDelegate This, NSTokenField tokenField, NSObject representedObject)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var tokenField__handle__ = tokenField!.GetNonNullHandle (nameof (tokenField));
			var representedObject__handle__ = representedObject!.GetNonNullHandle (nameof (representedObject));
			NSTokenStyle ret;
			ret = (NSTokenStyle) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("tokenField:styleForRepresentedObject:"), tokenField__handle__, representedObject__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (tokenField);
			GC.KeepAlive (representedObject);
			return ret!;
		}
		[DynamicDependencyAttribute ("GetCompletionStrings(AppKit.NSTokenField,System.String,System.IntPtr,System.IntPtr)")]
		[DynamicDependencyAttribute ("GetDisplayString(AppKit.NSTokenField,Foundation.NSObject)")]
		[DynamicDependencyAttribute ("GetEditingString(AppKit.NSTokenField,Foundation.NSObject)")]
		[DynamicDependencyAttribute ("GetMenu(AppKit.NSTokenField,Foundation.NSObject)")]
		[DynamicDependencyAttribute ("GetRepresentedObject(AppKit.NSTokenField,System.String)")]
		[DynamicDependencyAttribute ("GetStyle(AppKit.NSTokenField,Foundation.NSObject)")]
		[DynamicDependencyAttribute ("HasMenu(AppKit.NSTokenField,Foundation.NSObject)")]
		[DynamicDependencyAttribute ("Read(AppKit.NSTokenField,AppKit.NSPasteboard)")]
		[DynamicDependencyAttribute ("ShouldAddObjects(AppKit.NSTokenField,Foundation.NSArray,System.UIntPtr)")]
		[DynamicDependencyAttribute ("WriteRepresented(AppKit.NSTokenField,Foundation.NSArray,AppKit.NSPasteboard)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSTokenFieldDelegateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static INSTokenFieldDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="INSTokenFieldDelegate" /> interface to support all the methods from the NSTokenFieldDelegate protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="INSTokenFieldDelegate" /> interface allow developers to treat instances of the interface as having all the optional methods of the original NSTokenFieldDelegate protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class NSTokenFieldDelegate_Extensions {
		/// <param name="tokenField">To be added.</param><param name="substring">To be added.</param><param name="tokenIndex">To be added.</param><param name="selectedIndex">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string[] GetCompletionStrings (this INSTokenFieldDelegate This, NSTokenField tokenField, string substring, nint tokenIndex, nint selectedIndex)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var tokenField__handle__ = tokenField!.GetNonNullHandle (nameof (tokenField));
			if (substring is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (substring));
			var nssubstring = CFString.CreateNative (substring);
			string[]? ret;
			ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("tokenField:completionsForSubstring:indexOfToken:indexOfSelectedItem:"), tokenField__handle__, nssubstring, tokenIndex, selectedIndex), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tokenField);
			CFString.ReleaseNative (nssubstring);
			return ret!;
		}
		/// <param name="tokenField">To be added.</param><param name="tokens">To be added.</param><param name="index">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSArray ShouldAddObjects (this INSTokenFieldDelegate This, NSTokenField tokenField, NSArray tokens, nuint index)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var tokenField__handle__ = tokenField!.GetNonNullHandle (nameof (tokenField));
			var tokens__handle__ = tokens!.GetNonNullHandle (nameof (tokens));
			NSArray? ret;
			ret =  Runtime.GetNSObject<NSArray> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_UIntPtr (This.Handle, Selector.GetHandle ("tokenField:shouldAddObjects:atIndex:"), tokenField__handle__, tokens__handle__, index), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tokenField);
			GC.KeepAlive (tokens);
			return ret!;
		}
		/// <param name="tokenField">To be added.</param><param name="representedObject">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string GetDisplayString (this INSTokenFieldDelegate This, NSTokenField tokenField, NSObject representedObject)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var tokenField__handle__ = tokenField!.GetNonNullHandle (nameof (tokenField));
			var representedObject__handle__ = representedObject!.GetNonNullHandle (nameof (representedObject));
			string? ret;
			ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("tokenField:displayStringForRepresentedObject:"), tokenField__handle__, representedObject__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tokenField);
			GC.KeepAlive (representedObject);
			return ret!;
		}
		/// <param name="tokenField">To be added.</param><param name="representedObject">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string GetEditingString (this INSTokenFieldDelegate This, NSTokenField tokenField, NSObject representedObject)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var tokenField__handle__ = tokenField!.GetNonNullHandle (nameof (tokenField));
			var representedObject__handle__ = representedObject!.GetNonNullHandle (nameof (representedObject));
			string? ret;
			ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("tokenField:editingStringForRepresentedObject:"), tokenField__handle__, representedObject__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tokenField);
			GC.KeepAlive (representedObject);
			return ret!;
		}
		/// <param name="tokenField">To be added.</param><param name="editingString">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSObject? GetRepresentedObject (this INSTokenFieldDelegate This, NSTokenField tokenField, string editingString)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var tokenField__handle__ = tokenField!.GetNonNullHandle (nameof (tokenField));
			if (editingString is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (editingString));
			var nseditingString = CFString.CreateNative (editingString);
			NSObject? ret;
			ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("tokenField:representedObjectForEditingString:"), tokenField__handle__, nseditingString), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tokenField);
			CFString.ReleaseNative (nseditingString);
			return ret!;
		}
		/// <param name="tokenField">To be added.</param><param name="objects">To be added.</param><param name="pboard">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool WriteRepresented (this INSTokenFieldDelegate This, NSTokenField tokenField, NSArray objects, NSPasteboard pboard)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var tokenField__handle__ = tokenField!.GetNonNullHandle (nameof (tokenField));
			var objects__handle__ = objects!.GetNonNullHandle (nameof (objects));
			var pboard__handle__ = pboard!.GetNonNullHandle (nameof (pboard));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("tokenField:writeRepresentedObjects:toPasteboard:"), tokenField__handle__, objects__handle__, pboard__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (tokenField);
			GC.KeepAlive (objects);
			GC.KeepAlive (pboard);
			return ret != 0;
		}
		/// <param name="tokenField">To be added.</param><param name="pboard">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSObject[] Read (this INSTokenFieldDelegate This, NSTokenField tokenField, NSPasteboard pboard)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var tokenField__handle__ = tokenField!.GetNonNullHandle (nameof (tokenField));
			var pboard__handle__ = pboard!.GetNonNullHandle (nameof (pboard));
			NSObject[]? ret;
			ret = CFArray.ArrayFromHandle<NSObject>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("tokenField:readFromPasteboard:"), tokenField__handle__, pboard__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tokenField);
			GC.KeepAlive (pboard);
			return ret!;
		}
		/// <param name="tokenField">To be added.</param><param name="representedObject">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSMenu GetMenu (this INSTokenFieldDelegate This, NSTokenField tokenField, NSObject representedObject)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var tokenField__handle__ = tokenField!.GetNonNullHandle (nameof (tokenField));
			var representedObject__handle__ = representedObject!.GetNonNullHandle (nameof (representedObject));
			NSMenu? ret;
			ret =  Runtime.GetNSObject<NSMenu> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("tokenField:menuForRepresentedObject:"), tokenField__handle__, representedObject__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tokenField);
			GC.KeepAlive (representedObject);
			return ret!;
		}
		/// <param name="tokenField">To be added.</param><param name="representedObject">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool HasMenu (this INSTokenFieldDelegate This, NSTokenField tokenField, NSObject representedObject)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var tokenField__handle__ = tokenField!.GetNonNullHandle (nameof (tokenField));
			var representedObject__handle__ = representedObject!.GetNonNullHandle (nameof (representedObject));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("tokenField:hasMenuForRepresentedObject:"), tokenField__handle__, representedObject__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (tokenField);
			GC.KeepAlive (representedObject);
			return ret != 0;
		}
		/// <param name="tokenField">To be added.</param><param name="representedObject">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSTokenStyle GetStyle (this INSTokenFieldDelegate This, NSTokenField tokenField, NSObject representedObject)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var tokenField__handle__ = tokenField!.GetNonNullHandle (nameof (tokenField));
			var representedObject__handle__ = representedObject!.GetNonNullHandle (nameof (representedObject));
			NSTokenStyle ret;
			ret = (NSTokenStyle) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("tokenField:styleForRepresentedObject:"), tokenField__handle__, representedObject__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (tokenField);
			GC.KeepAlive (representedObject);
			return ret!;
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class NSTokenFieldDelegateWrapper : BaseWrapper, INSTokenFieldDelegate {
		public NSTokenFieldDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSTokenFieldDelegateWrapper))]
		static NSTokenFieldDelegateWrapper ()
		{
			GC.KeepAlive (null);
		}
	}
}
namespace AppKit {
	/// <summary>
	///   <para>This is a class that implements the interface <see cref="INSTokenFieldDelegate" /> (for the protocol <c>NSTokenFieldDelegate</c>).</para>
	///   <para>Subclass this class to easily create a type that implements the protocol.</para>
	///   <para>An alternative is to create a subclass of <see cref="NSObject" /> and then implemented the interface <see cref="INSTokenFieldDelegate" />.</para>
	/// </summary>
	[Protocol()]
	[Register("Microsoft_macOS__AppKit_NSTokenFieldDelegate", false)]
	[Model]
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	public unsafe partial class NSTokenFieldDelegate : NSObject, INSTokenFieldDelegate {
		/// <summary>Creates a new <see cref="NSTokenFieldDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public NSTokenFieldDelegate () : base (NSObjectFlag.Empty)
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
		protected NSTokenFieldDelegate (NSObjectFlag t) : base (t)
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
		protected internal NSTokenFieldDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		/// <param name="tokenField">To be added.</param><param name="substring">To be added.</param><param name="tokenIndex">To be added.</param><param name="selectedIndex">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("tokenField:completionsForSubstring:indexOfToken:indexOfSelectedItem:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string[] GetCompletionStrings (NSTokenField tokenField, string substring, nint tokenIndex, nint selectedIndex)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="tokenField">To be added.</param><param name="representedObject">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("tokenField:displayStringForRepresentedObject:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string GetDisplayString (NSTokenField tokenField, NSObject representedObject)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="tokenField">To be added.</param><param name="representedObject">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("tokenField:editingStringForRepresentedObject:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string GetEditingString (NSTokenField tokenField, NSObject representedObject)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="tokenField">To be added.</param><param name="representedObject">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("tokenField:menuForRepresentedObject:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSMenu GetMenu (NSTokenField tokenField, NSObject representedObject)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="tokenField">To be added.</param><param name="editingString">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("tokenField:representedObjectForEditingString:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject? GetRepresentedObject (NSTokenField tokenField, string editingString)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="tokenField">To be added.</param><param name="representedObject">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("tokenField:styleForRepresentedObject:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSTokenStyle GetStyle (NSTokenField tokenField, NSObject representedObject)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="tokenField">To be added.</param><param name="representedObject">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("tokenField:hasMenuForRepresentedObject:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool HasMenu (NSTokenField tokenField, NSObject representedObject)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="tokenField">To be added.</param><param name="pboard">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("tokenField:readFromPasteboard:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject[] Read (NSTokenField tokenField, NSPasteboard pboard)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="tokenField">To be added.</param><param name="tokens">To be added.</param><param name="index">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("tokenField:shouldAddObjects:atIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSArray ShouldAddObjects (NSTokenField tokenField, NSArray tokens, nuint index)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="tokenField">To be added.</param><param name="objects">To be added.</param><param name="pboard">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("tokenField:writeRepresentedObjects:toPasteboard:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool WriteRepresented (NSTokenField tokenField, NSArray objects, NSPasteboard pboard)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class NSTokenFieldDelegate */
}
