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
namespace Phase {
	[Register("PHASESoundEvent", true)]
	[SupportedOSPlatform ("tvos17.0")]
	[SupportedOSPlatform ("ios15.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	public unsafe partial class PhaseSoundEvent : NSObject {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithEngine_AssetIdentifier_Error_X = "initWithEngine:assetIdentifier:error:";
		static readonly NativeHandle selInitWithEngine_AssetIdentifier_Error_XHandle = Selector.GetHandle ("initWithEngine:assetIdentifier:error:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithEngine_AssetIdentifier_MixerParameters_Error_X = "initWithEngine:assetIdentifier:mixerParameters:error:";
		static readonly NativeHandle selInitWithEngine_AssetIdentifier_MixerParameters_Error_XHandle = Selector.GetHandle ("initWithEngine:assetIdentifier:mixerParameters:error:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsIndefiniteX = "isIndefinite";
		static readonly NativeHandle selIsIndefiniteXHandle = Selector.GetHandle ("isIndefinite");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMetaParametersX = "metaParameters";
		static readonly NativeHandle selMetaParametersXHandle = Selector.GetHandle ("metaParameters");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMixersX = "mixers";
		static readonly NativeHandle selMixersXHandle = Selector.GetHandle ("mixers");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPauseX = "pause";
		static readonly NativeHandle selPauseXHandle = Selector.GetHandle ("pause");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPrepareAndReturnError_X = "prepareAndReturnError:";
		static readonly NativeHandle selPrepareAndReturnError_XHandle = Selector.GetHandle ("prepareAndReturnError:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPrepareStateX = "prepareState";
		static readonly NativeHandle selPrepareStateXHandle = Selector.GetHandle ("prepareState");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPrepareWithCompletion_X = "prepareWithCompletion:";
		static readonly NativeHandle selPrepareWithCompletion_XHandle = Selector.GetHandle ("prepareWithCompletion:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPullStreamNodesX = "pullStreamNodes";
		static readonly NativeHandle selPullStreamNodesXHandle = Selector.GetHandle ("pullStreamNodes");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPushStreamNodesX = "pushStreamNodes";
		static readonly NativeHandle selPushStreamNodesXHandle = Selector.GetHandle ("pushStreamNodes");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRenderingStateX = "renderingState";
		static readonly NativeHandle selRenderingStateXHandle = Selector.GetHandle ("renderingState");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selResumeX = "resume";
		static readonly NativeHandle selResumeXHandle = Selector.GetHandle ("resume");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selResumeAtTime_X = "resumeAtTime:";
		static readonly NativeHandle selResumeAtTime_XHandle = Selector.GetHandle ("resumeAtTime:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSeekToTime_Completion_X = "seekToTime:completion:";
		static readonly NativeHandle selSeekToTime_Completion_XHandle = Selector.GetHandle ("seekToTime:completion:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSeekToTime_ResumeAtEngineTime_Completion_X = "seekToTime:resumeAtEngineTime:completion:";
		static readonly NativeHandle selSeekToTime_ResumeAtEngineTime_Completion_XHandle = Selector.GetHandle ("seekToTime:resumeAtEngineTime:completion:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selStartAndReturnError_X = "startAndReturnError:";
		static readonly NativeHandle selStartAndReturnError_XHandle = Selector.GetHandle ("startAndReturnError:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selStartAtTime_Completion_X = "startAtTime:completion:";
		static readonly NativeHandle selStartAtTime_Completion_XHandle = Selector.GetHandle ("startAtTime:completion:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selStartWithCompletion_X = "startWithCompletion:";
		static readonly NativeHandle selStartWithCompletion_XHandle = Selector.GetHandle ("startWithCompletion:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selStopAndInvalidateX = "stopAndInvalidate";
		static readonly NativeHandle selStopAndInvalidateXHandle = Selector.GetHandle ("stopAndInvalidate");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("PHASESoundEvent");
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
		protected PhaseSoundEvent (NSObjectFlag t) : base (t)
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
		protected internal PhaseSoundEvent (NativeHandle handle) : base (handle)
		{
		}

		[Export ("initWithEngine:assetIdentifier:mixerParameters:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe PhaseSoundEvent (PhaseEngine engine, string assetIdentifier, PhaseMixerParameters mixerParameters, out NSError? error)
			: base (NSObjectFlag.Empty)
		{
			var engine__handle__ = engine!.GetNonNullHandle (nameof (engine));
			if (assetIdentifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (assetIdentifier));
			var mixerParameters__handle__ = mixerParameters!.GetNonNullHandle (nameof (mixerParameters));
			NativeHandle errorValue = IntPtr.Zero;
			var nsassetIdentifier = CFString.CreateNative (assetIdentifier);
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_ref_NativeHandle (this.Handle, selInitWithEngine_AssetIdentifier_MixerParameters_Error_XHandle, engine__handle__, nsassetIdentifier, mixerParameters__handle__, &errorValue), "initWithEngine:assetIdentifier:mixerParameters:error:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle_ref_NativeHandle (&__objc_super__, selInitWithEngine_AssetIdentifier_MixerParameters_Error_XHandle, engine__handle__, nsassetIdentifier, mixerParameters__handle__, &errorValue), "initWithEngine:assetIdentifier:mixerParameters:error:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (engine);
			GC.KeepAlive (mixerParameters);
			CFString.ReleaseNative (nsassetIdentifier);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
		}
		[Export ("initWithEngine:assetIdentifier:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe PhaseSoundEvent (PhaseEngine engine, string assetIdentifier, out NSError? error)
			: base (NSObjectFlag.Empty)
		{
			var engine__handle__ = engine!.GetNonNullHandle (nameof (engine));
			if (assetIdentifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (assetIdentifier));
			NativeHandle errorValue = IntPtr.Zero;
			var nsassetIdentifier = CFString.CreateNative (assetIdentifier);
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_ref_NativeHandle (this.Handle, selInitWithEngine_AssetIdentifier_Error_XHandle, engine__handle__, nsassetIdentifier, &errorValue), "initWithEngine:assetIdentifier:error:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_ref_NativeHandle (&__objc_super__, selInitWithEngine_AssetIdentifier_Error_XHandle, engine__handle__, nsassetIdentifier, &errorValue), "initWithEngine:assetIdentifier:error:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (engine);
			CFString.ReleaseNative (nsassetIdentifier);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
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
		[Export ("prepareWithCompletion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void Prepare ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V99))]global::System.Action<PhaseSoundEventPrepareHandlerReason>? completionBlock)
		{
			using var block_completionBlock = Trampolines.SDActionArity1V99.CreateNullableBlock (completionBlock);
			BlockLiteral *block_ptr_completionBlock = null;
			if (completionBlock is not null)
				block_ptr_completionBlock = &block_completionBlock;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selPrepareWithCompletion_XHandle, (IntPtr) block_ptr_completionBlock);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selPrepareWithCompletion_XHandle, (IntPtr) block_ptr_completionBlock);
					GC.KeepAlive (this);
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<PhaseSoundEventPrepareHandlerReason> PrepareAsync ()
		{
			var tcs = new TaskCompletionSource<PhaseSoundEventPrepareHandlerReason> ();
			Prepare((obj_) => {
				tcs.SetResult (obj_!);
			});
			return tcs.Task;
		}
		[Export ("prepareAndReturnError:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual bool Prepare (out NSError? error)
		{
			NativeHandle errorValue = IntPtr.Zero;
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_ref_NativeHandle (this.Handle, selPrepareAndReturnError_XHandle, &errorValue);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_ref_NativeHandle (&__objc_super__, selPrepareAndReturnError_XHandle, &errorValue);
					GC.KeepAlive (this);
				}
			}
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret != 0;
		}
		[Export ("resume")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Resume ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selResumeXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selResumeXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("resumeAtTime:")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Resume (global::AVFoundation.AVAudioTime? time)
		{
			var time__handle__ = time.GetHandle ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selResumeAtTime_XHandle, time__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selResumeAtTime_XHandle, time__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (time);
		}
		[Export ("seekToTime:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual bool Seek (double time, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V100))]global::System.Action<PhaseSoundEventSeekHandlerReason>? completionHandler)
		{
			using var block_completionHandler = Trampolines.SDActionArity1V100.CreateNullableBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = null;
			if (completionHandler is not null)
				block_ptr_completionHandler = &block_completionHandler;
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_Double_NativeHandle (this.Handle, selSeekToTime_Completion_XHandle, time, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_Double_NativeHandle (&__objc_super__, selSeekToTime_Completion_XHandle, time, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
			return ret != 0;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<PhaseSoundEventSeekHandlerReason> SeekAsync (double time)
		{
			var tcs = new TaskCompletionSource<PhaseSoundEventSeekHandlerReason> ();
			Seek(time, (obj_) => {
				tcs.SetResult (obj_!);
			});
			return tcs.Task;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<PhaseSoundEventSeekHandlerReason> SeekAsync (double time, out bool result)
		{
			var tcs = new TaskCompletionSource<PhaseSoundEventSeekHandlerReason> ();
			result = Seek(time, (obj_) => {
				tcs.SetResult (obj_!);
			})!;
			return tcs.Task;
		}
		[Export ("seekToTime:resumeAtEngineTime:completion:")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void Seek (double time, global::AVFoundation.AVAudioTime engineTime, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V100))]global::System.Action<PhaseSoundEventSeekHandlerReason>? handler)
		{
			var engineTime__handle__ = engineTime!.GetNonNullHandle (nameof (engineTime));
			using var block_handler = Trampolines.SDActionArity1V100.CreateNullableBlock (handler);
			BlockLiteral *block_ptr_handler = null;
			if (handler is not null)
				block_ptr_handler = &block_handler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_Double_NativeHandle_NativeHandle (this.Handle, selSeekToTime_ResumeAtEngineTime_Completion_XHandle, time, engineTime__handle__, (IntPtr) block_ptr_handler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_Double_NativeHandle_NativeHandle (&__objc_super__, selSeekToTime_ResumeAtEngineTime_Completion_XHandle, time, engineTime__handle__, (IntPtr) block_ptr_handler);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (engineTime);
		}
		[Export ("startWithCompletion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual bool Start ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V101))]global::System.Action<PhaseSoundEventStartHandlerReason>? completionBlock)
		{
			using var block_completionBlock = Trampolines.SDActionArity1V101.CreateNullableBlock (completionBlock);
			BlockLiteral *block_ptr_completionBlock = null;
			if (completionBlock is not null)
				block_ptr_completionBlock = &block_completionBlock;
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (this.Handle, selStartWithCompletion_XHandle, (IntPtr) block_ptr_completionBlock);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle (&__objc_super__, selStartWithCompletion_XHandle, (IntPtr) block_ptr_completionBlock);
					GC.KeepAlive (this);
				}
			}
			return ret != 0;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<PhaseSoundEventStartHandlerReason> StartAsync ()
		{
			var tcs = new TaskCompletionSource<PhaseSoundEventStartHandlerReason> ();
			Start((obj_) => {
				tcs.SetResult (obj_!);
			});
			return tcs.Task;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<PhaseSoundEventStartHandlerReason> StartAsync (out bool result)
		{
			var tcs = new TaskCompletionSource<PhaseSoundEventStartHandlerReason> ();
			result = Start((obj_) => {
				tcs.SetResult (obj_!);
			})!;
			return tcs.Task;
		}
		[Export ("startAndReturnError:")]
		[Obsolete ("Use the other 'Start' overload instead, this doesn't exist.", false)]
		[EditorBrowsable (EditorBrowsableState.Never)]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual bool Start (out NSError? error)
		{
			NativeHandle errorValue = IntPtr.Zero;
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_ref_NativeHandle (this.Handle, selStartAndReturnError_XHandle, &errorValue);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_ref_NativeHandle (&__objc_super__, selStartAndReturnError_XHandle, &errorValue);
					GC.KeepAlive (this);
				}
			}
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret != 0;
		}
		[Export ("startAtTime:completion:")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void Start (global::AVFoundation.AVAudioTime? when, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V101))]global::System.Action<PhaseSoundEventStartHandlerReason>? handler)
		{
			var when__handle__ = when.GetHandle ();
			using var block_handler = Trampolines.SDActionArity1V101.CreateNullableBlock (handler);
			BlockLiteral *block_ptr_handler = null;
			if (handler is not null)
				block_ptr_handler = &block_handler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selStartAtTime_Completion_XHandle, when__handle__, (IntPtr) block_ptr_handler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selStartAtTime_Completion_XHandle, when__handle__, (IntPtr) block_ptr_handler);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (when);
		}
		[Export ("stopAndInvalidate")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void StopAndInvalidate ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selStopAndInvalidateXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selStopAndInvalidateXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool Indefinite {
			[Export ("isIndefinite")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsIndefiniteXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsIndefiniteXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDictionary<NSString, PhaseMetaParameter> MetaParameters {
			[Export ("metaParameters", ArgumentSemantic.Copy)]
			get {
				NSDictionary<NSString, PhaseMetaParameter>? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDictionary<NSString, PhaseMetaParameter>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selMetaParametersXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSDictionary<NSString, PhaseMetaParameter>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selMetaParametersXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDictionary<NSString, PhaseMixer> Mixers {
			[Export ("mixers", ArgumentSemantic.Copy)]
			get {
				NSDictionary<NSString, PhaseMixer>? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDictionary<NSString, PhaseMixer>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selMixersXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSDictionary<NSString, PhaseMixer>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selMixersXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual PhaseSoundEventPrepareState PrepareState {
			[Export ("prepareState")]
			get {
				PhaseSoundEventPrepareState ret;
				if (IsDirectBinding) {
					ret = (Phase.PhaseSoundEventPrepareState) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selPrepareStateXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (Phase.PhaseSoundEventPrepareState) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selPrepareStateXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		public virtual NSDictionary<NSString, PhasePullStreamNode> PullStreamNodes {
			[Export ("pullStreamNodes", ArgumentSemantic.Copy)]
			get {
				NSDictionary<NSString, PhasePullStreamNode>? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDictionary<NSString, PhasePullStreamNode>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selPullStreamNodesXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSDictionary<NSString, PhasePullStreamNode>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selPullStreamNodesXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDictionary<NSString, PhasePushStreamNode> PushStreamNodes {
			[Export ("pushStreamNodes", ArgumentSemantic.Copy)]
			get {
				NSDictionary<NSString, PhasePushStreamNode>? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDictionary<NSString, PhasePushStreamNode>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selPushStreamNodesXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSDictionary<NSString, PhasePushStreamNode>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selPushStreamNodesXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual PhaseRenderingState RenderingState {
			[Export ("renderingState")]
			get {
				PhaseRenderingState ret;
				if (IsDirectBinding) {
					ret = (Phase.PhaseRenderingState) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selRenderingStateXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (Phase.PhaseRenderingState) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selRenderingStateXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
	} /* class PhaseSoundEvent */
}
