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
using GLKit;
using Metal;
using CoreML;
using MapKit;
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Contacts;
using Security;
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
using NewsstandKit;
using FileProvider;
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;
using MetalPerformanceShadersGraph;
#nullable enable
namespace UIKit {
	#pragma warning disable CS1573
	/// <summary>Interface for working with paste and drop text items.</summary>
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[Protocol (Name = "UITextPasteItem", WrapperType = typeof (UITextPasteItemWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetStringResult", Selector = "setStringResult:", ParameterType = new Type [] { typeof (string) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetAttributedStringResult", Selector = "setAttributedStringResult:", ParameterType = new Type [] { typeof (NSAttributedString) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetAttachmentResult", Selector = "setAttachmentResult:", ParameterType = new Type [] { typeof (NSTextAttachment) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetNoResult", Selector = "setNoResult")]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetDefaultResult", Selector = "setDefaultResult")]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "ItemProvider", Selector = "itemProvider", PropertyType = typeof (NSItemProvider), GetterSelector = "itemProvider", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "LocalObject", Selector = "localObject", PropertyType = typeof (NSObject), GetterSelector = "localObject", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "DefaultAttributes", Selector = "defaultAttributes", PropertyType = typeof (global::Foundation.NSDictionary<NSString, NSObject>), GetterSelector = "defaultAttributes", ArgumentSemantic = ArgumentSemantic.None)]
	public partial interface IUITextPasteItem : INativeObject, IDisposable
	{
		/// <param name="string">The new attachment value.</param><summary>Sets the text result.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("setStringResult:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetStringResult (string @string)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="string">The new attachment value.</param><summary>Sets the text result.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetStringResult (IUITextPasteItem This, string @string)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (@string is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (@string));
			var nsstring = CFString.CreateNative (@string);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setStringResult:"), nsstring);
			GC.KeepAlive (This);
			CFString.ReleaseNative (nsstring);
		}
		/// <param name="string">The new attachment value.</param><summary>Sets the string value of the paste item.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("setAttributedStringResult:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetAttributedStringResult (NSAttributedString @string)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="string">The new attachment value.</param><summary>Sets the string value of the paste item.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetAttributedStringResult (IUITextPasteItem This, NSAttributedString @string)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var @string__handle__ = @string!.GetNonNullHandle (nameof (@string));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setAttributedStringResult:"), @string__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (@string);
		}
		/// <param name="textAttachment">The new attachment value.</param><summary>Sets the attachment result to the specified attachment.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("setAttachmentResult:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetAttachmentResult (NSTextAttachment textAttachment)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="textAttachment">The new attachment value.</param><summary>Sets the attachment result to the specified attachment.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetAttachmentResult (IUITextPasteItem This, NSTextAttachment textAttachment)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var textAttachment__handle__ = textAttachment!.GetNonNullHandle (nameof (textAttachment));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setAttachmentResult:"), textAttachment__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (textAttachment);
		}
		/// <summary>Causes the text value to not be provided by its provider.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("setNoResult")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetNoResult ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <summary>Causes the text value to not be provided by its provider.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetNoResult (IUITextPasteItem This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			global::ObjCRuntime.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("setNoResult"));
			GC.KeepAlive (This);
		}
		/// <summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("setDefaultResult")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetDefaultResult ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetDefaultResult (IUITextPasteItem This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			global::ObjCRuntime.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("setDefaultResult"));
			GC.KeepAlive (This);
		}
		[DynamicDependencyAttribute ("DefaultAttributes")]
		[DynamicDependencyAttribute ("ItemProvider")]
		[DynamicDependencyAttribute ("LocalObject")]
		[DynamicDependencyAttribute ("SetAttachmentResult(UIKit.NSTextAttachment)")]
		[DynamicDependencyAttribute ("SetAttributedStringResult(Foundation.NSAttributedString)")]
		[DynamicDependencyAttribute ("SetDefaultResult()")]
		[DynamicDependencyAttribute ("SetNoResult()")]
		[DynamicDependencyAttribute ("SetStringResult(System.String)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UITextPasteItemWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IUITextPasteItem ()
		{
			GC.KeepAlive (null);
		}
		/// <summary>Gets the provider that provides the text data for the paste item.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual NSItemProvider ItemProvider {
			[Export ("itemProvider")]
			get {
				return _GetItemProvider (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSItemProvider _GetItemProvider (IUITextPasteItem This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			NSItemProvider ret;
			ret =  Runtime.GetNSObject<NSItemProvider> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("itemProvider")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		/// <summary>Gets the context object, if present, that was attached to the item when it was lifted.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual NSObject? LocalObject {
			[Export ("localObject")]
			get {
				return _GetLocalObject (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSObject _GetLocalObject (IUITextPasteItem This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			NSObject ret;
			ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("localObject")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		/// <summary>Gets the default attributes for plain text paste items.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual NSDictionary<NSString, NSObject> DefaultAttributes {
			[Export ("defaultAttributes")]
			get {
				return _GetDefaultAttributes (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSDictionary<NSString, NSObject> _GetDefaultAttributes (IUITextPasteItem This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			NSDictionary<NSString, NSObject> ret;
			ret =  Runtime.GetNSObject<NSDictionary<NSString, NSObject>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("defaultAttributes")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class UITextPasteItemWrapper : BaseWrapper, IUITextPasteItem {
		public UITextPasteItemWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UITextPasteItemWrapper))]
		static UITextPasteItemWrapper ()
		{
			GC.KeepAlive (null);
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
		public NSItemProvider ItemProvider {
			[Export ("itemProvider")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				NSItemProvider ret;
				ret =  Runtime.GetNSObject<NSItemProvider> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("itemProvider")), false)!;
				return ret;
			}
		}
		/// <summary>Gets the context object, if present, that was attached to the item when it was lifted.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSObject? LocalObject {
			[Export ("localObject")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				NSObject ret;
				ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("localObject")), false)!;
				return ret;
			}
		}
		/// <summary>Gets the default attributes for plain text paste items.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSDictionary<NSString, NSObject> DefaultAttributes {
			[Export ("defaultAttributes")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				NSDictionary<NSString, NSObject> ret;
				ret =  Runtime.GetNSObject<NSDictionary<NSString, NSObject>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("defaultAttributes")), false)!;
				return ret;
			}
		}
	}
}
