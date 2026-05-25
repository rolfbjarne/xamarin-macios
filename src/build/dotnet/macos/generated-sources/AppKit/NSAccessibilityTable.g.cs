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
	/// <summary>This interface represents the Objective-C protocol <c>NSAccessibilityTable</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[Protocol (Name = "NSAccessibilityTable", WrapperType = typeof (NSAccessibilityTableWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilityLabel", Selector = "accessibilityLabel", PropertyType = typeof (string), GetterSelector = "accessibilityLabel", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilityRows", Selector = "accessibilityRows", PropertyType = typeof (INSAccessibilityRow[]), GetterSelector = "accessibilityRows", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "AccessibilitySelectedRows", Selector = "accessibilitySelectedRows", PropertyType = typeof (INSAccessibilityRow[]), GetterSelector = "accessibilitySelectedRows", SetterSelector = "setAccessibilitySelectedRows:", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "AccessibilityVisibleRows", Selector = "accessibilityVisibleRows", PropertyType = typeof (INSAccessibilityRow[]), GetterSelector = "accessibilityVisibleRows", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "AccessibilityColumns", Selector = "accessibilityColumns", PropertyType = typeof (NSObject[]), GetterSelector = "accessibilityColumns", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "AccessibilityVisibleColumns", Selector = "accessibilityVisibleColumns", PropertyType = typeof (NSObject[]), GetterSelector = "accessibilityVisibleColumns", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "AccessibilitySelectedColumns", Selector = "accessibilitySelectedColumns", PropertyType = typeof (NSObject[]), GetterSelector = "accessibilitySelectedColumns", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "AccessibilityHeaderGroup", Selector = "accessibilityHeaderGroup", PropertyType = typeof (string), GetterSelector = "accessibilityHeaderGroup", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "AccessibilitySelectedCells", Selector = "accessibilitySelectedCells", PropertyType = typeof (NSObject[]), GetterSelector = "accessibilitySelectedCells", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "AccessibilityVisibleCells", Selector = "accessibilityVisibleCells", PropertyType = typeof (NSObject[]), GetterSelector = "accessibilityVisibleCells", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "AccessibilityRowHeaderUIElements", Selector = "accessibilityRowHeaderUIElements", PropertyType = typeof (NSObject[]), GetterSelector = "accessibilityRowHeaderUIElements", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "AccessibilityColumnHeaderUIElements", Selector = "accessibilityColumnHeaderUIElements", PropertyType = typeof (NSObject[]), GetterSelector = "accessibilityColumnHeaderUIElements", ArgumentSemantic = ArgumentSemantic.None)]
	public partial interface INSAccessibilityTable : INativeObject, IDisposable, 
		AppKit.INSAccessibilityElementProtocol
		, AppKit.INSAccessibilityGroup
	{
		[DynamicDependencyAttribute ("AccessibilityColumnHeaderUIElements")]
		[DynamicDependencyAttribute ("AccessibilityColumns")]
		[DynamicDependencyAttribute ("AccessibilityHeaderGroup")]
		[DynamicDependencyAttribute ("AccessibilityLabel")]
		[DynamicDependencyAttribute ("AccessibilityRowHeaderUIElements")]
		[DynamicDependencyAttribute ("AccessibilityRows")]
		[DynamicDependencyAttribute ("AccessibilitySelectedCells")]
		[DynamicDependencyAttribute ("AccessibilitySelectedColumns")]
		[DynamicDependencyAttribute ("AccessibilitySelectedRows")]
		[DynamicDependencyAttribute ("AccessibilityVisibleCells")]
		[DynamicDependencyAttribute ("AccessibilityVisibleColumns")]
		[DynamicDependencyAttribute ("AccessibilityVisibleRows")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSAccessibilityTableWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static INSAccessibilityTable ()
		{
			GC.KeepAlive (null);
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual string? AccessibilityLabel {
			[Export ("accessibilityLabel")]
			get {
				return _GetAccessibilityLabel (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static string _GetAccessibilityLabel (INSAccessibilityTable This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			string ret;
			ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("accessibilityLabel")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual INSAccessibilityRow[]? AccessibilityRows {
			[Export ("accessibilityRows")]
			get {
				return _GetAccessibilityRows (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static INSAccessibilityRow[] _GetAccessibilityRows (INSAccessibilityTable This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			INSAccessibilityRow[] ret;
			ret = CFArray.ArrayFromHandle<INSAccessibilityRow>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("accessibilityRows")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.OptionalMember]
		public virtual INSAccessibilityRow[]? AccessibilitySelectedRows {
			[Export ("accessibilitySelectedRows")]
			get {
				return _GetAccessibilitySelectedRows (this);
			}
			[Export ("setAccessibilitySelectedRows:")]
			set {
				_SetAccessibilitySelectedRows (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static INSAccessibilityRow[] _GetAccessibilitySelectedRows (INSAccessibilityTable This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			INSAccessibilityRow[] ret;
			ret = CFArray.ArrayFromHandle<INSAccessibilityRow>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("accessibilitySelectedRows")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetAccessibilitySelectedRows (INSAccessibilityTable This, INSAccessibilityRow[]? value)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			using var nsa_value = value is null ? null : NSArray.FromNSObjects (value);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setAccessibilitySelectedRows:"), nsa_value.GetHandle ());
			GC.KeepAlive (This);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.OptionalMember]
		public virtual INSAccessibilityRow[] AccessibilityVisibleRows {
			[Export ("accessibilityVisibleRows")]
			get {
				return _GetAccessibilityVisibleRows (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static INSAccessibilityRow[] _GetAccessibilityVisibleRows (INSAccessibilityTable This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			INSAccessibilityRow[] ret;
			ret = CFArray.ArrayFromHandle<INSAccessibilityRow>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("accessibilityVisibleRows")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.OptionalMember]
		public virtual NSObject[] AccessibilityColumns {
			[Export ("accessibilityColumns")]
			get {
				return _GetAccessibilityColumns (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSObject[] _GetAccessibilityColumns (INSAccessibilityTable This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSObject[] ret;
			ret = CFArray.ArrayFromHandle<NSObject>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("accessibilityColumns")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.OptionalMember]
		public virtual NSObject[] AccessibilityVisibleColumns {
			[Export ("accessibilityVisibleColumns")]
			get {
				return _GetAccessibilityVisibleColumns (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSObject[] _GetAccessibilityVisibleColumns (INSAccessibilityTable This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSObject[] ret;
			ret = CFArray.ArrayFromHandle<NSObject>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("accessibilityVisibleColumns")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.OptionalMember]
		public virtual NSObject[] AccessibilitySelectedColumns {
			[Export ("accessibilitySelectedColumns")]
			get {
				return _GetAccessibilitySelectedColumns (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSObject[] _GetAccessibilitySelectedColumns (INSAccessibilityTable This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSObject[] ret;
			ret = CFArray.ArrayFromHandle<NSObject>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("accessibilitySelectedColumns")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[ObsoletedOSPlatform ("macos10.14", "Use 'AccessibilityHeader' instead.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[global::Foundation.OptionalMember]
		public virtual string AccessibilityHeaderGroup {
			[Export ("accessibilityHeaderGroup")]
			get {
				return _GetAccessibilityHeaderGroup (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static string _GetAccessibilityHeaderGroup (INSAccessibilityTable This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			string ret;
			ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("accessibilityHeaderGroup")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.OptionalMember]
		public virtual NSObject[] AccessibilitySelectedCells {
			[Export ("accessibilitySelectedCells")]
			get {
				return _GetAccessibilitySelectedCells (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSObject[] _GetAccessibilitySelectedCells (INSAccessibilityTable This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSObject[] ret;
			ret = CFArray.ArrayFromHandle<NSObject>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("accessibilitySelectedCells")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.OptionalMember]
		public virtual NSObject[] AccessibilityVisibleCells {
			[Export ("accessibilityVisibleCells")]
			get {
				return _GetAccessibilityVisibleCells (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSObject[] _GetAccessibilityVisibleCells (INSAccessibilityTable This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSObject[] ret;
			ret = CFArray.ArrayFromHandle<NSObject>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("accessibilityVisibleCells")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.OptionalMember]
		public virtual NSObject[] AccessibilityRowHeaderUIElements {
			[Export ("accessibilityRowHeaderUIElements")]
			get {
				return _GetAccessibilityRowHeaderUIElements (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSObject[] _GetAccessibilityRowHeaderUIElements (INSAccessibilityTable This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSObject[] ret;
			ret = CFArray.ArrayFromHandle<NSObject>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("accessibilityRowHeaderUIElements")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.OptionalMember]
		public virtual NSObject[] AccessibilityColumnHeaderUIElements {
			[Export ("accessibilityColumnHeaderUIElements")]
			get {
				return _GetAccessibilityColumnHeaderUIElements (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSObject[] _GetAccessibilityColumnHeaderUIElements (INSAccessibilityTable This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSObject[] ret;
			ret = CFArray.ArrayFromHandle<NSObject>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("accessibilityColumnHeaderUIElements")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="INSAccessibilityTable" /> interface to support all the methods from the NSAccessibilityTable protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="INSAccessibilityTable" /> interface allow developers to treat instances of the interface as having all the optional methods of the original NSAccessibilityTable protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class NSAccessibilityTable_Extensions {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static INSAccessibilityRow[] GetAccessibilitySelectedRows (this INSAccessibilityTable This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			INSAccessibilityRow[] ret;
			ret = CFArray.ArrayFromHandle<INSAccessibilityRow>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("accessibilitySelectedRows")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetAccessibilitySelectedRows (this INSAccessibilityTable This, INSAccessibilityRow[]? value)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			using var nsa_value = value is null ? null : NSArray.FromNSObjects (value);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setAccessibilitySelectedRows:"), nsa_value.GetHandle ());
			GC.KeepAlive (This);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static INSAccessibilityRow[] GetAccessibilityVisibleRows (this INSAccessibilityTable This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			INSAccessibilityRow[] ret;
			ret = CFArray.ArrayFromHandle<INSAccessibilityRow>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("accessibilityVisibleRows")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSObject[] GetAccessibilityColumns (this INSAccessibilityTable This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSObject[] ret;
			ret = CFArray.ArrayFromHandle<NSObject>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("accessibilityColumns")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSObject[] GetAccessibilityVisibleColumns (this INSAccessibilityTable This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSObject[] ret;
			ret = CFArray.ArrayFromHandle<NSObject>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("accessibilityVisibleColumns")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSObject[] GetAccessibilitySelectedColumns (this INSAccessibilityTable This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSObject[] ret;
			ret = CFArray.ArrayFromHandle<NSObject>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("accessibilitySelectedColumns")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string GetAccessibilityHeaderGroup (this INSAccessibilityTable This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			string ret;
			ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("accessibilityHeaderGroup")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSObject[] GetAccessibilitySelectedCells (this INSAccessibilityTable This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSObject[] ret;
			ret = CFArray.ArrayFromHandle<NSObject>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("accessibilitySelectedCells")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSObject[] GetAccessibilityVisibleCells (this INSAccessibilityTable This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSObject[] ret;
			ret = CFArray.ArrayFromHandle<NSObject>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("accessibilityVisibleCells")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSObject[] GetAccessibilityRowHeaderUIElements (this INSAccessibilityTable This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSObject[] ret;
			ret = CFArray.ArrayFromHandle<NSObject>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("accessibilityRowHeaderUIElements")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSObject[] GetAccessibilityColumnHeaderUIElements (this INSAccessibilityTable This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSObject[] ret;
			ret = CFArray.ArrayFromHandle<NSObject>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("accessibilityColumnHeaderUIElements")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class NSAccessibilityTableWrapper : BaseWrapper, INSAccessibilityTable {
		public NSAccessibilityTableWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSAccessibilityTableWrapper))]
		static NSAccessibilityTableWrapper ()
		{
			GC.KeepAlive (null);
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public string? AccessibilityLabel {
			[Export ("accessibilityLabel")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				string ret;
				ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("accessibilityLabel")), false)!;
				return ret;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public INSAccessibilityRow[]? AccessibilityRows {
			[Export ("accessibilityRows")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				INSAccessibilityRow[] ret;
				ret = CFArray.ArrayFromHandle<INSAccessibilityRow>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("accessibilityRows")), false)!;
				return ret;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		public CGRect AccessibilityFrame {
			[Export ("accessibilityFrame")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				CGRect ret;
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend (this.Handle, Selector.GetHandle ("accessibilityFrame"));
				} else {
					ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret (this.Handle, Selector.GetHandle ("accessibilityFrame"));
				}
				return ret!;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		public NSObject? AccessibilityParent {
			[Export ("accessibilityParent")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSObject ret;
				ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("accessibilityParent")), false)!;
				return ret;
			}
		}
	}
}
