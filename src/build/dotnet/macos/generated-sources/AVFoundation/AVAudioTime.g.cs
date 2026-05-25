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
	/// <summary>Immutable time representation used by <see cref="T:AVFoundation.AVAudioEngine" /> objects.</summary><remarks>To be added.</remarks><related type="externalDocumentation" href="https://developer.apple.com/documentation/avfaudio/avaudiotime">Apple documentation for <c>AVAudioTime</c></related>
	[Register("AVAudioTime", true)]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe partial class AVAudioTime : NSObject {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAudioTimeStampX = "audioTimeStamp";
		static readonly NativeHandle selAudioTimeStampXHandle = Selector.GetHandle ("audioTimeStamp");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selExtrapolateTimeFromAnchor_X = "extrapolateTimeFromAnchor:";
		static readonly NativeHandle selExtrapolateTimeFromAnchor_XHandle = Selector.GetHandle ("extrapolateTimeFromAnchor:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selHostTimeX = "hostTime";
		static readonly NativeHandle selHostTimeXHandle = Selector.GetHandle ("hostTime");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selHostTimeForSeconds_X = "hostTimeForSeconds:";
		static readonly NativeHandle selHostTimeForSeconds_XHandle = Selector.GetHandle ("hostTimeForSeconds:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithAudioTimeStamp_SampleRate_X = "initWithAudioTimeStamp:sampleRate:";
		static readonly NativeHandle selInitWithAudioTimeStamp_SampleRate_XHandle = Selector.GetHandle ("initWithAudioTimeStamp:sampleRate:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithHostTime_X = "initWithHostTime:";
		static readonly NativeHandle selInitWithHostTime_XHandle = Selector.GetHandle ("initWithHostTime:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithHostTime_SampleTime_AtRate_X = "initWithHostTime:sampleTime:atRate:";
		static readonly NativeHandle selInitWithHostTime_SampleTime_AtRate_XHandle = Selector.GetHandle ("initWithHostTime:sampleTime:atRate:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithSampleTime_AtRate_X = "initWithSampleTime:atRate:";
		static readonly NativeHandle selInitWithSampleTime_AtRate_XHandle = Selector.GetHandle ("initWithSampleTime:atRate:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsHostTimeValidX = "isHostTimeValid";
		static readonly NativeHandle selIsHostTimeValidXHandle = Selector.GetHandle ("isHostTimeValid");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsSampleTimeValidX = "isSampleTimeValid";
		static readonly NativeHandle selIsSampleTimeValidXHandle = Selector.GetHandle ("isSampleTimeValid");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSampleRateX = "sampleRate";
		static readonly NativeHandle selSampleRateXHandle = Selector.GetHandle ("sampleRate");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSampleTimeX = "sampleTime";
		static readonly NativeHandle selSampleTimeXHandle = Selector.GetHandle ("sampleTime");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSecondsForHostTime_X = "secondsForHostTime:";
		static readonly NativeHandle selSecondsForHostTime_XHandle = Selector.GetHandle ("secondsForHostTime:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTimeWithAudioTimeStamp_SampleRate_X = "timeWithAudioTimeStamp:sampleRate:";
		static readonly NativeHandle selTimeWithAudioTimeStamp_SampleRate_XHandle = Selector.GetHandle ("timeWithAudioTimeStamp:sampleRate:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTimeWithHostTime_X = "timeWithHostTime:";
		static readonly NativeHandle selTimeWithHostTime_XHandle = Selector.GetHandle ("timeWithHostTime:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTimeWithHostTime_SampleTime_AtRate_X = "timeWithHostTime:sampleTime:atRate:";
		static readonly NativeHandle selTimeWithHostTime_SampleTime_AtRate_XHandle = Selector.GetHandle ("timeWithHostTime:sampleTime:atRate:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTimeWithSampleTime_AtRate_X = "timeWithSampleTime:atRate:";
		static readonly NativeHandle selTimeWithSampleTime_AtRate_XHandle = Selector.GetHandle ("timeWithSampleTime:atRate:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("AVAudioTime");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		/// <summary>Creates a new <see cref="AVAudioTime" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public AVAudioTime () : base (NSObjectFlag.Empty)
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
		protected AVAudioTime (NSObjectFlag t) : base (t)
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
		protected internal AVAudioTime (NativeHandle handle) : base (handle)
		{
		}

		/// <param name="timestamp">To be added.</param><param name="sampleRate">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("initWithAudioTimeStamp:sampleRate:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe AVAudioTime (ref global::AudioToolbox.AudioTimeStamp timestamp, double sampleRate)
			: base (NSObjectFlag.Empty)
		{
			fixed (global::AudioToolbox.AudioTimeStamp* timestamp__pointer = &timestamp) {
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_ref_AudioTimeStamp_Double (this.Handle, selInitWithAudioTimeStamp_SampleRate_XHandle, timestamp__pointer, sampleRate), "initWithAudioTimeStamp:sampleRate:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_ref_AudioTimeStamp_Double (&__objc_super__, selInitWithAudioTimeStamp_SampleRate_XHandle, timestamp__pointer, sampleRate), "initWithAudioTimeStamp:sampleRate:");
					GC.KeepAlive (this);
				}
			}
			}
		}
		/// <param name="hostTime">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("initWithHostTime:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public AVAudioTime (ulong hostTime)
			: base (NSObjectFlag.Empty)
		{
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UInt64 (this.Handle, selInitWithHostTime_XHandle, hostTime), "initWithHostTime:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_UInt64 (&__objc_super__, selInitWithHostTime_XHandle, hostTime), "initWithHostTime:");
					GC.KeepAlive (this);
				}
			}
		}
		/// <param name="sampleTime">To be added.</param><param name="sampleRate">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("initWithSampleTime:atRate:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public AVAudioTime (long sampleTime, double sampleRate)
			: base (NSObjectFlag.Empty)
		{
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_Int64_Double (this.Handle, selInitWithSampleTime_AtRate_XHandle, sampleTime, sampleRate), "initWithSampleTime:atRate:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_Int64_Double (&__objc_super__, selInitWithSampleTime_AtRate_XHandle, sampleTime, sampleRate), "initWithSampleTime:atRate:");
					GC.KeepAlive (this);
				}
			}
		}
		/// <param name="hostTime">To be added.</param><param name="sampleTime">To be added.</param><param name="sampleRate">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("initWithHostTime:sampleTime:atRate:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public AVAudioTime (ulong hostTime, long sampleTime, double sampleRate)
			: base (NSObjectFlag.Empty)
		{
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UInt64_Int64_Double (this.Handle, selInitWithHostTime_SampleTime_AtRate_XHandle, hostTime, sampleTime, sampleRate), "initWithHostTime:sampleTime:atRate:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_UInt64_Int64_Double (&__objc_super__, selInitWithHostTime_SampleTime_AtRate_XHandle, hostTime, sampleTime, sampleRate), "initWithHostTime:sampleTime:atRate:");
					GC.KeepAlive (this);
				}
			}
		}
		/// <param name="anchorTime">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("extrapolateTimeFromAnchor:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual AVAudioTime? ExtrapolateTimeFromAnchor (AVAudioTime anchorTime)
		{
			var anchorTime__handle__ = anchorTime!.GetNonNullHandle (nameof (anchorTime));
			AVAudioTime? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<AVAudioTime> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selExtrapolateTimeFromAnchor_XHandle, anchorTime__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<AVAudioTime> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selExtrapolateTimeFromAnchor_XHandle, anchorTime__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (anchorTime);
			return ret!;
		}
		/// <param name="timestamp">To be added.</param><param name="sampleRate">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("timeWithAudioTimeStamp:sampleRate:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static AVAudioTime FromAudioTimeStamp (ref global::AudioToolbox.AudioTimeStamp timestamp, double sampleRate)
		{
			fixed (global::AudioToolbox.AudioTimeStamp* timestamp__pointer = &timestamp) {
			AVAudioTime ret;
			ret =  Runtime.GetNSObject<AVAudioTime> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_ref_AudioTimeStamp_Double (class_ptr, selTimeWithAudioTimeStamp_SampleRate_XHandle, timestamp__pointer, sampleRate), false)!;
			return ret;
			}
		}
		/// <param name="hostTime">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("timeWithHostTime:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static AVAudioTime FromHostTime (ulong hostTime)
		{
			AVAudioTime ret;
			ret =  Runtime.GetNSObject<AVAudioTime> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UInt64 (class_ptr, selTimeWithHostTime_XHandle, hostTime), false)!;
			return ret;
		}
		/// <param name="hostTime">To be added.</param><param name="sampleTime">To be added.</param><param name="sampleRate">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("timeWithHostTime:sampleTime:atRate:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static AVAudioTime FromHostTime (ulong hostTime, long sampleTime, double sampleRate)
		{
			AVAudioTime ret;
			ret =  Runtime.GetNSObject<AVAudioTime> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UInt64_Int64_Double (class_ptr, selTimeWithHostTime_SampleTime_AtRate_XHandle, hostTime, sampleTime, sampleRate), false)!;
			return ret;
		}
		/// <param name="sampleTime">To be added.</param><param name="sampleRate">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("timeWithSampleTime:atRate:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static AVAudioTime FromSampleTime (long sampleTime, double sampleRate)
		{
			AVAudioTime ret;
			ret =  Runtime.GetNSObject<AVAudioTime> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_Int64_Double (class_ptr, selTimeWithSampleTime_AtRate_XHandle, sampleTime, sampleRate), false)!;
			return ret;
		}
		/// <param name="seconds">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("hostTimeForSeconds:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static ulong HostTimeForSeconds (double seconds)
		{
			ulong ret;
			ret = global::ObjCRuntime.Messaging.UInt64_objc_msgSend_Double (class_ptr, selHostTimeForSeconds_XHandle, seconds);
			return ret;
		}
		/// <param name="hostTime">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("secondsForHostTime:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static double SecondsForHostTime (ulong hostTime)
		{
			double ret;
			ret = global::ObjCRuntime.Messaging.Double_objc_msgSend_UInt64 (class_ptr, selSecondsForHostTime_XHandle, hostTime);
			return ret;
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::AudioToolbox.AudioTimeStamp AudioTimeStamp {
			[Export ("audioTimeStamp")]
			get {
				global::AudioToolbox.AudioTimeStamp ret;
				if (IsDirectBinding) {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						ret = global::ObjCRuntime.Messaging.AudioTimeStamp_objc_msgSend (this.Handle, selAudioTimeStampXHandle);
					} else {
						ret = global::ObjCRuntime.Messaging.AudioTimeStamp_objc_msgSend_stret (this.Handle, selAudioTimeStampXHandle);
					}
				} else {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.AudioTimeStamp_objc_msgSendSuper (&__objc_super__, selAudioTimeStampXHandle);
							GC.KeepAlive (this);
						}
					} else {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.AudioTimeStamp_objc_msgSendSuper_stret (&__objc_super__, selAudioTimeStampXHandle);
							GC.KeepAlive (this);
						}
					}
				}
				return ret!;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual ulong HostTime {
			[Export ("hostTime")]
			get {
				ulong ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.UInt64_objc_msgSend (this.Handle, selHostTimeXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.UInt64_objc_msgSendSuper (&__objc_super__, selHostTimeXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		/// <summary>Gets whether <see cref="P:AVFoundation.AVAudioTime.HostTime" /> is valid.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool HostTimeValid {
			[Export ("isHostTimeValid")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsHostTimeValidXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsHostTimeValidXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		/// <summary>The sample rate at which <see cref="P:AVFoundation.AVAudioTime.SampleTime" /> is expressed.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual double SampleRate {
			[Export ("sampleRate")]
			get {
				double ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.Double_objc_msgSend (this.Handle, selSampleRateXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.Double_objc_msgSendSuper (&__objc_super__, selSampleRateXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		/// <summary>The time, as a number of audio samples.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual long SampleTime {
			[Export ("sampleTime")]
			get {
				long ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.Int64_objc_msgSend (this.Handle, selSampleTimeXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.Int64_objc_msgSendSuper (&__objc_super__, selSampleTimeXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		/// <summary>Gets whether <see cref="P:AVFoundation.AVAudioTime.SampleTime" /> is valid.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool SampleTimeValid {
			[Export ("isSampleTimeValid")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsSampleTimeValidXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsSampleTimeValidXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
	} /* class AVAudioTime */
}
