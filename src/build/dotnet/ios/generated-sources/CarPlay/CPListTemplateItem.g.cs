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
namespace CarPlay {
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>CPListTemplateItem</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[UnsupportedOSPlatform ("tvos")]
	[UnsupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("ios14.0")]
	[Protocol (Name = "CPListTemplateItem", WrapperType = typeof (CPListTemplateItemWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "Text", Selector = "text", PropertyType = typeof (string), GetterSelector = "text", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "UserInfo", Selector = "userInfo", PropertyType = typeof (NSObject), GetterSelector = "userInfo", SetterSelector = "setUserInfo:", ArgumentSemantic = ArgumentSemantic.Retain)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "Enabled", Selector = "enabled", PropertyType = typeof (bool), GetterSelector = "isEnabled", SetterSelector = "setEnabled:", ArgumentSemantic = ArgumentSemantic.None)]
	public partial interface ICPListTemplateItem : INativeObject, IDisposable
	{
		[DynamicDependencyAttribute ("Enabled")]
		[DynamicDependencyAttribute ("Text")]
		[DynamicDependencyAttribute ("UserInfo")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (CPListTemplateItemWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static ICPListTemplateItem ()
		{
			GC.KeepAlive (null);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual string? Text {
			[Export ("text")]
			get {
				return _GetText (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static string _GetText (ICPListTemplateItem This)
		{
			string ret;
			ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("text")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual NSObject? UserInfo {
			[Export ("userInfo", ArgumentSemantic.Retain)]
			get {
				return _GetUserInfo (this);
			}
			[Export ("setUserInfo:", ArgumentSemantic.Retain)]
			set {
				_SetUserInfo (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSObject _GetUserInfo (ICPListTemplateItem This)
		{
			NSObject ret;
			ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("userInfo")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetUserInfo (ICPListTemplateItem This, NSObject? value)
		{
			var value__handle__ = value.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setUserInfo:"), value__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (value);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios15.0")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[global::Foundation.RequiredMember]
		public virtual bool Enabled {
			[Export ("isEnabled")]
			get {
				return _GetEnabled (this);
			}
			[Export ("setEnabled:")]
			set {
				_SetEnabled (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _GetEnabled (ICPListTemplateItem This)
		{
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("isEnabled"));
			GC.KeepAlive (This);
			return ret != 0;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetEnabled (ICPListTemplateItem This, bool value)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_bool (This.Handle, Selector.GetHandle ("setEnabled:"), value ? (byte) 1 : (byte) 0);
			GC.KeepAlive (This);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class CPListTemplateItemWrapper : BaseWrapper, ICPListTemplateItem {
		public CPListTemplateItemWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (CPListTemplateItemWrapper))]
		static CPListTemplateItemWrapper ()
		{
			GC.KeepAlive (null);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public string? Text {
			[Export ("text")]
			get {
				string ret;
				ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("text")), false)!;
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSObject? UserInfo {
			[Export ("userInfo", ArgumentSemantic.Retain)]
			get {
				NSObject ret;
				ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("userInfo")), false)!;
				return ret;
			}
			[Export ("setUserInfo:", ArgumentSemantic.Retain)]
			set {
				var value__handle__ = value.GetHandle ();
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setUserInfo:"), value__handle__);
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios15.0")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		public bool Enabled {
			[Export ("isEnabled")]
			get {
				byte ret;
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isEnabled"));
				return ret != 0;
			}
			[Export ("setEnabled:")]
			set {
				global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setEnabled:"), value ? (byte) 1 : (byte) 0);
			}
		}
	}
}
