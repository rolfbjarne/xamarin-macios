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
namespace PhotosUI {
	[Register("PHPickerFilter", true)]
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("macos13.0")]
	[SupportedOSPlatform ("ios14.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[Advice (@"This type should not be subclassed.")]
	public unsafe partial class PHPickerFilter : NSObject, INSCopying {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAllFilterMatchingSubfilters_X = "allFilterMatchingSubfilters:";
		static readonly NativeHandle selAllFilterMatchingSubfilters_XHandle = Selector.GetHandle ("allFilterMatchingSubfilters:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAnyFilterMatchingSubfilters_X = "anyFilterMatchingSubfilters:";
		static readonly NativeHandle selAnyFilterMatchingSubfilters_XHandle = Selector.GetHandle ("anyFilterMatchingSubfilters:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selBurstsFilterX = "burstsFilter";
		static readonly NativeHandle selBurstsFilterXHandle = Selector.GetHandle ("burstsFilter");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCinematicVideosFilterX = "cinematicVideosFilter";
		static readonly NativeHandle selCinematicVideosFilterXHandle = Selector.GetHandle ("cinematicVideosFilter");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCopyWithZone_X = "copyWithZone:";
		static readonly NativeHandle selCopyWithZone_XHandle = Selector.GetHandle ("copyWithZone:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDepthEffectPhotosFilterX = "depthEffectPhotosFilter";
		static readonly NativeHandle selDepthEffectPhotosFilterXHandle = Selector.GetHandle ("depthEffectPhotosFilter");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selImagesFilterX = "imagesFilter";
		static readonly NativeHandle selImagesFilterXHandle = Selector.GetHandle ("imagesFilter");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLivePhotosFilterX = "livePhotosFilter";
		static readonly NativeHandle selLivePhotosFilterXHandle = Selector.GetHandle ("livePhotosFilter");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selNotFilterOfSubfilter_X = "notFilterOfSubfilter:";
		static readonly NativeHandle selNotFilterOfSubfilter_XHandle = Selector.GetHandle ("notFilterOfSubfilter:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPanoramasFilterX = "panoramasFilter";
		static readonly NativeHandle selPanoramasFilterXHandle = Selector.GetHandle ("panoramasFilter");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPlaybackStyleFilter_X = "playbackStyleFilter:";
		static readonly NativeHandle selPlaybackStyleFilter_XHandle = Selector.GetHandle ("playbackStyleFilter:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selScreenRecordingsFilterX = "screenRecordingsFilter";
		static readonly NativeHandle selScreenRecordingsFilterXHandle = Selector.GetHandle ("screenRecordingsFilter");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selScreenshotsFilterX = "screenshotsFilter";
		static readonly NativeHandle selScreenshotsFilterXHandle = Selector.GetHandle ("screenshotsFilter");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSlomoVideosFilterX = "slomoVideosFilter";
		static readonly NativeHandle selSlomoVideosFilterXHandle = Selector.GetHandle ("slomoVideosFilter");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSpatialMediaFilterX = "spatialMediaFilter";
		static readonly NativeHandle selSpatialMediaFilterXHandle = Selector.GetHandle ("spatialMediaFilter");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTimelapseVideosFilterX = "timelapseVideosFilter";
		static readonly NativeHandle selTimelapseVideosFilterXHandle = Selector.GetHandle ("timelapseVideosFilter");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selVideosFilterX = "videosFilter";
		static readonly NativeHandle selVideosFilterXHandle = Selector.GetHandle ("videosFilter");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("PHPickerFilter");
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
		protected PHPickerFilter (NSObjectFlag t) : base (t)
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
		protected internal PHPickerFilter (NativeHandle handle) : base (handle)
		{
		}

		/// <param name="zone">Developers should pass <see langword="null" />.  Memory zones are no longer used.</param><summary>Performs a copy of the underlying Objective-C object.</summary><returns>The newly-allocated object.</returns><remarks><para>This method performs a "shallow copy" of <see langword="this" />. If this object contains references to external objects, the new object will contain references to the same object.</para></remarks>
		[Export ("copyWithZone:")]
		[return: ReleaseAttribute ()]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject Copy (NSZone? zone)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var zone__handle__ = zone.GetHandle ();
			NSObject? ret;
			if (IsDirectBinding) {
				ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selCopyWithZone_XHandle, zone__handle__), true)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selCopyWithZone_XHandle, zone__handle__), true)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (zone);
			return ret!;
		}
		[Export ("allFilterMatchingSubfilters:")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static PHPickerFilter GetAllFilterMatchingSubfilters (PHPickerFilter[] subfilters)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (subfilters is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (subfilters));
			using var nsa_subfilters = NSArray.FromNSObjects (subfilters);
			PHPickerFilter ret;
			ret =  Runtime.GetNSObject<PHPickerFilter> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, selAllFilterMatchingSubfilters_XHandle, nsa_subfilters.Handle), false)!;
			return ret;
		}
		[Export ("anyFilterMatchingSubfilters:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static PHPickerFilter GetAnyFilterMatchingSubfilters (PHPickerFilter[] subfilters)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (subfilters is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (subfilters));
			using var nsa_subfilters = NSArray.FromNSObjects (subfilters);
			PHPickerFilter ret;
			ret =  Runtime.GetNSObject<PHPickerFilter> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, selAnyFilterMatchingSubfilters_XHandle, nsa_subfilters.Handle), false)!;
			return ret;
		}
		[Export ("notFilterOfSubfilter:")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static PHPickerFilter GetNotFilterOfSubfilter (PHPickerFilter subfilter)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var subfilter__handle__ = subfilter!.GetNonNullHandle (nameof (subfilter));
			PHPickerFilter? ret;
			ret =  Runtime.GetNSObject<PHPickerFilter> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, selNotFilterOfSubfilter_XHandle, subfilter__handle__), false)!;
			GC.KeepAlive (subfilter);
			return ret!;
		}
		[Export ("playbackStyleFilter:")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static PHPickerFilter GetPlaybackStyleFilter (global::Photos.PHAssetPlaybackStyle playbackStyle)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			PHPickerFilter ret;
			ret =  Runtime.GetNSObject<PHPickerFilter> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_IntPtr (class_ptr, selPlaybackStyleFilter_XHandle, (IntPtr) (long) playbackStyle), false)!;
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		public static PHPickerFilter BurstsFilter {
			[Export ("burstsFilter")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				PHPickerFilter? ret;
				ret =  Runtime.GetNSObject<PHPickerFilter> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selBurstsFilterXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		public static PHPickerFilter CinematicVideosFilter {
			[Export ("cinematicVideosFilter")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				PHPickerFilter? ret;
				ret =  Runtime.GetNSObject<PHPickerFilter> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selCinematicVideosFilterXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		public static PHPickerFilter DepthEffectPhotosFilter {
			[Export ("depthEffectPhotosFilter")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				PHPickerFilter? ret;
				ret =  Runtime.GetNSObject<PHPickerFilter> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selDepthEffectPhotosFilterXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static PHPickerFilter ImagesFilter {
			[Export ("imagesFilter")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				PHPickerFilter? ret;
				ret =  Runtime.GetNSObject<PHPickerFilter> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selImagesFilterXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static PHPickerFilter LivePhotosFilter {
			[Export ("livePhotosFilter")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				PHPickerFilter? ret;
				ret =  Runtime.GetNSObject<PHPickerFilter> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selLivePhotosFilterXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		public static PHPickerFilter PanoramasFilter {
			[Export ("panoramasFilter")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				PHPickerFilter? ret;
				ret =  Runtime.GetNSObject<PHPickerFilter> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selPanoramasFilterXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		public static PHPickerFilter ScreenRecordingsFilter {
			[Export ("screenRecordingsFilter")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				PHPickerFilter? ret;
				ret =  Runtime.GetNSObject<PHPickerFilter> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selScreenRecordingsFilterXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		public static PHPickerFilter ScreenshotsFilter {
			[Export ("screenshotsFilter")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				PHPickerFilter? ret;
				ret =  Runtime.GetNSObject<PHPickerFilter> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selScreenshotsFilterXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		public static PHPickerFilter SlomoVideosFilter {
			[Export ("slomoVideosFilter")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				PHPickerFilter? ret;
				ret =  Runtime.GetNSObject<PHPickerFilter> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selSlomoVideosFilterXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		public static PHPickerFilter SpatialMediaFilter {
			[Export ("spatialMediaFilter")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				PHPickerFilter? ret;
				ret =  Runtime.GetNSObject<PHPickerFilter> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selSpatialMediaFilterXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		public static PHPickerFilter TimelapseVideosFilter {
			[Export ("timelapseVideosFilter")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				PHPickerFilter? ret;
				ret =  Runtime.GetNSObject<PHPickerFilter> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selTimelapseVideosFilterXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static PHPickerFilter VideosFilter {
			[Export ("videosFilter")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				PHPickerFilter? ret;
				ret =  Runtime.GetNSObject<PHPickerFilter> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selVideosFilterXHandle), false)!;
				return ret!;
			}
		}
	} /* class PHPickerFilter */
}
