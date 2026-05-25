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
namespace CoreSpotlight {
	/// <summary>Searches data that the developer has previously indexed with the Core Spotlight API.</summary><remarks><para>Application developers search indexed app content by creating a <see cref="T:CoreSpotlight.CSSearchQuery" /> with a query string that searches for the specified data. Developers then set neither, one, or both of the <see cref="P:CoreSpotlight.CSSearchQuery.FoundItemsHandler" /> and <see cref="P:CoreSpotlight.CSSearchQuery.CompletionHandler" /> properties to, and then call <see cref="M:CoreSpotlight.CSSearchQuery.Start" /> to begin receiving items that are matched by the query string.</para><para>Core Spotlight search query strings have an easy-to-understand syntax for developers who are familiar with C#:
	/// <list type="bullet"><item><term>The C# logical operators, <c>==</c>, <c>!=</c>, <c>&lt;</c>, <c>&gt;</c>, <c>&lt;=</c>, and <c>&gt;=</c>, are supported.</term></item><item><term>Embedded single quotes match an entire string, while embedded double quotes match quoted instances within larger strings. Developers should, of course, note that embedded quotes must be escaped with a backslash.</term></item><item><term>An asterisk, <c>*</c>, does wildcard matching.</term></item><item><term><c>c</c>, <c>d</c>, <c>w</c>, and <c>t</c>, perform case-insensitive, diacritic-insensitive, word-based, and token-based matching, respectively.</term></item><item><term>Developers can use the logical AND (<c>&amp;&amp;</c>) and logical OR (<c>||</c>) operators to build combined queries.</term></item><item><term>DateTime methods can be used on the special <c>$time</c> variable and its members to match time intervals.</term></item></list></para><para>For more information, see Apple's documentation for the <format type="text/html"><a href="https://developer.apple.com/reference/CoreSpotlight/CSSearchQuery">CSSearchQuery object</a></format>.</para></remarks><related type="externalDocumentation" href="https://developer.apple.com/reference/CoreSpotlight/CSSearchQuery">Apple documentation for <c>CSSearchQuery</c></related>
	[Register("CSSearchQuery", true)]
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	public unsafe partial class CSSearchQuery : NSObject {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCancelX = "cancel";
		static readonly NativeHandle selCancelXHandle = Selector.GetHandle ("cancel");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCompletionHandlerX = "completionHandler";
		static readonly NativeHandle selCompletionHandlerXHandle = Selector.GetHandle ("completionHandler");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFoundItemCountX = "foundItemCount";
		static readonly NativeHandle selFoundItemCountXHandle = Selector.GetHandle ("foundItemCount");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFoundItemsHandlerX = "foundItemsHandler";
		static readonly NativeHandle selFoundItemsHandlerXHandle = Selector.GetHandle ("foundItemsHandler");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithQueryString_Attributes_X = "initWithQueryString:attributes:";
		static readonly NativeHandle selInitWithQueryString_Attributes_XHandle = Selector.GetHandle ("initWithQueryString:attributes:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithQueryString_QueryContext_X = "initWithQueryString:queryContext:";
		static readonly NativeHandle selInitWithQueryString_QueryContext_XHandle = Selector.GetHandle ("initWithQueryString:queryContext:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsCancelledX = "isCancelled";
		static readonly NativeHandle selIsCancelledXHandle = Selector.GetHandle ("isCancelled");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selProtectionClassesX = "protectionClasses";
		static readonly NativeHandle selProtectionClassesXHandle = Selector.GetHandle ("protectionClasses");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetCompletionHandler_X = "setCompletionHandler:";
		static readonly NativeHandle selSetCompletionHandler_XHandle = Selector.GetHandle ("setCompletionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetFoundItemsHandler_X = "setFoundItemsHandler:";
		static readonly NativeHandle selSetFoundItemsHandler_XHandle = Selector.GetHandle ("setFoundItemsHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetProtectionClasses_X = "setProtectionClasses:";
		static readonly NativeHandle selSetProtectionClasses_XHandle = Selector.GetHandle ("setProtectionClasses:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selStartX = "start";
		static readonly NativeHandle selStartXHandle = Selector.GetHandle ("start");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("CSSearchQuery");
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
		protected CSSearchQuery (NSObjectFlag t) : base (t)
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
		protected internal CSSearchQuery (NativeHandle handle) : base (handle)
		{
		}

		/// <param name="queryString">To be added.</param><param name="attributes"><para>A list of strings from <see cref="T:CoreSpotlight.CSSearchableItemAttributeSet" /> to match.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>Creates a new search query object for the specified query string and attributes.</summary><remarks><para>For more information on the query string format, see Apple's documentation for the <format type="text/html"><a href="https://developer.apple.com/reference/CoreSpotlight/CSSearchQuery">CSSearchQuery object</a></format>.</para></remarks>
		[Export ("initWithQueryString:attributes:")]
		[ObsoletedOSPlatform ("ios16.0", "Use the constructor that takes a 'CSSearchQueryContext' parameter instead.")]
		[ObsoletedOSPlatform ("maccatalyst18.0", "Use the constructor that takes a 'CSSearchQueryContext' parameter instead.")]
		[ObsoletedOSPlatform ("macos13.0", "Use the constructor that takes a 'CSSearchQueryContext' parameter instead.")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public CSSearchQuery (string queryString, string[]? attributes)
			: base (NSObjectFlag.Empty)
		{
			if (queryString is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (queryString));
			var nsqueryString = CFString.CreateNative (queryString);
			using var nsa_attributes = NSArray.FromNullableStrings (attributes);
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selInitWithQueryString_Attributes_XHandle, nsqueryString, nsa_attributes.GetHandle ()), "initWithQueryString:attributes:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selInitWithQueryString_Attributes_XHandle, nsqueryString, nsa_attributes.GetHandle ()), "initWithQueryString:attributes:");
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsqueryString);
		}
		[Export ("initWithQueryString:queryContext:")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[UnsupportedOSPlatform ("tvos")]
		[DesignatedInitializer]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public CSSearchQuery (string queryString, CSSearchQueryContext? queryContext)
			: base (NSObjectFlag.Empty)
		{
			if (queryString is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (queryString));
			var queryContext__handle__ = queryContext.GetHandle ();
			var nsqueryString = CFString.CreateNative (queryString);
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selInitWithQueryString_QueryContext_XHandle, nsqueryString, queryContext__handle__), "initWithQueryString:queryContext:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selInitWithQueryString_QueryContext_XHandle, nsqueryString, queryContext__handle__), "initWithQueryString:queryContext:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (queryContext);
			CFString.ReleaseNative (nsqueryString);
		}
		/// <summary>Cancels the current search and calls <see cref="P:CoreSpotlight.CSSearchQuery.CompletionHandler" />, if present, with <see cref="F:CoreSpotlight.CSSearchQueryErrorCode.Cancelled" />.</summary><remarks>To be added.</remarks>
		[Export ("cancel")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Cancel ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selCancelXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selCancelXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		/// <summary>Starts the search.</summary><remarks>To be added.</remarks>
		[Export ("start")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Start ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selStartXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selStartXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		/// <summary>Gets a value that tells whether the query has been canceled.</summary><value>A value that tells whether the query has been canceled.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool Cancelled {
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
		/// <summary>Gets or sets a handler that, if it is not <see langword="null" />, is run when the search completes.</summary><value><para>A  handler that, if supplied, is run when the search completes.</para><para tool="nullallowed">This value can be <see langword="null" />.</para></value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual global::System.Action<NSError>? CompletionHandler {
			[return: DelegateProxy (typeof (ObjCRuntime.Trampolines.SDActionArity1V16))]
			[Export ("completionHandler", ArgumentSemantic.Copy)]
			get {
				NativeHandle ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selCompletionHandlerXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selCompletionHandlerXHandle);
						GC.KeepAlive (this);
					}
				}
				return global::ObjCRuntime.Trampolines.NIDActionArity1V16.Create (ret)!;
			}
			[param: BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V16))]
			[Export ("setCompletionHandler:", ArgumentSemantic.Copy)]
			set {
				using var block_value = Trampolines.SDActionArity1V16.CreateNullableBlock (value);
				BlockLiteral *block_ptr_value = null;
				if (value is not null)
					block_ptr_value = &block_value;
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetCompletionHandler_XHandle, (IntPtr) block_ptr_value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetCompletionHandler_XHandle, (IntPtr) block_ptr_value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>Gets the current number of found items.</summary><value>The current number of found items.</value><remarks>This number will grow as more search results become ready.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nuint FoundItemCount {
			[Export ("foundItemCount")]
			get {
				nuint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selFoundItemCountXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selFoundItemCountXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		/// <summary>Gets or sets a handler that, if it is not <see langword="null" />, is run when a batch of search results is ready.</summary><value><para>A a handler that, if it is not <see langword="null" />, is run when a batch of search results is ready.</para><para tool="nullallowed">This value can be <see langword="null" />.</para></value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual global::System.Action<CSSearchableItem[]>? FoundItemsHandler {
			[return: DelegateProxy (typeof (ObjCRuntime.Trampolines.SDActionArity1V44))]
			[Export ("foundItemsHandler", ArgumentSemantic.Copy)]
			get {
				NativeHandle ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selFoundItemsHandlerXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selFoundItemsHandlerXHandle);
						GC.KeepAlive (this);
					}
				}
				return global::ObjCRuntime.Trampolines.NIDActionArity1V44.Create (ret)!;
			}
			[param: BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V44))]
			[Export ("setFoundItemsHandler:", ArgumentSemantic.Copy)]
			set {
				using var block_value = Trampolines.SDActionArity1V44.CreateNullableBlock (value);
				BlockLiteral *block_ptr_value = null;
				if (value is not null)
					block_ptr_value = &block_value;
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetFoundItemsHandler_XHandle, (IntPtr) block_ptr_value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetFoundItemsHandler_XHandle, (IntPtr) block_ptr_value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>Gets or sets an array of protection classes for the indexed data.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string[] ProtectionClasses {
			[Export ("protectionClasses", ArgumentSemantic.Copy)]
			get {
				string[] ret;
				if (IsDirectBinding) {
					ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selProtectionClassesXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selProtectionClassesXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setProtectionClasses:", ArgumentSemantic.Copy)]
			set {
				if (value is null)
					ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (value));
				using var nsa_value = NSArray.FromStrings (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetProtectionClasses_XHandle, nsa_value.Handle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetProtectionClasses_XHandle, nsa_value.Handle);
						GC.KeepAlive (this);
					}
				}
			}
		}
	} /* class CSSearchQuery */
}
