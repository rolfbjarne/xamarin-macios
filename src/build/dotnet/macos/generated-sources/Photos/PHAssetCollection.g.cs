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
namespace Photos {
	/// <summary>A collection of <see cref="T:Photos.PHAsset" />s.</summary><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/Photos/Reference/PHAssetCollection_Class/index.html">Apple documentation for <c>PHAssetCollection</c></related>
	[Register("PHAssetCollection", true)]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe partial class PHAssetCollection : PHCollection {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selApproximateLocationX = "approximateLocation";
		static readonly NativeHandle selApproximateLocationXHandle = Selector.GetHandle ("approximateLocation");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAssetCollectionSubtypeX = "assetCollectionSubtype";
		static readonly NativeHandle selAssetCollectionSubtypeXHandle = Selector.GetHandle ("assetCollectionSubtype");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAssetCollectionTypeX = "assetCollectionType";
		static readonly NativeHandle selAssetCollectionTypeXHandle = Selector.GetHandle ("assetCollectionType");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selEndDateX = "endDate";
		static readonly NativeHandle selEndDateXHandle = Selector.GetHandle ("endDate");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selEstimatedAssetCountX = "estimatedAssetCount";
		static readonly NativeHandle selEstimatedAssetCountXHandle = Selector.GetHandle ("estimatedAssetCount");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFetchAssetCollectionsContainingAsset_WithType_Options_X = "fetchAssetCollectionsContainingAsset:withType:options:";
		static readonly NativeHandle selFetchAssetCollectionsContainingAsset_WithType_Options_XHandle = Selector.GetHandle ("fetchAssetCollectionsContainingAsset:withType:options:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFetchAssetCollectionsWithALAssetGroupURLs_Options_X = "fetchAssetCollectionsWithALAssetGroupURLs:options:";
		static readonly NativeHandle selFetchAssetCollectionsWithALAssetGroupURLs_Options_XHandle = Selector.GetHandle ("fetchAssetCollectionsWithALAssetGroupURLs:options:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFetchAssetCollectionsWithLocalIdentifiers_Options_X = "fetchAssetCollectionsWithLocalIdentifiers:options:";
		static readonly NativeHandle selFetchAssetCollectionsWithLocalIdentifiers_Options_XHandle = Selector.GetHandle ("fetchAssetCollectionsWithLocalIdentifiers:options:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFetchAssetCollectionsWithType_Subtype_Options_X = "fetchAssetCollectionsWithType:subtype:options:";
		static readonly NativeHandle selFetchAssetCollectionsWithType_Subtype_Options_XHandle = Selector.GetHandle ("fetchAssetCollectionsWithType:subtype:options:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLocalizedLocationNamesX = "localizedLocationNames";
		static readonly NativeHandle selLocalizedLocationNamesXHandle = Selector.GetHandle ("localizedLocationNames");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selStartDateX = "startDate";
		static readonly NativeHandle selStartDateXHandle = Selector.GetHandle ("startDate");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTransientAssetCollectionWithAssetFetchResult_Title_X = "transientAssetCollectionWithAssetFetchResult:title:";
		static readonly NativeHandle selTransientAssetCollectionWithAssetFetchResult_Title_XHandle = Selector.GetHandle ("transientAssetCollectionWithAssetFetchResult:title:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTransientAssetCollectionWithAssets_Title_X = "transientAssetCollectionWithAssets:title:";
		static readonly NativeHandle selTransientAssetCollectionWithAssets_Title_XHandle = Selector.GetHandle ("transientAssetCollectionWithAssets:title:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("PHAssetCollection");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		/// <summary>Creates a new <see cref="PHAssetCollection" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PHAssetCollection () : base (NSObjectFlag.Empty)
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
		protected PHAssetCollection (NSObjectFlag t) : base (t)
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
		protected internal PHAssetCollection (NativeHandle handle) : base (handle)
		{
		}

		[Export ("fetchAssetCollectionsWithLocalIdentifiers:options:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static PHFetchResult FetchAssetCollections (string[] identifiers, PHFetchOptions? options)
		{
			if (identifiers is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (identifiers));
			var options__handle__ = options.GetHandle ();
			using var nsa_identifiers = NSArray.FromStrings (identifiers);
			PHFetchResult? ret;
			ret =  Runtime.GetNSObject<PHFetchResult> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (class_ptr, selFetchAssetCollectionsWithLocalIdentifiers_Options_XHandle, nsa_identifiers.Handle, options__handle__), false)!;
			GC.KeepAlive (options);
			return ret!;
		}
		[Export ("fetchAssetCollectionsWithType:subtype:options:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static PHFetchResult FetchAssetCollections (PHAssetCollectionType type, PHAssetCollectionSubtype subtype, PHFetchOptions? options)
		{
			var options__handle__ = options.GetHandle ();
			PHFetchResult? ret;
			ret =  Runtime.GetNSObject<PHFetchResult> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_IntPtr_IntPtr_NativeHandle (class_ptr, selFetchAssetCollectionsWithType_Subtype_Options_XHandle, (IntPtr) (long) type, (IntPtr) (long) subtype, options__handle__), false)!;
			GC.KeepAlive (options);
			return ret!;
		}
		[Export ("fetchAssetCollectionsContainingAsset:withType:options:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static PHFetchResult FetchAssetCollections (PHAsset asset, PHAssetCollectionType type, PHFetchOptions? options)
		{
			var asset__handle__ = asset!.GetNonNullHandle (nameof (asset));
			var options__handle__ = options.GetHandle ();
			PHFetchResult? ret;
			ret =  Runtime.GetNSObject<PHFetchResult> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_IntPtr_NativeHandle (class_ptr, selFetchAssetCollectionsContainingAsset_WithType_Options_XHandle, asset__handle__, (IntPtr) (long) type, options__handle__), false)!;
			GC.KeepAlive (asset);
			GC.KeepAlive (options);
			return ret!;
		}
		[Export ("fetchAssetCollectionsWithALAssetGroupURLs:options:")]
		[ObsoletedOSPlatform ("ios16.0", "Will be removed in a future release.")]
		[ObsoletedOSPlatform ("tvos16.0", "Will be removed in a future release.")]
		[ObsoletedOSPlatform ("macos13.0", "Will be removed in a future release.")]
		[ObsoletedOSPlatform ("maccatalyst16.0", "Will be removed in a future release.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static PHFetchResult FetchAssetCollections (NSUrl[] assetGroupUrls, PHFetchOptions? options)
		{
			if (assetGroupUrls is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (assetGroupUrls));
			var options__handle__ = options.GetHandle ();
			using var nsa_assetGroupUrls = NSArray.FromNSObjects (assetGroupUrls);
			PHFetchResult? ret;
			ret =  Runtime.GetNSObject<PHFetchResult> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (class_ptr, selFetchAssetCollectionsWithALAssetGroupURLs_Options_XHandle, nsa_assetGroupUrls.Handle, options__handle__), false)!;
			GC.KeepAlive (options);
			return ret!;
		}
		[Export ("transientAssetCollectionWithAssets:title:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static PHAssetCollection GetTransientAssetCollection (PHAsset[] assets, string? title)
		{
			if (assets is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (assets));
			using var nsa_assets = NSArray.FromNSObjects (assets);
			var nstitle = CFString.CreateNative (title);
			PHAssetCollection? ret;
			ret =  Runtime.GetNSObject<PHAssetCollection> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (class_ptr, selTransientAssetCollectionWithAssets_Title_XHandle, nsa_assets.Handle, nstitle), false)!;
			CFString.ReleaseNative (nstitle);
			return ret!;
		}
		[Export ("transientAssetCollectionWithAssetFetchResult:title:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static PHAssetCollection GetTransientAssetCollection (PHFetchResult fetchResult, string? title)
		{
			var fetchResult__handle__ = fetchResult!.GetNonNullHandle (nameof (fetchResult));
			var nstitle = CFString.CreateNative (title);
			PHAssetCollection? ret;
			ret =  Runtime.GetNSObject<PHAssetCollection> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (class_ptr, selTransientAssetCollectionWithAssetFetchResult_Title_XHandle, fetchResult__handle__, nstitle), false)!;
			GC.KeepAlive (fetchResult);
			CFString.ReleaseNative (nstitle);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::CoreLocation.CLLocation? ApproximateLocation {
			[Export ("approximateLocation", ArgumentSemantic.Retain)]
			get {
				global::CoreLocation.CLLocation? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::CoreLocation.CLLocation> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selApproximateLocationXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<global::CoreLocation.CLLocation> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selApproximateLocationXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual PHAssetCollectionSubtype AssetCollectionSubtype {
			[Export ("assetCollectionSubtype")]
			get {
				PHAssetCollectionSubtype ret;
				if (IsDirectBinding) {
					ret = (PHAssetCollectionSubtype) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selAssetCollectionSubtypeXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (PHAssetCollectionSubtype) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selAssetCollectionSubtypeXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual PHAssetCollectionType AssetCollectionType {
			[Export ("assetCollectionType")]
			get {
				PHAssetCollectionType ret;
				if (IsDirectBinding) {
					ret = (PHAssetCollectionType) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selAssetCollectionTypeXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (PHAssetCollectionType) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selAssetCollectionTypeXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDate? EndDate {
			[Export ("endDate", ArgumentSemantic.Retain)]
			get {
				NSDate? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDate> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selEndDateXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSDate> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selEndDateXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nuint EstimatedAssetCount {
			[Export ("estimatedAssetCount")]
			get {
				nuint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selEstimatedAssetCountXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selEstimatedAssetCountXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string[] LocalizedLocationNames {
			[Export ("localizedLocationNames", ArgumentSemantic.Retain)]
			get {
				string[] ret;
				if (IsDirectBinding) {
					ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selLocalizedLocationNamesXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selLocalizedLocationNamesXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDate? StartDate {
			[Export ("startDate", ArgumentSemantic.Retain)]
			get {
				NSDate? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDate> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selStartDateXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSDate> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selStartDateXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
	} /* class PHAssetCollection */
}
