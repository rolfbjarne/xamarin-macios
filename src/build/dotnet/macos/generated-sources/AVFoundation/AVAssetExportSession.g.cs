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
	[Register("AVAssetExportSession", true)]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe partial class AVAssetExportSession : NSObject {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAllExportPresetsX = "allExportPresets";
		static readonly NativeHandle selAllExportPresetsXHandle = Selector.GetHandle ("allExportPresets");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAllowsParallelizedExportX = "allowsParallelizedExport";
		static readonly NativeHandle selAllowsParallelizedExportXHandle = Selector.GetHandle ("allowsParallelizedExport");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAssetX = "asset";
		static readonly NativeHandle selAssetXHandle = Selector.GetHandle ("asset");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAudioMixX = "audioMix";
		static readonly NativeHandle selAudioMixXHandle = Selector.GetHandle ("audioMix");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAudioTimePitchAlgorithmX = "audioTimePitchAlgorithm";
		static readonly NativeHandle selAudioTimePitchAlgorithmXHandle = Selector.GetHandle ("audioTimePitchAlgorithm");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAudioTrackGroupHandlingX = "audioTrackGroupHandling";
		static readonly NativeHandle selAudioTrackGroupHandlingXHandle = Selector.GetHandle ("audioTrackGroupHandling");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCanPerformMultiplePassesOverSourceMediaDataX = "canPerformMultiplePassesOverSourceMediaData";
		static readonly NativeHandle selCanPerformMultiplePassesOverSourceMediaDataXHandle = Selector.GetHandle ("canPerformMultiplePassesOverSourceMediaData");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCancelExportX = "cancelExport";
		static readonly NativeHandle selCancelExportXHandle = Selector.GetHandle ("cancelExport");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCustomVideoCompositorX = "customVideoCompositor";
		static readonly NativeHandle selCustomVideoCompositorXHandle = Selector.GetHandle ("customVideoCompositor");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDetermineCompatibilityOfExportPreset_WithAsset_OutputFileType_CompletionHandler_X = "determineCompatibilityOfExportPreset:withAsset:outputFileType:completionHandler:";
		static readonly NativeHandle selDetermineCompatibilityOfExportPreset_WithAsset_OutputFileType_CompletionHandler_XHandle = Selector.GetHandle ("determineCompatibilityOfExportPreset:withAsset:outputFileType:completionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDetermineCompatibleFileTypesWithCompletionHandler_X = "determineCompatibleFileTypesWithCompletionHandler:";
		static readonly NativeHandle selDetermineCompatibleFileTypesWithCompletionHandler_XHandle = Selector.GetHandle ("determineCompatibleFileTypesWithCompletionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDirectoryForTemporaryFilesX = "directoryForTemporaryFiles";
		static readonly NativeHandle selDirectoryForTemporaryFilesXHandle = Selector.GetHandle ("directoryForTemporaryFiles");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selErrorX = "error";
		static readonly NativeHandle selErrorXHandle = Selector.GetHandle ("error");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selEstimateMaximumDurationWithCompletionHandler_X = "estimateMaximumDurationWithCompletionHandler:";
		static readonly NativeHandle selEstimateMaximumDurationWithCompletionHandler_XHandle = Selector.GetHandle ("estimateMaximumDurationWithCompletionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selEstimateOutputFileLengthWithCompletionHandler_X = "estimateOutputFileLengthWithCompletionHandler:";
		static readonly NativeHandle selEstimateOutputFileLengthWithCompletionHandler_XHandle = Selector.GetHandle ("estimateOutputFileLengthWithCompletionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selEstimatedOutputFileLengthX = "estimatedOutputFileLength";
		static readonly NativeHandle selEstimatedOutputFileLengthXHandle = Selector.GetHandle ("estimatedOutputFileLength");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selExportAsynchronouslyWithCompletionHandler_X = "exportAsynchronouslyWithCompletionHandler:";
		static readonly NativeHandle selExportAsynchronouslyWithCompletionHandler_XHandle = Selector.GetHandle ("exportAsynchronouslyWithCompletionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selExportPresetsCompatibleWithAsset_X = "exportPresetsCompatibleWithAsset:";
		static readonly NativeHandle selExportPresetsCompatibleWithAsset_XHandle = Selector.GetHandle ("exportPresetsCompatibleWithAsset:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selExportSessionWithAsset_PresetName_X = "exportSessionWithAsset:presetName:";
		static readonly NativeHandle selExportSessionWithAsset_PresetName_XHandle = Selector.GetHandle ("exportSessionWithAsset:presetName:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFileLengthLimitX = "fileLengthLimit";
		static readonly NativeHandle selFileLengthLimitXHandle = Selector.GetHandle ("fileLengthLimit");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithAsset_PresetName_X = "initWithAsset:presetName:";
		static readonly NativeHandle selInitWithAsset_PresetName_XHandle = Selector.GetHandle ("initWithAsset:presetName:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMaxDurationX = "maxDuration";
		static readonly NativeHandle selMaxDurationXHandle = Selector.GetHandle ("maxDuration");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMetadataX = "metadata";
		static readonly NativeHandle selMetadataXHandle = Selector.GetHandle ("metadata");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMetadataItemFilterX = "metadataItemFilter";
		static readonly NativeHandle selMetadataItemFilterXHandle = Selector.GetHandle ("metadataItemFilter");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selOutputFileTypeX = "outputFileType";
		static readonly NativeHandle selOutputFileTypeXHandle = Selector.GetHandle ("outputFileType");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selOutputURLX = "outputURL";
		static readonly NativeHandle selOutputURLXHandle = Selector.GetHandle ("outputURL");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPresetNameX = "presetName";
		static readonly NativeHandle selPresetNameXHandle = Selector.GetHandle ("presetName");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selProgressX = "progress";
		static readonly NativeHandle selProgressXHandle = Selector.GetHandle ("progress");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAllowsParallelizedExport_X = "setAllowsParallelizedExport:";
		static readonly NativeHandle selSetAllowsParallelizedExport_XHandle = Selector.GetHandle ("setAllowsParallelizedExport:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAudioMix_X = "setAudioMix:";
		static readonly NativeHandle selSetAudioMix_XHandle = Selector.GetHandle ("setAudioMix:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAudioTimePitchAlgorithm_X = "setAudioTimePitchAlgorithm:";
		static readonly NativeHandle selSetAudioTimePitchAlgorithm_XHandle = Selector.GetHandle ("setAudioTimePitchAlgorithm:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAudioTrackGroupHandling_X = "setAudioTrackGroupHandling:";
		static readonly NativeHandle selSetAudioTrackGroupHandling_XHandle = Selector.GetHandle ("setAudioTrackGroupHandling:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetCanPerformMultiplePassesOverSourceMediaData_X = "setCanPerformMultiplePassesOverSourceMediaData:";
		static readonly NativeHandle selSetCanPerformMultiplePassesOverSourceMediaData_XHandle = Selector.GetHandle ("setCanPerformMultiplePassesOverSourceMediaData:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetDirectoryForTemporaryFiles_X = "setDirectoryForTemporaryFiles:";
		static readonly NativeHandle selSetDirectoryForTemporaryFiles_XHandle = Selector.GetHandle ("setDirectoryForTemporaryFiles:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetFileLengthLimit_X = "setFileLengthLimit:";
		static readonly NativeHandle selSetFileLengthLimit_XHandle = Selector.GetHandle ("setFileLengthLimit:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetMetadata_X = "setMetadata:";
		static readonly NativeHandle selSetMetadata_XHandle = Selector.GetHandle ("setMetadata:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetMetadataItemFilter_X = "setMetadataItemFilter:";
		static readonly NativeHandle selSetMetadataItemFilter_XHandle = Selector.GetHandle ("setMetadataItemFilter:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetOutputFileType_X = "setOutputFileType:";
		static readonly NativeHandle selSetOutputFileType_XHandle = Selector.GetHandle ("setOutputFileType:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetOutputURL_X = "setOutputURL:";
		static readonly NativeHandle selSetOutputURL_XHandle = Selector.GetHandle ("setOutputURL:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetShouldOptimizeForNetworkUse_X = "setShouldOptimizeForNetworkUse:";
		static readonly NativeHandle selSetShouldOptimizeForNetworkUse_XHandle = Selector.GetHandle ("setShouldOptimizeForNetworkUse:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetTimeRange_X = "setTimeRange:";
		static readonly NativeHandle selSetTimeRange_XHandle = Selector.GetHandle ("setTimeRange:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetVideoComposition_X = "setVideoComposition:";
		static readonly NativeHandle selSetVideoComposition_XHandle = Selector.GetHandle ("setVideoComposition:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selShouldOptimizeForNetworkUseX = "shouldOptimizeForNetworkUse";
		static readonly NativeHandle selShouldOptimizeForNetworkUseXHandle = Selector.GetHandle ("shouldOptimizeForNetworkUse");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selStatusX = "status";
		static readonly NativeHandle selStatusXHandle = Selector.GetHandle ("status");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSupportedFileTypesX = "supportedFileTypes";
		static readonly NativeHandle selSupportedFileTypesXHandle = Selector.GetHandle ("supportedFileTypes");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTimeRangeX = "timeRange";
		static readonly NativeHandle selTimeRangeXHandle = Selector.GetHandle ("timeRange");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selVideoCompositionX = "videoComposition";
		static readonly NativeHandle selVideoCompositionXHandle = Selector.GetHandle ("videoComposition");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("AVAssetExportSession");
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
		protected AVAssetExportSession (NSObjectFlag t) : base (t)
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
		protected internal AVAssetExportSession (NativeHandle handle) : base (handle)
		{
		}

		[Export ("initWithAsset:presetName:")]
		[DesignatedInitializer]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public AVAssetExportSession (AVAsset asset, string presetName)
			: base (NSObjectFlag.Empty)
		{
			var asset__handle__ = asset!.GetNonNullHandle (nameof (asset));
			if (presetName is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (presetName));
			var nspresetName = CFString.CreateNative (presetName);
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selInitWithAsset_PresetName_XHandle, asset__handle__, nspresetName), "initWithAsset:presetName:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selInitWithAsset_PresetName_XHandle, asset__handle__, nspresetName), "initWithAsset:presetName:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (asset);
			CFString.ReleaseNative (nspresetName);
		}
		/// <param name="asset">To be added.</param><param name="preset">To be added.</param><summary>Creates an export session from an AVAsset and a preset.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public AVAssetExportSession (AVAsset asset, AVAssetExportSessionPreset preset)
			: this (asset, preset.GetConstant ()!)
		{
		}
		[Export ("cancelExport")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void CancelExport ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selCancelExportXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selCancelExportXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("determineCompatibilityOfExportPreset:withAsset:outputFileType:completionHandler:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void DetermineCompatibilityOfExportPreset (string presetName, AVAsset asset, string? outputFileType, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V2))]global::System.Action<bool> isCompatibleResult)
		{
			if (presetName is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (presetName));
			var asset__handle__ = asset!.GetNonNullHandle (nameof (asset));
			if (isCompatibleResult is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (isCompatibleResult));
			var nspresetName = CFString.CreateNative (presetName);
			var nsoutputFileType = CFString.CreateNative (outputFileType);
			using var block_isCompatibleResult = Trampolines.SDActionArity1V2.CreateBlock (isCompatibleResult);
			BlockLiteral *block_ptr_isCompatibleResult = &block_isCompatibleResult;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (class_ptr, selDetermineCompatibilityOfExportPreset_WithAsset_OutputFileType_CompletionHandler_XHandle, nspresetName, asset__handle__, nsoutputFileType, (IntPtr) block_ptr_isCompatibleResult);
			GC.KeepAlive (asset);
			CFString.ReleaseNative (nspresetName);
			CFString.ReleaseNative (nsoutputFileType);
		}
		/// <param name="presetName">The preset name (,
		/// ,
		/// ,
		/// ,
		/// ,
		/// ,
		///  or 
		/// ).</param>
		/// <param name="asset">To be added.</param>
		/// <param name="outputFileType">To be added.</param>
		/// <summary>Determines whether the specified preset is compatible with the asset and output file type.</summary>
		/// <returns>
		///           <para class="improve-task-t-return-type-description">A task that represents the asynchronous DetermineCompatibilityOfExportPreset operation.  The value of the TResult parameter is of type System.Action&lt;System.Boolean&gt;.</para>
		///         </returns>
		/// <remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Task<bool> DetermineCompatibilityOfExportPresetAsync (string presetName, AVAsset asset, string? outputFileType)
		{
			var tcs = new TaskCompletionSource<bool> ();
			DetermineCompatibilityOfExportPreset(presetName, asset, outputFileType, (obj_) => {
				tcs.SetResult (obj_!);
			});
			return tcs.Task;
		}
		/// <param name="presetName">The preset to check.</param><param name="asset">The asset against which to check the preset.</param><param name="outputFileType">The output file type against which to check the preset.</param><param name="isCompatibleResult">An action to run with the result of the check.</param><summary>Determines if a preset is compatible with an asset and output type, passing the result to <paramref name="isCompatibleResult" />.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void DetermineCompatibilityOfExportPreset (string presetName, AVAsset asset, AVFileTypes outputFileType, global::System.Action<bool> isCompatibleResult)
		{
			DetermineCompatibilityOfExportPreset (presetName, asset, outputFileType.GetConstant (), isCompatibleResult);
		}
		/// <param name="presetName">The preset to check.</param>
		/// <param name="asset">The asset against which to check the preset.</param>
		/// <param name="outputFileType">The output file type against which to check the preset.</param>
		/// <summary>Asynchronously determines if a preset is compatible with an asset and output type, returning a task that tells if it is.</summary>
		/// <returns>To be added.</returns>
		/// <remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe Task<bool> DetermineCompatibilityOfExportPresetAsync (string presetName, AVAsset asset, AVFileTypes outputFileType)
		{
			var tcs = new TaskCompletionSource<bool> ();
			DetermineCompatibilityOfExportPreset(presetName, asset, outputFileType, (obj_) => {
				tcs.SetResult (obj_!);
			});
			return tcs.Task;
		}
		[Export ("determineCompatibleFileTypesWithCompletionHandler:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void DetermineCompatibleFileTypes ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V3))]global::System.Action<string[]> compatibleFileTypesHandler)
		{
			if (compatibleFileTypesHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (compatibleFileTypesHandler));
			using var block_compatibleFileTypesHandler = Trampolines.SDActionArity1V3.CreateBlock (compatibleFileTypesHandler);
			BlockLiteral *block_ptr_compatibleFileTypesHandler = &block_compatibleFileTypesHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selDetermineCompatibleFileTypesWithCompletionHandler_XHandle, (IntPtr) block_ptr_compatibleFileTypesHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selDetermineCompatibleFileTypesWithCompletionHandler_XHandle, (IntPtr) block_ptr_compatibleFileTypesHandler);
					GC.KeepAlive (this);
				}
			}
		}
		/// <summary>Produces the list of compatible file types with this export session.</summary>
		/// <returns>
		///           <para class="improve-task-t-return-type-description">A task that represents the asynchronous DetermineCompatibleFileTypes operation.  The value of the TResult parameter is of type System.Action&lt;System.String[]&gt;.</para>
		///         </returns>
		/// <remarks>
		///           <para copied="true">The DetermineCompatibleFileTypesAsync method is suitable to be used with C# async by returning control to the caller with a Task representing the operation.</para>
		///         </remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<string[]> DetermineCompatibleFileTypesAsync ()
		{
			var tcs = new TaskCompletionSource<string[]> ();
			DetermineCompatibleFileTypes((obj_) => {
				tcs.SetResult (obj_!);
			});
			return tcs.Task;
		}
		[Export ("estimateMaximumDurationWithCompletionHandler:")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void EstimateMaximumDuration ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V9))]global::System.Action<global::CoreMedia.CMTime, NSError> handler)
		{
			if (handler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (handler));
			using var block_handler = Trampolines.SDActionArity2V9.CreateBlock (handler);
			BlockLiteral *block_ptr_handler = &block_handler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selEstimateMaximumDurationWithCompletionHandler_XHandle, (IntPtr) block_ptr_handler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selEstimateMaximumDurationWithCompletionHandler_XHandle, (IntPtr) block_ptr_handler);
					GC.KeepAlive (this);
				}
			}
		}
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<global::CoreMedia.CMTime> EstimateMaximumDurationAsync ()
		{
			var tcs = new TaskCompletionSource<global::CoreMedia.CMTime> ();
			EstimateMaximumDuration((arg1_, arg2_) => {
				if (arg2_ is not null)
					tcs.SetException (new NSErrorException(arg2_));
				else
					tcs.SetResult (arg1_!);
			});
			return tcs.Task;
		}
		[Export ("estimateOutputFileLengthWithCompletionHandler:")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void EstimateOutputFileLength ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V10))]global::System.Action<long, NSError> handler)
		{
			if (handler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (handler));
			using var block_handler = Trampolines.SDActionArity2V10.CreateBlock (handler);
			BlockLiteral *block_ptr_handler = &block_handler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selEstimateOutputFileLengthWithCompletionHandler_XHandle, (IntPtr) block_ptr_handler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selEstimateOutputFileLengthWithCompletionHandler_XHandle, (IntPtr) block_ptr_handler);
					GC.KeepAlive (this);
				}
			}
		}
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<long> EstimateOutputFileLengthAsync ()
		{
			var tcs = new TaskCompletionSource<long> ();
			EstimateOutputFileLength((arg1_, arg2_) => {
				if (arg2_ is not null)
					tcs.SetException (new NSErrorException(arg2_));
				else
					tcs.SetResult (arg1_!);
			});
			return tcs.Task;
		}
		[Export ("exportAsynchronouslyWithCompletionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void ExportAsynchronously ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action handler)
		{
			if (handler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (handler));
			using var block_handler = Trampolines.SDAction.CreateBlock (handler);
			BlockLiteral *block_ptr_handler = &block_handler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selExportAsynchronouslyWithCompletionHandler_XHandle, (IntPtr) block_ptr_handler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selExportAsynchronouslyWithCompletionHandler_XHandle, (IntPtr) block_ptr_handler);
					GC.KeepAlive (this);
				}
			}
		}
		/// <summary>Starts the export process.</summary>
		/// <returns>A task that represents the asynchronous ExportAsynchronously operation</returns>
		/// <remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task ExportTaskAsync ()
		{
			var tcs = new TaskCompletionSource<bool> ();
			ExportAsynchronously(() => {
				tcs.SetResult (true);
			});
			return tcs.Task;
		}
		[Export ("exportPresetsCompatibleWithAsset:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string[] ExportPresetsCompatibleWithAsset (AVAsset asset)
		{
			var asset__handle__ = asset!.GetNonNullHandle (nameof (asset));
			string[]? ret;
			ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, selExportPresetsCompatibleWithAsset_XHandle, asset__handle__), false)!;
			GC.KeepAlive (asset);
			return ret!;
		}
		[Export ("exportSessionWithAsset:presetName:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static AVAssetExportSession? FromAsset (AVAsset asset, string presetName)
		{
			var asset__handle__ = asset!.GetNonNullHandle (nameof (asset));
			if (presetName is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (presetName));
			var nspresetName = CFString.CreateNative (presetName);
			AVAssetExportSession? ret;
			ret =  Runtime.GetNSObject<AVAssetExportSession> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (class_ptr, selExportSessionWithAsset_PresetName_XHandle, asset__handle__, nspresetName), false)!;
			GC.KeepAlive (asset);
			CFString.ReleaseNative (nspresetName);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string[] AllExportPresets {
			[Export ("allExportPresets")]
			get {
				string[] ret;
				ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selAllExportPresetsXHandle), false)!;
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos14.0")]
		public virtual bool AllowsParallelizedExport {
			[Export ("allowsParallelizedExport")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selAllowsParallelizedExportXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selAllowsParallelizedExportXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setAllowsParallelizedExport:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetAllowsParallelizedExport_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetAllowsParallelizedExport_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual AVAsset Asset {
			[Export ("asset", ArgumentSemantic.Retain)]
			get {
				AVAsset? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<AVAsset> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selAssetXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<AVAsset> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selAssetXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual AVAudioMix? AudioMix {
			[Export ("audioMix", ArgumentSemantic.Copy)]
			get {
				AVAudioMix? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<AVAudioMix> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selAudioMixXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<AVAudioMix> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selAudioMixXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setAudioMix:", ArgumentSemantic.Copy)]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetAudioMix_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetAudioMix_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual NSString AudioTimePitchAlgorithm {
			[Export ("audioTimePitchAlgorithm", ArgumentSemantic.Copy)]
			get {
				NSString? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selAudioTimePitchAlgorithmXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selAudioTimePitchAlgorithmXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setAudioTimePitchAlgorithm:", ArgumentSemantic.Copy)]
			set {
				var value__handle__ = value!.GetNonNullHandle (nameof (value));
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetAudioTimePitchAlgorithm_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetAudioTimePitchAlgorithm_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		public virtual AVAssetTrackGroupOutputHandling AudioTrackGroupHandling {
			[Export ("audioTrackGroupHandling", ArgumentSemantic.Assign)]
			get {
				AVAssetTrackGroupOutputHandling ret;
				if (IsDirectBinding) {
					ret = (AVAssetTrackGroupOutputHandling) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selAudioTrackGroupHandlingXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (AVAssetTrackGroupOutputHandling) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selAudioTrackGroupHandlingXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setAudioTrackGroupHandling:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (this.Handle, selSetAudioTrackGroupHandling_XHandle, (UIntPtr) (ulong) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UIntPtr (&__objc_super__, selSetAudioTrackGroupHandling_XHandle, (UIntPtr) (ulong) value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[Advice (@"This property cannot be set after the export has started.")]
		public virtual bool CanPerformMultiplePassesOverSourceMediaData {
			[Export ("canPerformMultiplePassesOverSourceMediaData")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selCanPerformMultiplePassesOverSourceMediaDataXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selCanPerformMultiplePassesOverSourceMediaDataXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setCanPerformMultiplePassesOverSourceMediaData:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetCanPerformMultiplePassesOverSourceMediaData_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetCanPerformMultiplePassesOverSourceMediaData_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual IAVVideoCompositing? CustomVideoCompositor {
			[Export ("customVideoCompositor", ArgumentSemantic.Copy)]
			get {
				IAVVideoCompositing? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetINativeObject<IAVVideoCompositing> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selCustomVideoCompositorXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetINativeObject<IAVVideoCompositing> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selCustomVideoCompositorXHandle), false)!;
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
		[Advice (@"This property cannot be set after the export has started.")]
		public virtual NSUrl? DirectoryForTemporaryFiles {
			[Export ("directoryForTemporaryFiles", ArgumentSemantic.Copy)]
			get {
				NSUrl? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSUrl> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selDirectoryForTemporaryFilesXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSUrl> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selDirectoryForTemporaryFilesXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setDirectoryForTemporaryFiles:", ArgumentSemantic.Copy)]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetDirectoryForTemporaryFiles_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetDirectoryForTemporaryFiles_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSError? Error {
			[Export ("error")]
			get {
				NSError? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSError> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selErrorXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSError> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selErrorXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[ObsoletedOSPlatform ("ios13.0", "Use 'EstimateOutputFileLength' for more precise results.")]
		[ObsoletedOSPlatform ("tvos13.0", "Use 'EstimateOutputFileLength' for more precise results.")]
		[ObsoletedOSPlatform ("macos10.15", "Use 'EstimateOutputFileLength' for more precise results.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'EstimateOutputFileLength' for more precise results.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual long EstimatedOutputFileLength {
			[Export ("estimatedOutputFileLength")]
			get {
				long ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.Int64_objc_msgSend (this.Handle, selEstimatedOutputFileLengthXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.Int64_objc_msgSendSuper (&__objc_super__, selEstimatedOutputFileLengthXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual long FileLengthLimit {
			[Export ("fileLengthLimit")]
			get {
				long ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.Int64_objc_msgSend (this.Handle, selFileLengthLimitXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.Int64_objc_msgSendSuper (&__objc_super__, selFileLengthLimitXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setFileLengthLimit:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_Int64 (this.Handle, selSetFileLengthLimit_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_Int64 (&__objc_super__, selSetFileLengthLimit_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[ObsoletedOSPlatform ("ios13.0", "Use 'EstimateMaximumDuration' instead.")]
		[ObsoletedOSPlatform ("tvos13.0", "Use 'EstimateMaximumDuration' instead.")]
		[ObsoletedOSPlatform ("macos10.15", "Use 'EstimateMaximumDuration' instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'EstimateMaximumDuration' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual global::CoreMedia.CMTime MaxDuration {
			[Export ("maxDuration")]
			get {
				global::CoreMedia.CMTime ret;
				if (IsDirectBinding) {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						ret = global::ObjCRuntime.Messaging.CMTime_objc_msgSend (this.Handle, selMaxDurationXHandle);
					} else {
						ret = global::ObjCRuntime.Messaging.CMTime_objc_msgSend_stret (this.Handle, selMaxDurationXHandle);
					}
				} else {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.CMTime_objc_msgSendSuper (&__objc_super__, selMaxDurationXHandle);
							GC.KeepAlive (this);
						}
					} else {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.CMTime_objc_msgSendSuper_stret (&__objc_super__, selMaxDurationXHandle);
							GC.KeepAlive (this);
						}
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual AVMetadataItem[]? Metadata {
			[Export ("metadata", ArgumentSemantic.Copy)]
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
			[Export ("setMetadata:", ArgumentSemantic.Copy)]
			set {
				using var nsa_value = value is null ? null : NSArray.FromNSObjects (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetMetadata_XHandle, nsa_value.GetHandle ());
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetMetadata_XHandle, nsa_value.GetHandle ());
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual AVMetadataItemFilter? MetadataItemFilter {
			[Export ("metadataItemFilter", ArgumentSemantic.Retain)]
			get {
				AVMetadataItemFilter? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<AVMetadataItemFilter> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selMetadataItemFilterXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<AVMetadataItemFilter> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selMetadataItemFilterXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setMetadataItemFilter:", ArgumentSemantic.Retain)]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetMetadataItemFilter_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetMetadataItemFilter_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string? OutputFileType {
			[Export ("outputFileType", ArgumentSemantic.Copy)]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selOutputFileTypeXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selOutputFileTypeXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setOutputFileType:", ArgumentSemantic.Copy)]
			set {
				var nsvalue = CFString.CreateNative (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetOutputFileType_XHandle, nsvalue);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetOutputFileType_XHandle, nsvalue);
						GC.KeepAlive (this);
					}
				}
				CFString.ReleaseNative (nsvalue);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSUrl? OutputUrl {
			[Export ("outputURL", ArgumentSemantic.Copy)]
			get {
				NSUrl? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSUrl> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selOutputURLXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSUrl> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selOutputURLXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setOutputURL:", ArgumentSemantic.Copy)]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetOutputURL_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetOutputURL_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string PresetName {
			[Export ("presetName")]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selPresetNameXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selPresetNameXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual float Progress {
			[Export ("progress")]
			get {
				float ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selProgressXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.float_objc_msgSendSuper (&__objc_super__, selProgressXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldOptimizeForNetworkUse {
			[Export ("shouldOptimizeForNetworkUse")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selShouldOptimizeForNetworkUseXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selShouldOptimizeForNetworkUseXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setShouldOptimizeForNetworkUse:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetShouldOptimizeForNetworkUse_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetShouldOptimizeForNetworkUse_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual AVAssetExportSessionStatus Status {
			[Export ("status")]
			get {
				AVAssetExportSessionStatus ret;
				if (IsDirectBinding) {
					ret = (AVAssetExportSessionStatus) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selStatusXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (AVAssetExportSessionStatus) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selStatusXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string[] SupportedFileTypes {
			[Export ("supportedFileTypes")]
			get {
				string[] ret;
				if (IsDirectBinding) {
					ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selSupportedFileTypesXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selSupportedFileTypesXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::CoreMedia.CMTimeRange TimeRange {
			[Export ("timeRange", ArgumentSemantic.Assign)]
			get {
				global::CoreMedia.CMTimeRange ret;
				if (IsDirectBinding) {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						ret = global::ObjCRuntime.Messaging.CMTimeRange_objc_msgSend (this.Handle, selTimeRangeXHandle);
					} else {
						ret = global::ObjCRuntime.Messaging.CMTimeRange_objc_msgSend_stret (this.Handle, selTimeRangeXHandle);
					}
				} else {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.CMTimeRange_objc_msgSendSuper (&__objc_super__, selTimeRangeXHandle);
							GC.KeepAlive (this);
						}
					} else {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.CMTimeRange_objc_msgSendSuper_stret (&__objc_super__, selTimeRangeXHandle);
							GC.KeepAlive (this);
						}
					}
				}
				return ret!;
			}
			[Export ("setTimeRange:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_CMTimeRange (this.Handle, selSetTimeRange_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_CMTimeRange (&__objc_super__, selSetTimeRange_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual AVVideoComposition? VideoComposition {
			[Export ("videoComposition", ArgumentSemantic.Copy)]
			get {
				AVVideoComposition? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<AVVideoComposition> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selVideoCompositionXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<AVVideoComposition> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selVideoCompositionXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setVideoComposition:", ArgumentSemantic.Copy)]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetVideoComposition_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetVideoComposition_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AVAssetExportPresetMvHevc1440x1440;
		/// <summary>Represents the value associated with the constant 'AVAssetExportPresetMVHEVC1440x1440'.</summary>
		[Obsolete ("Use 'AVAssetExportSessionPreset.MvHevc1440x1440.GetConstant ()' instead.", false)]
		[EditorBrowsable (EditorBrowsableState.Never)]
		[Field ("AVAssetExportPresetMVHEVC1440x1440",  "AVFoundation")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		public static NSString AVAssetExportPresetMvHevc1440x1440 {
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos14.0")]
			[SupportedOSPlatform ("ios17.0")]
			[SupportedOSPlatform ("maccatalyst17.0")]
			get {
				if (_AVAssetExportPresetMvHevc1440x1440 is null)
					_AVAssetExportPresetMvHevc1440x1440 = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVAssetExportPresetMVHEVC1440x1440")!;
				return _AVAssetExportPresetMvHevc1440x1440;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AVAssetExportPresetMvHevc960x960;
		/// <summary>Represents the value associated with the constant 'AVAssetExportPresetMVHEVC960x960'.</summary>
		[Obsolete ("Use 'AVAssetExportSessionPreset.MvHevc960x960.GetConstant ()' instead.", false)]
		[EditorBrowsable (EditorBrowsableState.Never)]
		[Field ("AVAssetExportPresetMVHEVC960x960",  "AVFoundation")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		public static NSString AVAssetExportPresetMvHevc960x960 {
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos14.0")]
			[SupportedOSPlatform ("ios17.0")]
			[SupportedOSPlatform ("maccatalyst17.0")]
			get {
				if (_AVAssetExportPresetMvHevc960x960 is null)
					_AVAssetExportPresetMvHevc960x960 = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVAssetExportPresetMVHEVC960x960")!;
				return _AVAssetExportPresetMvHevc960x960;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Preset1280x720;
		/// <summary>Represents the value associated with the constant AVAssetExportPreset1280x720</summary>
		[Obsolete ("Use 'AVAssetExportSessionPreset.Preset1280x720.GetConstant ()' instead.", false)]
		[EditorBrowsable (EditorBrowsableState.Never)]
		[Field ("AVAssetExportPreset1280x720",  "AVFoundation")]
		public static NSString Preset1280x720 {
			get {
				if (_Preset1280x720 is null)
					_Preset1280x720 = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVAssetExportPreset1280x720")!;
				return _Preset1280x720;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Preset1920x1080;
		/// <summary>Represents the value associated with the constant AVAssetExportPreset1920x1080.</summary>
		[Obsolete ("Use 'AVAssetExportSessionPreset.Preset1920x1080.GetConstant ()' instead.", false)]
		[EditorBrowsable (EditorBrowsableState.Never)]
		[Field ("AVAssetExportPreset1920x1080",  "AVFoundation")]
		public static NSString Preset1920x1080 {
			get {
				if (_Preset1920x1080 is null)
					_Preset1920x1080 = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVAssetExportPreset1920x1080")!;
				return _Preset1920x1080;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Preset3840x2160;
		/// <summary>Represents the value associated with the constant AVAssetExportPreset3840x2160.</summary>
		[Obsolete ("Use 'AVAssetExportSessionPreset.Preset3840x2160.GetConstant ()' instead.", false)]
		[EditorBrowsable (EditorBrowsableState.Never)]
		[Field ("AVAssetExportPreset3840x2160",  "AVFoundation")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString Preset3840x2160 {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_Preset3840x2160 is null)
					_Preset3840x2160 = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVAssetExportPreset3840x2160")!;
				return _Preset3840x2160;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Preset640x480;
		/// <summary>Represents the value associated with the constant AVAssetExportPreset640x480</summary>
		[Obsolete ("Use 'AVAssetExportSessionPreset.Preset640x480.GetConstant ()' instead.", false)]
		[EditorBrowsable (EditorBrowsableState.Never)]
		[Field ("AVAssetExportPreset640x480",  "AVFoundation")]
		public static NSString Preset640x480 {
			get {
				if (_Preset640x480 is null)
					_Preset640x480 = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVAssetExportPreset640x480")!;
				return _Preset640x480;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Preset960x540;
		/// <summary>Represents the value associated with the constant AVAssetExportPreset960x540</summary>
		[Obsolete ("Use 'AVAssetExportSessionPreset.Preset960x540.GetConstant ()' instead.", false)]
		[EditorBrowsable (EditorBrowsableState.Never)]
		[Field ("AVAssetExportPreset960x540",  "AVFoundation")]
		public static NSString Preset960x540 {
			get {
				if (_Preset960x540 is null)
					_Preset960x540 = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVAssetExportPreset960x540")!;
				return _Preset960x540;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _PresetAppleM4A;
		/// <summary>Represents the value associated with the constant AVAssetExportPresetAppleM4A</summary><remarks>Audio-only, gapless playback for iTunes.</remarks>
		[Obsolete ("Use 'AVAssetExportSessionPreset.AppleM4A.GetConstant ()' instead.", false)]
		[EditorBrowsable (EditorBrowsableState.Never)]
		[Field ("AVAssetExportPresetAppleM4A",  "AVFoundation")]
		public static NSString PresetAppleM4A {
			get {
				if (_PresetAppleM4A is null)
					_PresetAppleM4A = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVAssetExportPresetAppleM4A")!;
				return _PresetAppleM4A;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _PresetAppleProRes4444Lpcm;
		/// <summary>Represents the value associated with the constant 'AVAssetExportPresetAppleProRes4444LPCM'.</summary>
		[Obsolete ("Use 'AVAssetExportSessionPreset.AppleProRes4444Lpcm.GetConstant ()' instead.", false)]
		[EditorBrowsable (EditorBrowsableState.Never)]
		[Field ("AVAssetExportPresetAppleProRes4444LPCM",  "AVFoundation")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("macos")]
		public static NSString PresetAppleProRes4444Lpcm {
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios15.0")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_PresetAppleProRes4444Lpcm is null)
					_PresetAppleProRes4444Lpcm = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVAssetExportPresetAppleProRes4444LPCM")!;
				return _PresetAppleProRes4444Lpcm;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _PresetHevc1920x1080;
		/// <summary>Represents the value associated with the constant AVAssetExportPresetHEVC1920x1080.</summary>
		[Obsolete ("Use 'AVAssetExportSessionPreset.Hevc1920x1080.GetConstant ()' instead.", false)]
		[EditorBrowsable (EditorBrowsableState.Never)]
		[Field ("AVAssetExportPresetHEVC1920x1080",  "AVFoundation")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString PresetHevc1920x1080 {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_PresetHevc1920x1080 is null)
					_PresetHevc1920x1080 = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVAssetExportPresetHEVC1920x1080")!;
				return _PresetHevc1920x1080;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _PresetHevc1920x1080WithAlpha;
		/// <summary>Represents the value associated with the constant 'AVAssetExportPresetHEVC1920x1080WithAlpha'.</summary>
		[Obsolete ("Use 'AVAssetExportSessionPreset.Hevc1920x1080WithAlpha.GetConstant ()' instead.", false)]
		[EditorBrowsable (EditorBrowsableState.Never)]
		[Field ("AVAssetExportPresetHEVC1920x1080WithAlpha",  "AVFoundation")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString PresetHevc1920x1080WithAlpha {
			[SupportedOSPlatform ("tvos13.0")]
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_PresetHevc1920x1080WithAlpha is null)
					_PresetHevc1920x1080WithAlpha = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVAssetExportPresetHEVC1920x1080WithAlpha")!;
				return _PresetHevc1920x1080WithAlpha;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _PresetHevc3840x2160;
		/// <summary>Represents the value associated with the constant AVAssetExportPresetHEVC3840x2160.</summary>
		[Obsolete ("Use 'AVAssetExportSessionPreset.Hevc3840x2160.GetConstant ()' instead.", false)]
		[EditorBrowsable (EditorBrowsableState.Never)]
		[Field ("AVAssetExportPresetHEVC3840x2160",  "AVFoundation")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString PresetHevc3840x2160 {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_PresetHevc3840x2160 is null)
					_PresetHevc3840x2160 = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVAssetExportPresetHEVC3840x2160")!;
				return _PresetHevc3840x2160;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _PresetHevc3840x2160WithAlpha;
		/// <summary>Represents the value associated with the constant 'AVAssetExportPresetHEVC3840x2160WithAlpha'.</summary>
		[Obsolete ("Use 'AVAssetExportSessionPreset.Hevc3840x2160WithAlpha.GetConstant ()' instead.", false)]
		[EditorBrowsable (EditorBrowsableState.Never)]
		[Field ("AVAssetExportPresetHEVC3840x2160WithAlpha",  "AVFoundation")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString PresetHevc3840x2160WithAlpha {
			[SupportedOSPlatform ("tvos13.0")]
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_PresetHevc3840x2160WithAlpha is null)
					_PresetHevc3840x2160WithAlpha = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVAssetExportPresetHEVC3840x2160WithAlpha")!;
				return _PresetHevc3840x2160WithAlpha;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _PresetHevc7680x4320;
		/// <summary>Represents the value associated with the constant 'AVAssetExportPresetHEVC7680x4320'.</summary>
		[Obsolete ("Use 'AVAssetExportSessionPreset.Hevc7680x4320.GetConstant ()' instead.", false)]
		[EditorBrowsable (EditorBrowsableState.Never)]
		[Field ("AVAssetExportPresetHEVC7680x4320",  "AVFoundation")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos12.1")]
		[UnsupportedOSPlatform ("maccatalyst")]
		public static NSString PresetHevc7680x4320 {
			[UnsupportedOSPlatform ("tvos")]
			[UnsupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos12.1")]
			[UnsupportedOSPlatform ("maccatalyst")]
			get {
				if (_PresetHevc7680x4320 is null)
					_PresetHevc7680x4320 = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVAssetExportPresetHEVC7680x4320")!;
				return _PresetHevc7680x4320;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _PresetHevcHighestQuality;
		/// <summary>Represents the value associated with the constant AVAssetExportPresetHEVCHighestQuality.</summary>
		[Obsolete ("Use 'AVAssetExportSessionPreset.HevcHighestQuality.GetConstant ()' instead.", false)]
		[EditorBrowsable (EditorBrowsableState.Never)]
		[Field ("AVAssetExportPresetHEVCHighestQuality",  "AVFoundation")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString PresetHevcHighestQuality {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_PresetHevcHighestQuality is null)
					_PresetHevcHighestQuality = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVAssetExportPresetHEVCHighestQuality")!;
				return _PresetHevcHighestQuality;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _PresetHevcHighestQualityWithAlpha;
		/// <summary>Represents the value associated with the constant 'AVAssetExportPresetHEVCHighestQualityWithAlpha'.</summary>
		[Obsolete ("Use 'AVAssetExportSessionPreset.HevcHighestQualityWithAlpha.GetConstant ()' instead.", false)]
		[EditorBrowsable (EditorBrowsableState.Never)]
		[Field ("AVAssetExportPresetHEVCHighestQualityWithAlpha",  "AVFoundation")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString PresetHevcHighestQualityWithAlpha {
			[SupportedOSPlatform ("tvos13.0")]
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_PresetHevcHighestQualityWithAlpha is null)
					_PresetHevcHighestQualityWithAlpha = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVAssetExportPresetHEVCHighestQualityWithAlpha")!;
				return _PresetHevcHighestQualityWithAlpha;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _PresetHighestQuality;
		/// <summary>Represents the value associated with the constant AVAssetExportPresetHighestQuality</summary><remarks>Quicktime preset: highest quality.</remarks>
		[Obsolete ("Use 'AVAssetExportSessionPreset.HighestQuality.GetConstant ()' instead.", false)]
		[EditorBrowsable (EditorBrowsableState.Never)]
		[Field ("AVAssetExportPresetHighestQuality",  "AVFoundation")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString PresetHighestQuality {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_PresetHighestQuality is null)
					_PresetHighestQuality = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVAssetExportPresetHighestQuality")!;
				return _PresetHighestQuality;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _PresetLowQuality;
		/// <summary>Represents the value associated with the constant AVAssetExportPresetLowQuality</summary><remarks>Quicktime preset: low quality.</remarks>
		[Obsolete ("Use 'AVAssetExportSessionPreset.LowQuality.GetConstant ()' instead.", false)]
		[EditorBrowsable (EditorBrowsableState.Never)]
		[Field ("AVAssetExportPresetLowQuality",  "AVFoundation")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString PresetLowQuality {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_PresetLowQuality is null)
					_PresetLowQuality = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVAssetExportPresetLowQuality")!;
				return _PresetLowQuality;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _PresetMediumQuality;
		/// <summary>Represents the value associated with the constant AVAssetExportPresetMediumQuality</summary><remarks>Quicktime preset: medium quality.</remarks>
		[Obsolete ("Use 'AVAssetExportSessionPreset.MediumQuality.GetConstant ()' instead.", false)]
		[EditorBrowsable (EditorBrowsableState.Never)]
		[Field ("AVAssetExportPresetMediumQuality",  "AVFoundation")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString PresetMediumQuality {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_PresetMediumQuality is null)
					_PresetMediumQuality = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVAssetExportPresetMediumQuality")!;
				return _PresetMediumQuality;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _PresetPassthrough;
		/// <summary>Represents the value associated with the constant AVAssetExportPresetPassthrough</summary>
		[Obsolete ("Use 'AVAssetExportSessionPreset.Passthrough.GetConstant ()' instead.", false)]
		[EditorBrowsable (EditorBrowsableState.Never)]
		[Field ("AVAssetExportPresetPassthrough",  "AVFoundation")]
		public static NSString PresetPassthrough {
			get {
				if (_PresetPassthrough is null)
					_PresetPassthrough = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVAssetExportPresetPassthrough")!;
				return _PresetPassthrough;
			}
		}
	} /* class AVAssetExportSession */
}
