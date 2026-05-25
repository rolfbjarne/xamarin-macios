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
	/// <summary>This interface represents the Objective-C protocol <c>NSLayerDelegateContentsScaleUpdating</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[Protocol (Name = "NSLayerDelegateContentsScaleUpdating", WrapperType = typeof (NSLayerDelegateContentsScaleUpdatingWrapper), IsInformal = true)]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldInheritContentsScale", Selector = "layer:shouldInheritContentsScale:fromWindow:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (CALayer), typeof (NFloat), typeof (NSWindow) }, ParameterByRef = new bool [] { false, false, false })]
	public partial interface INSLayerDelegateContentsScaleUpdating : INativeObject, IDisposable
	{
		/// <param name="layer">To be added.</param><param name="newScale">To be added.</param><param name="fromWindow">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("layer:shouldInheritContentsScale:fromWindow:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldInheritContentsScale (global::CoreAnimation.CALayer layer, nfloat newScale, NSWindow fromWindow)
		{
			return _ShouldInheritContentsScale (this, layer, newScale, fromWindow);
		}
		/// <param name="layer">To be added.</param><param name="newScale">To be added.</param><param name="fromWindow">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _ShouldInheritContentsScale (INSLayerDelegateContentsScaleUpdating This, global::CoreAnimation.CALayer layer, nfloat newScale, NSWindow fromWindow)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var layer__handle__ = layer!.GetNonNullHandle (nameof (layer));
			var fromWindow__handle__ = fromWindow!.GetNonNullHandle (nameof (fromWindow));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_nfloat_NativeHandle (This.Handle, Selector.GetHandle ("layer:shouldInheritContentsScale:fromWindow:"), layer__handle__, newScale, fromWindow__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (layer);
			GC.KeepAlive (fromWindow);
			return ret != 0;
		}
		[DynamicDependencyAttribute ("ShouldInheritContentsScale(CoreAnimation.CALayer,System.Runtime.InteropServices.NFloat,AppKit.NSWindow)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSLayerDelegateContentsScaleUpdatingWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static INSLayerDelegateContentsScaleUpdating ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="INSLayerDelegateContentsScaleUpdating" /> interface to support all the methods from the NSLayerDelegateContentsScaleUpdating protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="INSLayerDelegateContentsScaleUpdating" /> interface allow developers to treat instances of the interface as having all the optional methods of the original NSLayerDelegateContentsScaleUpdating protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class NSLayerDelegateContentsScaleUpdating_Extensions {
		/// <param name="layer">To be added.</param><param name="newScale">To be added.</param><param name="fromWindow">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool ShouldInheritContentsScale (this INSLayerDelegateContentsScaleUpdating This, global::CoreAnimation.CALayer layer, nfloat newScale, NSWindow fromWindow)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var layer__handle__ = layer!.GetNonNullHandle (nameof (layer));
			var fromWindow__handle__ = fromWindow!.GetNonNullHandle (nameof (fromWindow));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_nfloat_NativeHandle (This.Handle, Selector.GetHandle ("layer:shouldInheritContentsScale:fromWindow:"), layer__handle__, newScale, fromWindow__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (layer);
			GC.KeepAlive (fromWindow);
			return ret != 0;
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class NSLayerDelegateContentsScaleUpdatingWrapper : BaseWrapper, INSLayerDelegateContentsScaleUpdating {
		public NSLayerDelegateContentsScaleUpdatingWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSLayerDelegateContentsScaleUpdatingWrapper))]
		static NSLayerDelegateContentsScaleUpdatingWrapper ()
		{
			GC.KeepAlive (null);
		}
	}
}
