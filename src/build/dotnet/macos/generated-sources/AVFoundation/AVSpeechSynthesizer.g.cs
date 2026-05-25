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
	[Register("AVSpeechSynthesizer", true)]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe partial class AVSpeechSynthesizer : NSObject {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selContinueSpeakingX = "continueSpeaking";
		static readonly NativeHandle selContinueSpeakingXHandle = Selector.GetHandle ("continueSpeaking");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDelegateX = "delegate";
		static readonly NativeHandle selDelegateXHandle = Selector.GetHandle ("delegate");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsPausedX = "isPaused";
		static readonly NativeHandle selIsPausedXHandle = Selector.GetHandle ("isPaused");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsSpeakingX = "isSpeaking";
		static readonly NativeHandle selIsSpeakingXHandle = Selector.GetHandle ("isSpeaking");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPauseSpeakingAtBoundary_X = "pauseSpeakingAtBoundary:";
		static readonly NativeHandle selPauseSpeakingAtBoundary_XHandle = Selector.GetHandle ("pauseSpeakingAtBoundary:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPersonalVoiceAuthorizationStatusX = "personalVoiceAuthorizationStatus";
		static readonly NativeHandle selPersonalVoiceAuthorizationStatusXHandle = Selector.GetHandle ("personalVoiceAuthorizationStatus");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRequestPersonalVoiceAuthorizationWithCompletionHandler_X = "requestPersonalVoiceAuthorizationWithCompletionHandler:";
		static readonly NativeHandle selRequestPersonalVoiceAuthorizationWithCompletionHandler_XHandle = Selector.GetHandle ("requestPersonalVoiceAuthorizationWithCompletionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetDelegate_X = "setDelegate:";
		static readonly NativeHandle selSetDelegate_XHandle = Selector.GetHandle ("setDelegate:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetUsesApplicationAudioSession_X = "setUsesApplicationAudioSession:";
		static readonly NativeHandle selSetUsesApplicationAudioSession_XHandle = Selector.GetHandle ("setUsesApplicationAudioSession:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSpeakUtterance_X = "speakUtterance:";
		static readonly NativeHandle selSpeakUtterance_XHandle = Selector.GetHandle ("speakUtterance:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selStopSpeakingAtBoundary_X = "stopSpeakingAtBoundary:";
		static readonly NativeHandle selStopSpeakingAtBoundary_XHandle = Selector.GetHandle ("stopSpeakingAtBoundary:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selUsesApplicationAudioSessionX = "usesApplicationAudioSession";
		static readonly NativeHandle selUsesApplicationAudioSessionXHandle = Selector.GetHandle ("usesApplicationAudioSession");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selWriteUtterance_ToBufferCallback_X = "writeUtterance:toBufferCallback:";
		static readonly NativeHandle selWriteUtterance_ToBufferCallback_XHandle = Selector.GetHandle ("writeUtterance:toBufferCallback:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selWriteUtterance_ToBufferCallback_ToMarkerCallback_X = "writeUtterance:toBufferCallback:toMarkerCallback:";
		static readonly NativeHandle selWriteUtterance_ToBufferCallback_ToMarkerCallback_XHandle = Selector.GetHandle ("writeUtterance:toBufferCallback:toMarkerCallback:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("AVSpeechSynthesizer");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		/// <summary>Creates a new <see cref="AVSpeechSynthesizer" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public AVSpeechSynthesizer () : base (NSObjectFlag.Empty)
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
		protected AVSpeechSynthesizer (NSObjectFlag t) : base (t)
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
		protected internal AVSpeechSynthesizer (NativeHandle handle) : base (handle)
		{
		}

		/// <summary>Restarts a paused utterance.</summary><returns><see langword="true" /> if synthesis restarted successfully.</returns><remarks>To be added.</remarks>
		[Export ("continueSpeaking")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ContinueSpeaking ()
		{
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selContinueSpeakingXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selContinueSpeakingXHandle);
					GC.KeepAlive (this);
				}
			}
			return ret != 0;
		}
		/// <param name="boundary">Whether to stop immediately or to complete the current word.</param><summary>Instructs speech synthesis to pause at the <paramref name="boundary" />.</summary><returns><see langword="true" /> if synthesis was paused successfully.</returns><remarks>To be added.</remarks>
		[Export ("pauseSpeakingAtBoundary:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool PauseSpeaking (AVSpeechBoundary boundary)
		{
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_IntPtr (this.Handle, selPauseSpeakingAtBoundary_XHandle, (IntPtr) (long) boundary);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_IntPtr (&__objc_super__, selPauseSpeakingAtBoundary_XHandle, (IntPtr) (long) boundary);
					GC.KeepAlive (this);
				}
			}
			return ret != 0;
		}
		[Export ("requestPersonalVoiceAuthorizationWithCompletionHandler:")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void RequestPersonalVoiceAuthorization ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAVSpeechSynthesizerRequestPersonalVoiceAuthorizationCallback))]AVSpeechSynthesizerRequestPersonalVoiceAuthorizationCallback handler)
		{
			if (handler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (handler));
			using var block_handler = Trampolines.SDAVSpeechSynthesizerRequestPersonalVoiceAuthorizationCallback.CreateBlock (handler);
			BlockLiteral *block_ptr_handler = &block_handler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (class_ptr, selRequestPersonalVoiceAuthorizationWithCompletionHandler_XHandle, (IntPtr) block_ptr_handler);
		}
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Task<AVSpeechSynthesisPersonalVoiceAuthorizationStatus> RequestPersonalVoiceAuthorizationAsync ()
		{
			var tcs = new TaskCompletionSource<AVSpeechSynthesisPersonalVoiceAuthorizationStatus> ();
			RequestPersonalVoiceAuthorization((status_) => {
				tcs.SetResult (status_!);
			});
			return tcs.Task;
		}
		/// <param name="utterance">To be added.</param><summary>Begins synthesizing speech for, or enqueues for synthesis, the <paramref name="utterance" />.</summary><remarks>To be added.</remarks>
		[Export ("speakUtterance:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SpeakUtterance (AVSpeechUtterance utterance)
		{
			var utterance__handle__ = utterance!.GetNonNullHandle (nameof (utterance));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSpeakUtterance_XHandle, utterance__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSpeakUtterance_XHandle, utterance__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (utterance);
		}
		/// <param name="boundary">To be added.</param><summary>Stops speech playback, either immediately or after the current word.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("stopSpeakingAtBoundary:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool StopSpeaking (AVSpeechBoundary boundary)
		{
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_IntPtr (this.Handle, selStopSpeakingAtBoundary_XHandle, (IntPtr) (long) boundary);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_IntPtr (&__objc_super__, selStopSpeakingAtBoundary_XHandle, (IntPtr) (long) boundary);
					GC.KeepAlive (this);
				}
			}
			return ret != 0;
		}
		[Export ("writeUtterance:toBufferCallback:")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void WriteUtterance (AVSpeechUtterance utterance, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V10))]global::System.Action<AVAudioBuffer> bufferCallback)
		{
			var utterance__handle__ = utterance!.GetNonNullHandle (nameof (utterance));
			if (bufferCallback is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (bufferCallback));
			using var block_bufferCallback = Trampolines.SDActionArity1V10.CreateBlock (bufferCallback);
			BlockLiteral *block_ptr_bufferCallback = &block_bufferCallback;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selWriteUtterance_ToBufferCallback_XHandle, utterance__handle__, (IntPtr) block_ptr_bufferCallback);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selWriteUtterance_ToBufferCallback_XHandle, utterance__handle__, (IntPtr) block_ptr_bufferCallback);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (utterance);
		}
		[Export ("writeUtterance:toBufferCallback:toMarkerCallback:")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void WriteUtterance (AVSpeechUtterance utterance, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAVSpeechSynthesizerBufferCallback))]AVSpeechSynthesizerBufferCallback bufferCallback, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAVSpeechSynthesizerMarkerCallback))]AVSpeechSynthesizerMarkerCallback markerCallback)
		{
			var utterance__handle__ = utterance!.GetNonNullHandle (nameof (utterance));
			if (bufferCallback is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (bufferCallback));
			if (markerCallback is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (markerCallback));
			using var block_bufferCallback = Trampolines.SDAVSpeechSynthesizerBufferCallback.CreateBlock (bufferCallback);
			BlockLiteral *block_ptr_bufferCallback = &block_bufferCallback;
			using var block_markerCallback = Trampolines.SDAVSpeechSynthesizerMarkerCallback.CreateBlock (markerCallback);
			BlockLiteral *block_ptr_markerCallback = &block_markerCallback;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, selWriteUtterance_ToBufferCallback_ToMarkerCallback_XHandle, utterance__handle__, (IntPtr) block_ptr_bufferCallback, (IntPtr) block_ptr_markerCallback);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, selWriteUtterance_ToBufferCallback_ToMarkerCallback_XHandle, utterance__handle__, (IntPtr) block_ptr_bufferCallback, (IntPtr) block_ptr_markerCallback);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (utterance);
		}
		/// <summary>An instance of the AVFoundation.IAVSpeechSynthesizerDelegate model class which acts as the class delegate.</summary><value>The instance of the AVFoundation.IAVSpeechSynthesizerDelegate model class</value><remarks><para>The delegate instance assigned to this object will be used to handle events or provide data on demand to this class.</para><para>When setting the Delegate or WeakDelegate values events will be delivered to the specified instance instead of being delivered to the C#-style events</para><para>This is the strongly typed version of the object, developers should use the WeakDelegate property instead if they want to merely assign a class derived from NSObject that has been decorated with [Export] attributes.</para></remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public IAVSpeechSynthesizerDelegate? Delegate {
			get {
				return (WeakDelegate as IAVSpeechSynthesizerDelegate)!;
			}
			set {
				var rvalue = value as NSObject;
				if (!(value is null) && rvalue is null)
					throw new ArgumentException ("The object passed of type " + value.GetType () + " does not derive from NSObject");
				WeakDelegate = rvalue;
			}
		}
		/// <summary>Whether text-to-speech is currently paused.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool Paused {
			[Export ("isPaused")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsPausedXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsPausedXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		public static AVSpeechSynthesisPersonalVoiceAuthorizationStatus PersonalVoiceAuthorizationStatus {
			[Export ("personalVoiceAuthorizationStatus")]
			get {
				AVSpeechSynthesisPersonalVoiceAuthorizationStatus ret;
				ret = (AVSpeechSynthesisPersonalVoiceAuthorizationStatus) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (class_ptr, selPersonalVoiceAuthorizationStatusXHandle);
				return ret!;
			}
		}
		/// <summary>Whether the synthesizer is currently speaking, or has utterances queued. Ignores <see cref="P:AVFoundation.AVSpeechSynthesizer.Paused" /></summary><value>To be added.</value><remarks><para>Even if <see cref="P:AVFoundation.AVSpeechSynthesizer.Paused" /> is <see langword="true" />, this method will return <see langword="true" /> if the <see cref="T:AVFoundation.AVSpeechSynthesizer" /> contains unfinished or enqueued <see cref="T:AVFoundation.AVSpeechUtterance" />s.</para></remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool Speaking {
			[Export ("isSpeaking")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsSpeakingXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsSpeakingXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public virtual bool UsesApplicationAudioSession {
			[Export ("usesApplicationAudioSession")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selUsesApplicationAudioSessionXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selUsesApplicationAudioSessionXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setUsesApplicationAudioSession:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetUsesApplicationAudioSession_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetUsesApplicationAudioSession_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		object? __mt_WeakDelegate_var;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject? WeakDelegate {
			[Export ("delegate", ArgumentSemantic.Assign)]
			get {
				NSObject? ret;
				if (IsDirectBinding) {
					ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selDelegateXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selDelegateXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				MarkDirty ();
				__mt_WeakDelegate_var = ret;
				return ret!;
			}
			[Export ("setDelegate:", ArgumentSemantic.Assign)]
			set {
				NSApplication.EnsureDelegateAssignIsNotOverwritingInternalDelegate (__mt_WeakDelegate_var, value, GetInternalEventDelegateType);
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
				__mt_WeakDelegate_var = value;
			}
		}
		//
		// Events and properties from the delegate
		//
		internal virtual Type GetInternalEventDelegateType
		{
			get { return typeof (_AVSpeechSynthesizerDelegate); }
		}
		internal virtual _AVSpeechSynthesizerDelegate CreateInternalEventDelegateType ()
		{
			return (_AVSpeechSynthesizerDelegate)(new _AVSpeechSynthesizerDelegate());
		}
		internal _AVSpeechSynthesizerDelegate EnsureAVSpeechSynthesizerDelegate ()
		{
			if (WeakDelegate is not null)
				NSApplication.EnsureEventAndDelegateAreNotMismatched (WeakDelegate, GetInternalEventDelegateType);
			var del = Delegate as _AVSpeechSynthesizerDelegate;
			if (del is null){
				del = (_AVSpeechSynthesizerDelegate)CreateInternalEventDelegateType ();
				Delegate = (IAVSpeechSynthesizerDelegate)del;
			}
			return del;
		}
		#pragma warning disable 672
		[Register]
		internal class _AVSpeechSynthesizerDelegate : NSObject, IAVSpeechSynthesizerDelegate { 
			public _AVSpeechSynthesizerDelegate () { IsDirectBinding = false; }
			[DynamicDependency (DynamicallyAccessedMemberTypes.PublicMethods, typeof (_AVSpeechSynthesizerDelegate))]
			static _AVSpeechSynthesizerDelegate ()
			{
				GC.KeepAlive (null);
			}
			internal EventHandler<AVSpeechSynthesizerUteranceEventArgs>? didCancelSpeechUtterance;
			[Export ("speechSynthesizer:didCancelSpeechUtterance:")]
			public void DidCancelSpeechUtterance (AVSpeechSynthesizer synthesizer, AVSpeechUtterance utterance)
			{
				var handler = didCancelSpeechUtterance;
				if (handler is not null){
					var args = new AVSpeechSynthesizerUteranceEventArgs (utterance);
					handler (synthesizer, args);
				}
			}
			internal EventHandler<AVSpeechSynthesizerUteranceEventArgs>? didContinueSpeechUtterance;
			[Export ("speechSynthesizer:didContinueSpeechUtterance:")]
			public void DidContinueSpeechUtterance (AVSpeechSynthesizer synthesizer, AVSpeechUtterance utterance)
			{
				var handler = didContinueSpeechUtterance;
				if (handler is not null){
					var args = new AVSpeechSynthesizerUteranceEventArgs (utterance);
					handler (synthesizer, args);
				}
			}
			internal EventHandler<AVSpeechSynthesizerUteranceEventArgs>? didFinishSpeechUtterance;
			[Export ("speechSynthesizer:didFinishSpeechUtterance:")]
			public void DidFinishSpeechUtterance (AVSpeechSynthesizer synthesizer, AVSpeechUtterance utterance)
			{
				var handler = didFinishSpeechUtterance;
				if (handler is not null){
					var args = new AVSpeechSynthesizerUteranceEventArgs (utterance);
					handler (synthesizer, args);
				}
			}
			internal EventHandler<AVSpeechSynthesizerUteranceEventArgs>? didPauseSpeechUtterance;
			[Export ("speechSynthesizer:didPauseSpeechUtterance:")]
			public void DidPauseSpeechUtterance (AVSpeechSynthesizer synthesizer, AVSpeechUtterance utterance)
			{
				var handler = didPauseSpeechUtterance;
				if (handler is not null){
					var args = new AVSpeechSynthesizerUteranceEventArgs (utterance);
					handler (synthesizer, args);
				}
			}
			internal EventHandler<AVSpeechSynthesizerUteranceEventArgs>? didStartSpeechUtterance;
			[Export ("speechSynthesizer:didStartSpeechUtterance:")]
			public void DidStartSpeechUtterance (AVSpeechSynthesizer synthesizer, AVSpeechUtterance utterance)
			{
				var handler = didStartSpeechUtterance;
				if (handler is not null){
					var args = new AVSpeechSynthesizerUteranceEventArgs (utterance);
					handler (synthesizer, args);
				}
			}
			internal EventHandler<AVSpeechSynthesizerWillSpeakMarkerEventArgs>? willSpeakMarker;
			[Export ("speechSynthesizer:willSpeakMarker:utterance:")]
			public void WillSpeakMarker (AVSpeechSynthesizer synthesizer, AVSpeechSynthesisMarker marker, AVSpeechUtterance utterance)
			{
				var handler = willSpeakMarker;
				if (handler is not null){
					var args = new AVSpeechSynthesizerWillSpeakMarkerEventArgs (marker, utterance);
					handler (synthesizer, args);
				}
			}
			internal EventHandler<AVSpeechSynthesizerWillSpeakEventArgs>? willSpeakRangeOfSpeechString;
			[Export ("speechSynthesizer:willSpeakRangeOfSpeechString:utterance:")]
			public void WillSpeakRangeOfSpeechString (AVSpeechSynthesizer synthesizer, NSRange characterRange, AVSpeechUtterance utterance)
			{
				var handler = willSpeakRangeOfSpeechString;
				if (handler is not null){
					var args = new AVSpeechSynthesizerWillSpeakEventArgs (characterRange, utterance);
					handler (synthesizer, args);
				}
			}
		}
		#pragma warning restore 672
		public event EventHandler<AVSpeechSynthesizerUteranceEventArgs> DidCancelSpeechUtterance {
			add { EnsureAVSpeechSynthesizerDelegate ()!.didCancelSpeechUtterance += value; }
			remove { EnsureAVSpeechSynthesizerDelegate ()!.didCancelSpeechUtterance -= value; }
		}
		public event EventHandler<AVSpeechSynthesizerUteranceEventArgs> DidContinueSpeechUtterance {
			add { EnsureAVSpeechSynthesizerDelegate ()!.didContinueSpeechUtterance += value; }
			remove { EnsureAVSpeechSynthesizerDelegate ()!.didContinueSpeechUtterance -= value; }
		}
		public event EventHandler<AVSpeechSynthesizerUteranceEventArgs> DidFinishSpeechUtterance {
			add { EnsureAVSpeechSynthesizerDelegate ()!.didFinishSpeechUtterance += value; }
			remove { EnsureAVSpeechSynthesizerDelegate ()!.didFinishSpeechUtterance -= value; }
		}
		public event EventHandler<AVSpeechSynthesizerUteranceEventArgs> DidPauseSpeechUtterance {
			add { EnsureAVSpeechSynthesizerDelegate ()!.didPauseSpeechUtterance += value; }
			remove { EnsureAVSpeechSynthesizerDelegate ()!.didPauseSpeechUtterance -= value; }
		}
		public event EventHandler<AVSpeechSynthesizerUteranceEventArgs> DidStartSpeechUtterance {
			add { EnsureAVSpeechSynthesizerDelegate ()!.didStartSpeechUtterance += value; }
			remove { EnsureAVSpeechSynthesizerDelegate ()!.didStartSpeechUtterance -= value; }
		}
		public event EventHandler<AVSpeechSynthesizerWillSpeakMarkerEventArgs> WillSpeakMarker {
			add { EnsureAVSpeechSynthesizerDelegate ()!.willSpeakMarker += value; }
			remove { EnsureAVSpeechSynthesizerDelegate ()!.willSpeakMarker -= value; }
		}
		public event EventHandler<AVSpeechSynthesizerWillSpeakEventArgs> WillSpeakRangeOfSpeechString {
			add { EnsureAVSpeechSynthesizerDelegate ()!.willSpeakRangeOfSpeechString += value; }
			remove { EnsureAVSpeechSynthesizerDelegate ()!.willSpeakRangeOfSpeechString -= value; }
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_WeakDelegate_var = null;
			}
		}
	} /* class AVSpeechSynthesizer */
	//
	// EventArgs classes
	//
	/// <summary>Provides data for an event based on an Objective-C protocol method.</summary>
	public partial class AVSpeechSynthesizerUteranceEventArgs : EventArgs {
		/// <summary>Create a new instance of the <see cref="AVSpeechSynthesizerUteranceEventArgs" /> with the specified event data.</summary>
		/// <param name="utterance">The value for the <see cref="Utterance" /> property.</param>
		public AVSpeechSynthesizerUteranceEventArgs (AVSpeechUtterance utterance)
		{
			this.Utterance = utterance;
		}
		public AVSpeechUtterance Utterance { get; set; }
	}
	/// <summary>Provides data for an event based on an Objective-C protocol method.</summary>
	public partial class AVSpeechSynthesizerWillSpeakEventArgs : EventArgs {
		/// <summary>Create a new instance of the <see cref="AVSpeechSynthesizerWillSpeakEventArgs" /> with the specified event data.</summary>
		/// <param name="characterRange">The value for the <see cref="CharacterRange" /> property.</param>
		/// <param name="utterance">The value for the <see cref="Utterance" /> property.</param>
		public AVSpeechSynthesizerWillSpeakEventArgs (NSRange characterRange, AVSpeechUtterance utterance)
		{
			this.CharacterRange = characterRange;
			this.Utterance = utterance;
		}
		public NSRange CharacterRange { get; set; }
		public AVSpeechUtterance Utterance { get; set; }
	}
	/// <summary>Provides data for an event based on an Objective-C protocol method.</summary>
	public partial class AVSpeechSynthesizerWillSpeakMarkerEventArgs : EventArgs {
		/// <summary>Create a new instance of the <see cref="AVSpeechSynthesizerWillSpeakMarkerEventArgs" /> with the specified event data.</summary>
		/// <param name="marker">The value for the <see cref="Marker" /> property.</param>
		/// <param name="utterance">The value for the <see cref="Utterance" /> property.</param>
		public AVSpeechSynthesizerWillSpeakMarkerEventArgs (AVSpeechSynthesisMarker marker, AVSpeechUtterance utterance)
		{
			this.Marker = marker;
			this.Utterance = utterance;
		}
		public AVSpeechSynthesisMarker Marker { get; set; }
		public AVSpeechUtterance Utterance { get; set; }
	}
}
