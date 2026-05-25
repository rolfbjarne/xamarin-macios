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
	/// <summary>Interface defining necessary methods for the <see cref="T:CarPlay.ICPBarButtonProviding" /> protocol.</summary><remarks>To be added.</remarks>
	[UnsupportedOSPlatform ("tvos")]
	[UnsupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("ios")]
	[Protocol (Name = "CPBarButtonProviding", WrapperType = typeof (CPBarButtonProvidingWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "LeadingNavigationBarButtons", Selector = "leadingNavigationBarButtons", PropertyType = typeof (CarPlay.CPBarButton[]), GetterSelector = "leadingNavigationBarButtons", SetterSelector = "setLeadingNavigationBarButtons:", ArgumentSemantic = ArgumentSemantic.Retain)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "TrailingNavigationBarButtons", Selector = "trailingNavigationBarButtons", PropertyType = typeof (CarPlay.CPBarButton[]), GetterSelector = "trailingNavigationBarButtons", SetterSelector = "setTrailingNavigationBarButtons:", ArgumentSemantic = ArgumentSemantic.Retain)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "BackButton", Selector = "backButton", PropertyType = typeof (CarPlay.CPBarButton), GetterSelector = "backButton", SetterSelector = "setBackButton:", ArgumentSemantic = ArgumentSemantic.Retain)]
	public partial interface ICPBarButtonProviding : INativeObject, IDisposable
	{
		[DynamicDependencyAttribute ("BackButton")]
		[DynamicDependencyAttribute ("LeadingNavigationBarButtons")]
		[DynamicDependencyAttribute ("TrailingNavigationBarButtons")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (CPBarButtonProvidingWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static ICPBarButtonProviding ()
		{
			GC.KeepAlive (null);
		}
		/// <summary>Developers must override this with the array of <see cref="T:CarPlay.CPBarButton" /> objects on the leading part of the navigation bar.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual CPBarButton[] LeadingNavigationBarButtons {
			[Export ("leadingNavigationBarButtons", ArgumentSemantic.Retain)]
			get {
				return _GetLeadingNavigationBarButtons (this);
			}
			[Export ("setLeadingNavigationBarButtons:", ArgumentSemantic.Retain)]
			set {
				_SetLeadingNavigationBarButtons (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static CPBarButton[] _GetLeadingNavigationBarButtons (ICPBarButtonProviding This)
		{
			CPBarButton[] ret;
			ret = CFArray.ArrayFromHandle<CPBarButton>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("leadingNavigationBarButtons")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetLeadingNavigationBarButtons (ICPBarButtonProviding This, CPBarButton[] value)
		{
			if (value is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (value));
			using var nsa_value = NSArray.FromNSObjects (value);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setLeadingNavigationBarButtons:"), nsa_value.Handle);
			GC.KeepAlive (This);
		}
		/// <summary>Developers must override this with the array of <see cref="T:CarPlay.CPBarButton" /> objects on the trailing part of the navigation bar..</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual CPBarButton[] TrailingNavigationBarButtons {
			[Export ("trailingNavigationBarButtons", ArgumentSemantic.Retain)]
			get {
				return _GetTrailingNavigationBarButtons (this);
			}
			[Export ("setTrailingNavigationBarButtons:", ArgumentSemantic.Retain)]
			set {
				_SetTrailingNavigationBarButtons (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static CPBarButton[] _GetTrailingNavigationBarButtons (ICPBarButtonProviding This)
		{
			CPBarButton[] ret;
			ret = CFArray.ArrayFromHandle<CPBarButton>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("trailingNavigationBarButtons")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetTrailingNavigationBarButtons (ICPBarButtonProviding This, CPBarButton[] value)
		{
			if (value is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (value));
			using var nsa_value = NSArray.FromNSObjects (value);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setTrailingNavigationBarButtons:"), nsa_value.Handle);
			GC.KeepAlive (This);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual CPBarButton? BackButton {
			[Export ("backButton", ArgumentSemantic.Retain)]
			get {
				return _GetBackButton (this);
			}
			[Export ("setBackButton:", ArgumentSemantic.Retain)]
			set {
				_SetBackButton (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static CPBarButton _GetBackButton (ICPBarButtonProviding This)
		{
			CPBarButton ret;
			ret =  Runtime.GetNSObject<CPBarButton> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("backButton")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetBackButton (ICPBarButtonProviding This, CPBarButton? value)
		{
			var value__handle__ = value.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setBackButton:"), value__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (value);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class CPBarButtonProvidingWrapper : BaseWrapper, ICPBarButtonProviding {
		public CPBarButtonProvidingWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (CPBarButtonProvidingWrapper))]
		static CPBarButtonProvidingWrapper ()
		{
			GC.KeepAlive (null);
		}
		/// <summary>Developers must override this with the array of <see cref="T:CarPlay.CPBarButton" /> objects on the leading part of the navigation bar.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public CPBarButton[] LeadingNavigationBarButtons {
			[Export ("leadingNavigationBarButtons", ArgumentSemantic.Retain)]
			get {
				CPBarButton[] ret;
				ret = CFArray.ArrayFromHandle<CPBarButton>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("leadingNavigationBarButtons")), false)!;
				return ret;
			}
			[Export ("setLeadingNavigationBarButtons:", ArgumentSemantic.Retain)]
			set {
				if (value is null)
					ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (value));
				using var nsa_value = NSArray.FromNSObjects (value);
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setLeadingNavigationBarButtons:"), nsa_value.Handle);
			}
		}
		/// <summary>Developers must override this with the array of <see cref="T:CarPlay.CPBarButton" /> objects on the trailing part of the navigation bar..</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public CPBarButton[] TrailingNavigationBarButtons {
			[Export ("trailingNavigationBarButtons", ArgumentSemantic.Retain)]
			get {
				CPBarButton[] ret;
				ret = CFArray.ArrayFromHandle<CPBarButton>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("trailingNavigationBarButtons")), false)!;
				return ret;
			}
			[Export ("setTrailingNavigationBarButtons:", ArgumentSemantic.Retain)]
			set {
				if (value is null)
					ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (value));
				using var nsa_value = NSArray.FromNSObjects (value);
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setTrailingNavigationBarButtons:"), nsa_value.Handle);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public CPBarButton? BackButton {
			[Export ("backButton", ArgumentSemantic.Retain)]
			get {
				CPBarButton ret;
				ret =  Runtime.GetNSObject<CPBarButton> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("backButton")), false)!;
				return ret;
			}
			[Export ("setBackButton:", ArgumentSemantic.Retain)]
			set {
				var value__handle__ = value.GetHandle ();
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setBackButton:"), value__handle__);
				GC.KeepAlive (value);
			}
		}
	}
}
