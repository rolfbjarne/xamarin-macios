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
namespace UIKit {
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>UIInputViewAudioFeedback</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("tvos")]
	[Protocol (Name = "UIInputViewAudioFeedback", WrapperType = typeof (UIInputViewAudioFeedbackWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "EnableInputClicksWhenVisible", Selector = "enableInputClicksWhenVisible", PropertyType = typeof (bool), GetterSelector = "enableInputClicksWhenVisible", ArgumentSemantic = ArgumentSemantic.None)]
	public partial interface IUIInputViewAudioFeedback : INativeObject, IDisposable
	{
		[DynamicDependencyAttribute ("EnableInputClicksWhenVisible")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UIInputViewAudioFeedbackWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IUIInputViewAudioFeedback ()
		{
			GC.KeepAlive (null);
		}
		/// <summary>Gets a value that tells whether input clicks are enabled.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.OptionalMember]
		public virtual bool EnableInputClicksWhenVisible {
			[Export ("enableInputClicksWhenVisible")]
			get {
				return _GetEnableInputClicksWhenVisible (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _GetEnableInputClicksWhenVisible (IUIInputViewAudioFeedback This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("enableInputClicksWhenVisible"));
			GC.KeepAlive (This);
			return ret != 0;
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="IUIInputViewAudioFeedback" /> interface to support all the methods from the UIInputViewAudioFeedback protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IUIInputViewAudioFeedback" /> interface allow developers to treat instances of the interface as having all the optional methods of the original UIInputViewAudioFeedback protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class UIInputViewAudioFeedback_Extensions {
		/// <summary>Gets a value that tells whether input clicks are enabled.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool GetEnableInputClicksWhenVisible (this IUIInputViewAudioFeedback This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("enableInputClicksWhenVisible"));
			GC.KeepAlive (This);
			return ret != 0;
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class UIInputViewAudioFeedbackWrapper : BaseWrapper, IUIInputViewAudioFeedback {
		public UIInputViewAudioFeedbackWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UIInputViewAudioFeedbackWrapper))]
		static UIInputViewAudioFeedbackWrapper ()
		{
			GC.KeepAlive (null);
		}
	}
}
