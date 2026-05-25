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
using Metal;
using CoreML;
using AppKit;
using MapKit;
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Contacts;
using Security;
using CloudKit;
using Messages;
using AudioUnit;
using CoreVideo;
using CoreMedia;
using QuickLook;
using CoreImage;
using SpriteKit;
using Foundation;
using CoreMotion;
using ObjCRuntime;
using AddressBook;
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
namespace UIKit {
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>UIAccessibilityReadingContent</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("tvos")]
	[Protocol (Name = "UIAccessibilityReadingContent", WrapperType = typeof (UIAccessibilityReadingContentWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetAccessibilityLineNumber", Selector = "accessibilityLineNumberForPoint:", ReturnType = typeof (IntPtr), ParameterType = new Type [] { typeof (CGPoint) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetAccessibilityContent", Selector = "accessibilityContentForLineNumber:", ReturnType = typeof (string), ParameterType = new Type [] { typeof (IntPtr) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetAccessibilityFrame", Selector = "accessibilityFrameForLineNumber:", ReturnType = typeof (CGRect), ParameterType = new Type [] { typeof (IntPtr) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetAccessibilityPageContent", Selector = "accessibilityPageContent", ReturnType = typeof (string))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetAccessibilityAttributedContent", Selector = "accessibilityAttributedContentForLineNumber:", ReturnType = typeof (NSAttributedString), ParameterType = new Type [] { typeof (IntPtr) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetAccessibilityAttributedPageContent", Selector = "accessibilityAttributedPageContent", ReturnType = typeof (NSAttributedString))]
	public partial interface IUIAccessibilityReadingContent : INativeObject, IDisposable
	{
		/// <param name="point">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("accessibilityLineNumberForPoint:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint GetAccessibilityLineNumber (CGPoint point)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="point">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static nint _GetAccessibilityLineNumber (IUIAccessibilityReadingContent This, CGPoint point)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			nint ret;
			ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_CGPoint (This.Handle, Selector.GetHandle ("accessibilityLineNumberForPoint:"), point);
			GC.KeepAlive (This);
			return ret;
		}
		/// <param name="lineNumber">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("accessibilityContentForLineNumber:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string GetAccessibilityContent (nint lineNumber)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="lineNumber">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static string _GetAccessibilityContent (IUIAccessibilityReadingContent This, nint lineNumber)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			string ret;
			ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("accessibilityContentForLineNumber:"), lineNumber), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		/// <param name="lineNumber">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("accessibilityFrameForLineNumber:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGRect GetAccessibilityFrame (nint lineNumber)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="lineNumber">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static CGRect _GetAccessibilityFrame (IUIAccessibilityReadingContent This, nint lineNumber)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			CGRect ret;
			if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
				ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("accessibilityFrameForLineNumber:"), lineNumber);
				GC.KeepAlive (This);
			} else {
				ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret_IntPtr (This.Handle, Selector.GetHandle ("accessibilityFrameForLineNumber:"), lineNumber);
				GC.KeepAlive (This);
			}
			return ret!;
		}
		/// <summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("accessibilityPageContent")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string GetAccessibilityPageContent ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static string _GetAccessibilityPageContent (IUIAccessibilityReadingContent This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			string ret;
			ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("accessibilityPageContent")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		/// <param name="lineNumber">The line number of the desired text.</param><summary>Gets an attributes string that represents the text at the specified <paramref name="lineNumber" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("accessibilityAttributedContentForLineNumber:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSAttributedString? GetAccessibilityAttributedContent (nint lineNumber)
		{
			return _GetAccessibilityAttributedContent (this, lineNumber);
		}
		/// <param name="lineNumber">The line number of the desired text.</param><summary>Gets an attributes string that represents the text at the specified <paramref name="lineNumber" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSAttributedString? _GetAccessibilityAttributedContent (IUIAccessibilityReadingContent This, nint lineNumber)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			NSAttributedString ret;
			ret =  Runtime.GetNSObject<NSAttributedString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("accessibilityAttributedContentForLineNumber:"), lineNumber), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		/// <summary>Gets an attributes string that represents the text for the current page.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("accessibilityAttributedPageContent")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSAttributedString? GetAccessibilityAttributedPageContent ()
		{
			return _GetAccessibilityAttributedPageContent (this);
		}
		/// <summary>Gets an attributes string that represents the text for the current page.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSAttributedString? _GetAccessibilityAttributedPageContent (IUIAccessibilityReadingContent This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			NSAttributedString ret;
			ret =  Runtime.GetNSObject<NSAttributedString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("accessibilityAttributedPageContent")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[DynamicDependencyAttribute ("GetAccessibilityAttributedContent(System.IntPtr)")]
		[DynamicDependencyAttribute ("GetAccessibilityAttributedPageContent()")]
		[DynamicDependencyAttribute ("GetAccessibilityContent(System.IntPtr)")]
		[DynamicDependencyAttribute ("GetAccessibilityFrame(System.IntPtr)")]
		[DynamicDependencyAttribute ("GetAccessibilityLineNumber(CoreGraphics.CGPoint)")]
		[DynamicDependencyAttribute ("GetAccessibilityPageContent()")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UIAccessibilityReadingContentWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IUIAccessibilityReadingContent ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="IUIAccessibilityReadingContent" /> interface to support all the methods from the UIAccessibilityReadingContent protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IUIAccessibilityReadingContent" /> interface allow developers to treat instances of the interface as having all the optional methods of the original UIAccessibilityReadingContent protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class UIAccessibilityReadingContent_Extensions {
		/// <param name="lineNumber">The line number of the desired text.</param><summary>Gets an attributes string that represents the text at the specified <paramref name="lineNumber" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSAttributedString? GetAccessibilityAttributedContent (this IUIAccessibilityReadingContent This, nint lineNumber)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			NSAttributedString ret;
			ret =  Runtime.GetNSObject<NSAttributedString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("accessibilityAttributedContentForLineNumber:"), lineNumber), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		/// <summary>Gets an attributes string that represents the text for the current page.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSAttributedString? GetAccessibilityAttributedPageContent (this IUIAccessibilityReadingContent This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			NSAttributedString ret;
			ret =  Runtime.GetNSObject<NSAttributedString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("accessibilityAttributedPageContent")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class UIAccessibilityReadingContentWrapper : BaseWrapper, IUIAccessibilityReadingContent {
		public UIAccessibilityReadingContentWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UIAccessibilityReadingContentWrapper))]
		static UIAccessibilityReadingContentWrapper ()
		{
			GC.KeepAlive (null);
		}
		/// <param name="point">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("accessibilityLineNumberForPoint:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public nint GetAccessibilityLineNumber (CGPoint point)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			nint ret;
			ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_CGPoint (this.Handle, Selector.GetHandle ("accessibilityLineNumberForPoint:"), point);
			return ret;
		}
		/// <param name="lineNumber">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("accessibilityContentForLineNumber:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public string GetAccessibilityContent (nint lineNumber)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			string ret;
			ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("accessibilityContentForLineNumber:"), lineNumber), false)!;
			return ret;
		}
		/// <param name="lineNumber">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("accessibilityFrameForLineNumber:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public CGRect GetAccessibilityFrame (nint lineNumber)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			CGRect ret;
			if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
				ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("accessibilityFrameForLineNumber:"), lineNumber);
			} else {
				ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret_IntPtr (this.Handle, Selector.GetHandle ("accessibilityFrameForLineNumber:"), lineNumber);
			}
			return ret!;
		}
		/// <summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("accessibilityPageContent")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public string GetAccessibilityPageContent ()
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			string ret;
			ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("accessibilityPageContent")), false)!;
			return ret;
		}
	}
}
