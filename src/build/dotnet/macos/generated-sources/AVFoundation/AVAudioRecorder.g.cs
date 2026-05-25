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
	/// <summary>Audio recording class.</summary><remarks><para>
	/// 	To create instances of this class use the factory method <see cref="Create(Foundation.NSUrl,AudioSettings,out Foundation.NSError)" /></para><example><code lang="csharp lang-csharp"><![CDATA[
	/// var settings = new AudioSettings () {
	/// 	AudioFormat = AudioFormatType.LinearPCM,
	/// 	AudioQuality = AVAudioQuality.High,
	/// 	SampleRate = 44100f,
	/// 	NumberChannels = 1,
	/// };
	/// var recorder = AVAudioRecorder.Create (url, settings, out error);
	/// if (recorder == null) {
	/// Console.WriteLine (error);
	/// return;
	/// }
	/// recorder.PrepareToRecord ();
	/// recorder.Record ();
	/// ]]></code></example></remarks><related type="externalDocumentation" href="https://developer.apple.com/documentation/avfaudio/avaudiorecorder">Apple documentation for <c>AVAudioRecorder</c></related>
	[Register("AVAudioRecorder", true)]
	[SupportedOSPlatform ("tvos17.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	public unsafe partial class AVAudioRecorder : NSObject {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAveragePowerForChannel_X = "averagePowerForChannel:";
		static readonly NativeHandle selAveragePowerForChannel_XHandle = Selector.GetHandle ("averagePowerForChannel:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCurrentTimeX = "currentTime";
		static readonly NativeHandle selCurrentTimeXHandle = Selector.GetHandle ("currentTime");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDelegateX = "delegate";
		static readonly NativeHandle selDelegateXHandle = Selector.GetHandle ("delegate");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDeleteRecordingX = "deleteRecording";
		static readonly NativeHandle selDeleteRecordingXHandle = Selector.GetHandle ("deleteRecording");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDeviceCurrentTimeX = "deviceCurrentTime";
		static readonly NativeHandle selDeviceCurrentTimeXHandle = Selector.GetHandle ("deviceCurrentTime");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFormatX = "format";
		static readonly NativeHandle selFormatXHandle = Selector.GetHandle ("format");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithURL_Format_Error_X = "initWithURL:format:error:";
		static readonly NativeHandle selInitWithURL_Format_Error_XHandle = Selector.GetHandle ("initWithURL:format:error:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithURL_Settings_Error_X = "initWithURL:settings:error:";
		static readonly NativeHandle selInitWithURL_Settings_Error_XHandle = Selector.GetHandle ("initWithURL:settings:error:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsMeteringEnabledX = "isMeteringEnabled";
		static readonly NativeHandle selIsMeteringEnabledXHandle = Selector.GetHandle ("isMeteringEnabled");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsRecordingX = "isRecording";
		static readonly NativeHandle selIsRecordingXHandle = Selector.GetHandle ("isRecording");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPauseX = "pause";
		static readonly NativeHandle selPauseXHandle = Selector.GetHandle ("pause");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPeakPowerForChannel_X = "peakPowerForChannel:";
		static readonly NativeHandle selPeakPowerForChannel_XHandle = Selector.GetHandle ("peakPowerForChannel:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPrepareToRecordX = "prepareToRecord";
		static readonly NativeHandle selPrepareToRecordXHandle = Selector.GetHandle ("prepareToRecord");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRecordX = "record";
		static readonly NativeHandle selRecordXHandle = Selector.GetHandle ("record");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRecordAtTime_X = "recordAtTime:";
		static readonly NativeHandle selRecordAtTime_XHandle = Selector.GetHandle ("recordAtTime:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRecordAtTime_ForDuration_X = "recordAtTime:forDuration:";
		static readonly NativeHandle selRecordAtTime_ForDuration_XHandle = Selector.GetHandle ("recordAtTime:forDuration:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRecordForDuration_X = "recordForDuration:";
		static readonly NativeHandle selRecordForDuration_XHandle = Selector.GetHandle ("recordForDuration:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetDelegate_X = "setDelegate:";
		static readonly NativeHandle selSetDelegate_XHandle = Selector.GetHandle ("setDelegate:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetMeteringEnabled_X = "setMeteringEnabled:";
		static readonly NativeHandle selSetMeteringEnabled_XHandle = Selector.GetHandle ("setMeteringEnabled:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSettingsX = "settings";
		static readonly NativeHandle selSettingsXHandle = Selector.GetHandle ("settings");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selStopX = "stop";
		static readonly NativeHandle selStopXHandle = Selector.GetHandle ("stop");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selUpdateMetersX = "updateMeters";
		static readonly NativeHandle selUpdateMetersXHandle = Selector.GetHandle ("updateMeters");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selUrlX = "url";
		static readonly NativeHandle selUrlXHandle = Selector.GetHandle ("url");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("AVAudioRecorder");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		/// <summary>Creates a new <see cref="AVAudioRecorder" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public AVAudioRecorder () : base (NSObjectFlag.Empty)
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
		protected AVAudioRecorder (NSObjectFlag t) : base (t)
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
		protected internal AVAudioRecorder (NativeHandle handle) : base (handle)
		{
		}

		/// <param name="channelNumber">To be added.</param><summary>The average power for the <paramref name="channelNumber" /> channel, in decibels, of the sound being recorded.</summary><returns>To be added.</returns><remarks><para>Application developers must call <see cref="M:AVFoundation.AVAudioRecorder.UpdateMeters" /> prior to reading this value.</para></remarks>
		[Export ("averagePowerForChannel:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual float AveragePower (nuint channelNumber)
		{
			float ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.float_objc_msgSend_UIntPtr (this.Handle, selAveragePowerForChannel_XHandle, channelNumber);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.float_objc_msgSendSuper_UIntPtr (&__objc_super__, selAveragePowerForChannel_XHandle, channelNumber);
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		/// <summary>Delete's the current recording.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("deleteRecording")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool DeleteRecording ()
		{
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selDeleteRecordingXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selDeleteRecordingXHandle);
					GC.KeepAlive (this);
				}
			}
			return ret != 0;
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
		/// <param name="channelNumber">To be added.</param><summary>The peak power, in decibels, of the specified channel.</summary><returns>To be added.</returns><remarks><para>Application developers must call <see cref="M:AVFoundation.AVAudioPlayer.UpdateMeters" /> prior to reading this value.</para></remarks><altmember cref="M:AVFoundation.AVAudioPlayer.AveragePower(System.UIntPtr)" />
		[Export ("peakPowerForChannel:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual float PeakPower (nuint channelNumber)
		{
			float ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.float_objc_msgSend_UIntPtr (this.Handle, selPeakPowerForChannel_XHandle, channelNumber);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.float_objc_msgSendSuper_UIntPtr (&__objc_super__, selPeakPowerForChannel_XHandle, channelNumber);
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		/// <summary>Prepares the recorder for efficient startup.</summary><returns>To be added.</returns><remarks><para>This method creates or erases a file for recording.</para><para>The <see cref="M:AVFoundation.AVAudioRecorder.Record" /> method will call this method if necessary, but application developers may choose to explicitly call it in order to minimize startup lag.</para></remarks>
		[Export ("prepareToRecord")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool PrepareToRecord ()
		{
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selPrepareToRecordXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selPrepareToRecordXHandle);
					GC.KeepAlive (this);
				}
			}
			return ret != 0;
		}
		/// <summary>Begins recording. This method is asynchronous.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("record")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool Record ()
		{
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selRecordXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selRecordXHandle);
					GC.KeepAlive (this);
				}
			}
			return ret != 0;
		}
		/// <param name="time">A value greater than or equal to <see cref="P:AVFoundation.AVAudioRecorder.currentTime" />. Specifies a time in seconds.</param><summary>Begins recording at a specific time.</summary><returns>To be added.</returns><remarks>Begins recording at a specific time.  Can be used for exactly periodic recordings or recordings that occur with precise offsets to each other.</remarks>
		[Export ("recordAtTime:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool RecordAt (double time)
		{
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_Double (this.Handle, selRecordAtTime_XHandle, time);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_Double (&__objc_super__, selRecordAtTime_XHandle, time);
					GC.KeepAlive (this);
				}
			}
			return ret != 0;
		}
		/// <param name="time">A value greater than or equal to <see cref="P:AVFoundation.AVAudioRecorder.currentTime" />. Specifies a time in seconds.</param><param name="duration">Duration, in seconds, of the recording.</param><summary>Begins recording at a specific time, with a given duration.</summary><returns>To be added.</returns><remarks><para>The recording will automatically stop after <paramref name="duration" /> seconds.</para></remarks>
		[Export ("recordAtTime:forDuration:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool RecordAt (double time, double duration)
		{
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_Double_Double (this.Handle, selRecordAtTime_ForDuration_XHandle, time, duration);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_Double_Double (&__objc_super__, selRecordAtTime_ForDuration_XHandle, time, duration);
					GC.KeepAlive (this);
				}
			}
			return ret != 0;
		}
		/// <param name="duration">The number of seconds to record.</param><summary>Begins recording for a specific duration.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("recordForDuration:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool RecordFor (double duration)
		{
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_Double (this.Handle, selRecordForDuration_XHandle, duration);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_Double (&__objc_super__, selRecordForDuration_XHandle, duration);
					GC.KeepAlive (this);
				}
			}
			return ret != 0;
		}
		/// <summary>Stops recording asynchronously.</summary><remarks>To be added.</remarks>
		[Export ("stop")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Stop ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selStopXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selStopXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		/// <summary>Calculates the <see cref="M:AVFoundation.AVAudioRecorder.AveragePower(System.UIntPtr)" /> and <see cref="M:AVFoundation.AVAudioRecorder.PeakPower(System.UIntPtr)" /> properties.</summary><remarks><para>The <see cref="P:AVFoundation.AVAudioRecorder.MeteringEnabled" /> property must be <see langword="true" /> for this method to operate correctly.</para></remarks>
		[Export ("updateMeters")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void UpdateMeters ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selUpdateMetersXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selUpdateMetersXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("initWithURL:settings:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe virtual nint _InitWithUrl (NSUrl url, NSDictionary settings, out NSError error)
		{
			var url__handle__ = url!.GetNonNullHandle (nameof (url));
			var settings__handle__ = settings!.GetNonNullHandle (nameof (settings));
			NativeHandle errorValue = IntPtr.Zero;
			nint ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_NativeHandle_NativeHandle_ref_NativeHandle (this.Handle, selInitWithURL_Settings_Error_XHandle, url__handle__, settings__handle__, &errorValue);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_NativeHandle_NativeHandle_ref_NativeHandle (&__objc_super__, selInitWithURL_Settings_Error_XHandle, url__handle__, settings__handle__, &errorValue);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (url);
			GC.KeepAlive (settings);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		[Export ("initWithURL:format:error:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe virtual nint _InitWithUrl (NSUrl url, AVAudioFormat format, out NSError outError)
		{
			var url__handle__ = url!.GetNonNullHandle (nameof (url));
			var format__handle__ = format!.GetNonNullHandle (nameof (format));
			NativeHandle outErrorValue = IntPtr.Zero;
			nint ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_NativeHandle_NativeHandle_ref_NativeHandle (this.Handle, selInitWithURL_Format_Error_XHandle, url__handle__, format__handle__, &outErrorValue);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_NativeHandle_NativeHandle_ref_NativeHandle (&__objc_super__, selInitWithURL_Format_Error_XHandle, url__handle__, format__handle__, &outErrorValue);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (url);
			GC.KeepAlive (format);
			outError = Runtime.GetNSObject<NSError> (outErrorValue)!;
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual double CurrentTime {
			[Export ("currentTime")]
			get {
				double ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.Double_objc_msgSend (this.Handle, selCurrentTimeXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.Double_objc_msgSendSuper (&__objc_super__, selCurrentTimeXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		/// <summary>An instance of the AVFoundation.IAVAudioRecorderDelegate model class which acts as the class delegate.</summary><value>The instance of the AVFoundation.IAVAudioRecorderDelegate model class</value><remarks><para>The delegate instance assigned to this object will be used to handle events or provide data on demand to this class.</para><para>When setting the Delegate or WeakDelegate values events will be delivered to the specified instance instead of being delivered to the C#-style events</para><para>This is the strongly typed version of the object, developers should use the WeakDelegate property instead if they want to merely assign a class derived from NSObject that has been decorated with [Export] attributes.</para></remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public IAVAudioRecorderDelegate? Delegate {
			get {
				return (WeakDelegate as IAVAudioRecorderDelegate)!;
			}
			set {
				var rvalue = value as NSObject;
				if (!(value is null) && rvalue is null)
					throw new ArgumentException ("The object passed of type " + value.GetType () + " does not derive from NSObject");
				WeakDelegate = rvalue;
			}
		}
		/// <summary>A value that increases while the <see cref="T:AVFoundation.AVAudioRecorder" /> is recording or paused. May be used for synchronizing multiple recorders.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos17.0")]
		public virtual double DeviceCurrentTime {
			[Export ("deviceCurrentTime")]
			get {
				double ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.Double_objc_msgSend (this.Handle, selDeviceCurrentTimeXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.Double_objc_msgSendSuper (&__objc_super__, selDeviceCurrentTimeXHandle);
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
		[SupportedOSPlatform ("tvos17.0")]
		public virtual AVAudioFormat Format {
			[Export ("format")]
			get {
				AVAudioFormat? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<AVAudioFormat> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selFormatXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<AVAudioFormat> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selFormatXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		/// <summary>Whether audio-level metering can be used with the <see cref="T:AVFoundation.AVAudioRecorder" />.</summary><value>To be added.</value><remarks>To be added.</remarks><altmember cref="M:AVFoundation.AVAudioRecorder.UpdateMeters" />
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool MeteringEnabled {
			[Export ("isMeteringEnabled")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsMeteringEnabledXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsMeteringEnabledXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setMeteringEnabled:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetMeteringEnabled_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetMeteringEnabled_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>Whether the <see cref="T:AVFoundation.AVAudioRecorder" /> is currently recording.</summary><value><see langword="true" /> if the <see cref="T:AVFoundation.AVAudioRecorder" /> is currently recording.</value><remarks>To be added.</remarks>
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
		/// <summary>The audio recording settings being used.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public AudioSettings Settings {
			get {
				var src = WeakSettings is not null ? new NSMutableDictionary (WeakSettings) : null;
				return src is null ? null! : new AudioSettings(src);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSUrl Url {
			[Export ("url")]
			get {
				NSUrl? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSUrl> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selUrlXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSUrl> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selUrlXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
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
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDictionary WeakSettings {
			[Export ("settings")]
			get {
				NSDictionary? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDictionary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selSettingsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSDictionary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selSettingsXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		/// <summary>The current location, in seconds, of the recording insertion point.</summary><value>To be added.</value><remarks>To be added.</remarks><altmember cref="P:AVFoundation.AVAudioRecorder.DeviceCurrentTime" />
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Obsolete ("Use the 'CurrentTime' property instead.", false)]
		[EditorBrowsable (EditorBrowsableState.Never)]
		public virtual double currentTime {
			get {
				return (double) (CurrentTime);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_WeakDelegate_var = null;
			}
		}
	} /* class AVAudioRecorder */
}
