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
	[Register("CNAssetSpatialAudioInfo", true)]
	[SupportedOSPlatform ("tvos26.0")]
	[SupportedOSPlatform ("maccatalyst26.0")]
	[SupportedOSPlatform ("macos26.0")]
	[SupportedOSPlatform ("ios26.0")]
	public unsafe partial class CNAssetSpatialAudioInfo : NSObject {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAssetReaderOutputSettingsForContentType_X = "assetReaderOutputSettingsForContentType:";
		static readonly NativeHandle selAssetReaderOutputSettingsForContentType_XHandle = Selector.GetHandle ("assetReaderOutputSettingsForContentType:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAssetWriterInputSettingsForContentType_X = "assetWriterInputSettingsForContentType:";
		static readonly NativeHandle selAssetWriterInputSettingsForContentType_XHandle = Selector.GetHandle ("assetWriterInputSettingsForContentType:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAudioMixWithEffectIntensity_RenderingStyle_X = "audioMixWithEffectIntensity:renderingStyle:";
		static readonly NativeHandle selAudioMixWithEffectIntensity_RenderingStyle_XHandle = Selector.GetHandle ("audioMixWithEffectIntensity:renderingStyle:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCheckIfContainsSpatialAudio_CompletionHandler_X = "checkIfContainsSpatialAudio:completionHandler:";
		static readonly NativeHandle selCheckIfContainsSpatialAudio_CompletionHandler_XHandle = Selector.GetHandle ("checkIfContainsSpatialAudio:completionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDefaultEffectIntensityX = "defaultEffectIntensity";
		static readonly NativeHandle selDefaultEffectIntensityXHandle = Selector.GetHandle ("defaultEffectIntensity");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDefaultRenderingStyleX = "defaultRenderingStyle";
		static readonly NativeHandle selDefaultRenderingStyleXHandle = Selector.GetHandle ("defaultRenderingStyle");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDefaultSpatialAudioTrackX = "defaultSpatialAudioTrack";
		static readonly NativeHandle selDefaultSpatialAudioTrackXHandle = Selector.GetHandle ("defaultSpatialAudioTrack");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsSupportedX = "isSupported";
		static readonly NativeHandle selIsSupportedXHandle = Selector.GetHandle ("isSupported");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLoadFromAsset_CompletionHandler_X = "loadFromAsset:completionHandler:";
		static readonly NativeHandle selLoadFromAsset_CompletionHandler_XHandle = Selector.GetHandle ("loadFromAsset:completionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSpatialAudioMixMetadataX = "spatialAudioMixMetadata";
		static readonly NativeHandle selSpatialAudioMixMetadataXHandle = Selector.GetHandle ("spatialAudioMixMetadata");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("CNAssetSpatialAudioInfo");
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
		protected CNAssetSpatialAudioInfo (NSObjectFlag t) : base (t)
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
		protected internal CNAssetSpatialAudioInfo (NativeHandle handle) : base (handle)
		{
		}

		[Export ("checkIfContainsSpatialAudio:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void CheckIfContainsSpatialAudio (global::AVFoundation.AVAsset asset, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDCNAssetSpatialAudioInfoCheckIfContainsSpatialAudioCallback))]CNAssetSpatialAudioInfoCheckIfContainsSpatialAudioCallback completionHandler)
		{
			var asset__handle__ = asset!.GetNonNullHandle (nameof (asset));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDCNAssetSpatialAudioInfoCheckIfContainsSpatialAudioCallback.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (class_ptr, selCheckIfContainsSpatialAudio_CompletionHandler_XHandle, asset__handle__, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (asset);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Task<bool> CheckIfContainsSpatialAudioAsync (global::AVFoundation.AVAsset asset)
		{
			var tcs = new TaskCompletionSource<bool> ();
			CheckIfContainsSpatialAudio(asset, (result_) => {
				tcs.SetResult (result_!);
			});
			return tcs.Task;
		}
		[Export ("audioMixWithEffectIntensity:renderingStyle:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::AVFoundation.AVAudioMix CreateAudioMix (float effectIntensity, CNSpatialAudioRenderingStyle renderingStyle)
		{
			global::AVFoundation.AVAudioMix ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<global::AVFoundation.AVAudioMix> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_float_IntPtr (this.Handle, selAudioMixWithEffectIntensity_RenderingStyle_XHandle, effectIntensity, (IntPtr) (long) renderingStyle), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<global::AVFoundation.AVAudioMix> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_float_IntPtr (&__objc_super__, selAudioMixWithEffectIntensity_RenderingStyle_XHandle, effectIntensity, (IntPtr) (long) renderingStyle), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("assetReaderOutputSettingsForContentType:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDictionary<NSString, NSObject> GetAssetReaderOutputSettings (CNSpatialAudioContentType contentType)
		{
			NSDictionary<NSString, NSObject> ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSDictionary<NSString, NSObject>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_IntPtr (this.Handle, selAssetReaderOutputSettingsForContentType_XHandle, (IntPtr) (long) contentType), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSDictionary<NSString, NSObject>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_IntPtr (&__objc_super__, selAssetReaderOutputSettingsForContentType_XHandle, (IntPtr) (long) contentType), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("assetWriterInputSettingsForContentType:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDictionary<NSString, NSObject> GetAssetWriterInputSettingsFor (CNSpatialAudioContentType contentType)
		{
			NSDictionary<NSString, NSObject> ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSDictionary<NSString, NSObject>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_IntPtr (this.Handle, selAssetWriterInputSettingsForContentType_XHandle, (IntPtr) (long) contentType), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSDictionary<NSString, NSObject>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_IntPtr (&__objc_super__, selAssetWriterInputSettingsForContentType_XHandle, (IntPtr) (long) contentType), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("loadFromAsset:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void Load (global::AVFoundation.AVAsset asset, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDCNAssetSpatialAudioInfoLoadCallback))]CNAssetSpatialAudioInfoLoadCallback completionHandler)
		{
			var asset__handle__ = asset!.GetNonNullHandle (nameof (asset));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDCNAssetSpatialAudioInfoLoadCallback.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (class_ptr, selLoadFromAsset_CompletionHandler_XHandle, asset__handle__, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (asset);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Task<CNAssetSpatialAudioInfo> LoadAsync (global::AVFoundation.AVAsset asset)
		{
			var tcs = new TaskCompletionSource<CNAssetSpatialAudioInfo> ();
			Load(asset, (assetInfo_, error_) => {
				if (error_ is not null)
					tcs.SetException (new NSErrorException(error_));
				else
					tcs.SetResult (assetInfo_!);
			});
			return tcs.Task;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual float DefaultEffectIntensity {
			[Export ("defaultEffectIntensity")]
			get {
				float ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selDefaultEffectIntensityXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.float_objc_msgSendSuper (&__objc_super__, selDefaultEffectIntensityXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CNSpatialAudioRenderingStyle DefaultRenderingStyle {
			[Export ("defaultRenderingStyle")]
			get {
				CNSpatialAudioRenderingStyle ret;
				if (IsDirectBinding) {
					ret = (Cinematic.CNSpatialAudioRenderingStyle) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selDefaultRenderingStyleXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (Cinematic.CNSpatialAudioRenderingStyle) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selDefaultRenderingStyleXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::AVFoundation.AVAssetTrack DefaultSpatialAudioTrack {
			[Export ("defaultSpatialAudioTrack")]
			get {
				global::AVFoundation.AVAssetTrack? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::AVFoundation.AVAssetTrack> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selDefaultSpatialAudioTrackXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<global::AVFoundation.AVAssetTrack> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selDefaultSpatialAudioTrackXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool IsSupported {
			[Export ("isSupported")]
			get {
				byte ret;
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (class_ptr, selIsSupportedXHandle);
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSData SpatialAudioMixMetadata {
			[Export ("spatialAudioMixMetadata")]
			get {
				NSData? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSData> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selSpatialAudioMixMetadataXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSData> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selSpatialAudioMixMetadataXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
	} /* class CNAssetSpatialAudioInfo */
}
