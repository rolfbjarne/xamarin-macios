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
	[Register("AVOutputSettingsAssistant", true)]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe partial class AVOutputSettingsAssistant : NSObject {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAudioSettingsX = "audioSettings";
		static readonly NativeHandle selAudioSettingsXHandle = Selector.GetHandle ("audioSettings");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAvailableOutputSettingsPresetsX = "availableOutputSettingsPresets";
		static readonly NativeHandle selAvailableOutputSettingsPresetsXHandle = Selector.GetHandle ("availableOutputSettingsPresets");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selOutputFileTypeX = "outputFileType";
		static readonly NativeHandle selOutputFileTypeXHandle = Selector.GetHandle ("outputFileType");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selOutputSettingsAssistantWithPreset_X = "outputSettingsAssistantWithPreset:";
		static readonly NativeHandle selOutputSettingsAssistantWithPreset_XHandle = Selector.GetHandle ("outputSettingsAssistantWithPreset:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetSourceAudioFormat_X = "setSourceAudioFormat:";
		static readonly NativeHandle selSetSourceAudioFormat_XHandle = Selector.GetHandle ("setSourceAudioFormat:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetSourceVideoAverageFrameDuration_X = "setSourceVideoAverageFrameDuration:";
		static readonly NativeHandle selSetSourceVideoAverageFrameDuration_XHandle = Selector.GetHandle ("setSourceVideoAverageFrameDuration:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetSourceVideoFormat_X = "setSourceVideoFormat:";
		static readonly NativeHandle selSetSourceVideoFormat_XHandle = Selector.GetHandle ("setSourceVideoFormat:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetSourceVideoMinFrameDuration_X = "setSourceVideoMinFrameDuration:";
		static readonly NativeHandle selSetSourceVideoMinFrameDuration_XHandle = Selector.GetHandle ("setSourceVideoMinFrameDuration:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSourceAudioFormatX = "sourceAudioFormat";
		static readonly NativeHandle selSourceAudioFormatXHandle = Selector.GetHandle ("sourceAudioFormat");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSourceVideoAverageFrameDurationX = "sourceVideoAverageFrameDuration";
		static readonly NativeHandle selSourceVideoAverageFrameDurationXHandle = Selector.GetHandle ("sourceVideoAverageFrameDuration");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSourceVideoFormatX = "sourceVideoFormat";
		static readonly NativeHandle selSourceVideoFormatXHandle = Selector.GetHandle ("sourceVideoFormat");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSourceVideoMinFrameDurationX = "sourceVideoMinFrameDuration";
		static readonly NativeHandle selSourceVideoMinFrameDurationXHandle = Selector.GetHandle ("sourceVideoMinFrameDuration");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selVideoSettingsX = "videoSettings";
		static readonly NativeHandle selVideoSettingsXHandle = Selector.GetHandle ("videoSettings");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("AVOutputSettingsAssistant");
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
		protected AVOutputSettingsAssistant (NSObjectFlag t) : base (t)
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
		protected internal AVOutputSettingsAssistant (NativeHandle handle) : base (handle)
		{
		}

		[Export ("outputSettingsAssistantWithPreset:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static AVOutputSettingsAssistant? FromPreset (string presetIdentifier)
		{
			if (presetIdentifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (presetIdentifier));
			var nspresetIdentifier = CFString.CreateNative (presetIdentifier);
			AVOutputSettingsAssistant? ret;
			ret =  Runtime.GetNSObject<AVOutputSettingsAssistant> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, selOutputSettingsAssistantWithPreset_XHandle, nspresetIdentifier), false)!;
			CFString.ReleaseNative (nspresetIdentifier);
			return ret!;
		}
		/// <summary>Gets the dictionary of values for creating <see cref="T:AVFoundation.AVAssetWriterInput" /> instances.</summary><value><para>(More documentation for this node is coming)</para><para tool="nullallowed">This value can be <see langword="null" />.</para></value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public AudioSettings? AudioSettings {
			get {
				var src = WeakAudioSettings is not null ? new NSMutableDictionary (WeakAudioSettings) : null;
				return src is null ? null! : new AudioSettings(src);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static string[] AvailableOutputSettingsPresets {
			[Export ("availableOutputSettingsPresets")]
			get {
				string[] ret;
				ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selAvailableOutputSettingsPresetsXHandle), false)!;
				return ret;
			}
		}
		/// <summary>Gets or sets the compressed video settings to use when creating a <see cref="T:AVFoundation.AVAssetWriterInput" /> object.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public AVVideoSettingsCompressed CompressedVideoSettings {
			get {
				var src = WeakVideoSettings is not null ? new NSMutableDictionary (WeakVideoSettings) : null;
				return src is null ? null! : new AVVideoSettingsCompressed(src);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string OutputFileType {
			[Export ("outputFileType", ArgumentSemantic.Copy)]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selOutputFileTypeXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selOutputFileTypeXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::CoreMedia.CMAudioFormatDescription? SourceAudioFormat {
			[Export ("sourceAudioFormat", ArgumentSemantic.Copy)]
			get {
				global::CoreMedia.CMAudioFormatDescription ret;
				if (IsDirectBinding) {
					ret = Runtime.GetINativeObject<global::CoreMedia.CMAudioFormatDescription> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selSourceAudioFormatXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = Runtime.GetINativeObject<global::CoreMedia.CMAudioFormatDescription> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selSourceAudioFormatXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setSourceAudioFormat:", ArgumentSemantic.Copy)]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetSourceAudioFormat_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetSourceAudioFormat_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::CoreMedia.CMTime SourceVideoAverageFrameDuration {
			[Export ("sourceVideoAverageFrameDuration", ArgumentSemantic.Copy)]
			get {
				global::CoreMedia.CMTime ret;
				if (IsDirectBinding) {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						ret = global::ObjCRuntime.Messaging.CMTime_objc_msgSend (this.Handle, selSourceVideoAverageFrameDurationXHandle);
					} else {
						ret = global::ObjCRuntime.Messaging.CMTime_objc_msgSend_stret (this.Handle, selSourceVideoAverageFrameDurationXHandle);
					}
				} else {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.CMTime_objc_msgSendSuper (&__objc_super__, selSourceVideoAverageFrameDurationXHandle);
							GC.KeepAlive (this);
						}
					} else {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.CMTime_objc_msgSendSuper_stret (&__objc_super__, selSourceVideoAverageFrameDurationXHandle);
							GC.KeepAlive (this);
						}
					}
				}
				return ret!;
			}
			[Export ("setSourceVideoAverageFrameDuration:", ArgumentSemantic.Copy)]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_CMTime (this.Handle, selSetSourceVideoAverageFrameDuration_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_CMTime (&__objc_super__, selSetSourceVideoAverageFrameDuration_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::CoreMedia.CMVideoFormatDescription? SourceVideoFormat {
			[Export ("sourceVideoFormat", ArgumentSemantic.Copy)]
			get {
				global::CoreMedia.CMVideoFormatDescription ret;
				if (IsDirectBinding) {
					ret = Runtime.GetINativeObject<global::CoreMedia.CMVideoFormatDescription> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selSourceVideoFormatXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = Runtime.GetINativeObject<global::CoreMedia.CMVideoFormatDescription> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selSourceVideoFormatXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setSourceVideoFormat:", ArgumentSemantic.Copy)]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetSourceVideoFormat_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetSourceVideoFormat_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual global::CoreMedia.CMTime SourceVideoMinFrameDuration {
			[Export ("sourceVideoMinFrameDuration", ArgumentSemantic.Copy)]
			get {
				global::CoreMedia.CMTime ret;
				if (IsDirectBinding) {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						ret = global::ObjCRuntime.Messaging.CMTime_objc_msgSend (this.Handle, selSourceVideoMinFrameDurationXHandle);
					} else {
						ret = global::ObjCRuntime.Messaging.CMTime_objc_msgSend_stret (this.Handle, selSourceVideoMinFrameDurationXHandle);
					}
				} else {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.CMTime_objc_msgSendSuper (&__objc_super__, selSourceVideoMinFrameDurationXHandle);
							GC.KeepAlive (this);
						}
					} else {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.CMTime_objc_msgSendSuper_stret (&__objc_super__, selSourceVideoMinFrameDurationXHandle);
							GC.KeepAlive (this);
						}
					}
				}
				return ret!;
			}
			[Export ("setSourceVideoMinFrameDuration:", ArgumentSemantic.Copy)]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_CMTime (this.Handle, selSetSourceVideoMinFrameDuration_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_CMTime (&__objc_super__, selSetSourceVideoMinFrameDuration_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>Gets or sets the uncompressed video settings to use when creating a <see cref="T:AVFoundation.AVAssetWriterInput" /> object.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public AVVideoSettingsUncompressed UnCompressedVideoSettings {
			get {
				var src = WeakVideoSettings is not null ? new NSMutableDictionary (WeakVideoSettings) : null;
				return src is null ? null! : new AVVideoSettingsUncompressed(src);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDictionary? WeakAudioSettings {
			[Export ("audioSettings", ArgumentSemantic.Copy)]
			get {
				NSDictionary? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDictionary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selAudioSettingsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSDictionary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selAudioSettingsXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDictionary? WeakVideoSettings {
			[Export ("videoSettings", ArgumentSemantic.Copy)]
			get {
				NSDictionary? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDictionary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selVideoSettingsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSDictionary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selVideoSettingsXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? __Preset1280x720;
		/// <summary>Represents the value associated with the constant 'AVOutputSettingsPreset1280x720'.</summary>
		[Field ("AVOutputSettingsPreset1280x720",  "AVFoundation")]
		internal static NSString _Preset1280x720 {
			get {
				if (__Preset1280x720 is null)
					__Preset1280x720 = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVOutputSettingsPreset1280x720")!;
				return __Preset1280x720;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? __Preset1920x1080;
		/// <summary>Represents the value associated with the constant 'AVOutputSettingsPreset1920x1080'.</summary>
		[Field ("AVOutputSettingsPreset1920x1080",  "AVFoundation")]
		internal static NSString _Preset1920x1080 {
			get {
				if (__Preset1920x1080 is null)
					__Preset1920x1080 = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVOutputSettingsPreset1920x1080")!;
				return __Preset1920x1080;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? __Preset3840x2160;
		/// <summary>Represents the value associated with the constant 'AVOutputSettingsPreset3840x2160'.</summary>
		[Field ("AVOutputSettingsPreset3840x2160",  "AVFoundation")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		internal static NSString _Preset3840x2160 {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (__Preset3840x2160 is null)
					__Preset3840x2160 = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVOutputSettingsPreset3840x2160")!;
				return __Preset3840x2160;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? __Preset640x480;
		/// <summary>Represents the value associated with the constant 'AVOutputSettingsPreset640x480'.</summary>
		[Field ("AVOutputSettingsPreset640x480",  "AVFoundation")]
		internal static NSString _Preset640x480 {
			get {
				if (__Preset640x480 is null)
					__Preset640x480 = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVOutputSettingsPreset640x480")!;
				return __Preset640x480;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? __Preset960x540;
		/// <summary>Represents the value associated with the constant 'AVOutputSettingsPreset960x540'.</summary>
		[Field ("AVOutputSettingsPreset960x540",  "AVFoundation")]
		internal static NSString _Preset960x540 {
			get {
				if (__Preset960x540 is null)
					__Preset960x540 = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVOutputSettingsPreset960x540")!;
				return __Preset960x540;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? __PresetHevc1920x1080;
		/// <summary>Represents the value associated with the constant 'AVOutputSettingsPresetHEVC1920x1080'.</summary>
		[Field ("AVOutputSettingsPresetHEVC1920x1080",  "AVFoundation")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		internal static NSString _PresetHevc1920x1080 {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (__PresetHevc1920x1080 is null)
					__PresetHevc1920x1080 = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVOutputSettingsPresetHEVC1920x1080")!;
				return __PresetHevc1920x1080;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? __PresetHevc3840x2160;
		/// <summary>Represents the value associated with the constant 'AVOutputSettingsPresetHEVC3840x2160'.</summary>
		[Field ("AVOutputSettingsPresetHEVC3840x2160",  "AVFoundation")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		internal static NSString _PresetHevc3840x2160 {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (__PresetHevc3840x2160 is null)
					__PresetHevc3840x2160 = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVOutputSettingsPresetHEVC3840x2160")!;
				return __PresetHevc3840x2160;
			}
		}
	} /* class AVOutputSettingsAssistant */
}
