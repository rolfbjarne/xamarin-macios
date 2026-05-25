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
namespace IntentsUI {
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>INUIHostedViewControlling</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[UnsupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[Protocol (Name = "INUIHostedViewControlling", WrapperType = typeof (INUIHostedViewControllingWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "Configure", Selector = "configureWithInteraction:context:completion:", ParameterType = new Type [] { typeof (Intents.INInteraction), typeof (IntentsUI.INUIHostedViewContext), typeof (global::System.Action<CGSize>) }, ParameterByRef = new bool [] { false, false, false }, ParameterBlockProxy = new Type? [] { null, null, typeof (ObjCRuntime.Trampolines.NIDActionArity1V217) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ConfigureView", Selector = "configureViewForParameters:ofInteraction:interactiveBehavior:context:completion:", ParameterType = new Type [] { typeof (global::Foundation.NSSet<global::Intents.INParameter>), typeof (Intents.INInteraction), typeof (IntentsUI.INUIInteractiveBehavior), typeof (IntentsUI.INUIHostedViewContext), typeof (IntentsUI.INUIHostedViewControllingConfigureViewHandler) }, ParameterByRef = new bool [] { false, false, false, false, false }, ParameterBlockProxy = new Type? [] { null, null, null, null, typeof (ObjCRuntime.Trampolines.NIDINUIHostedViewControllingConfigureViewHandler) })]
	public partial interface IINUIHostedViewControlling : INativeObject, IDisposable
	{
		/// <param name="interaction">To be added.</param><param name="context">To be added.</param><param name="completion">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("configureWithInteraction:context:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void Configure (global::Intents.INInteraction interaction, INUIHostedViewContext context, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V217))]global::System.Action<CGSize> completion)
		{
			_Configure (this, interaction, context, completion);
		}
		/// <param name="interaction">To be added.</param><param name="context">To be added.</param><param name="completion">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _Configure (IINUIHostedViewControlling This, global::Intents.INInteraction interaction, INUIHostedViewContext context, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V217))]global::System.Action<CGSize> completion)
		{
			var interaction__handle__ = interaction!.GetNonNullHandle (nameof (interaction));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V217.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr_NativeHandle (This.Handle, Selector.GetHandle ("configureWithInteraction:context:completion:"), interaction__handle__, (UIntPtr) (ulong) context, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (interaction);
		}
		/// <param name="parameters">To be added.</param><param name="interaction">To be added.</param><param name="interactiveBehavior">To be added.</param><param name="context">To be added.</param><param name="completionHandler">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("configureViewForParameters:ofInteraction:interactiveBehavior:context:completion:")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void ConfigureView (NSSet<global::Intents.INParameter> parameters, global::Intents.INInteraction interaction, INUIInteractiveBehavior interactiveBehavior, INUIHostedViewContext context, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDINUIHostedViewControllingConfigureViewHandler))]INUIHostedViewControllingConfigureViewHandler completionHandler)
		{
			_ConfigureView (this, parameters, interaction, interactiveBehavior, context, completionHandler);
		}
		/// <param name="parameters">To be added.</param><param name="interaction">To be added.</param><param name="interactiveBehavior">To be added.</param><param name="context">To be added.</param><param name="completionHandler">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _ConfigureView (IINUIHostedViewControlling This, NSSet<global::Intents.INParameter> parameters, global::Intents.INInteraction interaction, INUIInteractiveBehavior interactiveBehavior, INUIHostedViewContext context, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDINUIHostedViewControllingConfigureViewHandler))]INUIHostedViewControllingConfigureViewHandler completionHandler)
		{
			var parameters__handle__ = parameters!.GetNonNullHandle (nameof (parameters));
			var interaction__handle__ = interaction!.GetNonNullHandle (nameof (interaction));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDINUIHostedViewControllingConfigureViewHandler.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_UIntPtr_UIntPtr_NativeHandle (This.Handle, Selector.GetHandle ("configureViewForParameters:ofInteraction:interactiveBehavior:context:completion:"), parameters__handle__, interaction__handle__, (UIntPtr) (ulong) interactiveBehavior, (UIntPtr) (ulong) context, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
			GC.KeepAlive (parameters);
			GC.KeepAlive (interaction);
		}
		[DynamicDependencyAttribute ("Configure(Intents.INInteraction,IntentsUI.INUIHostedViewContext,System.Action{CoreGraphics.CGSize})")]
		[DynamicDependencyAttribute ("ConfigureView(Foundation.NSSet{Intents.INParameter},Intents.INInteraction,IntentsUI.INUIInteractiveBehavior,IntentsUI.INUIHostedViewContext,IntentsUI.INUIHostedViewControllingConfigureViewHandler)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (INUIHostedViewControllingWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IINUIHostedViewControlling ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="IINUIHostedViewControlling" /> interface to support all the methods from the INUIHostedViewControlling protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IINUIHostedViewControlling" /> interface allow developers to treat instances of the interface as having all the optional methods of the original INUIHostedViewControlling protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class INUIHostedViewControlling_Extensions {
		/// <param name="interaction">To be added.</param><param name="context">To be added.</param><param name="completion">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void Configure (this IINUIHostedViewControlling This, global::Intents.INInteraction interaction, INUIHostedViewContext context, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V217))]global::System.Action<CGSize> completion)
		{
			var interaction__handle__ = interaction!.GetNonNullHandle (nameof (interaction));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V217.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr_NativeHandle (This.Handle, Selector.GetHandle ("configureWithInteraction:context:completion:"), interaction__handle__, (UIntPtr) (ulong) context, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (interaction);
		}
		/// <param name="parameters">To be added.</param><param name="interaction">To be added.</param><param name="interactiveBehavior">To be added.</param><param name="context">To be added.</param><param name="completionHandler">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void ConfigureView (this IINUIHostedViewControlling This, NSSet<global::Intents.INParameter> parameters, global::Intents.INInteraction interaction, INUIInteractiveBehavior interactiveBehavior, INUIHostedViewContext context, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDINUIHostedViewControllingConfigureViewHandler))]INUIHostedViewControllingConfigureViewHandler completionHandler)
		{
			var parameters__handle__ = parameters!.GetNonNullHandle (nameof (parameters));
			var interaction__handle__ = interaction!.GetNonNullHandle (nameof (interaction));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDINUIHostedViewControllingConfigureViewHandler.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_UIntPtr_UIntPtr_NativeHandle (This.Handle, Selector.GetHandle ("configureViewForParameters:ofInteraction:interactiveBehavior:context:completion:"), parameters__handle__, interaction__handle__, (UIntPtr) (ulong) interactiveBehavior, (UIntPtr) (ulong) context, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
			GC.KeepAlive (parameters);
			GC.KeepAlive (interaction);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class INUIHostedViewControllingWrapper : BaseWrapper, IINUIHostedViewControlling {
		public INUIHostedViewControllingWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (INUIHostedViewControllingWrapper))]
		static INUIHostedViewControllingWrapper ()
		{
			GC.KeepAlive (null);
		}
	}
}
