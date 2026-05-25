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
	/// <summary>Allows posting messages and injecting user scripts into a Web page.</summary><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/WebKit/Reference/WKUserContentController_Ref/index.html">Apple documentation for <c>WKUserContentController</c></related>
	[Register("WKUserContentController", true)]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	public unsafe partial class WKUserContentController : NSObject, INSCoding, INSSecureCoding {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAddContentRuleList_X = "addContentRuleList:";
		static readonly NativeHandle selAddContentRuleList_XHandle = Selector.GetHandle ("addContentRuleList:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAddScriptMessageHandler_ContentWorld_Name_X = "addScriptMessageHandler:contentWorld:name:";
		static readonly NativeHandle selAddScriptMessageHandler_ContentWorld_Name_XHandle = Selector.GetHandle ("addScriptMessageHandler:contentWorld:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAddScriptMessageHandler_Name_X = "addScriptMessageHandler:name:";
		static readonly NativeHandle selAddScriptMessageHandler_Name_XHandle = Selector.GetHandle ("addScriptMessageHandler:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAddScriptMessageHandlerWithReply_ContentWorld_Name_X = "addScriptMessageHandlerWithReply:contentWorld:name:";
		static readonly NativeHandle selAddScriptMessageHandlerWithReply_ContentWorld_Name_XHandle = Selector.GetHandle ("addScriptMessageHandlerWithReply:contentWorld:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAddUserScript_X = "addUserScript:";
		static readonly NativeHandle selAddUserScript_XHandle = Selector.GetHandle ("addUserScript:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selEncodeWithCoder_X = "encodeWithCoder:";
		static readonly NativeHandle selEncodeWithCoder_XHandle = Selector.GetHandle ("encodeWithCoder:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithCoder_X = "initWithCoder:";
		static readonly NativeHandle selInitWithCoder_XHandle = Selector.GetHandle ("initWithCoder:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRemoveAllContentRuleListsX = "removeAllContentRuleLists";
		static readonly NativeHandle selRemoveAllContentRuleListsXHandle = Selector.GetHandle ("removeAllContentRuleLists");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRemoveAllScriptMessageHandlersX = "removeAllScriptMessageHandlers";
		static readonly NativeHandle selRemoveAllScriptMessageHandlersXHandle = Selector.GetHandle ("removeAllScriptMessageHandlers");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRemoveAllScriptMessageHandlersFromContentWorld_X = "removeAllScriptMessageHandlersFromContentWorld:";
		static readonly NativeHandle selRemoveAllScriptMessageHandlersFromContentWorld_XHandle = Selector.GetHandle ("removeAllScriptMessageHandlersFromContentWorld:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRemoveAllUserScriptsX = "removeAllUserScripts";
		static readonly NativeHandle selRemoveAllUserScriptsXHandle = Selector.GetHandle ("removeAllUserScripts");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRemoveContentRuleList_X = "removeContentRuleList:";
		static readonly NativeHandle selRemoveContentRuleList_XHandle = Selector.GetHandle ("removeContentRuleList:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRemoveScriptMessageHandlerForName_X = "removeScriptMessageHandlerForName:";
		static readonly NativeHandle selRemoveScriptMessageHandlerForName_XHandle = Selector.GetHandle ("removeScriptMessageHandlerForName:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRemoveScriptMessageHandlerForName_ContentWorld_X = "removeScriptMessageHandlerForName:contentWorld:";
		static readonly NativeHandle selRemoveScriptMessageHandlerForName_ContentWorld_XHandle = Selector.GetHandle ("removeScriptMessageHandlerForName:contentWorld:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selUserScriptsX = "userScripts";
		static readonly NativeHandle selUserScriptsXHandle = Selector.GetHandle ("userScripts");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("WKUserContentController");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		/// <summary>Creates a new <see cref="WKUserContentController" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public WKUserContentController () : base (NSObjectFlag.Empty)
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
		public WKUserContentController (NSCoder coder) : base (NSObjectFlag.Empty)
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
		protected WKUserContentController (NSObjectFlag t) : base (t)
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
		protected internal WKUserContentController (NativeHandle handle) : base (handle)
		{
		}

		[Export ("addContentRuleList:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AddContentRuleList (WKContentRuleList contentRuleList)
		{
			var contentRuleList__handle__ = contentRuleList!.GetNonNullHandle (nameof (contentRuleList));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selAddContentRuleList_XHandle, contentRuleList__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selAddContentRuleList_XHandle, contentRuleList__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (contentRuleList);
		}
		[Export ("addScriptMessageHandler:name:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AddScriptMessageHandler (IWKScriptMessageHandler scriptMessageHandler, string name)
		{
			var scriptMessageHandler__handle__ = scriptMessageHandler!.GetNonNullHandle (nameof (scriptMessageHandler));
			if (name is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (name));
			var nsname = CFString.CreateNative (name);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selAddScriptMessageHandler_Name_XHandle, scriptMessageHandler__handle__, nsname);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selAddScriptMessageHandler_Name_XHandle, scriptMessageHandler__handle__, nsname);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (scriptMessageHandler);
			CFString.ReleaseNative (nsname);
		}
		[Export ("addScriptMessageHandler:contentWorld:name:")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AddScriptMessageHandler (IWKScriptMessageHandler scriptMessageHandler, WKContentWorld world, string name)
		{
			var scriptMessageHandler__handle__ = scriptMessageHandler!.GetNonNullHandle (nameof (scriptMessageHandler));
			var world__handle__ = world!.GetNonNullHandle (nameof (world));
			if (name is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (name));
			var nsname = CFString.CreateNative (name);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, selAddScriptMessageHandler_ContentWorld_Name_XHandle, scriptMessageHandler__handle__, world__handle__, nsname);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, selAddScriptMessageHandler_ContentWorld_Name_XHandle, scriptMessageHandler__handle__, world__handle__, nsname);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (scriptMessageHandler);
			GC.KeepAlive (world);
			CFString.ReleaseNative (nsname);
		}
		[Export ("addScriptMessageHandlerWithReply:contentWorld:name:")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AddScriptMessageHandler (IWKScriptMessageHandlerWithReply scriptMessageHandlerWithReply, WKContentWorld contentWorld, string name)
		{
			var scriptMessageHandlerWithReply__handle__ = scriptMessageHandlerWithReply!.GetNonNullHandle (nameof (scriptMessageHandlerWithReply));
			var contentWorld__handle__ = contentWorld!.GetNonNullHandle (nameof (contentWorld));
			if (name is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (name));
			var nsname = CFString.CreateNative (name);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, selAddScriptMessageHandlerWithReply_ContentWorld_Name_XHandle, scriptMessageHandlerWithReply__handle__, contentWorld__handle__, nsname);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, selAddScriptMessageHandlerWithReply_ContentWorld_Name_XHandle, scriptMessageHandlerWithReply__handle__, contentWorld__handle__, nsname);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (scriptMessageHandlerWithReply);
			GC.KeepAlive (contentWorld);
			CFString.ReleaseNative (nsname);
		}
		[Export ("addUserScript:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AddUserScript (WKUserScript userScript)
		{
			var userScript__handle__ = userScript!.GetNonNullHandle (nameof (userScript));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selAddUserScript_XHandle, userScript__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selAddUserScript_XHandle, userScript__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (userScript);
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
		[Export ("removeAllContentRuleLists")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemoveAllContentRuleLists ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selRemoveAllContentRuleListsXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selRemoveAllContentRuleListsXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("removeAllScriptMessageHandlersFromContentWorld:")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemoveAllScriptMessageHandlers (WKContentWorld contentWorld)
		{
			var contentWorld__handle__ = contentWorld!.GetNonNullHandle (nameof (contentWorld));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selRemoveAllScriptMessageHandlersFromContentWorld_XHandle, contentWorld__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selRemoveAllScriptMessageHandlersFromContentWorld_XHandle, contentWorld__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (contentWorld);
		}
		[Export ("removeAllScriptMessageHandlers")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemoveAllScriptMessageHandlers ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selRemoveAllScriptMessageHandlersXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selRemoveAllScriptMessageHandlersXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("removeAllUserScripts")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemoveAllUserScripts ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selRemoveAllUserScriptsXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selRemoveAllUserScriptsXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("removeContentRuleList:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemoveContentRuleList (WKContentRuleList contentRuleList)
		{
			var contentRuleList__handle__ = contentRuleList!.GetNonNullHandle (nameof (contentRuleList));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selRemoveContentRuleList_XHandle, contentRuleList__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selRemoveContentRuleList_XHandle, contentRuleList__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (contentRuleList);
		}
		[Export ("removeScriptMessageHandlerForName:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemoveScriptMessageHandler (string name)
		{
			if (name is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (name));
			var nsname = CFString.CreateNative (name);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selRemoveScriptMessageHandlerForName_XHandle, nsname);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selRemoveScriptMessageHandlerForName_XHandle, nsname);
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsname);
		}
		[Export ("removeScriptMessageHandlerForName:contentWorld:")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemoveScriptMessageHandler (string name, WKContentWorld contentWorld)
		{
			if (name is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (name));
			var contentWorld__handle__ = contentWorld!.GetNonNullHandle (nameof (contentWorld));
			var nsname = CFString.CreateNative (name);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selRemoveScriptMessageHandlerForName_ContentWorld_XHandle, nsname, contentWorld__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selRemoveScriptMessageHandlerForName_ContentWorld_XHandle, nsname, contentWorld__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (contentWorld);
			CFString.ReleaseNative (nsname);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual WKUserScript[] UserScripts {
			[Export ("userScripts")]
			get {
				WKUserScript[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<WKUserScript>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selUserScriptsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<WKUserScript>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selUserScriptsXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
	} /* class WKUserContentController */
}
