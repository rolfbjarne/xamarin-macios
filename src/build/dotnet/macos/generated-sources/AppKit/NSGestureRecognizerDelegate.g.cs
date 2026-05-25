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
	/// <summary>This interface represents the Objective-C protocol <c>NSGestureRecognizerDelegate</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[Protocol (Name = "NSGestureRecognizerDelegate", WrapperType = typeof (NSGestureRecognizerDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldBegin", Selector = "gestureRecognizerShouldBegin:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (NSGestureRecognizer) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldRecognizeSimultaneously", Selector = "gestureRecognizer:shouldRecognizeSimultaneouslyWithGestureRecognizer:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (NSGestureRecognizer), typeof (NSGestureRecognizer) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldRequireFailure", Selector = "gestureRecognizer:shouldRequireFailureOfGestureRecognizer:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (NSGestureRecognizer), typeof (NSGestureRecognizer) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldBeRequiredToFail", Selector = "gestureRecognizer:shouldBeRequiredToFailByGestureRecognizer:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (NSGestureRecognizer), typeof (NSGestureRecognizer) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldAttemptToRecognize", Selector = "gestureRecognizer:shouldAttemptToRecognizeWithEvent:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (NSGestureRecognizer), typeof (NSEvent) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldReceiveTouch", Selector = "gestureRecognizer:shouldReceiveTouch:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (NSGestureRecognizer), typeof (NSTouch) }, ParameterByRef = new bool [] { false, false })]
	public partial interface INSGestureRecognizerDelegate : INativeObject, IDisposable
	{
		/// <param name="gestureRecognizer">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("gestureRecognizerShouldBegin:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldBegin (NSGestureRecognizer gestureRecognizer)
		{
			return _ShouldBegin (this, gestureRecognizer);
		}
		/// <param name="gestureRecognizer">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _ShouldBegin (INSGestureRecognizerDelegate This, NSGestureRecognizer gestureRecognizer)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var gestureRecognizer__handle__ = gestureRecognizer!.GetNonNullHandle (nameof (gestureRecognizer));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("gestureRecognizerShouldBegin:"), gestureRecognizer__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (gestureRecognizer);
			return ret != 0;
		}
		/// <param name="gestureRecognizer">To be added.</param><param name="otherGestureRecognizer">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("gestureRecognizer:shouldRecognizeSimultaneouslyWithGestureRecognizer:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldRecognizeSimultaneously (NSGestureRecognizer gestureRecognizer, NSGestureRecognizer otherGestureRecognizer)
		{
			return _ShouldRecognizeSimultaneously (this, gestureRecognizer, otherGestureRecognizer);
		}
		/// <param name="gestureRecognizer">To be added.</param><param name="otherGestureRecognizer">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _ShouldRecognizeSimultaneously (INSGestureRecognizerDelegate This, NSGestureRecognizer gestureRecognizer, NSGestureRecognizer otherGestureRecognizer)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var gestureRecognizer__handle__ = gestureRecognizer!.GetNonNullHandle (nameof (gestureRecognizer));
			var otherGestureRecognizer__handle__ = otherGestureRecognizer!.GetNonNullHandle (nameof (otherGestureRecognizer));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("gestureRecognizer:shouldRecognizeSimultaneouslyWithGestureRecognizer:"), gestureRecognizer__handle__, otherGestureRecognizer__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (gestureRecognizer);
			GC.KeepAlive (otherGestureRecognizer);
			return ret != 0;
		}
		/// <param name="gestureRecognizer">To be added.</param><param name="otherGestureRecognizer">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("gestureRecognizer:shouldRequireFailureOfGestureRecognizer:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldRequireFailure (NSGestureRecognizer gestureRecognizer, NSGestureRecognizer otherGestureRecognizer)
		{
			return _ShouldRequireFailure (this, gestureRecognizer, otherGestureRecognizer);
		}
		/// <param name="gestureRecognizer">To be added.</param><param name="otherGestureRecognizer">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _ShouldRequireFailure (INSGestureRecognizerDelegate This, NSGestureRecognizer gestureRecognizer, NSGestureRecognizer otherGestureRecognizer)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var gestureRecognizer__handle__ = gestureRecognizer!.GetNonNullHandle (nameof (gestureRecognizer));
			var otherGestureRecognizer__handle__ = otherGestureRecognizer!.GetNonNullHandle (nameof (otherGestureRecognizer));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("gestureRecognizer:shouldRequireFailureOfGestureRecognizer:"), gestureRecognizer__handle__, otherGestureRecognizer__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (gestureRecognizer);
			GC.KeepAlive (otherGestureRecognizer);
			return ret != 0;
		}
		/// <param name="gestureRecognizer">To be added.</param><param name="otherGestureRecognizer">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("gestureRecognizer:shouldBeRequiredToFailByGestureRecognizer:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldBeRequiredToFail (NSGestureRecognizer gestureRecognizer, NSGestureRecognizer otherGestureRecognizer)
		{
			return _ShouldBeRequiredToFail (this, gestureRecognizer, otherGestureRecognizer);
		}
		/// <param name="gestureRecognizer">To be added.</param><param name="otherGestureRecognizer">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _ShouldBeRequiredToFail (INSGestureRecognizerDelegate This, NSGestureRecognizer gestureRecognizer, NSGestureRecognizer otherGestureRecognizer)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var gestureRecognizer__handle__ = gestureRecognizer!.GetNonNullHandle (nameof (gestureRecognizer));
			var otherGestureRecognizer__handle__ = otherGestureRecognizer!.GetNonNullHandle (nameof (otherGestureRecognizer));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("gestureRecognizer:shouldBeRequiredToFailByGestureRecognizer:"), gestureRecognizer__handle__, otherGestureRecognizer__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (gestureRecognizer);
			GC.KeepAlive (otherGestureRecognizer);
			return ret != 0;
		}
		/// <param name="gestureRecognizer">To be added.</param><param name="theEvent">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("gestureRecognizer:shouldAttemptToRecognizeWithEvent:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldAttemptToRecognize (NSGestureRecognizer gestureRecognizer, NSEvent theEvent)
		{
			return _ShouldAttemptToRecognize (this, gestureRecognizer, theEvent);
		}
		/// <param name="gestureRecognizer">To be added.</param><param name="theEvent">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _ShouldAttemptToRecognize (INSGestureRecognizerDelegate This, NSGestureRecognizer gestureRecognizer, NSEvent theEvent)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var gestureRecognizer__handle__ = gestureRecognizer!.GetNonNullHandle (nameof (gestureRecognizer));
			var theEvent__handle__ = theEvent!.GetNonNullHandle (nameof (theEvent));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("gestureRecognizer:shouldAttemptToRecognizeWithEvent:"), gestureRecognizer__handle__, theEvent__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (gestureRecognizer);
			GC.KeepAlive (theEvent);
			return ret != 0;
		}
		/// <param name="gestureRecognizer">To be added.</param><param name="touch">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("gestureRecognizer:shouldReceiveTouch:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldReceiveTouch (NSGestureRecognizer gestureRecognizer, NSTouch touch)
		{
			return _ShouldReceiveTouch (this, gestureRecognizer, touch);
		}
		/// <param name="gestureRecognizer">To be added.</param><param name="touch">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _ShouldReceiveTouch (INSGestureRecognizerDelegate This, NSGestureRecognizer gestureRecognizer, NSTouch touch)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var gestureRecognizer__handle__ = gestureRecognizer!.GetNonNullHandle (nameof (gestureRecognizer));
			var touch__handle__ = touch!.GetNonNullHandle (nameof (touch));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("gestureRecognizer:shouldReceiveTouch:"), gestureRecognizer__handle__, touch__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (gestureRecognizer);
			GC.KeepAlive (touch);
			return ret != 0;
		}
		[DynamicDependencyAttribute ("ShouldAttemptToRecognize(AppKit.NSGestureRecognizer,AppKit.NSEvent)")]
		[DynamicDependencyAttribute ("ShouldBegin(AppKit.NSGestureRecognizer)")]
		[DynamicDependencyAttribute ("ShouldBeRequiredToFail(AppKit.NSGestureRecognizer,AppKit.NSGestureRecognizer)")]
		[DynamicDependencyAttribute ("ShouldReceiveTouch(AppKit.NSGestureRecognizer,AppKit.NSTouch)")]
		[DynamicDependencyAttribute ("ShouldRecognizeSimultaneously(AppKit.NSGestureRecognizer,AppKit.NSGestureRecognizer)")]
		[DynamicDependencyAttribute ("ShouldRequireFailure(AppKit.NSGestureRecognizer,AppKit.NSGestureRecognizer)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSGestureRecognizerDelegateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static INSGestureRecognizerDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="INSGestureRecognizerDelegate" /> interface to support all the methods from the NSGestureRecognizerDelegate protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="INSGestureRecognizerDelegate" /> interface allow developers to treat instances of the interface as having all the optional methods of the original NSGestureRecognizerDelegate protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class NSGestureRecognizerDelegate_Extensions {
		/// <param name="gestureRecognizer">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool ShouldBegin (this INSGestureRecognizerDelegate This, NSGestureRecognizer gestureRecognizer)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var gestureRecognizer__handle__ = gestureRecognizer!.GetNonNullHandle (nameof (gestureRecognizer));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("gestureRecognizerShouldBegin:"), gestureRecognizer__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (gestureRecognizer);
			return ret != 0;
		}
		/// <param name="gestureRecognizer">To be added.</param><param name="otherGestureRecognizer">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool ShouldRecognizeSimultaneously (this INSGestureRecognizerDelegate This, NSGestureRecognizer gestureRecognizer, NSGestureRecognizer otherGestureRecognizer)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var gestureRecognizer__handle__ = gestureRecognizer!.GetNonNullHandle (nameof (gestureRecognizer));
			var otherGestureRecognizer__handle__ = otherGestureRecognizer!.GetNonNullHandle (nameof (otherGestureRecognizer));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("gestureRecognizer:shouldRecognizeSimultaneouslyWithGestureRecognizer:"), gestureRecognizer__handle__, otherGestureRecognizer__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (gestureRecognizer);
			GC.KeepAlive (otherGestureRecognizer);
			return ret != 0;
		}
		/// <param name="gestureRecognizer">To be added.</param><param name="otherGestureRecognizer">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool ShouldRequireFailure (this INSGestureRecognizerDelegate This, NSGestureRecognizer gestureRecognizer, NSGestureRecognizer otherGestureRecognizer)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var gestureRecognizer__handle__ = gestureRecognizer!.GetNonNullHandle (nameof (gestureRecognizer));
			var otherGestureRecognizer__handle__ = otherGestureRecognizer!.GetNonNullHandle (nameof (otherGestureRecognizer));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("gestureRecognizer:shouldRequireFailureOfGestureRecognizer:"), gestureRecognizer__handle__, otherGestureRecognizer__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (gestureRecognizer);
			GC.KeepAlive (otherGestureRecognizer);
			return ret != 0;
		}
		/// <param name="gestureRecognizer">To be added.</param><param name="otherGestureRecognizer">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool ShouldBeRequiredToFail (this INSGestureRecognizerDelegate This, NSGestureRecognizer gestureRecognizer, NSGestureRecognizer otherGestureRecognizer)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var gestureRecognizer__handle__ = gestureRecognizer!.GetNonNullHandle (nameof (gestureRecognizer));
			var otherGestureRecognizer__handle__ = otherGestureRecognizer!.GetNonNullHandle (nameof (otherGestureRecognizer));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("gestureRecognizer:shouldBeRequiredToFailByGestureRecognizer:"), gestureRecognizer__handle__, otherGestureRecognizer__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (gestureRecognizer);
			GC.KeepAlive (otherGestureRecognizer);
			return ret != 0;
		}
		/// <param name="gestureRecognizer">To be added.</param><param name="theEvent">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool ShouldAttemptToRecognize (this INSGestureRecognizerDelegate This, NSGestureRecognizer gestureRecognizer, NSEvent theEvent)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var gestureRecognizer__handle__ = gestureRecognizer!.GetNonNullHandle (nameof (gestureRecognizer));
			var theEvent__handle__ = theEvent!.GetNonNullHandle (nameof (theEvent));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("gestureRecognizer:shouldAttemptToRecognizeWithEvent:"), gestureRecognizer__handle__, theEvent__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (gestureRecognizer);
			GC.KeepAlive (theEvent);
			return ret != 0;
		}
		/// <param name="gestureRecognizer">To be added.</param><param name="touch">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool ShouldReceiveTouch (this INSGestureRecognizerDelegate This, NSGestureRecognizer gestureRecognizer, NSTouch touch)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var gestureRecognizer__handle__ = gestureRecognizer!.GetNonNullHandle (nameof (gestureRecognizer));
			var touch__handle__ = touch!.GetNonNullHandle (nameof (touch));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("gestureRecognizer:shouldReceiveTouch:"), gestureRecognizer__handle__, touch__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (gestureRecognizer);
			GC.KeepAlive (touch);
			return ret != 0;
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class NSGestureRecognizerDelegateWrapper : BaseWrapper, INSGestureRecognizerDelegate {
		public NSGestureRecognizerDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSGestureRecognizerDelegateWrapper))]
		static NSGestureRecognizerDelegateWrapper ()
		{
			GC.KeepAlive (null);
		}
	}
}
namespace AppKit {
	/// <summary>
	///   <para>This is a class that implements the interface <see cref="INSGestureRecognizerDelegate" /> (for the protocol <c>NSGestureRecognizerDelegate</c>).</para>
	///   <para>Subclass this class to easily create a type that implements the protocol.</para>
	///   <para>An alternative is to create a subclass of <see cref="NSObject" /> and then implemented the interface <see cref="INSGestureRecognizerDelegate" />.</para>
	/// </summary>
	[Protocol()]
	[Register("Microsoft_macOS__AppKit_NSGestureRecognizerDelegate", false)]
	[Model]
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	public unsafe partial class NSGestureRecognizerDelegate : NSObject, INSGestureRecognizerDelegate {
		/// <summary>Creates a new <see cref="NSGestureRecognizerDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public NSGestureRecognizerDelegate () : base (NSObjectFlag.Empty)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			IsDirectBinding = false;
			unsafe {
			var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
			InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, global::ObjCRuntime.Selector.Init), "init");
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
		protected NSGestureRecognizerDelegate (NSObjectFlag t) : base (t)
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
		protected internal NSGestureRecognizerDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		/// <param name="gestureRecognizer">To be added.</param><param name="theEvent">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("gestureRecognizer:shouldAttemptToRecognizeWithEvent:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldAttemptToRecognize (NSGestureRecognizer gestureRecognizer, NSEvent theEvent)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="gestureRecognizer">To be added.</param><param name="otherGestureRecognizer">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("gestureRecognizer:shouldBeRequiredToFailByGestureRecognizer:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldBeRequiredToFail (NSGestureRecognizer gestureRecognizer, NSGestureRecognizer otherGestureRecognizer)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="gestureRecognizer">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("gestureRecognizerShouldBegin:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldBegin (NSGestureRecognizer gestureRecognizer)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="gestureRecognizer">To be added.</param><param name="touch">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("gestureRecognizer:shouldReceiveTouch:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldReceiveTouch (NSGestureRecognizer gestureRecognizer, NSTouch touch)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="gestureRecognizer">To be added.</param><param name="otherGestureRecognizer">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("gestureRecognizer:shouldRecognizeSimultaneouslyWithGestureRecognizer:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldRecognizeSimultaneously (NSGestureRecognizer gestureRecognizer, NSGestureRecognizer otherGestureRecognizer)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="gestureRecognizer">To be added.</param><param name="otherGestureRecognizer">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("gestureRecognizer:shouldRequireFailureOfGestureRecognizer:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldRequireFailure (NSGestureRecognizer gestureRecognizer, NSGestureRecognizer otherGestureRecognizer)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class NSGestureRecognizerDelegate */
}
