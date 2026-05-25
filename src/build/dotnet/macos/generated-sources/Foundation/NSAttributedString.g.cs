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
	[Register("NSAttributedString", true)]
	public unsafe partial class NSAttributedString : NSObject, INSCoding, INSCopying, INSMutableCopying, INSSecureCoding, global::AppKit.INSPasteboardReading, global::AppKit.INSPasteboardWriting {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRTFDFileWrapperFromRange_DocumentAttributes_X = "RTFDFileWrapperFromRange:documentAttributes:";
		static readonly NativeHandle selRTFDFileWrapperFromRange_DocumentAttributes_XHandle = Selector.GetHandle ("RTFDFileWrapperFromRange:documentAttributes:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRTFDFromRange_DocumentAttributes_X = "RTFDFromRange:documentAttributes:";
		static readonly NativeHandle selRTFDFromRange_DocumentAttributes_XHandle = Selector.GetHandle ("RTFDFromRange:documentAttributes:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRTFFromRange_DocumentAttributes_X = "RTFFromRange:documentAttributes:";
		static readonly NativeHandle selRTFFromRange_DocumentAttributes_XHandle = Selector.GetHandle ("RTFFromRange:documentAttributes:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selURLAtIndex_EffectiveRange_X = "URLAtIndex:effectiveRange:";
		static readonly NativeHandle selURLAtIndex_EffectiveRange_XHandle = Selector.GetHandle ("URLAtIndex:effectiveRange:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAttribute_AtIndex_EffectiveRange_X = "attribute:atIndex:effectiveRange:";
		static readonly NativeHandle selAttribute_AtIndex_EffectiveRange_XHandle = Selector.GetHandle ("attribute:atIndex:effectiveRange:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAttribute_AtIndex_LongestEffectiveRange_InRange_X = "attribute:atIndex:longestEffectiveRange:inRange:";
		static readonly NativeHandle selAttribute_AtIndex_LongestEffectiveRange_InRange_XHandle = Selector.GetHandle ("attribute:atIndex:longestEffectiveRange:inRange:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAttributedStringByInflectingStringX = "attributedStringByInflectingString";
		static readonly NativeHandle selAttributedStringByInflectingStringXHandle = Selector.GetHandle ("attributedStringByInflectingString");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAttributedStringWithAdaptiveImageGlyph_Attributes_X = "attributedStringWithAdaptiveImageGlyph:attributes:";
		static readonly NativeHandle selAttributedStringWithAdaptiveImageGlyph_Attributes_XHandle = Selector.GetHandle ("attributedStringWithAdaptiveImageGlyph:attributes:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAttributedStringWithAttachment_X = "attributedStringWithAttachment:";
		static readonly NativeHandle selAttributedStringWithAttachment_XHandle = Selector.GetHandle ("attributedStringWithAttachment:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAttributedStringWithAttachment_Attributes_X = "attributedStringWithAttachment:attributes:";
		static readonly NativeHandle selAttributedStringWithAttachment_Attributes_XHandle = Selector.GetHandle ("attributedStringWithAttachment:attributes:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAttributedSubstringFromRange_X = "attributedSubstringFromRange:";
		static readonly NativeHandle selAttributedSubstringFromRange_XHandle = Selector.GetHandle ("attributedSubstringFromRange:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAttributesAtIndex_EffectiveRange_X = "attributesAtIndex:effectiveRange:";
		static readonly NativeHandle selAttributesAtIndex_EffectiveRange_XHandle = Selector.GetHandle ("attributesAtIndex:effectiveRange:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAttributesAtIndex_LongestEffectiveRange_InRange_X = "attributesAtIndex:longestEffectiveRange:inRange:";
		static readonly NativeHandle selAttributesAtIndex_LongestEffectiveRange_InRange_XHandle = Selector.GetHandle ("attributesAtIndex:longestEffectiveRange:inRange:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selBoundingRectWithSize_Options_X = "boundingRectWithSize:options:";
		static readonly NativeHandle selBoundingRectWithSize_Options_XHandle = Selector.GetHandle ("boundingRectWithSize:options:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selContainsAttachmentsX = "containsAttachments";
		static readonly NativeHandle selContainsAttachmentsXHandle = Selector.GetHandle ("containsAttachments");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selContainsAttachmentsInRange_X = "containsAttachmentsInRange:";
		static readonly NativeHandle selContainsAttachmentsInRange_XHandle = Selector.GetHandle ("containsAttachmentsInRange:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCopyWithZone_X = "copyWithZone:";
		static readonly NativeHandle selCopyWithZone_XHandle = Selector.GetHandle ("copyWithZone:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDataFromRange_DocumentAttributes_Error_X = "dataFromRange:documentAttributes:error:";
		static readonly NativeHandle selDataFromRange_DocumentAttributes_Error_XHandle = Selector.GetHandle ("dataFromRange:documentAttributes:error:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDocFormatFromRange_DocumentAttributes_X = "docFormatFromRange:documentAttributes:";
		static readonly NativeHandle selDocFormatFromRange_DocumentAttributes_XHandle = Selector.GetHandle ("docFormatFromRange:documentAttributes:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDoubleClickAtIndex_X = "doubleClickAtIndex:";
		static readonly NativeHandle selDoubleClickAtIndex_XHandle = Selector.GetHandle ("doubleClickAtIndex:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDrawAtPoint_X = "drawAtPoint:";
		static readonly NativeHandle selDrawAtPoint_XHandle = Selector.GetHandle ("drawAtPoint:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDrawInRect_X = "drawInRect:";
		static readonly NativeHandle selDrawInRect_XHandle = Selector.GetHandle ("drawInRect:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDrawWithRect_Options_X = "drawWithRect:options:";
		static readonly NativeHandle selDrawWithRect_Options_XHandle = Selector.GetHandle ("drawWithRect:options:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selEncodeWithCoder_X = "encodeWithCoder:";
		static readonly NativeHandle selEncodeWithCoder_XHandle = Selector.GetHandle ("encodeWithCoder:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selEnumerateAttribute_InRange_Options_UsingBlock_X = "enumerateAttribute:inRange:options:usingBlock:";
		static readonly NativeHandle selEnumerateAttribute_InRange_Options_UsingBlock_XHandle = Selector.GetHandle ("enumerateAttribute:inRange:options:usingBlock:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selEnumerateAttributesInRange_Options_UsingBlock_X = "enumerateAttributesInRange:options:usingBlock:";
		static readonly NativeHandle selEnumerateAttributesInRange_Options_UsingBlock_XHandle = Selector.GetHandle ("enumerateAttributesInRange:options:usingBlock:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFileWrapperFromRange_DocumentAttributes_Error_X = "fileWrapperFromRange:documentAttributes:error:";
		static readonly NativeHandle selFileWrapperFromRange_DocumentAttributes_Error_XHandle = Selector.GetHandle ("fileWrapperFromRange:documentAttributes:error:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFontAttributesInRange_X = "fontAttributesInRange:";
		static readonly NativeHandle selFontAttributesInRange_XHandle = Selector.GetHandle ("fontAttributesInRange:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithAttributedString_X = "initWithAttributedString:";
		static readonly NativeHandle selInitWithAttributedString_XHandle = Selector.GetHandle ("initWithAttributedString:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithCoder_X = "initWithCoder:";
		static readonly NativeHandle selInitWithCoder_XHandle = Selector.GetHandle ("initWithCoder:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithContentsOfMarkdownFileAtURL_Options_BaseURL_Error_X = "initWithContentsOfMarkdownFileAtURL:options:baseURL:error:";
		static readonly NativeHandle selInitWithContentsOfMarkdownFileAtURL_Options_BaseURL_Error_XHandle = Selector.GetHandle ("initWithContentsOfMarkdownFileAtURL:options:baseURL:error:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithData_Options_DocumentAttributes_Error_X = "initWithData:options:documentAttributes:error:";
		static readonly NativeHandle selInitWithData_Options_DocumentAttributes_Error_XHandle = Selector.GetHandle ("initWithData:options:documentAttributes:error:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithDocFormat_DocumentAttributes_X = "initWithDocFormat:documentAttributes:";
		static readonly NativeHandle selInitWithDocFormat_DocumentAttributes_XHandle = Selector.GetHandle ("initWithDocFormat:documentAttributes:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithHTML_BaseURL_DocumentAttributes_X = "initWithHTML:baseURL:documentAttributes:";
		static readonly NativeHandle selInitWithHTML_BaseURL_DocumentAttributes_XHandle = Selector.GetHandle ("initWithHTML:baseURL:documentAttributes:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithHTML_DocumentAttributes_X = "initWithHTML:documentAttributes:";
		static readonly NativeHandle selInitWithHTML_DocumentAttributes_XHandle = Selector.GetHandle ("initWithHTML:documentAttributes:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithHTML_Options_DocumentAttributes_X = "initWithHTML:options:documentAttributes:";
		static readonly NativeHandle selInitWithHTML_Options_DocumentAttributes_XHandle = Selector.GetHandle ("initWithHTML:options:documentAttributes:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithMarkdown_Options_BaseURL_Error_X = "initWithMarkdown:options:baseURL:error:";
		static readonly NativeHandle selInitWithMarkdown_Options_BaseURL_Error_XHandle = Selector.GetHandle ("initWithMarkdown:options:baseURL:error:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithMarkdownString_Options_BaseURL_Error_X = "initWithMarkdownString:options:baseURL:error:";
		static readonly NativeHandle selInitWithMarkdownString_Options_BaseURL_Error_XHandle = Selector.GetHandle ("initWithMarkdownString:options:baseURL:error:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithPasteboardPropertyList_OfType_X = "initWithPasteboardPropertyList:ofType:";
		static readonly NativeHandle selInitWithPasteboardPropertyList_OfType_XHandle = Selector.GetHandle ("initWithPasteboardPropertyList:ofType:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithPath_DocumentAttributes_X = "initWithPath:documentAttributes:";
		static readonly NativeHandle selInitWithPath_DocumentAttributes_XHandle = Selector.GetHandle ("initWithPath:documentAttributes:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithRTF_DocumentAttributes_X = "initWithRTF:documentAttributes:";
		static readonly NativeHandle selInitWithRTF_DocumentAttributes_XHandle = Selector.GetHandle ("initWithRTF:documentAttributes:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithRTFD_DocumentAttributes_X = "initWithRTFD:documentAttributes:";
		static readonly NativeHandle selInitWithRTFD_DocumentAttributes_XHandle = Selector.GetHandle ("initWithRTFD:documentAttributes:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithRTFDFileWrapper_DocumentAttributes_X = "initWithRTFDFileWrapper:documentAttributes:";
		static readonly NativeHandle selInitWithRTFDFileWrapper_DocumentAttributes_XHandle = Selector.GetHandle ("initWithRTFDFileWrapper:documentAttributes:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithString_X = "initWithString:";
		static readonly NativeHandle selInitWithString_XHandle = Selector.GetHandle ("initWithString:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithString_Attributes_X = "initWithString:attributes:";
		static readonly NativeHandle selInitWithString_Attributes_XHandle = Selector.GetHandle ("initWithString:attributes:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithURL_DocumentAttributes_X = "initWithURL:documentAttributes:";
		static readonly NativeHandle selInitWithURL_DocumentAttributes_XHandle = Selector.GetHandle ("initWithURL:documentAttributes:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithURL_Options_DocumentAttributes_Error_X = "initWithURL:options:documentAttributes:error:";
		static readonly NativeHandle selInitWithURL_Options_DocumentAttributes_Error_XHandle = Selector.GetHandle ("initWithURL:options:documentAttributes:error:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsEqualToAttributedString_X = "isEqualToAttributedString:";
		static readonly NativeHandle selIsEqualToAttributedString_XHandle = Selector.GetHandle ("isEqualToAttributedString:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selItemNumberInTextList_AtIndex_X = "itemNumberInTextList:atIndex:";
		static readonly NativeHandle selItemNumberInTextList_AtIndex_XHandle = Selector.GetHandle ("itemNumberInTextList:atIndex:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLengthX = "length";
		static readonly NativeHandle selLengthXHandle = Selector.GetHandle ("length");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLineBreakBeforeIndex_WithinRange_X = "lineBreakBeforeIndex:withinRange:";
		static readonly NativeHandle selLineBreakBeforeIndex_WithinRange_XHandle = Selector.GetHandle ("lineBreakBeforeIndex:withinRange:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLineBreakByHyphenatingBeforeIndex_WithinRange_X = "lineBreakByHyphenatingBeforeIndex:withinRange:";
		static readonly NativeHandle selLineBreakByHyphenatingBeforeIndex_WithinRange_XHandle = Selector.GetHandle ("lineBreakByHyphenatingBeforeIndex:withinRange:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLoadFromHTMLWithData_Options_CompletionHandler_X = "loadFromHTMLWithData:options:completionHandler:";
		static readonly NativeHandle selLoadFromHTMLWithData_Options_CompletionHandler_XHandle = Selector.GetHandle ("loadFromHTMLWithData:options:completionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLoadFromHTMLWithFileURL_Options_CompletionHandler_X = "loadFromHTMLWithFileURL:options:completionHandler:";
		static readonly NativeHandle selLoadFromHTMLWithFileURL_Options_CompletionHandler_XHandle = Selector.GetHandle ("loadFromHTMLWithFileURL:options:completionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLoadFromHTMLWithRequest_Options_CompletionHandler_X = "loadFromHTMLWithRequest:options:completionHandler:";
		static readonly NativeHandle selLoadFromHTMLWithRequest_Options_CompletionHandler_XHandle = Selector.GetHandle ("loadFromHTMLWithRequest:options:completionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLoadFromHTMLWithString_Options_CompletionHandler_X = "loadFromHTMLWithString:options:completionHandler:";
		static readonly NativeHandle selLoadFromHTMLWithString_Options_CompletionHandler_XHandle = Selector.GetHandle ("loadFromHTMLWithString:options:completionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMutableCopyWithZone_X = "mutableCopyWithZone:";
		static readonly NativeHandle selMutableCopyWithZone_XHandle = Selector.GetHandle ("mutableCopyWithZone:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selNextWordFromIndex_Forward_X = "nextWordFromIndex:forward:";
		static readonly NativeHandle selNextWordFromIndex_Forward_XHandle = Selector.GetHandle ("nextWordFromIndex:forward:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPasteboardPropertyListForType_X = "pasteboardPropertyListForType:";
		static readonly NativeHandle selPasteboardPropertyListForType_XHandle = Selector.GetHandle ("pasteboardPropertyListForType:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPrefersRTFDInRange_X = "prefersRTFDInRange:";
		static readonly NativeHandle selPrefersRTFDInRange_XHandle = Selector.GetHandle ("prefersRTFDInRange:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRangeOfTextBlock_AtIndex_X = "rangeOfTextBlock:atIndex:";
		static readonly NativeHandle selRangeOfTextBlock_AtIndex_XHandle = Selector.GetHandle ("rangeOfTextBlock:atIndex:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRangeOfTextList_AtIndex_X = "rangeOfTextList:atIndex:";
		static readonly NativeHandle selRangeOfTextList_AtIndex_XHandle = Selector.GetHandle ("rangeOfTextList:atIndex:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRangeOfTextTable_AtIndex_X = "rangeOfTextTable:atIndex:";
		static readonly NativeHandle selRangeOfTextTable_AtIndex_XHandle = Selector.GetHandle ("rangeOfTextTable:atIndex:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selReadableTypesForPasteboard_X = "readableTypesForPasteboard:";
		static readonly NativeHandle selReadableTypesForPasteboard_XHandle = Selector.GetHandle ("readableTypesForPasteboard:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selReadingOptionsForType_Pasteboard_X = "readingOptionsForType:pasteboard:";
		static readonly NativeHandle selReadingOptionsForType_Pasteboard_XHandle = Selector.GetHandle ("readingOptionsForType:pasteboard:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRulerAttributesInRange_X = "rulerAttributesInRange:";
		static readonly NativeHandle selRulerAttributesInRange_XHandle = Selector.GetHandle ("rulerAttributesInRange:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSizeX = "size";
		static readonly NativeHandle selSizeXHandle = Selector.GetHandle ("size");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selStringX = "string";
		static readonly NativeHandle selStringXHandle = Selector.GetHandle ("string");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selWritableTypesForPasteboard_X = "writableTypesForPasteboard:";
		static readonly NativeHandle selWritableTypesForPasteboard_XHandle = Selector.GetHandle ("writableTypesForPasteboard:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selWritingOptionsForType_Pasteboard_X = "writingOptionsForType:pasteboard:";
		static readonly NativeHandle selWritingOptionsForType_Pasteboard_XHandle = Selector.GetHandle ("writingOptionsForType:pasteboard:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("NSAttributedString");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		/// <summary>Creates a new <see cref="NSAttributedString" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public NSAttributedString () : base (NSObjectFlag.Empty)
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
		public NSAttributedString (NSCoder coder) : base (NSObjectFlag.Empty)
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
		protected NSAttributedString (NSObjectFlag t) : base (t)
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
		protected internal NSAttributedString (NativeHandle handle) : base (handle)
		{
		}

		[Export ("initWithString:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSAttributedString (string str)
			: base (NSObjectFlag.Empty)
		{
			if (str is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (str));
			var nsstr = CFString.CreateNative (str);
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selInitWithString_XHandle, nsstr), "initWithString:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selInitWithString_XHandle, nsstr), "initWithString:");
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsstr);
		}
		[Export ("initWithString:attributes:")]
		[EditorBrowsable (EditorBrowsableState.Never)]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSAttributedString (string str, NSDictionary? attributes)
			: base (NSObjectFlag.Empty)
		{
			if (str is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (str));
			var attributes__handle__ = attributes.GetHandle ();
			var nsstr = CFString.CreateNative (str);
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selInitWithString_Attributes_XHandle, nsstr, attributes__handle__), "initWithString:attributes:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selInitWithString_Attributes_XHandle, nsstr, attributes__handle__), "initWithString:attributes:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (attributes);
			CFString.ReleaseNative (nsstr);
		}
		[Export ("initWithAttributedString:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSAttributedString (NSAttributedString other)
			: base (NSObjectFlag.Empty)
		{
			var other__handle__ = other!.GetNonNullHandle (nameof (other));
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selInitWithAttributedString_XHandle, other__handle__), "initWithAttributedString:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selInitWithAttributedString_XHandle, other__handle__), "initWithAttributedString:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (other);
		}
		/// <param name="url">To be added.</param><param name="options"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><param name="resultDocumentAttributes">To be added.</param><param name="error">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("initWithURL:options:documentAttributes:error:")]
		[Obsolete ("Use the 'Create' method instead, because there's no way to return an error from a constructor.", false)]
		[EditorBrowsable (EditorBrowsableState.Never)]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NSAttributedString (NSUrl url, NSDictionary options, out NSDictionary resultDocumentAttributes, out NSError error)
			: base (NSObjectFlag.Empty)
		{
			var url__handle__ = url!.GetNonNullHandle (nameof (url));
			var options__handle__ = options!.GetNonNullHandle (nameof (options));
			NativeHandle resultDocumentAttributesValue = IntPtr.Zero;
			NativeHandle errorValue = IntPtr.Zero;
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_ref_NativeHandle_ref_NativeHandle (this.Handle, selInitWithURL_Options_DocumentAttributes_Error_XHandle, url__handle__, options__handle__, &resultDocumentAttributesValue, &errorValue), "initWithURL:options:documentAttributes:error:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_ref_NativeHandle_ref_NativeHandle (&__objc_super__, selInitWithURL_Options_DocumentAttributes_Error_XHandle, url__handle__, options__handle__, &resultDocumentAttributesValue, &errorValue), "initWithURL:options:documentAttributes:error:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (url);
			GC.KeepAlive (options);
			resultDocumentAttributes = Runtime.GetNSObject<NSDictionary> (resultDocumentAttributesValue)!;
			error = Runtime.GetNSObject<NSError> (errorValue)!;
		}
		/// <param name="data">To be added.</param><param name="options"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><param name="docAttributes">To be added.</param><param name="error">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("initWithData:options:documentAttributes:error:")]
		[Obsolete ("Use the 'Create' method instead, because there's no way to return an error from a constructor.", false)]
		[EditorBrowsable (EditorBrowsableState.Never)]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NSAttributedString (NSData data, NSDictionary options, out NSDictionary docAttributes, out NSError error)
			: base (NSObjectFlag.Empty)
		{
			var data__handle__ = data!.GetNonNullHandle (nameof (data));
			var options__handle__ = options!.GetNonNullHandle (nameof (options));
			NativeHandle docAttributesValue = IntPtr.Zero;
			NativeHandle errorValue = IntPtr.Zero;
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_ref_NativeHandle_ref_NativeHandle (this.Handle, selInitWithData_Options_DocumentAttributes_Error_XHandle, data__handle__, options__handle__, &docAttributesValue, &errorValue), "initWithData:options:documentAttributes:error:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_ref_NativeHandle_ref_NativeHandle (&__objc_super__, selInitWithData_Options_DocumentAttributes_Error_XHandle, data__handle__, options__handle__, &docAttributesValue, &errorValue), "initWithData:options:documentAttributes:error:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (data);
			GC.KeepAlive (options);
			docAttributes = Runtime.GetNSObject<NSDictionary> (docAttributesValue)!;
			error = Runtime.GetNSObject<NSError> (errorValue)!;
		}
		/// <param name="url">To be added.</param><param name="options">To be added.</param><param name="resultDocumentAttributes">To be added.</param><param name="error">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Obsolete ("Use the 'Create' method instead, because there's no way to return an error from a constructor.", false)]
		[EditorBrowsable (EditorBrowsableState.Never)]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NSAttributedString (NSUrl url, NSAttributedStringDocumentAttributes options, out NSDictionary resultDocumentAttributes, out NSError error)
			: this (url, options.GetDictionary ()!, out resultDocumentAttributes, out error)
		{
		}
		/// <param name="data">To be added.</param><param name="options">To be added.</param><param name="resultDocumentAttributes">To be added.</param><param name="error">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Obsolete ("Use the 'Create' method instead, because there's no way to return an error from a constructor.", false)]
		[EditorBrowsable (EditorBrowsableState.Never)]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NSAttributedString (NSData data, NSAttributedStringDocumentAttributes options, out NSDictionary resultDocumentAttributes, out NSError error)
			: this (data, options.GetDictionary ()!, out resultDocumentAttributes, out error)
		{
		}
		/// <param name="wordDocFormat">To be added.</param><param name="docAttributes">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Obsolete ("Use 'CreateWithDocFormat' instead.", false)]
		[EditorBrowsable (EditorBrowsableState.Never)]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NSAttributedString (NSData wordDocFormat, out NSDictionary docAttributes)
			: base (NSObjectFlag.Empty)
		{
			var wordDocFormat__handle__ = wordDocFormat!.GetNonNullHandle (nameof (wordDocFormat));
			NativeHandle docAttributesValue = IntPtr.Zero;
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_ref_NativeHandle (this.Handle, selInitWithDocFormat_DocumentAttributes_XHandle, wordDocFormat__handle__, &docAttributesValue), "initWithDocFormat:documentAttributes:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_ref_NativeHandle (&__objc_super__, selInitWithDocFormat_DocumentAttributes_XHandle, wordDocFormat__handle__, &docAttributesValue), "initWithDocFormat:documentAttributes:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (wordDocFormat);
			docAttributes = Runtime.GetNSObject<NSDictionary> (docAttributesValue)!;
		}
		/// <param name="htmlData">To be added.</param><param name="baseUrl">To be added.</param><param name="docAttributes">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Obsolete ("Use 'CreateWithHTML' instead.", false)]
		[EditorBrowsable (EditorBrowsableState.Never)]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NSAttributedString (NSData htmlData, NSUrl baseUrl, out NSDictionary docAttributes)
			: base (NSObjectFlag.Empty)
		{
			var htmlData__handle__ = htmlData!.GetNonNullHandle (nameof (htmlData));
			var baseUrl__handle__ = baseUrl!.GetNonNullHandle (nameof (baseUrl));
			NativeHandle docAttributesValue = IntPtr.Zero;
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_ref_NativeHandle (this.Handle, selInitWithHTML_BaseURL_DocumentAttributes_XHandle, htmlData__handle__, baseUrl__handle__, &docAttributesValue), "initWithHTML:baseURL:documentAttributes:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_ref_NativeHandle (&__objc_super__, selInitWithHTML_BaseURL_DocumentAttributes_XHandle, htmlData__handle__, baseUrl__handle__, &docAttributesValue), "initWithHTML:baseURL:documentAttributes:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (htmlData);
			GC.KeepAlive (baseUrl);
			docAttributes = Runtime.GetNSObject<NSDictionary> (docAttributesValue)!;
		}
		/// <param name="path">To be added.</param><param name="resultDocumentAttributes">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("initWithPath:documentAttributes:")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[ObsoletedOSPlatform ("macos10.11", "Use 'Create (NSUrl, NSDictionary, out NSDictionary, out NSError)' instead.")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NSAttributedString (string path, out NSDictionary resultDocumentAttributes)
			: base (NSObjectFlag.Empty)
		{
			if (path is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (path));
			NativeHandle resultDocumentAttributesValue = IntPtr.Zero;
			var nspath = CFString.CreateNative (path);
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_ref_NativeHandle (this.Handle, selInitWithPath_DocumentAttributes_XHandle, nspath, &resultDocumentAttributesValue), "initWithPath:documentAttributes:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_ref_NativeHandle (&__objc_super__, selInitWithPath_DocumentAttributes_XHandle, nspath, &resultDocumentAttributesValue), "initWithPath:documentAttributes:");
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nspath);
			resultDocumentAttributes = Runtime.GetNSObject<NSDictionary> (resultDocumentAttributesValue)!;
		}
		/// <param name="url">To be added.</param><param name="resultDocumentAttributes">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("initWithURL:documentAttributes:")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[ObsoletedOSPlatform ("macos10.11", "Use 'Create (NSUrl, NSDictionary, out NSDictionary, out NSError)' instead.")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NSAttributedString (NSUrl url, out NSDictionary resultDocumentAttributes)
			: base (NSObjectFlag.Empty)
		{
			var url__handle__ = url!.GetNonNullHandle (nameof (url));
			NativeHandle resultDocumentAttributesValue = IntPtr.Zero;
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_ref_NativeHandle (this.Handle, selInitWithURL_DocumentAttributes_XHandle, url__handle__, &resultDocumentAttributesValue), "initWithURL:documentAttributes:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_ref_NativeHandle (&__objc_super__, selInitWithURL_DocumentAttributes_XHandle, url__handle__, &resultDocumentAttributesValue), "initWithURL:documentAttributes:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (url);
			resultDocumentAttributes = Runtime.GetNSObject<NSDictionary> (resultDocumentAttributesValue)!;
		}
		/// <param name="data">To be added.</param><param name="options">To be added.</param><param name="resultDocumentAttributes">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[ObsoletedOSPlatform ("macos10.11", "Use 'CreateWithHTML (NSData, NSDictionary, out NSDictionary)' instead.")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NSAttributedString (NSData data, NSDictionary? options, out NSDictionary resultDocumentAttributes)
			: base (NSObjectFlag.Empty)
		{
			var data__handle__ = data!.GetNonNullHandle (nameof (data));
			var options__handle__ = options.GetHandle ();
			NativeHandle resultDocumentAttributesValue = IntPtr.Zero;
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_ref_NativeHandle (this.Handle, selInitWithHTML_Options_DocumentAttributes_XHandle, data__handle__, options__handle__, &resultDocumentAttributesValue), "initWithHTML:options:documentAttributes:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_ref_NativeHandle (&__objc_super__, selInitWithHTML_Options_DocumentAttributes_XHandle, data__handle__, options__handle__, &resultDocumentAttributesValue), "initWithHTML:options:documentAttributes:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (data);
			GC.KeepAlive (options);
			resultDocumentAttributes = Runtime.GetNSObject<NSDictionary> (resultDocumentAttributesValue)!;
		}
		/// <param name="data">To be added.</param><param name="options">To be added.</param><param name="resultDocumentAttributes">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[ObsoletedOSPlatform ("macos10.11", "Use 'CreateWithHTML (NSData, NSAttributedStringDocumentAttributes, out NSDictionary)' instead.")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NSAttributedString (NSData data, NSAttributedStringDocumentAttributes options, out NSDictionary resultDocumentAttributes)
			: this (data, options.GetDictionary (), out resultDocumentAttributes)
		{
		}
		/// <param name="wrapper">To be added.</param><param name="resultDocumentAttributes">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[ObsoletedOSPlatform ("macos10.11", "Use 'Create (NSFileWrapper, out NSDictionary)' instead.")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NSAttributedString (NSFileWrapper wrapper, out NSDictionary resultDocumentAttributes)
			: base (NSObjectFlag.Empty)
		{
			var wrapper__handle__ = wrapper!.GetNonNullHandle (nameof (wrapper));
			NativeHandle resultDocumentAttributesValue = IntPtr.Zero;
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_ref_NativeHandle (this.Handle, selInitWithRTFDFileWrapper_DocumentAttributes_XHandle, wrapper__handle__, &resultDocumentAttributesValue), "initWithRTFDFileWrapper:documentAttributes:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_ref_NativeHandle (&__objc_super__, selInitWithRTFDFileWrapper_DocumentAttributes_XHandle, wrapper__handle__, &resultDocumentAttributesValue), "initWithRTFDFileWrapper:documentAttributes:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (wrapper);
			resultDocumentAttributes = Runtime.GetNSObject<NSDictionary> (resultDocumentAttributesValue)!;
		}
		[Export ("initWithContentsOfMarkdownFileAtURL:options:baseURL:error:")]
		[Obsolete ("Use the 'Create' method instead, because there's no way to return an error from a constructor.", false)]
		[EditorBrowsable (EditorBrowsableState.Never)]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NSAttributedString (NSUrl markdownFile, NSAttributedStringMarkdownParsingOptions? options, NSUrl? baseUrl, out NSError? error)
			: base (NSObjectFlag.Empty)
		{
			var markdownFile__handle__ = markdownFile!.GetNonNullHandle (nameof (markdownFile));
			var options__handle__ = options.GetHandle ();
			var baseUrl__handle__ = baseUrl.GetHandle ();
			NativeHandle errorValue = IntPtr.Zero;
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_ref_NativeHandle (this.Handle, selInitWithContentsOfMarkdownFileAtURL_Options_BaseURL_Error_XHandle, markdownFile__handle__, options__handle__, baseUrl__handle__, &errorValue), "initWithContentsOfMarkdownFileAtURL:options:baseURL:error:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle_ref_NativeHandle (&__objc_super__, selInitWithContentsOfMarkdownFileAtURL_Options_BaseURL_Error_XHandle, markdownFile__handle__, options__handle__, baseUrl__handle__, &errorValue), "initWithContentsOfMarkdownFileAtURL:options:baseURL:error:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (markdownFile);
			GC.KeepAlive (options);
			GC.KeepAlive (baseUrl);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
		}
		[Export ("initWithMarkdown:options:baseURL:error:")]
		[Obsolete ("Use the 'Create' method instead, because there's no way to return an error from a constructor.", false)]
		[EditorBrowsable (EditorBrowsableState.Never)]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NSAttributedString (NSData markdown, NSAttributedStringMarkdownParsingOptions? options, NSUrl? baseUrl, out NSError? error)
			: base (NSObjectFlag.Empty)
		{
			var markdown__handle__ = markdown!.GetNonNullHandle (nameof (markdown));
			var options__handle__ = options.GetHandle ();
			var baseUrl__handle__ = baseUrl.GetHandle ();
			NativeHandle errorValue = IntPtr.Zero;
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_ref_NativeHandle (this.Handle, selInitWithMarkdown_Options_BaseURL_Error_XHandle, markdown__handle__, options__handle__, baseUrl__handle__, &errorValue), "initWithMarkdown:options:baseURL:error:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle_ref_NativeHandle (&__objc_super__, selInitWithMarkdown_Options_BaseURL_Error_XHandle, markdown__handle__, options__handle__, baseUrl__handle__, &errorValue), "initWithMarkdown:options:baseURL:error:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (markdown);
			GC.KeepAlive (options);
			GC.KeepAlive (baseUrl);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
		}
		[Export ("initWithMarkdownString:options:baseURL:error:")]
		[Obsolete ("Use the 'Create' method instead, because there's no way to return an error from a constructor.", false)]
		[EditorBrowsable (EditorBrowsableState.Never)]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NSAttributedString (string markdownString, NSAttributedStringMarkdownParsingOptions? options, NSUrl? baseUrl, out NSError? error)
			: base (NSObjectFlag.Empty)
		{
			if (markdownString is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (markdownString));
			var options__handle__ = options.GetHandle ();
			var baseUrl__handle__ = baseUrl.GetHandle ();
			NativeHandle errorValue = IntPtr.Zero;
			var nsmarkdownString = CFString.CreateNative (markdownString);
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_ref_NativeHandle (this.Handle, selInitWithMarkdownString_Options_BaseURL_Error_XHandle, nsmarkdownString, options__handle__, baseUrl__handle__, &errorValue), "initWithMarkdownString:options:baseURL:error:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle_ref_NativeHandle (&__objc_super__, selInitWithMarkdownString_Options_BaseURL_Error_XHandle, nsmarkdownString, options__handle__, baseUrl__handle__, &errorValue), "initWithMarkdownString:options:baseURL:error:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (options);
			GC.KeepAlive (baseUrl);
			CFString.ReleaseNative (nsmarkdownString);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
		}
		/// <param name="size">To be added.</param><param name="options">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("boundingRectWithSize:options:")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGRect BoundingRectWithSize (CGSize size, NSStringDrawingOptions options)
		{
			CGRect ret;
			if (IsDirectBinding) {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_CGSize_UIntPtr (this.Handle, selBoundingRectWithSize_Options_XHandle, size, (UIntPtr) (ulong) options);
				} else {
					ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret_CGSize_UIntPtr (this.Handle, selBoundingRectWithSize_Options_XHandle, size, (UIntPtr) (ulong) options);
				}
			} else {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper_CGSize_UIntPtr (&__objc_super__, selBoundingRectWithSize_Options_XHandle, size, (UIntPtr) (ulong) options);
						GC.KeepAlive (this);
					}
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper_stret_CGSize_UIntPtr (&__objc_super__, selBoundingRectWithSize_Options_XHandle, size, (UIntPtr) (ulong) options);
						GC.KeepAlive (this);
					}
				}
			}
			return ret!;
		}
		/// <param name="range">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("containsAttachmentsInRange:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ContainsAttachmentsInRange (NSRange range)
		{
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NSRange (this.Handle, selContainsAttachmentsInRange_XHandle, range);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NSRange (&__objc_super__, selContainsAttachmentsInRange_XHandle, range);
					GC.KeepAlive (this);
				}
			}
			return ret != 0;
		}
		/// <param name="zone">Developers should pass <see langword="null" />.  Memory zones are no longer used.</param><summary>Performs a copy of the underlying Objective-C object.</summary><returns>The newly-allocated object.</returns><remarks><para>This method performs a "shallow copy" of <see langword="this" />. If this object contains references to external objects, the new object will contain references to the same object.</para></remarks>
		[Export ("copyWithZone:")]
		[return: ReleaseAttribute ()]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject Copy (NSZone? zone)
		{
			var zone__handle__ = zone.GetHandle ();
			NSObject? ret;
			if (IsDirectBinding) {
				ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selCopyWithZone_XHandle, zone__handle__), true)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selCopyWithZone_XHandle, zone__handle__), true)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (zone);
			return ret!;
		}
		[Export ("attributedStringWithAdaptiveImageGlyph:attributes:")]
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSAttributedString Create (global::AppKit.NSAdaptiveImageGlyph adaptiveImageGlyph, NSDictionary<NSString, NSObject> attributes)
		{
			var adaptiveImageGlyph__handle__ = adaptiveImageGlyph!.GetNonNullHandle (nameof (adaptiveImageGlyph));
			var attributes__handle__ = attributes!.GetNonNullHandle (nameof (attributes));
			NSAttributedString? ret;
			ret =  Runtime.GetNSObject<NSAttributedString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (class_ptr, selAttributedStringWithAdaptiveImageGlyph_Attributes_XHandle, adaptiveImageGlyph__handle__, attributes__handle__), false)!;
			GC.KeepAlive (adaptiveImageGlyph);
			GC.KeepAlive (attributes);
			return ret!;
		}
		[Export ("doubleClickAtIndex:")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSRange DoubleClick (nuint index)
		{
			NSRange ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.NSRange_objc_msgSend_UIntPtr (this.Handle, selDoubleClickAtIndex_XHandle, index);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.NSRange_objc_msgSendSuper_UIntPtr (&__objc_super__, selDoubleClickAtIndex_XHandle, index);
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		/// <param name="rect">To be added.</param><param name="options">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("drawWithRect:options:")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DrawString (CGRect rect, NSStringDrawingOptions options)
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_CGRect_UIntPtr (this.Handle, selDrawWithRect_Options_XHandle, rect, (UIntPtr) (ulong) options);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_CGRect_UIntPtr (&__objc_super__, selDrawWithRect_Options_XHandle, rect, (UIntPtr) (ulong) options);
					GC.KeepAlive (this);
				}
			}
		}
		/// <param name="point">To be added.</param><summary>Draws the string at the specified point.</summary><remarks>To be added.</remarks>
		[Export ("drawAtPoint:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DrawString (CGPoint point)
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_CGPoint (this.Handle, selDrawAtPoint_XHandle, point);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_CGPoint (&__objc_super__, selDrawAtPoint_XHandle, point);
					GC.KeepAlive (this);
				}
			}
		}
		/// <param name="rect">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("drawInRect:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DrawString (CGRect rect)
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_CGRect (this.Handle, selDrawInRect_XHandle, rect);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_CGRect (&__objc_super__, selDrawInRect_XHandle, rect);
					GC.KeepAlive (this);
				}
			}
		}
		/// <summary>Encodes the state of the object using the provided encoder.</summary><param name="encoder">The encoder object where the state of the object will be stored</param><remarks><para>This method is part of the <see cref="T:Foundation.INSCoding" /> protocol and is used by applications to preserve the state of the object into an archive.</para><para>Developers will typically create an <see cref="T:Foundation.NSKeyedArchiver" /> and then invoke the <see cref="M:Foundation.NSKeyedArchiver.ArchiveRootObjectToFile(Foundation.NSObject,System.String)" /> method which will call into this method.</para><para>If developers want to allow their object to be archived, they should override this method and store their state in using the provided <paramref name="encoder" /> parameter. In addition, developers should also implement a constructor that takes an NSCoder argument and is exported with <c>[Export ("initWithCoder:")]</c>.</para><example><code lang="csharp lang-csharp"><![CDATA[public void override EncodeTo (NSCoder coder) {
		/// coder.Encode (1, key: "version");
		/// coder.Encode (userName, key: "userName");
		/// coder.Encode (hostName, key: "hostName");]]></code></example></remarks>
		[Export ("encodeWithCoder:")]
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
		[Export ("enumerateAttribute:inRange:options:usingBlock:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void EnumerateAttribute (NSString attributeName, NSRange inRange, NSAttributedStringEnumeration options, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDNSAttributedStringCallback))]NSAttributedStringCallback callback)
		{
			var attributeName__handle__ = attributeName!.GetNonNullHandle (nameof (attributeName));
			if (callback is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (callback));
			using var block_callback = Trampolines.SDNSAttributedStringCallback.CreateBlock (callback);
			BlockLiteral *block_ptr_callback = &block_callback;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NSRange_UIntPtr_NativeHandle (this.Handle, selEnumerateAttribute_InRange_Options_UsingBlock_XHandle, attributeName__handle__, inRange, (UIntPtr) (ulong) options, (IntPtr) block_ptr_callback);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NSRange_UIntPtr_NativeHandle (&__objc_super__, selEnumerateAttribute_InRange_Options_UsingBlock_XHandle, attributeName__handle__, inRange, (UIntPtr) (ulong) options, (IntPtr) block_ptr_callback);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (attributeName);
		}
		[Export ("enumerateAttributesInRange:options:usingBlock:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void EnumerateAttributes (NSRange range, NSAttributedStringEnumeration options, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDNSAttributedRangeCallback))]NSAttributedRangeCallback callback)
		{
			if (callback is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (callback));
			using var block_callback = Trampolines.SDNSAttributedRangeCallback.CreateBlock (callback);
			BlockLiteral *block_ptr_callback = &block_callback;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NSRange_UIntPtr_NativeHandle (this.Handle, selEnumerateAttributesInRange_Options_UsingBlock_XHandle, range, (UIntPtr) (ulong) options, (IntPtr) block_ptr_callback);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NSRange_UIntPtr_NativeHandle (&__objc_super__, selEnumerateAttributesInRange_Options_UsingBlock_XHandle, range, (UIntPtr) (ulong) options, (IntPtr) block_ptr_callback);
					GC.KeepAlive (this);
				}
			}
		}
		/// <param name="attachment">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("attributedStringWithAttachment:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSAttributedString FromAttachment (global::AppKit.NSTextAttachment attachment)
		{
			var attachment__handle__ = attachment!.GetNonNullHandle (nameof (attachment));
			NSAttributedString? ret;
			ret =  Runtime.GetNSObject<NSAttributedString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, selAttributedStringWithAttachment_XHandle, attachment__handle__), false)!;
			GC.KeepAlive (attachment);
			return ret!;
		}
		[Export ("attributedStringWithAttachment:attributes:")]
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSAttributedString FromAttachment (global::AppKit.NSTextAttachment attachment, NSDictionary<NSString, NSObject> attributes)
		{
			var attachment__handle__ = attachment!.GetNonNullHandle (nameof (attachment));
			var attributes__handle__ = attributes!.GetNonNullHandle (nameof (attributes));
			NSAttributedString? ret;
			ret =  Runtime.GetNSObject<NSAttributedString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (class_ptr, selAttributedStringWithAttachment_Attributes_XHandle, attachment__handle__, attributes__handle__), false)!;
			GC.KeepAlive (attachment);
			GC.KeepAlive (attributes);
			return ret!;
		}
		/// <param name="attribute">To be added.</param><param name="location">To be added.</param><param name="effectiveRange">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("attribute:atIndex:effectiveRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual NSObject GetAttribute (string attribute, nint location, out NSRange effectiveRange)
		{
			if (attribute is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (attribute));
			fixed (NSRange* effectiveRange__pointer = &effectiveRange) {
			var nsattribute = CFString.CreateNative (attribute);
			effectiveRange = default;
			NSObject? ret;
			if (IsDirectBinding) {
				ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_IntPtr_out_NSRange (this.Handle, selAttribute_AtIndex_EffectiveRange_XHandle, nsattribute, location, effectiveRange__pointer), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_IntPtr_out_NSRange (&__objc_super__, selAttribute_AtIndex_EffectiveRange_XHandle, nsattribute, location, effectiveRange__pointer), false)!;
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsattribute);
			return ret!;
			}
		}
		/// <param name="attribute">To be added.</param><param name="location">To be added.</param><param name="longestEffectiveRange">To be added.</param><param name="rangeLimit">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("attribute:atIndex:longestEffectiveRange:inRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual NSObject GetAttribute (string attribute, nint location, out NSRange longestEffectiveRange, NSRange rangeLimit)
		{
			if (attribute is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (attribute));
			fixed (NSRange* longestEffectiveRange__pointer = &longestEffectiveRange) {
			var nsattribute = CFString.CreateNative (attribute);
			longestEffectiveRange = default;
			NSObject? ret;
			if (IsDirectBinding) {
				ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_IntPtr_out_NSRange_NSRange (this.Handle, selAttribute_AtIndex_LongestEffectiveRange_InRange_XHandle, nsattribute, location, longestEffectiveRange__pointer, rangeLimit), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_IntPtr_out_NSRange_NSRange (&__objc_super__, selAttribute_AtIndex_LongestEffectiveRange_InRange_XHandle, nsattribute, location, longestEffectiveRange__pointer, rangeLimit), false)!;
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsattribute);
			return ret!;
			}
		}
		/// <param name="location">To be added.</param><param name="longestEffectiveRange">To be added.</param><param name="rangeLimit">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("attributesAtIndex:longestEffectiveRange:inRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual NSDictionary GetAttributes (nint location, out NSRange longestEffectiveRange, NSRange rangeLimit)
		{
			fixed (NSRange* longestEffectiveRange__pointer = &longestEffectiveRange) {
			longestEffectiveRange = default;
			NSDictionary ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSDictionary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_IntPtr_out_NSRange_NSRange (this.Handle, selAttributesAtIndex_LongestEffectiveRange_InRange_XHandle, location, longestEffectiveRange__pointer, rangeLimit), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSDictionary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_IntPtr_out_NSRange_NSRange (&__objc_super__, selAttributesAtIndex_LongestEffectiveRange_InRange_XHandle, location, longestEffectiveRange__pointer, rangeLimit), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
			}
		}
		[Export ("dataFromRange:documentAttributes:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual NSData? GetData (NSRange range, NSDictionary options, out NSError error)
		{
			var options__handle__ = options!.GetNonNullHandle (nameof (options));
			NativeHandle errorValue = IntPtr.Zero;
			NSData? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSData> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NSRange_NativeHandle_ref_NativeHandle (this.Handle, selDataFromRange_DocumentAttributes_Error_XHandle, range, options__handle__, &errorValue), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSData> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NSRange_NativeHandle_ref_NativeHandle (&__objc_super__, selDataFromRange_DocumentAttributes_Error_XHandle, range, options__handle__, &errorValue), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (options);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		/// <param name="range">To be added.</param><param name="options">To be added.</param><param name="error">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NSData? GetData (NSRange range, NSAttributedStringDocumentAttributes options, out NSError error)
		{
			return this.GetData (range, options.GetDictionary ()!, out error);
		}
		/// <param name="range">To be added.</param><param name="options">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("docFormatFromRange:documentAttributes:")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSData GetDocFormat (NSRange range, NSDictionary? options)
		{
			var options__handle__ = options.GetHandle ();
			NSData? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSData> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NSRange_NativeHandle (this.Handle, selDocFormatFromRange_DocumentAttributes_XHandle, range, options__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSData> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NSRange_NativeHandle (&__objc_super__, selDocFormatFromRange_DocumentAttributes_XHandle, range, options__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (options);
			return ret!;
		}
		/// <param name="range">To be added.</param><param name="options">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSData GetDocFormat (NSRange range, NSAttributedStringDocumentAttributes options)
		{
			return this.GetDocFormat (range, options.GetDictionary ());
		}
		[Export ("fileWrapperFromRange:documentAttributes:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual NSFileWrapper? GetFileWrapper (NSRange range, NSDictionary options, out NSError error)
		{
			var options__handle__ = options!.GetNonNullHandle (nameof (options));
			NativeHandle errorValue = IntPtr.Zero;
			NSFileWrapper? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSFileWrapper> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NSRange_NativeHandle_ref_NativeHandle (this.Handle, selFileWrapperFromRange_DocumentAttributes_Error_XHandle, range, options__handle__, &errorValue), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSFileWrapper> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NSRange_NativeHandle_ref_NativeHandle (&__objc_super__, selFileWrapperFromRange_DocumentAttributes_Error_XHandle, range, options__handle__, &errorValue), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (options);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		/// <param name="range">To be added.</param><param name="options">To be added.</param><param name="error">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NSFileWrapper? GetFileWrapper (NSRange range, NSAttributedStringDocumentAttributes options, out NSError error)
		{
			return this.GetFileWrapper (range, options.GetDictionary ()!, out error);
		}
		/// <param name="range">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("fontAttributesInRange:")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDictionary GetFontAttributes (NSRange range)
		{
			NSDictionary ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSDictionary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NSRange (this.Handle, selFontAttributesInRange_XHandle, range), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSDictionary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NSRange (&__objc_super__, selFontAttributesInRange_XHandle, range), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("itemNumberInTextList:atIndex:")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint GetItemNumber (global::AppKit.NSTextList textList, nuint index)
		{
			var textList__handle__ = textList!.GetNonNullHandle (nameof (textList));
			nint ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_NativeHandle_UIntPtr (this.Handle, selItemNumberInTextList_AtIndex_XHandle, textList__handle__, index);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_NativeHandle_UIntPtr (&__objc_super__, selItemNumberInTextList_AtIndex_XHandle, textList__handle__, index);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (textList);
			return ret!;
		}
		[Export ("lineBreakBeforeIndex:withinRange:")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nuint GetLineBreak (nuint beforeIndex, NSRange aRange)
		{
			nuint ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend_UIntPtr_NSRange (this.Handle, selLineBreakBeforeIndex_WithinRange_XHandle, beforeIndex, aRange);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper_UIntPtr_NSRange (&__objc_super__, selLineBreakBeforeIndex_WithinRange_XHandle, beforeIndex, aRange);
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("lineBreakByHyphenatingBeforeIndex:withinRange:")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nuint GetLineBreakByHyphenating (nuint beforeIndex, NSRange aRange)
		{
			nuint ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend_UIntPtr_NSRange (this.Handle, selLineBreakByHyphenatingBeforeIndex_WithinRange_XHandle, beforeIndex, aRange);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper_UIntPtr_NSRange (&__objc_super__, selLineBreakByHyphenatingBeforeIndex_WithinRange_XHandle, beforeIndex, aRange);
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("nextWordFromIndex:forward:")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nuint GetNextWord (nuint fromIndex, bool isForward)
		{
			nuint ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend_UIntPtr_bool (this.Handle, selNextWordFromIndex_Forward_XHandle, fromIndex, isForward ? (byte) 1 : (byte) 0);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper_UIntPtr_bool (&__objc_super__, selNextWordFromIndex_Forward_XHandle, fromIndex, isForward ? (byte) 1 : (byte) 0);
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		/// <param name="type">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("pasteboardPropertyListForType:")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject GetPasteboardPropertyListForType (string type)
		{
			if (type is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (type));
			var nstype = CFString.CreateNative (type);
			NSObject? ret;
			if (IsDirectBinding) {
				ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selPasteboardPropertyListForType_XHandle, nstype), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selPasteboardPropertyListForType_XHandle, nstype), false)!;
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nstype);
			return ret!;
		}
		[Export ("rangeOfTextBlock:atIndex:")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSRange GetRange (global::AppKit.NSTextBlock textBlock, nuint index)
		{
			var textBlock__handle__ = textBlock!.GetNonNullHandle (nameof (textBlock));
			NSRange ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.NSRange_objc_msgSend_NativeHandle_UIntPtr (this.Handle, selRangeOfTextBlock_AtIndex_XHandle, textBlock__handle__, index);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.NSRange_objc_msgSendSuper_NativeHandle_UIntPtr (&__objc_super__, selRangeOfTextBlock_AtIndex_XHandle, textBlock__handle__, index);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (textBlock);
			return ret!;
		}
		[Export ("rangeOfTextTable:atIndex:")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSRange GetRange (global::AppKit.NSTextTable textTable, nuint index)
		{
			var textTable__handle__ = textTable!.GetNonNullHandle (nameof (textTable));
			NSRange ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.NSRange_objc_msgSend_NativeHandle_UIntPtr (this.Handle, selRangeOfTextTable_AtIndex_XHandle, textTable__handle__, index);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.NSRange_objc_msgSendSuper_NativeHandle_UIntPtr (&__objc_super__, selRangeOfTextTable_AtIndex_XHandle, textTable__handle__, index);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (textTable);
			return ret!;
		}
		[Export ("rangeOfTextList:atIndex:")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSRange GetRange (global::AppKit.NSTextList textList, nuint index)
		{
			var textList__handle__ = textList!.GetNonNullHandle (nameof (textList));
			NSRange ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.NSRange_objc_msgSend_NativeHandle_UIntPtr (this.Handle, selRangeOfTextList_AtIndex_XHandle, textList__handle__, index);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.NSRange_objc_msgSendSuper_NativeHandle_UIntPtr (&__objc_super__, selRangeOfTextList_AtIndex_XHandle, textList__handle__, index);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (textList);
			return ret!;
		}
		/// <param name="pasteboard">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("readableTypesForPasteboard:")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string[] GetReadableTypesForPasteboard (global::AppKit.NSPasteboard pasteboard)
		{
			var pasteboard__handle__ = pasteboard!.GetNonNullHandle (nameof (pasteboard));
			string[]? ret;
			ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, selReadableTypesForPasteboard_XHandle, pasteboard__handle__), false)!;
			GC.KeepAlive (pasteboard);
			return ret!;
		}
		/// <param name="type">To be added.</param><param name="pasteboard">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("readingOptionsForType:pasteboard:")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static global::AppKit.NSPasteboardReadingOptions GetReadingOptionsForType (string type, global::AppKit.NSPasteboard pasteboard)
		{
			if (type is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (type));
			var pasteboard__handle__ = pasteboard!.GetNonNullHandle (nameof (pasteboard));
			var nstype = CFString.CreateNative (type);
			global::AppKit.NSPasteboardReadingOptions ret;
			ret = (NSPasteboardReadingOptions) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend_NativeHandle_NativeHandle (class_ptr, selReadingOptionsForType_Pasteboard_XHandle, nstype, pasteboard__handle__);
			GC.KeepAlive (pasteboard);
			CFString.ReleaseNative (nstype);
			return ret!;
		}
		/// <param name="range">To be added.</param><param name="options">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("RTFFromRange:documentAttributes:")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSData GetRtf (NSRange range, NSDictionary? options)
		{
			var options__handle__ = options.GetHandle ();
			NSData? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSData> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NSRange_NativeHandle (this.Handle, selRTFFromRange_DocumentAttributes_XHandle, range, options__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSData> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NSRange_NativeHandle (&__objc_super__, selRTFFromRange_DocumentAttributes_XHandle, range, options__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (options);
			return ret!;
		}
		/// <param name="range">To be added.</param><param name="options">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSData GetRtf (NSRange range, NSAttributedStringDocumentAttributes options)
		{
			return this.GetRtf (range, options.GetDictionary ());
		}
		/// <param name="range">To be added.</param><param name="options">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("RTFDFromRange:documentAttributes:")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSData GetRtfd (NSRange range, NSDictionary? options)
		{
			var options__handle__ = options.GetHandle ();
			NSData? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSData> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NSRange_NativeHandle (this.Handle, selRTFDFromRange_DocumentAttributes_XHandle, range, options__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSData> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NSRange_NativeHandle (&__objc_super__, selRTFDFromRange_DocumentAttributes_XHandle, range, options__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (options);
			return ret!;
		}
		/// <param name="range">To be added.</param><param name="options">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSData GetRtfd (NSRange range, NSAttributedStringDocumentAttributes options)
		{
			return this.GetRtfd (range, options.GetDictionary ());
		}
		/// <param name="range">To be added.</param><param name="options">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("RTFDFileWrapperFromRange:documentAttributes:")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSFileWrapper GetRtfdFileWrapper (NSRange range, NSDictionary? options)
		{
			var options__handle__ = options.GetHandle ();
			NSFileWrapper? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSFileWrapper> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NSRange_NativeHandle (this.Handle, selRTFDFileWrapperFromRange_DocumentAttributes_XHandle, range, options__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSFileWrapper> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NSRange_NativeHandle (&__objc_super__, selRTFDFileWrapperFromRange_DocumentAttributes_XHandle, range, options__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (options);
			return ret!;
		}
		/// <param name="range">To be added.</param><param name="options">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSFileWrapper GetRtfdFileWrapper (NSRange range, NSAttributedStringDocumentAttributes options)
		{
			return this.GetRtfdFileWrapper (range, options.GetDictionary ());
		}
		/// <param name="range">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("rulerAttributesInRange:")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDictionary GetRulerAttributes (NSRange range)
		{
			NSDictionary ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSDictionary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NSRange (this.Handle, selRulerAttributesInRange_XHandle, range), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSDictionary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NSRange (&__objc_super__, selRulerAttributesInRange_XHandle, range), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("URLAtIndex:effectiveRange:")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[ObsoletedOSPlatform ("macos10.11", "Use 'NSDataDetector' instead.")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual NSUrl GetUrl (nuint index, out NSRange effectiveRange)
		{
			fixed (NSRange* effectiveRange__pointer = &effectiveRange) {
			effectiveRange = default;
			NSUrl ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSUrl> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UIntPtr_out_NSRange (this.Handle, selURLAtIndex_EffectiveRange_XHandle, index, effectiveRange__pointer), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSUrl> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_UIntPtr_out_NSRange (&__objc_super__, selURLAtIndex_EffectiveRange_XHandle, index, effectiveRange__pointer), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
			}
		}
		/// <param name="pasteboard">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("writableTypesForPasteboard:")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string[] GetWritableTypesForPasteboard (global::AppKit.NSPasteboard pasteboard)
		{
			var pasteboard__handle__ = pasteboard!.GetNonNullHandle (nameof (pasteboard));
			string[]? ret;
			if (IsDirectBinding) {
				ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selWritableTypesForPasteboard_XHandle, pasteboard__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selWritableTypesForPasteboard_XHandle, pasteboard__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (pasteboard);
			return ret!;
		}
		/// <param name="type">To be added.</param><param name="pasteboard">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("writingOptionsForType:pasteboard:")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::AppKit.NSPasteboardWritingOptions GetWritingOptionsForType (string type, global::AppKit.NSPasteboard pasteboard)
		{
			if (type is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (type));
			var pasteboard__handle__ = pasteboard!.GetNonNullHandle (nameof (pasteboard));
			var nstype = CFString.CreateNative (type);
			global::AppKit.NSPasteboardWritingOptions ret;
			if (IsDirectBinding) {
				ret = (NSPasteboardWritingOptions) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selWritingOptionsForType_Pasteboard_XHandle, nstype, pasteboard__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = (NSPasteboardWritingOptions) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selWritingOptionsForType_Pasteboard_XHandle, nstype, pasteboard__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (pasteboard);
			CFString.ReleaseNative (nstype);
			return ret!;
		}
		[Export ("isEqualToAttributedString:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool IsEqual (NSAttributedString other)
		{
			var other__handle__ = other!.GetNonNullHandle (nameof (other));
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (this.Handle, selIsEqualToAttributedString_XHandle, other__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle (&__objc_super__, selIsEqualToAttributedString_XHandle, other__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (other);
			return ret != 0;
		}
		[Export ("loadFromHTMLWithRequest:options:completionHandler:")]
		[EditorBrowsable (EditorBrowsableState.Never)]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void LoadFromHtml (NSUrlRequest request, NSDictionary options, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDNSAttributedStringCompletionHandler))]NSAttributedStringCompletionHandler completionHandler)
		{
			var request__handle__ = request!.GetNonNullHandle (nameof (request));
			var options__handle__ = options!.GetNonNullHandle (nameof (options));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDNSAttributedStringCompletionHandler.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			GC.KeepAlive (WebKit.WKContentMode.Recommended); // no-op to ensure WebKit.framework is loaded into memory
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (class_ptr, selLoadFromHTMLWithRequest_Options_CompletionHandler_XHandle, request__handle__, options__handle__, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (request);
			GC.KeepAlive (options);
		}
		[EditorBrowsable (EditorBrowsableState.Never)]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Task<NSLoadFromHtmlResult> LoadFromHtmlAsync (NSUrlRequest request, NSDictionary options)
		{
			var tcs = new TaskCompletionSource<NSLoadFromHtmlResult> ();
			LoadFromHtml(request, options, (attributedString_, attributes_, error_) => {
				if (error_ is not null)
					tcs.SetException (new NSErrorException(error_));
				else
					tcs.SetResult (new NSLoadFromHtmlResult (attributedString_!, attributes_!));
			});
			return tcs.Task;
		}
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void LoadFromHtml (NSUrlRequest request, NSAttributedStringDocumentAttributes options, NSAttributedStringCompletionHandler completionHandler)
		{
			LoadFromHtml (request, options.GetDictionary ()!, completionHandler);
		}
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Task<NSLoadFromHtmlResult> LoadFromHtmlAsync (NSUrlRequest request, NSAttributedStringDocumentAttributes options)
		{
			var tcs = new TaskCompletionSource<NSLoadFromHtmlResult> ();
			LoadFromHtml(request, options, (attributedString_, attributes_, error_) => {
				if (error_ is not null)
					tcs.SetException (new NSErrorException(error_));
				else
					tcs.SetResult (new NSLoadFromHtmlResult (attributedString_!, attributes_!));
			});
			return tcs.Task;
		}
		[Export ("loadFromHTMLWithFileURL:options:completionHandler:")]
		[EditorBrowsable (EditorBrowsableState.Never)]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void LoadFromHtml (NSUrl fileUrl, NSDictionary options, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDNSAttributedStringCompletionHandler))]NSAttributedStringCompletionHandler completionHandler)
		{
			var fileUrl__handle__ = fileUrl!.GetNonNullHandle (nameof (fileUrl));
			var options__handle__ = options!.GetNonNullHandle (nameof (options));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDNSAttributedStringCompletionHandler.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			GC.KeepAlive (WebKit.WKContentMode.Recommended); // no-op to ensure WebKit.framework is loaded into memory
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (class_ptr, selLoadFromHTMLWithFileURL_Options_CompletionHandler_XHandle, fileUrl__handle__, options__handle__, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (fileUrl);
			GC.KeepAlive (options);
		}
		[EditorBrowsable (EditorBrowsableState.Never)]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Task<NSLoadFromHtmlResult> LoadFromHtmlAsync (NSUrl fileUrl, NSDictionary options)
		{
			var tcs = new TaskCompletionSource<NSLoadFromHtmlResult> ();
			LoadFromHtml(fileUrl, options, (attributedString_, attributes_, error_) => {
				if (error_ is not null)
					tcs.SetException (new NSErrorException(error_));
				else
					tcs.SetResult (new NSLoadFromHtmlResult (attributedString_!, attributes_!));
			});
			return tcs.Task;
		}
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void LoadFromHtml (NSUrl fileUrl, NSAttributedStringDocumentAttributes options, NSAttributedStringCompletionHandler completionHandler)
		{
			LoadFromHtml (fileUrl, options.GetDictionary ()!, completionHandler);
		}
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Task<NSLoadFromHtmlResult> LoadFromHtmlAsync (NSUrl fileUrl, NSAttributedStringDocumentAttributes options)
		{
			var tcs = new TaskCompletionSource<NSLoadFromHtmlResult> ();
			LoadFromHtml(fileUrl, options, (attributedString_, attributes_, error_) => {
				if (error_ is not null)
					tcs.SetException (new NSErrorException(error_));
				else
					tcs.SetResult (new NSLoadFromHtmlResult (attributedString_!, attributes_!));
			});
			return tcs.Task;
		}
		[Export ("loadFromHTMLWithString:options:completionHandler:")]
		[EditorBrowsable (EditorBrowsableState.Never)]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void LoadFromHtml (string @string, NSDictionary options, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDNSAttributedStringCompletionHandler))]NSAttributedStringCompletionHandler completionHandler)
		{
			if (@string is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (@string));
			var options__handle__ = options!.GetNonNullHandle (nameof (options));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			var nsstring = CFString.CreateNative (@string);
			using var block_completionHandler = Trampolines.SDNSAttributedStringCompletionHandler.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			GC.KeepAlive (WebKit.WKContentMode.Recommended); // no-op to ensure WebKit.framework is loaded into memory
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (class_ptr, selLoadFromHTMLWithString_Options_CompletionHandler_XHandle, nsstring, options__handle__, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (options);
			CFString.ReleaseNative (nsstring);
		}
		[EditorBrowsable (EditorBrowsableState.Never)]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Task<NSLoadFromHtmlResult> LoadFromHtmlAsync (string @string, NSDictionary options)
		{
			var tcs = new TaskCompletionSource<NSLoadFromHtmlResult> ();
			LoadFromHtml(@string, options, (attributedString_, attributes_, error_) => {
				if (error_ is not null)
					tcs.SetException (new NSErrorException(error_));
				else
					tcs.SetResult (new NSLoadFromHtmlResult (attributedString_!, attributes_!));
			});
			return tcs.Task;
		}
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void LoadFromHtml (string @string, NSAttributedStringDocumentAttributes options, NSAttributedStringCompletionHandler completionHandler)
		{
			LoadFromHtml (@string, options.GetDictionary ()!, completionHandler);
		}
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Task<NSLoadFromHtmlResult> LoadFromHtmlAsync (string @string, NSAttributedStringDocumentAttributes options)
		{
			var tcs = new TaskCompletionSource<NSLoadFromHtmlResult> ();
			LoadFromHtml(@string, options, (attributedString_, attributes_, error_) => {
				if (error_ is not null)
					tcs.SetException (new NSErrorException(error_));
				else
					tcs.SetResult (new NSLoadFromHtmlResult (attributedString_!, attributes_!));
			});
			return tcs.Task;
		}
		[Export ("loadFromHTMLWithData:options:completionHandler:")]
		[EditorBrowsable (EditorBrowsableState.Never)]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void LoadFromHtml (NSData data, NSDictionary options, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDNSAttributedStringCompletionHandler))]NSAttributedStringCompletionHandler completionHandler)
		{
			var data__handle__ = data!.GetNonNullHandle (nameof (data));
			var options__handle__ = options!.GetNonNullHandle (nameof (options));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDNSAttributedStringCompletionHandler.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			GC.KeepAlive (WebKit.WKContentMode.Recommended); // no-op to ensure WebKit.framework is loaded into memory
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (class_ptr, selLoadFromHTMLWithData_Options_CompletionHandler_XHandle, data__handle__, options__handle__, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (data);
			GC.KeepAlive (options);
		}
		[EditorBrowsable (EditorBrowsableState.Never)]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Task<NSLoadFromHtmlResult> LoadFromHtmlAsync (NSData data, NSDictionary options)
		{
			var tcs = new TaskCompletionSource<NSLoadFromHtmlResult> ();
			LoadFromHtml(data, options, (attributedString_, attributes_, error_) => {
				if (error_ is not null)
					tcs.SetException (new NSErrorException(error_));
				else
					tcs.SetResult (new NSLoadFromHtmlResult (attributedString_!, attributes_!));
			});
			return tcs.Task;
		}
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void LoadFromHtml (NSData data, NSAttributedStringDocumentAttributes options, NSAttributedStringCompletionHandler completionHandler)
		{
			LoadFromHtml (data, options.GetDictionary ()!, completionHandler);
		}
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Task<NSLoadFromHtmlResult> LoadFromHtmlAsync (NSData data, NSAttributedStringDocumentAttributes options)
		{
			var tcs = new TaskCompletionSource<NSLoadFromHtmlResult> ();
			LoadFromHtml(data, options, (attributedString_, attributes_, error_) => {
				if (error_ is not null)
					tcs.SetException (new NSErrorException(error_));
				else
					tcs.SetResult (new NSLoadFromHtmlResult (attributedString_!, attributes_!));
			});
			return tcs.Task;
		}
		[Export ("attributesAtIndex:effectiveRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint LowLevelGetAttributes (nint location, nint effectiveRange)
		{
			nint ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (this.Handle, selAttributesAtIndex_EffectiveRange_XHandle, location, effectiveRange);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr (&__objc_super__, selAttributesAtIndex_EffectiveRange_XHandle, location, effectiveRange);
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		/// <param name="zone">Zone to use to allocate this object, or null to use the default zone.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("mutableCopyWithZone:")]
		[return: ReleaseAttribute ()]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject MutableCopy (NSZone? zone)
		{
			var zone__handle__ = zone.GetHandle ();
			NSObject? ret;
			if (IsDirectBinding) {
				ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selMutableCopyWithZone_XHandle, zone__handle__), true)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selMutableCopyWithZone_XHandle, zone__handle__), true)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (zone);
			return ret!;
		}
		[Export ("prefersRTFDInRange:")]
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool PrefersRtfdInRange (NSRange range)
		{
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NSRange (this.Handle, selPrefersRTFDInRange_XHandle, range);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NSRange (&__objc_super__, selPrefersRTFDInRange_XHandle, range);
					GC.KeepAlive (this);
				}
			}
			return ret != 0;
		}
		[Export ("attributedSubstringFromRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal virtual NSAttributedString Substring (NSRange range)
		{
			NSAttributedString ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSAttributedString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NSRange (this.Handle, selAttributedSubstringFromRange_XHandle, range), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSAttributedString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NSRange (&__objc_super__, selAttributedSubstringFromRange_XHandle, range), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe NativeHandle _InitWithContentsOfMarkdownFile (NSUrl markdownFile, NSAttributedStringMarkdownParsingOptions? options, NSUrl? baseUrl, out NSError? error)
		{
			var markdownFile__handle__ = markdownFile!.GetNonNullHandle (nameof (markdownFile));
			var options__handle__ = options.GetHandle ();
			var baseUrl__handle__ = baseUrl.GetHandle ();
			NativeHandle errorValue = IntPtr.Zero;
			NativeHandle ret;
			ret = global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_ref_NativeHandle (this.Handle, selInitWithContentsOfMarkdownFileAtURL_Options_BaseURL_Error_XHandle, markdownFile__handle__, options__handle__, baseUrl__handle__, &errorValue);
			GC.KeepAlive (markdownFile);
			GC.KeepAlive (options);
			GC.KeepAlive (baseUrl);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe NativeHandle _InitWithData (NSData data, NSDictionary options, out NSDictionary resultDocumentAttributes, out NSError error)
		{
			var data__handle__ = data!.GetNonNullHandle (nameof (data));
			var options__handle__ = options!.GetNonNullHandle (nameof (options));
			NativeHandle resultDocumentAttributesValue = IntPtr.Zero;
			NativeHandle errorValue = IntPtr.Zero;
			NativeHandle ret;
			ret = global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_ref_NativeHandle_ref_NativeHandle (this.Handle, selInitWithData_Options_DocumentAttributes_Error_XHandle, data__handle__, options__handle__, &resultDocumentAttributesValue, &errorValue);
			GC.KeepAlive (data);
			GC.KeepAlive (options);
			resultDocumentAttributes = Runtime.GetNSObject<NSDictionary> (resultDocumentAttributesValue)!;
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		/// <param name="wordDocFormat">To be added.</param><param name="docAttributes">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("initWithDocFormat:documentAttributes:")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe virtual NativeHandle _InitWithDocFormat (NSData wordDocFormat, out NSDictionary docAttributes)
		{
			var wordDocFormat__handle__ = wordDocFormat!.GetNonNullHandle (nameof (wordDocFormat));
			NativeHandle docAttributesValue = IntPtr.Zero;
			NativeHandle ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_ref_NativeHandle (this.Handle, selInitWithDocFormat_DocumentAttributes_XHandle, wordDocFormat__handle__, &docAttributesValue);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_ref_NativeHandle (&__objc_super__, selInitWithDocFormat_DocumentAttributes_XHandle, wordDocFormat__handle__, &docAttributesValue);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (wordDocFormat);
			docAttributes = Runtime.GetNSObject<NSDictionary> (docAttributesValue)!;
			return ret!;
		}
		/// <param name="htmlData">To be added.</param><param name="baseUrl">To be added.</param><param name="docAttributes">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("initWithHTML:baseURL:documentAttributes:")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe virtual NativeHandle _InitWithHTML (NSData htmlData, NSUrl baseUrl, out NSDictionary docAttributes)
		{
			var htmlData__handle__ = htmlData!.GetNonNullHandle (nameof (htmlData));
			var baseUrl__handle__ = baseUrl!.GetNonNullHandle (nameof (baseUrl));
			NativeHandle docAttributesValue = IntPtr.Zero;
			NativeHandle ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_ref_NativeHandle (this.Handle, selInitWithHTML_BaseURL_DocumentAttributes_XHandle, htmlData__handle__, baseUrl__handle__, &docAttributesValue);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_ref_NativeHandle (&__objc_super__, selInitWithHTML_BaseURL_DocumentAttributes_XHandle, htmlData__handle__, baseUrl__handle__, &docAttributesValue);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (htmlData);
			GC.KeepAlive (baseUrl);
			docAttributes = Runtime.GetNSObject<NSDictionary> (docAttributesValue)!;
			return ret!;
		}
		[Export ("initWithHTML:documentAttributes:")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe virtual nint _InitWithHTML (NSData data, out NSDictionary resultDocumentAttributes)
		{
			var data__handle__ = data!.GetNonNullHandle (nameof (data));
			NativeHandle resultDocumentAttributesValue = IntPtr.Zero;
			nint ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_NativeHandle_ref_NativeHandle (this.Handle, selInitWithHTML_DocumentAttributes_XHandle, data__handle__, &resultDocumentAttributesValue);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_NativeHandle_ref_NativeHandle (&__objc_super__, selInitWithHTML_DocumentAttributes_XHandle, data__handle__, &resultDocumentAttributesValue);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (data);
			resultDocumentAttributes = Runtime.GetNSObject<NSDictionary> (resultDocumentAttributesValue)!;
			return ret!;
		}
		[Export ("initWithHTML:options:documentAttributes:")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe virtual NativeHandle _InitWithHTML (NSData data, NSDictionary options, out NSDictionary resultDocumentAttributes)
		{
			var data__handle__ = data!.GetNonNullHandle (nameof (data));
			var options__handle__ = options!.GetNonNullHandle (nameof (options));
			NativeHandle resultDocumentAttributesValue = IntPtr.Zero;
			NativeHandle ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_ref_NativeHandle (this.Handle, selInitWithHTML_Options_DocumentAttributes_XHandle, data__handle__, options__handle__, &resultDocumentAttributesValue);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_ref_NativeHandle (&__objc_super__, selInitWithHTML_Options_DocumentAttributes_XHandle, data__handle__, options__handle__, &resultDocumentAttributesValue);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (data);
			GC.KeepAlive (options);
			resultDocumentAttributes = Runtime.GetNSObject<NSDictionary> (resultDocumentAttributesValue)!;
			return ret!;
		}
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe NativeHandle _InitWithMarkdown (NSData markdown, NSAttributedStringMarkdownParsingOptions? options, NSUrl? baseUrl, out NSError? error)
		{
			var markdown__handle__ = markdown!.GetNonNullHandle (nameof (markdown));
			var options__handle__ = options.GetHandle ();
			var baseUrl__handle__ = baseUrl.GetHandle ();
			NativeHandle errorValue = IntPtr.Zero;
			NativeHandle ret;
			ret = global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_ref_NativeHandle (this.Handle, selInitWithMarkdown_Options_BaseURL_Error_XHandle, markdown__handle__, options__handle__, baseUrl__handle__, &errorValue);
			GC.KeepAlive (markdown);
			GC.KeepAlive (options);
			GC.KeepAlive (baseUrl);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe NativeHandle _InitWithMarkdownString (string markdownString, NSAttributedStringMarkdownParsingOptions? options, NSUrl? baseUrl, out NSError? error)
		{
			if (markdownString is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (markdownString));
			var options__handle__ = options.GetHandle ();
			var baseUrl__handle__ = baseUrl.GetHandle ();
			NativeHandle errorValue = IntPtr.Zero;
			var nsmarkdownString = CFString.CreateNative (markdownString);
			NativeHandle ret;
			ret = global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_ref_NativeHandle (this.Handle, selInitWithMarkdownString_Options_BaseURL_Error_XHandle, nsmarkdownString, options__handle__, baseUrl__handle__, &errorValue);
			GC.KeepAlive (options);
			GC.KeepAlive (baseUrl);
			CFString.ReleaseNative (nsmarkdownString);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		[Export ("initWithRTFDFileWrapper:documentAttributes:")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe virtual NativeHandle _InitWithRTFDFileWrapper (NSFileWrapper wrapper, out NSDictionary resultDocumentAttributes)
		{
			var wrapper__handle__ = wrapper!.GetNonNullHandle (nameof (wrapper));
			NativeHandle resultDocumentAttributesValue = IntPtr.Zero;
			NativeHandle ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_ref_NativeHandle (this.Handle, selInitWithRTFDFileWrapper_DocumentAttributes_XHandle, wrapper__handle__, &resultDocumentAttributesValue);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_ref_NativeHandle (&__objc_super__, selInitWithRTFDFileWrapper_DocumentAttributes_XHandle, wrapper__handle__, &resultDocumentAttributesValue);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (wrapper);
			resultDocumentAttributes = Runtime.GetNSObject<NSDictionary> (resultDocumentAttributesValue)!;
			return ret!;
		}
		[Export ("initWithRTF:documentAttributes:")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe virtual nint _InitWithRtf (NSData data, out NSDictionary resultDocumentAttributes)
		{
			var data__handle__ = data!.GetNonNullHandle (nameof (data));
			NativeHandle resultDocumentAttributesValue = IntPtr.Zero;
			nint ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_NativeHandle_ref_NativeHandle (this.Handle, selInitWithRTF_DocumentAttributes_XHandle, data__handle__, &resultDocumentAttributesValue);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_NativeHandle_ref_NativeHandle (&__objc_super__, selInitWithRTF_DocumentAttributes_XHandle, data__handle__, &resultDocumentAttributesValue);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (data);
			resultDocumentAttributes = Runtime.GetNSObject<NSDictionary> (resultDocumentAttributesValue)!;
			return ret!;
		}
		[Export ("initWithRTFD:documentAttributes:")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe virtual nint _InitWithRtfd (NSData data, out NSDictionary resultDocumentAttributes)
		{
			var data__handle__ = data!.GetNonNullHandle (nameof (data));
			NativeHandle resultDocumentAttributesValue = IntPtr.Zero;
			nint ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_NativeHandle_ref_NativeHandle (this.Handle, selInitWithRTFD_DocumentAttributes_XHandle, data__handle__, &resultDocumentAttributesValue);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_NativeHandle_ref_NativeHandle (&__objc_super__, selInitWithRTFD_DocumentAttributes_XHandle, data__handle__, &resultDocumentAttributesValue);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (data);
			resultDocumentAttributes = Runtime.GetNSObject<NSDictionary> (resultDocumentAttributesValue)!;
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe NativeHandle _InitWithUrl (NSUrl url, NSDictionary options, out NSDictionary resultDocumentAttributes, out NSError error)
		{
			var url__handle__ = url!.GetNonNullHandle (nameof (url));
			var options__handle__ = options!.GetNonNullHandle (nameof (options));
			NativeHandle resultDocumentAttributesValue = IntPtr.Zero;
			NativeHandle errorValue = IntPtr.Zero;
			NativeHandle ret;
			ret = global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_ref_NativeHandle_ref_NativeHandle (this.Handle, selInitWithURL_Options_DocumentAttributes_Error_XHandle, url__handle__, options__handle__, &resultDocumentAttributesValue, &errorValue);
			GC.KeepAlive (url);
			GC.KeepAlive (options);
			resultDocumentAttributes = Runtime.GetNSObject<NSDictionary> (resultDocumentAttributesValue)!;
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public virtual NSAttributedString AttributedStringByInflectingString {
			[Export ("attributedStringByInflectingString")]
			get {
				NSAttributedString? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSAttributedString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selAttributedStringByInflectingStringXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSAttributedString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selAttributedStringByInflectingStringXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		public virtual bool ContainsAttachments {
			[Export ("containsAttachments")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selContainsAttachmentsXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selContainsAttachmentsXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint Length {
			[Export ("length")]
			get {
				nint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selLengthXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selLengthXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint LowLevelValue {
			[Export ("string")]
			get {
				nint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selStringXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selStringXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual CGSize Size {
			[Export ("size")]
			get {
				CGSize ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.CGSize_objc_msgSend (this.Handle, selSizeXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGSize_objc_msgSendSuper (&__objc_super__, selSizeXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CocoaVersionDocumentAttribute;
		/// <summary>Represents the value associated with the constant 'NSCocoaVersionDocumentAttribute'.</summary>
		[Field ("NSCocoaVersionDocumentAttribute",  "AppKit")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString CocoaVersionDocumentAttribute {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("tvos13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_CocoaVersionDocumentAttribute is null)
					_CocoaVersionDocumentAttribute = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSCocoaVersionDocumentAttribute")!;
				return _CocoaVersionDocumentAttribute;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _SourceTextScalingDocumentAttribute;
		/// <summary>Represents the value associated with the constant 'NSSourceTextScalingDocumentAttribute'.</summary>
		[Field ("NSSourceTextScalingDocumentAttribute",  "AppKit")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString SourceTextScalingDocumentAttribute {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("tvos13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_SourceTextScalingDocumentAttribute is null)
					_SourceTextScalingDocumentAttribute = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSSourceTextScalingDocumentAttribute")!;
				return _SourceTextScalingDocumentAttribute;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _TextLayoutSectionOrientation;
		/// <summary>Represents the value associated with the constant 'NSTextLayoutSectionOrientation'.</summary>
		[Field ("NSTextLayoutSectionOrientation",  "AppKit")]
		public static NSString TextLayoutSectionOrientation {
			get {
				if (_TextLayoutSectionOrientation is null)
					_TextLayoutSectionOrientation = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSTextLayoutSectionOrientation")!;
				return _TextLayoutSectionOrientation;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _TextLayoutSectionRange;
		/// <summary>Represents the value associated with the constant 'NSTextLayoutSectionRange'.</summary>
		[Field ("NSTextLayoutSectionRange",  "AppKit")]
		public static NSString TextLayoutSectionRange {
			get {
				if (_TextLayoutSectionRange is null)
					_TextLayoutSectionRange = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSTextLayoutSectionRange")!;
				return _TextLayoutSectionRange;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _TextLayoutSectionsAttribute;
		/// <summary>Represents the value associated with the constant 'NSTextLayoutSectionsAttribute'.</summary>
		[Field ("NSTextLayoutSectionsAttribute",  "AppKit")]
		public static NSString TextLayoutSectionsAttribute {
			get {
				if (_TextLayoutSectionsAttribute is null)
					_TextLayoutSectionsAttribute = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSTextLayoutSectionsAttribute")!;
				return _TextLayoutSectionsAttribute;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _TextScalingDocumentAttribute;
		/// <summary>Represents the value associated with the constant 'NSTextScalingDocumentAttribute'.</summary>
		[Field ("NSTextScalingDocumentAttribute",  "AppKit")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString TextScalingDocumentAttribute {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("tvos13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_TextScalingDocumentAttribute is null)
					_TextScalingDocumentAttribute = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSTextScalingDocumentAttribute")!;
				return _TextScalingDocumentAttribute;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSUnderlineByWordMask",  "AppKit")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[ObsoletedOSPlatform ("macos10.11")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static nint UnderlineByWordMaskAttributeName {
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[ObsoletedOSPlatform ("macos10.11")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				return Dlfcn.GetIntPtr (Libraries.AppKit.Handle, "NSUnderlineByWordMask");
			}
		}
	} /* class NSAttributedString */
	//
	// Async result classes
	//
	/// <summary>This class holds the return values for an asynchronous operation.</summary>
	public partial class NSLoadFromHtmlResult {
		/// <summary>The result value from the asynchronous operation.</summary>
		public NSAttributedString AttributedString { get; set; }
		/// <summary>The result value from the asynchronous operation.</summary>
		public NSDictionary<NSString, NSObject> Attributes { get; set; }
		partial void Initialize ();
		/// <summary>Creates a new instance of this class.</summary>
		/// <param name="attributedString">Result value from an asynchronous operation.</param>
		/// <param name="attributes">Result value from an asynchronous operation.</param>
		public NSLoadFromHtmlResult (NSAttributedString attributedString, NSDictionary<NSString, NSObject> attributes) {
			this.AttributedString = attributedString;
			this.Attributes = attributes;
			Initialize ();
		}
	}
}
