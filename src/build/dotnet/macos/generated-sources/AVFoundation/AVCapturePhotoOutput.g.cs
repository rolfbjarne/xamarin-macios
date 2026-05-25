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
	/// <summary>Provides an interface for capturing still images, Live Photos, RAW capture, wide-gamut color, and bracketed images.</summary><related type="externalDocumentation" href="https://developer.apple.com/reference/AVFoundation/AVCapturePhotoOutput">Apple documentation for <c>AVCapturePhotoOutput</c></related>
	[Register("AVCapturePhotoOutput", true)]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("tvos17.0")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	public unsafe partial class AVCapturePhotoOutput : AVCaptureOutput {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAvailablePhotoCodecTypesX = "availablePhotoCodecTypes";
		static readonly NativeHandle selAvailablePhotoCodecTypesXHandle = Selector.GetHandle ("availablePhotoCodecTypes");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAvailablePhotoFileTypesX = "availablePhotoFileTypes";
		static readonly NativeHandle selAvailablePhotoFileTypesXHandle = Selector.GetHandle ("availablePhotoFileTypes");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAvailablePhotoPixelFormatTypesX = "availablePhotoPixelFormatTypes";
		static readonly NativeHandle selAvailablePhotoPixelFormatTypesXHandle = Selector.GetHandle ("availablePhotoPixelFormatTypes");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCapturePhotoWithSettings_Delegate_X = "capturePhotoWithSettings:delegate:";
		static readonly NativeHandle selCapturePhotoWithSettings_Delegate_XHandle = Selector.GetHandle ("capturePhotoWithSettings:delegate:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCaptureReadinessX = "captureReadiness";
		static readonly NativeHandle selCaptureReadinessXHandle = Selector.GetHandle ("captureReadiness");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsConstantColorEnabledX = "isConstantColorEnabled";
		static readonly NativeHandle selIsConstantColorEnabledXHandle = Selector.GetHandle ("isConstantColorEnabled");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsConstantColorSupportedX = "isConstantColorSupported";
		static readonly NativeHandle selIsConstantColorSupportedXHandle = Selector.GetHandle ("isConstantColorSupported");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsFastCapturePrioritizationEnabledX = "isFastCapturePrioritizationEnabled";
		static readonly NativeHandle selIsFastCapturePrioritizationEnabledXHandle = Selector.GetHandle ("isFastCapturePrioritizationEnabled");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsFastCapturePrioritizationSupportedX = "isFastCapturePrioritizationSupported";
		static readonly NativeHandle selIsFastCapturePrioritizationSupportedXHandle = Selector.GetHandle ("isFastCapturePrioritizationSupported");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsHighResolutionCaptureEnabledX = "isHighResolutionCaptureEnabled";
		static readonly NativeHandle selIsHighResolutionCaptureEnabledXHandle = Selector.GetHandle ("isHighResolutionCaptureEnabled");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsResponsiveCaptureEnabledX = "isResponsiveCaptureEnabled";
		static readonly NativeHandle selIsResponsiveCaptureEnabledXHandle = Selector.GetHandle ("isResponsiveCaptureEnabled");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsResponsiveCaptureSupportedX = "isResponsiveCaptureSupported";
		static readonly NativeHandle selIsResponsiveCaptureSupportedXHandle = Selector.GetHandle ("isResponsiveCaptureSupported");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsShutterSoundSuppressionSupportedX = "isShutterSoundSuppressionSupported";
		static readonly NativeHandle selIsShutterSoundSuppressionSupportedXHandle = Selector.GetHandle ("isShutterSoundSuppressionSupported");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsZeroShutterLagEnabledX = "isZeroShutterLagEnabled";
		static readonly NativeHandle selIsZeroShutterLagEnabledXHandle = Selector.GetHandle ("isZeroShutterLagEnabled");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsZeroShutterLagSupportedX = "isZeroShutterLagSupported";
		static readonly NativeHandle selIsZeroShutterLagSupportedXHandle = Selector.GetHandle ("isZeroShutterLagSupported");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMaxPhotoDimensionsX = "maxPhotoDimensions";
		static readonly NativeHandle selMaxPhotoDimensionsXHandle = Selector.GetHandle ("maxPhotoDimensions");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMaxPhotoQualityPrioritizationX = "maxPhotoQualityPrioritization";
		static readonly NativeHandle selMaxPhotoQualityPrioritizationXHandle = Selector.GetHandle ("maxPhotoQualityPrioritization");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPreservesLivePhotoCaptureSuspendedOnSessionStopX = "preservesLivePhotoCaptureSuspendedOnSessionStop";
		static readonly NativeHandle selPreservesLivePhotoCaptureSuspendedOnSessionStopXHandle = Selector.GetHandle ("preservesLivePhotoCaptureSuspendedOnSessionStop");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetConstantColorEnabled_X = "setConstantColorEnabled:";
		static readonly NativeHandle selSetConstantColorEnabled_XHandle = Selector.GetHandle ("setConstantColorEnabled:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetFastCapturePrioritizationEnabled_X = "setFastCapturePrioritizationEnabled:";
		static readonly NativeHandle selSetFastCapturePrioritizationEnabled_XHandle = Selector.GetHandle ("setFastCapturePrioritizationEnabled:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetFastCapturePrioritizationSupported_X = "setFastCapturePrioritizationSupported:";
		static readonly NativeHandle selSetFastCapturePrioritizationSupported_XHandle = Selector.GetHandle ("setFastCapturePrioritizationSupported:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetHighResolutionCaptureEnabled_X = "setHighResolutionCaptureEnabled:";
		static readonly NativeHandle selSetHighResolutionCaptureEnabled_XHandle = Selector.GetHandle ("setHighResolutionCaptureEnabled:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetMaxPhotoDimensions_X = "setMaxPhotoDimensions:";
		static readonly NativeHandle selSetMaxPhotoDimensions_XHandle = Selector.GetHandle ("setMaxPhotoDimensions:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetMaxPhotoQualityPrioritization_X = "setMaxPhotoQualityPrioritization:";
		static readonly NativeHandle selSetMaxPhotoQualityPrioritization_XHandle = Selector.GetHandle ("setMaxPhotoQualityPrioritization:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetPreservesLivePhotoCaptureSuspendedOnSessionStop_X = "setPreservesLivePhotoCaptureSuspendedOnSessionStop:";
		static readonly NativeHandle selSetPreservesLivePhotoCaptureSuspendedOnSessionStop_XHandle = Selector.GetHandle ("setPreservesLivePhotoCaptureSuspendedOnSessionStop:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetResponsiveCaptureEnabled_X = "setResponsiveCaptureEnabled:";
		static readonly NativeHandle selSetResponsiveCaptureEnabled_XHandle = Selector.GetHandle ("setResponsiveCaptureEnabled:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetZeroShutterLagEnabled_X = "setZeroShutterLagEnabled:";
		static readonly NativeHandle selSetZeroShutterLagEnabled_XHandle = Selector.GetHandle ("setZeroShutterLagEnabled:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSupportedFlashModesX = "supportedFlashModes";
		static readonly NativeHandle selSupportedFlashModesXHandle = Selector.GetHandle ("supportedFlashModes");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSupportedPhotoCodecTypesForFileType_X = "supportedPhotoCodecTypesForFileType:";
		static readonly NativeHandle selSupportedPhotoCodecTypesForFileType_XHandle = Selector.GetHandle ("supportedPhotoCodecTypesForFileType:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSupportedPhotoPixelFormatTypesForFileType_X = "supportedPhotoPixelFormatTypesForFileType:";
		static readonly NativeHandle selSupportedPhotoPixelFormatTypesForFileType_XHandle = Selector.GetHandle ("supportedPhotoPixelFormatTypesForFileType:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("AVCapturePhotoOutput");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		/// <summary>Creates a new <see cref="AVCapturePhotoOutput" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public AVCapturePhotoOutput () : base (NSObjectFlag.Empty)
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
		protected AVCapturePhotoOutput (NSObjectFlag t) : base (t)
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
		protected internal AVCapturePhotoOutput (NativeHandle handle) : base (handle)
		{
		}

		[Export ("capturePhotoWithSettings:delegate:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void CapturePhoto (AVCapturePhotoSettings settings, IAVCapturePhotoCaptureDelegate cb)
		{
			var settings__handle__ = settings!.GetNonNullHandle (nameof (settings));
			var cb__handle__ = cb!.GetNonNullHandle (nameof (cb));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selCapturePhotoWithSettings_Delegate_XHandle, settings__handle__, cb__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selCapturePhotoWithSettings_Delegate_XHandle, settings__handle__, cb__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (settings);
			GC.KeepAlive (cb);
		}
		[Export ("supportedPhotoPixelFormatTypesForFileType:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSNumber[] GetSupportedPhotoPixelFormatTypesForFileType (string fileType)
		{
			if (fileType is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (fileType));
			var nsfileType = CFString.CreateNative (fileType);
			NSNumber[]? ret;
			if (IsDirectBinding) {
				ret = CFArray.ArrayFromHandle<NSNumber>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selSupportedPhotoPixelFormatTypesForFileType_XHandle, nsfileType), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFArray.ArrayFromHandle<NSNumber>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selSupportedPhotoPixelFormatTypesForFileType_XHandle, nsfileType), false)!;
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsfileType);
			return ret!;
		}
		[Export ("supportedPhotoCodecTypesForFileType:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal virtual NSString[] _GetSupportedPhotoCodecTypesForFileType (string fileType)
		{
			if (fileType is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (fileType));
			var nsfileType = CFString.CreateNative (fileType);
			NSString[]? ret;
			if (IsDirectBinding) {
				ret = CFArray.ArrayFromHandle<NSString>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selSupportedPhotoCodecTypesForFileType_XHandle, nsfileType), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFArray.ArrayFromHandle<NSString>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selSupportedPhotoCodecTypesForFileType_XHandle, nsfileType), false)!;
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsfileType);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string[] AvailablePhotoCodecTypes {
			[Export ("availablePhotoCodecTypes")]
			get {
				string[] ret;
				if (IsDirectBinding) {
					ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selAvailablePhotoCodecTypesXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selAvailablePhotoCodecTypesXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSNumber[] AvailablePhotoPixelFormatTypes {
			[Export ("availablePhotoPixelFormatTypes")]
			get {
				NSNumber[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<NSNumber>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selAvailablePhotoPixelFormatTypesXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<NSNumber>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selAvailablePhotoPixelFormatTypesXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		public virtual AVCapturePhotoOutputCaptureReadiness CaptureReadiness {
			[Export ("captureReadiness")]
			get {
				AVCapturePhotoOutputCaptureReadiness ret;
				if (IsDirectBinding) {
					ret = (AVCapturePhotoOutputCaptureReadiness) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selCaptureReadinessXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (AVCapturePhotoOutputCaptureReadiness) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selCaptureReadinessXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("ios18.0")]
		public virtual bool ConstantColorEnabled {
			[Export ("isConstantColorEnabled")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsConstantColorEnabledXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsConstantColorEnabledXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setConstantColorEnabled:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetConstantColorEnabled_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetConstantColorEnabled_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("ios18.0")]
		public virtual bool ConstantColorSupported {
			[Export ("isConstantColorSupported")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsConstantColorSupportedXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsConstantColorSupportedXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		public virtual bool FastCapturePrioritizationEnabled {
			[Export ("isFastCapturePrioritizationEnabled")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsFastCapturePrioritizationEnabledXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsFastCapturePrioritizationEnabledXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setFastCapturePrioritizationEnabled:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetFastCapturePrioritizationEnabled_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetFastCapturePrioritizationEnabled_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		public virtual bool FastCapturePrioritizationSupported {
			[Export ("isFastCapturePrioritizationSupported")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsFastCapturePrioritizationSupportedXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsFastCapturePrioritizationSupportedXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setFastCapturePrioritizationSupported:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetFastCapturePrioritizationSupported_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetFastCapturePrioritizationSupported_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos17.0")]
		public AVFileTypes[] GetAvailablePhotoFileTypes {
			get {
				return (Array.ConvertAll (_GetAvailablePhotoFileTypes, s => AVFileTypesExtensions.GetValue (s)) as AVFileTypes[])!;
			}
		}
		/// <summary>Gets or sets a Boolean value that controls whether high resolution capture is enabled.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[ObsoletedOSPlatform ("ios16.0", "Use 'MaxPhotoDimensions' instead.")]
		[ObsoletedOSPlatform ("maccatalyst16.0", "Use 'MaxPhotoDimensions' instead.")]
		[ObsoletedOSPlatform ("tvos16.0", "Use 'MaxPhotoDimensions' instead.")]
		[ObsoletedOSPlatform ("macos13.0", "Use 'MaxPhotoDimensions' instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos17.0")]
		public virtual bool IsHighResolutionCaptureEnabled {
			[Export ("isHighResolutionCaptureEnabled")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsHighResolutionCaptureEnabledXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsHighResolutionCaptureEnabledXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setHighResolutionCaptureEnabled:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetHighResolutionCaptureEnabled_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetHighResolutionCaptureEnabled_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("tvos17.0")]
		public virtual global::CoreMedia.CMVideoDimensions MaxPhotoDimensions {
			[Export ("maxPhotoDimensions")]
			get {
				global::CoreMedia.CMVideoDimensions ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.CMVideoDimensions_objc_msgSend (this.Handle, selMaxPhotoDimensionsXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CMVideoDimensions_objc_msgSendSuper (&__objc_super__, selMaxPhotoDimensionsXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setMaxPhotoDimensions:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_CMVideoDimensions (this.Handle, selSetMaxPhotoDimensions_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_CMVideoDimensions (&__objc_super__, selSetMaxPhotoDimensions_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("tvos17.0")]
		public virtual AVCapturePhotoQualityPrioritization MaxPhotoQualityPrioritization {
			[Export ("maxPhotoQualityPrioritization", ArgumentSemantic.Assign)]
			get {
				AVCapturePhotoQualityPrioritization ret;
				if (IsDirectBinding) {
					ret = (AVCapturePhotoQualityPrioritization) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selMaxPhotoQualityPrioritizationXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (AVCapturePhotoQualityPrioritization) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selMaxPhotoQualityPrioritizationXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setMaxPhotoQualityPrioritization:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetMaxPhotoQualityPrioritization_XHandle, (IntPtr) (long) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, selSetMaxPhotoQualityPrioritization_XHandle, (IntPtr) (long) value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("tvos17.0")]
		public virtual bool PreservesLivePhotoCaptureSuspendedOnSessionStop {
			[Export ("preservesLivePhotoCaptureSuspendedOnSessionStop")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selPreservesLivePhotoCaptureSuspendedOnSessionStopXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selPreservesLivePhotoCaptureSuspendedOnSessionStopXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setPreservesLivePhotoCaptureSuspendedOnSessionStop:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetPreservesLivePhotoCaptureSuspendedOnSessionStop_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetPreservesLivePhotoCaptureSuspendedOnSessionStop_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		public virtual bool ResponsiveCaptureEnabled {
			[Export ("isResponsiveCaptureEnabled")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsResponsiveCaptureEnabledXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsResponsiveCaptureEnabledXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setResponsiveCaptureEnabled:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetResponsiveCaptureEnabled_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetResponsiveCaptureEnabled_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		public virtual bool ResponsiveCaptureSupported {
			[Export ("isResponsiveCaptureSupported")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsResponsiveCaptureSupportedXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsResponsiveCaptureSupportedXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("ios18.0")]
		public virtual bool ShutterSoundSuppressionSupported {
			[Export ("isShutterSoundSuppressionSupported")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsShutterSoundSuppressionSupportedXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsShutterSoundSuppressionSupportedXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos17.0")]
		[BindAs (typeof (AVCaptureFlashMode[]), OriginalType = typeof (NSNumber[]))]
		public virtual global::AVFoundation.AVCaptureFlashMode[] SupportedFlashModes {
			[Export ("supportedFlashModes")]
			get {
				global::AVFoundation.AVCaptureFlashMode[] ret;
				if (IsDirectBinding) {
					ret = NSArray.ArrayFromHandleFunc <global::AVFoundation.AVCaptureFlashMode> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selSupportedFlashModesXHandle), ptr => (global::AVFoundation.AVCaptureFlashMode) NSNumber.ToInt64 (ptr), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = NSArray.ArrayFromHandleFunc <global::AVFoundation.AVCaptureFlashMode> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selSupportedFlashModesXHandle), ptr => (global::AVFoundation.AVCaptureFlashMode) NSNumber.ToInt64 (ptr), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		public virtual bool ZeroShutterLagEnabled {
			[Export ("isZeroShutterLagEnabled")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsZeroShutterLagEnabledXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsZeroShutterLagEnabledXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setZeroShutterLagEnabled:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetZeroShutterLagEnabled_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetZeroShutterLagEnabled_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		public virtual bool ZeroShutterLagSupported {
			[Export ("isZeroShutterLagSupported")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsZeroShutterLagSupportedXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsZeroShutterLagSupportedXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos17.0")]
		internal virtual NSString[] _GetAvailablePhotoFileTypes {
			[Export ("availablePhotoFileTypes")]
			get {
				NSString[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<NSString>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selAvailablePhotoFileTypesXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<NSString>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selAvailablePhotoFileTypesXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
	} /* class AVCapturePhotoOutput */
}
