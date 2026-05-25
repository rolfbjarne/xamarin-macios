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
	/// <summary>This interface represents the Objective-C protocol <c>CPSelectableListItem</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[UnsupportedOSPlatform ("tvos")]
	[UnsupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("ios14.0")]
	[Protocol (Name = "CPSelectableListItem", WrapperType = typeof (CPSelectableListItemWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "Handler", Selector = "handler", PropertyType = typeof (CarPlay.CPSelectableListItemHandler), GetterSelector = "handler", SetterSelector = "setHandler:", ArgumentSemantic = ArgumentSemantic.Copy, ParameterBlockProxy = new Type [] { typeof (ObjCRuntime.Trampolines.NIDCPSelectableListItemHandler) }, ReturnTypeDelegateProxy = typeof (ObjCRuntime.Trampolines.SDCPSelectableListItemHandler))]
	public partial interface ICPSelectableListItem : INativeObject, IDisposable, 
		CarPlay.ICPListTemplateItem
	{
		[DynamicDependencyAttribute ("Handler")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (CPSelectableListItemWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static ICPSelectableListItem ()
		{
			GC.KeepAlive (null);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public unsafe virtual CPSelectableListItemHandler? Handler {
			[return: DelegateProxy (typeof (ObjCRuntime.Trampolines.SDCPSelectableListItemHandler))]
			[Export ("handler", ArgumentSemantic.Copy)]
			get {
				return _GetHandler (this);
			}
			[param: BlockProxy (typeof (ObjCRuntime.Trampolines.NIDCPSelectableListItemHandler))]
			[Export ("setHandler:", ArgumentSemantic.Copy)]
			set {
				_SetHandler (this, value);
			}
		}
		[return: DelegateProxy (typeof (ObjCRuntime.Trampolines.SDCPSelectableListItemHandler))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static CPSelectableListItemHandler _GetHandler (ICPSelectableListItem This)
		{
			NativeHandle ret;
			ret = global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("handler"));
			GC.KeepAlive (This);
			return global::ObjCRuntime.Trampolines.NIDCPSelectableListItemHandler.Create (ret)!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _SetHandler (ICPSelectableListItem This, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDCPSelectableListItemHandler))]CPSelectableListItemHandler? value)
		{
			using var block_value = Trampolines.SDCPSelectableListItemHandler.CreateNullableBlock (value);
			BlockLiteral *block_ptr_value = null;
			if (value is not null)
				block_ptr_value = &block_value;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setHandler:"), (IntPtr) block_ptr_value);
			GC.KeepAlive (This);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class CPSelectableListItemWrapper : BaseWrapper, ICPSelectableListItem {
		public CPSelectableListItemWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (CPSelectableListItemWrapper))]
		static CPSelectableListItemWrapper ()
		{
			GC.KeepAlive (null);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe CPSelectableListItemHandler? Handler {
			[return: DelegateProxy (typeof (ObjCRuntime.Trampolines.SDCPSelectableListItemHandler))]
			[Export ("handler", ArgumentSemantic.Copy)]
			get {
				NativeHandle ret;
				ret = global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("handler"));
				return global::ObjCRuntime.Trampolines.NIDCPSelectableListItemHandler.Create (ret)!;
			}
			[param: BlockProxy (typeof (ObjCRuntime.Trampolines.NIDCPSelectableListItemHandler))]
			[Export ("setHandler:", ArgumentSemantic.Copy)]
			set {
				using var block_value = Trampolines.SDCPSelectableListItemHandler.CreateNullableBlock (value);
				BlockLiteral *block_ptr_value = null;
				if (value is not null)
					block_ptr_value = &block_value;
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setHandler:"), (IntPtr) block_ptr_value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios14.0")]
		public string? Text {
			[Export ("text")]
			[UnsupportedOSPlatform ("tvos")]
			[UnsupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("ios14.0")]
			get {
				string ret;
				ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("text")), false)!;
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios14.0")]
		public NSObject? UserInfo {
			[Export ("userInfo", ArgumentSemantic.Retain)]
			[UnsupportedOSPlatform ("tvos")]
			[UnsupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("ios14.0")]
			get {
				NSObject ret;
				ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("userInfo")), false)!;
				return ret;
			}
			[Export ("setUserInfo:", ArgumentSemantic.Retain)]
			[UnsupportedOSPlatform ("tvos")]
			[UnsupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("ios14.0")]
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
			[UnsupportedOSPlatform ("tvos")]
			[UnsupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("ios15.0")]
			[UnsupportedOSPlatform ("maccatalyst")]
			get {
				byte ret;
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isEnabled"));
				return ret != 0;
			}
			[Export ("setEnabled:")]
			[UnsupportedOSPlatform ("tvos")]
			[UnsupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("ios15.0")]
			[UnsupportedOSPlatform ("maccatalyst")]
			set {
				global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setEnabled:"), value ? (byte) 1 : (byte) 0);
			}
		}
	}
}
