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
	/// <summary>This interface represents the Objective-C protocol <c>UILayoutGuideAspectFitting</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[SupportedOSPlatform ("tvos16.0")]
	[SupportedOSPlatform ("ios16.0")]
	[SupportedOSPlatform ("maccatalyst16.0")]
	[Protocol (Name = "UILayoutGuideAspectFitting", WrapperType = typeof (UILayoutGuideAspectFittingWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "AspectRatio", Selector = "aspectRatio", PropertyType = typeof (NFloat), GetterSelector = "aspectRatio", SetterSelector = "setAspectRatio:", ArgumentSemantic = ArgumentSemantic.None)]
	public partial interface IUILayoutGuideAspectFitting : INativeObject, IDisposable
	{
		[DynamicDependencyAttribute ("AspectRatio")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UILayoutGuideAspectFittingWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IUILayoutGuideAspectFitting ()
		{
			GC.KeepAlive (null);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual nfloat AspectRatio {
			[Export ("aspectRatio")]
			get {
				return _GetAspectRatio (this);
			}
			[Export ("setAspectRatio:")]
			set {
				_SetAspectRatio (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static nfloat _GetAspectRatio (IUILayoutGuideAspectFitting This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			nfloat ret;
			ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend (This.Handle, Selector.GetHandle ("aspectRatio"));
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetAspectRatio (IUILayoutGuideAspectFitting This, nfloat value)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_nfloat (This.Handle, Selector.GetHandle ("setAspectRatio:"), value);
			GC.KeepAlive (This);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class UILayoutGuideAspectFittingWrapper : BaseWrapper, IUILayoutGuideAspectFitting {
		public UILayoutGuideAspectFittingWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UILayoutGuideAspectFittingWrapper))]
		static UILayoutGuideAspectFittingWrapper ()
		{
			GC.KeepAlive (null);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public nfloat AspectRatio {
			[Export ("aspectRatio")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				nfloat ret;
				ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend (this.Handle, Selector.GetHandle ("aspectRatio"));
				return ret;
			}
			[Export ("setAspectRatio:")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				global::ObjCRuntime.Messaging.void_objc_msgSend_nfloat (this.Handle, Selector.GetHandle ("setAspectRatio:"), value);
			}
		}
	}
}
