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
namespace Foundation {
	[Register("NSItemProvider", true)]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe partial class NSItemProvider : NSObject, INSCopying {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCanLoadObjectOfClass_X = "canLoadObjectOfClass:";
		static readonly NativeHandle selCanLoadObjectOfClass_XHandle = Selector.GetHandle ("canLoadObjectOfClass:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selContainerFrameX = "containerFrame";
		static readonly NativeHandle selContainerFrameXHandle = Selector.GetHandle ("containerFrame");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCopyWithZone_X = "copyWithZone:";
		static readonly NativeHandle selCopyWithZone_XHandle = Selector.GetHandle ("copyWithZone:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selHasItemConformingToTypeIdentifier_X = "hasItemConformingToTypeIdentifier:";
		static readonly NativeHandle selHasItemConformingToTypeIdentifier_XHandle = Selector.GetHandle ("hasItemConformingToTypeIdentifier:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selHasRepresentationConformingToTypeIdentifier_FileOptions_X = "hasRepresentationConformingToTypeIdentifier:fileOptions:";
		static readonly NativeHandle selHasRepresentationConformingToTypeIdentifier_FileOptions_XHandle = Selector.GetHandle ("hasRepresentationConformingToTypeIdentifier:fileOptions:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithContentsOfURL_X = "initWithContentsOfURL:";
		static readonly NativeHandle selInitWithContentsOfURL_XHandle = Selector.GetHandle ("initWithContentsOfURL:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithContentsOfURL_ContentType_OpenInPlace_Coordinated_Visibility_X = "initWithContentsOfURL:contentType:openInPlace:coordinated:visibility:";
		static readonly NativeHandle selInitWithContentsOfURL_ContentType_OpenInPlace_Coordinated_Visibility_XHandle = Selector.GetHandle ("initWithContentsOfURL:contentType:openInPlace:coordinated:visibility:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithItem_TypeIdentifier_X = "initWithItem:typeIdentifier:";
		static readonly NativeHandle selInitWithItem_TypeIdentifier_XHandle = Selector.GetHandle ("initWithItem:typeIdentifier:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithObject_X = "initWithObject:";
		static readonly NativeHandle selInitWithObject_XHandle = Selector.GetHandle ("initWithObject:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLoadDataRepresentationForContentType_CompletionHandler_X = "loadDataRepresentationForContentType:completionHandler:";
		static readonly NativeHandle selLoadDataRepresentationForContentType_CompletionHandler_XHandle = Selector.GetHandle ("loadDataRepresentationForContentType:completionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLoadDataRepresentationForTypeIdentifier_CompletionHandler_X = "loadDataRepresentationForTypeIdentifier:completionHandler:";
		static readonly NativeHandle selLoadDataRepresentationForTypeIdentifier_CompletionHandler_XHandle = Selector.GetHandle ("loadDataRepresentationForTypeIdentifier:completionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLoadFileRepresentationForContentType_OpenInPlace_CompletionHandler_X = "loadFileRepresentationForContentType:openInPlace:completionHandler:";
		static readonly NativeHandle selLoadFileRepresentationForContentType_OpenInPlace_CompletionHandler_XHandle = Selector.GetHandle ("loadFileRepresentationForContentType:openInPlace:completionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLoadFileRepresentationForTypeIdentifier_CompletionHandler_X = "loadFileRepresentationForTypeIdentifier:completionHandler:";
		static readonly NativeHandle selLoadFileRepresentationForTypeIdentifier_CompletionHandler_XHandle = Selector.GetHandle ("loadFileRepresentationForTypeIdentifier:completionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLoadInPlaceFileRepresentationForTypeIdentifier_CompletionHandler_X = "loadInPlaceFileRepresentationForTypeIdentifier:completionHandler:";
		static readonly NativeHandle selLoadInPlaceFileRepresentationForTypeIdentifier_CompletionHandler_XHandle = Selector.GetHandle ("loadInPlaceFileRepresentationForTypeIdentifier:completionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLoadItemForTypeIdentifier_Options_CompletionHandler_X = "loadItemForTypeIdentifier:options:completionHandler:";
		static readonly NativeHandle selLoadItemForTypeIdentifier_Options_CompletionHandler_XHandle = Selector.GetHandle ("loadItemForTypeIdentifier:options:completionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLoadObjectOfClass_CompletionHandler_X = "loadObjectOfClass:completionHandler:";
		static readonly NativeHandle selLoadObjectOfClass_CompletionHandler_XHandle = Selector.GetHandle ("loadObjectOfClass:completionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLoadPreviewImageWithOptions_CompletionHandler_X = "loadPreviewImageWithOptions:completionHandler:";
		static readonly NativeHandle selLoadPreviewImageWithOptions_CompletionHandler_XHandle = Selector.GetHandle ("loadPreviewImageWithOptions:completionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPreferredPresentationSizeX = "preferredPresentationSize";
		static readonly NativeHandle selPreferredPresentationSizeXHandle = Selector.GetHandle ("preferredPresentationSize");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRegisterCKShare_Container_AllowedSharingOptions_X = "registerCKShare:container:allowedSharingOptions:";
		static readonly NativeHandle selRegisterCKShare_Container_AllowedSharingOptions_XHandle = Selector.GetHandle ("registerCKShare:container:allowedSharingOptions:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRegisterCKShareWithContainer_AllowedSharingOptions_PreparationHandler_X = "registerCKShareWithContainer:allowedSharingOptions:preparationHandler:";
		static readonly NativeHandle selRegisterCKShareWithContainer_AllowedSharingOptions_PreparationHandler_XHandle = Selector.GetHandle ("registerCKShareWithContainer:allowedSharingOptions:preparationHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRegisterCloudKitShare_Container_X = "registerCloudKitShare:container:";
		static readonly NativeHandle selRegisterCloudKitShare_Container_XHandle = Selector.GetHandle ("registerCloudKitShare:container:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRegisterCloudKitShareWithPreparationHandler_X = "registerCloudKitShareWithPreparationHandler:";
		static readonly NativeHandle selRegisterCloudKitShareWithPreparationHandler_XHandle = Selector.GetHandle ("registerCloudKitShareWithPreparationHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRegisterDataRepresentationForContentType_Visibility_LoadHandler_X = "registerDataRepresentationForContentType:visibility:loadHandler:";
		static readonly NativeHandle selRegisterDataRepresentationForContentType_Visibility_LoadHandler_XHandle = Selector.GetHandle ("registerDataRepresentationForContentType:visibility:loadHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRegisterDataRepresentationForTypeIdentifier_Visibility_LoadHandler_X = "registerDataRepresentationForTypeIdentifier:visibility:loadHandler:";
		static readonly NativeHandle selRegisterDataRepresentationForTypeIdentifier_Visibility_LoadHandler_XHandle = Selector.GetHandle ("registerDataRepresentationForTypeIdentifier:visibility:loadHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRegisterFileRepresentationForContentType_Visibility_OpenInPlace_LoadHandler_X = "registerFileRepresentationForContentType:visibility:openInPlace:loadHandler:";
		static readonly NativeHandle selRegisterFileRepresentationForContentType_Visibility_OpenInPlace_LoadHandler_XHandle = Selector.GetHandle ("registerFileRepresentationForContentType:visibility:openInPlace:loadHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRegisterFileRepresentationForTypeIdentifier_FileOptions_Visibility_LoadHandler_X = "registerFileRepresentationForTypeIdentifier:fileOptions:visibility:loadHandler:";
		static readonly NativeHandle selRegisterFileRepresentationForTypeIdentifier_FileOptions_Visibility_LoadHandler_XHandle = Selector.GetHandle ("registerFileRepresentationForTypeIdentifier:fileOptions:visibility:loadHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRegisterItemForTypeIdentifier_LoadHandler_X = "registerItemForTypeIdentifier:loadHandler:";
		static readonly NativeHandle selRegisterItemForTypeIdentifier_LoadHandler_XHandle = Selector.GetHandle ("registerItemForTypeIdentifier:loadHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRegisterObject_Visibility_X = "registerObject:visibility:";
		static readonly NativeHandle selRegisterObject_Visibility_XHandle = Selector.GetHandle ("registerObject:visibility:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRegisterObjectOfClass_Visibility_LoadHandler_X = "registerObjectOfClass:visibility:loadHandler:";
		static readonly NativeHandle selRegisterObjectOfClass_Visibility_LoadHandler_XHandle = Selector.GetHandle ("registerObjectOfClass:visibility:loadHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRegisteredContentTypesX = "registeredContentTypes";
		static readonly NativeHandle selRegisteredContentTypesXHandle = Selector.GetHandle ("registeredContentTypes");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRegisteredContentTypesConformingToContentType_X = "registeredContentTypesConformingToContentType:";
		static readonly NativeHandle selRegisteredContentTypesConformingToContentType_XHandle = Selector.GetHandle ("registeredContentTypesConformingToContentType:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRegisteredContentTypesForOpenInPlaceX = "registeredContentTypesForOpenInPlace";
		static readonly NativeHandle selRegisteredContentTypesForOpenInPlaceXHandle = Selector.GetHandle ("registeredContentTypesForOpenInPlace");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRegisteredTypeIdentifiersX = "registeredTypeIdentifiers";
		static readonly NativeHandle selRegisteredTypeIdentifiersXHandle = Selector.GetHandle ("registeredTypeIdentifiers");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRegisteredTypeIdentifiersWithFileOptions_X = "registeredTypeIdentifiersWithFileOptions:";
		static readonly NativeHandle selRegisteredTypeIdentifiersWithFileOptions_XHandle = Selector.GetHandle ("registeredTypeIdentifiersWithFileOptions:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetPreferredPresentationSize_X = "setPreferredPresentationSize:";
		static readonly NativeHandle selSetPreferredPresentationSize_XHandle = Selector.GetHandle ("setPreferredPresentationSize:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetPreviewImageHandler_X = "setPreviewImageHandler:";
		static readonly NativeHandle selSetPreviewImageHandler_XHandle = Selector.GetHandle ("setPreviewImageHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetSuggestedName_X = "setSuggestedName:";
		static readonly NativeHandle selSetSuggestedName_XHandle = Selector.GetHandle ("setSuggestedName:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSourceFrameX = "sourceFrame";
		static readonly NativeHandle selSourceFrameXHandle = Selector.GetHandle ("sourceFrame");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSuggestedNameX = "suggestedName";
		static readonly NativeHandle selSuggestedNameXHandle = Selector.GetHandle ("suggestedName");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("NSItemProvider");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		/// <summary>Creates a new <see cref="NSItemProvider" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[DesignatedInitializer]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public NSItemProvider () : base (NSObjectFlag.Empty)
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
		protected NSItemProvider (NSObjectFlag t) : base (t)
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
		protected internal NSItemProvider (NativeHandle handle) : base (handle)
		{
		}

		[Export ("initWithItem:typeIdentifier:")]
		[DesignatedInitializer]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSItemProvider (NSObject? item, string typeIdentifier)
			: base (NSObjectFlag.Empty)
		{
			var item__handle__ = item.GetHandle ();
			if (typeIdentifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (typeIdentifier));
			var nstypeIdentifier = CFString.CreateNative (typeIdentifier);
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selInitWithItem_TypeIdentifier_XHandle, item__handle__, nstypeIdentifier), "initWithItem:typeIdentifier:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selInitWithItem_TypeIdentifier_XHandle, item__handle__, nstypeIdentifier), "initWithItem:typeIdentifier:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (item);
			CFString.ReleaseNative (nstypeIdentifier);
		}
		[Export ("initWithContentsOfURL:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSItemProvider (NSUrl fileUrl)
			: base (NSObjectFlag.Empty)
		{
			var fileUrl__handle__ = fileUrl!.GetNonNullHandle (nameof (fileUrl));
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selInitWithContentsOfURL_XHandle, fileUrl__handle__), "initWithContentsOfURL:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selInitWithContentsOfURL_XHandle, fileUrl__handle__), "initWithContentsOfURL:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (fileUrl);
		}
		[Export ("initWithObject:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSItemProvider (INSItemProviderWriting @object)
			: base (NSObjectFlag.Empty)
		{
			var @object__handle__ = @object!.GetNonNullHandle (nameof (@object));
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selInitWithObject_XHandle, @object__handle__), "initWithObject:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selInitWithObject_XHandle, @object__handle__), "initWithObject:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (@object);
		}
		[Export ("initWithContentsOfURL:contentType:openInPlace:coordinated:visibility:")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSItemProvider (NSUrl fileUrl, global::UniformTypeIdentifiers.UTType? contentType, bool openInPlace, bool coordinated, NSItemProviderRepresentationVisibility visibility)
			: base (NSObjectFlag.Empty)
		{
			var fileUrl__handle__ = fileUrl!.GetNonNullHandle (nameof (fileUrl));
			var contentType__handle__ = contentType.GetHandle ();
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_bool_bool_IntPtr (this.Handle, selInitWithContentsOfURL_ContentType_OpenInPlace_Coordinated_Visibility_XHandle, fileUrl__handle__, contentType__handle__, openInPlace ? (byte) 1 : (byte) 0, coordinated ? (byte) 1 : (byte) 0, (IntPtr) (long) visibility), "initWithContentsOfURL:contentType:openInPlace:coordinated:visibility:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_bool_bool_IntPtr (&__objc_super__, selInitWithContentsOfURL_ContentType_OpenInPlace_Coordinated_Visibility_XHandle, fileUrl__handle__, contentType__handle__, openInPlace ? (byte) 1 : (byte) 0, coordinated ? (byte) 1 : (byte) 0, (IntPtr) (long) visibility), "initWithContentsOfURL:contentType:openInPlace:coordinated:visibility:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (fileUrl);
			GC.KeepAlive (contentType);
		}
		[Export ("canLoadObjectOfClass:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool CanLoadObject (Class aClass)
		{
			var aClass__handle__ = aClass!.GetNonNullHandle (nameof (aClass));
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (this.Handle, selCanLoadObjectOfClass_XHandle, aClass.Handle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle (&__objc_super__, selCanLoadObjectOfClass_XHandle, aClass.Handle);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (aClass);
			return ret != 0;
		}
		/// <param name="type">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public bool CanLoadObject (global::System.Type type)
		{
			return CanLoadObject (new Class (type));
		}
		/// <param name="zone">Developers should pass <see langword="null" />.  Memory zones are no longer used.</param><summary>Performs a copy of the underlying Objective-C object.</summary><returns>The newly-allocated object.</returns><remarks><para>This method performs a "shallow copy" of <see langword="this" />. If this object contains references to external objects, the new object will contain references to the same object.</para></remarks>
		[Export ("copyWithZone:")]
		[return: ReleaseAttribute ()]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject Copy (NSZone? zone)
		{
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
		[Export ("registeredTypeIdentifiersWithFileOptions:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string[] GetRegisteredTypeIdentifiers (NSItemProviderFileOptions fileOptions)
		{
			string[] ret;
			if (IsDirectBinding) {
				ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_IntPtr (this.Handle, selRegisteredTypeIdentifiersWithFileOptions_XHandle, (IntPtr) (long) fileOptions), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_IntPtr (&__objc_super__, selRegisteredTypeIdentifiersWithFileOptions_XHandle, (IntPtr) (long) fileOptions), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("hasRepresentationConformingToTypeIdentifier:fileOptions:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool HasConformingRepresentation (string typeIdentifier, NSItemProviderFileOptions fileOptions)
		{
			if (typeIdentifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (typeIdentifier));
			var nstypeIdentifier = CFString.CreateNative (typeIdentifier);
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_IntPtr (this.Handle, selHasRepresentationConformingToTypeIdentifier_FileOptions_XHandle, nstypeIdentifier, (IntPtr) (long) fileOptions);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle_IntPtr (&__objc_super__, selHasRepresentationConformingToTypeIdentifier_FileOptions_XHandle, nstypeIdentifier, (IntPtr) (long) fileOptions);
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nstypeIdentifier);
			return ret != 0;
		}
		[Export ("hasItemConformingToTypeIdentifier:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool HasItemConformingTo (string typeIdentifier)
		{
			if (typeIdentifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (typeIdentifier));
			var nstypeIdentifier = CFString.CreateNative (typeIdentifier);
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (this.Handle, selHasItemConformingToTypeIdentifier_XHandle, nstypeIdentifier);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle (&__objc_super__, selHasItemConformingToTypeIdentifier_XHandle, nstypeIdentifier);
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nstypeIdentifier);
			return ret != 0;
		}
		[Export ("loadDataRepresentationForTypeIdentifier:completionHandler:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual NSProgress LoadDataRepresentation (string typeIdentifier, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V16))]global::System.Action<NSData, NSError> completionHandler)
		{
			if (typeIdentifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (typeIdentifier));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			var nstypeIdentifier = CFString.CreateNative (typeIdentifier);
			using var block_completionHandler = Trampolines.SDActionArity2V16.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			NSProgress? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSProgress> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selLoadDataRepresentationForTypeIdentifier_CompletionHandler_XHandle, nstypeIdentifier, (IntPtr) block_ptr_completionHandler), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSProgress> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selLoadDataRepresentationForTypeIdentifier_CompletionHandler_XHandle, nstypeIdentifier, (IntPtr) block_ptr_completionHandler), false)!;
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nstypeIdentifier);
			return ret!;
		}
		/// <param name="typeIdentifier">To be added.</param>
		/// <summary>To be added.</summary>
		/// <returns>
		///           <para class="improve-task-t-return-type-description">A task that represents the asynchronous LoadDataRepresentation operation.  The value of the TResult parameter is of type System.Action&lt;Foundation.NSData,Foundation.NSError&gt;.</para>
		///         </returns>
		/// <remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<NSData> LoadDataRepresentationAsync (string typeIdentifier)
		{
			var tcs = new TaskCompletionSource<NSData> ();
			LoadDataRepresentation(typeIdentifier, (arg1_, arg2_) => {
				if (arg2_ is not null)
					tcs.SetException (new NSErrorException(arg2_));
				else
					tcs.SetResult (arg1_!);
			});
			return tcs.Task;
		}
		/// <param name="typeIdentifier">To be added.</param>
		/// <param name="result">To be added.</param>
		/// <summary>To be added.</summary>
		/// <returns>To be added.</returns>
		/// <remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<NSData> LoadDataRepresentationAsync (string typeIdentifier, out NSProgress result)
		{
			var tcs = new TaskCompletionSource<NSData> ();
			result = LoadDataRepresentation(typeIdentifier, (arg1_, arg2_) => {
				if (arg2_ is not null)
					tcs.SetException (new NSErrorException(arg2_));
				else
					tcs.SetResult (arg1_!);
			})!;
			return tcs.Task;
		}
		[Export ("loadDataRepresentationForContentType:completionHandler:")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual NSProgress LoadDataRepresentation (global::UniformTypeIdentifiers.UTType contentType, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDItemProviderDataCompletionHandler))]ItemProviderDataCompletionHandler completionHandler)
		{
			var contentType__handle__ = contentType!.GetNonNullHandle (nameof (contentType));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDItemProviderDataCompletionHandler.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			NSProgress? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSProgress> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selLoadDataRepresentationForContentType_CompletionHandler_XHandle, contentType__handle__, (IntPtr) block_ptr_completionHandler), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSProgress> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selLoadDataRepresentationForContentType_CompletionHandler_XHandle, contentType__handle__, (IntPtr) block_ptr_completionHandler), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (contentType);
			return ret!;
		}
		[Export ("loadFileRepresentationForTypeIdentifier:completionHandler:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual NSProgress LoadFileRepresentation (string typeIdentifier, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V23))]global::System.Action<NSUrl, NSError> completionHandler)
		{
			if (typeIdentifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (typeIdentifier));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			var nstypeIdentifier = CFString.CreateNative (typeIdentifier);
			using var block_completionHandler = Trampolines.SDActionArity2V23.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			NSProgress? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSProgress> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selLoadFileRepresentationForTypeIdentifier_CompletionHandler_XHandle, nstypeIdentifier, (IntPtr) block_ptr_completionHandler), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSProgress> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selLoadFileRepresentationForTypeIdentifier_CompletionHandler_XHandle, nstypeIdentifier, (IntPtr) block_ptr_completionHandler), false)!;
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nstypeIdentifier);
			return ret!;
		}
		/// <param name="typeIdentifier">To be added.</param>
		/// <summary>To be added.</summary>
		/// <returns>
		///           <para class="improve-task-t-return-type-description">A task that represents the asynchronous LoadFileRepresentation operation.  The value of the TResult parameter is of type System.Action&lt;Foundation.NSUrl,Foundation.NSError&gt;.</para>
		///         </returns>
		/// <remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<NSUrl> LoadFileRepresentationAsync (string typeIdentifier)
		{
			var tcs = new TaskCompletionSource<NSUrl> ();
			LoadFileRepresentation(typeIdentifier, (arg1_, arg2_) => {
				if (arg2_ is not null)
					tcs.SetException (new NSErrorException(arg2_));
				else
					tcs.SetResult (arg1_!);
			});
			return tcs.Task;
		}
		/// <param name="typeIdentifier">To be added.</param>
		/// <param name="result">To be added.</param>
		/// <summary>To be added.</summary>
		/// <returns>To be added.</returns>
		/// <remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<NSUrl> LoadFileRepresentationAsync (string typeIdentifier, out NSProgress result)
		{
			var tcs = new TaskCompletionSource<NSUrl> ();
			result = LoadFileRepresentation(typeIdentifier, (arg1_, arg2_) => {
				if (arg2_ is not null)
					tcs.SetException (new NSErrorException(arg2_));
				else
					tcs.SetResult (arg1_!);
			})!;
			return tcs.Task;
		}
		[Export ("loadFileRepresentationForContentType:openInPlace:completionHandler:")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual NSProgress LoadFileRepresentation (global::UniformTypeIdentifiers.UTType contentType, bool openInPlace, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDLoadFileRepresentationHandler))]LoadFileRepresentationHandler completionHandler)
		{
			var contentType__handle__ = contentType!.GetNonNullHandle (nameof (contentType));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDLoadFileRepresentationHandler.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			NSProgress? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSProgress> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_bool_NativeHandle (this.Handle, selLoadFileRepresentationForContentType_OpenInPlace_CompletionHandler_XHandle, contentType__handle__, openInPlace ? (byte) 1 : (byte) 0, (IntPtr) block_ptr_completionHandler), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSProgress> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_bool_NativeHandle (&__objc_super__, selLoadFileRepresentationForContentType_OpenInPlace_CompletionHandler_XHandle, contentType__handle__, openInPlace ? (byte) 1 : (byte) 0, (IntPtr) block_ptr_completionHandler), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (contentType);
			return ret!;
		}
		[Export ("loadInPlaceFileRepresentationForTypeIdentifier:completionHandler:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual NSProgress LoadInPlaceFileRepresentation (string typeIdentifier, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDLoadInPlaceFileRepresentationHandler))]LoadInPlaceFileRepresentationHandler completionHandler)
		{
			if (typeIdentifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (typeIdentifier));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			var nstypeIdentifier = CFString.CreateNative (typeIdentifier);
			using var block_completionHandler = Trampolines.SDLoadInPlaceFileRepresentationHandler.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			NSProgress? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSProgress> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selLoadInPlaceFileRepresentationForTypeIdentifier_CompletionHandler_XHandle, nstypeIdentifier, (IntPtr) block_ptr_completionHandler), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSProgress> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selLoadInPlaceFileRepresentationForTypeIdentifier_CompletionHandler_XHandle, nstypeIdentifier, (IntPtr) block_ptr_completionHandler), false)!;
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nstypeIdentifier);
			return ret!;
		}
		/// <param name="typeIdentifier">To be added.</param>
		/// <summary>To be added.</summary>
		/// <returns>
		///           <para>A task that represents the asynchronous LoadInPlaceFileRepresentation operation.   The value of the TResult parameter is of type Foundation.LoadInPlaceResult.</para>
		///         </returns>
		/// <remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<LoadInPlaceResult> LoadInPlaceFileRepresentationAsync (string typeIdentifier)
		{
			var tcs = new TaskCompletionSource<LoadInPlaceResult> ();
			LoadInPlaceFileRepresentation(typeIdentifier, (fileUrl_, isInPlace_, error_) => {
				if (error_ is not null)
					tcs.SetException (new NSErrorException(error_));
				else
					tcs.SetResult (new LoadInPlaceResult (fileUrl_!, isInPlace_!));
			});
			return tcs.Task;
		}
		/// <param name="typeIdentifier">To be added.</param>
		/// <param name="result">To be added.</param>
		/// <summary>To be added.</summary>
		/// <returns>To be added.</returns>
		/// <remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<LoadInPlaceResult> LoadInPlaceFileRepresentationAsync (string typeIdentifier, out NSProgress result)
		{
			var tcs = new TaskCompletionSource<LoadInPlaceResult> ();
			result = LoadInPlaceFileRepresentation(typeIdentifier, (fileUrl_, isInPlace_, error_) => {
				if (error_ is not null)
					tcs.SetException (new NSErrorException(error_));
				else
					tcs.SetResult (new LoadInPlaceResult (fileUrl_!, isInPlace_!));
			})!;
			return tcs.Task;
		}
		[Export ("loadItemForTypeIdentifier:options:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void LoadItem (string typeIdentifier, NSDictionary? options, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V78))]global::System.Action<NSObject, NSError>? completionHandler)
		{
			if (typeIdentifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (typeIdentifier));
			var options__handle__ = options.GetHandle ();
			var nstypeIdentifier = CFString.CreateNative (typeIdentifier);
			using var block_completionHandler = Trampolines.SDActionArity2V78.CreateNullableBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = null;
			if (completionHandler is not null)
				block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, selLoadItemForTypeIdentifier_Options_CompletionHandler_XHandle, nstypeIdentifier, options__handle__, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, selLoadItemForTypeIdentifier_Options_CompletionHandler_XHandle, nstypeIdentifier, options__handle__, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (options);
			CFString.ReleaseNative (nstypeIdentifier);
		}
		/// <param name="typeIdentifier">To be added.</param>
		/// <param name="options">To be added.</param>
		/// <summary>To be added.</summary>
		/// <returns>
		///           <para class="improve-task-t-return-type-description">A task that represents the asynchronous LoadItem operation.  The value of the TResult parameter is of type System.Action&lt;Foundation.NSObject,Foundation.NSError&gt;.</para>
		///         </returns>
		/// <remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<NSObject> LoadItemAsync (string typeIdentifier, NSDictionary? options)
		{
			var tcs = new TaskCompletionSource<NSObject> ();
			LoadItem(typeIdentifier, options, (arg1_, arg2_) => {
				if (arg2_ is not null)
					tcs.SetException (new NSErrorException(arg2_));
				else
					tcs.SetResult (arg1_!);
			});
			return tcs.Task;
		}
		[Export ("loadObjectOfClass:completionHandler:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual NSProgress LoadObject (Class aClass, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V79))]global::System.Action<INSItemProviderReading, NSError> completionHandler)
		{
			var aClass__handle__ = aClass!.GetNonNullHandle (nameof (aClass));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity2V79.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			NSProgress? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSProgress> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selLoadObjectOfClass_CompletionHandler_XHandle, aClass.Handle, (IntPtr) block_ptr_completionHandler), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSProgress> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selLoadObjectOfClass_CompletionHandler_XHandle, aClass.Handle, (IntPtr) block_ptr_completionHandler), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (aClass);
			return ret!;
		}
		/// <param name="aClass">To be added.</param>
		/// <summary>To be added.</summary>
		/// <returns>
		///           <para class="improve-task-t-return-type-description">A task that represents the asynchronous LoadObject operation.  The value of the TResult parameter is of type System.Action&lt;Foundation.INSItemProviderReading,Foundation.NSError&gt;.</para>
		///         </returns>
		/// <remarks>
		///           <para copied="true">The LoadObjectAsync method is suitable to be used with C# async by returning control to the caller with a Task representing the operation.</para>
		///           <para copied="true">To be added.</para>
		///         </remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<INSItemProviderReading> LoadObjectAsync (Class aClass)
		{
			var tcs = new TaskCompletionSource<INSItemProviderReading> ();
			LoadObject(aClass, (arg1_, arg2_) => {
				if (arg2_ is not null)
					tcs.SetException (new NSErrorException(arg2_));
				else
					tcs.SetResult (arg1_!);
			});
			return tcs.Task;
		}
		/// <param name="aClass">To be added.</param>
		/// <param name="result">To be added.</param>
		/// <summary>To be added.</summary>
		/// <returns>To be added.</returns>
		/// <remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<INSItemProviderReading> LoadObjectAsync (Class aClass, out NSProgress result)
		{
			var tcs = new TaskCompletionSource<INSItemProviderReading> ();
			result = LoadObject(aClass, (arg1_, arg2_) => {
				if (arg2_ is not null)
					tcs.SetException (new NSErrorException(arg2_));
				else
					tcs.SetResult (arg1_!);
			})!;
			return tcs.Task;
		}
		[Export ("loadPreviewImageWithOptions:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void LoadPreviewImage (NSDictionary options, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V78))]global::System.Action<NSObject, NSError> completionHandler)
		{
			var options__handle__ = options!.GetNonNullHandle (nameof (options));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity2V78.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selLoadPreviewImageWithOptions_CompletionHandler_XHandle, options__handle__, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selLoadPreviewImageWithOptions_CompletionHandler_XHandle, options__handle__, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (options);
		}
		/// <param name="options">To be added.</param>
		/// <summary>To be added.</summary>
		/// <returns>
		///           <para class="improve-task-t-return-type-description">A task that represents the asynchronous LoadPreviewImage operation.  The value of the TResult parameter is of type System.Action&lt;Foundation.NSObject,Foundation.NSError&gt;.</para>
		///         </returns>
		/// <remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<NSObject> LoadPreviewImageAsync (NSDictionary options)
		{
			var tcs = new TaskCompletionSource<NSObject> ();
			LoadPreviewImage(options, (arg1_, arg2_) => {
				if (arg2_ is not null)
					tcs.SetException (new NSErrorException(arg2_));
				else
					tcs.SetResult (arg1_!);
			});
			return tcs.Task;
		}
		[Export ("registerCKShareWithContainer:allowedSharingOptions:preparationHandler:")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void RegisterCKShare (global::CloudKit.CKContainer container, global::CloudKit.CKAllowedSharingOptions allowedOptions, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action preparationHandler)
		{
			var container__handle__ = container!.GetNonNullHandle (nameof (container));
			var allowedOptions__handle__ = allowedOptions!.GetNonNullHandle (nameof (allowedOptions));
			if (preparationHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (preparationHandler));
			using var block_preparationHandler = Trampolines.SDAction.CreateBlock (preparationHandler);
			BlockLiteral *block_ptr_preparationHandler = &block_preparationHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, selRegisterCKShareWithContainer_AllowedSharingOptions_PreparationHandler_XHandle, container__handle__, allowedOptions__handle__, (IntPtr) block_ptr_preparationHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, selRegisterCKShareWithContainer_AllowedSharingOptions_PreparationHandler_XHandle, container__handle__, allowedOptions__handle__, (IntPtr) block_ptr_preparationHandler);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (container);
			GC.KeepAlive (allowedOptions);
		}
		[Export ("registerCKShare:container:allowedSharingOptions:")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RegisterCKShare (global::CloudKit.CKShare share, global::CloudKit.CKContainer container, global::CloudKit.CKAllowedSharingOptions allowedOptions)
		{
			var share__handle__ = share!.GetNonNullHandle (nameof (share));
			var container__handle__ = container!.GetNonNullHandle (nameof (container));
			var allowedOptions__handle__ = allowedOptions!.GetNonNullHandle (nameof (allowedOptions));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, selRegisterCKShare_Container_AllowedSharingOptions_XHandle, share__handle__, container__handle__, allowedOptions__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, selRegisterCKShare_Container_AllowedSharingOptions_XHandle, share__handle__, container__handle__, allowedOptions__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (share);
			GC.KeepAlive (container);
			GC.KeepAlive (allowedOptions);
		}
		/// <param name="preparationHandler">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("registerCloudKitShareWithPreparationHandler:")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void RegisterCloudKitShare ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDCloudKitRegistrationPreparationAction))]CloudKitRegistrationPreparationAction preparationHandler)
		{
			if (preparationHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (preparationHandler));
			using var block_preparationHandler = Trampolines.SDCloudKitRegistrationPreparationAction.CreateBlock (preparationHandler);
			BlockLiteral *block_ptr_preparationHandler = &block_preparationHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selRegisterCloudKitShareWithPreparationHandler_XHandle, (IntPtr) block_ptr_preparationHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selRegisterCloudKitShareWithPreparationHandler_XHandle, (IntPtr) block_ptr_preparationHandler);
					GC.KeepAlive (this);
				}
			}
		}
		/// <param name="share">To be added.</param><param name="container">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("registerCloudKitShare:container:")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RegisterCloudKitShare (global::CloudKit.CKShare share, global::CloudKit.CKContainer container)
		{
			var share__handle__ = share!.GetNonNullHandle (nameof (share));
			var container__handle__ = container!.GetNonNullHandle (nameof (container));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selRegisterCloudKitShare_Container_XHandle, share__handle__, container__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selRegisterCloudKitShare_Container_XHandle, share__handle__, container__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (share);
			GC.KeepAlive (container);
		}
		[Export ("registerDataRepresentationForTypeIdentifier:visibility:loadHandler:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void RegisterDataRepresentation (string typeIdentifier, NSItemProviderRepresentationVisibility visibility, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDRegisterDataRepresentationLoadHandler))]RegisterDataRepresentationLoadHandler loadHandler)
		{
			if (typeIdentifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (typeIdentifier));
			if (loadHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (loadHandler));
			var nstypeIdentifier = CFString.CreateNative (typeIdentifier);
			using var block_loadHandler = Trampolines.SDRegisterDataRepresentationLoadHandler.CreateBlock (loadHandler);
			BlockLiteral *block_ptr_loadHandler = &block_loadHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_IntPtr_NativeHandle (this.Handle, selRegisterDataRepresentationForTypeIdentifier_Visibility_LoadHandler_XHandle, nstypeIdentifier, (IntPtr) (long) visibility, (IntPtr) block_ptr_loadHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_IntPtr_NativeHandle (&__objc_super__, selRegisterDataRepresentationForTypeIdentifier_Visibility_LoadHandler_XHandle, nstypeIdentifier, (IntPtr) (long) visibility, (IntPtr) block_ptr_loadHandler);
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nstypeIdentifier);
		}
		[Export ("registerDataRepresentationForContentType:visibility:loadHandler:")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void RegisterDataRepresentation (global::UniformTypeIdentifiers.UTType contentType, NSItemProviderRepresentationVisibility visibility, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDNSItemProviderUTTypeLoadDelegate))]NSItemProviderUTTypeLoadDelegate loadHandler)
		{
			var contentType__handle__ = contentType!.GetNonNullHandle (nameof (contentType));
			if (loadHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (loadHandler));
			using var block_loadHandler = Trampolines.SDNSItemProviderUTTypeLoadDelegate.CreateBlock (loadHandler);
			BlockLiteral *block_ptr_loadHandler = &block_loadHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_IntPtr_NativeHandle (this.Handle, selRegisterDataRepresentationForContentType_Visibility_LoadHandler_XHandle, contentType__handle__, (IntPtr) (long) visibility, (IntPtr) block_ptr_loadHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_IntPtr_NativeHandle (&__objc_super__, selRegisterDataRepresentationForContentType_Visibility_LoadHandler_XHandle, contentType__handle__, (IntPtr) (long) visibility, (IntPtr) block_ptr_loadHandler);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (contentType);
		}
		[Export ("registerFileRepresentationForTypeIdentifier:fileOptions:visibility:loadHandler:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void RegisterFileRepresentation (string typeIdentifier, NSItemProviderFileOptions fileOptions, NSItemProviderRepresentationVisibility visibility, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDRegisterFileRepresentationLoadHandler))]RegisterFileRepresentationLoadHandler loadHandler)
		{
			if (typeIdentifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (typeIdentifier));
			if (loadHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (loadHandler));
			var nstypeIdentifier = CFString.CreateNative (typeIdentifier);
			using var block_loadHandler = Trampolines.SDRegisterFileRepresentationLoadHandler.CreateBlock (loadHandler);
			BlockLiteral *block_ptr_loadHandler = &block_loadHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_IntPtr_IntPtr_NativeHandle (this.Handle, selRegisterFileRepresentationForTypeIdentifier_FileOptions_Visibility_LoadHandler_XHandle, nstypeIdentifier, (IntPtr) (long) fileOptions, (IntPtr) (long) visibility, (IntPtr) block_ptr_loadHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_IntPtr_IntPtr_NativeHandle (&__objc_super__, selRegisterFileRepresentationForTypeIdentifier_FileOptions_Visibility_LoadHandler_XHandle, nstypeIdentifier, (IntPtr) (long) fileOptions, (IntPtr) (long) visibility, (IntPtr) block_ptr_loadHandler);
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nstypeIdentifier);
		}
		[Export ("registerFileRepresentationForContentType:visibility:openInPlace:loadHandler:")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void RegisterFileRepresentation (global::UniformTypeIdentifiers.UTType contentType, NSItemProviderRepresentationVisibility visibility, bool openInPlace, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDNSItemProviderUTTypeLoadDelegate))]NSItemProviderUTTypeLoadDelegate loadHandler)
		{
			var contentType__handle__ = contentType!.GetNonNullHandle (nameof (contentType));
			if (loadHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (loadHandler));
			using var block_loadHandler = Trampolines.SDNSItemProviderUTTypeLoadDelegate.CreateBlock (loadHandler);
			BlockLiteral *block_ptr_loadHandler = &block_loadHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_IntPtr_bool_NativeHandle (this.Handle, selRegisterFileRepresentationForContentType_Visibility_OpenInPlace_LoadHandler_XHandle, contentType__handle__, (IntPtr) (long) visibility, openInPlace ? (byte) 1 : (byte) 0, (IntPtr) block_ptr_loadHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_IntPtr_bool_NativeHandle (&__objc_super__, selRegisterFileRepresentationForContentType_Visibility_OpenInPlace_LoadHandler_XHandle, contentType__handle__, (IntPtr) (long) visibility, openInPlace ? (byte) 1 : (byte) 0, (IntPtr) block_ptr_loadHandler);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (contentType);
		}
		[Export ("registerItemForTypeIdentifier:loadHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void RegisterItemForTypeIdentifier (string typeIdentifier, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDNSItemProviderLoadHandler))]NSItemProviderLoadHandler loadHandler)
		{
			if (typeIdentifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (typeIdentifier));
			if (loadHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (loadHandler));
			var nstypeIdentifier = CFString.CreateNative (typeIdentifier);
			using var block_loadHandler = Trampolines.SDNSItemProviderLoadHandler.CreateBlock (loadHandler);
			BlockLiteral *block_ptr_loadHandler = &block_loadHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selRegisterItemForTypeIdentifier_LoadHandler_XHandle, nstypeIdentifier, (IntPtr) block_ptr_loadHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selRegisterItemForTypeIdentifier_LoadHandler_XHandle, nstypeIdentifier, (IntPtr) block_ptr_loadHandler);
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nstypeIdentifier);
		}
		[Export ("registerObject:visibility:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RegisterObject (INSItemProviderWriting @object, NSItemProviderRepresentationVisibility visibility)
		{
			var @object__handle__ = @object!.GetNonNullHandle (nameof (@object));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_IntPtr (this.Handle, selRegisterObject_Visibility_XHandle, @object__handle__, (IntPtr) (long) visibility);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_IntPtr (&__objc_super__, selRegisterObject_Visibility_XHandle, @object__handle__, (IntPtr) (long) visibility);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (@object);
		}
		[Export ("registerObjectOfClass:visibility:loadHandler:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void RegisterObject (Class aClass, NSItemProviderRepresentationVisibility visibility, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDRegisterObjectRepresentationLoadHandler))]RegisterObjectRepresentationLoadHandler loadHandler)
		{
			var aClass__handle__ = aClass!.GetNonNullHandle (nameof (aClass));
			if (loadHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (loadHandler));
			using var block_loadHandler = Trampolines.SDRegisterObjectRepresentationLoadHandler.CreateBlock (loadHandler);
			BlockLiteral *block_ptr_loadHandler = &block_loadHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_IntPtr_NativeHandle (this.Handle, selRegisterObjectOfClass_Visibility_LoadHandler_XHandle, aClass.Handle, (IntPtr) (long) visibility, (IntPtr) block_ptr_loadHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_IntPtr_NativeHandle (&__objc_super__, selRegisterObjectOfClass_Visibility_LoadHandler_XHandle, aClass.Handle, (IntPtr) (long) visibility, (IntPtr) block_ptr_loadHandler);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (aClass);
		}
		/// <param name="type">To be added.</param><param name="visibility">To be added.</param><param name="loadHandler">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void RegisterObject (global::System.Type type, NSItemProviderRepresentationVisibility visibility, RegisterObjectRepresentationLoadHandler loadHandler)
		{
			RegisterObject (new Class (type), visibility, loadHandler);
		}
		[Export ("registeredContentTypesConformingToContentType:")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::UniformTypeIdentifiers.UTType[] RegisteredContentTypesConforming (global::UniformTypeIdentifiers.UTType contentType)
		{
			var contentType__handle__ = contentType!.GetNonNullHandle (nameof (contentType));
			global::UniformTypeIdentifiers.UTType[]? ret;
			if (IsDirectBinding) {
				ret = CFArray.ArrayFromHandle<global::UniformTypeIdentifiers.UTType>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selRegisteredContentTypesConformingToContentType_XHandle, contentType__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFArray.ArrayFromHandle<global::UniformTypeIdentifiers.UTType>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selRegisteredContentTypesConformingToContentType_XHandle, contentType__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (contentType);
			return ret!;
		}
		/// <param name="handler">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("setPreviewImageHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void SetPreviewImageHandler ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDNSItemProviderLoadHandler))]NSItemProviderLoadHandler handler)
		{
			if (handler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (handler));
			using var block_handler = Trampolines.SDNSItemProviderLoadHandler.CreateBlock (handler);
			BlockLiteral *block_ptr_handler = &block_handler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetPreviewImageHandler_XHandle, (IntPtr) block_ptr_handler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetPreviewImageHandler_XHandle, (IntPtr) block_ptr_handler);
					GC.KeepAlive (this);
				}
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public virtual CGRect ContainerFrame {
			[Export ("containerFrame")]
			get {
				CGRect ret;
				if (IsDirectBinding) {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend (this.Handle, selContainerFrameXHandle);
					} else {
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret (this.Handle, selContainerFrameXHandle);
					}
				} else {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper (&__objc_super__, selContainerFrameXHandle);
							GC.KeepAlive (this);
						}
					} else {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper_stret (&__objc_super__, selContainerFrameXHandle);
							GC.KeepAlive (this);
						}
					}
				}
				return ret!;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		public virtual CGSize PreferredPresentationSize {
			[Export ("preferredPresentationSize")]
			get {
				CGSize ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.CGSize_objc_msgSend (this.Handle, selPreferredPresentationSizeXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGSize_objc_msgSendSuper (&__objc_super__, selPreferredPresentationSizeXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		public virtual global::UniformTypeIdentifiers.UTType[] RegisteredContentTypes {
			[Export ("registeredContentTypes", ArgumentSemantic.Copy)]
			get {
				global::UniformTypeIdentifiers.UTType[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<global::UniformTypeIdentifiers.UTType>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selRegisteredContentTypesXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<global::UniformTypeIdentifiers.UTType>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selRegisteredContentTypesXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		public virtual global::UniformTypeIdentifiers.UTType[] RegisteredContentTypesForOpenInPlace {
			[Export ("registeredContentTypesForOpenInPlace", ArgumentSemantic.Copy)]
			get {
				global::UniformTypeIdentifiers.UTType[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<global::UniformTypeIdentifiers.UTType>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selRegisteredContentTypesForOpenInPlaceXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<global::UniformTypeIdentifiers.UTType>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selRegisteredContentTypesForOpenInPlaceXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string[] RegisteredTypeIdentifiers {
			[Export ("registeredTypeIdentifiers", ArgumentSemantic.Copy)]
			get {
				string[] ret;
				if (IsDirectBinding) {
					ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selRegisteredTypeIdentifiersXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selRegisteredTypeIdentifiersXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public virtual CGRect SourceFrame {
			[Export ("sourceFrame")]
			get {
				CGRect ret;
				if (IsDirectBinding) {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend (this.Handle, selSourceFrameXHandle);
					} else {
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret (this.Handle, selSourceFrameXHandle);
					}
				} else {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper (&__objc_super__, selSourceFrameXHandle);
							GC.KeepAlive (this);
						}
					} else {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper_stret (&__objc_super__, selSourceFrameXHandle);
							GC.KeepAlive (this);
						}
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		public virtual string? SuggestedName {
			[Export ("suggestedName")]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selSuggestedNameXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selSuggestedNameXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setSuggestedName:")]
			set {
				var nsvalue = CFString.CreateNative (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetSuggestedName_XHandle, nsvalue);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetSuggestedName_XHandle, nsvalue);
						GC.KeepAlive (this);
					}
				}
				CFString.ReleaseNative (nsvalue);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ErrorDomain;
		/// <summary>Represents the value associated with the constant NSItemProviderErrorDomain</summary><value></value><remarks>To be added.</remarks>
		[Field ("NSItemProviderErrorDomain",  "Foundation")]
		public static NSString ErrorDomain {
			get {
				if (_ErrorDomain is null)
					_ErrorDomain = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSItemProviderErrorDomain")!;
				return _ErrorDomain;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _PreferredImageSizeKey;
		/// <summary>Represents the value associated with the constant NSItemProviderPreferredImageSizeKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("NSItemProviderPreferredImageSizeKey",  "Foundation")]
		public static NSString PreferredImageSizeKey {
			get {
				if (_PreferredImageSizeKey is null)
					_PreferredImageSizeKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSItemProviderPreferredImageSizeKey")!;
				return _PreferredImageSizeKey;
			}
		}
	} /* class NSItemProvider */
	//
	// Async result classes
	//
	/// <summary>This class holds the return values for an asynchronous operation.</summary>
	public partial class LoadInPlaceResult {
		/// <summary>The result value from the asynchronous operation.</summary>
		public NSUrl FileUrl { get; set; }
		/// <summary>The result value from the asynchronous operation.</summary>
		public bool IsInPlace { get; set; }
		partial void Initialize ();
		/// <summary>Creates a new instance of this class.</summary>
		/// <param name="fileUrl">Result value from an asynchronous operation.</param>
		/// <param name="isInPlace">Result value from an asynchronous operation.</param>
		public LoadInPlaceResult (NSUrl fileUrl, bool isInPlace) {
			this.FileUrl = fileUrl;
			this.IsInPlace = isInPlace;
			Initialize ();
		}
	}
}
