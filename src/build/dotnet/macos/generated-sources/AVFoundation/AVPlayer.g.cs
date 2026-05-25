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
	[Register("AVPlayer", true)]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe partial class AVPlayer : NSObject {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selActionAtItemEndX = "actionAtItemEnd";
		static readonly NativeHandle selActionAtItemEndXHandle = Selector.GetHandle ("actionAtItemEnd");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAddBoundaryTimeObserverForTimes_Queue_UsingBlock_X = "addBoundaryTimeObserverForTimes:queue:usingBlock:";
		static readonly NativeHandle selAddBoundaryTimeObserverForTimes_Queue_UsingBlock_XHandle = Selector.GetHandle ("addBoundaryTimeObserverForTimes:queue:usingBlock:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAddPeriodicTimeObserverForInterval_Queue_UsingBlock_X = "addPeriodicTimeObserverForInterval:queue:usingBlock:";
		static readonly NativeHandle selAddPeriodicTimeObserverForInterval_Queue_UsingBlock_XHandle = Selector.GetHandle ("addPeriodicTimeObserverForInterval:queue:usingBlock:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAllowsCaptureOfClearKeyVideoX = "allowsCaptureOfClearKeyVideo";
		static readonly NativeHandle selAllowsCaptureOfClearKeyVideoXHandle = Selector.GetHandle ("allowsCaptureOfClearKeyVideo");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAllowsExternalPlaybackX = "allowsExternalPlayback";
		static readonly NativeHandle selAllowsExternalPlaybackXHandle = Selector.GetHandle ("allowsExternalPlayback");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAppliesMediaSelectionCriteriaAutomaticallyX = "appliesMediaSelectionCriteriaAutomatically";
		static readonly NativeHandle selAppliesMediaSelectionCriteriaAutomaticallyXHandle = Selector.GetHandle ("appliesMediaSelectionCriteriaAutomatically");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAudioOutputDeviceUniqueIDX = "audioOutputDeviceUniqueID";
		static readonly NativeHandle selAudioOutputDeviceUniqueIDXHandle = Selector.GetHandle ("audioOutputDeviceUniqueID");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAudiovisualBackgroundPlaybackPolicyX = "audiovisualBackgroundPlaybackPolicy";
		static readonly NativeHandle selAudiovisualBackgroundPlaybackPolicyXHandle = Selector.GetHandle ("audiovisualBackgroundPlaybackPolicy");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAutomaticallyWaitsToMinimizeStallingX = "automaticallyWaitsToMinimizeStalling";
		static readonly NativeHandle selAutomaticallyWaitsToMinimizeStallingXHandle = Selector.GetHandle ("automaticallyWaitsToMinimizeStalling");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCancelPendingPrerollsX = "cancelPendingPrerolls";
		static readonly NativeHandle selCancelPendingPrerollsXHandle = Selector.GetHandle ("cancelPendingPrerolls");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCurrentItemX = "currentItem";
		static readonly NativeHandle selCurrentItemXHandle = Selector.GetHandle ("currentItem");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCurrentTimeX = "currentTime";
		static readonly NativeHandle selCurrentTimeXHandle = Selector.GetHandle ("currentTime");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDefaultRateX = "defaultRate";
		static readonly NativeHandle selDefaultRateXHandle = Selector.GetHandle ("defaultRate");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selEligibleForHDRPlaybackX = "eligibleForHDRPlayback";
		static readonly NativeHandle selEligibleForHDRPlaybackXHandle = Selector.GetHandle ("eligibleForHDRPlayback");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selErrorX = "error";
		static readonly NativeHandle selErrorXHandle = Selector.GetHandle ("error");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selExternalPlaybackVideoGravityX = "externalPlaybackVideoGravity";
		static readonly NativeHandle selExternalPlaybackVideoGravityXHandle = Selector.GetHandle ("externalPlaybackVideoGravity");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithPlayerItem_X = "initWithPlayerItem:";
		static readonly NativeHandle selInitWithPlayerItem_XHandle = Selector.GetHandle ("initWithPlayerItem:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithURL_X = "initWithURL:";
		static readonly NativeHandle selInitWithURL_XHandle = Selector.GetHandle ("initWithURL:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsClosedCaptionDisplayEnabledX = "isClosedCaptionDisplayEnabled";
		static readonly NativeHandle selIsClosedCaptionDisplayEnabledXHandle = Selector.GetHandle ("isClosedCaptionDisplayEnabled");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsExternalPlaybackActiveX = "isExternalPlaybackActive";
		static readonly NativeHandle selIsExternalPlaybackActiveXHandle = Selector.GetHandle ("isExternalPlaybackActive");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsMutedX = "isMuted";
		static readonly NativeHandle selIsMutedXHandle = Selector.GetHandle ("isMuted");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsObservationEnabledX = "isObservationEnabled";
		static readonly NativeHandle selIsObservationEnabledXHandle = Selector.GetHandle ("isObservationEnabled");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMasterClockX = "masterClock";
		static readonly NativeHandle selMasterClockXHandle = Selector.GetHandle ("masterClock");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMediaSelectionCriteriaForMediaCharacteristic_X = "mediaSelectionCriteriaForMediaCharacteristic:";
		static readonly NativeHandle selMediaSelectionCriteriaForMediaCharacteristic_XHandle = Selector.GetHandle ("mediaSelectionCriteriaForMediaCharacteristic:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selNetworkResourcePriorityX = "networkResourcePriority";
		static readonly NativeHandle selNetworkResourcePriorityXHandle = Selector.GetHandle ("networkResourcePriority");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selOutputObscuredDueToInsufficientExternalProtectionX = "outputObscuredDueToInsufficientExternalProtection";
		static readonly NativeHandle selOutputObscuredDueToInsufficientExternalProtectionXHandle = Selector.GetHandle ("outputObscuredDueToInsufficientExternalProtection");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPauseX = "pause";
		static readonly NativeHandle selPauseXHandle = Selector.GetHandle ("pause");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPlayX = "play";
		static readonly NativeHandle selPlayXHandle = Selector.GetHandle ("play");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPlayImmediatelyAtRate_X = "playImmediatelyAtRate:";
		static readonly NativeHandle selPlayImmediatelyAtRate_XHandle = Selector.GetHandle ("playImmediatelyAtRate:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPlaybackCoordinatorX = "playbackCoordinator";
		static readonly NativeHandle selPlaybackCoordinatorXHandle = Selector.GetHandle ("playbackCoordinator");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPlayerWithPlayerItem_X = "playerWithPlayerItem:";
		static readonly NativeHandle selPlayerWithPlayerItem_XHandle = Selector.GetHandle ("playerWithPlayerItem:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPlayerWithURL_X = "playerWithURL:";
		static readonly NativeHandle selPlayerWithURL_XHandle = Selector.GetHandle ("playerWithURL:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPreferredVideoDecoderGPURegistryIDX = "preferredVideoDecoderGPURegistryID";
		static readonly NativeHandle selPreferredVideoDecoderGPURegistryIDXHandle = Selector.GetHandle ("preferredVideoDecoderGPURegistryID");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPrerollAtRate_CompletionHandler_X = "prerollAtRate:completionHandler:";
		static readonly NativeHandle selPrerollAtRate_CompletionHandler_XHandle = Selector.GetHandle ("prerollAtRate:completionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPreventsDisplaySleepDuringVideoPlaybackX = "preventsDisplaySleepDuringVideoPlayback";
		static readonly NativeHandle selPreventsDisplaySleepDuringVideoPlaybackXHandle = Selector.GetHandle ("preventsDisplaySleepDuringVideoPlayback");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRateX = "rate";
		static readonly NativeHandle selRateXHandle = Selector.GetHandle ("rate");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selReasonForWaitingToPlayX = "reasonForWaitingToPlay";
		static readonly NativeHandle selReasonForWaitingToPlayXHandle = Selector.GetHandle ("reasonForWaitingToPlay");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRemoveTimeObserver_X = "removeTimeObserver:";
		static readonly NativeHandle selRemoveTimeObserver_XHandle = Selector.GetHandle ("removeTimeObserver:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selReplaceCurrentItemWithPlayerItem_X = "replaceCurrentItemWithPlayerItem:";
		static readonly NativeHandle selReplaceCurrentItemWithPlayerItem_XHandle = Selector.GetHandle ("replaceCurrentItemWithPlayerItem:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSeekToDate_X = "seekToDate:";
		static readonly NativeHandle selSeekToDate_XHandle = Selector.GetHandle ("seekToDate:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSeekToDate_CompletionHandler_X = "seekToDate:completionHandler:";
		static readonly NativeHandle selSeekToDate_CompletionHandler_XHandle = Selector.GetHandle ("seekToDate:completionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSeekToTime_X = "seekToTime:";
		static readonly NativeHandle selSeekToTime_XHandle = Selector.GetHandle ("seekToTime:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSeekToTime_CompletionHandler_X = "seekToTime:completionHandler:";
		static readonly NativeHandle selSeekToTime_CompletionHandler_XHandle = Selector.GetHandle ("seekToTime:completionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSeekToTime_ToleranceBefore_ToleranceAfter_X = "seekToTime:toleranceBefore:toleranceAfter:";
		static readonly NativeHandle selSeekToTime_ToleranceBefore_ToleranceAfter_XHandle = Selector.GetHandle ("seekToTime:toleranceBefore:toleranceAfter:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSeekToTime_ToleranceBefore_ToleranceAfter_CompletionHandler_X = "seekToTime:toleranceBefore:toleranceAfter:completionHandler:";
		static readonly NativeHandle selSeekToTime_ToleranceBefore_ToleranceAfter_CompletionHandler_XHandle = Selector.GetHandle ("seekToTime:toleranceBefore:toleranceAfter:completionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetActionAtItemEnd_X = "setActionAtItemEnd:";
		static readonly NativeHandle selSetActionAtItemEnd_XHandle = Selector.GetHandle ("setActionAtItemEnd:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAllowsCaptureOfClearKeyVideo_X = "setAllowsCaptureOfClearKeyVideo:";
		static readonly NativeHandle selSetAllowsCaptureOfClearKeyVideo_XHandle = Selector.GetHandle ("setAllowsCaptureOfClearKeyVideo:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAllowsExternalPlayback_X = "setAllowsExternalPlayback:";
		static readonly NativeHandle selSetAllowsExternalPlayback_XHandle = Selector.GetHandle ("setAllowsExternalPlayback:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAppliesMediaSelectionCriteriaAutomatically_X = "setAppliesMediaSelectionCriteriaAutomatically:";
		static readonly NativeHandle selSetAppliesMediaSelectionCriteriaAutomatically_XHandle = Selector.GetHandle ("setAppliesMediaSelectionCriteriaAutomatically:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAudioOutputDeviceUniqueID_X = "setAudioOutputDeviceUniqueID:";
		static readonly NativeHandle selSetAudioOutputDeviceUniqueID_XHandle = Selector.GetHandle ("setAudioOutputDeviceUniqueID:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAudiovisualBackgroundPlaybackPolicy_X = "setAudiovisualBackgroundPlaybackPolicy:";
		static readonly NativeHandle selSetAudiovisualBackgroundPlaybackPolicy_XHandle = Selector.GetHandle ("setAudiovisualBackgroundPlaybackPolicy:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAutomaticallyWaitsToMinimizeStalling_X = "setAutomaticallyWaitsToMinimizeStalling:";
		static readonly NativeHandle selSetAutomaticallyWaitsToMinimizeStalling_XHandle = Selector.GetHandle ("setAutomaticallyWaitsToMinimizeStalling:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetClosedCaptionDisplayEnabled_X = "setClosedCaptionDisplayEnabled:";
		static readonly NativeHandle selSetClosedCaptionDisplayEnabled_XHandle = Selector.GetHandle ("setClosedCaptionDisplayEnabled:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetDefaultRate_X = "setDefaultRate:";
		static readonly NativeHandle selSetDefaultRate_XHandle = Selector.GetHandle ("setDefaultRate:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetExternalPlaybackVideoGravity_X = "setExternalPlaybackVideoGravity:";
		static readonly NativeHandle selSetExternalPlaybackVideoGravity_XHandle = Selector.GetHandle ("setExternalPlaybackVideoGravity:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetMasterClock_X = "setMasterClock:";
		static readonly NativeHandle selSetMasterClock_XHandle = Selector.GetHandle ("setMasterClock:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetMediaSelectionCriteria_ForMediaCharacteristic_X = "setMediaSelectionCriteria:forMediaCharacteristic:";
		static readonly NativeHandle selSetMediaSelectionCriteria_ForMediaCharacteristic_XHandle = Selector.GetHandle ("setMediaSelectionCriteria:forMediaCharacteristic:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetMuted_X = "setMuted:";
		static readonly NativeHandle selSetMuted_XHandle = Selector.GetHandle ("setMuted:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetNetworkResourcePriority_X = "setNetworkResourcePriority:";
		static readonly NativeHandle selSetNetworkResourcePriority_XHandle = Selector.GetHandle ("setNetworkResourcePriority:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetObservationEnabled_X = "setObservationEnabled:";
		static readonly NativeHandle selSetObservationEnabled_XHandle = Selector.GetHandle ("setObservationEnabled:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetPreferredVideoDecoderGPURegistryID_X = "setPreferredVideoDecoderGPURegistryID:";
		static readonly NativeHandle selSetPreferredVideoDecoderGPURegistryID_XHandle = Selector.GetHandle ("setPreferredVideoDecoderGPURegistryID:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetPreventsDisplaySleepDuringVideoPlayback_X = "setPreventsDisplaySleepDuringVideoPlayback:";
		static readonly NativeHandle selSetPreventsDisplaySleepDuringVideoPlayback_XHandle = Selector.GetHandle ("setPreventsDisplaySleepDuringVideoPlayback:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetRate_X = "setRate:";
		static readonly NativeHandle selSetRate_XHandle = Selector.GetHandle ("setRate:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetRate_Time_AtHostTime_X = "setRate:time:atHostTime:";
		static readonly NativeHandle selSetRate_Time_AtHostTime_XHandle = Selector.GetHandle ("setRate:time:atHostTime:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetSourceClock_X = "setSourceClock:";
		static readonly NativeHandle selSetSourceClock_XHandle = Selector.GetHandle ("setSourceClock:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetVideoOutput_X = "setVideoOutput:";
		static readonly NativeHandle selSetVideoOutput_XHandle = Selector.GetHandle ("setVideoOutput:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetVolume_X = "setVolume:";
		static readonly NativeHandle selSetVolume_XHandle = Selector.GetHandle ("setVolume:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSourceClockX = "sourceClock";
		static readonly NativeHandle selSourceClockXHandle = Selector.GetHandle ("sourceClock");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selStatusX = "status";
		static readonly NativeHandle selStatusXHandle = Selector.GetHandle ("status");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTimeControlStatusX = "timeControlStatus";
		static readonly NativeHandle selTimeControlStatusXHandle = Selector.GetHandle ("timeControlStatus");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selVideoOutputX = "videoOutput";
		static readonly NativeHandle selVideoOutputXHandle = Selector.GetHandle ("videoOutput");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selVolumeX = "volume";
		static readonly NativeHandle selVolumeXHandle = Selector.GetHandle ("volume");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("AVPlayer");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		/// <summary>Creates a new <see cref="AVPlayer" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public AVPlayer () : base (NSObjectFlag.Empty)
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
		protected AVPlayer (NSObjectFlag t) : base (t)
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
		protected internal AVPlayer (NativeHandle handle) : base (handle)
		{
		}

		[Export ("initWithURL:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public AVPlayer (NSUrl URL)
			: base (NSObjectFlag.Empty)
		{
			var URL__handle__ = URL!.GetNonNullHandle (nameof (URL));
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selInitWithURL_XHandle, URL__handle__), "initWithURL:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selInitWithURL_XHandle, URL__handle__), "initWithURL:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (URL);
		}
		[Export ("initWithPlayerItem:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public AVPlayer (AVPlayerItem? item)
			: base (NSObjectFlag.Empty)
		{
			var item__handle__ = item.GetHandle ();
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selInitWithPlayerItem_XHandle, item__handle__), "initWithPlayerItem:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selInitWithPlayerItem_XHandle, item__handle__), "initWithPlayerItem:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (item);
		}
		[Export ("addBoundaryTimeObserverForTimes:queue:usingBlock:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual NSObject AddBoundaryTimeObserver (NSValue[] times, global::CoreFoundation.DispatchQueue? queue, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action handler)
		{
			if (times is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (times));
			var queue__handle__ = queue.GetHandle ();
			if (handler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (handler));
			using var nsa_times = NSArray.FromNSObjects (times);
			using var block_handler = Trampolines.SDAction.CreateBlock (handler);
			BlockLiteral *block_ptr_handler = &block_handler;
			NSObject? ret;
			if (IsDirectBinding) {
				ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, selAddBoundaryTimeObserverForTimes_Queue_UsingBlock_XHandle, nsa_times.Handle, queue__handle__, (IntPtr) block_ptr_handler), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, selAddBoundaryTimeObserverForTimes_Queue_UsingBlock_XHandle, nsa_times.Handle, queue__handle__, (IntPtr) block_ptr_handler), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (queue);
			return ret!;
		}
		[Export ("addPeriodicTimeObserverForInterval:queue:usingBlock:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual NSObject AddPeriodicTimeObserver (global::CoreMedia.CMTime interval, global::CoreFoundation.DispatchQueue? queue, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V9))]global::System.Action<global::CoreMedia.CMTime> handler)
		{
			var queue__handle__ = queue.GetHandle ();
			if (handler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (handler));
			using var block_handler = Trampolines.SDActionArity1V9.CreateBlock (handler);
			BlockLiteral *block_ptr_handler = &block_handler;
			NSObject? ret;
			if (IsDirectBinding) {
				ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_CMTime_NativeHandle_NativeHandle (this.Handle, selAddPeriodicTimeObserverForInterval_Queue_UsingBlock_XHandle, interval, queue__handle__, (IntPtr) block_ptr_handler), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_CMTime_NativeHandle_NativeHandle (&__objc_super__, selAddPeriodicTimeObserverForInterval_Queue_UsingBlock_XHandle, interval, queue__handle__, (IntPtr) block_ptr_handler), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (queue);
			return ret!;
		}
		[Export ("cancelPendingPrerolls")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void CancelPendingPrerolls ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selCancelPendingPrerollsXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selCancelPendingPrerollsXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("playerWithPlayerItem:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static AVPlayer FromPlayerItem (AVPlayerItem? item)
		{
			var item__handle__ = item.GetHandle ();
			AVPlayer? ret;
			ret =  Runtime.GetNSObject<AVPlayer> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, selPlayerWithPlayerItem_XHandle, item__handle__), false)!;
			GC.KeepAlive (item);
			return ret!;
		}
		[Export ("playerWithURL:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static AVPlayer FromUrl (NSUrl URL)
		{
			var URL__handle__ = URL!.GetNonNullHandle (nameof (URL));
			AVPlayer? ret;
			ret =  Runtime.GetNSObject<AVPlayer> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, selPlayerWithURL_XHandle, URL__handle__), false)!;
			GC.KeepAlive (URL);
			return ret!;
		}
		[Export ("mediaSelectionCriteriaForMediaCharacteristic:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual AVPlayerMediaSelectionCriteria? MediaSelectionCriteriaForMediaCharacteristic (NSString avMediaCharacteristic)
		{
			var avMediaCharacteristic__handle__ = avMediaCharacteristic!.GetNonNullHandle (nameof (avMediaCharacteristic));
			AVPlayerMediaSelectionCriteria? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<AVPlayerMediaSelectionCriteria> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selMediaSelectionCriteriaForMediaCharacteristic_XHandle, avMediaCharacteristic__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<AVPlayerMediaSelectionCriteria> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selMediaSelectionCriteriaForMediaCharacteristic_XHandle, avMediaCharacteristic__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (avMediaCharacteristic);
			return ret!;
		}
		[Export ("pause")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Pause ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selPauseXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selPauseXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("play")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Play ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selPlayXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selPlayXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("playImmediatelyAtRate:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PlayImmediatelyAtRate (float rate)
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, selPlayImmediatelyAtRate_XHandle, rate);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_float (&__objc_super__, selPlayImmediatelyAtRate_XHandle, rate);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("prerollAtRate:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void Preroll (float rate, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAVCompletion))]AVCompletion? onComplete)
		{
			using var block_onComplete = Trampolines.SDAVCompletion.CreateNullableBlock (onComplete);
			BlockLiteral *block_ptr_onComplete = null;
			if (onComplete is not null)
				block_ptr_onComplete = &block_onComplete;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_float_NativeHandle (this.Handle, selPrerollAtRate_CompletionHandler_XHandle, rate, (IntPtr) block_ptr_onComplete);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_float_NativeHandle (&__objc_super__, selPrerollAtRate_CompletionHandler_XHandle, rate, (IntPtr) block_ptr_onComplete);
					GC.KeepAlive (this);
				}
			}
		}
		/// <param name="rate">Playback rate.</param>
		/// <summary>Starts loading media into the playback buffers.</summary>
		/// <returns>
		///           <para>A task that represents the asynchronous Preroll operation.   The value of the TResult parameter is a <see cref="AVFoundation.AVCompletion" />.</para>
		///         </returns>
		/// <remarks>
		///           <para copied="true">The PrerollAsync method is suitable to be used with C# async by returning control to the caller with a Task representing the operation.</para>
		///           <para copied="true">To be added.</para>
		///         </remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<bool> PrerollAsync (float rate)
		{
			var tcs = new TaskCompletionSource<bool> ();
			Preroll(rate, (finished_) => {
				tcs.SetResult (finished_!);
			});
			return tcs.Task;
		}
		[Export ("removeTimeObserver:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemoveTimeObserver (NSObject observer)
		{
			var observer__handle__ = observer!.GetNonNullHandle (nameof (observer));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selRemoveTimeObserver_XHandle, observer__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selRemoveTimeObserver_XHandle, observer__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (observer);
		}
		[Export ("replaceCurrentItemWithPlayerItem:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ReplaceCurrentItemWithPlayerItem (AVPlayerItem? item)
		{
			var item__handle__ = item.GetHandle ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selReplaceCurrentItemWithPlayerItem_XHandle, item__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selReplaceCurrentItemWithPlayerItem_XHandle, item__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (item);
		}
		[Export ("seekToTime:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Seek (global::CoreMedia.CMTime toTime)
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_CMTime (this.Handle, selSeekToTime_XHandle, toTime);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_CMTime (&__objc_super__, selSeekToTime_XHandle, toTime);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("seekToTime:toleranceBefore:toleranceAfter:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Seek (global::CoreMedia.CMTime toTime, global::CoreMedia.CMTime toleranceBefore, global::CoreMedia.CMTime toleranceAfter)
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_CMTime_CMTime_CMTime (this.Handle, selSeekToTime_ToleranceBefore_ToleranceAfter_XHandle, toTime, toleranceBefore, toleranceAfter);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_CMTime_CMTime_CMTime (&__objc_super__, selSeekToTime_ToleranceBefore_ToleranceAfter_XHandle, toTime, toleranceBefore, toleranceAfter);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("seekToTime:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void Seek (global::CoreMedia.CMTime time, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAVCompletion))]AVCompletion completion)
		{
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDAVCompletion.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_CMTime_NativeHandle (this.Handle, selSeekToTime_CompletionHandler_XHandle, time, (IntPtr) block_ptr_completion);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_CMTime_NativeHandle (&__objc_super__, selSeekToTime_CompletionHandler_XHandle, time, (IntPtr) block_ptr_completion);
					GC.KeepAlive (this);
				}
			}
		}
		/// <param name="time">Seek time target.</param>
		/// <summary>Seeks to a specific location in the playback stream.</summary>
		/// <returns>
		///           <para>A task that represents the asynchronous Seek operation.   The value of the TResult parameter is a <see cref="AVFoundation.AVCompletion" />.</para>
		///         </returns>
		/// <remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<bool> SeekAsync (global::CoreMedia.CMTime time)
		{
			var tcs = new TaskCompletionSource<bool> ();
			Seek(time, (finished_) => {
				tcs.SetResult (finished_!);
			});
			return tcs.Task;
		}
		[Export ("seekToTime:toleranceBefore:toleranceAfter:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void Seek (global::CoreMedia.CMTime time, global::CoreMedia.CMTime toleranceBefore, global::CoreMedia.CMTime toleranceAfter, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAVCompletion))]AVCompletion completion)
		{
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDAVCompletion.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_CMTime_CMTime_CMTime_NativeHandle (this.Handle, selSeekToTime_ToleranceBefore_ToleranceAfter_CompletionHandler_XHandle, time, toleranceBefore, toleranceAfter, (IntPtr) block_ptr_completion);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_CMTime_CMTime_CMTime_NativeHandle (&__objc_super__, selSeekToTime_ToleranceBefore_ToleranceAfter_CompletionHandler_XHandle, time, toleranceBefore, toleranceAfter, (IntPtr) block_ptr_completion);
					GC.KeepAlive (this);
				}
			}
		}
		/// <param name="time">To be added.</param>
		/// <param name="toleranceBefore">To be added.</param>
		/// <param name="toleranceAfter">To be added.</param>
		/// <summary>Seeks to a specific time, with a specified tolerance. May be higher performane than non-tolerant seek.</summary>
		/// <returns>To be added.</returns>
		/// <remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<bool> SeekAsync (global::CoreMedia.CMTime time, global::CoreMedia.CMTime toleranceBefore, global::CoreMedia.CMTime toleranceAfter)
		{
			var tcs = new TaskCompletionSource<bool> ();
			Seek(time, toleranceBefore, toleranceAfter, (finished_) => {
				tcs.SetResult (finished_!);
			});
			return tcs.Task;
		}
		[Export ("seekToDate:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Seek (NSDate date)
		{
			var date__handle__ = date!.GetNonNullHandle (nameof (date));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSeekToDate_XHandle, date__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSeekToDate_XHandle, date__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (date);
		}
		[Export ("seekToDate:completionHandler:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void Seek (NSDate date, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAVCompletion))]AVCompletion onComplete)
		{
			var date__handle__ = date!.GetNonNullHandle (nameof (date));
			if (onComplete is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (onComplete));
			using var block_onComplete = Trampolines.SDAVCompletion.CreateBlock (onComplete);
			BlockLiteral *block_ptr_onComplete = &block_onComplete;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selSeekToDate_CompletionHandler_XHandle, date__handle__, (IntPtr) block_ptr_onComplete);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selSeekToDate_CompletionHandler_XHandle, date__handle__, (IntPtr) block_ptr_onComplete);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (date);
		}
		/// <param name="date">Target data to seek to</param>
		/// <summary>Asynchronously seeks to a specific time in the playback stream.</summary>
		/// <returns>
		///           <para>A task that represents the asynchronous Seek operation.   The value of the TResult parameter is a <see cref="AVFoundation.AVCompletion" />.</para>
		///         </returns>
		/// <remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<bool> SeekAsync (NSDate date)
		{
			var tcs = new TaskCompletionSource<bool> ();
			Seek(date, (finished_) => {
				tcs.SetResult (finished_!);
			});
			return tcs.Task;
		}
		[Export ("setMediaSelectionCriteria:forMediaCharacteristic:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetMediaSelectionCriteria (AVPlayerMediaSelectionCriteria? criteria, NSString avMediaCharacteristic)
		{
			var criteria__handle__ = criteria.GetHandle ();
			var avMediaCharacteristic__handle__ = avMediaCharacteristic!.GetNonNullHandle (nameof (avMediaCharacteristic));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selSetMediaSelectionCriteria_ForMediaCharacteristic_XHandle, criteria__handle__, avMediaCharacteristic__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selSetMediaSelectionCriteria_ForMediaCharacteristic_XHandle, criteria__handle__, avMediaCharacteristic__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (criteria);
			GC.KeepAlive (avMediaCharacteristic);
		}
		[Export ("setRate:time:atHostTime:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetRate (float rate, global::CoreMedia.CMTime itemTime, global::CoreMedia.CMTime hostClockTime)
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_float_CMTime_CMTime (this.Handle, selSetRate_Time_AtHostTime_XHandle, rate, itemTime, hostClockTime);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_float_CMTime_CMTime (&__objc_super__, selSetRate_Time_AtHostTime_XHandle, rate, itemTime, hostClockTime);
					GC.KeepAlive (this);
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual AVPlayerActionAtItemEnd ActionAtItemEnd {
			[Export ("actionAtItemEnd")]
			get {
				AVPlayerActionAtItemEnd ret;
				if (IsDirectBinding) {
					ret = (AVPlayerActionAtItemEnd) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selActionAtItemEndXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (AVPlayerActionAtItemEnd) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selActionAtItemEndXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setActionAtItemEnd:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetActionAtItemEnd_XHandle, (IntPtr) (long) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, selSetActionAtItemEnd_XHandle, (IntPtr) (long) value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst26.4")]
		[SupportedOSPlatform ("tvos26.4")]
		[SupportedOSPlatform ("macos26.4")]
		[SupportedOSPlatform ("ios26.4")]
		public virtual bool AllowsCaptureOfClearKeyVideo {
			[Export ("allowsCaptureOfClearKeyVideo")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selAllowsCaptureOfClearKeyVideoXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selAllowsCaptureOfClearKeyVideoXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setAllowsCaptureOfClearKeyVideo:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetAllowsCaptureOfClearKeyVideo_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetAllowsCaptureOfClearKeyVideo_XHandle, value ? (byte) 1 : (byte) 0);
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
		public virtual bool AllowsExternalPlayback {
			[Export ("allowsExternalPlayback")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selAllowsExternalPlaybackXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selAllowsExternalPlaybackXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setAllowsExternalPlayback:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetAllowsExternalPlayback_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetAllowsExternalPlayback_XHandle, value ? (byte) 1 : (byte) 0);
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
		public virtual bool AppliesMediaSelectionCriteriaAutomatically {
			[Export ("appliesMediaSelectionCriteriaAutomatically")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selAppliesMediaSelectionCriteriaAutomaticallyXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selAppliesMediaSelectionCriteriaAutomaticallyXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setAppliesMediaSelectionCriteriaAutomatically:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetAppliesMediaSelectionCriteriaAutomatically_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetAppliesMediaSelectionCriteriaAutomatically_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public virtual string? AudioOutputDeviceUniqueID {
			[Export ("audioOutputDeviceUniqueID")]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selAudioOutputDeviceUniqueIDXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selAudioOutputDeviceUniqueIDXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setAudioOutputDeviceUniqueID:")]
			set {
				var nsvalue = CFString.CreateNative (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetAudioOutputDeviceUniqueID_XHandle, nsvalue);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetAudioOutputDeviceUniqueID_XHandle, nsvalue);
						GC.KeepAlive (this);
					}
				}
				CFString.ReleaseNative (nsvalue);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public virtual AVPlayerAudiovisualBackgroundPlaybackPolicy AudiovisualBackgroundPlaybackPolicy {
			[Export ("audiovisualBackgroundPlaybackPolicy", ArgumentSemantic.Assign)]
			get {
				AVPlayerAudiovisualBackgroundPlaybackPolicy ret;
				if (IsDirectBinding) {
					ret = (AVPlayerAudiovisualBackgroundPlaybackPolicy) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selAudiovisualBackgroundPlaybackPolicyXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (AVPlayerAudiovisualBackgroundPlaybackPolicy) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selAudiovisualBackgroundPlaybackPolicyXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setAudiovisualBackgroundPlaybackPolicy:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetAudiovisualBackgroundPlaybackPolicy_XHandle, (IntPtr) (long) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, selSetAudiovisualBackgroundPlaybackPolicy_XHandle, (IntPtr) (long) value);
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
		public virtual bool AutomaticallyWaitsToMinimizeStalling {
			[Export ("automaticallyWaitsToMinimizeStalling")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selAutomaticallyWaitsToMinimizeStallingXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selAutomaticallyWaitsToMinimizeStallingXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setAutomaticallyWaitsToMinimizeStalling:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetAutomaticallyWaitsToMinimizeStalling_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetAutomaticallyWaitsToMinimizeStalling_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>Whether the player displays closed captioning.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[ObsoletedOSPlatform ("macos10.13")]
		[ObsoletedOSPlatform ("ios11.0")]
		[ObsoletedOSPlatform ("tvos11.0")]
		[ObsoletedOSPlatform ("maccatalyst13.1")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		public virtual bool ClosedCaptionDisplayEnabled {
			[Export ("isClosedCaptionDisplayEnabled")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsClosedCaptionDisplayEnabledXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsClosedCaptionDisplayEnabledXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setClosedCaptionDisplayEnabled:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetClosedCaptionDisplayEnabled_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetClosedCaptionDisplayEnabled_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual AVPlayerItem? CurrentItem {
			[Export ("currentItem")]
			get {
				AVPlayerItem? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<AVPlayerItem> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selCurrentItemXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<AVPlayerItem> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selCurrentItemXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::CoreMedia.CMTime CurrentTime {
			[Export ("currentTime")]
			get {
				global::CoreMedia.CMTime ret;
				if (IsDirectBinding) {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						ret = global::ObjCRuntime.Messaging.CMTime_objc_msgSend (this.Handle, selCurrentTimeXHandle);
					} else {
						ret = global::ObjCRuntime.Messaging.CMTime_objc_msgSend_stret (this.Handle, selCurrentTimeXHandle);
					}
				} else {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.CMTime_objc_msgSendSuper (&__objc_super__, selCurrentTimeXHandle);
							GC.KeepAlive (this);
						}
					} else {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.CMTime_objc_msgSendSuper_stret (&__objc_super__, selCurrentTimeXHandle);
							GC.KeepAlive (this);
						}
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		public virtual float DefaultRate {
			[Export ("defaultRate")]
			get {
				float ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selDefaultRateXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.float_objc_msgSendSuper (&__objc_super__, selDefaultRateXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setDefaultRate:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, selSetDefaultRate_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_float (&__objc_super__, selSetDefaultRate_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos13.4")]
		[SupportedOSPlatform ("ios13.4")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static bool EligibleForHdrPlayback {
			[Export ("eligibleForHDRPlayback")]
			get {
				byte ret;
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (class_ptr, selEligibleForHDRPlaybackXHandle);
				return ret != 0;
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
		/// <summary>Whether the player is currently playing back in external playback mode.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual bool ExternalPlaybackActive {
			[Export ("isExternalPlaybackActive")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsExternalPlaybackActiveXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsExternalPlaybackActiveXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[ObsoletedOSPlatform ("macos15.0")]
		[ObsoletedOSPlatform ("ios15.0")]
		[ObsoletedOSPlatform ("tvos15.0")]
		[ObsoletedOSPlatform ("maccatalyst15.0")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		public virtual global::CoreMedia.CMClock? MasterClock {
			[Export ("masterClock")]
			get {
				global::CoreMedia.CMClock ret;
				if (IsDirectBinding) {
					ret = Runtime.GetINativeObject<global::CoreMedia.CMClock> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selMasterClockXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = Runtime.GetINativeObject<global::CoreMedia.CMClock> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selMasterClockXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setMasterClock:")]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetMasterClock_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetMasterClock_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		/// <summary>Whether the <see cref="T:AVFoundation.AVPlayer" /> is currently muted.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool Muted {
			[Export ("isMuted")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsMutedXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsMutedXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setMuted:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetMuted_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetMuted_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		public virtual AVPlayerNetworkResourcePriority NetworkResourcePriority {
			[Export ("networkResourcePriority", ArgumentSemantic.Assign)]
			get {
				AVPlayerNetworkResourcePriority ret;
				if (IsDirectBinding) {
					ret = (AVPlayerNetworkResourcePriority) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selNetworkResourcePriorityXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (AVPlayerNetworkResourcePriority) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selNetworkResourcePriorityXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setNetworkResourcePriority:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetNetworkResourcePriority_XHandle, (IntPtr) (long) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, selSetNetworkResourcePriority_XHandle, (IntPtr) (long) value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		public static bool ObservationEnabled {
			[Export ("isObservationEnabled")]
			get {
				byte ret;
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (class_ptr, selIsObservationEnabledXHandle);
				return ret != 0;
			}
			[Export ("setObservationEnabled:")]
			set {
				global::ObjCRuntime.Messaging.void_objc_msgSend_bool (class_ptr, selSetObservationEnabled_XHandle, value ? (byte) 1 : (byte) 0);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual bool OutputObscuredDueToInsufficientExternalProtection {
			[Export ("outputObscuredDueToInsufficientExternalProtection")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selOutputObscuredDueToInsufficientExternalProtectionXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selOutputObscuredDueToInsufficientExternalProtectionXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public virtual AVPlayerPlaybackCoordinator PlaybackCoordinator {
			[Export ("playbackCoordinator", ArgumentSemantic.Retain)]
			get {
				AVPlayerPlaybackCoordinator? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<AVPlayerPlaybackCoordinator> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selPlaybackCoordinatorXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<AVPlayerPlaybackCoordinator> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selPlaybackCoordinatorXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public virtual ulong PreferredVideoDecoderGpuRegistryId {
			[Export ("preferredVideoDecoderGPURegistryID")]
			get {
				ulong ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.UInt64_objc_msgSend (this.Handle, selPreferredVideoDecoderGPURegistryIDXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.UInt64_objc_msgSendSuper (&__objc_super__, selPreferredVideoDecoderGPURegistryIDXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setPreferredVideoDecoderGPURegistryID:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_UInt64 (this.Handle, selSetPreferredVideoDecoderGPURegistryID_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UInt64 (&__objc_super__, selSetPreferredVideoDecoderGPURegistryID_XHandle, value);
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
		public virtual bool PreventsDisplaySleepDuringVideoPlayback {
			[Export ("preventsDisplaySleepDuringVideoPlayback")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selPreventsDisplaySleepDuringVideoPlaybackXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selPreventsDisplaySleepDuringVideoPlaybackXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setPreventsDisplaySleepDuringVideoPlayback:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetPreventsDisplaySleepDuringVideoPlayback_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetPreventsDisplaySleepDuringVideoPlayback_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual float Rate {
			[Export ("rate")]
			get {
				float ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selRateXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.float_objc_msgSendSuper (&__objc_super__, selRateXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setRate:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, selSetRate_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_float (&__objc_super__, selSetRate_XHandle, value);
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
		public virtual string? ReasonForWaitingToPlay {
			[Export ("reasonForWaitingToPlay")]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selReasonForWaitingToPlayXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selReasonForWaitingToPlayXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public virtual global::CoreMedia.CMClock? SourceClock {
			[Export ("sourceClock", ArgumentSemantic.Retain)]
			get {
				global::CoreMedia.CMClock ret;
				if (IsDirectBinding) {
					ret = Runtime.GetINativeObject<global::CoreMedia.CMClock> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selSourceClockXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = Runtime.GetINativeObject<global::CoreMedia.CMClock> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selSourceClockXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setSourceClock:", ArgumentSemantic.Retain)]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetSourceClock_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetSourceClock_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual AVPlayerStatus Status {
			[Export ("status")]
			get {
				AVPlayerStatus ret;
				if (IsDirectBinding) {
					ret = (AVPlayerStatus) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selStatusXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (AVPlayerStatus) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selStatusXHandle);
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
		public virtual AVPlayerTimeControlStatus TimeControlStatus {
			[Export ("timeControlStatus")]
			get {
				AVPlayerTimeControlStatus ret;
				if (IsDirectBinding) {
					ret = (AVPlayerTimeControlStatus) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selTimeControlStatusXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (AVPlayerTimeControlStatus) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selTimeControlStatusXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		object? __mt_VideoOutput_var;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos17.2")]
		[SupportedOSPlatform ("macos14.2")]
		[SupportedOSPlatform ("ios17.2")]
		[SupportedOSPlatform ("maccatalyst17.2")]
		public virtual AVPlayerVideoOutput? VideoOutput {
			[Export ("videoOutput", ArgumentSemantic.Assign)]
			get {
				AVPlayerVideoOutput? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<AVPlayerVideoOutput> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selVideoOutputXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<AVPlayerVideoOutput> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selVideoOutputXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				MarkDirty ();
				__mt_VideoOutput_var = ret;
				return ret!;
			}
			[Export ("setVideoOutput:", ArgumentSemantic.Assign)]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetVideoOutput_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetVideoOutput_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
				MarkDirty ();
				__mt_VideoOutput_var = value;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual float Volume {
			[Export ("volume")]
			get {
				float ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selVolumeXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.float_objc_msgSendSuper (&__objc_super__, selVolumeXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setVolume:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, selSetVolume_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_float (&__objc_super__, selSetVolume_XHandle, value);
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
		protected virtual NSString WeakExternalPlaybackVideoGravity {
			[Export ("externalPlaybackVideoGravity", ArgumentSemantic.Copy)]
			get {
				NSString? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selExternalPlaybackVideoGravityXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selExternalPlaybackVideoGravityXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setExternalPlaybackVideoGravity:", ArgumentSemantic.Copy)]
			set {
				var value__handle__ = value!.GetNonNullHandle (nameof (value));
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetExternalPlaybackVideoGravity_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetExternalPlaybackVideoGravity_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _EligibleForHdrPlaybackDidChangeNotification;
		/// <summary>Notification constant for EligibleForHdrPlaybackDidChange</summary>
		/// <value><see cref="NSString" /> constant, should be used as a token to <see cref="NSNotificationCenter" />.</value>
		/// <remarks>
		///   <para>
		///     This constant can be used with <see cref="NSNotificationCenter" /> to register a listener for this notification.
		///     This is an <see cref="NSString" /> instead of a string, because these values can be used as tokens in some native
		///     libraries instead of being used purely for their actual string content. The 'notification' parameter to the callback
		///     contains extra information that is specific to the notification type.
		///   </para>
		///   <para>
		///     To subscribe to this notification, developers can use the convenience <see cref="Notifications.ObserveEligibleForHdrPlaybackDidChange(NSObject,EventHandler{NSNotificationEventArgs})" />
		///     or <see cref="Notifications.ObserveEligibleForHdrPlaybackDidChange(EventHandler{NSNotificationEventArgs})" /> methods,
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
		/// notification = AVPlayer.Notifications.ObserveEligibleForHdrPlaybackDidChange ((sender, args) => {
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
		/// void Callback (object sender, AVPlayer.NSNotificationEventArgs args)
		/// {
		///     // Access strongly typed args
		///     Console.WriteLine ("Notification: {0}", args.Notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     notification = AVPlayer.Notifications.ObserveEligibleForHdrPlaybackDidChange (Callback);
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
		///     AVPlayer.EligibleForHdrPlaybackDidChangeNotification, (notification) => { Console.WriteLine ("Received the notification EligibleForHdrPlaybackDidChange", notification); }
		/// );
		///
		/// // Method style
		/// void Callback (NSNotification notification)
		/// {
		///     Console.WriteLine ("Received the notification EligibleForHdrPlaybackDidChange", notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     NSNotificationCenter.DefaultCenter.AddObserver (AVPlayer.EligibleForHdrPlaybackDidChangeNotification, Callback);
		/// }
		/// ]]></code>
		///   </example>
		/// </remarks>
		[Field ("AVPlayerEligibleForHDRPlaybackDidChangeNotification",  "AVFoundation")]
		[SupportedOSPlatform ("tvos13.4")]
		[SupportedOSPlatform ("ios13.4")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[Advice ("Use AVPlayer.Notifications.ObserveEligibleForHdrPlaybackDidChange helper method instead.")]
		public static NSString EligibleForHdrPlaybackDidChangeNotification {
			[SupportedOSPlatform ("tvos13.4")]
			[SupportedOSPlatform ("ios13.4")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_EligibleForHdrPlaybackDidChangeNotification is null)
					_EligibleForHdrPlaybackDidChangeNotification = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVPlayerEligibleForHDRPlaybackDidChangeNotification")!;
				return _EligibleForHdrPlaybackDidChangeNotification;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _RateDidChangeNotification;
		/// <summary>Notification constant for RateDidChange</summary>
		/// <value><see cref="NSString" /> constant, should be used as a token to <see cref="NSNotificationCenter" />.</value>
		/// <remarks>
		///   <para>
		///     This constant can be used with <see cref="NSNotificationCenter" /> to register a listener for this notification.
		///     This is an <see cref="NSString" /> instead of a string, because these values can be used as tokens in some native
		///     libraries instead of being used purely for their actual string content. The 'notification' parameter to the callback
		///     contains extra information that is specific to the notification type.
		///   </para>
		///   <para>
		///     To subscribe to this notification, developers can use the convenience <see cref="Notifications.ObserveRateDidChange(NSObject,EventHandler{AVPlayerRateDidChangeEventArgs})" />
		///     or <see cref="Notifications.ObserveRateDidChange(EventHandler{AVPlayerRateDidChangeEventArgs})" /> methods,
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
		/// notification = AVPlayer.Notifications.ObserveRateDidChange ((sender, args) => {
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
		/// void Callback (object sender, AVPlayer.AVPlayerRateDidChangeEventArgs args)
		/// {
		///     // Access strongly typed args
		///     Console.WriteLine ("Notification: {0}", args.Notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     notification = AVPlayer.Notifications.ObserveRateDidChange (Callback);
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
		///     AVPlayer.RateDidChangeNotification, (notification) => { Console.WriteLine ("Received the notification RateDidChange", notification); }
		/// );
		///
		/// // Method style
		/// void Callback (NSNotification notification)
		/// {
		///     Console.WriteLine ("Received the notification RateDidChange", notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     NSNotificationCenter.DefaultCenter.AddObserver (AVPlayer.RateDidChangeNotification, Callback);
		/// }
		/// ]]></code>
		///   </example>
		/// </remarks>
		[Field ("AVPlayerRateDidChangeNotification",  "AVFoundation")]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[Advice ("Use AVPlayer.Notifications.ObserveRateDidChange helper method instead.")]
		public static NSString RateDidChangeNotification {
			[SupportedOSPlatform ("tvos15.0")]
			[SupportedOSPlatform ("ios15.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_RateDidChangeNotification is null)
					_RateDidChangeNotification = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVPlayerRateDidChangeNotification")!;
				return _RateDidChangeNotification;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_VideoOutput_var = null;
			}
		}
		//
		// Notifications
		//
		/// <summary>Notifications posted by the <see cref="global::AVFoundation.AVPlayer" /> class.</summary>
		/// <remarks>
		///    <para>This class contains various helper methods that allow developers to observe events posted in the notification hub (<see cref="Foundation.NSNotificationCenter" />).</para>
		///    <para>The methods defined in this class post events that invoke the provided method or lambda with a <see cref="Foundation.NSNotificationEventArgs" /> parameter, which contains strongly typed properties for the notification arguments.</para>
		/// </remarks>
		public static partial class Notifications {
			/// <summary>Strongly typed notification for the <see cref="global::AVFoundation.AVPlayer.EligibleForHdrPlaybackDidChangeNotification" /> constant.</summary>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::AVFoundation.AVPlayer.EligibleForHdrPlaybackDidChangeNotification" /> notifications.</para>
			///   <example>
			///   <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for any object
			/// var token = AVPlayer.Notifications.ObserveEligibleForHdrPlaybackDidChange ((notification) => {
			///   Console.WriteLine ("Observed EligibleForHdrPlaybackDidChangeNotification!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveEligibleForHdrPlaybackDidChange (EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (EligibleForHdrPlaybackDidChangeNotification, notification => handler (null, new NSNotificationEventArgs (notification)));
			}
			/// <summary>Strongly typed notification for the <see cref="global::AVFoundation.AVPlayer.EligibleForHdrPlaybackDidChangeNotification" /> constant.</summary>
			/// <param name="objectToObserve">The specific object to observe.</param>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::AVFoundation.AVPlayer.EligibleForHdrPlaybackDidChangeNotification" /> notifications.</para>
			///   <example>
			///     <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for a single object
			/// var token = AVPlayer.Notifications.ObserveEligibleForHdrPlaybackDidChange (objectToObserve, (notification) => {
			///   Console.WriteLine ($"Observed EligibleForHdrPlaybackDidChangeNotification for {nameof (objectToObserve)}!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveEligibleForHdrPlaybackDidChange (NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (EligibleForHdrPlaybackDidChangeNotification, notification => handler (null, new NSNotificationEventArgs (notification)), objectToObserve);
			}
			/// <summary>Strongly typed notification for the <see cref="global::AVFoundation.AVPlayer.RateDidChangeNotification" /> constant.</summary>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::AVFoundation.AVPlayer.RateDidChangeNotification" /> notifications.</para>
			///   <example>
			///   <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for any object
			/// var token = AVPlayer.Notifications.ObserveRateDidChange ((notification) => {
			///   Console.WriteLine ("Observed RateDidChangeNotification!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveRateDidChange (EventHandler<AVFoundation.AVPlayerRateDidChangeEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (RateDidChangeNotification, notification => handler (null, new AVFoundation.AVPlayerRateDidChangeEventArgs (notification)));
			}
			/// <summary>Strongly typed notification for the <see cref="global::AVFoundation.AVPlayer.RateDidChangeNotification" /> constant.</summary>
			/// <param name="objectToObserve">The specific object to observe.</param>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::AVFoundation.AVPlayer.RateDidChangeNotification" /> notifications.</para>
			///   <example>
			///     <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for a single object
			/// var token = AVPlayer.Notifications.ObserveRateDidChange (objectToObserve, (notification) => {
			///   Console.WriteLine ($"Observed RateDidChangeNotification for {nameof (objectToObserve)}!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveRateDidChange (NSObject objectToObserve, EventHandler<AVFoundation.AVPlayerRateDidChangeEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (RateDidChangeNotification, notification => handler (null, new AVFoundation.AVPlayerRateDidChangeEventArgs (notification)), objectToObserve);
			}
		}
	} /* class AVPlayer */
}
