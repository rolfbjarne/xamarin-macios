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
using UIKit;
using GLKit;
using Metal;
using CoreML;
using MapKit;
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Contacts;
using Security;
using Messages;
using AudioUnit;
using CoreVideo;
using CoreMedia;
using QuickLook;
using CoreImage;
using SpriteKit;
using Foundation;
using CoreMotion;
using ObjCRuntime;
using AddressBook;
using MediaPlayer;
using GameplayKit;
using CoreGraphics;
using CoreLocation;
using AVFoundation;
using NewsstandKit;
using FileProvider;
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;
using MetalPerformanceShadersGraph;
#nullable enable
namespace Intents {
	[Register("INPlayMediaIntent", true)]
	[SupportedOSPlatform ("tvos14.0")]
	[UnsupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	public unsafe partial class INPlayMediaIntent : INIntent {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("INPlayMediaIntent");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		/// <summary>A constructor that initializes the object from the data stored in the unarchiver object.</summary>
		/// <param name="coder">The unarchiver object.</param>
		/// <remarks>
		///   <para>This constructor is provided to allow the class to be initialized from an unarchiver (for example, during NIB deserialization). This is part of the <see cref="Foundation.NSCoding" /> protocol.</para>
		///   <para>If developers want to create a subclass of this object and continue to support deserialization from an archive, they should implement a constructor with an identical signature: taking a single parameter of type <see cref="Foundation.NSCoder" /> and decorate it with the <c>[Export("initWithCoder:"]</c> attribute.</para>
		///   <para>The state of this object can also be serialized by using the <see cref="Foundation.INSCoding.EncodeTo" /> companion method.</para>
		/// </remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[DesignatedInitializer]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("initWithCoder:")]
		public INPlayMediaIntent (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("initWithCoder:"), coder.Handle), "initWithCoder:");
			} else {
				unsafe {
				var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
				InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (&__objc_super__, Selector.GetHandle ("initWithCoder:"), coder.Handle), "initWithCoder:");
				GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (coder);
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
		protected INPlayMediaIntent (NSObjectFlag t) : base (t)
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
		protected internal INPlayMediaIntent (NativeHandle handle) : base (handle)
		{
		}

		[Export ("initWithMediaItems:mediaContainer:playShuffled:playbackRepeatMode:resumePlayback:playbackQueueLocation:playbackSpeed:mediaSearch:")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos14.0")]
		[DesignatedInitializer]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public INPlayMediaIntent (INMediaItem[]? mediaItems, INMediaItem? mediaContainer, [BindAs (typeof (bool?), OriginalType = typeof (NSNumber))] bool? playShuffled, INPlaybackRepeatMode playbackRepeatMode, [BindAs (typeof (bool?), OriginalType = typeof (NSNumber))] bool? resumePlayback, INPlaybackQueueLocation playbackQueueLocation, [BindAs (typeof (double?), OriginalType = typeof (NSNumber))] double? playbackSpeed, INMediaSearch? mediaSearch)
			: base (NSObjectFlag.Empty)
		{
			var mediaContainer__handle__ = mediaContainer.GetHandle ();
			var mediaSearch__handle__ = mediaSearch.GetHandle ();
			using var nsa_mediaItems = mediaItems is null ? null : NSArray.FromNSObjects (mediaItems);
			using var nsb_playShuffled = playShuffled is null ? null : new NSNumber (playShuffled.Value);
			using var nsb_resumePlayback = resumePlayback is null ? null : new NSNumber (resumePlayback.Value);
			using var nsb_playbackSpeed = playbackSpeed is null ? null : new NSNumber (playbackSpeed.Value);
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_IntPtr_NativeHandle_IntPtr_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("initWithMediaItems:mediaContainer:playShuffled:playbackRepeatMode:resumePlayback:playbackQueueLocation:playbackSpeed:mediaSearch:"), nsa_mediaItems.GetHandle (), mediaContainer__handle__, nsb_playShuffled.GetHandle (), (IntPtr) (long) playbackRepeatMode, nsb_resumePlayback.GetHandle (), (IntPtr) (long) playbackQueueLocation, nsb_playbackSpeed.GetHandle (), mediaSearch__handle__), "initWithMediaItems:mediaContainer:playShuffled:playbackRepeatMode:resumePlayback:playbackQueueLocation:playbackSpeed:mediaSearch:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle_IntPtr_NativeHandle_IntPtr_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("initWithMediaItems:mediaContainer:playShuffled:playbackRepeatMode:resumePlayback:playbackQueueLocation:playbackSpeed:mediaSearch:"), nsa_mediaItems.GetHandle (), mediaContainer__handle__, nsb_playShuffled.GetHandle (), (IntPtr) (long) playbackRepeatMode, nsb_resumePlayback.GetHandle (), (IntPtr) (long) playbackQueueLocation, nsb_playbackSpeed.GetHandle (), mediaSearch__handle__), "initWithMediaItems:mediaContainer:playShuffled:playbackRepeatMode:resumePlayback:playbackQueueLocation:playbackSpeed:mediaSearch:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (mediaContainer);
			GC.KeepAlive (mediaSearch);
		}
		[Export ("initWithMediaItems:mediaContainer:playShuffled:playbackRepeatMode:resumePlayback:")]
		[ObsoletedOSPlatform ("ios13.0", "Use the '.ctor (INMediaItem [], INMediaItem, bool?, INPlaybackRepeatMode, bool?, INPlaybackQueueLocation, double?, INMediaSearch)' instead.")]
		[ObsoletedOSPlatform ("tvos13.0", "Use the '.ctor (INMediaItem [], INMediaItem, bool?, INPlaybackRepeatMode, bool?, INPlaybackQueueLocation, double?, INMediaSearch)' instead.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use the '.ctor (INMediaItem [], INMediaItem, bool?, INPlaybackRepeatMode, bool?, INPlaybackQueueLocation, double?, INMediaSearch)' instead.")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public INPlayMediaIntent (INMediaItem[]? mediaItems, INMediaItem? mediaContainer, [BindAs (typeof (bool?), OriginalType = typeof (NSNumber))] bool? playShuffled, INPlaybackRepeatMode playbackRepeatMode, [BindAs (typeof (bool?), OriginalType = typeof (NSNumber))] bool? resumePlayback)
			: base (NSObjectFlag.Empty)
		{
			var mediaContainer__handle__ = mediaContainer.GetHandle ();
			using var nsa_mediaItems = mediaItems is null ? null : NSArray.FromNSObjects (mediaItems);
			using var nsb_playShuffled = playShuffled is null ? null : new NSNumber (playShuffled.Value);
			using var nsb_resumePlayback = resumePlayback is null ? null : new NSNumber (resumePlayback.Value);
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_IntPtr_NativeHandle (this.Handle, Selector.GetHandle ("initWithMediaItems:mediaContainer:playShuffled:playbackRepeatMode:resumePlayback:"), nsa_mediaItems.GetHandle (), mediaContainer__handle__, nsb_playShuffled.GetHandle (), (IntPtr) (long) playbackRepeatMode, nsb_resumePlayback.GetHandle ()), "initWithMediaItems:mediaContainer:playShuffled:playbackRepeatMode:resumePlayback:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle_IntPtr_NativeHandle (&__objc_super__, Selector.GetHandle ("initWithMediaItems:mediaContainer:playShuffled:playbackRepeatMode:resumePlayback:"), nsa_mediaItems.GetHandle (), mediaContainer__handle__, nsb_playShuffled.GetHandle (), (IntPtr) (long) playbackRepeatMode, nsb_resumePlayback.GetHandle ()), "initWithMediaItems:mediaContainer:playShuffled:playbackRepeatMode:resumePlayback:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (mediaContainer);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual INMediaItem? MediaContainer {
			[Export ("mediaContainer", ArgumentSemantic.Copy)]
			get {
				INMediaItem? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<INMediaItem> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("mediaContainer")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<INMediaItem> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("mediaContainer")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual INMediaItem[]? MediaItems {
			[Export ("mediaItems", ArgumentSemantic.Copy)]
			get {
				INMediaItem[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<INMediaItem>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("mediaItems")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<INMediaItem>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("mediaItems")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos14.0")]
		public virtual INMediaSearch? MediaSearch {
			[Export ("mediaSearch", ArgumentSemantic.Copy)]
			get {
				INMediaSearch? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<INMediaSearch> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("mediaSearch")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<INMediaSearch> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("mediaSearch")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[BindAs (typeof (bool?), OriginalType = typeof (NSNumber))]
		public virtual bool? PlayShuffled {
			[Export ("playShuffled", ArgumentSemantic.Copy)]
			get {
				bool? ret;
				if (IsDirectBinding) {
					ret = Runtime.GetNSObject<NSNumber> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("playShuffled")), false)?.BoolValue;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = Runtime.GetNSObject<NSNumber> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("playShuffled")), false)?.BoolValue;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos14.0")]
		public virtual INPlaybackQueueLocation PlaybackQueueLocation {
			[Export ("playbackQueueLocation", ArgumentSemantic.Assign)]
			get {
				INPlaybackQueueLocation ret;
				if (IsDirectBinding) {
					ret = (Intents.INPlaybackQueueLocation) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("playbackQueueLocation"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (Intents.INPlaybackQueueLocation) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("playbackQueueLocation"));
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual INPlaybackRepeatMode PlaybackRepeatMode {
			[Export ("playbackRepeatMode", ArgumentSemantic.Assign)]
			get {
				INPlaybackRepeatMode ret;
				if (IsDirectBinding) {
					ret = (Intents.INPlaybackRepeatMode) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("playbackRepeatMode"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (Intents.INPlaybackRepeatMode) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("playbackRepeatMode"));
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos14.0")]
		[BindAs (typeof (double?), OriginalType = typeof (NSNumber))]
		public virtual double? PlaybackSpeed {
			[Export ("playbackSpeed", ArgumentSemantic.Copy)]
			get {
				double? ret;
				if (IsDirectBinding) {
					ret = Runtime.GetNSObject<NSNumber> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("playbackSpeed")), false)?.DoubleValue;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = Runtime.GetNSObject<NSNumber> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("playbackSpeed")), false)?.DoubleValue;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[BindAs (typeof (bool?), OriginalType = typeof (NSNumber))]
		public virtual bool? ResumePlayback {
			[Export ("resumePlayback", ArgumentSemantic.Copy)]
			get {
				bool? ret;
				if (IsDirectBinding) {
					ret = Runtime.GetNSObject<NSNumber> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("resumePlayback")), false)?.BoolValue;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = Runtime.GetNSObject<NSNumber> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("resumePlayback")), false)?.BoolValue;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
	} /* class INPlayMediaIntent */
}
