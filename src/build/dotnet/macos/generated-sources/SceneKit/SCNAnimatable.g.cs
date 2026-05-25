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
namespace SceneKit {
	#pragma warning disable CS1573
	/// <summary>Allows animations to be applied.</summary><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/SceneKit/Reference/SCNAnimatable_Protocol/index.html">Apple documentation for <c>SCNAnimatable</c></related>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	[Protocol (Name = "SCNAnimatable", WrapperType = typeof (SCNAnimatableWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "AddAnimation", Selector = "addAnimation:forKey:", ParameterType = new Type [] { typeof (ISCNAnimationProtocol), typeof (string) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "AddAnimation", Selector = "addAnimationPlayer:forKey:", ParameterType = new Type [] { typeof (SCNAnimationPlayer), typeof (NSString) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "RemoveAllAnimations", Selector = "removeAllAnimations")]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "RemoveAllAnimationsWithBlendOutDuration", Selector = "removeAllAnimationsWithBlendOutDuration:", ParameterType = new Type [] { typeof (NFloat) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "RemoveAnimation", Selector = "removeAnimationForKey:", ParameterType = new Type [] { typeof (NSString) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetAnimationKeys", Selector = "animationKeys", ReturnType = typeof (NSString[]))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetAnimationPlayer", Selector = "animationPlayerForKey:", ReturnType = typeof (SCNAnimationPlayer), ParameterType = new Type [] { typeof (NSString) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetAnimation", Selector = "animationForKey:", ReturnType = typeof (CAAnimation), ParameterType = new Type [] { typeof (NSString) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "PauseAnimation", Selector = "pauseAnimationForKey:", ParameterType = new Type [] { typeof (NSString) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "ResumeAnimation", Selector = "resumeAnimationForKey:", ParameterType = new Type [] { typeof (NSString) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "IsAnimationPaused", Selector = "isAnimationForKeyPaused:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (NSString) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "RemoveAnimation", Selector = "removeAnimationForKey:fadeOutDuration:", ParameterType = new Type [] { typeof (NSString), typeof (NFloat) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "RemoveAnimationUsingBlendOutDuration", Selector = "removeAnimationForKey:blendOutDuration:", ParameterType = new Type [] { typeof (NSString), typeof (NFloat) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetSpeed", Selector = "setSpeed:forAnimationKey:", ParameterType = new Type [] { typeof (NFloat), typeof (NSString) }, ParameterByRef = new bool [] { false, false })]
	public partial interface ISCNAnimatable : INativeObject, IDisposable
	{
		/// <summary>Adds <paramref name="scnAnimation" />, identified with the specified <paramref name="key" />.</summary><param name="scnAnimation">The animation to add.</param><param name="key">The animation key.</param><remarks><para>The following example shows how a rotation animation can be added to a <see cref="T:SceneKit.SCNGeometry" /> object:</para><example><code lang="csharp lang-csharp"><![CDATA[
		/// var animation = new CABasicAnimation ();
		/// animation.KeyPath = "rotation";
		/// var v = new SCNVector4 (1.0f, 1.0f, 0.0f, (float) (Math.PI * 2.0));
		/// animation.To = NSValue.FromVector (v);
		/// animation.Duration = 5.0f;
		/// animation.RepeatCount = float.MaxValue; //repeat forever
		/// animatableObject.AddAnimation (animation, (NSString) "rotation");
		/// ]]></code></example></remarks>
		[global::Foundation.RequiredMember]
		[Export ("addAnimation:forKey:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AddAnimation (ISCNAnimationProtocol scnAnimation, string? key)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <summary>Adds <paramref name="scnAnimation" />, identified with the specified <paramref name="key" />.</summary><param name="scnAnimation">The animation to add.</param><param name="key">The animation key.</param><remarks><para>The following example shows how a rotation animation can be added to a <see cref="T:SceneKit.SCNGeometry" /> object:</para><example><code lang="csharp lang-csharp"><![CDATA[
		/// var animation = new CABasicAnimation ();
		/// animation.KeyPath = "rotation";
		/// var v = new SCNVector4 (1.0f, 1.0f, 0.0f, (float) (Math.PI * 2.0));
		/// animation.To = NSValue.FromVector (v);
		/// animation.Duration = 5.0f;
		/// animation.RepeatCount = float.MaxValue; //repeat forever
		/// animatableObject.AddAnimation (animation, (NSString) "rotation");
		/// ]]></code></example></remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _AddAnimation (ISCNAnimatable This, ISCNAnimationProtocol scnAnimation, string? key)
		{
			var scnAnimation__handle__ = scnAnimation!.GetNonNullHandle (nameof (scnAnimation));
			var nskey = CFString.CreateNative (key);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("addAnimation:forKey:"), scnAnimation__handle__, nskey);
			GC.KeepAlive (This);
			GC.KeepAlive (scnAnimation);
			CFString.ReleaseNative (nskey);
		}
		[global::Foundation.RequiredMember]
		[Export ("addAnimationPlayer:forKey:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AddAnimation (SCNAnimationPlayer player, NSString? key)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _AddAnimation (ISCNAnimatable This, SCNAnimationPlayer player, NSString? key)
		{
			var player__handle__ = player!.GetNonNullHandle (nameof (player));
			var key__handle__ = key.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("addAnimationPlayer:forKey:"), player__handle__, key__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (player);
			GC.KeepAlive (key);
		}
		/// <summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("removeAllAnimations")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemoveAllAnimations ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _RemoveAllAnimations (ISCNAnimatable This)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("removeAllAnimations"));
			GC.KeepAlive (This);
		}
		[global::Foundation.RequiredMember]
		[Export ("removeAllAnimationsWithBlendOutDuration:")]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemoveAllAnimationsWithBlendOutDuration (nfloat duration)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _RemoveAllAnimationsWithBlendOutDuration (ISCNAnimatable This, nfloat duration)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_nfloat (This.Handle, Selector.GetHandle ("removeAllAnimationsWithBlendOutDuration:"), duration);
			GC.KeepAlive (This);
		}
		/// <param name="key">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("removeAnimationForKey:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemoveAnimation (NSString key)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="key">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _RemoveAnimation (ISCNAnimatable This, NSString key)
		{
			var key__handle__ = key!.GetNonNullHandle (nameof (key));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("removeAnimationForKey:"), key__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (key);
		}
		/// <summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("animationKeys")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSString[] GetAnimationKeys ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSString[] _GetAnimationKeys (ISCNAnimatable This)
		{
			NSString[] ret;
			ret = CFArray.ArrayFromHandle<NSString>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("animationKeys")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[global::Foundation.RequiredMember]
		[Export ("animationPlayerForKey:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual SCNAnimationPlayer? GetAnimationPlayer (NSString key)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static SCNAnimationPlayer? _GetAnimationPlayer (ISCNAnimatable This, NSString key)
		{
			var key__handle__ = key!.GetNonNullHandle (nameof (key));
			SCNAnimationPlayer? ret;
			ret =  Runtime.GetNSObject<SCNAnimationPlayer> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("animationPlayerForKey:"), key__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (key);
			return ret!;
		}
		/// <param name="key">To be added.</param><summary>Developers should not use this deprecated method. Developers should use 'GetAnimationPlayer' instead.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("animationForKey:")]
		[ObsoletedOSPlatform ("tvos11.0", "Use 'GetAnimationPlayer' instead.")]
		[ObsoletedOSPlatform ("ios11.0", "Use 'GetAnimationPlayer' instead.")]
		[ObsoletedOSPlatform ("macos10.13", "Use 'GetAnimationPlayer' instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'GetAnimationPlayer' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::CoreAnimation.CAAnimation? GetAnimation (NSString key)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="key">To be added.</param><summary>Developers should not use this deprecated method. Developers should use 'GetAnimationPlayer' instead.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[ObsoletedOSPlatform ("tvos11.0", "Use 'GetAnimationPlayer' instead.")]
		[ObsoletedOSPlatform ("ios11.0", "Use 'GetAnimationPlayer' instead.")]
		[ObsoletedOSPlatform ("macos10.13", "Use 'GetAnimationPlayer' instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'GetAnimationPlayer' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static global::CoreAnimation.CAAnimation? _GetAnimation (ISCNAnimatable This, NSString key)
		{
			var key__handle__ = key!.GetNonNullHandle (nameof (key));
			global::CoreAnimation.CAAnimation? ret;
			ret =  Runtime.GetNSObject<global::CoreAnimation.CAAnimation> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("animationForKey:"), key__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (key);
			return ret!;
		}
		/// <param name="key">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("pauseAnimationForKey:")]
		[ObsoletedOSPlatform ("tvos11.0", "Use 'SCNAnimationPlayer.Paused' instead.")]
		[ObsoletedOSPlatform ("ios11.0", "Use 'SCNAnimationPlayer.Paused' instead.")]
		[ObsoletedOSPlatform ("macos10.13", "Use 'SCNAnimationPlayer.Paused' instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'SCNAnimationPlayer.Paused' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PauseAnimation (NSString key)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="key">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[ObsoletedOSPlatform ("tvos11.0", "Use 'SCNAnimationPlayer.Paused' instead.")]
		[ObsoletedOSPlatform ("ios11.0", "Use 'SCNAnimationPlayer.Paused' instead.")]
		[ObsoletedOSPlatform ("macos10.13", "Use 'SCNAnimationPlayer.Paused' instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'SCNAnimationPlayer.Paused' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _PauseAnimation (ISCNAnimatable This, NSString key)
		{
			var key__handle__ = key!.GetNonNullHandle (nameof (key));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("pauseAnimationForKey:"), key__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (key);
		}
		/// <param name="key">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("resumeAnimationForKey:")]
		[ObsoletedOSPlatform ("tvos11.0", "Use 'SCNAnimationPlayer.Paused' instead.")]
		[ObsoletedOSPlatform ("ios11.0", "Use 'SCNAnimationPlayer.Paused' instead.")]
		[ObsoletedOSPlatform ("macos10.13", "Use 'SCNAnimationPlayer.Paused' instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'SCNAnimationPlayer.Paused' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ResumeAnimation (NSString key)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="key">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[ObsoletedOSPlatform ("tvos11.0", "Use 'SCNAnimationPlayer.Paused' instead.")]
		[ObsoletedOSPlatform ("ios11.0", "Use 'SCNAnimationPlayer.Paused' instead.")]
		[ObsoletedOSPlatform ("macos10.13", "Use 'SCNAnimationPlayer.Paused' instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'SCNAnimationPlayer.Paused' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _ResumeAnimation (ISCNAnimatable This, NSString key)
		{
			var key__handle__ = key!.GetNonNullHandle (nameof (key));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("resumeAnimationForKey:"), key__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (key);
		}
		/// <param name="key">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("isAnimationForKeyPaused:")]
		[ObsoletedOSPlatform ("tvos11.0", "Use 'SCNAnimationPlayer.Paused' instead.")]
		[ObsoletedOSPlatform ("ios11.0", "Use 'SCNAnimationPlayer.Paused' instead.")]
		[ObsoletedOSPlatform ("macos10.13", "Use 'SCNAnimationPlayer.Paused' instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'SCNAnimationPlayer.Paused' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool IsAnimationPaused (NSString key)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="key">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[ObsoletedOSPlatform ("tvos11.0", "Use 'SCNAnimationPlayer.Paused' instead.")]
		[ObsoletedOSPlatform ("ios11.0", "Use 'SCNAnimationPlayer.Paused' instead.")]
		[ObsoletedOSPlatform ("macos10.13", "Use 'SCNAnimationPlayer.Paused' instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'SCNAnimationPlayer.Paused' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _IsAnimationPaused (ISCNAnimatable This, NSString key)
		{
			var key__handle__ = key!.GetNonNullHandle (nameof (key));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("isAnimationForKeyPaused:"), key__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (key);
			return ret != 0;
		}
		/// <param name="key">To be added.</param><param name="duration">To be added.</param><summary>Deprecated. Developers should use <see cref="M:SceneKit.SCNAnimatable.RemoveAnimationUsingBlendOutDuration(Foundation.NSString,System.Runtime.InteropServices.NFloat)" />.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("removeAnimationForKey:fadeOutDuration:")]
		[ObsoletedOSPlatform ("tvos11.0", "Use 'RemoveAnimationUsingBlendOutDuration' instead.")]
		[ObsoletedOSPlatform ("ios11.0", "Use 'RemoveAnimationUsingBlendOutDuration' instead.")]
		[ObsoletedOSPlatform ("macos10.13", "Use 'RemoveAnimationUsingBlendOutDuration' instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'RemoveAnimationUsingBlendOutDuration' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemoveAnimation (NSString key, nfloat duration)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="key">To be added.</param><param name="duration">To be added.</param><summary>Deprecated. Developers should use <see cref="M:SceneKit.SCNAnimatable.RemoveAnimationUsingBlendOutDuration(Foundation.NSString,System.Runtime.InteropServices.NFloat)" />.</summary><remarks>To be added.</remarks>
		[ObsoletedOSPlatform ("tvos11.0", "Use 'RemoveAnimationUsingBlendOutDuration' instead.")]
		[ObsoletedOSPlatform ("ios11.0", "Use 'RemoveAnimationUsingBlendOutDuration' instead.")]
		[ObsoletedOSPlatform ("macos10.13", "Use 'RemoveAnimationUsingBlendOutDuration' instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'RemoveAnimationUsingBlendOutDuration' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _RemoveAnimation (ISCNAnimatable This, NSString key, nfloat duration)
		{
			var key__handle__ = key!.GetNonNullHandle (nameof (key));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_nfloat (This.Handle, Selector.GetHandle ("removeAnimationForKey:fadeOutDuration:"), key__handle__, duration);
			GC.KeepAlive (This);
			GC.KeepAlive (key);
		}
		/// <param name="key">The key for the animation to remove.</param><param name="blendOutDuration">The duration, in seconds, over which to blend the animation out.</param><summary>Removes the specified animation, blending it out over the specified duration.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("removeAnimationForKey:blendOutDuration:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemoveAnimationUsingBlendOutDuration (NSString key, nfloat blendOutDuration)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="key">The key for the animation to remove.</param><param name="blendOutDuration">The duration, in seconds, over which to blend the animation out.</param><summary>Removes the specified animation, blending it out over the specified duration.</summary><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _RemoveAnimationUsingBlendOutDuration (ISCNAnimatable This, NSString key, nfloat blendOutDuration)
		{
			var key__handle__ = key!.GetNonNullHandle (nameof (key));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_nfloat (This.Handle, Selector.GetHandle ("removeAnimationForKey:blendOutDuration:"), key__handle__, blendOutDuration);
			GC.KeepAlive (This);
			GC.KeepAlive (key);
		}
		/// <param name="speed">To be added.</param><param name="key">To be added.</param><summary>Deprecated. Developers should use <see cref="P:SceneKit.SCNAnimationPlayer.Speed" />, instead.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("setSpeed:forAnimationKey:")]
		[ObsoletedOSPlatform ("tvos11.0", "Use 'SCNAnimationPlayer.Speed' instead.")]
		[ObsoletedOSPlatform ("ios11.0", "Use 'SCNAnimationPlayer.Speed' instead.")]
		[ObsoletedOSPlatform ("macos10.13", "Use 'SCNAnimationPlayer.Speed' instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'SCNAnimationPlayer.Speed' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetSpeed (nfloat speed, NSString key)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="speed">To be added.</param><param name="key">To be added.</param><summary>Deprecated. Developers should use <see cref="P:SceneKit.SCNAnimationPlayer.Speed" />, instead.</summary><remarks>To be added.</remarks>
		[ObsoletedOSPlatform ("tvos11.0", "Use 'SCNAnimationPlayer.Speed' instead.")]
		[ObsoletedOSPlatform ("ios11.0", "Use 'SCNAnimationPlayer.Speed' instead.")]
		[ObsoletedOSPlatform ("macos10.13", "Use 'SCNAnimationPlayer.Speed' instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'SCNAnimationPlayer.Speed' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetSpeed (ISCNAnimatable This, nfloat speed, NSString key)
		{
			var key__handle__ = key!.GetNonNullHandle (nameof (key));
			global::ObjCRuntime.Messaging.void_objc_msgSend_nfloat_NativeHandle (This.Handle, Selector.GetHandle ("setSpeed:forAnimationKey:"), speed, key__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (key);
		}
		[DynamicDependencyAttribute ("AddAnimation(SceneKit.ISCNAnimationProtocol,System.String)")]
		[DynamicDependencyAttribute ("AddAnimation(SceneKit.SCNAnimationPlayer,Foundation.NSString)")]
		[DynamicDependencyAttribute ("GetAnimation(Foundation.NSString)")]
		[DynamicDependencyAttribute ("GetAnimationKeys()")]
		[DynamicDependencyAttribute ("GetAnimationPlayer(Foundation.NSString)")]
		[DynamicDependencyAttribute ("IsAnimationPaused(Foundation.NSString)")]
		[DynamicDependencyAttribute ("PauseAnimation(Foundation.NSString)")]
		[DynamicDependencyAttribute ("RemoveAllAnimations()")]
		[DynamicDependencyAttribute ("RemoveAllAnimationsWithBlendOutDuration(System.Runtime.InteropServices.NFloat)")]
		[DynamicDependencyAttribute ("RemoveAnimation(Foundation.NSString,System.Runtime.InteropServices.NFloat)")]
		[DynamicDependencyAttribute ("RemoveAnimation(Foundation.NSString)")]
		[DynamicDependencyAttribute ("RemoveAnimationUsingBlendOutDuration(Foundation.NSString,System.Runtime.InteropServices.NFloat)")]
		[DynamicDependencyAttribute ("ResumeAnimation(Foundation.NSString)")]
		[DynamicDependencyAttribute ("SetSpeed(System.Runtime.InteropServices.NFloat,Foundation.NSString)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (SCNAnimatableWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static ISCNAnimatable ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class SCNAnimatableWrapper : BaseWrapper, ISCNAnimatable {
		public SCNAnimatableWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (SCNAnimatableWrapper))]
		static SCNAnimatableWrapper ()
		{
			GC.KeepAlive (null);
		}
		/// <summary>Adds <paramref name="scnAnimation" />, identified with the specified <paramref name="key" />.</summary><param name="scnAnimation">The animation to add.</param><param name="key">The animation key.</param><remarks><para>The following example shows how a rotation animation can be added to a <see cref="T:SceneKit.SCNGeometry" /> object:</para><example><code lang="csharp lang-csharp"><![CDATA[
		/// var animation = new CABasicAnimation ();
		/// animation.KeyPath = "rotation";
		/// var v = new SCNVector4 (1.0f, 1.0f, 0.0f, (float) (Math.PI * 2.0));
		/// animation.To = NSValue.FromVector (v);
		/// animation.Duration = 5.0f;
		/// animation.RepeatCount = float.MaxValue; //repeat forever
		/// animatableObject.AddAnimation (animation, (NSString) "rotation");
		/// ]]></code></example></remarks>
		[Export ("addAnimation:forKey:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void AddAnimation (ISCNAnimationProtocol scnAnimation, string? key)
		{
			var scnAnimation__handle__ = scnAnimation!.GetNonNullHandle (nameof (scnAnimation));
			var nskey = CFString.CreateNative (key);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("addAnimation:forKey:"), scnAnimation__handle__, nskey);
			GC.KeepAlive (scnAnimation);
			CFString.ReleaseNative (nskey);
		}
		[Export ("addAnimationPlayer:forKey:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void AddAnimation (SCNAnimationPlayer player, NSString? key)
		{
			var player__handle__ = player!.GetNonNullHandle (nameof (player));
			var key__handle__ = key.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("addAnimationPlayer:forKey:"), player__handle__, key__handle__);
			GC.KeepAlive (player);
			GC.KeepAlive (key);
		}
		/// <summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("removeAllAnimations")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void RemoveAllAnimations ()
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("removeAllAnimations"));
		}
		[Export ("removeAllAnimationsWithBlendOutDuration:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void RemoveAllAnimationsWithBlendOutDuration (nfloat duration)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_nfloat (this.Handle, Selector.GetHandle ("removeAllAnimationsWithBlendOutDuration:"), duration);
		}
		/// <param name="key">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("removeAnimationForKey:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void RemoveAnimation (NSString key)
		{
			var key__handle__ = key!.GetNonNullHandle (nameof (key));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("removeAnimationForKey:"), key__handle__);
			GC.KeepAlive (key);
		}
		/// <summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("animationKeys")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSString[] GetAnimationKeys ()
		{
			NSString[] ret;
			ret = CFArray.ArrayFromHandle<NSString>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("animationKeys")), false)!;
			return ret;
		}
		[Export ("animationPlayerForKey:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public SCNAnimationPlayer? GetAnimationPlayer (NSString key)
		{
			var key__handle__ = key!.GetNonNullHandle (nameof (key));
			SCNAnimationPlayer? ret;
			ret =  Runtime.GetNSObject<SCNAnimationPlayer> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("animationPlayerForKey:"), key__handle__), false)!;
			GC.KeepAlive (key);
			return ret!;
		}
		/// <param name="key">To be added.</param><summary>Developers should not use this deprecated method. Developers should use 'GetAnimationPlayer' instead.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("animationForKey:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public global::CoreAnimation.CAAnimation? GetAnimation (NSString key)
		{
			var key__handle__ = key!.GetNonNullHandle (nameof (key));
			global::CoreAnimation.CAAnimation? ret;
			ret =  Runtime.GetNSObject<global::CoreAnimation.CAAnimation> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("animationForKey:"), key__handle__), false)!;
			GC.KeepAlive (key);
			return ret!;
		}
		/// <param name="key">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("pauseAnimationForKey:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void PauseAnimation (NSString key)
		{
			var key__handle__ = key!.GetNonNullHandle (nameof (key));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("pauseAnimationForKey:"), key__handle__);
			GC.KeepAlive (key);
		}
		/// <param name="key">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("resumeAnimationForKey:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void ResumeAnimation (NSString key)
		{
			var key__handle__ = key!.GetNonNullHandle (nameof (key));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("resumeAnimationForKey:"), key__handle__);
			GC.KeepAlive (key);
		}
		/// <param name="key">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("isAnimationForKeyPaused:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public bool IsAnimationPaused (NSString key)
		{
			var key__handle__ = key!.GetNonNullHandle (nameof (key));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("isAnimationForKeyPaused:"), key__handle__);
			GC.KeepAlive (key);
			return ret != 0;
		}
		/// <param name="key">To be added.</param><param name="duration">To be added.</param><summary>Deprecated. Developers should use <see cref="M:SceneKit.SCNAnimatable.RemoveAnimationUsingBlendOutDuration(Foundation.NSString,System.Runtime.InteropServices.NFloat)" />.</summary><remarks>To be added.</remarks>
		[Export ("removeAnimationForKey:fadeOutDuration:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void RemoveAnimation (NSString key, nfloat duration)
		{
			var key__handle__ = key!.GetNonNullHandle (nameof (key));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_nfloat (this.Handle, Selector.GetHandle ("removeAnimationForKey:fadeOutDuration:"), key__handle__, duration);
			GC.KeepAlive (key);
		}
		/// <param name="key">The key for the animation to remove.</param><param name="blendOutDuration">The duration, in seconds, over which to blend the animation out.</param><summary>Removes the specified animation, blending it out over the specified duration.</summary><remarks>To be added.</remarks>
		[Export ("removeAnimationForKey:blendOutDuration:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void RemoveAnimationUsingBlendOutDuration (NSString key, nfloat blendOutDuration)
		{
			var key__handle__ = key!.GetNonNullHandle (nameof (key));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_nfloat (this.Handle, Selector.GetHandle ("removeAnimationForKey:blendOutDuration:"), key__handle__, blendOutDuration);
			GC.KeepAlive (key);
		}
		/// <param name="speed">To be added.</param><param name="key">To be added.</param><summary>Deprecated. Developers should use <see cref="P:SceneKit.SCNAnimationPlayer.Speed" />, instead.</summary><remarks>To be added.</remarks>
		[Export ("setSpeed:forAnimationKey:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetSpeed (nfloat speed, NSString key)
		{
			var key__handle__ = key!.GetNonNullHandle (nameof (key));
			global::ObjCRuntime.Messaging.void_objc_msgSend_nfloat_NativeHandle (this.Handle, Selector.GetHandle ("setSpeed:forAnimationKey:"), speed, key__handle__);
			GC.KeepAlive (key);
		}
	}
}
namespace SceneKit {
	/// <summary>Allows animations to be applied.</summary><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/SceneKit/Reference/SCNAnimatable_Protocol/index.html">Apple documentation for <c>SCNAnimatable</c></related>
	[Protocol()]
	[Register("Microsoft_macOS__SceneKit_SCNAnimatable", false)]
	[Model]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe abstract partial class SCNAnimatable : NSObject, ISCNAnimatable {
		/// <summary>Creates a new <see cref="SCNAnimatable" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected SCNAnimatable () : base (NSObjectFlag.Empty)
		{
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
		protected SCNAnimatable (NSObjectFlag t) : base (t)
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
		protected internal SCNAnimatable (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		/// <summary>Adds <paramref name="scnAnimation" />, identified with the specified <paramref name="key" />.</summary><param name="scnAnimation">The animation to add.</param><param name="key">The animation key.</param><remarks><para>The following example shows how a rotation animation can be added to a <see cref="T:SceneKit.SCNGeometry" /> object:</para><example><code lang="csharp lang-csharp"><![CDATA[
		/// var animation = new CABasicAnimation ();
		/// animation.KeyPath = "rotation";
		/// var v = new SCNVector4 (1.0f, 1.0f, 0.0f, (float) (Math.PI * 2.0));
		/// animation.To = NSValue.FromVector (v);
		/// animation.Duration = 5.0f;
		/// animation.RepeatCount = float.MaxValue; //repeat forever
		/// animatableObject.AddAnimation (animation, (NSString) "rotation");
		/// ]]></code></example></remarks>
		[Export ("addAnimation:forKey:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AddAnimation (ISCNAnimationProtocol scnAnimation, string? key)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("addAnimationPlayer:forKey:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AddAnimation (SCNAnimationPlayer player, NSString? key)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="key">To be added.</param><summary>Developers should not use this deprecated method. Developers should use 'GetAnimationPlayer' instead.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("animationForKey:")]
		[ObsoletedOSPlatform ("tvos11.0", "Use 'GetAnimationPlayer' instead.")]
		[ObsoletedOSPlatform ("ios11.0", "Use 'GetAnimationPlayer' instead.")]
		[ObsoletedOSPlatform ("macos10.13", "Use 'GetAnimationPlayer' instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'GetAnimationPlayer' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::CoreAnimation.CAAnimation? GetAnimation (NSString key)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("animationKeys")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSString[] GetAnimationKeys ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("animationPlayerForKey:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual SCNAnimationPlayer? GetAnimationPlayer (NSString key)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="key">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("isAnimationForKeyPaused:")]
		[ObsoletedOSPlatform ("tvos11.0", "Use 'SCNAnimationPlayer.Paused' instead.")]
		[ObsoletedOSPlatform ("ios11.0", "Use 'SCNAnimationPlayer.Paused' instead.")]
		[ObsoletedOSPlatform ("macos10.13", "Use 'SCNAnimationPlayer.Paused' instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'SCNAnimationPlayer.Paused' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool IsAnimationPaused (NSString key)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="key">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("pauseAnimationForKey:")]
		[ObsoletedOSPlatform ("tvos11.0", "Use 'SCNAnimationPlayer.Paused' instead.")]
		[ObsoletedOSPlatform ("ios11.0", "Use 'SCNAnimationPlayer.Paused' instead.")]
		[ObsoletedOSPlatform ("macos10.13", "Use 'SCNAnimationPlayer.Paused' instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'SCNAnimationPlayer.Paused' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PauseAnimation (NSString key)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("removeAllAnimations")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemoveAllAnimations ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("removeAllAnimationsWithBlendOutDuration:")]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemoveAllAnimationsWithBlendOutDuration (nfloat duration)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="key">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("removeAnimationForKey:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemoveAnimation (NSString key)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="key">To be added.</param><param name="duration">To be added.</param><summary>Deprecated. Developers should use <see cref="M:SceneKit.SCNAnimatable.RemoveAnimationUsingBlendOutDuration(Foundation.NSString,System.Runtime.InteropServices.NFloat)" />.</summary><remarks>To be added.</remarks>
		[Export ("removeAnimationForKey:fadeOutDuration:")]
		[ObsoletedOSPlatform ("tvos11.0", "Use 'RemoveAnimationUsingBlendOutDuration' instead.")]
		[ObsoletedOSPlatform ("ios11.0", "Use 'RemoveAnimationUsingBlendOutDuration' instead.")]
		[ObsoletedOSPlatform ("macos10.13", "Use 'RemoveAnimationUsingBlendOutDuration' instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'RemoveAnimationUsingBlendOutDuration' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemoveAnimation (NSString key, nfloat duration)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="key">The key for the animation to remove.</param><param name="blendOutDuration">The duration, in seconds, over which to blend the animation out.</param><summary>Removes the specified animation, blending it out over the specified duration.</summary><remarks>To be added.</remarks>
		[Export ("removeAnimationForKey:blendOutDuration:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemoveAnimationUsingBlendOutDuration (NSString key, nfloat blendOutDuration)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="key">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("resumeAnimationForKey:")]
		[ObsoletedOSPlatform ("tvos11.0", "Use 'SCNAnimationPlayer.Paused' instead.")]
		[ObsoletedOSPlatform ("ios11.0", "Use 'SCNAnimationPlayer.Paused' instead.")]
		[ObsoletedOSPlatform ("macos10.13", "Use 'SCNAnimationPlayer.Paused' instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'SCNAnimationPlayer.Paused' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ResumeAnimation (NSString key)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="speed">To be added.</param><param name="key">To be added.</param><summary>Deprecated. Developers should use <see cref="P:SceneKit.SCNAnimationPlayer.Speed" />, instead.</summary><remarks>To be added.</remarks>
		[Export ("setSpeed:forAnimationKey:")]
		[ObsoletedOSPlatform ("tvos11.0", "Use 'SCNAnimationPlayer.Speed' instead.")]
		[ObsoletedOSPlatform ("ios11.0", "Use 'SCNAnimationPlayer.Speed' instead.")]
		[ObsoletedOSPlatform ("macos10.13", "Use 'SCNAnimationPlayer.Speed' instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'SCNAnimationPlayer.Speed' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetSpeed (nfloat speed, NSString key)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class SCNAnimatable */
}
