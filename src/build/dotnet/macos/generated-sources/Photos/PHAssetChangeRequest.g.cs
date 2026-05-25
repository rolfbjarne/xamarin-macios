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
	/// <summary>Used within a Photos change block to create, update, or delete <see cref="T:Photos.PHAsset" /> objects.</summary><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/Photos/Reference/PHAssetChangeRequest_Class/index.html">Apple documentation for <c>PHAssetChangeRequest</c></related>
	[Register("PHAssetChangeRequest", true)]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe partial class PHAssetChangeRequest : PHChangeRequest {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selChangeRequestForAsset_X = "changeRequestForAsset:";
		static readonly NativeHandle selChangeRequestForAsset_XHandle = Selector.GetHandle ("changeRequestForAsset:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selContentEditingOutputX = "contentEditingOutput";
		static readonly NativeHandle selContentEditingOutputXHandle = Selector.GetHandle ("contentEditingOutput");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCreationDateX = "creationDate";
		static readonly NativeHandle selCreationDateXHandle = Selector.GetHandle ("creationDate");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCreationRequestForAssetFromImage_X = "creationRequestForAssetFromImage:";
		static readonly NativeHandle selCreationRequestForAssetFromImage_XHandle = Selector.GetHandle ("creationRequestForAssetFromImage:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCreationRequestForAssetFromImageAtFileURL_X = "creationRequestForAssetFromImageAtFileURL:";
		static readonly NativeHandle selCreationRequestForAssetFromImageAtFileURL_XHandle = Selector.GetHandle ("creationRequestForAssetFromImageAtFileURL:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCreationRequestForAssetFromVideoAtFileURL_X = "creationRequestForAssetFromVideoAtFileURL:";
		static readonly NativeHandle selCreationRequestForAssetFromVideoAtFileURL_XHandle = Selector.GetHandle ("creationRequestForAssetFromVideoAtFileURL:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDeleteAssets_X = "deleteAssets:";
		static readonly NativeHandle selDeleteAssets_XHandle = Selector.GetHandle ("deleteAssets:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsFavoriteX = "isFavorite";
		static readonly NativeHandle selIsFavoriteXHandle = Selector.GetHandle ("isFavorite");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsHiddenX = "isHidden";
		static readonly NativeHandle selIsHiddenXHandle = Selector.GetHandle ("isHidden");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLocationX = "location";
		static readonly NativeHandle selLocationXHandle = Selector.GetHandle ("location");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPlaceholderForCreatedAssetX = "placeholderForCreatedAsset";
		static readonly NativeHandle selPlaceholderForCreatedAssetXHandle = Selector.GetHandle ("placeholderForCreatedAsset");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRevertAssetContentToOriginalX = "revertAssetContentToOriginal";
		static readonly NativeHandle selRevertAssetContentToOriginalXHandle = Selector.GetHandle ("revertAssetContentToOriginal");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetContentEditingOutput_X = "setContentEditingOutput:";
		static readonly NativeHandle selSetContentEditingOutput_XHandle = Selector.GetHandle ("setContentEditingOutput:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetCreationDate_X = "setCreationDate:";
		static readonly NativeHandle selSetCreationDate_XHandle = Selector.GetHandle ("setCreationDate:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetFavorite_X = "setFavorite:";
		static readonly NativeHandle selSetFavorite_XHandle = Selector.GetHandle ("setFavorite:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetHidden_X = "setHidden:";
		static readonly NativeHandle selSetHidden_XHandle = Selector.GetHandle ("setHidden:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetLocation_X = "setLocation:";
		static readonly NativeHandle selSetLocation_XHandle = Selector.GetHandle ("setLocation:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("PHAssetChangeRequest");
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
		protected PHAssetChangeRequest (NSObjectFlag t) : base (t)
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
		protected internal PHAssetChangeRequest (NativeHandle handle) : base (handle)
		{
		}

		[Export ("changeRequestForAsset:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static PHAssetChangeRequest ChangeRequest (PHAsset asset)
		{
			var asset__handle__ = asset!.GetNonNullHandle (nameof (asset));
			PHAssetChangeRequest? ret;
			ret =  Runtime.GetNSObject<PHAssetChangeRequest> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, selChangeRequestForAsset_XHandle, asset__handle__), false)!;
			GC.KeepAlive (asset);
			return ret!;
		}
		[Export ("deleteAssets:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DeleteAssets (PHAsset[] assets)
		{
			if (assets is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (assets));
			using var nsa_assets = NSArray.FromNSObjects (assets);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (class_ptr, selDeleteAssets_XHandle, nsa_assets.Handle);
		}
		[Export ("creationRequestForAssetFromImage:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static PHAssetChangeRequest FromImage (global::AppKit.NSImage image)
		{
			var image__handle__ = image!.GetNonNullHandle (nameof (image));
			PHAssetChangeRequest? ret;
			ret =  Runtime.GetNSObject<PHAssetChangeRequest> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, selCreationRequestForAssetFromImage_XHandle, image__handle__), false)!;
			GC.KeepAlive (image);
			return ret!;
		}
		[Export ("creationRequestForAssetFromImageAtFileURL:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static PHAssetChangeRequest? FromImage (NSUrl fileUrl)
		{
			var fileUrl__handle__ = fileUrl!.GetNonNullHandle (nameof (fileUrl));
			PHAssetChangeRequest? ret;
			ret =  Runtime.GetNSObject<PHAssetChangeRequest> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, selCreationRequestForAssetFromImageAtFileURL_XHandle, fileUrl__handle__), false)!;
			GC.KeepAlive (fileUrl);
			return ret!;
		}
		[Export ("creationRequestForAssetFromVideoAtFileURL:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static PHAssetChangeRequest? FromVideo (NSUrl fileUrl)
		{
			var fileUrl__handle__ = fileUrl!.GetNonNullHandle (nameof (fileUrl));
			PHAssetChangeRequest? ret;
			ret =  Runtime.GetNSObject<PHAssetChangeRequest> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, selCreationRequestForAssetFromVideoAtFileURL_XHandle, fileUrl__handle__), false)!;
			GC.KeepAlive (fileUrl);
			return ret!;
		}
		[Export ("revertAssetContentToOriginal")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RevertAssetContentToOriginal ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selRevertAssetContentToOriginalXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selRevertAssetContentToOriginalXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual PHContentEditingOutput? ContentEditingOutput {
			[Export ("contentEditingOutput", ArgumentSemantic.Retain)]
			get {
				PHContentEditingOutput? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<PHContentEditingOutput> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selContentEditingOutputXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<PHContentEditingOutput> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selContentEditingOutputXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setContentEditingOutput:", ArgumentSemantic.Retain)]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetContentEditingOutput_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetContentEditingOutput_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDate? CreationDate {
			[Export ("creationDate", ArgumentSemantic.Retain)]
			get {
				NSDate? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDate> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selCreationDateXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSDate> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selCreationDateXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setCreationDate:", ArgumentSemantic.Retain)]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetCreationDate_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetCreationDate_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool Favorite {
			[Export ("isFavorite")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsFavoriteXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsFavoriteXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setFavorite:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetFavorite_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetFavorite_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool Hidden {
			[Export ("isHidden")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsHiddenXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsHiddenXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setHidden:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetHidden_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetHidden_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::CoreLocation.CLLocation? Location {
			[Export ("location", ArgumentSemantic.Retain)]
			get {
				global::CoreLocation.CLLocation? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::CoreLocation.CLLocation> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selLocationXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<global::CoreLocation.CLLocation> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selLocationXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setLocation:", ArgumentSemantic.Retain)]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetLocation_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetLocation_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual PHObjectPlaceholder? PlaceholderForCreatedAsset {
			[Export ("placeholderForCreatedAsset", ArgumentSemantic.Retain)]
			get {
				PHObjectPlaceholder? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<PHObjectPlaceholder> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selPlaceholderForCreatedAssetXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<PHObjectPlaceholder> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selPlaceholderForCreatedAssetXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
	} /* class PHAssetChangeRequest */
}
