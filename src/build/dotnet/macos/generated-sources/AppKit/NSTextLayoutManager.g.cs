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
namespace AppKit {
	[Register("NSTextLayoutManager", true)]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[UnsupportedOSPlatform ("tvos")]
	[UnsupportedOSPlatform ("ios")]
	public unsafe partial class NSTextLayoutManager : NSObject, INSCoding, INSSecureCoding, INSTextSelectionDataSource {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAddRenderingAttribute_Value_ForTextRange_X = "addRenderingAttribute:value:forTextRange:";
		static readonly NativeHandle selAddRenderingAttribute_Value_ForTextRange_XHandle = Selector.GetHandle ("addRenderingAttribute:value:forTextRange:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selBaseWritingDirectionAtLocation_X = "baseWritingDirectionAtLocation:";
		static readonly NativeHandle selBaseWritingDirectionAtLocation_XHandle = Selector.GetHandle ("baseWritingDirectionAtLocation:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDelegateX = "delegate";
		static readonly NativeHandle selDelegateXHandle = Selector.GetHandle ("delegate");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDocumentRangeX = "documentRange";
		static readonly NativeHandle selDocumentRangeXHandle = Selector.GetHandle ("documentRange");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selEncodeWithCoder_X = "encodeWithCoder:";
		static readonly NativeHandle selEncodeWithCoder_XHandle = Selector.GetHandle ("encodeWithCoder:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selEnsureLayoutForBounds_X = "ensureLayoutForBounds:";
		static readonly NativeHandle selEnsureLayoutForBounds_XHandle = Selector.GetHandle ("ensureLayoutForBounds:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selEnsureLayoutForRange_X = "ensureLayoutForRange:";
		static readonly NativeHandle selEnsureLayoutForRange_XHandle = Selector.GetHandle ("ensureLayoutForRange:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selEnumerateCaretOffsetsInLineFragmentAtLocation_UsingBlock_X = "enumerateCaretOffsetsInLineFragmentAtLocation:usingBlock:";
		static readonly NativeHandle selEnumerateCaretOffsetsInLineFragmentAtLocation_UsingBlock_XHandle = Selector.GetHandle ("enumerateCaretOffsetsInLineFragmentAtLocation:usingBlock:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selEnumerateContainerBoundariesFromLocation_Reverse_UsingBlock_X = "enumerateContainerBoundariesFromLocation:reverse:usingBlock:";
		static readonly NativeHandle selEnumerateContainerBoundariesFromLocation_Reverse_UsingBlock_XHandle = Selector.GetHandle ("enumerateContainerBoundariesFromLocation:reverse:usingBlock:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selEnumerateRenderingAttributesFromLocation_Reverse_UsingBlock_X = "enumerateRenderingAttributesFromLocation:reverse:usingBlock:";
		static readonly NativeHandle selEnumerateRenderingAttributesFromLocation_Reverse_UsingBlock_XHandle = Selector.GetHandle ("enumerateRenderingAttributesFromLocation:reverse:usingBlock:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selEnumerateSubstringsFromLocation_Options_UsingBlock_X = "enumerateSubstringsFromLocation:options:usingBlock:";
		static readonly NativeHandle selEnumerateSubstringsFromLocation_Options_UsingBlock_XHandle = Selector.GetHandle ("enumerateSubstringsFromLocation:options:usingBlock:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selEnumerateTextLayoutFragmentsFromLocation_Options_UsingBlock_X = "enumerateTextLayoutFragmentsFromLocation:options:usingBlock:";
		static readonly NativeHandle selEnumerateTextLayoutFragmentsFromLocation_Options_UsingBlock_XHandle = Selector.GetHandle ("enumerateTextLayoutFragmentsFromLocation:options:usingBlock:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selEnumerateTextSegmentsInRange_Type_Options_UsingBlock_X = "enumerateTextSegmentsInRange:type:options:usingBlock:";
		static readonly NativeHandle selEnumerateTextSegmentsInRange_Type_Options_UsingBlock_XHandle = Selector.GetHandle ("enumerateTextSegmentsInRange:type:options:usingBlock:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithCoder_X = "initWithCoder:";
		static readonly NativeHandle selInitWithCoder_XHandle = Selector.GetHandle ("initWithCoder:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInvalidateLayoutForRange_X = "invalidateLayoutForRange:";
		static readonly NativeHandle selInvalidateLayoutForRange_XHandle = Selector.GetHandle ("invalidateLayoutForRange:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInvalidateRenderingAttributesForTextRange_X = "invalidateRenderingAttributesForTextRange:";
		static readonly NativeHandle selInvalidateRenderingAttributesForTextRange_XHandle = Selector.GetHandle ("invalidateRenderingAttributesForTextRange:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLayoutQueueX = "layoutQueue";
		static readonly NativeHandle selLayoutQueueXHandle = Selector.GetHandle ("layoutQueue");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLimitsLayoutForSuspiciousContentsX = "limitsLayoutForSuspiciousContents";
		static readonly NativeHandle selLimitsLayoutForSuspiciousContentsXHandle = Selector.GetHandle ("limitsLayoutForSuspiciousContents");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLineFragmentRangeForPoint_InContainerAtLocation_X = "lineFragmentRangeForPoint:inContainerAtLocation:";
		static readonly NativeHandle selLineFragmentRangeForPoint_InContainerAtLocation_XHandle = Selector.GetHandle ("lineFragmentRangeForPoint:inContainerAtLocation:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLinkRenderingAttributesX = "linkRenderingAttributes";
		static readonly NativeHandle selLinkRenderingAttributesXHandle = Selector.GetHandle ("linkRenderingAttributes");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLocationFromLocation_WithOffset_X = "locationFromLocation:withOffset:";
		static readonly NativeHandle selLocationFromLocation_WithOffset_XHandle = Selector.GetHandle ("locationFromLocation:withOffset:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selOffsetFromLocation_ToLocation_X = "offsetFromLocation:toLocation:";
		static readonly NativeHandle selOffsetFromLocation_ToLocation_XHandle = Selector.GetHandle ("offsetFromLocation:toLocation:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRemoveRenderingAttribute_ForTextRange_X = "removeRenderingAttribute:forTextRange:";
		static readonly NativeHandle selRemoveRenderingAttribute_ForTextRange_XHandle = Selector.GetHandle ("removeRenderingAttribute:forTextRange:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRenderingAttributesForLink_AtLocation_X = "renderingAttributesForLink:atLocation:";
		static readonly NativeHandle selRenderingAttributesForLink_AtLocation_XHandle = Selector.GetHandle ("renderingAttributesForLink:atLocation:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRenderingAttributesValidatorX = "renderingAttributesValidator";
		static readonly NativeHandle selRenderingAttributesValidatorXHandle = Selector.GetHandle ("renderingAttributesValidator");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selReplaceContentsInRange_WithAttributedString_X = "replaceContentsInRange:withAttributedString:";
		static readonly NativeHandle selReplaceContentsInRange_WithAttributedString_XHandle = Selector.GetHandle ("replaceContentsInRange:withAttributedString:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selReplaceContentsInRange_WithTextElements_X = "replaceContentsInRange:withTextElements:";
		static readonly NativeHandle selReplaceContentsInRange_WithTextElements_XHandle = Selector.GetHandle ("replaceContentsInRange:withTextElements:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selReplaceTextContentManager_X = "replaceTextContentManager:";
		static readonly NativeHandle selReplaceTextContentManager_XHandle = Selector.GetHandle ("replaceTextContentManager:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selResolvesNaturalAlignmentWithBaseWritingDirectionX = "resolvesNaturalAlignmentWithBaseWritingDirection";
		static readonly NativeHandle selResolvesNaturalAlignmentWithBaseWritingDirectionXHandle = Selector.GetHandle ("resolvesNaturalAlignmentWithBaseWritingDirection");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetDelegate_X = "setDelegate:";
		static readonly NativeHandle selSetDelegate_XHandle = Selector.GetHandle ("setDelegate:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetLayoutQueue_X = "setLayoutQueue:";
		static readonly NativeHandle selSetLayoutQueue_XHandle = Selector.GetHandle ("setLayoutQueue:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetLimitsLayoutForSuspiciousContents_X = "setLimitsLayoutForSuspiciousContents:";
		static readonly NativeHandle selSetLimitsLayoutForSuspiciousContents_XHandle = Selector.GetHandle ("setLimitsLayoutForSuspiciousContents:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetRenderingAttributes_ForTextRange_X = "setRenderingAttributes:forTextRange:";
		static readonly NativeHandle selSetRenderingAttributes_ForTextRange_XHandle = Selector.GetHandle ("setRenderingAttributes:forTextRange:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetRenderingAttributesValidator_X = "setRenderingAttributesValidator:";
		static readonly NativeHandle selSetRenderingAttributesValidator_XHandle = Selector.GetHandle ("setRenderingAttributesValidator:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetResolvesNaturalAlignmentWithBaseWritingDirection_X = "setResolvesNaturalAlignmentWithBaseWritingDirection:";
		static readonly NativeHandle selSetResolvesNaturalAlignmentWithBaseWritingDirection_XHandle = Selector.GetHandle ("setResolvesNaturalAlignmentWithBaseWritingDirection:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetTextContainer_X = "setTextContainer:";
		static readonly NativeHandle selSetTextContainer_XHandle = Selector.GetHandle ("setTextContainer:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetTextSelectionNavigation_X = "setTextSelectionNavigation:";
		static readonly NativeHandle selSetTextSelectionNavigation_XHandle = Selector.GetHandle ("setTextSelectionNavigation:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetTextSelections_X = "setTextSelections:";
		static readonly NativeHandle selSetTextSelections_XHandle = Selector.GetHandle ("setTextSelections:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetUsesFontLeading_X = "setUsesFontLeading:";
		static readonly NativeHandle selSetUsesFontLeading_XHandle = Selector.GetHandle ("setUsesFontLeading:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetUsesHyphenation_X = "setUsesHyphenation:";
		static readonly NativeHandle selSetUsesHyphenation_XHandle = Selector.GetHandle ("setUsesHyphenation:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTextContainerX = "textContainer";
		static readonly NativeHandle selTextContainerXHandle = Selector.GetHandle ("textContainer");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTextContentManagerX = "textContentManager";
		static readonly NativeHandle selTextContentManagerXHandle = Selector.GetHandle ("textContentManager");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTextLayoutFragmentForLocation_X = "textLayoutFragmentForLocation:";
		static readonly NativeHandle selTextLayoutFragmentForLocation_XHandle = Selector.GetHandle ("textLayoutFragmentForLocation:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTextLayoutFragmentForPosition_X = "textLayoutFragmentForPosition:";
		static readonly NativeHandle selTextLayoutFragmentForPosition_XHandle = Selector.GetHandle ("textLayoutFragmentForPosition:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTextLayoutOrientationAtLocation_X = "textLayoutOrientationAtLocation:";
		static readonly NativeHandle selTextLayoutOrientationAtLocation_XHandle = Selector.GetHandle ("textLayoutOrientationAtLocation:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTextRangeForSelectionGranularity_EnclosingLocation_X = "textRangeForSelectionGranularity:enclosingLocation:";
		static readonly NativeHandle selTextRangeForSelectionGranularity_EnclosingLocation_XHandle = Selector.GetHandle ("textRangeForSelectionGranularity:enclosingLocation:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTextSelectionNavigationX = "textSelectionNavigation";
		static readonly NativeHandle selTextSelectionNavigationXHandle = Selector.GetHandle ("textSelectionNavigation");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTextSelectionsX = "textSelections";
		static readonly NativeHandle selTextSelectionsXHandle = Selector.GetHandle ("textSelections");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTextViewportLayoutControllerX = "textViewportLayoutController";
		static readonly NativeHandle selTextViewportLayoutControllerXHandle = Selector.GetHandle ("textViewportLayoutController");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selUsageBoundsForTextContainerX = "usageBoundsForTextContainer";
		static readonly NativeHandle selUsageBoundsForTextContainerXHandle = Selector.GetHandle ("usageBoundsForTextContainer");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selUsesFontLeadingX = "usesFontLeading";
		static readonly NativeHandle selUsesFontLeadingXHandle = Selector.GetHandle ("usesFontLeading");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selUsesHyphenationX = "usesHyphenation";
		static readonly NativeHandle selUsesHyphenationXHandle = Selector.GetHandle ("usesHyphenation");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("NSTextLayoutManager");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		/// <summary>Creates a new <see cref="NSTextLayoutManager" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[DesignatedInitializer]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public NSTextLayoutManager () : base (NSObjectFlag.Empty)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
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
		public NSTextLayoutManager (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
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
		protected NSTextLayoutManager (NSObjectFlag t) : base (t)
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
		protected internal NSTextLayoutManager (NativeHandle handle) : base (handle)
		{
		}

		[Export ("addRenderingAttribute:value:forTextRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AddRenderingAttribute (string renderingAttribute, NSObject? value, NSTextRange textRange)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (renderingAttribute is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (renderingAttribute));
			var value__handle__ = value.GetHandle ();
			var textRange__handle__ = textRange!.GetNonNullHandle (nameof (textRange));
			var nsrenderingAttribute = CFString.CreateNative (renderingAttribute);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, selAddRenderingAttribute_Value_ForTextRange_XHandle, nsrenderingAttribute, value__handle__, textRange__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, selAddRenderingAttribute_Value_ForTextRange_XHandle, nsrenderingAttribute, value__handle__, textRange__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (value);
			GC.KeepAlive (textRange);
			CFString.ReleaseNative (nsrenderingAttribute);
		}
		/// <summary>Encodes the state of the object using the provided encoder.</summary><param name="encoder">The encoder object where the state of the object will be stored</param><remarks><para>This method is part of the <see cref="T:Foundation.INSCoding" /> protocol and is used by applications to preserve the state of the object into an archive.</para><para>Developers will typically create an <see cref="T:Foundation.NSKeyedArchiver" /> and then invoke the <see cref="M:Foundation.NSKeyedArchiver.ArchiveRootObjectToFile(Foundation.NSObject,System.String)" /> method which will call into this method.</para><para>If developers want to allow their object to be archived, they should override this method and store their state in using the provided <paramref name="encoder" /> parameter. In addition, developers should also implement a constructor that takes an NSCoder argument and is exported with <c>[Export ("initWithCoder:")]</c>.</para><example><code lang="csharp lang-csharp"><![CDATA[public void override EncodeTo (NSCoder coder) {
		/// coder.Encode (1, key: "version");
		/// coder.Encode (userName, key: "userName");
		/// coder.Encode (hostName, key: "hostName");]]></code></example></remarks>
		[Export ("encodeWithCoder:")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void EncodeTo (NSCoder encoder)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
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
		[Export ("ensureLayoutForRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void EnsureLayout (NSTextRange range)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var range__handle__ = range!.GetNonNullHandle (nameof (range));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selEnsureLayoutForRange_XHandle, range__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selEnsureLayoutForRange_XHandle, range__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (range);
		}
		[Export ("ensureLayoutForBounds:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void EnsureLayout (CGRect bounds)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_CGRect (this.Handle, selEnsureLayoutForBounds_XHandle, bounds);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_CGRect (&__objc_super__, selEnsureLayoutForBounds_XHandle, bounds);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("enumerateCaretOffsetsInLineFragmentAtLocation:usingBlock:")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void EnumerateCaretOffsets (INSTextLocation location, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDNSTextSelectionDataSourceEnumerateCaretOffsetsDelegate))]NSTextSelectionDataSourceEnumerateCaretOffsetsDelegate handler)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var location__handle__ = location!.GetNonNullHandle (nameof (location));
			if (handler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (handler));
			using var block_handler = Trampolines.SDNSTextSelectionDataSourceEnumerateCaretOffsetsDelegate.CreateBlock (handler);
			BlockLiteral *block_ptr_handler = &block_handler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selEnumerateCaretOffsetsInLineFragmentAtLocation_UsingBlock_XHandle, location__handle__, (IntPtr) block_ptr_handler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selEnumerateCaretOffsetsInLineFragmentAtLocation_UsingBlock_XHandle, location__handle__, (IntPtr) block_ptr_handler);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (location);
		}
		[Export ("enumerateContainerBoundariesFromLocation:reverse:usingBlock:")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void EnumerateContainerBoundaries (INSTextLocation location, bool reverse, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDNSTextSelectionDataSourceEnumerateContainerBoundariesDelegate))]NSTextSelectionDataSourceEnumerateContainerBoundariesDelegate handler)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var location__handle__ = location!.GetNonNullHandle (nameof (location));
			if (handler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (handler));
			using var block_handler = Trampolines.SDNSTextSelectionDataSourceEnumerateContainerBoundariesDelegate.CreateBlock (handler);
			BlockLiteral *block_ptr_handler = &block_handler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_bool_NativeHandle (this.Handle, selEnumerateContainerBoundariesFromLocation_Reverse_UsingBlock_XHandle, location__handle__, reverse ? (byte) 1 : (byte) 0, (IntPtr) block_ptr_handler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_bool_NativeHandle (&__objc_super__, selEnumerateContainerBoundariesFromLocation_Reverse_UsingBlock_XHandle, location__handle__, reverse ? (byte) 1 : (byte) 0, (IntPtr) block_ptr_handler);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (location);
		}
		[Export ("enumerateRenderingAttributesFromLocation:reverse:usingBlock:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void EnumerateRenderingAttributes (INSTextLocation location, bool reverse, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDNSTextLayoutManagerEnumerateRenderingAttributesDelegate))]NSTextLayoutManagerEnumerateRenderingAttributesDelegate handler)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var location__handle__ = location!.GetNonNullHandle (nameof (location));
			if (handler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (handler));
			using var block_handler = Trampolines.SDNSTextLayoutManagerEnumerateRenderingAttributesDelegate.CreateBlock (handler);
			BlockLiteral *block_ptr_handler = &block_handler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_bool_NativeHandle (this.Handle, selEnumerateRenderingAttributesFromLocation_Reverse_UsingBlock_XHandle, location__handle__, reverse ? (byte) 1 : (byte) 0, (IntPtr) block_ptr_handler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_bool_NativeHandle (&__objc_super__, selEnumerateRenderingAttributesFromLocation_Reverse_UsingBlock_XHandle, location__handle__, reverse ? (byte) 1 : (byte) 0, (IntPtr) block_ptr_handler);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (location);
		}
		[Export ("enumerateSubstringsFromLocation:options:usingBlock:")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void EnumerateSubstrings (INSTextLocation location, NSStringEnumerationOptions options, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDNSTextSelectionDataSourceEnumerateSubstringsDelegate))]NSTextSelectionDataSourceEnumerateSubstringsDelegate handler)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var location__handle__ = location!.GetNonNullHandle (nameof (location));
			if (handler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (handler));
			using var block_handler = Trampolines.SDNSTextSelectionDataSourceEnumerateSubstringsDelegate.CreateBlock (handler);
			BlockLiteral *block_ptr_handler = &block_handler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr_NativeHandle (this.Handle, selEnumerateSubstringsFromLocation_Options_UsingBlock_XHandle, location__handle__, (UIntPtr) (ulong) options, (IntPtr) block_ptr_handler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_UIntPtr_NativeHandle (&__objc_super__, selEnumerateSubstringsFromLocation_Options_UsingBlock_XHandle, location__handle__, (UIntPtr) (ulong) options, (IntPtr) block_ptr_handler);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (location);
		}
		[Export ("enumerateTextLayoutFragmentsFromLocation:options:usingBlock:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual INSTextLocation? EnumerateTextLayoutFragments (INSTextLocation? location, NSTextLayoutFragmentEnumerationOptions options, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDFuncArity2V3))]global::System.Func<NSTextLayoutFragment, bool> handler)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var location__handle__ = location.GetHandle ();
			if (handler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (handler));
			using var block_handler = Trampolines.SDFuncArity2V3.CreateBlock (handler);
			BlockLiteral *block_ptr_handler = &block_handler;
			INSTextLocation? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetINativeObject<INSTextLocation> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_UIntPtr_NativeHandle (this.Handle, selEnumerateTextLayoutFragmentsFromLocation_Options_UsingBlock_XHandle, location__handle__, (UIntPtr) (ulong) options, (IntPtr) block_ptr_handler), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetINativeObject<INSTextLocation> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_UIntPtr_NativeHandle (&__objc_super__, selEnumerateTextLayoutFragmentsFromLocation_Options_UsingBlock_XHandle, location__handle__, (UIntPtr) (ulong) options, (IntPtr) block_ptr_handler), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (location);
			return ret!;
		}
		[Export ("enumerateTextSegmentsInRange:type:options:usingBlock:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void EnumerateTextSegments (NSTextRange textRange, NSTextLayoutManagerSegmentType type, NSTextLayoutManagerSegmentOptions options, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDNSTextLayoutManagerEnumerateTextSegmentsDelegate))]NSTextLayoutManagerEnumerateTextSegmentsDelegate handler)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var textRange__handle__ = textRange!.GetNonNullHandle (nameof (textRange));
			if (handler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (handler));
			using var block_handler = Trampolines.SDNSTextLayoutManagerEnumerateTextSegmentsDelegate.CreateBlock (handler);
			BlockLiteral *block_ptr_handler = &block_handler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_IntPtr_UIntPtr_NativeHandle (this.Handle, selEnumerateTextSegmentsInRange_Type_Options_UsingBlock_XHandle, textRange__handle__, (IntPtr) (long) type, (UIntPtr) (ulong) options, (IntPtr) block_ptr_handler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_IntPtr_UIntPtr_NativeHandle (&__objc_super__, selEnumerateTextSegmentsInRange_Type_Options_UsingBlock_XHandle, textRange__handle__, (IntPtr) (long) type, (UIntPtr) (ulong) options, (IntPtr) block_ptr_handler);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (textRange);
		}
		[Export ("baseWritingDirectionAtLocation:")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSTextSelectionNavigationWritingDirection GetBaseWritingDirection (INSTextLocation location)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var location__handle__ = location!.GetNonNullHandle (nameof (location));
			NSTextSelectionNavigationWritingDirection ret;
			if (IsDirectBinding) {
				ret = (NSTextSelectionNavigationWritingDirection) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_NativeHandle (this.Handle, selBaseWritingDirectionAtLocation_XHandle, location__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = (NSTextSelectionNavigationWritingDirection) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_NativeHandle (&__objc_super__, selBaseWritingDirectionAtLocation_XHandle, location__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (location);
			return ret!;
		}
		[Export ("lineFragmentRangeForPoint:inContainerAtLocation:")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSTextRange? GetLineFragmentRange (CGPoint point, INSTextLocation location)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var location__handle__ = location!.GetNonNullHandle (nameof (location));
			NSTextRange? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSTextRange> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_CGPoint_NativeHandle (this.Handle, selLineFragmentRangeForPoint_InContainerAtLocation_XHandle, point, location__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSTextRange> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_CGPoint_NativeHandle (&__objc_super__, selLineFragmentRangeForPoint_InContainerAtLocation_XHandle, point, location__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (location);
			return ret!;
		}
		[Export ("locationFromLocation:withOffset:")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual INSTextLocation? GetLocation (INSTextLocation location, nint offset)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var location__handle__ = location!.GetNonNullHandle (nameof (location));
			INSTextLocation? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetINativeObject<INSTextLocation> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_IntPtr (this.Handle, selLocationFromLocation_WithOffset_XHandle, location__handle__, offset), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetINativeObject<INSTextLocation> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_IntPtr (&__objc_super__, selLocationFromLocation_WithOffset_XHandle, location__handle__, offset), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (location);
			return ret!;
		}
		[Export ("offsetFromLocation:toLocation:")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint GetOffsetFromLocation (INSTextLocation from, INSTextLocation to)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var from__handle__ = from!.GetNonNullHandle (nameof (from));
			var to__handle__ = to!.GetNonNullHandle (nameof (to));
			nint ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selOffsetFromLocation_ToLocation_XHandle, from__handle__, to__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selOffsetFromLocation_ToLocation_XHandle, from__handle__, to__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (from);
			GC.KeepAlive (to);
			return ret!;
		}
		[Export ("renderingAttributesForLink:atLocation:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDictionary<NSString, NSObject> GetRenderingAttributes (NSObject link, INSTextLocation location)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var link__handle__ = link!.GetNonNullHandle (nameof (link));
			var location__handle__ = location!.GetNonNullHandle (nameof (location));
			NSDictionary<NSString, NSObject>? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSDictionary<NSString, NSObject>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selRenderingAttributesForLink_AtLocation_XHandle, link__handle__, location__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSDictionary<NSString, NSObject>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selRenderingAttributesForLink_AtLocation_XHandle, link__handle__, location__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (link);
			GC.KeepAlive (location);
			return ret!;
		}
		[Export ("textLayoutFragmentForPosition:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSTextLayoutFragment? GetTextLayoutFragment (CGPoint position)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSTextLayoutFragment ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSTextLayoutFragment> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_CGPoint (this.Handle, selTextLayoutFragmentForPosition_XHandle, position), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSTextLayoutFragment> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_CGPoint (&__objc_super__, selTextLayoutFragmentForPosition_XHandle, position), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("textLayoutFragmentForLocation:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSTextLayoutFragment? GetTextLayoutFragment (INSTextLocation location)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var location__handle__ = location!.GetNonNullHandle (nameof (location));
			NSTextLayoutFragment? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSTextLayoutFragment> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selTextLayoutFragmentForLocation_XHandle, location__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSTextLayoutFragment> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selTextLayoutFragmentForLocation_XHandle, location__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (location);
			return ret!;
		}
		[Export ("textLayoutOrientationAtLocation:")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSTextSelectionNavigationLayoutOrientation GetTextLayoutOrientation (INSTextLocation location)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var location__handle__ = location!.GetNonNullHandle (nameof (location));
			NSTextSelectionNavigationLayoutOrientation ret;
			if (IsDirectBinding) {
				ret = (NSTextSelectionNavigationLayoutOrientation) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_NativeHandle (this.Handle, selTextLayoutOrientationAtLocation_XHandle, location__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = (NSTextSelectionNavigationLayoutOrientation) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_NativeHandle (&__objc_super__, selTextLayoutOrientationAtLocation_XHandle, location__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (location);
			return ret!;
		}
		[Export ("textRangeForSelectionGranularity:enclosingLocation:")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSTextRange? GetTextRange (NSTextSelectionGranularity selectionGranularity, INSTextLocation location)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var location__handle__ = location!.GetNonNullHandle (nameof (location));
			NSTextRange? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSTextRange> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_IntPtr_NativeHandle (this.Handle, selTextRangeForSelectionGranularity_EnclosingLocation_XHandle, (IntPtr) (long) selectionGranularity, location__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSTextRange> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_IntPtr_NativeHandle (&__objc_super__, selTextRangeForSelectionGranularity_EnclosingLocation_XHandle, (IntPtr) (long) selectionGranularity, location__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (location);
			return ret!;
		}
		[Export ("invalidateLayoutForRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void InvalidateLayout (NSTextRange range)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var range__handle__ = range!.GetNonNullHandle (nameof (range));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selInvalidateLayoutForRange_XHandle, range__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selInvalidateLayoutForRange_XHandle, range__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (range);
		}
		[Export ("invalidateRenderingAttributesForTextRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void InvalidateRenderingAttributes (NSTextRange textRange)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var textRange__handle__ = textRange!.GetNonNullHandle (nameof (textRange));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selInvalidateRenderingAttributesForTextRange_XHandle, textRange__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selInvalidateRenderingAttributesForTextRange_XHandle, textRange__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (textRange);
		}
		[Export ("removeRenderingAttribute:forTextRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemoveRenderingAttribute (string renderingAttribute, NSTextRange textRange)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (renderingAttribute is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (renderingAttribute));
			var textRange__handle__ = textRange!.GetNonNullHandle (nameof (textRange));
			var nsrenderingAttribute = CFString.CreateNative (renderingAttribute);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selRemoveRenderingAttribute_ForTextRange_XHandle, nsrenderingAttribute, textRange__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selRemoveRenderingAttribute_ForTextRange_XHandle, nsrenderingAttribute, textRange__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (textRange);
			CFString.ReleaseNative (nsrenderingAttribute);
		}
		[Export ("replaceTextContentManager:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Replace (NSTextContentManager textContentManager)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var textContentManager__handle__ = textContentManager!.GetNonNullHandle (nameof (textContentManager));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selReplaceTextContentManager_XHandle, textContentManager__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selReplaceTextContentManager_XHandle, textContentManager__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (textContentManager);
		}
		[Export ("replaceContentsInRange:withTextElements:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ReplaceContents (NSTextRange range, NSTextElement[] textElements)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var range__handle__ = range!.GetNonNullHandle (nameof (range));
			if (textElements is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (textElements));
			using var nsa_textElements = NSArray.FromNSObjects (textElements);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selReplaceContentsInRange_WithTextElements_XHandle, range__handle__, nsa_textElements.Handle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selReplaceContentsInRange_WithTextElements_XHandle, range__handle__, nsa_textElements.Handle);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (range);
		}
		[Export ("replaceContentsInRange:withAttributedString:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ReplaceContents (NSTextRange range, NSAttributedString attributedString)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var range__handle__ = range!.GetNonNullHandle (nameof (range));
			var attributedString__handle__ = attributedString!.GetNonNullHandle (nameof (attributedString));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selReplaceContentsInRange_WithAttributedString_XHandle, range__handle__, attributedString__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selReplaceContentsInRange_WithAttributedString_XHandle, range__handle__, attributedString__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (range);
			GC.KeepAlive (attributedString);
		}
		[Export ("setRenderingAttributes:forTextRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetRenderingAttributes (NSDictionary<NSString, NSObject> renderingAttributes, NSTextRange textRange)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var renderingAttributes__handle__ = renderingAttributes!.GetNonNullHandle (nameof (renderingAttributes));
			var textRange__handle__ = textRange!.GetNonNullHandle (nameof (textRange));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selSetRenderingAttributes_ForTextRange_XHandle, renderingAttributes__handle__, textRange__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selSetRenderingAttributes_ForTextRange_XHandle, renderingAttributes__handle__, textRange__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (renderingAttributes);
			GC.KeepAlive (textRange);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public INSTextLayoutManagerDelegate? Delegate {
			get {
				return (WeakDelegate as INSTextLayoutManagerDelegate)!;
			}
			set {
				var rvalue = value as NSObject;
				if (!(value is null) && rvalue is null)
					throw new ArgumentException ("The object passed of type " + value.GetType () + " does not derive from NSObject");
				WeakDelegate = rvalue;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		public virtual NSTextRange DocumentRange {
			[Export ("documentRange", ArgumentSemantic.Retain)]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSTextRange? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSTextRange> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selDocumentRangeXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSTextRange> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selDocumentRangeXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSOperationQueue? LayoutQueue {
			[Export ("layoutQueue", ArgumentSemantic.Retain)]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSOperationQueue? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSOperationQueue> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selLayoutQueueXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSOperationQueue> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selLayoutQueueXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setLayoutQueue:", ArgumentSemantic.Retain)]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetLayoutQueue_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetLayoutQueue_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool LimitsLayoutForSuspiciousContents {
			[Export ("limitsLayoutForSuspiciousContents")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selLimitsLayoutForSuspiciousContentsXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selLimitsLayoutForSuspiciousContentsXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setLimitsLayoutForSuspiciousContents:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetLimitsLayoutForSuspiciousContents_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetLimitsLayoutForSuspiciousContents_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSDictionary<NSString, NSObject> LinkRenderingAttributes {
			[Export ("linkRenderingAttributes")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSDictionary<NSString, NSObject>? ret;
				ret =  Runtime.GetNSObject<NSDictionary<NSString, NSObject>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selLinkRenderingAttributesXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual global::System.Action<NSTextLayoutManager, NSTextLayoutFragment>? RenderingAttributesValidator {
			[return: DelegateProxy (typeof (ObjCRuntime.Trampolines.SDActionArity2V27))]
			[Export ("renderingAttributesValidator", ArgumentSemantic.Copy)]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NativeHandle ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selRenderingAttributesValidatorXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selRenderingAttributesValidatorXHandle);
						GC.KeepAlive (this);
					}
				}
				return global::ObjCRuntime.Trampolines.NIDActionArity2V27.Create (ret)!;
			}
			[param: BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V27))]
			[Export ("setRenderingAttributesValidator:", ArgumentSemantic.Copy)]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				using var block_value = Trampolines.SDActionArity2V27.CreateNullableBlock (value);
				BlockLiteral *block_ptr_value = null;
				if (value is not null)
					block_ptr_value = &block_value;
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetRenderingAttributesValidator_XHandle, (IntPtr) block_ptr_value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetRenderingAttributesValidator_XHandle, (IntPtr) block_ptr_value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		public virtual bool ResolvesNaturalAlignmentWithBaseWritingDirection {
			[Export ("resolvesNaturalAlignmentWithBaseWritingDirection")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selResolvesNaturalAlignmentWithBaseWritingDirectionXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selResolvesNaturalAlignmentWithBaseWritingDirectionXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setResolvesNaturalAlignmentWithBaseWritingDirection:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetResolvesNaturalAlignmentWithBaseWritingDirection_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetResolvesNaturalAlignmentWithBaseWritingDirection_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSTextContainer? TextContainer {
			[Export ("textContainer", ArgumentSemantic.Retain)]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSTextContainer? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSTextContainer> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selTextContainerXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSTextContainer> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selTextContainerXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setTextContainer:", ArgumentSemantic.Retain)]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetTextContainer_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetTextContainer_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		object? __mt_TextContentManager_var;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSTextContentManager? TextContentManager {
			[Export ("textContentManager", ArgumentSemantic.Weak)]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSTextContentManager? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSTextContentManager> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selTextContentManagerXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSTextContentManager> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selTextContentManagerXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				MarkDirty ();
				__mt_TextContentManager_var = ret;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSTextSelectionNavigation TextSelectionNavigation {
			[Export ("textSelectionNavigation", ArgumentSemantic.Retain)]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSTextSelectionNavigation? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSTextSelectionNavigation> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selTextSelectionNavigationXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSTextSelectionNavigation> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selTextSelectionNavigationXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setTextSelectionNavigation:", ArgumentSemantic.Retain)]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				var value__handle__ = value!.GetNonNullHandle (nameof (value));
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetTextSelectionNavigation_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetTextSelectionNavigation_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSTextSelection[] TextSelections {
			[Export ("textSelections", ArgumentSemantic.Retain)]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSTextSelection[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<NSTextSelection>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selTextSelectionsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<NSTextSelection>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selTextSelectionsXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setTextSelections:", ArgumentSemantic.Retain)]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (value is null)
					ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (value));
				using var nsa_value = NSArray.FromNSObjects (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetTextSelections_XHandle, nsa_value.Handle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetTextSelections_XHandle, nsa_value.Handle);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSTextViewportLayoutController TextViewportLayoutController {
			[Export ("textViewportLayoutController", ArgumentSemantic.Retain)]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSTextViewportLayoutController? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSTextViewportLayoutController> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selTextViewportLayoutControllerXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSTextViewportLayoutController> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selTextViewportLayoutControllerXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGRect UsageBoundsForTextContainer {
			[Export ("usageBoundsForTextContainer")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				CGRect ret;
				if (IsDirectBinding) {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend (this.Handle, selUsageBoundsForTextContainerXHandle);
					} else {
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret (this.Handle, selUsageBoundsForTextContainerXHandle);
					}
				} else {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper (&__objc_super__, selUsageBoundsForTextContainerXHandle);
							GC.KeepAlive (this);
						}
					} else {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper_stret (&__objc_super__, selUsageBoundsForTextContainerXHandle);
							GC.KeepAlive (this);
						}
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool UsesFontLeading {
			[Export ("usesFontLeading")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selUsesFontLeadingXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selUsesFontLeadingXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setUsesFontLeading:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetUsesFontLeading_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetUsesFontLeading_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool UsesHyphenation {
			[Export ("usesHyphenation")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selUsesHyphenationXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selUsesHyphenationXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setUsesHyphenation:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetUsesHyphenation_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetUsesHyphenation_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		object? __mt_WeakDelegate_var;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject? WeakDelegate {
			[Export ("delegate", ArgumentSemantic.Weak)]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSObject? ret;
				if (IsDirectBinding) {
					ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selDelegateXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selDelegateXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				MarkDirty ();
				__mt_WeakDelegate_var = ret;
				return ret!;
			}
			[Export ("setDelegate:", ArgumentSemantic.Weak)]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetDelegate_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetDelegate_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
				MarkDirty ();
				__mt_WeakDelegate_var = value;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_TextContentManager_var = null;
				__mt_WeakDelegate_var = null;
			}
		}
	} /* class NSTextLayoutManager */
}
