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
namespace MediaPlayer {
	[Register("MPMediaItem", true)]
	public unsafe partial class MPMediaItem : MPMediaEntity {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("MPMediaItem");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		/// <summary>Creates a new <see cref="MPMediaItem" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public MPMediaItem () : base (NSObjectFlag.Empty)
		{
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			} else {
				unsafe {
				var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
				InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
				GC.KeepAlive (this);
				}
			}
		}

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
		public MPMediaItem (NSCoder coder) : base (NSObjectFlag.Empty)
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
		protected MPMediaItem (NSObjectFlag t) : base (t)
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
		protected internal MPMediaItem (NativeHandle handle) : base (handle)
		{
		}

		/// <param name="groupingType">Grouping type.</param><summary>Returns the persistent ID for the specified grouping type.</summary><returns></returns><remarks></remarks>
		[Export ("persistentIDPropertyForGroupingType:")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string GetPersistentIDProperty (MPMediaGrouping groupingType)
		{
			string ret;
			ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("persistentIDPropertyForGroupingType:"), (IntPtr) (long) groupingType), false)!;
			return ret;
		}
		/// <param name="groupingType">Grouping type.</param><summary>Returns the title for the specified grouping type</summary><returns></returns><remarks></remarks>
		[Export ("titlePropertyForGroupingType:")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string GetTitleProperty (MPMediaGrouping groupingType)
		{
			string ret;
			ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("titlePropertyForGroupingType:"), (IntPtr) (long) groupingType), false)!;
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AlbumArtistPersistentIDProperty;
		/// <summary>Represents the value associated with the constant MPMediaItemPropertyAlbumArtistPersistentID</summary><value></value><remarks>
		/// 	  Persistent IDs can be used as unique identifiers across
		/// 	  application launches and as long as the media item has not
		/// 	  been changed or synchronized again with the host computer.
		/// 	</remarks>
		[EditorBrowsable (EditorBrowsableState.Never)]
		[Field ("MPMediaItemPropertyAlbumArtistPersistentID",  "MediaPlayer")]
		public static NSString AlbumArtistPersistentIDProperty {
			get {
				if (_AlbumArtistPersistentIDProperty is null)
					_AlbumArtistPersistentIDProperty = Dlfcn.GetStringConstant (Libraries.MediaPlayer.Handle, "MPMediaItemPropertyAlbumArtistPersistentID")!;
				return _AlbumArtistPersistentIDProperty;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AlbumArtistProperty;
		/// <summary>Represents the value associated with the constant MPMediaItemPropertyAlbumArtist</summary><value></value><remarks></remarks>
		[EditorBrowsable (EditorBrowsableState.Never)]
		[Field ("MPMediaItemPropertyAlbumArtist",  "MediaPlayer")]
		public static NSString AlbumArtistProperty {
			get {
				if (_AlbumArtistProperty is null)
					_AlbumArtistProperty = Dlfcn.GetStringConstant (Libraries.MediaPlayer.Handle, "MPMediaItemPropertyAlbumArtist")!;
				return _AlbumArtistProperty;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AlbumPersistentIDProperty;
		/// <summary>Represents the value associated with the constant MPMediaItemPropertyAlbumPersistentID</summary><value></value><remarks>
		/// 	  Persistent IDs can be used as unique identifiers across
		/// 	  application launches and as long as the media item has not
		/// 	  been changed or synchronized again with the host computer.
		/// 	</remarks>
		[EditorBrowsable (EditorBrowsableState.Never)]
		[Field ("MPMediaItemPropertyAlbumPersistentID",  "MediaPlayer")]
		public static NSString AlbumPersistentIDProperty {
			get {
				if (_AlbumPersistentIDProperty is null)
					_AlbumPersistentIDProperty = Dlfcn.GetStringConstant (Libraries.MediaPlayer.Handle, "MPMediaItemPropertyAlbumPersistentID")!;
				return _AlbumPersistentIDProperty;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AlbumTitleProperty;
		/// <summary>Represents the value associated with the constant MPMediaItemPropertyAlbumTitle</summary><value></value><remarks></remarks>
		[EditorBrowsable (EditorBrowsableState.Never)]
		[Field ("MPMediaItemPropertyAlbumTitle",  "MediaPlayer")]
		public static NSString AlbumTitleProperty {
			get {
				if (_AlbumTitleProperty is null)
					_AlbumTitleProperty = Dlfcn.GetStringConstant (Libraries.MediaPlayer.Handle, "MPMediaItemPropertyAlbumTitle")!;
				return _AlbumTitleProperty;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AlbumTrackCountProperty;
		/// <summary>Represents the value associated with the constant MPMediaItemPropertyAlbumTrackCount</summary><value></value><remarks></remarks>
		[EditorBrowsable (EditorBrowsableState.Never)]
		[Field ("MPMediaItemPropertyAlbumTrackCount",  "MediaPlayer")]
		public static NSString AlbumTrackCountProperty {
			get {
				if (_AlbumTrackCountProperty is null)
					_AlbumTrackCountProperty = Dlfcn.GetStringConstant (Libraries.MediaPlayer.Handle, "MPMediaItemPropertyAlbumTrackCount")!;
				return _AlbumTrackCountProperty;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AlbumTrackNumberProperty;
		/// <summary>Represents the value associated with the constant MPMediaItemPropertyAlbumTrackNumber</summary><value></value><remarks></remarks>
		[EditorBrowsable (EditorBrowsableState.Never)]
		[Field ("MPMediaItemPropertyAlbumTrackNumber",  "MediaPlayer")]
		public static NSString AlbumTrackNumberProperty {
			get {
				if (_AlbumTrackNumberProperty is null)
					_AlbumTrackNumberProperty = Dlfcn.GetStringConstant (Libraries.MediaPlayer.Handle, "MPMediaItemPropertyAlbumTrackNumber")!;
				return _AlbumTrackNumberProperty;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ArtistPersistentIDProperty;
		/// <summary>Represents the value associated with the constant MPMediaItemPropertyArtistPersistentID</summary><value></value><remarks></remarks>
		[EditorBrowsable (EditorBrowsableState.Never)]
		[Field ("MPMediaItemPropertyArtistPersistentID",  "MediaPlayer")]
		public static NSString ArtistPersistentIDProperty {
			get {
				if (_ArtistPersistentIDProperty is null)
					_ArtistPersistentIDProperty = Dlfcn.GetStringConstant (Libraries.MediaPlayer.Handle, "MPMediaItemPropertyArtistPersistentID")!;
				return _ArtistPersistentIDProperty;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ArtistProperty;
		/// <summary>Represents the value associated with the constant MPMediaItemPropertyArtist</summary><value></value><remarks></remarks>
		[EditorBrowsable (EditorBrowsableState.Never)]
		[Field ("MPMediaItemPropertyArtist",  "MediaPlayer")]
		public static NSString ArtistProperty {
			get {
				if (_ArtistProperty is null)
					_ArtistProperty = Dlfcn.GetStringConstant (Libraries.MediaPlayer.Handle, "MPMediaItemPropertyArtist")!;
				return _ArtistProperty;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ArtworkProperty;
		/// <summary>Represents the value associated with the constant MPMediaItemPropertyArtwork</summary><value></value><remarks></remarks>
		[EditorBrowsable (EditorBrowsableState.Never)]
		[Field ("MPMediaItemPropertyArtwork",  "MediaPlayer")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString ArtworkProperty {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_ArtworkProperty is null)
					_ArtworkProperty = Dlfcn.GetStringConstant (Libraries.MediaPlayer.Handle, "MPMediaItemPropertyArtwork")!;
				return _ArtworkProperty;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AssetURLProperty;
		/// <summary>Represents the value associated with the constant MPMediaItemPropertyAssetURL</summary><value></value><remarks></remarks>
		[EditorBrowsable (EditorBrowsableState.Never)]
		[Field ("MPMediaItemPropertyAssetURL",  "MediaPlayer")]
		public static NSString AssetURLProperty {
			get {
				if (_AssetURLProperty is null)
					_AssetURLProperty = Dlfcn.GetStringConstant (Libraries.MediaPlayer.Handle, "MPMediaItemPropertyAssetURL")!;
				return _AssetURLProperty;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _BeatsPerMinuteProperty;
		/// <summary>Represents the value associated with the constant MPMediaItemPropertyBeatsPerMinute</summary><value></value><remarks></remarks>
		[EditorBrowsable (EditorBrowsableState.Never)]
		[Field ("MPMediaItemPropertyBeatsPerMinute",  "MediaPlayer")]
		public static NSString BeatsPerMinuteProperty {
			get {
				if (_BeatsPerMinuteProperty is null)
					_BeatsPerMinuteProperty = Dlfcn.GetStringConstant (Libraries.MediaPlayer.Handle, "MPMediaItemPropertyBeatsPerMinute")!;
				return _BeatsPerMinuteProperty;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _BookmarkTimeProperty;
		/// <summary>Represents the value associated with the constant MPMediaItemPropertyBookmarkTime</summary><value></value><remarks></remarks>
		[EditorBrowsable (EditorBrowsableState.Never)]
		[Field ("MPMediaItemPropertyBookmarkTime",  "MediaPlayer")]
		public static NSString BookmarkTimeProperty {
			get {
				if (_BookmarkTimeProperty is null)
					_BookmarkTimeProperty = Dlfcn.GetStringConstant (Libraries.MediaPlayer.Handle, "MPMediaItemPropertyBookmarkTime")!;
				return _BookmarkTimeProperty;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CommentsProperty;
		/// <summary>Represents the value associated with the constant MPMediaItemPropertyComments</summary><value></value><remarks></remarks>
		[EditorBrowsable (EditorBrowsableState.Never)]
		[Field ("MPMediaItemPropertyComments",  "MediaPlayer")]
		public static NSString CommentsProperty {
			get {
				if (_CommentsProperty is null)
					_CommentsProperty = Dlfcn.GetStringConstant (Libraries.MediaPlayer.Handle, "MPMediaItemPropertyComments")!;
				return _CommentsProperty;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ComposerPersistentIDProperty;
		/// <summary>Represents the value associated with the constant MPMediaItemPropertyComposerPersistentID</summary><value></value><remarks></remarks>
		[EditorBrowsable (EditorBrowsableState.Never)]
		[Field ("MPMediaItemPropertyComposerPersistentID",  "MediaPlayer")]
		public static NSString ComposerPersistentIDProperty {
			get {
				if (_ComposerPersistentIDProperty is null)
					_ComposerPersistentIDProperty = Dlfcn.GetStringConstant (Libraries.MediaPlayer.Handle, "MPMediaItemPropertyComposerPersistentID")!;
				return _ComposerPersistentIDProperty;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ComposerProperty;
		/// <summary>Represents the value associated with the constant MPMediaItemPropertyComposer</summary><value></value><remarks></remarks>
		[EditorBrowsable (EditorBrowsableState.Never)]
		[Field ("MPMediaItemPropertyComposer",  "MediaPlayer")]
		public static NSString ComposerProperty {
			get {
				if (_ComposerProperty is null)
					_ComposerProperty = Dlfcn.GetStringConstant (Libraries.MediaPlayer.Handle, "MPMediaItemPropertyComposer")!;
				return _ComposerProperty;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DateAddedProperty;
		/// <summary>The value that is associated with the MPMediaItemPropertyDateAdded constant.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[EditorBrowsable (EditorBrowsableState.Never)]
		[Field ("MPMediaItemPropertyDateAdded",  "MediaPlayer")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString DateAddedProperty {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_DateAddedProperty is null)
					_DateAddedProperty = Dlfcn.GetStringConstant (Libraries.MediaPlayer.Handle, "MPMediaItemPropertyDateAdded")!;
				return _DateAddedProperty;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DiscCountProperty;
		/// <summary>Represents the value associated with the constant MPMediaItemPropertyDiscCount</summary><value></value><remarks></remarks>
		[EditorBrowsable (EditorBrowsableState.Never)]
		[Field ("MPMediaItemPropertyDiscCount",  "MediaPlayer")]
		public static NSString DiscCountProperty {
			get {
				if (_DiscCountProperty is null)
					_DiscCountProperty = Dlfcn.GetStringConstant (Libraries.MediaPlayer.Handle, "MPMediaItemPropertyDiscCount")!;
				return _DiscCountProperty;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DiscNumberProperty;
		/// <summary>Represents the value associated with the constant MPMediaItemPropertyDiscNumber</summary><value></value><remarks></remarks>
		[EditorBrowsable (EditorBrowsableState.Never)]
		[Field ("MPMediaItemPropertyDiscNumber",  "MediaPlayer")]
		public static NSString DiscNumberProperty {
			get {
				if (_DiscNumberProperty is null)
					_DiscNumberProperty = Dlfcn.GetStringConstant (Libraries.MediaPlayer.Handle, "MPMediaItemPropertyDiscNumber")!;
				return _DiscNumberProperty;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _GenrePersistentIDProperty;
		/// <summary>Represents the value associated with the constant MPMediaItemPropertyGenrePersistentID</summary><value></value><remarks></remarks>
		[EditorBrowsable (EditorBrowsableState.Never)]
		[Field ("MPMediaItemPropertyGenrePersistentID",  "MediaPlayer")]
		public static NSString GenrePersistentIDProperty {
			get {
				if (_GenrePersistentIDProperty is null)
					_GenrePersistentIDProperty = Dlfcn.GetStringConstant (Libraries.MediaPlayer.Handle, "MPMediaItemPropertyGenrePersistentID")!;
				return _GenrePersistentIDProperty;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _GenreProperty;
		/// <summary>Represents the value associated with the constant MPMediaItemPropertyGenre</summary><value></value><remarks></remarks>
		[EditorBrowsable (EditorBrowsableState.Never)]
		[Field ("MPMediaItemPropertyGenre",  "MediaPlayer")]
		public static NSString GenreProperty {
			get {
				if (_GenreProperty is null)
					_GenreProperty = Dlfcn.GetStringConstant (Libraries.MediaPlayer.Handle, "MPMediaItemPropertyGenre")!;
				return _GenreProperty;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _HasProtectedAssetProperty;
		/// <summary>The value that is associated with the MPMediaItemPropertyHasProtectedAsset constant.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[EditorBrowsable (EditorBrowsableState.Never)]
		[Field ("MPMediaItemPropertyHasProtectedAsset",  "MediaPlayer")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString HasProtectedAssetProperty {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_HasProtectedAssetProperty is null)
					_HasProtectedAssetProperty = Dlfcn.GetStringConstant (Libraries.MediaPlayer.Handle, "MPMediaItemPropertyHasProtectedAsset")!;
				return _HasProtectedAssetProperty;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IsCloudItemProperty;
		/// <summary>Represents the value associated with the constant MPMediaItemPropertyIsCloudItem</summary><value></value><remarks></remarks>
		[EditorBrowsable (EditorBrowsableState.Never)]
		[Field ("MPMediaItemPropertyIsCloudItem",  "MediaPlayer")]
		public static NSString IsCloudItemProperty {
			get {
				if (_IsCloudItemProperty is null)
					_IsCloudItemProperty = Dlfcn.GetStringConstant (Libraries.MediaPlayer.Handle, "MPMediaItemPropertyIsCloudItem")!;
				return _IsCloudItemProperty;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IsCompilationProperty;
		/// <summary>Represents the value associated with the constant MPMediaItemPropertyIsCompilation</summary><value></value><remarks></remarks>
		[EditorBrowsable (EditorBrowsableState.Never)]
		[Field ("MPMediaItemPropertyIsCompilation",  "MediaPlayer")]
		public static NSString IsCompilationProperty {
			get {
				if (_IsCompilationProperty is null)
					_IsCompilationProperty = Dlfcn.GetStringConstant (Libraries.MediaPlayer.Handle, "MPMediaItemPropertyIsCompilation")!;
				return _IsCompilationProperty;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IsExplicitProperty;
		/// <summary>The value that is associated with the MPMediaItemPropertyIsExplicit constant.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[EditorBrowsable (EditorBrowsableState.Never)]
		[Field ("MPMediaItemPropertyIsExplicit",  "MediaPlayer")]
		public static NSString IsExplicitProperty {
			get {
				if (_IsExplicitProperty is null)
					_IsExplicitProperty = Dlfcn.GetStringConstant (Libraries.MediaPlayer.Handle, "MPMediaItemPropertyIsExplicit")!;
				return _IsExplicitProperty;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IsPreorderProperty;
		/// <summary>Represents the value associated with the constant 'MPMediaItemPropertyIsPreorder'.</summary>
		[EditorBrowsable (EditorBrowsableState.Never)]
		[Field ("MPMediaItemPropertyIsPreorder",  "MediaPlayer")]
		[SupportedOSPlatform ("tvos14.5")]
		[SupportedOSPlatform ("ios14.5")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString IsPreorderProperty {
			[SupportedOSPlatform ("tvos14.5")]
			[SupportedOSPlatform ("ios14.5")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_IsPreorderProperty is null)
					_IsPreorderProperty = Dlfcn.GetStringConstant (Libraries.MediaPlayer.Handle, "MPMediaItemPropertyIsPreorder")!;
				return _IsPreorderProperty;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _LastPlayedDateProperty;
		/// <summary>Represents the value associated with the constant MPMediaItemPropertyLastPlayedDate</summary><value></value><remarks></remarks>
		[EditorBrowsable (EditorBrowsableState.Never)]
		[Field ("MPMediaItemPropertyLastPlayedDate",  "MediaPlayer")]
		public static NSString LastPlayedDateProperty {
			get {
				if (_LastPlayedDateProperty is null)
					_LastPlayedDateProperty = Dlfcn.GetStringConstant (Libraries.MediaPlayer.Handle, "MPMediaItemPropertyLastPlayedDate")!;
				return _LastPlayedDateProperty;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _LyricsProperty;
		/// <summary>Represents the value associated with the constant MPMediaItemPropertyLyrics</summary><value></value><remarks></remarks>
		[EditorBrowsable (EditorBrowsableState.Never)]
		[Field ("MPMediaItemPropertyLyrics",  "MediaPlayer")]
		public static NSString LyricsProperty {
			get {
				if (_LyricsProperty is null)
					_LyricsProperty = Dlfcn.GetStringConstant (Libraries.MediaPlayer.Handle, "MPMediaItemPropertyLyrics")!;
				return _LyricsProperty;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _MediaTypeProperty;
		/// <summary>Represents the value associated with the constant MPMediaItemPropertyMediaType</summary><value></value><remarks></remarks>
		[EditorBrowsable (EditorBrowsableState.Never)]
		[Field ("MPMediaItemPropertyMediaType",  "MediaPlayer")]
		public static NSString MediaTypeProperty {
			get {
				if (_MediaTypeProperty is null)
					_MediaTypeProperty = Dlfcn.GetStringConstant (Libraries.MediaPlayer.Handle, "MPMediaItemPropertyMediaType")!;
				return _MediaTypeProperty;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _PersistentIDProperty;
		/// <summary>Represents the value associated with the constant MPMediaItemPropertyPersistentID</summary><value></value><remarks></remarks>
		[EditorBrowsable (EditorBrowsableState.Never)]
		[Field ("MPMediaItemPropertyPersistentID",  "MediaPlayer")]
		public static NSString PersistentIDProperty {
			get {
				if (_PersistentIDProperty is null)
					_PersistentIDProperty = Dlfcn.GetStringConstant (Libraries.MediaPlayer.Handle, "MPMediaItemPropertyPersistentID")!;
				return _PersistentIDProperty;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _PlayCountProperty;
		/// <summary>Represents the value associated with the constant MPMediaItemPropertyPlayCount</summary><value></value><remarks></remarks>
		[EditorBrowsable (EditorBrowsableState.Never)]
		[Field ("MPMediaItemPropertyPlayCount",  "MediaPlayer")]
		public static NSString PlayCountProperty {
			get {
				if (_PlayCountProperty is null)
					_PlayCountProperty = Dlfcn.GetStringConstant (Libraries.MediaPlayer.Handle, "MPMediaItemPropertyPlayCount")!;
				return _PlayCountProperty;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _PlaybackDurationProperty;
		/// <summary>Represents the value associated with the constant MPMediaItemPropertyPlaybackDuration</summary><value></value><remarks></remarks>
		[EditorBrowsable (EditorBrowsableState.Never)]
		[Field ("MPMediaItemPropertyPlaybackDuration",  "MediaPlayer")]
		public static NSString PlaybackDurationProperty {
			get {
				if (_PlaybackDurationProperty is null)
					_PlaybackDurationProperty = Dlfcn.GetStringConstant (Libraries.MediaPlayer.Handle, "MPMediaItemPropertyPlaybackDuration")!;
				return _PlaybackDurationProperty;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _PlaybackStoreIDProperty;
		/// <summary>Backing store for the <see cref="MPMediaItem.PlaybackStoreID" /> property.</summary>
		[EditorBrowsable (EditorBrowsableState.Never)]
		[Field ("MPMediaItemPropertyPlaybackStoreID",  "MediaPlayer")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString PlaybackStoreIDProperty {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_PlaybackStoreIDProperty is null)
					_PlaybackStoreIDProperty = Dlfcn.GetStringConstant (Libraries.MediaPlayer.Handle, "MPMediaItemPropertyPlaybackStoreID")!;
				return _PlaybackStoreIDProperty;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _PodcastPersistentIDProperty;
		/// <summary>Represents the value associated with the constant MPMediaItemPropertyPodcastPersistentID</summary><value></value><remarks></remarks>
		[EditorBrowsable (EditorBrowsableState.Never)]
		[Field ("MPMediaItemPropertyPodcastPersistentID",  "MediaPlayer")]
		public static NSString PodcastPersistentIDProperty {
			get {
				if (_PodcastPersistentIDProperty is null)
					_PodcastPersistentIDProperty = Dlfcn.GetStringConstant (Libraries.MediaPlayer.Handle, "MPMediaItemPropertyPodcastPersistentID")!;
				return _PodcastPersistentIDProperty;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _PodcastTitleProperty;
		/// <summary>Represents the value associated with the constant MPMediaItemPropertyPodcastTitle</summary><value></value><remarks></remarks>
		[EditorBrowsable (EditorBrowsableState.Never)]
		[Field ("MPMediaItemPropertyPodcastTitle",  "MediaPlayer")]
		public static NSString PodcastTitleProperty {
			get {
				if (_PodcastTitleProperty is null)
					_PodcastTitleProperty = Dlfcn.GetStringConstant (Libraries.MediaPlayer.Handle, "MPMediaItemPropertyPodcastTitle")!;
				return _PodcastTitleProperty;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _RatingProperty;
		/// <summary>Represents the value associated with the constant MPMediaItemPropertyRating</summary><value></value><remarks></remarks>
		[EditorBrowsable (EditorBrowsableState.Never)]
		[Field ("MPMediaItemPropertyRating",  "MediaPlayer")]
		public static NSString RatingProperty {
			get {
				if (_RatingProperty is null)
					_RatingProperty = Dlfcn.GetStringConstant (Libraries.MediaPlayer.Handle, "MPMediaItemPropertyRating")!;
				return _RatingProperty;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ReleaseDateProperty;
		/// <summary>Represents the value associated with the constant MPMediaItemPropertyReleaseDate</summary><value></value><remarks></remarks>
		[EditorBrowsable (EditorBrowsableState.Never)]
		[Field ("MPMediaItemPropertyReleaseDate",  "MediaPlayer")]
		public static NSString ReleaseDateProperty {
			get {
				if (_ReleaseDateProperty is null)
					_ReleaseDateProperty = Dlfcn.GetStringConstant (Libraries.MediaPlayer.Handle, "MPMediaItemPropertyReleaseDate")!;
				return _ReleaseDateProperty;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _SkipCountProperty;
		/// <summary>Represents the value associated with the constant MPMediaItemPropertySkipCount</summary><value></value><remarks></remarks>
		[EditorBrowsable (EditorBrowsableState.Never)]
		[Field ("MPMediaItemPropertySkipCount",  "MediaPlayer")]
		public static NSString SkipCountProperty {
			get {
				if (_SkipCountProperty is null)
					_SkipCountProperty = Dlfcn.GetStringConstant (Libraries.MediaPlayer.Handle, "MPMediaItemPropertySkipCount")!;
				return _SkipCountProperty;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _TitleProperty;
		/// <summary>Represents the value associated with the constant MPMediaItemPropertyTitle</summary><value></value><remarks></remarks>
		[EditorBrowsable (EditorBrowsableState.Never)]
		[Field ("MPMediaItemPropertyTitle",  "MediaPlayer")]
		public static NSString TitleProperty {
			get {
				if (_TitleProperty is null)
					_TitleProperty = Dlfcn.GetStringConstant (Libraries.MediaPlayer.Handle, "MPMediaItemPropertyTitle")!;
				return _TitleProperty;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _UserGroupingProperty;
		/// <summary>Represents the value associated with the constant MPMediaItemPropertyUserGrouping</summary><value></value><remarks></remarks>
		[EditorBrowsable (EditorBrowsableState.Never)]
		[Field ("MPMediaItemPropertyUserGrouping",  "MediaPlayer")]
		public static NSString UserGroupingProperty {
			get {
				if (_UserGroupingProperty is null)
					_UserGroupingProperty = Dlfcn.GetStringConstant (Libraries.MediaPlayer.Handle, "MPMediaItemPropertyUserGrouping")!;
				return _UserGroupingProperty;
			}
		}
	} /* class MPMediaItem */
}
