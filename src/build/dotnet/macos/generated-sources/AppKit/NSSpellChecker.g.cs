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
	[Register("NSSpellChecker", true)]
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	public unsafe partial class NSSpellChecker : NSObject {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAccessoryViewX = "accessoryView";
		static readonly NativeHandle selAccessoryViewXHandle = Selector.GetHandle ("accessoryView");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAutomaticallyIdentifiesLanguagesX = "automaticallyIdentifiesLanguages";
		static readonly NativeHandle selAutomaticallyIdentifiesLanguagesXHandle = Selector.GetHandle ("automaticallyIdentifiesLanguages");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAvailableLanguagesX = "availableLanguages";
		static readonly NativeHandle selAvailableLanguagesXHandle = Selector.GetHandle ("availableLanguages");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCheckGrammarOfString_StartingAt_Language_Wrap_InSpellDocumentWithTag_Details_X = "checkGrammarOfString:startingAt:language:wrap:inSpellDocumentWithTag:details:";
		static readonly NativeHandle selCheckGrammarOfString_StartingAt_Language_Wrap_InSpellDocumentWithTag_Details_XHandle = Selector.GetHandle ("checkGrammarOfString:startingAt:language:wrap:inSpellDocumentWithTag:details:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCheckSpellingOfString_StartingAt_X = "checkSpellingOfString:startingAt:";
		static readonly NativeHandle selCheckSpellingOfString_StartingAt_XHandle = Selector.GetHandle ("checkSpellingOfString:startingAt:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCheckSpellingOfString_StartingAt_Language_Wrap_InSpellDocumentWithTag_WordCount_X = "checkSpellingOfString:startingAt:language:wrap:inSpellDocumentWithTag:wordCount:";
		static readonly NativeHandle selCheckSpellingOfString_StartingAt_Language_Wrap_InSpellDocumentWithTag_WordCount_XHandle = Selector.GetHandle ("checkSpellingOfString:startingAt:language:wrap:inSpellDocumentWithTag:wordCount:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCheckString_Range_Types_Options_InSpellDocumentWithTag_Orthography_WordCount_X = "checkString:range:types:options:inSpellDocumentWithTag:orthography:wordCount:";
		static readonly NativeHandle selCheckString_Range_Types_Options_InSpellDocumentWithTag_Orthography_WordCount_XHandle = Selector.GetHandle ("checkString:range:types:options:inSpellDocumentWithTag:orthography:wordCount:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCloseSpellDocumentWithTag_X = "closeSpellDocumentWithTag:";
		static readonly NativeHandle selCloseSpellDocumentWithTag_XHandle = Selector.GetHandle ("closeSpellDocumentWithTag:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCompletionsForPartialWordRange_InString_Language_InSpellDocumentWithTag_X = "completionsForPartialWordRange:inString:language:inSpellDocumentWithTag:";
		static readonly NativeHandle selCompletionsForPartialWordRange_InString_Language_InSpellDocumentWithTag_XHandle = Selector.GetHandle ("completionsForPartialWordRange:inString:language:inSpellDocumentWithTag:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCorrectionForWordRange_InString_Language_InSpellDocumentWithTag_X = "correctionForWordRange:inString:language:inSpellDocumentWithTag:";
		static readonly NativeHandle selCorrectionForWordRange_InString_Language_InSpellDocumentWithTag_XHandle = Selector.GetHandle ("correctionForWordRange:inString:language:inSpellDocumentWithTag:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCountWordsInString_Language_X = "countWordsInString:language:";
		static readonly NativeHandle selCountWordsInString_Language_XHandle = Selector.GetHandle ("countWordsInString:language:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDeletesAutospaceBetweenString_AndString_Language_X = "deletesAutospaceBetweenString:andString:language:";
		static readonly NativeHandle selDeletesAutospaceBetweenString_AndString_Language_XHandle = Selector.GetHandle ("deletesAutospaceBetweenString:andString:language:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDismissCorrectionIndicatorForView_X = "dismissCorrectionIndicatorForView:";
		static readonly NativeHandle selDismissCorrectionIndicatorForView_XHandle = Selector.GetHandle ("dismissCorrectionIndicatorForView:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selGuessesForWordRange_InString_Language_InSpellDocumentWithTag_X = "guessesForWordRange:inString:language:inSpellDocumentWithTag:";
		static readonly NativeHandle selGuessesForWordRange_InString_Language_InSpellDocumentWithTag_XHandle = Selector.GetHandle ("guessesForWordRange:inString:language:inSpellDocumentWithTag:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selHasLearnedWord_X = "hasLearnedWord:";
		static readonly NativeHandle selHasLearnedWord_XHandle = Selector.GetHandle ("hasLearnedWord:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIgnoreWord_InSpellDocumentWithTag_X = "ignoreWord:inSpellDocumentWithTag:";
		static readonly NativeHandle selIgnoreWord_InSpellDocumentWithTag_XHandle = Selector.GetHandle ("ignoreWord:inSpellDocumentWithTag:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIgnoredWordsInSpellDocumentWithTag_X = "ignoredWordsInSpellDocumentWithTag:";
		static readonly NativeHandle selIgnoredWordsInSpellDocumentWithTag_XHandle = Selector.GetHandle ("ignoredWordsInSpellDocumentWithTag:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsAutomaticCapitalizationEnabledX = "isAutomaticCapitalizationEnabled";
		static readonly NativeHandle selIsAutomaticCapitalizationEnabledXHandle = Selector.GetHandle ("isAutomaticCapitalizationEnabled");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsAutomaticDashSubstitutionEnabledX = "isAutomaticDashSubstitutionEnabled";
		static readonly NativeHandle selIsAutomaticDashSubstitutionEnabledXHandle = Selector.GetHandle ("isAutomaticDashSubstitutionEnabled");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsAutomaticInlinePredictionEnabledX = "isAutomaticInlinePredictionEnabled";
		static readonly NativeHandle selIsAutomaticInlinePredictionEnabledXHandle = Selector.GetHandle ("isAutomaticInlinePredictionEnabled");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsAutomaticPeriodSubstitutionEnabledX = "isAutomaticPeriodSubstitutionEnabled";
		static readonly NativeHandle selIsAutomaticPeriodSubstitutionEnabledXHandle = Selector.GetHandle ("isAutomaticPeriodSubstitutionEnabled");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsAutomaticQuoteSubstitutionEnabledX = "isAutomaticQuoteSubstitutionEnabled";
		static readonly NativeHandle selIsAutomaticQuoteSubstitutionEnabledXHandle = Selector.GetHandle ("isAutomaticQuoteSubstitutionEnabled");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsAutomaticSpellingCorrectionEnabledX = "isAutomaticSpellingCorrectionEnabled";
		static readonly NativeHandle selIsAutomaticSpellingCorrectionEnabledXHandle = Selector.GetHandle ("isAutomaticSpellingCorrectionEnabled");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsAutomaticTextCompletionEnabledX = "isAutomaticTextCompletionEnabled";
		static readonly NativeHandle selIsAutomaticTextCompletionEnabledXHandle = Selector.GetHandle ("isAutomaticTextCompletionEnabled");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsAutomaticTextReplacementEnabledX = "isAutomaticTextReplacementEnabled";
		static readonly NativeHandle selIsAutomaticTextReplacementEnabledXHandle = Selector.GetHandle ("isAutomaticTextReplacementEnabled");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLanguageX = "language";
		static readonly NativeHandle selLanguageXHandle = Selector.GetHandle ("language");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLanguageForWordRange_InString_Orthography_X = "languageForWordRange:inString:orthography:";
		static readonly NativeHandle selLanguageForWordRange_InString_Orthography_XHandle = Selector.GetHandle ("languageForWordRange:inString:orthography:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLearnWord_X = "learnWord:";
		static readonly NativeHandle selLearnWord_XHandle = Selector.GetHandle ("learnWord:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMenuForResult_String_Options_AtLocation_InView_X = "menuForResult:string:options:atLocation:inView:";
		static readonly NativeHandle selMenuForResult_String_Options_AtLocation_InView_XHandle = Selector.GetHandle ("menuForResult:string:options:atLocation:inView:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPreventsAutocorrectionBeforeString_Language_X = "preventsAutocorrectionBeforeString:language:";
		static readonly NativeHandle selPreventsAutocorrectionBeforeString_Language_XHandle = Selector.GetHandle ("preventsAutocorrectionBeforeString:language:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRecordResponse_ToCorrection_ForWord_Language_InSpellDocumentWithTag_X = "recordResponse:toCorrection:forWord:language:inSpellDocumentWithTag:";
		static readonly NativeHandle selRecordResponse_ToCorrection_ForWord_Language_InSpellDocumentWithTag_XHandle = Selector.GetHandle ("recordResponse:toCorrection:forWord:language:inSpellDocumentWithTag:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRequestCandidatesForSelectedRange_InString_Types_Options_InSpellDocumentWithTag_CompletionHandler_X = "requestCandidatesForSelectedRange:inString:types:options:inSpellDocumentWithTag:completionHandler:";
		static readonly NativeHandle selRequestCandidatesForSelectedRange_InString_Types_Options_InSpellDocumentWithTag_CompletionHandler_XHandle = Selector.GetHandle ("requestCandidatesForSelectedRange:inString:types:options:inSpellDocumentWithTag:completionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRequestCheckingOfString_Range_Types_Options_InSpellDocumentWithTag_CompletionHandler_X = "requestCheckingOfString:range:types:options:inSpellDocumentWithTag:completionHandler:";
		static readonly NativeHandle selRequestCheckingOfString_Range_Types_Options_InSpellDocumentWithTag_CompletionHandler_XHandle = Selector.GetHandle ("requestCheckingOfString:range:types:options:inSpellDocumentWithTag:completionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAccessoryView_X = "setAccessoryView:";
		static readonly NativeHandle selSetAccessoryView_XHandle = Selector.GetHandle ("setAccessoryView:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAutomaticallyIdentifiesLanguages_X = "setAutomaticallyIdentifiesLanguages:";
		static readonly NativeHandle selSetAutomaticallyIdentifiesLanguages_XHandle = Selector.GetHandle ("setAutomaticallyIdentifiesLanguages:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetIgnoredWords_InSpellDocumentWithTag_X = "setIgnoredWords:inSpellDocumentWithTag:";
		static readonly NativeHandle selSetIgnoredWords_InSpellDocumentWithTag_XHandle = Selector.GetHandle ("setIgnoredWords:inSpellDocumentWithTag:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetLanguage_X = "setLanguage:";
		static readonly NativeHandle selSetLanguage_XHandle = Selector.GetHandle ("setLanguage:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetSubstitutionsPanelAccessoryViewController_X = "setSubstitutionsPanelAccessoryViewController:";
		static readonly NativeHandle selSetSubstitutionsPanelAccessoryViewController_XHandle = Selector.GetHandle ("setSubstitutionsPanelAccessoryViewController:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetWordFieldStringValue_X = "setWordFieldStringValue:";
		static readonly NativeHandle selSetWordFieldStringValue_XHandle = Selector.GetHandle ("setWordFieldStringValue:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSharedSpellCheckerX = "sharedSpellChecker";
		static readonly NativeHandle selSharedSpellCheckerXHandle = Selector.GetHandle ("sharedSpellChecker");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSharedSpellCheckerExistsX = "sharedSpellCheckerExists";
		static readonly NativeHandle selSharedSpellCheckerExistsXHandle = Selector.GetHandle ("sharedSpellCheckerExists");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selShowCorrectionIndicatorOfType_PrimaryString_AlternativeStrings_ForStringInRect_View_CompletionHandler_X = "showCorrectionIndicatorOfType:primaryString:alternativeStrings:forStringInRect:view:completionHandler:";
		static readonly NativeHandle selShowCorrectionIndicatorOfType_PrimaryString_AlternativeStrings_ForStringInRect_View_CompletionHandler_XHandle = Selector.GetHandle ("showCorrectionIndicatorOfType:primaryString:alternativeStrings:forStringInRect:view:completionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selShowInlinePredictionForCandidates_Client_X = "showInlinePredictionForCandidates:client:";
		static readonly NativeHandle selShowInlinePredictionForCandidates_Client_XHandle = Selector.GetHandle ("showInlinePredictionForCandidates:client:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSpellingPanelX = "spellingPanel";
		static readonly NativeHandle selSpellingPanelXHandle = Selector.GetHandle ("spellingPanel");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSubstitutionsPanelX = "substitutionsPanel";
		static readonly NativeHandle selSubstitutionsPanelXHandle = Selector.GetHandle ("substitutionsPanel");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSubstitutionsPanelAccessoryViewControllerX = "substitutionsPanelAccessoryViewController";
		static readonly NativeHandle selSubstitutionsPanelAccessoryViewControllerXHandle = Selector.GetHandle ("substitutionsPanelAccessoryViewController");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selUniqueSpellDocumentTagX = "uniqueSpellDocumentTag";
		static readonly NativeHandle selUniqueSpellDocumentTagXHandle = Selector.GetHandle ("uniqueSpellDocumentTag");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selUnlearnWord_X = "unlearnWord:";
		static readonly NativeHandle selUnlearnWord_XHandle = Selector.GetHandle ("unlearnWord:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selUpdatePanelsX = "updatePanels";
		static readonly NativeHandle selUpdatePanelsXHandle = Selector.GetHandle ("updatePanels");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selUpdateSpellingPanelWithGrammarString_Detail_X = "updateSpellingPanelWithGrammarString:detail:";
		static readonly NativeHandle selUpdateSpellingPanelWithGrammarString_Detail_XHandle = Selector.GetHandle ("updateSpellingPanelWithGrammarString:detail:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selUpdateSpellingPanelWithMisspelledWord_X = "updateSpellingPanelWithMisspelledWord:";
		static readonly NativeHandle selUpdateSpellingPanelWithMisspelledWord_XHandle = Selector.GetHandle ("updateSpellingPanelWithMisspelledWord:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selUserPreferredLanguagesX = "userPreferredLanguages";
		static readonly NativeHandle selUserPreferredLanguagesXHandle = Selector.GetHandle ("userPreferredLanguages");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selUserQuotesArrayForLanguage_X = "userQuotesArrayForLanguage:";
		static readonly NativeHandle selUserQuotesArrayForLanguage_XHandle = Selector.GetHandle ("userQuotesArrayForLanguage:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selUserReplacementsDictionaryX = "userReplacementsDictionary";
		static readonly NativeHandle selUserReplacementsDictionaryXHandle = Selector.GetHandle ("userReplacementsDictionary");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("NSSpellChecker");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		/// <summary>Creates a new <see cref="NSSpellChecker" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public NSSpellChecker () : base (NSObjectFlag.Empty)
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
		protected NSSpellChecker (NSObjectFlag t) : base (t)
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
		protected internal NSSpellChecker (NativeHandle handle) : base (handle)
		{
		}

		[Export ("checkGrammarOfString:startingAt:language:wrap:inSpellDocumentWithTag:details:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSRange CheckGrammar (string stringToCheck, nint startingOffset, string language, bool wrapFlag, nint documentTag, NSDictionary[] details)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (stringToCheck is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (stringToCheck));
			if (language is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (language));
			if (details is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (details));
			var nsstringToCheck = CFString.CreateNative (stringToCheck);
			var nslanguage = CFString.CreateNative (language);
			using var nsa_details = NSArray.FromNSObjects (details);
			NSRange ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.NSRange_objc_msgSend_NativeHandle_IntPtr_NativeHandle_bool_IntPtr_NativeHandle (this.Handle, selCheckGrammarOfString_StartingAt_Language_Wrap_InSpellDocumentWithTag_Details_XHandle, nsstringToCheck, startingOffset, nslanguage, wrapFlag ? (byte) 1 : (byte) 0, documentTag, nsa_details.Handle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.NSRange_objc_msgSendSuper_NativeHandle_IntPtr_NativeHandle_bool_IntPtr_NativeHandle (&__objc_super__, selCheckGrammarOfString_StartingAt_Language_Wrap_InSpellDocumentWithTag_Details_XHandle, nsstringToCheck, startingOffset, nslanguage, wrapFlag ? (byte) 1 : (byte) 0, documentTag, nsa_details.Handle);
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsstringToCheck);
			CFString.ReleaseNative (nslanguage);
			return ret!;
		}
		[Export ("checkSpellingOfString:startingAt:language:wrap:inSpellDocumentWithTag:wordCount:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual NSRange CheckSpelling (string stringToCheck, nint startingOffset, string language, bool wrapFlag, nint documentTag, out nint wordCount)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (stringToCheck is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (stringToCheck));
			if (language is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (language));
			fixed (nint* wordCount__pointer = &wordCount) {
			var nsstringToCheck = CFString.CreateNative (stringToCheck);
			var nslanguage = CFString.CreateNative (language);
			wordCount = default;
			NSRange ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.NSRange_objc_msgSend_NativeHandle_IntPtr_NativeHandle_bool_IntPtr_out_IntPtr (this.Handle, selCheckSpellingOfString_StartingAt_Language_Wrap_InSpellDocumentWithTag_WordCount_XHandle, nsstringToCheck, startingOffset, nslanguage, wrapFlag ? (byte) 1 : (byte) 0, documentTag, wordCount__pointer);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.NSRange_objc_msgSendSuper_NativeHandle_IntPtr_NativeHandle_bool_IntPtr_out_IntPtr (&__objc_super__, selCheckSpellingOfString_StartingAt_Language_Wrap_InSpellDocumentWithTag_WordCount_XHandle, nsstringToCheck, startingOffset, nslanguage, wrapFlag ? (byte) 1 : (byte) 0, documentTag, wordCount__pointer);
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsstringToCheck);
			CFString.ReleaseNative (nslanguage);
			return ret!;
			}
		}
		[Export ("checkSpellingOfString:startingAt:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSRange CheckSpelling (string stringToCheck, nint startingOffset)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (stringToCheck is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (stringToCheck));
			var nsstringToCheck = CFString.CreateNative (stringToCheck);
			NSRange ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.NSRange_objc_msgSend_NativeHandle_IntPtr (this.Handle, selCheckSpellingOfString_StartingAt_XHandle, nsstringToCheck, startingOffset);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.NSRange_objc_msgSendSuper_NativeHandle_IntPtr (&__objc_super__, selCheckSpellingOfString_StartingAt_XHandle, nsstringToCheck, startingOffset);
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsstringToCheck);
			return ret!;
		}
		[Export ("checkString:range:types:options:inSpellDocumentWithTag:orthography:wordCount:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual NSTextCheckingResult[] CheckString (string stringToCheck, NSRange range, NSTextCheckingTypes checkingTypes, NSDictionary? options, nint tag, out NSOrthography orthography, out nint wordCount)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (stringToCheck is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (stringToCheck));
			var options__handle__ = options.GetHandle ();
			NativeHandle orthographyValue = IntPtr.Zero;
			fixed (nint* wordCount__pointer = &wordCount) {
			var nsstringToCheck = CFString.CreateNative (stringToCheck);
			wordCount = default;
			NSTextCheckingResult[]? ret;
			if (IsDirectBinding) {
				ret = CFArray.ArrayFromHandle<NSTextCheckingResult>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NSRange_UInt64_NativeHandle_IntPtr_ref_NativeHandle_out_IntPtr (this.Handle, selCheckString_Range_Types_Options_InSpellDocumentWithTag_Orthography_WordCount_XHandle, nsstringToCheck, range, (UInt64)checkingTypes, options__handle__, tag, &orthographyValue, wordCount__pointer), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFArray.ArrayFromHandle<NSTextCheckingResult>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NSRange_UInt64_NativeHandle_IntPtr_ref_NativeHandle_out_IntPtr (&__objc_super__, selCheckString_Range_Types_Options_InSpellDocumentWithTag_Orthography_WordCount_XHandle, nsstringToCheck, range, (UInt64)checkingTypes, options__handle__, tag, &orthographyValue, wordCount__pointer), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (options);
			CFString.ReleaseNative (nsstringToCheck);
			orthography = Runtime.GetNSObject<NSOrthography> (orthographyValue)!;
			return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NSTextCheckingResult[] CheckString (string stringToCheck, NSRange range, NSTextCheckingTypes checkingTypes, NSTextCheckingOptions options, nint tag, out NSOrthography orthography, out nint wordCount)
		{
			return CheckString (stringToCheck, range, checkingTypes, options.GetDictionary (), tag, out orthography, out wordCount);
		}
		[Export ("closeSpellDocumentWithTag:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void CloseSpellDocument (nint documentTag)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selCloseSpellDocumentWithTag_XHandle, documentTag);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, selCloseSpellDocumentWithTag_XHandle, documentTag);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("completionsForPartialWordRange:inString:language:inSpellDocumentWithTag:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string[] CompletionsForPartialWordRange (NSRange range, string theString, string language, nint documentTag)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (theString is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (theString));
			if (language is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (language));
			var nstheString = CFString.CreateNative (theString);
			var nslanguage = CFString.CreateNative (language);
			string[]? ret;
			if (IsDirectBinding) {
				ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NSRange_NativeHandle_NativeHandle_IntPtr (this.Handle, selCompletionsForPartialWordRange_InString_Language_InSpellDocumentWithTag_XHandle, range, nstheString, nslanguage, documentTag), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NSRange_NativeHandle_NativeHandle_IntPtr (&__objc_super__, selCompletionsForPartialWordRange_InString_Language_InSpellDocumentWithTag_XHandle, range, nstheString, nslanguage, documentTag), false)!;
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nstheString);
			CFString.ReleaseNative (nslanguage);
			return ret!;
		}
		[Export ("countWordsInString:language:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint CountWords (string stringToCount, string language)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (stringToCount is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (stringToCount));
			if (language is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (language));
			var nsstringToCount = CFString.CreateNative (stringToCount);
			var nslanguage = CFString.CreateNative (language);
			nint ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selCountWordsInString_Language_XHandle, nsstringToCount, nslanguage);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selCountWordsInString_Language_XHandle, nsstringToCount, nslanguage);
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsstringToCount);
			CFString.ReleaseNative (nslanguage);
			return ret!;
		}
		[Export ("deletesAutospaceBetweenString:andString:language:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool DeletesAutospace (string precedingString, string followingString, string? language)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (precedingString is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (precedingString));
			if (followingString is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (followingString));
			var nsprecedingString = CFString.CreateNative (precedingString);
			var nsfollowingString = CFString.CreateNative (followingString);
			var nslanguage = CFString.CreateNative (language);
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, selDeletesAutospaceBetweenString_AndString_Language_XHandle, nsprecedingString, nsfollowingString, nslanguage);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, selDeletesAutospaceBetweenString_AndString_Language_XHandle, nsprecedingString, nsfollowingString, nslanguage);
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsprecedingString);
			CFString.ReleaseNative (nsfollowingString);
			CFString.ReleaseNative (nslanguage);
			return ret != 0;
		}
		[Export ("dismissCorrectionIndicatorForView:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DismissCorrectionIndicator (NSView forView)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var forView__handle__ = forView!.GetNonNullHandle (nameof (forView));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selDismissCorrectionIndicatorForView_XHandle, forView__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selDismissCorrectionIndicatorForView_XHandle, forView__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (forView);
		}
		[Export ("correctionForWordRange:inString:language:inSpellDocumentWithTag:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string GetCorrection (NSRange forWordRange, string inString, string language, nint inSpellDocumentWithTag)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (inString is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (inString));
			if (language is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (language));
			var nsinString = CFString.CreateNative (inString);
			var nslanguage = CFString.CreateNative (language);
			string? ret;
			if (IsDirectBinding) {
				ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NSRange_NativeHandle_NativeHandle_IntPtr (this.Handle, selCorrectionForWordRange_InString_Language_InSpellDocumentWithTag_XHandle, forWordRange, nsinString, nslanguage, inSpellDocumentWithTag), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NSRange_NativeHandle_NativeHandle_IntPtr (&__objc_super__, selCorrectionForWordRange_InString_Language_InSpellDocumentWithTag_XHandle, forWordRange, nsinString, nslanguage, inSpellDocumentWithTag), false)!;
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsinString);
			CFString.ReleaseNative (nslanguage);
			return ret!;
		}
		[Export ("language")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		protected virtual string GetLanguage ()
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			string ret;
			if (IsDirectBinding) {
				ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selLanguageXHandle), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selLanguageXHandle), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("languageForWordRange:inString:orthography:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string GetLanguage (NSRange forWordRange, string inString, NSOrthography orthography)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (inString is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (inString));
			var orthography__handle__ = orthography!.GetNonNullHandle (nameof (orthography));
			var nsinString = CFString.CreateNative (inString);
			string? ret;
			if (IsDirectBinding) {
				ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NSRange_NativeHandle_NativeHandle (this.Handle, selLanguageForWordRange_InString_Orthography_XHandle, forWordRange, nsinString, orthography__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NSRange_NativeHandle_NativeHandle (&__objc_super__, selLanguageForWordRange_InString_Orthography_XHandle, forWordRange, nsinString, orthography__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (orthography);
			CFString.ReleaseNative (nsinString);
			return ret!;
		}
		[Export ("guessesForWordRange:inString:language:inSpellDocumentWithTag:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string[] GuessesForWordRange (NSRange range, string theString, string language, nint documentTag)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (theString is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (theString));
			if (language is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (language));
			var nstheString = CFString.CreateNative (theString);
			var nslanguage = CFString.CreateNative (language);
			string[]? ret;
			if (IsDirectBinding) {
				ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NSRange_NativeHandle_NativeHandle_IntPtr (this.Handle, selGuessesForWordRange_InString_Language_InSpellDocumentWithTag_XHandle, range, nstheString, nslanguage, documentTag), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NSRange_NativeHandle_NativeHandle_IntPtr (&__objc_super__, selGuessesForWordRange_InString_Language_InSpellDocumentWithTag_XHandle, range, nstheString, nslanguage, documentTag), false)!;
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nstheString);
			CFString.ReleaseNative (nslanguage);
			return ret!;
		}
		[Export ("hasLearnedWord:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool HasLearnedWord (string word)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (word is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (word));
			var nsword = CFString.CreateNative (word);
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (this.Handle, selHasLearnedWord_XHandle, nsword);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle (&__objc_super__, selHasLearnedWord_XHandle, nsword);
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsword);
			return ret != 0;
		}
		[Export ("ignoreWord:inSpellDocumentWithTag:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void IgnoreWord (string wordToIgnore, nint documentTag)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (wordToIgnore is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (wordToIgnore));
			var nswordToIgnore = CFString.CreateNative (wordToIgnore);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_IntPtr (this.Handle, selIgnoreWord_InSpellDocumentWithTag_XHandle, nswordToIgnore, documentTag);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_IntPtr (&__objc_super__, selIgnoreWord_InSpellDocumentWithTag_XHandle, nswordToIgnore, documentTag);
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nswordToIgnore);
		}
		[Export ("ignoredWordsInSpellDocumentWithTag:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string[] IgnoredWords (nint documentTag)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			string[] ret;
			if (IsDirectBinding) {
				ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_IntPtr (this.Handle, selIgnoredWordsInSpellDocumentWithTag_XHandle, documentTag), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_IntPtr (&__objc_super__, selIgnoredWordsInSpellDocumentWithTag_XHandle, documentTag), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		/// <summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("isAutomaticDashSubstitutionEnabled")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool IsAutomaticDashSubstitutionEnabled ()
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (class_ptr, selIsAutomaticDashSubstitutionEnabledXHandle);
			return ret != 0;
		}
		/// <summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("isAutomaticQuoteSubstitutionEnabled")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool IsAutomaticQuoteSubstitutionEnabled ()
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (class_ptr, selIsAutomaticQuoteSubstitutionEnabledXHandle);
			return ret != 0;
		}
		[Export ("learnWord:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void LearnWord (string word)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (word is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (word));
			var nsword = CFString.CreateNative (word);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selLearnWord_XHandle, nsword);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selLearnWord_XHandle, nsword);
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsword);
		}
		[Export ("menuForResult:string:options:atLocation:inView:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSMenu MenuForResults (NSTextCheckingResult result, string checkedString, NSDictionary options, CGPoint location, NSView view)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var result__handle__ = result!.GetNonNullHandle (nameof (result));
			if (checkedString is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (checkedString));
			var options__handle__ = options!.GetNonNullHandle (nameof (options));
			var view__handle__ = view!.GetNonNullHandle (nameof (view));
			var nscheckedString = CFString.CreateNative (checkedString);
			NSMenu? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSMenu> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_CGPoint_NativeHandle (this.Handle, selMenuForResult_String_Options_AtLocation_InView_XHandle, result__handle__, nscheckedString, options__handle__, location, view__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSMenu> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle_CGPoint_NativeHandle (&__objc_super__, selMenuForResult_String_Options_AtLocation_InView_XHandle, result__handle__, nscheckedString, options__handle__, location, view__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (result);
			GC.KeepAlive (options);
			GC.KeepAlive (view);
			CFString.ReleaseNative (nscheckedString);
			return ret!;
		}
		/// <param name="result">To be added.</param><param name="checkedString">To be added.</param><param name="options">To be added.</param><param name="location">To be added.</param><param name="view">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSMenu MenuForResults (NSTextCheckingResult result, string checkedString, NSTextCheckingOptions options, CGPoint location, NSView view)
		{
			return MenuForResults (result, checkedString, options.GetDictionary ()!, location, view);
		}
		[Export ("preventsAutocorrectionBeforeString:language:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool PreventsAutocorrectionBefore (string aString, string? language)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (aString is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (aString));
			var nsaString = CFString.CreateNative (aString);
			var nslanguage = CFString.CreateNative (language);
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selPreventsAutocorrectionBeforeString_Language_XHandle, nsaString, nslanguage);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selPreventsAutocorrectionBeforeString_Language_XHandle, nsaString, nslanguage);
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsaString);
			CFString.ReleaseNative (nslanguage);
			return ret != 0;
		}
		[Export ("recordResponse:toCorrection:forWord:language:inSpellDocumentWithTag:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RecordResponse (NSCorrectionResponse response, string toCorrection, string forWord, string language, nint inSpellDocumentWithTag)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (toCorrection is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (toCorrection));
			if (forWord is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (forWord));
			if (language is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (language));
			var nstoCorrection = CFString.CreateNative (toCorrection);
			var nsforWord = CFString.CreateNative (forWord);
			var nslanguage = CFString.CreateNative (language);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_NativeHandle_NativeHandle_NativeHandle_IntPtr (this.Handle, selRecordResponse_ToCorrection_ForWord_Language_InSpellDocumentWithTag_XHandle, (IntPtr) (long) response, nstoCorrection, nsforWord, nslanguage, inSpellDocumentWithTag);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_NativeHandle_NativeHandle_NativeHandle_IntPtr (&__objc_super__, selRecordResponse_ToCorrection_ForWord_Language_InSpellDocumentWithTag_XHandle, (IntPtr) (long) response, nstoCorrection, nsforWord, nslanguage, inSpellDocumentWithTag);
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nstoCorrection);
			CFString.ReleaseNative (nsforWord);
			CFString.ReleaseNative (nslanguage);
		}
		[Export ("requestCandidatesForSelectedRange:inString:types:options:inSpellDocumentWithTag:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual nint RequestCandidates (NSRange selectedRange, string stringToCheck, ulong checkingTypes, NSDictionary<NSString, NSObject>? options, nint tag, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V24))]global::System.Action<nint, NSTextCheckingResult[]>? completionHandler)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (stringToCheck is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (stringToCheck));
			var options__handle__ = options.GetHandle ();
			var nsstringToCheck = CFString.CreateNative (stringToCheck);
			using var block_completionHandler = Trampolines.SDActionArity2V24.CreateNullableBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = null;
			if (completionHandler is not null)
				block_ptr_completionHandler = &block_completionHandler;
			nint ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_NSRange_NativeHandle_UInt64_NativeHandle_IntPtr_NativeHandle (this.Handle, selRequestCandidatesForSelectedRange_InString_Types_Options_InSpellDocumentWithTag_CompletionHandler_XHandle, selectedRange, nsstringToCheck, checkingTypes, options__handle__, tag, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_NSRange_NativeHandle_UInt64_NativeHandle_IntPtr_NativeHandle (&__objc_super__, selRequestCandidatesForSelectedRange_InString_Types_Options_InSpellDocumentWithTag_CompletionHandler_XHandle, selectedRange, nsstringToCheck, checkingTypes, options__handle__, tag, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (options);
			CFString.ReleaseNative (nsstringToCheck);
			return ret!;
		}
		/// <param name="selectedRange">To be added.</param>
		/// <param name="stringToCheck">To be added.</param>
		/// <param name="checkingTypes">To be added.</param>
		/// <param name="options">To be added.</param>
		/// <param name="tag">To be added.</param>
		/// <summary>To be added.</summary>
		/// <returns>To be added.</returns>
		/// <remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<NSSpellCheckerCandidates> RequestCandidatesAsync (NSRange selectedRange, string stringToCheck, ulong checkingTypes, NSDictionary<NSString, NSObject>? options, nint tag)
		{
			var tcs = new TaskCompletionSource<NSSpellCheckerCandidates> ();
			RequestCandidates(selectedRange, stringToCheck, checkingTypes, options, tag, (arg1_, arg2_) => {
				tcs.SetResult (new NSSpellCheckerCandidates (arg1_!, arg2_!));
			});
			return tcs.Task;
		}
		/// <param name="selectedRange">To be added.</param>
		/// <param name="stringToCheck">To be added.</param>
		/// <param name="checkingTypes">To be added.</param>
		/// <param name="options">To be added.</param>
		/// <param name="tag">To be added.</param>
		/// <param name="result">To be added.</param>
		/// <summary>To be added.</summary>
		/// <returns>To be added.</returns>
		/// <remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<NSSpellCheckerCandidates> RequestCandidatesAsync (NSRange selectedRange, string stringToCheck, ulong checkingTypes, NSDictionary<NSString, NSObject>? options, nint tag, out nint result)
		{
			var tcs = new TaskCompletionSource<NSSpellCheckerCandidates> ();
			result = RequestCandidates(selectedRange, stringToCheck, checkingTypes, options, tag, (arg1_, arg2_) => {
				tcs.SetResult (new NSSpellCheckerCandidates (arg1_!, arg2_!));
			})!;
			return tcs.Task;
		}
		[Export ("requestCheckingOfString:range:types:options:inSpellDocumentWithTag:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual nint RequestChecking (string stringToCheck, NSRange range, NSTextCheckingTypes checkingTypes, NSDictionary? options, nint tag, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity4V0))]global::System.Action<nint, NSTextCheckingResult[], NSOrthography, nint> completionHandler)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (stringToCheck is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (stringToCheck));
			var options__handle__ = options.GetHandle ();
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			var nsstringToCheck = CFString.CreateNative (stringToCheck);
			using var block_completionHandler = Trampolines.SDActionArity4V0.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			nint ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_NativeHandle_NSRange_UInt64_NativeHandle_IntPtr_NativeHandle (this.Handle, selRequestCheckingOfString_Range_Types_Options_InSpellDocumentWithTag_CompletionHandler_XHandle, nsstringToCheck, range, (UInt64)checkingTypes, options__handle__, tag, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_NativeHandle_NSRange_UInt64_NativeHandle_IntPtr_NativeHandle (&__objc_super__, selRequestCheckingOfString_Range_Types_Options_InSpellDocumentWithTag_CompletionHandler_XHandle, nsstringToCheck, range, (UInt64)checkingTypes, options__handle__, tag, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (options);
			CFString.ReleaseNative (nsstringToCheck);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe nint RequestChecking (string stringToCheck, NSRange range, NSTextCheckingTypes checkingTypes, NSTextCheckingOptions options, nint tag, global::System.Action<nint, NSTextCheckingResult[], NSOrthography, nint> completionHandler)
		{
			return RequestChecking (stringToCheck, range, checkingTypes, options.GetDictionary (), tag, completionHandler);
		}
		[Export ("setIgnoredWords:inSpellDocumentWithTag:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetIgnoredWords (string[] words, nint documentTag)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (words is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (words));
			using var nsa_words = NSArray.FromStrings (words);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_IntPtr (this.Handle, selSetIgnoredWords_InSpellDocumentWithTag_XHandle, nsa_words.Handle, documentTag);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_IntPtr (&__objc_super__, selSetIgnoredWords_InSpellDocumentWithTag_XHandle, nsa_words.Handle, documentTag);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("setLanguage:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		protected virtual bool SetLanguage (string language)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (language is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (language));
			var nslanguage = CFString.CreateNative (language);
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (this.Handle, selSetLanguage_XHandle, nslanguage);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetLanguage_XHandle, nslanguage);
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nslanguage);
			return ret != 0;
		}
		[Export ("setWordFieldStringValue:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetWordFieldStringValue (string aString)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (aString is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (aString));
			var nsaString = CFString.CreateNative (aString);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetWordFieldStringValue_XHandle, nsaString);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetWordFieldStringValue_XHandle, nsaString);
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsaString);
		}
		[Export ("showCorrectionIndicatorOfType:primaryString:alternativeStrings:forStringInRect:view:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void ShowCorrectionIndicatorOfType (NSCorrectionIndicatorType type, string primaryString, string[] alternativeStrings, CGRect forStringInRect, NSRulerView view, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDNSSpellCheckerShowCorrectionIndicatorOfTypeHandler))]NSSpellCheckerShowCorrectionIndicatorOfTypeHandler completionHandler)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (primaryString is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (primaryString));
			if (alternativeStrings is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (alternativeStrings));
			var view__handle__ = view!.GetNonNullHandle (nameof (view));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			var nsprimaryString = CFString.CreateNative (primaryString);
			using var nsa_alternativeStrings = NSArray.FromStrings (alternativeStrings);
			using var block_completionHandler = Trampolines.SDNSSpellCheckerShowCorrectionIndicatorOfTypeHandler.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_NativeHandle_NativeHandle_CGRect_NativeHandle_NativeHandle (this.Handle, selShowCorrectionIndicatorOfType_PrimaryString_AlternativeStrings_ForStringInRect_View_CompletionHandler_XHandle, (IntPtr) (long) type, nsprimaryString, nsa_alternativeStrings.Handle, forStringInRect, view__handle__, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_NativeHandle_NativeHandle_CGRect_NativeHandle_NativeHandle (&__objc_super__, selShowCorrectionIndicatorOfType_PrimaryString_AlternativeStrings_ForStringInRect_View_CompletionHandler_XHandle, (IntPtr) (long) type, nsprimaryString, nsa_alternativeStrings.Handle, forStringInRect, view__handle__, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (view);
			CFString.ReleaseNative (nsprimaryString);
		}
		[Export ("showInlinePredictionForCandidates:client:")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos14.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ShowInlinePrediction (NSTextCheckingResult[] candidates, INSTextInputClient client)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (candidates is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (candidates));
			var client__handle__ = client!.GetNonNullHandle (nameof (client));
			using var nsa_candidates = NSArray.FromNSObjects (candidates);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selShowInlinePredictionForCandidates_Client_XHandle, nsa_candidates.Handle, client__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selShowInlinePredictionForCandidates_Client_XHandle, nsa_candidates.Handle, client__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (client);
		}
		[Export ("unlearnWord:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void UnlearnWord (string word)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (word is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (word));
			var nsword = CFString.CreateNative (word);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selUnlearnWord_XHandle, nsword);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selUnlearnWord_XHandle, nsword);
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsword);
		}
		[Export ("updatePanels")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void UpdatePanels ()
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selUpdatePanelsXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selUpdatePanelsXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("updateSpellingPanelWithGrammarString:detail:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void UpdateSpellingPanelWithGrammarl (string theString, NSDictionary detail)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (theString is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (theString));
			var detail__handle__ = detail!.GetNonNullHandle (nameof (detail));
			var nstheString = CFString.CreateNative (theString);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selUpdateSpellingPanelWithGrammarString_Detail_XHandle, nstheString, detail__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selUpdateSpellingPanelWithGrammarString_Detail_XHandle, nstheString, detail__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (detail);
			CFString.ReleaseNative (nstheString);
		}
		[Export ("updateSpellingPanelWithMisspelledWord:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void UpdateSpellingPanelWithMisspelledWord (string word)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (word is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (word));
			var nsword = CFString.CreateNative (word);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selUpdateSpellingPanelWithMisspelledWord_XHandle, nsword);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selUpdateSpellingPanelWithMisspelledWord_XHandle, nsword);
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsword);
		}
		[Export ("userQuotesArrayForLanguage:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string[] UserQuotesArrayForLanguage (string language)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (language is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (language));
			var nslanguage = CFString.CreateNative (language);
			string[]? ret;
			if (IsDirectBinding) {
				ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selUserQuotesArrayForLanguage_XHandle, nslanguage), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selUserQuotesArrayForLanguage_XHandle, nslanguage), false)!;
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nslanguage);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSView? AccessoryView {
			[Export ("accessoryView", ArgumentSemantic.Retain)]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSView? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSView> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selAccessoryViewXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSView> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selAccessoryViewXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setAccessoryView:", ArgumentSemantic.Retain)]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetAccessoryView_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetAccessoryView_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool AutomaticallyIdentifiesLanguages {
			[Export ("automaticallyIdentifiesLanguages")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selAutomaticallyIdentifiesLanguagesXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selAutomaticallyIdentifiesLanguagesXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setAutomaticallyIdentifiesLanguages:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetAutomaticallyIdentifiesLanguages_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetAutomaticallyIdentifiesLanguages_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string[] AvailableLanguages {
			[Export ("availableLanguages")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				string[] ret;
				if (IsDirectBinding) {
					ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selAvailableLanguagesXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selAvailableLanguagesXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool IsAutomaticCapitalizationEnabled {
			[Export ("isAutomaticCapitalizationEnabled")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				byte ret;
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (class_ptr, selIsAutomaticCapitalizationEnabledXHandle);
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos14.0")]
		public static bool IsAutomaticInlinePredictionEnabled {
			[Export ("isAutomaticInlinePredictionEnabled")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				byte ret;
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (class_ptr, selIsAutomaticInlinePredictionEnabledXHandle);
				return ret != 0;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool IsAutomaticPeriodSubstitutionEnabled {
			[Export ("isAutomaticPeriodSubstitutionEnabled")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				byte ret;
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (class_ptr, selIsAutomaticPeriodSubstitutionEnabledXHandle);
				return ret != 0;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool IsAutomaticSpellingCorrectionEnabled {
			[Export ("isAutomaticSpellingCorrectionEnabled")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				byte ret;
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (class_ptr, selIsAutomaticSpellingCorrectionEnabledXHandle);
				return ret != 0;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool IsAutomaticTextCompletionEnabled {
			[Export ("isAutomaticTextCompletionEnabled")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				byte ret;
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (class_ptr, selIsAutomaticTextCompletionEnabledXHandle);
				return ret != 0;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool IsAutomaticTextReplacementEnabled {
			[Export ("isAutomaticTextReplacementEnabled")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				byte ret;
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (class_ptr, selIsAutomaticTextReplacementEnabledXHandle);
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSSpellChecker SharedSpellChecker {
			[Export ("sharedSpellChecker")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSSpellChecker? ret;
				ret =  Runtime.GetNSObject<NSSpellChecker> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selSharedSpellCheckerXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool SharedSpellCheckerExists {
			[Export ("sharedSpellCheckerExists")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				byte ret;
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (class_ptr, selSharedSpellCheckerExistsXHandle);
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSPanel SpellingPanel {
			[Export ("spellingPanel")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSPanel? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSPanel> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selSpellingPanelXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSPanel> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selSpellingPanelXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSPanel SubstitutionsPanel {
			[Export ("substitutionsPanel")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSPanel? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSPanel> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selSubstitutionsPanelXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSPanel> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selSubstitutionsPanelXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSViewController SubstitutionsPanelAccessoryViewController {
			[Export ("substitutionsPanelAccessoryViewController", ArgumentSemantic.Retain)]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSViewController? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSViewController> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selSubstitutionsPanelAccessoryViewControllerXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSViewController> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selSubstitutionsPanelAccessoryViewControllerXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setSubstitutionsPanelAccessoryViewController:", ArgumentSemantic.Retain)]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				var value__handle__ = value!.GetNonNullHandle (nameof (value));
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetSubstitutionsPanelAccessoryViewController_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetSubstitutionsPanelAccessoryViewController_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static nint UniqueSpellDocumentTag {
			[Export ("uniqueSpellDocumentTag")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				nint ret;
				ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (class_ptr, selUniqueSpellDocumentTagXHandle);
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string[] UserPreferredLanguages {
			[Export ("userPreferredLanguages")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				string[] ret;
				if (IsDirectBinding) {
					ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selUserPreferredLanguagesXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selUserPreferredLanguagesXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDictionary UserReplacementsDictionary {
			[Export ("userReplacementsDictionary")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSDictionary? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDictionary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selUserReplacementsDictionaryXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSDictionary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selUserReplacementsDictionaryXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DidChangeAutomaticCapitalizationNotification;
		/// <summary>Notification constant for DidChangeAutomaticCapitalization</summary>
		/// <value><see cref="NSString" /> constant, should be used as a token to <see cref="NSNotificationCenter" />.</value>
		/// <remarks>
		///   <para>
		///     This constant can be used with <see cref="NSNotificationCenter" /> to register a listener for this notification.
		///     This is an <see cref="NSString" /> instead of a string, because these values can be used as tokens in some native
		///     libraries instead of being used purely for their actual string content. The 'notification' parameter to the callback
		///     contains extra information that is specific to the notification type.
		///   </para>
		///   <para>
		///     To subscribe to this notification, developers can use the convenience <see cref="Notifications.ObserveDidChangeAutomaticCapitalization(NSObject,EventHandler{NSNotificationEventArgs})" />
		///     or <see cref="Notifications.ObserveDidChangeAutomaticCapitalization(EventHandler{NSNotificationEventArgs})" /> methods,
		///     which offers strongly typed access to the parameters of the notification.
		///   </para>
		///   <para>
		///     The following example shows how to use the strongly typed <see cref="Notifications" /> class, to take the guesswork
		///     out of the available properties in the notification:
		///   </para>
		///   <example>
		///     <code lang="csharp lang-csharp"><![CDATA[
		/// //
		/// // Lambda style
		/// //
		///
		/// // listening
		/// notification = NSSpellChecker.Notifications.ObserveDidChangeAutomaticCapitalization ((sender, args) => {
		/// /* Access strongly typed args */
		/// Console.WriteLine ("Notification: {0}", args.Notification);
		/// });
		///
		/// // To stop listening:
		/// notification.Dispose ();
		///
		/// //
		/// // Method style
		/// //
		/// NSObject notification;
		/// void Callback (object sender, NSSpellChecker.NSNotificationEventArgs args)
		/// {
		///     // Access strongly typed args
		///     Console.WriteLine ("Notification: {0}", args.Notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     notification = NSSpellChecker.Notifications.ObserveDidChangeAutomaticCapitalization (Callback);
		/// }
		///
		/// void Teardown ()
		/// {
		///     notification.Dispose ();
		/// }]]></code>
		///   </example>
		///   <para>
		///     The following example shows how to use the notification with the DefaultCenter API:
		///   </para>
		///   <example>
		///     <code lang="csharp lang-csharp"><![CDATA[
		/// // Lambda style
		/// NSNotificationCenter.DefaultCenter.AddObserver (
		///     NSSpellChecker.DidChangeAutomaticCapitalizationNotification, (notification) => { Console.WriteLine ("Received the notification DidChangeAutomaticCapitalization", notification); }
		/// );
		///
		/// // Method style
		/// void Callback (NSNotification notification)
		/// {
		///     Console.WriteLine ("Received the notification DidChangeAutomaticCapitalization", notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     NSNotificationCenter.DefaultCenter.AddObserver (NSSpellChecker.DidChangeAutomaticCapitalizationNotification, Callback);
		/// }
		/// ]]></code>
		///   </example>
		/// </remarks>
		[Field ("NSSpellCheckerDidChangeAutomaticCapitalizationNotification",  "AppKit")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[Advice ("Use NSSpellChecker.Notifications.ObserveDidChangeAutomaticCapitalization helper method instead.")]
		public static NSString DidChangeAutomaticCapitalizationNotification {
			[SupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_DidChangeAutomaticCapitalizationNotification is null)
					_DidChangeAutomaticCapitalizationNotification = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSSpellCheckerDidChangeAutomaticCapitalizationNotification")!;
				return _DidChangeAutomaticCapitalizationNotification;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DidChangeAutomaticInlinePredictionNotification;
		/// <summary>Notification constant for DidChangeAutomaticInlinePrediction</summary>
		/// <value><see cref="NSString" /> constant, should be used as a token to <see cref="NSNotificationCenter" />.</value>
		/// <remarks>
		///   <para>
		///     This constant can be used with <see cref="NSNotificationCenter" /> to register a listener for this notification.
		///     This is an <see cref="NSString" /> instead of a string, because these values can be used as tokens in some native
		///     libraries instead of being used purely for their actual string content. The 'notification' parameter to the callback
		///     contains extra information that is specific to the notification type.
		///   </para>
		///   <para>
		///     To subscribe to this notification, developers can use the convenience <see cref="Notifications.ObserveDidChangeAutomaticInlinePrediction(NSObject,EventHandler{NSNotificationEventArgs})" />
		///     or <see cref="Notifications.ObserveDidChangeAutomaticInlinePrediction(EventHandler{NSNotificationEventArgs})" /> methods,
		///     which offers strongly typed access to the parameters of the notification.
		///   </para>
		///   <para>
		///     The following example shows how to use the strongly typed <see cref="Notifications" /> class, to take the guesswork
		///     out of the available properties in the notification:
		///   </para>
		///   <example>
		///     <code lang="csharp lang-csharp"><![CDATA[
		/// //
		/// // Lambda style
		/// //
		///
		/// // listening
		/// notification = NSSpellChecker.Notifications.ObserveDidChangeAutomaticInlinePrediction ((sender, args) => {
		/// /* Access strongly typed args */
		/// Console.WriteLine ("Notification: {0}", args.Notification);
		/// });
		///
		/// // To stop listening:
		/// notification.Dispose ();
		///
		/// //
		/// // Method style
		/// //
		/// NSObject notification;
		/// void Callback (object sender, NSSpellChecker.NSNotificationEventArgs args)
		/// {
		///     // Access strongly typed args
		///     Console.WriteLine ("Notification: {0}", args.Notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     notification = NSSpellChecker.Notifications.ObserveDidChangeAutomaticInlinePrediction (Callback);
		/// }
		///
		/// void Teardown ()
		/// {
		///     notification.Dispose ();
		/// }]]></code>
		///   </example>
		///   <para>
		///     The following example shows how to use the notification with the DefaultCenter API:
		///   </para>
		///   <example>
		///     <code lang="csharp lang-csharp"><![CDATA[
		/// // Lambda style
		/// NSNotificationCenter.DefaultCenter.AddObserver (
		///     NSSpellChecker.DidChangeAutomaticInlinePredictionNotification, (notification) => { Console.WriteLine ("Received the notification DidChangeAutomaticInlinePrediction", notification); }
		/// );
		///
		/// // Method style
		/// void Callback (NSNotification notification)
		/// {
		///     Console.WriteLine ("Received the notification DidChangeAutomaticInlinePrediction", notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     NSNotificationCenter.DefaultCenter.AddObserver (NSSpellChecker.DidChangeAutomaticInlinePredictionNotification, Callback);
		/// }
		/// ]]></code>
		///   </example>
		/// </remarks>
		[Field ("NSSpellCheckerDidChangeAutomaticInlinePredictionNotification",  "AppKit")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos14.0")]
		[Advice ("Use NSSpellChecker.Notifications.ObserveDidChangeAutomaticInlinePrediction helper method instead.")]
		public static NSString DidChangeAutomaticInlinePredictionNotification {
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos14.0")]
			get {
				if (_DidChangeAutomaticInlinePredictionNotification is null)
					_DidChangeAutomaticInlinePredictionNotification = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSSpellCheckerDidChangeAutomaticInlinePredictionNotification")!;
				return _DidChangeAutomaticInlinePredictionNotification;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DidChangeAutomaticPeriodSubstitutionNotification;
		/// <summary>Notification constant for DidChangeAutomaticPeriodSubstitution</summary>
		/// <value><see cref="NSString" /> constant, should be used as a token to <see cref="NSNotificationCenter" />.</value>
		/// <remarks>
		///   <para>
		///     This constant can be used with <see cref="NSNotificationCenter" /> to register a listener for this notification.
		///     This is an <see cref="NSString" /> instead of a string, because these values can be used as tokens in some native
		///     libraries instead of being used purely for their actual string content. The 'notification' parameter to the callback
		///     contains extra information that is specific to the notification type.
		///   </para>
		///   <para>
		///     To subscribe to this notification, developers can use the convenience <see cref="Notifications.ObserveDidChangeAutomaticPeriodSubstitution(NSObject,EventHandler{NSNotificationEventArgs})" />
		///     or <see cref="Notifications.ObserveDidChangeAutomaticPeriodSubstitution(EventHandler{NSNotificationEventArgs})" /> methods,
		///     which offers strongly typed access to the parameters of the notification.
		///   </para>
		///   <para>
		///     The following example shows how to use the strongly typed <see cref="Notifications" /> class, to take the guesswork
		///     out of the available properties in the notification:
		///   </para>
		///   <example>
		///     <code lang="csharp lang-csharp"><![CDATA[
		/// //
		/// // Lambda style
		/// //
		///
		/// // listening
		/// notification = NSSpellChecker.Notifications.ObserveDidChangeAutomaticPeriodSubstitution ((sender, args) => {
		/// /* Access strongly typed args */
		/// Console.WriteLine ("Notification: {0}", args.Notification);
		/// });
		///
		/// // To stop listening:
		/// notification.Dispose ();
		///
		/// //
		/// // Method style
		/// //
		/// NSObject notification;
		/// void Callback (object sender, NSSpellChecker.NSNotificationEventArgs args)
		/// {
		///     // Access strongly typed args
		///     Console.WriteLine ("Notification: {0}", args.Notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     notification = NSSpellChecker.Notifications.ObserveDidChangeAutomaticPeriodSubstitution (Callback);
		/// }
		///
		/// void Teardown ()
		/// {
		///     notification.Dispose ();
		/// }]]></code>
		///   </example>
		///   <para>
		///     The following example shows how to use the notification with the DefaultCenter API:
		///   </para>
		///   <example>
		///     <code lang="csharp lang-csharp"><![CDATA[
		/// // Lambda style
		/// NSNotificationCenter.DefaultCenter.AddObserver (
		///     NSSpellChecker.DidChangeAutomaticPeriodSubstitutionNotification, (notification) => { Console.WriteLine ("Received the notification DidChangeAutomaticPeriodSubstitution", notification); }
		/// );
		///
		/// // Method style
		/// void Callback (NSNotification notification)
		/// {
		///     Console.WriteLine ("Received the notification DidChangeAutomaticPeriodSubstitution", notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     NSNotificationCenter.DefaultCenter.AddObserver (NSSpellChecker.DidChangeAutomaticPeriodSubstitutionNotification, Callback);
		/// }
		/// ]]></code>
		///   </example>
		/// </remarks>
		[Field ("NSSpellCheckerDidChangeAutomaticPeriodSubstitutionNotification",  "AppKit")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[Advice ("Use NSSpellChecker.Notifications.ObserveDidChangeAutomaticPeriodSubstitution helper method instead.")]
		public static NSString DidChangeAutomaticPeriodSubstitutionNotification {
			[SupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_DidChangeAutomaticPeriodSubstitutionNotification is null)
					_DidChangeAutomaticPeriodSubstitutionNotification = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSSpellCheckerDidChangeAutomaticPeriodSubstitutionNotification")!;
				return _DidChangeAutomaticPeriodSubstitutionNotification;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DidChangeAutomaticSpellingCorrectionNotification;
		/// <summary>Notification constant for DidChangeAutomaticSpellingCorrection</summary>
		/// <value><see cref="NSString" /> constant, should be used as a token to <see cref="NSNotificationCenter" />.</value>
		/// <remarks>
		///   <para>
		///     This constant can be used with <see cref="NSNotificationCenter" /> to register a listener for this notification.
		///     This is an <see cref="NSString" /> instead of a string, because these values can be used as tokens in some native
		///     libraries instead of being used purely for their actual string content. The 'notification' parameter to the callback
		///     contains extra information that is specific to the notification type.
		///   </para>
		///   <para>
		///     To subscribe to this notification, developers can use the convenience <see cref="Notifications.ObserveDidChangeAutomaticSpellingCorrection(NSObject,EventHandler{NSNotificationEventArgs})" />
		///     or <see cref="Notifications.ObserveDidChangeAutomaticSpellingCorrection(EventHandler{NSNotificationEventArgs})" /> methods,
		///     which offers strongly typed access to the parameters of the notification.
		///   </para>
		///   <para>
		///     The following example shows how to use the strongly typed <see cref="Notifications" /> class, to take the guesswork
		///     out of the available properties in the notification:
		///   </para>
		///   <example>
		///     <code lang="csharp lang-csharp"><![CDATA[
		/// //
		/// // Lambda style
		/// //
		///
		/// // listening
		/// notification = NSSpellChecker.Notifications.ObserveDidChangeAutomaticSpellingCorrection ((sender, args) => {
		/// /* Access strongly typed args */
		/// Console.WriteLine ("Notification: {0}", args.Notification);
		/// });
		///
		/// // To stop listening:
		/// notification.Dispose ();
		///
		/// //
		/// // Method style
		/// //
		/// NSObject notification;
		/// void Callback (object sender, NSSpellChecker.NSNotificationEventArgs args)
		/// {
		///     // Access strongly typed args
		///     Console.WriteLine ("Notification: {0}", args.Notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     notification = NSSpellChecker.Notifications.ObserveDidChangeAutomaticSpellingCorrection (Callback);
		/// }
		///
		/// void Teardown ()
		/// {
		///     notification.Dispose ();
		/// }]]></code>
		///   </example>
		///   <para>
		///     The following example shows how to use the notification with the DefaultCenter API:
		///   </para>
		///   <example>
		///     <code lang="csharp lang-csharp"><![CDATA[
		/// // Lambda style
		/// NSNotificationCenter.DefaultCenter.AddObserver (
		///     NSSpellChecker.DidChangeAutomaticSpellingCorrectionNotification, (notification) => { Console.WriteLine ("Received the notification DidChangeAutomaticSpellingCorrection", notification); }
		/// );
		///
		/// // Method style
		/// void Callback (NSNotification notification)
		/// {
		///     Console.WriteLine ("Received the notification DidChangeAutomaticSpellingCorrection", notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     NSNotificationCenter.DefaultCenter.AddObserver (NSSpellChecker.DidChangeAutomaticSpellingCorrectionNotification, Callback);
		/// }
		/// ]]></code>
		///   </example>
		/// </remarks>
		[Field ("NSSpellCheckerDidChangeAutomaticSpellingCorrectionNotification",  "AppKit")]
		[Advice ("Use NSSpellChecker.Notifications.ObserveDidChangeAutomaticSpellingCorrection helper method instead.")]
		public static NSString DidChangeAutomaticSpellingCorrectionNotification {
			get {
				if (_DidChangeAutomaticSpellingCorrectionNotification is null)
					_DidChangeAutomaticSpellingCorrectionNotification = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSSpellCheckerDidChangeAutomaticSpellingCorrectionNotification")!;
				return _DidChangeAutomaticSpellingCorrectionNotification;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DidChangeAutomaticTextCompletionNotification;
		/// <summary>Notification constant for DidChangeAutomaticTextCompletion</summary>
		/// <value><see cref="NSString" /> constant, should be used as a token to <see cref="NSNotificationCenter" />.</value>
		/// <remarks>
		///   <para>
		///     This constant can be used with <see cref="NSNotificationCenter" /> to register a listener for this notification.
		///     This is an <see cref="NSString" /> instead of a string, because these values can be used as tokens in some native
		///     libraries instead of being used purely for their actual string content. The 'notification' parameter to the callback
		///     contains extra information that is specific to the notification type.
		///   </para>
		///   <para>
		///     To subscribe to this notification, developers can use the convenience <see cref="Notifications.ObserveDidChangeAutomaticTextCompletion(NSObject,EventHandler{NSNotificationEventArgs})" />
		///     or <see cref="Notifications.ObserveDidChangeAutomaticTextCompletion(EventHandler{NSNotificationEventArgs})" /> methods,
		///     which offers strongly typed access to the parameters of the notification.
		///   </para>
		///   <para>
		///     The following example shows how to use the strongly typed <see cref="Notifications" /> class, to take the guesswork
		///     out of the available properties in the notification:
		///   </para>
		///   <example>
		///     <code lang="csharp lang-csharp"><![CDATA[
		/// //
		/// // Lambda style
		/// //
		///
		/// // listening
		/// notification = NSSpellChecker.Notifications.ObserveDidChangeAutomaticTextCompletion ((sender, args) => {
		/// /* Access strongly typed args */
		/// Console.WriteLine ("Notification: {0}", args.Notification);
		/// });
		///
		/// // To stop listening:
		/// notification.Dispose ();
		///
		/// //
		/// // Method style
		/// //
		/// NSObject notification;
		/// void Callback (object sender, NSSpellChecker.NSNotificationEventArgs args)
		/// {
		///     // Access strongly typed args
		///     Console.WriteLine ("Notification: {0}", args.Notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     notification = NSSpellChecker.Notifications.ObserveDidChangeAutomaticTextCompletion (Callback);
		/// }
		///
		/// void Teardown ()
		/// {
		///     notification.Dispose ();
		/// }]]></code>
		///   </example>
		///   <para>
		///     The following example shows how to use the notification with the DefaultCenter API:
		///   </para>
		///   <example>
		///     <code lang="csharp lang-csharp"><![CDATA[
		/// // Lambda style
		/// NSNotificationCenter.DefaultCenter.AddObserver (
		///     NSSpellChecker.DidChangeAutomaticTextCompletionNotification, (notification) => { Console.WriteLine ("Received the notification DidChangeAutomaticTextCompletion", notification); }
		/// );
		///
		/// // Method style
		/// void Callback (NSNotification notification)
		/// {
		///     Console.WriteLine ("Received the notification DidChangeAutomaticTextCompletion", notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     NSNotificationCenter.DefaultCenter.AddObserver (NSSpellChecker.DidChangeAutomaticTextCompletionNotification, Callback);
		/// }
		/// ]]></code>
		///   </example>
		/// </remarks>
		[Field ("NSSpellCheckerDidChangeAutomaticTextCompletionNotification",  "AppKit")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[Advice ("Use NSSpellChecker.Notifications.ObserveDidChangeAutomaticTextCompletion helper method instead.")]
		public static NSString DidChangeAutomaticTextCompletionNotification {
			[SupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_DidChangeAutomaticTextCompletionNotification is null)
					_DidChangeAutomaticTextCompletionNotification = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSSpellCheckerDidChangeAutomaticTextCompletionNotification")!;
				return _DidChangeAutomaticTextCompletionNotification;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DidChangeAutomaticTextReplacementNotification;
		/// <summary>Notification constant for DidChangeAutomaticTextReplacement</summary>
		/// <value><see cref="NSString" /> constant, should be used as a token to <see cref="NSNotificationCenter" />.</value>
		/// <remarks>
		///   <para>
		///     This constant can be used with <see cref="NSNotificationCenter" /> to register a listener for this notification.
		///     This is an <see cref="NSString" /> instead of a string, because these values can be used as tokens in some native
		///     libraries instead of being used purely for their actual string content. The 'notification' parameter to the callback
		///     contains extra information that is specific to the notification type.
		///   </para>
		///   <para>
		///     To subscribe to this notification, developers can use the convenience <see cref="Notifications.ObserveDidChangeAutomaticTextReplacement(NSObject,EventHandler{NSNotificationEventArgs})" />
		///     or <see cref="Notifications.ObserveDidChangeAutomaticTextReplacement(EventHandler{NSNotificationEventArgs})" /> methods,
		///     which offers strongly typed access to the parameters of the notification.
		///   </para>
		///   <para>
		///     The following example shows how to use the strongly typed <see cref="Notifications" /> class, to take the guesswork
		///     out of the available properties in the notification:
		///   </para>
		///   <example>
		///     <code lang="csharp lang-csharp"><![CDATA[
		/// //
		/// // Lambda style
		/// //
		///
		/// // listening
		/// notification = NSSpellChecker.Notifications.ObserveDidChangeAutomaticTextReplacement ((sender, args) => {
		/// /* Access strongly typed args */
		/// Console.WriteLine ("Notification: {0}", args.Notification);
		/// });
		///
		/// // To stop listening:
		/// notification.Dispose ();
		///
		/// //
		/// // Method style
		/// //
		/// NSObject notification;
		/// void Callback (object sender, NSSpellChecker.NSNotificationEventArgs args)
		/// {
		///     // Access strongly typed args
		///     Console.WriteLine ("Notification: {0}", args.Notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     notification = NSSpellChecker.Notifications.ObserveDidChangeAutomaticTextReplacement (Callback);
		/// }
		///
		/// void Teardown ()
		/// {
		///     notification.Dispose ();
		/// }]]></code>
		///   </example>
		///   <para>
		///     The following example shows how to use the notification with the DefaultCenter API:
		///   </para>
		///   <example>
		///     <code lang="csharp lang-csharp"><![CDATA[
		/// // Lambda style
		/// NSNotificationCenter.DefaultCenter.AddObserver (
		///     NSSpellChecker.DidChangeAutomaticTextReplacementNotification, (notification) => { Console.WriteLine ("Received the notification DidChangeAutomaticTextReplacement", notification); }
		/// );
		///
		/// // Method style
		/// void Callback (NSNotification notification)
		/// {
		///     Console.WriteLine ("Received the notification DidChangeAutomaticTextReplacement", notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     NSNotificationCenter.DefaultCenter.AddObserver (NSSpellChecker.DidChangeAutomaticTextReplacementNotification, Callback);
		/// }
		/// ]]></code>
		///   </example>
		/// </remarks>
		[Field ("NSSpellCheckerDidChangeAutomaticTextReplacementNotification",  "AppKit")]
		[Advice ("Use NSSpellChecker.Notifications.ObserveDidChangeAutomaticTextReplacement helper method instead.")]
		public static NSString DidChangeAutomaticTextReplacementNotification {
			get {
				if (_DidChangeAutomaticTextReplacementNotification is null)
					_DidChangeAutomaticTextReplacementNotification = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSSpellCheckerDidChangeAutomaticTextReplacementNotification")!;
				return _DidChangeAutomaticTextReplacementNotification;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _TextCheckingDocumentAuthorKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSTextCheckingDocumentAuthorKey",  "AppKit")]
		public static NSString TextCheckingDocumentAuthorKey {
			get {
				if (_TextCheckingDocumentAuthorKey is null)
					_TextCheckingDocumentAuthorKey = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSTextCheckingDocumentAuthorKey")!;
				return _TextCheckingDocumentAuthorKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _TextCheckingDocumentTitleKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSTextCheckingDocumentTitleKey",  "AppKit")]
		public static NSString TextCheckingDocumentTitleKey {
			get {
				if (_TextCheckingDocumentTitleKey is null)
					_TextCheckingDocumentTitleKey = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSTextCheckingDocumentTitleKey")!;
				return _TextCheckingDocumentTitleKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _TextCheckingDocumentURLKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSTextCheckingDocumentURLKey",  "AppKit")]
		public static NSString TextCheckingDocumentURLKey {
			get {
				if (_TextCheckingDocumentURLKey is null)
					_TextCheckingDocumentURLKey = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSTextCheckingDocumentURLKey")!;
				return _TextCheckingDocumentURLKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _TextCheckingGenerateInlinePredictionsKey;
		/// <summary>Represents the value associated with the constant 'NSTextCheckingGenerateInlinePredictionsKey'.</summary>
		[Field ("NSTextCheckingGenerateInlinePredictionsKey",  "AppKit")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos14.0")]
		public static NSString TextCheckingGenerateInlinePredictionsKey {
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos14.0")]
			get {
				if (_TextCheckingGenerateInlinePredictionsKey is null)
					_TextCheckingGenerateInlinePredictionsKey = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSTextCheckingGenerateInlinePredictionsKey")!;
				return _TextCheckingGenerateInlinePredictionsKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _TextCheckingOrthographyKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSTextCheckingOrthographyKey",  "AppKit")]
		public static NSString TextCheckingOrthographyKey {
			get {
				if (_TextCheckingOrthographyKey is null)
					_TextCheckingOrthographyKey = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSTextCheckingOrthographyKey")!;
				return _TextCheckingOrthographyKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _TextCheckingQuotesKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSTextCheckingQuotesKey",  "AppKit")]
		public static NSString TextCheckingQuotesKey {
			get {
				if (_TextCheckingQuotesKey is null)
					_TextCheckingQuotesKey = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSTextCheckingQuotesKey")!;
				return _TextCheckingQuotesKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _TextCheckingReferenceDateKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSTextCheckingReferenceDateKey",  "AppKit")]
		public static NSString TextCheckingReferenceDateKey {
			get {
				if (_TextCheckingReferenceDateKey is null)
					_TextCheckingReferenceDateKey = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSTextCheckingReferenceDateKey")!;
				return _TextCheckingReferenceDateKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _TextCheckingReferenceTimeZoneKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSTextCheckingReferenceTimeZoneKey",  "AppKit")]
		public static NSString TextCheckingReferenceTimeZoneKey {
			get {
				if (_TextCheckingReferenceTimeZoneKey is null)
					_TextCheckingReferenceTimeZoneKey = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSTextCheckingReferenceTimeZoneKey")!;
				return _TextCheckingReferenceTimeZoneKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _TextCheckingRegularExpressionsKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSTextCheckingRegularExpressionsKey",  "AppKit")]
		public static NSString TextCheckingRegularExpressionsKey {
			get {
				if (_TextCheckingRegularExpressionsKey is null)
					_TextCheckingRegularExpressionsKey = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSTextCheckingRegularExpressionsKey")!;
				return _TextCheckingRegularExpressionsKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _TextCheckingReplacementsKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSTextCheckingReplacementsKey",  "AppKit")]
		public static NSString TextCheckingReplacementsKey {
			get {
				if (_TextCheckingReplacementsKey is null)
					_TextCheckingReplacementsKey = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSTextCheckingReplacementsKey")!;
				return _TextCheckingReplacementsKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _TextCheckingSelectedRangeKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSTextCheckingSelectedRangeKey",  "AppKit")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString TextCheckingSelectedRangeKey {
			[SupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_TextCheckingSelectedRangeKey is null)
					_TextCheckingSelectedRangeKey = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSTextCheckingSelectedRangeKey")!;
				return _TextCheckingSelectedRangeKey;
			}
		}
		//
		// Notifications
		//
		/// <summary>Notifications posted by the <see cref="global::AppKit.NSSpellChecker" /> class.</summary>
		/// <remarks>
		///    <para>This class contains various helper methods that allow developers to observe events posted in the notification hub (<see cref="Foundation.NSNotificationCenter" />).</para>
		///    <para>The methods defined in this class post events that invoke the provided method or lambda with a <see cref="Foundation.NSNotificationEventArgs" /> parameter, which contains strongly typed properties for the notification arguments.</para>
		/// </remarks>
		public static partial class Notifications {
			/// <summary>Strongly typed notification for the <see cref="global::AppKit.NSSpellChecker.DidChangeAutomaticCapitalizationNotification" /> constant.</summary>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::AppKit.NSSpellChecker.DidChangeAutomaticCapitalizationNotification" /> notifications.</para>
			///   <example>
			///   <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for any object
			/// var token = NSSpellChecker.Notifications.ObserveDidChangeAutomaticCapitalization ((notification) => {
			///   Console.WriteLine ("Observed DidChangeAutomaticCapitalizationNotification!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveDidChangeAutomaticCapitalization (EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (DidChangeAutomaticCapitalizationNotification, notification => handler (null, new NSNotificationEventArgs (notification)));
			}
			/// <summary>Strongly typed notification for the <see cref="global::AppKit.NSSpellChecker.DidChangeAutomaticCapitalizationNotification" /> constant.</summary>
			/// <param name="objectToObserve">The specific object to observe.</param>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::AppKit.NSSpellChecker.DidChangeAutomaticCapitalizationNotification" /> notifications.</para>
			///   <example>
			///     <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for a single object
			/// var token = NSSpellChecker.Notifications.ObserveDidChangeAutomaticCapitalization (objectToObserve, (notification) => {
			///   Console.WriteLine ($"Observed DidChangeAutomaticCapitalizationNotification for {nameof (objectToObserve)}!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveDidChangeAutomaticCapitalization (NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (DidChangeAutomaticCapitalizationNotification, notification => handler (null, new NSNotificationEventArgs (notification)), objectToObserve);
			}
			/// <summary>Strongly typed notification for the <see cref="global::AppKit.NSSpellChecker.DidChangeAutomaticInlinePredictionNotification" /> constant.</summary>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::AppKit.NSSpellChecker.DidChangeAutomaticInlinePredictionNotification" /> notifications.</para>
			///   <example>
			///   <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for any object
			/// var token = NSSpellChecker.Notifications.ObserveDidChangeAutomaticInlinePrediction ((notification) => {
			///   Console.WriteLine ("Observed DidChangeAutomaticInlinePredictionNotification!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveDidChangeAutomaticInlinePrediction (EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (DidChangeAutomaticInlinePredictionNotification, notification => handler (null, new NSNotificationEventArgs (notification)));
			}
			/// <summary>Strongly typed notification for the <see cref="global::AppKit.NSSpellChecker.DidChangeAutomaticInlinePredictionNotification" /> constant.</summary>
			/// <param name="objectToObserve">The specific object to observe.</param>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::AppKit.NSSpellChecker.DidChangeAutomaticInlinePredictionNotification" /> notifications.</para>
			///   <example>
			///     <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for a single object
			/// var token = NSSpellChecker.Notifications.ObserveDidChangeAutomaticInlinePrediction (objectToObserve, (notification) => {
			///   Console.WriteLine ($"Observed DidChangeAutomaticInlinePredictionNotification for {nameof (objectToObserve)}!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveDidChangeAutomaticInlinePrediction (NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (DidChangeAutomaticInlinePredictionNotification, notification => handler (null, new NSNotificationEventArgs (notification)), objectToObserve);
			}
			/// <summary>Strongly typed notification for the <see cref="global::AppKit.NSSpellChecker.DidChangeAutomaticPeriodSubstitutionNotification" /> constant.</summary>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::AppKit.NSSpellChecker.DidChangeAutomaticPeriodSubstitutionNotification" /> notifications.</para>
			///   <example>
			///   <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for any object
			/// var token = NSSpellChecker.Notifications.ObserveDidChangeAutomaticPeriodSubstitution ((notification) => {
			///   Console.WriteLine ("Observed DidChangeAutomaticPeriodSubstitutionNotification!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveDidChangeAutomaticPeriodSubstitution (EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (DidChangeAutomaticPeriodSubstitutionNotification, notification => handler (null, new NSNotificationEventArgs (notification)));
			}
			/// <summary>Strongly typed notification for the <see cref="global::AppKit.NSSpellChecker.DidChangeAutomaticPeriodSubstitutionNotification" /> constant.</summary>
			/// <param name="objectToObserve">The specific object to observe.</param>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::AppKit.NSSpellChecker.DidChangeAutomaticPeriodSubstitutionNotification" /> notifications.</para>
			///   <example>
			///     <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for a single object
			/// var token = NSSpellChecker.Notifications.ObserveDidChangeAutomaticPeriodSubstitution (objectToObserve, (notification) => {
			///   Console.WriteLine ($"Observed DidChangeAutomaticPeriodSubstitutionNotification for {nameof (objectToObserve)}!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveDidChangeAutomaticPeriodSubstitution (NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (DidChangeAutomaticPeriodSubstitutionNotification, notification => handler (null, new NSNotificationEventArgs (notification)), objectToObserve);
			}
			/// <summary>Strongly typed notification for the <see cref="global::AppKit.NSSpellChecker.DidChangeAutomaticSpellingCorrectionNotification" /> constant.</summary>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::AppKit.NSSpellChecker.DidChangeAutomaticSpellingCorrectionNotification" /> notifications.</para>
			///   <example>
			///   <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for any object
			/// var token = NSSpellChecker.Notifications.ObserveDidChangeAutomaticSpellingCorrection ((notification) => {
			///   Console.WriteLine ("Observed DidChangeAutomaticSpellingCorrectionNotification!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveDidChangeAutomaticSpellingCorrection (EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (DidChangeAutomaticSpellingCorrectionNotification, notification => handler (null, new NSNotificationEventArgs (notification)));
			}
			/// <summary>Strongly typed notification for the <see cref="global::AppKit.NSSpellChecker.DidChangeAutomaticSpellingCorrectionNotification" /> constant.</summary>
			/// <param name="objectToObserve">The specific object to observe.</param>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::AppKit.NSSpellChecker.DidChangeAutomaticSpellingCorrectionNotification" /> notifications.</para>
			///   <example>
			///     <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for a single object
			/// var token = NSSpellChecker.Notifications.ObserveDidChangeAutomaticSpellingCorrection (objectToObserve, (notification) => {
			///   Console.WriteLine ($"Observed DidChangeAutomaticSpellingCorrectionNotification for {nameof (objectToObserve)}!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveDidChangeAutomaticSpellingCorrection (NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (DidChangeAutomaticSpellingCorrectionNotification, notification => handler (null, new NSNotificationEventArgs (notification)), objectToObserve);
			}
			/// <summary>Strongly typed notification for the <see cref="global::AppKit.NSSpellChecker.DidChangeAutomaticTextCompletionNotification" /> constant.</summary>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::AppKit.NSSpellChecker.DidChangeAutomaticTextCompletionNotification" /> notifications.</para>
			///   <example>
			///   <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for any object
			/// var token = NSSpellChecker.Notifications.ObserveDidChangeAutomaticTextCompletion ((notification) => {
			///   Console.WriteLine ("Observed DidChangeAutomaticTextCompletionNotification!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveDidChangeAutomaticTextCompletion (EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (DidChangeAutomaticTextCompletionNotification, notification => handler (null, new NSNotificationEventArgs (notification)));
			}
			/// <summary>Strongly typed notification for the <see cref="global::AppKit.NSSpellChecker.DidChangeAutomaticTextCompletionNotification" /> constant.</summary>
			/// <param name="objectToObserve">The specific object to observe.</param>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::AppKit.NSSpellChecker.DidChangeAutomaticTextCompletionNotification" /> notifications.</para>
			///   <example>
			///     <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for a single object
			/// var token = NSSpellChecker.Notifications.ObserveDidChangeAutomaticTextCompletion (objectToObserve, (notification) => {
			///   Console.WriteLine ($"Observed DidChangeAutomaticTextCompletionNotification for {nameof (objectToObserve)}!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveDidChangeAutomaticTextCompletion (NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (DidChangeAutomaticTextCompletionNotification, notification => handler (null, new NSNotificationEventArgs (notification)), objectToObserve);
			}
			/// <summary>Strongly typed notification for the <see cref="global::AppKit.NSSpellChecker.DidChangeAutomaticTextReplacementNotification" /> constant.</summary>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::AppKit.NSSpellChecker.DidChangeAutomaticTextReplacementNotification" /> notifications.</para>
			///   <example>
			///   <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for any object
			/// var token = NSSpellChecker.Notifications.ObserveDidChangeAutomaticTextReplacement ((notification) => {
			///   Console.WriteLine ("Observed DidChangeAutomaticTextReplacementNotification!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveDidChangeAutomaticTextReplacement (EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (DidChangeAutomaticTextReplacementNotification, notification => handler (null, new NSNotificationEventArgs (notification)));
			}
			/// <summary>Strongly typed notification for the <see cref="global::AppKit.NSSpellChecker.DidChangeAutomaticTextReplacementNotification" /> constant.</summary>
			/// <param name="objectToObserve">The specific object to observe.</param>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::AppKit.NSSpellChecker.DidChangeAutomaticTextReplacementNotification" /> notifications.</para>
			///   <example>
			///     <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for a single object
			/// var token = NSSpellChecker.Notifications.ObserveDidChangeAutomaticTextReplacement (objectToObserve, (notification) => {
			///   Console.WriteLine ($"Observed DidChangeAutomaticTextReplacementNotification for {nameof (objectToObserve)}!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveDidChangeAutomaticTextReplacement (NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (DidChangeAutomaticTextReplacementNotification, notification => handler (null, new NSNotificationEventArgs (notification)), objectToObserve);
			}
		}
	} /* class NSSpellChecker */
	//
	// Async result classes
	//
	/// <summary>This class holds the return values for an asynchronous operation.</summary>
	public partial class NSSpellCheckerCandidates {
		/// <summary>The result value from the asynchronous operation.</summary>
		public nint Arg1 { get; set; }
		/// <summary>The result value from the asynchronous operation.</summary>
		public NSTextCheckingResult[] Arg2 { get; set; }
		partial void Initialize ();
		/// <summary>Creates a new instance of this class.</summary>
		/// <param name="arg1">Result value from an asynchronous operation.</param>
		/// <param name="arg2">Result value from an asynchronous operation.</param>
		public NSSpellCheckerCandidates (nint arg1, NSTextCheckingResult[] arg2) {
			this.Arg1 = arg1;
			this.Arg2 = arg2;
			Initialize ();
		}
	}
}
