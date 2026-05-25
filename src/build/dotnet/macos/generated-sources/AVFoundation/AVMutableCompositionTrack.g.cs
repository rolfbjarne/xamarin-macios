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
	[Register("AVMutableCompositionTrack", true)]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe partial class AVMutableCompositionTrack : AVCompositionTrack {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAddTrackAssociationToTrack_Type_X = "addTrackAssociationToTrack:type:";
		static readonly NativeHandle selAddTrackAssociationToTrack_Type_XHandle = Selector.GetHandle ("addTrackAssociationToTrack:type:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selExtendedLanguageTagX = "extendedLanguageTag";
		static readonly NativeHandle selExtendedLanguageTagXHandle = Selector.GetHandle ("extendedLanguageTag");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInsertEmptyTimeRange_X = "insertEmptyTimeRange:";
		static readonly NativeHandle selInsertEmptyTimeRange_XHandle = Selector.GetHandle ("insertEmptyTimeRange:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInsertTimeRange_OfTrack_AtTime_Error_X = "insertTimeRange:ofTrack:atTime:error:";
		static readonly NativeHandle selInsertTimeRange_OfTrack_AtTime_Error_XHandle = Selector.GetHandle ("insertTimeRange:ofTrack:atTime:error:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInsertTimeRanges_OfTracks_AtTime_Error_X = "insertTimeRanges:ofTracks:atTime:error:";
		static readonly NativeHandle selInsertTimeRanges_OfTracks_AtTime_Error_XHandle = Selector.GetHandle ("insertTimeRanges:ofTracks:atTime:error:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsEnabledX = "isEnabled";
		static readonly NativeHandle selIsEnabledXHandle = Selector.GetHandle ("isEnabled");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLanguageCodeX = "languageCode";
		static readonly NativeHandle selLanguageCodeXHandle = Selector.GetHandle ("languageCode");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selNaturalTimeScaleX = "naturalTimeScale";
		static readonly NativeHandle selNaturalTimeScaleXHandle = Selector.GetHandle ("naturalTimeScale");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPreferredTransformX = "preferredTransform";
		static readonly NativeHandle selPreferredTransformXHandle = Selector.GetHandle ("preferredTransform");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPreferredVolumeX = "preferredVolume";
		static readonly NativeHandle selPreferredVolumeXHandle = Selector.GetHandle ("preferredVolume");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRemoveTimeRange_X = "removeTimeRange:";
		static readonly NativeHandle selRemoveTimeRange_XHandle = Selector.GetHandle ("removeTimeRange:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRemoveTrackAssociationToTrack_Type_X = "removeTrackAssociationToTrack:type:";
		static readonly NativeHandle selRemoveTrackAssociationToTrack_Type_XHandle = Selector.GetHandle ("removeTrackAssociationToTrack:type:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selReplaceFormatDescription_WithFormatDescription_X = "replaceFormatDescription:withFormatDescription:";
		static readonly NativeHandle selReplaceFormatDescription_WithFormatDescription_XHandle = Selector.GetHandle ("replaceFormatDescription:withFormatDescription:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selScaleTimeRange_ToDuration_X = "scaleTimeRange:toDuration:";
		static readonly NativeHandle selScaleTimeRange_ToDuration_XHandle = Selector.GetHandle ("scaleTimeRange:toDuration:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSegmentsX = "segments";
		static readonly NativeHandle selSegmentsXHandle = Selector.GetHandle ("segments");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetEnabled_X = "setEnabled:";
		static readonly NativeHandle selSetEnabled_XHandle = Selector.GetHandle ("setEnabled:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetExtendedLanguageTag_X = "setExtendedLanguageTag:";
		static readonly NativeHandle selSetExtendedLanguageTag_XHandle = Selector.GetHandle ("setExtendedLanguageTag:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetLanguageCode_X = "setLanguageCode:";
		static readonly NativeHandle selSetLanguageCode_XHandle = Selector.GetHandle ("setLanguageCode:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetNaturalTimeScale_X = "setNaturalTimeScale:";
		static readonly NativeHandle selSetNaturalTimeScale_XHandle = Selector.GetHandle ("setNaturalTimeScale:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetPreferredTransform_X = "setPreferredTransform:";
		static readonly NativeHandle selSetPreferredTransform_XHandle = Selector.GetHandle ("setPreferredTransform:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetPreferredVolume_X = "setPreferredVolume:";
		static readonly NativeHandle selSetPreferredVolume_XHandle = Selector.GetHandle ("setPreferredVolume:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetSegments_X = "setSegments:";
		static readonly NativeHandle selSetSegments_XHandle = Selector.GetHandle ("setSegments:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selValidateTrackSegments_Error_X = "validateTrackSegments:error:";
		static readonly NativeHandle selValidateTrackSegments_Error_XHandle = Selector.GetHandle ("validateTrackSegments:error:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("AVMutableCompositionTrack");
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
		protected AVMutableCompositionTrack (NSObjectFlag t) : base (t)
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
		protected internal AVMutableCompositionTrack (NativeHandle handle) : base (handle)
		{
		}

		[Export ("addTrackAssociationToTrack:type:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AddTrackAssociation (AVCompositionTrack compositionTrack, string trackAssociationType)
		{
			var compositionTrack__handle__ = compositionTrack!.GetNonNullHandle (nameof (compositionTrack));
			if (trackAssociationType is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (trackAssociationType));
			var nstrackAssociationType = CFString.CreateNative (trackAssociationType);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selAddTrackAssociationToTrack_Type_XHandle, compositionTrack__handle__, nstrackAssociationType);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selAddTrackAssociationToTrack_Type_XHandle, compositionTrack__handle__, nstrackAssociationType);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (compositionTrack);
			CFString.ReleaseNative (nstrackAssociationType);
		}
		[Export ("insertEmptyTimeRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void InsertEmptyTimeRange (global::CoreMedia.CMTimeRange timeRange)
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
		[Export ("insertTimeRange:ofTrack:atTime:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual bool InsertTimeRange (global::CoreMedia.CMTimeRange timeRange, AVAssetTrack ofTrack, global::CoreMedia.CMTime atTime, out NSError error)
		{
			var ofTrack__handle__ = ofTrack!.GetNonNullHandle (nameof (ofTrack));
			NativeHandle errorValue = IntPtr.Zero;
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_CMTimeRange_NativeHandle_CMTime_ref_NativeHandle (this.Handle, selInsertTimeRange_OfTrack_AtTime_Error_XHandle, timeRange, ofTrack__handle__, atTime, &errorValue);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_CMTimeRange_NativeHandle_CMTime_ref_NativeHandle (&__objc_super__, selInsertTimeRange_OfTrack_AtTime_Error_XHandle, timeRange, ofTrack__handle__, atTime, &errorValue);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (ofTrack);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret != 0;
		}
		[Export ("insertTimeRanges:ofTracks:atTime:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual bool InsertTimeRanges (NSValue[] cmTimeRanges, AVAssetTrack[] tracks, global::CoreMedia.CMTime startTime, out NSError error)
		{
			if (cmTimeRanges is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (cmTimeRanges));
			if (tracks is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (tracks));
			NativeHandle errorValue = IntPtr.Zero;
			using var nsa_cmTimeRanges = NSArray.FromNSObjects (cmTimeRanges);
			using var nsa_tracks = NSArray.FromNSObjects (tracks);
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_CMTime_ref_NativeHandle (this.Handle, selInsertTimeRanges_OfTracks_AtTime_Error_XHandle, nsa_cmTimeRanges.Handle, nsa_tracks.Handle, startTime, &errorValue);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle_NativeHandle_CMTime_ref_NativeHandle (&__objc_super__, selInsertTimeRanges_OfTracks_AtTime_Error_XHandle, nsa_cmTimeRanges.Handle, nsa_tracks.Handle, startTime, &errorValue);
					GC.KeepAlive (this);
				}
			}
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret != 0;
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
		[Export ("removeTrackAssociationToTrack:type:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemoveTrackAssociation (AVCompositionTrack compositionTrack, string trackAssociationType)
		{
			var compositionTrack__handle__ = compositionTrack!.GetNonNullHandle (nameof (compositionTrack));
			if (trackAssociationType is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (trackAssociationType));
			var nstrackAssociationType = CFString.CreateNative (trackAssociationType);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selRemoveTrackAssociationToTrack_Type_XHandle, compositionTrack__handle__, nstrackAssociationType);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selRemoveTrackAssociationToTrack_Type_XHandle, compositionTrack__handle__, nstrackAssociationType);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (compositionTrack);
			CFString.ReleaseNative (nstrackAssociationType);
		}
		[Export ("replaceFormatDescription:withFormatDescription:")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ReplaceFormatDescription (global::CoreMedia.CMFormatDescription originalFormatDescription, global::CoreMedia.CMFormatDescription? replacementFormatDescription)
		{
			var originalFormatDescription__handle__ = originalFormatDescription!.GetNonNullHandle (nameof (originalFormatDescription));
			var replacementFormatDescription__handle__ = replacementFormatDescription.GetHandle ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selReplaceFormatDescription_WithFormatDescription_XHandle, originalFormatDescription.Handle, replacementFormatDescription__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selReplaceFormatDescription_WithFormatDescription_XHandle, originalFormatDescription.Handle, replacementFormatDescription__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (originalFormatDescription);
			GC.KeepAlive (replacementFormatDescription);
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
		[Export ("validateTrackSegments:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual bool ValidateTrackSegments (AVCompositionTrackSegment[] trackSegments, out NSError error)
		{
			if (trackSegments is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (trackSegments));
			NativeHandle errorValue = IntPtr.Zero;
			using var nsa_trackSegments = NSArray.FromNSObjects (trackSegments);
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_ref_NativeHandle (this.Handle, selValidateTrackSegments_Error_XHandle, nsa_trackSegments.Handle, &errorValue);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle_ref_NativeHandle (&__objc_super__, selValidateTrackSegments_Error_XHandle, nsa_trackSegments.Handle, &errorValue);
					GC.KeepAlive (this);
				}
			}
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret != 0;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public virtual bool Enabled {
			[Export ("isEnabled")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsEnabledXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsEnabledXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setEnabled:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetEnabled_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetEnabled_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public new virtual string? ExtendedLanguageTag {
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
		public new virtual string? LanguageCode {
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
		public new virtual int NaturalTimeScale {
			[Export ("naturalTimeScale")]
			get {
				int ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.int_objc_msgSend (this.Handle, selNaturalTimeScaleXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.int_objc_msgSendSuper (&__objc_super__, selNaturalTimeScaleXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setNaturalTimeScale:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_int (this.Handle, selSetNaturalTimeScale_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_int (&__objc_super__, selSetNaturalTimeScale_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public new virtual CGAffineTransform PreferredTransform {
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
			[Export ("setPreferredTransform:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_CGAffineTransform (this.Handle, selSetPreferredTransform_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_CGAffineTransform (&__objc_super__, selSetPreferredTransform_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public new virtual float PreferredVolume {
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
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public new virtual AVCompositionTrackSegment[]? Segments {
			[Export ("segments", ArgumentSemantic.Copy)]
			get {
				AVCompositionTrackSegment[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<AVCompositionTrackSegment>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selSegmentsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<AVCompositionTrackSegment>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selSegmentsXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setSegments:", ArgumentSemantic.Copy)]
			set {
				using var nsa_value = value is null ? null : NSArray.FromNSObjects (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetSegments_XHandle, nsa_value.GetHandle ());
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetSegments_XHandle, nsa_value.GetHandle ());
						GC.KeepAlive (this);
					}
				}
			}
		}
	} /* class AVMutableCompositionTrack */
}
