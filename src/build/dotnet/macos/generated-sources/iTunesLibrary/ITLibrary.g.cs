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
namespace iTunesLibrary {
	[Register("ITLibrary", true)]
	public unsafe partial class ITLibrary : NSObject {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAllMediaItemsX = "allMediaItems";
		static readonly NativeHandle selAllMediaItemsXHandle = Selector.GetHandle ("allMediaItems");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAllPlaylistsX = "allPlaylists";
		static readonly NativeHandle selAllPlaylistsXHandle = Selector.GetHandle ("allPlaylists");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selApiMajorVersionX = "apiMajorVersion";
		static readonly NativeHandle selApiMajorVersionXHandle = Selector.GetHandle ("apiMajorVersion");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selApiMinorVersionX = "apiMinorVersion";
		static readonly NativeHandle selApiMinorVersionXHandle = Selector.GetHandle ("apiMinorVersion");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selApplicationVersionX = "applicationVersion";
		static readonly NativeHandle selApplicationVersionXHandle = Selector.GetHandle ("applicationVersion");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selArtworkForMediaFile_X = "artworkForMediaFile:";
		static readonly NativeHandle selArtworkForMediaFile_XHandle = Selector.GetHandle ("artworkForMediaFile:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFeaturesX = "features";
		static readonly NativeHandle selFeaturesXHandle = Selector.GetHandle ("features");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithAPIVersion_Error_X = "initWithAPIVersion:error:";
		static readonly NativeHandle selInitWithAPIVersion_Error_XHandle = Selector.GetHandle ("initWithAPIVersion:error:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithAPIVersion_Options_Error_X = "initWithAPIVersion:options:error:";
		static readonly NativeHandle selInitWithAPIVersion_Options_Error_XHandle = Selector.GetHandle ("initWithAPIVersion:options:error:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLibraryWithAPIVersion_Error_X = "libraryWithAPIVersion:error:";
		static readonly NativeHandle selLibraryWithAPIVersion_Error_XHandle = Selector.GetHandle ("libraryWithAPIVersion:error:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLibraryWithAPIVersion_Options_Error_X = "libraryWithAPIVersion:options:error:";
		static readonly NativeHandle selLibraryWithAPIVersion_Options_Error_XHandle = Selector.GetHandle ("libraryWithAPIVersion:options:error:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMediaFolderLocationX = "mediaFolderLocation";
		static readonly NativeHandle selMediaFolderLocationXHandle = Selector.GetHandle ("mediaFolderLocation");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMusicFolderLocationX = "musicFolderLocation";
		static readonly NativeHandle selMusicFolderLocationXHandle = Selector.GetHandle ("musicFolderLocation");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selReloadDataX = "reloadData";
		static readonly NativeHandle selReloadDataXHandle = Selector.GetHandle ("reloadData");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selShouldShowContentRatingX = "shouldShowContentRating";
		static readonly NativeHandle selShouldShowContentRatingXHandle = Selector.GetHandle ("shouldShowContentRating");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selUnloadDataX = "unloadData";
		static readonly NativeHandle selUnloadDataXHandle = Selector.GetHandle ("unloadData");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("ITLibrary");
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
		protected ITLibrary (NSObjectFlag t) : base (t)
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
		protected internal ITLibrary (NativeHandle handle) : base (handle)
		{
		}

		/// <param name="requestedAPIVersion">To be added.</param><param name="error">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("initWithAPIVersion:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe ITLibrary (string requestedAPIVersion, out NSError? error)
			: base (NSObjectFlag.Empty)
		{
			if (requestedAPIVersion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (requestedAPIVersion));
			NativeHandle errorValue = IntPtr.Zero;
			var nsrequestedAPIVersion = CFString.CreateNative (requestedAPIVersion);
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_ref_NativeHandle (this.Handle, selInitWithAPIVersion_Error_XHandle, nsrequestedAPIVersion, &errorValue), "initWithAPIVersion:error:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_ref_NativeHandle (&__objc_super__, selInitWithAPIVersion_Error_XHandle, nsrequestedAPIVersion, &errorValue), "initWithAPIVersion:error:");
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsrequestedAPIVersion);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
		}
		/// <param name="requestedAPIVersion">To be added.</param><param name="options">To be added.</param><param name="error">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("initWithAPIVersion:options:error:")]
		[DesignatedInitializer]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe ITLibrary (string requestedAPIVersion, ITLibInitOptions options, out NSError? error)
			: base (NSObjectFlag.Empty)
		{
			if (requestedAPIVersion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (requestedAPIVersion));
			NativeHandle errorValue = IntPtr.Zero;
			var nsrequestedAPIVersion = CFString.CreateNative (requestedAPIVersion);
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_UIntPtr_ref_NativeHandle (this.Handle, selInitWithAPIVersion_Options_Error_XHandle, nsrequestedAPIVersion, (UIntPtr) (ulong) options, &errorValue), "initWithAPIVersion:options:error:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_UIntPtr_ref_NativeHandle (&__objc_super__, selInitWithAPIVersion_Options_Error_XHandle, nsrequestedAPIVersion, (UIntPtr) (ulong) options, &errorValue), "initWithAPIVersion:options:error:");
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsrequestedAPIVersion);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
		}
		/// <param name="mediaFileUrl">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("artworkForMediaFile:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual ITLibArtwork? GetArtwork (NSUrl mediaFileUrl)
		{
			var mediaFileUrl__handle__ = mediaFileUrl!.GetNonNullHandle (nameof (mediaFileUrl));
			ITLibArtwork? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<ITLibArtwork> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selArtworkForMediaFile_XHandle, mediaFileUrl__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<ITLibArtwork> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selArtworkForMediaFile_XHandle, mediaFileUrl__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (mediaFileUrl);
			return ret!;
		}
		/// <param name="requestedAPIVersion">To be added.</param><param name="error">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("libraryWithAPIVersion:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static ITLibrary? GetLibrary (string requestedAPIVersion, out NSError? error)
		{
			if (requestedAPIVersion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (requestedAPIVersion));
			NativeHandle errorValue = IntPtr.Zero;
			var nsrequestedAPIVersion = CFString.CreateNative (requestedAPIVersion);
			ITLibrary? ret;
			ret =  Runtime.GetNSObject<ITLibrary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_ref_NativeHandle (class_ptr, selLibraryWithAPIVersion_Error_XHandle, nsrequestedAPIVersion, &errorValue), false)!;
			CFString.ReleaseNative (nsrequestedAPIVersion);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		/// <param name="requestedAPIVersion">To be added.</param><param name="options">To be added.</param><param name="error">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("libraryWithAPIVersion:options:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static ITLibrary? GetLibrary (string requestedAPIVersion, ITLibInitOptions options, out NSError? error)
		{
			if (requestedAPIVersion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (requestedAPIVersion));
			NativeHandle errorValue = IntPtr.Zero;
			var nsrequestedAPIVersion = CFString.CreateNative (requestedAPIVersion);
			ITLibrary? ret;
			ret =  Runtime.GetNSObject<ITLibrary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_UIntPtr_ref_NativeHandle (class_ptr, selLibraryWithAPIVersion_Options_Error_XHandle, nsrequestedAPIVersion, (UIntPtr) (ulong) options, &errorValue), false)!;
			CFString.ReleaseNative (nsrequestedAPIVersion);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		/// <summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("reloadData")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ReloadData ()
		{
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selReloadDataXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selReloadDataXHandle);
					GC.KeepAlive (this);
				}
			}
			return ret != 0;
		}
		/// <summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("unloadData")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void UnloadData ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selUnloadDataXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selUnloadDataXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual ITLibMediaItem[] AllMediaItems {
			[Export ("allMediaItems", ArgumentSemantic.Retain)]
			get {
				ITLibMediaItem[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<ITLibMediaItem>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selAllMediaItemsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<ITLibMediaItem>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selAllMediaItemsXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual ITLibPlaylist[] AllPlaylists {
			[Export ("allPlaylists", ArgumentSemantic.Retain)]
			get {
				ITLibPlaylist[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<ITLibPlaylist>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selAllPlaylistsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<ITLibPlaylist>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selAllPlaylistsXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nuint ApiMajorVersion {
			[Export ("apiMajorVersion")]
			get {
				nuint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selApiMajorVersionXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selApiMajorVersionXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nuint ApiMinorVersion {
			[Export ("apiMinorVersion")]
			get {
				nuint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selApiMinorVersionXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selApiMinorVersionXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string ApplicationVersion {
			[Export ("applicationVersion")]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selApplicationVersionXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selApplicationVersionXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual ITLibExportFeature Features {
			[Export ("features", ArgumentSemantic.Assign)]
			get {
				ITLibExportFeature ret;
				if (IsDirectBinding) {
					ret = (iTunesLibrary.ITLibExportFeature) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selFeaturesXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (iTunesLibrary.ITLibExportFeature) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selFeaturesXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSUrl? MediaFolderLocation {
			[Export ("mediaFolderLocation", ArgumentSemantic.Copy)]
			get {
				NSUrl? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSUrl> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selMediaFolderLocationXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSUrl> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selMediaFolderLocationXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSUrl? MusicFolderLocation {
			[Export ("musicFolderLocation", ArgumentSemantic.Copy)]
			get {
				NSUrl? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSUrl> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selMusicFolderLocationXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSUrl> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selMusicFolderLocationXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShowContentRating {
			[Export ("shouldShowContentRating")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selShouldShowContentRatingXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selShouldShowContentRatingXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
	} /* class ITLibrary */
}
