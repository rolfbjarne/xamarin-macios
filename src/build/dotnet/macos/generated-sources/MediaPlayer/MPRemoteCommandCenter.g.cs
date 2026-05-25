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
namespace MediaPlayer {
	/// <summary>Class that handles events from external media players.</summary><remarks>To be added.</remarks><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/MediaPlayer/Reference/MPRemoteCommandCenter_Ref/index.html">Apple documentation for <c>MPRemoteCommandCenter</c></related>
	[Register("MPRemoteCommandCenter", true)]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe partial class MPRemoteCommandCenter : NSObject {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selBookmarkCommandX = "bookmarkCommand";
		static readonly NativeHandle selBookmarkCommandXHandle = Selector.GetHandle ("bookmarkCommand");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selChangePlaybackPositionCommandX = "changePlaybackPositionCommand";
		static readonly NativeHandle selChangePlaybackPositionCommandXHandle = Selector.GetHandle ("changePlaybackPositionCommand");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selChangePlaybackRateCommandX = "changePlaybackRateCommand";
		static readonly NativeHandle selChangePlaybackRateCommandXHandle = Selector.GetHandle ("changePlaybackRateCommand");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selChangeRepeatModeCommandX = "changeRepeatModeCommand";
		static readonly NativeHandle selChangeRepeatModeCommandXHandle = Selector.GetHandle ("changeRepeatModeCommand");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selChangeShuffleModeCommandX = "changeShuffleModeCommand";
		static readonly NativeHandle selChangeShuffleModeCommandXHandle = Selector.GetHandle ("changeShuffleModeCommand");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDisableLanguageOptionCommandX = "disableLanguageOptionCommand";
		static readonly NativeHandle selDisableLanguageOptionCommandXHandle = Selector.GetHandle ("disableLanguageOptionCommand");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDislikeCommandX = "dislikeCommand";
		static readonly NativeHandle selDislikeCommandXHandle = Selector.GetHandle ("dislikeCommand");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selEnableLanguageOptionCommandX = "enableLanguageOptionCommand";
		static readonly NativeHandle selEnableLanguageOptionCommandXHandle = Selector.GetHandle ("enableLanguageOptionCommand");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLikeCommandX = "likeCommand";
		static readonly NativeHandle selLikeCommandXHandle = Selector.GetHandle ("likeCommand");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selNextTrackCommandX = "nextTrackCommand";
		static readonly NativeHandle selNextTrackCommandXHandle = Selector.GetHandle ("nextTrackCommand");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPauseCommandX = "pauseCommand";
		static readonly NativeHandle selPauseCommandXHandle = Selector.GetHandle ("pauseCommand");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPlayCommandX = "playCommand";
		static readonly NativeHandle selPlayCommandXHandle = Selector.GetHandle ("playCommand");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPreviousTrackCommandX = "previousTrackCommand";
		static readonly NativeHandle selPreviousTrackCommandXHandle = Selector.GetHandle ("previousTrackCommand");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRatingCommandX = "ratingCommand";
		static readonly NativeHandle selRatingCommandXHandle = Selector.GetHandle ("ratingCommand");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSeekBackwardCommandX = "seekBackwardCommand";
		static readonly NativeHandle selSeekBackwardCommandXHandle = Selector.GetHandle ("seekBackwardCommand");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSeekForwardCommandX = "seekForwardCommand";
		static readonly NativeHandle selSeekForwardCommandXHandle = Selector.GetHandle ("seekForwardCommand");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSharedCommandCenterX = "sharedCommandCenter";
		static readonly NativeHandle selSharedCommandCenterXHandle = Selector.GetHandle ("sharedCommandCenter");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSkipBackwardCommandX = "skipBackwardCommand";
		static readonly NativeHandle selSkipBackwardCommandXHandle = Selector.GetHandle ("skipBackwardCommand");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSkipForwardCommandX = "skipForwardCommand";
		static readonly NativeHandle selSkipForwardCommandXHandle = Selector.GetHandle ("skipForwardCommand");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selStopCommandX = "stopCommand";
		static readonly NativeHandle selStopCommandXHandle = Selector.GetHandle ("stopCommand");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTogglePlayPauseCommandX = "togglePlayPauseCommand";
		static readonly NativeHandle selTogglePlayPauseCommandXHandle = Selector.GetHandle ("togglePlayPauseCommand");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("MPRemoteCommandCenter");
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
		protected MPRemoteCommandCenter (NSObjectFlag t) : base (t)
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
		protected internal MPRemoteCommandCenter (NativeHandle handle) : base (handle)
		{
		}

		/// <summary>Gets the bookmarking command.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MPFeedbackCommand BookmarkCommand {
			[Export ("bookmarkCommand")]
			get {
				MPFeedbackCommand? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<MPFeedbackCommand> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selBookmarkCommandXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<MPFeedbackCommand> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selBookmarkCommandXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		/// <summary>Gets the command that is used to change the playback position.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual MPChangePlaybackPositionCommand ChangePlaybackPositionCommand {
			[Export ("changePlaybackPositionCommand")]
			get {
				MPChangePlaybackPositionCommand? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<MPChangePlaybackPositionCommand> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selChangePlaybackPositionCommandXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<MPChangePlaybackPositionCommand> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selChangePlaybackPositionCommandXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		/// <summary>Gets the command that is used to change the playback rate.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MPChangePlaybackRateCommand ChangePlaybackRateCommand {
			[Export ("changePlaybackRateCommand")]
			get {
				MPChangePlaybackRateCommand? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<MPChangePlaybackRateCommand> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selChangePlaybackRateCommandXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<MPChangePlaybackRateCommand> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selChangePlaybackRateCommandXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		/// <summary>Gets the command that is used to change the repeat mode.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual MPChangeRepeatModeCommand ChangeRepeatModeCommand {
			[Export ("changeRepeatModeCommand")]
			get {
				MPChangeRepeatModeCommand? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<MPChangeRepeatModeCommand> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selChangeRepeatModeCommandXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<MPChangeRepeatModeCommand> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selChangeRepeatModeCommandXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		/// <summary>Gets the command that is used to change the shuffle mode.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual MPChangeShuffleModeCommand ChangeShuffleModeCommand {
			[Export ("changeShuffleModeCommand")]
			get {
				MPChangeShuffleModeCommand? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<MPChangeShuffleModeCommand> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selChangeShuffleModeCommandXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<MPChangeShuffleModeCommand> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selChangeShuffleModeCommandXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		/// <summary>Gets the command that is used to disable language options.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual MPRemoteCommand DisableLanguageOptionCommand {
			[Export ("disableLanguageOptionCommand")]
			get {
				MPRemoteCommand? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<MPRemoteCommand> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selDisableLanguageOptionCommandXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<MPRemoteCommand> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selDisableLanguageOptionCommandXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		/// <summary>Gets the command that is used to dislike the currently playing item.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MPFeedbackCommand DislikeCommand {
			[Export ("dislikeCommand")]
			get {
				MPFeedbackCommand? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<MPFeedbackCommand> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selDislikeCommandXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<MPFeedbackCommand> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selDislikeCommandXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		/// <summary>Gets the command that is used to enable language options.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual MPRemoteCommand EnableLanguageOptionCommand {
			[Export ("enableLanguageOptionCommand")]
			get {
				MPRemoteCommand? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<MPRemoteCommand> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selEnableLanguageOptionCommandXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<MPRemoteCommand> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selEnableLanguageOptionCommandXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		/// <summary>Gets the command that is used to like the currently playing item.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MPFeedbackCommand LikeCommand {
			[Export ("likeCommand")]
			get {
				MPFeedbackCommand? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<MPFeedbackCommand> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selLikeCommandXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<MPFeedbackCommand> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selLikeCommandXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		/// <summary>Gets the command that is used to play the next track.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MPRemoteCommand NextTrackCommand {
			[Export ("nextTrackCommand")]
			get {
				MPRemoteCommand? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<MPRemoteCommand> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selNextTrackCommandXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<MPRemoteCommand> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selNextTrackCommandXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		/// <summary>Gets the command that is used to pause playback.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MPRemoteCommand PauseCommand {
			[Export ("pauseCommand")]
			get {
				MPRemoteCommand? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<MPRemoteCommand> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selPauseCommandXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<MPRemoteCommand> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selPauseCommandXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		/// <summary>Gets the command that is used to begin or resume playback.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MPRemoteCommand PlayCommand {
			[Export ("playCommand")]
			get {
				MPRemoteCommand? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<MPRemoteCommand> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selPlayCommandXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<MPRemoteCommand> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selPlayCommandXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		/// <summary>Gets the command that is used to play the previous track.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MPRemoteCommand PreviousTrackCommand {
			[Export ("previousTrackCommand")]
			get {
				MPRemoteCommand? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<MPRemoteCommand> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selPreviousTrackCommandXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<MPRemoteCommand> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selPreviousTrackCommandXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		/// <summary>Gets the command that is used to rate the currently playing item.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MPRatingCommand RatingCommand {
			[Export ("ratingCommand")]
			get {
				MPRatingCommand? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<MPRatingCommand> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selRatingCommandXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<MPRatingCommand> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selRatingCommandXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		/// <summary>Gets the command that is used to seek backward.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MPRemoteCommand SeekBackwardCommand {
			[Export ("seekBackwardCommand")]
			get {
				MPRemoteCommand? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<MPRemoteCommand> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selSeekBackwardCommandXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<MPRemoteCommand> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selSeekBackwardCommandXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		/// <summary>Gets the command that is used to seek forward.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MPRemoteCommand SeekForwardCommand {
			[Export ("seekForwardCommand")]
			get {
				MPRemoteCommand? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<MPRemoteCommand> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selSeekForwardCommandXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<MPRemoteCommand> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selSeekForwardCommandXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		/// <summary>Gets the shared command center object.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPRemoteCommandCenter Shared {
			[Export ("sharedCommandCenter")]
			get {
				MPRemoteCommandCenter? ret;
				ret =  Runtime.GetNSObject<MPRemoteCommandCenter> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selSharedCommandCenterXHandle), false)!;
				return ret!;
			}
		}
		/// <summary>Gets the command that is used to skip backward.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MPSkipIntervalCommand SkipBackwardCommand {
			[Export ("skipBackwardCommand")]
			get {
				MPSkipIntervalCommand? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<MPSkipIntervalCommand> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selSkipBackwardCommandXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<MPSkipIntervalCommand> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selSkipBackwardCommandXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		/// <summary>Gets the command that is used to skip forward.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MPSkipIntervalCommand SkipForwardCommand {
			[Export ("skipForwardCommand")]
			get {
				MPSkipIntervalCommand? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<MPSkipIntervalCommand> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selSkipForwardCommandXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<MPSkipIntervalCommand> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selSkipForwardCommandXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		/// <summary>Gets the command that is used to stop playback.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MPRemoteCommand StopCommand {
			[Export ("stopCommand")]
			get {
				MPRemoteCommand? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<MPRemoteCommand> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selStopCommandXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<MPRemoteCommand> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selStopCommandXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		/// <summary>Gets the command that is used to toggle the paused/playing state.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MPRemoteCommand TogglePlayPauseCommand {
			[Export ("togglePlayPauseCommand")]
			get {
				MPRemoteCommand? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<MPRemoteCommand> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selTogglePlayPauseCommandXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<MPRemoteCommand> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selTogglePlayPauseCommandXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
	} /* class MPRemoteCommandCenter */
}
