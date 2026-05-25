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
	/// <summary>This interface represents the Objective-C protocol <c>UILetterformAwareAdjusting</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[SupportedOSPlatform ("tvos17.0")]
	[SupportedOSPlatform ("ios17.0")]
	[SupportedOSPlatform ("maccatalyst17.0")]
	[Protocol (Name = "UILetterformAwareAdjusting", WrapperType = typeof (UILetterformAwareAdjustingWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "SizingRule", Selector = "sizingRule", PropertyType = typeof (UILetterformAwareSizingRule), GetterSelector = "sizingRule", SetterSelector = "setSizingRule:", ArgumentSemantic = ArgumentSemantic.Assign)]
	public partial interface IUILetterformAwareAdjusting : INativeObject, IDisposable
	{
		[DynamicDependencyAttribute ("SizingRule")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UILetterformAwareAdjustingWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IUILetterformAwareAdjusting ()
		{
			GC.KeepAlive (null);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual UILetterformAwareSizingRule SizingRule {
			[Export ("sizingRule", ArgumentSemantic.Assign)]
			get {
				return _GetSizingRule (this);
			}
			[Export ("setSizingRule:", ArgumentSemantic.Assign)]
			set {
				_SetSizingRule (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static UILetterformAwareSizingRule _GetSizingRule (IUILetterformAwareAdjusting This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			UILetterformAwareSizingRule ret;
			ret = (UILetterformAwareSizingRule) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("sizingRule"));
			GC.KeepAlive (This);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetSizingRule (IUILetterformAwareAdjusting This, UILetterformAwareSizingRule value)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setSizingRule:"), (IntPtr) (long) value);
			GC.KeepAlive (This);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class UILetterformAwareAdjustingWrapper : BaseWrapper, IUILetterformAwareAdjusting {
		public UILetterformAwareAdjustingWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UILetterformAwareAdjustingWrapper))]
		static UILetterformAwareAdjustingWrapper ()
		{
			GC.KeepAlive (null);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public UILetterformAwareSizingRule SizingRule {
			[Export ("sizingRule", ArgumentSemantic.Assign)]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UILetterformAwareSizingRule ret;
				ret = (UILetterformAwareSizingRule) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("sizingRule"));
				return ret!;
			}
			[Export ("setSizingRule:", ArgumentSemantic.Assign)]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setSizingRule:"), (IntPtr) (long) value);
			}
		}
	}
}
