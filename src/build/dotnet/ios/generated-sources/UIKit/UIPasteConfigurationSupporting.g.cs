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
	/// <summary>Interface defining methods for objects that support paste configuration.</summary>
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("maccatalyst16.0")]
	[SupportedOSPlatform ("ios")]
	[Protocol (Name = "UIPasteConfigurationSupporting", WrapperType = typeof (UIPasteConfigurationSupportingWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "Paste", Selector = "pasteItemProviders:", ParameterType = new Type [] { typeof (NSItemProvider[]) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "CanPaste", Selector = "canPasteItemProviders:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (NSItemProvider[]) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "PasteConfiguration", Selector = "pasteConfiguration", PropertyType = typeof (UIPasteConfiguration), GetterSelector = "pasteConfiguration", SetterSelector = "setPasteConfiguration:", ArgumentSemantic = ArgumentSemantic.Copy)]
	public partial interface IUIPasteConfigurationSupporting : INativeObject, IDisposable
	{
		/// <param name="itemProviders">The item providers for the items to paste.</param><summary>Performs the paste.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("pasteItemProviders:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Paste (NSItemProvider[] itemProviders)
		{
			_Paste (this, itemProviders);
		}
		/// <param name="itemProviders">The item providers for the items to paste.</param><summary>Performs the paste.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _Paste (IUIPasteConfigurationSupporting This, NSItemProvider[] itemProviders)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (itemProviders is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (itemProviders));
			using var nsa_itemProviders = NSArray.FromNSObjects (itemProviders);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("pasteItemProviders:"), nsa_itemProviders.Handle);
			GC.KeepAlive (This);
		}
		/// <param name="itemProviders">The ittem providers to check.</param><summary>Returns <see langword="true" /> if the responder can paste from the specified item providers.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("canPasteItemProviders:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool CanPaste (NSItemProvider[] itemProviders)
		{
			return _CanPaste (this, itemProviders);
		}
		/// <param name="itemProviders">The ittem providers to check.</param><summary>Returns <see langword="true" /> if the responder can paste from the specified item providers.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _CanPaste (IUIPasteConfigurationSupporting This, NSItemProvider[] itemProviders)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (itemProviders is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (itemProviders));
			using var nsa_itemProviders = NSArray.FromNSObjects (itemProviders);
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("canPasteItemProviders:"), nsa_itemProviders.Handle);
			GC.KeepAlive (This);
			return ret != 0;
		}
		[DynamicDependencyAttribute ("CanPaste(Foundation.NSItemProvider[])")]
		[DynamicDependencyAttribute ("Paste(Foundation.NSItemProvider[])")]
		[DynamicDependencyAttribute ("PasteConfiguration")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UIPasteConfigurationSupportingWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IUIPasteConfigurationSupporting ()
		{
			GC.KeepAlive (null);
		}
		/// <summary>The <see cref="T:UIKit.UIPasteConfiguration" /> supported by <see langword="this" /> object.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual UIPasteConfiguration? PasteConfiguration {
			[Export ("pasteConfiguration", ArgumentSemantic.Copy)]
			get {
				return _GetPasteConfiguration (this);
			}
			[Export ("setPasteConfiguration:", ArgumentSemantic.Copy)]
			set {
				_SetPasteConfiguration (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static UIPasteConfiguration _GetPasteConfiguration (IUIPasteConfigurationSupporting This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			UIPasteConfiguration ret;
			ret =  Runtime.GetNSObject<UIPasteConfiguration> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("pasteConfiguration")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetPasteConfiguration (IUIPasteConfigurationSupporting This, UIPasteConfiguration? value)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var value__handle__ = value.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setPasteConfiguration:"), value__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (value);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="IUIPasteConfigurationSupporting" /> interface to support all the methods from the UIPasteConfigurationSupporting protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IUIPasteConfigurationSupporting" /> interface allow developers to treat instances of the interface as having all the optional methods of the original UIPasteConfigurationSupporting protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class UIPasteConfigurationSupporting_Extensions {
		/// <param name="itemProviders">The item providers for the items to paste.</param><summary>Performs the paste.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void Paste (this IUIPasteConfigurationSupporting This, NSItemProvider[] itemProviders)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (itemProviders is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (itemProviders));
			using var nsa_itemProviders = NSArray.FromNSObjects (itemProviders);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("pasteItemProviders:"), nsa_itemProviders.Handle);
			GC.KeepAlive (This);
		}
		/// <param name="itemProviders">The ittem providers to check.</param><summary>Returns <see langword="true" /> if the responder can paste from the specified item providers.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool CanPaste (this IUIPasteConfigurationSupporting This, NSItemProvider[] itemProviders)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (itemProviders is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (itemProviders));
			using var nsa_itemProviders = NSArray.FromNSObjects (itemProviders);
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("canPasteItemProviders:"), nsa_itemProviders.Handle);
			GC.KeepAlive (This);
			return ret != 0;
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class UIPasteConfigurationSupportingWrapper : BaseWrapper, IUIPasteConfigurationSupporting {
		public UIPasteConfigurationSupportingWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UIPasteConfigurationSupportingWrapper))]
		static UIPasteConfigurationSupportingWrapper ()
		{
			GC.KeepAlive (null);
		}
		/// <summary>The <see cref="T:UIKit.UIPasteConfiguration" /> supported by <see langword="this" /> object.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public UIPasteConfiguration? PasteConfiguration {
			[Export ("pasteConfiguration", ArgumentSemantic.Copy)]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UIPasteConfiguration ret;
				ret =  Runtime.GetNSObject<UIPasteConfiguration> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("pasteConfiguration")), false)!;
				return ret;
			}
			[Export ("setPasteConfiguration:", ArgumentSemantic.Copy)]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				var value__handle__ = value.GetHandle ();
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setPasteConfiguration:"), value__handle__);
				GC.KeepAlive (value);
			}
		}
	}
}
