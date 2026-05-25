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
	/// <summary>This interface represents the Objective-C protocol <c>UIGestureRecognizerDelegate</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[UnsupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("tvos")]
	[Protocol (Name = "UIGestureRecognizerDelegate", WrapperType = typeof (UIGestureRecognizerDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldReceiveTouch", Selector = "gestureRecognizer:shouldReceiveTouch:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (UIGestureRecognizer), typeof (UITouch) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldRecognizeSimultaneously", Selector = "gestureRecognizer:shouldRecognizeSimultaneouslyWithGestureRecognizer:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (UIGestureRecognizer), typeof (UIGestureRecognizer) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldBegin", Selector = "gestureRecognizerShouldBegin:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (UIGestureRecognizer) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldBeRequiredToFailBy", Selector = "gestureRecognizer:shouldBeRequiredToFailByGestureRecognizer:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (UIGestureRecognizer), typeof (UIGestureRecognizer) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldRequireFailureOf", Selector = "gestureRecognizer:shouldRequireFailureOfGestureRecognizer:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (UIGestureRecognizer), typeof (UIGestureRecognizer) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldReceivePress", Selector = "gestureRecognizer:shouldReceivePress:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (UIGestureRecognizer), typeof (UIPress) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldReceiveEvent", Selector = "gestureRecognizer:shouldReceiveEvent:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (UIGestureRecognizer), typeof (UIEvent) }, ParameterByRef = new bool [] { false, false })]
	public partial interface IUIGestureRecognizerDelegate : INativeObject, IDisposable
	{
		/// <param name="recognizer">To be added.</param><param name="touch">To be added.</param><summary>Whether the recognizer should receive the specified touch.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("gestureRecognizer:shouldReceiveTouch:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldReceiveTouch (UIGestureRecognizer recognizer, UITouch touch)
		{
			return _ShouldReceiveTouch (this, recognizer, touch);
		}
		/// <param name="recognizer">To be added.</param><param name="touch">To be added.</param><summary>Whether the recognizer should receive the specified touch.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _ShouldReceiveTouch (IUIGestureRecognizerDelegate This, UIGestureRecognizer recognizer, UITouch touch)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var recognizer__handle__ = recognizer!.GetNonNullHandle (nameof (recognizer));
			var touch__handle__ = touch!.GetNonNullHandle (nameof (touch));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("gestureRecognizer:shouldReceiveTouch:"), recognizer__handle__, touch__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (recognizer);
			GC.KeepAlive (touch);
			return ret != 0;
		}
		/// <param name="gestureRecognizer">To be added.</param><param name="otherGestureRecognizer">To be added.</param><summary>Whether the two gesture recognizers should be allowed to recognize gestures simultaneously.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("gestureRecognizer:shouldRecognizeSimultaneouslyWithGestureRecognizer:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldRecognizeSimultaneously (UIGestureRecognizer gestureRecognizer, UIGestureRecognizer otherGestureRecognizer)
		{
			return _ShouldRecognizeSimultaneously (this, gestureRecognizer, otherGestureRecognizer);
		}
		/// <param name="gestureRecognizer">To be added.</param><param name="otherGestureRecognizer">To be added.</param><summary>Whether the two gesture recognizers should be allowed to recognize gestures simultaneously.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _ShouldRecognizeSimultaneously (IUIGestureRecognizerDelegate This, UIGestureRecognizer gestureRecognizer, UIGestureRecognizer otherGestureRecognizer)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var gestureRecognizer__handle__ = gestureRecognizer!.GetNonNullHandle (nameof (gestureRecognizer));
			var otherGestureRecognizer__handle__ = otherGestureRecognizer!.GetNonNullHandle (nameof (otherGestureRecognizer));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("gestureRecognizer:shouldRecognizeSimultaneouslyWithGestureRecognizer:"), gestureRecognizer__handle__, otherGestureRecognizer__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (gestureRecognizer);
			GC.KeepAlive (otherGestureRecognizer);
			return ret != 0;
		}
		/// <param name="recognizer">To be added.</param><summary>Whether the gesture recognition should begin.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("gestureRecognizerShouldBegin:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldBegin (UIGestureRecognizer recognizer)
		{
			return _ShouldBegin (this, recognizer);
		}
		/// <param name="recognizer">To be added.</param><summary>Whether the gesture recognition should begin.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _ShouldBegin (IUIGestureRecognizerDelegate This, UIGestureRecognizer recognizer)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var recognizer__handle__ = recognizer!.GetNonNullHandle (nameof (recognizer));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("gestureRecognizerShouldBegin:"), recognizer__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (recognizer);
			return ret != 0;
		}
		/// <param name="gestureRecognizer">To be added.</param><param name="otherGestureRecognizer">To be added.</param><summary>Whether there is a dynamic failure requirement between the specified gesture recognizers.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("gestureRecognizer:shouldBeRequiredToFailByGestureRecognizer:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldBeRequiredToFailBy (UIGestureRecognizer gestureRecognizer, UIGestureRecognizer otherGestureRecognizer)
		{
			return _ShouldBeRequiredToFailBy (this, gestureRecognizer, otherGestureRecognizer);
		}
		/// <param name="gestureRecognizer">To be added.</param><param name="otherGestureRecognizer">To be added.</param><summary>Whether there is a dynamic failure requirement between the specified gesture recognizers.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _ShouldBeRequiredToFailBy (IUIGestureRecognizerDelegate This, UIGestureRecognizer gestureRecognizer, UIGestureRecognizer otherGestureRecognizer)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var gestureRecognizer__handle__ = gestureRecognizer!.GetNonNullHandle (nameof (gestureRecognizer));
			var otherGestureRecognizer__handle__ = otherGestureRecognizer!.GetNonNullHandle (nameof (otherGestureRecognizer));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("gestureRecognizer:shouldBeRequiredToFailByGestureRecognizer:"), gestureRecognizer__handle__, otherGestureRecognizer__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (gestureRecognizer);
			GC.KeepAlive (otherGestureRecognizer);
			return ret != 0;
		}
		/// <param name="gestureRecognizer">To be added.</param><param name="otherGestureRecognizer">To be added.</param><summary>Whether the specified gestureRecognizer should be required to fail by the otherGestureRecognizer.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("gestureRecognizer:shouldRequireFailureOfGestureRecognizer:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldRequireFailureOf (UIGestureRecognizer gestureRecognizer, UIGestureRecognizer otherGestureRecognizer)
		{
			return _ShouldRequireFailureOf (this, gestureRecognizer, otherGestureRecognizer);
		}
		/// <param name="gestureRecognizer">To be added.</param><param name="otherGestureRecognizer">To be added.</param><summary>Whether the specified gestureRecognizer should be required to fail by the otherGestureRecognizer.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _ShouldRequireFailureOf (IUIGestureRecognizerDelegate This, UIGestureRecognizer gestureRecognizer, UIGestureRecognizer otherGestureRecognizer)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var gestureRecognizer__handle__ = gestureRecognizer!.GetNonNullHandle (nameof (gestureRecognizer));
			var otherGestureRecognizer__handle__ = otherGestureRecognizer!.GetNonNullHandle (nameof (otherGestureRecognizer));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("gestureRecognizer:shouldRequireFailureOfGestureRecognizer:"), gestureRecognizer__handle__, otherGestureRecognizer__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (gestureRecognizer);
			GC.KeepAlive (otherGestureRecognizer);
			return ret != 0;
		}
		/// <param name="gestureRecognizer">To be added.</param><param name="press">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("gestureRecognizer:shouldReceivePress:")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldReceivePress (UIGestureRecognizer gestureRecognizer, UIPress press)
		{
			return _ShouldReceivePress (this, gestureRecognizer, press);
		}
		/// <param name="gestureRecognizer">To be added.</param><param name="press">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _ShouldReceivePress (IUIGestureRecognizerDelegate This, UIGestureRecognizer gestureRecognizer, UIPress press)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var gestureRecognizer__handle__ = gestureRecognizer!.GetNonNullHandle (nameof (gestureRecognizer));
			var press__handle__ = press!.GetNonNullHandle (nameof (press));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("gestureRecognizer:shouldReceivePress:"), gestureRecognizer__handle__, press__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (gestureRecognizer);
			GC.KeepAlive (press);
			return ret != 0;
		}
		[global::Foundation.OptionalMember]
		[Export ("gestureRecognizer:shouldReceiveEvent:")]
		[SupportedOSPlatform ("tvos13.4")]
		[SupportedOSPlatform ("ios13.4")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldReceiveEvent (UIGestureRecognizer gestureRecognizer, UIEvent @event)
		{
			return _ShouldReceiveEvent (this, gestureRecognizer, @event);
		}
		[SupportedOSPlatform ("tvos13.4")]
		[SupportedOSPlatform ("ios13.4")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _ShouldReceiveEvent (IUIGestureRecognizerDelegate This, UIGestureRecognizer gestureRecognizer, UIEvent @event)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var gestureRecognizer__handle__ = gestureRecognizer!.GetNonNullHandle (nameof (gestureRecognizer));
			var @event__handle__ = @event!.GetNonNullHandle (nameof (@event));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("gestureRecognizer:shouldReceiveEvent:"), gestureRecognizer__handle__, @event__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (gestureRecognizer);
			GC.KeepAlive (@event);
			return ret != 0;
		}
		[DynamicDependencyAttribute ("ShouldBegin(UIKit.UIGestureRecognizer)")]
		[DynamicDependencyAttribute ("ShouldBeRequiredToFailBy(UIKit.UIGestureRecognizer,UIKit.UIGestureRecognizer)")]
		[DynamicDependencyAttribute ("ShouldReceiveEvent(UIKit.UIGestureRecognizer,UIKit.UIEvent)")]
		[DynamicDependencyAttribute ("ShouldReceivePress(UIKit.UIGestureRecognizer,UIKit.UIPress)")]
		[DynamicDependencyAttribute ("ShouldReceiveTouch(UIKit.UIGestureRecognizer,UIKit.UITouch)")]
		[DynamicDependencyAttribute ("ShouldRecognizeSimultaneously(UIKit.UIGestureRecognizer,UIKit.UIGestureRecognizer)")]
		[DynamicDependencyAttribute ("ShouldRequireFailureOf(UIKit.UIGestureRecognizer,UIKit.UIGestureRecognizer)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UIGestureRecognizerDelegateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IUIGestureRecognizerDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="IUIGestureRecognizerDelegate" /> interface to support all the methods from the UIGestureRecognizerDelegate protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IUIGestureRecognizerDelegate" /> interface allow developers to treat instances of the interface as having all the optional methods of the original UIGestureRecognizerDelegate protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class UIGestureRecognizerDelegate_Extensions {
		/// <param name="recognizer">To be added.</param><param name="touch">To be added.</param><summary>Whether the recognizer should receive the specified touch.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool ShouldReceiveTouch (this IUIGestureRecognizerDelegate This, UIGestureRecognizer recognizer, UITouch touch)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var recognizer__handle__ = recognizer!.GetNonNullHandle (nameof (recognizer));
			var touch__handle__ = touch!.GetNonNullHandle (nameof (touch));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("gestureRecognizer:shouldReceiveTouch:"), recognizer__handle__, touch__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (recognizer);
			GC.KeepAlive (touch);
			return ret != 0;
		}
		/// <param name="gestureRecognizer">To be added.</param><param name="otherGestureRecognizer">To be added.</param><summary>Whether the two gesture recognizers should be allowed to recognize gestures simultaneously.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool ShouldRecognizeSimultaneously (this IUIGestureRecognizerDelegate This, UIGestureRecognizer gestureRecognizer, UIGestureRecognizer otherGestureRecognizer)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var gestureRecognizer__handle__ = gestureRecognizer!.GetNonNullHandle (nameof (gestureRecognizer));
			var otherGestureRecognizer__handle__ = otherGestureRecognizer!.GetNonNullHandle (nameof (otherGestureRecognizer));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("gestureRecognizer:shouldRecognizeSimultaneouslyWithGestureRecognizer:"), gestureRecognizer__handle__, otherGestureRecognizer__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (gestureRecognizer);
			GC.KeepAlive (otherGestureRecognizer);
			return ret != 0;
		}
		/// <param name="recognizer">To be added.</param><summary>Whether the gesture recognition should begin.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool ShouldBegin (this IUIGestureRecognizerDelegate This, UIGestureRecognizer recognizer)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var recognizer__handle__ = recognizer!.GetNonNullHandle (nameof (recognizer));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("gestureRecognizerShouldBegin:"), recognizer__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (recognizer);
			return ret != 0;
		}
		/// <param name="gestureRecognizer">To be added.</param><param name="otherGestureRecognizer">To be added.</param><summary>Whether there is a dynamic failure requirement between the specified gesture recognizers.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool ShouldBeRequiredToFailBy (this IUIGestureRecognizerDelegate This, UIGestureRecognizer gestureRecognizer, UIGestureRecognizer otherGestureRecognizer)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var gestureRecognizer__handle__ = gestureRecognizer!.GetNonNullHandle (nameof (gestureRecognizer));
			var otherGestureRecognizer__handle__ = otherGestureRecognizer!.GetNonNullHandle (nameof (otherGestureRecognizer));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("gestureRecognizer:shouldBeRequiredToFailByGestureRecognizer:"), gestureRecognizer__handle__, otherGestureRecognizer__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (gestureRecognizer);
			GC.KeepAlive (otherGestureRecognizer);
			return ret != 0;
		}
		/// <param name="gestureRecognizer">To be added.</param><param name="otherGestureRecognizer">To be added.</param><summary>Whether the specified gestureRecognizer should be required to fail by the otherGestureRecognizer.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool ShouldRequireFailureOf (this IUIGestureRecognizerDelegate This, UIGestureRecognizer gestureRecognizer, UIGestureRecognizer otherGestureRecognizer)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var gestureRecognizer__handle__ = gestureRecognizer!.GetNonNullHandle (nameof (gestureRecognizer));
			var otherGestureRecognizer__handle__ = otherGestureRecognizer!.GetNonNullHandle (nameof (otherGestureRecognizer));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("gestureRecognizer:shouldRequireFailureOfGestureRecognizer:"), gestureRecognizer__handle__, otherGestureRecognizer__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (gestureRecognizer);
			GC.KeepAlive (otherGestureRecognizer);
			return ret != 0;
		}
		/// <param name="gestureRecognizer">To be added.</param><param name="press">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool ShouldReceivePress (this IUIGestureRecognizerDelegate This, UIGestureRecognizer gestureRecognizer, UIPress press)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var gestureRecognizer__handle__ = gestureRecognizer!.GetNonNullHandle (nameof (gestureRecognizer));
			var press__handle__ = press!.GetNonNullHandle (nameof (press));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("gestureRecognizer:shouldReceivePress:"), gestureRecognizer__handle__, press__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (gestureRecognizer);
			GC.KeepAlive (press);
			return ret != 0;
		}
		[SupportedOSPlatform ("tvos13.4")]
		[SupportedOSPlatform ("ios13.4")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool ShouldReceiveEvent (this IUIGestureRecognizerDelegate This, UIGestureRecognizer gestureRecognizer, UIEvent @event)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var gestureRecognizer__handle__ = gestureRecognizer!.GetNonNullHandle (nameof (gestureRecognizer));
			var @event__handle__ = @event!.GetNonNullHandle (nameof (@event));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("gestureRecognizer:shouldReceiveEvent:"), gestureRecognizer__handle__, @event__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (gestureRecognizer);
			GC.KeepAlive (@event);
			return ret != 0;
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class UIGestureRecognizerDelegateWrapper : BaseWrapper, IUIGestureRecognizerDelegate {
		public UIGestureRecognizerDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UIGestureRecognizerDelegateWrapper))]
		static UIGestureRecognizerDelegateWrapper ()
		{
			GC.KeepAlive (null);
		}
	}
}
namespace UIKit {
	/// <summary>
	///   <para>This is a class that implements the interface <see cref="IUIGestureRecognizerDelegate" /> (for the protocol <c>UIGestureRecognizerDelegate</c>).</para>
	///   <para>Subclass this class to easily create a type that implements the protocol.</para>
	///   <para>An alternative is to create a subclass of <see cref="NSObject" /> and then implemented the interface <see cref="IUIGestureRecognizerDelegate" />.</para>
	/// </summary>
	[Protocol()]
	[Register("Microsoft_tvOS__UIKit_UIGestureRecognizerDelegate", false)]
	[Model]
	[UnsupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("tvos")]
	public unsafe partial class UIGestureRecognizerDelegate : NSObject, IUIGestureRecognizerDelegate {
		/// <summary>Creates a new <see cref="UIGestureRecognizerDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public UIGestureRecognizerDelegate () : base (NSObjectFlag.Empty)
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
		protected UIGestureRecognizerDelegate (NSObjectFlag t) : base (t)
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
		protected internal UIGestureRecognizerDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		/// <param name="gestureRecognizer">To be added.</param><param name="otherGestureRecognizer">To be added.</param><summary>Whether there is a dynamic failure requirement between the specified gesture recognizers.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("gestureRecognizer:shouldBeRequiredToFailByGestureRecognizer:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldBeRequiredToFailBy (UIGestureRecognizer gestureRecognizer, UIGestureRecognizer otherGestureRecognizer)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="recognizer">To be added.</param><summary>Whether the gesture recognition should begin.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("gestureRecognizerShouldBegin:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldBegin (UIGestureRecognizer recognizer)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("gestureRecognizer:shouldReceiveEvent:")]
		[SupportedOSPlatform ("tvos13.4")]
		[SupportedOSPlatform ("ios13.4")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldReceiveEvent (UIGestureRecognizer gestureRecognizer, UIEvent @event)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="gestureRecognizer">To be added.</param><param name="press">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("gestureRecognizer:shouldReceivePress:")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldReceivePress (UIGestureRecognizer gestureRecognizer, UIPress press)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="recognizer">To be added.</param><param name="touch">To be added.</param><summary>Whether the recognizer should receive the specified touch.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("gestureRecognizer:shouldReceiveTouch:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldReceiveTouch (UIGestureRecognizer recognizer, UITouch touch)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="gestureRecognizer">To be added.</param><param name="otherGestureRecognizer">To be added.</param><summary>Whether the two gesture recognizers should be allowed to recognize gestures simultaneously.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("gestureRecognizer:shouldRecognizeSimultaneouslyWithGestureRecognizer:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldRecognizeSimultaneously (UIGestureRecognizer gestureRecognizer, UIGestureRecognizer otherGestureRecognizer)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="gestureRecognizer">To be added.</param><param name="otherGestureRecognizer">To be added.</param><summary>Whether the specified gestureRecognizer should be required to fail by the otherGestureRecognizer.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("gestureRecognizer:shouldRequireFailureOfGestureRecognizer:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldRequireFailureOf (UIGestureRecognizer gestureRecognizer, UIGestureRecognizer otherGestureRecognizer)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class UIGestureRecognizerDelegate */
}
