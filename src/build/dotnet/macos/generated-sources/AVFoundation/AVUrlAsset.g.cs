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
	[Register("AVURLAsset", true)]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe partial class AVUrlAsset : AVAsset, IAVContentKeyRecipient {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selURLX = "URL";
		static readonly NativeHandle selURLXHandle = Selector.GetHandle ("URL");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selURLAssetWithURL_Options_X = "URLAssetWithURL:options:";
		static readonly NativeHandle selURLAssetWithURL_Options_XHandle = Selector.GetHandle ("URLAssetWithURL:options:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAssetCacheX = "assetCache";
		static readonly NativeHandle selAssetCacheXHandle = Selector.GetHandle ("assetCache");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAudiovisualContentTypesX = "audiovisualContentTypes";
		static readonly NativeHandle selAudiovisualContentTypesXHandle = Selector.GetHandle ("audiovisualContentTypes");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAudiovisualMIMETypesX = "audiovisualMIMETypes";
		static readonly NativeHandle selAudiovisualMIMETypesXHandle = Selector.GetHandle ("audiovisualMIMETypes");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAudiovisualTypesX = "audiovisualTypes";
		static readonly NativeHandle selAudiovisualTypesXHandle = Selector.GetHandle ("audiovisualTypes");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCompatibleTrackForCompositionTrack_X = "compatibleTrackForCompositionTrack:";
		static readonly NativeHandle selCompatibleTrackForCompositionTrack_XHandle = Selector.GetHandle ("compatibleTrackForCompositionTrack:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selContentKeySession_DidProvideContentKey_X = "contentKeySession:didProvideContentKey:";
		static readonly NativeHandle selContentKeySession_DidProvideContentKey_XHandle = Selector.GetHandle ("contentKeySession:didProvideContentKey:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFindCompatibleTrackForCompositionTrack_CompletionHandler_X = "findCompatibleTrackForCompositionTrack:completionHandler:";
		static readonly NativeHandle selFindCompatibleTrackForCompositionTrack_CompletionHandler_XHandle = Selector.GetHandle ("findCompatibleTrackForCompositionTrack:completionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selHttpSessionIdentifierX = "httpSessionIdentifier";
		static readonly NativeHandle selHttpSessionIdentifierXHandle = Selector.GetHandle ("httpSessionIdentifier");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithURL_Options_X = "initWithURL:options:";
		static readonly NativeHandle selInitWithURL_Options_XHandle = Selector.GetHandle ("initWithURL:options:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsPlayableExtendedMIMEType_X = "isPlayableExtendedMIMEType:";
		static readonly NativeHandle selIsPlayableExtendedMIMEType_XHandle = Selector.GetHandle ("isPlayableExtendedMIMEType:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMayRequireContentKeysForMediaDataProcessingX = "mayRequireContentKeysForMediaDataProcessing";
		static readonly NativeHandle selMayRequireContentKeysForMediaDataProcessingXHandle = Selector.GetHandle ("mayRequireContentKeysForMediaDataProcessing");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMediaExtensionPropertiesX = "mediaExtensionProperties";
		static readonly NativeHandle selMediaExtensionPropertiesXHandle = Selector.GetHandle ("mediaExtensionProperties");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selResourceLoaderX = "resourceLoader";
		static readonly NativeHandle selResourceLoaderXHandle = Selector.GetHandle ("resourceLoader");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSidecarURLX = "sidecarURL";
		static readonly NativeHandle selSidecarURLXHandle = Selector.GetHandle ("sidecarURL");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selVariantsX = "variants";
		static readonly NativeHandle selVariantsXHandle = Selector.GetHandle ("variants");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("AVURLAsset");
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
		protected AVUrlAsset (NSObjectFlag t) : base (t)
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
		protected internal AVUrlAsset (NativeHandle handle) : base (handle)
		{
		}

		[Export ("initWithURL:options:")]
		[DesignatedInitializer]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public AVUrlAsset (NSUrl url, NSDictionary? options)
			: base (NSObjectFlag.Empty)
		{
			var url__handle__ = url!.GetNonNullHandle (nameof (url));
			var options__handle__ = options.GetHandle ();
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selInitWithURL_Options_XHandle, url__handle__, options__handle__), "initWithURL:options:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selInitWithURL_Options_XHandle, url__handle__, options__handle__), "initWithURL:options:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (url);
			GC.KeepAlive (options);
		}
		/// <param name="url">To be added.</param><param name="options">To be added.</param><summary>Creates a new <see cref="T:AVFoundation.AVUrlAsset" /> for the specified <paramref name="url" /> and <paramref name="options" />.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public AVUrlAsset (NSUrl url, AVUrlAssetOptions? options)
			: this (url, options.GetDictionary ())
		{
		}
		/// <param name="url">To be added.</param><summary>Creates a new <see cref="T:AVFoundation.AVUrlAsset" /> for the specified <paramref name="url" />.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public AVUrlAsset (NSUrl url)
			: this (url, (NSDictionary) null!)
		{
		}
		[Export ("compatibleTrackForCompositionTrack:")]
		[ObsoletedOSPlatform ("macos15.0")]
		[ObsoletedOSPlatform ("ios18.0")]
		[ObsoletedOSPlatform ("tvos18.0")]
		[ObsoletedOSPlatform ("maccatalyst18.0")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual AVAssetTrack? CompatibleTrack (AVCompositionTrack forCompositionTrack)
		{
			var forCompositionTrack__handle__ = forCompositionTrack!.GetNonNullHandle (nameof (forCompositionTrack));
			AVAssetTrack? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<AVAssetTrack> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selCompatibleTrackForCompositionTrack_XHandle, forCompositionTrack__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<AVAssetTrack> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selCompatibleTrackForCompositionTrack_XHandle, forCompositionTrack__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (forCompositionTrack);
			return ret!;
		}
		/// <param name="url">To be added.</param><param name="options">To be added.</param><summary>Creates a new <see cref="T:AVFoundation.AVUrlAsset" /> for the specified <paramref name="url" /> and <paramref name="options" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static AVUrlAsset Create (NSUrl url, AVUrlAssetOptions? options)
		{
			return FromUrl (url, options.GetDictionary ());
		}
		/// <param name="url">To be added.</param><summary>Creates a new <see cref="T:AVFoundation.AVUrlAsset" /> for the specified <paramref name="url" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static AVUrlAsset Create (NSUrl url)
		{
			return FromUrl (url, (NSDictionary) null!);
		}
		[Export ("contentKeySession:didProvideContentKey:")]
		[SupportedOSPlatform ("tvos14.5")]
		[SupportedOSPlatform ("ios14.5")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidProvideContentKey (AVContentKeySession contentKeySession, AVContentKey contentKey)
		{
			var contentKeySession__handle__ = contentKeySession!.GetNonNullHandle (nameof (contentKeySession));
			var contentKey__handle__ = contentKey!.GetNonNullHandle (nameof (contentKey));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selContentKeySession_DidProvideContentKey_XHandle, contentKeySession__handle__, contentKey__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selContentKeySession_DidProvideContentKey_XHandle, contentKeySession__handle__, contentKey__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (contentKeySession);
			GC.KeepAlive (contentKey);
		}
		[Export ("findCompatibleTrackForCompositionTrack:completionHandler:")]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void FindCompatibleTrack (AVCompositionTrack compositionTrack, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V21))]global::System.Action<AVAssetTrack, NSError> completionHandler)
		{
			var compositionTrack__handle__ = compositionTrack!.GetNonNullHandle (nameof (compositionTrack));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity2V21.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selFindCompatibleTrackForCompositionTrack_CompletionHandler_XHandle, compositionTrack__handle__, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selFindCompatibleTrackForCompositionTrack_CompletionHandler_XHandle, compositionTrack__handle__, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (compositionTrack);
		}
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<AVAssetTrack> FindCompatibleTrackAsync (AVCompositionTrack compositionTrack)
		{
			var tcs = new TaskCompletionSource<AVAssetTrack> ();
			FindCompatibleTrack(compositionTrack, (arg1_, arg2_) => {
				if (arg2_ is not null)
					tcs.SetException (new NSErrorException(arg2_));
				else
					tcs.SetResult (arg1_!);
			});
			return tcs.Task;
		}
		[Export ("URLAssetWithURL:options:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Advice (@"Use constructor or 'Create' method instead.")]
		internal static AVUrlAsset FromUrl (NSUrl url, NSDictionary? options)
		{
			var url__handle__ = url!.GetNonNullHandle (nameof (url));
			var options__handle__ = options.GetHandle ();
			AVUrlAsset? ret;
			ret =  Runtime.GetNSObject<AVUrlAsset> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (class_ptr, selURLAssetWithURL_Options_XHandle, url__handle__, options__handle__), false)!;
			GC.KeepAlive (url);
			GC.KeepAlive (options);
			return ret!;
		}
		[Export ("isPlayableExtendedMIMEType:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool IsPlayable (string extendedMimeType)
		{
			if (extendedMimeType is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (extendedMimeType));
			var nsextendedMimeType = CFString.CreateNative (extendedMimeType);
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (class_ptr, selIsPlayableExtendedMIMEType_XHandle, nsextendedMimeType);
			CFString.ReleaseNative (nsextendedMimeType);
			return ret != 0;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		public static global::UniformTypeIdentifiers.UTType[] AudiovisualContentTypes {
			[Export ("audiovisualContentTypes", ArgumentSemantic.Copy)]
			get {
				global::UniformTypeIdentifiers.UTType[]? ret;
				ret = CFArray.ArrayFromHandle<global::UniformTypeIdentifiers.UTType>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selAudiovisualContentTypesXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string[] AudiovisualMimeTypes {
			[Export ("audiovisualMIMETypes")]
			get {
				string[] ret;
				ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selAudiovisualMIMETypesXHandle), false)!;
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[ObsoletedOSPlatform ("maccatalyst26.0", "Use 'AudioVisualContentTypes' instead.")]
		[ObsoletedOSPlatform ("ios26.0", "Use 'AudioVisualContentTypes' instead.")]
		[ObsoletedOSPlatform ("tvos26.0", "Use 'AudioVisualContentTypes' instead.")]
		[ObsoletedOSPlatform ("macos26.0", "Use 'AudioVisualContentTypes' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		public static string[] AudiovisualTypes {
			[Export ("audiovisualTypes")]
			get {
				string[] ret;
				ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selAudiovisualTypesXHandle), false)!;
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual AVAssetCache? Cache {
			[Export ("assetCache")]
			get {
				AVAssetCache? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<AVAssetCache> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selAssetCacheXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<AVAssetCache> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selAssetCacheXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		public virtual NSUuid HttpSessionIdentifier {
			[Export ("httpSessionIdentifier")]
			get {
				NSUuid? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSUuid> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selHttpSessionIdentifierXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSUuid> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selHttpSessionIdentifierXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		public virtual bool MayRequireContentKeysForMediaDataProcessing {
			[Export ("mayRequireContentKeysForMediaDataProcessing")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selMayRequireContentKeysForMediaDataProcessingXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selMayRequireContentKeysForMediaDataProcessingXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos15.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		public virtual AVMediaExtensionProperties? MediaExtensionProperties {
			[Export ("mediaExtensionProperties")]
			get {
				AVMediaExtensionProperties? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<AVMediaExtensionProperties> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selMediaExtensionPropertiesXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<AVMediaExtensionProperties> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selMediaExtensionPropertiesXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual AVAssetResourceLoader ResourceLoader {
			[Export ("resourceLoader")]
			get {
				AVAssetResourceLoader? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<AVAssetResourceLoader> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selResourceLoaderXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<AVAssetResourceLoader> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selResourceLoaderXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos26.0")]
		public virtual NSUrl? SidecarUrl {
			[Export ("sidecarURL")]
			get {
				NSUrl? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSUrl> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selSidecarURLXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSUrl> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selSidecarURLXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSUrl Url {
			[Export ("URL", ArgumentSemantic.Copy)]
			get {
				NSUrl? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSUrl> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selURLXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSUrl> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selURLXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public virtual AVAssetVariant[] Variants {
			[Export ("variants")]
			get {
				AVAssetVariant[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<AVAssetVariant>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selVariantsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<AVAssetVariant>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selVariantsXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AllowsCellularAccessKey;
		/// <summary>Represents the value associated with the AVURLAssetAllowsCellularAccessKey constant.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("AVURLAssetAllowsCellularAccessKey",  "AVFoundation")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString AllowsCellularAccessKey {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_AllowsCellularAccessKey is null)
					_AllowsCellularAccessKey = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVURLAssetAllowsCellularAccessKey")!;
				return _AllowsCellularAccessKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AllowsConstrainedNetworkAccessKey;
		/// <summary>Represents the value associated with the constant 'AVURLAssetAllowsConstrainedNetworkAccessKey'.</summary>
		[Field ("AVURLAssetAllowsConstrainedNetworkAccessKey",  "AVFoundation")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString AllowsConstrainedNetworkAccessKey {
			[SupportedOSPlatform ("tvos13.0")]
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_AllowsConstrainedNetworkAccessKey is null)
					_AllowsConstrainedNetworkAccessKey = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVURLAssetAllowsConstrainedNetworkAccessKey")!;
				return _AllowsConstrainedNetworkAccessKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AllowsExpensiveNetworkAccessKey;
		/// <summary>Represents the value associated with the constant 'AVURLAssetAllowsExpensiveNetworkAccessKey'.</summary>
		[Field ("AVURLAssetAllowsExpensiveNetworkAccessKey",  "AVFoundation")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString AllowsExpensiveNetworkAccessKey {
			[SupportedOSPlatform ("tvos13.0")]
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_AllowsExpensiveNetworkAccessKey is null)
					_AllowsExpensiveNetworkAccessKey = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVURLAssetAllowsExpensiveNetworkAccessKey")!;
				return _AllowsExpensiveNetworkAccessKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _HttpCookiesKey;
		/// <summary>Represents the value associated with the constant AVURLAssetHTTPCookiesKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVURLAssetHTTPCookiesKey",  "AVFoundation")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString HttpCookiesKey {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_HttpCookiesKey is null)
					_HttpCookiesKey = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVURLAssetHTTPCookiesKey")!;
				return _HttpCookiesKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _HttpUserAgentKey;
		/// <summary>Represents the value associated with the constant 'AVURLAssetHTTPUserAgentKey'.</summary>
		[Field ("AVURLAssetHTTPUserAgentKey",  "AVFoundation")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		public static NSString HttpUserAgentKey {
			[SupportedOSPlatform ("maccatalyst16.0")]
			[SupportedOSPlatform ("tvos16.0")]
			[SupportedOSPlatform ("macos13.0")]
			[SupportedOSPlatform ("ios16.0")]
			get {
				if (_HttpUserAgentKey is null)
					_HttpUserAgentKey = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVURLAssetHTTPUserAgentKey")!;
				return _HttpUserAgentKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _OverrideMimeTypeKey;
		/// <summary>Represents the value associated with the constant 'AVURLAssetOverrideMIMETypeKey'.</summary>
		[Field ("AVURLAssetOverrideMIMETypeKey",  "AVFoundation")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		public static NSString OverrideMimeTypeKey {
			[SupportedOSPlatform ("maccatalyst17.0")]
			[SupportedOSPlatform ("tvos17.0")]
			[SupportedOSPlatform ("macos14.0")]
			[SupportedOSPlatform ("ios17.0")]
			get {
				if (_OverrideMimeTypeKey is null)
					_OverrideMimeTypeKey = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVURLAssetOverrideMIMETypeKey")!;
				return _OverrideMimeTypeKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _PreferPreciseDurationAndTimingKey;
		/// <summary>Represents the value associated with the constant AVURLAssetPreferPreciseDurationAndTimingKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVURLAssetPreferPreciseDurationAndTimingKey",  "AVFoundation")]
		public static NSString PreferPreciseDurationAndTimingKey {
			get {
				if (_PreferPreciseDurationAndTimingKey is null)
					_PreferPreciseDurationAndTimingKey = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVURLAssetPreferPreciseDurationAndTimingKey")!;
				return _PreferPreciseDurationAndTimingKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _PrimarySessionIdentifierKey;
		/// <summary>Represents the value associated with the constant 'AVURLAssetPrimarySessionIdentifierKey'.</summary>
		[Field ("AVURLAssetPrimarySessionIdentifierKey",  "AVFoundation")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		public static NSString PrimarySessionIdentifierKey {
			[SupportedOSPlatform ("maccatalyst16.0")]
			[SupportedOSPlatform ("tvos16.0")]
			[SupportedOSPlatform ("macos13.0")]
			[SupportedOSPlatform ("ios16.0")]
			get {
				if (_PrimarySessionIdentifierKey is null)
					_PrimarySessionIdentifierKey = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVURLAssetPrimarySessionIdentifierKey")!;
				return _PrimarySessionIdentifierKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ReferenceRestrictionsKey;
		/// <summary>Represents the value associated with the constant AVURLAssetReferenceRestrictionsKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVURLAssetReferenceRestrictionsKey",  "AVFoundation")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString ReferenceRestrictionsKey {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_ReferenceRestrictionsKey is null)
					_ReferenceRestrictionsKey = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVURLAssetReferenceRestrictionsKey")!;
				return _ReferenceRestrictionsKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _RequestAttributionKey;
		/// <summary>Represents the value associated with the constant 'AVURLAssetURLRequestAttributionKey'.</summary>
		[Field ("AVURLAssetURLRequestAttributionKey",  "AVFoundation")]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString RequestAttributionKey {
			[SupportedOSPlatform ("tvos15.0")]
			[SupportedOSPlatform ("ios15.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_RequestAttributionKey is null)
					_RequestAttributionKey = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVURLAssetURLRequestAttributionKey")!;
				return _RequestAttributionKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ShouldParseExternalSphericalTagsKey;
		/// <summary>Represents the value associated with the constant 'AVURLAssetShouldParseExternalSphericalTagsKey'.</summary>
		[Field ("AVURLAssetShouldParseExternalSphericalTagsKey",  "AVFoundation")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		public static NSString ShouldParseExternalSphericalTagsKey {
			[SupportedOSPlatform ("maccatalyst26.0")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos26.0")]
			[SupportedOSPlatform ("ios26.0")]
			get {
				if (_ShouldParseExternalSphericalTagsKey is null)
					_ShouldParseExternalSphericalTagsKey = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVURLAssetShouldParseExternalSphericalTagsKey")!;
				return _ShouldParseExternalSphericalTagsKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ShouldSupportAliasDataReferencesKey;
		/// <summary>Represents the value associated with the constant 'AVURLAssetShouldSupportAliasDataReferencesKey'.</summary>
		[Field ("AVURLAssetShouldSupportAliasDataReferencesKey",  "AVFoundation")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString ShouldSupportAliasDataReferencesKey {
			[UnsupportedOSPlatform ("tvos")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_ShouldSupportAliasDataReferencesKey is null)
					_ShouldSupportAliasDataReferencesKey = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVURLAssetShouldSupportAliasDataReferencesKey")!;
				return _ShouldSupportAliasDataReferencesKey;
			}
		}
	} /* class AVUrlAsset */
}
