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
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Security;
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
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;
using MetalPerformanceShadersGraph;
#nullable enable
namespace TVUIKit {
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>TVLockupViewComponent</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[Protocol (Name = "TVLockupViewComponent", WrapperType = typeof (TVLockupViewComponentWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "UpdateAppearanceForLockupView", Selector = "updateAppearanceForLockupViewState:", ParameterType = new Type [] { typeof (UIControlState) }, ParameterByRef = new bool [] { false })]
	public partial interface ITVLockupViewComponent : INativeObject, IDisposable
	{
		[global::Foundation.OptionalMember]
		[Export ("updateAppearanceForLockupViewState:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void UpdateAppearanceForLockupView (global::UIKit.UIControlState state)
		{
			_UpdateAppearanceForLockupView (this, state);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _UpdateAppearanceForLockupView (ITVLockupViewComponent This, global::UIKit.UIControlState state)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (This.Handle, Selector.GetHandle ("updateAppearanceForLockupViewState:"), (UIntPtr) (ulong) state);
			GC.KeepAlive (This);
		}
		[DynamicDependencyAttribute ("UpdateAppearanceForLockupView(UIKit.UIControlState)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (TVLockupViewComponentWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static ITVLockupViewComponent ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="ITVLockupViewComponent" /> interface to support all the methods from the TVLockupViewComponent protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="ITVLockupViewComponent" /> interface allow developers to treat instances of the interface as having all the optional methods of the original TVLockupViewComponent protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class TVLockupViewComponent_Extensions {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void UpdateAppearanceForLockupView (this ITVLockupViewComponent This, global::UIKit.UIControlState state)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (This.Handle, Selector.GetHandle ("updateAppearanceForLockupViewState:"), (UIntPtr) (ulong) state);
			GC.KeepAlive (This);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class TVLockupViewComponentWrapper : BaseWrapper, ITVLockupViewComponent {
		public TVLockupViewComponentWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (TVLockupViewComponentWrapper))]
		static TVLockupViewComponentWrapper ()
		{
			GC.KeepAlive (null);
		}
	}
}
