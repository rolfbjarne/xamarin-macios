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
	[Register("AVAssetWriterInput", true)]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe partial class AVAssetWriterInput : NSObject {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAddTrackAssociationWithTrackOfInput_Type_X = "addTrackAssociationWithTrackOfInput:type:";
		static readonly NativeHandle selAddTrackAssociationWithTrackOfInput_Type_XHandle = Selector.GetHandle ("addTrackAssociationWithTrackOfInput:type:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAppendSampleBuffer_X = "appendSampleBuffer:";
		static readonly NativeHandle selAppendSampleBuffer_XHandle = Selector.GetHandle ("appendSampleBuffer:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAssetWriterInputWithMediaType_OutputSettings_X = "assetWriterInputWithMediaType:outputSettings:";
		static readonly NativeHandle selAssetWriterInputWithMediaType_OutputSettings_XHandle = Selector.GetHandle ("assetWriterInputWithMediaType:outputSettings:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAssetWriterInputWithMediaType_OutputSettings_SourceFormatHint_X = "assetWriterInputWithMediaType:outputSettings:sourceFormatHint:";
		static readonly NativeHandle selAssetWriterInputWithMediaType_OutputSettings_SourceFormatHint_XHandle = Selector.GetHandle ("assetWriterInputWithMediaType:outputSettings:sourceFormatHint:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCanAddTrackAssociationWithTrackOfInput_Type_X = "canAddTrackAssociationWithTrackOfInput:type:";
		static readonly NativeHandle selCanAddTrackAssociationWithTrackOfInput_Type_XHandle = Selector.GetHandle ("canAddTrackAssociationWithTrackOfInput:type:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCanPerformMultiplePassesX = "canPerformMultiplePasses";
		static readonly NativeHandle selCanPerformMultiplePassesXHandle = Selector.GetHandle ("canPerformMultiplePasses");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCurrentPassDescriptionX = "currentPassDescription";
		static readonly NativeHandle selCurrentPassDescriptionXHandle = Selector.GetHandle ("currentPassDescription");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selExpectsMediaDataInRealTimeX = "expectsMediaDataInRealTime";
		static readonly NativeHandle selExpectsMediaDataInRealTimeXHandle = Selector.GetHandle ("expectsMediaDataInRealTime");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selExtendedLanguageTagX = "extendedLanguageTag";
		static readonly NativeHandle selExtendedLanguageTagXHandle = Selector.GetHandle ("extendedLanguageTag");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithMediaType_OutputSettings_X = "initWithMediaType:outputSettings:";
		static readonly NativeHandle selInitWithMediaType_OutputSettings_XHandle = Selector.GetHandle ("initWithMediaType:outputSettings:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithMediaType_OutputSettings_SourceFormatHint_X = "initWithMediaType:outputSettings:sourceFormatHint:";
		static readonly NativeHandle selInitWithMediaType_OutputSettings_SourceFormatHint_XHandle = Selector.GetHandle ("initWithMediaType:outputSettings:sourceFormatHint:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsReadyForMoreMediaDataX = "isReadyForMoreMediaData";
		static readonly NativeHandle selIsReadyForMoreMediaDataXHandle = Selector.GetHandle ("isReadyForMoreMediaData");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLanguageCodeX = "languageCode";
		static readonly NativeHandle selLanguageCodeXHandle = Selector.GetHandle ("languageCode");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMarkAsFinishedX = "markAsFinished";
		static readonly NativeHandle selMarkAsFinishedXHandle = Selector.GetHandle ("markAsFinished");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMarkCurrentPassAsFinishedX = "markCurrentPassAsFinished";
		static readonly NativeHandle selMarkCurrentPassAsFinishedXHandle = Selector.GetHandle ("markCurrentPassAsFinished");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMarksOutputTrackAsEnabledX = "marksOutputTrackAsEnabled";
		static readonly NativeHandle selMarksOutputTrackAsEnabledXHandle = Selector.GetHandle ("marksOutputTrackAsEnabled");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMediaDataLocationX = "mediaDataLocation";
		static readonly NativeHandle selMediaDataLocationXHandle = Selector.GetHandle ("mediaDataLocation");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMediaTimeScaleX = "mediaTimeScale";
		static readonly NativeHandle selMediaTimeScaleXHandle = Selector.GetHandle ("mediaTimeScale");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMediaTypeX = "mediaType";
		static readonly NativeHandle selMediaTypeXHandle = Selector.GetHandle ("mediaType");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMetadataX = "metadata";
		static readonly NativeHandle selMetadataXHandle = Selector.GetHandle ("metadata");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selNaturalSizeX = "naturalSize";
		static readonly NativeHandle selNaturalSizeXHandle = Selector.GetHandle ("naturalSize");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selOutputSettingsX = "outputSettings";
		static readonly NativeHandle selOutputSettingsXHandle = Selector.GetHandle ("outputSettings");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPerformsMultiPassEncodingIfSupportedX = "performsMultiPassEncodingIfSupported";
		static readonly NativeHandle selPerformsMultiPassEncodingIfSupportedXHandle = Selector.GetHandle ("performsMultiPassEncodingIfSupported");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPreferredMediaChunkAlignmentX = "preferredMediaChunkAlignment";
		static readonly NativeHandle selPreferredMediaChunkAlignmentXHandle = Selector.GetHandle ("preferredMediaChunkAlignment");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPreferredMediaChunkDurationX = "preferredMediaChunkDuration";
		static readonly NativeHandle selPreferredMediaChunkDurationXHandle = Selector.GetHandle ("preferredMediaChunkDuration");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPreferredVolumeX = "preferredVolume";
		static readonly NativeHandle selPreferredVolumeXHandle = Selector.GetHandle ("preferredVolume");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRequestMediaDataWhenReadyOnQueue_UsingBlock_X = "requestMediaDataWhenReadyOnQueue:usingBlock:";
		static readonly NativeHandle selRequestMediaDataWhenReadyOnQueue_UsingBlock_XHandle = Selector.GetHandle ("requestMediaDataWhenReadyOnQueue:usingBlock:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRespondToEachPassDescriptionOnQueue_UsingBlock_X = "respondToEachPassDescriptionOnQueue:usingBlock:";
		static readonly NativeHandle selRespondToEachPassDescriptionOnQueue_UsingBlock_XHandle = Selector.GetHandle ("respondToEachPassDescriptionOnQueue:usingBlock:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSampleReferenceBaseURLX = "sampleReferenceBaseURL";
		static readonly NativeHandle selSampleReferenceBaseURLXHandle = Selector.GetHandle ("sampleReferenceBaseURL");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetExpectsMediaDataInRealTime_X = "setExpectsMediaDataInRealTime:";
		static readonly NativeHandle selSetExpectsMediaDataInRealTime_XHandle = Selector.GetHandle ("setExpectsMediaDataInRealTime:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetExtendedLanguageTag_X = "setExtendedLanguageTag:";
		static readonly NativeHandle selSetExtendedLanguageTag_XHandle = Selector.GetHandle ("setExtendedLanguageTag:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetLanguageCode_X = "setLanguageCode:";
		static readonly NativeHandle selSetLanguageCode_XHandle = Selector.GetHandle ("setLanguageCode:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetMarksOutputTrackAsEnabled_X = "setMarksOutputTrackAsEnabled:";
		static readonly NativeHandle selSetMarksOutputTrackAsEnabled_XHandle = Selector.GetHandle ("setMarksOutputTrackAsEnabled:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetMediaDataLocation_X = "setMediaDataLocation:";
		static readonly NativeHandle selSetMediaDataLocation_XHandle = Selector.GetHandle ("setMediaDataLocation:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetMediaTimeScale_X = "setMediaTimeScale:";
		static readonly NativeHandle selSetMediaTimeScale_XHandle = Selector.GetHandle ("setMediaTimeScale:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetMetadata_X = "setMetadata:";
		static readonly NativeHandle selSetMetadata_XHandle = Selector.GetHandle ("setMetadata:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetNaturalSize_X = "setNaturalSize:";
		static readonly NativeHandle selSetNaturalSize_XHandle = Selector.GetHandle ("setNaturalSize:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetPerformsMultiPassEncodingIfSupported_X = "setPerformsMultiPassEncodingIfSupported:";
		static readonly NativeHandle selSetPerformsMultiPassEncodingIfSupported_XHandle = Selector.GetHandle ("setPerformsMultiPassEncodingIfSupported:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetPreferredMediaChunkAlignment_X = "setPreferredMediaChunkAlignment:";
		static readonly NativeHandle selSetPreferredMediaChunkAlignment_XHandle = Selector.GetHandle ("setPreferredMediaChunkAlignment:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetPreferredMediaChunkDuration_X = "setPreferredMediaChunkDuration:";
		static readonly NativeHandle selSetPreferredMediaChunkDuration_XHandle = Selector.GetHandle ("setPreferredMediaChunkDuration:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetPreferredVolume_X = "setPreferredVolume:";
		static readonly NativeHandle selSetPreferredVolume_XHandle = Selector.GetHandle ("setPreferredVolume:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetSampleReferenceBaseURL_X = "setSampleReferenceBaseURL:";
		static readonly NativeHandle selSetSampleReferenceBaseURL_XHandle = Selector.GetHandle ("setSampleReferenceBaseURL:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetTransform_X = "setTransform:";
		static readonly NativeHandle selSetTransform_XHandle = Selector.GetHandle ("setTransform:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSourceFormatHintX = "sourceFormatHint";
		static readonly NativeHandle selSourceFormatHintXHandle = Selector.GetHandle ("sourceFormatHint");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTransformX = "transform";
		static readonly NativeHandle selTransformXHandle = Selector.GetHandle ("transform");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("AVAssetWriterInput");
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
		protected AVAssetWriterInput (NSObjectFlag t) : base (t)
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
		protected internal AVAssetWriterInput (NativeHandle handle) : base (handle)
		{
		}

		[Export ("initWithMediaType:outputSettings:sourceFormatHint:")]
		[DesignatedInitializer]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		protected AVAssetWriterInput (string mediaType, NSDictionary? outputSettings, global::CoreMedia.CMFormatDescription? sourceFormatHint)
			: base (NSObjectFlag.Empty)
		{
			if (mediaType is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (mediaType));
			var outputSettings__handle__ = outputSettings.GetHandle ();
			var sourceFormatHint__handle__ = sourceFormatHint.GetHandle ();
			var nsmediaType = CFString.CreateNative (mediaType);
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, selInitWithMediaType_OutputSettings_SourceFormatHint_XHandle, nsmediaType, outputSettings__handle__, sourceFormatHint__handle__), "initWithMediaType:outputSettings:sourceFormatHint:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, selInitWithMediaType_OutputSettings_SourceFormatHint_XHandle, nsmediaType, outputSettings__handle__, sourceFormatHint__handle__), "initWithMediaType:outputSettings:sourceFormatHint:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (outputSettings);
			GC.KeepAlive (sourceFormatHint);
			CFString.ReleaseNative (nsmediaType);
		}
		/// <param name="mediaType">To be added.</param><param name="outputSettings">To be added.</param><param name="sourceFormatHint">To be added.</param><summary>Creates a new <see cref="T:AVFoundation.AVAssetWriterInput" /> with the specified <paramref name="mediaType" />, <paramref name="outputSettings" />, and <paramref name="sourceFormatHint" />.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public AVAssetWriterInput (string mediaType, AudioSettings? outputSettings, global::CoreMedia.CMFormatDescription? sourceFormatHint)
			: this (mediaType, outputSettings.GetDictionary (), sourceFormatHint)
		{
		}
		/// <param name="mediaType">To be added.</param><param name="outputSettings">To be added.</param><param name="sourceFormatHint">To be added.</param><summary>Creates a new <see cref="T:AVFoundation.AVAssetWriterInput" /> with the specified <paramref name="mediaType" />, <paramref name="outputSettings" />, and <paramref name="sourceFormatHint" />.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public AVAssetWriterInput (string mediaType, AVVideoSettingsCompressed? outputSettings, global::CoreMedia.CMFormatDescription? sourceFormatHint)
			: this (mediaType, outputSettings.GetDictionary (), sourceFormatHint)
		{
		}
		[Export ("initWithMediaType:outputSettings:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		protected AVAssetWriterInput (string mediaType, NSDictionary? outputSettings)
			: base (NSObjectFlag.Empty)
		{
			if (mediaType is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (mediaType));
			var outputSettings__handle__ = outputSettings.GetHandle ();
			var nsmediaType = CFString.CreateNative (mediaType);
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selInitWithMediaType_OutputSettings_XHandle, nsmediaType, outputSettings__handle__), "initWithMediaType:outputSettings:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selInitWithMediaType_OutputSettings_XHandle, nsmediaType, outputSettings__handle__), "initWithMediaType:outputSettings:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (outputSettings);
			CFString.ReleaseNative (nsmediaType);
		}
		/// <param name="mediaType">To be added.</param><param name="outputSettings">To be added.</param><summary>Creates a new <see cref="T:AVFoundation.AVAssetWriterInput" /> with the specified <paramref name="mediaType" /> and <paramref name="outputSettings" />.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public AVAssetWriterInput (string mediaType, AudioSettings? outputSettings)
			: this (mediaType, outputSettings.GetDictionary ())
		{
		}
		/// <param name="mediaType">To be added.</param><param name="outputSettings">To be added.</param><summary>Creates a new <see cref="T:AVFoundation.AVAssetWriterInput" /> with the specified <paramref name="mediaType" /> and <paramref name="outputSettings" />.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public AVAssetWriterInput (string mediaType, AVVideoSettingsCompressed? outputSettings)
			: this (mediaType, outputSettings.GetDictionary ())
		{
		}
		[Export ("addTrackAssociationWithTrackOfInput:type:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AddTrackAssociationWithTrackOfInput (AVAssetWriterInput input, NSString trackAssociationType)
		{
			var input__handle__ = input!.GetNonNullHandle (nameof (input));
			var trackAssociationType__handle__ = trackAssociationType!.GetNonNullHandle (nameof (trackAssociationType));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selAddTrackAssociationWithTrackOfInput_Type_XHandle, input__handle__, trackAssociationType__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selAddTrackAssociationWithTrackOfInput_Type_XHandle, input__handle__, trackAssociationType__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (input);
			GC.KeepAlive (trackAssociationType);
		}
		[Export ("appendSampleBuffer:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool AppendSampleBuffer (global::CoreMedia.CMSampleBuffer sampleBuffer)
		{
			var sampleBuffer__handle__ = sampleBuffer!.GetNonNullHandle (nameof (sampleBuffer));
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (this.Handle, selAppendSampleBuffer_XHandle, sampleBuffer.Handle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle (&__objc_super__, selAppendSampleBuffer_XHandle, sampleBuffer.Handle);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (sampleBuffer);
			return ret != 0;
		}
		[Export ("canAddTrackAssociationWithTrackOfInput:type:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool CanAddTrackAssociationWithTrackOfInput (AVAssetWriterInput input, NSString trackAssociationType)
		{
			var input__handle__ = input!.GetNonNullHandle (nameof (input));
			var trackAssociationType__handle__ = trackAssociationType!.GetNonNullHandle (nameof (trackAssociationType));
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selCanAddTrackAssociationWithTrackOfInput_Type_XHandle, input__handle__, trackAssociationType__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selCanAddTrackAssociationWithTrackOfInput_Type_XHandle, input__handle__, trackAssociationType__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (input);
			GC.KeepAlive (trackAssociationType);
			return ret != 0;
		}
		[Export ("assetWriterInputWithMediaType:outputSettings:sourceFormatHint:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static AVAssetWriterInput Create (string mediaType, NSDictionary? outputSettings, global::CoreMedia.CMFormatDescription? sourceFormatHint)
		{
			if (mediaType is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (mediaType));
			var outputSettings__handle__ = outputSettings.GetHandle ();
			var sourceFormatHint__handle__ = sourceFormatHint.GetHandle ();
			var nsmediaType = CFString.CreateNative (mediaType);
			AVAssetWriterInput? ret;
			ret =  Runtime.GetNSObject<AVAssetWriterInput> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (class_ptr, selAssetWriterInputWithMediaType_OutputSettings_SourceFormatHint_XHandle, nsmediaType, outputSettings__handle__, sourceFormatHint__handle__), false)!;
			GC.KeepAlive (outputSettings);
			GC.KeepAlive (sourceFormatHint);
			CFString.ReleaseNative (nsmediaType);
			return ret!;
		}
		/// <param name="mediaType">To be added.</param><param name="outputSettings">To be added.</param><param name="sourceFormatHint">To be added.</param><summary>Static factory method to create a new <see cref="T:AVFoundation.AVAssetWriterInput" /> with the specified <paramref name="mediaType" />, <paramref name="outputSettings" />, and <paramref name="sourceFormatHint" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static AVAssetWriterInput Create (string mediaType, AudioSettings? outputSettings, global::CoreMedia.CMFormatDescription? sourceFormatHint)
		{
			return Create(mediaType, outputSettings.GetDictionary (), sourceFormatHint);
		}
		/// <param name="mediaType">To be added.</param><param name="outputSettings">To be added.</param><param name="sourceFormatHint">To be added.</param><summary>Static factory method to create a new <see cref="T:AVFoundation.AVAssetWriterInput" /> with the specified <paramref name="mediaType" />, <paramref name="outputSettings" />, and <paramref name="sourceFormatHint" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static AVAssetWriterInput Create (string mediaType, AVVideoSettingsCompressed? outputSettings, global::CoreMedia.CMFormatDescription? sourceFormatHint)
		{
			return Create(mediaType, outputSettings.GetDictionary (), sourceFormatHint);
		}
		/// <param name="mediaType">To be added.</param><param name="outputSettings"><para>The dictionary should contain configuration
		/// 	  information using keys from the <see cref="T:AVFoundation.AVAudioSettings" /> and <see cref="T:AVFoundation.AVVideo" />.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>Static factory method to create a new <see cref="T:AVFoundation.AVAssetWriterInput" /> with the specified <paramref name="mediaType" /> and <paramref name="outputSettings" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static AVAssetWriterInput Create (string mediaType, AudioSettings? outputSettings)
		{
			return FromType (mediaType, outputSettings.GetDictionary ());
		}
		/// <param name="mediaType">To be added.</param><param name="outputSettings">To be added.</param><summary>Static factory method to create a new <see cref="T:AVFoundation.AVAssetWriterInput" /> with the specified <paramref name="mediaType" /> and <paramref name="outputSettings" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static AVAssetWriterInput Create (string mediaType, AVVideoSettingsCompressed? outputSettings)
		{
			return FromType (mediaType, outputSettings.GetDictionary ());
		}
		[Export ("assetWriterInputWithMediaType:outputSettings:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Advice (@"Use constructor or 'Create' method instead.")]
		internal static AVAssetWriterInput FromType (string mediaType, NSDictionary? outputSettings)
		{
			if (mediaType is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (mediaType));
			var outputSettings__handle__ = outputSettings.GetHandle ();
			var nsmediaType = CFString.CreateNative (mediaType);
			AVAssetWriterInput? ret;
			ret =  Runtime.GetNSObject<AVAssetWriterInput> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (class_ptr, selAssetWriterInputWithMediaType_OutputSettings_XHandle, nsmediaType, outputSettings__handle__), false)!;
			GC.KeepAlive (outputSettings);
			CFString.ReleaseNative (nsmediaType);
			return ret!;
		}
		[Export ("markAsFinished")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void MarkAsFinished ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selMarkAsFinishedXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selMarkAsFinishedXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("markCurrentPassAsFinished")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void MarkCurrentPassAsFinished ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selMarkCurrentPassAsFinishedXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selMarkCurrentPassAsFinishedXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("requestMediaDataWhenReadyOnQueue:usingBlock:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void RequestMediaData (global::CoreFoundation.DispatchQueue queue, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action action)
		{
			var queue__handle__ = queue!.GetNonNullHandle (nameof (queue));
			if (action is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (action));
			using var block_action = Trampolines.SDAction.CreateBlock (action);
			BlockLiteral *block_ptr_action = &block_action;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selRequestMediaDataWhenReadyOnQueue_UsingBlock_XHandle, queue.Handle, (IntPtr) block_ptr_action);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selRequestMediaDataWhenReadyOnQueue_UsingBlock_XHandle, queue.Handle, (IntPtr) block_ptr_action);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (queue);
		}
		[Export ("respondToEachPassDescriptionOnQueue:usingBlock:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void SetPassHandler (global::CoreFoundation.DispatchQueue queue, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action passHandler)
		{
			var queue__handle__ = queue!.GetNonNullHandle (nameof (queue));
			if (passHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (passHandler));
			using var block_passHandler = Trampolines.SDAction.CreateBlock (passHandler);
			BlockLiteral *block_ptr_passHandler = &block_passHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selRespondToEachPassDescriptionOnQueue_UsingBlock_XHandle, queue.Handle, (IntPtr) block_ptr_passHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selRespondToEachPassDescriptionOnQueue_UsingBlock_XHandle, queue.Handle, (IntPtr) block_ptr_passHandler);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (queue);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual bool CanPerformMultiplePasses {
			[Export ("canPerformMultiplePasses")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selCanPerformMultiplePassesXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selCanPerformMultiplePassesXHandle);
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
		public virtual AVAssetWriterInputPassDescription? CurrentPassDescription {
			[Export ("currentPassDescription")]
			get {
				AVAssetWriterInputPassDescription? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<AVAssetWriterInputPassDescription> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selCurrentPassDescriptionXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<AVAssetWriterInputPassDescription> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selCurrentPassDescriptionXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ExpectsMediaDataInRealTime {
			[Export ("expectsMediaDataInRealTime")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selExpectsMediaDataInRealTimeXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selExpectsMediaDataInRealTimeXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setExpectsMediaDataInRealTime:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetExpectsMediaDataInRealTime_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetExpectsMediaDataInRealTime_XHandle, value ? (byte) 1 : (byte) 0);
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
		public virtual string? ExtendedLanguageTag {
			[Export ("extendedLanguageTag", ArgumentSemantic.Copy)]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selExtendedLanguageTagXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selExtendedLanguageTagXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setExtendedLanguageTag:", ArgumentSemantic.Copy)]
			set {
				var nsvalue = CFString.CreateNative (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetExtendedLanguageTag_XHandle, nsvalue);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetExtendedLanguageTag_XHandle, nsvalue);
						GC.KeepAlive (this);
					}
				}
				CFString.ReleaseNative (nsvalue);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual string? LanguageCode {
			[Export ("languageCode", ArgumentSemantic.Copy)]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selLanguageCodeXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selLanguageCodeXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setLanguageCode:", ArgumentSemantic.Copy)]
			set {
				var nsvalue = CFString.CreateNative (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetLanguageCode_XHandle, nsvalue);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetLanguageCode_XHandle, nsvalue);
						GC.KeepAlive (this);
					}
				}
				CFString.ReleaseNative (nsvalue);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual bool MarksOutputTrackAsEnabled {
			[Export ("marksOutputTrackAsEnabled")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selMarksOutputTrackAsEnabledXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selMarksOutputTrackAsEnabledXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setMarksOutputTrackAsEnabled:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetMarksOutputTrackAsEnabled_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetMarksOutputTrackAsEnabled_XHandle, value ? (byte) 1 : (byte) 0);
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
		public virtual string MediaDataLocation {
			[Export ("mediaDataLocation")]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selMediaDataLocationXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selMediaDataLocationXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setMediaDataLocation:")]
			set {
				if (value is null)
					ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (value));
				var nsvalue = CFString.CreateNative (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetMediaDataLocation_XHandle, nsvalue);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetMediaDataLocation_XHandle, nsvalue);
						GC.KeepAlive (this);
					}
				}
				CFString.ReleaseNative (nsvalue);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual int MediaTimeScale {
			[Export ("mediaTimeScale")]
			get {
				int ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.int_objc_msgSend (this.Handle, selMediaTimeScaleXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.int_objc_msgSendSuper (&__objc_super__, selMediaTimeScaleXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setMediaTimeScale:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_int (this.Handle, selSetMediaTimeScale_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_int (&__objc_super__, selSetMediaTimeScale_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string MediaType {
			[Export ("mediaType")]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selMediaTypeXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selMediaTypeXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual AVMetadataItem[] Metadata {
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
				if (value is null)
					ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (value));
				using var nsa_value = NSArray.FromNSObjects (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetMetadata_XHandle, nsa_value.Handle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetMetadata_XHandle, nsa_value.Handle);
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
			[Export ("setNaturalSize:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_CGSize (this.Handle, selSetNaturalSize_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_CGSize (&__objc_super__, selSetNaturalSize_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDictionary? OutputSettings {
			[Export ("outputSettings")]
			get {
				NSDictionary? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDictionary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selOutputSettingsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSDictionary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selOutputSettingsXHandle), false)!;
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
		public virtual bool PerformsMultiPassEncodingIfSupported {
			[Export ("performsMultiPassEncodingIfSupported")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selPerformsMultiPassEncodingIfSupportedXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selPerformsMultiPassEncodingIfSupportedXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setPerformsMultiPassEncodingIfSupported:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetPerformsMultiPassEncodingIfSupported_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetPerformsMultiPassEncodingIfSupported_XHandle, value ? (byte) 1 : (byte) 0);
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
		public virtual nint PreferredMediaChunkAlignment {
			[Export ("preferredMediaChunkAlignment")]
			get {
				nint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selPreferredMediaChunkAlignmentXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selPreferredMediaChunkAlignmentXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setPreferredMediaChunkAlignment:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetPreferredMediaChunkAlignment_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, selSetPreferredMediaChunkAlignment_XHandle, value);
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
		public virtual global::CoreMedia.CMTime PreferredMediaChunkDuration {
			[Export ("preferredMediaChunkDuration")]
			get {
				global::CoreMedia.CMTime ret;
				if (IsDirectBinding) {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						ret = global::ObjCRuntime.Messaging.CMTime_objc_msgSend (this.Handle, selPreferredMediaChunkDurationXHandle);
					} else {
						ret = global::ObjCRuntime.Messaging.CMTime_objc_msgSend_stret (this.Handle, selPreferredMediaChunkDurationXHandle);
					}
				} else {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.CMTime_objc_msgSendSuper (&__objc_super__, selPreferredMediaChunkDurationXHandle);
							GC.KeepAlive (this);
						}
					} else {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.CMTime_objc_msgSendSuper_stret (&__objc_super__, selPreferredMediaChunkDurationXHandle);
							GC.KeepAlive (this);
						}
					}
				}
				return ret!;
			}
			[Export ("setPreferredMediaChunkDuration:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_CMTime (this.Handle, selSetPreferredMediaChunkDuration_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_CMTime (&__objc_super__, selSetPreferredMediaChunkDuration_XHandle, value);
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
			[Export ("setPreferredVolume:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, selSetPreferredVolume_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_float (&__objc_super__, selSetPreferredVolume_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>Whether this writer is ready for more samples to be appended.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ReadyForMoreMediaData {
			[Export ("isReadyForMoreMediaData")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsReadyForMoreMediaDataXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsReadyForMoreMediaDataXHandle);
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
		public virtual NSUrl? SampleReferenceBaseUrl {
			[Export ("sampleReferenceBaseURL", ArgumentSemantic.Copy)]
			get {
				NSUrl? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSUrl> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selSampleReferenceBaseURLXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSUrl> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selSampleReferenceBaseURLXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setSampleReferenceBaseURL:", ArgumentSemantic.Copy)]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetSampleReferenceBaseURL_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetSampleReferenceBaseURL_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::CoreMedia.CMFormatDescription? SourceFormatHint {
			[Export ("sourceFormatHint")]
			get {
				global::CoreMedia.CMFormatDescription ret;
				if (IsDirectBinding) {
					ret = CMFormatDescription.Create (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selSourceFormatHintXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CMFormatDescription.Create (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selSourceFormatHintXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGAffineTransform Transform {
			[Export ("transform", ArgumentSemantic.Assign)]
			get {
				CGAffineTransform ret;
				if (IsDirectBinding) {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						ret = global::ObjCRuntime.Messaging.CGAffineTransform_objc_msgSend (this.Handle, selTransformXHandle);
					} else {
						ret = global::ObjCRuntime.Messaging.CGAffineTransform_objc_msgSend_stret (this.Handle, selTransformXHandle);
					}
				} else {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.CGAffineTransform_objc_msgSendSuper (&__objc_super__, selTransformXHandle);
							GC.KeepAlive (this);
						}
					} else {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.CGAffineTransform_objc_msgSendSuper_stret (&__objc_super__, selTransformXHandle);
							GC.KeepAlive (this);
						}
					}
				}
				return ret!;
			}
			[Export ("setTransform:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_CGAffineTransform (this.Handle, selSetTransform_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_CGAffineTransform (&__objc_super__, selSetTransform_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
	} /* class AVAssetWriterInput */
}
