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
	/// <summary>This interface represents the Objective-C protocol <c>UIContentView</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[SupportedOSPlatform ("tvos14.0")]
	[SupportedOSPlatform ("ios14.0")]
	[UnsupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("maccatalyst")]
	[Protocol (Name = "UIContentView", WrapperType = typeof (UIContentViewWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "SupportsConfiguration", Selector = "supportsConfiguration:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (IUIContentConfiguration) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "Configuration", Selector = "configuration", PropertyType = typeof (IUIContentConfiguration), GetterSelector = "configuration", SetterSelector = "setConfiguration:", ArgumentSemantic = ArgumentSemantic.Copy)]
	public partial interface IUIContentView : INativeObject, IDisposable
	{
		[global::Foundation.OptionalMember]
		[Export ("supportsConfiguration:")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[UnsupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool SupportsConfiguration (IUIContentConfiguration configuration)
		{
			return _SupportsConfiguration (this, configuration);
		}
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[UnsupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _SupportsConfiguration (IUIContentView This, IUIContentConfiguration configuration)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var configuration__handle__ = configuration!.GetNonNullHandle (nameof (configuration));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("supportsConfiguration:"), configuration__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (configuration);
			return ret != 0;
		}
		[DynamicDependencyAttribute ("Configuration")]
		[DynamicDependencyAttribute ("SupportsConfiguration(UIKit.IUIContentConfiguration)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UIContentViewWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IUIContentView ()
		{
			GC.KeepAlive (null);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual IUIContentConfiguration Configuration {
			[Export ("configuration", ArgumentSemantic.Copy)]
			get {
				return _GetConfiguration (this);
			}
			[Export ("setConfiguration:", ArgumentSemantic.Copy)]
			set {
				_SetConfiguration (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static IUIContentConfiguration _GetConfiguration (IUIContentView This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			IUIContentConfiguration ret;
			ret =  Runtime.GetINativeObject<IUIContentConfiguration> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("configuration")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetConfiguration (IUIContentView This, IUIContentConfiguration value)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var value__handle__ = value!.GetNonNullHandle (nameof (value));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setConfiguration:"), value__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (value);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="IUIContentView" /> interface to support all the methods from the UIContentView protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IUIContentView" /> interface allow developers to treat instances of the interface as having all the optional methods of the original UIContentView protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class UIContentView_Extensions {
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[UnsupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool SupportsConfiguration (this IUIContentView This, IUIContentConfiguration configuration)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var configuration__handle__ = configuration!.GetNonNullHandle (nameof (configuration));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("supportsConfiguration:"), configuration__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (configuration);
			return ret != 0;
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class UIContentViewWrapper : BaseWrapper, IUIContentView {
		public UIContentViewWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UIContentViewWrapper))]
		static UIContentViewWrapper ()
		{
			GC.KeepAlive (null);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public IUIContentConfiguration Configuration {
			[Export ("configuration", ArgumentSemantic.Copy)]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				IUIContentConfiguration ret;
				ret =  Runtime.GetINativeObject<IUIContentConfiguration> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("configuration")), false)!;
				return ret;
			}
			[Export ("setConfiguration:", ArgumentSemantic.Copy)]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				var value__handle__ = value!.GetNonNullHandle (nameof (value));
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setConfiguration:"), value__handle__);
				GC.KeepAlive (value);
			}
		}
	}
}
