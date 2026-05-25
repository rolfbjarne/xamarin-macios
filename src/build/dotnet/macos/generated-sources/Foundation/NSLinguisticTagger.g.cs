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
	[Register("NSLinguisticTagger", true)]
	[ObsoletedOSPlatform ("macos11.0", "Use 'NaturalLanguage.*' API instead.")]
	[ObsoletedOSPlatform ("ios14.0", "Use 'NaturalLanguage.*' API instead.")]
	[ObsoletedOSPlatform ("tvos14.0", "Use 'NaturalLanguage.*' API instead.")]
	[ObsoletedOSPlatform ("maccatalyst14.0", "Use 'NaturalLanguage.*' API instead.")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("maccatalyst")]
	public unsafe partial class NSLinguisticTagger : NSObject {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAvailableTagSchemesForLanguage_X = "availableTagSchemesForLanguage:";
		static readonly NativeHandle selAvailableTagSchemesForLanguage_XHandle = Selector.GetHandle ("availableTagSchemesForLanguage:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAvailableTagSchemesForUnit_Language_X = "availableTagSchemesForUnit:language:";
		static readonly NativeHandle selAvailableTagSchemesForUnit_Language_XHandle = Selector.GetHandle ("availableTagSchemesForUnit:language:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDominantLanguageX = "dominantLanguage";
		static readonly NativeHandle selDominantLanguageXHandle = Selector.GetHandle ("dominantLanguage");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDominantLanguageForString_X = "dominantLanguageForString:";
		static readonly NativeHandle selDominantLanguageForString_XHandle = Selector.GetHandle ("dominantLanguageForString:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selEnumerateTagsForString_Range_Unit_Scheme_Options_Orthography_UsingBlock_X = "enumerateTagsForString:range:unit:scheme:options:orthography:usingBlock:";
		static readonly NativeHandle selEnumerateTagsForString_Range_Unit_Scheme_Options_Orthography_UsingBlock_XHandle = Selector.GetHandle ("enumerateTagsForString:range:unit:scheme:options:orthography:usingBlock:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selEnumerateTagsInRange_Scheme_Options_UsingBlock_X = "enumerateTagsInRange:scheme:options:usingBlock:";
		static readonly NativeHandle selEnumerateTagsInRange_Scheme_Options_UsingBlock_XHandle = Selector.GetHandle ("enumerateTagsInRange:scheme:options:usingBlock:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selEnumerateTagsInRange_Unit_Scheme_Options_UsingBlock_X = "enumerateTagsInRange:unit:scheme:options:usingBlock:";
		static readonly NativeHandle selEnumerateTagsInRange_Unit_Scheme_Options_UsingBlock_XHandle = Selector.GetHandle ("enumerateTagsInRange:unit:scheme:options:usingBlock:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithTagSchemes_Options_X = "initWithTagSchemes:options:";
		static readonly NativeHandle selInitWithTagSchemes_Options_XHandle = Selector.GetHandle ("initWithTagSchemes:options:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selOrthographyAtIndex_EffectiveRange_X = "orthographyAtIndex:effectiveRange:";
		static readonly NativeHandle selOrthographyAtIndex_EffectiveRange_XHandle = Selector.GetHandle ("orthographyAtIndex:effectiveRange:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPossibleTagsAtIndex_Scheme_TokenRange_SentenceRange_Scores_X = "possibleTagsAtIndex:scheme:tokenRange:sentenceRange:scores:";
		static readonly NativeHandle selPossibleTagsAtIndex_Scheme_TokenRange_SentenceRange_Scores_XHandle = Selector.GetHandle ("possibleTagsAtIndex:scheme:tokenRange:sentenceRange:scores:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSentenceRangeForRange_X = "sentenceRangeForRange:";
		static readonly NativeHandle selSentenceRangeForRange_XHandle = Selector.GetHandle ("sentenceRangeForRange:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetOrthography_Range_X = "setOrthography:range:";
		static readonly NativeHandle selSetOrthography_Range_XHandle = Selector.GetHandle ("setOrthography:range:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetString_X = "setString:";
		static readonly NativeHandle selSetString_XHandle = Selector.GetHandle ("setString:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selStringX = "string";
		static readonly NativeHandle selStringXHandle = Selector.GetHandle ("string");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selStringEditedInRange_ChangeInLength_X = "stringEditedInRange:changeInLength:";
		static readonly NativeHandle selStringEditedInRange_ChangeInLength_XHandle = Selector.GetHandle ("stringEditedInRange:changeInLength:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTagAtIndex_Scheme_TokenRange_SentenceRange_X = "tagAtIndex:scheme:tokenRange:sentenceRange:";
		static readonly NativeHandle selTagAtIndex_Scheme_TokenRange_SentenceRange_XHandle = Selector.GetHandle ("tagAtIndex:scheme:tokenRange:sentenceRange:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTagAtIndex_Unit_Scheme_TokenRange_X = "tagAtIndex:unit:scheme:tokenRange:";
		static readonly NativeHandle selTagAtIndex_Unit_Scheme_TokenRange_XHandle = Selector.GetHandle ("tagAtIndex:unit:scheme:tokenRange:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTagForString_AtIndex_Unit_Scheme_Orthography_TokenRange_X = "tagForString:atIndex:unit:scheme:orthography:tokenRange:";
		static readonly NativeHandle selTagForString_AtIndex_Unit_Scheme_Orthography_TokenRange_XHandle = Selector.GetHandle ("tagForString:atIndex:unit:scheme:orthography:tokenRange:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTagSchemesX = "tagSchemes";
		static readonly NativeHandle selTagSchemesXHandle = Selector.GetHandle ("tagSchemes");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTagsForString_Range_Unit_Scheme_Options_Orthography_TokenRanges_X = "tagsForString:range:unit:scheme:options:orthography:tokenRanges:";
		static readonly NativeHandle selTagsForString_Range_Unit_Scheme_Options_Orthography_TokenRanges_XHandle = Selector.GetHandle ("tagsForString:range:unit:scheme:options:orthography:tokenRanges:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTagsInRange_Scheme_Options_TokenRanges_X = "tagsInRange:scheme:options:tokenRanges:";
		static readonly NativeHandle selTagsInRange_Scheme_Options_TokenRanges_XHandle = Selector.GetHandle ("tagsInRange:scheme:options:tokenRanges:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTagsInRange_Unit_Scheme_Options_TokenRanges_X = "tagsInRange:unit:scheme:options:tokenRanges:";
		static readonly NativeHandle selTagsInRange_Unit_Scheme_Options_TokenRanges_XHandle = Selector.GetHandle ("tagsInRange:unit:scheme:options:tokenRanges:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTokenRangeAtIndex_Unit_X = "tokenRangeAtIndex:unit:";
		static readonly NativeHandle selTokenRangeAtIndex_Unit_XHandle = Selector.GetHandle ("tokenRangeAtIndex:unit:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("NSLinguisticTagger");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		/// <summary>Creates a new <see cref="NSLinguisticTagger" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public NSLinguisticTagger () : base (NSObjectFlag.Empty)
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
		protected NSLinguisticTagger (NSObjectFlag t) : base (t)
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
		protected internal NSLinguisticTagger (NativeHandle handle) : base (handle)
		{
		}

		[Export ("initWithTagSchemes:options:")]
		[DesignatedInitializer]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSLinguisticTagger (NSString[] tagSchemes, NSLinguisticTaggerOptions opts)
			: base (NSObjectFlag.Empty)
		{
			if (tagSchemes is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (tagSchemes));
			using var nsa_tagSchemes = NSArray.FromNSObjects (tagSchemes);
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_UIntPtr (this.Handle, selInitWithTagSchemes_Options_XHandle, nsa_tagSchemes.Handle, (UIntPtr) (ulong) opts), "initWithTagSchemes:options:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_UIntPtr (&__objc_super__, selInitWithTagSchemes_Options_XHandle, nsa_tagSchemes.Handle, (UIntPtr) (ulong) opts), "initWithTagSchemes:options:");
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("enumerateTagsInRange:unit:scheme:options:usingBlock:")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("macos12.0", "Use 'NaturalLanguage.*' API instead.")]
		[ObsoletedOSPlatform ("ios14.0", "Use 'NaturalLanguage.*' API instead.")]
		[ObsoletedOSPlatform ("tvos14.0", "Use 'NaturalLanguage.*' API instead.")]
		[ObsoletedOSPlatform ("maccatalyst15.0", "Use 'NaturalLanguage.*' API instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void EnumerateTags (NSRange range, NSLinguisticTaggerUnit unit, string scheme, NSLinguisticTaggerOptions options, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDLinguisticTagEnumerator))]LinguisticTagEnumerator enumerator)
		{
			if (scheme is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (scheme));
			if (enumerator is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (enumerator));
			var nsscheme = CFString.CreateNative (scheme);
			using var block_enumerator = Trampolines.SDLinguisticTagEnumerator.CreateBlock (enumerator);
			BlockLiteral *block_ptr_enumerator = &block_enumerator;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NSRange_IntPtr_NativeHandle_UIntPtr_NativeHandle (this.Handle, selEnumerateTagsInRange_Unit_Scheme_Options_UsingBlock_XHandle, range, (IntPtr) (long) unit, nsscheme, (UIntPtr) (ulong) options, (IntPtr) block_ptr_enumerator);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NSRange_IntPtr_NativeHandle_UIntPtr_NativeHandle (&__objc_super__, selEnumerateTagsInRange_Unit_Scheme_Options_UsingBlock_XHandle, range, (IntPtr) (long) unit, nsscheme, (UIntPtr) (ulong) options, (IntPtr) block_ptr_enumerator);
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsscheme);
		}
		[Export ("enumerateTagsForString:range:unit:scheme:options:orthography:usingBlock:")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("macos12.0", "Use 'NaturalLanguage.*' API instead.")]
		[ObsoletedOSPlatform ("ios14.0", "Use 'NaturalLanguage.*' API instead.")]
		[ObsoletedOSPlatform ("tvos14.0", "Use 'NaturalLanguage.*' API instead.")]
		[ObsoletedOSPlatform ("maccatalyst15.0", "Use 'NaturalLanguage.*' API instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void EnumerateTags (string str, NSRange range, NSLinguisticTaggerUnit unit, string scheme, NSLinguisticTaggerOptions options, NSOrthography? orthography, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDLinguisticTagEnumerator))]LinguisticTagEnumerator enumerator)
		{
			if (str is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (str));
			if (scheme is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (scheme));
			var orthography__handle__ = orthography.GetHandle ();
			if (enumerator is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (enumerator));
			var nsstr = CFString.CreateNative (str);
			var nsscheme = CFString.CreateNative (scheme);
			using var block_enumerator = Trampolines.SDLinguisticTagEnumerator.CreateBlock (enumerator);
			BlockLiteral *block_ptr_enumerator = &block_enumerator;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NSRange_IntPtr_NativeHandle_UIntPtr_NativeHandle_NativeHandle (class_ptr, selEnumerateTagsForString_Range_Unit_Scheme_Options_Orthography_UsingBlock_XHandle, nsstr, range, (IntPtr) (long) unit, nsscheme, (UIntPtr) (ulong) options, orthography__handle__, (IntPtr) block_ptr_enumerator);
			GC.KeepAlive (orthography);
			CFString.ReleaseNative (nsstr);
			CFString.ReleaseNative (nsscheme);
		}
		[Export ("enumerateTagsInRange:scheme:options:usingBlock:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void EnumerateTagsInRange (NSRange range, NSString tagScheme, NSLinguisticTaggerOptions opts, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDNSLingusticEnumerator))]NSLingusticEnumerator enumerator)
		{
			var tagScheme__handle__ = tagScheme!.GetNonNullHandle (nameof (tagScheme));
			if (enumerator is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (enumerator));
			using var block_enumerator = Trampolines.SDNSLingusticEnumerator.CreateBlock (enumerator);
			BlockLiteral *block_ptr_enumerator = &block_enumerator;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NSRange_NativeHandle_UIntPtr_NativeHandle (this.Handle, selEnumerateTagsInRange_Scheme_Options_UsingBlock_XHandle, range, tagScheme__handle__, (UIntPtr) (ulong) opts, (IntPtr) block_ptr_enumerator);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NSRange_NativeHandle_UIntPtr_NativeHandle (&__objc_super__, selEnumerateTagsInRange_Scheme_Options_UsingBlock_XHandle, range, tagScheme__handle__, (UIntPtr) (ulong) opts, (IntPtr) block_ptr_enumerator);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (tagScheme);
		}
		[Export ("availableTagSchemesForUnit:language:")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("macos12.0", "Use 'NaturalLanguage.*' API instead.")]
		[ObsoletedOSPlatform ("ios14.0", "Use 'NaturalLanguage.*' API instead.")]
		[ObsoletedOSPlatform ("tvos14.0", "Use 'NaturalLanguage.*' API instead.")]
		[ObsoletedOSPlatform ("maccatalyst15.0", "Use 'NaturalLanguage.*' API instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string[] GetAvailableTagSchemes (NSLinguisticTaggerUnit unit, string language)
		{
			if (language is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (language));
			var nslanguage = CFString.CreateNative (language);
			string[]? ret;
			ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_IntPtr_NativeHandle (class_ptr, selAvailableTagSchemesForUnit_Language_XHandle, (IntPtr) (long) unit, nslanguage), false)!;
			CFString.ReleaseNative (nslanguage);
			return ret!;
		}
		[Export ("availableTagSchemesForLanguage:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSString[] GetAvailableTagSchemesForLanguage (string language)
		{
			if (language is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (language));
			var nslanguage = CFString.CreateNative (language);
			NSString[]? ret;
			ret = CFArray.ArrayFromHandle<NSString>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, selAvailableTagSchemesForLanguage_XHandle, nslanguage), false)!;
			CFString.ReleaseNative (nslanguage);
			return ret!;
		}
		[Export ("dominantLanguageForString:")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("macos12.0", "Use 'NaturalLanguage.*' API instead.")]
		[ObsoletedOSPlatform ("ios14.0", "Use 'NaturalLanguage.*' API instead.")]
		[ObsoletedOSPlatform ("tvos14.0", "Use 'NaturalLanguage.*' API instead.")]
		[ObsoletedOSPlatform ("maccatalyst15.0", "Use 'NaturalLanguage.*' API instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string? GetDominantLanguage (string str)
		{
			if (str is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (str));
			var nsstr = CFString.CreateNative (str);
			string? ret;
			ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, selDominantLanguageForString_XHandle, nsstr), false)!;
			CFString.ReleaseNative (nsstr);
			return ret!;
		}
		/// <param name="charIndex">To be added.</param><param name="effectiveRange">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("orthographyAtIndex:effectiveRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual NSOrthography GetOrthography (nint charIndex, ref NSRange effectiveRange)
		{
			fixed (NSRange* effectiveRange__pointer = &effectiveRange) {
			NSOrthography ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSOrthography> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_IntPtr_ref_NSRange (this.Handle, selOrthographyAtIndex_EffectiveRange_XHandle, charIndex, effectiveRange__pointer), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSOrthography> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_IntPtr_ref_NSRange (&__objc_super__, selOrthographyAtIndex_EffectiveRange_XHandle, charIndex, effectiveRange__pointer), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
			}
		}
		[Export ("possibleTagsAtIndex:scheme:tokenRange:sentenceRange:scores:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe virtual NSString[] GetPossibleTags (nint charIndex, NSString tagScheme, ref NSRange tokenRange, ref NSRange sentenceRange, ref NSArray scores)
		{
			var tagScheme__handle__ = tagScheme!.GetNonNullHandle (nameof (tagScheme));
			fixed (NSRange* tokenRange__pointer = &tokenRange) {
			fixed (NSRange* sentenceRange__pointer = &sentenceRange) {
			var scoresValue = Runtime.RetainAndAutoreleaseNativeObject (scores);
			NSString[]? ret;
			if (IsDirectBinding) {
				ret = CFArray.ArrayFromHandle<NSString>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_IntPtr_NativeHandle_ref_NSRange_ref_NSRange_ref_NativeHandle (this.Handle, selPossibleTagsAtIndex_Scheme_TokenRange_SentenceRange_Scores_XHandle, charIndex, tagScheme__handle__, tokenRange__pointer, sentenceRange__pointer, &scoresValue), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFArray.ArrayFromHandle<NSString>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_IntPtr_NativeHandle_ref_NSRange_ref_NSRange_ref_NativeHandle (&__objc_super__, selPossibleTagsAtIndex_Scheme_TokenRange_SentenceRange_Scores_XHandle, charIndex, tagScheme__handle__, tokenRange__pointer, sentenceRange__pointer, &scoresValue), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (tagScheme);
			scores = Runtime.GetNSObject<NSArray> (scoresValue)!;
			return ret!;
			}
			}
		}
		[Export ("sentenceRangeForRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSRange GetSentenceRangeForRange (NSRange range)
		{
			NSRange ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.NSRange_objc_msgSend_NSRange (this.Handle, selSentenceRangeForRange_XHandle, range);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.NSRange_objc_msgSendSuper_NSRange (&__objc_super__, selSentenceRangeForRange_XHandle, range);
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		/// <param name="charIndex">To be added.</param><param name="tagScheme">To be added.</param><param name="tokenRange">To be added.</param><param name="sentenceRange">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("tagAtIndex:scheme:tokenRange:sentenceRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual string GetTag (nint charIndex, NSString tagScheme, ref NSRange tokenRange, ref NSRange sentenceRange)
		{
			var tagScheme__handle__ = tagScheme!.GetNonNullHandle (nameof (tagScheme));
			fixed (NSRange* tokenRange__pointer = &tokenRange) {
			fixed (NSRange* sentenceRange__pointer = &sentenceRange) {
			string? ret;
			if (IsDirectBinding) {
				ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_IntPtr_NativeHandle_ref_NSRange_ref_NSRange (this.Handle, selTagAtIndex_Scheme_TokenRange_SentenceRange_XHandle, charIndex, tagScheme__handle__, tokenRange__pointer, sentenceRange__pointer), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_IntPtr_NativeHandle_ref_NSRange_ref_NSRange (&__objc_super__, selTagAtIndex_Scheme_TokenRange_SentenceRange_XHandle, charIndex, tagScheme__handle__, tokenRange__pointer, sentenceRange__pointer), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (tagScheme);
			return ret!;
			}
			}
		}
		/// <param name="charIndex">To be added.</param><param name="unit">To be added.</param><param name="scheme">To be added.</param><param name="tokenRange"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("tagAtIndex:unit:scheme:tokenRange:")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("macos12.0", "Use 'NaturalLanguage.*' API instead.")]
		[ObsoletedOSPlatform ("ios14.0", "Use 'NaturalLanguage.*' API instead.")]
		[ObsoletedOSPlatform ("tvos14.0", "Use 'NaturalLanguage.*' API instead.")]
		[ObsoletedOSPlatform ("maccatalyst15.0", "Use 'NaturalLanguage.*' API instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual string? GetTag (nuint charIndex, NSLinguisticTaggerUnit unit, string scheme, ref NSRange tokenRange)
		{
			if (scheme is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (scheme));
			fixed (NSRange* tokenRange__pointer = &tokenRange) {
			var nsscheme = CFString.CreateNative (scheme);
			string? ret;
			if (IsDirectBinding) {
				ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UIntPtr_IntPtr_NativeHandle_ref_NSRange (this.Handle, selTagAtIndex_Unit_Scheme_TokenRange_XHandle, charIndex, (IntPtr) (long) unit, nsscheme, tokenRange__pointer), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_UIntPtr_IntPtr_NativeHandle_ref_NSRange (&__objc_super__, selTagAtIndex_Unit_Scheme_TokenRange_XHandle, charIndex, (IntPtr) (long) unit, nsscheme, tokenRange__pointer), false)!;
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsscheme);
			return ret!;
			}
		}
		/// <param name="str">To be added.</param><param name="charIndex">To be added.</param><param name="unit">To be added.</param><param name="scheme">To be added.</param><param name="orthography"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><param name="tokenRange"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("tagForString:atIndex:unit:scheme:orthography:tokenRange:")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("macos12.0", "Use 'NaturalLanguage.*' API instead.")]
		[ObsoletedOSPlatform ("ios14.0", "Use 'NaturalLanguage.*' API instead.")]
		[ObsoletedOSPlatform ("tvos14.0", "Use 'NaturalLanguage.*' API instead.")]
		[ObsoletedOSPlatform ("maccatalyst15.0", "Use 'NaturalLanguage.*' API instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static string? GetTag (string str, nuint charIndex, NSLinguisticTaggerUnit unit, string scheme, NSOrthography? orthography, ref NSRange tokenRange)
		{
			if (str is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (str));
			if (scheme is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (scheme));
			var orthography__handle__ = orthography.GetHandle ();
			fixed (NSRange* tokenRange__pointer = &tokenRange) {
			var nsstr = CFString.CreateNative (str);
			var nsscheme = CFString.CreateNative (scheme);
			string? ret;
			ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_UIntPtr_IntPtr_NativeHandle_NativeHandle_ref_NSRange (class_ptr, selTagForString_AtIndex_Unit_Scheme_Orthography_TokenRange_XHandle, nsstr, charIndex, (IntPtr) (long) unit, nsscheme, orthography__handle__, tokenRange__pointer), false)!;
			GC.KeepAlive (orthography);
			CFString.ReleaseNative (nsstr);
			CFString.ReleaseNative (nsscheme);
			return ret!;
			}
		}
		[Export ("tagsInRange:unit:scheme:options:tokenRanges:")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("macos12.0", "Use 'NaturalLanguage.*' API instead.")]
		[ObsoletedOSPlatform ("ios14.0", "Use 'NaturalLanguage.*' API instead.")]
		[ObsoletedOSPlatform ("tvos14.0", "Use 'NaturalLanguage.*' API instead.")]
		[ObsoletedOSPlatform ("maccatalyst15.0", "Use 'NaturalLanguage.*' API instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual string[] GetTags (NSRange range, NSLinguisticTaggerUnit unit, string scheme, NSLinguisticTaggerOptions options, out NSValue[]? tokenRanges)
		{
			if (scheme is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (scheme));
			NativeHandle tokenRangesValue = IntPtr.Zero;
			var nsscheme = CFString.CreateNative (scheme);
			string[]? ret;
			if (IsDirectBinding) {
				ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NSRange_IntPtr_NativeHandle_UIntPtr_ref_NativeHandle (this.Handle, selTagsInRange_Unit_Scheme_Options_TokenRanges_XHandle, range, (IntPtr) (long) unit, nsscheme, (UIntPtr) (ulong) options, &tokenRangesValue), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NSRange_IntPtr_NativeHandle_UIntPtr_ref_NativeHandle (&__objc_super__, selTagsInRange_Unit_Scheme_Options_TokenRanges_XHandle, range, (IntPtr) (long) unit, nsscheme, (UIntPtr) (ulong) options, &tokenRangesValue), false)!;
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsscheme);
			tokenRanges = CFArray.ArrayFromHandle<NSValue> (tokenRangesValue)!;
			return ret!;
		}
		[Export ("tagsForString:range:unit:scheme:options:orthography:tokenRanges:")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("macos12.0", "Use 'NaturalLanguage.*' API instead.")]
		[ObsoletedOSPlatform ("ios14.0", "Use 'NaturalLanguage.*' API instead.")]
		[ObsoletedOSPlatform ("tvos14.0", "Use 'NaturalLanguage.*' API instead.")]
		[ObsoletedOSPlatform ("maccatalyst15.0", "Use 'NaturalLanguage.*' API instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static string[] GetTags (string str, NSRange range, NSLinguisticTaggerUnit unit, string scheme, NSLinguisticTaggerOptions options, NSOrthography? orthography, out NSValue[]? tokenRanges)
		{
			if (str is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (str));
			if (scheme is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (scheme));
			var orthography__handle__ = orthography.GetHandle ();
			NativeHandle tokenRangesValue = IntPtr.Zero;
			var nsstr = CFString.CreateNative (str);
			var nsscheme = CFString.CreateNative (scheme);
			string[]? ret;
			ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NSRange_IntPtr_NativeHandle_UIntPtr_NativeHandle_ref_NativeHandle (class_ptr, selTagsForString_Range_Unit_Scheme_Options_Orthography_TokenRanges_XHandle, nsstr, range, (IntPtr) (long) unit, nsscheme, (UIntPtr) (ulong) options, orthography__handle__, &tokenRangesValue), false)!;
			GC.KeepAlive (orthography);
			CFString.ReleaseNative (nsstr);
			CFString.ReleaseNative (nsscheme);
			tokenRanges = CFArray.ArrayFromHandle<NSValue> (tokenRangesValue)!;
			return ret!;
		}
		[Export ("tagsInRange:scheme:options:tokenRanges:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe virtual NSString[] GetTagsInRange (NSRange range, NSString tagScheme, NSLinguisticTaggerOptions opts, ref NSArray tokenRanges)
		{
			var tagScheme__handle__ = tagScheme!.GetNonNullHandle (nameof (tagScheme));
			var tokenRangesValue = Runtime.RetainAndAutoreleaseNativeObject (tokenRanges);
			NSString[]? ret;
			if (IsDirectBinding) {
				ret = CFArray.ArrayFromHandle<NSString>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NSRange_NativeHandle_UIntPtr_ref_NativeHandle (this.Handle, selTagsInRange_Scheme_Options_TokenRanges_XHandle, range, tagScheme__handle__, (UIntPtr) (ulong) opts, &tokenRangesValue), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFArray.ArrayFromHandle<NSString>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NSRange_NativeHandle_UIntPtr_ref_NativeHandle (&__objc_super__, selTagsInRange_Scheme_Options_TokenRanges_XHandle, range, tagScheme__handle__, (UIntPtr) (ulong) opts, &tokenRangesValue), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (tagScheme);
			tokenRanges = Runtime.GetNSObject<NSArray> (tokenRangesValue)!;
			return ret!;
		}
		/// <param name="charIndex">To be added.</param><param name="unit">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("tokenRangeAtIndex:unit:")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("macos12.0", "Use 'NaturalLanguage.*' API instead.")]
		[ObsoletedOSPlatform ("ios14.0", "Use 'NaturalLanguage.*' API instead.")]
		[ObsoletedOSPlatform ("tvos14.0", "Use 'NaturalLanguage.*' API instead.")]
		[ObsoletedOSPlatform ("maccatalyst15.0", "Use 'NaturalLanguage.*' API instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSRange GetTokenRange (nuint charIndex, NSLinguisticTaggerUnit unit)
		{
			NSRange ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.NSRange_objc_msgSend_UIntPtr_IntPtr (this.Handle, selTokenRangeAtIndex_Unit_XHandle, charIndex, (IntPtr) (long) unit);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.NSRange_objc_msgSendSuper_UIntPtr_IntPtr (&__objc_super__, selTokenRangeAtIndex_Unit_XHandle, charIndex, (IntPtr) (long) unit);
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("setOrthography:range:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetOrthographyrange (NSOrthography orthography, NSRange range)
		{
			var orthography__handle__ = orthography!.GetNonNullHandle (nameof (orthography));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NSRange (this.Handle, selSetOrthography_Range_XHandle, orthography__handle__, range);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NSRange (&__objc_super__, selSetOrthography_Range_XHandle, orthography__handle__, range);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (orthography);
		}
		/// <param name="newRange">To be added.</param><param name="delta">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("stringEditedInRange:changeInLength:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void StringEditedInRange (NSRange newRange, nint delta)
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NSRange_IntPtr (this.Handle, selStringEditedInRange_ChangeInLength_XHandle, newRange, delta);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NSRange_IntPtr (&__objc_super__, selStringEditedInRange_ChangeInLength_XHandle, newRange, delta);
					GC.KeepAlive (this);
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string? AnalysisString {
			[Export ("string", ArgumentSemantic.Retain)]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selStringXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selStringXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setString:", ArgumentSemantic.Retain)]
			set {
				var nsvalue = CFString.CreateNative (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetString_XHandle, nsvalue);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetString_XHandle, nsvalue);
						GC.KeepAlive (this);
					}
				}
				CFString.ReleaseNative (nsvalue);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("macos12.0", "Use 'NaturalLanguage.*' API instead.")]
		[ObsoletedOSPlatform ("ios14.0", "Use 'NaturalLanguage.*' API instead.")]
		[ObsoletedOSPlatform ("tvos14.0", "Use 'NaturalLanguage.*' API instead.")]
		[ObsoletedOSPlatform ("maccatalyst15.0", "Use 'NaturalLanguage.*' API instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual string? DominantLanguage {
			[Export ("dominantLanguage")]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selDominantLanguageXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selDominantLanguageXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSString[] TagSchemes {
			[Export ("tagSchemes")]
			get {
				NSString[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<NSString>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selTagSchemesXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<NSString>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selTagSchemesXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
	} /* class NSLinguisticTagger */
}
