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
namespace NaturalLanguage {
	/// <summary>Analyzes text and produces an enumerable list of tags drawn from a specified set of tag schemas.</summary>
	[Register("NLTagger", true)]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe partial class NLTagger : NSObject {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAvailableTagSchemesForUnit_Language_X = "availableTagSchemesForUnit:language:";
		static readonly NativeHandle selAvailableTagSchemesForUnit_Language_XHandle = Selector.GetHandle ("availableTagSchemesForUnit:language:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDominantLanguageX = "dominantLanguage";
		static readonly NativeHandle selDominantLanguageXHandle = Selector.GetHandle ("dominantLanguage");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selEnumerateTagsInRange_Unit_Scheme_Options_UsingBlock_X = "enumerateTagsInRange:unit:scheme:options:usingBlock:";
		static readonly NativeHandle selEnumerateTagsInRange_Unit_Scheme_Options_UsingBlock_XHandle = Selector.GetHandle ("enumerateTagsInRange:unit:scheme:options:usingBlock:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selGazetteersForTagScheme_X = "gazetteersForTagScheme:";
		static readonly NativeHandle selGazetteersForTagScheme_XHandle = Selector.GetHandle ("gazetteersForTagScheme:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithTagSchemes_X = "initWithTagSchemes:";
		static readonly NativeHandle selInitWithTagSchemes_XHandle = Selector.GetHandle ("initWithTagSchemes:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selModelsForTagScheme_X = "modelsForTagScheme:";
		static readonly NativeHandle selModelsForTagScheme_XHandle = Selector.GetHandle ("modelsForTagScheme:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRequestAssetsForLanguage_TagScheme_CompletionHandler_X = "requestAssetsForLanguage:tagScheme:completionHandler:";
		static readonly NativeHandle selRequestAssetsForLanguage_TagScheme_CompletionHandler_XHandle = Selector.GetHandle ("requestAssetsForLanguage:tagScheme:completionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetGazetteers_ForTagScheme_X = "setGazetteers:forTagScheme:";
		static readonly NativeHandle selSetGazetteers_ForTagScheme_XHandle = Selector.GetHandle ("setGazetteers:forTagScheme:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetLanguage_Range_X = "setLanguage:range:";
		static readonly NativeHandle selSetLanguage_Range_XHandle = Selector.GetHandle ("setLanguage:range:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetModels_ForTagScheme_X = "setModels:forTagScheme:";
		static readonly NativeHandle selSetModels_ForTagScheme_XHandle = Selector.GetHandle ("setModels:forTagScheme:");
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
		const string selTagAtIndex_Unit_Scheme_TokenRange_X = "tagAtIndex:unit:scheme:tokenRange:";
		static readonly NativeHandle selTagAtIndex_Unit_Scheme_TokenRange_XHandle = Selector.GetHandle ("tagAtIndex:unit:scheme:tokenRange:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTagHypothesesAtIndex_Unit_Scheme_MaximumCount_TokenRange_X = "tagHypothesesAtIndex:unit:scheme:maximumCount:tokenRange:";
		static readonly NativeHandle selTagHypothesesAtIndex_Unit_Scheme_MaximumCount_TokenRange_XHandle = Selector.GetHandle ("tagHypothesesAtIndex:unit:scheme:maximumCount:tokenRange:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTagSchemesX = "tagSchemes";
		static readonly NativeHandle selTagSchemesXHandle = Selector.GetHandle ("tagSchemes");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTagsInRange_Unit_Scheme_Options_TokenRanges_X = "tagsInRange:unit:scheme:options:tokenRanges:";
		static readonly NativeHandle selTagsInRange_Unit_Scheme_Options_TokenRanges_XHandle = Selector.GetHandle ("tagsInRange:unit:scheme:options:tokenRanges:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTokenRangeAtIndex_Unit_X = "tokenRangeAtIndex:unit:";
		static readonly NativeHandle selTokenRangeAtIndex_Unit_XHandle = Selector.GetHandle ("tokenRangeAtIndex:unit:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTokenRangeForRange_Unit_X = "tokenRangeForRange:unit:";
		static readonly NativeHandle selTokenRangeForRange_Unit_XHandle = Selector.GetHandle ("tokenRangeForRange:unit:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("NLTagger");
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
		protected NLTagger (NSObjectFlag t) : base (t)
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
		protected internal NLTagger (NativeHandle handle) : base (handle)
		{
		}

		/// <param name="tagSchemes">The taggging schemes that detail the classifications to return.</param><summary>Initializes a tagger that classifies tokens according the the identified tagging schemes.</summary><remarks>To be added.</remarks>
		[Export ("initWithTagSchemes:")]
		[EditorBrowsable (EditorBrowsableState.Never)]
		[DesignatedInitializer]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NLTagger (params NSString[] tagSchemes)
			: base (NSObjectFlag.Empty)
		{
			if (tagSchemes is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (tagSchemes));
			using var nsa_tagSchemes = NSArray.FromNSObjects (tagSchemes);
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selInitWithTagSchemes_XHandle, nsa_tagSchemes.Handle), "initWithTagSchemes:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selInitWithTagSchemes_XHandle, nsa_tagSchemes.Handle), "initWithTagSchemes:");
					GC.KeepAlive (this);
				}
			}
		}
		/// <param name="tagSchemes">The taggging schemes that detail the classifications to return.</param><summary>Initializes a tagger that classifies tokens according the the provided tagging schemes.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NLTagger (params NLTagScheme[] tagSchemes)
			: this (Array.ConvertAll (tagSchemes, e => e.GetConstant ()!))
		{
		}
		/// <param name="range">The range of the tag.</param><param name="unit">The lexical unit of the tag.</param><param name="scheme">The schemes for which to enumerate the corresponding tags.</param><param name="options">Options that control preprocessing done to tags.</param><param name="handler">A handler to run on enumerated tags.</param><summary>Enumerates over a filtered list of tags and applies a handler.</summary><remarks>To be added.</remarks>
		[Export ("enumerateTagsInRange:unit:scheme:options:usingBlock:")]
		[EditorBrowsable (EditorBrowsableState.Never)]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void EnumerateTags (NSRange range, NLTokenUnit unit, NSString scheme, NLTaggerOptions options, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDNLTaggerEnumerateTagsContinuationHandler))]NLTaggerEnumerateTagsContinuationHandler handler)
		{
			var scheme__handle__ = scheme!.GetNonNullHandle (nameof (scheme));
			if (handler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (handler));
			using var block_handler = Trampolines.SDNLTaggerEnumerateTagsContinuationHandler.CreateBlock (handler);
			BlockLiteral *block_ptr_handler = &block_handler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NSRange_IntPtr_NativeHandle_UIntPtr_NativeHandle (this.Handle, selEnumerateTagsInRange_Unit_Scheme_Options_UsingBlock_XHandle, range, (IntPtr) (long) unit, scheme__handle__, (UIntPtr) (ulong) options, (IntPtr) block_ptr_handler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NSRange_IntPtr_NativeHandle_UIntPtr_NativeHandle (&__objc_super__, selEnumerateTagsInRange_Unit_Scheme_Options_UsingBlock_XHandle, range, (IntPtr) (long) unit, scheme__handle__, (UIntPtr) (ulong) options, (IntPtr) block_ptr_handler);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (scheme);
		}
		/// <param name="range">The range of the tag.</param><param name="unit">The lexical unit of the tag.</param><param name="scheme">The schemes for which to enumerate the corresponding tags.</param><param name="options">Options that control preprocessing done to tags.</param><param name="handler">A handler to run on enumerated tags.</param><summary>Enumerates over a filtered list of tags and applies a handler.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void EnumerateTags (NSRange range, NLTokenUnit unit, NLTagScheme scheme, NLTaggerOptions options, NLTaggerEnumerateTagsContinuationHandler handler)
		{
			EnumerateTags (range, unit, scheme.GetConstant ()!, options, handler);
		}
		/// <param name="unit">The unit for which to get the available tag schemes.</param><param name="language">The language that constrains the tags available for the <paramref name="unit" />.</param><summary>Returns the available tag schemes for <paramref name="unit" /> and <paramref name="language" />.</summary><returns>The available tag schemes for <paramref name="unit" /> and <paramref name="language" />.</returns><remarks>To be added.</remarks>
		[Export ("availableTagSchemesForUnit:language:")]
		[EditorBrowsable (EditorBrowsableState.Never)]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSString[] GetAvailableTagSchemes (NLTokenUnit unit, NSString language)
		{
			var language__handle__ = language!.GetNonNullHandle (nameof (language));
			NSString[]? ret;
			ret = CFArray.ArrayFromHandle<NSString>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_IntPtr_NativeHandle (class_ptr, selAvailableTagSchemesForUnit_Language_XHandle, (IntPtr) (long) unit, language__handle__), false)!;
			GC.KeepAlive (language);
			return ret!;
		}
		/// <param name="unit">The unit for which to get the available tag schemes.</param><param name="language">The language that constrains the tags available for the <paramref name="unit" />.</param><summary>Returns the available tag schemes for <paramref name="unit" /> and <paramref name="language" />.</summary><returns>The available tag schemes for <paramref name="unit" /> and <paramref name="language" />.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NLTagScheme[] GetAvailableTagSchemes (NLTokenUnit unit, NLLanguage language)
		{
			return Array.ConvertAll (GetAvailableTagSchemes (unit, language.GetConstant()!), e => NLTagSchemeExtensions.GetValue (e));
		}
		[Export ("gazetteersForTagScheme:")]
		[EditorBrowsable (EditorBrowsableState.Never)]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NLGazetteer[] GetGazetteers (NSString tagScheme)
		{
			var tagScheme__handle__ = tagScheme!.GetNonNullHandle (nameof (tagScheme));
			NLGazetteer[]? ret;
			if (IsDirectBinding) {
				ret = CFArray.ArrayFromHandle<NLGazetteer>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selGazetteersForTagScheme_XHandle, tagScheme__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFArray.ArrayFromHandle<NLGazetteer>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selGazetteersForTagScheme_XHandle, tagScheme__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (tagScheme);
			return ret!;
		}
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NLGazetteer[] GetGazetteers (NLTagScheme tagScheme)
		{
			return GetGazetteers (tagScheme.GetConstant ()!);
		}
		/// <param name="tagScheme">The tag scheme for which to get corresponding models.</param><summary>Returns the models that generate tags from the specified scheme.</summary><returns>The models that generate tags from the specified scheme.</returns><remarks>To be added.</remarks>
		[Export ("modelsForTagScheme:")]
		[EditorBrowsable (EditorBrowsableState.Never)]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NLModel[] GetModels (NSString tagScheme)
		{
			var tagScheme__handle__ = tagScheme!.GetNonNullHandle (nameof (tagScheme));
			NLModel[]? ret;
			if (IsDirectBinding) {
				ret = CFArray.ArrayFromHandle<NLModel>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selModelsForTagScheme_XHandle, tagScheme__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFArray.ArrayFromHandle<NLModel>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selModelsForTagScheme_XHandle, tagScheme__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (tagScheme);
			return ret!;
		}
		/// <param name="tagScheme">The tag scheme for which to get corresponding models.</param><summary>Returns the models that generate tags from the specified scheme.</summary><returns>The models that generate tags from the specified scheme.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NLModel[] GetModels (NLTagScheme tagScheme)
		{
			return GetModels (tagScheme.GetConstant ()!);
		}
		[Export ("tagHypothesesAtIndex:unit:scheme:maximumCount:tokenRange:")]
		[EditorBrowsable (EditorBrowsableState.Never)]
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual NSDictionary<NSString, NSNumber> GetNativeTagHypotheses (nuint characterIndex, NLTokenUnit unit, NSString scheme, nuint maximumCount, out NSRange tokenRange)
		{
			var scheme__handle__ = scheme!.GetNonNullHandle (nameof (scheme));
			fixed (NSRange* tokenRange__pointer = &tokenRange) {
			tokenRange = default;
			NSDictionary<NSString, NSNumber>? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSDictionary<NSString, NSNumber>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UIntPtr_IntPtr_NativeHandle_UIntPtr_out_NSRange (this.Handle, selTagHypothesesAtIndex_Unit_Scheme_MaximumCount_TokenRange_XHandle, characterIndex, (IntPtr) (long) unit, scheme__handle__, maximumCount, tokenRange__pointer), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSDictionary<NSString, NSNumber>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_UIntPtr_IntPtr_NativeHandle_UIntPtr_out_NSRange (&__objc_super__, selTagHypothesesAtIndex_Unit_Scheme_MaximumCount_TokenRange_XHandle, characterIndex, (IntPtr) (long) unit, scheme__handle__, maximumCount, tokenRange__pointer), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (scheme);
			return ret!;
			}
		}
		[EditorBrowsable (EditorBrowsableState.Never)]
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSDictionary<NSString, NSNumber> GetNativeTagHypotheses (nuint characterIndex, NLTokenUnit unit, NSString scheme, nuint maximumCount)
		{
			return GetTagHypotheses (characterIndex, unit, scheme, maximumCount, IntPtr.Zero);
		}
		/// <param name="characterIndex">To be added.</param><param name="unit">To be added.</param><param name="scheme">To be added.</param><param name="tokenRange">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("tagAtIndex:unit:scheme:tokenRange:")]
		[EditorBrowsable (EditorBrowsableState.Never)]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual NSString? GetTag (nuint characterIndex, NLTokenUnit unit, NSString scheme, out NSRange tokenRange)
		{
			var scheme__handle__ = scheme!.GetNonNullHandle (nameof (scheme));
			fixed (NSRange* tokenRange__pointer = &tokenRange) {
			tokenRange = default;
			NSString? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UIntPtr_IntPtr_NativeHandle_out_NSRange (this.Handle, selTagAtIndex_Unit_Scheme_TokenRange_XHandle, characterIndex, (IntPtr) (long) unit, scheme__handle__, tokenRange__pointer), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_UIntPtr_IntPtr_NativeHandle_out_NSRange (&__objc_super__, selTagAtIndex_Unit_Scheme_TokenRange_XHandle, characterIndex, (IntPtr) (long) unit, scheme__handle__, tokenRange__pointer), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (scheme);
			return ret!;
			}
		}
		/// <param name="characterIndex">To be added.</param><param name="unit">To be added.</param><param name="scheme">To be added.</param><param name="tokenRange">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NSString? GetTag (nuint characterIndex, NLTokenUnit unit, NLTagScheme scheme, out NSRange tokenRange)
		{
			return GetTag (characterIndex, unit, scheme.GetConstant ()!, out tokenRange);
		}
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal NSDictionary<NSString, NSNumber> GetTagHypotheses (nuint characterIndex, NLTokenUnit unit, NSString scheme, nuint maximumCount, nint tokenRange)
		{
			var scheme__handle__ = scheme!.GetNonNullHandle (nameof (scheme));
			NSDictionary<NSString, NSNumber>? ret;
			ret =  Runtime.GetNSObject<NSDictionary<NSString, NSNumber>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UIntPtr_IntPtr_NativeHandle_UIntPtr_IntPtr (this.Handle, selTagHypothesesAtIndex_Unit_Scheme_MaximumCount_TokenRange_XHandle, characterIndex, (IntPtr) (long) unit, scheme__handle__, maximumCount, tokenRange), false)!;
			GC.KeepAlive (scheme);
			return ret!;
		}
		/// <param name="range">The index range of the characters from which to get tags.</param><param name="unit">The token unit for the tags to retrieve.</param><param name="scheme">The tag scheme for the tags to retrieve.</param><param name="options">Options that control preprocessing done to tags.</param><param name="tokenRanges">Location to store the ranges of the tokens for the returned tags.</param><summary>Returns the tags and ranges for a string range and unit.</summary><returns>The tags and ranges for the string range and unit.</returns><remarks>To be added.</remarks>
		[Export ("tagsInRange:unit:scheme:options:tokenRanges:")]
		[EditorBrowsable (EditorBrowsableState.Never)]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual NSString[] GetTags (NSRange range, NLTokenUnit unit, NSString scheme, NLTaggerOptions options, out NSValue[]? tokenRanges)
		{
			var scheme__handle__ = scheme!.GetNonNullHandle (nameof (scheme));
			NativeHandle tokenRangesValue = IntPtr.Zero;
			NSString[]? ret;
			if (IsDirectBinding) {
				ret = CFArray.ArrayFromHandle<NSString>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NSRange_IntPtr_NativeHandle_UIntPtr_ref_NativeHandle (this.Handle, selTagsInRange_Unit_Scheme_Options_TokenRanges_XHandle, range, (IntPtr) (long) unit, scheme__handle__, (UIntPtr) (ulong) options, &tokenRangesValue), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFArray.ArrayFromHandle<NSString>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NSRange_IntPtr_NativeHandle_UIntPtr_ref_NativeHandle (&__objc_super__, selTagsInRange_Unit_Scheme_Options_TokenRanges_XHandle, range, (IntPtr) (long) unit, scheme__handle__, (UIntPtr) (ulong) options, &tokenRangesValue), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (scheme);
			tokenRanges = CFArray.ArrayFromHandle<NSValue> (tokenRangesValue)!;
			return ret!;
		}
		/// <param name="range">To be added.</param><param name="unit">To be added.</param><param name="scheme">To be added.</param><param name="options">To be added.</param><param name="tokenRanges">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NSString[] GetTags (NSRange range, NLTokenUnit unit, NLTagScheme scheme, NLTaggerOptions options, out NSValue[]? tokenRanges)
		{
			return GetTags (range, unit, scheme.GetConstant ()!, options, out tokenRanges);
		}
		/// <param name="characterIndex">A character index for the desired range.</param><param name="unit">The unit, which covers the <paramref name="characterIndex" />, whose range to get.</param><summary>Returns the lexical range of the <paramref name="unit" /> that contains the specified <paramref name="characterIndex" />.</summary><returns>The lexical range of the <paramref name="unit" /> that contains the specified <paramref name="characterIndex" />.</returns><remarks>To be added.</remarks>
		[Export ("tokenRangeAtIndex:unit:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSRange GetTokenRange (nuint characterIndex, NSString unit)
		{
			var unit__handle__ = unit!.GetNonNullHandle (nameof (unit));
			NSRange ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.NSRange_objc_msgSend_UIntPtr_NativeHandle (this.Handle, selTokenRangeAtIndex_Unit_XHandle, characterIndex, unit__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.NSRange_objc_msgSendSuper_UIntPtr_NativeHandle (&__objc_super__, selTokenRangeAtIndex_Unit_XHandle, characterIndex, unit__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (unit);
			return ret!;
		}
		[Export ("tokenRangeForRange:unit:")]
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSRange GetTokenRange (NSRange range, NLTokenUnit unit)
		{
			NSRange ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.NSRange_objc_msgSend_NSRange_IntPtr (this.Handle, selTokenRangeForRange_Unit_XHandle, range, (IntPtr) (long) unit);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.NSRange_objc_msgSendSuper_NSRange_IntPtr (&__objc_super__, selTokenRangeForRange_Unit_XHandle, range, (IntPtr) (long) unit);
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("requestAssetsForLanguage:tagScheme:completionHandler:")]
		[EditorBrowsable (EditorBrowsableState.Never)]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void RequestAssets (NSString language, NSString tagScheme, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V118))]global::System.Action<NLTaggerAssetsResult, NSError> completionHandler)
		{
			var language__handle__ = language!.GetNonNullHandle (nameof (language));
			var tagScheme__handle__ = tagScheme!.GetNonNullHandle (nameof (tagScheme));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity2V118.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (class_ptr, selRequestAssetsForLanguage_TagScheme_CompletionHandler_XHandle, language__handle__, tagScheme__handle__, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (language);
			GC.KeepAlive (tagScheme);
		}
		[EditorBrowsable (EditorBrowsableState.Never)]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Task<NLTaggerAssetsResult> RequestAssetsAsync (NSString language, NSString tagScheme)
		{
			var tcs = new TaskCompletionSource<NLTaggerAssetsResult> ();
			RequestAssets(language, tagScheme, (arg1_, arg2_) => {
				if (arg2_ is not null)
					tcs.SetException (new NSErrorException(arg2_));
				else
					tcs.SetResult (arg1_!);
			});
			return tcs.Task;
		}
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void RequestAssets (NLLanguage language, NLTagScheme tagScheme, global::System.Action<NLTaggerAssetsResult, NSError> completionHandler)
		{
			RequestAssets (language.GetConstant ()!, tagScheme.GetConstant ()!, completionHandler);
		}
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Task<NLTaggerAssetsResult> RequestAssetsAsync (NLLanguage language, NLTagScheme tagScheme)
		{
			var tcs = new TaskCompletionSource<NLTaggerAssetsResult> ();
			RequestAssets(language, tagScheme, (arg1_, arg2_) => {
				if (arg2_ is not null)
					tcs.SetException (new NSErrorException(arg2_));
				else
					tcs.SetResult (arg1_!);
			});
			return tcs.Task;
		}
		[Export ("setGazetteers:forTagScheme:")]
		[EditorBrowsable (EditorBrowsableState.Never)]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetGazetteers (NLGazetteer[] gazetteers, NSString tagScheme)
		{
			if (gazetteers is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (gazetteers));
			var tagScheme__handle__ = tagScheme!.GetNonNullHandle (nameof (tagScheme));
			using var nsa_gazetteers = NSArray.FromNSObjects (gazetteers);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selSetGazetteers_ForTagScheme_XHandle, nsa_gazetteers.Handle, tagScheme__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selSetGazetteers_ForTagScheme_XHandle, nsa_gazetteers.Handle, tagScheme__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (tagScheme);
		}
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetGazetteers (NLGazetteer[] gazetteers, NLTagScheme tagScheme)
		{
			SetGazetteers (gazetteers, tagScheme.GetConstant ()!);
		}
		/// <param name="language">The new language value.</param><param name="range">The range to which to apply the change.</param><summary>Sets the language for the specified range.</summary><remarks>To be added.</remarks>
		[Export ("setLanguage:range:")]
		[EditorBrowsable (EditorBrowsableState.Never)]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetLanguage (NSString language, NSRange range)
		{
			var language__handle__ = language!.GetNonNullHandle (nameof (language));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NSRange (this.Handle, selSetLanguage_Range_XHandle, language__handle__, range);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NSRange (&__objc_super__, selSetLanguage_Range_XHandle, language__handle__, range);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (language);
		}
		/// <param name="language">The new language value.</param><param name="range">The range to which to apply the change.</param><summary>Sets the language for the specified range.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetLanguage (NLLanguage language, NSRange range)
		{
			SetLanguage (language.GetConstant ()!, range);
		}
		/// <param name="models">The models to assign to the tag schemes.</param><param name="tagScheme">The tag scheme for which to assign the models.</param><summary>Assigns models to a tag scheme.</summary><remarks>To be added.</remarks>
		[Export ("setModels:forTagScheme:")]
		[EditorBrowsable (EditorBrowsableState.Never)]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetModels (NLModel[] models, NSString tagScheme)
		{
			if (models is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (models));
			var tagScheme__handle__ = tagScheme!.GetNonNullHandle (nameof (tagScheme));
			using var nsa_models = NSArray.FromNSObjects (models);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selSetModels_ForTagScheme_XHandle, nsa_models.Handle, tagScheme__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selSetModels_ForTagScheme_XHandle, nsa_models.Handle, tagScheme__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (tagScheme);
		}
		/// <param name="models">The models to assign to the tag schemes.</param><param name="tagScheme">The tag scheme for which to assign the models.</param><summary>Assigns models to a tag scheme.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetModels (NLModel[] models, NLTagScheme tagScheme)
		{
			SetModels (models, tagScheme.GetConstant ()!);
		}
		/// <param name="orthography">The orthography to set for the range.</param><param name="range">The range for which to assign an orthography.</param><summary>Assigns an orthography to a range.</summary><remarks>To be added.</remarks>
		[Export ("setOrthography:range:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetOrthography (NSOrthography orthography, NSRange range)
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
		/// <summary>Gets the dominant language for the tagged text.</summary><value>The dominant language for the tagged text.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NLLanguage DominantLanguage {
			get {
				return (NLLanguage) (NLLanguageExtensions.GetValue (_DominantLanguage));
			}
		}
		/// <summary>Gets or sets the string to tag.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string? String {
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
		/// <summary>Gets the tagging schemes that are supported by this tagger.</summary><value>The tagging schemes that are supported by this tagger.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NLTagScheme[] TagSchemes {
			get {
				return (Array.ConvertAll (_TagSchemes, e => NLTagSchemeExtensions.GetValue (e)) as NLTagScheme[])!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal virtual NSString? _DominantLanguage {
			[Export ("dominantLanguage")]
			get {
				NSString? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selDominantLanguageXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selDominantLanguageXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal virtual NSString[] _TagSchemes {
			[Export ("tagSchemes", ArgumentSemantic.Copy)]
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
	} /* class NLTagger */
}
