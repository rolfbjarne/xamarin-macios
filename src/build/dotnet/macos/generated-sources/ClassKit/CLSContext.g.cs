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
namespace ClassKit {
	/// <summary>A node in a ClassKit context hierarchy.</summary>
	[Register("CLSContext", true)]
	[SupportedOSPlatform ("maccatalyst")]
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	public unsafe partial class CLSContext : CLSObject {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAddChildContext_X = "addChildContext:";
		static readonly NativeHandle selAddChildContext_XHandle = Selector.GetHandle ("addChildContext:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAddNavigationChildContext_X = "addNavigationChildContext:";
		static readonly NativeHandle selAddNavigationChildContext_XHandle = Selector.GetHandle ("addNavigationChildContext:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAddProgressReportingCapabilities_X = "addProgressReportingCapabilities:";
		static readonly NativeHandle selAddProgressReportingCapabilities_XHandle = Selector.GetHandle ("addProgressReportingCapabilities:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selBecomeActiveX = "becomeActive";
		static readonly NativeHandle selBecomeActiveXHandle = Selector.GetHandle ("becomeActive");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCreateNewActivityX = "createNewActivity";
		static readonly NativeHandle selCreateNewActivityXHandle = Selector.GetHandle ("createNewActivity");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCurrentActivityX = "currentActivity";
		static readonly NativeHandle selCurrentActivityXHandle = Selector.GetHandle ("currentActivity");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCustomTypeNameX = "customTypeName";
		static readonly NativeHandle selCustomTypeNameXHandle = Selector.GetHandle ("customTypeName");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDescendantMatchingIdentifierPath_Completion_X = "descendantMatchingIdentifierPath:completion:";
		static readonly NativeHandle selDescendantMatchingIdentifierPath_Completion_XHandle = Selector.GetHandle ("descendantMatchingIdentifierPath:completion:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDisplayOrderX = "displayOrder";
		static readonly NativeHandle selDisplayOrderXHandle = Selector.GetHandle ("displayOrder");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIdentifierX = "identifier";
		static readonly NativeHandle selIdentifierXHandle = Selector.GetHandle ("identifier");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIdentifierPathX = "identifierPath";
		static readonly NativeHandle selIdentifierPathXHandle = Selector.GetHandle ("identifierPath");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithType_Identifier_Title_X = "initWithType:identifier:title:";
		static readonly NativeHandle selInitWithType_Identifier_Title_XHandle = Selector.GetHandle ("initWithType:identifier:title:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsActiveX = "isActive";
		static readonly NativeHandle selIsActiveXHandle = Selector.GetHandle ("isActive");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsAssignableX = "isAssignable";
		static readonly NativeHandle selIsAssignableXHandle = Selector.GetHandle ("isAssignable");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selNavigationChildContextsX = "navigationChildContexts";
		static readonly NativeHandle selNavigationChildContextsXHandle = Selector.GetHandle ("navigationChildContexts");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selParentX = "parent";
		static readonly NativeHandle selParentXHandle = Selector.GetHandle ("parent");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selProgressReportingCapabilitiesX = "progressReportingCapabilities";
		static readonly NativeHandle selProgressReportingCapabilitiesXHandle = Selector.GetHandle ("progressReportingCapabilities");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRemoveFromParentX = "removeFromParent";
		static readonly NativeHandle selRemoveFromParentXHandle = Selector.GetHandle ("removeFromParent");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRemoveNavigationChildContext_X = "removeNavigationChildContext:";
		static readonly NativeHandle selRemoveNavigationChildContext_XHandle = Selector.GetHandle ("removeNavigationChildContext:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selResetProgressReportingCapabilitiesX = "resetProgressReportingCapabilities";
		static readonly NativeHandle selResetProgressReportingCapabilitiesXHandle = Selector.GetHandle ("resetProgressReportingCapabilities");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selResignActiveX = "resignActive";
		static readonly NativeHandle selResignActiveXHandle = Selector.GetHandle ("resignActive");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAssignable_X = "setAssignable:";
		static readonly NativeHandle selSetAssignable_XHandle = Selector.GetHandle ("setAssignable:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetCustomTypeName_X = "setCustomTypeName:";
		static readonly NativeHandle selSetCustomTypeName_XHandle = Selector.GetHandle ("setCustomTypeName:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetDisplayOrder_X = "setDisplayOrder:";
		static readonly NativeHandle selSetDisplayOrder_XHandle = Selector.GetHandle ("setDisplayOrder:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetSuggestedAge_X = "setSuggestedAge:";
		static readonly NativeHandle selSetSuggestedAge_XHandle = Selector.GetHandle ("setSuggestedAge:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetSuggestedCompletionTime_X = "setSuggestedCompletionTime:";
		static readonly NativeHandle selSetSuggestedCompletionTime_XHandle = Selector.GetHandle ("setSuggestedCompletionTime:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetSummary_X = "setSummary:";
		static readonly NativeHandle selSetSummary_XHandle = Selector.GetHandle ("setSummary:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetThumbnail_X = "setThumbnail:";
		static readonly NativeHandle selSetThumbnail_XHandle = Selector.GetHandle ("setThumbnail:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetTitle_X = "setTitle:";
		static readonly NativeHandle selSetTitle_XHandle = Selector.GetHandle ("setTitle:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetTopic_X = "setTopic:";
		static readonly NativeHandle selSetTopic_XHandle = Selector.GetHandle ("setTopic:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetType_X = "setType:";
		static readonly NativeHandle selSetType_XHandle = Selector.GetHandle ("setType:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetUniversalLinkURL_X = "setUniversalLinkURL:";
		static readonly NativeHandle selSetUniversalLinkURL_XHandle = Selector.GetHandle ("setUniversalLinkURL:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSuggestedAgeX = "suggestedAge";
		static readonly NativeHandle selSuggestedAgeXHandle = Selector.GetHandle ("suggestedAge");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSuggestedCompletionTimeX = "suggestedCompletionTime";
		static readonly NativeHandle selSuggestedCompletionTimeXHandle = Selector.GetHandle ("suggestedCompletionTime");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSummaryX = "summary";
		static readonly NativeHandle selSummaryXHandle = Selector.GetHandle ("summary");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selThumbnailX = "thumbnail";
		static readonly NativeHandle selThumbnailXHandle = Selector.GetHandle ("thumbnail");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTitleX = "title";
		static readonly NativeHandle selTitleXHandle = Selector.GetHandle ("title");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTopicX = "topic";
		static readonly NativeHandle selTopicXHandle = Selector.GetHandle ("topic");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTypeX = "type";
		static readonly NativeHandle selTypeXHandle = Selector.GetHandle ("type");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selUniversalLinkURLX = "universalLinkURL";
		static readonly NativeHandle selUniversalLinkURLXHandle = Selector.GetHandle ("universalLinkURL");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("CLSContext");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
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
		public CLSContext (NSCoder coder) : base (NSObjectFlag.Empty)
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
		protected CLSContext (NSObjectFlag t) : base (t)
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
		protected internal CLSContext (NativeHandle handle) : base (handle)
		{
		}

		[Export ("initWithType:identifier:title:")]
		[DesignatedInitializer]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public CLSContext (CLSContextType type, string identifier, string title)
			: base (NSObjectFlag.Empty)
		{
			if (identifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (identifier));
			if (title is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (title));
			var nsidentifier = CFString.CreateNative (identifier);
			var nstitle = CFString.CreateNative (title);
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_IntPtr_NativeHandle_NativeHandle (this.Handle, selInitWithType_Identifier_Title_XHandle, (IntPtr) (long) type, nsidentifier, nstitle), "initWithType:identifier:title:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_IntPtr_NativeHandle_NativeHandle (&__objc_super__, selInitWithType_Identifier_Title_XHandle, (IntPtr) (long) type, nsidentifier, nstitle), "initWithType:identifier:title:");
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsidentifier);
			CFString.ReleaseNative (nstitle);
		}
		[Export ("addChildContext:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AddChild (CLSContext childContext)
		{
			var childContext__handle__ = childContext!.GetNonNullHandle (nameof (childContext));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selAddChildContext_XHandle, childContext__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selAddChildContext_XHandle, childContext__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (childContext);
		}
		[Export ("addNavigationChildContext:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios14.5")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AddNavigationChild (CLSContext childContext)
		{
			var childContext__handle__ = childContext!.GetNonNullHandle (nameof (childContext));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selAddNavigationChildContext_XHandle, childContext__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selAddNavigationChildContext_XHandle, childContext__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (childContext);
		}
		[Export ("addProgressReportingCapabilities:")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AddProgressReportingCapabilities (NSSet<CLSProgressReportingCapability> capabilities)
		{
			var capabilities__handle__ = capabilities!.GetNonNullHandle (nameof (capabilities));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selAddProgressReportingCapabilities_XHandle, capabilities__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selAddProgressReportingCapabilities_XHandle, capabilities__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (capabilities);
		}
		[Export ("becomeActive")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void BecomeActive ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selBecomeActiveXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selBecomeActiveXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("createNewActivity")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CLSActivity CreateNewActivity ()
		{
			CLSActivity ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<CLSActivity> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selCreateNewActivityXHandle), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<CLSActivity> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selCreateNewActivityXHandle), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("descendantMatchingIdentifierPath:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void FindDescendantMatching (string[] identifierPath, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V37))]global::System.Action<CLSContext, NSError> completion)
		{
			if (identifierPath is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (identifierPath));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var nsa_identifierPath = NSArray.FromStrings (identifierPath);
			using var block_completion = Trampolines.SDActionArity2V37.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selDescendantMatchingIdentifierPath_Completion_XHandle, nsa_identifierPath.Handle, (IntPtr) block_ptr_completion);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selDescendantMatchingIdentifierPath_Completion_XHandle, nsa_identifierPath.Handle, (IntPtr) block_ptr_completion);
					GC.KeepAlive (this);
				}
			}
		}
		/// <param name="identifierPath">The identifier path for the context to retrieve.</param>
		/// <summary>Returns a task that contains the context that is represented by the provided identifier path.</summary>
		/// <returns>A task that contains the context that is represented by the provided identifier path.</returns>
		/// <remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<CLSContext> FindDescendantMatchingAsync (string[] identifierPath)
		{
			var tcs = new TaskCompletionSource<CLSContext> ();
			FindDescendantMatching(identifierPath, (arg1_, arg2_) => {
				if (arg2_ is not null)
					tcs.SetException (new NSErrorException(arg2_));
				else
					tcs.SetResult (arg1_!);
			});
			return tcs.Task;
		}
		[Export ("removeFromParent")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemoveFromParent ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selRemoveFromParentXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selRemoveFromParentXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("removeNavigationChildContext:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios14.5")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemoveNavigationChild (CLSContext childContext)
		{
			var childContext__handle__ = childContext!.GetNonNullHandle (nameof (childContext));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selRemoveNavigationChildContext_XHandle, childContext__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selRemoveNavigationChildContext_XHandle, childContext__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (childContext);
		}
		[Export ("resetProgressReportingCapabilities")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ResetProgressReportingCapabilities ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selResetProgressReportingCapabilitiesXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selResetProgressReportingCapabilitiesXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("resignActive")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ResignActive ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selResignActiveXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selResignActiveXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("setType:")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetType (CLSContextType type)
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetType_XHandle, (IntPtr) (long) type);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, selSetType_XHandle, (IntPtr) (long) type);
					GC.KeepAlive (this);
				}
			}
		}
		/// <summary>Gets a Boolean value that tells whether the context is currently active.</summary><value><see langword="true" /> if the context is active. Otherwise, <see langword="false" />.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool Active {
			[Export ("isActive")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsActiveXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsActiveXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		public virtual bool Assignable {
			[Export ("isAssignable")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsAssignableXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsAssignableXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setAssignable:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetAssignable_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetAssignable_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CLSActivity? CurrentActivity {
			[Export ("currentActivity", ArgumentSemantic.Retain)]
			get {
				CLSActivity? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<CLSActivity> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selCurrentActivityXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<CLSActivity> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selCurrentActivityXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios13.4")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		public virtual string? CustomTypeName {
			[Export ("customTypeName")]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selCustomTypeNameXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selCustomTypeNameXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setCustomTypeName:")]
			set {
				var nsvalue = CFString.CreateNative (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetCustomTypeName_XHandle, nsvalue);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetCustomTypeName_XHandle, nsvalue);
						GC.KeepAlive (this);
					}
				}
				CFString.ReleaseNative (nsvalue);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint DisplayOrder {
			[Export ("displayOrder")]
			get {
				nint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selDisplayOrderXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selDisplayOrderXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setDisplayOrder:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetDisplayOrder_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, selSetDisplayOrder_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string Identifier {
			[Export ("identifier")]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selIdentifierXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selIdentifierXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios13.4")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		public virtual string[] IdentifierPath {
			[Export ("identifierPath", ArgumentSemantic.Copy)]
			get {
				string[] ret;
				if (IsDirectBinding) {
					ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selIdentifierPathXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selIdentifierPathXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios14.5")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		public virtual CLSContext[] NavigationChildContexts {
			[Export ("navigationChildContexts", ArgumentSemantic.Copy)]
			get {
				CLSContext[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<CLSContext>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selNavigationChildContextsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<CLSContext>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selNavigationChildContextsXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CLSContext? Parent {
			[Export ("parent")]
			get {
				CLSContext? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<CLSContext> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selParentXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<CLSContext> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selParentXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		public virtual NSSet<CLSProgressReportingCapability> ProgressReportingCapabilities {
			[Export ("progressReportingCapabilities", ArgumentSemantic.Copy)]
			get {
				NSSet<CLSProgressReportingCapability>? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSSet<CLSProgressReportingCapability>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selProgressReportingCapabilitiesXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSSet<CLSProgressReportingCapability>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selProgressReportingCapabilitiesXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		public virtual NSRange SuggestedAge {
			[Export ("suggestedAge", ArgumentSemantic.Assign)]
			get {
				NSRange ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.NSRange_objc_msgSend (this.Handle, selSuggestedAgeXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.NSRange_objc_msgSendSuper (&__objc_super__, selSuggestedAgeXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setSuggestedAge:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NSRange (this.Handle, selSetSuggestedAge_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NSRange (&__objc_super__, selSetSuggestedAge_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		public virtual NSRange SuggestedCompletionTime {
			[Export ("suggestedCompletionTime", ArgumentSemantic.Assign)]
			get {
				NSRange ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.NSRange_objc_msgSend (this.Handle, selSuggestedCompletionTimeXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.NSRange_objc_msgSendSuper (&__objc_super__, selSuggestedCompletionTimeXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setSuggestedCompletionTime:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NSRange (this.Handle, selSetSuggestedCompletionTime_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NSRange (&__objc_super__, selSetSuggestedCompletionTime_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios13.4")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		public virtual string? Summary {
			[Export ("summary")]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selSummaryXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selSummaryXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setSummary:")]
			set {
				var nsvalue = CFString.CreateNative (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetSummary_XHandle, nsvalue);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetSummary_XHandle, nsvalue);
						GC.KeepAlive (this);
					}
				}
				CFString.ReleaseNative (nsvalue);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios13.4")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		public virtual CGImage? Thumbnail {
			[Export ("thumbnail", ArgumentSemantic.Assign)]
			get {
				CGImage ret;
				if (IsDirectBinding) {
					ret = Runtime.GetINativeObject<global::CoreGraphics.CGImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selThumbnailXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = Runtime.GetINativeObject<global::CoreGraphics.CGImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selThumbnailXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setThumbnail:", ArgumentSemantic.Assign)]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetThumbnail_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetThumbnail_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string Title {
			[Export ("title")]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selTitleXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selTitleXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setTitle:")]
			set {
				if (value is null)
					ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (value));
				var nsvalue = CFString.CreateNative (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetTitle_XHandle, nsvalue);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetTitle_XHandle, nsvalue);
						GC.KeepAlive (this);
					}
				}
				CFString.ReleaseNative (nsvalue);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CLSContextType Type {
			[Export ("type", ArgumentSemantic.Assign)]
			get {
				CLSContextType ret;
				if (IsDirectBinding) {
					ret = (ClassKit.CLSContextType) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selTypeXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (ClassKit.CLSContextType) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selTypeXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSUrl? UniversalLinkUrl {
			[Export ("universalLinkURL", ArgumentSemantic.Retain)]
			get {
				NSUrl? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSUrl> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selUniversalLinkURLXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSUrl> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selUniversalLinkURLXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setUniversalLinkURL:", ArgumentSemantic.Retain)]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetUniversalLinkURL_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetUniversalLinkURL_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		protected virtual NSString? WeakTopic {
			[Export ("topic", ArgumentSemantic.Copy)]
			get {
				NSString? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selTopicXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selTopicXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setTopic:", ArgumentSemantic.Copy)]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetTopic_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetTopic_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
	} /* class CLSContext */
}
