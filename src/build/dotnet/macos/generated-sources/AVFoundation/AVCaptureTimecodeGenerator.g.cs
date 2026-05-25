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
	[Register("AVCaptureTimecodeGenerator", true)]
	[SupportedOSPlatform ("tvos26.0")]
	[SupportedOSPlatform ("maccatalyst26.0")]
	[SupportedOSPlatform ("macos26.0")]
	[SupportedOSPlatform ("ios26.0")]
	public unsafe partial class AVCaptureTimecodeGenerator : NSObject {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAvailableSourcesX = "availableSources";
		static readonly NativeHandle selAvailableSourcesXHandle = Selector.GetHandle ("availableSources");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCurrentSourceX = "currentSource";
		static readonly NativeHandle selCurrentSourceXHandle = Selector.GetHandle ("currentSource");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDelegateX = "delegate";
		static readonly NativeHandle selDelegateXHandle = Selector.GetHandle ("delegate");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDelegateCallbackQueueX = "delegateCallbackQueue";
		static readonly NativeHandle selDelegateCallbackQueueXHandle = Selector.GetHandle ("delegateCallbackQueue");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFrameCountSourceX = "frameCountSource";
		static readonly NativeHandle selFrameCountSourceXHandle = Selector.GetHandle ("frameCountSource");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selGenerateInitialTimecodeX = "generateInitialTimecode";
		static readonly NativeHandle selGenerateInitialTimecodeXHandle = Selector.GetHandle ("generateInitialTimecode");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRealTimeClockSourceX = "realTimeClockSource";
		static readonly NativeHandle selRealTimeClockSourceXHandle = Selector.GetHandle ("realTimeClockSource");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetDelegate_Queue_X = "setDelegate:queue:";
		static readonly NativeHandle selSetDelegate_Queue_XHandle = Selector.GetHandle ("setDelegate:queue:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetSynchronizationTimeout_X = "setSynchronizationTimeout:";
		static readonly NativeHandle selSetSynchronizationTimeout_XHandle = Selector.GetHandle ("setSynchronizationTimeout:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetTimecodeAlignmentOffset_X = "setTimecodeAlignmentOffset:";
		static readonly NativeHandle selSetTimecodeAlignmentOffset_XHandle = Selector.GetHandle ("setTimecodeAlignmentOffset:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetTimecodeFrameDuration_X = "setTimecodeFrameDuration:";
		static readonly NativeHandle selSetTimecodeFrameDuration_XHandle = Selector.GetHandle ("setTimecodeFrameDuration:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selStartSynchronizationWithTimecodeSource_X = "startSynchronizationWithTimecodeSource:";
		static readonly NativeHandle selStartSynchronizationWithTimecodeSource_XHandle = Selector.GetHandle ("startSynchronizationWithTimecodeSource:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSynchronizationTimeoutX = "synchronizationTimeout";
		static readonly NativeHandle selSynchronizationTimeoutXHandle = Selector.GetHandle ("synchronizationTimeout");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTimecodeAlignmentOffsetX = "timecodeAlignmentOffset";
		static readonly NativeHandle selTimecodeAlignmentOffsetXHandle = Selector.GetHandle ("timecodeAlignmentOffset");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTimecodeFrameDurationX = "timecodeFrameDuration";
		static readonly NativeHandle selTimecodeFrameDurationXHandle = Selector.GetHandle ("timecodeFrameDuration");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("AVCaptureTimecodeGenerator");
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
		protected AVCaptureTimecodeGenerator (NSObjectFlag t) : base (t)
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
		protected internal AVCaptureTimecodeGenerator (NativeHandle handle) : base (handle)
		{
		}

		[Export ("setDelegate:queue:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetDelegate (IAVCaptureTimecodeGeneratorDelegate? @delegate, global::CoreFoundation.DispatchQueue? callbackQueue)
		{
			var @delegate__handle__ = @delegate.GetHandle ();
			var callbackQueue__handle__ = callbackQueue.GetHandle ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selSetDelegate_Queue_XHandle, @delegate__handle__, callbackQueue__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selSetDelegate_Queue_XHandle, @delegate__handle__, callbackQueue__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (@delegate);
			GC.KeepAlive (callbackQueue);
		}
		[Export ("startSynchronizationWithTimecodeSource:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void StartSynchronization (AVCaptureTimecodeSource source)
		{
			var source__handle__ = source!.GetNonNullHandle (nameof (source));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selStartSynchronizationWithTimecodeSource_XHandle, source__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selStartSynchronizationWithTimecodeSource_XHandle, source__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (source);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual AVCaptureTimecodeSource[] AvailableSources {
			[Export ("availableSources", ArgumentSemantic.Copy)]
			get {
				AVCaptureTimecodeSource[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<AVCaptureTimecodeSource>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selAvailableSourcesXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<AVCaptureTimecodeSource>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selAvailableSourcesXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual AVCaptureTimecodeSource CurrentSource {
			[Export ("currentSource")]
			get {
				AVCaptureTimecodeSource? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<AVCaptureTimecodeSource> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selCurrentSourceXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<AVCaptureTimecodeSource> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selCurrentSourceXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public IAVCaptureTimecodeGeneratorDelegate? Delegate {
			get {
				return (WeakDelegate as IAVCaptureTimecodeGeneratorDelegate)!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::CoreFoundation.DispatchQueue? DelegateCallbackQueue {
			[Export ("delegateCallbackQueue")]
			get {
				global::CoreFoundation.DispatchQueue ret;
				if (IsDirectBinding) {
					ret = Runtime.GetINativeObject<global::CoreFoundation.DispatchQueue> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selDelegateCallbackQueueXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = Runtime.GetINativeObject<global::CoreFoundation.DispatchQueue> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selDelegateCallbackQueueXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static AVCaptureTimecodeSource FrameCountSource {
			[Export ("frameCountSource")]
			get {
				AVCaptureTimecodeSource? ret;
				ret =  Runtime.GetNSObject<AVCaptureTimecodeSource> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selFrameCountSourceXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual AVCaptureTimecode GenerateInitialTimecode {
			[Export ("generateInitialTimecode")]
			get {
				AVCaptureTimecode ret;
				if (IsDirectBinding) {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						ret = global::ObjCRuntime.Messaging.AVCaptureTimecode_objc_msgSend (this.Handle, selGenerateInitialTimecodeXHandle);
					} else {
						ret = global::ObjCRuntime.Messaging.AVCaptureTimecode_objc_msgSend_stret (this.Handle, selGenerateInitialTimecodeXHandle);
					}
				} else {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.AVCaptureTimecode_objc_msgSendSuper (&__objc_super__, selGenerateInitialTimecodeXHandle);
							GC.KeepAlive (this);
						}
					} else {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.AVCaptureTimecode_objc_msgSendSuper_stret (&__objc_super__, selGenerateInitialTimecodeXHandle);
							GC.KeepAlive (this);
						}
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static AVCaptureTimecodeSource RealTimeClockSource {
			[Export ("realTimeClockSource")]
			get {
				AVCaptureTimecodeSource? ret;
				ret =  Runtime.GetNSObject<AVCaptureTimecodeSource> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selRealTimeClockSourceXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual double SynchronizationTimeout {
			[Export ("synchronizationTimeout")]
			get {
				double ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.Double_objc_msgSend (this.Handle, selSynchronizationTimeoutXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.Double_objc_msgSendSuper (&__objc_super__, selSynchronizationTimeoutXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setSynchronizationTimeout:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_Double (this.Handle, selSetSynchronizationTimeout_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_Double (&__objc_super__, selSetSynchronizationTimeout_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual double TimecodeAlignmentOffset {
			[Export ("timecodeAlignmentOffset")]
			get {
				double ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.Double_objc_msgSend (this.Handle, selTimecodeAlignmentOffsetXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.Double_objc_msgSendSuper (&__objc_super__, selTimecodeAlignmentOffsetXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setTimecodeAlignmentOffset:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_Double (this.Handle, selSetTimecodeAlignmentOffset_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_Double (&__objc_super__, selSetTimecodeAlignmentOffset_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::CoreMedia.CMTime TimecodeFrameDuration {
			[Export ("timecodeFrameDuration", ArgumentSemantic.Assign)]
			get {
				global::CoreMedia.CMTime ret;
				if (IsDirectBinding) {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						ret = global::ObjCRuntime.Messaging.CMTime_objc_msgSend (this.Handle, selTimecodeFrameDurationXHandle);
					} else {
						ret = global::ObjCRuntime.Messaging.CMTime_objc_msgSend_stret (this.Handle, selTimecodeFrameDurationXHandle);
					}
				} else {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.CMTime_objc_msgSendSuper (&__objc_super__, selTimecodeFrameDurationXHandle);
							GC.KeepAlive (this);
						}
					} else {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.CMTime_objc_msgSendSuper_stret (&__objc_super__, selTimecodeFrameDurationXHandle);
							GC.KeepAlive (this);
						}
					}
				}
				return ret!;
			}
			[Export ("setTimecodeFrameDuration:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_CMTime (this.Handle, selSetTimecodeFrameDuration_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_CMTime (&__objc_super__, selSetTimecodeFrameDuration_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject? WeakDelegate {
			[Export ("delegate")]
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
				return ret!;
			}
		}
	} /* class AVCaptureTimecodeGenerator */
}
