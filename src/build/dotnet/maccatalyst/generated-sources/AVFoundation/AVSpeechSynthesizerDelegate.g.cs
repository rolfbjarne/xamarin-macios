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
using Metal;
using CoreML;
using AppKit;
using MapKit;
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Contacts;
using Security;
using CloudKit;
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
using FileProvider;
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;
using MetalPerformanceShadersGraph;
#nullable enable
namespace AVFoundation {
	#pragma warning disable CS1573
	/// <summary>The delegate object for <see cref="T:AVFoundation.AVSpeechSynthesizer" />s. Provides events relating to speech utterances.</summary><remarks>To be added.</remarks><related type="externalDocumentation" href="https://developer.apple.com/documentation/avfaudio/avspeechsynthesizerdelegate">Apple documentation for <c>AVSpeechSynthesizerDelegate</c></related>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	[Protocol (Name = "AVSpeechSynthesizerDelegate", WrapperType = typeof (AVSpeechSynthesizerDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidStartSpeechUtterance", Selector = "speechSynthesizer:didStartSpeechUtterance:", ParameterType = new Type [] { typeof (AVSpeechSynthesizer), typeof (AVSpeechUtterance) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidFinishSpeechUtterance", Selector = "speechSynthesizer:didFinishSpeechUtterance:", ParameterType = new Type [] { typeof (AVSpeechSynthesizer), typeof (AVSpeechUtterance) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidPauseSpeechUtterance", Selector = "speechSynthesizer:didPauseSpeechUtterance:", ParameterType = new Type [] { typeof (AVSpeechSynthesizer), typeof (AVSpeechUtterance) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidContinueSpeechUtterance", Selector = "speechSynthesizer:didContinueSpeechUtterance:", ParameterType = new Type [] { typeof (AVSpeechSynthesizer), typeof (AVSpeechUtterance) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidCancelSpeechUtterance", Selector = "speechSynthesizer:didCancelSpeechUtterance:", ParameterType = new Type [] { typeof (AVSpeechSynthesizer), typeof (AVSpeechUtterance) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillSpeakRangeOfSpeechString", Selector = "speechSynthesizer:willSpeakRangeOfSpeechString:utterance:", ParameterType = new Type [] { typeof (AVSpeechSynthesizer), typeof (NSRange), typeof (AVSpeechUtterance) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillSpeakMarker", Selector = "speechSynthesizer:willSpeakMarker:utterance:", ParameterType = new Type [] { typeof (AVSpeechSynthesizer), typeof (AVSpeechSynthesisMarker), typeof (AVSpeechUtterance) }, ParameterByRef = new bool [] { false, false, false })]
	public partial interface IAVSpeechSynthesizerDelegate : INativeObject, IDisposable
	{
		/// <param name="synthesizer">To be added.</param><param name="utterance">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("speechSynthesizer:didStartSpeechUtterance:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidStartSpeechUtterance (AVSpeechSynthesizer synthesizer, AVSpeechUtterance utterance)
		{
			_DidStartSpeechUtterance (this, synthesizer, utterance);
		}
		/// <param name="synthesizer">To be added.</param><param name="utterance">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidStartSpeechUtterance (IAVSpeechSynthesizerDelegate This, AVSpeechSynthesizer synthesizer, AVSpeechUtterance utterance)
		{
			var synthesizer__handle__ = synthesizer!.GetNonNullHandle (nameof (synthesizer));
			var utterance__handle__ = utterance!.GetNonNullHandle (nameof (utterance));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("speechSynthesizer:didStartSpeechUtterance:"), synthesizer__handle__, utterance__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (synthesizer);
			GC.KeepAlive (utterance);
		}
		/// <param name="synthesizer">To be added.</param><param name="utterance">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("speechSynthesizer:didFinishSpeechUtterance:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidFinishSpeechUtterance (AVSpeechSynthesizer synthesizer, AVSpeechUtterance utterance)
		{
			_DidFinishSpeechUtterance (this, synthesizer, utterance);
		}
		/// <param name="synthesizer">To be added.</param><param name="utterance">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidFinishSpeechUtterance (IAVSpeechSynthesizerDelegate This, AVSpeechSynthesizer synthesizer, AVSpeechUtterance utterance)
		{
			var synthesizer__handle__ = synthesizer!.GetNonNullHandle (nameof (synthesizer));
			var utterance__handle__ = utterance!.GetNonNullHandle (nameof (utterance));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("speechSynthesizer:didFinishSpeechUtterance:"), synthesizer__handle__, utterance__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (synthesizer);
			GC.KeepAlive (utterance);
		}
		/// <param name="synthesizer">To be added.</param><param name="utterance">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("speechSynthesizer:didPauseSpeechUtterance:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidPauseSpeechUtterance (AVSpeechSynthesizer synthesizer, AVSpeechUtterance utterance)
		{
			_DidPauseSpeechUtterance (this, synthesizer, utterance);
		}
		/// <param name="synthesizer">To be added.</param><param name="utterance">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidPauseSpeechUtterance (IAVSpeechSynthesizerDelegate This, AVSpeechSynthesizer synthesizer, AVSpeechUtterance utterance)
		{
			var synthesizer__handle__ = synthesizer!.GetNonNullHandle (nameof (synthesizer));
			var utterance__handle__ = utterance!.GetNonNullHandle (nameof (utterance));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("speechSynthesizer:didPauseSpeechUtterance:"), synthesizer__handle__, utterance__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (synthesizer);
			GC.KeepAlive (utterance);
		}
		/// <param name="synthesizer">To be added.</param><param name="utterance">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("speechSynthesizer:didContinueSpeechUtterance:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidContinueSpeechUtterance (AVSpeechSynthesizer synthesizer, AVSpeechUtterance utterance)
		{
			_DidContinueSpeechUtterance (this, synthesizer, utterance);
		}
		/// <param name="synthesizer">To be added.</param><param name="utterance">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidContinueSpeechUtterance (IAVSpeechSynthesizerDelegate This, AVSpeechSynthesizer synthesizer, AVSpeechUtterance utterance)
		{
			var synthesizer__handle__ = synthesizer!.GetNonNullHandle (nameof (synthesizer));
			var utterance__handle__ = utterance!.GetNonNullHandle (nameof (utterance));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("speechSynthesizer:didContinueSpeechUtterance:"), synthesizer__handle__, utterance__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (synthesizer);
			GC.KeepAlive (utterance);
		}
		/// <param name="synthesizer">To be added.</param><param name="utterance">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("speechSynthesizer:didCancelSpeechUtterance:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidCancelSpeechUtterance (AVSpeechSynthesizer synthesizer, AVSpeechUtterance utterance)
		{
			_DidCancelSpeechUtterance (this, synthesizer, utterance);
		}
		/// <param name="synthesizer">To be added.</param><param name="utterance">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidCancelSpeechUtterance (IAVSpeechSynthesizerDelegate This, AVSpeechSynthesizer synthesizer, AVSpeechUtterance utterance)
		{
			var synthesizer__handle__ = synthesizer!.GetNonNullHandle (nameof (synthesizer));
			var utterance__handle__ = utterance!.GetNonNullHandle (nameof (utterance));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("speechSynthesizer:didCancelSpeechUtterance:"), synthesizer__handle__, utterance__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (synthesizer);
			GC.KeepAlive (utterance);
		}
		/// <param name="synthesizer">To be added.</param><param name="characterRange">To be added.</param><param name="utterance">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("speechSynthesizer:willSpeakRangeOfSpeechString:utterance:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillSpeakRangeOfSpeechString (AVSpeechSynthesizer synthesizer, NSRange characterRange, AVSpeechUtterance utterance)
		{
			_WillSpeakRangeOfSpeechString (this, synthesizer, characterRange, utterance);
		}
		/// <param name="synthesizer">To be added.</param><param name="characterRange">To be added.</param><param name="utterance">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _WillSpeakRangeOfSpeechString (IAVSpeechSynthesizerDelegate This, AVSpeechSynthesizer synthesizer, NSRange characterRange, AVSpeechUtterance utterance)
		{
			var synthesizer__handle__ = synthesizer!.GetNonNullHandle (nameof (synthesizer));
			var utterance__handle__ = utterance!.GetNonNullHandle (nameof (utterance));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NSRange_NativeHandle (This.Handle, Selector.GetHandle ("speechSynthesizer:willSpeakRangeOfSpeechString:utterance:"), synthesizer__handle__, characterRange, utterance__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (synthesizer);
			GC.KeepAlive (utterance);
		}
		[global::Foundation.OptionalMember]
		[Export ("speechSynthesizer:willSpeakMarker:utterance:")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillSpeakMarker (AVSpeechSynthesizer synthesizer, AVSpeechSynthesisMarker marker, AVSpeechUtterance utterance)
		{
			_WillSpeakMarker (this, synthesizer, marker, utterance);
		}
		[SupportedOSPlatform ("maccatalyst17.0")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _WillSpeakMarker (IAVSpeechSynthesizerDelegate This, AVSpeechSynthesizer synthesizer, AVSpeechSynthesisMarker marker, AVSpeechUtterance utterance)
		{
			var synthesizer__handle__ = synthesizer!.GetNonNullHandle (nameof (synthesizer));
			var marker__handle__ = marker!.GetNonNullHandle (nameof (marker));
			var utterance__handle__ = utterance!.GetNonNullHandle (nameof (utterance));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("speechSynthesizer:willSpeakMarker:utterance:"), synthesizer__handle__, marker__handle__, utterance__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (synthesizer);
			GC.KeepAlive (marker);
			GC.KeepAlive (utterance);
		}
		[DynamicDependencyAttribute ("DidCancelSpeechUtterance(AVFoundation.AVSpeechSynthesizer,AVFoundation.AVSpeechUtterance)")]
		[DynamicDependencyAttribute ("DidContinueSpeechUtterance(AVFoundation.AVSpeechSynthesizer,AVFoundation.AVSpeechUtterance)")]
		[DynamicDependencyAttribute ("DidFinishSpeechUtterance(AVFoundation.AVSpeechSynthesizer,AVFoundation.AVSpeechUtterance)")]
		[DynamicDependencyAttribute ("DidPauseSpeechUtterance(AVFoundation.AVSpeechSynthesizer,AVFoundation.AVSpeechUtterance)")]
		[DynamicDependencyAttribute ("DidStartSpeechUtterance(AVFoundation.AVSpeechSynthesizer,AVFoundation.AVSpeechUtterance)")]
		[DynamicDependencyAttribute ("WillSpeakMarker(AVFoundation.AVSpeechSynthesizer,AVFoundation.AVSpeechSynthesisMarker,AVFoundation.AVSpeechUtterance)")]
		[DynamicDependencyAttribute ("WillSpeakRangeOfSpeechString(AVFoundation.AVSpeechSynthesizer,Foundation.NSRange,AVFoundation.AVSpeechUtterance)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (AVSpeechSynthesizerDelegateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IAVSpeechSynthesizerDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="IAVSpeechSynthesizerDelegate" /> interface to support all the methods from the AVSpeechSynthesizerDelegate protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IAVSpeechSynthesizerDelegate" /> interface allow developers to treat instances of the interface as having all the optional methods of the original AVSpeechSynthesizerDelegate protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class AVSpeechSynthesizerDelegate_Extensions {
		/// <param name="synthesizer">To be added.</param><param name="utterance">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidStartSpeechUtterance (this IAVSpeechSynthesizerDelegate This, AVSpeechSynthesizer synthesizer, AVSpeechUtterance utterance)
		{
			var synthesizer__handle__ = synthesizer!.GetNonNullHandle (nameof (synthesizer));
			var utterance__handle__ = utterance!.GetNonNullHandle (nameof (utterance));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("speechSynthesizer:didStartSpeechUtterance:"), synthesizer__handle__, utterance__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (synthesizer);
			GC.KeepAlive (utterance);
		}
		/// <param name="synthesizer">To be added.</param><param name="utterance">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidFinishSpeechUtterance (this IAVSpeechSynthesizerDelegate This, AVSpeechSynthesizer synthesizer, AVSpeechUtterance utterance)
		{
			var synthesizer__handle__ = synthesizer!.GetNonNullHandle (nameof (synthesizer));
			var utterance__handle__ = utterance!.GetNonNullHandle (nameof (utterance));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("speechSynthesizer:didFinishSpeechUtterance:"), synthesizer__handle__, utterance__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (synthesizer);
			GC.KeepAlive (utterance);
		}
		/// <param name="synthesizer">To be added.</param><param name="utterance">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidPauseSpeechUtterance (this IAVSpeechSynthesizerDelegate This, AVSpeechSynthesizer synthesizer, AVSpeechUtterance utterance)
		{
			var synthesizer__handle__ = synthesizer!.GetNonNullHandle (nameof (synthesizer));
			var utterance__handle__ = utterance!.GetNonNullHandle (nameof (utterance));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("speechSynthesizer:didPauseSpeechUtterance:"), synthesizer__handle__, utterance__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (synthesizer);
			GC.KeepAlive (utterance);
		}
		/// <param name="synthesizer">To be added.</param><param name="utterance">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidContinueSpeechUtterance (this IAVSpeechSynthesizerDelegate This, AVSpeechSynthesizer synthesizer, AVSpeechUtterance utterance)
		{
			var synthesizer__handle__ = synthesizer!.GetNonNullHandle (nameof (synthesizer));
			var utterance__handle__ = utterance!.GetNonNullHandle (nameof (utterance));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("speechSynthesizer:didContinueSpeechUtterance:"), synthesizer__handle__, utterance__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (synthesizer);
			GC.KeepAlive (utterance);
		}
		/// <param name="synthesizer">To be added.</param><param name="utterance">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidCancelSpeechUtterance (this IAVSpeechSynthesizerDelegate This, AVSpeechSynthesizer synthesizer, AVSpeechUtterance utterance)
		{
			var synthesizer__handle__ = synthesizer!.GetNonNullHandle (nameof (synthesizer));
			var utterance__handle__ = utterance!.GetNonNullHandle (nameof (utterance));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("speechSynthesizer:didCancelSpeechUtterance:"), synthesizer__handle__, utterance__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (synthesizer);
			GC.KeepAlive (utterance);
		}
		/// <param name="synthesizer">To be added.</param><param name="characterRange">To be added.</param><param name="utterance">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void WillSpeakRangeOfSpeechString (this IAVSpeechSynthesizerDelegate This, AVSpeechSynthesizer synthesizer, NSRange characterRange, AVSpeechUtterance utterance)
		{
			var synthesizer__handle__ = synthesizer!.GetNonNullHandle (nameof (synthesizer));
			var utterance__handle__ = utterance!.GetNonNullHandle (nameof (utterance));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NSRange_NativeHandle (This.Handle, Selector.GetHandle ("speechSynthesizer:willSpeakRangeOfSpeechString:utterance:"), synthesizer__handle__, characterRange, utterance__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (synthesizer);
			GC.KeepAlive (utterance);
		}
		[SupportedOSPlatform ("maccatalyst17.0")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void WillSpeakMarker (this IAVSpeechSynthesizerDelegate This, AVSpeechSynthesizer synthesizer, AVSpeechSynthesisMarker marker, AVSpeechUtterance utterance)
		{
			var synthesizer__handle__ = synthesizer!.GetNonNullHandle (nameof (synthesizer));
			var marker__handle__ = marker!.GetNonNullHandle (nameof (marker));
			var utterance__handle__ = utterance!.GetNonNullHandle (nameof (utterance));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("speechSynthesizer:willSpeakMarker:utterance:"), synthesizer__handle__, marker__handle__, utterance__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (synthesizer);
			GC.KeepAlive (marker);
			GC.KeepAlive (utterance);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class AVSpeechSynthesizerDelegateWrapper : BaseWrapper, IAVSpeechSynthesizerDelegate {
		public AVSpeechSynthesizerDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (AVSpeechSynthesizerDelegateWrapper))]
		static AVSpeechSynthesizerDelegateWrapper ()
		{
			GC.KeepAlive (null);
		}
	}
}
namespace AVFoundation {
	/// <summary>The delegate object for <see cref="T:AVFoundation.AVSpeechSynthesizer" />s. Provides events relating to speech utterances.</summary><remarks>To be added.</remarks><related type="externalDocumentation" href="https://developer.apple.com/documentation/avfaudio/avspeechsynthesizerdelegate">Apple documentation for <c>AVSpeechSynthesizerDelegate</c></related>
	[Protocol()]
	[Register("Microsoft_MacCatalyst__AVFoundation_AVSpeechSynthesizerDelegate", false)]
	[Model]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe partial class AVSpeechSynthesizerDelegate : NSObject, IAVSpeechSynthesizerDelegate {
		/// <summary>Creates a new <see cref="AVSpeechSynthesizerDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public AVSpeechSynthesizerDelegate () : base (NSObjectFlag.Empty)
		{
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
		protected AVSpeechSynthesizerDelegate (NSObjectFlag t) : base (t)
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
		protected internal AVSpeechSynthesizerDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		/// <param name="synthesizer">To be added.</param><param name="utterance">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("speechSynthesizer:didCancelSpeechUtterance:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidCancelSpeechUtterance (AVSpeechSynthesizer synthesizer, AVSpeechUtterance utterance)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="synthesizer">To be added.</param><param name="utterance">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("speechSynthesizer:didContinueSpeechUtterance:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidContinueSpeechUtterance (AVSpeechSynthesizer synthesizer, AVSpeechUtterance utterance)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="synthesizer">To be added.</param><param name="utterance">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("speechSynthesizer:didFinishSpeechUtterance:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidFinishSpeechUtterance (AVSpeechSynthesizer synthesizer, AVSpeechUtterance utterance)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="synthesizer">To be added.</param><param name="utterance">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("speechSynthesizer:didPauseSpeechUtterance:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidPauseSpeechUtterance (AVSpeechSynthesizer synthesizer, AVSpeechUtterance utterance)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="synthesizer">To be added.</param><param name="utterance">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("speechSynthesizer:didStartSpeechUtterance:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidStartSpeechUtterance (AVSpeechSynthesizer synthesizer, AVSpeechUtterance utterance)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("speechSynthesizer:willSpeakMarker:utterance:")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillSpeakMarker (AVSpeechSynthesizer synthesizer, AVSpeechSynthesisMarker marker, AVSpeechUtterance utterance)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="synthesizer">To be added.</param><param name="characterRange">To be added.</param><param name="utterance">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("speechSynthesizer:willSpeakRangeOfSpeechString:utterance:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillSpeakRangeOfSpeechString (AVSpeechSynthesizer synthesizer, NSRange characterRange, AVSpeechUtterance utterance)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class AVSpeechSynthesizerDelegate */
}
