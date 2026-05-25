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
namespace Foundation {
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>NSURLAuthenticationChallengeSender</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[Protocol (Name = "NSURLAuthenticationChallengeSender", WrapperType = typeof (NSUrlAuthenticationChallengeSenderWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "UseCredential", Selector = "useCredential:forAuthenticationChallenge:", ParameterType = new Type [] { typeof (NSUrlCredential), typeof (NSUrlAuthenticationChallenge) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "ContinueWithoutCredential", Selector = "continueWithoutCredentialForAuthenticationChallenge:", ParameterType = new Type [] { typeof (NSUrlAuthenticationChallenge) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "CancelAuthenticationChallenge", Selector = "cancelAuthenticationChallenge:", ParameterType = new Type [] { typeof (NSUrlAuthenticationChallenge) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "PerformDefaultHandling", Selector = "performDefaultHandlingForAuthenticationChallenge:", ParameterType = new Type [] { typeof (NSUrlAuthenticationChallenge) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "RejectProtectionSpaceAndContinue", Selector = "rejectProtectionSpaceAndContinueWithChallenge:", ParameterType = new Type [] { typeof (NSUrlAuthenticationChallenge) }, ParameterByRef = new bool [] { false })]
	public partial interface INSUrlAuthenticationChallengeSender : INativeObject, IDisposable
	{
		[global::Foundation.RequiredMember]
		[Export ("useCredential:forAuthenticationChallenge:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void UseCredential (NSUrlCredential credential, NSUrlAuthenticationChallenge challenge)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _UseCredential (INSUrlAuthenticationChallengeSender This, NSUrlCredential credential, NSUrlAuthenticationChallenge challenge)
		{
			var credential__handle__ = credential!.GetNonNullHandle (nameof (credential));
			var challenge__handle__ = challenge!.GetNonNullHandle (nameof (challenge));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("useCredential:forAuthenticationChallenge:"), credential__handle__, challenge__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (credential);
			GC.KeepAlive (challenge);
		}
		[global::Foundation.RequiredMember]
		[Export ("continueWithoutCredentialForAuthenticationChallenge:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ContinueWithoutCredential (NSUrlAuthenticationChallenge challenge)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _ContinueWithoutCredential (INSUrlAuthenticationChallengeSender This, NSUrlAuthenticationChallenge challenge)
		{
			var challenge__handle__ = challenge!.GetNonNullHandle (nameof (challenge));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("continueWithoutCredentialForAuthenticationChallenge:"), challenge__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (challenge);
		}
		[global::Foundation.RequiredMember]
		[Export ("cancelAuthenticationChallenge:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void CancelAuthenticationChallenge (NSUrlAuthenticationChallenge challenge)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _CancelAuthenticationChallenge (INSUrlAuthenticationChallengeSender This, NSUrlAuthenticationChallenge challenge)
		{
			var challenge__handle__ = challenge!.GetNonNullHandle (nameof (challenge));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("cancelAuthenticationChallenge:"), challenge__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (challenge);
		}
		[global::Foundation.OptionalMember]
		[Export ("performDefaultHandlingForAuthenticationChallenge:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PerformDefaultHandling (NSUrlAuthenticationChallenge challenge)
		{
			_PerformDefaultHandling (this, challenge);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _PerformDefaultHandling (INSUrlAuthenticationChallengeSender This, NSUrlAuthenticationChallenge challenge)
		{
			var challenge__handle__ = challenge!.GetNonNullHandle (nameof (challenge));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("performDefaultHandlingForAuthenticationChallenge:"), challenge__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (challenge);
		}
		[global::Foundation.OptionalMember]
		[Export ("rejectProtectionSpaceAndContinueWithChallenge:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RejectProtectionSpaceAndContinue (NSUrlAuthenticationChallenge challenge)
		{
			_RejectProtectionSpaceAndContinue (this, challenge);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _RejectProtectionSpaceAndContinue (INSUrlAuthenticationChallengeSender This, NSUrlAuthenticationChallenge challenge)
		{
			var challenge__handle__ = challenge!.GetNonNullHandle (nameof (challenge));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("rejectProtectionSpaceAndContinueWithChallenge:"), challenge__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (challenge);
		}
		[DynamicDependencyAttribute ("CancelAuthenticationChallenge(Foundation.NSUrlAuthenticationChallenge)")]
		[DynamicDependencyAttribute ("ContinueWithoutCredential(Foundation.NSUrlAuthenticationChallenge)")]
		[DynamicDependencyAttribute ("PerformDefaultHandling(Foundation.NSUrlAuthenticationChallenge)")]
		[DynamicDependencyAttribute ("RejectProtectionSpaceAndContinue(Foundation.NSUrlAuthenticationChallenge)")]
		[DynamicDependencyAttribute ("UseCredential(Foundation.NSUrlCredential,Foundation.NSUrlAuthenticationChallenge)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSUrlAuthenticationChallengeSenderWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static INSUrlAuthenticationChallengeSender ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="INSUrlAuthenticationChallengeSender" /> interface to support all the methods from the NSURLAuthenticationChallengeSender protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="INSUrlAuthenticationChallengeSender" /> interface allow developers to treat instances of the interface as having all the optional methods of the original NSURLAuthenticationChallengeSender protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class NSUrlAuthenticationChallengeSender_Extensions {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void PerformDefaultHandling (this INSUrlAuthenticationChallengeSender This, NSUrlAuthenticationChallenge challenge)
		{
			var challenge__handle__ = challenge!.GetNonNullHandle (nameof (challenge));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("performDefaultHandlingForAuthenticationChallenge:"), challenge__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (challenge);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void RejectProtectionSpaceAndContinue (this INSUrlAuthenticationChallengeSender This, NSUrlAuthenticationChallenge challenge)
		{
			var challenge__handle__ = challenge!.GetNonNullHandle (nameof (challenge));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("rejectProtectionSpaceAndContinueWithChallenge:"), challenge__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (challenge);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class NSUrlAuthenticationChallengeSenderWrapper : BaseWrapper, INSUrlAuthenticationChallengeSender {
		public NSUrlAuthenticationChallengeSenderWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSUrlAuthenticationChallengeSenderWrapper))]
		static NSUrlAuthenticationChallengeSenderWrapper ()
		{
			GC.KeepAlive (null);
		}
		[Export ("useCredential:forAuthenticationChallenge:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void UseCredential (NSUrlCredential credential, NSUrlAuthenticationChallenge challenge)
		{
			var credential__handle__ = credential!.GetNonNullHandle (nameof (credential));
			var challenge__handle__ = challenge!.GetNonNullHandle (nameof (challenge));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("useCredential:forAuthenticationChallenge:"), credential__handle__, challenge__handle__);
			GC.KeepAlive (credential);
			GC.KeepAlive (challenge);
		}
		[Export ("continueWithoutCredentialForAuthenticationChallenge:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void ContinueWithoutCredential (NSUrlAuthenticationChallenge challenge)
		{
			var challenge__handle__ = challenge!.GetNonNullHandle (nameof (challenge));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("continueWithoutCredentialForAuthenticationChallenge:"), challenge__handle__);
			GC.KeepAlive (challenge);
		}
		[Export ("cancelAuthenticationChallenge:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void CancelAuthenticationChallenge (NSUrlAuthenticationChallenge challenge)
		{
			var challenge__handle__ = challenge!.GetNonNullHandle (nameof (challenge));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("cancelAuthenticationChallenge:"), challenge__handle__);
			GC.KeepAlive (challenge);
		}
	}
}
