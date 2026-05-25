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
	/// <summary>This interface represents the Objective-C protocol <c>NSAccessibilityLayoutArea</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[Protocol (Name = "NSAccessibilityLayoutArea", WrapperType = typeof (NSAccessibilityLayoutAreaWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilityLabel", Selector = "accessibilityLabel", PropertyType = typeof (string), GetterSelector = "accessibilityLabel", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilityChildren", Selector = "accessibilityChildren", PropertyType = typeof (NSObject[]), GetterSelector = "accessibilityChildren", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilitySelectedChildren", Selector = "accessibilitySelectedChildren", PropertyType = typeof (NSObject[]), GetterSelector = "accessibilitySelectedChildren", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilityFocusedUIElement", Selector = "accessibilityFocusedUIElement", PropertyType = typeof (NSObject), GetterSelector = "accessibilityFocusedUIElement", ArgumentSemantic = ArgumentSemantic.None)]
	public partial interface INSAccessibilityLayoutArea : INativeObject, IDisposable, 
		AppKit.INSAccessibilityElementProtocol
		, AppKit.INSAccessibilityGroup
	{
		[DynamicDependencyAttribute ("AccessibilityChildren")]
		[DynamicDependencyAttribute ("AccessibilityFocusedUIElement")]
		[DynamicDependencyAttribute ("AccessibilityLabel")]
		[DynamicDependencyAttribute ("AccessibilitySelectedChildren")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSAccessibilityLayoutAreaWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static INSAccessibilityLayoutArea ()
		{
			GC.KeepAlive (null);
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual string AccessibilityLabel {
			[Export ("accessibilityLabel")]
			get {
				return _GetAccessibilityLabel (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static string _GetAccessibilityLabel (INSAccessibilityLayoutArea This)
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
		public virtual NSObject[]? AccessibilityChildren {
			[Export ("accessibilityChildren")]
			get {
				return _GetAccessibilityChildren (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSObject[] _GetAccessibilityChildren (INSAccessibilityLayoutArea This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSObject[] ret;
			ret = CFArray.ArrayFromHandle<NSObject>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("accessibilityChildren")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual NSObject[]? AccessibilitySelectedChildren {
			[Export ("accessibilitySelectedChildren")]
			get {
				return _GetAccessibilitySelectedChildren (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSObject[] _GetAccessibilitySelectedChildren (INSAccessibilityLayoutArea This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSObject[] ret;
			ret = CFArray.ArrayFromHandle<NSObject>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("accessibilitySelectedChildren")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual NSObject AccessibilityFocusedUIElement {
			[Export ("accessibilityFocusedUIElement")]
			get {
				return _GetAccessibilityFocusedUIElement (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSObject _GetAccessibilityFocusedUIElement (INSAccessibilityLayoutArea This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSObject ret;
			ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("accessibilityFocusedUIElement")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class NSAccessibilityLayoutAreaWrapper : BaseWrapper, INSAccessibilityLayoutArea {
		public NSAccessibilityLayoutAreaWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSAccessibilityLayoutAreaWrapper))]
		static NSAccessibilityLayoutAreaWrapper ()
		{
			GC.KeepAlive (null);
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public string AccessibilityLabel {
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
		public NSObject[]? AccessibilityChildren {
			[Export ("accessibilityChildren")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSObject[] ret;
				ret = CFArray.ArrayFromHandle<NSObject>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("accessibilityChildren")), false)!;
				return ret;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSObject[]? AccessibilitySelectedChildren {
			[Export ("accessibilitySelectedChildren")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSObject[] ret;
				ret = CFArray.ArrayFromHandle<NSObject>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("accessibilitySelectedChildren")), false)!;
				return ret;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSObject AccessibilityFocusedUIElement {
			[Export ("accessibilityFocusedUIElement")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSObject ret;
				ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("accessibilityFocusedUIElement")), false)!;
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
