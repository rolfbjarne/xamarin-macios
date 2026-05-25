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
namespace MediaLibrary {
	[Register("MLMediaSource", true)]
	[ObsoletedOSPlatform ("macos10.15")]
	[SupportedOSPlatform ("macos")]
	public unsafe partial class MLMediaSource : NSObject {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAttributesX = "attributes";
		static readonly NativeHandle selAttributesXHandle = Selector.GetHandle ("attributes");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMediaGroupForIdentifier_X = "mediaGroupForIdentifier:";
		static readonly NativeHandle selMediaGroupForIdentifier_XHandle = Selector.GetHandle ("mediaGroupForIdentifier:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMediaGroupsForIdentifiers_X = "mediaGroupsForIdentifiers:";
		static readonly NativeHandle selMediaGroupsForIdentifiers_XHandle = Selector.GetHandle ("mediaGroupsForIdentifiers:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMediaLibraryX = "mediaLibrary";
		static readonly NativeHandle selMediaLibraryXHandle = Selector.GetHandle ("mediaLibrary");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMediaObjectForIdentifier_X = "mediaObjectForIdentifier:";
		static readonly NativeHandle selMediaObjectForIdentifier_XHandle = Selector.GetHandle ("mediaObjectForIdentifier:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMediaObjectsForIdentifiers_X = "mediaObjectsForIdentifiers:";
		static readonly NativeHandle selMediaObjectsForIdentifiers_XHandle = Selector.GetHandle ("mediaObjectsForIdentifiers:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMediaSourceIdentifierX = "mediaSourceIdentifier";
		static readonly NativeHandle selMediaSourceIdentifierXHandle = Selector.GetHandle ("mediaSourceIdentifier");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRootMediaGroupX = "rootMediaGroup";
		static readonly NativeHandle selRootMediaGroupXHandle = Selector.GetHandle ("rootMediaGroup");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("MLMediaSource");
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
		protected MLMediaSource (NSObjectFlag t) : base (t)
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
		protected internal MLMediaSource (NativeHandle handle) : base (handle)
		{
		}

		/// <param name="mediaGroupIdentifier">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("mediaGroupForIdentifier:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MLMediaGroup? MediaGroupForIdentifier (NSString mediaGroupIdentifier)
		{
			var mediaGroupIdentifier__handle__ = mediaGroupIdentifier!.GetNonNullHandle (nameof (mediaGroupIdentifier));
			MLMediaGroup? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<MLMediaGroup> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selMediaGroupForIdentifier_XHandle, mediaGroupIdentifier__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<MLMediaGroup> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selMediaGroupForIdentifier_XHandle, mediaGroupIdentifier__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (mediaGroupIdentifier);
			return ret!;
		}
		/// <param name="mediaGroupIdentifiers">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("mediaGroupsForIdentifiers:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDictionary<NSString, MLMediaGroup> MediaGroupsForIdentifiers (NSString[] mediaGroupIdentifiers)
		{
			if (mediaGroupIdentifiers is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (mediaGroupIdentifiers));
			using var nsa_mediaGroupIdentifiers = NSArray.FromNSObjects (mediaGroupIdentifiers);
			NSDictionary<NSString, MLMediaGroup> ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSDictionary<NSString, MLMediaGroup>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selMediaGroupsForIdentifiers_XHandle, nsa_mediaGroupIdentifiers.Handle), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSDictionary<NSString, MLMediaGroup>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selMediaGroupsForIdentifiers_XHandle, nsa_mediaGroupIdentifiers.Handle), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		/// <param name="mediaObjectIdentifier">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("mediaObjectForIdentifier:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MLMediaObject? MediaObjectForIdentifier (NSString mediaObjectIdentifier)
		{
			var mediaObjectIdentifier__handle__ = mediaObjectIdentifier!.GetNonNullHandle (nameof (mediaObjectIdentifier));
			MLMediaObject? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<MLMediaObject> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selMediaObjectForIdentifier_XHandle, mediaObjectIdentifier__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<MLMediaObject> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selMediaObjectForIdentifier_XHandle, mediaObjectIdentifier__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (mediaObjectIdentifier);
			return ret!;
		}
		/// <param name="mediaObjectIdentifiers">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("mediaObjectsForIdentifiers:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDictionary<NSString, MLMediaObject> MediaObjectsForIdentifiers (NSString[] mediaObjectIdentifiers)
		{
			if (mediaObjectIdentifiers is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (mediaObjectIdentifiers));
			using var nsa_mediaObjectIdentifiers = NSArray.FromNSObjects (mediaObjectIdentifiers);
			NSDictionary<NSString, MLMediaObject> ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSDictionary<NSString, MLMediaObject>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selMediaObjectsForIdentifiers_XHandle, nsa_mediaObjectIdentifiers.Handle), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSDictionary<NSString, MLMediaObject>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selMediaObjectsForIdentifiers_XHandle, nsa_mediaObjectIdentifiers.Handle), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDictionary<NSString, NSObject> Attributes {
			[Export ("attributes", ArgumentSemantic.Copy)]
			get {
				NSDictionary<NSString, NSObject>? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDictionary<NSString, NSObject>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selAttributesXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSDictionary<NSString, NSObject>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selAttributesXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		object? __mt_MediaLibrary_var;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MLMediaLibrary? MediaLibrary {
			[Export ("mediaLibrary", ArgumentSemantic.Assign)]
			get {
				MLMediaLibrary? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<MLMediaLibrary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selMediaLibraryXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<MLMediaLibrary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selMediaLibraryXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				MarkDirty ();
				__mt_MediaLibrary_var = ret;
				return ret!;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSString MediaSourceIdentifier {
			[Export ("mediaSourceIdentifier")]
			get {
				NSString? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selMediaSourceIdentifierXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selMediaSourceIdentifierXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MLMediaGroup? RootMediaGroup {
			[Export ("rootMediaGroup", ArgumentSemantic.Retain)]
			get {
				MLMediaGroup? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<MLMediaGroup> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selRootMediaGroupXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<MLMediaGroup> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selRootMediaGroupXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _MediaSourceApertureIdentifier;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("MLMediaSourceApertureIdentifier",  "MediaLibrary")]
		public static NSString MediaSourceApertureIdentifier {
			get {
				if (_MediaSourceApertureIdentifier is null)
					_MediaSourceApertureIdentifier = Dlfcn.GetStringConstant (Libraries.MediaLibrary.Handle, "MLMediaSourceApertureIdentifier")!;
				return _MediaSourceApertureIdentifier;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _MediaSourceAppDefinedFoldersIdentifier;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("MLMediaSourceAppDefinedFoldersIdentifier",  "MediaLibrary")]
		public static NSString MediaSourceAppDefinedFoldersIdentifier {
			get {
				if (_MediaSourceAppDefinedFoldersIdentifier is null)
					_MediaSourceAppDefinedFoldersIdentifier = Dlfcn.GetStringConstant (Libraries.MediaLibrary.Handle, "MLMediaSourceAppDefinedFoldersIdentifier")!;
				return _MediaSourceAppDefinedFoldersIdentifier;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _MediaSourceCustomFoldersIdentifier;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("MLMediaSourceCustomFoldersIdentifier",  "MediaLibrary")]
		public static NSString MediaSourceCustomFoldersIdentifier {
			get {
				if (_MediaSourceCustomFoldersIdentifier is null)
					_MediaSourceCustomFoldersIdentifier = Dlfcn.GetStringConstant (Libraries.MediaLibrary.Handle, "MLMediaSourceCustomFoldersIdentifier")!;
				return _MediaSourceCustomFoldersIdentifier;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _MediaSourceFinalCutIdentifier;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("MLMediaSourceFinalCutIdentifier",  "MediaLibrary")]
		public static NSString MediaSourceFinalCutIdentifier {
			get {
				if (_MediaSourceFinalCutIdentifier is null)
					_MediaSourceFinalCutIdentifier = Dlfcn.GetStringConstant (Libraries.MediaLibrary.Handle, "MLMediaSourceFinalCutIdentifier")!;
				return _MediaSourceFinalCutIdentifier;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _MediaSourceGarageBandIdentifier;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("MLMediaSourceGarageBandIdentifier",  "MediaLibrary")]
		public static NSString MediaSourceGarageBandIdentifier {
			get {
				if (_MediaSourceGarageBandIdentifier is null)
					_MediaSourceGarageBandIdentifier = Dlfcn.GetStringConstant (Libraries.MediaLibrary.Handle, "MLMediaSourceGarageBandIdentifier")!;
				return _MediaSourceGarageBandIdentifier;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _MediaSourceLogicIdentifier;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("MLMediaSourceLogicIdentifier",  "MediaLibrary")]
		public static NSString MediaSourceLogicIdentifier {
			get {
				if (_MediaSourceLogicIdentifier is null)
					_MediaSourceLogicIdentifier = Dlfcn.GetStringConstant (Libraries.MediaLibrary.Handle, "MLMediaSourceLogicIdentifier")!;
				return _MediaSourceLogicIdentifier;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _MediaSourceMoviesFolderIdentifier;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("MLMediaSourceMoviesFolderIdentifier",  "MediaLibrary")]
		public static NSString MediaSourceMoviesFolderIdentifier {
			get {
				if (_MediaSourceMoviesFolderIdentifier is null)
					_MediaSourceMoviesFolderIdentifier = Dlfcn.GetStringConstant (Libraries.MediaLibrary.Handle, "MLMediaSourceMoviesFolderIdentifier")!;
				return _MediaSourceMoviesFolderIdentifier;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _MediaSourcePhotoBoothIdentifier;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("MLMediaSourcePhotoBoothIdentifier",  "MediaLibrary")]
		public static NSString MediaSourcePhotoBoothIdentifier {
			get {
				if (_MediaSourcePhotoBoothIdentifier is null)
					_MediaSourcePhotoBoothIdentifier = Dlfcn.GetStringConstant (Libraries.MediaLibrary.Handle, "MLMediaSourcePhotoBoothIdentifier")!;
				return _MediaSourcePhotoBoothIdentifier;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _MediaSourcePhotosIdentifier;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("MLMediaSourcePhotosIdentifier",  "MediaLibrary")]
		public static NSString MediaSourcePhotosIdentifier {
			get {
				if (_MediaSourcePhotosIdentifier is null)
					_MediaSourcePhotosIdentifier = Dlfcn.GetStringConstant (Libraries.MediaLibrary.Handle, "MLMediaSourcePhotosIdentifier")!;
				return _MediaSourcePhotosIdentifier;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _MediaSourceiMovieIdentifier;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("MLMediaSourceiMovieIdentifier",  "MediaLibrary")]
		public static NSString MediaSourceiMovieIdentifier {
			get {
				if (_MediaSourceiMovieIdentifier is null)
					_MediaSourceiMovieIdentifier = Dlfcn.GetStringConstant (Libraries.MediaLibrary.Handle, "MLMediaSourceiMovieIdentifier")!;
				return _MediaSourceiMovieIdentifier;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _MediaSourceiPhotoIdentifier;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("MLMediaSourceiPhotoIdentifier",  "MediaLibrary")]
		public static NSString MediaSourceiPhotoIdentifier {
			get {
				if (_MediaSourceiPhotoIdentifier is null)
					_MediaSourceiPhotoIdentifier = Dlfcn.GetStringConstant (Libraries.MediaLibrary.Handle, "MLMediaSourceiPhotoIdentifier")!;
				return _MediaSourceiPhotoIdentifier;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _MediaSourceiTunesIdentifier;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("MLMediaSourceiTunesIdentifier",  "MediaLibrary")]
		public static NSString MediaSourceiTunesIdentifier {
			get {
				if (_MediaSourceiTunesIdentifier is null)
					_MediaSourceiTunesIdentifier = Dlfcn.GetStringConstant (Libraries.MediaLibrary.Handle, "MLMediaSourceiTunesIdentifier")!;
				return _MediaSourceiTunesIdentifier;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_MediaLibrary_var = null;
			}
		}
	} /* class MLMediaSource */
}
