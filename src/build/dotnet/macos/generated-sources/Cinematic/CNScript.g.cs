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
namespace Cinematic {
	[Register("CNScript", true)]
	[SupportedOSPlatform ("tvos17.0")]
	[SupportedOSPlatform ("macos14.0")]
	[SupportedOSPlatform ("ios17.0")]
	[SupportedOSPlatform ("maccatalyst26.0")]
	public unsafe partial class CNScript : NSObject {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAddDetectionTrack_X = "addDetectionTrack:";
		static readonly NativeHandle selAddDetectionTrack_XHandle = Selector.GetHandle ("addDetectionTrack:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAddUserDecision_X = "addUserDecision:";
		static readonly NativeHandle selAddUserDecision_XHandle = Selector.GetHandle ("addUserDecision:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAddedDetectionTracksX = "addedDetectionTracks";
		static readonly NativeHandle selAddedDetectionTracksXHandle = Selector.GetHandle ("addedDetectionTracks");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selBaseDecisionsInTimeRange_X = "baseDecisionsInTimeRange:";
		static readonly NativeHandle selBaseDecisionsInTimeRange_XHandle = Selector.GetHandle ("baseDecisionsInTimeRange:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selChangesX = "changes";
		static readonly NativeHandle selChangesXHandle = Selector.GetHandle ("changes");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selChangesTrimmedByTimeRange_X = "changesTrimmedByTimeRange:";
		static readonly NativeHandle selChangesTrimmedByTimeRange_XHandle = Selector.GetHandle ("changesTrimmedByTimeRange:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDecisionAfterTime_X = "decisionAfterTime:";
		static readonly NativeHandle selDecisionAfterTime_XHandle = Selector.GetHandle ("decisionAfterTime:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDecisionAtTime_Tolerance_X = "decisionAtTime:tolerance:";
		static readonly NativeHandle selDecisionAtTime_Tolerance_XHandle = Selector.GetHandle ("decisionAtTime:tolerance:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDecisionBeforeTime_X = "decisionBeforeTime:";
		static readonly NativeHandle selDecisionBeforeTime_XHandle = Selector.GetHandle ("decisionBeforeTime:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDecisionsInTimeRange_X = "decisionsInTimeRange:";
		static readonly NativeHandle selDecisionsInTimeRange_XHandle = Selector.GetHandle ("decisionsInTimeRange:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDetectionTrackForDecision_X = "detectionTrackForDecision:";
		static readonly NativeHandle selDetectionTrackForDecision_XHandle = Selector.GetHandle ("detectionTrackForDecision:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDetectionTrackForID_X = "detectionTrackForID:";
		static readonly NativeHandle selDetectionTrackForID_XHandle = Selector.GetHandle ("detectionTrackForID:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFNumberX = "fNumber";
		static readonly NativeHandle selFNumberXHandle = Selector.GetHandle ("fNumber");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFrameAtTime_Tolerance_X = "frameAtTime:tolerance:";
		static readonly NativeHandle selFrameAtTime_Tolerance_XHandle = Selector.GetHandle ("frameAtTime:tolerance:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFramesInTimeRange_X = "framesInTimeRange:";
		static readonly NativeHandle selFramesInTimeRange_XHandle = Selector.GetHandle ("framesInTimeRange:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLoadFromAsset_Changes_Progress_CompletionHandler_X = "loadFromAsset:changes:progress:completionHandler:";
		static readonly NativeHandle selLoadFromAsset_Changes_Progress_CompletionHandler_XHandle = Selector.GetHandle ("loadFromAsset:changes:progress:completionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPrimaryDecisionAtTime_X = "primaryDecisionAtTime:";
		static readonly NativeHandle selPrimaryDecisionAtTime_XHandle = Selector.GetHandle ("primaryDecisionAtTime:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selReloadWithChanges_X = "reloadWithChanges:";
		static readonly NativeHandle selReloadWithChanges_XHandle = Selector.GetHandle ("reloadWithChanges:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRemoveAllUserDecisionsX = "removeAllUserDecisions";
		static readonly NativeHandle selRemoveAllUserDecisionsXHandle = Selector.GetHandle ("removeAllUserDecisions");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRemoveDetectionTrack_X = "removeDetectionTrack:";
		static readonly NativeHandle selRemoveDetectionTrack_XHandle = Selector.GetHandle ("removeDetectionTrack:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRemoveUserDecision_X = "removeUserDecision:";
		static readonly NativeHandle selRemoveUserDecision_XHandle = Selector.GetHandle ("removeUserDecision:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSecondaryDecisionAtTime_X = "secondaryDecisionAtTime:";
		static readonly NativeHandle selSecondaryDecisionAtTime_XHandle = Selector.GetHandle ("secondaryDecisionAtTime:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetFNumber_X = "setFNumber:";
		static readonly NativeHandle selSetFNumber_XHandle = Selector.GetHandle ("setFNumber:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTimeRangeX = "timeRange";
		static readonly NativeHandle selTimeRangeXHandle = Selector.GetHandle ("timeRange");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTimeRangeOfTransitionAfterDecision_X = "timeRangeOfTransitionAfterDecision:";
		static readonly NativeHandle selTimeRangeOfTransitionAfterDecision_XHandle = Selector.GetHandle ("timeRangeOfTransitionAfterDecision:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTimeRangeOfTransitionBeforeDecision_X = "timeRangeOfTransitionBeforeDecision:";
		static readonly NativeHandle selTimeRangeOfTransitionBeforeDecision_XHandle = Selector.GetHandle ("timeRangeOfTransitionBeforeDecision:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selUserDecisionsInTimeRange_X = "userDecisionsInTimeRange:";
		static readonly NativeHandle selUserDecisionsInTimeRange_XHandle = Selector.GetHandle ("userDecisionsInTimeRange:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("CNScript");
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
		protected CNScript (NSObjectFlag t) : base (t)
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
		protected internal CNScript (NativeHandle handle) : base (handle)
		{
		}

		[Export ("addDetectionTrack:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual long AddDetectionTrack (CNDetectionTrack detectionTrack)
		{
			var detectionTrack__handle__ = detectionTrack!.GetNonNullHandle (nameof (detectionTrack));
			long ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.Int64_objc_msgSend_NativeHandle (this.Handle, selAddDetectionTrack_XHandle, detectionTrack__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.Int64_objc_msgSendSuper_NativeHandle (&__objc_super__, selAddDetectionTrack_XHandle, detectionTrack__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (detectionTrack);
			return ret!;
		}
		[Export ("addUserDecision:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool AddUserDecision (CNDecision decision)
		{
			var decision__handle__ = decision!.GetNonNullHandle (nameof (decision));
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (this.Handle, selAddUserDecision_XHandle, decision__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle (&__objc_super__, selAddUserDecision_XHandle, decision__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (decision);
			return ret != 0;
		}
		[Export ("baseDecisionsInTimeRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CNDecision[] GetBaseDecisions (global::CoreMedia.CMTimeRange timeRange)
		{
			CNDecision[] ret;
			if (IsDirectBinding) {
				ret = CFArray.ArrayFromHandle<CNDecision>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_CMTimeRange (this.Handle, selBaseDecisionsInTimeRange_XHandle, timeRange), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFArray.ArrayFromHandle<CNDecision>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_CMTimeRange (&__objc_super__, selBaseDecisionsInTimeRange_XHandle, timeRange), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("changesTrimmedByTimeRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CNScriptChanges GetChangesTrimmed (global::CoreMedia.CMTimeRange timeRange)
		{
			CNScriptChanges ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<CNScriptChanges> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_CMTimeRange (this.Handle, selChangesTrimmedByTimeRange_XHandle, timeRange), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<CNScriptChanges> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_CMTimeRange (&__objc_super__, selChangesTrimmedByTimeRange_XHandle, timeRange), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("decisionAtTime:tolerance:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CNDecision? GetDecision (global::CoreMedia.CMTime time, global::CoreMedia.CMTime tolerance)
		{
			CNDecision ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<CNDecision> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_CMTime_CMTime (this.Handle, selDecisionAtTime_Tolerance_XHandle, time, tolerance), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<CNDecision> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_CMTime_CMTime (&__objc_super__, selDecisionAtTime_Tolerance_XHandle, time, tolerance), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("decisionAfterTime:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CNDecision? GetDecisionAfterTime (global::CoreMedia.CMTime time)
		{
			CNDecision ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<CNDecision> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_CMTime (this.Handle, selDecisionAfterTime_XHandle, time), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<CNDecision> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_CMTime (&__objc_super__, selDecisionAfterTime_XHandle, time), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("decisionBeforeTime:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CNDecision? GetDecisionBeforeTime (global::CoreMedia.CMTime time)
		{
			CNDecision ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<CNDecision> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_CMTime (this.Handle, selDecisionBeforeTime_XHandle, time), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<CNDecision> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_CMTime (&__objc_super__, selDecisionBeforeTime_XHandle, time), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("decisionsInTimeRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CNDecision[] GetDecisions (global::CoreMedia.CMTimeRange timeRange)
		{
			CNDecision[] ret;
			if (IsDirectBinding) {
				ret = CFArray.ArrayFromHandle<CNDecision>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_CMTimeRange (this.Handle, selDecisionsInTimeRange_XHandle, timeRange), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFArray.ArrayFromHandle<CNDecision>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_CMTimeRange (&__objc_super__, selDecisionsInTimeRange_XHandle, timeRange), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("detectionTrackForDecision:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CNDetectionTrack? GetDetectionTrack (CNDecision decision)
		{
			var decision__handle__ = decision!.GetNonNullHandle (nameof (decision));
			CNDetectionTrack? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<CNDetectionTrack> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selDetectionTrackForDecision_XHandle, decision__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<CNDetectionTrack> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selDetectionTrackForDecision_XHandle, decision__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (decision);
			return ret!;
		}
		[Export ("detectionTrackForID:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CNDetectionTrack? GetDetectionTrackForId (long detectionId)
		{
			CNDetectionTrack ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<CNDetectionTrack> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_Int64 (this.Handle, selDetectionTrackForID_XHandle, detectionId), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<CNDetectionTrack> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_Int64 (&__objc_super__, selDetectionTrackForID_XHandle, detectionId), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("frameAtTime:tolerance:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CNScriptFrame? GetFrame (global::CoreMedia.CMTime time, global::CoreMedia.CMTime tolerance)
		{
			CNScriptFrame ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<CNScriptFrame> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_CMTime_CMTime (this.Handle, selFrameAtTime_Tolerance_XHandle, time, tolerance), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<CNScriptFrame> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_CMTime_CMTime (&__objc_super__, selFrameAtTime_Tolerance_XHandle, time, tolerance), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("framesInTimeRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CNScriptFrame[] GetFrames (global::CoreMedia.CMTimeRange timeRange)
		{
			CNScriptFrame[] ret;
			if (IsDirectBinding) {
				ret = CFArray.ArrayFromHandle<CNScriptFrame>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_CMTimeRange (this.Handle, selFramesInTimeRange_XHandle, timeRange), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFArray.ArrayFromHandle<CNScriptFrame>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_CMTimeRange (&__objc_super__, selFramesInTimeRange_XHandle, timeRange), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("primaryDecisionAtTime:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CNDecision? GetPrimaryDecision (global::CoreMedia.CMTime time)
		{
			CNDecision ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<CNDecision> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_CMTime (this.Handle, selPrimaryDecisionAtTime_XHandle, time), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<CNDecision> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_CMTime (&__objc_super__, selPrimaryDecisionAtTime_XHandle, time), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("secondaryDecisionAtTime:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CNDecision? GetSecondaryDecision (global::CoreMedia.CMTime time)
		{
			CNDecision ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<CNDecision> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_CMTime (this.Handle, selSecondaryDecisionAtTime_XHandle, time), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<CNDecision> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_CMTime (&__objc_super__, selSecondaryDecisionAtTime_XHandle, time), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("timeRangeOfTransitionAfterDecision:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::CoreMedia.CMTimeRange GetTimeRangeOfTransitionAfterDecision (CNDecision decision)
		{
			var decision__handle__ = decision!.GetNonNullHandle (nameof (decision));
			global::CoreMedia.CMTimeRange ret;
			if (IsDirectBinding) {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					ret = global::ObjCRuntime.Messaging.CMTimeRange_objc_msgSend_NativeHandle (this.Handle, selTimeRangeOfTransitionAfterDecision_XHandle, decision__handle__);
				} else {
					ret = global::ObjCRuntime.Messaging.CMTimeRange_objc_msgSend_stret_NativeHandle (this.Handle, selTimeRangeOfTransitionAfterDecision_XHandle, decision__handle__);
				}
			} else {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CMTimeRange_objc_msgSendSuper_NativeHandle (&__objc_super__, selTimeRangeOfTransitionAfterDecision_XHandle, decision__handle__);
						GC.KeepAlive (this);
					}
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CMTimeRange_objc_msgSendSuper_stret_NativeHandle (&__objc_super__, selTimeRangeOfTransitionAfterDecision_XHandle, decision__handle__);
						GC.KeepAlive (this);
					}
				}
			}
			GC.KeepAlive (decision);
			return ret!;
		}
		[Export ("timeRangeOfTransitionBeforeDecision:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::CoreMedia.CMTimeRange GetTimeRangeOfTransitionBeforeDecision (CNDecision decision)
		{
			var decision__handle__ = decision!.GetNonNullHandle (nameof (decision));
			global::CoreMedia.CMTimeRange ret;
			if (IsDirectBinding) {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					ret = global::ObjCRuntime.Messaging.CMTimeRange_objc_msgSend_NativeHandle (this.Handle, selTimeRangeOfTransitionBeforeDecision_XHandle, decision__handle__);
				} else {
					ret = global::ObjCRuntime.Messaging.CMTimeRange_objc_msgSend_stret_NativeHandle (this.Handle, selTimeRangeOfTransitionBeforeDecision_XHandle, decision__handle__);
				}
			} else {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CMTimeRange_objc_msgSendSuper_NativeHandle (&__objc_super__, selTimeRangeOfTransitionBeforeDecision_XHandle, decision__handle__);
						GC.KeepAlive (this);
					}
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CMTimeRange_objc_msgSendSuper_stret_NativeHandle (&__objc_super__, selTimeRangeOfTransitionBeforeDecision_XHandle, decision__handle__);
						GC.KeepAlive (this);
					}
				}
			}
			GC.KeepAlive (decision);
			return ret!;
		}
		[Export ("userDecisionsInTimeRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CNDecision[] GetUserDecisions (global::CoreMedia.CMTimeRange timeRange)
		{
			CNDecision[] ret;
			if (IsDirectBinding) {
				ret = CFArray.ArrayFromHandle<CNDecision>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_CMTimeRange (this.Handle, selUserDecisionsInTimeRange_XHandle, timeRange), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFArray.ArrayFromHandle<CNDecision>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_CMTimeRange (&__objc_super__, selUserDecisionsInTimeRange_XHandle, timeRange), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("loadFromAsset:changes:progress:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void Load (global::AVFoundation.AVAsset asset, CNScriptChanges? changes, NSProgress? progress, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V36))]global::System.Action<CNScript, NSError> completionHandler)
		{
			var asset__handle__ = asset!.GetNonNullHandle (nameof (asset));
			var changes__handle__ = changes.GetHandle ();
			var progress__handle__ = progress.GetHandle ();
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity2V36.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (class_ptr, selLoadFromAsset_Changes_Progress_CompletionHandler_XHandle, asset__handle__, changes__handle__, progress__handle__, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (asset);
			GC.KeepAlive (changes);
			GC.KeepAlive (progress);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Task<CNScript> LoadAsync (global::AVFoundation.AVAsset asset, CNScriptChanges? changes, NSProgress? progress)
		{
			var tcs = new TaskCompletionSource<CNScript> ();
			Load(asset, changes, progress, (arg1_, arg2_) => {
				if (arg2_ is not null)
					tcs.SetException (new NSErrorException(arg2_));
				else
					tcs.SetResult (arg1_!);
			});
			return tcs.Task;
		}
		[Export ("reloadWithChanges:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Reload (CNScriptChanges? changes)
		{
			var changes__handle__ = changes.GetHandle ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selReloadWithChanges_XHandle, changes__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selReloadWithChanges_XHandle, changes__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (changes);
		}
		[Export ("removeAllUserDecisions")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemoveAllUserDecisions ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selRemoveAllUserDecisionsXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selRemoveAllUserDecisionsXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("removeDetectionTrack:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool RemoveDetectionTrack (CNDetectionTrack detectionTrack)
		{
			var detectionTrack__handle__ = detectionTrack!.GetNonNullHandle (nameof (detectionTrack));
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (this.Handle, selRemoveDetectionTrack_XHandle, detectionTrack__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle (&__objc_super__, selRemoveDetectionTrack_XHandle, detectionTrack__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (detectionTrack);
			return ret != 0;
		}
		[Export ("removeUserDecision:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool RemoveUserDecision (CNDecision decision)
		{
			var decision__handle__ = decision!.GetNonNullHandle (nameof (decision));
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (this.Handle, selRemoveUserDecision_XHandle, decision__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle (&__objc_super__, selRemoveUserDecision_XHandle, decision__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (decision);
			return ret != 0;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CNDetectionTrack[] AddedDetectionTracks {
			[Export ("addedDetectionTracks", ArgumentSemantic.Retain)]
			get {
				CNDetectionTrack[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<CNDetectionTrack>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selAddedDetectionTracksXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<CNDetectionTrack>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selAddedDetectionTracksXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CNScriptChanges Changes {
			[Export ("changes")]
			get {
				CNScriptChanges? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<CNScriptChanges> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selChangesXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<CNScriptChanges> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selChangesXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual float FNumber {
			[Export ("fNumber")]
			get {
				float ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selFNumberXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.float_objc_msgSendSuper (&__objc_super__, selFNumberXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setFNumber:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, selSetFNumber_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_float (&__objc_super__, selSetFNumber_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::CoreMedia.CMTimeRange TimeRange {
			[Export ("timeRange")]
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
		}
	} /* class CNScript */
}
