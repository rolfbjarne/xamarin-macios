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
using Metal;
using CoreML;
using OpenGL;
using AppKit;
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Contacts;
using Security;
using CloudKit;
using AudioUnit;
using CoreVideo;
using CoreMedia;
using CoreImage;
using SpriteKit;
using Foundation;
using ObjCRuntime;
using MediaPlayer;
using GameplayKit;
using CoreGraphics;
using CoreLocation;
using AVFoundation;
using FileProvider;
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;
using MetalPerformanceShadersGraph;
#nullable enable
namespace AppKit {
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>NSFontChanging</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[Protocol (Name = "NSFontChanging", WrapperType = typeof (NSFontChangingWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ChangeFont", Selector = "changeFont:", ParameterType = new Type [] { typeof (NSFontManager) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetValidModes", Selector = "validModesForFontPanel:", ReturnType = typeof (NSFontPanelModeMask), ParameterType = new Type [] { typeof (NSFontPanel) }, ParameterByRef = new bool [] { false })]
	public partial interface INSFontChanging : INativeObject, IDisposable
	{
		/// <param name="sender">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("changeFont:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ChangeFont (NSFontManager? sender)
		{
			_ChangeFont (this, sender);
		}
		/// <param name="sender">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _ChangeFont (INSFontChanging This, NSFontManager? sender)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var sender__handle__ = sender.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("changeFont:"), sender__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
		}
		/// <param name="fontPanel">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("validModesForFontPanel:")]
		[ObsoletedOSPlatform ("macos11.0", "Now optional method.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSFontPanelModeMask GetValidModes (NSFontPanel fontPanel)
		{
			return _GetValidModes (this, fontPanel);
		}
		/// <param name="fontPanel">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[ObsoletedOSPlatform ("macos11.0", "Now optional method.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSFontPanelModeMask _GetValidModes (INSFontChanging This, NSFontPanel fontPanel)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var fontPanel__handle__ = fontPanel!.GetNonNullHandle (nameof (fontPanel));
			NSFontPanelModeMask ret;
			ret = (NSFontPanelModeMask) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("validModesForFontPanel:"), fontPanel__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (fontPanel);
			return ret!;
		}
		[DynamicDependencyAttribute ("ChangeFont(AppKit.NSFontManager)")]
		[DynamicDependencyAttribute ("GetValidModes(AppKit.NSFontPanel)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSFontChangingWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static INSFontChanging ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="INSFontChanging" /> interface to support all the methods from the NSFontChanging protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="INSFontChanging" /> interface allow developers to treat instances of the interface as having all the optional methods of the original NSFontChanging protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class NSFontChanging_Extensions {
		/// <param name="sender">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void ChangeFont (this INSFontChanging This, NSFontManager? sender)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var sender__handle__ = sender.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("changeFont:"), sender__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
		}
		/// <param name="fontPanel">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[ObsoletedOSPlatform ("macos11.0", "Now optional method.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSFontPanelModeMask GetValidModes (this INSFontChanging This, NSFontPanel fontPanel)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var fontPanel__handle__ = fontPanel!.GetNonNullHandle (nameof (fontPanel));
			NSFontPanelModeMask ret;
			ret = (NSFontPanelModeMask) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("validModesForFontPanel:"), fontPanel__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (fontPanel);
			return ret!;
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class NSFontChangingWrapper : BaseWrapper, INSFontChanging {
		public NSFontChangingWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSFontChangingWrapper))]
		static NSFontChangingWrapper ()
		{
			GC.KeepAlive (null);
		}
	}
}
