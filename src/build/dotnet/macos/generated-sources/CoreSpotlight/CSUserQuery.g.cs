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
	[Register("CSUserQuery", true)]
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("macos13.0")]
	[SupportedOSPlatform ("ios16.0")]
	[SupportedOSPlatform ("maccatalyst16.0")]
	public unsafe partial class CSUserQuery : CSSearchQuery {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCancelX = "cancel";
		static readonly NativeHandle selCancelXHandle = Selector.GetHandle ("cancel");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFoundSuggestionCountX = "foundSuggestionCount";
		static readonly NativeHandle selFoundSuggestionCountXHandle = Selector.GetHandle ("foundSuggestionCount");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFoundSuggestionsHandlerX = "foundSuggestionsHandler";
		static readonly NativeHandle selFoundSuggestionsHandlerXHandle = Selector.GetHandle ("foundSuggestionsHandler");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithUserQueryString_UserQueryContext_X = "initWithUserQueryString:userQueryContext:";
		static readonly NativeHandle selInitWithUserQueryString_UserQueryContext_XHandle = Selector.GetHandle ("initWithUserQueryString:userQueryContext:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPrepareX = "prepare";
		static readonly NativeHandle selPrepareXHandle = Selector.GetHandle ("prepare");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPrepareProtectionClasses_X = "prepareProtectionClasses:";
		static readonly NativeHandle selPrepareProtectionClasses_XHandle = Selector.GetHandle ("prepareProtectionClasses:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetFoundSuggestionsHandler_X = "setFoundSuggestionsHandler:";
		static readonly NativeHandle selSetFoundSuggestionsHandler_XHandle = Selector.GetHandle ("setFoundSuggestionsHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selStartX = "start";
		static readonly NativeHandle selStartXHandle = Selector.GetHandle ("start");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selUserEngagedWithItem_VisibleItems_UserInteractionType_X = "userEngagedWithItem:visibleItems:userInteractionType:";
		static readonly NativeHandle selUserEngagedWithItem_VisibleItems_UserInteractionType_XHandle = Selector.GetHandle ("userEngagedWithItem:visibleItems:userInteractionType:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selUserEngagedWithSuggestion_VisibleSuggestions_UserInteractionType_X = "userEngagedWithSuggestion:visibleSuggestions:userInteractionType:";
		static readonly NativeHandle selUserEngagedWithSuggestion_VisibleSuggestions_UserInteractionType_XHandle = Selector.GetHandle ("userEngagedWithSuggestion:visibleSuggestions:userInteractionType:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("CSUserQuery");
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
		protected CSUserQuery (NSObjectFlag t) : base (t)
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
		protected internal CSUserQuery (NativeHandle handle) : base (handle)
		{
		}

		[Export ("initWithUserQueryString:userQueryContext:")]
		[DesignatedInitializer]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public CSUserQuery (string? userQueryString, CSUserQueryContext? userQueryContext)
			: base (NSObjectFlag.Empty)
		{
			var userQueryContext__handle__ = userQueryContext.GetHandle ();
			var nsuserQueryString = CFString.CreateNative (userQueryString);
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selInitWithUserQueryString_UserQueryContext_XHandle, nsuserQueryString, userQueryContext__handle__), "initWithUserQueryString:userQueryContext:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selInitWithUserQueryString_UserQueryContext_XHandle, nsuserQueryString, userQueryContext__handle__), "initWithUserQueryString:userQueryContext:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (userQueryContext);
			CFString.ReleaseNative (nsuserQueryString);
		}
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
		[Export ("prepare")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void Prepare ()
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend (class_ptr, selPrepareXHandle);
		}
		[Export ("prepareProtectionClasses:")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void Prepare (NSString[] protectionClasses)
		{
			if (protectionClasses is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (protectionClasses));
			using var nsa_protectionClasses = NSArray.FromNSObjects (protectionClasses);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (class_ptr, selPrepareProtectionClasses_XHandle, nsa_protectionClasses.Handle);
		}
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void Prepare (NSFileProtectionType[] protectionClasses)
		{
			Prepare (protectionClasses.ToConstantArray ()!);
		}
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
		[Export ("userEngagedWithItem:visibleItems:userInteractionType:")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void UserEngaged (CSSearchableItem item, CSSearchableItem[] visibleItems, CSUserInteraction userInteractionType)
		{
			var item__handle__ = item!.GetNonNullHandle (nameof (item));
			if (visibleItems is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (visibleItems));
			using var nsa_visibleItems = NSArray.FromNSObjects (visibleItems);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_IntPtr (this.Handle, selUserEngagedWithItem_VisibleItems_UserInteractionType_XHandle, item__handle__, nsa_visibleItems.Handle, (IntPtr) (long) userInteractionType);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_IntPtr (&__objc_super__, selUserEngagedWithItem_VisibleItems_UserInteractionType_XHandle, item__handle__, nsa_visibleItems.Handle, (IntPtr) (long) userInteractionType);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (item);
		}
		[Export ("userEngagedWithSuggestion:visibleSuggestions:userInteractionType:")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void UserEngaged (CSSuggestion suggestion, CSSuggestion[] visibleSuggestions, CSUserInteraction userInteractionType)
		{
			var suggestion__handle__ = suggestion!.GetNonNullHandle (nameof (suggestion));
			if (visibleSuggestions is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (visibleSuggestions));
			using var nsa_visibleSuggestions = NSArray.FromNSObjects (visibleSuggestions);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_IntPtr (this.Handle, selUserEngagedWithSuggestion_VisibleSuggestions_UserInteractionType_XHandle, suggestion__handle__, nsa_visibleSuggestions.Handle, (IntPtr) (long) userInteractionType);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_IntPtr (&__objc_super__, selUserEngagedWithSuggestion_VisibleSuggestions_UserInteractionType_XHandle, suggestion__handle__, nsa_visibleSuggestions.Handle, (IntPtr) (long) userInteractionType);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (suggestion);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint FoundSuggestionCount {
			[Export ("foundSuggestionCount")]
			get {
				nint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selFoundSuggestionCountXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selFoundSuggestionCountXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual global::System.Action<NSArray<CSSuggestion>>? FoundSuggestionsHandler {
			[return: DelegateProxy (typeof (ObjCRuntime.Trampolines.SDActionArity1V45))]
			[Export ("foundSuggestionsHandler", ArgumentSemantic.Copy)]
			get {
				NativeHandle ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selFoundSuggestionsHandlerXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selFoundSuggestionsHandlerXHandle);
						GC.KeepAlive (this);
					}
				}
				return global::ObjCRuntime.Trampolines.NIDActionArity1V45.Create (ret)!;
			}
			[param: BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V45))]
			[Export ("setFoundSuggestionsHandler:", ArgumentSemantic.Copy)]
			set {
				using var block_value = Trampolines.SDActionArity1V45.CreateNullableBlock (value);
				BlockLiteral *block_ptr_value = null;
				if (value is not null)
					block_ptr_value = &block_value;
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetFoundSuggestionsHandler_XHandle, (IntPtr) block_ptr_value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetFoundSuggestionsHandler_XHandle, (IntPtr) block_ptr_value);
						GC.KeepAlive (this);
					}
				}
			}
		}
	} /* class CSUserQuery */
}
