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
	/// <summary>This interface represents the Objective-C protocol <c>UIContextMenuInteractionDelegate</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[SupportedOSPlatform ("tvos17.0")]
	[SupportedOSPlatform ("ios13.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[Protocol (Name = "UIContextMenuInteractionDelegate", WrapperType = typeof (UIContextMenuInteractionDelegateWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetConfigurationForMenu", Selector = "contextMenuInteraction:configurationForMenuAtLocation:", ReturnType = typeof (UIContextMenuConfiguration), ParameterType = new Type [] { typeof (UIContextMenuInteraction), typeof (CGPoint) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetPreviewForHighlightingMenu", Selector = "contextMenuInteraction:previewForHighlightingMenuWithConfiguration:", ReturnType = typeof (UITargetedPreview), ParameterType = new Type [] { typeof (UIContextMenuInteraction), typeof (UIContextMenuConfiguration) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetPreviewForDismissingMenu", Selector = "contextMenuInteraction:previewForDismissingMenuWithConfiguration:", ReturnType = typeof (UITargetedPreview), ParameterType = new Type [] { typeof (UIContextMenuInteraction), typeof (UIContextMenuConfiguration) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillPerformPreviewAction", Selector = "contextMenuInteraction:willPerformPreviewActionForMenuWithConfiguration:animator:", ParameterType = new Type [] { typeof (UIContextMenuInteraction), typeof (UIContextMenuConfiguration), typeof (IUIContextMenuInteractionCommitAnimating) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillDisplayMenu", Selector = "contextMenuInteraction:willDisplayMenuForConfiguration:animator:", ParameterType = new Type [] { typeof (UIContextMenuInteraction), typeof (UIContextMenuConfiguration), typeof (IUIContextMenuInteractionAnimating) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillEnd", Selector = "contextMenuInteraction:willEndForConfiguration:animator:", ParameterType = new Type [] { typeof (UIContextMenuInteraction), typeof (UIContextMenuConfiguration), typeof (IUIContextMenuInteractionAnimating) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetHighlightPreview", Selector = "contextMenuInteraction:configuration:highlightPreviewForItemWithIdentifier:", ReturnType = typeof (UITargetedPreview), ParameterType = new Type [] { typeof (UIContextMenuInteraction), typeof (UIContextMenuConfiguration), typeof (INSCopying) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetDismissalPreview", Selector = "contextMenuInteraction:configuration:dismissalPreviewForItemWithIdentifier:", ReturnType = typeof (UITargetedPreview), ParameterType = new Type [] { typeof (UIContextMenuInteraction), typeof (UIContextMenuConfiguration), typeof (INSCopying) }, ParameterByRef = new bool [] { false, false, false })]
	public partial interface IUIContextMenuInteractionDelegate : INativeObject, IDisposable
	{
		[global::Foundation.RequiredMember]
		[Export ("contextMenuInteraction:configurationForMenuAtLocation:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIContextMenuConfiguration? GetConfigurationForMenu (UIContextMenuInteraction interaction, CGPoint location)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static UIContextMenuConfiguration? _GetConfigurationForMenu (IUIContextMenuInteractionDelegate This, UIContextMenuInteraction interaction, CGPoint location)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var interaction__handle__ = interaction!.GetNonNullHandle (nameof (interaction));
			UIContextMenuConfiguration? ret;
			ret =  Runtime.GetNSObject<UIContextMenuConfiguration> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_CGPoint (This.Handle, Selector.GetHandle ("contextMenuInteraction:configurationForMenuAtLocation:"), interaction__handle__, location), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (interaction);
			return ret!;
		}
		[global::Foundation.OptionalMember]
		[Export ("contextMenuInteraction:previewForHighlightingMenuWithConfiguration:")]
		[UnsupportedOSPlatform ("tvos")]
		[ObsoletedOSPlatform ("ios16.0")]
		[ObsoletedOSPlatform ("maccatalyst16.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UITargetedPreview? GetPreviewForHighlightingMenu (UIContextMenuInteraction interaction, UIContextMenuConfiguration configuration)
		{
			return _GetPreviewForHighlightingMenu (this, interaction, configuration);
		}
		[UnsupportedOSPlatform ("tvos")]
		[ObsoletedOSPlatform ("ios16.0")]
		[ObsoletedOSPlatform ("maccatalyst16.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static UITargetedPreview? _GetPreviewForHighlightingMenu (IUIContextMenuInteractionDelegate This, UIContextMenuInteraction interaction, UIContextMenuConfiguration configuration)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var interaction__handle__ = interaction!.GetNonNullHandle (nameof (interaction));
			var configuration__handle__ = configuration!.GetNonNullHandle (nameof (configuration));
			UITargetedPreview? ret;
			ret =  Runtime.GetNSObject<UITargetedPreview> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("contextMenuInteraction:previewForHighlightingMenuWithConfiguration:"), interaction__handle__, configuration__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (interaction);
			GC.KeepAlive (configuration);
			return ret!;
		}
		[global::Foundation.OptionalMember]
		[Export ("contextMenuInteraction:previewForDismissingMenuWithConfiguration:")]
		[UnsupportedOSPlatform ("tvos")]
		[ObsoletedOSPlatform ("ios16.0")]
		[ObsoletedOSPlatform ("maccatalyst16.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UITargetedPreview? GetPreviewForDismissingMenu (UIContextMenuInteraction interaction, UIContextMenuConfiguration configuration)
		{
			return _GetPreviewForDismissingMenu (this, interaction, configuration);
		}
		[UnsupportedOSPlatform ("tvos")]
		[ObsoletedOSPlatform ("ios16.0")]
		[ObsoletedOSPlatform ("maccatalyst16.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static UITargetedPreview? _GetPreviewForDismissingMenu (IUIContextMenuInteractionDelegate This, UIContextMenuInteraction interaction, UIContextMenuConfiguration configuration)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var interaction__handle__ = interaction!.GetNonNullHandle (nameof (interaction));
			var configuration__handle__ = configuration!.GetNonNullHandle (nameof (configuration));
			UITargetedPreview? ret;
			ret =  Runtime.GetNSObject<UITargetedPreview> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("contextMenuInteraction:previewForDismissingMenuWithConfiguration:"), interaction__handle__, configuration__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (interaction);
			GC.KeepAlive (configuration);
			return ret!;
		}
		[global::Foundation.OptionalMember]
		[Export ("contextMenuInteraction:willPerformPreviewActionForMenuWithConfiguration:animator:")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillPerformPreviewAction (UIContextMenuInteraction interaction, UIContextMenuConfiguration configuration, IUIContextMenuInteractionCommitAnimating animator)
		{
			_WillPerformPreviewAction (this, interaction, configuration, animator);
		}
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _WillPerformPreviewAction (IUIContextMenuInteractionDelegate This, UIContextMenuInteraction interaction, UIContextMenuConfiguration configuration, IUIContextMenuInteractionCommitAnimating animator)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var interaction__handle__ = interaction!.GetNonNullHandle (nameof (interaction));
			var configuration__handle__ = configuration!.GetNonNullHandle (nameof (configuration));
			var animator__handle__ = animator!.GetNonNullHandle (nameof (animator));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("contextMenuInteraction:willPerformPreviewActionForMenuWithConfiguration:animator:"), interaction__handle__, configuration__handle__, animator__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (interaction);
			GC.KeepAlive (configuration);
			GC.KeepAlive (animator);
		}
		[global::Foundation.OptionalMember]
		[Export ("contextMenuInteraction:willDisplayMenuForConfiguration:animator:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillDisplayMenu (UIContextMenuInteraction interaction, UIContextMenuConfiguration configuration, IUIContextMenuInteractionAnimating? animator)
		{
			_WillDisplayMenu (this, interaction, configuration, animator);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _WillDisplayMenu (IUIContextMenuInteractionDelegate This, UIContextMenuInteraction interaction, UIContextMenuConfiguration configuration, IUIContextMenuInteractionAnimating? animator)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var interaction__handle__ = interaction!.GetNonNullHandle (nameof (interaction));
			var configuration__handle__ = configuration!.GetNonNullHandle (nameof (configuration));
			var animator__handle__ = animator.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("contextMenuInteraction:willDisplayMenuForConfiguration:animator:"), interaction__handle__, configuration__handle__, animator__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (interaction);
			GC.KeepAlive (configuration);
			GC.KeepAlive (animator);
		}
		[global::Foundation.OptionalMember]
		[Export ("contextMenuInteraction:willEndForConfiguration:animator:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillEnd (UIContextMenuInteraction interaction, UIContextMenuConfiguration configuration, IUIContextMenuInteractionAnimating? animator)
		{
			_WillEnd (this, interaction, configuration, animator);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _WillEnd (IUIContextMenuInteractionDelegate This, UIContextMenuInteraction interaction, UIContextMenuConfiguration configuration, IUIContextMenuInteractionAnimating? animator)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var interaction__handle__ = interaction!.GetNonNullHandle (nameof (interaction));
			var configuration__handle__ = configuration!.GetNonNullHandle (nameof (configuration));
			var animator__handle__ = animator.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("contextMenuInteraction:willEndForConfiguration:animator:"), interaction__handle__, configuration__handle__, animator__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (interaction);
			GC.KeepAlive (configuration);
			GC.KeepAlive (animator);
		}
		[global::Foundation.OptionalMember]
		[Export ("contextMenuInteraction:configuration:highlightPreviewForItemWithIdentifier:")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[SupportedOSPlatform ("tvos17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UITargetedPreview? GetHighlightPreview (UIContextMenuInteraction interaction, UIContextMenuConfiguration configuration, INSCopying identifier)
		{
			return _GetHighlightPreview (this, interaction, configuration, identifier);
		}
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[SupportedOSPlatform ("tvos17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static UITargetedPreview? _GetHighlightPreview (IUIContextMenuInteractionDelegate This, UIContextMenuInteraction interaction, UIContextMenuConfiguration configuration, INSCopying identifier)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var interaction__handle__ = interaction!.GetNonNullHandle (nameof (interaction));
			var configuration__handle__ = configuration!.GetNonNullHandle (nameof (configuration));
			var identifier__handle__ = identifier!.GetNonNullHandle (nameof (identifier));
			UITargetedPreview? ret;
			ret =  Runtime.GetNSObject<UITargetedPreview> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("contextMenuInteraction:configuration:highlightPreviewForItemWithIdentifier:"), interaction__handle__, configuration__handle__, identifier__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (interaction);
			GC.KeepAlive (configuration);
			GC.KeepAlive (identifier);
			return ret!;
		}
		[global::Foundation.OptionalMember]
		[Export ("contextMenuInteraction:configuration:dismissalPreviewForItemWithIdentifier:")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[SupportedOSPlatform ("tvos17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UITargetedPreview? GetDismissalPreview (UIContextMenuInteraction interaction, UIContextMenuConfiguration configuration, INSCopying identifier)
		{
			return _GetDismissalPreview (this, interaction, configuration, identifier);
		}
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[SupportedOSPlatform ("tvos17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static UITargetedPreview? _GetDismissalPreview (IUIContextMenuInteractionDelegate This, UIContextMenuInteraction interaction, UIContextMenuConfiguration configuration, INSCopying identifier)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var interaction__handle__ = interaction!.GetNonNullHandle (nameof (interaction));
			var configuration__handle__ = configuration!.GetNonNullHandle (nameof (configuration));
			var identifier__handle__ = identifier!.GetNonNullHandle (nameof (identifier));
			UITargetedPreview? ret;
			ret =  Runtime.GetNSObject<UITargetedPreview> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("contextMenuInteraction:configuration:dismissalPreviewForItemWithIdentifier:"), interaction__handle__, configuration__handle__, identifier__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (interaction);
			GC.KeepAlive (configuration);
			GC.KeepAlive (identifier);
			return ret!;
		}
		[DynamicDependencyAttribute ("GetConfigurationForMenu(UIKit.UIContextMenuInteraction,CoreGraphics.CGPoint)")]
		[DynamicDependencyAttribute ("GetDismissalPreview(UIKit.UIContextMenuInteraction,UIKit.UIContextMenuConfiguration,Foundation.INSCopying)")]
		[DynamicDependencyAttribute ("GetHighlightPreview(UIKit.UIContextMenuInteraction,UIKit.UIContextMenuConfiguration,Foundation.INSCopying)")]
		[DynamicDependencyAttribute ("GetPreviewForDismissingMenu(UIKit.UIContextMenuInteraction,UIKit.UIContextMenuConfiguration)")]
		[DynamicDependencyAttribute ("GetPreviewForHighlightingMenu(UIKit.UIContextMenuInteraction,UIKit.UIContextMenuConfiguration)")]
		[DynamicDependencyAttribute ("WillDisplayMenu(UIKit.UIContextMenuInteraction,UIKit.UIContextMenuConfiguration,UIKit.IUIContextMenuInteractionAnimating)")]
		[DynamicDependencyAttribute ("WillEnd(UIKit.UIContextMenuInteraction,UIKit.UIContextMenuConfiguration,UIKit.IUIContextMenuInteractionAnimating)")]
		[DynamicDependencyAttribute ("WillPerformPreviewAction(UIKit.UIContextMenuInteraction,UIKit.UIContextMenuConfiguration,UIKit.IUIContextMenuInteractionCommitAnimating)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UIContextMenuInteractionDelegateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IUIContextMenuInteractionDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="IUIContextMenuInteractionDelegate" /> interface to support all the methods from the UIContextMenuInteractionDelegate protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IUIContextMenuInteractionDelegate" /> interface allow developers to treat instances of the interface as having all the optional methods of the original UIContextMenuInteractionDelegate protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class UIContextMenuInteractionDelegate_Extensions {
		[UnsupportedOSPlatform ("tvos")]
		[ObsoletedOSPlatform ("ios16.0")]
		[ObsoletedOSPlatform ("maccatalyst16.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static UITargetedPreview? GetPreviewForHighlightingMenu (this IUIContextMenuInteractionDelegate This, UIContextMenuInteraction interaction, UIContextMenuConfiguration configuration)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var interaction__handle__ = interaction!.GetNonNullHandle (nameof (interaction));
			var configuration__handle__ = configuration!.GetNonNullHandle (nameof (configuration));
			UITargetedPreview? ret;
			ret =  Runtime.GetNSObject<UITargetedPreview> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("contextMenuInteraction:previewForHighlightingMenuWithConfiguration:"), interaction__handle__, configuration__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (interaction);
			GC.KeepAlive (configuration);
			return ret!;
		}
		[UnsupportedOSPlatform ("tvos")]
		[ObsoletedOSPlatform ("ios16.0")]
		[ObsoletedOSPlatform ("maccatalyst16.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static UITargetedPreview? GetPreviewForDismissingMenu (this IUIContextMenuInteractionDelegate This, UIContextMenuInteraction interaction, UIContextMenuConfiguration configuration)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var interaction__handle__ = interaction!.GetNonNullHandle (nameof (interaction));
			var configuration__handle__ = configuration!.GetNonNullHandle (nameof (configuration));
			UITargetedPreview? ret;
			ret =  Runtime.GetNSObject<UITargetedPreview> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("contextMenuInteraction:previewForDismissingMenuWithConfiguration:"), interaction__handle__, configuration__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (interaction);
			GC.KeepAlive (configuration);
			return ret!;
		}
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void WillPerformPreviewAction (this IUIContextMenuInteractionDelegate This, UIContextMenuInteraction interaction, UIContextMenuConfiguration configuration, IUIContextMenuInteractionCommitAnimating animator)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var interaction__handle__ = interaction!.GetNonNullHandle (nameof (interaction));
			var configuration__handle__ = configuration!.GetNonNullHandle (nameof (configuration));
			var animator__handle__ = animator!.GetNonNullHandle (nameof (animator));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("contextMenuInteraction:willPerformPreviewActionForMenuWithConfiguration:animator:"), interaction__handle__, configuration__handle__, animator__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (interaction);
			GC.KeepAlive (configuration);
			GC.KeepAlive (animator);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void WillDisplayMenu (this IUIContextMenuInteractionDelegate This, UIContextMenuInteraction interaction, UIContextMenuConfiguration configuration, IUIContextMenuInteractionAnimating? animator)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var interaction__handle__ = interaction!.GetNonNullHandle (nameof (interaction));
			var configuration__handle__ = configuration!.GetNonNullHandle (nameof (configuration));
			var animator__handle__ = animator.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("contextMenuInteraction:willDisplayMenuForConfiguration:animator:"), interaction__handle__, configuration__handle__, animator__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (interaction);
			GC.KeepAlive (configuration);
			GC.KeepAlive (animator);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void WillEnd (this IUIContextMenuInteractionDelegate This, UIContextMenuInteraction interaction, UIContextMenuConfiguration configuration, IUIContextMenuInteractionAnimating? animator)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var interaction__handle__ = interaction!.GetNonNullHandle (nameof (interaction));
			var configuration__handle__ = configuration!.GetNonNullHandle (nameof (configuration));
			var animator__handle__ = animator.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("contextMenuInteraction:willEndForConfiguration:animator:"), interaction__handle__, configuration__handle__, animator__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (interaction);
			GC.KeepAlive (configuration);
			GC.KeepAlive (animator);
		}
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[SupportedOSPlatform ("tvos17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static UITargetedPreview? GetHighlightPreview (this IUIContextMenuInteractionDelegate This, UIContextMenuInteraction interaction, UIContextMenuConfiguration configuration, INSCopying identifier)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var interaction__handle__ = interaction!.GetNonNullHandle (nameof (interaction));
			var configuration__handle__ = configuration!.GetNonNullHandle (nameof (configuration));
			var identifier__handle__ = identifier!.GetNonNullHandle (nameof (identifier));
			UITargetedPreview? ret;
			ret =  Runtime.GetNSObject<UITargetedPreview> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("contextMenuInteraction:configuration:highlightPreviewForItemWithIdentifier:"), interaction__handle__, configuration__handle__, identifier__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (interaction);
			GC.KeepAlive (configuration);
			GC.KeepAlive (identifier);
			return ret!;
		}
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[SupportedOSPlatform ("tvos17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static UITargetedPreview? GetDismissalPreview (this IUIContextMenuInteractionDelegate This, UIContextMenuInteraction interaction, UIContextMenuConfiguration configuration, INSCopying identifier)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var interaction__handle__ = interaction!.GetNonNullHandle (nameof (interaction));
			var configuration__handle__ = configuration!.GetNonNullHandle (nameof (configuration));
			var identifier__handle__ = identifier!.GetNonNullHandle (nameof (identifier));
			UITargetedPreview? ret;
			ret =  Runtime.GetNSObject<UITargetedPreview> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("contextMenuInteraction:configuration:dismissalPreviewForItemWithIdentifier:"), interaction__handle__, configuration__handle__, identifier__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (interaction);
			GC.KeepAlive (configuration);
			GC.KeepAlive (identifier);
			return ret!;
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class UIContextMenuInteractionDelegateWrapper : BaseWrapper, IUIContextMenuInteractionDelegate {
		public UIContextMenuInteractionDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UIContextMenuInteractionDelegateWrapper))]
		static UIContextMenuInteractionDelegateWrapper ()
		{
			GC.KeepAlive (null);
		}
		[Export ("contextMenuInteraction:configurationForMenuAtLocation:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public UIContextMenuConfiguration? GetConfigurationForMenu (UIContextMenuInteraction interaction, CGPoint location)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var interaction__handle__ = interaction!.GetNonNullHandle (nameof (interaction));
			UIContextMenuConfiguration? ret;
			ret =  Runtime.GetNSObject<UIContextMenuConfiguration> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_CGPoint (this.Handle, Selector.GetHandle ("contextMenuInteraction:configurationForMenuAtLocation:"), interaction__handle__, location), false)!;
			GC.KeepAlive (interaction);
			return ret!;
		}
	}
}
namespace UIKit {
	/// <summary>
	///   <para>This is a class that implements the interface <see cref="IUIContextMenuInteractionDelegate" /> (for the protocol <c>UIContextMenuInteractionDelegate</c>).</para>
	///   <para>Subclass this class to easily create a type that implements the protocol.</para>
	///   <para>An alternative is to create a subclass of <see cref="NSObject" /> and then implemented the interface <see cref="IUIContextMenuInteractionDelegate" />.</para>
	/// </summary>
	[Protocol()]
	[Register("Microsoft_iOS__UIKit_UIContextMenuInteractionDelegate", false)]
	[Model]
	[SupportedOSPlatform ("tvos17.0")]
	[SupportedOSPlatform ("ios13.0")]
	[SupportedOSPlatform ("maccatalyst")]
	public unsafe abstract partial class UIContextMenuInteractionDelegate : NSObject, IUIContextMenuInteractionDelegate {
		/// <summary>Creates a new <see cref="UIContextMenuInteractionDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected UIContextMenuInteractionDelegate () : base (NSObjectFlag.Empty)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			IsDirectBinding = false;
			unsafe {
			var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
			InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			GC.KeepAlive (this);
			}
		}

		/// <summary>Constructor to call on derived classes to skip initialization and merely allocate the object.</summary>
		/// <param name="t">Unused sentinel value, pass NSObjectFlag.Empty.</param>
		/// <remarks>
		///     <para>
		///         This constructor should be called by derived classes when they completely construct the object in managed code and merely want the runtime to allocate and initialize the <see cref="Foundation.NSObject" />.
		///         This is required to implement the two-step initialization process that Objective-C uses, the first step is to perform the object allocation, the second step is to initialize the object.
		///         When developers invoke this constructor, they take advantage of a direct path that goes all the way up to <see cref="Foundation.NSObject" /> to merely allocate the object's memory and bind the Objective-C and C# objects together.
		///         The actual initialization of the object is up to the developer.
		///     </para>
		///     <para>
		///         This constructor is typically used by the binding generator to allocate the object, but prevent the actual initialization to take place.
		///         Once the allocation has taken place, the constructor has to initialize the object.
		///         With constructors generated by the binding generator this means that it manually invokes one of the "init" methods to initialize the object.
		///     </para>
		///     <para>It is the developer's responsibility to completely initialize the object if they chain up using this constructor chain.</para>
		///     <para>
		///         In general, if the developer's constructor invokes the corresponding base implementation, then it should also call an Objective-C init method.
		///         If this is not the case, developers should instead chain to the proper constructor in their class.
		///     </para>
		///     <para>
		///         The argument value is ignored and merely ensures that the only code that is executed is the construction phase is the basic <see cref="Foundation.NSObject" /> allocation and runtime type registration.
		///         Typically the chaining would look like this:
		///     </para>
		///     <example>
		///             <code lang="csharp lang-csharp"><![CDATA[
		/// //
		/// // The NSObjectFlag constructor merely allocates the object and registers the C# class with the Objective-C runtime if necessary.
		/// // No actual initXxx method is invoked, that is done later in the constructor
		/// //
		/// // This is taken from the iOS SDK's source code for the UIView class:
		/// //
		/// [Export ("initWithFrame:")]
		/// public UIView (CGRect frame) : base (NSObjectFlag.Empty)
		/// {
		///     // Invoke the init method now.
		///     var initWithFrame = new Selector ("initWithFrame:").Handle;
		///     if (IsDirectBinding) {
		///         Handle = ObjCRuntime.Messaging.IntPtr_objc_msgSend_CGRect (this.Handle, initWithFrame, frame);
		///     } else {
		///         unsafe {
		///             var __objc_super__ = new ObjCRuntime.ObjCSuper (this);
		///             Handle = ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_CGRect (&__objc_super__, initWithFrame, frame);
		///         }
		///         GC.KeepAlive (this);
		///     }
		/// }
		/// ]]></code>
		///     </example>
		/// </remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected UIContextMenuInteractionDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = false;
		}

		/// <summary>A constructor used when creating managed representations of unmanaged objects. Called by the runtime.</summary>
		/// <param name="handle">Pointer (handle) to the unmanaged object.</param>
		/// <remarks>
		///     <para>
		///         This constructor is invoked by the runtime infrastructure (<see cref="ObjCRuntime.Runtime.GetNSObject(System.IntPtr)" />) to create a new managed representation for a pointer to an unmanaged Objective-C object.
		///         Developers should not invoke this method directly, instead they should call <see cref="ObjCRuntime.Runtime.GetNSObject(System.IntPtr)" /> as it will prevent two instances of a managed object pointing to the same native object.
		///     </para>
		/// </remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal UIContextMenuInteractionDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		[Export ("contextMenuInteraction:configurationForMenuAtLocation:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIContextMenuConfiguration? GetConfigurationForMenu (UIContextMenuInteraction interaction, CGPoint location)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("contextMenuInteraction:configuration:dismissalPreviewForItemWithIdentifier:")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[SupportedOSPlatform ("tvos17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UITargetedPreview? GetDismissalPreview (UIContextMenuInteraction interaction, UIContextMenuConfiguration configuration, INSCopying identifier)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("contextMenuInteraction:configuration:highlightPreviewForItemWithIdentifier:")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[SupportedOSPlatform ("tvos17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UITargetedPreview? GetHighlightPreview (UIContextMenuInteraction interaction, UIContextMenuConfiguration configuration, INSCopying identifier)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("contextMenuInteraction:previewForDismissingMenuWithConfiguration:")]
		[UnsupportedOSPlatform ("tvos")]
		[ObsoletedOSPlatform ("ios16.0")]
		[ObsoletedOSPlatform ("maccatalyst16.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UITargetedPreview? GetPreviewForDismissingMenu (UIContextMenuInteraction interaction, UIContextMenuConfiguration configuration)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("contextMenuInteraction:previewForHighlightingMenuWithConfiguration:")]
		[UnsupportedOSPlatform ("tvos")]
		[ObsoletedOSPlatform ("ios16.0")]
		[ObsoletedOSPlatform ("maccatalyst16.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UITargetedPreview? GetPreviewForHighlightingMenu (UIContextMenuInteraction interaction, UIContextMenuConfiguration configuration)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("contextMenuInteraction:willDisplayMenuForConfiguration:animator:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillDisplayMenu (UIContextMenuInteraction interaction, UIContextMenuConfiguration configuration, IUIContextMenuInteractionAnimating? animator)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("contextMenuInteraction:willEndForConfiguration:animator:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillEnd (UIContextMenuInteraction interaction, UIContextMenuConfiguration configuration, IUIContextMenuInteractionAnimating? animator)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("contextMenuInteraction:willPerformPreviewActionForMenuWithConfiguration:animator:")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillPerformPreviewAction (UIContextMenuInteraction interaction, UIContextMenuConfiguration configuration, IUIContextMenuInteractionCommitAnimating animator)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class UIContextMenuInteractionDelegate */
}
