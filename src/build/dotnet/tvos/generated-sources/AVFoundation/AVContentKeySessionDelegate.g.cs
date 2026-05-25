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
namespace AVFoundation {
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>AVContentKeySessionDelegate</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	[Protocol (Name = "AVContentKeySessionDelegate", WrapperType = typeof (AVContentKeySessionDelegateWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "DidProvideContentKeyRequest", Selector = "contentKeySession:didProvideContentKeyRequest:", ParameterType = new Type [] { typeof (AVContentKeySession), typeof (AVContentKeyRequest) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidProvideRenewingContentKeyRequest", Selector = "contentKeySession:didProvideRenewingContentKeyRequest:", ParameterType = new Type [] { typeof (AVContentKeySession), typeof (AVContentKeyRequest) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidProvidePersistableContentKeyRequest", Selector = "contentKeySession:didProvidePersistableContentKeyRequest:", ParameterType = new Type [] { typeof (AVContentKeySession), typeof (AVPersistableContentKeyRequest) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidFail", Selector = "contentKeySession:contentKeyRequest:didFailWithError:", ParameterType = new Type [] { typeof (AVContentKeySession), typeof (AVContentKeyRequest), typeof (NSError) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldRetryContentKeyRequest", Selector = "contentKeySession:shouldRetryContentKeyRequest:reason:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (AVContentKeySession), typeof (AVContentKeyRequest), typeof (string) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidChange", Selector = "contentKeySessionContentProtectionSessionIdentifierDidChange:", ParameterType = new Type [] { typeof (AVContentKeySession) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidUpdate", Selector = "contentKeySession:didUpdatePersistableContentKey:forContentKeyIdentifier:", ParameterType = new Type [] { typeof (AVContentKeySession), typeof (NSData), typeof (NSObject) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidSucceed", Selector = "contentKeySession:contentKeyRequestDidSucceed:", ParameterType = new Type [] { typeof (AVContentKeySession), typeof (AVContentKeyRequest) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidGenerateExpiredSessionReport", Selector = "contentKeySessionDidGenerateExpiredSessionReport:", ParameterType = new Type [] { typeof (AVContentKeySession) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidProvideContentKeyRequests", Selector = "contentKeySession:didProvideContentKeyRequests:forInitializationData:", ParameterType = new Type [] { typeof (AVContentKeySession), typeof (AVContentKeyRequest[]), typeof (NSData) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ExternalProtectionStatusDidChange", Selector = "contentKeySession:externalProtectionStatusDidChangeForContentKey:", ParameterType = new Type [] { typeof (AVContentKeySession), typeof (AVContentKey) }, ParameterByRef = new bool [] { false, false })]
	public partial interface IAVContentKeySessionDelegate : INativeObject, IDisposable
	{
		/// <param name="session">To be added.</param><param name="keyRequest">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("contentKeySession:didProvideContentKeyRequest:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidProvideContentKeyRequest (AVContentKeySession session, AVContentKeyRequest keyRequest)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="session">To be added.</param><param name="keyRequest">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidProvideContentKeyRequest (IAVContentKeySessionDelegate This, AVContentKeySession session, AVContentKeyRequest keyRequest)
		{
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			var keyRequest__handle__ = keyRequest!.GetNonNullHandle (nameof (keyRequest));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("contentKeySession:didProvideContentKeyRequest:"), session__handle__, keyRequest__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (session);
			GC.KeepAlive (keyRequest);
		}
		/// <param name="session">To be added.</param><param name="keyRequest">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("contentKeySession:didProvideRenewingContentKeyRequest:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidProvideRenewingContentKeyRequest (AVContentKeySession session, AVContentKeyRequest keyRequest)
		{
			_DidProvideRenewingContentKeyRequest (this, session, keyRequest);
		}
		/// <param name="session">To be added.</param><param name="keyRequest">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidProvideRenewingContentKeyRequest (IAVContentKeySessionDelegate This, AVContentKeySession session, AVContentKeyRequest keyRequest)
		{
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			var keyRequest__handle__ = keyRequest!.GetNonNullHandle (nameof (keyRequest));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("contentKeySession:didProvideRenewingContentKeyRequest:"), session__handle__, keyRequest__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (session);
			GC.KeepAlive (keyRequest);
		}
		/// <param name="session">To be added.</param><param name="keyRequest">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("contentKeySession:didProvidePersistableContentKeyRequest:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidProvidePersistableContentKeyRequest (AVContentKeySession session, AVPersistableContentKeyRequest keyRequest)
		{
			_DidProvidePersistableContentKeyRequest (this, session, keyRequest);
		}
		/// <param name="session">To be added.</param><param name="keyRequest">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidProvidePersistableContentKeyRequest (IAVContentKeySessionDelegate This, AVContentKeySession session, AVPersistableContentKeyRequest keyRequest)
		{
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			var keyRequest__handle__ = keyRequest!.GetNonNullHandle (nameof (keyRequest));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("contentKeySession:didProvidePersistableContentKeyRequest:"), session__handle__, keyRequest__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (session);
			GC.KeepAlive (keyRequest);
		}
		/// <param name="session">To be added.</param><param name="keyRequest">To be added.</param><param name="err">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("contentKeySession:contentKeyRequest:didFailWithError:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidFail (AVContentKeySession session, AVContentKeyRequest keyRequest, NSError err)
		{
			_DidFail (this, session, keyRequest, err);
		}
		/// <param name="session">To be added.</param><param name="keyRequest">To be added.</param><param name="err">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidFail (IAVContentKeySessionDelegate This, AVContentKeySession session, AVContentKeyRequest keyRequest, NSError err)
		{
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			var keyRequest__handle__ = keyRequest!.GetNonNullHandle (nameof (keyRequest));
			var err__handle__ = err!.GetNonNullHandle (nameof (err));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("contentKeySession:contentKeyRequest:didFailWithError:"), session__handle__, keyRequest__handle__, err__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (session);
			GC.KeepAlive (keyRequest);
			GC.KeepAlive (err);
		}
		/// <param name="session">To be added.</param><param name="keyRequest">To be added.</param><param name="retryReason">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("contentKeySession:shouldRetryContentKeyRequest:reason:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldRetryContentKeyRequest (AVContentKeySession session, AVContentKeyRequest keyRequest, string retryReason)
		{
			return _ShouldRetryContentKeyRequest (this, session, keyRequest, retryReason);
		}
		/// <param name="session">To be added.</param><param name="keyRequest">To be added.</param><param name="retryReason">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _ShouldRetryContentKeyRequest (IAVContentKeySessionDelegate This, AVContentKeySession session, AVContentKeyRequest keyRequest, string retryReason)
		{
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			var keyRequest__handle__ = keyRequest!.GetNonNullHandle (nameof (keyRequest));
			if (retryReason is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (retryReason));
			var nsretryReason = CFString.CreateNative (retryReason);
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("contentKeySession:shouldRetryContentKeyRequest:reason:"), session__handle__, keyRequest__handle__, nsretryReason);
			GC.KeepAlive (This);
			GC.KeepAlive (session);
			GC.KeepAlive (keyRequest);
			CFString.ReleaseNative (nsretryReason);
			return ret != 0;
		}
		/// <param name="session">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("contentKeySessionContentProtectionSessionIdentifierDidChange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidChange (AVContentKeySession session)
		{
			_DidChange (this, session);
		}
		/// <param name="session">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidChange (IAVContentKeySessionDelegate This, AVContentKeySession session)
		{
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("contentKeySessionContentProtectionSessionIdentifierDidChange:"), session__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (session);
		}
		/// <param name="session">The session that is supplying the information for the event.</param><param name="persistableContentKey">The updated key.</param><param name="keyIdentifier">The identifier for the updated key.</param><summary>Developers may override this method to handle a request  for a an updated <paramref name="persistableContentKey" /> that was made with the specified <paramref name="keyIdentifier" />.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("contentKeySession:didUpdatePersistableContentKey:forContentKeyIdentifier:")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidUpdate (AVContentKeySession session, NSData persistableContentKey, NSObject keyIdentifier)
		{
			_DidUpdate (this, session, persistableContentKey, keyIdentifier);
		}
		/// <param name="session">The session that is supplying the information for the event.</param><param name="persistableContentKey">The updated key.</param><param name="keyIdentifier">The identifier for the updated key.</param><summary>Developers may override this method to handle a request  for a an updated <paramref name="persistableContentKey" /> that was made with the specified <paramref name="keyIdentifier" />.</summary><remarks>To be added.</remarks>
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidUpdate (IAVContentKeySessionDelegate This, AVContentKeySession session, NSData persistableContentKey, NSObject keyIdentifier)
		{
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			var persistableContentKey__handle__ = persistableContentKey!.GetNonNullHandle (nameof (persistableContentKey));
			var keyIdentifier__handle__ = keyIdentifier!.GetNonNullHandle (nameof (keyIdentifier));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("contentKeySession:didUpdatePersistableContentKey:forContentKeyIdentifier:"), session__handle__, persistableContentKey__handle__, keyIdentifier__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (session);
			GC.KeepAlive (persistableContentKey);
			GC.KeepAlive (keyIdentifier);
		}
		/// <param name="session">To be added.</param><param name="keyRequest">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("contentKeySession:contentKeyRequestDidSucceed:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidSucceed (AVContentKeySession session, AVContentKeyRequest keyRequest)
		{
			_DidSucceed (this, session, keyRequest);
		}
		/// <param name="session">To be added.</param><param name="keyRequest">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidSucceed (IAVContentKeySessionDelegate This, AVContentKeySession session, AVContentKeyRequest keyRequest)
		{
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			var keyRequest__handle__ = keyRequest!.GetNonNullHandle (nameof (keyRequest));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("contentKeySession:contentKeyRequestDidSucceed:"), session__handle__, keyRequest__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (session);
			GC.KeepAlive (keyRequest);
		}
		/// <param name="session">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("contentKeySessionDidGenerateExpiredSessionReport:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidGenerateExpiredSessionReport (AVContentKeySession session)
		{
			_DidGenerateExpiredSessionReport (this, session);
		}
		/// <param name="session">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidGenerateExpiredSessionReport (IAVContentKeySessionDelegate This, AVContentKeySession session)
		{
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("contentKeySessionDidGenerateExpiredSessionReport:"), session__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (session);
		}
		[global::Foundation.OptionalMember]
		[Export ("contentKeySession:didProvideContentKeyRequests:forInitializationData:")]
		[SupportedOSPlatform ("tvos17.4")]
		[SupportedOSPlatform ("macos14.4")]
		[SupportedOSPlatform ("ios17.4")]
		[SupportedOSPlatform ("maccatalyst17.4")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidProvideContentKeyRequests (AVContentKeySession session, AVContentKeyRequest[] keyRequests, NSData? initializationData)
		{
			_DidProvideContentKeyRequests (this, session, keyRequests, initializationData);
		}
		[SupportedOSPlatform ("tvos17.4")]
		[SupportedOSPlatform ("macos14.4")]
		[SupportedOSPlatform ("ios17.4")]
		[SupportedOSPlatform ("maccatalyst17.4")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidProvideContentKeyRequests (IAVContentKeySessionDelegate This, AVContentKeySession session, AVContentKeyRequest[] keyRequests, NSData? initializationData)
		{
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			if (keyRequests is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (keyRequests));
			var initializationData__handle__ = initializationData.GetHandle ();
			using var nsa_keyRequests = NSArray.FromNSObjects (keyRequests);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("contentKeySession:didProvideContentKeyRequests:forInitializationData:"), session__handle__, nsa_keyRequests.Handle, initializationData__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (session);
			GC.KeepAlive (initializationData);
		}
		[global::Foundation.OptionalMember]
		[Export ("contentKeySession:externalProtectionStatusDidChangeForContentKey:")]
		[SupportedOSPlatform ("tvos17.4")]
		[SupportedOSPlatform ("macos14.4")]
		[SupportedOSPlatform ("ios17.4")]
		[SupportedOSPlatform ("maccatalyst17.4")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ExternalProtectionStatusDidChange (AVContentKeySession session, AVContentKey contentKey)
		{
			_ExternalProtectionStatusDidChange (this, session, contentKey);
		}
		[SupportedOSPlatform ("tvos17.4")]
		[SupportedOSPlatform ("macos14.4")]
		[SupportedOSPlatform ("ios17.4")]
		[SupportedOSPlatform ("maccatalyst17.4")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _ExternalProtectionStatusDidChange (IAVContentKeySessionDelegate This, AVContentKeySession session, AVContentKey contentKey)
		{
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			var contentKey__handle__ = contentKey!.GetNonNullHandle (nameof (contentKey));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("contentKeySession:externalProtectionStatusDidChangeForContentKey:"), session__handle__, contentKey__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (session);
			GC.KeepAlive (contentKey);
		}
		[DynamicDependencyAttribute ("DidChange(AVFoundation.AVContentKeySession)")]
		[DynamicDependencyAttribute ("DidFail(AVFoundation.AVContentKeySession,AVFoundation.AVContentKeyRequest,Foundation.NSError)")]
		[DynamicDependencyAttribute ("DidGenerateExpiredSessionReport(AVFoundation.AVContentKeySession)")]
		[DynamicDependencyAttribute ("DidProvideContentKeyRequest(AVFoundation.AVContentKeySession,AVFoundation.AVContentKeyRequest)")]
		[DynamicDependencyAttribute ("DidProvideContentKeyRequests(AVFoundation.AVContentKeySession,AVFoundation.AVContentKeyRequest[],Foundation.NSData)")]
		[DynamicDependencyAttribute ("DidProvidePersistableContentKeyRequest(AVFoundation.AVContentKeySession,AVFoundation.AVPersistableContentKeyRequest)")]
		[DynamicDependencyAttribute ("DidProvideRenewingContentKeyRequest(AVFoundation.AVContentKeySession,AVFoundation.AVContentKeyRequest)")]
		[DynamicDependencyAttribute ("DidSucceed(AVFoundation.AVContentKeySession,AVFoundation.AVContentKeyRequest)")]
		[DynamicDependencyAttribute ("DidUpdate(AVFoundation.AVContentKeySession,Foundation.NSData,Foundation.NSObject)")]
		[DynamicDependencyAttribute ("ExternalProtectionStatusDidChange(AVFoundation.AVContentKeySession,AVFoundation.AVContentKey)")]
		[DynamicDependencyAttribute ("ShouldRetryContentKeyRequest(AVFoundation.AVContentKeySession,AVFoundation.AVContentKeyRequest,System.String)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (AVContentKeySessionDelegateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IAVContentKeySessionDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="IAVContentKeySessionDelegate" /> interface to support all the methods from the AVContentKeySessionDelegate protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IAVContentKeySessionDelegate" /> interface allow developers to treat instances of the interface as having all the optional methods of the original AVContentKeySessionDelegate protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class AVContentKeySessionDelegate_Extensions {
		/// <param name="session">To be added.</param><param name="keyRequest">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidProvideRenewingContentKeyRequest (this IAVContentKeySessionDelegate This, AVContentKeySession session, AVContentKeyRequest keyRequest)
		{
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			var keyRequest__handle__ = keyRequest!.GetNonNullHandle (nameof (keyRequest));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("contentKeySession:didProvideRenewingContentKeyRequest:"), session__handle__, keyRequest__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (session);
			GC.KeepAlive (keyRequest);
		}
		/// <param name="session">To be added.</param><param name="keyRequest">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidProvidePersistableContentKeyRequest (this IAVContentKeySessionDelegate This, AVContentKeySession session, AVPersistableContentKeyRequest keyRequest)
		{
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			var keyRequest__handle__ = keyRequest!.GetNonNullHandle (nameof (keyRequest));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("contentKeySession:didProvidePersistableContentKeyRequest:"), session__handle__, keyRequest__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (session);
			GC.KeepAlive (keyRequest);
		}
		/// <param name="session">To be added.</param><param name="keyRequest">To be added.</param><param name="err">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidFail (this IAVContentKeySessionDelegate This, AVContentKeySession session, AVContentKeyRequest keyRequest, NSError err)
		{
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			var keyRequest__handle__ = keyRequest!.GetNonNullHandle (nameof (keyRequest));
			var err__handle__ = err!.GetNonNullHandle (nameof (err));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("contentKeySession:contentKeyRequest:didFailWithError:"), session__handle__, keyRequest__handle__, err__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (session);
			GC.KeepAlive (keyRequest);
			GC.KeepAlive (err);
		}
		/// <param name="session">To be added.</param><param name="keyRequest">To be added.</param><param name="retryReason">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool ShouldRetryContentKeyRequest (this IAVContentKeySessionDelegate This, AVContentKeySession session, AVContentKeyRequest keyRequest, string retryReason)
		{
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			var keyRequest__handle__ = keyRequest!.GetNonNullHandle (nameof (keyRequest));
			if (retryReason is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (retryReason));
			var nsretryReason = CFString.CreateNative (retryReason);
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("contentKeySession:shouldRetryContentKeyRequest:reason:"), session__handle__, keyRequest__handle__, nsretryReason);
			GC.KeepAlive (This);
			GC.KeepAlive (session);
			GC.KeepAlive (keyRequest);
			CFString.ReleaseNative (nsretryReason);
			return ret != 0;
		}
		/// <param name="session">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidChange (this IAVContentKeySessionDelegate This, AVContentKeySession session)
		{
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("contentKeySessionContentProtectionSessionIdentifierDidChange:"), session__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (session);
		}
		/// <param name="session">The session that is supplying the information for the event.</param><param name="persistableContentKey">The updated key.</param><param name="keyIdentifier">The identifier for the updated key.</param><summary>Developers may override this method to handle a request  for a an updated <paramref name="persistableContentKey" /> that was made with the specified <paramref name="keyIdentifier" />.</summary><remarks>To be added.</remarks>
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidUpdate (this IAVContentKeySessionDelegate This, AVContentKeySession session, NSData persistableContentKey, NSObject keyIdentifier)
		{
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			var persistableContentKey__handle__ = persistableContentKey!.GetNonNullHandle (nameof (persistableContentKey));
			var keyIdentifier__handle__ = keyIdentifier!.GetNonNullHandle (nameof (keyIdentifier));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("contentKeySession:didUpdatePersistableContentKey:forContentKeyIdentifier:"), session__handle__, persistableContentKey__handle__, keyIdentifier__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (session);
			GC.KeepAlive (persistableContentKey);
			GC.KeepAlive (keyIdentifier);
		}
		/// <param name="session">To be added.</param><param name="keyRequest">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidSucceed (this IAVContentKeySessionDelegate This, AVContentKeySession session, AVContentKeyRequest keyRequest)
		{
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			var keyRequest__handle__ = keyRequest!.GetNonNullHandle (nameof (keyRequest));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("contentKeySession:contentKeyRequestDidSucceed:"), session__handle__, keyRequest__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (session);
			GC.KeepAlive (keyRequest);
		}
		/// <param name="session">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidGenerateExpiredSessionReport (this IAVContentKeySessionDelegate This, AVContentKeySession session)
		{
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("contentKeySessionDidGenerateExpiredSessionReport:"), session__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (session);
		}
		[SupportedOSPlatform ("tvos17.4")]
		[SupportedOSPlatform ("macos14.4")]
		[SupportedOSPlatform ("ios17.4")]
		[SupportedOSPlatform ("maccatalyst17.4")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidProvideContentKeyRequests (this IAVContentKeySessionDelegate This, AVContentKeySession session, AVContentKeyRequest[] keyRequests, NSData? initializationData)
		{
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			if (keyRequests is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (keyRequests));
			var initializationData__handle__ = initializationData.GetHandle ();
			using var nsa_keyRequests = NSArray.FromNSObjects (keyRequests);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("contentKeySession:didProvideContentKeyRequests:forInitializationData:"), session__handle__, nsa_keyRequests.Handle, initializationData__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (session);
			GC.KeepAlive (initializationData);
		}
		[SupportedOSPlatform ("tvos17.4")]
		[SupportedOSPlatform ("macos14.4")]
		[SupportedOSPlatform ("ios17.4")]
		[SupportedOSPlatform ("maccatalyst17.4")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void ExternalProtectionStatusDidChange (this IAVContentKeySessionDelegate This, AVContentKeySession session, AVContentKey contentKey)
		{
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			var contentKey__handle__ = contentKey!.GetNonNullHandle (nameof (contentKey));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("contentKeySession:externalProtectionStatusDidChangeForContentKey:"), session__handle__, contentKey__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (session);
			GC.KeepAlive (contentKey);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class AVContentKeySessionDelegateWrapper : BaseWrapper, IAVContentKeySessionDelegate {
		public AVContentKeySessionDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (AVContentKeySessionDelegateWrapper))]
		static AVContentKeySessionDelegateWrapper ()
		{
			GC.KeepAlive (null);
		}
		/// <param name="session">To be added.</param><param name="keyRequest">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("contentKeySession:didProvideContentKeyRequest:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void DidProvideContentKeyRequest (AVContentKeySession session, AVContentKeyRequest keyRequest)
		{
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			var keyRequest__handle__ = keyRequest!.GetNonNullHandle (nameof (keyRequest));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("contentKeySession:didProvideContentKeyRequest:"), session__handle__, keyRequest__handle__);
			GC.KeepAlive (session);
			GC.KeepAlive (keyRequest);
		}
	}
}
namespace AVFoundation {
	/// <summary>
	///   <para>This is a class that implements the interface <see cref="IAVContentKeySessionDelegate" /> (for the protocol <c>AVContentKeySessionDelegate</c>).</para>
	///   <para>Subclass this class to easily create a type that implements the protocol.</para>
	///   <para>An alternative is to create a subclass of <see cref="NSObject" /> and then implemented the interface <see cref="IAVContentKeySessionDelegate" />.</para>
	/// </summary>
	[Protocol()]
	[Register("Microsoft_tvOS__AVFoundation_AVContentKeySessionDelegate", false)]
	[Model]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe abstract partial class AVContentKeySessionDelegate : NSObject, IAVContentKeySessionDelegate {
		/// <summary>Creates a new <see cref="AVContentKeySessionDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected AVContentKeySessionDelegate () : base (NSObjectFlag.Empty)
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
		protected AVContentKeySessionDelegate (NSObjectFlag t) : base (t)
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
		protected internal AVContentKeySessionDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		/// <param name="session">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("contentKeySessionContentProtectionSessionIdentifierDidChange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidChange (AVContentKeySession session)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="session">To be added.</param><param name="keyRequest">To be added.</param><param name="err">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("contentKeySession:contentKeyRequest:didFailWithError:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidFail (AVContentKeySession session, AVContentKeyRequest keyRequest, NSError err)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="session">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("contentKeySessionDidGenerateExpiredSessionReport:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidGenerateExpiredSessionReport (AVContentKeySession session)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="session">To be added.</param><param name="keyRequest">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("contentKeySession:didProvideContentKeyRequest:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidProvideContentKeyRequest (AVContentKeySession session, AVContentKeyRequest keyRequest)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("contentKeySession:didProvideContentKeyRequests:forInitializationData:")]
		[SupportedOSPlatform ("tvos17.4")]
		[SupportedOSPlatform ("macos14.4")]
		[SupportedOSPlatform ("ios17.4")]
		[SupportedOSPlatform ("maccatalyst17.4")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidProvideContentKeyRequests (AVContentKeySession session, AVContentKeyRequest[] keyRequests, NSData? initializationData)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="session">To be added.</param><param name="keyRequest">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("contentKeySession:didProvidePersistableContentKeyRequest:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidProvidePersistableContentKeyRequest (AVContentKeySession session, AVPersistableContentKeyRequest keyRequest)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="session">To be added.</param><param name="keyRequest">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("contentKeySession:didProvideRenewingContentKeyRequest:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidProvideRenewingContentKeyRequest (AVContentKeySession session, AVContentKeyRequest keyRequest)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="session">To be added.</param><param name="keyRequest">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("contentKeySession:contentKeyRequestDidSucceed:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidSucceed (AVContentKeySession session, AVContentKeyRequest keyRequest)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="session">The session that is supplying the information for the event.</param><param name="persistableContentKey">The updated key.</param><param name="keyIdentifier">The identifier for the updated key.</param><summary>Developers may override this method to handle a request  for a an updated <paramref name="persistableContentKey" /> that was made with the specified <paramref name="keyIdentifier" />.</summary><remarks>To be added.</remarks>
		[Export ("contentKeySession:didUpdatePersistableContentKey:forContentKeyIdentifier:")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidUpdate (AVContentKeySession session, NSData persistableContentKey, NSObject keyIdentifier)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("contentKeySession:externalProtectionStatusDidChangeForContentKey:")]
		[SupportedOSPlatform ("tvos17.4")]
		[SupportedOSPlatform ("macos14.4")]
		[SupportedOSPlatform ("ios17.4")]
		[SupportedOSPlatform ("maccatalyst17.4")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ExternalProtectionStatusDidChange (AVContentKeySession session, AVContentKey contentKey)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="session">To be added.</param><param name="keyRequest">To be added.</param><param name="retryReason">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("contentKeySession:shouldRetryContentKeyRequest:reason:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldRetryContentKeyRequest (AVContentKeySession session, AVContentKeyRequest keyRequest, string retryReason)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class AVContentKeySessionDelegate */
}
