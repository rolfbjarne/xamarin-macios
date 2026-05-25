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
	[Register("AVPlayerItemAccessLogEvent", true)]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe partial class AVPlayerItemAccessLogEvent : NSObject, INSCopying {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selURIX = "URI";
		static readonly NativeHandle selURIXHandle = Selector.GetHandle ("URI");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAverageAudioBitrateX = "averageAudioBitrate";
		static readonly NativeHandle selAverageAudioBitrateXHandle = Selector.GetHandle ("averageAudioBitrate");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAverageVideoBitrateX = "averageVideoBitrate";
		static readonly NativeHandle selAverageVideoBitrateXHandle = Selector.GetHandle ("averageVideoBitrate");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCopyWithZone_X = "copyWithZone:";
		static readonly NativeHandle selCopyWithZone_XHandle = Selector.GetHandle ("copyWithZone:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDownloadOverdueX = "downloadOverdue";
		static readonly NativeHandle selDownloadOverdueXHandle = Selector.GetHandle ("downloadOverdue");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDurationWatchedX = "durationWatched";
		static readonly NativeHandle selDurationWatchedXHandle = Selector.GetHandle ("durationWatched");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIndicatedAverageBitrateX = "indicatedAverageBitrate";
		static readonly NativeHandle selIndicatedAverageBitrateXHandle = Selector.GetHandle ("indicatedAverageBitrate");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIndicatedBitrateX = "indicatedBitrate";
		static readonly NativeHandle selIndicatedBitrateXHandle = Selector.GetHandle ("indicatedBitrate");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMediaRequestsWWANX = "mediaRequestsWWAN";
		static readonly NativeHandle selMediaRequestsWWANXHandle = Selector.GetHandle ("mediaRequestsWWAN");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selNumberOfBytesTransferredX = "numberOfBytesTransferred";
		static readonly NativeHandle selNumberOfBytesTransferredXHandle = Selector.GetHandle ("numberOfBytesTransferred");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selNumberOfDroppedVideoFramesX = "numberOfDroppedVideoFrames";
		static readonly NativeHandle selNumberOfDroppedVideoFramesXHandle = Selector.GetHandle ("numberOfDroppedVideoFrames");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selNumberOfMediaRequestsX = "numberOfMediaRequests";
		static readonly NativeHandle selNumberOfMediaRequestsXHandle = Selector.GetHandle ("numberOfMediaRequests");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selNumberOfSegmentsDownloadedX = "numberOfSegmentsDownloaded";
		static readonly NativeHandle selNumberOfSegmentsDownloadedXHandle = Selector.GetHandle ("numberOfSegmentsDownloaded");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selNumberOfServerAddressChangesX = "numberOfServerAddressChanges";
		static readonly NativeHandle selNumberOfServerAddressChangesXHandle = Selector.GetHandle ("numberOfServerAddressChanges");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selNumberOfStallsX = "numberOfStalls";
		static readonly NativeHandle selNumberOfStallsXHandle = Selector.GetHandle ("numberOfStalls");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selObservedBitrateX = "observedBitrate";
		static readonly NativeHandle selObservedBitrateXHandle = Selector.GetHandle ("observedBitrate");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selObservedBitrateStandardDeviationX = "observedBitrateStandardDeviation";
		static readonly NativeHandle selObservedBitrateStandardDeviationXHandle = Selector.GetHandle ("observedBitrateStandardDeviation");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selObservedMaxBitrateX = "observedMaxBitrate";
		static readonly NativeHandle selObservedMaxBitrateXHandle = Selector.GetHandle ("observedMaxBitrate");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selObservedMinBitrateX = "observedMinBitrate";
		static readonly NativeHandle selObservedMinBitrateXHandle = Selector.GetHandle ("observedMinBitrate");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPlaybackSessionIDX = "playbackSessionID";
		static readonly NativeHandle selPlaybackSessionIDXHandle = Selector.GetHandle ("playbackSessionID");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPlaybackStartDateX = "playbackStartDate";
		static readonly NativeHandle selPlaybackStartDateXHandle = Selector.GetHandle ("playbackStartDate");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPlaybackStartOffsetX = "playbackStartOffset";
		static readonly NativeHandle selPlaybackStartOffsetXHandle = Selector.GetHandle ("playbackStartOffset");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPlaybackTypeX = "playbackType";
		static readonly NativeHandle selPlaybackTypeXHandle = Selector.GetHandle ("playbackType");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSegmentsDownloadedDurationX = "segmentsDownloadedDuration";
		static readonly NativeHandle selSegmentsDownloadedDurationXHandle = Selector.GetHandle ("segmentsDownloadedDuration");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selServerAddressX = "serverAddress";
		static readonly NativeHandle selServerAddressXHandle = Selector.GetHandle ("serverAddress");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selStartupTimeX = "startupTime";
		static readonly NativeHandle selStartupTimeXHandle = Selector.GetHandle ("startupTime");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSwitchBitrateX = "switchBitrate";
		static readonly NativeHandle selSwitchBitrateXHandle = Selector.GetHandle ("switchBitrate");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTransferDurationX = "transferDuration";
		static readonly NativeHandle selTransferDurationXHandle = Selector.GetHandle ("transferDuration");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("AVPlayerItemAccessLogEvent");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		/// <summary>Creates a new <see cref="AVPlayerItemAccessLogEvent" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public AVPlayerItemAccessLogEvent () : base (NSObjectFlag.Empty)
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
		protected AVPlayerItemAccessLogEvent (NSObjectFlag t) : base (t)
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
		protected internal AVPlayerItemAccessLogEvent (NativeHandle handle) : base (handle)
		{
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
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual double AverageAudioBitrate {
			[Export ("averageAudioBitrate")]
			get {
				double ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.Double_objc_msgSend (this.Handle, selAverageAudioBitrateXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.Double_objc_msgSendSuper (&__objc_super__, selAverageAudioBitrateXHandle);
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
		public virtual double AverageVideoBitrate {
			[Export ("averageVideoBitrate")]
			get {
				double ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.Double_objc_msgSend (this.Handle, selAverageVideoBitrateXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.Double_objc_msgSendSuper (&__objc_super__, selAverageVideoBitrateXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual long BytesTransferred {
			[Export ("numberOfBytesTransferred")]
			get {
				long ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.Int64_objc_msgSend (this.Handle, selNumberOfBytesTransferredXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.Int64_objc_msgSendSuper (&__objc_super__, selNumberOfBytesTransferredXHandle);
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
		public virtual nint DownloadOverdue {
			[Export ("downloadOverdue")]
			get {
				nint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selDownloadOverdueXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selDownloadOverdueXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint DroppedVideoFrameCount {
			[Export ("numberOfDroppedVideoFrames")]
			get {
				nint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selNumberOfDroppedVideoFramesXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selNumberOfDroppedVideoFramesXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual double DurationWatched {
			[Export ("durationWatched")]
			get {
				double ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.Double_objc_msgSend (this.Handle, selDurationWatchedXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.Double_objc_msgSendSuper (&__objc_super__, selDurationWatchedXHandle);
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
		public virtual double IndicatedAverageBitrate {
			[Export ("indicatedAverageBitrate")]
			get {
				double ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.Double_objc_msgSend (this.Handle, selIndicatedAverageBitrateXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.Double_objc_msgSendSuper (&__objc_super__, selIndicatedAverageBitrateXHandle);
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
		public virtual double IndicatedBitrate {
			[Export ("indicatedBitrate")]
			get {
				double ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.Double_objc_msgSend (this.Handle, selIndicatedBitrateXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.Double_objc_msgSendSuper (&__objc_super__, selIndicatedBitrateXHandle);
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
		public virtual nint MediaRequestsWWAN {
			[Export ("mediaRequestsWWAN")]
			get {
				nint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selMediaRequestsWWANXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selMediaRequestsWWANXHandle);
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
		public virtual nint NumberOfMediaRequests {
			[Export ("numberOfMediaRequests")]
			get {
				nint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selNumberOfMediaRequestsXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selNumberOfMediaRequestsXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual double ObservedBitrate {
			[Export ("observedBitrate")]
			get {
				double ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.Double_objc_msgSend (this.Handle, selObservedBitrateXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.Double_objc_msgSendSuper (&__objc_super__, selObservedBitrateXHandle);
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
		public virtual double ObservedBitrateStandardDeviation {
			[Export ("observedBitrateStandardDeviation")]
			get {
				double ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.Double_objc_msgSend (this.Handle, selObservedBitrateStandardDeviationXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.Double_objc_msgSendSuper (&__objc_super__, selObservedBitrateStandardDeviationXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[ObsoletedOSPlatform ("macos12.0", "Use 'ObservedBitrateStandardDeviation' instead.")]
		[ObsoletedOSPlatform ("ios15.0", "Use 'ObservedBitrateStandardDeviation' instead.")]
		[ObsoletedOSPlatform ("tvos15.0", "Use 'ObservedBitrateStandardDeviation' instead.")]
		[ObsoletedOSPlatform ("maccatalyst15.0", "Use 'ObservedBitrateStandardDeviation' instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual double ObservedMaxBitrate {
			[Export ("observedMaxBitrate")]
			get {
				double ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.Double_objc_msgSend (this.Handle, selObservedMaxBitrateXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.Double_objc_msgSendSuper (&__objc_super__, selObservedMaxBitrateXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[ObsoletedOSPlatform ("macos12.0", "Use 'ObservedBitrateStandardDeviation' instead.")]
		[ObsoletedOSPlatform ("ios15.0", "Use 'ObservedBitrateStandardDeviation' instead.")]
		[ObsoletedOSPlatform ("tvos15.0", "Use 'ObservedBitrateStandardDeviation' instead.")]
		[ObsoletedOSPlatform ("maccatalyst15.0", "Use 'ObservedBitrateStandardDeviation' instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual double ObservedMinBitrate {
			[Export ("observedMinBitrate")]
			get {
				double ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.Double_objc_msgSend (this.Handle, selObservedMinBitrateXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.Double_objc_msgSendSuper (&__objc_super__, selObservedMinBitrateXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string? PlaybackSessionID {
			[Export ("playbackSessionID")]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selPlaybackSessionIDXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selPlaybackSessionIDXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSData? PlaybackStartDate {
			[Export ("playbackStartDate")]
			get {
				NSData? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSData> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selPlaybackStartDateXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSData> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selPlaybackStartDateXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual double PlaybackStartOffset {
			[Export ("playbackStartOffset")]
			get {
				double ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.Double_objc_msgSend (this.Handle, selPlaybackStartOffsetXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.Double_objc_msgSendSuper (&__objc_super__, selPlaybackStartOffsetXHandle);
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
		public virtual string? PlaybackType {
			[Export ("playbackType", ArgumentSemantic.Copy)]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selPlaybackTypeXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selPlaybackTypeXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[ObsoletedOSPlatform ("ios7.0", "Use 'NumberOfMediaRequests' instead.")]
		[ObsoletedOSPlatform ("tvos9.0", "Use 'NumberOfMediaRequests' instead.")]
		[ObsoletedOSPlatform ("macos10.9", "Use 'NumberOfMediaRequests' instead.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'NumberOfMediaRequests' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		public virtual nint SegmentedDownloadedCount {
			[Export ("numberOfSegmentsDownloaded")]
			get {
				nint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selNumberOfSegmentsDownloadedXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selNumberOfSegmentsDownloadedXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual double SegmentsDownloadedDuration {
			[Export ("segmentsDownloadedDuration")]
			get {
				double ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.Double_objc_msgSend (this.Handle, selSegmentsDownloadedDurationXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.Double_objc_msgSendSuper (&__objc_super__, selSegmentsDownloadedDurationXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string? ServerAddress {
			[Export ("serverAddress")]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selServerAddressXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selServerAddressXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint ServerAddressChangeCount {
			[Export ("numberOfServerAddressChanges")]
			get {
				nint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selNumberOfServerAddressChangesXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selNumberOfServerAddressChangesXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint StallCount {
			[Export ("numberOfStalls")]
			get {
				nint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selNumberOfStallsXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selNumberOfStallsXHandle);
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
		public virtual double StartupTime {
			[Export ("startupTime")]
			get {
				double ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.Double_objc_msgSend (this.Handle, selStartupTimeXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.Double_objc_msgSendSuper (&__objc_super__, selStartupTimeXHandle);
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
		public virtual double SwitchBitrate {
			[Export ("switchBitrate")]
			get {
				double ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.Double_objc_msgSend (this.Handle, selSwitchBitrateXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.Double_objc_msgSendSuper (&__objc_super__, selSwitchBitrateXHandle);
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
		public virtual double TransferDuration {
			[Export ("transferDuration")]
			get {
				double ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.Double_objc_msgSend (this.Handle, selTransferDurationXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.Double_objc_msgSendSuper (&__objc_super__, selTransferDurationXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string? Uri {
			[Export ("URI")]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selURIXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selURIXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
	} /* class AVPlayerItemAccessLogEvent */
}
