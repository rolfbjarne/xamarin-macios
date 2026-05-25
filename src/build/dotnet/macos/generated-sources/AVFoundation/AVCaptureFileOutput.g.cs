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
	/// <summary>A class that represents a file-based <see cref="T:AVFoundation.AVCaptureOutput" />. Application developers should use concrete subtypes <see cref="T:AVFoundation.AVCaptureMovieFileOutput" /> or <see cref="T:AVFoundation.AVCaptureAudioDataOutput" />.</summary><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/AVFoundation/Reference/AVCaptureFileOutput_Class/index.html">Apple documentation for <c>AVCaptureFileOutput</c></related>
	[Register("AVCaptureFileOutput", true)]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("tvos17.0")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	public unsafe partial class AVCaptureFileOutput : AVCaptureOutput {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDelegateX = "delegate";
		static readonly NativeHandle selDelegateXHandle = Selector.GetHandle ("delegate");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsRecordingX = "isRecording";
		static readonly NativeHandle selIsRecordingXHandle = Selector.GetHandle ("isRecording");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsRecordingPausedX = "isRecordingPaused";
		static readonly NativeHandle selIsRecordingPausedXHandle = Selector.GetHandle ("isRecordingPaused");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMaxRecordedDurationX = "maxRecordedDuration";
		static readonly NativeHandle selMaxRecordedDurationXHandle = Selector.GetHandle ("maxRecordedDuration");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMaxRecordedFileSizeX = "maxRecordedFileSize";
		static readonly NativeHandle selMaxRecordedFileSizeXHandle = Selector.GetHandle ("maxRecordedFileSize");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMinFreeDiskSpaceLimitX = "minFreeDiskSpaceLimit";
		static readonly NativeHandle selMinFreeDiskSpaceLimitXHandle = Selector.GetHandle ("minFreeDiskSpaceLimit");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selOutputFileURLX = "outputFileURL";
		static readonly NativeHandle selOutputFileURLXHandle = Selector.GetHandle ("outputFileURL");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPauseRecordingX = "pauseRecording";
		static readonly NativeHandle selPauseRecordingXHandle = Selector.GetHandle ("pauseRecording");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRecordedDurationX = "recordedDuration";
		static readonly NativeHandle selRecordedDurationXHandle = Selector.GetHandle ("recordedDuration");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRecordedFileSizeX = "recordedFileSize";
		static readonly NativeHandle selRecordedFileSizeXHandle = Selector.GetHandle ("recordedFileSize");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selResumeRecordingX = "resumeRecording";
		static readonly NativeHandle selResumeRecordingXHandle = Selector.GetHandle ("resumeRecording");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetDelegate_X = "setDelegate:";
		static readonly NativeHandle selSetDelegate_XHandle = Selector.GetHandle ("setDelegate:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetMaxRecordedDuration_X = "setMaxRecordedDuration:";
		static readonly NativeHandle selSetMaxRecordedDuration_XHandle = Selector.GetHandle ("setMaxRecordedDuration:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetMaxRecordedFileSize_X = "setMaxRecordedFileSize:";
		static readonly NativeHandle selSetMaxRecordedFileSize_XHandle = Selector.GetHandle ("setMaxRecordedFileSize:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetMinFreeDiskSpaceLimit_X = "setMinFreeDiskSpaceLimit:";
		static readonly NativeHandle selSetMinFreeDiskSpaceLimit_XHandle = Selector.GetHandle ("setMinFreeDiskSpaceLimit:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selStartRecordingToOutputFileURL_RecordingDelegate_X = "startRecordingToOutputFileURL:recordingDelegate:";
		static readonly NativeHandle selStartRecordingToOutputFileURL_RecordingDelegate_XHandle = Selector.GetHandle ("startRecordingToOutputFileURL:recordingDelegate:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selStopRecordingX = "stopRecording";
		static readonly NativeHandle selStopRecordingXHandle = Selector.GetHandle ("stopRecording");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("AVCaptureFileOutput");
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
		protected AVCaptureFileOutput (NSObjectFlag t) : base (t)
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
		protected internal AVCaptureFileOutput (NativeHandle handle) : base (handle)
		{
		}

		[Export ("pauseRecording")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PauseRecording ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selPauseRecordingXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selPauseRecordingXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("resumeRecording")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ResumeRecording ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selResumeRecordingXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selResumeRecordingXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("startRecordingToOutputFileURL:recordingDelegate:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void StartRecordingToOutputFile (NSUrl outputFileUrl, IAVCaptureFileOutputRecordingDelegate recordingDelegate)
		{
			var outputFileUrl__handle__ = outputFileUrl!.GetNonNullHandle (nameof (outputFileUrl));
			var recordingDelegate__handle__ = recordingDelegate!.GetNonNullHandle (nameof (recordingDelegate));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selStartRecordingToOutputFileURL_RecordingDelegate_XHandle, outputFileUrl__handle__, recordingDelegate__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selStartRecordingToOutputFileURL_RecordingDelegate_XHandle, outputFileUrl__handle__, recordingDelegate__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (outputFileUrl);
			GC.KeepAlive (recordingDelegate);
		}
		[Export ("stopRecording")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void StopRecording ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selStopRecordingXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selStopRecordingXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		object? __mt_Delegate_var;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public virtual IAVCaptureFileOutputDelegate? Delegate {
			[Export ("delegate", ArgumentSemantic.Assign)]
			get {
				IAVCaptureFileOutputDelegate? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetINativeObject<IAVCaptureFileOutputDelegate> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selDelegateXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetINativeObject<IAVCaptureFileOutputDelegate> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selDelegateXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				MarkDirty ();
				__mt_Delegate_var = ret;
				return ret!;
			}
			[Export ("setDelegate:", ArgumentSemantic.Assign)]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetDelegate_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetDelegate_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
				MarkDirty ();
				__mt_Delegate_var = value;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::CoreMedia.CMTime MaxRecordedDuration {
			[Export ("maxRecordedDuration")]
			get {
				global::CoreMedia.CMTime ret;
				if (IsDirectBinding) {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						ret = global::ObjCRuntime.Messaging.CMTime_objc_msgSend (this.Handle, selMaxRecordedDurationXHandle);
					} else {
						ret = global::ObjCRuntime.Messaging.CMTime_objc_msgSend_stret (this.Handle, selMaxRecordedDurationXHandle);
					}
				} else {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.CMTime_objc_msgSendSuper (&__objc_super__, selMaxRecordedDurationXHandle);
							GC.KeepAlive (this);
						}
					} else {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.CMTime_objc_msgSendSuper_stret (&__objc_super__, selMaxRecordedDurationXHandle);
							GC.KeepAlive (this);
						}
					}
				}
				return ret!;
			}
			[Export ("setMaxRecordedDuration:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_CMTime (this.Handle, selSetMaxRecordedDuration_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_CMTime (&__objc_super__, selSetMaxRecordedDuration_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual long MaxRecordedFileSize {
			[Export ("maxRecordedFileSize")]
			get {
				long ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.Int64_objc_msgSend (this.Handle, selMaxRecordedFileSizeXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.Int64_objc_msgSendSuper (&__objc_super__, selMaxRecordedFileSizeXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setMaxRecordedFileSize:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_Int64 (this.Handle, selSetMaxRecordedFileSize_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_Int64 (&__objc_super__, selSetMaxRecordedFileSize_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual long MinFreeDiskSpaceLimit {
			[Export ("minFreeDiskSpaceLimit")]
			get {
				long ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.Int64_objc_msgSend (this.Handle, selMinFreeDiskSpaceLimitXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.Int64_objc_msgSendSuper (&__objc_super__, selMinFreeDiskSpaceLimitXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setMinFreeDiskSpaceLimit:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_Int64 (this.Handle, selSetMinFreeDiskSpaceLimit_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_Int64 (&__objc_super__, selSetMinFreeDiskSpaceLimit_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSUrl? OutputFileURL {
			[Export ("outputFileURL")]
			get {
				NSUrl? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSUrl> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selOutputFileURLXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSUrl> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selOutputFileURLXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::CoreMedia.CMTime RecordedDuration {
			[Export ("recordedDuration")]
			get {
				global::CoreMedia.CMTime ret;
				if (IsDirectBinding) {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						ret = global::ObjCRuntime.Messaging.CMTime_objc_msgSend (this.Handle, selRecordedDurationXHandle);
					} else {
						ret = global::ObjCRuntime.Messaging.CMTime_objc_msgSend_stret (this.Handle, selRecordedDurationXHandle);
					}
				} else {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.CMTime_objc_msgSendSuper (&__objc_super__, selRecordedDurationXHandle);
							GC.KeepAlive (this);
						}
					} else {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.CMTime_objc_msgSendSuper_stret (&__objc_super__, selRecordedDurationXHandle);
							GC.KeepAlive (this);
						}
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual long RecordedFileSize {
			[Export ("recordedFileSize")]
			get {
				long ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.Int64_objc_msgSend (this.Handle, selRecordedFileSizeXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.Int64_objc_msgSendSuper (&__objc_super__, selRecordedFileSizeXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		/// <summary>Whether the system is currently recording captured data.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool Recording {
			[Export ("isRecording")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsRecordingXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsRecordingXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("macos")]
		public virtual bool RecordingPaused {
			[Export ("isRecordingPaused")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsRecordingPausedXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsRecordingPausedXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_Delegate_var = null;
			}
		}
	} /* class AVCaptureFileOutput */
}
