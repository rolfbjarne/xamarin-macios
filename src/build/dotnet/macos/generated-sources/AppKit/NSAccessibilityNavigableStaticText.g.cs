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
	/// <summary>This interface represents the Objective-C protocol <c>NSAccessibilityNavigableStaticText</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[Protocol (Name = "NSAccessibilityNavigableStaticText", WrapperType = typeof (NSAccessibilityNavigableStaticTextWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetAccessibilityString", Selector = "accessibilityStringForRange:", ReturnType = typeof (string), ParameterType = new Type [] { typeof (NSRange) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetAccessibilityLine", Selector = "accessibilityLineForIndex:", ReturnType = typeof (IntPtr), ParameterType = new Type [] { typeof (IntPtr) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetAccessibilityRangeForLine", Selector = "accessibilityRangeForLine:", ReturnType = typeof (NSRange), ParameterType = new Type [] { typeof (IntPtr) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetAccessibilityFrame", Selector = "accessibilityFrameForRange:", ReturnType = typeof (CGRect), ParameterType = new Type [] { typeof (NSRange) }, ParameterByRef = new bool [] { false })]
	public partial interface INSAccessibilityNavigableStaticText : INativeObject, IDisposable, 
		AppKit.INSAccessibilityElementProtocol
		, AppKit.INSAccessibilityStaticText
	{
		/// <param name="range">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("accessibilityStringForRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string? GetAccessibilityString (NSRange range)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="range">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static string? _GetAccessibilityString (INSAccessibilityNavigableStaticText This, NSRange range)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			string ret;
			ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NSRange (This.Handle, Selector.GetHandle ("accessibilityStringForRange:"), range), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		/// <param name="index">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("accessibilityLineForIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint GetAccessibilityLine (nint index)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="index">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static nint _GetAccessibilityLine (INSAccessibilityNavigableStaticText This, nint index)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			nint ret;
			ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("accessibilityLineForIndex:"), index);
			GC.KeepAlive (This);
			return ret;
		}
		/// <param name="lineNumber">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("accessibilityRangeForLine:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSRange GetAccessibilityRangeForLine (nint lineNumber)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="lineNumber">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSRange _GetAccessibilityRangeForLine (INSAccessibilityNavigableStaticText This, nint lineNumber)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSRange ret;
			ret = global::ObjCRuntime.Messaging.NSRange_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("accessibilityRangeForLine:"), lineNumber);
			GC.KeepAlive (This);
			return ret;
		}
		/// <param name="range">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("accessibilityFrameForRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGRect GetAccessibilityFrame (NSRange range)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="range">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static CGRect _GetAccessibilityFrame (INSAccessibilityNavigableStaticText This, NSRange range)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			CGRect ret;
			if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
				ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_NSRange (This.Handle, Selector.GetHandle ("accessibilityFrameForRange:"), range);
				GC.KeepAlive (This);
			} else {
				ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret_NSRange (This.Handle, Selector.GetHandle ("accessibilityFrameForRange:"), range);
				GC.KeepAlive (This);
			}
			return ret!;
		}
		[DynamicDependencyAttribute ("GetAccessibilityFrame(Foundation.NSRange)")]
		[DynamicDependencyAttribute ("GetAccessibilityLine(System.IntPtr)")]
		[DynamicDependencyAttribute ("GetAccessibilityRangeForLine(System.IntPtr)")]
		[DynamicDependencyAttribute ("GetAccessibilityString(Foundation.NSRange)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSAccessibilityNavigableStaticTextWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static INSAccessibilityNavigableStaticText ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class NSAccessibilityNavigableStaticTextWrapper : BaseWrapper, INSAccessibilityNavigableStaticText {
		public NSAccessibilityNavigableStaticTextWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSAccessibilityNavigableStaticTextWrapper))]
		static NSAccessibilityNavigableStaticTextWrapper ()
		{
			GC.KeepAlive (null);
		}
		/// <param name="range">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("accessibilityStringForRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public string? GetAccessibilityString (NSRange range)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			string ret;
			ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NSRange (this.Handle, Selector.GetHandle ("accessibilityStringForRange:"), range), false)!;
			return ret;
		}
		/// <param name="index">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("accessibilityLineForIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public nint GetAccessibilityLine (nint index)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			nint ret;
			ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("accessibilityLineForIndex:"), index);
			return ret;
		}
		/// <param name="lineNumber">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("accessibilityRangeForLine:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSRange GetAccessibilityRangeForLine (nint lineNumber)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSRange ret;
			ret = global::ObjCRuntime.Messaging.NSRange_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("accessibilityRangeForLine:"), lineNumber);
			return ret;
		}
		/// <param name="range">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("accessibilityFrameForRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public CGRect GetAccessibilityFrame (NSRange range)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			CGRect ret;
			if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
				ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_NSRange (this.Handle, Selector.GetHandle ("accessibilityFrameForRange:"), range);
			} else {
				ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret_NSRange (this.Handle, Selector.GetHandle ("accessibilityFrameForRange:"), range);
			}
			return ret!;
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
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public string? AccessibilityValue {
			[Export ("accessibilityValue")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				string ret;
				ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("accessibilityValue")), false)!;
				return ret;
			}
		}
	}
}
