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
namespace AuthenticationServices {
	[Register("ASAuthorizationProviderExtensionAuthorizationResult", true)]
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("ios15.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	public unsafe partial class ASAuthorizationProviderExtensionAuthorizationResult : NSObject {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selHttpAuthorizationHeadersX = "httpAuthorizationHeaders";
		static readonly NativeHandle selHttpAuthorizationHeadersXHandle = Selector.GetHandle ("httpAuthorizationHeaders");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selHttpBodyX = "httpBody";
		static readonly NativeHandle selHttpBodyXHandle = Selector.GetHandle ("httpBody");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selHttpResponseX = "httpResponse";
		static readonly NativeHandle selHttpResponseXHandle = Selector.GetHandle ("httpResponse");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithHTTPAuthorizationHeaders_X = "initWithHTTPAuthorizationHeaders:";
		static readonly NativeHandle selInitWithHTTPAuthorizationHeaders_XHandle = Selector.GetHandle ("initWithHTTPAuthorizationHeaders:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithHTTPResponse_HttpBody_X = "initWithHTTPResponse:httpBody:";
		static readonly NativeHandle selInitWithHTTPResponse_HttpBody_XHandle = Selector.GetHandle ("initWithHTTPResponse:httpBody:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPrivateKeysX = "privateKeys";
		static readonly NativeHandle selPrivateKeysXHandle = Selector.GetHandle ("privateKeys");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetHttpAuthorizationHeaders_X = "setHttpAuthorizationHeaders:";
		static readonly NativeHandle selSetHttpAuthorizationHeaders_XHandle = Selector.GetHandle ("setHttpAuthorizationHeaders:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetHttpBody_X = "setHttpBody:";
		static readonly NativeHandle selSetHttpBody_XHandle = Selector.GetHandle ("setHttpBody:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetHttpResponse_X = "setHttpResponse:";
		static readonly NativeHandle selSetHttpResponse_XHandle = Selector.GetHandle ("setHttpResponse:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetPrivateKeys_X = "setPrivateKeys:";
		static readonly NativeHandle selSetPrivateKeys_XHandle = Selector.GetHandle ("setPrivateKeys:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("ASAuthorizationProviderExtensionAuthorizationResult");
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
		protected ASAuthorizationProviderExtensionAuthorizationResult (NSObjectFlag t) : base (t)
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
		protected internal ASAuthorizationProviderExtensionAuthorizationResult (NativeHandle handle) : base (handle)
		{
		}

		[Export ("initWithHTTPAuthorizationHeaders:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public ASAuthorizationProviderExtensionAuthorizationResult (NSDictionary<NSString, NSString> httpAuthorizationHeaders)
			: base (NSObjectFlag.Empty)
		{
			var httpAuthorizationHeaders__handle__ = httpAuthorizationHeaders!.GetNonNullHandle (nameof (httpAuthorizationHeaders));
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selInitWithHTTPAuthorizationHeaders_XHandle, httpAuthorizationHeaders__handle__), "initWithHTTPAuthorizationHeaders:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selInitWithHTTPAuthorizationHeaders_XHandle, httpAuthorizationHeaders__handle__), "initWithHTTPAuthorizationHeaders:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (httpAuthorizationHeaders);
		}
		[Export ("initWithHTTPResponse:httpBody:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public ASAuthorizationProviderExtensionAuthorizationResult (NSHttpUrlResponse httpResponse, NSData? httpBody)
			: base (NSObjectFlag.Empty)
		{
			var httpResponse__handle__ = httpResponse!.GetNonNullHandle (nameof (httpResponse));
			var httpBody__handle__ = httpBody.GetHandle ();
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selInitWithHTTPResponse_HttpBody_XHandle, httpResponse__handle__, httpBody__handle__), "initWithHTTPResponse:httpBody:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selInitWithHTTPResponse_HttpBody_XHandle, httpResponse__handle__, httpBody__handle__), "initWithHTTPResponse:httpBody:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (httpResponse);
			GC.KeepAlive (httpBody);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		object? __mt_HttpAuthorizationHeaders_var;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDictionary<NSString, NSString>? HttpAuthorizationHeaders {
			[Export ("httpAuthorizationHeaders", ArgumentSemantic.Assign)]
			get {
				NSDictionary<NSString, NSString>? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDictionary<NSString, NSString>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selHttpAuthorizationHeadersXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSDictionary<NSString, NSString>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selHttpAuthorizationHeadersXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				MarkDirty ();
				__mt_HttpAuthorizationHeaders_var = ret;
				return ret!;
			}
			[Export ("setHttpAuthorizationHeaders:", ArgumentSemantic.Assign)]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetHttpAuthorizationHeaders_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetHttpAuthorizationHeaders_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
				MarkDirty ();
				__mt_HttpAuthorizationHeaders_var = value;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		object? __mt_HttpBody_var;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSData? HttpBody {
			[Export ("httpBody", ArgumentSemantic.Assign)]
			get {
				NSData? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSData> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selHttpBodyXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSData> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selHttpBodyXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				MarkDirty ();
				__mt_HttpBody_var = ret;
				return ret!;
			}
			[Export ("setHttpBody:", ArgumentSemantic.Assign)]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetHttpBody_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetHttpBody_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
				MarkDirty ();
				__mt_HttpBody_var = value;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSHttpUrlResponse? HttpResponse {
			[Export ("httpResponse", ArgumentSemantic.Copy)]
			get {
				NSHttpUrlResponse? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSHttpUrlResponse> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selHttpResponseXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSHttpUrlResponse> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selHttpResponseXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setHttpResponse:", ArgumentSemantic.Copy)]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetHttpResponse_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetHttpResponse_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::Security.SecKey[] PrivateKeys {
			[Export ("privateKeys", ArgumentSemantic.Assign)]
			get {
				global::Security.SecKey[] ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<global::Security.SecKey>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selPrivateKeysXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<global::Security.SecKey>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selPrivateKeysXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setPrivateKeys:", ArgumentSemantic.Assign)]
			set {
				if (value is null)
					ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (value));
				using var nsa_value = NSArray.FromNSObjects (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetPrivateKeys_XHandle, nsa_value.Handle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetPrivateKeys_XHandle, nsa_value.Handle);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_HttpAuthorizationHeaders_var = null;
				__mt_HttpBody_var = null;
			}
		}
	} /* class ASAuthorizationProviderExtensionAuthorizationResult */
}
