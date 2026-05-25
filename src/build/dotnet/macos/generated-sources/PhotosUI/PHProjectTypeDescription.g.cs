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
	[Register("PHProjectTypeDescription", true)]
	[UnsupportedOSPlatform ("ios")]
	[UnsupportedOSPlatform ("tvos")]
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	public unsafe partial class PHProjectTypeDescription : NSObject, INSCoding, INSSecureCoding {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCanProvideSubtypesX = "canProvideSubtypes";
		static readonly NativeHandle selCanProvideSubtypesXHandle = Selector.GetHandle ("canProvideSubtypes");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selEncodeWithCoder_X = "encodeWithCoder:";
		static readonly NativeHandle selEncodeWithCoder_XHandle = Selector.GetHandle ("encodeWithCoder:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selImageX = "image";
		static readonly NativeHandle selImageXHandle = Selector.GetHandle ("image");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithCoder_X = "initWithCoder:";
		static readonly NativeHandle selInitWithCoder_XHandle = Selector.GetHandle ("initWithCoder:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithProjectType_Title_AttributedDescription_Image_CanProvideSubtypes_X = "initWithProjectType:title:attributedDescription:image:canProvideSubtypes:";
		static readonly NativeHandle selInitWithProjectType_Title_AttributedDescription_Image_CanProvideSubtypes_XHandle = Selector.GetHandle ("initWithProjectType:title:attributedDescription:image:canProvideSubtypes:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithProjectType_Title_AttributedDescription_Image_SubtypeDescriptions_X = "initWithProjectType:title:attributedDescription:image:subtypeDescriptions:";
		static readonly NativeHandle selInitWithProjectType_Title_AttributedDescription_Image_SubtypeDescriptions_XHandle = Selector.GetHandle ("initWithProjectType:title:attributedDescription:image:subtypeDescriptions:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithProjectType_Title_Description_Image_X = "initWithProjectType:title:description:image:";
		static readonly NativeHandle selInitWithProjectType_Title_Description_Image_XHandle = Selector.GetHandle ("initWithProjectType:title:description:image:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithProjectType_Title_Description_Image_CanProvideSubtypes_X = "initWithProjectType:title:description:image:canProvideSubtypes:";
		static readonly NativeHandle selInitWithProjectType_Title_Description_Image_CanProvideSubtypes_XHandle = Selector.GetHandle ("initWithProjectType:title:description:image:canProvideSubtypes:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithProjectType_Title_Description_Image_SubtypeDescriptions_X = "initWithProjectType:title:description:image:subtypeDescriptions:";
		static readonly NativeHandle selInitWithProjectType_Title_Description_Image_SubtypeDescriptions_XHandle = Selector.GetHandle ("initWithProjectType:title:description:image:subtypeDescriptions:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLocalizedAttributedDescriptionX = "localizedAttributedDescription";
		static readonly NativeHandle selLocalizedAttributedDescriptionXHandle = Selector.GetHandle ("localizedAttributedDescription");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLocalizedDescriptionX = "localizedDescription";
		static readonly NativeHandle selLocalizedDescriptionXHandle = Selector.GetHandle ("localizedDescription");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLocalizedTitleX = "localizedTitle";
		static readonly NativeHandle selLocalizedTitleXHandle = Selector.GetHandle ("localizedTitle");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selProjectTypeX = "projectType";
		static readonly NativeHandle selProjectTypeXHandle = Selector.GetHandle ("projectType");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSubtypeDescriptionsX = "subtypeDescriptions";
		static readonly NativeHandle selSubtypeDescriptionsXHandle = Selector.GetHandle ("subtypeDescriptions");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("PHProjectTypeDescription");
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
		public PHProjectTypeDescription (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.InitWithCoder, coder.Handle), "initWithCoder:");
			} else {
				unsafe {
				var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
				InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (&__objc_super__, Selector.InitWithCoder, coder.Handle), "initWithCoder:");
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
		protected PHProjectTypeDescription (NSObjectFlag t) : base (t)
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
		protected internal PHProjectTypeDescription (NativeHandle handle) : base (handle)
		{
		}

		[Export ("initWithProjectType:title:description:image:subtypeDescriptions:")]
		[DesignatedInitializer]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public PHProjectTypeDescription (NSString projectType, string localizedTitle, string? localizedDescription, global::AppKit.NSImage? image, PHProjectTypeDescription[] subtypeDescriptions)
			: base (NSObjectFlag.Empty)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var projectType__handle__ = projectType!.GetNonNullHandle (nameof (projectType));
			if (localizedTitle is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (localizedTitle));
			var image__handle__ = image.GetHandle ();
			if (subtypeDescriptions is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (subtypeDescriptions));
			var nslocalizedTitle = CFString.CreateNative (localizedTitle);
			var nslocalizedDescription = CFString.CreateNative (localizedDescription);
			using var nsa_subtypeDescriptions = NSArray.FromNSObjects (subtypeDescriptions);
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle (this.Handle, selInitWithProjectType_Title_Description_Image_SubtypeDescriptions_XHandle, projectType__handle__, nslocalizedTitle, nslocalizedDescription, image__handle__, nsa_subtypeDescriptions.Handle), "initWithProjectType:title:description:image:subtypeDescriptions:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, selInitWithProjectType_Title_Description_Image_SubtypeDescriptions_XHandle, projectType__handle__, nslocalizedTitle, nslocalizedDescription, image__handle__, nsa_subtypeDescriptions.Handle), "initWithProjectType:title:description:image:subtypeDescriptions:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (projectType);
			GC.KeepAlive (image);
			CFString.ReleaseNative (nslocalizedTitle);
			CFString.ReleaseNative (nslocalizedDescription);
		}
		[Export ("initWithProjectType:title:description:image:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public PHProjectTypeDescription (NSString projectType, string localizedTitle, string? localizedDescription, global::AppKit.NSImage? image)
			: base (NSObjectFlag.Empty)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var projectType__handle__ = projectType!.GetNonNullHandle (nameof (projectType));
			if (localizedTitle is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (localizedTitle));
			var image__handle__ = image.GetHandle ();
			var nslocalizedTitle = CFString.CreateNative (localizedTitle);
			var nslocalizedDescription = CFString.CreateNative (localizedDescription);
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (this.Handle, selInitWithProjectType_Title_Description_Image_XHandle, projectType__handle__, nslocalizedTitle, nslocalizedDescription, image__handle__), "initWithProjectType:title:description:image:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, selInitWithProjectType_Title_Description_Image_XHandle, projectType__handle__, nslocalizedTitle, nslocalizedDescription, image__handle__), "initWithProjectType:title:description:image:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (projectType);
			GC.KeepAlive (image);
			CFString.ReleaseNative (nslocalizedTitle);
			CFString.ReleaseNative (nslocalizedDescription);
		}
		[Export ("initWithProjectType:title:attributedDescription:image:subtypeDescriptions:")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		[DesignatedInitializer]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public PHProjectTypeDescription (NSString projectType, string localizedTitle, NSAttributedString? localizedAttributedDescription, global::AppKit.NSImage? image, PHProjectTypeDescription[] subtypeDescriptions)
			: base (NSObjectFlag.Empty)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var projectType__handle__ = projectType!.GetNonNullHandle (nameof (projectType));
			if (localizedTitle is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (localizedTitle));
			var localizedAttributedDescription__handle__ = localizedAttributedDescription.GetHandle ();
			var image__handle__ = image.GetHandle ();
			if (subtypeDescriptions is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (subtypeDescriptions));
			var nslocalizedTitle = CFString.CreateNative (localizedTitle);
			using var nsa_subtypeDescriptions = NSArray.FromNSObjects (subtypeDescriptions);
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle (this.Handle, selInitWithProjectType_Title_AttributedDescription_Image_SubtypeDescriptions_XHandle, projectType__handle__, nslocalizedTitle, localizedAttributedDescription__handle__, image__handle__, nsa_subtypeDescriptions.Handle), "initWithProjectType:title:attributedDescription:image:subtypeDescriptions:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, selInitWithProjectType_Title_AttributedDescription_Image_SubtypeDescriptions_XHandle, projectType__handle__, nslocalizedTitle, localizedAttributedDescription__handle__, image__handle__, nsa_subtypeDescriptions.Handle), "initWithProjectType:title:attributedDescription:image:subtypeDescriptions:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (projectType);
			GC.KeepAlive (localizedAttributedDescription);
			GC.KeepAlive (image);
			CFString.ReleaseNative (nslocalizedTitle);
		}
		[Export ("initWithProjectType:title:attributedDescription:image:canProvideSubtypes:")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		[DesignatedInitializer]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public PHProjectTypeDescription (NSString projectType, string localizedTitle, NSAttributedString? localizedAttributedDescription, global::AppKit.NSImage? image, bool canProvideSubtypes)
			: base (NSObjectFlag.Empty)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var projectType__handle__ = projectType!.GetNonNullHandle (nameof (projectType));
			if (localizedTitle is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (localizedTitle));
			var localizedAttributedDescription__handle__ = localizedAttributedDescription.GetHandle ();
			var image__handle__ = image.GetHandle ();
			var nslocalizedTitle = CFString.CreateNative (localizedTitle);
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle_bool (this.Handle, selInitWithProjectType_Title_AttributedDescription_Image_CanProvideSubtypes_XHandle, projectType__handle__, nslocalizedTitle, localizedAttributedDescription__handle__, image__handle__, canProvideSubtypes ? (byte) 1 : (byte) 0), "initWithProjectType:title:attributedDescription:image:canProvideSubtypes:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle_NativeHandle_bool (&__objc_super__, selInitWithProjectType_Title_AttributedDescription_Image_CanProvideSubtypes_XHandle, projectType__handle__, nslocalizedTitle, localizedAttributedDescription__handle__, image__handle__, canProvideSubtypes ? (byte) 1 : (byte) 0), "initWithProjectType:title:attributedDescription:image:canProvideSubtypes:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (projectType);
			GC.KeepAlive (localizedAttributedDescription);
			GC.KeepAlive (image);
			CFString.ReleaseNative (nslocalizedTitle);
		}
		[Export ("initWithProjectType:title:description:image:canProvideSubtypes:")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		[DesignatedInitializer]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public PHProjectTypeDescription (NSString projectType, string localizedTitle, string? localizedDescription, global::AppKit.NSImage? image, bool canProvideSubtypes)
			: base (NSObjectFlag.Empty)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var projectType__handle__ = projectType!.GetNonNullHandle (nameof (projectType));
			if (localizedTitle is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (localizedTitle));
			var image__handle__ = image.GetHandle ();
			var nslocalizedTitle = CFString.CreateNative (localizedTitle);
			var nslocalizedDescription = CFString.CreateNative (localizedDescription);
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle_bool (this.Handle, selInitWithProjectType_Title_Description_Image_CanProvideSubtypes_XHandle, projectType__handle__, nslocalizedTitle, nslocalizedDescription, image__handle__, canProvideSubtypes ? (byte) 1 : (byte) 0), "initWithProjectType:title:description:image:canProvideSubtypes:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle_NativeHandle_bool (&__objc_super__, selInitWithProjectType_Title_Description_Image_CanProvideSubtypes_XHandle, projectType__handle__, nslocalizedTitle, nslocalizedDescription, image__handle__, canProvideSubtypes ? (byte) 1 : (byte) 0), "initWithProjectType:title:description:image:canProvideSubtypes:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (projectType);
			GC.KeepAlive (image);
			CFString.ReleaseNative (nslocalizedTitle);
			CFString.ReleaseNative (nslocalizedDescription);
		}
		/// <summary>Encodes the state of the object using the provided encoder.</summary><param name="encoder">The encoder object where the state of the object will be stored</param><remarks><para>This method is part of the <see cref="T:Foundation.INSCoding" /> protocol and is used by applications to preserve the state of the object into an archive.</para><para>Developers will typically create an <see cref="T:Foundation.NSKeyedArchiver" /> and then invoke the <see cref="M:Foundation.NSKeyedArchiver.ArchiveRootObjectToFile(Foundation.NSObject,System.String)" /> method which will call into this method.</para><para>If developers want to allow their object to be archived, they should override this method and store their state in using the provided <paramref name="encoder" /> parameter. In addition, developers should also implement a constructor that takes an NSCoder argument and is exported with <c>[Export ("initWithCoder:")]</c>.</para><example><code lang="csharp lang-csharp"><![CDATA[public void override EncodeTo (NSCoder coder) {
		/// coder.Encode (1, key: "version");
		/// coder.Encode (userName, key: "userName");
		/// coder.Encode (hostName, key: "hostName");]]></code></example></remarks>
		[Export ("encodeWithCoder:")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void EncodeTo (NSCoder encoder)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var encoder__handle__ = encoder!.GetNonNullHandle (nameof (encoder));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selEncodeWithCoder_XHandle, encoder__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selEncodeWithCoder_XHandle, encoder__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (encoder);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		public virtual bool CanProvideSubtypes {
			[Export ("canProvideSubtypes")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selCanProvideSubtypesXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selCanProvideSubtypesXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::AppKit.NSImage? Image {
			[Export ("image", ArgumentSemantic.Copy)]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				global::AppKit.NSImage? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::AppKit.NSImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selImageXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<global::AppKit.NSImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selImageXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		public virtual NSAttributedString? LocalizedAttributedDescription {
			[Export ("localizedAttributedDescription", ArgumentSemantic.Copy)]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSAttributedString? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSAttributedString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selLocalizedAttributedDescriptionXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSAttributedString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selLocalizedAttributedDescriptionXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string? LocalizedDescription {
			[Export ("localizedDescription")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selLocalizedDescriptionXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selLocalizedDescriptionXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string LocalizedTitle {
			[Export ("localizedTitle")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selLocalizedTitleXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selLocalizedTitleXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSString ProjectType {
			[Export ("projectType")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSString? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selProjectTypeXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selProjectTypeXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual PHProjectTypeDescription[] SubtypeDescriptions {
			[Export ("subtypeDescriptions", ArgumentSemantic.Copy)]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				PHProjectTypeDescription[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<PHProjectTypeDescription>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selSubtypeDescriptionsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<PHProjectTypeDescription>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selSubtypeDescriptionsXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
	} /* class PHProjectTypeDescription */
}
