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
	/// <summary>A class that extends <see cref="T:AppKit.NSParagraphStyle" /> to allow changing subattributes.</summary><remarks><para></para><para tool="threads">The members of this class can be used from a background thread.</para></remarks><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/Cocoa/Reference/ApplicationKit/Classes/NSMutableParagraphStyle_Class/index.html">Apple documentation for <c>NSMutableParagraphStyle</c></related>
	[Register("NSMutableParagraphStyle", true)]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	public unsafe partial class NSMutableParagraphStyle : NSParagraphStyle {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAddTabStop_X = "addTabStop:";
		static readonly NativeHandle selAddTabStop_XHandle = Selector.GetHandle ("addTabStop:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAlignmentX = "alignment";
		static readonly NativeHandle selAlignmentXHandle = Selector.GetHandle ("alignment");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAllowsDefaultTighteningForTruncationX = "allowsDefaultTighteningForTruncation";
		static readonly NativeHandle selAllowsDefaultTighteningForTruncationXHandle = Selector.GetHandle ("allowsDefaultTighteningForTruncation");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selBaseWritingDirectionX = "baseWritingDirection";
		static readonly NativeHandle selBaseWritingDirectionXHandle = Selector.GetHandle ("baseWritingDirection");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDefaultTabIntervalX = "defaultTabInterval";
		static readonly NativeHandle selDefaultTabIntervalXHandle = Selector.GetHandle ("defaultTabInterval");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFirstLineHeadIndentX = "firstLineHeadIndent";
		static readonly NativeHandle selFirstLineHeadIndentXHandle = Selector.GetHandle ("firstLineHeadIndent");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selHeadIndentX = "headIndent";
		static readonly NativeHandle selHeadIndentXHandle = Selector.GetHandle ("headIndent");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selHeaderLevelX = "headerLevel";
		static readonly NativeHandle selHeaderLevelXHandle = Selector.GetHandle ("headerLevel");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selHyphenationFactorX = "hyphenationFactor";
		static readonly NativeHandle selHyphenationFactorXHandle = Selector.GetHandle ("hyphenationFactor");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLineBreakModeX = "lineBreakMode";
		static readonly NativeHandle selLineBreakModeXHandle = Selector.GetHandle ("lineBreakMode");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLineBreakStrategyX = "lineBreakStrategy";
		static readonly NativeHandle selLineBreakStrategyXHandle = Selector.GetHandle ("lineBreakStrategy");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLineHeightMultipleX = "lineHeightMultiple";
		static readonly NativeHandle selLineHeightMultipleXHandle = Selector.GetHandle ("lineHeightMultiple");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLineSpacingX = "lineSpacing";
		static readonly NativeHandle selLineSpacingXHandle = Selector.GetHandle ("lineSpacing");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMaximumLineHeightX = "maximumLineHeight";
		static readonly NativeHandle selMaximumLineHeightXHandle = Selector.GetHandle ("maximumLineHeight");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMinimumLineHeightX = "minimumLineHeight";
		static readonly NativeHandle selMinimumLineHeightXHandle = Selector.GetHandle ("minimumLineHeight");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selParagraphSpacingX = "paragraphSpacing";
		static readonly NativeHandle selParagraphSpacingXHandle = Selector.GetHandle ("paragraphSpacing");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selParagraphSpacingBeforeX = "paragraphSpacingBefore";
		static readonly NativeHandle selParagraphSpacingBeforeXHandle = Selector.GetHandle ("paragraphSpacingBefore");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRemoveTabStop_X = "removeTabStop:";
		static readonly NativeHandle selRemoveTabStop_XHandle = Selector.GetHandle ("removeTabStop:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAlignment_X = "setAlignment:";
		static readonly NativeHandle selSetAlignment_XHandle = Selector.GetHandle ("setAlignment:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAllowsDefaultTighteningForTruncation_X = "setAllowsDefaultTighteningForTruncation:";
		static readonly NativeHandle selSetAllowsDefaultTighteningForTruncation_XHandle = Selector.GetHandle ("setAllowsDefaultTighteningForTruncation:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetBaseWritingDirection_X = "setBaseWritingDirection:";
		static readonly NativeHandle selSetBaseWritingDirection_XHandle = Selector.GetHandle ("setBaseWritingDirection:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetDefaultTabInterval_X = "setDefaultTabInterval:";
		static readonly NativeHandle selSetDefaultTabInterval_XHandle = Selector.GetHandle ("setDefaultTabInterval:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetFirstLineHeadIndent_X = "setFirstLineHeadIndent:";
		static readonly NativeHandle selSetFirstLineHeadIndent_XHandle = Selector.GetHandle ("setFirstLineHeadIndent:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetHeadIndent_X = "setHeadIndent:";
		static readonly NativeHandle selSetHeadIndent_XHandle = Selector.GetHandle ("setHeadIndent:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetHeaderLevel_X = "setHeaderLevel:";
		static readonly NativeHandle selSetHeaderLevel_XHandle = Selector.GetHandle ("setHeaderLevel:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetHyphenationFactor_X = "setHyphenationFactor:";
		static readonly NativeHandle selSetHyphenationFactor_XHandle = Selector.GetHandle ("setHyphenationFactor:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetLineBreakMode_X = "setLineBreakMode:";
		static readonly NativeHandle selSetLineBreakMode_XHandle = Selector.GetHandle ("setLineBreakMode:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetLineBreakStrategy_X = "setLineBreakStrategy:";
		static readonly NativeHandle selSetLineBreakStrategy_XHandle = Selector.GetHandle ("setLineBreakStrategy:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetLineHeightMultiple_X = "setLineHeightMultiple:";
		static readonly NativeHandle selSetLineHeightMultiple_XHandle = Selector.GetHandle ("setLineHeightMultiple:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetLineSpacing_X = "setLineSpacing:";
		static readonly NativeHandle selSetLineSpacing_XHandle = Selector.GetHandle ("setLineSpacing:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetMaximumLineHeight_X = "setMaximumLineHeight:";
		static readonly NativeHandle selSetMaximumLineHeight_XHandle = Selector.GetHandle ("setMaximumLineHeight:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetMinimumLineHeight_X = "setMinimumLineHeight:";
		static readonly NativeHandle selSetMinimumLineHeight_XHandle = Selector.GetHandle ("setMinimumLineHeight:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetParagraphSpacing_X = "setParagraphSpacing:";
		static readonly NativeHandle selSetParagraphSpacing_XHandle = Selector.GetHandle ("setParagraphSpacing:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetParagraphSpacingBefore_X = "setParagraphSpacingBefore:";
		static readonly NativeHandle selSetParagraphSpacingBefore_XHandle = Selector.GetHandle ("setParagraphSpacingBefore:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetParagraphStyle_X = "setParagraphStyle:";
		static readonly NativeHandle selSetParagraphStyle_XHandle = Selector.GetHandle ("setParagraphStyle:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetTabStops_X = "setTabStops:";
		static readonly NativeHandle selSetTabStops_XHandle = Selector.GetHandle ("setTabStops:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetTailIndent_X = "setTailIndent:";
		static readonly NativeHandle selSetTailIndent_XHandle = Selector.GetHandle ("setTailIndent:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetTextBlocks_X = "setTextBlocks:";
		static readonly NativeHandle selSetTextBlocks_XHandle = Selector.GetHandle ("setTextBlocks:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetTextLists_X = "setTextLists:";
		static readonly NativeHandle selSetTextLists_XHandle = Selector.GetHandle ("setTextLists:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetTighteningFactorForTruncation_X = "setTighteningFactorForTruncation:";
		static readonly NativeHandle selSetTighteningFactorForTruncation_XHandle = Selector.GetHandle ("setTighteningFactorForTruncation:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetUsesDefaultHyphenation_X = "setUsesDefaultHyphenation:";
		static readonly NativeHandle selSetUsesDefaultHyphenation_XHandle = Selector.GetHandle ("setUsesDefaultHyphenation:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTabStopsX = "tabStops";
		static readonly NativeHandle selTabStopsXHandle = Selector.GetHandle ("tabStops");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTailIndentX = "tailIndent";
		static readonly NativeHandle selTailIndentXHandle = Selector.GetHandle ("tailIndent");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTextBlocksX = "textBlocks";
		static readonly NativeHandle selTextBlocksXHandle = Selector.GetHandle ("textBlocks");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTextListsX = "textLists";
		static readonly NativeHandle selTextListsXHandle = Selector.GetHandle ("textLists");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTighteningFactorForTruncationX = "tighteningFactorForTruncation";
		static readonly NativeHandle selTighteningFactorForTruncationXHandle = Selector.GetHandle ("tighteningFactorForTruncation");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selUsesDefaultHyphenationX = "usesDefaultHyphenation";
		static readonly NativeHandle selUsesDefaultHyphenationXHandle = Selector.GetHandle ("usesDefaultHyphenation");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("NSMutableParagraphStyle");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		/// <summary>Creates a new <see cref="NSMutableParagraphStyle" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public NSMutableParagraphStyle () : base (NSObjectFlag.Empty)
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
		public NSMutableParagraphStyle (NSCoder coder) : base (NSObjectFlag.Empty)
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
		protected NSMutableParagraphStyle (NSObjectFlag t) : base (t)
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
		protected internal NSMutableParagraphStyle (NativeHandle handle) : base (handle)
		{
		}

		/// <summary>Adds the specified <see cref="T:AppKit.NSTextTab" /> to the pargraph style.</summary><param name="textTab">To be added.</param><remarks><para>(More documentation for this node is coming)</para><para tool="threads">This can be used from a background thread.</para></remarks>
		[Export ("addTabStop:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AddTabStop (NSTextTab textTab)
		{
			var textTab__handle__ = textTab!.GetNonNullHandle (nameof (textTab));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selAddTabStop_XHandle, textTab__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selAddTabStop_XHandle, textTab__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (textTab);
		}
		/// <param name="textTab">To be added.</param><summary>Removes the tab stop <paramref name="textTab" />.</summary><remarks><para>(More documentation for this node is coming)</para><para tool="threads">This can be used from a background thread.</para></remarks>
		[Export ("removeTabStop:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemoveTabStop (NSTextTab textTab)
		{
			var textTab__handle__ = textTab!.GetNonNullHandle (nameof (textTab));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selRemoveTabStop_XHandle, textTab__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selRemoveTabStop_XHandle, textTab__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (textTab);
		}
		/// <param name="paragraphStyle">To be added.</param><summary>Replaces the existing style with <paramref name="paragraphStyle" />.</summary><remarks><para>(More documentation for this node is coming)</para><para tool="threads">This can be used from a background thread.</para></remarks>
		[Export ("setParagraphStyle:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetParagraphStyle (NSParagraphStyle paragraphStyle)
		{
			var paragraphStyle__handle__ = paragraphStyle!.GetNonNullHandle (nameof (paragraphStyle));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetParagraphStyle_XHandle, paragraphStyle__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetParagraphStyle_XHandle, paragraphStyle__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (paragraphStyle);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public override NSTextAlignment Alignment {
			[Export ("alignment")]
			get {
				NSTextAlignment ret;
				if (IsDirectBinding) {
					ret = NSTextAlignmentExtensions.ToManaged ((nuint) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selAlignmentXHandle));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = NSTextAlignmentExtensions.ToManaged ((nuint) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selAlignmentXHandle));
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setAlignment:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (this.Handle, selSetAlignment_XHandle, (UIntPtr) NSTextAlignmentExtensions.ToNative (value));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UIntPtr (&__objc_super__, selSetAlignment_XHandle, (UIntPtr) NSTextAlignmentExtensions.ToNative (value));
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public override bool AllowsDefaultTighteningForTruncation {
			[Export ("allowsDefaultTighteningForTruncation")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selAllowsDefaultTighteningForTruncationXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selAllowsDefaultTighteningForTruncationXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setAllowsDefaultTighteningForTruncation:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetAllowsDefaultTighteningForTruncation_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetAllowsDefaultTighteningForTruncation_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>The norml writing direction.</summary><value>To be added.</value><remarks><para>(More documentation for this node is coming)</para><para tool="threads">This can be used from a background thread.</para></remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public override NSWritingDirection BaseWritingDirection {
			[Export ("baseWritingDirection")]
			get {
				NSWritingDirection ret;
				if (IsDirectBinding) {
					ret = (NSWritingDirection) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selBaseWritingDirectionXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (NSWritingDirection) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selBaseWritingDirectionXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setBaseWritingDirection:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetBaseWritingDirection_XHandle, (IntPtr) (long) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, selSetBaseWritingDirection_XHandle, (IntPtr) (long) value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>The value, in points, of tab intervals.</summary><value>The default is 0.</value><remarks><para>(More documentation for this node is coming)</para><para tool="threads">This can be used from a background thread.</para></remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public override nfloat DefaultTabInterval {
			[Export ("defaultTabInterval")]
			get {
				nfloat ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend (this.Handle, selDefaultTabIntervalXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSendSuper (&__objc_super__, selDefaultTabIntervalXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setDefaultTabInterval:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_nfloat (this.Handle, selSetDefaultTabInterval_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_nfloat (&__objc_super__, selSetDefaultTabInterval_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>The indentation of the paragraph's first line.</summary><value>To be added.</value><remarks><para>(More documentation for this node is coming)</para><para tool="threads">This can be used from a background thread.</para></remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public override nfloat FirstLineHeadIndent {
			[Export ("firstLineHeadIndent")]
			get {
				nfloat ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend (this.Handle, selFirstLineHeadIndentXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSendSuper (&__objc_super__, selFirstLineHeadIndentXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setFirstLineHeadIndent:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_nfloat (this.Handle, selSetFirstLineHeadIndent_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_nfloat (&__objc_super__, selSetFirstLineHeadIndent_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>The indentation of the paragraph's lines, other than the first. (See <see cref="P:AppKit.NSMutableParagraphStyle.FirstLineHeadIndent" />.)</summary><value>To be added.</value><remarks><para>(More documentation for this node is coming)</para><para tool="threads">This can be used from a background thread.</para></remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public override nfloat HeadIndent {
			[Export ("headIndent")]
			get {
				nfloat ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend (this.Handle, selHeadIndentXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSendSuper (&__objc_super__, selHeadIndentXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setHeadIndent:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_nfloat (this.Handle, selSetHeadIndent_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_nfloat (&__objc_super__, selSetHeadIndent_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public override nint HeaderLevel {
			[Export ("headerLevel")]
			get {
				nint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selHeaderLevelXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selHeaderLevelXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setHeaderLevel:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetHeaderLevel_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, selSetHeaderLevel_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>The paragraph's threshold for hyphenation.</summary><value>Ranges from 0 to 1, indicating ratio of text width to the width of line fragment. Default is 0, indicating that the layout manager's hyphenation factor is used.</value><remarks><para>(More documentation for this node is coming)</para><para tool="threads">This can be used from a background thread.</para></remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public override float HyphenationFactor {
			[Export ("hyphenationFactor")]
			get {
				float ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selHyphenationFactorXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.float_objc_msgSendSuper (&__objc_super__, selHyphenationFactorXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setHyphenationFactor:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, selSetHyphenationFactor_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_float (&__objc_super__, selSetHyphenationFactor_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public override NSLineBreakMode LineBreakMode {
			[Export ("lineBreakMode")]
			get {
				NSLineBreakMode ret;
				if (IsDirectBinding) {
					ret = (NSLineBreakMode) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selLineBreakModeXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (NSLineBreakMode) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selLineBreakModeXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setLineBreakMode:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (this.Handle, selSetLineBreakMode_XHandle, (UIntPtr) (ulong) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UIntPtr (&__objc_super__, selSetLineBreakMode_XHandle, (UIntPtr) (ulong) value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public override NSLineBreakStrategy LineBreakStrategy {
			[Export ("lineBreakStrategy", ArgumentSemantic.Assign)]
			get {
				NSLineBreakStrategy ret;
				if (IsDirectBinding) {
					ret = (NSLineBreakStrategy) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selLineBreakStrategyXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (NSLineBreakStrategy) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selLineBreakStrategyXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setLineBreakStrategy:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (this.Handle, selSetLineBreakStrategy_XHandle, (UIntPtr) (ulong) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UIntPtr (&__objc_super__, selSetLineBreakStrategy_XHandle, (UIntPtr) (ulong) value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>The natural line height of the paragraph is multiplied by this factor before constraint to minimum and maximum.</summary><value>To be added.</value><remarks><para>(More documentation for this node is coming)</para><para tool="threads">This can be used from a background thread.</para></remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public override nfloat LineHeightMultiple {
			[Export ("lineHeightMultiple")]
			get {
				nfloat ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend (this.Handle, selLineHeightMultipleXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSendSuper (&__objc_super__, selLineHeightMultipleXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setLineHeightMultiple:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_nfloat (this.Handle, selSetLineHeightMultiple_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_nfloat (&__objc_super__, selSetLineHeightMultiple_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>The distance, in points, between the bottom of one line fragment and the top of the next.</summary><value>To be added.</value><remarks><para>(More documentation for this node is coming)</para><para tool="threads">This can be used from a background thread.</para></remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public override nfloat LineSpacing {
			[Export ("lineSpacing")]
			get {
				nfloat ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend (this.Handle, selLineSpacingXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSendSuper (&__objc_super__, selLineSpacingXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setLineSpacing:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_nfloat (this.Handle, selSetLineSpacing_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_nfloat (&__objc_super__, selSetLineSpacing_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>The paragraph's maximum line height, in points.</summary><value>The default of 0 indicates no limit.</value><remarks><para>(More documentation for this node is coming)</para><para tool="threads">This can be used from a background thread.</para></remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public override nfloat MaximumLineHeight {
			[Export ("maximumLineHeight")]
			get {
				nfloat ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend (this.Handle, selMaximumLineHeightXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSendSuper (&__objc_super__, selMaximumLineHeightXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setMaximumLineHeight:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_nfloat (this.Handle, selSetMaximumLineHeight_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_nfloat (&__objc_super__, selSetMaximumLineHeight_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>The minimum height, in points, of lines in the paragraph.</summary><value>To be added.</value><remarks><para>(More documentation for this node is coming)</para><para tool="threads">This can be used from a background thread.</para></remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public override nfloat MinimumLineHeight {
			[Export ("minimumLineHeight")]
			get {
				nfloat ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend (this.Handle, selMinimumLineHeightXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSendSuper (&__objc_super__, selMinimumLineHeightXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setMinimumLineHeight:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_nfloat (this.Handle, selSetMinimumLineHeight_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_nfloat (&__objc_super__, selSetMinimumLineHeight_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>Distance, in points, after the paragraph.</summary><value>To be added.</value><remarks><para>(More documentation for this node is coming)</para><para tool="threads">This can be used from a background thread.</para></remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public override nfloat ParagraphSpacing {
			[Export ("paragraphSpacing")]
			get {
				nfloat ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend (this.Handle, selParagraphSpacingXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSendSuper (&__objc_super__, selParagraphSpacingXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setParagraphSpacing:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_nfloat (this.Handle, selSetParagraphSpacing_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_nfloat (&__objc_super__, selSetParagraphSpacing_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>Distance, in points, between a paragraph's top and its first line.</summary><value>To be added.</value><remarks><para>(More documentation for this node is coming)</para><para tool="threads">This can be used from a background thread.</para></remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public override nfloat ParagraphSpacingBefore {
			[Export ("paragraphSpacingBefore")]
			get {
				nfloat ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend (this.Handle, selParagraphSpacingBeforeXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSendSuper (&__objc_super__, selParagraphSpacingBeforeXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setParagraphSpacingBefore:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_nfloat (this.Handle, selSetParagraphSpacingBefore_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_nfloat (&__objc_super__, selSetParagraphSpacingBefore_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>The paragraph's tab stops, sorted by location.</summary><value>To be added.</value><remarks><para>(More documentation for this node is coming)</para><para tool="threads">This can be used from a background thread.</para></remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public override NSTextTab[]? TabStops {
			[Export ("tabStops", ArgumentSemantic.Copy)]
			get {
				NSTextTab[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<NSTextTab>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selTabStopsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<NSTextTab>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selTabStopsXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setTabStops:", ArgumentSemantic.Copy)]
			set {
				using var nsa_value = value is null ? null : NSArray.FromNSObjects (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetTabStops_XHandle, nsa_value.GetHandle ());
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetTabStops_XHandle, nsa_value.GetHandle ());
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>The distance, in points, from the margin of a text container to the end of lines.</summary><value>To be added.</value><remarks><para>(More documentation for this node is coming)</para><para tool="threads">This can be used from a background thread.</para></remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public override nfloat TailIndent {
			[Export ("tailIndent")]
			get {
				nfloat ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend (this.Handle, selTailIndentXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSendSuper (&__objc_super__, selTailIndentXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setTailIndent:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_nfloat (this.Handle, selSetTailIndent_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_nfloat (&__objc_super__, selSetTailIndent_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public override NSTextBlock[] TextBlocks {
			[Export ("textBlocks")]
			get {
				NSTextBlock[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<NSTextBlock>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selTextBlocksXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<NSTextBlock>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selTextBlocksXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setTextBlocks:")]
			set {
				if (value is null)
					ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (value));
				using var nsa_value = NSArray.FromNSObjects (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetTextBlocks_XHandle, nsa_value.Handle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetTextBlocks_XHandle, nsa_value.Handle);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public override NSTextList[] TextLists {
			[Export ("textLists")]
			get {
				NSTextList[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<NSTextList>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selTextListsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<NSTextList>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selTextListsXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setTextLists:")]
			set {
				if (value is null)
					ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (value));
				using var nsa_value = NSArray.FromNSObjects (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetTextLists_XHandle, nsa_value.Handle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetTextLists_XHandle, nsa_value.Handle);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public override float TighteningFactorForTruncation {
			[Export ("tighteningFactorForTruncation")]
			get {
				float ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selTighteningFactorForTruncationXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.float_objc_msgSendSuper (&__objc_super__, selTighteningFactorForTruncationXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setTighteningFactorForTruncation:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, selSetTighteningFactorForTruncation_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_float (&__objc_super__, selSetTighteningFactorForTruncation_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		public virtual bool UsesDefaultHyphenation {
			[Export ("usesDefaultHyphenation")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selUsesDefaultHyphenationXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selUsesDefaultHyphenationXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setUsesDefaultHyphenation:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetUsesDefaultHyphenation_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetUsesDefaultHyphenation_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
	} /* class NSMutableParagraphStyle */
}
