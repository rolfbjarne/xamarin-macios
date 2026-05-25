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
namespace Foundation {
	#pragma warning disable CS1573
	/// <summary>The URL protocol client category.</summary><remarks>To be added.</remarks>
	[Protocol (Name = "NSURLProtocolClient", WrapperType = typeof (NSUrlProtocolClientWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "Redirected", Selector = "URLProtocol:wasRedirectedToRequest:redirectResponse:", ParameterType = new Type [] { typeof (NSUrlProtocol), typeof (NSUrlRequest), typeof (NSUrlResponse) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "CachedResponseIsValid", Selector = "URLProtocol:cachedResponseIsValid:", ParameterType = new Type [] { typeof (NSUrlProtocol), typeof (NSCachedUrlResponse) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "ReceivedResponse", Selector = "URLProtocol:didReceiveResponse:cacheStoragePolicy:", ParameterType = new Type [] { typeof (NSUrlProtocol), typeof (NSUrlResponse), typeof (NSUrlCacheStoragePolicy) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "DataLoaded", Selector = "URLProtocol:didLoadData:", ParameterType = new Type [] { typeof (NSUrlProtocol), typeof (NSData) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "FinishedLoading", Selector = "URLProtocolDidFinishLoading:", ParameterType = new Type [] { typeof (NSUrlProtocol) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "FailedWithError", Selector = "URLProtocol:didFailWithError:", ParameterType = new Type [] { typeof (NSUrlProtocol), typeof (NSError) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "ReceivedAuthenticationChallenge", Selector = "URLProtocol:didReceiveAuthenticationChallenge:", ParameterType = new Type [] { typeof (NSUrlProtocol), typeof (NSUrlAuthenticationChallenge) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "CancelledAuthenticationChallenge", Selector = "URLProtocol:didCancelAuthenticationChallenge:", ParameterType = new Type [] { typeof (NSUrlProtocol), typeof (NSUrlAuthenticationChallenge) }, ParameterByRef = new bool [] { false, false })]
	public partial interface INSUrlProtocolClient : INativeObject, IDisposable
	{
		/// <param name="protocol">To be added.</param><param name="redirectedToEequest">To be added.</param><param name="redirectResponse">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("URLProtocol:wasRedirectedToRequest:redirectResponse:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Redirected (NSUrlProtocol protocol, NSUrlRequest redirectedToEequest, NSUrlResponse redirectResponse)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="protocol">To be added.</param><param name="redirectedToEequest">To be added.</param><param name="redirectResponse">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _Redirected (INSUrlProtocolClient This, NSUrlProtocol protocol, NSUrlRequest redirectedToEequest, NSUrlResponse redirectResponse)
		{
			var protocol__handle__ = protocol!.GetNonNullHandle (nameof (protocol));
			var redirectedToEequest__handle__ = redirectedToEequest!.GetNonNullHandle (nameof (redirectedToEequest));
			var redirectResponse__handle__ = redirectResponse!.GetNonNullHandle (nameof (redirectResponse));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("URLProtocol:wasRedirectedToRequest:redirectResponse:"), protocol__handle__, redirectedToEequest__handle__, redirectResponse__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (protocol);
			GC.KeepAlive (redirectedToEequest);
			GC.KeepAlive (redirectResponse);
		}
		/// <param name="protocol">To be added.</param><param name="cachedResponse">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("URLProtocol:cachedResponseIsValid:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void CachedResponseIsValid (NSUrlProtocol protocol, NSCachedUrlResponse cachedResponse)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="protocol">To be added.</param><param name="cachedResponse">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _CachedResponseIsValid (INSUrlProtocolClient This, NSUrlProtocol protocol, NSCachedUrlResponse cachedResponse)
		{
			var protocol__handle__ = protocol!.GetNonNullHandle (nameof (protocol));
			var cachedResponse__handle__ = cachedResponse!.GetNonNullHandle (nameof (cachedResponse));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("URLProtocol:cachedResponseIsValid:"), protocol__handle__, cachedResponse__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (protocol);
			GC.KeepAlive (cachedResponse);
		}
		/// <param name="protocol">To be added.</param><param name="response">To be added.</param><param name="policy">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("URLProtocol:didReceiveResponse:cacheStoragePolicy:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ReceivedResponse (NSUrlProtocol protocol, NSUrlResponse response, NSUrlCacheStoragePolicy policy)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="protocol">To be added.</param><param name="response">To be added.</param><param name="policy">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _ReceivedResponse (INSUrlProtocolClient This, NSUrlProtocol protocol, NSUrlResponse response, NSUrlCacheStoragePolicy policy)
		{
			var protocol__handle__ = protocol!.GetNonNullHandle (nameof (protocol));
			var response__handle__ = response!.GetNonNullHandle (nameof (response));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_UIntPtr (This.Handle, Selector.GetHandle ("URLProtocol:didReceiveResponse:cacheStoragePolicy:"), protocol__handle__, response__handle__, (UIntPtr) (ulong) policy);
			GC.KeepAlive (This);
			GC.KeepAlive (protocol);
			GC.KeepAlive (response);
		}
		/// <param name="protocol">To be added.</param><param name="data">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("URLProtocol:didLoadData:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DataLoaded (NSUrlProtocol protocol, NSData data)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="protocol">To be added.</param><param name="data">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DataLoaded (INSUrlProtocolClient This, NSUrlProtocol protocol, NSData data)
		{
			var protocol__handle__ = protocol!.GetNonNullHandle (nameof (protocol));
			var data__handle__ = data!.GetNonNullHandle (nameof (data));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("URLProtocol:didLoadData:"), protocol__handle__, data__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (protocol);
			GC.KeepAlive (data);
		}
		/// <param name="protocol">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("URLProtocolDidFinishLoading:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void FinishedLoading (NSUrlProtocol protocol)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="protocol">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _FinishedLoading (INSUrlProtocolClient This, NSUrlProtocol protocol)
		{
			var protocol__handle__ = protocol!.GetNonNullHandle (nameof (protocol));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("URLProtocolDidFinishLoading:"), protocol__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (protocol);
		}
		/// <param name="protocol">To be added.</param><param name="error">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("URLProtocol:didFailWithError:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void FailedWithError (NSUrlProtocol protocol, NSError error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="protocol">To be added.</param><param name="error">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _FailedWithError (INSUrlProtocolClient This, NSUrlProtocol protocol, NSError error)
		{
			var protocol__handle__ = protocol!.GetNonNullHandle (nameof (protocol));
			var error__handle__ = error!.GetNonNullHandle (nameof (error));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("URLProtocol:didFailWithError:"), protocol__handle__, error__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (protocol);
			GC.KeepAlive (error);
		}
		/// <param name="protocol">To be added.</param><param name="challenge">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("URLProtocol:didReceiveAuthenticationChallenge:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ReceivedAuthenticationChallenge (NSUrlProtocol protocol, NSUrlAuthenticationChallenge challenge)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="protocol">To be added.</param><param name="challenge">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _ReceivedAuthenticationChallenge (INSUrlProtocolClient This, NSUrlProtocol protocol, NSUrlAuthenticationChallenge challenge)
		{
			var protocol__handle__ = protocol!.GetNonNullHandle (nameof (protocol));
			var challenge__handle__ = challenge!.GetNonNullHandle (nameof (challenge));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("URLProtocol:didReceiveAuthenticationChallenge:"), protocol__handle__, challenge__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (protocol);
			GC.KeepAlive (challenge);
		}
		/// <param name="protocol">To be added.</param><param name="challenge">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("URLProtocol:didCancelAuthenticationChallenge:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void CancelledAuthenticationChallenge (NSUrlProtocol protocol, NSUrlAuthenticationChallenge challenge)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="protocol">To be added.</param><param name="challenge">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _CancelledAuthenticationChallenge (INSUrlProtocolClient This, NSUrlProtocol protocol, NSUrlAuthenticationChallenge challenge)
		{
			var protocol__handle__ = protocol!.GetNonNullHandle (nameof (protocol));
			var challenge__handle__ = challenge!.GetNonNullHandle (nameof (challenge));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("URLProtocol:didCancelAuthenticationChallenge:"), protocol__handle__, challenge__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (protocol);
			GC.KeepAlive (challenge);
		}
		[DynamicDependencyAttribute ("CachedResponseIsValid(Foundation.NSUrlProtocol,Foundation.NSCachedUrlResponse)")]
		[DynamicDependencyAttribute ("CancelledAuthenticationChallenge(Foundation.NSUrlProtocol,Foundation.NSUrlAuthenticationChallenge)")]
		[DynamicDependencyAttribute ("DataLoaded(Foundation.NSUrlProtocol,Foundation.NSData)")]
		[DynamicDependencyAttribute ("FailedWithError(Foundation.NSUrlProtocol,Foundation.NSError)")]
		[DynamicDependencyAttribute ("FinishedLoading(Foundation.NSUrlProtocol)")]
		[DynamicDependencyAttribute ("ReceivedAuthenticationChallenge(Foundation.NSUrlProtocol,Foundation.NSUrlAuthenticationChallenge)")]
		[DynamicDependencyAttribute ("ReceivedResponse(Foundation.NSUrlProtocol,Foundation.NSUrlResponse,Foundation.NSUrlCacheStoragePolicy)")]
		[DynamicDependencyAttribute ("Redirected(Foundation.NSUrlProtocol,Foundation.NSUrlRequest,Foundation.NSUrlResponse)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSUrlProtocolClientWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static INSUrlProtocolClient ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class NSUrlProtocolClientWrapper : BaseWrapper, INSUrlProtocolClient {
		public NSUrlProtocolClientWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSUrlProtocolClientWrapper))]
		static NSUrlProtocolClientWrapper ()
		{
			GC.KeepAlive (null);
		}
		/// <param name="protocol">To be added.</param><param name="redirectedToEequest">To be added.</param><param name="redirectResponse">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("URLProtocol:wasRedirectedToRequest:redirectResponse:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void Redirected (NSUrlProtocol protocol, NSUrlRequest redirectedToEequest, NSUrlResponse redirectResponse)
		{
			var protocol__handle__ = protocol!.GetNonNullHandle (nameof (protocol));
			var redirectedToEequest__handle__ = redirectedToEequest!.GetNonNullHandle (nameof (redirectedToEequest));
			var redirectResponse__handle__ = redirectResponse!.GetNonNullHandle (nameof (redirectResponse));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("URLProtocol:wasRedirectedToRequest:redirectResponse:"), protocol__handle__, redirectedToEequest__handle__, redirectResponse__handle__);
			GC.KeepAlive (protocol);
			GC.KeepAlive (redirectedToEequest);
			GC.KeepAlive (redirectResponse);
		}
		/// <param name="protocol">To be added.</param><param name="cachedResponse">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("URLProtocol:cachedResponseIsValid:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void CachedResponseIsValid (NSUrlProtocol protocol, NSCachedUrlResponse cachedResponse)
		{
			var protocol__handle__ = protocol!.GetNonNullHandle (nameof (protocol));
			var cachedResponse__handle__ = cachedResponse!.GetNonNullHandle (nameof (cachedResponse));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("URLProtocol:cachedResponseIsValid:"), protocol__handle__, cachedResponse__handle__);
			GC.KeepAlive (protocol);
			GC.KeepAlive (cachedResponse);
		}
		/// <param name="protocol">To be added.</param><param name="response">To be added.</param><param name="policy">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("URLProtocol:didReceiveResponse:cacheStoragePolicy:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void ReceivedResponse (NSUrlProtocol protocol, NSUrlResponse response, NSUrlCacheStoragePolicy policy)
		{
			var protocol__handle__ = protocol!.GetNonNullHandle (nameof (protocol));
			var response__handle__ = response!.GetNonNullHandle (nameof (response));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_UIntPtr (this.Handle, Selector.GetHandle ("URLProtocol:didReceiveResponse:cacheStoragePolicy:"), protocol__handle__, response__handle__, (UIntPtr) (ulong) policy);
			GC.KeepAlive (protocol);
			GC.KeepAlive (response);
		}
		/// <param name="protocol">To be added.</param><param name="data">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("URLProtocol:didLoadData:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void DataLoaded (NSUrlProtocol protocol, NSData data)
		{
			var protocol__handle__ = protocol!.GetNonNullHandle (nameof (protocol));
			var data__handle__ = data!.GetNonNullHandle (nameof (data));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("URLProtocol:didLoadData:"), protocol__handle__, data__handle__);
			GC.KeepAlive (protocol);
			GC.KeepAlive (data);
		}
		/// <param name="protocol">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("URLProtocolDidFinishLoading:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void FinishedLoading (NSUrlProtocol protocol)
		{
			var protocol__handle__ = protocol!.GetNonNullHandle (nameof (protocol));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("URLProtocolDidFinishLoading:"), protocol__handle__);
			GC.KeepAlive (protocol);
		}
		/// <param name="protocol">To be added.</param><param name="error">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("URLProtocol:didFailWithError:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void FailedWithError (NSUrlProtocol protocol, NSError error)
		{
			var protocol__handle__ = protocol!.GetNonNullHandle (nameof (protocol));
			var error__handle__ = error!.GetNonNullHandle (nameof (error));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("URLProtocol:didFailWithError:"), protocol__handle__, error__handle__);
			GC.KeepAlive (protocol);
			GC.KeepAlive (error);
		}
		/// <param name="protocol">To be added.</param><param name="challenge">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("URLProtocol:didReceiveAuthenticationChallenge:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void ReceivedAuthenticationChallenge (NSUrlProtocol protocol, NSUrlAuthenticationChallenge challenge)
		{
			var protocol__handle__ = protocol!.GetNonNullHandle (nameof (protocol));
			var challenge__handle__ = challenge!.GetNonNullHandle (nameof (challenge));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("URLProtocol:didReceiveAuthenticationChallenge:"), protocol__handle__, challenge__handle__);
			GC.KeepAlive (protocol);
			GC.KeepAlive (challenge);
		}
		/// <param name="protocol">To be added.</param><param name="challenge">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("URLProtocol:didCancelAuthenticationChallenge:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void CancelledAuthenticationChallenge (NSUrlProtocol protocol, NSUrlAuthenticationChallenge challenge)
		{
			var protocol__handle__ = protocol!.GetNonNullHandle (nameof (protocol));
			var challenge__handle__ = challenge!.GetNonNullHandle (nameof (challenge));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("URLProtocol:didCancelAuthenticationChallenge:"), protocol__handle__, challenge__handle__);
			GC.KeepAlive (protocol);
			GC.KeepAlive (challenge);
		}
	}
}
