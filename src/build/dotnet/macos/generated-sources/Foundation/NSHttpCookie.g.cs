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
	[Register("NSHTTPCookie", true)]
	public unsafe partial class NSHttpCookie : NSObject {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCommentX = "comment";
		static readonly NativeHandle selCommentXHandle = Selector.GetHandle ("comment");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCommentURLX = "commentURL";
		static readonly NativeHandle selCommentURLXHandle = Selector.GetHandle ("commentURL");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCookieWithProperties_X = "cookieWithProperties:";
		static readonly NativeHandle selCookieWithProperties_XHandle = Selector.GetHandle ("cookieWithProperties:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCookiesWithResponseHeaderFields_ForURL_X = "cookiesWithResponseHeaderFields:forURL:";
		static readonly NativeHandle selCookiesWithResponseHeaderFields_ForURL_XHandle = Selector.GetHandle ("cookiesWithResponseHeaderFields:forURL:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDomainX = "domain";
		static readonly NativeHandle selDomainXHandle = Selector.GetHandle ("domain");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selExpiresDateX = "expiresDate";
		static readonly NativeHandle selExpiresDateXHandle = Selector.GetHandle ("expiresDate");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithProperties_X = "initWithProperties:";
		static readonly NativeHandle selInitWithProperties_XHandle = Selector.GetHandle ("initWithProperties:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsHTTPOnlyX = "isHTTPOnly";
		static readonly NativeHandle selIsHTTPOnlyXHandle = Selector.GetHandle ("isHTTPOnly");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsSecureX = "isSecure";
		static readonly NativeHandle selIsSecureXHandle = Selector.GetHandle ("isSecure");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsSessionOnlyX = "isSessionOnly";
		static readonly NativeHandle selIsSessionOnlyXHandle = Selector.GetHandle ("isSessionOnly");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selNameX = "name";
		static readonly NativeHandle selNameXHandle = Selector.GetHandle ("name");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPathX = "path";
		static readonly NativeHandle selPathXHandle = Selector.GetHandle ("path");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPortListX = "portList";
		static readonly NativeHandle selPortListXHandle = Selector.GetHandle ("portList");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPropertiesX = "properties";
		static readonly NativeHandle selPropertiesXHandle = Selector.GetHandle ("properties");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRequestHeaderFieldsWithCookies_X = "requestHeaderFieldsWithCookies:";
		static readonly NativeHandle selRequestHeaderFieldsWithCookies_XHandle = Selector.GetHandle ("requestHeaderFieldsWithCookies:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSameSitePolicyX = "sameSitePolicy";
		static readonly NativeHandle selSameSitePolicyXHandle = Selector.GetHandle ("sameSitePolicy");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selValueX = "value";
		static readonly NativeHandle selValueXHandle = Selector.GetHandle ("value");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selVersionX = "version";
		static readonly NativeHandle selVersionXHandle = Selector.GetHandle ("version");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("NSHTTPCookie");
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
		protected NSHttpCookie (NSObjectFlag t) : base (t)
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
		protected internal NSHttpCookie (NativeHandle handle) : base (handle)
		{
		}

		[Export ("initWithProperties:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSHttpCookie (NSDictionary properties)
			: base (NSObjectFlag.Empty)
		{
			var properties__handle__ = properties!.GetNonNullHandle (nameof (properties));
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selInitWithProperties_XHandle, properties__handle__), "initWithProperties:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selInitWithProperties_XHandle, properties__handle__), "initWithProperties:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (properties);
		}
		[Export ("cookieWithProperties:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSHttpCookie CookieFromProperties (NSDictionary properties)
		{
			var properties__handle__ = properties!.GetNonNullHandle (nameof (properties));
			NSHttpCookie? ret;
			ret =  Runtime.GetNSObject<NSHttpCookie> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, selCookieWithProperties_XHandle, properties__handle__), false)!;
			GC.KeepAlive (properties);
			return ret!;
		}
		[Export ("cookiesWithResponseHeaderFields:forURL:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSHttpCookie[] CookiesWithResponseHeaderFields (NSDictionary headerFields, NSUrl url)
		{
			var headerFields__handle__ = headerFields!.GetNonNullHandle (nameof (headerFields));
			var url__handle__ = url!.GetNonNullHandle (nameof (url));
			NSHttpCookie[]? ret;
			ret = CFArray.ArrayFromHandle<NSHttpCookie>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (class_ptr, selCookiesWithResponseHeaderFields_ForURL_XHandle, headerFields__handle__, url__handle__), false)!;
			GC.KeepAlive (headerFields);
			GC.KeepAlive (url);
			return ret!;
		}
		[Export ("requestHeaderFieldsWithCookies:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSDictionary RequestHeaderFieldsWithCookies (NSHttpCookie[] cookies)
		{
			if (cookies is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (cookies));
			using var nsa_cookies = NSArray.FromNSObjects (cookies);
			NSDictionary ret;
			ret =  Runtime.GetNSObject<NSDictionary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, selRequestHeaderFieldsWithCookies_XHandle, nsa_cookies.Handle), false)!;
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string Comment {
			[Export ("comment")]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selCommentXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selCommentXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSUrl CommentUrl {
			[Export ("commentURL")]
			get {
				NSUrl? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSUrl> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selCommentURLXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSUrl> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selCommentURLXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string Domain {
			[Export ("domain")]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selDomainXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selDomainXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDate ExpiresDate {
			[Export ("expiresDate")]
			get {
				NSDate? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDate> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selExpiresDateXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSDate> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selExpiresDateXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		/// <summary>Whether this cookie should only be sent to HTTP servers per RFC 2965.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool IsHttpOnly {
			[Export ("isHTTPOnly")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsHTTPOnlyXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsHTTPOnlyXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		/// <summary>Whether this cookie should only be sent over secure channels.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool IsSecure {
			[Export ("isSecure")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsSecureXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsSecureXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		/// <summary>Whether this cookie should be discarded at the end of the session, ignoring the expiration date.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool IsSessionOnly {
			[Export ("isSessionOnly")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsSessionOnlyXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsSessionOnlyXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string Name {
			[Export ("name")]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selNameXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selNameXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string Path {
			[Export ("path")]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selPathXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selPathXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSNumber[] PortList {
			[Export ("portList")]
			get {
				NSNumber[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<NSNumber>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selPortListXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<NSNumber>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selPortListXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDictionary Properties {
			[Export ("properties")]
			get {
				NSDictionary? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDictionary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selPropertiesXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSDictionary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selPropertiesXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public virtual NSString? SameSitePolicy {
			[Export ("sameSitePolicy")]
			get {
				NSString? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selSameSitePolicyXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selSameSitePolicyXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string Value {
			[Export ("value")]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selValueXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selValueXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nuint Version {
			[Export ("version")]
			get {
				nuint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selVersionXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selVersionXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _KeyComment;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSHTTPCookieComment",  "Foundation")]
		public static NSString KeyComment {
			get {
				if (_KeyComment is null)
					_KeyComment = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSHTTPCookieComment")!;
				return _KeyComment;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _KeyCommentUrl;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSHTTPCookieCommentURL",  "Foundation")]
		public static NSString KeyCommentUrl {
			get {
				if (_KeyCommentUrl is null)
					_KeyCommentUrl = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSHTTPCookieCommentURL")!;
				return _KeyCommentUrl;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _KeyDiscard;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSHTTPCookieDiscard",  "Foundation")]
		public static NSString KeyDiscard {
			get {
				if (_KeyDiscard is null)
					_KeyDiscard = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSHTTPCookieDiscard")!;
				return _KeyDiscard;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _KeyDomain;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSHTTPCookieDomain",  "Foundation")]
		public static NSString KeyDomain {
			get {
				if (_KeyDomain is null)
					_KeyDomain = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSHTTPCookieDomain")!;
				return _KeyDomain;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _KeyExpires;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSHTTPCookieExpires",  "Foundation")]
		public static NSString KeyExpires {
			get {
				if (_KeyExpires is null)
					_KeyExpires = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSHTTPCookieExpires")!;
				return _KeyExpires;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _KeyMaximumAge;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSHTTPCookieMaximumAge",  "Foundation")]
		public static NSString KeyMaximumAge {
			get {
				if (_KeyMaximumAge is null)
					_KeyMaximumAge = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSHTTPCookieMaximumAge")!;
				return _KeyMaximumAge;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _KeyName;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSHTTPCookieName",  "Foundation")]
		public static NSString KeyName {
			get {
				if (_KeyName is null)
					_KeyName = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSHTTPCookieName")!;
				return _KeyName;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _KeyOriginUrl;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSHTTPCookieOriginURL",  "Foundation")]
		public static NSString KeyOriginUrl {
			get {
				if (_KeyOriginUrl is null)
					_KeyOriginUrl = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSHTTPCookieOriginURL")!;
				return _KeyOriginUrl;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _KeyPath;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSHTTPCookiePath",  "Foundation")]
		public static NSString KeyPath {
			get {
				if (_KeyPath is null)
					_KeyPath = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSHTTPCookiePath")!;
				return _KeyPath;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _KeyPort;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSHTTPCookiePort",  "Foundation")]
		public static NSString KeyPort {
			get {
				if (_KeyPort is null)
					_KeyPort = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSHTTPCookiePort")!;
				return _KeyPort;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _KeySameSiteLax;
		/// <summary>Represents the value associated with the constant 'NSHTTPCookieSameSiteLax'.</summary>
		[Field ("NSHTTPCookieSameSiteLax",  "Foundation")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString KeySameSiteLax {
			[SupportedOSPlatform ("tvos13.0")]
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_KeySameSiteLax is null)
					_KeySameSiteLax = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSHTTPCookieSameSiteLax")!;
				return _KeySameSiteLax;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _KeySameSitePolicy;
		/// <summary>Represents the value associated with the constant 'NSHTTPCookieSameSitePolicy'.</summary>
		[Field ("NSHTTPCookieSameSitePolicy",  "Foundation")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString KeySameSitePolicy {
			[SupportedOSPlatform ("tvos13.0")]
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_KeySameSitePolicy is null)
					_KeySameSitePolicy = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSHTTPCookieSameSitePolicy")!;
				return _KeySameSitePolicy;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _KeySameSiteStrict;
		/// <summary>Represents the value associated with the constant 'NSHTTPCookieSameSiteStrict'.</summary>
		[Field ("NSHTTPCookieSameSiteStrict",  "Foundation")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString KeySameSiteStrict {
			[SupportedOSPlatform ("tvos13.0")]
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_KeySameSiteStrict is null)
					_KeySameSiteStrict = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSHTTPCookieSameSiteStrict")!;
				return _KeySameSiteStrict;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _KeySecure;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSHTTPCookieSecure",  "Foundation")]
		public static NSString KeySecure {
			get {
				if (_KeySecure is null)
					_KeySecure = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSHTTPCookieSecure")!;
				return _KeySecure;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _KeySetByJavaScript;
		/// <summary>Represents the value associated with the constant 'NSHTTPCookieSetByJavaScript'.</summary>
		[Field ("NSHTTPCookieSetByJavaScript",  "Foundation")]
		[SupportedOSPlatform ("tvos18.2")]
		[SupportedOSPlatform ("ios18.2")]
		[SupportedOSPlatform ("maccatalyst18.2")]
		[SupportedOSPlatform ("macos15.2")]
		public static NSString KeySetByJavaScript {
			[SupportedOSPlatform ("tvos18.2")]
			[SupportedOSPlatform ("ios18.2")]
			[SupportedOSPlatform ("maccatalyst18.2")]
			[SupportedOSPlatform ("macos15.2")]
			get {
				if (_KeySetByJavaScript is null)
					_KeySetByJavaScript = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSHTTPCookieSetByJavaScript")!;
				return _KeySetByJavaScript;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _KeyValue;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSHTTPCookieValue",  "Foundation")]
		public static NSString KeyValue {
			get {
				if (_KeyValue is null)
					_KeyValue = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSHTTPCookieValue")!;
				return _KeyValue;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _KeyVersion;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSHTTPCookieVersion",  "Foundation")]
		public static NSString KeyVersion {
			get {
				if (_KeyVersion is null)
					_KeyVersion = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSHTTPCookieVersion")!;
				return _KeyVersion;
			}
		}
	} /* class NSHttpCookie */
}
