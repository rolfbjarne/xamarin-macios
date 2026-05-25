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
namespace CallKit {
	#pragma warning disable CS1573
	/// <related type="externalDocumentation" href="https://developer.apple.com/reference/CallKit/CXProviderDelegate">Apple documentation for <c>CXProviderDelegate</c></related>
	[UnsupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[Protocol (Name = "CXProviderDelegate", WrapperType = typeof (CXProviderDelegateWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "DidReset", Selector = "providerDidReset:", ParameterType = new Type [] { typeof (CallKit.CXProvider) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidBegin", Selector = "providerDidBegin:", ParameterType = new Type [] { typeof (CallKit.CXProvider) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ExecuteTransaction", Selector = "provider:executeTransaction:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (CallKit.CXProvider), typeof (CallKit.CXTransaction) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "PerformStartCallAction", Selector = "provider:performStartCallAction:", ParameterType = new Type [] { typeof (CallKit.CXProvider), typeof (CallKit.CXStartCallAction) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "PerformAnswerCallAction", Selector = "provider:performAnswerCallAction:", ParameterType = new Type [] { typeof (CallKit.CXProvider), typeof (CallKit.CXAnswerCallAction) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "PerformEndCallAction", Selector = "provider:performEndCallAction:", ParameterType = new Type [] { typeof (CallKit.CXProvider), typeof (CallKit.CXEndCallAction) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "PerformSetHeldCallAction", Selector = "provider:performSetHeldCallAction:", ParameterType = new Type [] { typeof (CallKit.CXProvider), typeof (CallKit.CXSetHeldCallAction) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "PerformSetMutedCallAction", Selector = "provider:performSetMutedCallAction:", ParameterType = new Type [] { typeof (CallKit.CXProvider), typeof (CallKit.CXSetMutedCallAction) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "PerformSetGroupCallAction", Selector = "provider:performSetGroupCallAction:", ParameterType = new Type [] { typeof (CallKit.CXProvider), typeof (CallKit.CXSetGroupCallAction) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "PerformPlayDtmfCallAction", Selector = "provider:performPlayDTMFCallAction:", ParameterType = new Type [] { typeof (CallKit.CXProvider), typeof (CallKit.CXPlayDtmfCallAction) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "TimedOutPerformingAction", Selector = "provider:timedOutPerformingAction:", ParameterType = new Type [] { typeof (CallKit.CXProvider), typeof (CallKit.CXAction) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidActivateAudioSession", Selector = "provider:didActivateAudioSession:", ParameterType = new Type [] { typeof (CallKit.CXProvider), typeof (AVAudioSession) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidDeactivateAudioSession", Selector = "provider:didDeactivateAudioSession:", ParameterType = new Type [] { typeof (CallKit.CXProvider), typeof (AVAudioSession) }, ParameterByRef = new bool [] { false, false })]
	public partial interface ICXProviderDelegate : INativeObject, IDisposable
	{
		/// <param name="provider">The provider to which the provider delegate belongs.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("providerDidReset:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidReset (CXProvider provider)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="provider">The provider to which the provider delegate belongs.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidReset (ICXProviderDelegate This, CXProvider provider)
		{
			var provider__handle__ = provider!.GetNonNullHandle (nameof (provider));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("providerDidReset:"), provider__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (provider);
		}
		/// <param name="provider">The provider to which the provider delegate belongs.</param><summary>The system began a call for the app.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("providerDidBegin:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidBegin (CXProvider provider)
		{
			_DidBegin (this, provider);
		}
		/// <param name="provider">The provider to which the provider delegate belongs.</param><summary>The system began a call for the app.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidBegin (ICXProviderDelegate This, CXProvider provider)
		{
			var provider__handle__ = provider!.GetNonNullHandle (nameof (provider));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("providerDidBegin:"), provider__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (provider);
		}
		/// <param name="provider">The provider to which the provider delegate belongs.</param><param name="transaction">The transaction to run.</param><summary>Atomically runs the actions that are contained in the <paramref name="transaction" />.</summary><returns><see langword="true" /> if the transaction succeeded. Otherwise, <see langword="false" />.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("provider:executeTransaction:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ExecuteTransaction (CXProvider provider, CXTransaction transaction)
		{
			return _ExecuteTransaction (this, provider, transaction);
		}
		/// <param name="provider">The provider to which the provider delegate belongs.</param><param name="transaction">The transaction to run.</param><summary>Atomically runs the actions that are contained in the <paramref name="transaction" />.</summary><returns><see langword="true" /> if the transaction succeeded. Otherwise, <see langword="false" />.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _ExecuteTransaction (ICXProviderDelegate This, CXProvider provider, CXTransaction transaction)
		{
			var provider__handle__ = provider!.GetNonNullHandle (nameof (provider));
			var transaction__handle__ = transaction!.GetNonNullHandle (nameof (transaction));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("provider:executeTransaction:"), provider__handle__, transaction__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (provider);
			GC.KeepAlive (transaction);
			return ret != 0;
		}
		/// <param name="provider">The provider to which the provider delegate belongs.</param><param name="action">The start call action to perform.</param><summary>Performs a start call action.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("provider:performStartCallAction:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PerformStartCallAction (CXProvider provider, CXStartCallAction action)
		{
			_PerformStartCallAction (this, provider, action);
		}
		/// <param name="provider">The provider to which the provider delegate belongs.</param><param name="action">The start call action to perform.</param><summary>Performs a start call action.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _PerformStartCallAction (ICXProviderDelegate This, CXProvider provider, CXStartCallAction action)
		{
			var provider__handle__ = provider!.GetNonNullHandle (nameof (provider));
			var action__handle__ = action!.GetNonNullHandle (nameof (action));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("provider:performStartCallAction:"), provider__handle__, action__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (provider);
			GC.KeepAlive (action);
		}
		/// <param name="provider">The provider to which the provider delegate belongs.</param><param name="action">The answer call action to perform.</param><summary>Performs an answer call action.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("provider:performAnswerCallAction:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PerformAnswerCallAction (CXProvider provider, CXAnswerCallAction action)
		{
			_PerformAnswerCallAction (this, provider, action);
		}
		/// <param name="provider">The provider to which the provider delegate belongs.</param><param name="action">The answer call action to perform.</param><summary>Performs an answer call action.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _PerformAnswerCallAction (ICXProviderDelegate This, CXProvider provider, CXAnswerCallAction action)
		{
			var provider__handle__ = provider!.GetNonNullHandle (nameof (provider));
			var action__handle__ = action!.GetNonNullHandle (nameof (action));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("provider:performAnswerCallAction:"), provider__handle__, action__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (provider);
			GC.KeepAlive (action);
		}
		/// <param name="provider">The provider to which the provider delegate belongs.</param><param name="action">The end call action to perform.</param><summary>Performs an end call action.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("provider:performEndCallAction:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PerformEndCallAction (CXProvider provider, CXEndCallAction action)
		{
			_PerformEndCallAction (this, provider, action);
		}
		/// <param name="provider">The provider to which the provider delegate belongs.</param><param name="action">The end call action to perform.</param><summary>Performs an end call action.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _PerformEndCallAction (ICXProviderDelegate This, CXProvider provider, CXEndCallAction action)
		{
			var provider__handle__ = provider!.GetNonNullHandle (nameof (provider));
			var action__handle__ = action!.GetNonNullHandle (nameof (action));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("provider:performEndCallAction:"), provider__handle__, action__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (provider);
			GC.KeepAlive (action);
		}
		/// <param name="provider">The provider to which the provider delegate belongs.</param><param name="action">The hold call action to perform.</param><summary>Performs a hold call action.</summary><remarks>This method can also be used to resume, or unhold, a call.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("provider:performSetHeldCallAction:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PerformSetHeldCallAction (CXProvider provider, CXSetHeldCallAction action)
		{
			_PerformSetHeldCallAction (this, provider, action);
		}
		/// <param name="provider">The provider to which the provider delegate belongs.</param><param name="action">The hold call action to perform.</param><summary>Performs a hold call action.</summary><remarks>This method can also be used to resume, or unhold, a call.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _PerformSetHeldCallAction (ICXProviderDelegate This, CXProvider provider, CXSetHeldCallAction action)
		{
			var provider__handle__ = provider!.GetNonNullHandle (nameof (provider));
			var action__handle__ = action!.GetNonNullHandle (nameof (action));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("provider:performSetHeldCallAction:"), provider__handle__, action__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (provider);
			GC.KeepAlive (action);
		}
		/// <param name="provider">The provider to which the provider delegate belongs.</param><param name="action">The set muted call action to perform.</param><summary>Performs a set muted call action.</summary><remarks>This method can also be used to unmute a call.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("provider:performSetMutedCallAction:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PerformSetMutedCallAction (CXProvider provider, CXSetMutedCallAction action)
		{
			_PerformSetMutedCallAction (this, provider, action);
		}
		/// <param name="provider">The provider to which the provider delegate belongs.</param><param name="action">The set muted call action to perform.</param><summary>Performs a set muted call action.</summary><remarks>This method can also be used to unmute a call.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _PerformSetMutedCallAction (ICXProviderDelegate This, CXProvider provider, CXSetMutedCallAction action)
		{
			var provider__handle__ = provider!.GetNonNullHandle (nameof (provider));
			var action__handle__ = action!.GetNonNullHandle (nameof (action));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("provider:performSetMutedCallAction:"), provider__handle__, action__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (provider);
			GC.KeepAlive (action);
		}
		/// <param name="provider">The provider to which the provider delegate belongs.</param><param name="action">The set group call action to perform.</param><summary>Performs a set group call action.</summary><remarks>This method can also be used to unset a group call.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("provider:performSetGroupCallAction:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PerformSetGroupCallAction (CXProvider provider, CXSetGroupCallAction action)
		{
			_PerformSetGroupCallAction (this, provider, action);
		}
		/// <param name="provider">The provider to which the provider delegate belongs.</param><param name="action">The set group call action to perform.</param><summary>Performs a set group call action.</summary><remarks>This method can also be used to unset a group call.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _PerformSetGroupCallAction (ICXProviderDelegate This, CXProvider provider, CXSetGroupCallAction action)
		{
			var provider__handle__ = provider!.GetNonNullHandle (nameof (provider));
			var action__handle__ = action!.GetNonNullHandle (nameof (action));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("provider:performSetGroupCallAction:"), provider__handle__, action__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (provider);
			GC.KeepAlive (action);
		}
		/// <param name="provider">The provider to which the provider delegate belongs.</param><param name="action">The DTMF play call action to perform.</param><summary>Performs a DTMF play call action.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("provider:performPlayDTMFCallAction:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PerformPlayDtmfCallAction (CXProvider provider, CXPlayDtmfCallAction action)
		{
			_PerformPlayDtmfCallAction (this, provider, action);
		}
		/// <param name="provider">The provider to which the provider delegate belongs.</param><param name="action">The DTMF play call action to perform.</param><summary>Performs a DTMF play call action.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _PerformPlayDtmfCallAction (ICXProviderDelegate This, CXProvider provider, CXPlayDtmfCallAction action)
		{
			var provider__handle__ = provider!.GetNonNullHandle (nameof (provider));
			var action__handle__ = action!.GetNonNullHandle (nameof (action));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("provider:performPlayDTMFCallAction:"), provider__handle__, action__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (provider);
			GC.KeepAlive (action);
		}
		/// <param name="provider">The provider to which the provider delegate belongs.</param><param name="action">The action that timed out.</param><summary>Method that is called when a timeout is hit before an action is finished performing.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("provider:timedOutPerformingAction:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void TimedOutPerformingAction (CXProvider provider, CXAction action)
		{
			_TimedOutPerformingAction (this, provider, action);
		}
		/// <param name="provider">The provider to which the provider delegate belongs.</param><param name="action">The action that timed out.</param><summary>Method that is called when a timeout is hit before an action is finished performing.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _TimedOutPerformingAction (ICXProviderDelegate This, CXProvider provider, CXAction action)
		{
			var provider__handle__ = provider!.GetNonNullHandle (nameof (provider));
			var action__handle__ = action!.GetNonNullHandle (nameof (action));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("provider:timedOutPerformingAction:"), provider__handle__, action__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (provider);
			GC.KeepAlive (action);
		}
		/// <param name="provider">The provider to which the provider delegate belongs.</param><param name="audioSession">To be added.</param><summary>The system activated a telephony-priority audio session for the call.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("provider:didActivateAudioSession:")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidActivateAudioSession (CXProvider provider, global::AVFoundation.AVAudioSession audioSession)
		{
			_DidActivateAudioSession (this, provider, audioSession);
		}
		/// <param name="provider">The provider to which the provider delegate belongs.</param><param name="audioSession">To be added.</param><summary>The system activated a telephony-priority audio session for the call.</summary><remarks>To be added.</remarks>
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidActivateAudioSession (ICXProviderDelegate This, CXProvider provider, global::AVFoundation.AVAudioSession audioSession)
		{
			var provider__handle__ = provider!.GetNonNullHandle (nameof (provider));
			var audioSession__handle__ = audioSession!.GetNonNullHandle (nameof (audioSession));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("provider:didActivateAudioSession:"), provider__handle__, audioSession__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (provider);
			GC.KeepAlive (audioSession);
		}
		/// <param name="provider">The provider to which the provider delegate belongs.</param><param name="audioSession">The audio session that was deactivated.</param><summary>The system deactivated an audio session that the app had been using for a call.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("provider:didDeactivateAudioSession:")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidDeactivateAudioSession (CXProvider provider, global::AVFoundation.AVAudioSession audioSession)
		{
			_DidDeactivateAudioSession (this, provider, audioSession);
		}
		/// <param name="provider">The provider to which the provider delegate belongs.</param><param name="audioSession">The audio session that was deactivated.</param><summary>The system deactivated an audio session that the app had been using for a call.</summary><remarks>To be added.</remarks>
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidDeactivateAudioSession (ICXProviderDelegate This, CXProvider provider, global::AVFoundation.AVAudioSession audioSession)
		{
			var provider__handle__ = provider!.GetNonNullHandle (nameof (provider));
			var audioSession__handle__ = audioSession!.GetNonNullHandle (nameof (audioSession));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("provider:didDeactivateAudioSession:"), provider__handle__, audioSession__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (provider);
			GC.KeepAlive (audioSession);
		}
		[DynamicDependencyAttribute ("DidActivateAudioSession(CallKit.CXProvider,AVFoundation.AVAudioSession)")]
		[DynamicDependencyAttribute ("DidBegin(CallKit.CXProvider)")]
		[DynamicDependencyAttribute ("DidDeactivateAudioSession(CallKit.CXProvider,AVFoundation.AVAudioSession)")]
		[DynamicDependencyAttribute ("DidReset(CallKit.CXProvider)")]
		[DynamicDependencyAttribute ("ExecuteTransaction(CallKit.CXProvider,CallKit.CXTransaction)")]
		[DynamicDependencyAttribute ("PerformAnswerCallAction(CallKit.CXProvider,CallKit.CXAnswerCallAction)")]
		[DynamicDependencyAttribute ("PerformEndCallAction(CallKit.CXProvider,CallKit.CXEndCallAction)")]
		[DynamicDependencyAttribute ("PerformPlayDtmfCallAction(CallKit.CXProvider,CallKit.CXPlayDtmfCallAction)")]
		[DynamicDependencyAttribute ("PerformSetGroupCallAction(CallKit.CXProvider,CallKit.CXSetGroupCallAction)")]
		[DynamicDependencyAttribute ("PerformSetHeldCallAction(CallKit.CXProvider,CallKit.CXSetHeldCallAction)")]
		[DynamicDependencyAttribute ("PerformSetMutedCallAction(CallKit.CXProvider,CallKit.CXSetMutedCallAction)")]
		[DynamicDependencyAttribute ("PerformStartCallAction(CallKit.CXProvider,CallKit.CXStartCallAction)")]
		[DynamicDependencyAttribute ("TimedOutPerformingAction(CallKit.CXProvider,CallKit.CXAction)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (CXProviderDelegateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static ICXProviderDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="ICXProviderDelegate" /> interface to support all the methods from the CXProviderDelegate protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="ICXProviderDelegate" /> interface allow developers to treat instances of the interface as having all the optional methods of the original CXProviderDelegate protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class CXProviderDelegate_Extensions {
		/// <param name="provider">The provider to which the provider delegate belongs.</param><summary>The system began a call for the app.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidBegin (this ICXProviderDelegate This, CXProvider provider)
		{
			var provider__handle__ = provider!.GetNonNullHandle (nameof (provider));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("providerDidBegin:"), provider__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (provider);
		}
		/// <param name="provider">The provider to which the provider delegate belongs.</param><param name="transaction">The transaction to run.</param><summary>Atomically runs the actions that are contained in the <paramref name="transaction" />.</summary><returns><see langword="true" /> if the transaction succeeded. Otherwise, <see langword="false" />.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool ExecuteTransaction (this ICXProviderDelegate This, CXProvider provider, CXTransaction transaction)
		{
			var provider__handle__ = provider!.GetNonNullHandle (nameof (provider));
			var transaction__handle__ = transaction!.GetNonNullHandle (nameof (transaction));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("provider:executeTransaction:"), provider__handle__, transaction__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (provider);
			GC.KeepAlive (transaction);
			return ret != 0;
		}
		/// <param name="provider">The provider to which the provider delegate belongs.</param><param name="action">The start call action to perform.</param><summary>Performs a start call action.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void PerformStartCallAction (this ICXProviderDelegate This, CXProvider provider, CXStartCallAction action)
		{
			var provider__handle__ = provider!.GetNonNullHandle (nameof (provider));
			var action__handle__ = action!.GetNonNullHandle (nameof (action));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("provider:performStartCallAction:"), provider__handle__, action__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (provider);
			GC.KeepAlive (action);
		}
		/// <param name="provider">The provider to which the provider delegate belongs.</param><param name="action">The answer call action to perform.</param><summary>Performs an answer call action.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void PerformAnswerCallAction (this ICXProviderDelegate This, CXProvider provider, CXAnswerCallAction action)
		{
			var provider__handle__ = provider!.GetNonNullHandle (nameof (provider));
			var action__handle__ = action!.GetNonNullHandle (nameof (action));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("provider:performAnswerCallAction:"), provider__handle__, action__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (provider);
			GC.KeepAlive (action);
		}
		/// <param name="provider">The provider to which the provider delegate belongs.</param><param name="action">The end call action to perform.</param><summary>Performs an end call action.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void PerformEndCallAction (this ICXProviderDelegate This, CXProvider provider, CXEndCallAction action)
		{
			var provider__handle__ = provider!.GetNonNullHandle (nameof (provider));
			var action__handle__ = action!.GetNonNullHandle (nameof (action));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("provider:performEndCallAction:"), provider__handle__, action__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (provider);
			GC.KeepAlive (action);
		}
		/// <param name="provider">The provider to which the provider delegate belongs.</param><param name="action">The hold call action to perform.</param><summary>Performs a hold call action.</summary><remarks>This method can also be used to resume, or unhold, a call.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void PerformSetHeldCallAction (this ICXProviderDelegate This, CXProvider provider, CXSetHeldCallAction action)
		{
			var provider__handle__ = provider!.GetNonNullHandle (nameof (provider));
			var action__handle__ = action!.GetNonNullHandle (nameof (action));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("provider:performSetHeldCallAction:"), provider__handle__, action__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (provider);
			GC.KeepAlive (action);
		}
		/// <param name="provider">The provider to which the provider delegate belongs.</param><param name="action">The set muted call action to perform.</param><summary>Performs a set muted call action.</summary><remarks>This method can also be used to unmute a call.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void PerformSetMutedCallAction (this ICXProviderDelegate This, CXProvider provider, CXSetMutedCallAction action)
		{
			var provider__handle__ = provider!.GetNonNullHandle (nameof (provider));
			var action__handle__ = action!.GetNonNullHandle (nameof (action));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("provider:performSetMutedCallAction:"), provider__handle__, action__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (provider);
			GC.KeepAlive (action);
		}
		/// <param name="provider">The provider to which the provider delegate belongs.</param><param name="action">The set group call action to perform.</param><summary>Performs a set group call action.</summary><remarks>This method can also be used to unset a group call.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void PerformSetGroupCallAction (this ICXProviderDelegate This, CXProvider provider, CXSetGroupCallAction action)
		{
			var provider__handle__ = provider!.GetNonNullHandle (nameof (provider));
			var action__handle__ = action!.GetNonNullHandle (nameof (action));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("provider:performSetGroupCallAction:"), provider__handle__, action__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (provider);
			GC.KeepAlive (action);
		}
		/// <param name="provider">The provider to which the provider delegate belongs.</param><param name="action">The DTMF play call action to perform.</param><summary>Performs a DTMF play call action.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void PerformPlayDtmfCallAction (this ICXProviderDelegate This, CXProvider provider, CXPlayDtmfCallAction action)
		{
			var provider__handle__ = provider!.GetNonNullHandle (nameof (provider));
			var action__handle__ = action!.GetNonNullHandle (nameof (action));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("provider:performPlayDTMFCallAction:"), provider__handle__, action__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (provider);
			GC.KeepAlive (action);
		}
		/// <param name="provider">The provider to which the provider delegate belongs.</param><param name="action">The action that timed out.</param><summary>Method that is called when a timeout is hit before an action is finished performing.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void TimedOutPerformingAction (this ICXProviderDelegate This, CXProvider provider, CXAction action)
		{
			var provider__handle__ = provider!.GetNonNullHandle (nameof (provider));
			var action__handle__ = action!.GetNonNullHandle (nameof (action));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("provider:timedOutPerformingAction:"), provider__handle__, action__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (provider);
			GC.KeepAlive (action);
		}
		/// <param name="provider">The provider to which the provider delegate belongs.</param><param name="audioSession">To be added.</param><summary>The system activated a telephony-priority audio session for the call.</summary><remarks>To be added.</remarks>
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidActivateAudioSession (this ICXProviderDelegate This, CXProvider provider, global::AVFoundation.AVAudioSession audioSession)
		{
			var provider__handle__ = provider!.GetNonNullHandle (nameof (provider));
			var audioSession__handle__ = audioSession!.GetNonNullHandle (nameof (audioSession));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("provider:didActivateAudioSession:"), provider__handle__, audioSession__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (provider);
			GC.KeepAlive (audioSession);
		}
		/// <param name="provider">The provider to which the provider delegate belongs.</param><param name="audioSession">The audio session that was deactivated.</param><summary>The system deactivated an audio session that the app had been using for a call.</summary><remarks>To be added.</remarks>
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidDeactivateAudioSession (this ICXProviderDelegate This, CXProvider provider, global::AVFoundation.AVAudioSession audioSession)
		{
			var provider__handle__ = provider!.GetNonNullHandle (nameof (provider));
			var audioSession__handle__ = audioSession!.GetNonNullHandle (nameof (audioSession));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("provider:didDeactivateAudioSession:"), provider__handle__, audioSession__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (provider);
			GC.KeepAlive (audioSession);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class CXProviderDelegateWrapper : BaseWrapper, ICXProviderDelegate {
		public CXProviderDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (CXProviderDelegateWrapper))]
		static CXProviderDelegateWrapper ()
		{
			GC.KeepAlive (null);
		}
		/// <param name="provider">The provider to which the provider delegate belongs.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("providerDidReset:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void DidReset (CXProvider provider)
		{
			var provider__handle__ = provider!.GetNonNullHandle (nameof (provider));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("providerDidReset:"), provider__handle__);
			GC.KeepAlive (provider);
		}
	}
}
namespace CallKit {
	/// <related type="externalDocumentation" href="https://developer.apple.com/reference/CallKit/CXProviderDelegate">Apple documentation for <c>CXProviderDelegate</c></related>
	[Protocol()]
	[Register("Microsoft_MacCatalyst__CallKit_CXProviderDelegate", false)]
	[Model]
	[UnsupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	public unsafe abstract partial class CXProviderDelegate : NSObject, ICXProviderDelegate {
		/// <summary>Creates a new <see cref="CXProviderDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected CXProviderDelegate () : base (NSObjectFlag.Empty)
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
		protected CXProviderDelegate (NSObjectFlag t) : base (t)
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
		protected internal CXProviderDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		/// <param name="provider">The provider to which the provider delegate belongs.</param><param name="audioSession">To be added.</param><summary>The system activated a telephony-priority audio session for the call.</summary><remarks>To be added.</remarks>
		[Export ("provider:didActivateAudioSession:")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidActivateAudioSession (CXProvider provider, global::AVFoundation.AVAudioSession audioSession)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="provider">The provider to which the provider delegate belongs.</param><summary>The system began a call for the app.</summary><remarks>To be added.</remarks>
		[Export ("providerDidBegin:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidBegin (CXProvider provider)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="provider">The provider to which the provider delegate belongs.</param><param name="audioSession">The audio session that was deactivated.</param><summary>The system deactivated an audio session that the app had been using for a call.</summary><remarks>To be added.</remarks>
		[Export ("provider:didDeactivateAudioSession:")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidDeactivateAudioSession (CXProvider provider, global::AVFoundation.AVAudioSession audioSession)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="provider">The provider to which the provider delegate belongs.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("providerDidReset:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidReset (CXProvider provider)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="provider">The provider to which the provider delegate belongs.</param><param name="transaction">The transaction to run.</param><summary>Atomically runs the actions that are contained in the <paramref name="transaction" />.</summary><returns><see langword="true" /> if the transaction succeeded. Otherwise, <see langword="false" />.</returns><remarks>To be added.</remarks>
		[Export ("provider:executeTransaction:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ExecuteTransaction (CXProvider provider, CXTransaction transaction)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="provider">The provider to which the provider delegate belongs.</param><param name="action">The answer call action to perform.</param><summary>Performs an answer call action.</summary><remarks>To be added.</remarks>
		[Export ("provider:performAnswerCallAction:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PerformAnswerCallAction (CXProvider provider, CXAnswerCallAction action)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="provider">The provider to which the provider delegate belongs.</param><param name="action">The end call action to perform.</param><summary>Performs an end call action.</summary><remarks>To be added.</remarks>
		[Export ("provider:performEndCallAction:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PerformEndCallAction (CXProvider provider, CXEndCallAction action)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="provider">The provider to which the provider delegate belongs.</param><param name="action">The DTMF play call action to perform.</param><summary>Performs a DTMF play call action.</summary><remarks>To be added.</remarks>
		[Export ("provider:performPlayDTMFCallAction:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PerformPlayDtmfCallAction (CXProvider provider, CXPlayDtmfCallAction action)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="provider">The provider to which the provider delegate belongs.</param><param name="action">The set group call action to perform.</param><summary>Performs a set group call action.</summary><remarks>This method can also be used to unset a group call.</remarks>
		[Export ("provider:performSetGroupCallAction:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PerformSetGroupCallAction (CXProvider provider, CXSetGroupCallAction action)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="provider">The provider to which the provider delegate belongs.</param><param name="action">The hold call action to perform.</param><summary>Performs a hold call action.</summary><remarks>This method can also be used to resume, or unhold, a call.</remarks>
		[Export ("provider:performSetHeldCallAction:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PerformSetHeldCallAction (CXProvider provider, CXSetHeldCallAction action)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="provider">The provider to which the provider delegate belongs.</param><param name="action">The set muted call action to perform.</param><summary>Performs a set muted call action.</summary><remarks>This method can also be used to unmute a call.</remarks>
		[Export ("provider:performSetMutedCallAction:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PerformSetMutedCallAction (CXProvider provider, CXSetMutedCallAction action)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="provider">The provider to which the provider delegate belongs.</param><param name="action">The start call action to perform.</param><summary>Performs a start call action.</summary><remarks>To be added.</remarks>
		[Export ("provider:performStartCallAction:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PerformStartCallAction (CXProvider provider, CXStartCallAction action)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="provider">The provider to which the provider delegate belongs.</param><param name="action">The action that timed out.</param><summary>Method that is called when a timeout is hit before an action is finished performing.</summary><remarks>To be added.</remarks>
		[Export ("provider:timedOutPerformingAction:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void TimedOutPerformingAction (CXProvider provider, CXAction action)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class CXProviderDelegate */
}
