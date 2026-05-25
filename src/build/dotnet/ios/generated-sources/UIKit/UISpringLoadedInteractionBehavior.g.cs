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
	/// <summary>Interface for specifying spring-loaded interaction behavior.</summary>
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[Protocol (Name = "UISpringLoadedInteractionBehavior", WrapperType = typeof (UISpringLoadedInteractionBehaviorWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "ShouldAllowInteraction", Selector = "shouldAllowInteraction:withContext:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (UISpringLoadedInteraction), typeof (IUISpringLoadedInteractionContext) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "InteractionDidFinish", Selector = "interactionDidFinish:", ParameterType = new Type [] { typeof (UISpringLoadedInteraction) }, ParameterByRef = new bool [] { false })]
	public partial interface IUISpringLoadedInteractionBehavior : INativeObject, IDisposable
	{
		/// <param name="interaction">The interaction to check.</param><param name="context">The context to query.</param><summary>Returns a Boolean value that tells whether spring-loading should start or continue for the specified <paramref name="context" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("shouldAllowInteraction:withContext:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldAllowInteraction (UISpringLoadedInteraction interaction, IUISpringLoadedInteractionContext context)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="interaction">The interaction to check.</param><param name="context">The context to query.</param><summary>Returns a Boolean value that tells whether spring-loading should start or continue for the specified <paramref name="context" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _ShouldAllowInteraction (IUISpringLoadedInteractionBehavior This, UISpringLoadedInteraction interaction, IUISpringLoadedInteractionContext context)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var interaction__handle__ = interaction!.GetNonNullHandle (nameof (interaction));
			var context__handle__ = context!.GetNonNullHandle (nameof (context));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("shouldAllowInteraction:withContext:"), interaction__handle__, context__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (interaction);
			GC.KeepAlive (context);
			return ret != 0;
		}
		/// <param name="interaction">The interaction that finished.</param><summary>Method that is called when the user cancels or carries out the spring-loaded interaction.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("interactionDidFinish:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void InteractionDidFinish (UISpringLoadedInteraction interaction)
		{
			_InteractionDidFinish (this, interaction);
		}
		/// <param name="interaction">The interaction that finished.</param><summary>Method that is called when the user cancels or carries out the spring-loaded interaction.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _InteractionDidFinish (IUISpringLoadedInteractionBehavior This, UISpringLoadedInteraction interaction)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var interaction__handle__ = interaction!.GetNonNullHandle (nameof (interaction));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("interactionDidFinish:"), interaction__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (interaction);
		}
		[DynamicDependencyAttribute ("InteractionDidFinish(UIKit.UISpringLoadedInteraction)")]
		[DynamicDependencyAttribute ("ShouldAllowInteraction(UIKit.UISpringLoadedInteraction,UIKit.IUISpringLoadedInteractionContext)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UISpringLoadedInteractionBehaviorWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IUISpringLoadedInteractionBehavior ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="IUISpringLoadedInteractionBehavior" /> interface to support all the methods from the UISpringLoadedInteractionBehavior protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IUISpringLoadedInteractionBehavior" /> interface allow developers to treat instances of the interface as having all the optional methods of the original UISpringLoadedInteractionBehavior protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class UISpringLoadedInteractionBehavior_Extensions {
		/// <param name="interaction">The interaction that finished.</param><summary>Method that is called when the user cancels or carries out the spring-loaded interaction.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void InteractionDidFinish (this IUISpringLoadedInteractionBehavior This, UISpringLoadedInteraction interaction)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var interaction__handle__ = interaction!.GetNonNullHandle (nameof (interaction));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("interactionDidFinish:"), interaction__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (interaction);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class UISpringLoadedInteractionBehaviorWrapper : BaseWrapper, IUISpringLoadedInteractionBehavior {
		public UISpringLoadedInteractionBehaviorWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UISpringLoadedInteractionBehaviorWrapper))]
		static UISpringLoadedInteractionBehaviorWrapper ()
		{
			GC.KeepAlive (null);
		}
		/// <param name="interaction">The interaction to check.</param><param name="context">The context to query.</param><summary>Returns a Boolean value that tells whether spring-loading should start or continue for the specified <paramref name="context" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("shouldAllowInteraction:withContext:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public bool ShouldAllowInteraction (UISpringLoadedInteraction interaction, IUISpringLoadedInteractionContext context)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var interaction__handle__ = interaction!.GetNonNullHandle (nameof (interaction));
			var context__handle__ = context!.GetNonNullHandle (nameof (context));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("shouldAllowInteraction:withContext:"), interaction__handle__, context__handle__);
			GC.KeepAlive (interaction);
			GC.KeepAlive (context);
			return ret != 0;
		}
	}
}
