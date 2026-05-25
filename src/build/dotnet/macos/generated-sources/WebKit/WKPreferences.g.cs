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
	/// <summary>Preference settings for a <see cref="T:WebKit.WKWebView" />.</summary><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/WebKit/Reference/WKPreferences_Ref/index.html">Apple documentation for <c>WKPreferences</c></related>
	[Register("WKPreferences", true)]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	public unsafe partial class WKPreferences : NSObject, INSCoding, INSSecureCoding {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selEncodeWithCoder_X = "encodeWithCoder:";
		static readonly NativeHandle selEncodeWithCoder_XHandle = Selector.GetHandle ("encodeWithCoder:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInactiveSchedulingPolicyX = "inactiveSchedulingPolicy";
		static readonly NativeHandle selInactiveSchedulingPolicyXHandle = Selector.GetHandle ("inactiveSchedulingPolicy");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithCoder_X = "initWithCoder:";
		static readonly NativeHandle selInitWithCoder_XHandle = Selector.GetHandle ("initWithCoder:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsElementFullscreenEnabledX = "isElementFullscreenEnabled";
		static readonly NativeHandle selIsElementFullscreenEnabledXHandle = Selector.GetHandle ("isElementFullscreenEnabled");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsFraudulentWebsiteWarningEnabledX = "isFraudulentWebsiteWarningEnabled";
		static readonly NativeHandle selIsFraudulentWebsiteWarningEnabledXHandle = Selector.GetHandle ("isFraudulentWebsiteWarningEnabled");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsSiteSpecificQuirksModeEnabledX = "isSiteSpecificQuirksModeEnabled";
		static readonly NativeHandle selIsSiteSpecificQuirksModeEnabledXHandle = Selector.GetHandle ("isSiteSpecificQuirksModeEnabled");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsTextInteractionEnabledX = "isTextInteractionEnabled";
		static readonly NativeHandle selIsTextInteractionEnabledXHandle = Selector.GetHandle ("isTextInteractionEnabled");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selJavaEnabledX = "javaEnabled";
		static readonly NativeHandle selJavaEnabledXHandle = Selector.GetHandle ("javaEnabled");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selJavaScriptCanOpenWindowsAutomaticallyX = "javaScriptCanOpenWindowsAutomatically";
		static readonly NativeHandle selJavaScriptCanOpenWindowsAutomaticallyXHandle = Selector.GetHandle ("javaScriptCanOpenWindowsAutomatically");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selJavaScriptEnabledX = "javaScriptEnabled";
		static readonly NativeHandle selJavaScriptEnabledXHandle = Selector.GetHandle ("javaScriptEnabled");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMinimumFontSizeX = "minimumFontSize";
		static readonly NativeHandle selMinimumFontSizeXHandle = Selector.GetHandle ("minimumFontSize");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPlugInsEnabledX = "plugInsEnabled";
		static readonly NativeHandle selPlugInsEnabledXHandle = Selector.GetHandle ("plugInsEnabled");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetElementFullscreenEnabled_X = "setElementFullscreenEnabled:";
		static readonly NativeHandle selSetElementFullscreenEnabled_XHandle = Selector.GetHandle ("setElementFullscreenEnabled:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetFraudulentWebsiteWarningEnabled_X = "setFraudulentWebsiteWarningEnabled:";
		static readonly NativeHandle selSetFraudulentWebsiteWarningEnabled_XHandle = Selector.GetHandle ("setFraudulentWebsiteWarningEnabled:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetInactiveSchedulingPolicy_X = "setInactiveSchedulingPolicy:";
		static readonly NativeHandle selSetInactiveSchedulingPolicy_XHandle = Selector.GetHandle ("setInactiveSchedulingPolicy:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetJavaEnabled_X = "setJavaEnabled:";
		static readonly NativeHandle selSetJavaEnabled_XHandle = Selector.GetHandle ("setJavaEnabled:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetJavaScriptCanOpenWindowsAutomatically_X = "setJavaScriptCanOpenWindowsAutomatically:";
		static readonly NativeHandle selSetJavaScriptCanOpenWindowsAutomatically_XHandle = Selector.GetHandle ("setJavaScriptCanOpenWindowsAutomatically:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetJavaScriptEnabled_X = "setJavaScriptEnabled:";
		static readonly NativeHandle selSetJavaScriptEnabled_XHandle = Selector.GetHandle ("setJavaScriptEnabled:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetMinimumFontSize_X = "setMinimumFontSize:";
		static readonly NativeHandle selSetMinimumFontSize_XHandle = Selector.GetHandle ("setMinimumFontSize:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetPlugInsEnabled_X = "setPlugInsEnabled:";
		static readonly NativeHandle selSetPlugInsEnabled_XHandle = Selector.GetHandle ("setPlugInsEnabled:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetShouldPrintBackgrounds_X = "setShouldPrintBackgrounds:";
		static readonly NativeHandle selSetShouldPrintBackgrounds_XHandle = Selector.GetHandle ("setShouldPrintBackgrounds:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetSiteSpecificQuirksModeEnabled_X = "setSiteSpecificQuirksModeEnabled:";
		static readonly NativeHandle selSetSiteSpecificQuirksModeEnabled_XHandle = Selector.GetHandle ("setSiteSpecificQuirksModeEnabled:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetTabFocusesLinks_X = "setTabFocusesLinks:";
		static readonly NativeHandle selSetTabFocusesLinks_XHandle = Selector.GetHandle ("setTabFocusesLinks:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetTextInteractionEnabled_X = "setTextInteractionEnabled:";
		static readonly NativeHandle selSetTextInteractionEnabled_XHandle = Selector.GetHandle ("setTextInteractionEnabled:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selShouldPrintBackgroundsX = "shouldPrintBackgrounds";
		static readonly NativeHandle selShouldPrintBackgroundsXHandle = Selector.GetHandle ("shouldPrintBackgrounds");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTabFocusesLinksX = "tabFocusesLinks";
		static readonly NativeHandle selTabFocusesLinksXHandle = Selector.GetHandle ("tabFocusesLinks");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTextInteractionEnabledX = "textInteractionEnabled";
		static readonly NativeHandle selTextInteractionEnabledXHandle = Selector.GetHandle ("textInteractionEnabled");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("WKPreferences");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		/// <summary>Creates a new <see cref="WKPreferences" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public WKPreferences () : base (NSObjectFlag.Empty)
		{
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, global::ObjCRuntime.Selector.Init), "init");
			} else {
				unsafe {
				var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
				InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, global::ObjCRuntime.Selector.Init), "init");
				GC.KeepAlive (this);
				}
			}
		}

		/// <summary>A constructor that initializes the object from the data stored in the unarchiver object.</summary>
		/// <param name="coder">The unarchiver object.</param>
		/// <remarks>
		///   <para>This constructor is provided to allow the class to be initialized from an unarchiver (for example, during NIB deserialization). This is part of the <see cref="Foundation.NSCoding" /> protocol.</para>
		///   <para>If developers want to create a subclass of this object and continue to support deserialization from an archive, they should implement a constructor with an identical signature: taking a single parameter of type <see cref="Foundation.NSCoder" /> and decorate it with the <c>[Export("initWithCoder:"]</c> attribute.</para>
		///   <para>The state of this object can also be serialized by using the <see cref="Foundation.INSCoding.EncodeTo" /> companion method.</para>
		/// </remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[DesignatedInitializer]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("initWithCoder:")]
		public WKPreferences (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.InitWithCoder, coder.Handle), "initWithCoder:");
			} else {
				unsafe {
				var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
				InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (&__objc_super__, Selector.InitWithCoder, coder.Handle), "initWithCoder:");
				GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (coder);
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
		protected WKPreferences (NSObjectFlag t) : base (t)
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
		protected internal WKPreferences (NativeHandle handle) : base (handle)
		{
		}

		/// <summary>Encodes the state of the object using the provided encoder.</summary><param name="encoder">The encoder object where the state of the object will be stored</param><remarks><para>This method is part of the <see cref="T:Foundation.INSCoding" /> protocol and is used by applications to preserve the state of the object into an archive.</para><para>Developers will typically create an <see cref="T:Foundation.NSKeyedArchiver" /> and then invoke the <see cref="M:Foundation.NSKeyedArchiver.ArchiveRootObjectToFile(Foundation.NSObject,System.String)" /> method which will call into this method.</para><para>If developers want to allow their object to be archived, they should override this method and store their state in using the provided <paramref name="encoder" /> parameter. In addition, developers should also implement a constructor that takes an NSCoder argument and is exported with <c>[Export ("initWithCoder:")]</c>.</para><example><code lang="csharp lang-csharp"><![CDATA[public void override EncodeTo (NSCoder coder) {
		/// coder.Encode (1, key: "version");
		/// coder.Encode (userName, key: "userName");
		/// coder.Encode (hostName, key: "hostName");]]></code></example></remarks>
		[Export ("encodeWithCoder:")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void EncodeTo (NSCoder encoder)
		{
			var encoder__handle__ = encoder!.GetNonNullHandle (nameof (encoder));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selEncodeWithCoder_XHandle, encoder__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selEncodeWithCoder_XHandle, encoder__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (encoder);
		}
		[Export ("isTextInteractionEnabled")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal virtual bool _NewGetTextInteractionEnabled ()
		{
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsTextInteractionEnabledXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsTextInteractionEnabledXHandle);
					GC.KeepAlive (this);
				}
			}
			return ret != 0;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("macos12.3")]
		[SupportedOSPlatform ("ios15.4")]
		[SupportedOSPlatform ("maccatalyst15.4")]
		public virtual bool ElementFullscreenEnabled {
			[Export ("isElementFullscreenEnabled")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsElementFullscreenEnabledXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsElementFullscreenEnabledXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setElementFullscreenEnabled:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetElementFullscreenEnabled_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetElementFullscreenEnabled_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public virtual bool FraudulentWebsiteWarningEnabled {
			[Export ("isFraudulentWebsiteWarningEnabled")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsFraudulentWebsiteWarningEnabledXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsFraudulentWebsiteWarningEnabledXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setFraudulentWebsiteWarningEnabled:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetFraudulentWebsiteWarningEnabled_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetFraudulentWebsiteWarningEnabled_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		public virtual WKInactiveSchedulingPolicy InactiveSchedulingPolicy {
			[Export ("inactiveSchedulingPolicy", ArgumentSemantic.Assign)]
			get {
				WKInactiveSchedulingPolicy ret;
				if (IsDirectBinding) {
					ret = (WebKit.WKInactiveSchedulingPolicy) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selInactiveSchedulingPolicyXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (WebKit.WKInactiveSchedulingPolicy) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selInactiveSchedulingPolicyXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setInactiveSchedulingPolicy:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetInactiveSchedulingPolicy_XHandle, (IntPtr) (long) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, selSetInactiveSchedulingPolicy_XHandle, (IntPtr) (long) value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("macos10.15", "Feature no longer supported.")]
		[SupportedOSPlatform ("macos")]
		public virtual bool JavaEnabled {
			[Export ("javaEnabled")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selJavaEnabledXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selJavaEnabledXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setJavaEnabled:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetJavaEnabled_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetJavaEnabled_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool JavaScriptCanOpenWindowsAutomatically {
			[Export ("javaScriptCanOpenWindowsAutomatically")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selJavaScriptCanOpenWindowsAutomaticallyXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selJavaScriptCanOpenWindowsAutomaticallyXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setJavaScriptCanOpenWindowsAutomatically:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetJavaScriptCanOpenWindowsAutomatically_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetJavaScriptCanOpenWindowsAutomatically_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[ObsoletedOSPlatform ("macos11.0", "Use 'WKWebPagePreferences.AllowsContentJavaScript' instead.")]
		[ObsoletedOSPlatform ("ios14.0", "Use 'WKWebPagePreferences.AllowsContentJavaScript' instead.")]
		[ObsoletedOSPlatform ("maccatalyst14.0", "Use 'WKWebPagePreferences.AllowsContentJavaScript' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		public virtual bool JavaScriptEnabled {
			[Export ("javaScriptEnabled")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selJavaScriptEnabledXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selJavaScriptEnabledXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setJavaScriptEnabled:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetJavaScriptEnabled_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetJavaScriptEnabled_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nfloat MinimumFontSize {
			[Export ("minimumFontSize")]
			get {
				nfloat ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend (this.Handle, selMinimumFontSizeXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSendSuper (&__objc_super__, selMinimumFontSizeXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setMinimumFontSize:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_nfloat (this.Handle, selSetMinimumFontSize_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_nfloat (&__objc_super__, selSetMinimumFontSize_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("macos10.15", "Feature no longer supported.")]
		[SupportedOSPlatform ("macos")]
		public virtual bool PlugInsEnabled {
			[Export ("plugInsEnabled")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selPlugInsEnabledXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selPlugInsEnabledXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setPlugInsEnabled:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetPlugInsEnabled_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetPlugInsEnabled_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("macos13.3")]
		[SupportedOSPlatform ("ios16.4")]
		[SupportedOSPlatform ("maccatalyst16.4")]
		public virtual bool ShouldPrintBackgrounds {
			[Export ("shouldPrintBackgrounds")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selShouldPrintBackgroundsXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selShouldPrintBackgroundsXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setShouldPrintBackgrounds:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetShouldPrintBackgrounds_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetShouldPrintBackgrounds_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("macos12.3")]
		[SupportedOSPlatform ("ios15.4")]
		[SupportedOSPlatform ("maccatalyst15.4")]
		public virtual bool SiteSpecificQuirksModeEnabled {
			[Export ("isSiteSpecificQuirksModeEnabled")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsSiteSpecificQuirksModeEnabledXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsSiteSpecificQuirksModeEnabledXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setSiteSpecificQuirksModeEnabled:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetSiteSpecificQuirksModeEnabled_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetSiteSpecificQuirksModeEnabled_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public virtual bool TabFocusesLinks {
			[Export ("tabFocusesLinks")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selTabFocusesLinksXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selTabFocusesLinksXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setTabFocusesLinks:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetTabFocusesLinks_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetTabFocusesLinks_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios14.5")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		internal virtual bool _OldTextInteractionEnabled {
			[Export ("textInteractionEnabled")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selTextInteractionEnabledXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selTextInteractionEnabledXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setTextInteractionEnabled:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetTextInteractionEnabled_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetTextInteractionEnabled_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
	} /* class WKPreferences */
}
