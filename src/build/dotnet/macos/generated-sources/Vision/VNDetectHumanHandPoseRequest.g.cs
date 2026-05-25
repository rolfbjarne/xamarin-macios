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
namespace Vision {
	[Register("VNDetectHumanHandPoseRequest", true)]
	[SupportedOSPlatform ("tvos14.0")]
	[SupportedOSPlatform ("ios14.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	public unsafe partial class VNDetectHumanHandPoseRequest : VNImageBasedRequest {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCurrentRevisionX = "currentRevision";
		static readonly NativeHandle selCurrentRevisionXHandle = Selector.GetHandle ("currentRevision");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDefaultRevisionX = "defaultRevision";
		static readonly NativeHandle selDefaultRevisionXHandle = Selector.GetHandle ("defaultRevision");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithCompletionHandler_X = "initWithCompletionHandler:";
		static readonly NativeHandle selInitWithCompletionHandler_XHandle = Selector.GetHandle ("initWithCompletionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMaximumHandCountX = "maximumHandCount";
		static readonly NativeHandle selMaximumHandCountXHandle = Selector.GetHandle ("maximumHandCount");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selResultsX = "results";
		static readonly NativeHandle selResultsXHandle = Selector.GetHandle ("results");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRevisionX = "revision";
		static readonly NativeHandle selRevisionXHandle = Selector.GetHandle ("revision");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetMaximumHandCount_X = "setMaximumHandCount:";
		static readonly NativeHandle selSetMaximumHandCount_XHandle = Selector.GetHandle ("setMaximumHandCount:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetRevision_X = "setRevision:";
		static readonly NativeHandle selSetRevision_XHandle = Selector.GetHandle ("setRevision:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSupportedJointNamesAndReturnError_X = "supportedJointNamesAndReturnError:";
		static readonly NativeHandle selSupportedJointNamesAndReturnError_XHandle = Selector.GetHandle ("supportedJointNamesAndReturnError:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSupportedJointNamesForRevision_Error_X = "supportedJointNamesForRevision:error:";
		static readonly NativeHandle selSupportedJointNamesForRevision_Error_XHandle = Selector.GetHandle ("supportedJointNamesForRevision:error:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSupportedJointsGroupNamesAndReturnError_X = "supportedJointsGroupNamesAndReturnError:";
		static readonly NativeHandle selSupportedJointsGroupNamesAndReturnError_XHandle = Selector.GetHandle ("supportedJointsGroupNamesAndReturnError:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSupportedJointsGroupNamesForRevision_Error_X = "supportedJointsGroupNamesForRevision:error:";
		static readonly NativeHandle selSupportedJointsGroupNamesForRevision_Error_XHandle = Selector.GetHandle ("supportedJointsGroupNamesForRevision:error:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSupportedRevisionsX = "supportedRevisions";
		static readonly NativeHandle selSupportedRevisionsXHandle = Selector.GetHandle ("supportedRevisions");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("VNDetectHumanHandPoseRequest");
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
		protected VNDetectHumanHandPoseRequest (NSObjectFlag t) : base (t)
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
		protected internal VNDetectHumanHandPoseRequest (NativeHandle handle) : base (handle)
		{
		}

		[Export ("initWithCompletionHandler:")]
		[DesignatedInitializer]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe VNDetectHumanHandPoseRequest ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDVNRequestCompletionHandler))]VNRequestCompletionHandler? completionHandler)
			: base (NSObjectFlag.Empty)
		{
			using var block_completionHandler = Trampolines.SDVNRequestCompletionHandler.CreateNullableBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = null;
			if (completionHandler is not null)
				block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selInitWithCompletionHandler_XHandle, (IntPtr) block_ptr_completionHandler), "initWithCompletionHandler:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selInitWithCompletionHandler_XHandle, (IntPtr) block_ptr_completionHandler), "initWithCompletionHandler:");
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("supportedJointNamesForRevision:error:")]
		[ObsoletedOSPlatform ("macos14.0")]
		[ObsoletedOSPlatform ("ios17.0")]
		[ObsoletedOSPlatform ("maccatalyst17.0")]
		[ObsoletedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[return: BindAs (typeof (VNHumanHandPoseObservationJointName[]), OriginalType = typeof (NSString[]))]
		public unsafe static global::Vision.VNHumanHandPoseObservationJointName[]? GetSupportedJointNames (VNDetectHumanHandPoseRequestRevision revision, out NSError? error)
		{
			NativeHandle errorValue = IntPtr.Zero;
			global::Vision.VNHumanHandPoseObservationJointName[] ret;
			ret = NSArray.ArrayFromHandleFunc <global::Vision.VNHumanHandPoseObservationJointName> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UIntPtr_ref_NativeHandle (class_ptr, selSupportedJointNamesForRevision_Error_XHandle, (UIntPtr) (ulong) revision, &errorValue), global::Vision.VNHumanHandPoseObservationJointNameExtensions.GetValue , false)!;
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		[Export ("supportedJointNamesAndReturnError:")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[return: BindAs (typeof (VNHumanHandPoseObservationJointName[]), OriginalType = typeof (NSString[]))]
		public unsafe virtual global::Vision.VNHumanHandPoseObservationJointName[]? GetSupportedJointNames (out NSError? error)
		{
			NativeHandle errorValue = IntPtr.Zero;
			global::Vision.VNHumanHandPoseObservationJointName[] ret;
			if (IsDirectBinding) {
				ret = NSArray.ArrayFromHandleFunc <global::Vision.VNHumanHandPoseObservationJointName> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_ref_NativeHandle (this.Handle, selSupportedJointNamesAndReturnError_XHandle, &errorValue), global::Vision.VNHumanHandPoseObservationJointNameExtensions.GetValue , false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = NSArray.ArrayFromHandleFunc <global::Vision.VNHumanHandPoseObservationJointName> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_ref_NativeHandle (&__objc_super__, selSupportedJointNamesAndReturnError_XHandle, &errorValue), global::Vision.VNHumanHandPoseObservationJointNameExtensions.GetValue , false)!;
					GC.KeepAlive (this);
				}
			}
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		[Export ("supportedJointsGroupNamesForRevision:error:")]
		[ObsoletedOSPlatform ("macos14.0")]
		[ObsoletedOSPlatform ("ios17.0")]
		[ObsoletedOSPlatform ("maccatalyst17.0")]
		[ObsoletedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[return: BindAs (typeof (VNHumanHandPoseObservationJointsGroupName[]), OriginalType = typeof (NSString[]))]
		public unsafe static global::Vision.VNHumanHandPoseObservationJointsGroupName[]? GetSupportedJointsGroupNames (VNDetectHumanHandPoseRequestRevision revision, out NSError? error)
		{
			NativeHandle errorValue = IntPtr.Zero;
			global::Vision.VNHumanHandPoseObservationJointsGroupName[] ret;
			ret = NSArray.ArrayFromHandleFunc <global::Vision.VNHumanHandPoseObservationJointsGroupName> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UIntPtr_ref_NativeHandle (class_ptr, selSupportedJointsGroupNamesForRevision_Error_XHandle, (UIntPtr) (ulong) revision, &errorValue), global::Vision.VNHumanHandPoseObservationJointsGroupNameExtensions.GetValue , false)!;
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		[Export ("supportedJointsGroupNamesAndReturnError:")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[return: BindAs (typeof (VNHumanHandPoseObservationJointsGroupName[]), OriginalType = typeof (NSString[]))]
		public unsafe virtual global::Vision.VNHumanHandPoseObservationJointsGroupName[]? GetSupportedJointsGroupNames (out NSError? error)
		{
			NativeHandle errorValue = IntPtr.Zero;
			global::Vision.VNHumanHandPoseObservationJointsGroupName[] ret;
			if (IsDirectBinding) {
				ret = NSArray.ArrayFromHandleFunc <global::Vision.VNHumanHandPoseObservationJointsGroupName> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_ref_NativeHandle (this.Handle, selSupportedJointsGroupNamesAndReturnError_XHandle, &errorValue), global::Vision.VNHumanHandPoseObservationJointsGroupNameExtensions.GetValue , false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = NSArray.ArrayFromHandleFunc <global::Vision.VNHumanHandPoseObservationJointsGroupName> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_ref_NativeHandle (&__objc_super__, selSupportedJointsGroupNamesAndReturnError_XHandle, &errorValue), global::Vision.VNHumanHandPoseObservationJointsGroupNameExtensions.GetValue , false)!;
					GC.KeepAlive (this);
				}
			}
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static VNDetectHumanHandPoseRequestRevision CurrentRevision {
			[Export ("currentRevision")]
			get {
				VNDetectHumanHandPoseRequestRevision ret;
				ret = (Vision.VNDetectHumanHandPoseRequestRevision) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (class_ptr, selCurrentRevisionXHandle);
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static VNDetectHumanHandPoseRequestRevision DefaultRevision {
			[Export ("defaultRevision")]
			get {
				VNDetectHumanHandPoseRequestRevision ret;
				ret = (Vision.VNDetectHumanHandPoseRequestRevision) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (class_ptr, selDefaultRevisionXHandle);
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nuint MaximumHandCount {
			[Export ("maximumHandCount")]
			get {
				nuint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selMaximumHandCountXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selMaximumHandCountXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setMaximumHandCount:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (this.Handle, selSetMaximumHandCount_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UIntPtr (&__objc_super__, selSetMaximumHandCount_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual VNHumanHandPoseObservation[]? Results {
			[Export ("results", ArgumentSemantic.Copy)]
			get {
				VNHumanHandPoseObservation[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<VNHumanHandPoseObservation>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selResultsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<VNHumanHandPoseObservation>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selResultsXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual VNDetectHumanHandPoseRequestRevision Revision {
			[Export ("revision")]
			get {
				VNDetectHumanHandPoseRequestRevision ret;
				if (IsDirectBinding) {
					ret = (Vision.VNDetectHumanHandPoseRequestRevision) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selRevisionXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (Vision.VNDetectHumanHandPoseRequestRevision) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selRevisionXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setRevision:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (this.Handle, selSetRevision_XHandle, (UIntPtr) (ulong) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UIntPtr (&__objc_super__, selSetRevision_XHandle, (UIntPtr) (ulong) value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static VNDetectHumanHandPoseRequestRevision[] SupportedRevisions {
			get {
				return (GetSupportedVersions<VNDetectHumanHandPoseRequestRevision> (WeakSupportedRevisions) as VNDetectHumanHandPoseRequestRevision[])!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSIndexSet WeakSupportedRevisions {
			[Export ("supportedRevisions", ArgumentSemantic.Copy)]
			get {
				NSIndexSet? ret;
				ret =  Runtime.GetNSObject<NSIndexSet> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selSupportedRevisionsXHandle), false)!;
				return ret!;
			}
		}
	} /* class VNDetectHumanHandPoseRequest */
}
