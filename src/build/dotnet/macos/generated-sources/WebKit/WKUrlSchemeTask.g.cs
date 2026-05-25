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
namespace WebKit {
	#pragma warning disable CS1573
	/// <summary>Interface for a task that loads data from a URL with an arbitrary scheme.</summary>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[Protocol (Name = "WKURLSchemeTask", WrapperType = typeof (WKUrlSchemeTaskWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "DidReceiveResponse", Selector = "didReceiveResponse:", ParameterType = new Type [] { typeof (NSUrlResponse) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "DidReceiveData", Selector = "didReceiveData:", ParameterType = new Type [] { typeof (NSData) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "DidFinish", Selector = "didFinish")]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "DidFailWithError", Selector = "didFailWithError:", ParameterType = new Type [] { typeof (NSError) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "Request", Selector = "request", PropertyType = typeof (NSUrlRequest), GetterSelector = "request", ArgumentSemantic = ArgumentSemantic.Copy)]
	public partial interface IWKUrlSchemeTask : INativeObject, IDisposable
	{
		/// <param name="response">The response that was received.</param><summary>Method that is called to indicate that the task received a response.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("didReceiveResponse:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidReceiveResponse (NSUrlResponse response)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="response">The response that was received.</param><summary>Method that is called to indicate that the task received a response.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidReceiveResponse (IWKUrlSchemeTask This, NSUrlResponse response)
		{
			var response__handle__ = response!.GetNonNullHandle (nameof (response));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("didReceiveResponse:"), response__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (response);
		}
		/// <param name="data">The data that was received.</param><summary>Method that is called to indicate that the task received the data.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("didReceiveData:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidReceiveData (NSData data)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="data">The data that was received.</param><summary>Method that is called to indicate that the task received the data.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidReceiveData (IWKUrlSchemeTask This, NSData data)
		{
			var data__handle__ = data!.GetNonNullHandle (nameof (data));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("didReceiveData:"), data__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (data);
		}
		/// <summary>Method that is called to indicate that the task is finished.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("didFinish")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidFinish ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <summary>Method that is called to indicate that the task is finished.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidFinish (IWKUrlSchemeTask This)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("didFinish"));
			GC.KeepAlive (This);
		}
		/// <param name="error">The error that occurred.</param><summary>Method that is called to indicate failure.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("didFailWithError:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidFailWithError (NSError error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="error">The error that occurred.</param><summary>Method that is called to indicate failure.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidFailWithError (IWKUrlSchemeTask This, NSError error)
		{
			var error__handle__ = error!.GetNonNullHandle (nameof (error));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("didFailWithError:"), error__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (error);
		}
		[DynamicDependencyAttribute ("DidFailWithError(Foundation.NSError)")]
		[DynamicDependencyAttribute ("DidFinish()")]
		[DynamicDependencyAttribute ("DidReceiveData(Foundation.NSData)")]
		[DynamicDependencyAttribute ("DidReceiveResponse(Foundation.NSUrlResponse)")]
		[DynamicDependencyAttribute ("Request")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (WKUrlSchemeTaskWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IWKUrlSchemeTask ()
		{
			GC.KeepAlive (null);
		}
		/// <summary>Gets the request.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual NSUrlRequest Request {
			[Export ("request", ArgumentSemantic.Copy)]
			get {
				return _GetRequest (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSUrlRequest _GetRequest (IWKUrlSchemeTask This)
		{
			NSUrlRequest ret;
			ret =  Runtime.GetNSObject<NSUrlRequest> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("request")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class WKUrlSchemeTaskWrapper : BaseWrapper, IWKUrlSchemeTask {
		public WKUrlSchemeTaskWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (WKUrlSchemeTaskWrapper))]
		static WKUrlSchemeTaskWrapper ()
		{
			GC.KeepAlive (null);
		}
		/// <param name="response">The response that was received.</param><summary>Method that is called to indicate that the task received a response.</summary><remarks>To be added.</remarks>
		[Export ("didReceiveResponse:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void DidReceiveResponse (NSUrlResponse response)
		{
			var response__handle__ = response!.GetNonNullHandle (nameof (response));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("didReceiveResponse:"), response__handle__);
			GC.KeepAlive (response);
		}
		/// <param name="data">The data that was received.</param><summary>Method that is called to indicate that the task received the data.</summary><remarks>To be added.</remarks>
		[Export ("didReceiveData:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void DidReceiveData (NSData data)
		{
			var data__handle__ = data!.GetNonNullHandle (nameof (data));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("didReceiveData:"), data__handle__);
			GC.KeepAlive (data);
		}
		/// <summary>Method that is called to indicate that the task is finished.</summary><remarks>To be added.</remarks>
		[Export ("didFinish")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void DidFinish ()
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("didFinish"));
		}
		/// <param name="error">The error that occurred.</param><summary>Method that is called to indicate failure.</summary><remarks>To be added.</remarks>
		[Export ("didFailWithError:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void DidFailWithError (NSError error)
		{
			var error__handle__ = error!.GetNonNullHandle (nameof (error));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("didFailWithError:"), error__handle__);
			GC.KeepAlive (error);
		}
		/// <summary>Gets the request.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSUrlRequest Request {
			[Export ("request", ArgumentSemantic.Copy)]
			get {
				NSUrlRequest ret;
				ret =  Runtime.GetNSObject<NSUrlRequest> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("request")), false)!;
				return ret;
			}
		}
	}
}
