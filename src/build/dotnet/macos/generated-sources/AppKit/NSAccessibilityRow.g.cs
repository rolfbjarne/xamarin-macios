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
	/// <summary>This interface represents the Objective-C protocol <c>NSAccessibilityRow</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[Protocol (Name = "NSAccessibilityRow", WrapperType = typeof (NSAccessibilityRowWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilityIndex", Selector = "accessibilityIndex", PropertyType = typeof (IntPtr), GetterSelector = "accessibilityIndex", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "AccessibilityDisclosureLevel", Selector = "accessibilityDisclosureLevel", PropertyType = typeof (IntPtr), GetterSelector = "accessibilityDisclosureLevel", ArgumentSemantic = ArgumentSemantic.None)]
	public partial interface INSAccessibilityRow : INativeObject, IDisposable, 
		AppKit.INSAccessibilityElementProtocol
		, AppKit.INSAccessibilityGroup
	{
		[DynamicDependencyAttribute ("AccessibilityDisclosureLevel")]
		[DynamicDependencyAttribute ("AccessibilityIndex")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSAccessibilityRowWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static INSAccessibilityRow ()
		{
			GC.KeepAlive (null);
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual nint AccessibilityIndex {
			[Export ("accessibilityIndex")]
			get {
				return _GetAccessibilityIndex (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static nint _GetAccessibilityIndex (INSAccessibilityRow This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			nint ret;
			ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("accessibilityIndex"));
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.OptionalMember]
		public virtual nint AccessibilityDisclosureLevel {
			[Export ("accessibilityDisclosureLevel")]
			get {
				return _GetAccessibilityDisclosureLevel (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static nint _GetAccessibilityDisclosureLevel (INSAccessibilityRow This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			nint ret;
			ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("accessibilityDisclosureLevel"));
			GC.KeepAlive (This);
			return ret;
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="INSAccessibilityRow" /> interface to support all the methods from the NSAccessibilityRow protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="INSAccessibilityRow" /> interface allow developers to treat instances of the interface as having all the optional methods of the original NSAccessibilityRow protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class NSAccessibilityRow_Extensions {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static nint GetAccessibilityDisclosureLevel (this INSAccessibilityRow This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			nint ret;
			ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("accessibilityDisclosureLevel"));
			GC.KeepAlive (This);
			return ret;
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class NSAccessibilityRowWrapper : BaseWrapper, INSAccessibilityRow {
		public NSAccessibilityRowWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSAccessibilityRowWrapper))]
		static NSAccessibilityRowWrapper ()
		{
			GC.KeepAlive (null);
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public nint AccessibilityIndex {
			[Export ("accessibilityIndex")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				nint ret;
				ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("accessibilityIndex"));
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
