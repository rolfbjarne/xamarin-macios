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
	/// <summary>This interface represents the Objective-C protocol <c>NSTokenFieldCellDelegate</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[Protocol (Name = "NSTokenFieldCellDelegate", WrapperType = typeof (NSTokenFieldCellDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetCompletionStrings", Selector = "tokenFieldCell:completionsForSubstring:indexOfToken:indexOfSelectedItem:", ReturnType = typeof (NSArray), ParameterType = new Type [] { typeof (NSTokenFieldCell), typeof (string), typeof (IntPtr), typeof (IntPtr) }, ParameterByRef = new bool [] { false, false, false, true })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldAddObjects", Selector = "tokenFieldCell:shouldAddObjects:atIndex:", ReturnType = typeof (NSArray), ParameterType = new Type [] { typeof (NSTokenFieldCell), typeof (NSObject[]), typeof (UIntPtr) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetDisplayString", Selector = "tokenFieldCell:displayStringForRepresentedObject:", ReturnType = typeof (string), ParameterType = new Type [] { typeof (NSTokenFieldCell), typeof (NSObject) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetEditingString", Selector = "tokenFieldCell:editingStringForRepresentedObject:", ReturnType = typeof (string), ParameterType = new Type [] { typeof (NSTokenFieldCell), typeof (NSObject) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetRepresentedObject", Selector = "tokenFieldCell:representedObjectForEditingString:", ReturnType = typeof (NSObject), ParameterType = new Type [] { typeof (NSTokenFieldCell), typeof (string) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WriteRepresentedObjects", Selector = "tokenFieldCell:writeRepresentedObjects:toPasteboard:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (NSTokenFieldCell), typeof (NSObject[]), typeof (NSPasteboard) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "Read", Selector = "tokenFieldCell:readFromPasteboard:", ReturnType = typeof (NSObject[]), ParameterType = new Type [] { typeof (NSTokenFieldCell), typeof (NSPasteboard) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetMenu", Selector = "tokenFieldCell:menuForRepresentedObject:", ReturnType = typeof (NSMenu), ParameterType = new Type [] { typeof (NSTokenFieldCell), typeof (NSObject) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "HasMenu", Selector = "tokenFieldCell:hasMenuForRepresentedObject:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (NSTokenFieldCell), typeof (NSObject) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetStyle", Selector = "tokenFieldCell:styleForRepresentedObject:", ReturnType = typeof (NSTokenStyle), ParameterType = new Type [] { typeof (NSTokenFieldCell), typeof (NSObject) }, ParameterByRef = new bool [] { false, false })]
	public partial interface INSTokenFieldCellDelegate : INativeObject, IDisposable
	{
		/// <param name="tokenFieldCell">To be added.</param><param name="substring">To be added.</param><param name="tokenIndex">To be added.</param><param name="selectedIndex">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("tokenFieldCell:completionsForSubstring:indexOfToken:indexOfSelectedItem:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual NSArray GetCompletionStrings (NSTokenFieldCell tokenFieldCell, string substring, nint tokenIndex, ref nint selectedIndex)
		{
			return _GetCompletionStrings (this, tokenFieldCell, substring, tokenIndex, ref selectedIndex);
		}
		/// <param name="tokenFieldCell">To be added.</param><param name="substring">To be added.</param><param name="tokenIndex">To be added.</param><param name="selectedIndex">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static NSArray _GetCompletionStrings (INSTokenFieldCellDelegate This, NSTokenFieldCell tokenFieldCell, string substring, nint tokenIndex, ref nint selectedIndex)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var tokenFieldCell__handle__ = tokenFieldCell!.GetNonNullHandle (nameof (tokenFieldCell));
			if (substring is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (substring));
			fixed (nint* selectedIndex__pointer = &selectedIndex) {
			var nssubstring = CFString.CreateNative (substring);
			NSArray? ret;
			ret =  Runtime.GetNSObject<NSArray> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_IntPtr_ref_IntPtr (This.Handle, Selector.GetHandle ("tokenFieldCell:completionsForSubstring:indexOfToken:indexOfSelectedItem:"), tokenFieldCell__handle__, nssubstring, tokenIndex, selectedIndex__pointer), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tokenFieldCell);
			CFString.ReleaseNative (nssubstring);
			return ret!;
			}
		}
		/// <param name="tokenFieldCell">To be added.</param><param name="tokens">To be added.</param><param name="index">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("tokenFieldCell:shouldAddObjects:atIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSArray ShouldAddObjects (NSTokenFieldCell tokenFieldCell, NSObject[] tokens, nuint index)
		{
			return _ShouldAddObjects (this, tokenFieldCell, tokens, index);
		}
		/// <param name="tokenFieldCell">To be added.</param><param name="tokens">To be added.</param><param name="index">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSArray _ShouldAddObjects (INSTokenFieldCellDelegate This, NSTokenFieldCell tokenFieldCell, NSObject[] tokens, nuint index)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var tokenFieldCell__handle__ = tokenFieldCell!.GetNonNullHandle (nameof (tokenFieldCell));
			if (tokens is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (tokens));
			using var nsa_tokens = NSArray.FromNSObjects (tokens);
			NSArray? ret;
			ret =  Runtime.GetNSObject<NSArray> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_UIntPtr (This.Handle, Selector.GetHandle ("tokenFieldCell:shouldAddObjects:atIndex:"), tokenFieldCell__handle__, nsa_tokens.Handle, index), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tokenFieldCell);
			return ret!;
		}
		/// <param name="tokenFieldCell">To be added.</param><param name="representedObject">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("tokenFieldCell:displayStringForRepresentedObject:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string GetDisplayString (NSTokenFieldCell tokenFieldCell, NSObject representedObject)
		{
			return _GetDisplayString (this, tokenFieldCell, representedObject);
		}
		/// <param name="tokenFieldCell">To be added.</param><param name="representedObject">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static string _GetDisplayString (INSTokenFieldCellDelegate This, NSTokenFieldCell tokenFieldCell, NSObject representedObject)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var tokenFieldCell__handle__ = tokenFieldCell!.GetNonNullHandle (nameof (tokenFieldCell));
			var representedObject__handle__ = representedObject!.GetNonNullHandle (nameof (representedObject));
			string? ret;
			ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("tokenFieldCell:displayStringForRepresentedObject:"), tokenFieldCell__handle__, representedObject__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tokenFieldCell);
			GC.KeepAlive (representedObject);
			return ret!;
		}
		/// <param name="tokenFieldCell">To be added.</param><param name="representedObject">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("tokenFieldCell:editingStringForRepresentedObject:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string GetEditingString (NSTokenFieldCell tokenFieldCell, NSObject representedObject)
		{
			return _GetEditingString (this, tokenFieldCell, representedObject);
		}
		/// <param name="tokenFieldCell">To be added.</param><param name="representedObject">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static string _GetEditingString (INSTokenFieldCellDelegate This, NSTokenFieldCell tokenFieldCell, NSObject representedObject)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var tokenFieldCell__handle__ = tokenFieldCell!.GetNonNullHandle (nameof (tokenFieldCell));
			var representedObject__handle__ = representedObject!.GetNonNullHandle (nameof (representedObject));
			string? ret;
			ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("tokenFieldCell:editingStringForRepresentedObject:"), tokenFieldCell__handle__, representedObject__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tokenFieldCell);
			GC.KeepAlive (representedObject);
			return ret!;
		}
		/// <param name="tokenFieldCell">To be added.</param><param name="editingString">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("tokenFieldCell:representedObjectForEditingString:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject? GetRepresentedObject (NSTokenFieldCell tokenFieldCell, string editingString)
		{
			return _GetRepresentedObject (this, tokenFieldCell, editingString);
		}
		/// <param name="tokenFieldCell">To be added.</param><param name="editingString">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSObject? _GetRepresentedObject (INSTokenFieldCellDelegate This, NSTokenFieldCell tokenFieldCell, string editingString)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var tokenFieldCell__handle__ = tokenFieldCell!.GetNonNullHandle (nameof (tokenFieldCell));
			if (editingString is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (editingString));
			var nseditingString = CFString.CreateNative (editingString);
			NSObject? ret;
			ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("tokenFieldCell:representedObjectForEditingString:"), tokenFieldCell__handle__, nseditingString), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tokenFieldCell);
			CFString.ReleaseNative (nseditingString);
			return ret!;
		}
		/// <param name="tokenFieldCell">To be added.</param><param name="objects">To be added.</param><param name="pboard">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("tokenFieldCell:writeRepresentedObjects:toPasteboard:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool WriteRepresentedObjects (NSTokenFieldCell tokenFieldCell, NSObject[] objects, NSPasteboard pboard)
		{
			return _WriteRepresentedObjects (this, tokenFieldCell, objects, pboard);
		}
		/// <param name="tokenFieldCell">To be added.</param><param name="objects">To be added.</param><param name="pboard">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _WriteRepresentedObjects (INSTokenFieldCellDelegate This, NSTokenFieldCell tokenFieldCell, NSObject[] objects, NSPasteboard pboard)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var tokenFieldCell__handle__ = tokenFieldCell!.GetNonNullHandle (nameof (tokenFieldCell));
			if (objects is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (objects));
			var pboard__handle__ = pboard!.GetNonNullHandle (nameof (pboard));
			using var nsa_objects = NSArray.FromNSObjects (objects);
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("tokenFieldCell:writeRepresentedObjects:toPasteboard:"), tokenFieldCell__handle__, nsa_objects.Handle, pboard__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (tokenFieldCell);
			GC.KeepAlive (pboard);
			return ret != 0;
		}
		/// <param name="tokenFieldCell">To be added.</param><param name="pboard">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("tokenFieldCell:readFromPasteboard:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject[] Read (NSTokenFieldCell tokenFieldCell, NSPasteboard pboard)
		{
			return _Read (this, tokenFieldCell, pboard);
		}
		/// <param name="tokenFieldCell">To be added.</param><param name="pboard">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSObject[] _Read (INSTokenFieldCellDelegate This, NSTokenFieldCell tokenFieldCell, NSPasteboard pboard)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var tokenFieldCell__handle__ = tokenFieldCell!.GetNonNullHandle (nameof (tokenFieldCell));
			var pboard__handle__ = pboard!.GetNonNullHandle (nameof (pboard));
			NSObject[]? ret;
			ret = CFArray.ArrayFromHandle<NSObject>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("tokenFieldCell:readFromPasteboard:"), tokenFieldCell__handle__, pboard__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tokenFieldCell);
			GC.KeepAlive (pboard);
			return ret!;
		}
		/// <param name="tokenFieldCell">To be added.</param><param name="representedObject">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("tokenFieldCell:menuForRepresentedObject:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSMenu GetMenu (NSTokenFieldCell tokenFieldCell, NSObject representedObject)
		{
			return _GetMenu (this, tokenFieldCell, representedObject);
		}
		/// <param name="tokenFieldCell">To be added.</param><param name="representedObject">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSMenu _GetMenu (INSTokenFieldCellDelegate This, NSTokenFieldCell tokenFieldCell, NSObject representedObject)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var tokenFieldCell__handle__ = tokenFieldCell!.GetNonNullHandle (nameof (tokenFieldCell));
			var representedObject__handle__ = representedObject!.GetNonNullHandle (nameof (representedObject));
			NSMenu? ret;
			ret =  Runtime.GetNSObject<NSMenu> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("tokenFieldCell:menuForRepresentedObject:"), tokenFieldCell__handle__, representedObject__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tokenFieldCell);
			GC.KeepAlive (representedObject);
			return ret!;
		}
		/// <param name="tokenFieldCell">To be added.</param><param name="representedObject">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("tokenFieldCell:hasMenuForRepresentedObject:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool HasMenu (NSTokenFieldCell tokenFieldCell, NSObject representedObject)
		{
			return _HasMenu (this, tokenFieldCell, representedObject);
		}
		/// <param name="tokenFieldCell">To be added.</param><param name="representedObject">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _HasMenu (INSTokenFieldCellDelegate This, NSTokenFieldCell tokenFieldCell, NSObject representedObject)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var tokenFieldCell__handle__ = tokenFieldCell!.GetNonNullHandle (nameof (tokenFieldCell));
			var representedObject__handle__ = representedObject!.GetNonNullHandle (nameof (representedObject));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("tokenFieldCell:hasMenuForRepresentedObject:"), tokenFieldCell__handle__, representedObject__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (tokenFieldCell);
			GC.KeepAlive (representedObject);
			return ret != 0;
		}
		/// <param name="tokenFieldCell">To be added.</param><param name="representedObject">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("tokenFieldCell:styleForRepresentedObject:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSTokenStyle GetStyle (NSTokenFieldCell tokenFieldCell, NSObject representedObject)
		{
			return _GetStyle (this, tokenFieldCell, representedObject);
		}
		/// <param name="tokenFieldCell">To be added.</param><param name="representedObject">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSTokenStyle _GetStyle (INSTokenFieldCellDelegate This, NSTokenFieldCell tokenFieldCell, NSObject representedObject)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var tokenFieldCell__handle__ = tokenFieldCell!.GetNonNullHandle (nameof (tokenFieldCell));
			var representedObject__handle__ = representedObject!.GetNonNullHandle (nameof (representedObject));
			NSTokenStyle ret;
			ret = (NSTokenStyle) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("tokenFieldCell:styleForRepresentedObject:"), tokenFieldCell__handle__, representedObject__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (tokenFieldCell);
			GC.KeepAlive (representedObject);
			return ret!;
		}
		[DynamicDependencyAttribute ("GetCompletionStrings(AppKit.NSTokenFieldCell,System.String,System.IntPtr,System.IntPtr@)")]
		[DynamicDependencyAttribute ("GetDisplayString(AppKit.NSTokenFieldCell,Foundation.NSObject)")]
		[DynamicDependencyAttribute ("GetEditingString(AppKit.NSTokenFieldCell,Foundation.NSObject)")]
		[DynamicDependencyAttribute ("GetMenu(AppKit.NSTokenFieldCell,Foundation.NSObject)")]
		[DynamicDependencyAttribute ("GetRepresentedObject(AppKit.NSTokenFieldCell,System.String)")]
		[DynamicDependencyAttribute ("GetStyle(AppKit.NSTokenFieldCell,Foundation.NSObject)")]
		[DynamicDependencyAttribute ("HasMenu(AppKit.NSTokenFieldCell,Foundation.NSObject)")]
		[DynamicDependencyAttribute ("Read(AppKit.NSTokenFieldCell,AppKit.NSPasteboard)")]
		[DynamicDependencyAttribute ("ShouldAddObjects(AppKit.NSTokenFieldCell,Foundation.NSObject[],System.UIntPtr)")]
		[DynamicDependencyAttribute ("WriteRepresentedObjects(AppKit.NSTokenFieldCell,Foundation.NSObject[],AppKit.NSPasteboard)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSTokenFieldCellDelegateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static INSTokenFieldCellDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="INSTokenFieldCellDelegate" /> interface to support all the methods from the NSTokenFieldCellDelegate protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="INSTokenFieldCellDelegate" /> interface allow developers to treat instances of the interface as having all the optional methods of the original NSTokenFieldCellDelegate protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class NSTokenFieldCellDelegate_Extensions {
		/// <param name="tokenFieldCell">To be added.</param><param name="substring">To be added.</param><param name="tokenIndex">To be added.</param><param name="selectedIndex">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static NSArray GetCompletionStrings (this INSTokenFieldCellDelegate This, NSTokenFieldCell tokenFieldCell, string substring, nint tokenIndex, ref nint selectedIndex)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var tokenFieldCell__handle__ = tokenFieldCell!.GetNonNullHandle (nameof (tokenFieldCell));
			if (substring is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (substring));
			fixed (nint* selectedIndex__pointer = &selectedIndex) {
			var nssubstring = CFString.CreateNative (substring);
			NSArray? ret;
			ret =  Runtime.GetNSObject<NSArray> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_IntPtr_ref_IntPtr (This.Handle, Selector.GetHandle ("tokenFieldCell:completionsForSubstring:indexOfToken:indexOfSelectedItem:"), tokenFieldCell__handle__, nssubstring, tokenIndex, selectedIndex__pointer), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tokenFieldCell);
			CFString.ReleaseNative (nssubstring);
			return ret!;
			}
		}
		/// <param name="tokenFieldCell">To be added.</param><param name="tokens">To be added.</param><param name="index">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSArray ShouldAddObjects (this INSTokenFieldCellDelegate This, NSTokenFieldCell tokenFieldCell, NSObject[] tokens, nuint index)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var tokenFieldCell__handle__ = tokenFieldCell!.GetNonNullHandle (nameof (tokenFieldCell));
			if (tokens is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (tokens));
			using var nsa_tokens = NSArray.FromNSObjects (tokens);
			NSArray? ret;
			ret =  Runtime.GetNSObject<NSArray> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_UIntPtr (This.Handle, Selector.GetHandle ("tokenFieldCell:shouldAddObjects:atIndex:"), tokenFieldCell__handle__, nsa_tokens.Handle, index), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tokenFieldCell);
			return ret!;
		}
		/// <param name="tokenFieldCell">To be added.</param><param name="representedObject">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string GetDisplayString (this INSTokenFieldCellDelegate This, NSTokenFieldCell tokenFieldCell, NSObject representedObject)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var tokenFieldCell__handle__ = tokenFieldCell!.GetNonNullHandle (nameof (tokenFieldCell));
			var representedObject__handle__ = representedObject!.GetNonNullHandle (nameof (representedObject));
			string? ret;
			ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("tokenFieldCell:displayStringForRepresentedObject:"), tokenFieldCell__handle__, representedObject__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tokenFieldCell);
			GC.KeepAlive (representedObject);
			return ret!;
		}
		/// <param name="tokenFieldCell">To be added.</param><param name="representedObject">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string GetEditingString (this INSTokenFieldCellDelegate This, NSTokenFieldCell tokenFieldCell, NSObject representedObject)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var tokenFieldCell__handle__ = tokenFieldCell!.GetNonNullHandle (nameof (tokenFieldCell));
			var representedObject__handle__ = representedObject!.GetNonNullHandle (nameof (representedObject));
			string? ret;
			ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("tokenFieldCell:editingStringForRepresentedObject:"), tokenFieldCell__handle__, representedObject__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tokenFieldCell);
			GC.KeepAlive (representedObject);
			return ret!;
		}
		/// <param name="tokenFieldCell">To be added.</param><param name="editingString">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSObject? GetRepresentedObject (this INSTokenFieldCellDelegate This, NSTokenFieldCell tokenFieldCell, string editingString)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var tokenFieldCell__handle__ = tokenFieldCell!.GetNonNullHandle (nameof (tokenFieldCell));
			if (editingString is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (editingString));
			var nseditingString = CFString.CreateNative (editingString);
			NSObject? ret;
			ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("tokenFieldCell:representedObjectForEditingString:"), tokenFieldCell__handle__, nseditingString), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tokenFieldCell);
			CFString.ReleaseNative (nseditingString);
			return ret!;
		}
		/// <param name="tokenFieldCell">To be added.</param><param name="objects">To be added.</param><param name="pboard">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool WriteRepresentedObjects (this INSTokenFieldCellDelegate This, NSTokenFieldCell tokenFieldCell, NSObject[] objects, NSPasteboard pboard)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var tokenFieldCell__handle__ = tokenFieldCell!.GetNonNullHandle (nameof (tokenFieldCell));
			if (objects is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (objects));
			var pboard__handle__ = pboard!.GetNonNullHandle (nameof (pboard));
			using var nsa_objects = NSArray.FromNSObjects (objects);
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("tokenFieldCell:writeRepresentedObjects:toPasteboard:"), tokenFieldCell__handle__, nsa_objects.Handle, pboard__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (tokenFieldCell);
			GC.KeepAlive (pboard);
			return ret != 0;
		}
		/// <param name="tokenFieldCell">To be added.</param><param name="pboard">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSObject[] Read (this INSTokenFieldCellDelegate This, NSTokenFieldCell tokenFieldCell, NSPasteboard pboard)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var tokenFieldCell__handle__ = tokenFieldCell!.GetNonNullHandle (nameof (tokenFieldCell));
			var pboard__handle__ = pboard!.GetNonNullHandle (nameof (pboard));
			NSObject[]? ret;
			ret = CFArray.ArrayFromHandle<NSObject>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("tokenFieldCell:readFromPasteboard:"), tokenFieldCell__handle__, pboard__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tokenFieldCell);
			GC.KeepAlive (pboard);
			return ret!;
		}
		/// <param name="tokenFieldCell">To be added.</param><param name="representedObject">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSMenu GetMenu (this INSTokenFieldCellDelegate This, NSTokenFieldCell tokenFieldCell, NSObject representedObject)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var tokenFieldCell__handle__ = tokenFieldCell!.GetNonNullHandle (nameof (tokenFieldCell));
			var representedObject__handle__ = representedObject!.GetNonNullHandle (nameof (representedObject));
			NSMenu? ret;
			ret =  Runtime.GetNSObject<NSMenu> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("tokenFieldCell:menuForRepresentedObject:"), tokenFieldCell__handle__, representedObject__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tokenFieldCell);
			GC.KeepAlive (representedObject);
			return ret!;
		}
		/// <param name="tokenFieldCell">To be added.</param><param name="representedObject">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool HasMenu (this INSTokenFieldCellDelegate This, NSTokenFieldCell tokenFieldCell, NSObject representedObject)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var tokenFieldCell__handle__ = tokenFieldCell!.GetNonNullHandle (nameof (tokenFieldCell));
			var representedObject__handle__ = representedObject!.GetNonNullHandle (nameof (representedObject));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("tokenFieldCell:hasMenuForRepresentedObject:"), tokenFieldCell__handle__, representedObject__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (tokenFieldCell);
			GC.KeepAlive (representedObject);
			return ret != 0;
		}
		/// <param name="tokenFieldCell">To be added.</param><param name="representedObject">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSTokenStyle GetStyle (this INSTokenFieldCellDelegate This, NSTokenFieldCell tokenFieldCell, NSObject representedObject)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var tokenFieldCell__handle__ = tokenFieldCell!.GetNonNullHandle (nameof (tokenFieldCell));
			var representedObject__handle__ = representedObject!.GetNonNullHandle (nameof (representedObject));
			NSTokenStyle ret;
			ret = (NSTokenStyle) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("tokenFieldCell:styleForRepresentedObject:"), tokenFieldCell__handle__, representedObject__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (tokenFieldCell);
			GC.KeepAlive (representedObject);
			return ret!;
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class NSTokenFieldCellDelegateWrapper : BaseWrapper, INSTokenFieldCellDelegate {
		public NSTokenFieldCellDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSTokenFieldCellDelegateWrapper))]
		static NSTokenFieldCellDelegateWrapper ()
		{
			GC.KeepAlive (null);
		}
	}
}
namespace AppKit {
	/// <summary>
	///   <para>This is a class that implements the interface <see cref="INSTokenFieldCellDelegate" /> (for the protocol <c>NSTokenFieldCellDelegate</c>).</para>
	///   <para>Subclass this class to easily create a type that implements the protocol.</para>
	///   <para>An alternative is to create a subclass of <see cref="NSObject" /> and then implemented the interface <see cref="INSTokenFieldCellDelegate" />.</para>
	/// </summary>
	[Protocol()]
	[Register("Microsoft_macOS__AppKit_NSTokenFieldCellDelegate", false)]
	[Model]
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	public unsafe partial class NSTokenFieldCellDelegate : NSObject, INSTokenFieldCellDelegate {
		/// <summary>Creates a new <see cref="NSTokenFieldCellDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public NSTokenFieldCellDelegate () : base (NSObjectFlag.Empty)
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
		protected NSTokenFieldCellDelegate (NSObjectFlag t) : base (t)
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
		protected internal NSTokenFieldCellDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		/// <param name="tokenFieldCell">To be added.</param><param name="substring">To be added.</param><param name="tokenIndex">To be added.</param><param name="selectedIndex">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("tokenFieldCell:completionsForSubstring:indexOfToken:indexOfSelectedItem:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual NSArray GetCompletionStrings (NSTokenFieldCell tokenFieldCell, string substring, nint tokenIndex, ref nint selectedIndex)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="tokenFieldCell">To be added.</param><param name="representedObject">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("tokenFieldCell:displayStringForRepresentedObject:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string GetDisplayString (NSTokenFieldCell tokenFieldCell, NSObject representedObject)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="tokenFieldCell">To be added.</param><param name="representedObject">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("tokenFieldCell:editingStringForRepresentedObject:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string GetEditingString (NSTokenFieldCell tokenFieldCell, NSObject representedObject)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="tokenFieldCell">To be added.</param><param name="representedObject">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("tokenFieldCell:menuForRepresentedObject:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSMenu GetMenu (NSTokenFieldCell tokenFieldCell, NSObject representedObject)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="tokenFieldCell">To be added.</param><param name="editingString">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("tokenFieldCell:representedObjectForEditingString:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject? GetRepresentedObject (NSTokenFieldCell tokenFieldCell, string editingString)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="tokenFieldCell">To be added.</param><param name="representedObject">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("tokenFieldCell:styleForRepresentedObject:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSTokenStyle GetStyle (NSTokenFieldCell tokenFieldCell, NSObject representedObject)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="tokenFieldCell">To be added.</param><param name="representedObject">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("tokenFieldCell:hasMenuForRepresentedObject:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool HasMenu (NSTokenFieldCell tokenFieldCell, NSObject representedObject)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="tokenFieldCell">To be added.</param><param name="pboard">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("tokenFieldCell:readFromPasteboard:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject[] Read (NSTokenFieldCell tokenFieldCell, NSPasteboard pboard)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="tokenFieldCell">To be added.</param><param name="tokens">To be added.</param><param name="index">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("tokenFieldCell:shouldAddObjects:atIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSArray ShouldAddObjects (NSTokenFieldCell tokenFieldCell, NSObject[] tokens, nuint index)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="tokenFieldCell">To be added.</param><param name="objects">To be added.</param><param name="pboard">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("tokenFieldCell:writeRepresentedObjects:toPasteboard:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool WriteRepresentedObjects (NSTokenFieldCell tokenFieldCell, NSObject[] objects, NSPasteboard pboard)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class NSTokenFieldCellDelegate */
}
