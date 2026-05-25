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
	/// <summary>This interface represents the Objective-C protocol <c>UIMenuLeaf</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[SupportedOSPlatform ("tvos16.0")]
	[SupportedOSPlatform ("ios16.0")]
	[SupportedOSPlatform ("maccatalyst16.0")]
	[Protocol (Name = "UIMenuLeaf", WrapperType = typeof (UIMenuLeafWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "Target", Selector = "performWithSender:target:", ParameterType = new Type [] { typeof (NSObject), typeof (NSObject) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "Title", Selector = "title", PropertyType = typeof (string), GetterSelector = "title", SetterSelector = "setTitle:", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "Image", Selector = "image", PropertyType = typeof (UIImage), GetterSelector = "image", SetterSelector = "setImage:", ArgumentSemantic = ArgumentSemantic.Copy)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "DiscoverabilityTitle", Selector = "discoverabilityTitle", PropertyType = typeof (string), GetterSelector = "discoverabilityTitle", SetterSelector = "setDiscoverabilityTitle:", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "Attributes", Selector = "attributes", PropertyType = typeof (UIMenuElementAttributes), GetterSelector = "attributes", SetterSelector = "setAttributes:", ArgumentSemantic = ArgumentSemantic.Assign)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "State", Selector = "state", PropertyType = typeof (UIMenuElementState), GetterSelector = "state", SetterSelector = "setState:", ArgumentSemantic = ArgumentSemantic.Assign)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "Sender", Selector = "sender", PropertyType = typeof (NSObject), GetterSelector = "sender", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "PresentationSourceItem", Selector = "presentationSourceItem", PropertyType = typeof (IUIPopoverPresentationControllerSourceItem), GetterSelector = "presentationSourceItem", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "RepeatBehavior", Selector = "repeatBehavior", PropertyType = typeof (UIMenuElementRepeatBehavior), GetterSelector = "repeatBehavior", SetterSelector = "setRepeatBehavior:", ArgumentSemantic = ArgumentSemantic.Assign)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "SelectedImage", Selector = "selectedImage", PropertyType = typeof (UIImage), GetterSelector = "selectedImage", SetterSelector = "setSelectedImage:", ArgumentSemantic = ArgumentSemantic.Copy)]
	public partial interface IUIMenuLeaf : INativeObject, IDisposable
	{
		[global::Foundation.RequiredMember]
		[Export ("performWithSender:target:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Target (NSObject? sender, NSObject? target)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _Target (IUIMenuLeaf This, NSObject? sender, NSObject? target)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var sender__handle__ = sender.GetHandle ();
			var target__handle__ = target.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("performWithSender:target:"), sender__handle__, target__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
			GC.KeepAlive (target);
		}
		[DynamicDependencyAttribute ("Attributes")]
		[DynamicDependencyAttribute ("DiscoverabilityTitle")]
		[DynamicDependencyAttribute ("Image")]
		[DynamicDependencyAttribute ("PresentationSourceItem")]
		[DynamicDependencyAttribute ("RepeatBehavior")]
		[DynamicDependencyAttribute ("SelectedImage")]
		[DynamicDependencyAttribute ("Sender")]
		[DynamicDependencyAttribute ("State")]
		[DynamicDependencyAttribute ("Target(Foundation.NSObject,Foundation.NSObject)")]
		[DynamicDependencyAttribute ("Title")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UIMenuLeafWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IUIMenuLeaf ()
		{
			GC.KeepAlive (null);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual string Title {
			[Export ("title")]
			get {
				return _GetTitle (this);
			}
			[Export ("setTitle:")]
			set {
				_SetTitle (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static string _GetTitle (IUIMenuLeaf This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			string ret;
			ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("title")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetTitle (IUIMenuLeaf This, string value)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (value is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (value));
			var nsvalue = CFString.CreateNative (value);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setTitle:"), nsvalue);
			GC.KeepAlive (This);
			CFString.ReleaseNative (nsvalue);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual UIImage? Image {
			[Export ("image", ArgumentSemantic.Copy)]
			get {
				return _GetImage (this);
			}
			[Export ("setImage:", ArgumentSemantic.Copy)]
			set {
				_SetImage (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static UIImage _GetImage (IUIMenuLeaf This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			UIImage ret;
			ret =  Runtime.GetNSObject<UIImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("image")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetImage (IUIMenuLeaf This, UIImage? value)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var value__handle__ = value.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setImage:"), value__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (value);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual string? DiscoverabilityTitle {
			[Export ("discoverabilityTitle")]
			get {
				return _GetDiscoverabilityTitle (this);
			}
			[Export ("setDiscoverabilityTitle:")]
			set {
				_SetDiscoverabilityTitle (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static string _GetDiscoverabilityTitle (IUIMenuLeaf This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			string ret;
			ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("discoverabilityTitle")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetDiscoverabilityTitle (IUIMenuLeaf This, string? value)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var nsvalue = CFString.CreateNative (value);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setDiscoverabilityTitle:"), nsvalue);
			GC.KeepAlive (This);
			CFString.ReleaseNative (nsvalue);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual UIMenuElementAttributes Attributes {
			[Export ("attributes", ArgumentSemantic.Assign)]
			get {
				return _GetAttributes (this);
			}
			[Export ("setAttributes:", ArgumentSemantic.Assign)]
			set {
				_SetAttributes (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static UIMenuElementAttributes _GetAttributes (IUIMenuLeaf This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			UIMenuElementAttributes ret;
			ret = (UIMenuElementAttributes) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("attributes"));
			GC.KeepAlive (This);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetAttributes (IUIMenuLeaf This, UIMenuElementAttributes value)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (This.Handle, Selector.GetHandle ("setAttributes:"), (UIntPtr) (ulong) value);
			GC.KeepAlive (This);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual UIMenuElementState State {
			[Export ("state", ArgumentSemantic.Assign)]
			get {
				return _GetState (this);
			}
			[Export ("setState:", ArgumentSemantic.Assign)]
			set {
				_SetState (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static UIMenuElementState _GetState (IUIMenuLeaf This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			UIMenuElementState ret;
			ret = (UIMenuElementState) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("state"));
			GC.KeepAlive (This);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetState (IUIMenuLeaf This, UIMenuElementState value)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setState:"), (IntPtr) (long) value);
			GC.KeepAlive (This);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual NSObject? Sender {
			[Export ("sender")]
			get {
				return _GetSender (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSObject _GetSender (IUIMenuLeaf This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			NSObject ret;
			ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("sender")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[global::Foundation.RequiredMember]
		public virtual IUIPopoverPresentationControllerSourceItem PresentationSourceItem {
			[Export ("presentationSourceItem")]
			get {
				return _GetPresentationSourceItem (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static IUIPopoverPresentationControllerSourceItem _GetPresentationSourceItem (IUIMenuLeaf This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			IUIPopoverPresentationControllerSourceItem ret;
			ret =  Runtime.GetINativeObject<IUIPopoverPresentationControllerSourceItem> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("presentationSourceItem")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[global::Foundation.RequiredMember]
		public virtual UIMenuElementRepeatBehavior RepeatBehavior {
			[Export ("repeatBehavior", ArgumentSemantic.Assign)]
			get {
				return _GetRepeatBehavior (this);
			}
			[Export ("setRepeatBehavior:", ArgumentSemantic.Assign)]
			set {
				_SetRepeatBehavior (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static UIMenuElementRepeatBehavior _GetRepeatBehavior (IUIMenuLeaf This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			UIMenuElementRepeatBehavior ret;
			ret = (UIMenuElementRepeatBehavior) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("repeatBehavior"));
			GC.KeepAlive (This);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetRepeatBehavior (IUIMenuLeaf This, UIMenuElementRepeatBehavior value)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setRepeatBehavior:"), (IntPtr) (long) value);
			GC.KeepAlive (This);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[global::Foundation.OptionalMember]
		public virtual UIImage SelectedImage {
			[Export ("selectedImage", ArgumentSemantic.Copy)]
			get {
				return _GetSelectedImage (this);
			}
			[Export ("setSelectedImage:", ArgumentSemantic.Copy)]
			set {
				_SetSelectedImage (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static UIImage _GetSelectedImage (IUIMenuLeaf This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			UIImage ret;
			ret =  Runtime.GetNSObject<UIImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("selectedImage")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetSelectedImage (IUIMenuLeaf This, UIImage value)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var value__handle__ = value!.GetNonNullHandle (nameof (value));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setSelectedImage:"), value__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (value);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="IUIMenuLeaf" /> interface to support all the methods from the UIMenuLeaf protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IUIMenuLeaf" /> interface allow developers to treat instances of the interface as having all the optional methods of the original UIMenuLeaf protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class UIMenuLeaf_Extensions {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static UIImage GetSelectedImage (this IUIMenuLeaf This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			UIImage ret;
			ret =  Runtime.GetNSObject<UIImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("selectedImage")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetSelectedImage (this IUIMenuLeaf This, UIImage value)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var value__handle__ = value!.GetNonNullHandle (nameof (value));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setSelectedImage:"), value__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (value);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class UIMenuLeafWrapper : BaseWrapper, IUIMenuLeaf {
		public UIMenuLeafWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UIMenuLeafWrapper))]
		static UIMenuLeafWrapper ()
		{
			GC.KeepAlive (null);
		}
		[Export ("performWithSender:target:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void Target (NSObject? sender, NSObject? target)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var sender__handle__ = sender.GetHandle ();
			var target__handle__ = target.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("performWithSender:target:"), sender__handle__, target__handle__);
			GC.KeepAlive (sender);
			GC.KeepAlive (target);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public string Title {
			[Export ("title")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				string ret;
				ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("title")), false)!;
				return ret;
			}
			[Export ("setTitle:")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (value is null)
					ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (value));
				var nsvalue = CFString.CreateNative (value);
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setTitle:"), nsvalue);
				CFString.ReleaseNative (nsvalue);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public UIImage? Image {
			[Export ("image", ArgumentSemantic.Copy)]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UIImage ret;
				ret =  Runtime.GetNSObject<UIImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("image")), false)!;
				return ret;
			}
			[Export ("setImage:", ArgumentSemantic.Copy)]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				var value__handle__ = value.GetHandle ();
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setImage:"), value__handle__);
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public string? DiscoverabilityTitle {
			[Export ("discoverabilityTitle")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				string ret;
				ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("discoverabilityTitle")), false)!;
				return ret;
			}
			[Export ("setDiscoverabilityTitle:")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				var nsvalue = CFString.CreateNative (value);
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setDiscoverabilityTitle:"), nsvalue);
				CFString.ReleaseNative (nsvalue);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public UIMenuElementAttributes Attributes {
			[Export ("attributes", ArgumentSemantic.Assign)]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UIMenuElementAttributes ret;
				ret = (UIMenuElementAttributes) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("attributes"));
				return ret!;
			}
			[Export ("setAttributes:", ArgumentSemantic.Assign)]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (this.Handle, Selector.GetHandle ("setAttributes:"), (UIntPtr) (ulong) value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public UIMenuElementState State {
			[Export ("state", ArgumentSemantic.Assign)]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UIMenuElementState ret;
				ret = (UIMenuElementState) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("state"));
				return ret!;
			}
			[Export ("setState:", ArgumentSemantic.Assign)]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setState:"), (IntPtr) (long) value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSObject? Sender {
			[Export ("sender")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				NSObject ret;
				ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("sender")), false)!;
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		public IUIPopoverPresentationControllerSourceItem PresentationSourceItem {
			[Export ("presentationSourceItem")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				IUIPopoverPresentationControllerSourceItem ret;
				ret =  Runtime.GetINativeObject<IUIPopoverPresentationControllerSourceItem> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("presentationSourceItem")), false)!;
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		public UIMenuElementRepeatBehavior RepeatBehavior {
			[Export ("repeatBehavior", ArgumentSemantic.Assign)]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UIMenuElementRepeatBehavior ret;
				ret = (UIMenuElementRepeatBehavior) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("repeatBehavior"));
				return ret!;
			}
			[Export ("setRepeatBehavior:", ArgumentSemantic.Assign)]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setRepeatBehavior:"), (IntPtr) (long) value);
			}
		}
	}
}
