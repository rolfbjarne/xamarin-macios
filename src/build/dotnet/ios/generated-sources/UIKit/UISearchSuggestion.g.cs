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
	/// <summary>This interface represents the Objective-C protocol <c>UISearchSuggestion</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[SupportedOSPlatform ("tvos14.0")]
	[SupportedOSPlatform ("ios16.0")]
	[SupportedOSPlatform ("maccatalyst16.0")]
	[Protocol (Name = "UISearchSuggestion", WrapperType = typeof (UISearchSuggestionWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetLocalizedDescription", Selector = "localizedDescription", ReturnType = typeof (NSString))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetIconImage", Selector = "iconImage", ReturnType = typeof (UIImage))]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "LocalizedSuggestion", Selector = "localizedSuggestion", PropertyType = typeof (NSString), GetterSelector = "localizedSuggestion", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "LocalizedAttributedSuggestion", Selector = "localizedAttributedSuggestion", PropertyType = typeof (NSAttributedString), GetterSelector = "localizedAttributedSuggestion", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "RepresentedObject", Selector = "representedObject", PropertyType = typeof (NSObject), GetterSelector = "representedObject", SetterSelector = "setRepresentedObject:", ArgumentSemantic = ArgumentSemantic.Retain)]
	public partial interface IUISearchSuggestion : INativeObject, IDisposable
	{
		[global::Foundation.OptionalMember]
		[Export ("localizedDescription")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSString? GetLocalizedDescription ()
		{
			return _GetLocalizedDescription (this);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSString? _GetLocalizedDescription (IUISearchSuggestion This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			NSString ret;
			ret =  Runtime.GetNSObject<NSString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("localizedDescription")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[global::Foundation.OptionalMember]
		[Export ("iconImage")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIImage? GetIconImage ()
		{
			return _GetIconImage (this);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static UIImage? _GetIconImage (IUISearchSuggestion This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			UIImage ret;
			ret =  Runtime.GetNSObject<UIImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("iconImage")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[DynamicDependencyAttribute ("GetIconImage()")]
		[DynamicDependencyAttribute ("GetLocalizedDescription()")]
		[DynamicDependencyAttribute ("LocalizedAttributedSuggestion")]
		[DynamicDependencyAttribute ("LocalizedSuggestion")]
		[DynamicDependencyAttribute ("RepresentedObject")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UISearchSuggestionWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IUISearchSuggestion ()
		{
			GC.KeepAlive (null);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual NSString? LocalizedSuggestion {
			[Export ("localizedSuggestion")]
			get {
				return _GetLocalizedSuggestion (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSString _GetLocalizedSuggestion (IUISearchSuggestion This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			NSString ret;
			ret =  Runtime.GetNSObject<NSString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("localizedSuggestion")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[global::Foundation.OptionalMember]
		public virtual NSAttributedString? LocalizedAttributedSuggestion {
			[Export ("localizedAttributedSuggestion")]
			get {
				return _GetLocalizedAttributedSuggestion (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSAttributedString _GetLocalizedAttributedSuggestion (IUISearchSuggestion This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			NSAttributedString ret;
			ret =  Runtime.GetNSObject<NSAttributedString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("localizedAttributedSuggestion")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[global::Foundation.OptionalMember]
		public virtual NSObject? RepresentedObject {
			[Export ("representedObject", ArgumentSemantic.Retain)]
			get {
				return _GetRepresentedObject (this);
			}
			[Export ("setRepresentedObject:", ArgumentSemantic.Retain)]
			set {
				_SetRepresentedObject (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSObject _GetRepresentedObject (IUISearchSuggestion This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			NSObject ret;
			ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("representedObject")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetRepresentedObject (IUISearchSuggestion This, NSObject? value)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var value__handle__ = value.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setRepresentedObject:"), value__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (value);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="IUISearchSuggestion" /> interface to support all the methods from the UISearchSuggestion protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IUISearchSuggestion" /> interface allow developers to treat instances of the interface as having all the optional methods of the original UISearchSuggestion protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class UISearchSuggestion_Extensions {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSString? GetLocalizedDescription (this IUISearchSuggestion This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			NSString ret;
			ret =  Runtime.GetNSObject<NSString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("localizedDescription")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static UIImage? GetIconImage (this IUISearchSuggestion This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			UIImage ret;
			ret =  Runtime.GetNSObject<UIImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("iconImage")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSAttributedString GetLocalizedAttributedSuggestion (this IUISearchSuggestion This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			NSAttributedString ret;
			ret =  Runtime.GetNSObject<NSAttributedString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("localizedAttributedSuggestion")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSObject GetRepresentedObject (this IUISearchSuggestion This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			NSObject ret;
			ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("representedObject")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetRepresentedObject (this IUISearchSuggestion This, NSObject? value)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var value__handle__ = value.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setRepresentedObject:"), value__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (value);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class UISearchSuggestionWrapper : BaseWrapper, IUISearchSuggestion {
		public UISearchSuggestionWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UISearchSuggestionWrapper))]
		static UISearchSuggestionWrapper ()
		{
			GC.KeepAlive (null);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSString? LocalizedSuggestion {
			[Export ("localizedSuggestion")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				NSString ret;
				ret =  Runtime.GetNSObject<NSString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("localizedSuggestion")), false)!;
				return ret;
			}
		}
	}
}
