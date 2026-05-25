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
	/// <summary>Interface for applying state-based visual styles to spring-loaded interactions.</summary>
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[Protocol (Name = "UISpringLoadedInteractionEffect", WrapperType = typeof (UISpringLoadedInteractionEffectWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "DidChange", Selector = "interaction:didChangeWithContext:", ParameterType = new Type [] { typeof (UISpringLoadedInteraction), typeof (IUISpringLoadedInteractionContext) }, ParameterByRef = new bool [] { false, false })]
	public partial interface IUISpringLoadedInteractionEffect : INativeObject, IDisposable
	{
		/// <param name="interaction">The interaction whose state has changed.</param><param name="context">The interaction context.</param><summary>Method that is called when the interaction state changes.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("interaction:didChangeWithContext:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidChange (UISpringLoadedInteraction interaction, IUISpringLoadedInteractionContext context)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="interaction">The interaction whose state has changed.</param><param name="context">The interaction context.</param><summary>Method that is called when the interaction state changes.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidChange (IUISpringLoadedInteractionEffect This, UISpringLoadedInteraction interaction, IUISpringLoadedInteractionContext context)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var interaction__handle__ = interaction!.GetNonNullHandle (nameof (interaction));
			var context__handle__ = context!.GetNonNullHandle (nameof (context));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("interaction:didChangeWithContext:"), interaction__handle__, context__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (interaction);
			GC.KeepAlive (context);
		}
		[DynamicDependencyAttribute ("DidChange(UIKit.UISpringLoadedInteraction,UIKit.IUISpringLoadedInteractionContext)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UISpringLoadedInteractionEffectWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IUISpringLoadedInteractionEffect ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class UISpringLoadedInteractionEffectWrapper : BaseWrapper, IUISpringLoadedInteractionEffect {
		public UISpringLoadedInteractionEffectWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UISpringLoadedInteractionEffectWrapper))]
		static UISpringLoadedInteractionEffectWrapper ()
		{
			GC.KeepAlive (null);
		}
		/// <param name="interaction">The interaction whose state has changed.</param><param name="context">The interaction context.</param><summary>Method that is called when the interaction state changes.</summary><remarks>To be added.</remarks>
		[Export ("interaction:didChangeWithContext:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void DidChange (UISpringLoadedInteraction interaction, IUISpringLoadedInteractionContext context)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var interaction__handle__ = interaction!.GetNonNullHandle (nameof (interaction));
			var context__handle__ = context!.GetNonNullHandle (nameof (context));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("interaction:didChangeWithContext:"), interaction__handle__, context__handle__);
			GC.KeepAlive (interaction);
			GC.KeepAlive (context);
		}
	}
}
