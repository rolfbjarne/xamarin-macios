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
	/// <summary>This interface represents the Objective-C protocol <c>NSURLDownloadDelegate</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[UnsupportedOSPlatform ("ios")]
	[UnsupportedOSPlatform ("maccatalyst")]
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("macos")]
	[Protocol (Name = "NSURLDownloadDelegate", WrapperType = typeof (NSUrlDownloadDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DownloadBegan", Selector = "downloadDidBegin:", ParameterType = new Type [] { typeof (NSUrlDownload) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillSendRequest", Selector = "download:willSendRequest:redirectResponse:", ReturnType = typeof (NSUrlRequest), ParameterType = new Type [] { typeof (NSUrlDownload), typeof (NSUrlRequest), typeof (NSUrlResponse) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ReceivedAuthenticationChallenge", Selector = "download:didReceiveAuthenticationChallenge:", ParameterType = new Type [] { typeof (NSUrlDownload), typeof (NSUrlAuthenticationChallenge) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "CanceledAuthenticationChallenge", Selector = "download:didCancelAuthenticationChallenge:", ParameterType = new Type [] { typeof (NSUrlDownload), typeof (NSUrlAuthenticationChallenge) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ReceivedResponse", Selector = "download:didReceiveResponse:", ParameterType = new Type [] { typeof (NSUrlDownload), typeof (NSUrlResponse) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "Resume", Selector = "download:willResumeWithResponse:fromByte:", ParameterType = new Type [] { typeof (NSUrlDownload), typeof (NSUrlResponse), typeof (long) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ReceivedData", Selector = "download:didReceiveDataOfLength:", ParameterType = new Type [] { typeof (NSUrlDownload), typeof (UIntPtr) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DecodeSourceData", Selector = "download:shouldDecodeSourceDataOfMIMEType:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (NSUrlDownload), typeof (string) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DecideDestination", Selector = "download:decideDestinationWithSuggestedFilename:", ParameterType = new Type [] { typeof (NSUrlDownload), typeof (string) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "CreatedDestination", Selector = "download:didCreateDestination:", ParameterType = new Type [] { typeof (NSUrlDownload), typeof (string) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "Finished", Selector = "downloadDidFinish:", ParameterType = new Type [] { typeof (NSUrlDownload) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "FailedWithError", Selector = "download:didFailWithError:", ParameterType = new Type [] { typeof (NSUrlDownload), typeof (NSError) }, ParameterByRef = new bool [] { false, false })]
	public partial interface INSUrlDownloadDelegate : INativeObject, IDisposable
	{
		/// <param name="download">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("downloadDidBegin:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DownloadBegan (NSUrlDownload download)
		{
			_DownloadBegan (this, download);
		}
		/// <param name="download">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DownloadBegan (INSUrlDownloadDelegate This, NSUrlDownload download)
		{
			var download__handle__ = download!.GetNonNullHandle (nameof (download));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("downloadDidBegin:"), download__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (download);
		}
		/// <param name="download">To be added.</param><param name="request">To be added.</param><param name="redirectResponse">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("download:willSendRequest:redirectResponse:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSUrlRequest WillSendRequest (NSUrlDownload download, NSUrlRequest request, NSUrlResponse redirectResponse)
		{
			return _WillSendRequest (this, download, request, redirectResponse);
		}
		/// <param name="download">To be added.</param><param name="request">To be added.</param><param name="redirectResponse">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSUrlRequest _WillSendRequest (INSUrlDownloadDelegate This, NSUrlDownload download, NSUrlRequest request, NSUrlResponse redirectResponse)
		{
			var download__handle__ = download!.GetNonNullHandle (nameof (download));
			var request__handle__ = request!.GetNonNullHandle (nameof (request));
			var redirectResponse__handle__ = redirectResponse!.GetNonNullHandle (nameof (redirectResponse));
			NSUrlRequest? ret;
			ret =  Runtime.GetNSObject<NSUrlRequest> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("download:willSendRequest:redirectResponse:"), download__handle__, request__handle__, redirectResponse__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (download);
			GC.KeepAlive (request);
			GC.KeepAlive (redirectResponse);
			return ret!;
		}
		/// <param name="download">To be added.</param><param name="challenge">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("download:didReceiveAuthenticationChallenge:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ReceivedAuthenticationChallenge (NSUrlDownload download, NSUrlAuthenticationChallenge challenge)
		{
			_ReceivedAuthenticationChallenge (this, download, challenge);
		}
		/// <param name="download">To be added.</param><param name="challenge">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _ReceivedAuthenticationChallenge (INSUrlDownloadDelegate This, NSUrlDownload download, NSUrlAuthenticationChallenge challenge)
		{
			var download__handle__ = download!.GetNonNullHandle (nameof (download));
			var challenge__handle__ = challenge!.GetNonNullHandle (nameof (challenge));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("download:didReceiveAuthenticationChallenge:"), download__handle__, challenge__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (download);
			GC.KeepAlive (challenge);
		}
		/// <param name="download">To be added.</param><param name="challenge">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("download:didCancelAuthenticationChallenge:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void CanceledAuthenticationChallenge (NSUrlDownload download, NSUrlAuthenticationChallenge challenge)
		{
			_CanceledAuthenticationChallenge (this, download, challenge);
		}
		/// <param name="download">To be added.</param><param name="challenge">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _CanceledAuthenticationChallenge (INSUrlDownloadDelegate This, NSUrlDownload download, NSUrlAuthenticationChallenge challenge)
		{
			var download__handle__ = download!.GetNonNullHandle (nameof (download));
			var challenge__handle__ = challenge!.GetNonNullHandle (nameof (challenge));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("download:didCancelAuthenticationChallenge:"), download__handle__, challenge__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (download);
			GC.KeepAlive (challenge);
		}
		/// <param name="download">To be added.</param><param name="response">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("download:didReceiveResponse:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ReceivedResponse (NSUrlDownload download, NSUrlResponse response)
		{
			_ReceivedResponse (this, download, response);
		}
		/// <param name="download">To be added.</param><param name="response">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _ReceivedResponse (INSUrlDownloadDelegate This, NSUrlDownload download, NSUrlResponse response)
		{
			var download__handle__ = download!.GetNonNullHandle (nameof (download));
			var response__handle__ = response!.GetNonNullHandle (nameof (response));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("download:didReceiveResponse:"), download__handle__, response__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (download);
			GC.KeepAlive (response);
		}
		/// <param name="download">To be added.</param><param name="response">To be added.</param><param name="startingByte">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("download:willResumeWithResponse:fromByte:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Resume (NSUrlDownload download, NSUrlResponse response, long startingByte)
		{
			_Resume (this, download, response, startingByte);
		}
		/// <param name="download">To be added.</param><param name="response">To be added.</param><param name="startingByte">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _Resume (INSUrlDownloadDelegate This, NSUrlDownload download, NSUrlResponse response, long startingByte)
		{
			var download__handle__ = download!.GetNonNullHandle (nameof (download));
			var response__handle__ = response!.GetNonNullHandle (nameof (response));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_Int64 (This.Handle, Selector.GetHandle ("download:willResumeWithResponse:fromByte:"), download__handle__, response__handle__, startingByte);
			GC.KeepAlive (This);
			GC.KeepAlive (download);
			GC.KeepAlive (response);
		}
		/// <param name="download">To be added.</param><param name="length">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("download:didReceiveDataOfLength:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ReceivedData (NSUrlDownload download, nuint length)
		{
			_ReceivedData (this, download, length);
		}
		/// <param name="download">To be added.</param><param name="length">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _ReceivedData (INSUrlDownloadDelegate This, NSUrlDownload download, nuint length)
		{
			var download__handle__ = download!.GetNonNullHandle (nameof (download));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr (This.Handle, Selector.GetHandle ("download:didReceiveDataOfLength:"), download__handle__, length);
			GC.KeepAlive (This);
			GC.KeepAlive (download);
		}
		/// <param name="download">To be added.</param><param name="encodingType">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("download:shouldDecodeSourceDataOfMIMEType:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool DecodeSourceData (NSUrlDownload download, string encodingType)
		{
			return _DecodeSourceData (this, download, encodingType);
		}
		/// <param name="download">To be added.</param><param name="encodingType">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _DecodeSourceData (INSUrlDownloadDelegate This, NSUrlDownload download, string encodingType)
		{
			var download__handle__ = download!.GetNonNullHandle (nameof (download));
			if (encodingType is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (encodingType));
			var nsencodingType = CFString.CreateNative (encodingType);
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("download:shouldDecodeSourceDataOfMIMEType:"), download__handle__, nsencodingType);
			GC.KeepAlive (This);
			GC.KeepAlive (download);
			CFString.ReleaseNative (nsencodingType);
			return ret != 0;
		}
		/// <param name="download">To be added.</param><param name="suggestedFilename">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("download:decideDestinationWithSuggestedFilename:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DecideDestination (NSUrlDownload download, string suggestedFilename)
		{
			_DecideDestination (this, download, suggestedFilename);
		}
		/// <param name="download">To be added.</param><param name="suggestedFilename">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DecideDestination (INSUrlDownloadDelegate This, NSUrlDownload download, string suggestedFilename)
		{
			var download__handle__ = download!.GetNonNullHandle (nameof (download));
			if (suggestedFilename is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (suggestedFilename));
			var nssuggestedFilename = CFString.CreateNative (suggestedFilename);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("download:decideDestinationWithSuggestedFilename:"), download__handle__, nssuggestedFilename);
			GC.KeepAlive (This);
			GC.KeepAlive (download);
			CFString.ReleaseNative (nssuggestedFilename);
		}
		/// <param name="download">To be added.</param><param name="path">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("download:didCreateDestination:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void CreatedDestination (NSUrlDownload download, string path)
		{
			_CreatedDestination (this, download, path);
		}
		/// <param name="download">To be added.</param><param name="path">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _CreatedDestination (INSUrlDownloadDelegate This, NSUrlDownload download, string path)
		{
			var download__handle__ = download!.GetNonNullHandle (nameof (download));
			if (path is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (path));
			var nspath = CFString.CreateNative (path);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("download:didCreateDestination:"), download__handle__, nspath);
			GC.KeepAlive (This);
			GC.KeepAlive (download);
			CFString.ReleaseNative (nspath);
		}
		/// <param name="download">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("downloadDidFinish:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Finished (NSUrlDownload download)
		{
			_Finished (this, download);
		}
		/// <param name="download">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _Finished (INSUrlDownloadDelegate This, NSUrlDownload download)
		{
			var download__handle__ = download!.GetNonNullHandle (nameof (download));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("downloadDidFinish:"), download__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (download);
		}
		/// <param name="download">To be added.</param><param name="error">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("download:didFailWithError:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void FailedWithError (NSUrlDownload download, NSError error)
		{
			_FailedWithError (this, download, error);
		}
		/// <param name="download">To be added.</param><param name="error">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _FailedWithError (INSUrlDownloadDelegate This, NSUrlDownload download, NSError error)
		{
			var download__handle__ = download!.GetNonNullHandle (nameof (download));
			var error__handle__ = error!.GetNonNullHandle (nameof (error));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("download:didFailWithError:"), download__handle__, error__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (download);
			GC.KeepAlive (error);
		}
		[DynamicDependencyAttribute ("CanceledAuthenticationChallenge(Foundation.NSUrlDownload,Foundation.NSUrlAuthenticationChallenge)")]
		[DynamicDependencyAttribute ("CreatedDestination(Foundation.NSUrlDownload,System.String)")]
		[DynamicDependencyAttribute ("DecideDestination(Foundation.NSUrlDownload,System.String)")]
		[DynamicDependencyAttribute ("DecodeSourceData(Foundation.NSUrlDownload,System.String)")]
		[DynamicDependencyAttribute ("DownloadBegan(Foundation.NSUrlDownload)")]
		[DynamicDependencyAttribute ("FailedWithError(Foundation.NSUrlDownload,Foundation.NSError)")]
		[DynamicDependencyAttribute ("Finished(Foundation.NSUrlDownload)")]
		[DynamicDependencyAttribute ("ReceivedAuthenticationChallenge(Foundation.NSUrlDownload,Foundation.NSUrlAuthenticationChallenge)")]
		[DynamicDependencyAttribute ("ReceivedData(Foundation.NSUrlDownload,System.UIntPtr)")]
		[DynamicDependencyAttribute ("ReceivedResponse(Foundation.NSUrlDownload,Foundation.NSUrlResponse)")]
		[DynamicDependencyAttribute ("Resume(Foundation.NSUrlDownload,Foundation.NSUrlResponse,System.Int64)")]
		[DynamicDependencyAttribute ("WillSendRequest(Foundation.NSUrlDownload,Foundation.NSUrlRequest,Foundation.NSUrlResponse)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSUrlDownloadDelegateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static INSUrlDownloadDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="INSUrlDownloadDelegate" /> interface to support all the methods from the NSURLDownloadDelegate protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="INSUrlDownloadDelegate" /> interface allow developers to treat instances of the interface as having all the optional methods of the original NSURLDownloadDelegate protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class NSUrlDownloadDelegate_Extensions {
		/// <param name="download">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DownloadBegan (this INSUrlDownloadDelegate This, NSUrlDownload download)
		{
			var download__handle__ = download!.GetNonNullHandle (nameof (download));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("downloadDidBegin:"), download__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (download);
		}
		/// <param name="download">To be added.</param><param name="request">To be added.</param><param name="redirectResponse">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSUrlRequest WillSendRequest (this INSUrlDownloadDelegate This, NSUrlDownload download, NSUrlRequest request, NSUrlResponse redirectResponse)
		{
			var download__handle__ = download!.GetNonNullHandle (nameof (download));
			var request__handle__ = request!.GetNonNullHandle (nameof (request));
			var redirectResponse__handle__ = redirectResponse!.GetNonNullHandle (nameof (redirectResponse));
			NSUrlRequest? ret;
			ret =  Runtime.GetNSObject<NSUrlRequest> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("download:willSendRequest:redirectResponse:"), download__handle__, request__handle__, redirectResponse__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (download);
			GC.KeepAlive (request);
			GC.KeepAlive (redirectResponse);
			return ret!;
		}
		/// <param name="download">To be added.</param><param name="challenge">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void ReceivedAuthenticationChallenge (this INSUrlDownloadDelegate This, NSUrlDownload download, NSUrlAuthenticationChallenge challenge)
		{
			var download__handle__ = download!.GetNonNullHandle (nameof (download));
			var challenge__handle__ = challenge!.GetNonNullHandle (nameof (challenge));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("download:didReceiveAuthenticationChallenge:"), download__handle__, challenge__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (download);
			GC.KeepAlive (challenge);
		}
		/// <param name="download">To be added.</param><param name="challenge">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void CanceledAuthenticationChallenge (this INSUrlDownloadDelegate This, NSUrlDownload download, NSUrlAuthenticationChallenge challenge)
		{
			var download__handle__ = download!.GetNonNullHandle (nameof (download));
			var challenge__handle__ = challenge!.GetNonNullHandle (nameof (challenge));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("download:didCancelAuthenticationChallenge:"), download__handle__, challenge__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (download);
			GC.KeepAlive (challenge);
		}
		/// <param name="download">To be added.</param><param name="response">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void ReceivedResponse (this INSUrlDownloadDelegate This, NSUrlDownload download, NSUrlResponse response)
		{
			var download__handle__ = download!.GetNonNullHandle (nameof (download));
			var response__handle__ = response!.GetNonNullHandle (nameof (response));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("download:didReceiveResponse:"), download__handle__, response__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (download);
			GC.KeepAlive (response);
		}
		/// <param name="download">To be added.</param><param name="response">To be added.</param><param name="startingByte">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void Resume (this INSUrlDownloadDelegate This, NSUrlDownload download, NSUrlResponse response, long startingByte)
		{
			var download__handle__ = download!.GetNonNullHandle (nameof (download));
			var response__handle__ = response!.GetNonNullHandle (nameof (response));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_Int64 (This.Handle, Selector.GetHandle ("download:willResumeWithResponse:fromByte:"), download__handle__, response__handle__, startingByte);
			GC.KeepAlive (This);
			GC.KeepAlive (download);
			GC.KeepAlive (response);
		}
		/// <param name="download">To be added.</param><param name="length">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void ReceivedData (this INSUrlDownloadDelegate This, NSUrlDownload download, nuint length)
		{
			var download__handle__ = download!.GetNonNullHandle (nameof (download));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr (This.Handle, Selector.GetHandle ("download:didReceiveDataOfLength:"), download__handle__, length);
			GC.KeepAlive (This);
			GC.KeepAlive (download);
		}
		/// <param name="download">To be added.</param><param name="encodingType">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool DecodeSourceData (this INSUrlDownloadDelegate This, NSUrlDownload download, string encodingType)
		{
			var download__handle__ = download!.GetNonNullHandle (nameof (download));
			if (encodingType is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (encodingType));
			var nsencodingType = CFString.CreateNative (encodingType);
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("download:shouldDecodeSourceDataOfMIMEType:"), download__handle__, nsencodingType);
			GC.KeepAlive (This);
			GC.KeepAlive (download);
			CFString.ReleaseNative (nsencodingType);
			return ret != 0;
		}
		/// <param name="download">To be added.</param><param name="suggestedFilename">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DecideDestination (this INSUrlDownloadDelegate This, NSUrlDownload download, string suggestedFilename)
		{
			var download__handle__ = download!.GetNonNullHandle (nameof (download));
			if (suggestedFilename is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (suggestedFilename));
			var nssuggestedFilename = CFString.CreateNative (suggestedFilename);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("download:decideDestinationWithSuggestedFilename:"), download__handle__, nssuggestedFilename);
			GC.KeepAlive (This);
			GC.KeepAlive (download);
			CFString.ReleaseNative (nssuggestedFilename);
		}
		/// <param name="download">To be added.</param><param name="path">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void CreatedDestination (this INSUrlDownloadDelegate This, NSUrlDownload download, string path)
		{
			var download__handle__ = download!.GetNonNullHandle (nameof (download));
			if (path is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (path));
			var nspath = CFString.CreateNative (path);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("download:didCreateDestination:"), download__handle__, nspath);
			GC.KeepAlive (This);
			GC.KeepAlive (download);
			CFString.ReleaseNative (nspath);
		}
		/// <param name="download">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void Finished (this INSUrlDownloadDelegate This, NSUrlDownload download)
		{
			var download__handle__ = download!.GetNonNullHandle (nameof (download));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("downloadDidFinish:"), download__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (download);
		}
		/// <param name="download">To be added.</param><param name="error">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void FailedWithError (this INSUrlDownloadDelegate This, NSUrlDownload download, NSError error)
		{
			var download__handle__ = download!.GetNonNullHandle (nameof (download));
			var error__handle__ = error!.GetNonNullHandle (nameof (error));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("download:didFailWithError:"), download__handle__, error__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (download);
			GC.KeepAlive (error);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class NSUrlDownloadDelegateWrapper : BaseWrapper, INSUrlDownloadDelegate {
		public NSUrlDownloadDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSUrlDownloadDelegateWrapper))]
		static NSUrlDownloadDelegateWrapper ()
		{
			GC.KeepAlive (null);
		}
	}
}
namespace Foundation {
	/// <summary>
	///   <para>This is a class that implements the interface <see cref="INSUrlDownloadDelegate" /> (for the protocol <c>NSURLDownloadDelegate</c>).</para>
	///   <para>Subclass this class to easily create a type that implements the protocol.</para>
	///   <para>An alternative is to create a subclass of <see cref="NSObject" /> and then implemented the interface <see cref="INSUrlDownloadDelegate" />.</para>
	/// </summary>
	[Protocol(Name = "NSURLDownloadDelegate")]
	[Register("Microsoft_macOS__Foundation_NSUrlDownloadDelegate", false)]
	[Model]
	[UnsupportedOSPlatform ("ios")]
	[UnsupportedOSPlatform ("maccatalyst")]
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("macos")]
	public unsafe partial class NSUrlDownloadDelegate : NSObject, INSUrlDownloadDelegate {
		/// <summary>Creates a new <see cref="NSUrlDownloadDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public NSUrlDownloadDelegate () : base (NSObjectFlag.Empty)
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
		protected NSUrlDownloadDelegate (NSObjectFlag t) : base (t)
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
		protected internal NSUrlDownloadDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		/// <param name="download">To be added.</param><param name="challenge">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("download:didCancelAuthenticationChallenge:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void CanceledAuthenticationChallenge (NSUrlDownload download, NSUrlAuthenticationChallenge challenge)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="download">To be added.</param><param name="path">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("download:didCreateDestination:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void CreatedDestination (NSUrlDownload download, string path)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="download">To be added.</param><param name="suggestedFilename">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("download:decideDestinationWithSuggestedFilename:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DecideDestination (NSUrlDownload download, string suggestedFilename)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="download">To be added.</param><param name="encodingType">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("download:shouldDecodeSourceDataOfMIMEType:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool DecodeSourceData (NSUrlDownload download, string encodingType)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="download">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("downloadDidBegin:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DownloadBegan (NSUrlDownload download)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="download">To be added.</param><param name="error">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("download:didFailWithError:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void FailedWithError (NSUrlDownload download, NSError error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="download">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("downloadDidFinish:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Finished (NSUrlDownload download)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="download">To be added.</param><param name="challenge">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("download:didReceiveAuthenticationChallenge:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ReceivedAuthenticationChallenge (NSUrlDownload download, NSUrlAuthenticationChallenge challenge)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="download">To be added.</param><param name="length">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("download:didReceiveDataOfLength:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ReceivedData (NSUrlDownload download, nuint length)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="download">To be added.</param><param name="response">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("download:didReceiveResponse:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ReceivedResponse (NSUrlDownload download, NSUrlResponse response)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="download">To be added.</param><param name="response">To be added.</param><param name="startingByte">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("download:willResumeWithResponse:fromByte:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Resume (NSUrlDownload download, NSUrlResponse response, long startingByte)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="download">To be added.</param><param name="request">To be added.</param><param name="redirectResponse">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("download:willSendRequest:redirectResponse:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSUrlRequest WillSendRequest (NSUrlDownload download, NSUrlRequest request, NSUrlResponse redirectResponse)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class NSUrlDownloadDelegate */
}
