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
	[Register("AVMutableComposition", true)]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe partial class AVMutableComposition : AVComposition {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAddMutableTrackWithMediaType_PreferredTrackID_X = "addMutableTrackWithMediaType:preferredTrackID:";
		static readonly NativeHandle selAddMutableTrackWithMediaType_PreferredTrackID_XHandle = Selector.GetHandle ("addMutableTrackWithMediaType:preferredTrackID:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAddTracksForCinematicAssetInfo_PreferredStartingTrackID_X = "addTracksForCinematicAssetInfo:preferredStartingTrackID:";
		static readonly NativeHandle selAddTracksForCinematicAssetInfo_PreferredStartingTrackID_XHandle = Selector.GetHandle ("addTracksForCinematicAssetInfo:preferredStartingTrackID:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCompositionX = "composition";
		static readonly NativeHandle selCompositionXHandle = Selector.GetHandle ("composition");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCompositionWithURLAssetInitializationOptions_X = "compositionWithURLAssetInitializationOptions:";
		static readonly NativeHandle selCompositionWithURLAssetInitializationOptions_XHandle = Selector.GetHandle ("compositionWithURLAssetInitializationOptions:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInsertEmptyTimeRange_X = "insertEmptyTimeRange:";
		static readonly NativeHandle selInsertEmptyTimeRange_XHandle = Selector.GetHandle ("insertEmptyTimeRange:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInsertTimeRange_OfAsset_AtTime_CompletionHandler_X = "insertTimeRange:ofAsset:atTime:completionHandler:";
		static readonly NativeHandle selInsertTimeRange_OfAsset_AtTime_CompletionHandler_XHandle = Selector.GetHandle ("insertTimeRange:ofAsset:atTime:completionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInsertTimeRange_OfAsset_AtTime_Error_X = "insertTimeRange:ofAsset:atTime:error:";
		static readonly NativeHandle selInsertTimeRange_OfAsset_AtTime_Error_XHandle = Selector.GetHandle ("insertTimeRange:ofAsset:atTime:error:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMutableTrackCompatibleWithTrack_X = "mutableTrackCompatibleWithTrack:";
		static readonly NativeHandle selMutableTrackCompatibleWithTrack_XHandle = Selector.GetHandle ("mutableTrackCompatibleWithTrack:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selNaturalSizeX = "naturalSize";
		static readonly NativeHandle selNaturalSizeXHandle = Selector.GetHandle ("naturalSize");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRemoveTimeRange_X = "removeTimeRange:";
		static readonly NativeHandle selRemoveTimeRange_XHandle = Selector.GetHandle ("removeTimeRange:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRemoveTrack_X = "removeTrack:";
		static readonly NativeHandle selRemoveTrack_XHandle = Selector.GetHandle ("removeTrack:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selScaleTimeRange_ToDuration_X = "scaleTimeRange:toDuration:";
		static readonly NativeHandle selScaleTimeRange_ToDuration_XHandle = Selector.GetHandle ("scaleTimeRange:toDuration:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetNaturalSize_X = "setNaturalSize:";
		static readonly NativeHandle selSetNaturalSize_XHandle = Selector.GetHandle ("setNaturalSize:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("AVMutableComposition");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		/// <summary>Creates a new <see cref="AVMutableComposition" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public AVMutableComposition () : base (NSObjectFlag.Empty)
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
		protected AVMutableComposition (NSObjectFlag t) : base (t)
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
		protected internal AVMutableComposition (NativeHandle handle) : base (handle)
		{
		}

		[Export ("addMutableTrackWithMediaType:preferredTrackID:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual AVMutableCompositionTrack? AddMutableTrack (string mediaType, int preferredTrackId)
		{
			if (mediaType is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (mediaType));
			var nsmediaType = CFString.CreateNative (mediaType);
			AVMutableCompositionTrack? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<AVMutableCompositionTrack> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_int (this.Handle, selAddMutableTrackWithMediaType_PreferredTrackID_XHandle, nsmediaType, preferredTrackId), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<AVMutableCompositionTrack> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_int (&__objc_super__, selAddMutableTrackWithMediaType_PreferredTrackID_XHandle, nsmediaType, preferredTrackId), false)!;
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsmediaType);
			return ret!;
		}
		[Export ("addTracksForCinematicAssetInfo:preferredStartingTrackID:")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::Cinematic.CNCompositionInfo AddTracks (global::Cinematic.CNAssetInfo assetInfo, int preferredStartingTrackID)
		{
			var assetInfo__handle__ = assetInfo!.GetNonNullHandle (nameof (assetInfo));
			global::Cinematic.CNCompositionInfo? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<global::Cinematic.CNCompositionInfo> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_int (this.Handle, selAddTracksForCinematicAssetInfo_PreferredStartingTrackID_XHandle, assetInfo__handle__, preferredStartingTrackID), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<global::Cinematic.CNCompositionInfo> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_int (&__objc_super__, selAddTracksForCinematicAssetInfo_PreferredStartingTrackID_XHandle, assetInfo__handle__, preferredStartingTrackID), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (assetInfo);
			return ret!;
		}
		[Export ("composition")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static AVMutableComposition Create ()
		{
			AVMutableComposition ret;
			ret =  Runtime.GetNSObject<AVMutableComposition> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selCompositionXHandle), false)!;
			return ret;
		}
		[Export ("mutableTrackCompatibleWithTrack:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual AVMutableCompositionTrack? CreateMutableTrack (AVAssetTrack referenceTrack)
		{
			var referenceTrack__handle__ = referenceTrack!.GetNonNullHandle (nameof (referenceTrack));
			AVMutableCompositionTrack? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<AVMutableCompositionTrack> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selMutableTrackCompatibleWithTrack_XHandle, referenceTrack__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<AVMutableCompositionTrack> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selMutableTrackCompatibleWithTrack_XHandle, referenceTrack__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (referenceTrack);
			return ret!;
		}
		[Export ("compositionWithURLAssetInitializationOptions:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static AVMutableComposition FromOptions (NSDictionary<NSString, NSObject>? urlAssetInitializationOptions)
		{
			var urlAssetInitializationOptions__handle__ = urlAssetInitializationOptions.GetHandle ();
			AVMutableComposition? ret;
			ret =  Runtime.GetNSObject<AVMutableComposition> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, selCompositionWithURLAssetInitializationOptions_XHandle, urlAssetInitializationOptions__handle__), false)!;
			GC.KeepAlive (urlAssetInitializationOptions);
			return ret!;
		}
		[Export ("insertEmptyTimeRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void InserEmptyTimeRange (global::CoreMedia.CMTimeRange timeRange)
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_CMTimeRange (this.Handle, selInsertEmptyTimeRange_XHandle, timeRange);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_CMTimeRange (&__objc_super__, selInsertEmptyTimeRange_XHandle, timeRange);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("insertTimeRange:ofAsset:atTime:error:")]
		[ObsoletedOSPlatform ("macos15.0")]
		[ObsoletedOSPlatform ("ios18.0")]
		[ObsoletedOSPlatform ("tvos18.0")]
		[ObsoletedOSPlatform ("maccatalyst18.0")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual bool Insert (global::CoreMedia.CMTimeRange insertTimeRange, AVAsset sourceAsset, global::CoreMedia.CMTime atTime, out NSError error)
		{
			var sourceAsset__handle__ = sourceAsset!.GetNonNullHandle (nameof (sourceAsset));
			NativeHandle errorValue = IntPtr.Zero;
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_CMTimeRange_NativeHandle_CMTime_ref_NativeHandle (this.Handle, selInsertTimeRange_OfAsset_AtTime_Error_XHandle, insertTimeRange, sourceAsset__handle__, atTime, &errorValue);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_CMTimeRange_NativeHandle_CMTime_ref_NativeHandle (&__objc_super__, selInsertTimeRange_OfAsset_AtTime_Error_XHandle, insertTimeRange, sourceAsset__handle__, atTime, &errorValue);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (sourceAsset);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret != 0;
		}
		[Export ("insertTimeRange:ofAsset:atTime:completionHandler:")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void Insert (global::CoreMedia.CMTimeRange timeRange, AVAsset asset, global::CoreMedia.CMTime startTime, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAVMutableCompositionInsertHandler))]AVMutableCompositionInsertHandler completionHandler)
		{
			var asset__handle__ = asset!.GetNonNullHandle (nameof (asset));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDAVMutableCompositionInsertHandler.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_CMTimeRange_NativeHandle_CMTime_NativeHandle (this.Handle, selInsertTimeRange_OfAsset_AtTime_CompletionHandler_XHandle, timeRange, asset__handle__, startTime, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_CMTimeRange_NativeHandle_CMTime_NativeHandle (&__objc_super__, selInsertTimeRange_OfAsset_AtTime_CompletionHandler_XHandle, timeRange, asset__handle__, startTime, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (asset);
		}
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task InsertAsync (global::CoreMedia.CMTimeRange timeRange, AVAsset asset, global::CoreMedia.CMTime startTime)
		{
			var tcs = new TaskCompletionSource<bool> ();
			Insert(timeRange, asset, startTime, (error_) => {
				if (error_ is not null)
					tcs.SetException (new NSErrorException(error_));
				else
					tcs.SetResult (true);
			});
			return tcs.Task;
		}
		[Export ("removeTimeRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemoveTimeRange (global::CoreMedia.CMTimeRange timeRange)
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_CMTimeRange (this.Handle, selRemoveTimeRange_XHandle, timeRange);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_CMTimeRange (&__objc_super__, selRemoveTimeRange_XHandle, timeRange);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("removeTrack:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemoveTrack (AVCompositionTrack track)
		{
			var track__handle__ = track!.GetNonNullHandle (nameof (track));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selRemoveTrack_XHandle, track__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selRemoveTrack_XHandle, track__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (track);
		}
		[Export ("scaleTimeRange:toDuration:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ScaleTimeRange (global::CoreMedia.CMTimeRange timeRange, global::CoreMedia.CMTime duration)
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_CMTimeRange_CMTime (this.Handle, selScaleTimeRange_ToDuration_XHandle, timeRange, duration);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_CMTimeRange_CMTime (&__objc_super__, selScaleTimeRange_ToDuration_XHandle, timeRange, duration);
					GC.KeepAlive (this);
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public override CGSize NaturalSize {
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
	} /* class AVMutableComposition */
}
