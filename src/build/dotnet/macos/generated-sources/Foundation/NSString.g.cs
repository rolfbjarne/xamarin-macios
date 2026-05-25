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
	[Register("NSString", true)]
	public unsafe partial class NSString : NSObject, INSCoding, INSCopying, INSItemProviderReading, INSItemProviderWriting, INSMutableCopying, INSSecureCoding, global::AppKit.INSPasteboardReading, global::AppKit.INSPasteboardWriting, global::CloudKit.ICKRecordValue {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selBoundingRectWithSize_Options_Attributes_X = "boundingRectWithSize:options:attributes:";
		static readonly NativeHandle selBoundingRectWithSize_Options_Attributes_XHandle = Selector.GetHandle ("boundingRectWithSize:options:attributes:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCapitalizedStringWithLocale_X = "capitalizedStringWithLocale:";
		static readonly NativeHandle selCapitalizedStringWithLocale_XHandle = Selector.GetHandle ("capitalizedStringWithLocale:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCharacterAtIndex_X = "characterAtIndex:";
		static readonly NativeHandle selCharacterAtIndex_XHandle = Selector.GetHandle ("characterAtIndex:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCommonPrefixWithString_Options_X = "commonPrefixWithString:options:";
		static readonly NativeHandle selCommonPrefixWithString_Options_XHandle = Selector.GetHandle ("commonPrefixWithString:options:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCompare_X = "compare:";
		static readonly NativeHandle selCompare_XHandle = Selector.GetHandle ("compare:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCompare_Options_X = "compare:options:";
		static readonly NativeHandle selCompare_Options_XHandle = Selector.GetHandle ("compare:options:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCompare_Options_Range_X = "compare:options:range:";
		static readonly NativeHandle selCompare_Options_Range_XHandle = Selector.GetHandle ("compare:options:range:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCompare_Options_Range_Locale_X = "compare:options:range:locale:";
		static readonly NativeHandle selCompare_Options_Range_Locale_XHandle = Selector.GetHandle ("compare:options:range:locale:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selComponentsSeparatedByCharactersInSet_X = "componentsSeparatedByCharactersInSet:";
		static readonly NativeHandle selComponentsSeparatedByCharactersInSet_XHandle = Selector.GetHandle ("componentsSeparatedByCharactersInSet:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selComponentsSeparatedByString_X = "componentsSeparatedByString:";
		static readonly NativeHandle selComponentsSeparatedByString_XHandle = Selector.GetHandle ("componentsSeparatedByString:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selContainsString_X = "containsString:";
		static readonly NativeHandle selContainsString_XHandle = Selector.GetHandle ("containsString:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCopyWithZone_X = "copyWithZone:";
		static readonly NativeHandle selCopyWithZone_XHandle = Selector.GetHandle ("copyWithZone:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDrawAtPoint_WithAttributes_X = "drawAtPoint:withAttributes:";
		static readonly NativeHandle selDrawAtPoint_WithAttributes_XHandle = Selector.GetHandle ("drawAtPoint:withAttributes:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDrawInRect_WithAttributes_X = "drawInRect:withAttributes:";
		static readonly NativeHandle selDrawInRect_WithAttributes_XHandle = Selector.GetHandle ("drawInRect:withAttributes:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDrawWithRect_Options_Attributes_X = "drawWithRect:options:attributes:";
		static readonly NativeHandle selDrawWithRect_Options_Attributes_XHandle = Selector.GetHandle ("drawWithRect:options:attributes:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selEncodeWithCoder_X = "encodeWithCoder:";
		static readonly NativeHandle selEncodeWithCoder_XHandle = Selector.GetHandle ("encodeWithCoder:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selGetLineStart_End_ContentsEnd_ForRange_X = "getLineStart:end:contentsEnd:forRange:";
		static readonly NativeHandle selGetLineStart_End_ContentsEnd_ForRange_XHandle = Selector.GetHandle ("getLineStart:end:contentsEnd:forRange:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selGetParagraphStart_End_ContentsEnd_ForRange_X = "getParagraphStart:end:contentsEnd:forRange:";
		static readonly NativeHandle selGetParagraphStart_End_ContentsEnd_ForRange_XHandle = Selector.GetHandle ("getParagraphStart:end:contentsEnd:forRange:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selHasPrefix_X = "hasPrefix:";
		static readonly NativeHandle selHasPrefix_XHandle = Selector.GetHandle ("hasPrefix:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selHasSuffix_X = "hasSuffix:";
		static readonly NativeHandle selHasSuffix_XHandle = Selector.GetHandle ("hasSuffix:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithCoder_X = "initWithCoder:";
		static readonly NativeHandle selInitWithCoder_XHandle = Selector.GetHandle ("initWithCoder:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithData_Encoding_X = "initWithData:encoding:";
		static readonly NativeHandle selInitWithData_Encoding_XHandle = Selector.GetHandle ("initWithData:encoding:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithPasteboardPropertyList_OfType_X = "initWithPasteboardPropertyList:ofType:";
		static readonly NativeHandle selInitWithPasteboardPropertyList_OfType_XHandle = Selector.GetHandle ("initWithPasteboardPropertyList:ofType:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsAbsolutePathX = "isAbsolutePath";
		static readonly NativeHandle selIsAbsolutePathXHandle = Selector.GetHandle ("isAbsolutePath");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsEqualToString_X = "isEqualToString:";
		static readonly NativeHandle selIsEqualToString_XHandle = Selector.GetHandle ("isEqualToString:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selItemProviderVisibilityForRepresentationWithTypeIdentifier_X = "itemProviderVisibilityForRepresentationWithTypeIdentifier:";
		static readonly NativeHandle selItemProviderVisibilityForRepresentationWithTypeIdentifier_XHandle = Selector.GetHandle ("itemProviderVisibilityForRepresentationWithTypeIdentifier:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLastPathComponentX = "lastPathComponent";
		static readonly NativeHandle selLastPathComponentXHandle = Selector.GetHandle ("lastPathComponent");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLengthX = "length";
		static readonly NativeHandle selLengthXHandle = Selector.GetHandle ("length");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLineRangeForRange_X = "lineRangeForRange:";
		static readonly NativeHandle selLineRangeForRange_XHandle = Selector.GetHandle ("lineRangeForRange:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLoadDataWithTypeIdentifier_ForItemProviderCompletionHandler_X = "loadDataWithTypeIdentifier:forItemProviderCompletionHandler:";
		static readonly NativeHandle selLoadDataWithTypeIdentifier_ForItemProviderCompletionHandler_XHandle = Selector.GetHandle ("loadDataWithTypeIdentifier:forItemProviderCompletionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLocalizedCapitalizedStringX = "localizedCapitalizedString";
		static readonly NativeHandle selLocalizedCapitalizedStringXHandle = Selector.GetHandle ("localizedCapitalizedString");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLocalizedCaseInsensitiveContainsString_X = "localizedCaseInsensitiveContainsString:";
		static readonly NativeHandle selLocalizedCaseInsensitiveContainsString_XHandle = Selector.GetHandle ("localizedCaseInsensitiveContainsString:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLocalizedLowercaseStringX = "localizedLowercaseString";
		static readonly NativeHandle selLocalizedLowercaseStringXHandle = Selector.GetHandle ("localizedLowercaseString");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLocalizedStandardContainsString_X = "localizedStandardContainsString:";
		static readonly NativeHandle selLocalizedStandardContainsString_XHandle = Selector.GetHandle ("localizedStandardContainsString:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLocalizedStandardRangeOfString_X = "localizedStandardRangeOfString:";
		static readonly NativeHandle selLocalizedStandardRangeOfString_XHandle = Selector.GetHandle ("localizedStandardRangeOfString:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLocalizedUppercaseStringX = "localizedUppercaseString";
		static readonly NativeHandle selLocalizedUppercaseStringXHandle = Selector.GetHandle ("localizedUppercaseString");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLocalizedUserNotificationStringForKey_Arguments_X = "localizedUserNotificationStringForKey:arguments:";
		static readonly NativeHandle selLocalizedUserNotificationStringForKey_Arguments_XHandle = Selector.GetHandle ("localizedUserNotificationStringForKey:arguments:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLowercaseStringWithLocale_X = "lowercaseStringWithLocale:";
		static readonly NativeHandle selLowercaseStringWithLocale_XHandle = Selector.GetHandle ("lowercaseStringWithLocale:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMutableCopyWithZone_X = "mutableCopyWithZone:";
		static readonly NativeHandle selMutableCopyWithZone_XHandle = Selector.GetHandle ("mutableCopyWithZone:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selObjectWithItemProviderData_TypeIdentifier_Error_X = "objectWithItemProviderData:typeIdentifier:error:";
		static readonly NativeHandle selObjectWithItemProviderData_TypeIdentifier_Error_XHandle = Selector.GetHandle ("objectWithItemProviderData:typeIdentifier:error:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selParagraphRangeForRange_X = "paragraphRangeForRange:";
		static readonly NativeHandle selParagraphRangeForRange_XHandle = Selector.GetHandle ("paragraphRangeForRange:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPasteboardPropertyListForType_X = "pasteboardPropertyListForType:";
		static readonly NativeHandle selPasteboardPropertyListForType_XHandle = Selector.GetHandle ("pasteboardPropertyListForType:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPathComponentsX = "pathComponents";
		static readonly NativeHandle selPathComponentsXHandle = Selector.GetHandle ("pathComponents");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPathExtensionX = "pathExtension";
		static readonly NativeHandle selPathExtensionXHandle = Selector.GetHandle ("pathExtension");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPathWithComponents_X = "pathWithComponents:";
		static readonly NativeHandle selPathWithComponents_XHandle = Selector.GetHandle ("pathWithComponents:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selReadableTypeIdentifiersForItemProviderX = "readableTypeIdentifiersForItemProvider";
		static readonly NativeHandle selReadableTypeIdentifiersForItemProviderXHandle = Selector.GetHandle ("readableTypeIdentifiersForItemProvider");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selReadableTypesForPasteboard_X = "readableTypesForPasteboard:";
		static readonly NativeHandle selReadableTypesForPasteboard_XHandle = Selector.GetHandle ("readableTypesForPasteboard:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selReadingOptionsForType_Pasteboard_X = "readingOptionsForType:pasteboard:";
		static readonly NativeHandle selReadingOptionsForType_Pasteboard_XHandle = Selector.GetHandle ("readingOptionsForType:pasteboard:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSizeWithAttributes_X = "sizeWithAttributes:";
		static readonly NativeHandle selSizeWithAttributes_XHandle = Selector.GetHandle ("sizeWithAttributes:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selStringByAbbreviatingWithTildeInPathX = "stringByAbbreviatingWithTildeInPath";
		static readonly NativeHandle selStringByAbbreviatingWithTildeInPathXHandle = Selector.GetHandle ("stringByAbbreviatingWithTildeInPath");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selStringByAppendingPathComponent_X = "stringByAppendingPathComponent:";
		static readonly NativeHandle selStringByAppendingPathComponent_XHandle = Selector.GetHandle ("stringByAppendingPathComponent:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selStringByAppendingPathExtension_X = "stringByAppendingPathExtension:";
		static readonly NativeHandle selStringByAppendingPathExtension_XHandle = Selector.GetHandle ("stringByAppendingPathExtension:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selStringByApplyingTransform_Reverse_X = "stringByApplyingTransform:reverse:";
		static readonly NativeHandle selStringByApplyingTransform_Reverse_XHandle = Selector.GetHandle ("stringByApplyingTransform:reverse:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selStringByDeletingLastPathComponentX = "stringByDeletingLastPathComponent";
		static readonly NativeHandle selStringByDeletingLastPathComponentXHandle = Selector.GetHandle ("stringByDeletingLastPathComponent");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selStringByDeletingPathExtensionX = "stringByDeletingPathExtension";
		static readonly NativeHandle selStringByDeletingPathExtensionXHandle = Selector.GetHandle ("stringByDeletingPathExtension");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selStringByExpandingTildeInPathX = "stringByExpandingTildeInPath";
		static readonly NativeHandle selStringByExpandingTildeInPathXHandle = Selector.GetHandle ("stringByExpandingTildeInPath");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selStringByReplacingCharactersInRange_WithString_X = "stringByReplacingCharactersInRange:withString:";
		static readonly NativeHandle selStringByReplacingCharactersInRange_WithString_XHandle = Selector.GetHandle ("stringByReplacingCharactersInRange:withString:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selStringByResolvingSymlinksInPathX = "stringByResolvingSymlinksInPath";
		static readonly NativeHandle selStringByResolvingSymlinksInPathXHandle = Selector.GetHandle ("stringByResolvingSymlinksInPath");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selStringByStandardizingPathX = "stringByStandardizingPath";
		static readonly NativeHandle selStringByStandardizingPathXHandle = Selector.GetHandle ("stringByStandardizingPath");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selStringEncodingForData_EncodingOptions_ConvertedString_UsedLossyConversion_X = "stringEncodingForData:encodingOptions:convertedString:usedLossyConversion:";
		static readonly NativeHandle selStringEncodingForData_EncodingOptions_ConvertedString_UsedLossyConversion_XHandle = Selector.GetHandle ("stringEncodingForData:encodingOptions:convertedString:usedLossyConversion:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selStringsByAppendingPaths_X = "stringsByAppendingPaths:";
		static readonly NativeHandle selStringsByAppendingPaths_XHandle = Selector.GetHandle ("stringsByAppendingPaths:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selUppercaseStringWithLocale_X = "uppercaseStringWithLocale:";
		static readonly NativeHandle selUppercaseStringWithLocale_XHandle = Selector.GetHandle ("uppercaseStringWithLocale:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selVariantFittingPresentationWidth_X = "variantFittingPresentationWidth:";
		static readonly NativeHandle selVariantFittingPresentationWidth_XHandle = Selector.GetHandle ("variantFittingPresentationWidth:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selWritableTypeIdentifiersForItemProviderX = "writableTypeIdentifiersForItemProvider";
		static readonly NativeHandle selWritableTypeIdentifiersForItemProviderXHandle = Selector.GetHandle ("writableTypeIdentifiersForItemProvider");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selWritableTypesForPasteboard_X = "writableTypesForPasteboard:";
		static readonly NativeHandle selWritableTypesForPasteboard_XHandle = Selector.GetHandle ("writableTypesForPasteboard:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selWritingOptionsForType_Pasteboard_X = "writingOptionsForType:pasteboard:";
		static readonly NativeHandle selWritingOptionsForType_Pasteboard_XHandle = Selector.GetHandle ("writingOptionsForType:pasteboard:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("NSString");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		/// <summary>Creates a new <see cref="NSString" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[DesignatedInitializer]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public NSString () : base (NSObjectFlag.Empty)
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
		public NSString (NSCoder coder) : base (NSObjectFlag.Empty)
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
		protected NSString (NSObjectFlag t) : base (t)
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
		protected internal NSString (NativeHandle handle) : base (handle)
		{
		}

		[Export ("initWithData:encoding:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSString (NSData data, NSStringEncoding encoding)
			: base (NSObjectFlag.Empty)
		{
			var data__handle__ = data!.GetNonNullHandle (nameof (data));
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_UIntPtr (this.Handle, selInitWithData_Encoding_XHandle, data__handle__, (UIntPtr) (ulong) encoding), "initWithData:encoding:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_UIntPtr (&__objc_super__, selInitWithData_Encoding_XHandle, data__handle__, (UIntPtr) (ulong) encoding), "initWithData:encoding:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (data);
		}
		[Export ("stringByAbbreviatingWithTildeInPath")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSString AbbreviateTildeInPath ()
		{
			NSString ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selStringByAbbreviatingWithTildeInPathXHandle), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selStringByAbbreviatingWithTildeInPathXHandle), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("stringByAppendingPathComponent:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSString AppendPathComponent (NSString str)
		{
			var str__handle__ = str!.GetNonNullHandle (nameof (str));
			NSString? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selStringByAppendingPathComponent_XHandle, str__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selStringByAppendingPathComponent_XHandle, str__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (str);
			return ret!;
		}
		[Export ("stringByAppendingPathExtension:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSString AppendPathExtension (NSString str)
		{
			var str__handle__ = str!.GetNonNullHandle (nameof (str));
			NSString? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selStringByAppendingPathExtension_XHandle, str__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selStringByAppendingPathExtension_XHandle, str__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (str);
			return ret!;
		}
		[Export ("stringsByAppendingPaths:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string[] AppendPaths (string[] paths)
		{
			if (paths is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (paths));
			using var nsa_paths = NSArray.FromStrings (paths);
			string[] ret;
			if (IsDirectBinding) {
				ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selStringsByAppendingPaths_XHandle, nsa_paths.Handle), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selStringsByAppendingPaths_XHandle, nsa_paths.Handle), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		/// <param name="size">To be added.</param><param name="options">To be added.</param><param name="attributes">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public CGRect BoundingRectWithSize (CGSize size, NSStringDrawingOptions options, NSDictionary attributes)
		{
			var attributes__handle__ = attributes!.GetNonNullHandle (nameof (attributes));
			CGRect ret;
			if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
				ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_CGSize_UIntPtr_NativeHandle (this.Handle, selBoundingRectWithSize_Options_Attributes_XHandle, size, (UIntPtr) (ulong) options, attributes__handle__);
			} else {
				ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret_CGSize_UIntPtr_NativeHandle (this.Handle, selBoundingRectWithSize_Options_Attributes_XHandle, size, (UIntPtr) (ulong) options, attributes__handle__);
			}
			GC.KeepAlive (attributes);
			return ret!;
		}
		[Export ("capitalizedStringWithLocale:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string Capitalize (NSLocale? locale)
		{
			var locale__handle__ = locale.GetHandle ();
			string? ret;
			if (IsDirectBinding) {
				ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selCapitalizedStringWithLocale_XHandle, locale__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selCapitalizedStringWithLocale_XHandle, locale__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (locale);
			return ret!;
		}
		[Export ("commonPrefixWithString:options:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSString CommonPrefix (NSString aString, NSStringCompareOptions options)
		{
			var aString__handle__ = aString!.GetNonNullHandle (nameof (aString));
			NSString? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_UIntPtr (this.Handle, selCommonPrefixWithString_Options_XHandle, aString__handle__, (UIntPtr) (ulong) options), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_UIntPtr (&__objc_super__, selCommonPrefixWithString_Options_XHandle, aString__handle__, (UIntPtr) (ulong) options), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (aString);
			return ret!;
		}
		[Export ("compare:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSComparisonResult Compare (NSString aString)
		{
			var aString__handle__ = aString!.GetNonNullHandle (nameof (aString));
			NSComparisonResult ret;
			if (IsDirectBinding) {
				ret = (NSComparisonResult) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_NativeHandle (this.Handle, selCompare_XHandle, aString__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = (NSComparisonResult) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_NativeHandle (&__objc_super__, selCompare_XHandle, aString__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (aString);
			return ret!;
		}
		[Export ("compare:options:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSComparisonResult Compare (NSString aString, NSStringCompareOptions mask)
		{
			var aString__handle__ = aString!.GetNonNullHandle (nameof (aString));
			NSComparisonResult ret;
			if (IsDirectBinding) {
				ret = (NSComparisonResult) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_NativeHandle_UIntPtr (this.Handle, selCompare_Options_XHandle, aString__handle__, (UIntPtr) (ulong) mask);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = (NSComparisonResult) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_NativeHandle_UIntPtr (&__objc_super__, selCompare_Options_XHandle, aString__handle__, (UIntPtr) (ulong) mask);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (aString);
			return ret!;
		}
		[Export ("compare:options:range:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSComparisonResult Compare (NSString aString, NSStringCompareOptions mask, NSRange range)
		{
			var aString__handle__ = aString!.GetNonNullHandle (nameof (aString));
			NSComparisonResult ret;
			if (IsDirectBinding) {
				ret = (NSComparisonResult) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_NativeHandle_UIntPtr_NSRange (this.Handle, selCompare_Options_Range_XHandle, aString__handle__, (UIntPtr) (ulong) mask, range);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = (NSComparisonResult) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_NativeHandle_UIntPtr_NSRange (&__objc_super__, selCompare_Options_Range_XHandle, aString__handle__, (UIntPtr) (ulong) mask, range);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (aString);
			return ret!;
		}
		[Export ("compare:options:range:locale:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSComparisonResult Compare (NSString aString, NSStringCompareOptions mask, NSRange range, NSLocale? locale)
		{
			var aString__handle__ = aString!.GetNonNullHandle (nameof (aString));
			var locale__handle__ = locale.GetHandle ();
			NSComparisonResult ret;
			if (IsDirectBinding) {
				ret = (NSComparisonResult) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_NativeHandle_UIntPtr_NSRange_NativeHandle (this.Handle, selCompare_Options_Range_Locale_XHandle, aString__handle__, (UIntPtr) (ulong) mask, range, locale__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = (NSComparisonResult) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_NativeHandle_UIntPtr_NSRange_NativeHandle (&__objc_super__, selCompare_Options_Range_Locale_XHandle, aString__handle__, (UIntPtr) (ulong) mask, range, locale__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (aString);
			GC.KeepAlive (locale);
			return ret!;
		}
		[Export ("containsString:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool Contains (NSString str)
		{
			var str__handle__ = str!.GetNonNullHandle (nameof (str));
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (this.Handle, selContainsString_XHandle, str__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle (&__objc_super__, selContainsString_XHandle, str__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (str);
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
		[Export ("stringByDeletingLastPathComponent")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSString DeleteLastPathComponent ()
		{
			NSString ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selStringByDeletingLastPathComponentXHandle), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selStringByDeletingLastPathComponentXHandle), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("stringByDeletingPathExtension")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSString DeletePathExtension ()
		{
			NSString ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selStringByDeletingPathExtensionXHandle), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selStringByDeletingPathExtensionXHandle), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("stringEncodingForData:encodingOptions:convertedString:usedLossyConversion:")]
		[EditorBrowsable (EditorBrowsableState.Never)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static nuint DetectStringEncoding (NSData rawData, NSDictionary options, out string convertedString, out bool usedLossyConversion)
		{
			var rawData__handle__ = rawData!.GetNonNullHandle (nameof (rawData));
			var options__handle__ = options!.GetNonNullHandle (nameof (options));
			NativeHandle convertedStringValue = IntPtr.Zero;
			fixed (bool* usedLossyConversion__pointer = &usedLossyConversion) {
			usedLossyConversion = default;
			nuint ret;
			ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend_NativeHandle_NativeHandle_ref_NativeHandle_out_Boolean (class_ptr, selStringEncodingForData_EncodingOptions_ConvertedString_UsedLossyConversion_XHandle, rawData__handle__, options__handle__, &convertedStringValue, (byte*) usedLossyConversion__pointer);
			GC.KeepAlive (rawData);
			GC.KeepAlive (options);
			convertedString = CFString.FromHandle (convertedStringValue)!;
			return ret!;
			}
		}
		/// <param name="rawData">To be added.</param><param name="options">To be added.</param><param name="convertedString">To be added.</param><param name="usedLossyConversion">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static nuint DetectStringEncoding (NSData rawData, EncodingDetectionOptions options, out string convertedString, out bool usedLossyConversion)
		{
			return DetectStringEncoding(rawData,options.GetDictionary ()!, out convertedString, out usedLossyConversion);
		}
		/// <param name="point">To be added.</param><param name="attributes">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void DrawString (CGPoint point, NSDictionary attributes)
		{
			var attributes__handle__ = attributes!.GetNonNullHandle (nameof (attributes));
			global::ObjCRuntime.Messaging.void_objc_msgSend_CGPoint_NativeHandle (this.Handle, selDrawAtPoint_WithAttributes_XHandle, point, attributes__handle__);
			GC.KeepAlive (attributes);
		}
		/// <param name="rect">To be added.</param><param name="attributes">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void DrawString (CGRect rect, NSDictionary attributes)
		{
			var attributes__handle__ = attributes!.GetNonNullHandle (nameof (attributes));
			global::ObjCRuntime.Messaging.void_objc_msgSend_CGRect_NativeHandle (this.Handle, selDrawInRect_WithAttributes_XHandle, rect, attributes__handle__);
			GC.KeepAlive (attributes);
		}
		/// <param name="rect">To be added.</param><param name="options">To be added.</param><param name="attributes">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void DrawString (CGRect rect, NSStringDrawingOptions options, NSDictionary attributes)
		{
			var attributes__handle__ = attributes!.GetNonNullHandle (nameof (attributes));
			global::ObjCRuntime.Messaging.void_objc_msgSend_CGRect_UIntPtr_NativeHandle (this.Handle, selDrawWithRect_Options_Attributes_XHandle, rect, (UIntPtr) (ulong) options, attributes__handle__);
			GC.KeepAlive (attributes);
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
		[Export ("stringByExpandingTildeInPath")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSString ExpandTildeInPath ()
		{
			NSString ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selStringByExpandingTildeInPathXHandle), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selStringByExpandingTildeInPathXHandle), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		/// <param name="typeIdentifier">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("itemProviderVisibilityForRepresentationWithTypeIdentifier:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSItemProviderRepresentationVisibility GetItemProviderVisibilityForTypeIdentifier (string typeIdentifier)
		{
			if (typeIdentifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (typeIdentifier));
			var nstypeIdentifier = CFString.CreateNative (typeIdentifier);
			NSItemProviderRepresentationVisibility ret;
			if (IsDirectBinding) {
				ret = (NSItemProviderRepresentationVisibility) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_NativeHandle (this.Handle, selItemProviderVisibilityForRepresentationWithTypeIdentifier_XHandle, nstypeIdentifier);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = (NSItemProviderRepresentationVisibility) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_NativeHandle (&__objc_super__, selItemProviderVisibilityForRepresentationWithTypeIdentifier_XHandle, nstypeIdentifier);
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nstypeIdentifier);
			return ret!;
		}
		/// <param name="startPtr">To be added.</param><param name="lineEndPtr">To be added.</param><param name="contentsEndPtr">To be added.</param><param name="range">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("getLineStart:end:contentsEnd:forRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void GetLineStart (out nuint startPtr, out nuint lineEndPtr, out nuint contentsEndPtr, NSRange range)
		{
			fixed (nuint* startPtr__pointer = &startPtr) {
			fixed (nuint* lineEndPtr__pointer = &lineEndPtr) {
			fixed (nuint* contentsEndPtr__pointer = &contentsEndPtr) {
			startPtr = default;
			lineEndPtr = default;
			contentsEndPtr = default;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_out_UIntPtr_out_UIntPtr_out_UIntPtr_NSRange (this.Handle, selGetLineStart_End_ContentsEnd_ForRange_XHandle, startPtr__pointer, lineEndPtr__pointer, contentsEndPtr__pointer, range);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_out_UIntPtr_out_UIntPtr_out_UIntPtr_NSRange (&__objc_super__, selGetLineStart_End_ContentsEnd_ForRange_XHandle, startPtr__pointer, lineEndPtr__pointer, contentsEndPtr__pointer, range);
					GC.KeepAlive (this);
				}
			}
			}
			}
			}
		}
		/// <param name="key">To be added.</param><param name="arguments">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("localizedUserNotificationStringForKey:arguments:")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSString GetLocalizedUserNotificationString (NSString key, params NSObject[]? arguments)
		{
			var key__handle__ = key!.GetNonNullHandle (nameof (key));
			using var nsa_arguments = arguments is null ? null : NSArray.FromNSObjects (arguments);
			NSString? ret;
			ret =  Runtime.GetNSObject<NSString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (class_ptr, selLocalizedUserNotificationStringForKey_Arguments_XHandle, key__handle__, nsa_arguments.GetHandle ()), false)!;
			GC.KeepAlive (key);
			return ret!;
		}
		[Export ("objectWithItemProviderData:typeIdentifier:error:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static NSString? GetObject (NSData data, string typeIdentifier, out NSError? outError)
		{
			var data__handle__ = data!.GetNonNullHandle (nameof (data));
			if (typeIdentifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (typeIdentifier));
			NativeHandle outErrorValue = IntPtr.Zero;
			var nstypeIdentifier = CFString.CreateNative (typeIdentifier);
			NSString? ret;
			ret =  Runtime.GetNSObject<NSString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_ref_NativeHandle (class_ptr, selObjectWithItemProviderData_TypeIdentifier_Error_XHandle, data__handle__, nstypeIdentifier, &outErrorValue), false)!;
			GC.KeepAlive (data);
			CFString.ReleaseNative (nstypeIdentifier);
			outError = Runtime.GetNSObject<NSError> (outErrorValue)!;
			return ret!;
		}
		/// <param name="paragraphStartPosition">To be added.</param><param name="paragraphEndPosition">To be added.</param><param name="contentsEndPosition">To be added.</param><param name="range">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("getParagraphStart:end:contentsEnd:forRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void GetParagraphPositions (out nuint paragraphStartPosition, out nuint paragraphEndPosition, out nuint contentsEndPosition, NSRange range)
		{
			fixed (nuint* paragraphStartPosition__pointer = &paragraphStartPosition) {
			fixed (nuint* paragraphEndPosition__pointer = &paragraphEndPosition) {
			fixed (nuint* contentsEndPosition__pointer = &contentsEndPosition) {
			paragraphStartPosition = default;
			paragraphEndPosition = default;
			contentsEndPosition = default;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_out_UIntPtr_out_UIntPtr_out_UIntPtr_NSRange (this.Handle, selGetParagraphStart_End_ContentsEnd_ForRange_XHandle, paragraphStartPosition__pointer, paragraphEndPosition__pointer, contentsEndPosition__pointer, range);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_out_UIntPtr_out_UIntPtr_out_UIntPtr_NSRange (&__objc_super__, selGetParagraphStart_End_ContentsEnd_ForRange_XHandle, paragraphStartPosition__pointer, paragraphEndPosition__pointer, contentsEndPosition__pointer, range);
					GC.KeepAlive (this);
				}
			}
			}
			}
			}
		}
		[Export ("paragraphRangeForRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSRange GetParagraphRange (NSRange range)
		{
			NSRange ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.NSRange_objc_msgSend_NSRange (this.Handle, selParagraphRangeForRange_XHandle, range);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.NSRange_objc_msgSendSuper_NSRange (&__objc_super__, selParagraphRangeForRange_XHandle, range);
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
		/// <param name="width">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("variantFittingPresentationWidth:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSString GetVariantFittingPresentationWidth (nint width)
		{
			NSString ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_IntPtr (this.Handle, selVariantFittingPresentationWidth_XHandle, width), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_IntPtr (&__objc_super__, selVariantFittingPresentationWidth_XHandle, width), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
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
		[Export ("hasPrefix:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool HasPrefix (NSString prefix)
		{
			var prefix__handle__ = prefix!.GetNonNullHandle (nameof (prefix));
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (this.Handle, selHasPrefix_XHandle, prefix__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle (&__objc_super__, selHasPrefix_XHandle, prefix__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (prefix);
			return ret != 0;
		}
		[Export ("hasSuffix:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool HasSuffix (NSString suffix)
		{
			var suffix__handle__ = suffix!.GetNonNullHandle (nameof (suffix));
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (this.Handle, selHasSuffix_XHandle, suffix__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle (&__objc_super__, selHasSuffix_XHandle, suffix__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (suffix);
			return ret != 0;
		}
		/// <param name="handle">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public bool IsEqualTo (nint handle)
		{
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_IntPtr (this.Handle, selIsEqualToString_XHandle, handle);
			return ret != 0;
		}
		[Export ("lineRangeForRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSRange LineRangeForRange (NSRange range)
		{
			NSRange ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.NSRange_objc_msgSend_NSRange (this.Handle, selLineRangeForRange_XHandle, range);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.NSRange_objc_msgSendSuper_NSRange (&__objc_super__, selLineRangeForRange_XHandle, range);
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		/// <param name="typeIdentifier">A Universal Type Identifier (UTI) indicating the type of data to load.</param><param name="completionHandler">The method called after the data is loaded.</param><summary>Implement this method to customize the loading of data by an <see cref="T:Foundation.NSItemProvider" />.</summary><returns>An <see cref="T:Foundation.NSProgress" /> object reflecting the data-loading operation.</returns><remarks><para>The <paramref name="typeIdentifier" /> must be in the set of values returned by <see cref="Foundation.NSItemProviderWriting_Extensions.GetWritableTypeIdentifiersForItemProvider(Foundation.INSItemProviderWriting)" />.</para></remarks>
		[Export ("loadDataWithTypeIdentifier:forItemProviderCompletionHandler:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual NSProgress? LoadData (string typeIdentifier, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V16))]global::System.Action<NSData, NSError> completionHandler)
		{
			if (typeIdentifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (typeIdentifier));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			var nstypeIdentifier = CFString.CreateNative (typeIdentifier);
			using var block_completionHandler = Trampolines.SDActionArity2V16.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			NSProgress? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSProgress> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selLoadDataWithTypeIdentifier_ForItemProviderCompletionHandler_XHandle, nstypeIdentifier, (IntPtr) block_ptr_completionHandler), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSProgress> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selLoadDataWithTypeIdentifier_ForItemProviderCompletionHandler_XHandle, nstypeIdentifier, (IntPtr) block_ptr_completionHandler), false)!;
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nstypeIdentifier);
			return ret!;
		}
		/// <param name="typeIdentifier">A Universal Type Identifier (UTI) indicating the type of data to load.</param>
		/// <summary>Asynchronously loads data for the identified type from an item provider, returning a task that contains the data.</summary>
		/// <returns>To be added.</returns>
		/// <remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<NSData> LoadDataAsync (string typeIdentifier)
		{
			var tcs = new TaskCompletionSource<NSData> ();
			LoadData(typeIdentifier, (arg1_, arg2_) => {
				if (arg2_ is not null)
					tcs.SetException (new NSErrorException(arg2_));
				else
					tcs.SetResult (arg1_!);
			});
			return tcs.Task;
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<NSData> LoadDataAsync (string typeIdentifier, out NSProgress result)
		{
			var tcs = new TaskCompletionSource<NSData> ();
			result = LoadData(typeIdentifier, (arg1_, arg2_) => {
				if (arg2_ is not null)
					tcs.SetException (new NSErrorException(arg2_));
				else
					tcs.SetResult (arg1_!);
			})!;
			return tcs.Task;
		}
		[Export ("localizedCaseInsensitiveContainsString:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool LocalizedCaseInsensitiveContains (NSString str)
		{
			var str__handle__ = str!.GetNonNullHandle (nameof (str));
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (this.Handle, selLocalizedCaseInsensitiveContainsString_XHandle, str__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle (&__objc_super__, selLocalizedCaseInsensitiveContainsString_XHandle, str__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (str);
			return ret != 0;
		}
		[Export ("localizedStandardContainsString:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool LocalizedStandardContainsString (NSString str)
		{
			var str__handle__ = str!.GetNonNullHandle (nameof (str));
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (this.Handle, selLocalizedStandardContainsString_XHandle, str__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle (&__objc_super__, selLocalizedStandardContainsString_XHandle, str__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (str);
			return ret != 0;
		}
		[Export ("localizedStandardRangeOfString:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSRange LocalizedStandardRangeOfString (NSString str)
		{
			var str__handle__ = str!.GetNonNullHandle (nameof (str));
			NSRange ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.NSRange_objc_msgSend_NativeHandle (this.Handle, selLocalizedStandardRangeOfString_XHandle, str__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.NSRange_objc_msgSendSuper_NativeHandle (&__objc_super__, selLocalizedStandardRangeOfString_XHandle, str__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (str);
			return ret!;
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
		[Export ("pathWithComponents:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string[] PathWithComponents (string[] components)
		{
			if (components is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (components));
			using var nsa_components = NSArray.FromStrings (components);
			string[] ret;
			ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, selPathWithComponents_XHandle, nsa_components.Handle), false)!;
			return ret;
		}
		[Export ("stringByReplacingCharactersInRange:withString:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSString Replace (NSRange range, NSString replacement)
		{
			var replacement__handle__ = replacement!.GetNonNullHandle (nameof (replacement));
			NSString? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NSRange_NativeHandle (this.Handle, selStringByReplacingCharactersInRange_WithString_XHandle, range, replacement__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NSRange_NativeHandle (&__objc_super__, selStringByReplacingCharactersInRange_WithString_XHandle, range, replacement__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (replacement);
			return ret!;
		}
		[Export ("stringByResolvingSymlinksInPath")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSString ResolveSymlinksInPath ()
		{
			NSString ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selStringByResolvingSymlinksInPathXHandle), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selStringByResolvingSymlinksInPathXHandle), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("componentsSeparatedByString:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSString[] SeparateComponents (NSString separator)
		{
			var separator__handle__ = separator!.GetNonNullHandle (nameof (separator));
			NSString[]? ret;
			if (IsDirectBinding) {
				ret = CFArray.ArrayFromHandle<NSString>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selComponentsSeparatedByString_XHandle, separator__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFArray.ArrayFromHandle<NSString>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selComponentsSeparatedByString_XHandle, separator__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (separator);
			return ret!;
		}
		[Export ("componentsSeparatedByCharactersInSet:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSString[] SeparateComponents (NSCharacterSet separator)
		{
			var separator__handle__ = separator!.GetNonNullHandle (nameof (separator));
			NSString[]? ret;
			if (IsDirectBinding) {
				ret = CFArray.ArrayFromHandle<NSString>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selComponentsSeparatedByCharactersInSet_XHandle, separator__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFArray.ArrayFromHandle<NSString>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selComponentsSeparatedByCharactersInSet_XHandle, separator__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (separator);
			return ret!;
		}
		[Export ("stringByStandardizingPath")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSString StandarizePath ()
		{
			NSString ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selStringByStandardizingPathXHandle), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selStringByStandardizingPathXHandle), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		/// <param name="attributedStringAttributes">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public CGSize StringSize (NSDictionary? attributedStringAttributes)
		{
			var attributedStringAttributes__handle__ = attributedStringAttributes.GetHandle ();
			CGSize ret;
			ret = global::ObjCRuntime.Messaging.CGSize_objc_msgSend_NativeHandle (this.Handle, selSizeWithAttributes_XHandle, attributedStringAttributes__handle__);
			GC.KeepAlive (attributedStringAttributes);
			return ret!;
		}
		[Export ("lowercaseStringWithLocale:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string ToLower (NSLocale locale)
		{
			var locale__handle__ = locale!.GetNonNullHandle (nameof (locale));
			string? ret;
			if (IsDirectBinding) {
				ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selLowercaseStringWithLocale_XHandle, locale__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selLowercaseStringWithLocale_XHandle, locale__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (locale);
			return ret!;
		}
		[Export ("uppercaseStringWithLocale:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string ToUpper (NSLocale locale)
		{
			var locale__handle__ = locale!.GetNonNullHandle (nameof (locale));
			string? ret;
			if (IsDirectBinding) {
				ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selUppercaseStringWithLocale_XHandle, locale__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selUppercaseStringWithLocale_XHandle, locale__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (locale);
			return ret!;
		}
		[Export ("stringByApplyingTransform:reverse:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSString? TransliterateString (NSString transform, bool reverse)
		{
			var transform__handle__ = transform!.GetNonNullHandle (nameof (transform));
			NSString? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_bool (this.Handle, selStringByApplyingTransform_Reverse_XHandle, transform__handle__, reverse ? (byte) 1 : (byte) 0), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_bool (&__objc_super__, selStringByApplyingTransform_Reverse_XHandle, transform__handle__, reverse ? (byte) 1 : (byte) 0), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (transform);
			return ret!;
		}
		[Export ("characterAtIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal virtual char _characterAtIndex (nint index)
		{
			ushort ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.char_objc_msgSend_IntPtr (this.Handle, selCharacterAtIndex_XHandle, index);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.char_objc_msgSendSuper_IntPtr (&__objc_super__, selCharacterAtIndex_XHandle, index);
					GC.KeepAlive (this);
				}
			}
			return (char) ret;
		}
		/// <summary>Whether this is an absolute path.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool IsAbsolutePath {
			[Export ("isAbsolutePath")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsAbsolutePathXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsAbsolutePathXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSString LastPathComponent {
			[Export ("lastPathComponent")]
			get {
				NSString? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selLastPathComponentXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selLastPathComponentXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
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
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual NSString LocalizedCapitalizedString {
			[Export ("localizedCapitalizedString")]
			get {
				NSString? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selLocalizedCapitalizedStringXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selLocalizedCapitalizedStringXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual NSString LocalizedLowercaseString {
			[Export ("localizedLowercaseString")]
			get {
				NSString? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selLocalizedLowercaseStringXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selLocalizedLowercaseStringXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual NSString LocalizedUppercaseString {
			[Export ("localizedUppercaseString")]
			get {
				NSString? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selLocalizedUppercaseStringXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selLocalizedUppercaseStringXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string[] PathComponents {
			[Export ("pathComponents")]
			get {
				string[] ret;
				if (IsDirectBinding) {
					ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selPathComponentsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selPathComponentsXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSString PathExtension {
			[Export ("pathExtension")]
			get {
				NSString? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selPathExtensionXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selPathExtensionXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static string[] ReadableTypeIdentifiers {
			[Export ("readableTypeIdentifiersForItemProvider", ArgumentSemantic.Copy)]
			get {
				string[] ret;
				ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selReadableTypeIdentifiersForItemProviderXHandle), false)!;
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static string[] WritableTypeIdentifiers {
			[Export ("writableTypeIdentifiersForItemProvider", ArgumentSemantic.Copy)]
			get {
				string[] ret;
				ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selWritableTypeIdentifiersForItemProviderXHandle), false)!;
				return ret;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual string[] WritableTypeIdentifiersForItemProvider {
			[Export ("writableTypeIdentifiersForItemProvider", ArgumentSemantic.Copy)]
			get {
				string[] ret;
				if (IsDirectBinding) {
					ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selWritableTypeIdentifiersForItemProviderXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selWritableTypeIdentifiersForItemProviderXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _EncodingDetectionAllowLossyKey;
		/// <summary>Represents the value associated with the constant 'NSStringEncodingDetectionAllowLossyKey'.</summary>
		[Field ("NSStringEncodingDetectionAllowLossyKey",  "Foundation")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		internal static NSString EncodingDetectionAllowLossyKey {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_EncodingDetectionAllowLossyKey is null)
					_EncodingDetectionAllowLossyKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSStringEncodingDetectionAllowLossyKey")!;
				return _EncodingDetectionAllowLossyKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _EncodingDetectionDisallowedEncodingsKey;
		/// <summary>Represents the value associated with the constant 'NSStringEncodingDetectionDisallowedEncodingsKey'.</summary>
		[Field ("NSStringEncodingDetectionDisallowedEncodingsKey",  "Foundation")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		internal static NSString EncodingDetectionDisallowedEncodingsKey {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_EncodingDetectionDisallowedEncodingsKey is null)
					_EncodingDetectionDisallowedEncodingsKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSStringEncodingDetectionDisallowedEncodingsKey")!;
				return _EncodingDetectionDisallowedEncodingsKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _EncodingDetectionFromWindowsKey;
		/// <summary>Represents the value associated with the constant 'NSStringEncodingDetectionFromWindowsKey'.</summary>
		[Field ("NSStringEncodingDetectionFromWindowsKey",  "Foundation")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		internal static NSString EncodingDetectionFromWindowsKey {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_EncodingDetectionFromWindowsKey is null)
					_EncodingDetectionFromWindowsKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSStringEncodingDetectionFromWindowsKey")!;
				return _EncodingDetectionFromWindowsKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _EncodingDetectionLikelyLanguageKey;
		/// <summary>Represents the value associated with the constant 'NSStringEncodingDetectionLikelyLanguageKey'.</summary>
		[Field ("NSStringEncodingDetectionLikelyLanguageKey",  "Foundation")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		internal static NSString EncodingDetectionLikelyLanguageKey {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_EncodingDetectionLikelyLanguageKey is null)
					_EncodingDetectionLikelyLanguageKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSStringEncodingDetectionLikelyLanguageKey")!;
				return _EncodingDetectionLikelyLanguageKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _EncodingDetectionLossySubstitutionKey;
		/// <summary>Represents the value associated with the constant 'NSStringEncodingDetectionLossySubstitutionKey'.</summary>
		[Field ("NSStringEncodingDetectionLossySubstitutionKey",  "Foundation")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		internal static NSString EncodingDetectionLossySubstitutionKey {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_EncodingDetectionLossySubstitutionKey is null)
					_EncodingDetectionLossySubstitutionKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSStringEncodingDetectionLossySubstitutionKey")!;
				return _EncodingDetectionLossySubstitutionKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _EncodingDetectionSuggestedEncodingsKey;
		/// <summary>Represents the value associated with the constant 'NSStringEncodingDetectionSuggestedEncodingsKey'.</summary>
		[Field ("NSStringEncodingDetectionSuggestedEncodingsKey",  "Foundation")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		internal static NSString EncodingDetectionSuggestedEncodingsKey {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_EncodingDetectionSuggestedEncodingsKey is null)
					_EncodingDetectionSuggestedEncodingsKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSStringEncodingDetectionSuggestedEncodingsKey")!;
				return _EncodingDetectionSuggestedEncodingsKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _EncodingDetectionUseOnlySuggestedEncodingsKey;
		/// <summary>Represents the value associated with the constant 'NSStringEncodingDetectionUseOnlySuggestedEncodingsKey'.</summary>
		[Field ("NSStringEncodingDetectionUseOnlySuggestedEncodingsKey",  "Foundation")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		internal static NSString EncodingDetectionUseOnlySuggestedEncodingsKey {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_EncodingDetectionUseOnlySuggestedEncodingsKey is null)
					_EncodingDetectionUseOnlySuggestedEncodingsKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSStringEncodingDetectionUseOnlySuggestedEncodingsKey")!;
				return _EncodingDetectionUseOnlySuggestedEncodingsKey;
			}
		}
	} /* class NSString */
}
