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
	/// <summary>This interface represents the Objective-C protocol <c>UISearchTextFieldPasteItem</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("ios13.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[Protocol (Name = "UISearchTextFieldPasteItem", WrapperType = typeof (UISearchTextFieldPasteItemWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetSearchTokenResult", Selector = "setSearchTokenResult:", ParameterType = new Type [] { typeof (UISearchToken) }, ParameterByRef = new bool [] { false })]
	public partial interface IUISearchTextFieldPasteItem : INativeObject, IDisposable, 
		UIKit.IUITextPasteItem
	{
		[global::Foundation.RequiredMember]
		[Export ("setSearchTokenResult:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetSearchTokenResult (UISearchToken token)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetSearchTokenResult (IUISearchTextFieldPasteItem This, UISearchToken token)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var token__handle__ = token!.GetNonNullHandle (nameof (token));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setSearchTokenResult:"), token__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (token);
		}
		[DynamicDependencyAttribute ("SetSearchTokenResult(UIKit.UISearchToken)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UISearchTextFieldPasteItemWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IUISearchTextFieldPasteItem ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class UISearchTextFieldPasteItemWrapper : BaseWrapper, IUISearchTextFieldPasteItem {
		public UISearchTextFieldPasteItemWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UISearchTextFieldPasteItemWrapper))]
		static UISearchTextFieldPasteItemWrapper ()
		{
			GC.KeepAlive (null);
		}
		[Export ("setSearchTokenResult:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetSearchTokenResult (UISearchToken token)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var token__handle__ = token!.GetNonNullHandle (nameof (token));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setSearchTokenResult:"), token__handle__);
			GC.KeepAlive (token);
		}
		/// <param name="string">The new attachment value.</param><summary>Sets the text result.</summary><remarks>To be added.</remarks>
		[Export ("setStringResult:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetStringResult (string @string)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (@string is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (@string));
			var nsstring = CFString.CreateNative (@string);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setStringResult:"), nsstring);
			CFString.ReleaseNative (nsstring);
		}
		/// <param name="string">The new attachment value.</param><summary>Sets the string value of the paste item.</summary><remarks>To be added.</remarks>
		[Export ("setAttributedStringResult:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetAttributedStringResult (NSAttributedString @string)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var @string__handle__ = @string!.GetNonNullHandle (nameof (@string));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setAttributedStringResult:"), @string__handle__);
			GC.KeepAlive (@string);
		}
		/// <param name="textAttachment">The new attachment value.</param><summary>Sets the attachment result to the specified attachment.</summary><remarks>To be added.</remarks>
		[Export ("setAttachmentResult:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetAttachmentResult (NSTextAttachment textAttachment)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var textAttachment__handle__ = textAttachment!.GetNonNullHandle (nameof (textAttachment));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setAttachmentResult:"), textAttachment__handle__);
			GC.KeepAlive (textAttachment);
		}
		/// <summary>Causes the text value to not be provided by its provider.</summary><remarks>To be added.</remarks>
		[Export ("setNoResult")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetNoResult ()
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("setNoResult"));
		}
		/// <summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("setDefaultResult")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetDefaultResult ()
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("setDefaultResult"));
		}
		/// <summary>Gets the provider that provides the text data for the paste item.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		public NSItemProvider ItemProvider {
			[Export ("itemProvider")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				NSItemProvider ret;
				ret =  Runtime.GetNSObject<NSItemProvider> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("itemProvider")), false)!;
				return ret;
			}
		}
		/// <summary>Gets the context object, if present, that was attached to the item when it was lifted.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		public NSObject? LocalObject {
			[Export ("localObject")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				NSObject ret;
				ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("localObject")), false)!;
				return ret;
			}
		}
		/// <summary>Gets the default attributes for plain text paste items.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		public NSDictionary<NSString, NSObject> DefaultAttributes {
			[Export ("defaultAttributes")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				NSDictionary<NSString, NSObject> ret;
				ret =  Runtime.GetNSObject<NSDictionary<NSString, NSObject>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("defaultAttributes")), false)!;
				return ret;
			}
		}
	}
}
