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
namespace AVFoundation {
	[Register("AVAsset", true)]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe partial class AVAsset : NSObject, INSCopying {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAllMediaSelectionsX = "allMediaSelections";
		static readonly NativeHandle selAllMediaSelectionsXHandle = Selector.GetHandle ("allMediaSelections");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAssetWithURL_X = "assetWithURL:";
		static readonly NativeHandle selAssetWithURL_XHandle = Selector.GetHandle ("assetWithURL:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAvailableChapterLocalesX = "availableChapterLocales";
		static readonly NativeHandle selAvailableChapterLocalesXHandle = Selector.GetHandle ("availableChapterLocales");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAvailableMediaCharacteristicsWithMediaSelectionOptionsX = "availableMediaCharacteristicsWithMediaSelectionOptions";
		static readonly NativeHandle selAvailableMediaCharacteristicsWithMediaSelectionOptionsXHandle = Selector.GetHandle ("availableMediaCharacteristicsWithMediaSelectionOptions");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAvailableMetadataFormatsX = "availableMetadataFormats";
		static readonly NativeHandle selAvailableMetadataFormatsXHandle = Selector.GetHandle ("availableMetadataFormats");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCanContainFragmentsX = "canContainFragments";
		static readonly NativeHandle selCanContainFragmentsXHandle = Selector.GetHandle ("canContainFragments");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCancelLoadingX = "cancelLoading";
		static readonly NativeHandle selCancelLoadingXHandle = Selector.GetHandle ("cancelLoading");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selChapterMetadataGroupsBestMatchingPreferredLanguages_X = "chapterMetadataGroupsBestMatchingPreferredLanguages:";
		static readonly NativeHandle selChapterMetadataGroupsBestMatchingPreferredLanguages_XHandle = Selector.GetHandle ("chapterMetadataGroupsBestMatchingPreferredLanguages:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selChapterMetadataGroupsWithTitleLocale_ContainingItemsWithCommonKeys_X = "chapterMetadataGroupsWithTitleLocale:containingItemsWithCommonKeys:";
		static readonly NativeHandle selChapterMetadataGroupsWithTitleLocale_ContainingItemsWithCommonKeys_XHandle = Selector.GetHandle ("chapterMetadataGroupsWithTitleLocale:containingItemsWithCommonKeys:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCommonMetadataX = "commonMetadata";
		static readonly NativeHandle selCommonMetadataXHandle = Selector.GetHandle ("commonMetadata");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selContainsFragmentsX = "containsFragments";
		static readonly NativeHandle selContainsFragmentsXHandle = Selector.GetHandle ("containsFragments");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCopyWithZone_X = "copyWithZone:";
		static readonly NativeHandle selCopyWithZone_XHandle = Selector.GetHandle ("copyWithZone:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCreationDateX = "creationDate";
		static readonly NativeHandle selCreationDateXHandle = Selector.GetHandle ("creationDate");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDurationX = "duration";
		static readonly NativeHandle selDurationXHandle = Selector.GetHandle ("duration");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFindUnusedTrackIDWithCompletionHandler_X = "findUnusedTrackIDWithCompletionHandler:";
		static readonly NativeHandle selFindUnusedTrackIDWithCompletionHandler_XHandle = Selector.GetHandle ("findUnusedTrackIDWithCompletionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selHasProtectedContentX = "hasProtectedContent";
		static readonly NativeHandle selHasProtectedContentXHandle = Selector.GetHandle ("hasProtectedContent");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsCompatibleWithAirPlayVideoX = "isCompatibleWithAirPlayVideo";
		static readonly NativeHandle selIsCompatibleWithAirPlayVideoXHandle = Selector.GetHandle ("isCompatibleWithAirPlayVideo");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsComposableX = "isComposable";
		static readonly NativeHandle selIsComposableXHandle = Selector.GetHandle ("isComposable");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsExportableX = "isExportable";
		static readonly NativeHandle selIsExportableXHandle = Selector.GetHandle ("isExportable");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsPlayableX = "isPlayable";
		static readonly NativeHandle selIsPlayableXHandle = Selector.GetHandle ("isPlayable");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsReadableX = "isReadable";
		static readonly NativeHandle selIsReadableXHandle = Selector.GetHandle ("isReadable");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLoadChapterMetadataGroupsBestMatchingPreferredLanguages_CompletionHandler_X = "loadChapterMetadataGroupsBestMatchingPreferredLanguages:completionHandler:";
		static readonly NativeHandle selLoadChapterMetadataGroupsBestMatchingPreferredLanguages_CompletionHandler_XHandle = Selector.GetHandle ("loadChapterMetadataGroupsBestMatchingPreferredLanguages:completionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLoadChapterMetadataGroupsWithTitleLocale_ContainingItemsWithCommonKeys_CompletionHandler_X = "loadChapterMetadataGroupsWithTitleLocale:containingItemsWithCommonKeys:completionHandler:";
		static readonly NativeHandle selLoadChapterMetadataGroupsWithTitleLocale_ContainingItemsWithCommonKeys_CompletionHandler_XHandle = Selector.GetHandle ("loadChapterMetadataGroupsWithTitleLocale:containingItemsWithCommonKeys:completionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLoadMediaSelectionGroupForMediaCharacteristic_CompletionHandler_X = "loadMediaSelectionGroupForMediaCharacteristic:completionHandler:";
		static readonly NativeHandle selLoadMediaSelectionGroupForMediaCharacteristic_CompletionHandler_XHandle = Selector.GetHandle ("loadMediaSelectionGroupForMediaCharacteristic:completionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLoadMetadataForFormat_CompletionHandler_X = "loadMetadataForFormat:completionHandler:";
		static readonly NativeHandle selLoadMetadataForFormat_CompletionHandler_XHandle = Selector.GetHandle ("loadMetadataForFormat:completionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLoadTrackWithTrackID_CompletionHandler_X = "loadTrackWithTrackID:completionHandler:";
		static readonly NativeHandle selLoadTrackWithTrackID_CompletionHandler_XHandle = Selector.GetHandle ("loadTrackWithTrackID:completionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLoadTracksWithMediaCharacteristic_CompletionHandler_X = "loadTracksWithMediaCharacteristic:completionHandler:";
		static readonly NativeHandle selLoadTracksWithMediaCharacteristic_CompletionHandler_XHandle = Selector.GetHandle ("loadTracksWithMediaCharacteristic:completionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLoadTracksWithMediaType_CompletionHandler_X = "loadTracksWithMediaType:completionHandler:";
		static readonly NativeHandle selLoadTracksWithMediaType_CompletionHandler_XHandle = Selector.GetHandle ("loadTracksWithMediaType:completionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLoadValuesAsynchronouslyForKeys_CompletionHandler_X = "loadValuesAsynchronouslyForKeys:completionHandler:";
		static readonly NativeHandle selLoadValuesAsynchronouslyForKeys_CompletionHandler_XHandle = Selector.GetHandle ("loadValuesAsynchronouslyForKeys:completionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLyricsX = "lyrics";
		static readonly NativeHandle selLyricsXHandle = Selector.GetHandle ("lyrics");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMediaSelectionGroupForMediaCharacteristic_X = "mediaSelectionGroupForMediaCharacteristic:";
		static readonly NativeHandle selMediaSelectionGroupForMediaCharacteristic_XHandle = Selector.GetHandle ("mediaSelectionGroupForMediaCharacteristic:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMetadataX = "metadata";
		static readonly NativeHandle selMetadataXHandle = Selector.GetHandle ("metadata");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMetadataForFormat_X = "metadataForFormat:";
		static readonly NativeHandle selMetadataForFormat_XHandle = Selector.GetHandle ("metadataForFormat:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMinimumTimeOffsetFromLiveX = "minimumTimeOffsetFromLive";
		static readonly NativeHandle selMinimumTimeOffsetFromLiveXHandle = Selector.GetHandle ("minimumTimeOffsetFromLive");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selNaturalSizeX = "naturalSize";
		static readonly NativeHandle selNaturalSizeXHandle = Selector.GetHandle ("naturalSize");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selOverallDurationHintX = "overallDurationHint";
		static readonly NativeHandle selOverallDurationHintXHandle = Selector.GetHandle ("overallDurationHint");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPreferredMediaSelectionX = "preferredMediaSelection";
		static readonly NativeHandle selPreferredMediaSelectionXHandle = Selector.GetHandle ("preferredMediaSelection");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPreferredRateX = "preferredRate";
		static readonly NativeHandle selPreferredRateXHandle = Selector.GetHandle ("preferredRate");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPreferredTransformX = "preferredTransform";
		static readonly NativeHandle selPreferredTransformXHandle = Selector.GetHandle ("preferredTransform");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPreferredVolumeX = "preferredVolume";
		static readonly NativeHandle selPreferredVolumeXHandle = Selector.GetHandle ("preferredVolume");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selProvidesPreciseDurationAndTimingX = "providesPreciseDurationAndTiming";
		static readonly NativeHandle selProvidesPreciseDurationAndTimingXHandle = Selector.GetHandle ("providesPreciseDurationAndTiming");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selReferenceRestrictionsX = "referenceRestrictions";
		static readonly NativeHandle selReferenceRestrictionsXHandle = Selector.GetHandle ("referenceRestrictions");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selStatusOfValueForKey_Error_X = "statusOfValueForKey:error:";
		static readonly NativeHandle selStatusOfValueForKey_Error_XHandle = Selector.GetHandle ("statusOfValueForKey:error:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTrackGroupsX = "trackGroups";
		static readonly NativeHandle selTrackGroupsXHandle = Selector.GetHandle ("trackGroups");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTrackWithTrackID_X = "trackWithTrackID:";
		static readonly NativeHandle selTrackWithTrackID_XHandle = Selector.GetHandle ("trackWithTrackID:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTracksX = "tracks";
		static readonly NativeHandle selTracksXHandle = Selector.GetHandle ("tracks");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTracksWithMediaCharacteristic_X = "tracksWithMediaCharacteristic:";
		static readonly NativeHandle selTracksWithMediaCharacteristic_XHandle = Selector.GetHandle ("tracksWithMediaCharacteristic:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTracksWithMediaType_X = "tracksWithMediaType:";
		static readonly NativeHandle selTracksWithMediaType_XHandle = Selector.GetHandle ("tracksWithMediaType:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selUnusedTrackIDX = "unusedTrackID";
		static readonly NativeHandle selUnusedTrackIDXHandle = Selector.GetHandle ("unusedTrackID");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("AVAsset");
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
		protected AVAsset (NSObjectFlag t) : base (t)
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
		protected internal AVAsset (NativeHandle handle) : base (handle)
		{
		}

		[Export ("cancelLoading")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void CancelLoading ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selCancelLoadingXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selCancelLoadingXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		/// <param name="zone">Developers should pass <see langword="null" />.  Memory zones are no longer used.</param><summary>Performs a copy of the underlying Objective-C object.</summary><returns>The newly-allocated object.</returns><remarks><para>This method performs a "shallow copy" of <see langword="this" />. If this object contains references to external objects, the new object will contain references to the same object.</para></remarks>
		[Export ("copyWithZone:")]
		[return: ReleaseAttribute ()]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
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
		[Export ("findUnusedTrackIDWithCompletionHandler:")]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void FindUnusedTrackId ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V0))]global::System.Action<int, NSError> completionHandler)
		{
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity2V0.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selFindUnusedTrackIDWithCompletionHandler_XHandle, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selFindUnusedTrackIDWithCompletionHandler_XHandle, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
		}
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<int> FindUnusedTrackIdAsync ()
		{
			var tcs = new TaskCompletionSource<int> ();
			FindUnusedTrackId((arg1_, arg2_) => {
				if (arg2_ is not null)
					tcs.SetException (new NSErrorException(arg2_));
				else
					tcs.SetResult (arg1_!);
			});
			return tcs.Task;
		}
		[Export ("assetWithURL:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static AVAsset FromUrl (NSUrl url)
		{
			var url__handle__ = url!.GetNonNullHandle (nameof (url));
			AVAsset? ret;
			ret =  Runtime.GetNSObject<AVAsset> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, selAssetWithURL_XHandle, url__handle__), false)!;
			GC.KeepAlive (url);
			return ret!;
		}
		[Export ("chapterMetadataGroupsWithTitleLocale:containingItemsWithCommonKeys:")]
		[ObsoletedOSPlatform ("macos15.0", "Use 'LoadChapterMetadataGroups' instead.")]
		[ObsoletedOSPlatform ("ios18.0", "Use 'LoadChapterMetadataGroups' instead.")]
		[ObsoletedOSPlatform ("tvos18.0", "Use 'LoadChapterMetadataGroups' instead.")]
		[ObsoletedOSPlatform ("maccatalyst18.0", "Use 'LoadChapterMetadataGroups' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual AVTimedMetadataGroup[] GetChapterMetadataGroups (NSLocale forLocale, AVMetadataItem[]? commonKeys)
		{
			var forLocale__handle__ = forLocale!.GetNonNullHandle (nameof (forLocale));
			using var nsa_commonKeys = commonKeys is null ? null : NSArray.FromNSObjects (commonKeys);
			AVTimedMetadataGroup[]? ret;
			if (IsDirectBinding) {
				ret = CFArray.ArrayFromHandle<AVTimedMetadataGroup>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selChapterMetadataGroupsWithTitleLocale_ContainingItemsWithCommonKeys_XHandle, forLocale__handle__, nsa_commonKeys.GetHandle ()), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFArray.ArrayFromHandle<AVTimedMetadataGroup>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selChapterMetadataGroupsWithTitleLocale_ContainingItemsWithCommonKeys_XHandle, forLocale__handle__, nsa_commonKeys.GetHandle ()), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (forLocale);
			return ret!;
		}
		[Export ("chapterMetadataGroupsBestMatchingPreferredLanguages:")]
		[ObsoletedOSPlatform ("macos15.0", "Use 'LoadChapterMetadataGroups' instead.")]
		[ObsoletedOSPlatform ("ios18.0", "Use 'LoadChapterMetadataGroups' instead.")]
		[ObsoletedOSPlatform ("tvos18.0", "Use 'LoadChapterMetadataGroups' instead.")]
		[ObsoletedOSPlatform ("maccatalyst18.0", "Use 'LoadChapterMetadataGroups' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual AVTimedMetadataGroup[] GetChapterMetadataGroupsBestMatchingPreferredLanguages (string[] languages)
		{
			if (languages is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (languages));
			using var nsa_languages = NSArray.FromStrings (languages);
			AVTimedMetadataGroup[] ret;
			if (IsDirectBinding) {
				ret = CFArray.ArrayFromHandle<AVTimedMetadataGroup>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selChapterMetadataGroupsBestMatchingPreferredLanguages_XHandle, nsa_languages.Handle), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFArray.ArrayFromHandle<AVTimedMetadataGroup>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selChapterMetadataGroupsBestMatchingPreferredLanguages_XHandle, nsa_languages.Handle), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		/// <param name="avMediaCharacteristic">The characteristic to search for.</param><summary>Returns a media selection group whose options have the indicated <paramref name="avMediaCharacteristic" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public AVMediaSelectionGroup? GetMediaSelectionGroupForMediaCharacteristic (AVMediaCharacteristics avMediaCharacteristic)
		{
			return MediaSelectionGroupForMediaCharacteristic (avMediaCharacteristic.GetConstant ()!);
		}
		[Export ("metadataForFormat:")]
		[ObsoletedOSPlatform ("macos15.0")]
		[ObsoletedOSPlatform ("ios18.0")]
		[ObsoletedOSPlatform ("maccatalyst18.0")]
		[ObsoletedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual AVMetadataItem[] GetMetadataForFormat (NSString format)
		{
			var format__handle__ = format!.GetNonNullHandle (nameof (format));
			AVMetadataItem[]? ret;
			if (IsDirectBinding) {
				ret = CFArray.ArrayFromHandle<AVMetadataItem>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selMetadataForFormat_XHandle, format__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFArray.ArrayFromHandle<AVMetadataItem>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selMetadataForFormat_XHandle, format__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (format);
			return ret!;
		}
		/// <param name="format">The metadata format to search.</param><summary>Returns an array that contains a metadata item for each item in the container that is specified by <paramref name="format" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public AVMetadataItem[] GetMetadataForFormat (AVMetadataFormat format)
		{
			return GetMetadataForFormat (format.GetConstant ()!);
		}
		/// <param name="mediaType">The media type to use when searching for tracks.</param><summary>Returns an array of tracks of the specified media type.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public AVAssetTrack[] GetTracks (AVMediaTypes mediaType)
		{
			return TracksWithMediaType (mediaType.GetConstant ()!);
		}
		/// <param name="mediaCharacteristic">The media characteristic to use when searching for tracks.</param><summary>Returns an array of tracks that have the specified characteristic.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public AVAssetTrack[] GetTracks (AVMediaCharacteristics mediaCharacteristic)
		{
			return TracksWithMediaType (mediaCharacteristic.GetConstant ()!);
		}
		[Export ("loadChapterMetadataGroupsBestMatchingPreferredLanguages:completionHandler:")]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void LoadChapterMetadataGroups (string[] bestMatchingPreferredLanguages, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V1))]global::System.Action<NSArray<AVTimedMetadataGroup>, NSError> completionHandler)
		{
			if (bestMatchingPreferredLanguages is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (bestMatchingPreferredLanguages));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var nsa_bestMatchingPreferredLanguages = NSArray.FromStrings (bestMatchingPreferredLanguages);
			using var block_completionHandler = Trampolines.SDActionArity2V1.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selLoadChapterMetadataGroupsBestMatchingPreferredLanguages_CompletionHandler_XHandle, nsa_bestMatchingPreferredLanguages.Handle, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selLoadChapterMetadataGroupsBestMatchingPreferredLanguages_CompletionHandler_XHandle, nsa_bestMatchingPreferredLanguages.Handle, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
		}
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<NSArray<AVTimedMetadataGroup>> LoadChapterMetadataGroupsAsync (string[] bestMatchingPreferredLanguages)
		{
			var tcs = new TaskCompletionSource<NSArray<AVTimedMetadataGroup>> ();
			LoadChapterMetadataGroups(bestMatchingPreferredLanguages, (arg1_, arg2_) => {
				if (arg2_ is not null)
					tcs.SetException (new NSErrorException(arg2_));
				else
					tcs.SetResult (arg1_!);
			});
			return tcs.Task;
		}
		[Export ("loadChapterMetadataGroupsWithTitleLocale:containingItemsWithCommonKeys:completionHandler:")]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void LoadChapterMetadataGroups (NSLocale titleLocale, string[] commonKeys, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V1))]global::System.Action<NSArray<AVTimedMetadataGroup>, NSError> completionHandler)
		{
			var titleLocale__handle__ = titleLocale!.GetNonNullHandle (nameof (titleLocale));
			if (commonKeys is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (commonKeys));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var nsa_commonKeys = NSArray.FromStrings (commonKeys);
			using var block_completionHandler = Trampolines.SDActionArity2V1.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, selLoadChapterMetadataGroupsWithTitleLocale_ContainingItemsWithCommonKeys_CompletionHandler_XHandle, titleLocale__handle__, nsa_commonKeys.Handle, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, selLoadChapterMetadataGroupsWithTitleLocale_ContainingItemsWithCommonKeys_CompletionHandler_XHandle, titleLocale__handle__, nsa_commonKeys.Handle, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (titleLocale);
		}
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<NSArray<AVTimedMetadataGroup>> LoadChapterMetadataGroupsAsync (NSLocale titleLocale, string[] commonKeys)
		{
			var tcs = new TaskCompletionSource<NSArray<AVTimedMetadataGroup>> ();
			LoadChapterMetadataGroups(titleLocale, commonKeys, (arg1_, arg2_) => {
				if (arg2_ is not null)
					tcs.SetException (new NSErrorException(arg2_));
				else
					tcs.SetResult (arg1_!);
			});
			return tcs.Task;
		}
		[Export ("loadMediaSelectionGroupForMediaCharacteristic:completionHandler:")]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void LoadMediaSelectionGroup (string mediaCharacteristic, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V2))]global::System.Action<AVMediaSelectionGroup, NSError> completionHandler)
		{
			if (mediaCharacteristic is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (mediaCharacteristic));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			var nsmediaCharacteristic = CFString.CreateNative (mediaCharacteristic);
			using var block_completionHandler = Trampolines.SDActionArity2V2.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selLoadMediaSelectionGroupForMediaCharacteristic_CompletionHandler_XHandle, nsmediaCharacteristic, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selLoadMediaSelectionGroupForMediaCharacteristic_CompletionHandler_XHandle, nsmediaCharacteristic, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsmediaCharacteristic);
		}
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<AVMediaSelectionGroup> LoadMediaSelectionGroupAsync (string mediaCharacteristic)
		{
			var tcs = new TaskCompletionSource<AVMediaSelectionGroup> ();
			LoadMediaSelectionGroup(mediaCharacteristic, (arg1_, arg2_) => {
				if (arg2_ is not null)
					tcs.SetException (new NSErrorException(arg2_));
				else
					tcs.SetResult (arg1_!);
			});
			return tcs.Task;
		}
		[Export ("loadMetadataForFormat:completionHandler:")]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void LoadMetadata (string format, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V3))]global::System.Action<NSArray<AVMetadataItem>, NSError> completionHandler)
		{
			if (format is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (format));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			var nsformat = CFString.CreateNative (format);
			using var block_completionHandler = Trampolines.SDActionArity2V3.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selLoadMetadataForFormat_CompletionHandler_XHandle, nsformat, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selLoadMetadataForFormat_CompletionHandler_XHandle, nsformat, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsformat);
		}
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<NSArray<AVMetadataItem>> LoadMetadataAsync (string format)
		{
			var tcs = new TaskCompletionSource<NSArray<AVMetadataItem>> ();
			LoadMetadata(format, (arg1_, arg2_) => {
				if (arg2_ is not null)
					tcs.SetException (new NSErrorException(arg2_));
				else
					tcs.SetResult (arg1_!);
			});
			return tcs.Task;
		}
		[Export ("loadTrackWithTrackID:completionHandler:")]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void LoadTrack (int trackId, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V4))]global::System.Action<AVCompositionTrack, NSError> completionHandler)
		{
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity2V4.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_int_NativeHandle (this.Handle, selLoadTrackWithTrackID_CompletionHandler_XHandle, trackId, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_int_NativeHandle (&__objc_super__, selLoadTrackWithTrackID_CompletionHandler_XHandle, trackId, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
		}
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<AVCompositionTrack> LoadTrackAsync (int trackId)
		{
			var tcs = new TaskCompletionSource<AVCompositionTrack> ();
			LoadTrack(trackId, (arg1_, arg2_) => {
				if (arg2_ is not null)
					tcs.SetException (new NSErrorException(arg2_));
				else
					tcs.SetResult (arg1_!);
			});
			return tcs.Task;
		}
		[Export ("loadTracksWithMediaCharacteristic:completionHandler:")]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void LoadTrackWithMediaCharacteristics (string mediaCharacteristic, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V5))]global::System.Action<NSArray<AVCompositionTrack>, NSError> completionHandler)
		{
			if (mediaCharacteristic is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (mediaCharacteristic));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			var nsmediaCharacteristic = CFString.CreateNative (mediaCharacteristic);
			using var block_completionHandler = Trampolines.SDActionArity2V5.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selLoadTracksWithMediaCharacteristic_CompletionHandler_XHandle, nsmediaCharacteristic, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selLoadTracksWithMediaCharacteristic_CompletionHandler_XHandle, nsmediaCharacteristic, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsmediaCharacteristic);
		}
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<NSArray<AVCompositionTrack>> LoadTrackWithMediaCharacteristicsAsync (string mediaCharacteristic)
		{
			var tcs = new TaskCompletionSource<NSArray<AVCompositionTrack>> ();
			LoadTrackWithMediaCharacteristics(mediaCharacteristic, (arg1_, arg2_) => {
				if (arg2_ is not null)
					tcs.SetException (new NSErrorException(arg2_));
				else
					tcs.SetResult (arg1_!);
			});
			return tcs.Task;
		}
		[Export ("loadTracksWithMediaType:completionHandler:")]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void LoadTracksWithMediaType (string mediaType, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V6))]global::System.Action<NSArray<AVMutableCompositionTrack>, NSError> completionHandler)
		{
			if (mediaType is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (mediaType));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			var nsmediaType = CFString.CreateNative (mediaType);
			using var block_completionHandler = Trampolines.SDActionArity2V6.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selLoadTracksWithMediaType_CompletionHandler_XHandle, nsmediaType, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selLoadTracksWithMediaType_CompletionHandler_XHandle, nsmediaType, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsmediaType);
		}
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<NSArray<AVMutableCompositionTrack>> LoadTracksWithMediaTypeAsync (string mediaType)
		{
			var tcs = new TaskCompletionSource<NSArray<AVMutableCompositionTrack>> ();
			LoadTracksWithMediaType(mediaType, (arg1_, arg2_) => {
				if (arg2_ is not null)
					tcs.SetException (new NSErrorException(arg2_));
				else
					tcs.SetResult (arg1_!);
			});
			return tcs.Task;
		}
		[Export ("loadValuesAsynchronouslyForKeys:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void LoadValuesAsynchronously (string[] keys, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action handler)
		{
			if (keys is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (keys));
			if (handler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (handler));
			using var nsa_keys = NSArray.FromStrings (keys);
			using var block_handler = Trampolines.SDAction.CreateBlock (handler);
			BlockLiteral *block_ptr_handler = &block_handler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selLoadValuesAsynchronouslyForKeys_CompletionHandler_XHandle, nsa_keys.Handle, (IntPtr) block_ptr_handler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selLoadValuesAsynchronouslyForKeys_CompletionHandler_XHandle, nsa_keys.Handle, (IntPtr) block_ptr_handler);
					GC.KeepAlive (this);
				}
			}
		}
		/// <param name="keys">An array of keys to load.</param>
		/// <summary>Asks the asset to load the specified keys (unless they're already loaded).</summary>
		/// <returns>A task that represents the asynchronous LoadValuesAsynchronously operation</returns>
		/// <remarks>
		///           <para copied="true">The LoadValuesTaskAsync method is suitable to be used with C# async by returning control to the caller with a Task representing the operation.</para>
		///           <para copied="true">To be added.</para>
		///         </remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task LoadValuesTaskAsync (string[] keys)
		{
			var tcs = new TaskCompletionSource<bool> ();
			LoadValuesAsynchronously(keys, () => {
				tcs.SetResult (true);
			});
			return tcs.Task;
		}
		[Export ("mediaSelectionGroupForMediaCharacteristic:")]
		[ObsoletedOSPlatform ("macos15.0")]
		[ObsoletedOSPlatform ("ios18.0")]
		[ObsoletedOSPlatform ("maccatalyst18.0")]
		[ObsoletedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual AVMediaSelectionGroup? MediaSelectionGroupForMediaCharacteristic (string avMediaCharacteristic)
		{
			if (avMediaCharacteristic is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (avMediaCharacteristic));
			var nsavMediaCharacteristic = CFString.CreateNative (avMediaCharacteristic);
			AVMediaSelectionGroup? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<AVMediaSelectionGroup> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selMediaSelectionGroupForMediaCharacteristic_XHandle, nsavMediaCharacteristic), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<AVMediaSelectionGroup> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selMediaSelectionGroupForMediaCharacteristic_XHandle, nsavMediaCharacteristic), false)!;
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsavMediaCharacteristic);
			return ret!;
		}
		[Export ("statusOfValueForKey:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual AVKeyValueStatus StatusOfValue (string key, out NSError error)
		{
			if (key is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (key));
			NativeHandle errorValue = IntPtr.Zero;
			var nskey = CFString.CreateNative (key);
			AVKeyValueStatus ret;
			if (IsDirectBinding) {
				ret = (AVKeyValueStatus) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_NativeHandle_ref_NativeHandle (this.Handle, selStatusOfValueForKey_Error_XHandle, nskey, &errorValue);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = (AVKeyValueStatus) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_NativeHandle_ref_NativeHandle (&__objc_super__, selStatusOfValueForKey_Error_XHandle, nskey, &errorValue);
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nskey);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		[Export ("trackWithTrackID:")]
		[ObsoletedOSPlatform ("macos15.0", "Use 'NaturalSize/PreferredTransform' as appropriate on the video track instead.")]
		[ObsoletedOSPlatform ("ios18.0", "Use 'NaturalSize/PreferredTransform' as appropriate on the video track instead.")]
		[ObsoletedOSPlatform ("maccatalyst18.0", "Use 'NaturalSize/PreferredTransform' as appropriate on the video track instead.")]
		[ObsoletedOSPlatform ("tvos18.0", "Use 'NaturalSize/PreferredTransform' as appropriate on the video track instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual AVAssetTrack? TrackWithTrackID (int trackID)
		{
			AVAssetTrack ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<AVAssetTrack> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_int (this.Handle, selTrackWithTrackID_XHandle, trackID), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<AVAssetTrack> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_int (&__objc_super__, selTrackWithTrackID_XHandle, trackID), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("tracksWithMediaCharacteristic:")]
		[ObsoletedOSPlatform ("macos15.0")]
		[ObsoletedOSPlatform ("ios18.0")]
		[ObsoletedOSPlatform ("maccatalyst18.0")]
		[ObsoletedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual AVAssetTrack[] TracksWithMediaCharacteristic (string mediaCharacteristic)
		{
			if (mediaCharacteristic is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (mediaCharacteristic));
			var nsmediaCharacteristic = CFString.CreateNative (mediaCharacteristic);
			AVAssetTrack[]? ret;
			if (IsDirectBinding) {
				ret = CFArray.ArrayFromHandle<AVAssetTrack>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selTracksWithMediaCharacteristic_XHandle, nsmediaCharacteristic), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFArray.ArrayFromHandle<AVAssetTrack>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selTracksWithMediaCharacteristic_XHandle, nsmediaCharacteristic), false)!;
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsmediaCharacteristic);
			return ret!;
		}
		[Export ("tracksWithMediaType:")]
		[ObsoletedOSPlatform ("macos15.0", "Use 'NaturalSize/PreferredTransform' as appropriate on the video track instead.")]
		[ObsoletedOSPlatform ("ios18.0", "Use 'NaturalSize/PreferredTransform' as appropriate on the video track instead.")]
		[ObsoletedOSPlatform ("maccatalyst18.0", "Use 'NaturalSize/PreferredTransform' as appropriate on the video track instead.")]
		[ObsoletedOSPlatform ("tvos18.0", "Use 'NaturalSize/PreferredTransform' as appropriate on the video track instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual AVAssetTrack[] TracksWithMediaType (string mediaType)
		{
			if (mediaType is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (mediaType));
			var nsmediaType = CFString.CreateNative (mediaType);
			AVAssetTrack[]? ret;
			if (IsDirectBinding) {
				ret = CFArray.ArrayFromHandle<AVAssetTrack>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selTracksWithMediaType_XHandle, nsmediaType), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFArray.ArrayFromHandle<AVAssetTrack>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selTracksWithMediaType_XHandle, nsmediaType), false)!;
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsmediaType);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual AVMediaSelection[] AllMediaSelections {
			[Export ("allMediaSelections")]
			get {
				AVMediaSelection[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<AVMediaSelection>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selAllMediaSelectionsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<AVMediaSelection>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selAllMediaSelectionsXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSLocale[] AvailableChapterLocales {
			[Export ("availableChapterLocales")]
			get {
				NSLocale[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<NSLocale>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selAvailableChapterLocalesXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<NSLocale>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selAvailableChapterLocalesXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string[] AvailableMediaCharacteristicsWithMediaSelectionOptions {
			[Export ("availableMediaCharacteristicsWithMediaSelectionOptions")]
			get {
				string[] ret;
				if (IsDirectBinding) {
					ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selAvailableMediaCharacteristicsWithMediaSelectionOptionsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selAvailableMediaCharacteristicsWithMediaSelectionOptionsXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string[] AvailableMetadataFormats {
			[Export ("availableMetadataFormats")]
			get {
				string[] ret;
				if (IsDirectBinding) {
					ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selAvailableMetadataFormatsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selAvailableMetadataFormatsXHandle), false)!;
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
		public virtual bool CanContainFragments {
			[Export ("canContainFragments")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selCanContainFragmentsXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selCanContainFragmentsXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual AVMetadataItem[] CommonMetadata {
			[Export ("commonMetadata")]
			get {
				AVMetadataItem[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<AVMetadataItem>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selCommonMetadataXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<AVMetadataItem>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selCommonMetadataXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		/// <summary>Gets a Boolean value that tells whether the asset works with AirPlay Video.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual bool CompatibleWithAirPlayVideo {
			[Export ("isCompatibleWithAirPlayVideo")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsCompatibleWithAirPlayVideoXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsCompatibleWithAirPlayVideoXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		/// <summary>Whether the asset can be used within a segment of a <see cref="T:AVFoundation.AVCompositionTrack" />.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool Composable {
			[Export ("isComposable")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsComposableXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsComposableXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual bool ContainsFragments {
			[Export ("containsFragments")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selContainsFragmentsXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selContainsFragmentsXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual AVMetadataItem? CreationDate {
			[Export ("creationDate")]
			get {
				AVMetadataItem? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<AVMetadataItem> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selCreationDateXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<AVMetadataItem> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selCreationDateXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::CoreMedia.CMTime Duration {
			[Export ("duration")]
			get {
				global::CoreMedia.CMTime ret;
				if (IsDirectBinding) {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						ret = global::ObjCRuntime.Messaging.CMTime_objc_msgSend (this.Handle, selDurationXHandle);
					} else {
						ret = global::ObjCRuntime.Messaging.CMTime_objc_msgSend_stret (this.Handle, selDurationXHandle);
					}
				} else {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.CMTime_objc_msgSendSuper (&__objc_super__, selDurationXHandle);
							GC.KeepAlive (this);
						}
					} else {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.CMTime_objc_msgSendSuper_stret (&__objc_super__, selDurationXHandle);
							GC.KeepAlive (this);
						}
					}
				}
				return ret!;
			}
		}
		/// <summary>Whether the asset can be exported using a <see cref="T:AVFoundation.AVAssetExportSession" />.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool Exportable {
			[Export ("isExportable")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsExportableXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsExportableXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string? Lyrics {
			[Export ("lyrics")]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selLyricsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selLyricsXHandle), false)!;
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
		public virtual AVMetadataItem[] Metadata {
			[Export ("metadata")]
			get {
				AVMetadataItem[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<AVMetadataItem>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selMetadataXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<AVMetadataItem>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selMetadataXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public virtual global::CoreMedia.CMTime MinimumTimeOffsetFromLive {
			[Export ("minimumTimeOffsetFromLive")]
			get {
				global::CoreMedia.CMTime ret;
				if (IsDirectBinding) {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						ret = global::ObjCRuntime.Messaging.CMTime_objc_msgSend (this.Handle, selMinimumTimeOffsetFromLiveXHandle);
					} else {
						ret = global::ObjCRuntime.Messaging.CMTime_objc_msgSend_stret (this.Handle, selMinimumTimeOffsetFromLiveXHandle);
					}
				} else {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.CMTime_objc_msgSendSuper (&__objc_super__, selMinimumTimeOffsetFromLiveXHandle);
							GC.KeepAlive (this);
						}
					} else {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.CMTime_objc_msgSendSuper_stret (&__objc_super__, selMinimumTimeOffsetFromLiveXHandle);
							GC.KeepAlive (this);
						}
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[ObsoletedOSPlatform ("ios5.0", "Use 'NaturalSize/PreferredTransform' as appropriate on the video track instead.")]
		[ObsoletedOSPlatform ("tvos9.0", "Use 'NaturalSize/PreferredTransform' as appropriate on the video track instead.")]
		[ObsoletedOSPlatform ("macos10.8", "Use 'NaturalSize/PreferredTransform' as appropriate on the video track instead.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'NaturalSize/PreferredTransform' as appropriate on the video track instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		public virtual CGSize NaturalSize {
			[Export ("naturalSize")]
			get {
				CGSize ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.CGSize_objc_msgSend (this.Handle, selNaturalSizeXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGSize_objc_msgSendSuper (&__objc_super__, selNaturalSizeXHandle);
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
		public virtual global::CoreMedia.CMTime OverallDurationHint {
			[Export ("overallDurationHint")]
			get {
				global::CoreMedia.CMTime ret;
				if (IsDirectBinding) {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						ret = global::ObjCRuntime.Messaging.CMTime_objc_msgSend (this.Handle, selOverallDurationHintXHandle);
					} else {
						ret = global::ObjCRuntime.Messaging.CMTime_objc_msgSend_stret (this.Handle, selOverallDurationHintXHandle);
					}
				} else {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.CMTime_objc_msgSendSuper (&__objc_super__, selOverallDurationHintXHandle);
							GC.KeepAlive (this);
						}
					} else {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.CMTime_objc_msgSendSuper_stret (&__objc_super__, selOverallDurationHintXHandle);
							GC.KeepAlive (this);
						}
					}
				}
				return ret!;
			}
		}
		/// <summary>Whether the asset or its URL can be used with a <see cref="T:AVFoundation.AVPlayerItem" />.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool Playable {
			[Export ("isPlayable")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsPlayableXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsPlayableXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual AVMediaSelection PreferredMediaSelection {
			[Export ("preferredMediaSelection")]
			get {
				AVMediaSelection? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<AVMediaSelection> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selPreferredMediaSelectionXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<AVMediaSelection> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selPreferredMediaSelectionXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual float PreferredRate {
			[Export ("preferredRate")]
			get {
				float ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selPreferredRateXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.float_objc_msgSendSuper (&__objc_super__, selPreferredRateXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGAffineTransform PreferredTransform {
			[Export ("preferredTransform")]
			get {
				CGAffineTransform ret;
				if (IsDirectBinding) {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						ret = global::ObjCRuntime.Messaging.CGAffineTransform_objc_msgSend (this.Handle, selPreferredTransformXHandle);
					} else {
						ret = global::ObjCRuntime.Messaging.CGAffineTransform_objc_msgSend_stret (this.Handle, selPreferredTransformXHandle);
					}
				} else {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.CGAffineTransform_objc_msgSendSuper (&__objc_super__, selPreferredTransformXHandle);
							GC.KeepAlive (this);
						}
					} else {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.CGAffineTransform_objc_msgSendSuper_stret (&__objc_super__, selPreferredTransformXHandle);
							GC.KeepAlive (this);
						}
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual float PreferredVolume {
			[Export ("preferredVolume")]
			get {
				float ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selPreferredVolumeXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.float_objc_msgSendSuper (&__objc_super__, selPreferredVolumeXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ProtectedContent {
			[Export ("hasProtectedContent")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selHasProtectedContentXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selHasProtectedContentXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ProvidesPreciseDurationAndTiming {
			[Export ("providesPreciseDurationAndTiming")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selProvidesPreciseDurationAndTimingXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selProvidesPreciseDurationAndTimingXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		/// <summary>Whether the asset's media data is compatible with <see cref="T:AVFoundation.AVAssetReader" />.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool Readable {
			[Export ("isReadable")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsReadableXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsReadableXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual AVAssetReferenceRestrictions ReferenceRestrictions {
			[Export ("referenceRestrictions")]
			get {
				AVAssetReferenceRestrictions ret;
				if (IsDirectBinding) {
					ret = (AVAssetReferenceRestrictions) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selReferenceRestrictionsXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (AVAssetReferenceRestrictions) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selReferenceRestrictionsXHandle);
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
		public virtual AVAssetTrackGroup[] TrackGroups {
			[Export ("trackGroups", ArgumentSemantic.Copy)]
			get {
				AVAssetTrackGroup[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<AVAssetTrackGroup>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selTrackGroupsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<AVAssetTrackGroup>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selTrackGroupsXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual AVAssetTrack[] Tracks {
			[Export ("tracks")]
			get {
				AVAssetTrack[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<AVAssetTrack>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selTracksXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<AVAssetTrack>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selTracksXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[ObsoletedOSPlatform ("macos15.0")]
		[ObsoletedOSPlatform ("ios18.0")]
		[ObsoletedOSPlatform ("tvos18.0")]
		[ObsoletedOSPlatform ("maccatalyst18.0")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		public virtual int UnusedTrackId {
			[Export ("unusedTrackID")]
			get {
				int ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.int_objc_msgSend (this.Handle, selUnusedTrackIDXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.int_objc_msgSendSuper (&__objc_super__, selUnusedTrackIDXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ChapterMetadataGroupsDidChangeNotification;
		/// <summary>Notification constant for ChapterMetadataGroupsDidChange</summary>
		/// <value><see cref="NSString" /> constant, should be used as a token to <see cref="NSNotificationCenter" />.</value>
		/// <remarks>
		///   <para>
		///     This constant can be used with <see cref="NSNotificationCenter" /> to register a listener for this notification.
		///     This is an <see cref="NSString" /> instead of a string, because these values can be used as tokens in some native
		///     libraries instead of being used purely for their actual string content. The 'notification' parameter to the callback
		///     contains extra information that is specific to the notification type.
		///   </para>
		///   <para>
		///     To subscribe to this notification, developers can use the convenience <see cref="Notifications.ObserveChapterMetadataGroupsDidChange(NSObject,EventHandler{NSNotificationEventArgs})" />
		///     or <see cref="Notifications.ObserveChapterMetadataGroupsDidChange(EventHandler{NSNotificationEventArgs})" /> methods,
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
		/// notification = AVAsset.Notifications.ObserveChapterMetadataGroupsDidChange ((sender, args) => {
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
		/// void Callback (object sender, AVAsset.NSNotificationEventArgs args)
		/// {
		///     // Access strongly typed args
		///     Console.WriteLine ("Notification: {0}", args.Notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     notification = AVAsset.Notifications.ObserveChapterMetadataGroupsDidChange (Callback);
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
		///     AVAsset.ChapterMetadataGroupsDidChangeNotification, (notification) => { Console.WriteLine ("Received the notification ChapterMetadataGroupsDidChange", notification); }
		/// );
		///
		/// // Method style
		/// void Callback (NSNotification notification)
		/// {
		///     Console.WriteLine ("Received the notification ChapterMetadataGroupsDidChange", notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     NSNotificationCenter.DefaultCenter.AddObserver (AVAsset.ChapterMetadataGroupsDidChangeNotification, Callback);
		/// }
		/// ]]></code>
		///   </example>
		/// </remarks>
		[Field ("AVAssetChapterMetadataGroupsDidChangeNotification",  "AVFoundation")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[Advice ("Use AVAsset.Notifications.ObserveChapterMetadataGroupsDidChange helper method instead.")]
		public static NSString ChapterMetadataGroupsDidChangeNotification {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_ChapterMetadataGroupsDidChangeNotification is null)
					_ChapterMetadataGroupsDidChangeNotification = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVAssetChapterMetadataGroupsDidChangeNotification")!;
				return _ChapterMetadataGroupsDidChangeNotification;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ContainsFragmentsDidChangeNotification;
		/// <summary>Notification constant for ContainsFragmentsDidChange</summary>
		/// <value><see cref="NSString" /> constant, should be used as a token to <see cref="NSNotificationCenter" />.</value>
		/// <remarks>
		///   <para>
		///     This constant can be used with <see cref="NSNotificationCenter" /> to register a listener for this notification.
		///     This is an <see cref="NSString" /> instead of a string, because these values can be used as tokens in some native
		///     libraries instead of being used purely for their actual string content. The 'notification' parameter to the callback
		///     contains extra information that is specific to the notification type.
		///   </para>
		///   <para>
		///     To subscribe to this notification, developers can use the convenience <see cref="Notifications.ObserveContainsFragmentsDidChange(NSObject,EventHandler{NSNotificationEventArgs})" />
		///     or <see cref="Notifications.ObserveContainsFragmentsDidChange(EventHandler{NSNotificationEventArgs})" /> methods,
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
		/// notification = AVAsset.Notifications.ObserveContainsFragmentsDidChange ((sender, args) => {
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
		/// void Callback (object sender, AVAsset.NSNotificationEventArgs args)
		/// {
		///     // Access strongly typed args
		///     Console.WriteLine ("Notification: {0}", args.Notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     notification = AVAsset.Notifications.ObserveContainsFragmentsDidChange (Callback);
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
		///     AVAsset.ContainsFragmentsDidChangeNotification, (notification) => { Console.WriteLine ("Received the notification ContainsFragmentsDidChange", notification); }
		/// );
		///
		/// // Method style
		/// void Callback (NSNotification notification)
		/// {
		///     Console.WriteLine ("Received the notification ContainsFragmentsDidChange", notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     NSNotificationCenter.DefaultCenter.AddObserver (AVAsset.ContainsFragmentsDidChangeNotification, Callback);
		/// }
		/// ]]></code>
		///   </example>
		/// </remarks>
		[Field ("AVAssetContainsFragmentsDidChangeNotification",  "AVFoundation")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[Advice ("Use AVAsset.Notifications.ObserveContainsFragmentsDidChange helper method instead.")]
		public static NSString ContainsFragmentsDidChangeNotification {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_ContainsFragmentsDidChangeNotification is null)
					_ContainsFragmentsDidChangeNotification = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVAssetContainsFragmentsDidChangeNotification")!;
				return _ContainsFragmentsDidChangeNotification;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DurationDidChangeNotification;
		/// <summary>Notification constant for DurationDidChange</summary>
		/// <value><see cref="NSString" /> constant, should be used as a token to <see cref="NSNotificationCenter" />.</value>
		/// <remarks>
		///   <para>
		///     This constant can be used with <see cref="NSNotificationCenter" /> to register a listener for this notification.
		///     This is an <see cref="NSString" /> instead of a string, because these values can be used as tokens in some native
		///     libraries instead of being used purely for their actual string content. The 'notification' parameter to the callback
		///     contains extra information that is specific to the notification type.
		///   </para>
		///   <para>
		///     To subscribe to this notification, developers can use the convenience <see cref="Notifications.ObserveDurationDidChange(NSObject,EventHandler{NSNotificationEventArgs})" />
		///     or <see cref="Notifications.ObserveDurationDidChange(EventHandler{NSNotificationEventArgs})" /> methods,
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
		/// notification = AVAsset.Notifications.ObserveDurationDidChange ((sender, args) => {
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
		/// void Callback (object sender, AVAsset.NSNotificationEventArgs args)
		/// {
		///     // Access strongly typed args
		///     Console.WriteLine ("Notification: {0}", args.Notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     notification = AVAsset.Notifications.ObserveDurationDidChange (Callback);
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
		///     AVAsset.DurationDidChangeNotification, (notification) => { Console.WriteLine ("Received the notification DurationDidChange", notification); }
		/// );
		///
		/// // Method style
		/// void Callback (NSNotification notification)
		/// {
		///     Console.WriteLine ("Received the notification DurationDidChange", notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     NSNotificationCenter.DefaultCenter.AddObserver (AVAsset.DurationDidChangeNotification, Callback);
		/// }
		/// ]]></code>
		///   </example>
		/// </remarks>
		[Field ("AVAssetDurationDidChangeNotification",  "AVFoundation")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[Advice ("Use AVAsset.Notifications.ObserveDurationDidChange helper method instead.")]
		public static NSString DurationDidChangeNotification {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_DurationDidChangeNotification is null)
					_DurationDidChangeNotification = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVAssetDurationDidChangeNotification")!;
				return _DurationDidChangeNotification;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _MediaSelectionGroupsDidChangeNotification;
		/// <summary>Notification constant for MediaSelectionGroupsDidChange</summary>
		/// <value><see cref="NSString" /> constant, should be used as a token to <see cref="NSNotificationCenter" />.</value>
		/// <remarks>
		///   <para>
		///     This constant can be used with <see cref="NSNotificationCenter" /> to register a listener for this notification.
		///     This is an <see cref="NSString" /> instead of a string, because these values can be used as tokens in some native
		///     libraries instead of being used purely for their actual string content. The 'notification' parameter to the callback
		///     contains extra information that is specific to the notification type.
		///   </para>
		///   <para>
		///     To subscribe to this notification, developers can use the convenience <see cref="Notifications.ObserveMediaSelectionGroupsDidChange(NSObject,EventHandler{NSNotificationEventArgs})" />
		///     or <see cref="Notifications.ObserveMediaSelectionGroupsDidChange(EventHandler{NSNotificationEventArgs})" /> methods,
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
		/// notification = AVAsset.Notifications.ObserveMediaSelectionGroupsDidChange ((sender, args) => {
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
		/// void Callback (object sender, AVAsset.NSNotificationEventArgs args)
		/// {
		///     // Access strongly typed args
		///     Console.WriteLine ("Notification: {0}", args.Notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     notification = AVAsset.Notifications.ObserveMediaSelectionGroupsDidChange (Callback);
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
		///     AVAsset.MediaSelectionGroupsDidChangeNotification, (notification) => { Console.WriteLine ("Received the notification MediaSelectionGroupsDidChange", notification); }
		/// );
		///
		/// // Method style
		/// void Callback (NSNotification notification)
		/// {
		///     Console.WriteLine ("Received the notification MediaSelectionGroupsDidChange", notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     NSNotificationCenter.DefaultCenter.AddObserver (AVAsset.MediaSelectionGroupsDidChangeNotification, Callback);
		/// }
		/// ]]></code>
		///   </example>
		/// </remarks>
		[Field ("AVAssetMediaSelectionGroupsDidChangeNotification",  "AVFoundation")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[Advice ("Use AVAsset.Notifications.ObserveMediaSelectionGroupsDidChange helper method instead.")]
		public static NSString MediaSelectionGroupsDidChangeNotification {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_MediaSelectionGroupsDidChangeNotification is null)
					_MediaSelectionGroupsDidChangeNotification = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVAssetMediaSelectionGroupsDidChangeNotification")!;
				return _MediaSelectionGroupsDidChangeNotification;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _WasDefragmentedNotification;
		/// <summary>Notification constant for WasDefragmented</summary>
		/// <value><see cref="NSString" /> constant, should be used as a token to <see cref="NSNotificationCenter" />.</value>
		/// <remarks>
		///   <para>
		///     This constant can be used with <see cref="NSNotificationCenter" /> to register a listener for this notification.
		///     This is an <see cref="NSString" /> instead of a string, because these values can be used as tokens in some native
		///     libraries instead of being used purely for their actual string content. The 'notification' parameter to the callback
		///     contains extra information that is specific to the notification type.
		///   </para>
		///   <para>
		///     To subscribe to this notification, developers can use the convenience <see cref="Notifications.ObserveWasDefragmented(NSObject,EventHandler{NSNotificationEventArgs})" />
		///     or <see cref="Notifications.ObserveWasDefragmented(EventHandler{NSNotificationEventArgs})" /> methods,
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
		/// notification = AVAsset.Notifications.ObserveWasDefragmented ((sender, args) => {
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
		/// void Callback (object sender, AVAsset.NSNotificationEventArgs args)
		/// {
		///     // Access strongly typed args
		///     Console.WriteLine ("Notification: {0}", args.Notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     notification = AVAsset.Notifications.ObserveWasDefragmented (Callback);
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
		///     AVAsset.WasDefragmentedNotification, (notification) => { Console.WriteLine ("Received the notification WasDefragmented", notification); }
		/// );
		///
		/// // Method style
		/// void Callback (NSNotification notification)
		/// {
		///     Console.WriteLine ("Received the notification WasDefragmented", notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     NSNotificationCenter.DefaultCenter.AddObserver (AVAsset.WasDefragmentedNotification, Callback);
		/// }
		/// ]]></code>
		///   </example>
		/// </remarks>
		[Field ("AVAssetWasDefragmentedNotification",  "AVFoundation")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[Advice ("Use AVAsset.Notifications.ObserveWasDefragmented helper method instead.")]
		public static NSString WasDefragmentedNotification {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_WasDefragmentedNotification is null)
					_WasDefragmentedNotification = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVAssetWasDefragmentedNotification")!;
				return _WasDefragmentedNotification;
			}
		}
		//
		// Notifications
		//
		/// <summary>Notifications posted by the <see cref="global::AVFoundation.AVAsset" /> class.</summary>
		/// <remarks>
		///    <para>This class contains various helper methods that allow developers to observe events posted in the notification hub (<see cref="Foundation.NSNotificationCenter" />).</para>
		///    <para>The methods defined in this class post events that invoke the provided method or lambda with a <see cref="Foundation.NSNotificationEventArgs" /> parameter, which contains strongly typed properties for the notification arguments.</para>
		/// </remarks>
		public static partial class Notifications {
			/// <summary>Strongly typed notification for the <see cref="global::AVFoundation.AVAsset.ChapterMetadataGroupsDidChangeNotification" /> constant.</summary>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::AVFoundation.AVAsset.ChapterMetadataGroupsDidChangeNotification" /> notifications.</para>
			///   <example>
			///   <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for any object
			/// var token = AVAsset.Notifications.ObserveChapterMetadataGroupsDidChange ((notification) => {
			///   Console.WriteLine ("Observed ChapterMetadataGroupsDidChangeNotification!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveChapterMetadataGroupsDidChange (EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (ChapterMetadataGroupsDidChangeNotification, notification => handler (null, new NSNotificationEventArgs (notification)));
			}
			/// <summary>Strongly typed notification for the <see cref="global::AVFoundation.AVAsset.ChapterMetadataGroupsDidChangeNotification" /> constant.</summary>
			/// <param name="objectToObserve">The specific object to observe.</param>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::AVFoundation.AVAsset.ChapterMetadataGroupsDidChangeNotification" /> notifications.</para>
			///   <example>
			///     <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for a single object
			/// var token = AVAsset.Notifications.ObserveChapterMetadataGroupsDidChange (objectToObserve, (notification) => {
			///   Console.WriteLine ($"Observed ChapterMetadataGroupsDidChangeNotification for {nameof (objectToObserve)}!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveChapterMetadataGroupsDidChange (NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (ChapterMetadataGroupsDidChangeNotification, notification => handler (null, new NSNotificationEventArgs (notification)), objectToObserve);
			}
			/// <summary>Strongly typed notification for the <see cref="global::AVFoundation.AVAsset.ContainsFragmentsDidChangeNotification" /> constant.</summary>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::AVFoundation.AVAsset.ContainsFragmentsDidChangeNotification" /> notifications.</para>
			///   <example>
			///   <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for any object
			/// var token = AVAsset.Notifications.ObserveContainsFragmentsDidChange ((notification) => {
			///   Console.WriteLine ("Observed ContainsFragmentsDidChangeNotification!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveContainsFragmentsDidChange (EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (ContainsFragmentsDidChangeNotification, notification => handler (null, new NSNotificationEventArgs (notification)));
			}
			/// <summary>Strongly typed notification for the <see cref="global::AVFoundation.AVAsset.ContainsFragmentsDidChangeNotification" /> constant.</summary>
			/// <param name="objectToObserve">The specific object to observe.</param>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::AVFoundation.AVAsset.ContainsFragmentsDidChangeNotification" /> notifications.</para>
			///   <example>
			///     <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for a single object
			/// var token = AVAsset.Notifications.ObserveContainsFragmentsDidChange (objectToObserve, (notification) => {
			///   Console.WriteLine ($"Observed ContainsFragmentsDidChangeNotification for {nameof (objectToObserve)}!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveContainsFragmentsDidChange (NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (ContainsFragmentsDidChangeNotification, notification => handler (null, new NSNotificationEventArgs (notification)), objectToObserve);
			}
			/// <summary>Strongly typed notification for the <see cref="global::AVFoundation.AVAsset.DurationDidChangeNotification" /> constant.</summary>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::AVFoundation.AVAsset.DurationDidChangeNotification" /> notifications.</para>
			///   <example>
			///   <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for any object
			/// var token = AVAsset.Notifications.ObserveDurationDidChange ((notification) => {
			///   Console.WriteLine ("Observed DurationDidChangeNotification!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveDurationDidChange (EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (DurationDidChangeNotification, notification => handler (null, new NSNotificationEventArgs (notification)));
			}
			/// <summary>Strongly typed notification for the <see cref="global::AVFoundation.AVAsset.DurationDidChangeNotification" /> constant.</summary>
			/// <param name="objectToObserve">The specific object to observe.</param>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::AVFoundation.AVAsset.DurationDidChangeNotification" /> notifications.</para>
			///   <example>
			///     <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for a single object
			/// var token = AVAsset.Notifications.ObserveDurationDidChange (objectToObserve, (notification) => {
			///   Console.WriteLine ($"Observed DurationDidChangeNotification for {nameof (objectToObserve)}!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveDurationDidChange (NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (DurationDidChangeNotification, notification => handler (null, new NSNotificationEventArgs (notification)), objectToObserve);
			}
			/// <summary>Strongly typed notification for the <see cref="global::AVFoundation.AVAsset.MediaSelectionGroupsDidChangeNotification" /> constant.</summary>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::AVFoundation.AVAsset.MediaSelectionGroupsDidChangeNotification" /> notifications.</para>
			///   <example>
			///   <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for any object
			/// var token = AVAsset.Notifications.ObserveMediaSelectionGroupsDidChange ((notification) => {
			///   Console.WriteLine ("Observed MediaSelectionGroupsDidChangeNotification!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveMediaSelectionGroupsDidChange (EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (MediaSelectionGroupsDidChangeNotification, notification => handler (null, new NSNotificationEventArgs (notification)));
			}
			/// <summary>Strongly typed notification for the <see cref="global::AVFoundation.AVAsset.MediaSelectionGroupsDidChangeNotification" /> constant.</summary>
			/// <param name="objectToObserve">The specific object to observe.</param>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::AVFoundation.AVAsset.MediaSelectionGroupsDidChangeNotification" /> notifications.</para>
			///   <example>
			///     <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for a single object
			/// var token = AVAsset.Notifications.ObserveMediaSelectionGroupsDidChange (objectToObserve, (notification) => {
			///   Console.WriteLine ($"Observed MediaSelectionGroupsDidChangeNotification for {nameof (objectToObserve)}!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveMediaSelectionGroupsDidChange (NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (MediaSelectionGroupsDidChangeNotification, notification => handler (null, new NSNotificationEventArgs (notification)), objectToObserve);
			}
			/// <summary>Strongly typed notification for the <see cref="global::AVFoundation.AVAsset.WasDefragmentedNotification" /> constant.</summary>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::AVFoundation.AVAsset.WasDefragmentedNotification" /> notifications.</para>
			///   <example>
			///   <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for any object
			/// var token = AVAsset.Notifications.ObserveWasDefragmented ((notification) => {
			///   Console.WriteLine ("Observed WasDefragmentedNotification!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveWasDefragmented (EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (WasDefragmentedNotification, notification => handler (null, new NSNotificationEventArgs (notification)));
			}
			/// <summary>Strongly typed notification for the <see cref="global::AVFoundation.AVAsset.WasDefragmentedNotification" /> constant.</summary>
			/// <param name="objectToObserve">The specific object to observe.</param>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::AVFoundation.AVAsset.WasDefragmentedNotification" /> notifications.</para>
			///   <example>
			///     <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for a single object
			/// var token = AVAsset.Notifications.ObserveWasDefragmented (objectToObserve, (notification) => {
			///   Console.WriteLine ($"Observed WasDefragmentedNotification for {nameof (objectToObserve)}!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveWasDefragmented (NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (WasDefragmentedNotification, notification => handler (null, new NSNotificationEventArgs (notification)), objectToObserve);
			}
		}
	} /* class AVAsset */
}
