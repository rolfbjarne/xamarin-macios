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
namespace AVFoundation {
	[Register("AVAssetResourceLoadingRequest", true)]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe partial class AVAssetResourceLoadingRequest : NSObject {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selContentInformationRequestX = "contentInformationRequest";
		static readonly NativeHandle selContentInformationRequestXHandle = Selector.GetHandle ("contentInformationRequest");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDataRequestX = "dataRequest";
		static readonly NativeHandle selDataRequestXHandle = Selector.GetHandle ("dataRequest");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFinishLoadingX = "finishLoading";
		static readonly NativeHandle selFinishLoadingXHandle = Selector.GetHandle ("finishLoading");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFinishLoadingWithError_X = "finishLoadingWithError:";
		static readonly NativeHandle selFinishLoadingWithError_XHandle = Selector.GetHandle ("finishLoadingWithError:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFinishLoadingWithResponse_Data_Redirect_X = "finishLoadingWithResponse:data:redirect:";
		static readonly NativeHandle selFinishLoadingWithResponse_Data_Redirect_XHandle = Selector.GetHandle ("finishLoadingWithResponse:data:redirect:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsCancelledX = "isCancelled";
		static readonly NativeHandle selIsCancelledXHandle = Selector.GetHandle ("isCancelled");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsFinishedX = "isFinished";
		static readonly NativeHandle selIsFinishedXHandle = Selector.GetHandle ("isFinished");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPersistentContentKeyFromKeyVendorResponse_Options_Error_X = "persistentContentKeyFromKeyVendorResponse:options:error:";
		static readonly NativeHandle selPersistentContentKeyFromKeyVendorResponse_Options_Error_XHandle = Selector.GetHandle ("persistentContentKeyFromKeyVendorResponse:options:error:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRedirectX = "redirect";
		static readonly NativeHandle selRedirectXHandle = Selector.GetHandle ("redirect");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRequestX = "request";
		static readonly NativeHandle selRequestXHandle = Selector.GetHandle ("request");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRequestorX = "requestor";
		static readonly NativeHandle selRequestorXHandle = Selector.GetHandle ("requestor");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selResponseX = "response";
		static readonly NativeHandle selResponseXHandle = Selector.GetHandle ("response");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetRedirect_X = "setRedirect:";
		static readonly NativeHandle selSetRedirect_XHandle = Selector.GetHandle ("setRedirect:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetResponse_X = "setResponse:";
		static readonly NativeHandle selSetResponse_XHandle = Selector.GetHandle ("setResponse:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selStreamingContentKeyRequestDataForApp_ContentIdentifier_Options_Error_X = "streamingContentKeyRequestDataForApp:contentIdentifier:options:error:";
		static readonly NativeHandle selStreamingContentKeyRequestDataForApp_ContentIdentifier_Options_Error_XHandle = Selector.GetHandle ("streamingContentKeyRequestDataForApp:contentIdentifier:options:error:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("AVAssetResourceLoadingRequest");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
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
		protected AVAssetResourceLoadingRequest (NSObjectFlag t) : base (t)
		{
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
		protected internal AVAssetResourceLoadingRequest (NativeHandle handle) : base (handle)
		{
		}

		[Export ("finishLoadingWithResponse:data:redirect:")]
		[ObsoletedOSPlatform ("macos10.15", "Use the 'Response', 'Redirect' properties and the 'AVAssetResourceLoadingDataRequest.Responds' and 'AVAssetResourceLoadingRequest.FinishLoading' methods instead.")]
		[ObsoletedOSPlatform ("tvos9.0", "Use the 'Response', 'Redirect' properties and the 'AVAssetResourceLoadingDataRequest.Responds' and 'AVAssetResourceLoadingRequest.FinishLoading' methods instead.")]
		[ObsoletedOSPlatform ("ios7.0", "Use the 'Response', 'Redirect' properties and the 'AVAssetResourceLoadingDataRequest.Responds' and 'AVAssetResourceLoadingRequest.FinishLoading' methods instead.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use the 'Response', 'Redirect' properties and the 'AVAssetResourceLoadingDataRequest.Responds' and 'AVAssetResourceLoadingRequest.FinishLoading' methods instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void FinishLoading (NSUrlResponse? usingResponse, NSData? data, NSUrlRequest? redirect)
		{
			var usingResponse__handle__ = usingResponse.GetHandle ();
			var data__handle__ = data.GetHandle ();
			var redirect__handle__ = redirect.GetHandle ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, selFinishLoadingWithResponse_Data_Redirect_XHandle, usingResponse__handle__, data__handle__, redirect__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, selFinishLoadingWithResponse_Data_Redirect_XHandle, usingResponse__handle__, data__handle__, redirect__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (usingResponse);
			GC.KeepAlive (data);
			GC.KeepAlive (redirect);
		}
		[Export ("finishLoading")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void FinishLoading ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selFinishLoadingXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selFinishLoadingXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("finishLoadingWithError:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void FinishLoadingWithError (NSError? error)
		{
			var error__handle__ = error.GetHandle ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selFinishLoadingWithError_XHandle, error__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selFinishLoadingWithError_XHandle, error__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (error);
		}
		[Export ("persistentContentKeyFromKeyVendorResponse:options:error:")]
		[ObsoletedOSPlatform ("macos12.0")]
		[ObsoletedOSPlatform ("ios15.0")]
		[ObsoletedOSPlatform ("tvos15.0")]
		[ObsoletedOSPlatform ("maccatalyst15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual NSData? GetPersistentContentKey (NSData keyVendorResponse, NSDictionary<NSString, NSObject>? options, out NSError error)
		{
			var keyVendorResponse__handle__ = keyVendorResponse!.GetNonNullHandle (nameof (keyVendorResponse));
			var options__handle__ = options.GetHandle ();
			NativeHandle errorValue = IntPtr.Zero;
			NSData? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSData> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_ref_NativeHandle (this.Handle, selPersistentContentKeyFromKeyVendorResponse_Options_Error_XHandle, keyVendorResponse__handle__, options__handle__, &errorValue), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSData> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_ref_NativeHandle (&__objc_super__, selPersistentContentKeyFromKeyVendorResponse_Options_Error_XHandle, keyVendorResponse__handle__, options__handle__, &errorValue), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (keyVendorResponse);
			GC.KeepAlive (options);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		[Export ("streamingContentKeyRequestDataForApp:contentIdentifier:options:error:")]
		[ObsoletedOSPlatform ("macos12.0")]
		[ObsoletedOSPlatform ("ios15.0")]
		[ObsoletedOSPlatform ("tvos15.0")]
		[ObsoletedOSPlatform ("maccatalyst15.0")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual NSData? GetStreamingContentKey (NSData appIdentifier, NSData contentIdentifier, NSDictionary? options, out NSError error)
		{
			var appIdentifier__handle__ = appIdentifier!.GetNonNullHandle (nameof (appIdentifier));
			var contentIdentifier__handle__ = contentIdentifier!.GetNonNullHandle (nameof (contentIdentifier));
			var options__handle__ = options.GetHandle ();
			NativeHandle errorValue = IntPtr.Zero;
			NSData? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSData> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_ref_NativeHandle (this.Handle, selStreamingContentKeyRequestDataForApp_ContentIdentifier_Options_Error_XHandle, appIdentifier__handle__, contentIdentifier__handle__, options__handle__, &errorValue), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSData> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle_ref_NativeHandle (&__objc_super__, selStreamingContentKeyRequestDataForApp_ContentIdentifier_Options_Error_XHandle, appIdentifier__handle__, contentIdentifier__handle__, options__handle__, &errorValue), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (appIdentifier);
			GC.KeepAlive (contentIdentifier);
			GC.KeepAlive (options);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual AVAssetResourceLoadingContentInformationRequest? ContentInformationRequest {
			[Export ("contentInformationRequest")]
			get {
				AVAssetResourceLoadingContentInformationRequest? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<AVAssetResourceLoadingContentInformationRequest> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selContentInformationRequestXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<AVAssetResourceLoadingContentInformationRequest> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selContentInformationRequestXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual AVAssetResourceLoadingDataRequest? DataRequest {
			[Export ("dataRequest")]
			get {
				AVAssetResourceLoadingDataRequest? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<AVAssetResourceLoadingDataRequest> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selDataRequestXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<AVAssetResourceLoadingDataRequest> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selDataRequestXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		/// <summary>Gets a Boolean value that tells whether the request has completed.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool Finished {
			[Export ("isFinished")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsFinishedXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsFinishedXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		/// <summary>Gets a Boolean value that tells whether the request is cancelled..</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool IsCancelled {
			[Export ("isCancelled")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsCancelledXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsCancelledXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSUrlRequest? Redirect {
			[Export ("redirect", ArgumentSemantic.Copy)]
			get {
				NSUrlRequest? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSUrlRequest> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selRedirectXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSUrlRequest> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selRedirectXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setRedirect:", ArgumentSemantic.Copy)]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetRedirect_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetRedirect_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSUrlRequest Request {
			[Export ("request")]
			get {
				NSUrlRequest? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSUrlRequest> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selRequestXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSUrlRequest> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selRequestXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual AVAssetResourceLoadingRequestor Requestor {
			[Export ("requestor")]
			get {
				AVAssetResourceLoadingRequestor? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<AVAssetResourceLoadingRequestor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selRequestorXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<AVAssetResourceLoadingRequestor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selRequestorXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSUrlResponse? Response {
			[Export ("response", ArgumentSemantic.Copy)]
			get {
				NSUrlResponse? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSUrlResponse> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selResponseXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSUrlResponse> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selResponseXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setResponse:", ArgumentSemantic.Copy)]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetResponse_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetResponse_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _StreamingContentKeyRequestRequiresPersistentKey;
		/// <summary>Gets a Boolean value that tells whether a persistent key is required for streaming content requests.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("AVAssetResourceLoadingRequestStreamingContentKeyRequestRequiresPersistentKey",  "AVFoundation")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString StreamingContentKeyRequestRequiresPersistentKey {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_StreamingContentKeyRequestRequiresPersistentKey is null)
					_StreamingContentKeyRequestRequiresPersistentKey = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVAssetResourceLoadingRequestStreamingContentKeyRequestRequiresPersistentKey")!;
				return _StreamingContentKeyRequestRequiresPersistentKey;
			}
		}
	} /* class AVAssetResourceLoadingRequest */
}
